using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using AutoGCLib.Templates;
using AGC.Entity;
using AGC.BusinessLogicEx;
using AGC.BusinessLogic;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 Ai4 版本的命令配置 TypeScript 文件
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

            strRe_ClsName = strRe_ClsName + "AiCommands";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

            var model = BuildCommandTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/Ai4Command.sbn", model);
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

        private Ai4CommandTemplateModel BuildCommandTemplateModel()
        {
            var model = new Ai4CommandTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameUpper = ConvertToSnakeCase(TabName_Out4ListRegion4GC).ToUpper()
            };

            // 添加查询区按钮
            AddQueryCommands(model);

            // 添加功能区按钮
            AddFeatureCommands(model);

            return model;
        }

        /// <summary>
        /// 添加查询区命令
        /// </summary>
        private void AddQueryCommands(Ai4CommandTemplateModel model)
        {
            // 查询按钮（默认存在）
            model.Commands.Add(new Ai4Command
            {
                Id = "query",
                Region = "query",
                Text = "查询",
                ElementId = "btnQuery_Ai4",
                BtnClass = "btn btn-outline-warning text-nowrap",
                NeedAuxControl = false
            });

            // 导出按钮（如果启用了导出功能）
            if (objViewInfoENEx.arrViewFeatureFlds.Any(x => x.FeatureId == enumPrjFeature.SetExportExcel4User_0144))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "export",
                    Region = "query",
                    Text = "导出Excel",
                    ElementId = "btnExportExcel_Ai4",
                    BtnClass = "btn btn-outline-warning text-nowrap",
                    NeedAuxControl = false
                });
            }
        }

        /// <summary>
        /// 添加功能区命令
        /// </summary>
        private void AddFeatureCommands(Ai4CommandTemplateModel model)
        {
            var featureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true)
                .ToList();

            // 添加新记录（支持多种添加功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.AddNewRecord_0136 || 
                                            x.FeatureId == enumPrjFeature.AddNewRecordWithMaxId_0183 ||
                                            x.FeatureId == enumPrjFeature.AddNewRecord_0197))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "create",
                    Region = "feature",
                    Text = "添加",
                    ElementId = "btnCreate_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 修改记录（支持多种修改功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.UpdateRecord_0137 ||
                                            x.FeatureId == enumPrjFeature.UpdateRecord_0199))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "update",
                    Region = "feature",
                    Text = "修改",
                    ElementId = "btnUpdate_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 删除记录（支持多种删除功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.DelRecord_0138 ||
                                            x.FeatureId == enumPrjFeature.DelRecord_0184))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "delete",
                    Region = "feature",
                    Text = "删除",
                    ElementId = "btnDelete_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 导出Excel（支持多种导出功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.ExportToFile_0143 ||
                                            x.FeatureId == enumPrjFeature.ExportToFile_0196))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "export",
                    Region = "feature",
                    Text = "导出Excel",
                    ElementId = "btnExportExcel_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 查询（支持多种查询功能ID）
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.Query_0139 ||
                                            x.FeatureId == enumPrjFeature.Query_0186))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "query",
                    Region = "feature",
                    Text = "查询",
                    ElementId = "btnQuery_Ai4",
                    BtnClass = "btn btn-outline-warning text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 设置字段值（动态生成，如设置使用状态）
            var setFieldFeatures = featureRegionFlds.Where(x => x.FeatureId == enumPrjFeature.SetFieldValue_0148).ToList();
            foreach (var feature in setFieldFeatures)
            {
                var commandId = GetCommandId(feature);
                
                // 获取字段中文名（用于按钮文本）
                string buttonText = feature.ButtonName;
                if (string.IsNullOrEmpty(buttonText))
                {
                    buttonText = "设置字段值";
                }

                model.Commands.Add(new Ai4Command
                {
                    Id = commandId,
                    Region = "feature",
                    Text = buttonText,
                    ElementId = $"btn{char.ToUpper(commandId[0]) + commandId.Substring(1)}_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = true  // 需要辅助控件（如下拉框）
                });
            }
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

    }
}