using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(Control of Mvc)
    /// </summary>
    public class AutoGC_Cs_CWeb_PubFun : clsGeneCodeBase4View
    {

        private string strKeyFldName_ObjName = "";


        protected bool mbolIsUseCtl = true;
        public AutoGC_Cs_CWeb_PubFun()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../..";
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

        }

        public AutoGC_Cs_CWeb_PubFun(string strViewId)
     : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            this.strBaseUrl = "../..";
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

        }
        public AutoGC_Cs_CWeb_PubFun(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
      : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../..";
            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

        }




        /// <summary>
        // 生成权限有关的变量定义代码
        /// </summary>
        /// <returns></returns>

        /// <summary>
        // 生成权限有关的变量定义代码
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的界面功能名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的导出表名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。");
                strCodeForCs.Append("\r\n /// 姓名:");
                strCodeForCs.Append("\r\n /// 日期:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_vsPotenceLevel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefConst_ViewId4Potence()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_seUserId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:登录的用户ID,用于检查用户权限");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                ////				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                //strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_qsUserId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。");
                strCodeForCs.Append("\r\n /// 姓名:");
                strCodeForCs.Append("\r\n /// 日期:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                ////				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                //strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_DefProperty_vsTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的导出表名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_DefProperty_vsClassifyName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前记录排序的分类名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_DefProperty_vsViewName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的界面功能名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        // 生成权限有关判断权限的代码
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                  objViewInfoENEx.TabName_Out, "{", "}");

                strCodeForCs.Append("\r\n" + "//生成权限有关判断权限的代码");
                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "//根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推");
                strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"0\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"1\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"2\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"3\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"4\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"9\":");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        // 生成权限有关权限等级的代码
        /// </summary>
        /// <returns></returns>
        public string GenPotenceLevelProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState属性:用于记录当前用户在当前界面的权限等级");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成登录用户的用户名Session
        /// </summary>
        /// <returns></returns>
        public string GenLoginUserSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成登录用户的用户名Session");
                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:登录的用户ID,用于检查用户权限");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n ///protected clsUsersEN objUser");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///get");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser;");
                strCodeForCs.Append("\r\n ///pobjUser = (clsUsersEN)Session[\"objUser\"];");
                strCodeForCs.Append("\r\n ///if (pobjUser == null) ");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///pobjUser = null;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///return pobjUser;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///set");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser = value;");
                strCodeForCs.Append("\r\n ///Session.Add(\"objUser\", pobjUser);");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenErrMessageSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seErrMessage");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage;");
                strCodeForCs.Append("\r\n" + "strErrMessage = (string)Session[\"ErrMessage\"];");
                strCodeForCs.Append("\r\n" + "if (strErrMessage == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strErrMessage = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strErrMessage;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"ErrMessage\", strErrMessage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenPageSizeViewState()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于记录GridView中的每页记录数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageSize");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize;");
                strCodeForCs.Append("\r\n" + "strPageSize = (string)ViewState[\"PageSize\"];");
                strCodeForCs.Append("\r\n" + "if (strPageSize == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageSize = \"\";");
                strCodeForCs.Append("\r\n" + "return 15;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PageSize\", strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_PageIndex()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView中的页序号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageIndex");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex;");
                strCodeForCs.Append("\r\n" + "strPageIndex = (string)ViewState[\"pageIndex\"];");
                strCodeForCs.Append("\r\n" + "if (strPageIndex == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageIndex = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"pageIndex\", strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_PageCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView中的总页数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageCount");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageCount;");
                strCodeForCs.Append("\r\n" + "strPageCount = (string)ViewState[\"PageCount\"];");
                strCodeForCs.Append("\r\n" + "if (strPageCount == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageCount = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageCount = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PageCount\", strPageCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_RecCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView中的总页数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsRecCount");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strRecCount;");
                strCodeForCs.Append("\r\n" + "strRecCount = (string)ViewState[\"RecCount\"];");
                strCodeForCs.Append("\r\n" + "if (strRecCount == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strRecCount = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strRecCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strRecCount = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"RecCount\", strRecCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBackLinkStrSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string seBackErrPageLinkStr");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = (string)Session[\"BackErrPageLinkStr\"];");
                strCodeForCs.Append("\r\n" + "if (strBackErrPageLinkStr == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"BackErrPageLinkStr\", strBackErrPageLinkStr);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenBindGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	4、设置GridView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "//	6、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable_{1}(strWhereCond);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "获取数据表(DataTable)不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})获取数据表(DataTable)不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                ;
                strCodeForCs.Append("\r\n" + "//	4、设置GRIDView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                objViewInfoENEx.TabName);
                //}
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(PageSize) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = int.Parse(PageSize);");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PageSize = \"10\";");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = 10;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenBinggv_JumpPage());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//	6、设置记录数的状态,");
                    strCodeForCs.Append("\r\n" + "this.txtRecCount.Text = objDT.Rows.Count.ToString();");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 功能:计算DataGrid的页数");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">总共的记录数</param>");
                //strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">每页的记录数</param>");
                //strCodeForCs.Append("\r\n /// <returns>计算出来的页数</returns>");
                //strCodeForCs.Append("\r\n" + "protected int CalcPages(int intRecCount, int intPageSize)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "int intPages;");
                //strCodeForCs.Append("\r\n" + "intPages = intRecCount / intPageSize;");
                //strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize != 0) intPages ++;");
                //strCodeForCs.Append("\r\n" + "return intPages;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenBindGridView4WucInPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见;");
                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数;");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见；");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                      objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数；");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                  objViewInfoENEx.TabName, ClsName4WucTabName4Gv());

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "绑定GridView出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定GridView出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBindGridView4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}(string strWhereCond)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	4、设置GridView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "//	6、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + " int intRecCount = 0;");
                strCodeForCs.Append("\r\n" + "int intPageCount = 0;");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "vsWhereCond = strWhereCond;");
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{1}By);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{1}By);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "获取数据表(DataTable)不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})获取数据表(DataTable)不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                ;
                strCodeForCs.Append("\r\n" + "//	4、设置GRIDView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");

                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenBinggv_JumpPage());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//	6、设置记录数的状态,");
                    strCodeForCs.Append("\r\n" + "this.txtRecCount.Text = objDT.Rows.Count.ToString();");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 功能:计算DataGrid的页数");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">总共的记录数</param>");
                //strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">每页的记录数</param>");
                //strCodeForCs.Append("\r\n /// <returns>计算出来的页数</returns>");
                //strCodeForCs.Append("\r\n" + "protected int CalcPages(int intRecCount, int intPageSize)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "int intPages;");
                //strCodeForCs.Append("\r\n" + "intPages = intRecCount / intPageSize;");
                //strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize != 0) intPages ++;");
                //strCodeForCs.Append("\r\n" + "return intPages;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_GridView_Sorting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,单击列头进行排序所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_Sorting(object sender, GridViewSortEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intIndex;");
                strCodeForCs.Append("\r\n" + "//判断是否是新的排序字段");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(e.SortExpression);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                objViewInfoENEx.TabName);
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);",
                        objViewInfoENEx.TabName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }

                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//检查原来是升序");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\" Asc\");",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)		//如果原来不是升序就设置为升序");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else			///否则设置为降序");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Desc\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);",
                        objViewInfoENEx.TabName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsSort{0}By",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = (string)ViewState[\"Sort{0}By\"];",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (sSort{0}By == null) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = \"\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sSort{0}By;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By = value;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"Sort{0}By\", sSort{0}By);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_vsWhereCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsWhereCond",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = (string)ViewState[\"whereCond\"];",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (sWhereCond == null) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = \"\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sWhereCond;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond = value;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"whereCond\", sWhereCond);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetGvVisibility()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView字段的可见性");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility(string strColumnName, bool bolIsVisible)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, strColumnName, bolIsVisible);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetVisible()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView的可见性");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public void SetVisible(bool bolVisible)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.Visible = bolVisible;",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetSortBy()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView的可见性");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetSortBy(string strSortBy)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(vsSort{0}By) == true)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = strSortBy;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetCheckedItemForGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置在GridView中选择一个项(一条记录)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public bool SetCheckedItemForGv({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemForGv(gv{0}, 1, {1}.ToString());",
                    objViewInfoENEx.TabName,
                    objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_SetCheckedItemsForGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置在GridView中选择多个项(多条记录)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public bool SetCheckedItemForGv(List<{0}> {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1}.Select(x=>x.ToString()).ToList());",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncListName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncListName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenCombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objViewInfoENEx.TabName_Out);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             objViewInfoENEx.TabName_Out,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             objViewInfoENEx.TabName_Out,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = int.Parse( this.{2}.SelectedValue.ToString());",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///如果控件类型是文本框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                                    objViewInfoENEx.TabName_Out,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             objViewInfoENEx.TabName_Out,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "Button":
                            break;
                        default:
                            var strMsg = string.Format("(errorId:018)控件类型：{0}在相应函数中没有被处理!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}Condition", "在组合查询条件(Combine{0}Condition)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBinggv_JumpPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n ///生成专门用于BindGv中的跳页相关代码");

                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (pagerRow == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "Label lblRecCount = (Label)pagerRow.FindControl(\"lblRecCount\");");
                strCodeForCs.Append("\r\n" + "Label lblAllPages = (Label)pagerRow.FindControl(\"lblAllPages\");");
                strCodeForCs.Append("\r\n" + "Label lblCurrentPage = (Label)pagerRow.FindControl(\"lblCurrentPage\");");
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "Button btnNextPage = (Button)pagerRow.FindControl(\"btnNextPage\");");
                strCodeForCs.Append("\r\n" + "Button btnPrevPage = (Button)pagerRow.FindControl(\"btnPrevPage\");");
                strCodeForCs.Append("\r\n" + "Button tabJumpPage = (Button)pagerRow.FindControl(\"tabJumpPage\");");
                strCodeForCs.Append("\r\n" + "DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl(\"ddlPagerRecCount\");");
                strCodeForCs.Append("\r\n" + "if (lblRecCount != null)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "//当前记录数");
                strCodeForCs.AppendFormat("\r\n" + "lblRecCount.Text = intRecCount.ToString(); ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//当前页数");
                strCodeForCs.AppendFormat("\r\n" + "lblAllPages.Text = intPageCount.ToString(); ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//当前页序数");
                strCodeForCs.AppendFormat("\r\n" + "lblCurrentPage.Text = vsPageIndex.ToString();",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//当前即将跳到的页序数");
                strCodeForCs.AppendFormat("\r\n" + "txtJump2Page.Text = vsPageIndex.ToString();",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//如果当前页序数为0,则<前一页>按钮无效");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == 1) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = false; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = true; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "//如果当前页序数已为最后一页,则<前一页>按钮无效");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == intPageCount) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = false; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = true; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");

                strCodeForCs.Append("\r\n" + "//设置分页器中每页记录数的下拉框的值");
                strCodeForCs.Append("\r\n" + "if (vsPageSize>0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "ddlPagerRecCount.Text = vsPageSize.ToString();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.Append("\r\n" + "ddlPagerRecCount.Text = vsPageSize.ToString();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.BottomPagerRow.Visible = true;", objViewInfoENEx.TabName);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnAddNewRec4Gv_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///添加新记录的事件过程 ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                //    objViewInfoENEx.TabName);
                //}
                //else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                //{
                //    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                //    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                //    objViewInfoENEx.TabName);

                //}
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnExportExcel4Gv_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///导出Excel ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{0}.Get{0}(strWhereCond);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "string [] strCnName = new string[intColNum];");
                strCodeForCs.Append("\r\n" + "string [] strColName = new string[intColNum];");
                strCodeForCs.Append("\r\n" + "string strFileName = \"TT.xls\";");
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "strFolderName = \"D:\\\\FTP\\\\\";");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:下载文件。从服务器下载文件到客户端浏览器");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">需要下载的文件名。该文件名为带目录的文件全名</param>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                strCodeForCs.Append("\r\n" + "Response.End();");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 导出EXCEL文件,其中导出的字段完全与DataGrid一致。
        /// </summary>
        /// <returns></returns>
        public string GenbtnExportExcel4Gv_Click2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 事件函数:把查询条件的表记录,导出到Excel.");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                //        strCodeForCs.Append("\r\n" + "//生成专门用于导出Excel的相关代码");
                strCodeForCs.Append("\r\n" + "protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//导出Excel函数");
                strCodeForCs.Append("\r\n" + "ExportExcel();");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 导出EXCEL文件,其中导出的字段完全与DataGrid一致。专门针对导出字段
        /// </summary>
        /// <returns></returns>
        public string GenExportExcel4SetExportFld()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //生成专门用于导出Excel 的相关代码
                strCodeForCs.Append("\r\n /// <summary>");

                strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}信息导出.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(cls{2}EN.con_{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ViewName = vsViewName;//当前界面");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;//当前工程在生成代码系统中所用的工程Id,为了翻译字段名的中文名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名,也是Excel文件中的标题名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrColName = arrColName;//数据表的列名");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx);");
                strCodeForCs.Append("\r\n" + "strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名");
                strCodeForCs.Append("\r\n" + "arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名,也是Excel文件中的标题名");
                strCodeForCs.Append("\r\n" + "arrColName = objExportExcelSetENEx.arrColName;//数据表的列名");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");




                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");

                strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 功能:下载文件。从服务器下载文件到客户端浏览器");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">需要下载的文件名。该文件名为带目录的文件全名</param>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                //strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                //strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                //strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                //strCodeForCs.Append("\r\n" + "Response.End();");
                //strCodeForCs.Append("\r\n" + "return true;");
                //strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenExportExcel()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == true)
            {
                return GenExportExcel4SetExportFld();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //生成专门用于导出Excel 的相关代码
                strCodeForCs.Append("\r\n /// <summary>");

                strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                        objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}信息导出.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                List<string> arrColHead = new List<string>();
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    string strColHead = objExcelExportRegionFldsEx.ColCaption;
                    if (arrColHead.Contains(strColHead) == false)
                    {
                        arrColHead.Add(strColHead);
                    }
                    else
                    {
                        string strMsg = string.Format("导出Excel时,列头重复!重复列头:[{0}({2})].(In {1})",
                            strColHead, clsStackTrace.GetCurrClassFunction(),
                            objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName);
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(cls{2}EN.con_{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");

                strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取数据出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "  try");
                strCodeForCs.Append("\r\n" + "  {");
                strCodeForCs.Append("\r\n" + "//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + " catch (Exception objException)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException2)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"导出Excel出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException2.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenbtnDelete4Gv_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelete4Gv_Click4OneKeyword(objViewInfoENEx, bolIsUseWuc4Gv);
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///删除当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                    strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GetAllCheckedKeysFromGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///从列表中获取所有选择的关键字");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>返回所有选择的关键字列表</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private List<{0}> GetAllCheckedKeysFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetAllCheckedKeysFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetAllCheckedKeysFromGv", "没有选择记录, 请选择有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return null;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "return lst{0};",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{0}> arr{1}Lst = new List<{0}>();",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                        strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");
                        strCodeForCs.AppendFormat("\r\n" + "foreach (string str{0} in lst{0})",
                       objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + " arr{0}Lst.Add({1});",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                            objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.AppendFormat("\r\n" + "return arr{0}Lst;",
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetAllCheckedKeysFromGv4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///从列表中获取所有选择的关键字");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>返回所有选择的关键字列表</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public List<{0}> GetAllCheckedKeysFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetAllCheckedItemFromGv(gv{1}, \"chkCheckRec\", {0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetAllCheckedKeysFromGv", "没有选择记录, 请选择有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "clsCommonJsFunc.Alert(this, \"(errid:{0})没有选择记录,请选择有效的表记录!\");", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return null;");
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "return lst{0};",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{0}> arr{1}Lst = new List<{0}>();",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                        strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");
                        strCodeForCs.AppendFormat("\r\n" + "foreach (string str{0} in lst{0})",
                       objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(str{1});",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + " arr{0}Lst.Add({1});",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                            objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.AppendFormat("\r\n" + "return arr{0}Lst;",
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 针对主表只有一个关键字的删除事件
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelete4Gv_Click4OneKeyword(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///删除当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         ClsName4WucTabName4Gv());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "删除记录不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})删除记录不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, ClsName4WucTabName4Gv());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string GenbtnUpdate4Gv_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUpdate4Gv_Click4OneKeyword(objViewInfoENEx, bolIsUseWuc4Gv);
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///修改当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                    //    objViewInfoENEx.TabName,
                    //   objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    //}
                    //else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    //{
                    //    //strStd1Id = "";
                    //    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    //    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    //    objViewInfoENEx.TabName,
                    //    objKeyField.ObjFieldTabENEx.FldName,
                    //    objKeyField.PrivFuncName);
                    //}

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                    //    objKeyField.PrivFuncName);
                    //    //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                    //    //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                    //    strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                    //    strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                    //    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    //    {
                    //        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                    //        objViewInfoENEx.TabName);
                    //    }
                    //    strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                    //    strCodeForCs.Append("\r\n" + "}");
                    //}
                    //else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    //{
                    //    //strStd1Id = "";
                    //    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    //    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    //    objViewInfoENEx.TabName,
                    //    objKeyField.ObjFieldTabENEx.FldName,
                    //    objKeyField.PrivFuncName);
                    //    //Update{TabName}Record(strStd1Id);
                    //}
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetFirstCheckedKeyFromGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///从列表中获取选择的第一个关键字");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>返回选择的第一个关键字</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private {0} GetFirstCheckedKeyFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetFirstCheckedKeyFromGv", "没有选择记录, 请选择有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.Append("\r\n" + "return 0;");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + " return {0};",
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetFirstCheckedKeyFromGv4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///从列表中获取选择的第一个关键字");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>返回选择的第一个关键字</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} GetFirstCheckedKeyFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetFirstCheckedKeyFromGv", "没有选择记录, 请选择有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "clsCommonJsFunc.Alert(this, \"(errid:{0})没有选择记录,请选择有效的表记录!\");", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.Append("\r\n" + "return 0;");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + " return {0};",
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnUpdate4Gv_Click4OneKeyword(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///修改当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 ClsName4WucTabName4Gv());

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 ClsName4WucTabName4Gv());

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                    //    objViewInfoENEx.TabName,
                    //   objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    //}
                    //else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    //{
                    //    //strStd1Id = "";
                    //    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    //    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    //    objViewInfoENEx.TabName,
                    //    objKeyField.ObjFieldTabENEx.FldName,
                    //    objKeyField.PrivFuncName);
                    //}

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                    //    objKeyField.PrivFuncName);
                    //    //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                    //    //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                    //    strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                    //    strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                    //    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    //    {
                    //        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                    //        objViewInfoENEx.TabName);
                    //    }
                    //    strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                    //    strCodeForCs.Append("\r\n" + "}");
                    //}
                    //else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    //{
                    //    //strStd1Id = "";
                    //    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    //    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    //    objViewInfoENEx.TabName,
                    //    objKeyField.ObjFieldTabENEx.FldName,
                    //    objKeyField.PrivFuncName);
                    //    //Update{TabName}Record(strStd1Id);
                    //}
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnSetExportExcel4User_Click()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == false)
            {
                return "";
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///设置当前用户的Excel导出字段");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");


                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnSetExportExcel4User_Click(object sender, EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\"ViewName = '{" + "0" + "}'\", vsViewName);//当前界面");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And TabName = '{" + "0" + "}'\", vsTabName);//当前导出的使用的表");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And UserId = '{" + "0" + "}'\", clsCommonSession.UserId);//当前用户");
                    strCodeForCs.Append("\r\n" + "//根据条件获取Excel设置Id");
                    strCodeForCs.Append("\r\n" + "string strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());");
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetMaxStrId_S", "在系统中没有界面为{0},表名 = {1},并且用户 = {2}的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!", "生成代码");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "sbMsg.AppendFormat(\"(errid:{0})在系统中没有界面为[{{0}}]\", vsViewName);", strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\",表名 = '{" + "0" + "}'\", vsTabName);");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"并且用户 = '{" + "0" + "}'的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!\", clsCommonSession.UserId);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, sbMsg.ToString());");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//弹出导出Excel字段界面进行设置");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbScript = new StringBuilder();");

                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"<script language = 'javascript'>\");");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"window.open('\");");
                    strCodeForCs.Append("\r\n" + "sbScript.AppendFormat(\"../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users = {" + "0" + "}\", strid_ExportExcel4Users);");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"','_blank', 'left = 50px,top = 50px,status = no,width = 920px,height = 650px,scrollbars = yes'); </script>\");");
                    strCodeForCs.Append("\r\n" + "Page.ClientScript.RegisterStartupScript(this.GetType(), \"导出Excel字段设置\", sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "// Response.Write(sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成父对象的SESSION相关属性函数
        /// </summary>
        /// <returns></returns>
        public string GenParentObjSeesionProp()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.IsTabForeignKey() == true)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                        objQryRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "protected string {0}",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = (string)Session[\"{0}\"];",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null) ",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = \"\";",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.AppendFormat("\r\n" + "return str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = value;",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"{0}\", str{0});",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");

                    }
                }
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成跳页相关函数
        /// </summary>
        /// <returns></returns>
        public string GenJumpPage_RelaFunction(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //strCodeForCs.Append("\r\n ///生1成与跳页的相关函数");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:生成与跳页的相关函数.在GridView的脚部,当单击跳转按钮时发生的事件,在这里主要处理:跳转到GridView的某一数。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnJumpPage_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "if (txtJump2Page != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(txtJump2Page.Text.Trim()!= \"\" && ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)>0 && ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)-1<this.gv{0}.PageCount) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = int.Parse(txtJump2Page.Text)-1; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);",
                        objViewInfoENEx.TabName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成改变GridView中每页记录数的下拉框相关函数
        /// </summary>
        /// <returns></returns>
        public string GenddlPagerRecCount_SelectedIndexChanged(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //strCodeForCs.Append("\r\n ///生成的改变GridView中每页记录数的下拉框相关函数");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView的脚部,当每页记录数的下拉框发生改变时发生的事件,在这里主要处理:改变GridView的每页记录数。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.Append("\r\n" + "protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "DropDownList ddlPagerRecCount = (DropDownList)sender;");
                strCodeForCs.Append("\r\n" + "string strPageSize = ddlPagerRecCount.Text;");
                strCodeForCs.Append("\r\n" + "if (clsDateTime.IsNumeric(strPageSize) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "if (intPageSize >= 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = intPageSize;");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);",
                        objViewInfoENEx.TabName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }





        public string GenDdlBindFunction4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:private void PutDataToClass;
                }
                else
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                        if (objQryRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;

                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            //string strDS_DataValueField;
                            //string strDS_DataTextField;
                            string strDsTabName;
                            try
                            {
                                strDsTabName = clsQryRegionFldsBLEx.DsTabName4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDsTabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空,请检查!({2}).",
                                objViewInfoENEx.ViewName, "查询区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            //try
                            //{
                            //    strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                            //        objViewInfoENEx.ViewName, "查询区域", strDsTabName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //try
                            //{
                            //    strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName, strDS_DataValueField);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                            //          objViewInfoENEx.ViewName, "查询区域", strDsTabName, strDS_DataValueField,
                            //          clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;
                                    strCodeForCs.Append("\r\n /// <summary>");
                                    strCodeForCs.AppendFormat("\r\n ///绑定下拉框:ddl{0}的函数。", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n /// </summary>");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///列表项数据源表;

                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");

                                    //try
                                    //{
                                    //    if (objQryRegionFldsEx.DsCondStr.Trim() == "")
                                    //    {
                                    //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                                    //        strDS_DataValueField, strDS_DataTextField, strDsTabName);
                                    //    }
                                    //    else
                                    //    {
                                    //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";",
                                    //        strDS_DataValueField, strDS_DataTextField, strDsTabName, objQryRegionFldsEx.DsCondStr);
                                    //    }
                                    //}
                                    //catch (Exception objException)
                                    //{
                                    //    StringBuilder sbMsg = new StringBuilder();
                                    //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框:{2}函数出现错误,请在该区域中删除该字段. 数据源表名:{3}, 数据源值字段名:{4},数据源文本字段名:{5}.错误信息:[{6}]",
                                    //    objViewInfoENEx.ViewName, "查询区域", strDS_DataValueField, strDsTabName, strDS_DataValueField, strDS_DataTextField,
                                    //    objException.Message);
                                    //    throw new Exception(sbMsg.ToString());
                                    //}
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n /// <summary>");
                                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n /// </summary>");
                                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataValueField);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n /// <summary>");
                                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n /// </summary>");
                                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataValueField);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenDdlBindFunction4Page_Load()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.InUse == false) continue;
                //        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                //            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                //        }
                //    }
                //}


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0}_q);",
                                        objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}

                            //strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindDdl_{0}(ddl{1}_q);",
                            //        objFieldTab_ValueField.FldName,
                            //        objQryRegionFldsEx.FldName,
                            //        objPrjTabEN_CodeTab.TabName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        ///操作文件控件的控制层代码;
        public string GenFileCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;


            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "OptFile";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptFile.ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;

            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlCsFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		wuc{0} 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0} : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region 控件页面启动函数");

                ///生成用户自定义控件界面中Page_Load代码;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion 控件页面启动函数");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                        objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///如果控件类型是文本框;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;

                            default:
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                        break;
                    }
                }
                strCodeForCs.Append("\r\n" + "");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                    strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", "txt" + objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                    objEditRegionFldsEx.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                objEditRegionFldsEx.CtrlId);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///如果控件类型是文本框;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;

                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                ///校验自定义控件中自子控件的类型数值是否是合法正确的;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 校验自定义控件中自子控件的类型数值是否是合法正确的。");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、首先校验类型:整型、浮点型、日期型等,");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		2、校验最值,即最大值和最小值等");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		这些生成内容可以修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                        objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                        objEditRegionFldsEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                ///设置该控件在插入状态下的缺省值;
                ///

                strCodeForCs.Append("\r\n" + Gen_Wuc_CS_SetDefaultValue());
                ///获取当前日期的字符串以及获取当前月的字符串;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:获取当前日期的字符串");
                strCodeForCs.Append("\r\n /// 日期格式:");
                strCodeForCs.Append("\r\n /// 日期的字符串的格式有三种:");
                strCodeForCs.Append("\r\n ///		1、YYYYMMDD。	例如20050120");
                strCodeForCs.Append("\r\n ///		2、YYYY-MM-DD	例如2005-01-20");
                strCodeForCs.Append("\r\n ///		3、YYYY/MM/DD	例如2005/01/20");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intFormat\">日期格式,共有3种,传入参数0,1,2");
                strCodeForCs.Append("\r\n ///							参数不同,函数返回值就不同,");
                strCodeForCs.Append("\r\n ///							参见上面的日期格式");
                strCodeForCs.Append("\r\n ///	</param>");
                strCodeForCs.Append("\r\n /// <returns>返回当前日期的字符串</returns>");
                strCodeForCs.Append("\r\n" + "public string getTodayStr(int intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strToday;");
                strCodeForCs.Append("\r\n" + "string strYear, strMonth, strDay;");
                strCodeForCs.Append("\r\n" + "int intYear, intMonth, intDay;");
                strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
                strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
                strCodeForCs.Append("\r\n" + "intDay = System.DateTime.Today.Day;");
                strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intDay>9) strDay = intDay.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strDay = \"0\" + intDay.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
                strCodeForCs.Append("\r\n" + "switch(intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case 0:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 1:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + \"-\" + strMonth + \"-\" + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 2:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + \"/\" + strMonth + \"/\" + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strToday;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:获取当前月的字符串");
                strCodeForCs.Append("\r\n /// 月的格式:");
                strCodeForCs.Append("\r\n /// 月的字符串的格式有三种:");
                strCodeForCs.Append("\r\n ///		1、YYYYMM。	例如200501");
                strCodeForCs.Append("\r\n ///		2、YYYY-MM-DD	例如2005-01");
                strCodeForCs.Append("\r\n ///		3、YYYY/MM/DD	例如2005/01");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intFormat\">月的格式,共有3种,传入参数0,1,2");
                strCodeForCs.Append("\r\n ///							参数不同,函数返回值就不同,");
                strCodeForCs.Append("\r\n ///							参见上面的月的格式");
                strCodeForCs.Append("\r\n ///	</param>");
                strCodeForCs.Append("\r\n /// <returns>返回当前月的字符串</returns>");
                strCodeForCs.Append("\r\n" + "public string getCurrMonth(int intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCurrMonth;");
                strCodeForCs.Append("\r\n" + "string strYear, strMonth;");
                strCodeForCs.Append("\r\n" + "int intYear, intMonth;");
                strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
                strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
                strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
                strCodeForCs.Append("\r\n" + "switch(intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case 0:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 1:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"-\" + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 2:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"/\" + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strCurrMonth;");
                strCodeForCs.Append("\r\n" + "}");
                ///生成界面中下拉框的BIND函数,即添加下拉框列表项的函数;
                strTemp = GenDdlBindFunction();
                strCodeForCs.Append(strTemp);

                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS4QueryEdit(this, this.strBaseUrl));
                    }
                    else
                    {
                        //strCodeForCs.Append("\r\n" + objInfor.GC_SetBindDdl());
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGetDataFromClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:protected void GetDataFromClass;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n ///   如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}\">表实体类对象</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n /// 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            continue;
                        }
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ".ToString();");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ";");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n /// 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">表实体类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenInsRecControlCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "B_I";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "B_I.aspx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;


            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                /// strCodeForCs.Append("///生成插入记录的界面代码");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");

                //生成权限相关的界面ID
                strCodeForCs.Append("\r\n" + GenPotenceRelaVar());
                strCodeForCs.Append("\r\n" + "");
                //生成界面中Page_Load代码;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n ///0、获取操作类型");
                strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "if (Request.QueryString[\"OperateType\"] == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"ADD\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (Request.QueryString[\"OperateType\"].ToString() == \"ADD\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"ADD\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"UPDATE\";");
                strCodeForCs.AppendFormat("\r\n" + "{0} = Request.QueryString[\"{1}\"].ToString();",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}))",
                objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = \"被修改记录的关键字值为空,请检查!\";");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = clsCommonSession.ParentPage;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                // 生成权限有关判断权限的代码
                strCodeForCs.Append("\r\n" + GenPotenceRelaCode());

                //生成编辑区域的下拉框绑定代码---------------------------

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.InUse == false) continue;
                //        if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                //        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                //        objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                //    }
                //    strCodeForCs.Append("\r\n" + "//2、根据不同的操作类型(OperateType)做相应的操作");
                //    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();", objViewInfoENEx.TabName);
                //    //生成编辑区域的下拉框绑定代码 == == == == == == == == == == == == == = 

                //}
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把以该关键字的记录内容显示在界面上,");
                strCodeForCs.Append("\r\n ///　　　 在这里是把值传到表控件中");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                objKeyField.PrivFuncName);

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{

                //    //生成确定修改的事件函数;
                //    strCodeForCs.Append("\r\n /// <summary>");
                //    strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                //    strCodeForCs.Append("\r\n /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                //    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //    strCodeForCs.Append("\r\n /// </summary>");
                //    strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                //    strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                //    strCodeForCs.Append("\r\n" + "protected void btnSubmit_Click(object sender, System.EventArgs e)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.Append("\r\n" + "string strCommandText;");
                //    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                //    strCodeForCs.Append("\r\n" + "Button btnTemp;");
                //    strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                //    strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                //    strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                //    {

                //        strCodeForCs.Append("\r\n" + "case \"添加\":");
                //        strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                //        objViewInfoENEx.TabName);

                //        strCodeForCs.Append("\r\n" + "break;				");
                //        strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                //        strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                //        strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                //        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.Append("\r\n" + "//返回到调用添加界面的父界面");
                //        strCodeForCs.Append("\r\n" + "//Response.Redirect(clsCommonSession.ParentPage);");
                //        strCodeForCs.Append("\r\n" + "break;");
                //    }
                //    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //    {
                //        strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                //        strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                //        strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.Append("\r\n" + "//返回到调用修改界面的父界面");
                //        strCodeForCs.Append("\r\n" + "Response.Redirect(clsCommonSession.ParentPage);");

                //        strCodeForCs.Append("\r\n" + "break;");
                //    }
                //    strCodeForCs.Append("\r\n" + "}");
                //    strCodeForCs.Append("\r\n" + "}");
                //}
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //显示列表区域
                //    // strTemp = Gen_lbDispTableList_Click();
                //    strTemp = Gen_btnCancelEdit_Click();
                //    strCodeForCs.Append(strTemp);
                //}
                //strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + "}");

                ////生成专门用于用户自定义函数的类----------------------------
                //strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                //strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
                //     || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                //{
                //    strCodeForCs.Append("\r\n" + GenShowDataCode());
                //}

                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenPotenceLevelProperty());
                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenLoginUserSession());

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                //{
                //    /// 生成父对象的SESSION相关属性函数
                //    strCodeForCs.Append("\r\n" + GenParentObjSeesionProp());
                //}
                // 生成专门用于记录GridView中的每页记录数
                strCodeForCs.Append("\r\n" + GenPageSizeViewState());
                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());
                //生成把类对象的属性内容显示到界面上----------------------;
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    ///生成把类对象的属性内容显示到界面上;
                //    strTemp = GenGetDataFromClass();
                //    strCodeForCs.Append(strTemp);
                //}
                ////生成把类对象的属性内容显示到界面上 == == == == == == == == == == == 

                ////生成把界面上的属性数据传到类对象中的代码----------------------;
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //生成把界面上的属性数据传到类对象中的代码;
                //    strTemp = GenPutDataToClass();
                //    strCodeForCs.Append(strTemp);
                //}
                //生成把界面上的属性数据传到类对象中的代码 == == == == == == == == == == == 

                //生成与添加相关的代码---------------------------------
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                //{
                //    //添加记录准备过程
                //    strTemp = GenAddRecordCode();
                //    strCodeForCs.Append(strTemp);

                //    //添加记录存盘过程
                //    strTemp = GenAddRecordSaveCode(objViewInfoENEx, false);
                //    strCodeForCs.Append(strTemp);

                //    ////添加记录存盘过程V5版
                //    //strTemp = GenAddRecordSaveCodeV5(objViewInfoENEx, false);
                //    //strCodeForCs.Append(strTemp);
                //}
                //生成与添加相关的代码 == == == == == == == == == == == 

                //生成与修改相关的代码---------------------------------
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //修改记录准备过程
                //    strTemp = GenUpdateRecordCode();
                //    strCodeForCs.Append(strTemp);
                //    //修改记录存盘过程
                //    strTemp = GenUpdateRecordSaveCode(objViewInfoENEx, false);
                //    strCodeForCs.Append(strTemp);
                //    ////修改记录存盘过程V5版
                //    //strTemp = GenUpdateRecordSaveCodeV5(objViewInfoENEx, false);
                //    //strCodeForCs.Append(strTemp);
                //}
                //生成与修改相关的代码 == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "}");
                //生成专门用于用户自定义的函数 == == == == == == == == == == == == == == == == == == = 

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
        //修改添加的控制层的生成代码
        public string GenUpdInsRecControlCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "_UI.aspx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                // strCodeForCs.Append("///生成插入记录的界面代码");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");

                //生成权限相关的界面ID
                strCodeForCs.Append("\r\n" + GenPotenceRelaVar());
                strCodeForCs.Append("\r\n" + "");
                //生成界面中Page_Load代码;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n ///0、获取操作类型");
                strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "if (Request.QueryString[\"OperateType\"] == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"ADD\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (Request.QueryString[\"OperateType\"].ToString() == \"ADD\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"ADD\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonSession.OperateType = \"UPDATE\";");
                strCodeForCs.AppendFormat("\r\n" + "{0} = Request.QueryString[\"{1}\"].ToString();",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}))",
                objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = \"被修改记录的关键字值为空,请检查!\";");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = clsCommonSession.ParentPage;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                // 生成权限有关判断权限的代码
                strCodeForCs.Append("\r\n" + GenPotenceRelaCode());

                //生成编辑区域的下拉框绑定代码---------------------------

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.InUse == false) continue;
                //        if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                //        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                //        objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                //    }
                //    strCodeForCs.Append("\r\n" + "//2、根据不同的操作类型(OperateType)做相应的操作");
                //    strCodeForCs.Append("\r\n" + "if (clsCommonSession.OperateType == \"UPDATE\")");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "Update{1}Record({0});",
                //    objKeyField.PrivFuncName,
                //    objViewInfoENEx.TabName);
                //    strCodeForCs.Append("\r\n" + "//3、设置表控件中字控件的ReadOnly属性,");
                //    strCodeForCs.Append("\r\n" + "// 使之只读,因为在修改功能中关键字是不能被修改的。");

                //    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                //    {
                //        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);", objViewInfoENEx.TabName);
                //    }
                //    strCodeForCs.Append("\r\n" + "}");
                //    strCodeForCs.Append("\r\n" + "else");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();", objViewInfoENEx.TabName);
                //    strCodeForCs.Append("\r\n" + "}");
                //    //生成编辑区域的下拉框绑定代码 == == == == == == == == == == == == == = 

                //}
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把以该关键字的记录内容显示在界面上,");
                strCodeForCs.Append("\r\n ///　　　 在这里是把值传到表控件中");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                objKeyField.PrivFuncName);

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{

                //    //生成确定修改的事件函数;
                //    strCodeForCs.Append("\r\n /// <summary>");
                //    strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                //    strCodeForCs.Append("\r\n /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                //    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //    strCodeForCs.Append("\r\n /// </summary>");
                //    strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                //    strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                //    strCodeForCs.Append("\r\n" + "protected void btnOKUpd_Click(object sender, System.EventArgs e)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.Append("\r\n" + "string strCommandText;");
                //    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                //    strCodeForCs.Append("\r\n" + "Button btnTemp;");
                //    strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                //    strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                //    strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                //    {

                //        strCodeForCs.Append("\r\n" + "case \"添加\":");
                //        strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                //        objViewInfoENEx.TabName);

                //        strCodeForCs.Append("\r\n" + "break;				");
                //        strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                //        strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                //        strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                //        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.Append("\r\n" + "//返回到调用添加界面的父界面");
                //        strCodeForCs.Append("\r\n" + "//Response.Redirect(clsCommonSession.ParentPage);");
                //        strCodeForCs.Append("\r\n" + "break;");
                //    }
                //    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //    {
                //        strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                //        strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                //        strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                //        objViewInfoENEx.TabName);
                //        strCodeForCs.Append("\r\n" + "//返回到调用修改界面的父界面");
                //        strCodeForCs.Append("\r\n" + "Response.Redirect(clsCommonSession.ParentPage);");

                //        strCodeForCs.Append("\r\n" + "break;");
                //    }
                //    strCodeForCs.Append("\r\n" + "}");
                //    strCodeForCs.Append("\r\n" + "}");
                //}

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //生成专门用于用户自定义函数的类----------------------------
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                //{
                //    strCodeForCs.Append("\r\n" + GenShowDataCode());
                //}

                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenPotenceLevelProperty());
                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenLoginUserSession());

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                //{
                //    /// 生成父对象的SESSION相关属性函数
                //    strCodeForCs.Append("\r\n" + GenParentObjSeesionProp());
                //}
                // 生成专门用于记录GridView中的每页记录数
                strCodeForCs.Append("\r\n" + GenPageSizeViewState());
                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());
                //生成把类对象的属性内容显示到界面上----------------------;
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    ///生成把类对象的属性内容显示到界面上;
                //    strTemp = GenGetDataFromClass();
                //    strCodeForCs.Append(strTemp);
                //}
                ////生成把类对象的属性内容显示到界面上 == == == == == == == == == == == 

                ////生成把界面上的属性数据传到类对象中的代码----------------------;
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //生成把界面上的属性数据传到类对象中的代码;
                //    strTemp = GenPutDataToClass();
                //    strCodeForCs.Append(strTemp);
                //}
                //生成把界面上的属性数据传到类对象中的代码 == == == == == == == == == == == 

                //生成与添加相关的代码---------------------------------
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                //{
                //    //添加记录准备过程
                //    strTemp = GenAddRecordCode();
                //    strCodeForCs.Append(strTemp);

                //    //添加记录存盘过程
                //    strTemp = GenAddRecordSaveCode(objViewInfoENEx, false);
                //    strCodeForCs.Append(strTemp);

                //    ////添加记录存盘过程V5版
                //    //strTemp = GenAddRecordSaveCodeV5(objViewInfoENEx, false);
                //    //strCodeForCs.Append(strTemp);
                //}
                //生成与添加相关的代码 == == == == == == == == == == == 

                //生成与修改相关的代码---------------------------------
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //修改记录准备过程
                //    strTemp = GenUpdateRecordCode();
                //    strCodeForCs.Append(strTemp);
                //    //修改记录存盘过程
                //    strTemp = GenUpdateRecordSaveCode(objViewInfoENEx, false);
                //    strCodeForCs.Append(strTemp);
                //    ////修改记录存盘过程V5版
                //    //strTemp = GenUpdateRecordSaveCodeV5(objViewInfoENEx, false);
                //    //strCodeForCs.Append(strTemp);
                //}
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //|| objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    //显示列表区域
                //    // strTemp = Gen_lbDispTableList_Click();
                //    strTemp = Gen_btnCancelEdit_Click();
                //    strCodeForCs.Append(strTemp);
                //}
                //生成与修改相关的代码 == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "}");
                //生成专门用于用户自定义的函数 == == == == == == == == == == == == == == == == == == = 

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenPicCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;


            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "OptPic";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptPic.ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:显示图片。显示与关键字相关记录的图片");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
                objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "public void ShowPic({0} {1})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//用于WEB显示的文件路径,即URL");
                strCodeForCs.Append("\r\n" + "string strWebFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strWebFileDir\"];");
                strCodeForCs.Append("\r\n" + "//用于上传文件时,在WEB服务器上文件的目录");
                strCodeForCs.Append("\r\n" + "string strUploadFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strUploadFileDir\"];");
                strCodeForCs.Append("\r\n" + "//用于下载文件时,在WEB服务器上文件的目录");
                strCodeForCs.Append("\r\n" + "string strDownloadFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strDownloadFileDir\"];");
                strCodeForCs.Append("\r\n" + "//文件的最大长度");
                strCodeForCs.Append("\r\n" + "long lngMaxFileSize = long.Parse(System.Configuration.ConfigurationManager.AppSettings[\"lngMaxFileSize\"]);");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "imgPic.ImageUrl = \"\";");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == true)",
                objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}({1});",
                objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.Get{0}(obj{0}EN);",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strFileName = obj{0}EN.FileName;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (strFileName != \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName = strDownloadFileDir + strFileName;");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.GetFileFromTabField(strDownLoadFileName);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "imgPic.ImageUrl = strWebFileDir + strFileName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "protected void btnBrowPic_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//用于WEB显示的文件路径,即URL");
                strCodeForCs.Append("\r\n" + "string strWebFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strWebFileDir\"];");
                strCodeForCs.Append("\r\n" + "//用于上传文件时,在WEB服务器上文件的目录");
                strCodeForCs.Append("\r\n" + "string strUploadFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strUploadFileDir\"];");
                strCodeForCs.Append("\r\n" + "//用于下载文件时,在WEB服务器上文件的目录");
                strCodeForCs.Append("\r\n" + "string strDownloadFileDir = System.Configuration.ConfigurationManager.AppSettings[\"strDownloadFileDir\"];");
                strCodeForCs.Append("\r\n" + "//文件的最大长度");
                strCodeForCs.Append("\r\n" + "long lngMaxFileSize = long.Parse(System.Configuration.ConfigurationManager.AppSettings[\"lngMaxFileSize\"]);");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "string strUpLoadFileName = \"\";");
                strCodeForCs.Append("\r\n" + "string strIsSuccess = \"FALSE\";		//用来判断上断文件是否成功,即把文件从浏览器传到WEB服务器是否成功");
                strCodeForCs.Append("\r\n" + "string strFileName = \"\";");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                strCodeForCs.Append("\r\n" + "if (( flBrowFile.PostedFile != null) && (flBrowFile.PostedFile.ContentLength > 0))");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.Append("\r\n" + "//检验文件,文件不能为空和长度要大于0");
                strCodeForCs.Append("\r\n" + "strFileName = System.IO.Path.GetFileName(flBrowFile.PostedFile.FileName);");
                strCodeForCs.Append("\r\n" + "strUpLoadFileName = strUploadFileDir + strFileName;");
                strCodeForCs.Append("\r\n ///如果相关子目录不存在就新建子目录");
                strCodeForCs.Append("\r\n" + "if (System.IO.Directory.Exists(strUploadFileDir) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "Directory.CreateDirectory(strUploadFileDir);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (flBrowFile.PostedFile.ContentLength <= lngMaxFileSize) ");
                strCodeForCs.Append("\r\n" + "{ //保存文件");
                strCodeForCs.Append("\r\n" + "flBrowFile.PostedFile.SaveAs(strUpLoadFileName);");
                strCodeForCs.Append("\r\n" + "strIsSuccess = \"TRUE\";");
                strCodeForCs.Append("\r\n" + "Session.Add(\"strUpLoadFileName\", strUpLoadFileName);");
                strCodeForCs.Append("\r\n" + "this.imgPic.ImageUrl = strWebFileDir + strFileName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else //拒绝文件");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Visible = true;");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"文件大小超出限制 \" + lngMaxFileSize ;//label显示文件超过限制");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception a) //出现错误");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Visible = true;");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = a.Message.ToString();");
                strCodeForCs.Append("\r\n" + "DeleteFile(strWebFileDir + strFileName);//报错,并删除文件");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "Session.Add(\"strIsSuccess\", strIsSuccess);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "protected bool StoreFile()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUpLoadFileName = (string)Session[\"strUpLoadFileName\"];");
                strCodeForCs.Append("\r\n" + "string strFileName = System.IO.Path.GetFileName(strUpLoadFileName);");
                strCodeForCs.Append("\r\n" + "string strIsSuccess = (string)Session[\"strIsSuccess\"];");
                strCodeForCs.Append("\r\n" + "if (strIsSuccess == \"TRUE\")		//上传文件成功");
                strCodeForCs.Append("\r\n" + "{ //检验文件,文件不能为空和长度要大于0");
                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = ({0})Session[\"{1}\"];",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null)",
                objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = \"请先存储相关记录!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}({1});",
                objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.FileName = strFileName;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({2}))		//如果存在该记录,则修改",
                objViewInfoENEx.TabName, strKeyFldName_ObjName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else							//如果不存在该记录,则添加");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecordBySQL();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.StoreFileToTabField(strUpLoadFileName) == true)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Visible = true;");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"上传成功!\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Visible = true;");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"上传失败!\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else //上传文件成功");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Visible = true;");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"请先预览\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "protected void btnUpLoadPic_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "StoreFile();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "protected void DeleteFile (string strFileName) //删除上传文件");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (strFileName.Trim().Length > 0) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "FileInfo fi = new FileInfo(strFileName);");
                strCodeForCs.Append("\r\n" + "if (fi.Exists) //如果文件存在,删除文件");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.Append("\r\n" + "fi.Delete();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenPrivateVarCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成私有代码;
                strCodeForCs.Append("生成私有代码for C#");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    /// strCodeForCs.Append("\r\n" + objEditRegionFldsEx.objPrjTabFldENEx.CsType + " " + objEditRegionFldsEx.DataTypeAbbr + objEditRegionFldsEx.FldName + " = new " + objEditRegionFldsEx.objPrjTabFldENEx.CsType);
                    strCodeForCs.Append("\r\n" + objEditRegionFldsEx.ObjFieldTabENEx.CsType() + " " + objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr + objEditRegionFldsEx.FldName + ";");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_SetDdl_FldName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成私有代码;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框,针对字段:[{0}]",
                          objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()",
                       objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0});",
                                    objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框,针对字段:[{0}]",
                          objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()",
                        objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindDdl_{0}({1});",
                        objEditRegionFldsEx.ObjFieldTabENEx.CodeTabCode,
                        objEditRegionFldsEx.CtrlId,
                        objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                        strCodeForCs.Append("\r\n" + "}");
                    }

                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_SetDefaultValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置该控件在插入状态下的缺省值");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、如果是整型就默认为0；");
                strCodeForCs.Append("\r\n ///		2、如果是浮点型不默认为0.0；");
                strCodeForCs.Append("\r\n ///		3、如果是日期型就默认为当前的日期；");
                strCodeForCs.Append("\r\n ///		4、如果是位(bit)型就默认为false;");
                strCodeForCs.Append("\r\n ///		这些默认值可以再行修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                            objEditRegionFldsEx.CtrlId);
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox": ///如果控件类型是文本框;
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                objEditRegionFldsEx.CtrlId, strInitValue);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                 objEditRegionFldsEx.CtrlId, strInitValue);
                            break;

                    }

                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_IsValid()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成私有代码;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 校验自定义控件中自子控件的类型数值是否是合法正确的。");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、首先校验类型:整型、浮点型、日期型等,");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		2、校验最值,即最大值和最小值等");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		这些生成内容可以修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DropDownList_06) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "long" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                        objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                        objEditRegionFldsEx.FldName);
                    }
                }
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的整型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的浮点型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的日期型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                objEditRegionFldsEx.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                objEditRegionFldsEx.CtrlId,
                                objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                            }
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                            objEditRegionFldsEx.CtrlId);
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox": ///如果控件类型是文本框;

                            if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                objEditRegionFldsEx.CtrlId, strInitValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                               objEditRegionFldsEx.CtrlId, strInitValue);
                            break;
                    }

                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_SetKeyReadOnly()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.FldName
                         == objKeyField.ObjFieldTabENEx.FldName)
                        {
                            strCodeForCs.Append("\r\n" + "/// <summary>");
                            strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n" + "/// </summary>");
                            strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                            strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_FieldProperty4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成私有代码;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    ///
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}",
                    objEditRegionFldsEx.LabelCaption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");

                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;

                        case "DropDownList": ///如果控件是下拉框;
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex == 1)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "return true;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "return false;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == true)");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                            || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bigint"
                            || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short"
                           )
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return 0;");
                                strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                                objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.CsType());
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == 0)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "HyperLink":
                            break;

                        case "Image":
                            break;

                        case "ImageButton":
                            break;

                        case "Label":
                            break;

                        case "Link1Button":
                            break;

                        case "ListBox":
                            break;

                        case "Panel":
                            break;

                        case "RadioButton":
                            break;

                        case "RadioButtonList":
                            break;

                        case "TextBox": ///如果控件类型是文本框;
                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                            {
                                case "int":
                                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "short":
                                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "double":

                                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "DateTime":

                                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "bool":
                                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "float":
                                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "long":
                                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:

                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                            {
                                case "int":
                                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "short":
                                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "double":
                                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "DateTime":
                                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "bool":
                                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "float":
                                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "long":
                                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");

                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenPutDataToClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ///1生成从界面层到逻辑层的数据传输函数代码");
                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:protected void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            continue;
                        }
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "if (txt{0}.Text.Trim() == \"\")", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = 0;\\(字段类型:{2},字段长度:{3},是否可空:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = int.Parse(" + objEditRegionFldsEx.CtrlId + ".Text);");

                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = " + objEditRegionFldsEx.CtrlId + ".Text;");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }

                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把界面上的属性数据传到类对象中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">数据传输的目的类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    int intIndex = 0;
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        intIndex++;
                        if (objEditRegionFldsEx.InUse == false) continue;
                        string strTemp = "";
                        if (intIndex == 1)
                        {
                            strTemp = GetCode4FieldInPutDataToClass_First(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else if (intIndex == objViewInfoENEx.arrEditRegionFldSet4InUse.Count)
                        {
                            strTemp = GetCode4FieldInPutDataToClass_Last(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else
                        {
                            strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

       
       
        public string GenQueryRecControlCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;


            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;


            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "B_Q";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "B_Q.aspx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));
                strCodeForCs.Append("\r\n ///生成查询修改记录的控制层代码");
                strCodeForCs.Append("\r\n" + GenRefDomainName());

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");

                //生成权限相关的界面ID
                strCodeForCs.Append("\r\n" + GenPotenceRelaVar());

                strCodeForCs.Append("\r\n" + "");
                ///生成界面中Page_Load代码;               
                strCodeForCs.Append("\r\n" + "#region 页面启动函数");
                strTemp = GenPage_LoadCode(objViewInfoENEx, false);
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");

                ///生成查询按钮的事件函数代码;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//把GridView的当前页索引设置为0,即第1页。");
                strCodeForCs.Append("\r\n" + "//当单击查询时,首先显示的是表记录内容的第一部分内容。");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = 0;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//把表记录的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///生成在更改GridView的当前页索引时激发的函数;
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。");
                //strCodeForCs.Append("\r\n ///			 具体功能是重新显示新页(所单击页索引)的内容。");
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"source\"></param>");
                //strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                //strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)",
                //objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "//操作步骤:(共2步)");
                //strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                //strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                //strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                //strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = e.NewPageIndex;",
                //objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                //strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                //objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                ///生成与GridView排序相关的代码;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_Sorting(objViewInfoENEx, false);
                    strCodeForCs.Append(strTemp);
                    //									
                    //					strTemp = Gen_GridView_RowCreated();
                    //					strCodeForCs.Append(strTemp);
                }

                //生成导出Excel文件的代码
                strCodeForCs.Append("\r\n" + GenbtnExportExcel4Gv_Click2());

                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenJumpPage_RelaFunction(objViewInfoENEx, false));
                    /// 生成改变GridView中每页记录数的下拉框相关函数
                    strCodeForCs.Append("\r\n" + GenddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, false));

                }



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView的行建立事件过程
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, false);
                    strCodeForCs.Append(strTemp);
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)
                {
                    //GridView的行修改事件过程
                    strTemp = Gen_GridView_RowUpdating(objViewInfoENEx, false);
                    strCodeForCs.Append(strTemp);
                }
                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView的页号改变事件过程
                    strTemp = Gen_GridView_PageIndexChanging(objViewInfoENEx, false);
                    strCodeForCs.Append(strTemp);
                }


                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //生成用于用户自定义的函数---------------------------------------
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");


                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenPotenceLevelProperty());
                // 生成权限有关权限等级的代码
                strCodeForCs.Append("\r\n" + GenLoginUserSession());

                /// 生成父对象的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenParentObjSeesionProp());

                // 生成专门用于记录GridView中的每页记录数
                strCodeForCs.Append("\r\n" + GenPageSizeViewState());

                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());


                ///生成把所有的查询控件内容组合成一个条件串;
                strTemp = GenCombineCondition();
                strCodeForCs.Append(strTemp);
                ///生成根据界面上查询控件中所设置内容查询表记录,并显示在GridView中;
                strTemp = GenBindGridView();
                strCodeForCs.Append(strTemp);
                ///生成界面中下拉框的BIND函数,即添加下拉框列表项的函数;
                strTemp = GenDdlBindFunction4QueryRegion();
                strCodeForCs.Append(strTemp);


                //生成导出Excel文件的代码
                strCodeForCs.Append("\r\n" + GenExportExcel());

                strCodeForCs.Append("\r\n" + "}");
                //生成用于用户自定义的函数 == == == == == == == == == == == == == == == == == == == = 
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        protected string GenProtectedVarNameList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成查询区域中所用控件变量;
                //strCodeForCs.Append("\r\n ///生成控制层的控件变量名列表");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
        protected string GenRefDomainName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Text;");
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
      
      
        public string GenTransDataBetweenViewAndClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成删除记录代码;
                strCodeForCs.Append("///生成从逻辑层<-->界面层的数据传输函数代码");
                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:protected void GetDataFromClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ".ToString();");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ";");
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    ///从类中取数据传给窗体:protected void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "if (txt{0}.Text.Trim() == \"\")", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = 0;", objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = int.Parse(" + objEditRegionFldsEx.CtrlId + ".Text);");
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = " + objEditRegionFldsEx.CtrlId + ".Text;");
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///生成修改记录代码;
        public string GenUpdateRecCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成修改记录代码;
                strCodeForCs.Append("\r\n ///生成修改记录代码");
                strCodeForCs.Append("\r\n ///这是一个单表的修改记录的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//2、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//3、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.Append("\r\n" + "//1、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//2、检查传进去的对象属性是否合法");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.CheckProperty(ref strResult) == false)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strResult);");
                strCodeForCs.Append("\r\n" + "return ; ");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3、把数据实体层的数据修改同步到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Update() == false) ", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update", "修改记录不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})修改记录不成功!\";", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录不成功!\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenUpdRecControlCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;


            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "B_U";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "B_U.aspx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n ///生成查询修改记录的控制层代码");
                /// strCodeForCs.Append("///生成插入记录的界面代码");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                //生成界面中Page_Load代码;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(总共5步)");
                strCodeForCs.Append("\r\n" + "//1、判空。检查Session的关键字内容是否为空,");
                strCodeForCs.Append("\r\n /// 如为空则返回首页或其他调用页(上一页)");
                strCodeForCs.Append("\r\n" + "//2、为下拉框设置数据源");
                strCodeForCs.Append("\r\n" + "//3、获取需要修改的关键字值。");
                strCodeForCs.Append("\r\n ///　　该值往往通过Session来传递。");
                strCodeForCs.Append("\r\n" + "//4、显示该关键字记录的内容在界面上；");
                strCodeForCs.Append("\r\n" + "//5、清空提示信息的内容；");
                strCodeForCs.Append("\r\n" + "//6、设置表控件中字控件的ReadOnly属性,");
                strCodeForCs.Append("\r\n" + "// 使之只读,因为在修改功能中关键字是不能被修改的。");
                strCodeForCs.Append("\r\n" + "StringBuilder strSB = new StringBuilder();");
                strCodeForCs.Append("\r\n" + "string strMsg;");
                strCodeForCs.Append("\r\n" + "//1、判空。检查Session的关键字内容是否为空,");
                strCodeForCs.Append("\r\n /// 如为空则返回首页或其他调用页(上一页)");
                strCodeForCs.AppendFormat("\r\n" + "if (Session[\"{0}\"] == null)",
                objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"被修改记录的关键字为空,修改出错!\";");
                strCodeForCs.Append("\r\n" + "strSB.AppendFormat(\"<script>alert('{0}')</script>\", strMsg);");
                strCodeForCs.Append("\r\n ///因为Session的关键字值为空,所以不能继续修改,");
                strCodeForCs.Append("\r\n ///只能返回首页(index.htm)或其他页,在这里以index.htm作为首页的例子。");
                strCodeForCs.Append("\r\n" + "strSB.AppendFormat(\"<script language = 'javascript'> parent.window.location.href = '{0}'</script>\", \"index.htm\");");
                strCodeForCs.Append("\r\n" + "Response.Write(strSB);");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、为下拉框设置数据源");
                strCodeForCs.AppendFormat("\r\n ///例如wuc{0}B1.SetDdl_TabName();",
                objViewInfoENEx.TabName);
                ///生成界面中下拉框的列表项添加内容;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                }
                strCodeForCs.Append("\r\n" + "//3、获取需要修改的关键字值。");
                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Session[\"{2}\"].ToString();",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "//4、显示该关键字记录的内容在界面上；");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//5、清空提示信息的内容；");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                strCodeForCs.Append("\r\n" + "//6、设置表控件中字控件的ReadOnly属性,");
                strCodeForCs.Append("\r\n" + "// 使之只读,因为在修改功能中关键字是不能被修改的。");
                strCodeForCs.Append("\r\n /// 如果主键是标识递增型就不需要判断是否存在。");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode());
                }

                ///生成把类对象的属性内容显示到界面上;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);
                //生成确定修改的事件函数;
                strTemp = GenbtnOKUpd_ClickCode();
                strCodeForCs.Append(strTemp);

                //生成把界面上的属性数据传到类对象中的代码;
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);

                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    //修改记录准备过程
                    strTemp = GenUpdateRecordCode();
                    strCodeForCs.Append(strTemp);
                    //修改记录存盘过程
                    strTemp = GenUpdateRecordSaveCode(objViewInfoENEx, false);
                    strCodeForCs.Append(strTemp);
                    ////修改记录存盘过程V5版
                    //strTemp = GenUpdateRecordSaveCodeV5(objViewInfoENEx, false);
                    //strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#region 错误处理函数");

                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());


                strCodeForCs.Append("\r\n" + "#endregion 错误处理函数");


                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //生成插入记录准备过程代码
        public string GenAddRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}Record()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(false);",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消添加\";",
                objViewInfoENEx.TabName);

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = cls{0}BL.GetMaxStrId_S();",
                objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成插入记录存盘过程代码
      
        //生成修改记录准备过程代码
        public string GenUpdateRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //生成修改记录准备过程代码 for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void Update{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "//操作步骤:(总共2步)");
                strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消修改\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成修改存盘准备过程代码
        public string GenUpdateRecordSaveCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSave(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!wuc{0}B1.IsValid(ref strResult))",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                //检查唯一性------------------------------------------------------

                string strDuplicateInfo = "";
                bool bolIsFirst = true;
                //检查唯一性------------------------------------------------------
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})",
                                  objEditRegionFldsEx.LabelCaption,
                                objEditRegionFldsEx.FldName);
                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})",
                              objEditRegionFldsEx.LabelCaption,
                               objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"({0})不能重复!\";",
                           strDuplicateInfo);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");

                }
                //检查唯一性 == == == == == == == == == == == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录不成功!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录成功!\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {

                    strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.Clear();//添空控件中的内容",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消编辑\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//跳转到列表中刚刚的记录处,使用锚点功能。");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                            objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);


                strCodeForCs.Append("\r\n" + "return true; ");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成修改存盘准备过程代码
        public string GenUpdateRecordSaveCodeV5Baked0180429(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            //暂时不生成原因（删除）,发现和非V5基本是一致的
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中, V5版");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");

                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSaveV5(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!wuc{0}B1.IsValid(ref strResult))",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSaveV5", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                //检查唯一性------------------------------------------------------
                StringBuilder sbErrMsg = new StringBuilder();
                bool bolIsFirst = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            bolIsFirst = false;
                            sbErrMsg.AppendFormat("{0}({1})",
                            objEditRegionFldsEx.LabelCaption,
                            objEditRegionFldsEx.FldName);
                        }
                        else
                        {
                            sbErrMsg.AppendFormat("、{0}({1})",
                             objEditRegionFldsEx.LabelCaption,
                             objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (bolIsFirst == false)
                {
                    strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"{0}不能重复!\";",
                       sbErrMsg.ToString());
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                }

                //检查唯一性 == == == == == == == == == == == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = \"修改记录不成功!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录成功!\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.Clear();//添空控件中的内容",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消编辑\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//跳转到列表中刚刚的记录处,使用锚点功能。");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                          objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);

                strCodeForCs.Append("\r\n" + "return true; ");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //生成删除记录过程代码
        public string GenDelRecordCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //删除记录过程代码for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据给定关键字删除记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定关键字</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.AppendFormat("\r\n" + "protected void Delete{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "删除记录不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})删除记录不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                //strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView页号发生变化时的事件过程
        public string Gen_GridView_PageIndexChanging(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成插入记录代码;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。");
                strCodeForCs.Append("\r\n ///			 具体功能是重新显示新页(所单击页索引)的内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"source\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_PageIndexChanging(object sender, GridViewPageEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共2步)");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (e.NewPageIndex != -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.pageIndex = e.NewPageIndex;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);",
                        objViewInfoENEx.TabName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //生成GridView行建立的事件代码
        public string Gen_GridView_RowCreated()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成插入记录代码;
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,当GeidView行建立时发生的事件,在这里主要处理:数据行中处理删除时显示提示信息,还有在列头显示排序标志。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowCreated(object sender, GridViewRowEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)
                {
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.DataRow)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.LinkButton myDeleteButton;");
                    strCodeForCs.Append("\r\n" + "myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl(\"lbDelete\");");
                    strCodeForCs.Append("\r\n" + "if (myDeleteButton != null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "myDeleteButton.Attributes.Add(\"onclick\", \"return confirm('您真的要删除第 \" + (e.Row.RowIndex + 1).ToString() + \" 行吗？');\");");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)", 
                    //						objViewInfoENEx.TabName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "int intIndex;");
                    strCodeForCs.AppendFormat("\r\n" + "if (vsSort{0}By == \"\") return ;",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strSortEx;");
                    strCodeForCs.AppendFormat("\r\n" + "for(int i = 0;i<this.gv{0}.Columns.Count;i++)",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strSortEx = this.gv{0}.Columns[i].SortExpression;",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if (strSortEx == \"\") continue;");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(strSortEx + \" \");",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if(intIndex >= 0) //视图状态的排序表达式是否为该列的字段；");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "Label lblSort = new Label();");
                    strCodeForCs.Append("\r\n" + "lblSort.Font.Name = \"webdings\";//设置字体,在\"webdings\"中5是上三角,6是下三角；");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\"Asc\");",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "lblSort.Text = (intIndex>0?\" 5\":\" 6\");//是否为升序,而且为string型；");
                    strCodeForCs.Append("\r\n" + "e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；");
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    //					strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView行命令的事件代码
        public string Gen_GridView_RowCommand()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成插入记录代码;
                //        strCodeForCs.Append("\r\n ///生成GridView行命令的事件代码");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,当单击GeidView行中的命令按钮时发生的事件,在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowCommand(object sender, GridViewCommandEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandName = e.CommandName;");
                strCodeForCs.Append("\r\n" + "switch (strCommandName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"lbSelAll\":");
                strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.LinkButton lbSelAll;");
                strCodeForCs.Append("\r\n" + "lbSelAll = (LinkButton)e.CommandSource;");
                strCodeForCs.Append("\r\n" + "if (lbSelAll.CommandName != \"lbSelAll\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (lbSelAll.Text == \"全选\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"不选\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (lbSelAll.Text == \"不选\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"全选\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"NextPage\":");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.Append("\r\n" + "                    if (vsPageIndex < vsPageCount) vsPageIndex += 1;");
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this.Page, objException.Message);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"PrevPage\":");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.Append("\r\n" + "if (vsPageIndex > 1) vsPageIndex -= 1;");
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsWhereCond);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView行删除的事件代码
        public string Gen_GridView_RowDeleting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,进行行删除(RowDeleting)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowDeleting(object sender, GridViewDeleteEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                             objViewInfoENEx.TabName,
                             objPrjTabFldEN.ObjFieldTabENEx.FldName,
                             objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName,
                        objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvDeleteClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");
                    strCodeForCs.AppendFormat("\r\n" + "GvDeleteClick(this, objEventArgs4Delete);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record({1});",
                objViewInfoENEx.TabName,
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        //生成GridView行删除的事件代码
        public string Gen_GridView_RowUpdating(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,当GeidView行单击修改时发生的事件,在这里主要处理:数据行中处理修改相关记录。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowUpdating(object sender, GridViewUpdateEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    if (bolIsInWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (GvUpdateClick != null)");
                        strCodeForCs.Append("\r\n" + "{             ");
                        strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                          objKeyField.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "};");

                        strCodeForCs.AppendFormat("\r\n" + "GvUpdateClick(this, objEventArgs4Update);");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {
                    //strStd1Id = "";
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    objViewInfoENEx.TabName,
                    objKeyField.ObjFieldTabENEx.FldName,
                    objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_GvUpdateClick()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在Gv列表控件中,当GeidView行单击修改时发生的事件。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}1_GvUpdateClick(object sender, clsEventArgs4Update e)",
                        ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);    ////GridView的行删除事件过程
                                                                                //strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, false);
                                                                                //strCodeForCs.Append(strTemp);rjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Update{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_GvDeleteClick()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在Gv列表控件中,当GeidView行单击删除时发生的事件。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}1_GvDeleteClick(object sender, clsEventArgs4Delete e)",
                        ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Delete{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView行删除的事件代码
        public string Gen_lbDispTableList_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:显示表列表记录。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void lbDisp{0}List_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView行删除的事件代码
        public string Gen_btnCancelEdit_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:取消编辑状态,退回到列表状态");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnCancel{0}Edit_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.ViewTypeCode != (int)enumViewTypeCodeTab.Table_Insert_1)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                //    objViewInfoENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成<显示列表、编辑区域>
        /// </summary>
        /// <returns></returns>
        public string GenDispListRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成<显示列表、编辑区域>
        /// </summary>
        /// <returns></returns>
        public string GenDispEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        ///生成修改记录代码;
        public string GenPage_LoadCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用");
                strCodeForCs.Append("\r\n" + "{");
                // 生成权限有关判断权限的代码
                strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + GenDdlBindFunction4Page_Load());

                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{4}1.SetSortBy(string.Format(\"{{0}} Asc\", cls{1}EN.con_{0}));",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, "{", "}", ClsName4WucTabName4Gv());
                }

                strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");
                if (bolIsUseWuc4Gv == true)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    //   objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {

                    strCodeForCs.Append("\r\n" + "//3、设置表控件中字控件的ReadOnly属性,");
                    strCodeForCs.Append("\r\n" + "// 使之只读,因为在修改功能中关键字是不能被修改的。");

                    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "//设置逻辑层的公共函数,包含：缓存刷新函数");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}BL.objCommFun4BL = new clsCommFun4BL4{0}();",
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///生成修改记录代码;
        public string GenPage_LoadCode4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:用户定义控件页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGetPageCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:计算当前页数,根据记录数和每页记录数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">总记录数</param>");
                strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">每页记录数</param>");
                strCodeForCs.Append("\r\n" + "private int GetPageCount(int intRecCount, int intPageSize)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (intRecCount == 0) return 0;");
                strCodeForCs.Append("\r\n" + "int intPageCount = intRecCount / intPageSize;");
                strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize == 0) return intPageCount;");
                strCodeForCs.Append("\r\n" + "return intPageCount + 1;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        ///生成修改记录代码;
        public string GenbtnQuery_ClickCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//把GridView的当前页索引设置为0,即第1页。");
                strCodeForCs.Append("\r\n" + "//当单击查询时,首先显示的是表记录内容的第一部分内容。");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " {0}1.vsPageIndex = 1;",
                        ClsName4WucTabName4Gv());
                    strCodeForCs.AppendFormat("\r\n" + "//把表记录的内容显示在GridView中");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                     objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = 0;", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把表记录的内容显示在GridView中");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        ///生成修改记录代码;
        public string GenbtnOKUpd_ClickCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "Button btnTemp;");
                strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenShowDataCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n ///　　　   在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void ShowData({0})",
                    objViewInfoENEx.KeyVarDefineLstStr);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤:");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                        objKeyField.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                        objKeyField.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                    objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "{");


                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "在表[{1}]中,关键字为:[{0}]的记录不存在!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{2})在表[{1}]中,关键字为:[{0}]的记录不存在!\";",
                      objKeyField.PrivFuncName,
                      objViewInfoENEx.TabName, strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN = new cls{1}EN({2});",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.Get{1}(ref obj{0}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "在显示数据时获取记录对象不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})在显示数据时获取记录对象不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"obj{0}EN\", obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{1}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( wuc{2}B1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(wuc{2}B1.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass_First(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( wuc{2}B1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(wuc{2}B1.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass_Last(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( wuc{2}B1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(wuc{2}B1.{3});",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0003") //只写
            {
                sbCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.{1} = pobj{2}BL.Get{3}();",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.PropertyName(this.IsFstLcase), objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            else if (objEditRegionFldsEx.FldOpTypeId() == "0002") //只读
            {
                sbCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.{1} = pobj{2}EN.{3};",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.PropertyName(this.IsFstLcase), objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.{1} = pobj{2}EN.{3};",
            objViewInfoENEx.TabName, objEditRegionFldsEx.PropertyName(this.IsFstLcase), objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            //switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
            //{
            //    case enumViewTypeCodeTab.Table_Insert_1:// "0001":	//单表插入
            //        return GenInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_Update_2:// "0002":	//单表修改
            //        return GenUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_Query_3:// "0003":	//单表查询
            //        return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    //case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//单表的QUDI
            //    //    return GenQueryUpdDelInsRecControlCodeWithWuc4Gv(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QI_5:// "0005":	//单表的查询插入
            //        return GenQueryInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QU_6:// "0006":	//单表的查询修改
            //        return GenQueryUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QD_7:// "0007":	//单表的查询删除
            //        return GenQueryDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_UI_9:// "0009":	//单表的插入修改
            //        return GenUpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QUD_18:// "0018":	//单表的查询修改删除
            //        return GenQueryUpdDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0019":	//单表的查询删除,调用修改、添加
            //        return GenQueryDel_UpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_List_14:
            //        return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    default:
            //        clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            //        string strMsg = string.Format("界面类型：[{0}({1})]在函数:[{2}]中没有被处理,请联系管理员!",
            //            objViewTypeCodeTabEN.ViewTypeName,
            //            objViewInfoENEx.ViewTypeCode,
            //            clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //}
            return "";
        }


        public string GenbtnGoTop_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoTop_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = ddl{0}_q.SelectedValue;",
                        objInFor.FldName);
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     ClsName4WucTabName4Gv());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTopBy{1}(lst{2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{1});",
                     objViewInfoENEx.TabName,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置顶出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}1.BindGv_{1}(strWhereCond);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}1.SetCheckedItemForGv({1});",
                    ClsName4WucTabName4Gv(), objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnUpMove_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///上移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnUpMove_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MoveRecord(\"UP\");");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenMoveRecord(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///移动记录,包括上移和下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void MoveRecord(string strDirect)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = ddl{0}_q.SelectedValue;",
                        objInFor.FldName);
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = {2}1.GetFirstCheckedKeyFromGv();",
                                     objKeyField.PrivFuncName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     ClsName4WucTabName4Gv());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                                        objKeyField.PrivFuncName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"移动({0})记录出错。错误:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}1.BindGv_{1}(strWhereCond);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "{0}1.SetCheckedItemForGv({1});",
                    ClsName4WucTabName4Gv(), objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //public string GenPreCheck4Order(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder();

        //    try
        //    {

        //        clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

        //        if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n ///置底");
        //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "private bool PreCheck4Order()");
        //        strCodeForCs.Append("\r\n" + "{");
        //        if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == false)
        //        {
        //            strCodeForCs.AppendFormat("\r\n" + "if (ddl{0}_q.SelectedIndex <= 0)",
        //            objAdjustOrderNum.ClassificationFieldValue);

        //            strCodeForCs.Append("\r\n" + "{");
        //            strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"请输入{0}!\";", objAdjustOrderNum.ClassificationFieldValue);
        //            strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
        //            strCodeForCs.AppendFormat("\r\n" + "ddl{0}_q.Focus();",
        //                objAdjustOrderNum.ClassificationFieldValue);
        //            strCodeForCs.Append("\r\n" + "return false;");
        //            strCodeForCs.Append("\r\n" + "}");
        //        }
        //        strCodeForCs.Append("\r\n" + "return true;");
        //        strCodeForCs.Append("\r\n" + "}");

        //    }
        //    catch (Exception ex)
        //    {
        //        clsEntityBase.LogErrorS(ex, "");
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}

        public string GenbtnGoBottum_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);

                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoBottum_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = ddl{0}_q.SelectedValue;",
                        objInFor.FldName);
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     ClsName4WucTabName4Gv());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"请选择需要置底的记录!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottomBy{1}(lst{2}, {1});",
                         objViewInfoENEx.TabName,
                         objAdjustOrderNum.VarLst,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{1});",
                         objViewInfoENEx.TabName,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置底出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}1.BindGv_{1}(strWhereCond);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}1.SetCheckedItemForGv({1});",
                    ClsName4WucTabName4Gv(), objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenbtnReOrder_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);

                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///重序");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnReOrder_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");

                foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = ddl{0}_q.SelectedValue;",
                        objInFor.FldName);
                }

                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == false)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "string str{0} = ddl{0}_q.SelectedValue;",
                //        objAdjustOrderNum.ClassificationFieldValue);
                //}
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                  objAdjustOrderNum.VarLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"重序出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}1.BindGv_{1}(strWhereCond);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AutoGC_Cs_CWeb_PubFun);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
      
    }
}