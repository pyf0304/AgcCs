using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib.Templates;
using LaYumba.Functional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 Ai 版本的命令配置 TypeScript 文件
    /// 用于定义查询区和功能区的按钮
    /// </summary>
    partial class Vue_ViewScriptCommands_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptCommands_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "Commands";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            var model = BuildCommandTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/AiCommand.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n" +
                              $"错误类型: {ex.GetType().Name}\n" +
                              $"错误消息: {ex.Message}\n" +
                              $"堆栈跟踪: {ex.StackTrace}";

                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderCommandError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染命令模板失败: {ex.Message}", ex);
            }

            // 调试：写入渲染结果
            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedCommand_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private AiCommandTemplateModel BuildCommandTemplateModel()
        {
            var model = new AiCommandTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameUpper = ConvertToSnakeCase(TabName_Out4ListRegion4GC).ToUpper()
            };

            // 添加查询区按钮
            AddQueryCommands(model);

            // 添加功能区按钮
            AddFeatureCommands(model);

            // 🔥 新增：提取功能区下拉框选项信息
            ExtractFeatureOptions(model);
            ExtractFeatureOptions4DS(model);
            GetViewVariables4Import(model);
            return model;
        }

        private void GetViewVariables4Import(AiCommandTemplateModel model)
        {
            var vueShareVariables = new List<string>();
            foreach(var objFeatureOptions in model.FeatureOptions4DS)
            {
                foreach ( var p in objFeatureOptions.Parameters)
                {
                    if (string.IsNullOrEmpty(p.SharedVarName) == false)
                        vueShareVariables.Add(p.SharedVarName);
                }
            }
            model.ModuleName = objFuncModuleEN.FuncModuleEnName;
            model.strIsShare = objViewInfoENEx.IsShare ? "Share" : "";
            model.ViewVariables = vueShareVariables;

        }

        /// <summary>
        /// 添加查询区命令
        /// </summary>
        private void AddQueryCommands(AiCommandTemplateModel model)
        {
            // 查询按钮（默认存在）
            model.Commands.Add(new AiCommand
            {
                Id = "query",
                Region = "query",
                Text = "查询",
                ElementId = "btnQuery_Ai",
                BtnClass = "btn btn-outline-warning text-nowrap",
                NeedAuxControl = false
            });


            // 导出按钮（如果启用了导出功能）
            if (objViewInfoENEx.arrViewFeatureFlds.Any(x => x.FeatureId == enumPrjFeature.SetExportExcel4User_0144))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "export",
                    Region = "query",
                    Text = "导出Excel",
                    ElementId = "btnExportExcel_Ai",
                    BtnClass = "btn btn-outline-warning text-nowrap",
                    NeedAuxControl = false
                });
            }
        }
        /// <summary>
        /// 检查是否存在指定的功能
        /// </summary>
        /// <param name="featureId">功能ID</param>
        /// <returns>是否存在该功能</returns>
        private bool HasFeature(string featureId)
        {
            if (objViewInfoENEx.arrFeatureRegionFlds == null) return false;

            return objViewInfoENEx.arrFeatureRegionFlds
                .Any(x => x.InUse == true && x.FeatureId == featureId);
        }
        /// <summary>
        /// 添加功能区命令
        /// </summary>
        private void AddFeatureCommands(AiCommandTemplateModel model)
        {
            List<DdlOptionsInfo> arrDdlOptionsInfo = clsViewFeatureFldsBLEx.GetDdlOptionInfoLstByViewId(this.ViewId, this.PrjId);
            var featureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true)
                .ToList();

            model.HasAdjustOrderNum = HasFeature(enumPrjFeature.AdjustOrderNum_0142)
         || HasFeature(enumPrjFeature.AdjustOrderNum_0224)
         || HasFeature(enumPrjFeature.AdjustOrderNum_0225)
         || HasFeature(enumPrjFeature.AdjustOrderNum_1196);

            // 添加新记录（支持多种添加功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.AddNewRecord_0136 || 
                                            x.FeatureId == enumPrjFeature.AddNewRecordWithMaxId_0183 ||
                                            x.FeatureId == enumPrjFeature.AddNewRecord_0197))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "create",
                    Region = "feature",
                    Text = "添加",
                    ElementId = "btnCreate_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 修改记录（支持多种修改功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.UpdateRecord_0137 ||
                                            x.FeatureId == enumPrjFeature.UpdateRecord_0199))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "update",
                    Region = "feature",
                    Text = "修改",
                    ElementId = "btnUpdate_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 删除记录（支持多种删除功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.DelRecord_0138 ||
                                            x.FeatureId == enumPrjFeature.DelRecord_0184))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "delete",
                    Region = "feature",
                    Text = "删除",
                    ElementId = "btnDelete_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 🔥 新增：复制记录（支持多种复制功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.CopyRecord_0141 ||
                                            x.FeatureId == enumPrjFeature.CopyRecord_0198))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "copy",
                    Region = "feature",
                    Text = "复制",
                    ElementId = "btnCopy_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }


            // 🔥 新增：复制记录（支持多种复制功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.ExportToFile_0143 ||
                                            x.FeatureId == enumPrjFeature.ExportToFile_0196))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "export",
                    Region = "feature",
                    Text = "导出Excel",
                    ElementId = "btnExportExcel_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 详细信息（新增支持）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.DetailRecord_0239 ||
                                            x.FeatureId == enumPrjFeature.DetailRecord_Gv_0181))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "detail",
                    Region = "feature",
                    Text = "详细信息",
                    ElementId = "btnDetail_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }
                     

            // 查询（支持多种查询功能ID）
            // ⚠️ 避免与查询区的 query 命令重复
            var hasQueryInQueryRegion = model.Commands.Any(x => x.Id == "query" && x.Region == "query");
            if (!hasQueryInQueryRegion && 
                featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.Query_0139 ||
                                            x.FeatureId == enumPrjFeature.Query_0186))
            {
                model.Commands.Add(new AiCommand
                {
                    Id = "query",
                    Region = "feature",
                    Text = "查询",
                    ElementId = "btnQuery_Ai",
                    BtnClass = "btn btn-outline-warning text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 🔥 设置字段值（动态生成，如设置使用状态）
            var setFieldFeatures = featureRegionFlds.Where(x => x.FeatureId == enumPrjFeature.SetFieldValue_0148).ToList();
            foreach (var feature in setFieldFeatures)
            {
                var commandId = GetCommandId(feature);

                // 获取字段中文名（用于按钮文本）
                string buttonText = feature.Text;
                if (string.IsNullOrEmpty(buttonText))
                {
                    buttonText = "设置字段值";
                }
                // 🔥 获取辅助控件类型和选项键
                var (auxControlType, auxControlOptionsKey) = GetAuxControlInfo(feature);

                var objDdlOptionsInfo = arrDdlOptionsInfo.Find(x => x.FldId == feature.ReleFldId);
                if (objDdlOptionsInfo == null)
                {
                    model.Commands.Add(new AiCommand
                    {
                        Id = commandId,
                        Region = "feature",
                        Text = buttonText,
                        ElementId = $"btn{char.ToUpper(commandId[0]) + commandId.Substring(1)}_Ai",
                        BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                        NeedAuxControl = true,
                        AuxControlType = auxControlType,                                                
                        FieldName = GetFieldName(feature),
                        FieldNameCamel = ToCamelCase(GetFieldName(feature))
                    });
                    continue;
                }
                    



              
               

                
                model.Commands.Add(new AiCommand
                {
                    Id = commandId,
                    Region = "feature",
                    Text = buttonText,
                    ElementId = $"btn{char.ToUpper(commandId[0]) + commandId.Substring(1)}_Ai",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = true,
                    AuxControlId = objDdlOptionsInfo.AuxControlId,
                    AuxControlType = auxControlType,
                    AuxControlOptionsKey = objDdlOptionsInfo.AuxControlOptionsKey,
                    AuxControlLabel = objDdlOptionsInfo.AuxControlLabel,
                    IsNeedAuxControlLabel = objDdlOptionsInfo.IsNeedAuxControlLabel,
                    FieldName = GetFieldName(feature),
                    FieldNameCamel = ToCamelCase(GetFieldName(feature))
                });
            }
        }

        /// <summary>
        /// 🔥 新增：提取功能区下拉框选项信息
        /// 使用 clsDDLItemsOptionBL.GetDdlOptionInfoLst 获取下拉框数据源信息
        /// </summary>
        private void ExtractFeatureOptions(AiCommandTemplateModel model)
        {
            try
            {
                List<clsViewVariable> arrViewVariable = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(objViewInfoENEx.ViewId, this.PrjId);

                // 获取所有设置字段值的功能
                var setFieldFeatures = objViewInfoENEx.arrFeatureRegionFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .ToList();

                if (setFieldFeatures.Count == 0)
                {
                    Console.WriteLine("没有设置字段值功能");
                    return;
                }

                // 🔥 使用 GetDdlOptionInfoLst 获取下拉框选项信息
                var arrViewFeatureFldsENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .Cast<clsViewFeatureFldsENEx>()
                    .ToList();

                var ddlOptionsInfoList = clsViewFeatureFldsBLEx.GetDdlOptionInfoLst(arrViewFeatureFldsENEx);

                foreach (var ddlInfo in ddlOptionsInfoList)
                {
                    // 生成选项键（如 useState, dataBaseType）
                    string optionKey = ToCamelCase(ddlInfo.WApiClass);

                    // 检查是否已存在
                    if (model.FeatureOptions.Any(x => x.Key == optionKey))
                    {
                        continue;
                    }
                    foreach(var p in ddlInfo.Parameters)
                    {
                        string strVarName = arrViewVariable.Find(x => x.VarId == p.VarId)?.VariableName;
                        if (string.IsNullOrEmpty(strVarName) == false) p.SharedVarName = strVarName;
                    }
                    var optionInfo = new AiOptionsInfo
                    {
                        Key = optionKey,
                        WApiClass = ddlInfo.WApiClass,
                        ModuleName = ddlInfo.ModuleName,
                        GetDdlDataFuncName = ddlInfo.GetDdlDataFuncName,
                        IsExtendedClass = ddlInfo.IsExtendedClass,
                        Parameters = ddlInfo.Parameters?.Select(p =>
                            new DdlOptionParam
                            {
                                ParamName = p.ParamName,
                                SharedVarName = p.SharedVarName
                            }).ToList() ?? new List<DdlOptionParam>()
                    };

                    model.FeatureOptions.Add(optionInfo);

                    Console.WriteLine($"✅ 功能区选项: {optionKey}, 函数: {ddlInfo.GetDdlDataFuncName}, 参数数量: {optionInfo.Parameters.Count}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 提取功能区选项失败: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void ExtractFeatureOptions4DS(AiCommandTemplateModel model)
        {
            try
            {
                List<clsViewVariable> arrViewVariable = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(objViewInfoENEx.ViewId, this.PrjId);

                // 获取所有设置字段值的功能
                var setFieldFeatures = objViewInfoENEx.arrFeatureRegionFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .ToList();

                if (setFieldFeatures.Count == 0)
                {
                    Console.WriteLine("没有设置字段值功能");
                    return;
                }

                // 🔥 使用 GetDdlOptionInfoLst 获取下拉框选项信息
                var arrViewFeatureFldsENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .Cast<clsViewFeatureFldsENEx>()
                    .ToList();

                var ddlOptionsInfoList = clsViewFeatureFldsBLEx.GetDdlOptionInfoLst(arrViewFeatureFldsENEx);

                foreach (var ddlInfo in ddlOptionsInfoList)
                {
                    // 生成选项键（如 useState, dataBaseType）
                    string optionKey = ToCamelCase(ddlInfo.Key);

                    // 检查是否已存在
                    if (model.FeatureOptions.Any(x => x.Key == optionKey))
                    {
                        continue;
                    }
                    foreach (var p in ddlInfo.Parameters)
                    {
                        string strVarName = arrViewVariable.Find(x => x.VarId == p.VarId)?.VariableName;
                        if (string.IsNullOrEmpty(strVarName) == false) p.SharedVarName = strVarName;
                    }
                    var optionInfo = new AiOptionsInfo
                    {
                        //Key = optionKey,
                        ControlType = ddlInfo.ControlType,
                        WApiClass = ddlInfo.WApiClass,
                        ModuleName = ddlInfo.ModuleName,
                        GetDdlDataFuncName = ddlInfo.GetDdlDataFuncName,
                        IsExtendedClass = ddlInfo.IsExtendedClass,
                        WApiFileName = ddlInfo.WApiFileName,
                        WApiPath = ddlInfo.WApiPath,                        
                        Parameters = ddlInfo.Parameters?.Select(p => new DdlOptionParam
                        {
                            ParamName = p.ParamName,
                            SharedVarName = p.SharedVarName
                        }).ToList() ?? new List<DdlOptionParam>()
                    };
                    if (optionInfo.ControlType != "select4Bool")
                    {
                        if (model.FeatureOptions4DS.Find(x => x.WApiClass == optionInfo.WApiClass) == null)
                        {
                            model.FeatureOptions4DS.Add(optionInfo);
                        }
                    }
                    Console.WriteLine($"✅ 功能区选项: {optionKey}, 函数: {ddlInfo.GetDdlDataFuncName}, 参数数量: {optionInfo.Parameters.Count}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 提取功能区选项失败: {ex.Message}\n{ex.StackTrace}");
            }
        }


        /// <summary>
        /// 🔥 新增：获取辅助控件信息（类型和选项键）
        /// </summary>
        private (string AuxControlType, string AuxControlOptionsKey) GetAuxControlInfo(clsFeatureRegionFldsENEx feature)
        {
            try
            {

                // 获取关联字段
                if (string.IsNullOrEmpty(feature.ReleFldId))
                {
                    return (null, null);
                }
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                if (objFieldTab == null)
                {
                    return (null, null);
                }

                // 判断字段类型
                if (objFieldTab.DataTypeId == enumDataTypeAbbr.bit_03)
                {
                    return ("select4Bool", null);  // 布尔类型不需要 optionsKey
                }
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureIdCache(feature.ViewFeatureId, feature.PrjId());
                clsViewFeatureFldsEN objViewFeatureFlds = 
                    arrViewFeatureFlds.Find(x => x.CtlTypeId == enumCtlType.DropDownList_06 || x.CtlTypeId == enumCtlType.DropDownList_Bool_18);

                // 获取数据源表
                if (string.IsNullOrEmpty(objViewFeatureFlds.DsTabId))
                {
                    return ("select", null);
                }

                var objDsTab = clsPrjTabBL.GetObjByTabIdCache(objViewFeatureFlds.DsTabId, feature.PrjId());
                if (objDsTab == null)
                {
                    return ("select", null);
                }

                // 生成选项键
                string optionKey = ToCamelCase(objDsTab.TabName);

                return ("select", optionKey);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取辅助控件信息失败: {ex.Message}");
                return (null, null);
            }
        }

        /// <summary>
        /// 获取字段名
        /// </summary>
        private string GetFieldName(clsFeatureRegionFldsENEx feature)
        {
            if (!string.IsNullOrEmpty(feature.ReleFldId))
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                if (objFieldTab != null)
                {
                    return objFieldTab.FldName;
                }
            }
            return "Field";
        }

        /// <summary>
        /// 根据功能按钮获取命令ID
        /// 优先使用标准命令映射，SetFieldValue 功能根据关联字段智能生成
        /// </summary>
        private string GetCommandId(clsFeatureRegionFldsENEx feature)
        {
            // 🔥 1. 标准功能映射（使用正确的枚举值）
            if (feature.FeatureId == enumPrjFeature.AddNewRecord_0136)
                return "create";

            if (feature.FeatureId == enumPrjFeature.AddNewRecord_0197)
                return "create";

            if (feature.FeatureId == enumPrjFeature.UpdateRecord_0137)
                return "update";

            if (feature.FeatureId == enumPrjFeature.DelRecord_0138 ||
                feature.FeatureId == enumPrjFeature.DelRecord_0184)
                return "delete";

            if (feature.FeatureId == enumPrjFeature.Query_0139 ||
                feature.FeatureId == enumPrjFeature.Query_0186)
                return "query";

            if (feature.FeatureId == enumPrjFeature.ExportToFile_0143 ||
                feature.FeatureId == enumPrjFeature.ExportToFile_0196)
                return "export";

            // 🔥 2. SetFieldValue 功能：根据关联字段智能生成命令ID
            if (feature.FeatureId == enumPrjFeature.SetFieldValue_0148)
            {
                // 优先从关联字段ID获取字段名
                if (!string.IsNullOrEmpty(feature.ReleFldId))
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                    if (objFieldTab != null)
                    {
                        string fieldName = objFieldTab.FldName;
                        // "UseStateId" → "setUseState"
                        // "FuncModuleId" → "setFuncModule"
                        string commandId = "set" + RemoveIdSuffix(fieldName);
                        return ToCamelCase(commandId);
                    }
                }

                // 降级方案：从按钮文本推断
                return GenerateCommandIdFromButtonText(feature.ButtonName);
            }

            // 🔥 3. 其他功能：使用按钮名称的驼峰式
            return ToCamelCase(feature.ButtonName);
        }

        /// <summary>
        /// 移除字段名的 Id 后缀
        /// </summary>
        private string RemoveIdSuffix(string fieldName)
        {
            if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase) && fieldName.Length > 2)
            {
                return fieldName.Substring(0, fieldName.Length - 2);
            }
            return fieldName;
        }

        /// <summary>
        /// 从按钮文本生成命令ID
        /// </summary>
        private string GenerateCommandIdFromButtonText(string buttonText)
        {
            if (string.IsNullOrEmpty(buttonText))
                return "setField";

            // 移除"设置"前缀
            string fieldPart = buttonText.StartsWith("设置")
                ? buttonText.Substring(2)
                : buttonText;

            // 生成驼峰式命令ID
            return ToCamelCase("set" + fieldPart);
        }

        /// <summary>
        /// 将 PascalCase 转换为 SNAKE_CASE
        /// </summary>
        private string ConvertToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new StringBuilder();
            result.Append(char.ToUpper(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    result.Append('_');
                }
                result.Append(char.ToUpper(input[i]));
            }

            return result.ToString();
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}