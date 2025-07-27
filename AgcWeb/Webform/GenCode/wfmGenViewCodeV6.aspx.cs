///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Text;

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using com.taishsoft.common;
using AutoGCLib;
using AgcCommBase;


namespace AGC.Webform
{
    /// <summary>
    /// wfmGenViewCodeV6 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmGenViewCodeV6 : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                ///隐藏应该隐藏的控件内容
                ///
                if (clsCommForWebForm.SystemStatus == "DEBUG")
                {

                }
                //1、为下拉框设置数据源，绑定列表数据
                //===============================


                //2、显示无条件的表内容在DATAGRID中
                ///
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(ViewId, clsPubVar.CurrSelPrjId);
                lblViewName.Text = objViewInfo.ViewCnName + "(" + objViewInfo.ViewName + ")";

            }
        }


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId", strFuncModuleId);
            }
        }

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }


        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("SimpleFName", strSimpleFName);
            }
        }

       
        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId == null)
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}
        private string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                Session.Add("ViewId", strViewId);
            }
        }
        private string BackErrPageLinkStr
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
        private string ErrMessage
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

        private string BackGeneCode4WebV5LinkStr
        {
            get
            {
                string strBackGeneCode4WebV5LinkStr;
                strBackGeneCode4WebV5LinkStr = (string)Session["BackGeneCode4WebV5LinkStr"];
                if (strBackGeneCode4WebV5LinkStr == null)
                {
                    strBackGeneCode4WebV5LinkStr = "";
                }
                return strBackGeneCode4WebV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WebV5LinkStr = value;
                Session.Add("BackGeneCode4WebV5LinkStr", strBackGeneCode4WebV5LinkStr);
            }
        }




        public System.Data.DataTable GetViewTypeCode()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewTypeCode();
            objDDL.DataValueField = "ViewTypeCode";
            objDDL.DataTextField = "ViewTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            //			if (e.Item.ItemType == ListItemType.Item ||
            //				e.Item.ItemType == ListItemType.SelectedItem ||
            //				e.Item.ItemType == ListItemType.AlternatingItem ||
            //				e.Item.ItemType == ListItemType.EditItem)
            //			{
            //				chkIsSort = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsSort");
            //				string strIsSort = e.Item.Cells[10].Text;
            //				chkIsSort.Checked = bool.Parse(strIsSort);
            //
            //				chkIsTransCode = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsTransCode");
            //				string strIsTransCode = e.Item.Cells[12].Text;
            //				chkIsTransCode.Checked = bool.Parse(strIsTransCode);
            //
            //			}
        }




        //protected void btnGenViewCode_Click(object sender, System.EventArgs e)
        //{


        //    string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    tabCode.Visible = true;

        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneViewCode(strViewId, rblNetVersion.SelectedValue,
        //        //    clsPubVar.objCurrSelProject,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "", strCharEncodingId,
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        //protected void btnGenControlCode_Click(object sender, System.EventArgs e)
        //{


        //    string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;

        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneControlCode(strViewId, rblNetVersion.SelectedValue,
        //        //    clsPubVar.objCurrSelProject, clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "", strCharEncodingId,
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        //protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;

        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    ///根据ViewId获取编辑主表的TabId

        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId);
        //        string strTabId = objViewInfo.MainTabId;
        //        if (CheckTabFieldBySqlTab(strTabId) == false)
        //        {
        //            return;
        //        }

        //        //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
        //        //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
        //        //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
        //        //SimpleFName = clsString.GetSimpleFName_S(      autoGC5Cs_M.objPrjTabENEx.FileName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            //tabCode.Visible = false;
            Response.Redirect(clsCommonSession.ParentPage);
        }

        //protected void btnCtlViewCode_Click(object sender, System.EventArgs e)
        //{
        //    tabCode.Visible = true;

        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebCtlViewCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlViewCode(strViewId, rblNetVersion.SelectedValue,
        //        //    clsPubVar.objCurrSelProject,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        //protected void btnCtlControlCode_Click(object sender, System.EventArgs e)
        //{


        //    string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strFileName4GenCode = "";
           
        //    string strCodeText = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {

        //        strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, rblNetVersion.SelectedValue,
        //        //    clsPubVar.objCurrSelProject, 
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "", strCharEncodingId, 
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strFileName4GenCode;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {

            string strFileName = clsCommonSession.UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strFileContent, string strFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
            Response.Clear();
            //			Response.AddHeader("Content-Disposition", "inline; filename=" + ); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(strFileName));
            //			Response.AddHeader("Content-Length", strFileContent.Length.ToString()); 
            Response.ContentType = "application/octet-stream";
            Response.Write(strFileContent);
            Response.Write("\r\r\n");
            Response.End();
            return true;
        }

        protected void btnPreView_Click(object sender, System.EventArgs e)
        {

            string strViewId = clsCommonSession.ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            ViewId = strViewId;
            BackGeneCode4WebV5LinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=GeneCode4WebV5");
        }

        //protected void btnGenGeneLogicCodeEx_Oracle_Click(object sender, System.EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    
        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    ///根据ViewId获取编辑主表的TabId
        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;
        //        if (CheckTabFieldBySqlTab(strTabId) == false)
        //        {
        //            return;
        //        }

        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}

        //protected void btnGenGeneLogicCode_Oracle_Click(object sender, System.EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    
        //    string strViewId = clsCommonSession.ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    ///根据ViewId获取编辑主表的TabId

        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;
        //        if (CheckTabFieldBySqlTab(strTabId) == false)
        //        {
        //            return;
        //        }

        //        AutoGC6Cs_M_Ora autoGC5Cs_M_Oracle = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M_Oracle.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
        //        autoGC5Cs_M_Oracle.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M_Oracle.A_GenGeneralLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M_Oracle.objPrjTabENEx.FolderName + autoGC5Cs_M_Oracle.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M_Oracle.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M_Oracle.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M_Oracle.objPrjTabENEx.FileName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M_Oracle.objPrjTabENEx.FileName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}



        protected void btnGenGeneExLogicCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;

            string strViewId = clsCommonSession.ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            ///根据ViewId获取编辑主表的TabId
            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }

                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode4Query_Click(object sender, System.EventArgs e)
        {
            tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strViewId = clsCommonSession.ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
            if (objViewInfoENEx.ViewFldNum == 0)
            {
                ShowCode("界面中字段数为0，不能生成界面代码");
                return;

            }
            objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
            objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
            ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab4Query(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
            txtFileName4GenCode.Text = objViewInfoENEx.FileName;
            SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

        }



        protected void btnCtlControlCode4Query_Click(object sender, EventArgs e)
        {

        }
        private bool CheckTabFieldBySqlTab(string strTabId)
        {
            try
            {
                //判断是否可以删除
                if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, 
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId) == false)
                {
                    lblMsg2.Text = "检查表字段不成功!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }
        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }
        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                            clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}