using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using AutoGCLib.Templates;  // ✅ 这个 using 让你可以访问 RenderService.cs 中的类
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
    partial class Vue_ViewScript_EditAiCS_TS4TypeScript : WA_ViewScript_EditCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScript_EditAiCS_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            // 🔥 不调用 base.GeneCode()，而是复制必要的初始化代码

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

            strRe_ClsName = ThisClsName + "_EditAi";

            // 获取功能模块
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(
                objViewInfoENEx.FuncModuleAgcId,
                objViewInfoENEx.PrjId
            );

            // 设置文件名（带模块路径）
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

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
            // ✅ 这里可以直接使用 EditAiTemplateModel
            // 因为已经通过 using AutoGCLib.Templates; 引入了
            var model = new EditAiTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                PrimaryTypeId = objKeyField.PrimaryTypeId,
                ViewId = objViewInfoENEx.ViewId,
                ViewName = objViewInfoENEx.ViewName
            };

            return model;
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}