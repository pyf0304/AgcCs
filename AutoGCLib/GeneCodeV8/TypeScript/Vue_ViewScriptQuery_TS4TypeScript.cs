using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClassEx;
using AgcCommBase;
using AutoGCLib.Templates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 Ai 版本的查询字段规格 TypeScript 文件
    /// </summary>
    partial class Vue_ViewScriptQuery_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptQuery_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strCmPrjId)
            : base(strViewId, strPrjDataBaseId, strCmPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "Query";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            var model = BuildQueryTemplateModel();

            // 🔥 详细调试日志
            var debugLog = new StringBuilder();
            debugLog.AppendLine($"========== 查询模型调试 ==========");
            debugLog.AppendLine($"TableName: {model.TableName}");
            debugLog.AppendLine($"ModuleName: {model.ModuleName}");
            debugLog.AppendLine($"OptionsInfo.Count: {model.OptionsInfo.Count}");

            foreach (var option in model.OptionsInfo)
            {
                debugLog.AppendLine($"\n选项: {option.Key}");
                debugLog.AppendLine($"  FunctionName: {option.GetDdlDataFuncName}");
                debugLog.AppendLine($"  Parameters.Count: {option.Parameters?.Count ?? 0}");

                if (option.Parameters != null && option.Parameters.Count > 0)
                {
                    foreach (var param in option.Parameters)
                    {
                        debugLog.AppendLine($"    - {param.ParamName} = {param.SharedVarName}");
                    }
                }
            }

            debugLog.AppendLine($"\n====================================");
            Console.WriteLine(debugLog.ToString());

            // 写入文件
            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QueryModelDebug.log");
            File.WriteAllText(debugFile, debugLog.ToString(), Encoding.UTF8);

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/Ai3Query.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n" +
                              $"错误类型: {ex.GetType().Name}\n" +
                              $"错误消息: {ex.Message}\n" +
                              $"堆栈跟踪: {ex.StackTrace}";

                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}\n" +
                               $"内部异常堆栈: {ex.InnerException.StackTrace}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);

                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染查询模板失败: {ex.Message}", ex);
            }

            // 调试：写入渲染结果
            var resultFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedQuery_Debug.txt");
            File.WriteAllText(resultFile, result, Encoding.UTF8);

            return result;
        }

        /// <summary>
        /// 🔥 从数据源表和表功能获取选项信息（包含参数信息）
        /// </summary>
        private (string Key, string WApiClass, string ModuleName, string FunctionName, bool IsExtendedClass, List<DdlOptionParam> Parameters) GetOptionsInfoFromDataSource(clsQryRegionFldsEN fld)
        {
            try
            {
                string fldName = "";
                string optionKey = "";
                List<DdlOptionParam> parameters = new List<DdlOptionParam>();
                if (fld.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                {

                    fldName = fld.ObjFieldTab_PC().FldName;
                    optionKey = ToCamelCase(fldName) + "_q";
                    return (optionKey, null, null, null, false, parameters);
                }
                // 1. 检查是否有数据源表ID
                string dsTabId = fld.DsTabId;
                if (string.IsNullOrEmpty(dsTabId))
                {
                    return (null, null, null, null, false, null);
                }

                // 2. 获取数据源表对象
                var objDsTab = clsPrjTabBL.GetObjByTabIdCache(dsTabId, fld.PrjId);
                if (objDsTab == null)
                {
                    Console.WriteLine($"❌ 找不到数据源表: {dsTabId}");
                    return (null, null, null, null, false, null);
                }

                // 3. 获取表的功能模块
                var objFuncModule = objDsTab.ObjFuncModule();
                string moduleName = objFuncModule?.FuncModuleEnName ?? "SysPara";

                // 4. WApi 类名 = 数据源表名
                string wApiClass = objDsTab.TabName;

                //获取字段名
                fldName = fld.ObjFieldTab_PC().FldName;
                // 5. 默认 TypeScript 函数名
                string getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}";
                bool isExtendedClass = false;

                // 6. 🔥 如果有表功能ID
                string tabFeatureId = fld.TabFeatureId4Ddl;
                if (!string.IsNullOrEmpty(tabFeatureId))
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(tabFeatureId, fld.PrjId);
                    if (objTabFeature != null && objTabFeature.IsForTypeScript)
                    {
                        isExtendedClass = objTabFeature.IsExtendedClass;

                        // 获取函数名


                        if (string.IsNullOrEmpty(objTabFeature.GetDdlDataFuncName4Ex))
                        {
                            var strConditionFieldName = clsTabFeatureBLEx.GetConditionFieldNameByTabFeatureId(tabFeatureId, fld.PrjId);

                            if (string.IsNullOrEmpty(strConditionFieldName))
                            {
                                getDdlDataFuncName = $"{wApiClass}_{objTabFeature.GetDdlDataFuncName4Ex}";
                            }
                            else
                            {
                                getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}By{strConditionFieldName}";
                            }
                        }
                        else
                        {
                            getDdlDataFuncName = $"{wApiClass}_{objTabFeature.GetDdlDataFuncName4Ex}";
                        }
                        // 🔥 获取参数（从查询字段的 VarIdCond1, VarIdCond2）
                        parameters = GetFunctionParameters(fld, objTabFeature, fld.PrjId);
                    }
                }

                // 7. 生成选项键
                optionKey = ToCamelCase(fldName) + "_q";

                Console.WriteLine($"✅ 表: {wApiClass}, 函数: {getDdlDataFuncName}, 参数数量: {parameters.Count}");

                return (optionKey, wApiClass, moduleName, getDdlDataFuncName, isExtendedClass, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 获取选项信息失败: {ex.Message}\n{ex.StackTrace}");
                return (null, null, null, null, false, null);
            }
        }

        /// <summary>
        /// 🔥 新增：获取函数参数信息（从表功能的条件字段）
        /// 核心逻辑：
        /// 1. 从 TabFeatureFlds 获取条件字段（FieldTypeId = 16）
        /// 2. 通过 GCVariablePrjIdRela 查找对应的变量（通过 FldId + PrjId）
        /// 3. 从 GCVariable 获取变量名
        /// 4. 转换为共享变量格式（去掉 str 前缀，加上 _Static 后缀）
        /// </summary>
        private List<DdlOptionParam> GetFunctionParametersBak(clsTabFeatureEN objTabFeature, string strPrjId)
        {
            var parameters = new List<DdlOptionParam>();

            try
            {
                List<clsViewVariable> arrViewVariable = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(objViewInfoENEx.ViewId, strPrjId);

                Console.WriteLine($"  获取表功能 {objTabFeature.TabFeatureName} 的参数");
                // 1. 获取表功能字段列表
                var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, strPrjId);
                if (arrTabFeatureFlds == null || arrTabFeatureFlds.Count == 0)
                {
                    Console.WriteLine($"  表功能 {objTabFeature.TabFeatureName} 没有字段");
                    return parameters;
                }

                // 2. 筛选条件字段（FieldTypeId = 16）
                var arrConditionFields = arrTabFeatureFlds
                    .Where(x => x.FieldTypeId == enumFieldType.ConditionField_16)
                    .OrderBy(x => x.OrderNum)
                    .ToList();

                if (arrConditionFields.Count == 0)
                {
                    Console.WriteLine($"  表功能 {objTabFeature.TabFeatureName} 没有条件字段");
                    return parameters;
                }

                Console.WriteLine($"  找到 {arrConditionFields.Count} 个条件字段");

                // 3. 对每个条件字段，通过 GCVariablePrjIdRela 查找变量
                foreach (var condField in arrConditionFields)
                {
                    try
                    {
                        // 获取字段对象
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(condField.FldId, strPrjId);
                        if (objFieldTab == null)
                        {
                            Console.WriteLine($"    ⚠️ 找不到字段: {condField.FldId}");
                            continue;
                        }

                        Console.WriteLine($"    处理条件字段: {objFieldTab.FldName} ({condField.FldId})");

                        // 🔥 通过 GCVariablePrjIdRela 查找变量（根据 FldId + PrjId）
                        string strWhere = $"{conGCVariablePrjIdRela.FldId}='{condField.FldId}' and {conGCVariablePrjIdRela.PrjId}='{strPrjId}'";
                        var arrVariablePrjRela = clsGCVariablePrjIdRelaBL.GetObjLst(strWhere);

                        if (arrVariablePrjRela != null && arrVariablePrjRela.Count > 0)
                        {
                            var objVariablePrjRela = arrVariablePrjRela[0];

                            // 🔥 从 GCVariable 获取变量对象
                            var objVariable = clsGCVariableBLEx.GetObjByVarIdCache(objVariablePrjRela.VarId);
                            if (objVariable != null)
                            {
                                // 🔥 构建共享变量名：去掉 "str" 前缀，加上 "_Static" 后缀
                                // 例如：strProgLangTypeId → ProgLangTypeId_Static
                                string sharedVarName = arrViewVariable.Find(x => x.VarId == objVariablePrjRela.VarId)?.VariableName;


                                // 去掉 "str" 前缀（如果有）
                                if (sharedVarName.StartsWith("str") && sharedVarName.Length > 3 && char.IsUpper(sharedVarName[3]))
                                {
                                    sharedVarName = sharedVarName.Substring(3);
                                }



                                // 构建参数信息
                                var param = new DdlOptionParam
                                {
                                    ParamName = ToCamelCase(objFieldTab.FldName),  // 如 progLangTypeId
                                    SharedVarName = sharedVarName,                  // 如 ProgLangTypeId_Static
                                    FldId = condField.FldId,
                                    VarId = objVariable.VarId
                                };

                                parameters.Add(param);

                                Console.WriteLine($"      ✓ 找到变量: {objVariable.VarName} → 共享变量: {sharedVarName}");
                            }
                            else
                            {
                                Console.WriteLine($"      ⚠️ 找不到变量: VarId={objVariablePrjRela.VarId}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"      ⚠️ 字段 {objFieldTab.FldName} 在 GCVariablePrjIdRela 中没有对应的变量");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"    ❌ 处理条件字段失败: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 获取函数参数失败: {ex.Message}\n{ex.StackTrace}");
            }

            return parameters;
        }

        /// <summary>
        /// 🔥 修正：从查询字段的条件变量获取参数信息
        /// 核心逻辑：
        /// 1. 从 QryRegionFlds 的 VarIdCond1, VarIdCond2 等字段获取变量ID
        /// 2. 通过 GCVariable 获取变量名
        /// 3. 转换为共享变量格式（去掉 str 前缀，加上 _Static 后缀）
        /// </summary>
        private List<DdlOptionParam> GetFunctionParameters(clsQryRegionFldsEN fld, clsTabFeatureEN objTabFeature, string strPrjId)
        {
            var parameters = new List<DdlOptionParam>();

            try
            {
                List<clsViewVariable> arrViewVariable = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(objViewInfoENEx.ViewId, strPrjId);
                Console.WriteLine($"  获取表功能 {objTabFeature.TabFeatureName} 的参数");

                // 🔥 从查询字段的条件变量字段获取参数
                // VarIdCond1, VarIdCond2 等
                var conditionVarIds = new List<(string VarId, int Order)>();

                // 检查 VarIdCond1
                if (!string.IsNullOrEmpty(fld.VarIdCond1))
                {
                    conditionVarIds.Add((fld.VarIdCond1, 1));
                    Console.WriteLine($"    找到条件变量1: {fld.VarIdCond1}");
                }

                // 检查 VarIdCond2
                if (!string.IsNullOrEmpty(fld.VarIdCond2))
                {
                    conditionVarIds.Add((fld.VarIdCond2, 2));
                    Console.WriteLine($"    找到条件变量2: {fld.VarIdCond2}");
                }

                if (conditionVarIds.Count == 0)
                {
                    Console.WriteLine($"    没有条件变量");
                    return parameters;
                }

                // 按顺序处理每个条件变量
                foreach (var (varId, order) in conditionVarIds.OrderBy(x => x.Order))
                {
                    try
                    {
                        // 🔥 从 GCVariable 获取变量对象
                        var objVariable = clsGCVariableBLEx.GetObjByVarIdCache(varId);
                        if (objVariable != null)
                        {
                            // 🔥 构建共享变量名：去掉 "str" 前缀，加上 "_Static" 后缀
                            // 例如：strProgLangTypeId → ProgLangTypeId_Static
                            //       strCodeTypeId → CodeTypeId_Static
                            string sharedVarName = arrViewVariable.Find(x => x.VarId == varId)?.VariableName;

                            Console.WriteLine($"      原始变量名: {sharedVarName}");

                            // 去掉 "str" 前缀（如果有且后面是大写字母）
                            if (sharedVarName.StartsWith("str") && sharedVarName.Length > 3 && char.IsUpper(sharedVarName[3]))
                            {
                                sharedVarName = sharedVarName.Substring(3);
                            }



                            // 🔥 获取对应的字段ID（从 FldIdCond1, FldIdCond2）
                            string fldId = null;
                            if (order == 1 && !string.IsNullOrEmpty(fld.FldIdCond1))
                            {
                                fldId = fld.FldIdCond1;
                            }
                            else if (order == 2 && !string.IsNullOrEmpty(fld.FldIdCond2))
                            {
                                fldId = fld.FldIdCond2;
                            }

                            // 获取字段名（用于生成参数名）
                            string paramName = null;
                            if (!string.IsNullOrEmpty(fldId))
                            {
                                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(fldId, strPrjId);
                                if (objFieldTab != null)
                                {
                                    paramName = ToCamelCase(objFieldTab.FldName);
                                }
                            }

                            // 构建参数信息
                            var param = new DdlOptionParam
                            {
                                ParamName = paramName ?? ToCamelCase(objVariable.VarName),
                                SharedVarName = sharedVarName,
                                FldId = fldId,
                                VarId = varId
                            };

                            parameters.Add(param);

                            Console.WriteLine($"      ✓ 共享变量: {sharedVarName}");
                        }
                        else
                        {
                            Console.WriteLine($"      ⚠️ 找不到变量: VarId={varId}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"    ❌ 处理条件变量失败: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 获取函数参数失败: {ex.Message}\n{ex.StackTrace}");
            }

            return parameters;
        }

        /// <summary>
        /// 根据控件类型确定前端控件类型
        /// </summary>
        private string GetControlType(string ctlTypeId)
        {
            switch (ctlTypeId)
            {
                case enumCtlType.TextBox_16:
                    return "text";
                case enumCtlType.DropDownList_06:
                    return "select";
                case enumCtlType.CheckBox_02:
                    return "checkbox";
                case enumCtlType.RadioButton_14:
                    return "radio";
                default:
                    return "text";
            }
        }

        /// <summary>
        /// 根据控件类型和下拉框选项类型确定前端控件类型
        /// 🔥 支持 select4Bool（当 DdlItemsOptionId = '04' 真假列表时）
        /// </summary>
        private string GetControlType(clsQryRegionFldsENEx fld)
        {
            // 🔥 关键修复：如果是下拉框且选项类型为真假列表（04），返回 select4Bool
            if (fld.CtlTypeId == enumCtlType.DropDownList_06)
            {
                if (fld.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                {
                    return "select4Bool";
                }
                return "select";
            }

            // 其他控件类型
            switch (fld.CtlTypeId)
            {
                case enumCtlType.TextBox_16:
                    return "text";
                case enumCtlType.CheckBox_02:
                    return "checkbox";
                case enumCtlType.RadioButton_14:
                    return "radio";
                case enumCtlType.DropDownList_Bool_18:
                    return "select4Bool";
                default:
                    return "text";
            }
        }

        private AiQueryTemplateModel BuildQueryTemplateModel()
        {
            var model = new AiQueryTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                strIsShare = objViewInfoENEx.IsShare ? "Share" : "",
                ModuleName = objFuncModuleEN.FuncModuleEnName
            };

            // 获取查询区域字段
            var arrQueryFields = objViewInfoENEx.arrQryRegionFldSet4InUse
                .Where(x => x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            List<DdlOptionsInfo> arrDdlOptionsInfo = clsQryRegionFldsBLEx.GetDdlOptionInfoLstByViewId(objViewInfoENEx.ViewId, this.PrjId);
            int currentRow = 1;
            int currentOrder = 1;

            foreach (var objQueryField in arrQueryFields)
            {
                try
                {
                    var objPrjTabFld = objQueryField.ObjPrjTabFld();
                    if (objPrjTabFld == null) continue;

                    var objFieldTab = objPrjTabFld.ObjFieldTab();
                    if (objFieldTab == null) continue;

                    // 🔥 修改：传入完整的 fld 对象而不是只传 ctlTypeId
                    string controlType = GetControlType(objQueryField);
                    bool bolIsNumber = objQueryField.ObjFieldTab().IsNumberType();
                    string optionsKey = null;
                    string optionsWApiClass = null;
                    string optionsModuleName = null;
                    string optionsFunctionName = null;
                    bool optionsIsExtendedClass = false;
                    List<DdlOptionParam> optionsParameters = null;

                    // 🔥 修改：只有非布尔类型的下拉框才获取选项信息
                    if (objQueryField.CtlTypeId == enumCtlType.DropDownList_06 )
                    {
                        //var optionInfo = GetOptionsInfoFromDataSource(objQueryField);
                        var objDdlOptionsInfo = arrDdlOptionsInfo.Find(x => x.FldId == objQueryField.FldId);
                        optionsKey = objDdlOptionsInfo.Key;
                        optionsWApiClass = objDdlOptionsInfo.WApiClass;
                        optionsModuleName = objDdlOptionsInfo.ModuleName;
                        optionsFunctionName = objDdlOptionsInfo.GetDdlDataFuncName;
                        optionsIsExtendedClass = objDdlOptionsInfo.IsExtendedClass;
                        optionsParameters = objDdlOptionsInfo.Parameters;
                    }
                    if (objQueryField.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                    {
                        var optionInfo = GetOptionsInfoFromDataSource(objQueryField);
                        //var objDdlOptionsInfo = arrDdlOptionsInfo.Find(x => x.FldId == objQueryField.FldId);
                        optionsKey = optionInfo.Key;
                        optionsWApiClass = optionInfo.WApiClass;
                        optionsModuleName = optionInfo.ModuleName;
                        optionsFunctionName = optionInfo.FunctionName;
                        optionsIsExtendedClass = optionInfo.IsExtendedClass;
                        optionsParameters = optionInfo.Parameters;
                    }

                    var queryField = new AiQueryField
                    {
                        Key = ToCamelCase(objPrjTabFld.FldName()) + "_q",
                        Label = objQueryField.LabelCaption ?? objFieldTab.FldCnName,
                        Id = GetControlId(objQueryField.CtlTypeId, objPrjTabFld.FldName()),
                        ControlType = controlType,
                        IsNumber = bolIsNumber,
                        Width = 120,
                        Row = currentRow,
                        Order = currentOrder,
                        OptionsKey = optionsKey,
                        OptionsWApiClass = optionsWApiClass,
                        OptionsModuleName = optionsModuleName,
                        GetDdlDataFuncName = optionsFunctionName,
                        OptionsIsExtendedClass = optionsIsExtendedClass,
                        OptionsParameters = optionsParameters,
                        DefaultValue = GetDefaultValue(controlType, objQueryField.CtlTypeId)
                    };

                    model.QueryFields.Add(queryField);

                    currentOrder++;
                    if (currentOrder > 4)
                    {
                        currentRow++;
                        currentOrder = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"处理查询字段时出错: {ex.Message}");
                }
            }

            // 提取选项数据源信息
            ExtractOptionsInfo(model);
            ExtractOptionsInfo4DS(model);
            return model;
        }

        /// <summary>
        /// 提取所有唯一的选项信息
        /// </summary>
        private void ExtractOptionsInfo(AiQueryTemplateModel model)
        {
            var uniqueOptions = model.QueryFields
                .Where(f => !string.IsNullOrEmpty(f.OptionsKey))
                .GroupBy(f => f.OptionsKey)
                .Select(g =>
                {
                    var first = g.First();
                    return new AiOptionsInfo
                    {
                        Key = first.OptionsKey,
                        WApiClass = first.OptionsWApiClass,
                        ModuleName = first.OptionsModuleName,
                        GetDdlDataFuncName = first.GetDdlDataFuncName,
                        IsExtendedClass = first.OptionsIsExtendedClass,
                        WApiPath = first.OptionsIsExtendedClass ? "L3ForWApiEx" : "L3ForWApi",
                        WApiFileName = first.OptionsIsExtendedClass
                            ? $"cls{first.OptionsWApiClass}ExWApi"
                            : $"cls{first.OptionsWApiClass}WApi",
                        Parameters = first.OptionsParameters  // 🔥 新增
                    };
                })
                .ToList();

            model.OptionsInfo.AddRange(uniqueOptions);
        }

        private void ExtractOptionsInfo4DS(AiQueryTemplateModel model)
        {
            var uniqueOptions = model.QueryFields
                .Where(f => !string.IsNullOrEmpty(f.OptionsKey))
                .GroupBy(f => f.OptionsKey)
                .Select(g =>
                {
                    var first = g.First();
                    return new AiOptionsInfo
                    {
                        ControlType = first.ControlType,  // 🔥 新增：传递控件类型以区分 select 和 select4Bool
                        WApiClass = first.OptionsWApiClass,
                        ModuleName = first.OptionsModuleName,
                        GetDdlDataFuncName = first.GetDdlDataFuncName,
                        IsExtendedClass = first.OptionsIsExtendedClass,
                        WApiPath = first.OptionsIsExtendedClass ? "L3ForWApiEx" : "L3ForWApi",
                        WApiFileName = first.OptionsIsExtendedClass
                            ? $"cls{first.OptionsWApiClass}ExWApi"
                            : $"cls{first.OptionsWApiClass}WApi",
                        Parameters = first.OptionsParameters  // 🔥 新增
                    };
                })
                .ToList();
            foreach (var item in uniqueOptions)
            {
                if (item.ControlType == "select4Bool") continue;
                if (model.OptionsInfo4DS.Find(x => x.WApiClass == item.WApiClass) == null)
                {
                    model.OptionsInfo4DS.Add(item);
                }
            }
        }

        /// <summary>
        /// 生成控件ID
        /// </summary>
        private string GetControlId(string ctlTypeId, string fldName)
        {
            string prefix;
            switch (ctlTypeId)
            {
                case enumCtlType.TextBox_16:
                    prefix = "txt";
                    break;
                case enumCtlType.DropDownList_06:
                    prefix = "ddl";
                    break;
                case enumCtlType.DropDownList_Bool_18:
                    prefix = "ddl";
                    break;
                case enumCtlType.CheckBox_02:
                    prefix = "chk";
                    break;
                case enumCtlType.RadioButton_14:
                    prefix = "rdo";
                    break;
                default:
                    prefix = "txt";
                    break;
            }

            return prefix + fldName + "_q";
        }

        /// <summary>
        /// 获取默认值
        /// 🔥 修改：支持 select4Bool 类型
        /// </summary>
        private string GetDefaultValue(string controlType, string ctlTypeId)
        {
            if (controlType == "select")
            {
                return "0";  // 普通下拉框：'0' 表示"请选择"
            }
            else if (controlType == "select4Bool")
            {
                return "0";  // 🔥 布尔下拉框：'0' 表示"请选择是/否"
            }
            else if (controlType == "checkbox")
            {
                return "false";
            }
            else
            {
                return "";  // 文本框等：空字符串
            }
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}