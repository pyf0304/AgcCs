
using AGC;
using AGC.BusinessLogic;
using AGC.FunClass;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Web.UI;

public abstract class CommPageBase : System.Web.UI.Page, ICallbackEventHandler
{
    public string Page4FreeSenate = "../MicroTeach/FreeSenate.aspx";
    public string GetFreeSenateLink(string strFuncModuleId, string strCaseId, string strId_AppraiseType)
    {
        string strPageLink = string.Format("{0}?id={1}&FuncModuleAgcId={2}&Id_AppraiseType={3}",
                            Page4FreeSenate,
                              strCaseId,
                              strFuncModuleId,
                              strId_AppraiseType);

        return strPageLink;

    }
    /// <summary>
    /// 常量:当前页面名称
    /// </summary>
    public abstract string conCurrPageName
    {
        get;
    }
    /// <summary>
    /// 父页面。
    /// </summary>
    protected string vsParentPage
    {
        get
        {
            string sParentPage;
            sParentPage = (string)ViewState["ParentPage"];
            if (sParentPage == null)
            {
                sParentPage = "";
            }
            return sParentPage;
        }
        set
        {
            string sParentPage = value;
            ViewState.Add("ParentPage", sParentPage);
        }
    }

    public string PretreatmentParentPage(string strParentPage)
    {
        if (string.IsNullOrEmpty(strParentPage) == true) return "";
        strParentPage = strParentPage.Replace(conCurrPageName, "").Replace("||","|");
        string[] sstrParentPageItems = strParentPage.Split('|');
        if (sstrParentPageItems.Length == 0) return "";
        for (int i = 0; i < sstrParentPageItems.Length; i++)
        {
            if (string.IsNullOrEmpty(sstrParentPageItems[i]) == true) continue;
            return sstrParentPageItems[i];
        }
        return "";
    }
    /// <summary>
    /// 初始化父页面信息
    /// </summary>
    public abstract void InitParentPageInfo();
    /// <summary>
    /// 返回父页面
    /// </summary>
    public abstract void ReturnParentPage();
    /// <summary>
    /// 跳转到其他页面
    /// </summary>
    /// <param name="strPageName"></param>
    public abstract void JumpOtherPages(string strPageName);
    /// <summary>
    /// 模块Id
    /// </summary>
    public abstract string FuncModuleAgcId
    {
        get;
    }
    /// <summary>
    /// 系统所在的学校
    /// </summary>
    public string School
    {
        get
        {
            return clsMyConfig.spSchool;
        }
    }

    /// <summary>
    /// 系统所在的学校
    /// </summary>
    public bool IsVisitor
    {
        get
        {
            if (clsCommonSession.UserId == "visitor")
                return true;
            return false;
        }
    }

    public string isVisiablePlan
    {
        get
        {
            if (ViewState["plan"] != null)
            {
                if (String.CompareOrdinal(ViewState["plan"].ToString(), "1") == 0)
                {
                    return "1";
                }
            }
            return "0";
        }
        set
        {
            ViewState["plan"] = value;
        }
    }
    private string _callbackEventArgument;
    private int hasVisit
    {
        get
        {
            if (ViewState["hasVisit"] != null)
            {
                return Convert.ToInt32(ViewState["hasVisit"].ToString());
            }
            return 0;
        }
        set
        {
            ViewState["hasVisit"] = value;
        }
    }
    /// <summary>
    /// 当前操作用户的Id_User,如果是教师就返回Id_Teacher,如果是学生就返回Id_StudentInfo。
    /// </summary>
    protected string vsUserId
    {
        get
        {
            string sUserId;
            sUserId = (string)ViewState["UserId"];
            if (sUserId == null)
            {
                sUserId = "";
            }
            return sUserId;
        }
        set
        {
            string sUserId = value;
            ViewState.Add("UserId", sUserId);
        }
    }


    /// <summary>
    /// 案例名称。
    /// </summary>
    protected string vsCaseName
    {
        get
        {
            string sCaseName;
            sCaseName = (string)ViewState["CaseName"];
            if (sCaseName == null)
            {
                sCaseName = "";
            }
            return sCaseName;
        }
        set
        {
            string sCaseName = value;
            ViewState.Add("CaseName", sCaseName);
        }
    }

    /// <summary>
    /// 案例拥有者Id。
    /// </summary>
    protected string vsOwnerId
    {
        get
        {
            string sOwnerId;
            sOwnerId = (string)ViewState["OwnerId"];
            if (sOwnerId == null)
            {
                sOwnerId = "";
            }
            return sOwnerId;
        }
        set
        {
            string sOwnerId = value;
            ViewState.Add("OwnerId", sOwnerId);
        }
    }

    /// <summary>
    /// 案例拥有者Id。
    /// </summary>
    protected SortOrder vsMySortOrder
    {
        get
        {
            SortOrder sMySortOrder;
            if (ViewState["MySortOrder"] == null)
            {
                sMySortOrder = SortOrder.Ascending;
            }
            sMySortOrder = (SortOrder)ViewState["MySortOrder"];
            return sMySortOrder;
        }
        set
        {
            SortOrder sMySortOrder = value;
            ViewState.Add("MySortOrder", sMySortOrder);
        }
    }

    /// <summary>
    /// 当前记录案例日志-Mid。
    /// </summary>
    protected string vsLogMid
    {
        get
        {
            string sLogMid;
            sLogMid = (string)ViewState["LogMid"];
            if (sLogMid == null)
            {
                sLogMid = "";
            }
            return sLogMid;
        }
        set
        {
            string sLogMid = value;
            ViewState.Add("LogMid", sLogMid);
        }
    }

    /// <summary>
    /// 当前操作用户的Id_User,如果是教师就返回Id_Teacher,如果是学生就返回Id_StudentInfo。
    /// </summary>
    protected string vsIsDualVideo
    {
        get
        {
            string sIsDualVideo;
            sIsDualVideo = (string)ViewState["IsDualVideo"];
            if (sIsDualVideo == null)
            {
                sIsDualVideo = "";
            }
            return sIsDualVideo;
        }
        set
        {
            string sIsDualVideo = value;
            ViewState.Add("IsDualVideo", sIsDualVideo);
        }
    }
    /// <summary>
    /// 当前操作用户的《微格案例主视频下载》权限符号，分三种情况：
    /// 1、全部
    /// 2、部门
    /// 3、个人
    /// 4、空（“”）
    /// </summary>
    protected string vsExportMainVideo
    {
        get
        {
            string sExportMainVideo;
            sExportMainVideo = (string)ViewState["ExportMainVideo"];
            if (sExportMainVideo == null)
            {
                sExportMainVideo = "";
            }
            return sExportMainVideo;
        }
        set
        {
            string sExportMainVideo = value;
            ViewState.Add("ExportMainVideo", sExportMainVideo);
        }
    }
    /// <summary>
    /// 当前操作用户的《微格案例副视频下载》权限符号，分三种情况：
    /// 1、全部
    /// 2、部门
    /// 3、个人
    /// 4、空（“”）
    /// </summary>
    protected string vsExportSecVideo
    {
        get
        {
            string sExportSecVideo;
            sExportSecVideo = (string)ViewState["ExportSecVideo"];
            if (sExportSecVideo == null)
            {
                sExportSecVideo = "";
            }
            return sExportSecVideo;
        }
        set
        {
            string sExportSecVideo = value;
            ViewState.Add("ExportSecVideo", sExportSecVideo);
        }
    }


    #region 参数




    protected string ErrMessage
    {
        get
        {
            string strErrMessage;
            strErrMessage = (string)Session["ErrMessage"];
            if (strErrMessage == null)
            {
                strErrMessage = "";
            }
            return strErrMessage;
        }
        set
        {
            string strErrMessage = value;
            Session.Add("ErrMessage", strErrMessage);
        }
    }

    protected string BackErrPageLinkStr
    {
        get
        {
            string strBackErrPageLinkStr;
            strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
            if (strBackErrPageLinkStr == null)
            {
                strBackErrPageLinkStr = "";
            }
            return strBackErrPageLinkStr;
        }
        set
        {
            string strBackErrPageLinkStr = value;
            Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
        }
    }

    #region 课例ID
    /// <summary>
    /// 课例ID
    /// </summary>
    public string vsId_Case
    {
        get
        {
            if (ViewState["Id_Case"] != null)
            {
                return ViewState["Id_Case"].ToString().Trim();
            }
            return "";

        }
        set
        {
            ViewState["Id_Case"] = value;
        }
    }
    #endregion

    #region 案例与资源关系表中的ID
    /// <summary>
    /// 案例与资源关系表中的ID
    /// </summary>
    public string qsId_Case_Resource_Rel
    {
        get
        {
            if (Request.QueryString["id"] != null)
            {
                return Request.QueryString["id"].ToString().Trim();
            }
            return "";
        }
    }
    #endregion


    #endregion

    public string CurrentCaseCreatorID
    {
        get
        {
            if (ViewState["CurrentCaseCreatorID"] != null)
            {
                return ViewState["CurrentCaseCreatorID"].ToString().Trim();
            }
            return "";
        }
        set
        {
            if (!String.IsNullOrEmpty(qsId_Case_Resource_Rel))
            {
                ViewState["CurrentCaseCreatorID"] = value;
            }
        }
    }



    #region 获取文件名称
    /// <summary>
    /// 获取文件名称
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public string GetFileOriginalName(object data)
    {
        string result = String.Empty;
        if (data != null)
        {
            try
            {
                DataRowView dataitem = (DataRowView)data;
                if (String.Compare(dataitem.Row["SaveMode"].ToString().Trim(), "False") == 0)
                {
                    result = dataitem.Row["FileOriginName"].ToString().Trim();
                }
                else
                {
                    result = dataitem.Row["FileOriginalName"].ToString().Trim();
                }
            }
            catch
            {

            }
        }
        return result;
    }
    #endregion

    #region 获取文件大小
    /// <summary>
    /// 获取文件大小
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public string GetFileSize(object data)
    {
        string result = String.Empty;
        if (data != null)
        {
            try
            {
                DataRowView dataitem = (DataRowView)data;
                if (String.Compare(dataitem.Row["SaveMode"].ToString().Trim(), "False") == 0)
                {
                    result = dataitem.Row["FileSize"].ToString().Trim() ?? "0";
                }
                else
                {
                    result = dataitem.Row["ftpFileSize"].ToString().Trim() ?? "0";
                }
            }
            catch
            {

            }
        }
        return result + "M";
    }
    #endregion





    #region ICallbackEventHandler Members



    public string GetCallbackResult()
    {
        string[] parts = _callbackEventArgument.Split('|');
        object[] args = null;
        string result = "";

        if (parts.Length > 1)
        {
            args = new object[parts.Length - 1];
            Array.Copy(parts, 1, args, 0, args.Length);
        }

        MethodInfo method = this.GetType().GetMethod(parts[0]);
        if (method != null)
        {
            try
            {
                result = (string)method.Invoke(this, args);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("CommCasePlayBase", "GetCallbackResult", "_callbackEventArgument" + _callbackEventArgument + objException.Message, clsCommonSession.UserId);

            }
        }
        return result;
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
        _callbackEventArgument = eventArgument;
    }

    void ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)
    {
        this.RaiseCallbackEvent(eventArgument);
    }

    string ICallbackEventHandler.GetCallbackResult()
    {
        return this.GetCallbackResult();
    }
    #endregion


    #region 输出页面的数据流
    /// <summary>
    /// 输出页面的数据流
    /// </summary>
    /// <param name="control"></param>
    /// <returns></returns>
    private string RenderControl(Control control)
    {
        StringWriter writer1 = new StringWriter(CultureInfo.InvariantCulture);
        HtmlTextWriter writer2 = new HtmlTextWriter(writer1);
        control.RenderControl(writer2);
        writer2.Flush();
        writer2.Close();
        return writer1.ToString();
    }
    #endregion

    #region 注册脚本(javascript)
    /// <summary>
    /// 注册脚本(javascript)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void Page_PreRender(object sender, EventArgs e)
    //{
    //    RegClientScript();
    //    //BindFreeSenate("0");
    //    //       Page.RegisterStartupScript("tdClick", "<script>document.all.freesenate.click();</script>");
    //    //ClientScript.RegisterStartupScript(this.GetType(), "tdClick", "<script>document.all.freesenate.click();</script>");
    //}

    private void RegClientScript()
    {
        string CallServer = @"function CallServer(arg, context){context.innerHTML = 'Loading';" + ClientScript.GetCallbackEventReference(this, "arg", "ReceiveServerData", "context") + "}";
        ClientScript.RegisterClientScriptBlock(this.GetType(), "CallServer", CallServer, true);
    }
    #endregion

    #region 动态加载

    #region 获取创建日期
    /// <summary>
    /// 获取创建日期
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public string GetDate(object data)
    {
        string result = String.Empty;
        if (data != null)
        {
            try
            {
                DataRowView dataitem = (DataRowView)data;
                if (String.Compare(dataitem.Row["SaveMode"].ToString().Trim(), "False") == 0)
                {
                    // result = CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["SaveDate"].ToString().Trim(), 0) + " " + CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["SaveTime"].ToString().Trim(), 1);
                    result = dataitem.Row["SaveDate"].ToString().Substring(0, 4) + "-" + CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["SaveDate"].ToString().Substring(4, 4), 0);
                }
                else
                {
                    // result = CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["FileUpDate"].ToString().Trim(), 0) + " " + CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["FileUpTime"].ToString().Trim(), 1);
                    result = dataitem.Row["FileUpDate"].ToString().Substring(0, 4) + "-" + CommFunc4WebForm.clsWebString.ConvertDateTimeFormate(dataitem.Row["FileUpDate"].ToString().Substring(4, 4), 0);
                }
            }
            catch
            {

            }
        }
        return result;
    }
    #endregion




    #endregion



    /// <summary>
    /// 获取当前时间点
    /// </summary>
    /// <param name="CurrentPosition"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    public string GetCurrentPosition(string CurrentPosition, int flag)
    {
        string result = String.Empty;
        string[] Temp;
        if (!String.IsNullOrEmpty(CurrentPosition))
        {
            Temp = CurrentPosition.Split(',');
            if (flag == 0)
            {
                if (Temp[0].ToString() != "")
                {
                    if (Temp.Length > 1)
                    {
                        result = "对本课例在" + Temp[0].ToString() + "后的评议:";
                    }
                    else
                    {
                        result = "对本课例整体的评议:";
                    }
                }
                else
                {
                    result = "对本课例整体的评议:";
                }
            }
            else if (flag == 1)
            {
                if (Temp.Length > 1)
                {
                    result = Temp[1].ToString();
                }
                else
                {
                    result = "0";
                }
            }
        }
        return result;
    }




    #region 与教学资源库相关
    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id，可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsCollegeId
    {
        get
        {
            if (Request.QueryString["CollegeId"] != null)
            {
                return Request.QueryString["CollegeId"].ToString().Trim();
            }
            return "";
        }
    }
    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id，可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsMajorId
    {
        get
        {
            if (Request.QueryString["MajorId"] != null)
            {
                return Request.QueryString["MajorId"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 课程Id。例如：“00510023”等
    ///         
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsCourseId
    {
        get
        {
            if (Request.QueryString["CourseId"] != null)
            {
                return Request.QueryString["CourseId"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 设置菜单标题，根据专业Id、课程Id来决定菜单类型、标题名称等
    /// </summary>
    public abstract void SetMenuTitle();

    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id，可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsThemeName
    {
        get
        {
            if (Request.QueryString["ThemeName"] != null)
            {
                return Request.QueryString["ThemeName"].ToString().Trim();
            }
            return "";
        }
    }

    /// <summary>
    /// 专业Id。例如：“0051”等
    ///         根据专业Id，可以获取相关的学院
    /// 作者：潘以锋
    /// 建立日期：2014-08-30
    /// </summary>
    public string qsMajorMenuId
    {
        get
        {
            if (Request.QueryString["MajorMenuId"] != null)
            {
                return Request.QueryString["MajorMenuId"].ToString().Trim();
            }
            return "";
        }
    }
    #endregion


    /// <summary>
    /// 通过QueryString传递过来的UserId参数。这里是样例，大家可以参考这个样例。
    /// 姓名：
    /// 日期：
    /// </summary>
    public string qsParentPage
    {
        get
        {
            string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
            if ((strParentPage != null) && (strParentPage != ""))
            {
                return strParentPage;
            }
            else
            {
                return "";
            }
        }
    }
    /// <summary>
    /// 课例等级Id，分为优秀、良好、一般、较差
    /// </summary>
    public string qsCaseLevelId
    {
        get
        {
            if (Request.QueryString["CaseLevelId"] != null)
            {
                return Request.QueryString["CaseLevelId"].ToString().Trim();
            }
            return "";
        }
    }


    /// <summary>
    /// 当前操作的界面功能名称
    /// </summary>
    protected string vsViewName
    {
        get
        {
            string sViewName;
            sViewName = (string)ViewState["ViewName"];
            if (sViewName == null)
            {
                sViewName = "";
            }
            return sViewName;
        }
        set
        {
            string sViewName = value;
            ViewState.Add("ViewName", sViewName);
        }
    }
    /// <summary>
    /// 当前操作的导出表名称
    /// </summary>
    protected string vsTabName
    {
        get
        {
            string sTabName;
            sTabName = (string)ViewState["TabName"];
            if (sTabName == null)
            {
                sTabName = "";
            }
            return sTabName;
        }
        set
        {
            string sTabName = value;
            ViewState.Add("TabName", sTabName);
        }
    }
    /// <summary>
    /// 当前操作的导出表名称
    /// </summary>
    protected string vsTabId_T
    {
        get
        {
            string sTabId_T;
            sTabId_T = (string)ViewState["TabId_T"];
            if (sTabId_T == null)
            {
                sTabId_T = "";
            }
            return sTabId_T;
        }
        set
        {
            string sTabId_T = value;
            ViewState.Add("TabId_T", sTabId_T);
        }
    }


    /// <summary>
    /// 当前操作的界面Id_T
    /// </summary>
    protected string vsViewId_T
    {
        get
        {
            string sViewId_T;
            sViewId_T = (string)ViewState["ViewId_T"];
            if (sViewId_T == null)
            {
                sViewId_T = "";
            }
            return sViewId_T;
        }
        set
        {
            string sViewId_T = value;
            ViewState.Add("ViewId_T", sViewId_T);
        }
    }

    /// <summary>
    /// 层是否显示
    /// </summary>
    protected bool vsDivIsVisible
    {
        get
        {
            string sDivIsVisible;
            sDivIsVisible = (string)ViewState["DivIsVisible"];
            if (sDivIsVisible == null)
            {
                return false;
            }
            return bool.Parse(sDivIsVisible);
        }
        set
        {
            string sDivIsVisible = value.ToString();
            ViewState.Add("DivIsVisible", sDivIsVisible);
        }
    }
}