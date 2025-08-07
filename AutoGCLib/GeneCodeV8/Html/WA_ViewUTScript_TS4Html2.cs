using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.PureClass;
using AGC.PureClassEx;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    partial class WA_ViewUTScript_TS4Html : clsGeneCodeBase4Tab
    {
        //private clsPrjTabENEx objPrjTabENEx = null;
        //public WA_ViewUTScript_TS4Html()
        //{


        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        //public WA_ViewUTScript_TS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        //  : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        //{
        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_CS_Ts_DefButtonBak(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //    strTemp = A_GeneFuncCode_Ts_btnClick(strFuncName);
                //}
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string A_GeneFuncCode_CS_Ts_DefButtonBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            try
            {
                switch (objvFunction4GeneCodeEN.FuncName)
                {



                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);
            //objPrjTabENEx.ClsName = objPrjTabENEx.ClsName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cshtml";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                            .OrderBy(x => x.OrderNum); 

            try
            {
                //生成插入记录的界面代码;
                //      strCodeForCs.Append("///生成查询、修改、删除、添加记录的界面代码(利用控件)");
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.WApiForm.{0}\" %>",
                //  objPrjTabENEx.ClsName, objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "@page");
                strCodeForCs.Append("\r\n" + "@{");
                strCodeForCs.Append("\r\n" + "Layout = \"~/Pages/Shared/_Layout_RequireJS.cshtml\";");
                strCodeForCs.AppendFormat("\r\n" + "ViewData[\"Title\"] = \"{0}-单元测试\";", objPrjTabENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "@section Styles{");
                strCodeForCs.Append("\r\n" + "    <link rel=\"stylesheet\" href=\"../lib/bootstrap/dist/css/bootstrap.css\" />");
                strCodeForCs.Append("\r\n" + "    <link rel=\"stylesheet\" href=\"../css/site.css\" />");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "@section Scripts{");
                strCodeForCs.Append("\r\n" + "    <script src=\"../lib/jquery/dist/jquery.js\"></script>");
                strCodeForCs.Append("\r\n" + "    <script src=\"../lib/bootstrap/dist/js/bootstrap.js\"></script>");
                //strCodeForCs.Append("\r\n" + "    <script src=\"../js1/site.js\" asp-append-version=\"true\"></script>");
                strCodeForCs.Append("\r\n" + "    <script src=\"../lib/bootstrap/dist/js/popper.js\"></script>");
                strCodeForCs.Append("\r\n" + "    <script src=\"../lib/require/require.js\" data-main=\"../js/src/config\"></script>");
                strCodeForCs.Append("\r\n" + "}");
                // strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" %>",
                //objPrjTabENEx.ClsName, objProjectsENEx.PrjDomain);

                // strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                // strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
                // strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
                // strCodeForCs.Append("\r\n" + "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = utf-8\" />");
                // strCodeForCs.AppendFormat("\r\n" + "<title>{0}的WApi_TS单元测试</title>", objPrjTabENEx.TabCnName);
                // //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/taishweb2.css\"/>",
                // //  objViewInfoENEx.NameSpace);
                // strCodeForCs.Append("\r\n" + "     <link href=\"../../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                // strCodeForCs.Append("\r\n" + "     <link href=\"../../../Content/bootstrap.min.css\" rel=\"stylesheet\" />");

                // strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../../css/tz_base1.css\"/>",
                //     objProjectsENEx.PrjDomain);
                // strCodeForCs.Append("\r\n" + "<script type = \"text/javascript\" data-main = \"reqconfig.js\" src = \"../../../Scripts/require.js\" ></script>");

                string strClsName4UT_TS = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);
                string strClsName4UT_Ts_Lower = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName).ToLower();
                string strTabName_Lower = objPrjTabENEx.TabName.ToLower();

                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(this.CmPrjId, objPrjTabENEx.ApplicationTypeId, objPrjTabENEx.PrjId);

                clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathBLEx.GetObjByCodeTypeIdCache1(lngCMProjectAppRelaId, objPrjTabENEx.CodeTypeId, objPrjTabENEx.PrjId);

                strCodeForCs.Append("\r\n" + "     <script>    ");
                strCodeForCs.Append("\r\n" + "const strUrl1 = \"@Url.Content(\"~/Test/_FldComparison/\")\";");
                strCodeForCs.Append("\r\n" + "//console.log(\"strUrl1: \" + strUrl1);");
                strCodeForCs.Append("\r\n" + "const strCurrRootUrl = \"@Url.Content(\"~/\")\";");
                strCodeForCs.Append("\r\n" + "//console.log(\"strCurrRootUrl:\" + strCurrRootUrl);");

                strCodeForCs.Append("\r\n" + "         function ExpandDiv(divName, bolIsAddFldComparison, divName4Edit) {");

                strCodeForCs.Append("\r\n" + "//基于RequireJS来调用tzPubFun.ts中的函数OnlyShowDiv。");
                strCodeForCs.Append("\r\n" + "require([\"../js/TS/PubFun/tzPubFun.js\"], function (pubfun) {");
                strCodeForCs.Append("\r\n" + "      pubfun.OnlyShowDiv(divName, \"function\", \"content\");");                
                strCodeForCs.AppendFormat("\r\n" + "//console.log(\"divName4Edit:(In WApi{0}_UT_TS)\" + divName4Edit);", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (bolIsAddFldComparison == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "AddDPV_FldComparison(divName4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "function AddDPV_FldComparison(divName4Edit)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../js/{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Ts_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.AddDPV_FldComparison(divName4Edit);", strTabName_Lower, strClsName4UT_TS);
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "window.onload = function() {");
                strCodeForCs.Append("\r\n" + "const hidDivName = document.getElementById(\"hidDivName\");");
                strCodeForCs.Append("\r\n" + "const divName = hidDivName.value;");
                strCodeForCs.Append("\r\n" + "ExpandDiv(divName);");
                strCodeForCs.Append("\r\n" + "GetFldNameLst();");
                strCodeForCs.Append("\r\n" + "CreateCache();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {{", strFuncName4Code);
                //strCodeForCs.AppendFormat("\r\n" + "require([\"../js/{1}{3}/{0}.js\"], function({2}) {{",
                //    strClsName4UT_Ts_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                //strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                //    strTabName_Lower, strClsName4UT_TS, strFuncName4Code);
                //strCodeForCs.Append("\r\n" + "});");

                strCodeForCs.Append("\r\n" + "function CallBakFldNameLst(myFldNameLst)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "arrFldName = myFldNameLst.split(\",\");");
                strCodeForCs.Append("\r\n" + "//console.log(arrFldName);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "function GetFldNameLst()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../js/{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Ts_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                strCodeForCs.Append("\r\n" + "const strKey = $(\"#txtInput\").val();");
                           strCodeForCs.AppendFormat("\r\n" + "const bb = {0}.{1}.GetFldNameLst(CallBakFldNameLst);", strTabName_Lower, strClsName4UT_TS);

                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + " function CreateCache() {");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../js/{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Ts_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);

                strCodeForCs.Append("\r\n" + "            var strKey = $(\"#txtInput\").val();");
                strCodeForCs.AppendFormat("\r\n" + "            var bb = {0}.{1}.CreateCache(strKey);", strTabName_Lower, strClsName4UT_TS);
                strCodeForCs.Append("\r\n" + "            $(\"#lblPageStatusContent\").attr(\"value\", bb);// 布尔型");
                strCodeForCs.Append("\r\n" + "        });");
                strCodeForCs.Append("\r\n" + "    }");

                strCodeForCs.AppendFormat("\r\n" + "  function ShowDialog_{0}(pstrOp) {{", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "            strOp = pstrOp;");
                strCodeForCs.Append("\r\n" + "require(['jquery', 'bootstrap'], function($) {");
                strCodeForCs.Append("\r\n" + "            if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('添加记录');", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            else {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('修改记录');", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.AppendFormat("\r\n" + "            $('#divEditDialog_{0}').modal('show');", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.AppendFormat("\r\n" + "        function Submit_{0}(pstrOp) {{  ", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "            alert(\"提交\" + strOp);");
      
                strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {{",
                    strClsName4UT_Ts_Lower, strTabName_Lower);

                strCodeForCs.Append("\r\n" + "            if (strOp == \"Add\")");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "           {0}.{1}.btnAddNewRecord_Click();",
                    strTabName_Lower, strClsName4UT_TS);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            else");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "           {0}.{1}.btnUpdateRecord_Click()",
                    strTabName_Lower, strClsName4UT_TS);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "});");

                strCodeForCs.Append("\r\n" + "        }");
                //objPrjTabENEx.arrTabFeatureSet

                //clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId, objPrjTabENEx.ApplicationTypeId, objPrjTabENEx.PrjId, objPrjTabENEx.UserId);
                //基于RequireJS, 需要生成界面中通过Js函数来调用Ts的函数,
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncCHName4Code);
                    //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {{", strFuncName4Code);
                    strCodeForCs.AppendFormat("\r\n" + "require([\"../js/{1}{3}/{0}.js\"], function({2}) {{",
                        strClsName4UT_Ts_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                        strTabName_Lower, strClsName4UT_TS, strFuncName4Code);
                    strCodeForCs.Append("\r\n" + "});");

                    strCodeForCs.Append("\r\n" + "}");

                }


                strCodeForCs.Append("\r\n" + "    </script>");

                //strCodeForCs.Append("\r\n" + "</head>");


                //strCodeForCs.Append("\r\n" + "<body>");
                //strCodeForCs.Append("\r\n" + "<form id = \"form1\" runat = \"server\">");

                ASPHiddenFieldEx objASPNETHiddenFieldENEx = new ASPHiddenFieldEx();
                objASPNETHiddenFieldENEx.CtrlId = "hidDivName";
                //objASPNETHiddenFieldENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //ASPHiddenFieldEx objASPNETHiddenFieldENEx2 = new ASPHiddenFieldEx();
                //objASPNETHiddenFieldENEx2.CtrlId = "hidFldComparisonObjLst";
                //objASPNETHiddenFieldENEx2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //用来定义正文的标签类型
                clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                //用来定义1号标题的标签类型
                clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
                clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
                clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
                clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
                //0003:QUDI模式


                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + "runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<div id=\"divPageStatus\" style=\"width: 100%; float: left; margin-bottom:5px;\">");
                strCodeForCs.Append("\r\n" + "        <hr />");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatus\" name=\"lblPageStatus\" class=\"h6\" style=\"width:100px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            页面状态:");
                strCodeForCs.Append("\r\n" + "        </Label>");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatusContent\" name=\"lblPageStatusContent\" class=\"text-secondary\" style=\"width:600px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            缓存状态未知");
                strCodeForCs.Append("\r\n" + "        </Label>");
                strCodeForCs.Append("\r\n" + "    </div>");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strTemp = A_GeneFuncCode_CS_DefButton("Gen_WApi_CS_Ts_DefLabelMsg");
                //if (string.IsNullOrEmpty(strTemp) == false)
                //{
                //    strCodeForCs.Append("\r\n" + strTemp);
                //}

                strCodeForCs.Append("\r\n" + "</div>");

                //strCodeForCs.Append("\r\n" + "</form>");
                //strCodeForCs.Append("\r\n" + "</body>");
                //strCodeForCs.Append("\r\n" + "</html>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }




    
      
        public ASPLabelEx GetOrderNumLabel_TS(int intOrderNum)
        {


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblOrderNum{0}", intOrderNum);
            objASPNETLabelENEx.Text = string.Format("第{0}个函数：", intOrderNum);
            objASPNETLabelENEx.Width = 80;
            objASPNETLabelENEx.Height = 24;

            return objASPNETLabelENEx;
        }
        public ASPDivEx GetParaInputCtrlGroup_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("divParaGroup{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            GC_GetInputValueCtrl4Para(objFunction4GeneCodeEN.FuncId4Code, objvFunction4GeneCodeEN.OrderNum, objASPNETDivENEx);
            ASPDivEx objASPNETDivENEx_Edit = new ASPDivEx();
            objASPNETDivENEx_Edit.CtrlId = string.Format("divEditFldComparison{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Edit);
            return objASPNETDivENEx;


        }

        public string Gen_WApi_CS_Ts_DefLabelMsg(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblMsg");
            objASPNETLabelENEx.Text = "显示结果";
            objASPNETLabelENEx.Width = 200;
            objASPNETLabelENEx.Height = 24;
            objASPNETLabelENEx.mTextSize = "12sp";
            objASPNETLabelENEx.minHeight = "35dp";

            //objASPNETLabelENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETLabelENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            //objASPNETLabelENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string GetLinearLayout4FunctionByCommonFunction_TS(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objASPNETButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objASPNETButtonENEx.Width = 200;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";

            //ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);

            //添加显示结果的控件
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //添加水平线
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            //objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);



            return strCodeForCs.ToString();
        }
        private void GC_GetInputValueCtrl4Para_TS(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
        {
            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst == null) return;
            foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objFuncPara4CodeEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objFuncPara4CodeEN.ParaName,
                         objFuncPara4CodeEN.ParameterType);
                    throw new Exception(strMsg);
                }
                ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
                objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
                objASPNETLabelENEx.Width = 200;
                objASPNETLabelENEx.Height = 24;

                objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                if (objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
                    }
                    objASPNETTextBoxENEx.Width = 80;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
                }
                else
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                    }

                    objASPNETTextBoxENEx.Width = 80;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

                }
            }

        }
      
        public ASPDivEx GetFunctionGroupDiv_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName(  objFunction4CodeEN.FuncName4Code);


            //string strFunctionName_CN = string.Format("{0}、检查是否存在记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", strFunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left; margin-bottom:5px;");
            objASPNETDivENEx.Class = "function";
            
            //添加水平线
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            ASPDivEx objASPNETDivENEx_Title = GetDiv4FuncTitle_TS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Title);

            return objASPNETDivENEx;
        }

        private ASPDivEx GetFunctionResultDiv_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName =TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
            objASPNETDivENEx_Para.CtrlId = string.Format("divResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

            ASPHtmlButtonEx objASPNETButtonENEx = new ASPHtmlButtonEx();
            //objASPNETButtonENEx.Is4PureHtml = true;
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            if (strFunctionName.Contains("Add") == true)
            {
                objASPNETButtonENEx.OnClick = string.Format("this.ShowDialog_{1}('Add');", strFunctionName, objPrjTabENEx.TabName); ;
            }
            else if (strFunctionName.Contains("Update") == true)
            {
                objASPNETButtonENEx.OnClick = string.Format("this.ShowDialog_{1}('Update');", strFunctionName, objPrjTabENEx.TabName); ;
            }
            else
            {
                objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click()", strFunctionName, objPrjTabENEx.TabName); ;
            }
            objASPNETButtonENEx.Value = strFunctionName_CN;

            objASPNETButtonENEx.Width = 400;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.Class = "btn btn-outline-info btn-sm";

            objASPNETButtonENEx.Style = "width:400px;";
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";
         

            ASPLabelEx objASPNETLabelENEx2 = new ASPLabelEx();
            //objASPNETLabelENEx2.Is4PureHtml = true;
            objASPNETLabelENEx2.CtrlId = string.Format("lblResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETLabelENEx2.Text = "结果";
            objASPNETLabelENEx2.CssClass = "Content";
            objASPNETLabelENEx2.Width = 600;
            objASPNETLabelENEx2.Height = 24;

            ASPDivEx objASPNETDivENEx_List = new ASPDivEx();
            objASPNETDivENEx_List.CtrlId = string.Format("divList{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_List.Style = string.Format("width: 100%; float: left");

            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx2);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETDivENEx_List);
            return objASPNETDivENEx_Para;
            
        }
        /// <summary>
        /// 建立函数的标题Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncTitle_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}、{1}({2})", 
                objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code, objFunction4CodeEN.FuncName4Code);

            //< div class="title" style="width:100%">
            //      <div style = "float:left; width:80%; " >
            //                 < asp:Label ID = "lblIsExistRecord4Title" Width="600px" Height="24px" Text="结果" runat="server" />

            //      </div>
            //      <div style = "float:right; width:20%; " >
            //          < input id="btnIsExistRecord4Expand" type="button" value="展开" onclick="ExpandDiv('divGen_WApi_CS_Ts_DefButtonIsExistRecord')" />
            //      </div>
            //  </div>
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "title";
            objASPNETDivENEx.Style = "width:100%; height:25px;";

            {
                ASPDivEx objASPNETDivENEx_Left = new ASPDivEx();

                objASPNETDivENEx_Left.Style = "float:left; width:80%;";
                //clsASPLabelBLEx.GeneCode
                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                //objASPNETLabelENEx.Is4PureHtml = true;
                objASPNETLabelENEx.CtrlId = string.Format("lblTitle{0}", objvFunction4GeneCodeEN.OrderNum);
                objASPNETLabelENEx.Text = string.Format("测试：{0}", strFunctionName_CN);
                objASPNETLabelENEx.CssClass = "h6";
                objASPNETLabelENEx.Width = 700;
                objASPNETLabelENEx.Height = 20;

                objASPNETDivENEx_Left.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Left);

            }
            {
                ASPDivEx objASPNETDivENEx_Right = new ASPDivEx();

                objASPNETDivENEx_Right.Style = "float:right; width:20%;";

                ASPHtmlButtonEx objASPNETHtmlButtonENEx = new ASPHtmlButtonEx();
                objASPNETHtmlButtonENEx.CtrlId = string.Format("btnExpand{0}", strFunctionName);
                objASPNETHtmlButtonENEx.Value = string.Format("展开");
                var arrFuncPara4Code = clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4CodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
                if (arrFuncPara4Code == null)
                {
                    objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                }
                else
                {
                    var arrFuncPara4Code_Sel = arrFuncPara4Code.Where(x => x.DataTypeId == enumDataTypeAbbr.Object_29);
                    if (arrFuncPara4Code_Sel.Count() > 0)
                    {
                        objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}', true, 'divEditFldComparison{1}');", strFunctionName, objvFunction4GeneCodeEN.OrderNum);
                    }
                    else
                    {
                        objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                    }
                }
                objASPNETHtmlButtonENEx.Width = 300;
                objASPNETHtmlButtonENEx.Height = 24;

                objASPNETDivENEx_Right.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Right);
            }
            
            return objASPNETDivENEx;
        }

        /// <summary>
        /// 建立函数的内容Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncContent_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "content";
            objASPNETDivENEx.Style = "width: 100%";

            {
                ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup_TS(objvFunction4GeneCodeEN);
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
            }
            //{
            //    ASPDivEx objASPNETDivENEx_Button = new ASPDivEx();
            //    objASPNETDivENEx_Button.Class = "button";
            //    objASPNETDivENEx_Button.Style = "width: 100%";

            //    ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            //    objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            //    objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            //    objASPNETButtonENEx.Text = strFunctionName_CN;
            //    objASPNETButtonENEx.Width = 200;
            //    objASPNETButtonENEx.Height = 24;
            //    objASPNETButtonENEx.mTextSize = "12sp";
            //    objASPNETButtonENEx.minHeight = "35dp";
            //    objASPNETDivENEx_Button.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            //    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Button);
            //}
            //添加显示结果的控件
            ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv_TS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            return objASPNETDivENEx;

            //objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //return strCodeForCs.ToString();
        }
        //      private void GC_GetInputValueCtrl4Para(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
        //      {
        //          string strMsg = "";
        //          //            StringBuilder strCodeForCs = new StringBuilder();
        //          List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
        //clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);
        //          if (arrFuncPara4CodeObjLst == null) return;
        //          foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
        //          {
        //              clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
        //              clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
        //              if (objDataTypeAbbrEN == null)
        //              {
        //                  objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
        //                  if (objSelfDefDataTypeEN_Para == null)
        //                  {
        //                      strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
        //                          objFuncPara4CodeEN.ParameterType);
        //                      throw new Exception(strMsg);
        //                  }
        //              }
        //              if (objFuncPara4CodeEN.IsByRef == true)
        //              {
        //                  strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
        //                     objFuncPara4CodeEN.ParaName,
        //                       objFuncPara4CodeEN.ParameterType);
        //                  throw new Exception(strMsg);
        //              }
        //              ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
        //              objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
        //              objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

        //              ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
        //              objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
        //              objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
        //              objASPNETLabelENEx.Width = 200;
        //              objASPNETLabelENEx.Height = 24;

        //              objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

        //              if (objDataTypeAbbrEN.IsNeedQuote == true)
        //              {
        //                  ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
        //                  objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
        //                  if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
        //                  }
        //                  objASPNETTextBoxENEx.Width = 80;
        //                  objASPNETTextBoxENEx.Height = 24;
        //                  objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

        //                  objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
        //              }
        //              else
        //              {
        //                  ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
        //                  objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
        //                  if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
        //                  }
        //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
        //                  }
        //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
        //                  }
        //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
        //                  }
        //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
        //                  {
        //                      objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
        //                  }

        //                  objASPNETTextBoxENEx.Width = 80;
        //                  objASPNETTextBoxENEx.Height = 24;
        //                  objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

        //                  objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

        //              }
        //          }

        //      }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }
                //string strTemp_ImportClass = GeneCode_ImportClass();
                //if (string.IsNullOrEmpty(strTemp_ImportClass) == false)
                //{
                //    strCodeForCs.Append("\r\n" + strTemp_ImportClass);
                //}
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    }

}
