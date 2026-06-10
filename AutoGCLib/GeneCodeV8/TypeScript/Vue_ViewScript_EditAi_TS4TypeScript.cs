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
    /// 生成 EditAi（编辑区 Ai 版本）的 TypeScript 基类文件
    /// 使用 Scriban 模板引擎实现代码与模板分离
    /// 包含增删改查的完整逻辑
    /// </summary>
    partial class Vue_ViewScript_EditAi_TS4TypeScript : WA_ViewScript_EditCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        // 🔥 TypeScript 注释模式静态配置
        // Compact: 精简注释（默认，生产代码）
        // Verbose: 详细注释（包含 AutoGCLib 标记、操作步骤等）
        public static CommentVerbosity TypeScriptCommentMode { get; set; } = CommentVerbosity.Compact;

        public Vue_ViewScript_EditAi_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            // 检查编辑区域是否存在
            if (objViewInfoENEx.objViewRegion_Edit == null ||
                objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }

            // 检查编辑区域字段
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null ||
                objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new Exception(sbMessage.ToString());
            }

            // 设置类名和文件名
            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = ThisClsName + "Ai";

            // 获取功能模块
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(
                objViewInfoENEx.FuncModuleAgcId,
                objViewInfoENEx.PrjId
            );

            // 设置文件名（带模块路径）
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            // 🔥 清除模板缓存，确保使用最新的模板文件
            _renderService.ClearCache();

            // 构建模板数据
            var model = BuildEditAiTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/EditAi.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderEditAiError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染EditAi模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedEditAi_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private EditAiTemplateModel BuildEditAiTemplateModel()
        {
            // 🔥 获取数据类型信息
            string dataTypePrefix = objKeyField.ObjFieldTabENEx?.objDataTypeAbbrEN?.DataTypeAbbr ?? "str";
            string tsType = objKeyField.TypeScriptType;
            bool isNumeric = objKeyField.IsNumberType();
            string initValue = isNumeric ? "0" : "''";
            string primaryTypeId = objKeyField.PrimaryTypeId;
            
            // 🔥 判断是否需要 WithReturnKey/WithMaxId 方法（PrimaryTypeId 为 '02', '03', '06'）
            bool needReturnKeyMethod = (primaryTypeId == "02" || primaryTypeId == "03" || primaryTypeId == "06");
            
            // 🔥 判断是否为字符串自增（只有字符串才需要 GetMaxStrIdAsync 和 AddNewRecordWithMaxIdAsync）
            bool isStringAutoIncrement = !isNumeric && needReturnKeyMethod;

            // 🔥 判断是否需要刷新缓存（只有 localStorage(03) 和 sessionStorage(04) 需要）
            bool needRefreshCache = NeedRefreshCache();
            
            // 🔥 判断是否为多关键字段（联合主键）
            bool isMultiKey = PrjTabEx_EditRegion?.arrKeyFldSet?.Count > 1;
            
            // 🔥 判断是否需要检查关键字存在性
            // 只有以下情况需要检查：
            // 1. 单关键字段（非联合主键）
            // 2. 非 Identity（02）
            // 3. 非字符串自增（03, 06）
            bool needCheckKeyExist = !isMultiKey && 
                                      primaryTypeId != "02" && 
                                      primaryTypeId != "03" && 
                                      primaryTypeId != "06";
            
            // 🔥 构建关键字段列表（用于循环生成多个 Set 方法调用）
            var keyFields = new List<KeyFieldInfo>();
            if (PrjTabEx_EditRegion?.arrKeyFldSet != null)
            {
                foreach (var keyFld in PrjTabEx_EditRegion.arrKeyFldSet)
                {
                    var objFieldTab = keyFld.ObjFieldTab0();
                    var isFieldNumeric = objFieldTab.IsNumberType();
                    var fieldInitValue = isFieldNumeric ? "0" : "''";
                    
                    keyFields.Add(new KeyFieldInfo
                    {
                        FieldName = objFieldTab.FldName,
                        FieldNameCamel = ToCamelCase(objFieldTab.FldName),
                        PropertyName = objFieldTab.PropertyName(this.IsFstLcase),
                        IsNumeric = isFieldNumeric,
                        TypeScriptType = objFieldTab.TypeScriptType(),
                        InitValue = fieldInitValue
                    });
                }
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
            
            var model = new EditAiTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                KeyFieldWithPrefix = ToCamelCase(objKeyField.PrivFuncName),
                KeyFieldTypeScript = tsType,
                KeyFieldPrefixOnly = dataTypePrefix,
                KeyFieldInitValue = initValue,
                IsKeyFieldNumeric = isNumeric,
                IsMultiKey = isMultiKey,
                strIsShare = objViewInfoENEx.IsShare ? "Share" : "",
                KeyFields = keyFields,
                NeedCheckKeyExist = needCheckKeyExist,
                NeedReturnKeyMethod = needReturnKeyMethod,
                IsStringAutoIncrement = isStringAutoIncrement,
                ReturnKeyMethodReturnType = tsType,
                NeedRefreshCache = needRefreshCache,
                HasCacheClassifyField = hasCacheClassifyField,
                CacheClassifyFieldName = cacheClassifyFieldName,
                CacheClassifyFieldCamel = cacheClassifyFieldCamel,
                PrimaryTypeId = primaryTypeId,
                ViewId = objViewInfoENEx.ViewId,
                ViewName = objViewInfoENEx.ViewName,
                CommentMode = TypeScriptCommentMode
            };
            
            // 🔥 仅在 Verbose 模式下填充详细字段
            if (TypeScriptCommentMode == CommentVerbosity.Verbose)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);
                model.GenerateDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                model.GenerateDateShort = DateTime.Now.ToString("yyyy.MM.dd");
                model.ServerName = System.Environment.MachineName;
                model.DatabaseName = objPrjDataBaseEN?.DataBaseName ?? "未指定";
                model.PrjDataBaseId = objPrjDataBaseEN?.PrjDataBaseId ?? "";
                model.PrjId = objViewInfoENEx.PrjId;
                model.FrameworkLayer = "前端视图层(ViewScript/TypeScript)";
                model.Generator = "AutoGCLib GeneCodeV8 TypeScript";
            }

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
                // 从编辑区域获取表信息
                if (PrjTabEx_EditRegion == null)
                {
                    return false;
                }

                string cacheModeId = PrjTabEx_EditRegion.CacheModeId;
                
                // 03=localStorage, 04=sessionStorage
                return cacheModeId == "03" || cacheModeId == "04";
            }
            catch
            {
                // 如果获取失败，默认不生成刷新缓存代码
                return false;
            }
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}