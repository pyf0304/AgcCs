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
using TzAdvancedLib;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(Control of Mvc)
    /// </summary>
    public class WebCtlControlCode4Gv4CSharp : clsGeneCodeBase4View
    {
        private string strTabName_Out = "";
        private string strTabId_Out = "";

        protected bool mbolIsUseCtl = true;
        public WebCtlControlCode4Gv4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
      
        public WebCtlControlCode4Gv4CSharp(string strViewId)
     : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public WebCtlControlCode4Gv4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
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

        public string Gen_Wuc4Gv_CS_seErrMessage()
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
        
        public string Gen_Wuc4Gv_CS_vsPageSize()
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

      
        public string Gen_Wuc4Gv_CS_vsPageIndex()
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

        public string Gen_Wuc4Gv_CS_vsPageCount()
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

        public string Gen_Wuc4Gv_CS_vsRecCount()
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

        public string Gen_Wuc4Gv_CS_seBackErrPageLinkStr()
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
        public string Gen_Wuc4Gv_CS_BindGvByFuncBak()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}ByFunc(string strWhereCond)", strTabName_Out);
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
                //strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsWhereCond = strWhereCond;");
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                    strTabName_Out);
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
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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


        public string Gen_Wuc4Gv_CS_BindGv()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}(string strWhereCond)", strTabName_Out);
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
                //strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsWhereCond = strWhereCond;");
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                    strTabName_Out);
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
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                

                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_BindGvCache()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}Cache(cls{0}EN obj{0}Cond)", strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0} = null;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = obj{0}Cond.GetCombineCondition();", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "vsobj{0}Cond = obj{0}Cond;", strTabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "获取分页对象列表(缓存)不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})获取分页对象列表(缓存)不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                
                strCodeForCs.Append("\r\n" + "//	4、设置GRIDView的数据源(DataSource)；");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                //    strTabName_Out);
                //}
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arr{0};",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_BindGvByFunc()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}ByFunc(cls{0}EN obj{0}Cond)", strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0} = null;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}ENEx> arr{0}Ex = null;", strTabName_Out);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = obj{0}Cond.GetCombineCondition();", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "vsobj{0}Cond = obj{0}Cond;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                    strTabName_Out);
                }
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Ex = arr{0}.Select(this.CopyToEx).ToList();",                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "获取分页对象列表(缓存)不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})获取分页对象列表(缓存)不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "//	4、设置GRIDView的数据源(DataSource)；");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用",
                //    strTabName_Out);
                //}
                strCodeForCs.Append("\r\n ///设置GridView中每页的记录数");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arr{0}Ex;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5、绑定GridView,即把DataTable的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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




        public string Gen_Wuc4Gv_CS_GridView_Sorting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intIndex;");
                strCodeForCs.Append("\r\n" + "//判断是否是新的排序字段");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(e.SortExpression);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                strTabName_Out);

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));


                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//检查原来是升序");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\" Asc\");",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)		//如果原来不是升序就设置为升序");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else			///否则设置为降序");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Desc\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsSort{0}By",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = (string)ViewState[\"Sort{0}By\"];",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if (sSort{0}By == null) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = \"\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sSort{0}By;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By = value;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"Sort{0}By\", sSort{0}By);",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_vsWhereCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsWhereCond",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = (string)ViewState[\"whereCond\"];",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if (sWhereCond == null) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = \"\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sWhereCond;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond = value;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"whereCond\", sWhereCond);",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_SetGvVisibility()
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
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_SetGvVisibility_AllShow()
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
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty( x.FldId ) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{0}.{1}, true);",
                    strTabName_Out, objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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

        public string Gen_Wuc4Gv_CS_SetGvVisibility_AllHide()
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
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{0}.{1}, false);",
                    strTabName_Out,  objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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


        public string Gen_Wuc4Gv_CS_SetVisible()
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
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_SetSortBy()
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
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(vsSort{0}By) == true)", strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = strSortBy;", strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_SetCheckedItemForGv()
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
                    strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_SetCheckedItemsForGv()
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
                        strTabName_Out,
                        objKeyField.PrivFuncListName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1});",
                    strTabName_Out,
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


        public string GenBinggv_JumpPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n ///生成专门用于BindGv中的跳页相关代码");

                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;",
                strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//当前页数");
                strCodeForCs.AppendFormat("\r\n" + "lblAllPages.Text = intPageCount.ToString(); ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//当前页序数");
                strCodeForCs.AppendFormat("\r\n" + "lblCurrentPage.Text = vsPageIndex.ToString();",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//当前即将跳到的页序数");
                strCodeForCs.AppendFormat("\r\n" + "txtJump2Page.Text = vsPageIndex.ToString();",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//如果当前页序数为0,则<前一页>按钮无效");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == 1) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = false; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = true; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "//如果当前页序数已为最后一页,则<前一页>按钮无效");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == intPageCount) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = false; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = true; ",
                strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.BottomPagerRow.Visible = true;", strTabName_Out);
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


  

        public string Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv()
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
                            strTabName_Out,
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



        public string Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv()
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
                            strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_btnJumpPage_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "if (txtJump2Page != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(txtJump2Page.Text.Trim()!= \"\" && ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)>0 && ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)-1<this.gv{0}.PageCount) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = int.Parse(txtJump2Page.Text)-1; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        public string Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        private string Gen_Wuc4Gv_CS_ReBindGv(bool bolIsInWuc4Gv)
        {
            string strCodeForCs = "";
            if (bolIsInWuc4Gv == true)
            {
                if (this.IsUseFunc)
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}ByFunc(vsobj{0}Cond);", strTabName_Out);
                }
                else if ( objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}Cache(vsobj{0}Cond);", strTabName_Out);
                }
                else
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}(vsWhereCond);",
                        strTabName_Out);
                }
            }
            else
            {
                strCodeForCs = string.Format("\r\n" + "BindGv_{0}();", strTabName_Out);
            }
            return strCodeForCs;
        }

        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv{1}", strTabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
            return strClsName;
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            strTabName_Out = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
            strTabId_Out = objViewInfoENEx.objViewRegion_List.TabId;
            this.objViewInfoENEx = objViewInfoENEx;
            //if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strViewName = objViewInfoENEx.ViewName;
            //    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);
            
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = this.ClsName; 

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", this.ClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


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
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl", this.ClsName);
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

                //生成根据界面上查询控件中所设置内容查询表记录,并显示在GridView中;
                if (this.IsUseFunc == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvByFunc();
                    strCodeForCs.Append(strTemp);
                }
                else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvCache();
                    strCodeForCs.Append(strTemp);
                }
                else
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGv();
                    strCodeForCs.Append(strTemp);
                }
               


                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_btnJumpPage_Click(objViewInfoENEx, true));
                    /// 生成改变GridView中每页记录数的下拉框相关函数
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView的行建立事件过程
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView的页号改变事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                { 
                    //GridView的行修改事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowDeleting(objViewInfoENEx, true);
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageSize());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsRecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region 排序相关函数");

                ///生成与GridView排序相关的代码;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion 排序相关函数");
                strTemp = Gen_Wuc4Gv_CS_vsWhereCond();
                strCodeForCs.Append(strTemp);


                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seErrMessage());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seBackErrPageLinkStr());

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged());
                //strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetSortBy());
              
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        throw objException;
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
                            strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindDdl_{0}({1});",
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
     
      

        //生成GridView页号发生变化时的事件过程
        public string Gen_Wuc4Gv_CS_GridView_PageIndexChanging(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共2步)");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (e.NewPageIndex != -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.pageIndex = e.NewPageIndex;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        public string Gen_Wuc4Gv_CS_GridView_RowCreated()
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
                strTabName_Out);
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
                    //						strTabName_Out);
                    //					strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "int intIndex;");
                    strCodeForCs.AppendFormat("\r\n" + "if (vsSort{0}By == \"\") return ;",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strSortEx;");
                    strCodeForCs.AppendFormat("\r\n" + "for(int i = 0;i<this.gv{0}.Columns.Count;i++)",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strSortEx = this.gv{0}.Columns[i].SortExpression;",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if (strSortEx == \"\") continue;");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(strSortEx + \" \");",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if(intIndex >= 0) //视图状态的排序表达式是否为该列的字段；");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "Label lblSort = new Label();");
                    strCodeForCs.Append("\r\n" + "lblSort.Font.Name = \"webdings\";//设置字体,在\"webdings\"中5是上三角,6是下三角；");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\"Asc\");",
                    strTabName_Out);
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
        public string Gen_Wuc4Gv_CS_GridView_RowCommand()
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
                strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"不选\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (lbSelAll.Text == \"不选\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"全选\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"NextPage\":");
                strCodeForCs.Append("\r\n" + "//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引");
                strCodeForCs.Append("\r\n" + "                    if (vsPageIndex < vsPageCount) vsPageIndex += 1;");
                strCodeForCs.Append("\r\n" + "//2、重新绑定GridView,使之内容更新,变化到新的页");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(true));

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

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(true));

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
        public string Gen_Wuc4Gv_CS_GridView_RowDeleting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_GridView_RowUpdating(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                        strTabName_Out,
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {
                    //strStd1Id = "";
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    strTabName_Out,
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
                    strTabName_Out);

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
                    strTabName_Out);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged()
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
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);", strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_GetPageCount()
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WebCtlControlCode4Gv4CSharp);
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
                this.ClsName = string.Format("wuc{0}4Gv", strTabName_Out);
                objViewInfoENEx.ClsName = this.ClsName;
            }
        }
   
        public string Gen_Wuc4Gv_CS_vsCondObject()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于记录GridView中的当前条件对象。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN vsobj{0}Cond", strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sobj{0}Cond = (cls{0}EN)ViewState[\"obj{0}Cond\"];", strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "return sobj{0}Cond;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond = value;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"obj{0}Cond\", sobj{0}Cond);", strTabName_Out);
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
        public string Gen_Wuc4Gv_CS_Code4ListRegion()
        {
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = ClsName4WucTabName4Gv();

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", ClsName4WucTabName4Gv());
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            //strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            //strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

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
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvCache();
                    strCodeForCs.Append(strTemp);
                }
                else
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGv();
                    strCodeForCs.Append(strTemp);
                }



                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_btnJumpPage_Click(objViewInfoENEx, true));
                    /// 生成改变GridView中每页记录数的下拉框相关函数
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView的行建立事件过程
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView的页号改变事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                {
                    //GridView的行修改事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView的行删除事件过程
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowDeleting(objViewInfoENEx, true);
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageSize());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsRecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region 排序相关函数");

                ///生成与GridView排序相关的代码;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion 排序相关函数");
                strTemp = Gen_Wuc4Gv_CS_vsWhereCond();
                strCodeForCs.Append(strTemp);

                strTemp = Gen_Wuc4Gv_CS_vsCondObject();
                strCodeForCs.Append(strTemp);

                // 生成错误信息的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seErrMessage());
                // 生成返回链接的SESSION相关属性函数
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seBackErrPageLinkStr());

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetSortBy());
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

        public string Gen_Wuc4Gv_CS_CopyToEx()
        {
            
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", strTabName_Out);
            strBuilder.AppendFormat("\r\n /// <returns>目标对象=>cls{0}EN:obj{0}ENT</returns>", strTabName_Out);
            strBuilder.AppendFormat("\r\n public cls{0}ENEx CopyToEx(cls{0}EN obj{0}ENS)", strTabName_Out);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}ENEx obj{0}ENT = new cls{0}ENEx();", strTabName_Out);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}ENS, obj{0}ENT);",
                    strTabName_Out);
            List<clsDGRegionFldsENEx> arrDGRegionFld_Sel = objViewInfoENEx.arrDGRegionFldSet.FindAll(x => x.IsUseFunc() == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.PrjId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFld_Sel)
            {
                strBuilder.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(strTabId_Out, objDGRegionFldsEx.FldId, 1, objViewInfoENEx.PrjId);
                if (objDataNode_Curr == null)
                {
                    string strMsg = string.Format("TabId={0},FldId=[{1}], VersionNo=1, PrjId={2}的结点为空,请检查!", strTabId_Out, objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId);
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDGRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                string strLastVarName = "";
                

                var arrPath = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objDGRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                foreach(var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}ENT.{1}", strTabName_Out,  objCacheClassifyField.FldName);
                            }
                            strBuilder.AppendFormat("\r\n const {0} = cls{1}BL.func(con{1}.{2}, con{1}.{3}, {4} {5});", 
                                objDataNode_End.DataNodeName, 
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);

                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName )
                            {
                                case "equal":
                            
                                if (objDataNode_Start.TabId == strTabId_Out)
                                {
                                    strBuilder.AppendFormat("\r\n const {0} = obj{1}ENT.{2};", objDataNode_End.DataNodeName, 
                                        strTabName_Out,
                                        objFieldTab_Start.FldName);
                                }
                                else
                                {
                                    strBuilder.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                }
                                strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out)
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}ENT.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out,
                                        objFieldTab_Start.FldName);
                                    }
                                    else
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out)
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out,
                                        objFieldTab_Start.FldName,
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }
               
                }
                strBuilder.AppendFormat("\r\n obj{0}ENT.{1} = {2};", 
                                    strTabName_Out,
                                    objDGRegionFldsEx.DataPropertyName(),
                                    strLastVarName);
                strBuilder.Append("\r\n" + "};");
            }



            strBuilder.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "CopyToEx", "Copy表Ex:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
       
    }
}