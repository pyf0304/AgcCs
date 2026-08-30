using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib.Templates;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 DetailEx 扩展类的 TypeScript 文件
    /// 继承自 DetailAi 基类，实现详细信息显示功能
    /// 使用 Scriban 模板引擎实现代码与模板分离
    /// </summary>
    partial class Vue_ViewScript_DetailAiEx_TS4TypeScript : WA_ViewScript_DetailCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        // 🔥 TypeScript 注释模式静态配置
        // Compact: 精简注释（默认，生产代码）
        // Verbose: 详细注释（包含 AutoGCLib 标记、操作步骤等）
        public static CommentVerbosity TypeScriptCommentMode { get; set; } = CommentVerbosity.Compact;

        public Vue_ViewScript_DetailAiEx_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            // 检查详细信息区域是否存在
            if (objViewInfoENEx.objViewRegion_Detail == null ||
                objViewInfoENEx.objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }

            // 设置类名和文件名
            objViewInfoENEx.WebFormName = ThisClsName ;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = ThisClsName ;

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
            var model = BuildDetailExTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/DetailEx.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderDetailExError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染DetailEx模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedDetailEx_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        /// <summary>
        /// 构建 DetailEx 模板数据模型
        /// </summary>
        private DetailExTemplateModel BuildDetailExTemplateModel()
        {
            // 🔥 获取关键字字段信息
            var keyFields = PrjTabEx_DetailRegion?.arrPrjTabFldENExObjLst
                .Where(f => f.FieldTypeId == "02") // FieldTypeId='02' 表示关键字段
                .ToList();

            bool isMultiKey = keyFields.Count > 1;
            bool isUseFunc = this.IsUseFunc4Detail;
            var model = new DetailExTemplateModel
            {
                TableName = TabName_Out4DetailRegion,
                TableId = TabId_Out4DetailRegion,
                TableCnName = TabCnName_Out4Detail,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                ViewId = objViewInfoENEx.ViewId,
                ViewName = objViewInfoENEx.ViewName,
                IsMultiKey = isMultiKey,
                IsUseFunc4Detail = isUseFunc,
                CommentMode = TypeScriptCommentMode
            };

            // 🔥 仅在 Verbose 模式下填充详细字段
            if (TypeScriptCommentMode == CommentVerbosity.Verbose)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId);
                clsCMProjectEN objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(CmPrjId);

                model.GenerateDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                model.GenerateDateShort = DateTime.Now.ToString("yyyy.MM.dd");
                model.ServerName = System.Environment.MachineName;
                model.DatabaseServer = objPrjDataBaseEN?.DatabaseOwner ?? "未指定";
                model.DatabaseName = objPrjDataBaseEN?.DataBaseName ?? "未指定";
                model.PrjDataBaseId = objPrjDataBaseEN?.PrjDataBaseId ?? "";
                model.PrjId = objProject?.PrjId ?? "";
                model.PrjName = objProject?.PrjName ?? "";
                model.CMProjectId = objCMProject?.CmPrjId ?? "";
                model.CMProjectName = objCMProject?.CmPrjName ?? "";
                model.FrameworkLayer = "Vue_详细信息Ex_TS(Vue_ViewScript_DetailEx_TS,0261)";
                model.Generator = "AutoGCLib.Vue_ViewScript_DetailEx_TS4TypeScript";
            }

            return model;
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
        public override void GetClsName()
        {

            string strClassName = string.Format("WA_{0}_DetailAiEx", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = string.Format("{0}AiEx", strClassName); ;

            this.BaseClsName = string.Format("{0}Ai", strClassName);
            objViewInfoENEx.ClsName = this.ClsName;
        }

    }
}