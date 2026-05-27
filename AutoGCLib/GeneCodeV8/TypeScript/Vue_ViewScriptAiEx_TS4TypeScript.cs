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
    /// 生成 ExAi4 版本的 TypeScript 扩展类文件
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


            
            var model = BuildExAi4TemplateModel();

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

        private ExAi4TemplateModel BuildExAi4TemplateModel()
        {
            // 🔥 判断列表区域是否需要刷新缓存
            bool needRefreshCache = NeedRefreshCache();
            
            // 🔥 判断关键字类型
            bool isNumeric = objKeyField.IsNumberType();
            string initValue = isNumeric ? "0" : "''";

            var model = new ExAi4TemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                HasCacheMode = needRefreshCache,
                IsKeyFieldNumeric = isNumeric,
                KeyFieldInitValue = initValue,
                
                // 🔥 NEW: 设置绑定函数名称
                BindGvFuncName = GetBindGvFuncName()
            };

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
        private void ExtractSortColumns(ExAi4TemplateModel model)
        {
            if (objViewInfoENEx.arrListRegionFldSet == null) return;

            foreach (var field in objViewInfoENEx.arrListRegionFldSet.OrderBy(x => x.SeqNum))
            {
                // 只处理扩展字段（关联表字段）
                if (string.IsNullOrEmpty(field.OutFldId) || field.OutFldId == "0") 
                    continue;

                string strOutFldName = clsString.FstLcaseS(field.OutFldName());
                string columnKey = $"{clsString.FirstLcaseS(strOutFldName)}|Ex";
                
                var sortColumn = new ExAi4SortColumn
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
        /// </summary>
        private string GetBindGvFuncName()
        {
            string strFuncName = "";
            
            if (PrjTabEx_ListRegion.IsUseCache_TS())
            {
                strFuncName = $"this.BindGv_{TabName_Out4ListRegion4GC}Cache";
            }
            else
            {
                if (this.IsUseFunc)
                {
                    strFuncName = $"this.BindGv_{TabName_Out4ListRegion4GC}4Func";
                }
                else
                {
                    strFuncName = $"this.BindGv_{TabName_Out4ListRegion4GC}";
                }
            }
            
            return strFuncName;
        }

        /// <summary>
        /// 提取命令映射
        /// </summary>
        private void ExtractCommandMappings(ExAi4TemplateModel model)
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

                    var mapping = new ExAi4CommandMapping
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCSEx_TS4TypeScript));
            
        }
    }
}