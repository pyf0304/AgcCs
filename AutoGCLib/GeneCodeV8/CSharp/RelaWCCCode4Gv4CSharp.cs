using System;
using System.Text;
using System.IO;
using com.taishsoft.file;

using System.Collections;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using AGC.Entity;

using AGC.BusinessLogic;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(Control of Mvc)
    /// </summary>
    public class RelaWCCCode4Gv4CSharp : clsGeneCodeBase4View
    {
        private string strKeyFldName_ObjName = "";

        protected bool mbolIsUseCtl = true;
        public RelaWCCCode4Gv4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
      
        public RelaWCCCode4Gv4CSharp(string strViewId)
     : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public RelaWCCCode4Gv4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
      : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
    
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
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable_{1}(strWhereCond);",
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
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                    objViewInfoENEx.TabName);
                }
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
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(vsobj{2}Cond);",
                  objViewInfoENEx.TabName, ClsName4WucTabName4Gv(), objViewInfoENEx.TabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}(cls{1}EN obj{1}Cond)", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = JsonConvert.SerializeObject(obj{0}Cond);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = {0}GetRecCountByCond(obj{0}Cond);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的对象列表；");
                strCodeForCs.Append("\r\n" + "stuPagerPara objPagerPara = new stuPagerPara()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "pageIndex = vsPageIndex,");
                strCodeForCs.Append("\r\n" + "PageSize = vsPageSize,");
                strCodeForCs.AppendFormat("\r\n" + "whereCond = JsonConvert.SerializeObject(obj{0}Cond),", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "OrderBy = vsSort{0}By", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "};");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
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
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                //    objViewInfoENEx.TabName);
                //}
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
                

                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arrObjLst;",
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
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

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
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

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
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前条件。");
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
        public string Gen_vsCondObject()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前条件对象。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN vsobj{0}Cond", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sobj{0}Cond = (cls{0}EN)ViewState[\"obj{0}Cond\"];", objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "return sobj{0}Cond;", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond = value;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"obj{0}Cond\", sobj{0}Cond);", objViewInfoENEx.TabName_Out);
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

        public string Gen_SetGvVisibility_AllShow()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView字段的可见性,所有字段都显示");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility_AllShow()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty(x.FldId) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{1}.{2}, true);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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

        public string Gen_SetGvVisibility_AllHide()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置GridView字段的可见性,所有字段都隐藏");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility_AllHide()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty(x.FldId) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{1}.{2}, false);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out,  objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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

                strCodeForCs.AppendFormat("\r\n" + "public bool SetCheckedItemsForGv(List<{0}> {1})",
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
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                      
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}_q.SelectedIndex == 1)",
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
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}_q.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             objViewInfoENEx.TabName_Out,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
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

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
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

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
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

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
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
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
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
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
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
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
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
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
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
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
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
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
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
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
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
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
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
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
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
                    strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
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
                    //List<string> lstExamTypeId = GetAllCheckedKeysFromGv();
                    //if (lstExamTypeId == null) return;
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


                    strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string   strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
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
                        strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(vsobj{2}Cond);",
                            objViewInfoENEx.TabName, ClsName4WucTabName4Gv(), objViewInfoENEx.TabName_Out);
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
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
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
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                            objViewInfoENEx.TabName);
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
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
                    //string strExamTypeId = GetFirstCheckedKeyFromGv();
                    //if (string.IsNullOrEmpty(strExamTypeId) == true) return;
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

                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
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
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                            objViewInfoENEx.TabName);
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
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
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

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
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

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



        public string A_GenCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;

            this.objViewInfoENEx = objViewInfoENEx;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
           
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "B";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx.cs";
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
                strCodeForCs.AppendFormat("\r\n ///		wuc{0}B 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0}B : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region 控件页面启动函数");

                ///生成用户自定义控件界面中Page_Load代码;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion 控件页面启动函数");

                //定义字段属性
                strTemp = Gen_Wuc_CS_FieldProperty4Edit();
                strCodeForCs.Append(strTemp);

                strCodeForCs.Append("\r\n" + "");
                //设置关键字在修改时,为只读
                strTemp = Gen_Wuc_CS_SetKeyReadOnly();
                strCodeForCs.Append(strTemp);
                //清除用户自定义控件中,所有控件的值
                strTemp = Gen_Wuc_CS_Clear();
                strCodeForCs.Append(strTemp);

                //校验自定义控件中自子控件的类型数值是否是合法正确的;
                strTemp = Gen_Wuc_CS_IsValid();
                strCodeForCs.Append(strTemp);

                ///设置该控件在插入状态下的缺省值;
                strTemp = Gen_Wuc_CS_SetDefaultValue();
                strCodeForCs.Append(strTemp);

                //生成界面中下拉框的BIND函数,即添加下拉框列表项的函数;
                //strTemp = GenDdlBindFunction();
                //strCodeForCs.Append(strTemp);
                //生成控件中下拉框的BIND函数, 供主界面调用;
                strTemp = Gen_Wuc_CS_SetDdl_FldName();
                strCodeForCs.Append(strTemp);
                
               strCodeForCs.Append("\r\n" + "}");

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
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;

            this.objViewInfoENEx = objViewInfoENEx;
            //if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strViewName = objViewInfoENEx.ViewName;
            //    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);

            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = ClsName4WucTabName4Gv();

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", ClsName4WucTabName4Gv());
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", ClsName4WucTabName4Gv());
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl", ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 在GridView中,单击[修改]按钮时,所引发的修改事件");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvUpdateClick GvUpdateClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 在GridView中,单击[删除]按钮时,所引发的修改事件");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvDeleteClick GvDeleteClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 在GridView中,单击[详细信息]按钮时,所引发的修改事件");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvDetailClick GvDetailClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 在GridView中,单击[选择]按钮时,所引发的修改事件");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvSelectClick GvSelectClick;");
                }
                strCodeForCs.Append("\r\n" + "#region 控件页面启动函数");

                ///生成用户自定义控件界面中Page_Load代码;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion 控件页面启动函数");

                ///生成根据界面上查询控件中所设置内容查询表记录,并显示在GridView中;
                strTemp = GenBindGridView4Wuc();
                strCodeForCs.Append(strTemp);

                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenJumpPage_RelaFunction(objViewInfoENEx, true));
                    /// 生成改变GridView中每页记录数的下拉框相关函数
                    strCodeForCs.Append("\r\n" + GenddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView的行建立事件过程
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView的页号改变事件过程
                    strTemp = Gen_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                { 
                    //GridView的行修改事件过程
                    strTemp = Gen_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_GridView_RowDetailing(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_GridView_RowSelecting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                // 生成专门用于记录GridView中的每页记录数
                strCodeForCs.Append("\r\n" + GenPageSizeViewState());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_PageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_PageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_RecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GenGetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region 排序相关函数");

                ///生成与GridView排序相关的代码;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion 排序相关函数");
                strTemp = Gen_vsWhereCond();

                strCodeForCs.Append(strTemp);

                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + Gen_vsCondObject());
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());

                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GetAllCheckedKeysFromGv4Wuc());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GetFirstCheckedKeyFromGv4Wuc());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_chkSelAll_CheckedChanged());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetSortBy());
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


        /// <summary>
        /// 专门用于显示打印的表控件控件层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlControlCodeforTab_Disp(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            this.objViewInfoENEx = objViewInfoENEx;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "B";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B_Disp.ascx.cs";
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
                strCodeForCs.AppendFormat("\r\n ///		wuc{0} 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0}_Disp : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region 控件页面启动函数");

                ///生成用户自定义控件界面中Page_Load代码;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion 控件页面启动函数");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
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
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == true)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = 1;",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = 2;",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {


                                //string strDS_DataValueField;
                                //string strDS_DataTextField;
                                string strDsTabName;
                                try
                                {
                                    strDsTabName = clsEditRegionFldsBLEx.InitDsTabName4Get(objEditRegionFldsEx);
                                }
                                catch (Exception objException)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                    objViewInfoENEx.ViewName, "编辑区域", objException.Message);
                                    throw new Exception(sbMsg.ToString());
                                }
                                //try
                                //{
                                //    strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                                //    objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDsTabName);
                                //    throw new Exception(sbMsg.ToString());
                                //}

                                //try
                                //{
                                //    strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                                //    objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDsTabName, strDS_DataValueField);
                                //    throw new Exception(sbMsg.ToString());
                                //}


                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = \"0\";",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                //strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = new cls{1}EN(value, true).{2};",
                                //objEditRegionFldsEx.FldName,
                                //objEditRegionFldsEx.CodeTab,
                                //strDS_DataTextField);
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
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = value.ToString();", objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = value.ToString();", objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");

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
                        if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                        {
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0}_q);",
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
                                        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", objViewInfoENEx.TabName);

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
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataValueField);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};",
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
                                        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", objViewInfoENEx.TabName);

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
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataValueField);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};",
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
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
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

                            //strCodeForCs.AppendFormat("\r\n" + "{2}_BindDdl_{0}(ddl{1}_q);",
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
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
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
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框,针对字段:[{0}]",
                          objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()", objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_{0}({1});",
                        objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
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

        public string GenPrivateVarCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成私有代码;
                strCodeForCs.Append("生成私有代码for C#");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
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
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
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
                            strCodeForCs.AppendFormat("\r\n" + "{2}_BindDdl_{0}({1});",
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabCode,
                            objEditRegionFldsEx.CtrlId,
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                            strCodeForCs.Append("\r\n" + "}");
                        }
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
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    ///
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                strCodeForCs.Append("\r\n" + "using System.Linq;");
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
                strCodeForCs.Append("\r\n" + "using Newtonsoft.Json;"); //

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}4WApi;", objProject.PrjDomain);
                
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
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
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
                objViewInfoENEx.TabName   );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});",
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
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

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
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)
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
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
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
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
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
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvDeleteClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()");
                    strCodeForCs.Append("\r\n" + "{");
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

        //生成GridView行详细信息的事件代码
        public string Gen_GridView_RowDetailing(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,进行行详细信息(RowDetailing)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowDetailing(object sender, GridViewDetailEventArgs e)",
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
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvDetailClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Detail objEventArgs4Detail = new clsEventArgs4Detail()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "GvDetailClick(this, objEventArgs4Detail);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Detail{0}Record({1});",
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


        //生成GridView行详细信息的事件代码
        public string Gen_GridView_RowSelecting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在GridView中,进行行详细信息(RowSelecting)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowSelecting(object sender, GridViewSelectEventArgs e)",
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
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvSelectClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Select objEventArgs4Select = new clsEventArgs4Select()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "GvSelectClick(this, objEventArgs4Select);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Select{0}Record({1});",
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

        public string Gen_Wuc4Gv_chkSelAll_CheckedChanged()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在Gv列表控件中,当GeidView行单击全选复选框时发生的事件。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void chkSelAll_CheckedChanged(object sender, EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "CheckBox chkSelAll = (CheckBox)sender;");
                strCodeForCs.Append("\r\n" + "if (chkSelAll.Checked == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);", objViewInfoENEx.TabName);
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
           
                    strCodeForCs.AppendFormat("\r\n" + "{4}1.SetSortBy(string.Format(\"{{0}} Asc\", con{1}.{0}));",
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
                strCodeForCs.AppendFormat("\r\n" + "//{0}_objCommFun4BL = new clsCommFun4BL4{0}();",
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
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}_IsExist({1}) == false)		//检查该关键字的记录是否存在",
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
                    strCodeForCs.AppendFormat("\r\n" + "{0}Get{1}(ref obj{0}EN);",
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(RelaWCCCode4Gv4CSharp);
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
        public override void GetClsName()
        {
            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                this.ClsName = obj.ClsName;
                objViewInfoENEx.ClsName = this.ClsName;
            }
            else
            {
                this.ClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
                objViewInfoENEx.ClsName = this.ClsName;
            }
        }
      
    }
}