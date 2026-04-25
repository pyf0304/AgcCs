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
    /// 生成 Ai4 版本的基类 TypeScript 文件
    /// 这是一个复杂的类，包含完整的 CRUD 和列表操作功能
    /// </summary>
    partial class Vue_ViewScriptAi_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptAi_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "Ai";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

            var model = BuildAi4BaseTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/Ai4Base.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderAi4BaseError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染Ai4基类模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedAi4Base_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private Ai4BaseTemplateModel BuildAi4BaseTemplateModel()
        {
            var model = new Ai4BaseTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableNameUpper = ConvertToSnakeCase(TabName_Out4ListRegion4GC).ToUpper(),
                TableCnName = objPrjTabEx_ListRegion.TabCnName,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName()
            };

            // 提取功能按钮
            ExtractFeatures(model);

            return model;
        }

        /// <summary>
        /// 提取功能特性（按钮）
        /// </summary>
        private void ExtractFeatures(Ai4BaseTemplateModel model)
        {
            // 获取功能区域的字段
            var arrFeatureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true)
                .ToList();

            // 🔥 调试日志
            var logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractFeatures_Debug.log");
            using (var writer = new StreamWriter(logFile, append: true))
            {
                writer.WriteLine($"=== {DateTime.Now:yyyy-MM-dd HH:mm:ss} ===");
                writer.WriteLine($"功能区域字段总数: {arrFeatureRegionFlds.Count}");

                // 删除功能（支持多个功能ID）
                var deleteFeatureIds = new[] { 
                    enumPrjFeature.DelRecord_0138, 
                    enumPrjFeature.DelRecord_0184 
                };
                var deleteFeatures = arrFeatureRegionFlds
                    .Where(x => deleteFeatureIds.Contains(x.FeatureId))
                    .ToList();
                model.HasDeleteFeature = deleteFeatures.Count > 0;
                writer.WriteLine($"删除功能: {model.HasDeleteFeature} (找到 {deleteFeatures.Count} 个)");

                // 导出功能
                var exportFeatureIds = new[] { 
                    enumPrjFeature.ExportToFile_0143,
                    enumPrjFeature.ExportToFile_0196 
                };
                var exportFeatures = objViewInfoENEx.arrViewFeatureFlds.Where(x => 
                    exportFeatureIds.Contains(x.FeatureId)).ToList();
                model.HasExportFeature = exportFeatures.Count > 0;
                writer.WriteLine($"导出功能: {model.HasExportFeature} (找到 {exportFeatures.Count} 个)");

                // 设置字段值功能
                var setFieldFeatures = arrFeatureRegionFlds
                    .Where(x => x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .ToList();

                writer.WriteLine($"设置字段值功能: 找到 {setFieldFeatures.Count} 个");

                foreach (var feature in setFieldFeatures)
                {
                    try
                    {
                        var targetFldId = feature.ReleFldId;
                        writer.WriteLine($"  处理功能: {feature.ButtonName}, ReleFldId: {targetFldId}");

                        if (string.IsNullOrEmpty(targetFldId))
                        {
                            writer.WriteLine($"    警告: ReleFldId 为空");
                            continue;
                        }

                        // 🔥 关键修复：使用与原代码相同的方式获取字段对象
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(targetFldId, feature.PrjId());

                        if (objFieldTab == null)
                        {
                            writer.WriteLine($"    警告: 找不到字段对象");
                            continue;
                        }

                        var fldName = objFieldTab.FldName;
                        
                        // 🔥 从 feature.ObjFieldTabENEx 获取中文名称（Caption）
                        var fldCnName = feature.ObjFieldTabENEx?.Caption ?? objFieldTab.Caption ?? fldName;

                        writer.WriteLine($"    字段名: {fldName}");
                        writer.WriteLine($"    Caption: {fldCnName}");
                        writer.WriteLine($"    功能按钮名: '{feature.ButtonName}'");

                        var relatedTableName = GetRelatedTableName(fldName);

                        // 🔥 确定显示名称（使用 Caption）
                        string displayName;

                        // 如果 Caption 包含中文
                        if (!string.IsNullOrEmpty(fldCnName) && 
                            fldCnName.Any(c => c >= 0x4E00 && c <= 0x9FA5))
                        {
                            displayName = fldCnName;
                            writer.WriteLine($"    → 使用 Caption: '{displayName}'");
                        }
                        // 否则从按钮名推断
                        else if (!string.IsNullOrEmpty(feature.ButtonName) && 
                                 feature.ButtonName.StartsWith("设置"))
                        {
                            var baseName = feature.ButtonName.Substring(2);
                            displayName = fldName.EndsWith("Id") ? baseName + "Id" : baseName;
                            writer.WriteLine($"    → 从按钮名推断: '{displayName}'");
                        }
                        else
                        {
                            displayName = fldName;
                            writer.WriteLine($"    → 使用字段名: '{displayName}'");
                        }

                        var setFieldInfo = new Ai4SetFieldFeature
                        {
                            MethodName = "Set" + fldName,
                            MethodNameCamel = ToCamelCase("set" + fldName),
                            ButtonMethodName = "btnSet" + fldName + "_Click",
                            FieldName = fldName,
                            FieldNameCamel = ToCamelCase(fldName),
                            FieldCnName = displayName,
                            DdlId = "ddl" + fldName,
                            RelatedTableName = relatedTableName
                        };

                        writer.WriteLine($"    ✓ FieldCnName = '{setFieldInfo.FieldCnName}'");
                        writer.WriteLine($"    ✓ 生成方法 = {setFieldInfo.MethodName}");
                        writer.WriteLine($"    ✓ 关联表 = {setFieldInfo.RelatedTableName}");
                        writer.WriteLine();

                        model.SetFieldFeatures.Add(setFieldInfo);
                    }
                    catch (Exception ex)
                    {
                        writer.WriteLine($"    ✗ 错误: {ex.Message}");
                    }
                }

                writer.WriteLine($"最终提取功能数: {model.SetFieldFeatures.Count}");
                writer.WriteLine();
            }
        }

        /// <summary>
        /// 根据字段名推断关联表名
        /// 例如: UseStateId → UseState
        /// </summary>
        private string GetRelatedTableName(string fieldName)
        {
            if (fieldName.EndsWith("Id"))
            {
                return fieldName.Substring(0, fieldName.Length - 2);
            }
            return fieldName;
        }

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