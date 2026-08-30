using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib.Templates;
using CodeStruct;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 ExAi 版本的 TypeScript 扩展类文件
    /// 继承自 Ai 基类，实现命令模式和 CRUD 操作
    /// 使用 Scriban 模板引擎实现代码与模板分离
    /// </summary>
    partial class Vue_ViewScriptAiEx_TS4TypeScript : clsGeneCodeBase4View
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptAiEx_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            objViewInfoENEx.WebFormName = ThisClsName + "AiEx"; 
            objViewInfoENEx.WebFormFName = string.Format("{0}AiEx.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, objViewInfoENEx.TabName);
                        
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            //this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            //this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);


            
            var model = BuildExAiTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/ExAi4.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderExAi4Error_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染ExAi4模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedExAi4_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private ExAiTemplateModel BuildExAiTemplateModel()
        {
            var arrViewRegion = clsViewRegionBLEx.GetObjExLstByViewIdCache(this.ViewId, this.PrjId);

            // 🔥 判断列表区域是否需要刷新缓存
            bool needRefreshCache = NeedRefreshCache();
            string strUseCacheModeIdInList = arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002).UseCacheModeId;
            bool isUseCacheInList = strUseCacheModeIdInList == enumUseCacheMode.Inherit_01 ? needRefreshCache :
                (strUseCacheModeIdInList == enumUseCacheMode.Use_02 ? true : false);

            // 🔥 判断是否有字段映射函数（IsUseFunc）
            bool isUseFunc = this.IsUseFunc;
            // 🔥 判断关键字类型
            bool isNumeric = objKeyField.IsNumberType();
            string initValue = isNumeric ? "0" : "''";
            
            // 🔥 判断是否为多关键字
            bool isMultiKey = PrjTabEx_ListRegion?.arrKeyFldSet?.Count > 1;

            var model = new ExAiTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                UseCacheMode = needRefreshCache,
                UseCacheModeInList = isUseCacheInList,
                UseCacheModeIdInList = strUseCacheModeIdInList,
                SortClassifyLst4View = thisSortClassifyLst4View,
                IsKeyFieldNumeric = isNumeric,
                KeyFieldInitValue = initValue,
                IsUseFunc = isUseFunc,
                IsMultiKey = isMultiKey,
                strIsShare = objViewInfoENEx.IsShare ? "Share" : "",
                // 🔥 设置绑定函数名称
                BindGvFuncName = GetBindGvFuncName(),
                
                // 🔥 检查是否有 CRUD 功能
                HasQueryFeature = HasFeature(enumPrjFeature.Query_0139),
                HasCreateFeature = HasFeature(enumPrjFeature.AddNewRecord_0136) || HasFeature(enumPrjFeature.AddNewRecordWithMaxId_0183),
                HasDetailFeature = HasFeature(enumPrjFeature.DetailRecord_0239) || HasFeature(enumPrjFeature.DetailRecord_Gv_0181),
                HasUpdateFeature = HasFeature(enumPrjFeature.UpdateRecord_0137) || HasFeature(enumPrjFeature.UpdateRecord_0199),
                HasDeleteFeature = HasFeature(enumPrjFeature.DelRecord_0138) || HasFeature(enumPrjFeature.DelRecord_0184),
                HasExportFeature = HasFeature(enumPrjFeature.ExportToFile_0143) || HasFeature(enumPrjFeature.ExportToFile_0196),
                HasCopyFeature = HasFeature(enumPrjFeature.CopyRecord_0141) || HasFeature(enumPrjFeature.CopyRecord_0198),
                HasAdjustOrderNum = HasFeature(enumPrjFeature.AdjustOrderNum_0142) 
                || HasFeature(enumPrjFeature.AdjustOrderNum_0224) 
                || HasFeature(enumPrjFeature.AdjustOrderNum_0225)
                || HasFeature(enumPrjFeature.AdjustOrderNum_1196),

            };

            // 🔥 提取所有关键字字段信息
            if (isMultiKey && PrjTabEx_ListRegion?.arrKeyFldSet != null)
            {
                foreach (var keyFld in PrjTabEx_ListRegion.arrKeyFldSet)
                {
                    var objFieldTab = keyFld.ObjFieldTab0();
                    var isFieldNumeric = objFieldTab.IsNumberType();
                    var fieldInitValue = isFieldNumeric ? "0" : "''";
                    
                    model.KeyFields.Add(new KeyFieldInfo
                    {
                        FieldName = objFieldTab.FldName,
                        FieldNameCamel = ToCamelCase(objFieldTab.FldName),
                        PropertyName = objFieldTab.PropertyName(this.IsFstLcase),
                        IsNumber = isFieldNumeric,
                        TypeScriptType = objFieldTab.TypeScriptType(),
                        InitValue = fieldInitValue
                    });
                }
            }

            // 提取排序字段
            ExtractSortColumns(model);

            // 提取命令映射
            ExtractCommandMappings(model);

            return model;
        }

        /// <summary>
        /// 🔥 判断列表区域是否需要刷新缓存
        /// 只有当缓存模式为 localStorage(03) 或 sessionStorage(04) 时才需要刷新缓存
        /// </summary>
        private bool NeedRefreshCache()
        {
            try
            {
                // 从列表区域获取表信息
                if (PrjTabEx_ListRegion == null)
                {
                    return false;
                }

                string cacheModeId = PrjTabEx_ListRegion.CacheModeId;
                
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
        /// 提取排序字段信息
        /// </summary>
        private void ExtractSortColumns(ExAiTemplateModel model)
        {
            if (objViewInfoENEx.arrListRegionFldSet == null) return;

            foreach (var field in objViewInfoENEx.arrListRegionFldSet.OrderBy(x => x.SeqNum))
            {
                // 只处理扩展字段（关联表字段）
                if (string.IsNullOrEmpty(field.OutFldId) || field.OutFldId == "0") 
                    continue;

                string strOutFldName = clsString.FstLcaseS(field.OutFldName());
                string columnKey = $"{clsString.FirstLcaseS(strOutFldName)}|Ex";
                
                var sortColumn = new ExAiSortColumn
                {
                    ColumnKey = columnKey,
                    SortExpression = GetSortExpression(field)
                };

                model.SortColumns.Add(sortColumn);
            }
        }

        /// <summary>
        /// 获取排序表达式
        /// </summary>
        private string GetSortExpression(clsDGRegionFldsENEx field)
        {
            string strOutFldName = clsString.FstLcaseS(field.OutFldName());
            
            // 获取关联表信息
            string strRelaTabId = clsDnPathBLEx.GetLeftJoinTabIdByDnPathId(
                field.TabId(),
                field.DnPathId(),
                field.PrjId
            );

            List<(string, string)> arrOnCondition = clsDnPathBLEx.GetOnConditionByDnPathId(
                field.DnPathId(),
                field.PrjId
            );

            // 如果有关联条件，生成复杂排序表达式
            if (arrOnCondition != null && arrOnCondition.Count > 0 && !string.IsNullOrEmpty(strRelaTabId))
            {
                StringBuilder sortExpr = new StringBuilder();
                sortExpr.Append($"`{strOutFldName} ${{sortDirection}}|");
                
                foreach (var condition in arrOnCondition)
                {
                    sortExpr.Append($"({condition.Item1}){condition.Item2}|");
                }
                
                sortExpr.Append("`");
                return sortExpr.ToString();
            }
            else
            {
                // 简单排序表达式
                return "Format('{0} {1}', sortColumnKey, sortDirection)";
            }
        }

        /// <summary>
        /// 获取绑定列表的函数名称
        /// 根据是否使用Func转换、是否使用缓存来确定函数名
        /// 优先级：Func转换(4Func) > 缓存模式(Cache) > 默认(无后缀)
        /// </summary>
        private string GetBindGvFuncName()
        {
            string strSuffix = "";
            string strFuncName = "";
            
            // 🔥 第一优先：判断缓存模式
            if (PrjTabEx_ListRegion.IsUseCache_TS())
            {
                strSuffix = "Cache";
            }
            
            // 🔥 第二优先：判断是否使用Func转换（会覆盖Cache）
            if (this.IsUseFunc)
            {
                strSuffix = "4Func";
            }
            
            // 组装函数名称
            strFuncName = $"this.BindGv_{TabName_Out4ListRegion4GC}{strSuffix}";
            
            return strFuncName;
        }

        /// <summary>
        /// 提取命令映射
        /// </summary>
        private void ExtractCommandMappings(ExAiTemplateModel model)
        {
            var arrFeatureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true)
                .ToList();

            foreach (var feature in arrFeatureRegionFlds)
            {
                // 只添加 SetFieldValue 功能的命令映射
                if (feature.FeatureId == enumPrjFeature.SetFieldValue_0148)
                {
                    var commandId = GetCommandId(feature);
                    var methodName = GetMethodName(feature);  // 🔥 新增：获取方法名

                    var mapping = new ExAiCommandMapping
                    {
                        CommandName = GetCommandName(feature),  // SetUseStateId / SetFuncModuleId
                        CommandId = commandId,                   // setUseState / setFuncModule
                        FeatureId = feature.FeatureId,
                        MethodName = methodName                  // 🔥 SetUseStateId / SetFuncModuleId
                    };
                    model.CommandMappings.Add(mapping);
                }
            }
        }

        /// <summary>
        /// 获取命令ID（驼峰式）
        /// </summary>
        private string GetCommandId(clsFeatureRegionFldsENEx feature)
        {
            if (feature.FeatureId == enumPrjFeature.SetFieldValue_0148)
            {
                if (!string.IsNullOrEmpty(feature.ReleFldId))
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                    if (objFieldTab != null)
                    {
                        string fieldName = objFieldTab.FldName;
                        string commandId = "set" + RemoveIdSuffix(fieldName);
                        return ToCamelCase(commandId);  // setUseState
                    }
                }
            }
            
            return "setField";
        }

        /// <summary>
        /// 获取命令名称（用于 btn_Click 的 case）
        /// </summary>
        private string GetCommandName(clsFeatureRegionFldsENEx feature)
        {
            // 从关联字段获取方法名
            if (!string.IsNullOrEmpty(feature.ReleFldId))
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                if (objFieldTab != null)
                {
                    return "Set" + objFieldTab.FldName;  // SetUseStateId
                }
            }
            
            return "SetField";
        }

        /// <summary>
        /// 获取方法名（用于调用基类方法）
        /// </summary>
        private string GetMethodName(clsFeatureRegionFldsENEx feature)
        {
            return GetCommandName(feature);
        }

        /// <summary>
        /// 移除字段名的 Id 后缀
        /// 例如："UseStateId" → "UseState"
        /// </summary>
        private string RemoveIdSuffix(string fieldName)
        {
            if (string.IsNullOrEmpty(fieldName)) 
                return fieldName;
                
            if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase) && fieldName.Length > 2)
            {
                return fieldName.Substring(0, fieldName.Length - 2);
            }
            
            return fieldName;
        }

        /// <summary>
        /// 转换为驼峰命名
        /// </summary>
        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCSEx_TS4TypeScript));
            
        }
    }
}