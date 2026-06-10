using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib.Templates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 EditEx（编辑区扩展类 Ai 版本）的 TypeScript 文件
    /// 使用 Scriban 模板引擎实现代码与模板分离
    /// 继承自 EditAi 基类，提供业务扩展点和统一的按钮事件路由
    /// 用户可以在生成的类中添加自定义逻辑
    /// </summary>
    partial class Vue_ViewScript_EditAiEx_TS4TypeScript : WA_ViewScript_EditCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        // 🔥 TypeScript 注释模式（EditEx 总是使用详细注释）
        public static CommentVerbosity TypeScriptCommentMode { get; set; } = CommentVerbosity.Verbose;

        public Vue_ViewScript_EditAiEx_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
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
            objViewInfoENEx.WebFormName = ThisClsName + "AiEx";
            objViewInfoENEx.WebFormFName = string.Format("{0}AiEx.ts", ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = ThisClsName + "AiEx";
            // 获取功能模块
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(
                objViewInfoENEx.FuncModuleAgcId,
                objViewInfoENEx.PrjId
            );

            // 设置文件名（带模块路径）
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            // 清除模板缓存，确保使用最新的模板文件
            _renderService.ClearCache();

            // 构建模板数据
            var model = BuildEditExTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/EditEx.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderEditExError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染EditEx模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedEditEx_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private EditExTemplateModel BuildEditExTemplateModel()
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);
            clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);

            // 🔥 判断主键字段是否为数值类型
            bool isKeyFieldNumeric = objKeyField.IsNumberType();

            // 🔥 判断是否为复合主键（多关键字段）
            bool isMultiKey = objViewInfoENEx.arrKeyPrjTabFldSet != null && objViewInfoENEx.arrKeyPrjTabFldSet.Count > 1;

            // 🔥 构建关键字段列表
            var keyFields = new List<KeyFieldInfo>();
            if (objViewInfoENEx.arrKeyPrjTabFldSet != null)
            {
                foreach (clsPrjTabFldENEx keyField in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    var objFieldTab = keyField.ObjFieldTabENEx;
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

            var model = new EditExTemplateModel
            {
                // 基础字段
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                IsKeyFieldNumeric = isKeyFieldNumeric,  // 🔥 设置关键字段类型标志
                IsMultiKey = isMultiKey,                // 🔥 设置是否为复合主键
                KeyFields = keyFields,                  // 🔥 设置关键字段列表
                PrimaryTypeId = objKeyField.PrimaryTypeId,
                ViewId = objViewInfoENEx.ViewId,
                ViewName = objViewInfoENEx.ViewName,

                // 🔥 详细注释字段（EditEx 总是使用详细模式）
                GenerateDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                GenerateDateShort = DateTime.Now.ToString("yyyy.MM.dd"),
                ServerName = System.Environment.MachineName,
                DatabaseName = objPrjDataBaseEN?.DataBaseName ?? "未指定",
                DatabaseServer = objPrjDataBaseEN?.IpAddress ?? "未指定",
                PrjDataBaseId = objPrjDataBaseEN?.PrjDataBaseId ?? "",
                PrjId = objViewInfoENEx.PrjId,
                PrjName = objProjectsENEx?.PrjName ?? "未指定",
                CMProjectId = this.CmPrjId,
                CMProjectName = objCMProjectEN?.CmPrjName ?? "未指定",
                FrameworkLayer = $"Vue_编辑区后台AiEx_TS(Vue_ViewScript_EditCSAiEx_TS,{objViewInfoENEx.CodeTypeId})",
                Generator = "AutoGCLib.Vue_ViewScript_EditCSAiEx_TS4TypeScript",

                // 🔥 注释模式（EditEx 总是详细）
                CommentMode = CommentVerbosity.Verbose
            };

            return model;
        }

        /// <summary>
        /// 🔥 判断主键类型是否为数值类型
        /// </summary>
        /// <param name="primaryTypeId">主键类型ID</param>
        /// <returns>true=数值类型, false=字符串类型</returns>
        private bool IsNumericPrimaryType(string primaryTypeId)
        {
            // 数值类型的 PrimaryTypeId 列表
            // 01=自动编号(int/long)
            // 02=字符串自增(但底层是字符串)
            // 03=字符串自增(但底层是字符串)
            // 04=GUID(字符串)
            // 05=时间戳(字符串)
            // 06=字符串自增(但底层是字符串)
            // 07=数值型(long/int)
            
            return primaryTypeId == "01" || primaryTypeId == "07";
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}