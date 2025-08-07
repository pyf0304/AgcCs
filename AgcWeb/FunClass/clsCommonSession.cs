using AGC.BusinessLogic;
using AGC.Entity;
using AGC.FunClass;
using CommFunc4WebForm;

using GeneralPlatform.Entity;
using System;
using System.Text;

namespace AGC.FunClass
{
    /// <summary>
    /// Common 的摘要说明
    /// </summary>
    public class clsCommonSession
    {
        public clsCommonSession()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        
        public static string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)System.Web.HttpContext.Current.Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                System.Web.HttpContext.Current.Session.Add("UserId", strUserId);
            }
        }
        
        public static string UserName
        {
            get
            {
                string strUserName;
                strUserName = (string)System.Web.HttpContext.Current.Session["UserName"];
                if (strUserName == null)
                {
                    strUserName = "";
                }
                return strUserName;
            }
            set
            {
                string strUserName = value;
                System.Web.HttpContext.Current.Session.Add("UserName", strUserName);
            }
        }
        public static string RoleId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["RoleId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["RoleId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("RoleId", value);

            }

        }

        public static string UserRightsId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserRightsId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["UserRightsId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("UserRightsId", value);

            }

        }

        public string PrjIdBak
        {
            get
            {
                string strPrjId;
                strPrjId = (string)System.Web.HttpContext.Current.Session["PrjId"];
                if (strPrjId == null)
                {
                    strPrjId = "";
                    clsCommForWebForm.CheckPrjId(strPrjId);
                }
                return strPrjId;
            }
            set
            {
                string strPrjId = value;
                System.Web.HttpContext.Current.Session.Add("PrjId", strPrjId);
            }
        }
        public string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)System.Web.HttpContext.Current.Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                System.Web.HttpContext.Current.Session.Add("ObjId", strObjId);
            }
        }

        public string ActiveViewIndex
        {
            get
            {
                string strActiveViewIndex;
                strActiveViewIndex = (string)System.Web.HttpContext.Current.Session["ActiveViewIndex"];
                if (strActiveViewIndex == null)
                {
                    strActiveViewIndex = "";
                }
                return strActiveViewIndex;
            }
            set
            {
                string strActiveViewIndex = value;
                System.Web.HttpContext.Current.Session.Add("ActiveViewIndex", strActiveViewIndex);
            }
        }
        public string FldId
        {
            get
            {
                string strFldId;
                strFldId = (string)System.Web.HttpContext.Current.Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                System.Web.HttpContext.Current.Session.Add("FldId", strFldId);
            }
        }
        public static string CurrPrjId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrPrjId"].ToString();
                }
                else
                {
                    if (clsMyConfig.CurrPrjId != null)
                    {
                        return clsMyConfig.CurrPrjId;
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrPrjId", value);
            }
        }
        public static string ViewId4get
        {
            get
            {
                string strViewId;
                strViewId = (string)System.Web.HttpContext.Current.Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
           
        }
        
        public static int ApplicationTypeId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["ApplicationTypeId"] == null)
                {
                    return 0;
                }
                int strApplicationTypeId;
                strApplicationTypeId = (int)System.Web.HttpContext.Current.Session["ApplicationTypeId"];

                return strApplicationTypeId;
            }
            set
            {
                int strApplicationTypeId = value;
                System.Web.HttpContext.Current.Session.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }

        public static string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)System.Web.HttpContext.Current.Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                System.Web.HttpContext.Current.Session.Add("ViewId", strViewId);
            }
        }
        public enumViewTypeCodeTab ViewTypeCode
        {
            get
            {
                int intViewTypeCode;
                intViewTypeCode = (int)System.Web.HttpContext.Current.Session["ViewTypeCode"];
                //if (intViewTypeCode == null)
                //{
                //    intViewTypeCode = 0;
                //}
                return (enumViewTypeCodeTab) intViewTypeCode;
            }
            set
            {
                int intViewTypeCode = (int)value;
                System.Web.HttpContext.Current.Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        public string RegionId
        {
            get
            {
                string strRegionId;
                strRegionId = (string)System.Web.HttpContext.Current.Session["RegionId"];
                if (strRegionId == null)
                {
                    return "";
                }
                return strRegionId;
            }
            set
            {
                string strRegionId = value.ToString();
                System.Web.HttpContext.Current.Session.Add("RegionId", strRegionId);
            }
        }
        /// <summary>
        /// 当前默认的数据库
        /// </summary>
        public string PrjDataBaseName
        {
            get
            {
                string strPrjDataBaseName;
                strPrjDataBaseName = (string)System.Web.HttpContext.Current.Session["PrjDataBaseName"];
                if (strPrjDataBaseName == null)
                {
                    strPrjDataBaseName = "";
                }
                return strPrjDataBaseName;
            }
            set
            {
                string strPrjDataBaseName = value;
                System.Web.HttpContext.Current.Session.Add("PrjDataBaseName", strPrjDataBaseName);
            }
        }

        public string FuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)System.Web.HttpContext.Current.Session["FuncModuleAgcId"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                System.Web.HttpContext.Current.Session.Add("FuncModuleAgcId", strFuncModuleId);
            }
        }


        

        public static string qsTabId
        {
            get
            {
                string strTabId = System.Web.HttpContext.Current.Request.QueryString["TabId"] ?? "".ToString();
                if (string.IsNullOrEmpty(strTabId) == false)
                {
                    if (strTabId.Length != 8)
                    {
                        string strMsg = string.Format("TabId:[{0}]的长度为:[{1}]不为8！不正确！", strTabId, strTabId.Length);
                        throw new Exception(strMsg);
                    }
                }
                if ((strTabId != null) && (strTabId != ""))
                {
                    return strTabId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 通过QueryString传递过来的TabId参数。
        /// 姓名：潘以锋
        /// 日期：20191128
        /// </summary>
        public static string TabId
        {
            get
            {
                string strTabId;
                strTabId = (string)System.Web.HttpContext.Current.Session["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                System.Web.HttpContext.Current.Session.Add("TabId", strTabId);
            }
        }
        public string TabName
        {
            get
            {
                string strTabName;
                strTabName = (string)System.Web.HttpContext.Current.Session["TabName"];
                if (strTabName == null)
                {
                    strTabName = "";
                }
                return strTabName;
            }
            set
            {
                string strTabName = value;
                System.Web.HttpContext.Current.Session.Add("TabName", strTabName);
            }
        }
        public string TabCnName
        {
            get
            {
                string strTabCnName;
                strTabCnName = (string)System.Web.HttpContext.Current.Session["TabCnName"];
                if (strTabCnName == null)
                {
                    strTabCnName = "";
                }
                return strTabCnName;
            }
            set
            {
                string strTabCnName = value;
                System.Web.HttpContext.Current.Session.Add("TabCnName", strTabCnName);
            }
        }
        public string SqlDsTypeId
        {
            get
            {
                string strSqlDsTypeId;
                strSqlDsTypeId = (string)System.Web.HttpContext.Current.Session["SqlDsTypeId"];
                if (strSqlDsTypeId == null)
                {
                    strSqlDsTypeId = "";
                }
                return strSqlDsTypeId;
            }
            set
            {
                string strSqlDsTypeId = value;
                System.Web.HttpContext.Current.Session.Add("SqlDsTypeId", strSqlDsTypeId);
            }
        }

        /// <summary>
        /// 表中包含的字段名
        /// </summary>
        public string IncludeFieldName
        {
            get
            {
                string strIncludeFieldName;
                strIncludeFieldName = (string)System.Web.HttpContext.Current.Session["IncludeFieldName"];
                if (strIncludeFieldName == null)
                {
                    strIncludeFieldName = "";
                }
                return strIncludeFieldName;
            }
            set
            {
                string strIncludeFieldName = value;
                System.Web.HttpContext.Current.Session.Add("IncludeFieldName", strIncludeFieldName);
            }
        }
        //操作类型:主要指添加(ADD)还是修改(UPDATE)
        public string OperateType
        {
            get
            {
                string strOperateType;
                strOperateType = (string)System.Web.HttpContext.Current.Session["OperateType"];
                if (strOperateType == null)
                {
                    strOperateType = "";
                }
                return strOperateType;
            }
            set
            {
                string strOperateType = value;
                System.Web.HttpContext.Current.Session.Add("OperateType", strOperateType);
            }
        }

        public string PrimaryTypeId
        {
            get
            {
                string strPrimaryTypeId;
                strPrimaryTypeId = (string)System.Web.HttpContext.Current.Session["PrimaryTypeId"];
                if (strPrimaryTypeId == null)
                {
                    strPrimaryTypeId = "";
                }
                return strPrimaryTypeId;
            }
            set
            {
                string strPrimaryTypeId = value;
                System.Web.HttpContext.Current.Session.Add("PrimaryTypeId", strPrimaryTypeId);
            }
        }

        public bool IsDispProbableErrTab
        {
            get
            {
                 string strIsDispProbableErrTab;
                strIsDispProbableErrTab = (string)System.Web.HttpContext.Current.Session["IsDispProbableErrTab"];
                if (strIsDispProbableErrTab == null)
                {
                return false;
                }
                return bool.Parse( strIsDispProbableErrTab);
            }
            set
            {
                string strIsDispProbableErrTab = value.ToString();
                System.Web.HttpContext.Current.Session.Add("IsDispProbableErrTab", strIsDispProbableErrTab);
            }
        }


        //操作类型:主要指添加(ADD)还是修改(UPDATE)
        public string GenCode4TabType
        {
            get
            {
                string strGenCode4TabType;
                strGenCode4TabType = (string)System.Web.HttpContext.Current.Session["GenCode4TabType"];
                if (strGenCode4TabType == null)
                {
                    strGenCode4TabType = "";
                }
                return strGenCode4TabType;
            }
            set
            {
                string strGenCode4TabType = value;
                System.Web.HttpContext.Current.Session.Add("GenCode4TabType", strGenCode4TabType);
            }
        }

        ///父页面:是指一个页面,来调用另一个页面,用来添加(ADD)或者修改(UPDATE)
        ///     在父页面调用子页面前设置该Session属性,以便子页面知道是哪一个页面来调用它.
        public static string ParentPage
        {
            get
            {
                string strParentPage;
                strParentPage = (string)System.Web.HttpContext.Current.Session["ParentPage"];
                if (strParentPage == null)
                {
                    strParentPage = "";
                }
                return strParentPage;
            }
            set
            {
                string strParentPage = value;
                System.Web.HttpContext.Current.Session.Add("ParentPage", strParentPage);
            }
        }


        public string BackErrPageEditFldLinkStr
        {
            get
            {
                string strBackErrPageEditFldLinkStr;
                strBackErrPageEditFldLinkStr = (string)System.Web.HttpContext.Current.Session["BackErrPageEditFldLinkStr"];
                if (strBackErrPageEditFldLinkStr == null)
                {
                    strBackErrPageEditFldLinkStr = "";
                }
                return strBackErrPageEditFldLinkStr;
            }
            set
            {
                string strBackErrPageEditFldLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackErrPageEditFldLinkStr", strBackErrPageEditFldLinkStr);
            }
        }
        public string BackPageEditFldLinkStr
        {
            get
            {
                string strBackPageEditFldLinkStr;
                strBackPageEditFldLinkStr = (string)System.Web.HttpContext.Current.Session["BackPageEditFldLinkStr"];
                if (strBackPageEditFldLinkStr == null)
                {
                    strBackPageEditFldLinkStr = "";
                }
                return strBackPageEditFldLinkStr;
            }
            set
            {
                string strBackPageEditFldLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackPageEditFldLinkStr", strBackPageEditFldLinkStr);
            }
        }
        public static string seErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)System.Web.HttpContext.Current.Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                System.Web.HttpContext.Current.Session.Add("ErrMessage", strErrMessage);
            }
        }
        public static string seBackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)System.Web.HttpContext.Current.Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void GetErrorMessage(Exception objException, string ErrorMessage)
        {

            clsCommonSession.seErrMessage = ErrorMessage + objException.Message;
            clsCommonSession.seBackErrPageLinkStr  = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.Web.HttpContext.Current.Response.Redirect(Entity.clsSysParaEN.ErrorPage);

        }
        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void ShowErrorMessage(string strErrorMessage)
        {

            clsCommonSession.seErrMessage = strErrorMessage;
            clsCommonSession.seBackErrPageLinkStr  = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.Web.HttpContext.Current.Response.Redirect(Entity.clsSysParaEN.ErrorPage);

        }

        /// <summary>
        /// 当前结点Id
        /// </summary>
        public string CurrNodeId
        {
            get
            {
                string strCurrNodeId;
                strCurrNodeId = (string)System.Web.HttpContext.Current.Session["CurrNodeId"];
                if (strCurrNodeId == null)
                {
                    strCurrNodeId = "";
                }
                return strCurrNodeId;
            }
            set
            {
                string strCurrNodeId = value;
                System.Web.HttpContext.Current.Session.Add("CurrNodeId", strCurrNodeId);
            }
        }


        public string RoleId4CurrPrj
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["RoleId4CurrPrj"] != null)
                {
                    return System.Web.HttpContext.Current.Session["RoleId4CurrPrj"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("RoleId4CurrPrj", value);

            }

        }
        public static string CurrSelPrjId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["CurrSelPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["CurrSelPrjId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("CurrSelPrjId", value);

            }

        }

        /// <summary>
        /// 当前结点Id
        /// </summary>
        public string CurrRoleNodeId
        {
            get
            {
                string strCurrRoleNodeId;
                strCurrRoleNodeId = (string)System.Web.HttpContext.Current.Session["CurrRoleNodeId"];
                if (strCurrRoleNodeId == null)
                {
                    strCurrRoleNodeId = "";
                }
                return strCurrRoleNodeId;
            }
            set
            {
                string strCurrRoleNodeId = value;
                System.Web.HttpContext.Current.Session.Add("CurrRoleNodeId", strCurrRoleNodeId);
            }
        }

        /// <summary>
        /// 获取所有的公共Session，以字符串的形式返回
        /// </summary>
        /// <returns></returns>
        public static string getAllCommonSession()
        {
            StringBuilder sbSysPara = new StringBuilder();
            System.Collections.Specialized.NameObjectCollectionBase.KeysCollection  Keys = System.Web.HttpContext.Current.Session.Keys;
            sbSysPara.AppendFormat("公共Session键-值关系如下：");
            foreach (string strKeys in Keys)
            {
                sbSysPara.AppendFormat("{1}=[{0}]\r\n",
                    System.Web.HttpContext.Current.Session[strKeys], strKeys);
            }
          

            return sbSysPara.ToString();
        }

        public static clsQxUsersEN objQxUser
        {
            get
            {
                clsQxUsersEN pobjUser;
                pobjUser = (clsQxUsersEN)System.Web.HttpContext.Current.Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    System.Web.HttpContext.Current.Session.Add("ErrMessage", strErrMessage);
                    //clsPubFun4Web.AccessError(this, conCurrPageName);
                    
                }
                return pobjUser;
            }
            set
            {
                clsQxUsersEN pobjUser = value;
                System.Web.HttpContext.Current.Session.Add("objUser", pobjUser);
            }
        }
        ///生成登录用户的用户名Session
        public static string UserId4get
        {
            get
            {
                string strUserId;
                strUserId = (string)System.Web.HttpContext.Current.Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                string strMsg = string.Format("用户被设置为：{0}。在页面：【{1}】",
                    value,
                  System.Web.HttpContext.Current.Request.Url.AbsolutePath);
                //clsPubVar4Web.objLog.WriteDebugLog(strMsg);
                System.Web.HttpContext.Current.Session.Add("UserId", strUserId);
            }
        }
        public static string CourseId
        {
            get
            {
                string strCourseId;
                strCourseId = (string)System.Web.HttpContext.Current.Session["CourseId"];
                if (strCourseId == null)
                {
                    strCourseId = "";
                }
                return strCourseId;
            }
            set
            {
                string strCourseId = value;
                System.Web.HttpContext.Current.Session.Add("CourseId", strCourseId);
            }
        }

        public static string CmPrjId
        {
            get
            {
                string strCmPrjId;
                strCmPrjId = (string)System.Web.HttpContext.Current.Session["CmPrjId"];
                if (strCmPrjId == null)
                {
                    strCmPrjId = "";
                }
                return strCmPrjId;
            }
            set
            {
                string strCmPrjId = value;
                System.Web.HttpContext.Current.Session.Add("CmPrjId", strCmPrjId);
            }
        }
    }
}
