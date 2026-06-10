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
    /// 生成 Ai 版本的基类 TypeScript 文件
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
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            var model = BuildAiBaseTemplateModel();

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

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderAiBaseError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染Ai基类模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedAiBase_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private AiBaseTemplateModel BuildAiBaseTemplateModel()
        {
            // 🔥 从导出区域字段中选择前两个字段用于排序示例（参考原生成器逻辑）
            var (sortField1, sortField1Info, sortField2, sortField2Info, availableFields) = GetSortFieldsFromExportRegion();

            // 🔥 判断是否需要刷新缓存（只有 localStorage(03) 和 sessionStorage(04) 需要）
            bool needRefreshCache = NeedRefreshCache();
            
            // 🔥 判断是否有字段映射函数（IsUseFunc）
            bool isUseFunc = this.IsUseFunc;
            
            // 🔥 新增：判断是否为多关键字
            bool isMultiKey = objPrjTabEx_ListRegion?.arrKeyFldSet?.Count > 1;
            string strKeyTypeName="";
            if (isMultiKey == false)
            {
                strKeyTypeName = PrjTabEx_ListRegion.arrKeyFieldType[0].KeyType.ToString();
            }

            // 🔥 获取缓存分类字段信息
            bool hasCacheClassifyField = false;
            string cacheClassifyFieldName = "";
            string cacheClassifyFieldCamel = "";

            if (needRefreshCache && thisCacheClassify_List_TS != null)
            {
                if (thisCacheClassify_List_TS.IsHasCacheClassfyFld)
                {
                    hasCacheClassifyField = true;
                    cacheClassifyFieldName = thisCacheClassify_List_TS.FldName;
                    cacheClassifyFieldCamel = ToCamelCase(thisCacheClassify_List_TS.FldName);
                }
            }
            List<string> condVarLst = new List<string>();
            List<string> importVarLst = new List<string>();
            condVarLst = thisCacheClassifyLst4View.Select(x => x.CondVarName).ToList();
            condVarLst = condVarLst.Where(x => x != "").ToList();
            importVarLst = thisCacheClassifyLst4View.Select(x => x.ImportVarName).ToList();
            importVarLst = importVarLst.Where(x => x != "").ToList();
            string strCacheCondVars = string.Join(", ", condVarLst);
            string strCacheImportVars = string.Join(", ", importVarLst);
            bool hasCacheCondVar = condVarLst.Count>0?true:false;
            bool hasCacheImportVar = importVarLst.Count > 0 ? true : false;
            string strCacheCondVars4Fst = strCacheCondVars;
            if (condVarLst.Count>0) { 
                strCacheCondVars = ", " + strCacheCondVars;
            }
            if (importVarLst.Count > 0)
            {
                strCacheImportVars = ", " + strCacheImportVars;
            }

            var model = new AiBaseTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableNameUpper = ConvertToSnakeCase(TabName_Out4ListRegion4GC).ToUpper(),
                TableCnName = objPrjTabEx_ListRegion.TabCnName,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                HasCacheMode = needRefreshCache,
                HasCacheClassifyField = hasCacheClassifyField,
                CacheClassifyFieldName = cacheClassifyFieldName,
                CacheClassifyFieldCamel = cacheClassifyFieldCamel,
                IsUseFunc = isUseFunc,
                IsMultiKey = isMultiKey,  // 🔥 新增：是否为多关键字
                strIsShare = objViewInfoENEx.IsShare ? "Share" : "",
                // 🔥 排序字段
                SortField1 = sortField1,
                SortField1Type = sortField1Info?.TypeScriptType ?? "any",
                SortField1CompareExpr = sortField1Info?.CompareExpression ?? "String(a.field).localeCompare(String(b.field))",
                SortField2 = sortField2,
                SortField2Type = sortField2Info?.TypeScriptType ?? "any",
                SortField2CompareExpr = sortField2Info?.CompareExpression ?? "String(a.field).localeCompare(String(b.field))",
                AvailableFields = availableFields,
                CacheCondVarLst = condVarLst,
                CacheImportVarLst = importVarLst,
                CacheImportVars = strCacheImportVars,
                CacheCondVars = strCacheCondVars,
                CacheCondVars4Fst = strCacheCondVars4Fst,
                HasCacheCondVar = hasCacheCondVar,
                HasCacheImportVar = hasCacheImportVar,
                KeyTypeName = strKeyTypeName
            };

            // 提取功能按钮
            ExtractFeatures(model);

            return model;
        }

        /// <summary>
        /// 🔥 判断是否需要刷新缓存
        /// 只有当缓存模式为 localStorage(03) 或 sessionStorage(04) 时才需要刷新缓存
        /// </summary>
        private bool NeedRefreshCache()
        {
            try
            {
                // 从列表区域获取表信息
                if (objPrjTabEx_ListRegion == null)
                {
                    return false;
                }

                string cacheModeId = objPrjTabEx_ListRegion.CacheModeId;
                
                // 03=localStorage, 04=sessionStorage
                return cacheModeId == "03" || cacheModeId == "04";
            }
            catch
            {
                // 如果获取失败，默认不使用缓存
                return false;
            }
        }

        /// <summary>
        /// 从导出区域字段中选择前两个字段用于排序示例
        /// 参考原生成器 Gen_WApi_Ts_SortFunExportExcel 的逻辑
        /// </summary>
        private (string field1, FieldSortInfo info1, string field2, FieldSortInfo info2, List<FieldInfo> allFields) GetSortFieldsFromExportRegion()
        {
            var availableFields = new List<FieldInfo>();
            clsFieldTabEN objField_1 = null;
            clsFieldTabEN objField_2 = null;

            // 🔥 检查导出区域是否存在
            if (objViewInfoENEx.objViewRegion_ExportExcel == null)
            {
                // 如果没有导出区域，使用主键作为默认值
                string keyFieldName = objKeyField.FldName();
                var keyInfo = CreateFieldSortInfo(objKeyField);
                return (keyFieldName, keyInfo, keyFieldName, keyInfo, new List<FieldInfo>());
            }

            // 🔥 从导出区域的表中获取字段列表（参考原逻辑）
            List<clsFieldTabEN> arrFieldTab = clsFieldTabBLEx.GetObjLstByTabIdCache(TabId_Out4ExportExcel, objViewInfoENEx.PrjId);

            // 🔥 选择前两个非扩展类字段（参考原逻辑）
            foreach (var objInFor in arrFieldTab)
            {
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(
                    TabId_Out4ExportExcel, 
                    objInFor.FldId, 
                    objInFor.PrjId
                );
                
                // 跳过扩展类字段
                if (objPrjTabFld?.IsForExtendClass == true) continue;

                // 收集所有可用字段信息
                string csType = objInFor.CsType();
                string tsType = CsTypeToTypeScriptType(csType);
                availableFields.Add(new FieldInfo
                {
                    FieldName = objInFor.PropertyName(this.IsFstLcase),
                    CSharpType = csType,
                    TypeScriptType = tsType
                });

                // 选择前两个字段
                if (objField_1 == null)
                {
                    objField_1 = objInFor;
                }
                else if (objField_2 == null)
                {
                    objField_2 = objInFor;
                    break;
                }
            }

            // 如果没有找到足够的字段，使用主键
            if (objField_1 == null || objField_2 == null)
            {
                string keyFieldName = objKeyField.FldName();
                var keyInfo = CreateFieldSortInfo(objKeyField);
                return (keyFieldName, keyInfo, keyFieldName, keyInfo, availableFields);
            }

            // 🔥 创建字段排序信息
            string field1Name = objField_1.PropertyName(this.IsFstLcase);
            string field2Name = objField_2.PropertyName(this.IsFstLcase);
            
            var field1Info = CreateFieldSortInfo(objField_1);
            var field2Info = CreateFieldSortInfo(objField_2);

            return (field1Name, field1Info, field2Name, field2Info, availableFields);
        }

        /// <summary>
        /// 创建字段排序信息（包含比较表达式）
        /// 参考原生成器的逻辑：根据字段类型生成不同的比较表达式
        /// </summary>
        private FieldSortInfo CreateFieldSortInfo(clsFieldTabEN objField)
        {
            string fieldName = objField.PropertyName(this.IsFstLcase);
            string csType = objField.CsType();
            string tsType = CsTypeToTypeScriptType(csType);
            string compareExpr;

            // 🔥 根据字段类型生成比较表达式（参考原逻辑）
            if (objField.IsNumberType())
            {
                // 数字类型：使用减法
                compareExpr = $"a.{fieldName} - b.{fieldName}";
            }
            else if (objField.IsBoolType())
            {
                // 布尔类型：true 在前
                compareExpr = $"a.{fieldName} ? -1 : 1";
            }
            else
            {
                // 字符串类型：使用 localeCompare
                compareExpr = $"a.{fieldName}.localeCompare(b.{fieldName})";
            }

            return new FieldSortInfo
            {
                FieldName = fieldName,
                TypeScriptType = tsType,
                CSharpType = csType,
                CompareExpression = compareExpr
            };
        }

        /// <summary>
        /// 创建字段排序信息（重载：支持 clsPrjTabFldENEx）
        /// </summary>
        private FieldSortInfo CreateFieldSortInfo(clsPrjTabFldENEx objField)
        {
            var objFieldTab = objField.ObjFieldTabENEx;
            if (objFieldTab == null)
            {
                objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objField.FldId, objField.PrjId);
            }
            return CreateFieldSortInfo(objFieldTab);
        }

        /// <summary>
        /// 将 C# 类型转换为 TypeScript 类型
        /// </summary>
        private string CsTypeToTypeScriptType(string csType)
        {
            switch (csType.ToLower())
            {
                case "string":
                    return "string";
                case "int":
                case "long":
                case "short":
                case "byte":
                case "decimal":
                case "double":
                case "float":
                    return "number";
                case "bool":
                case "boolean":
                    return "boolean";
                case "datetime":
                    return "string";
                default:
                    return "any";
            }
        }

        private void ExtractFeatures(AiBaseTemplateModel model)
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

                // 删除功能（支持多个功能ID - 功能区按钮）
                var deleteFeatureIds = new[] { 
                    enumPrjFeature.DelRecord_0138, 
                    enumPrjFeature.DelRecord_0184 
                };
                var deleteFeatures = arrFeatureRegionFlds
                    .Where(x => deleteFeatureIds.Contains(x.FeatureId))
                    .ToList();
                model.HasDeleteFeature = deleteFeatures.Count > 0;
                writer.WriteLine($"删除功能: {model.HasDeleteFeature} (找到 {deleteFeatures.Count} 个)");

                // 🔥 新增：表格内删除功能（Gv按钮）
                var deleteInTabFeatureIds = new[] { 
                    enumPrjFeature.DelRecord_Gv_0175 
                };
                var deleteInTabFeatures = arrFeatureRegionFlds
                    .Where(x => deleteInTabFeatureIds.Contains(x.FeatureId))
                    .ToList();
                model.HasDeleteInTabFeature = deleteInTabFeatures.Count > 0;
                writer.WriteLine($"表格内删除功能: {model.HasDeleteInTabFeature} (找到 {deleteInTabFeatures.Count} 个)");

                // 🔥 新增：表格内选择功能（Gv按钮）
                var selectInTabFeatureIds = new[] { 
                    enumPrjFeature.SelectRecord_Gv_0182 
                };
                var selectInTabFeatures = arrFeatureRegionFlds
                    .Where(x => selectInTabFeatureIds.Contains(x.FeatureId))
                    .ToList();
                model.HasSelectInTabFeature = selectInTabFeatures.Count > 0;
                writer.WriteLine($"表格内选择功能: {model.HasSelectInTabFeature} (找到 {selectInTabFeatures.Count} 个)");

                // 🔥 新增：复制记录功能
                var copyFeatureIds = new[] { 
                    enumPrjFeature.CopyRecord_0141,
                    enumPrjFeature.CopyRecord_0198 
                };
                var copyFeatures = arrFeatureRegionFlds
                    .Where(x => copyFeatureIds.Contains(x.FeatureId))
                    .ToList();
                model.HasCopyFeature = copyFeatures.Count > 0;
                writer.WriteLine($"复制功能: {model.HasCopyFeature} (找到 {copyFeatures.Count} 个)");

                // 导出功能
                var exportFeatureIds = new[] { 
                    enumPrjFeature.ExportToFile_0143,
                    enumPrjFeature.ExportToFile_0196 
                };
                var exportFeatures = objViewInfoENEx.arrFeatureRegionFlds.Where(x => 
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

                        // 🔥 新增：获取字段的 C# 类型并转换为 TypeScript 类型
                        string csType = objFieldTab.CsType();
                        string tsType = CsTypeToTypeScriptType(csType);
                        
                        // 🔥 新增：根据类型确定参数前缀和验证需求
                        string paramPrefix;
                        bool needsValidation;
                        
                        if (csType.ToLower() == "bool" || csType.ToLower() == "boolean")
                        {
                            paramPrefix = "bol";
                            needsValidation = false;  // 布尔类型不需要空值验证
                        }
                        else if (objFieldTab.IsNumberType())
                        {
                            paramPrefix = "num";
                            needsValidation = true;
                        }
                        else
                        {
                            paramPrefix = "str";
                            needsValidation = true;
                        }

                        writer.WriteLine($"    字段名: {fldName}");
                        writer.WriteLine($"    C# 类型: {csType}");
                        writer.WriteLine($"    TypeScript 类型: {tsType}");
                        writer.WriteLine($"    参数前缀: {paramPrefix}");
                        writer.WriteLine($"    需要验证: {needsValidation}");
                        writer.WriteLine($"    Caption: {fldCnName}");
                        writer.WriteLine($"    功能按钮名: '{feature.ButtonName}'");

                        var relatedTableName = GetRelatedTableName(fldName);
                        
                        // 🔥 查询关联表所属的模块名
                        string relatedModuleName = GetModuleNameForTable(relatedTableName, feature.PrjId());

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

                        var setFieldInfo = new AiSetFieldFeature
                        {
                            MethodName = "Set" + fldName,
                            MethodNameCamel = ToCamelCase("set" + fldName),
                            ButtonMethodName = "btnSet" + fldName + "_Click",
                            FieldName = fldName,
                            FieldNameCamel = ToCamelCase(fldName),
                            FieldCnName = displayName,
                            DdlId = "ddl" + fldName,
                            RelatedTableName = relatedTableName,
                            RelatedModuleName = relatedModuleName,
                            FieldTypeScript = tsType,        // 🔥 新增
                            ParamPrefix = paramPrefix,        // 🔥 新增
                            NeedsValidation = needsValidation // 🔥 新增
                        };

                        writer.WriteLine($"    ✓ FieldCnName = '{setFieldInfo.FieldCnName}'");
                        writer.WriteLine($"    ✓ 生成方法 = {setFieldInfo.MethodName}");
                        writer.WriteLine($"    ✓ 关联表 = {setFieldInfo.RelatedTableName}");
                        writer.WriteLine($"    ✓ 关联模块 = {setFieldInfo.RelatedModuleName}");
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

        /// <summary>
        /// 根据表名查询其所属的功能模块英文名
        /// </summary>
        private string GetModuleNameForTable(string tableName, string prjId)
        {
            try
            {
                // 通过表名查找项目表信息
                var objPrjTab = clsPrjTabBLEx.GetObjByTabNameAndPrjId(tableName, prjId);
                
                if (objPrjTab == null)
                {
                    // 如果找不到，默认返回 SysPara（兼容旧逻辑）
                    return "SysPara";
                }

                // 获取功能模块信息
                var objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(
                    objPrjTab.FuncModuleAgcId,
                    prjId
                );

                if (objFuncModule != null && !string.IsNullOrEmpty(objFuncModule.FuncModuleEnName))
                {
                    return objFuncModule.FuncModuleEnName;
                }

                // 如果模块名为空，返回默认值
                return "SysPara";
            }
            catch
            {
                // 出错时返回默认值
                return "SysPara";
            }
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