using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
//using SqlSv; 
using com.taishsoft.common;
using CommFunc4WebForm;

///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewFldInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmDesignView4WinV5_New : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {


            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                ///隐藏应该隐藏的控件内容

                ///显示界面提示信息：----------------------
                ///显示界面提示信息：======================
                //1、为下拉框设置数据源，绑定列表数据
                //				clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode);
                //string strApplicationTypeId = clsApplicationTypeBLEx.WINDOWSAPP;
                //clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode, strApplicationTypeId);

                //4、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                DispViewInfo(ViewId);
                //为函数列表下拉框添加内容
                ddlFuncList.Items.Add("导出到EXCEL");
                ddlFuncList.Items.Add("绑定ListView");

                
                
                //btnGenViewCode.Attributes["onclick"] = string.Format("ClearText({0});", txtCode.ClientID);

            }
        }
        private string BackGeneCode4WinV5LinkStr
        {
            get
            {
                string strBackGeneCode4WinV5LinkStr;
                strBackGeneCode4WinV5LinkStr = (string)Session["BackGeneCode4WinV5LinkStr"];
                if (strBackGeneCode4WinV5LinkStr == null)
                {
                    strBackGeneCode4WinV5LinkStr = "";
                }
                return strBackGeneCode4WinV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WinV5LinkStr = value;
                Session.Add("BackGeneCode4WinV5LinkStr", strBackGeneCode4WinV5LinkStr);
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

        //		private clsViewFldInfo objViewFldInfo
        //		{
        //			get
        //			{
        //				clsViewFldInfo pobjViewFldInfo;
        //				pobjViewFldInfo = (clsUsersEN)Session["objViewFldInfo"];
        //				if (pobjViewFldInfo==null) 
        //				{
        //					pobjViewFldInfo = null;
        //				}
        //				return pobjViewFldInfo;
        //			}
        //			set
        //			{
        //				clsViewFldInfo pobjViewFldInfo = value;
        //				Session.Add("objViewFldInfo", pobjViewFldInfo);
        //			}
        //		}

        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
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


        private long mId
        {
            get
            {
                long lngMId;
                if (Session["mId"] == null)
                {
                    return 0;
                }
                lngMId = long.Parse(Session["mId"].ToString());
                return lngMId;
            }
            set
            {
                long lngMId = value;
                Session.Add("mId", lngMId);
            }
        }


        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)Session["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                Session.Add("SimpleFName", strSimpleFName);
            }
        }


        private void DispViewInfo(string strViewId)
        {
            //1、显示界面名称
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);

            //3、显示界面类型
            //ddlViewTypeCode.SelectedValue = objViewInfo.ViewTypeCode;

        }
        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and ViewFldInfo.ViewId = '" + ViewId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            return strWhereCond;
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngMId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngMId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngMId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //if (clsViewFldInfo.IsExist(lngMId) == false)		//检查该关键字的记录是否存在
            //{
            //    string ss = "关键字为：" + lngMId + "的不存在!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            ////3、用提供的关键字初始化一个类对象；
            //clsViewFldInfo objViewFldInfo = new clsViewFldInfo(lngMId);
            //4、获取类对象的所有属性；
            //objViewFldInfo.GetViewFldInfo();
            //Session.Add("objViewFldInfo", objViewFldInfo);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
        }




        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {
            string strFileName = UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);

        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void btnCtlViewCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            //tabDG.Visible = false;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                   ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
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

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            //tabDG.Visible = false;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab4Query(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = false;

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;

            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            try
            {
                ///根据ViewId获取编辑主表的TabId
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;

                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode_Disp_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = false;
            tabCode.Visible = true;

            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab_Disp(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = true;
        }


        protected void btnGenFunc_Click(object sender, System.EventArgs e)
        {

            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlFuncList.SelectedValue == "导出到EXCEL")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenbtnExportExcel4Dg_Click());
                }
                else if (ddlFuncList.SelectedValue == "绑定ListView")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenBindListView());
                }
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                //			SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneLogicCodeEx_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";

            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;


            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }



        //protected void btnGenGeneLogicCode_Oracle_Click(object sender, EventArgs e)
        //{
        //    //			tabDG.Visible = false;

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    
        //    string strViewId = ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    try
        //    {
        //        ///根据ViewId获取编辑主表的TabId
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;

        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M.A_GenGeneralLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}
        //protected void btnGenGeneLogicCodeEx_Oracle_Click(object sender, EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    string strViewId = ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    
        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;

        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;

        //        ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //    <asp:MenuItem Text="单表的QUDI_LV" Value="0"></asp:MenuItem>
            //    <asp:MenuItem Text="单表组合界面_ListView" Value="新建项"></asp:MenuItem>
            //    <asp:MenuItem Text="单表组合界面_GridView" Value="2"></asp:MenuItem>
            //    <asp:MenuItem Text="单表插入" Value="3"></asp:MenuItem>
            //    <asp:MenuItem Text="单表查询" Value="4"></asp:MenuItem>
            int intMenuIndex = int.Parse(e.Item.Value);
            switch (intMenuIndex)
            {
                case 0://单表的QUDI_LV,0008
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0008";
                    break;
                case 1://单表组合界面_ListView,0011
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0011";
                    break;
                case 2://单表组合界面_GridView,0020
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20;// "0020";
                    break;
                case 3://单表插入,0012
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_Insert_1;// "0012";
                    break;
                case 4://单表查询,
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_Query_3;// "0008";
                    break;
            }
            MultiView1.ActiveViewIndex = intMenuIndex;
        }
        /// <summary>
        /// 单表的QUDI_LV,0008
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGenViewCode01_ClickBak(object sender, EventArgs e)
        {
            //			tabDG.Visible = false;

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;

                objViewInfoENEx.IsDesign = false;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
                autoGC5Cs_VWin.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenCode_Click(object sender, EventArgs e)
        {
            Button objButton = sender as Button;

            string strCodeTypeId = objButton.CommandArgument;

            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            if (objCodeTypeEN == null)
            {
                string strMsg = string.Format("按钮:{0}的命令参数(CommandArgument):{1}设置不正确.", objButton.Text, strCodeTypeId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            string strViewId = clsCommonSession.ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";

            string strCmPrjId = "";
            string strTabId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WinViewCode_QD;

            try
            {

                string strCodeText = AutoGC.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                               vsLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                              clsCommonSession.ApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                //strCodeText = clsViewInfoBLEx_GeneCode.GeneViewCode(strViewId, rblNetVersion.SelectedValue,
                //    clsPubVar.objCurrSelProject,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "", strCharEncodingId,
                //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                vsSimpleFName = strRe_ClsName;
                txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
                
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            //			tabDG.Visible = false;

            //Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            //tabCode.Visible = true;
            //string strViewId = ViewId;
            //if (strViewId.Trim().Length == 0)
            //{
            //    lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
            //    return;
            //}
            //lblMsg2.Text = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";

            //try
            //{

            //    clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            //    objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            //    clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            //    WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
            //    objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
            //    objViewInfoENEx.CurrUserName = clsCommonSession.UserName;

            //    objViewInfoENEx.IsDesign = false;
            //    //是否使用控件
            //    objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
            //    autoGC5Cs_VWin.CurrUserName = clsCommonSession.UserName;
            //    ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
            //    SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //}
            //catch (Exception objException)
            //{

            //    clsCommonSession.seErrMessage = objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //}

        }
        protected void btnGenViewCode02_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                objViewInfoENEx.IsDesign = false;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode02_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                objViewInfoENEx.IsDesign = true;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


        }
        protected void btnGenViewCode02_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);

            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = false;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }



        }
        protected void btnGenViewDesignCode02_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = true;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }



        }
        protected void btnGenViewCode03_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                objViewInfoENEx.IsDesign = false;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
                enumViewTypeCodeTab intViewTypeCode = new clsCommonSession().ViewTypeCode;
                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode03_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                //objViewInfoENEx.NetVersion = "2005";

                objViewInfoENEx.IsDesign = true;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewCode03_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = false;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode03_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = true;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
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

        private string vsSimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["vsSimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("vsSimpleFName", strSimpleFName);
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