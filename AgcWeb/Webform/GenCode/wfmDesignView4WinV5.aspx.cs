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


using System.Collections.Generic;
using com.taishsoft.common;
using System.Text;

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AgcCommBase;
using AutoGCLib;


namespace AGC.Webform
{
    /// <summary>
    /// wfmViewFldInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmDesignView4WinV5 : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            string js = "";
            js += "<script>\r\r\n";
            js += "function ld(){\r\r\n";
            js += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n";
            js += "if(document.getElementsByName('RadioName')[i].value==";
            js += "document.getElementById('" + rd.ClientID + "').value) ";
            js += "document.getElementsByName('RadioName')[i].checked=true\r\r\n";
            js += "}\r\r\n";
            js += "window.onload=ld\r\r\n";
            js += "</" + "script>\r\r\n";
            //			this.RegisterStartupScript("js",js); 
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                ///隐藏应该隐藏的控件内容

                ///显示界面提示信息：----------------------
                ///显示界面提示信息：======================
                //1、为下拉框设置数据源，绑定列表数据
                //				clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode);
                string strApplicationTypeId = clsApplicationTypeBLEx.WINDOWSAPP.ToString();
                
                //3、显示无条件的表内容在DATAGRID中
                //BindDg_ViewFldInfo();		//显示界面字段表的信息
                //4、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                DispViewInfo(ViewId);
                //为函数列表下拉框添加内容
                ddlFuncList.Items.Add("导出到EXCEL");
                ddlFuncList.Items.Add("绑定ListView");
                divViewFldList.Visible = false;
                divQueryFldList.Visible = false;
                divEditCtrlFldList.Visible = false;
                divDispDataFldList.Visible = false;
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

        
        ///// <summary>
        ///// 登录的用户ID，用于检查用户权限
        ///// </summary>
        //protected string vsUserId
        //{
        //    get
        //    {
        //        string strUserId;
        //        strUserId = (string)ViewState["UserId"];
        //        if (strUserId == null)
        //        {
        //            strUserId = "";
        //        }
        //        return strUserId;
        //    }
        //    set
        //    {
        //        string strUserId = value;
        //        ViewState.Add("UserId", strUserId);
        //    }
        //}

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
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
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

            lblViewName.Text = objViewInfo.ViewName;
            //4、显示界面功能
            lblViewFunction.Text = objViewInfo.ViewFunction;

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

        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        //private void BindDg_ViewFldInfo()
        //{
        //    //操作步骤：(共5步)
        //    //	1、组合界面条件串；
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
        //    //	4、设置DATAGRID的数据源(DataSource)；
        //    //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
        //    //	6、设置记录数的状态，
        //    //		在本界面中是把状态显示在控件txtRecCount中。

        //    //	1、组合界面条件串；
        //    string strWhereCond = CombineCondition();
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    System.Data.DataTable objDT = clsViewFldInfo.GetViewFldInfoT(strWhereCond);
        //    //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
        //    //		3.1 首先计算页数；
        //    //		3.2 如果当前页大于页数就为最后一页
        //    int intPages = CalcPages(objDT.Rows.Count, this.dgViewFldInfo.PageSize);
        //    if (intPages==0) 
        //    {
        //        this.dgViewFldInfo.CurrentPageIndex = 0;
        //    }
        //    else if (this.dgViewFldInfo.CurrentPageIndex > intPages - 1) 
        //    {
        //        this.dgViewFldInfo.CurrentPageIndex = intPages - 1;
        //    }
        //    //	4、设置DATAGRID的数据源(DataSource)；
        //    DataView objDV = objDT.DefaultView;
        //    //			objDV.Sort = strSortBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
        //    this.dgViewFldInfo.DataSource=objDV;
        //    //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
        //    this.dgViewFldInfo.DataBind();
        //    //	6、设置记录数的状态，
        //    this.txtRecCount.Text= objDT.Rows.Count.ToString();
        //}

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }


        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.dgViewFldInfo.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            //BindDg_ViewFldInfo();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgViewFldInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //			if(Request.Form["RadioName"] != null) 
            //			{ 
            //				rd.Value =  Request.Form["RadioName"].ToString(); 
            //			}

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgViewFldInfo.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            //BindDg_ViewFldInfo();
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
            if (lngMId == 0) return;        //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
                                            //if (clsViewFldInfo.IsExist(lngMId) == false)		//检查该关键字的记录是否存在
                                            //{
                                            //    string ss = "关键字为：" + lngMId + "的不存在!";
                                            //    clsCommonJsFunc.Alert(this, ss);
                                            //    return ;
                                            //}
                                            ////3、用提供的关键字初始化一个类对象；
                                            //clsViewFldInfo objViewFldInfo = new clsViewFldInfo(lngMId);
                                            //4、获取类对象的所有属性；
                                            //objViewFldInfo.GetViewFldInfo();
                                            //Session.Add("objViewFldInfo", objViewFldInfo);
                                            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
        }



        protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int intStepIndex;
            if (Request.Form["RadioName"] != null)
            {
                rd.Value = Request.Form["RadioName"].ToString();
                intStepIndex = int.Parse(rd.Value);
                //bool bolIsSuccess = (new clsViewFldInfoEx().DownOrderByOne(ViewId, intStepIndex));
                //if (bolIsSuccess == true)
                //{

                //    intNextStepIndex = intStepIndex + 1;
                //    rd.Value = intNextStepIndex.ToString();

                //    ///通过intNextStepIndex计算当前索引的页号P1
                //    ///如果DATAGRID的当前页号小于P1就增加当前当前页号

                //    ///通过intNextStepIndex计算当前索引的页号P1
                //    int intPages = CalcPages(intNextStepIndex, this.dgViewFldInfo.PageSize);
                //    ///如果DATAGRID的当前页号小于P1就增加当前当前页号
                //    if (this.dgViewFldInfo.CurrentPageIndex < intPages-1 ) 
                //    {
                //        this.dgViewFldInfo.CurrentPageIndex = intPages-1;
                //    }
                //BindDg_ViewFldInfo();
                //}
            }

        }

        protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int intStepIndex;
            if (Request.Form["RadioName"] != null)
            {
                rd.Value = Request.Form["RadioName"].ToString();
                intStepIndex = int.Parse(rd.Value);
                //bool bolIsSuccess = (new clsViewFldInfoEx().UpOrderByOne(ViewId, intStepIndex));
                //if (bolIsSuccess == true)
                //{
                //    intPrevStepIndex = intStepIndex - 1;
                //    rd.Value = intPrevStepIndex.ToString();
                //    ///通过intNextStepIndex计算当前索引的页号P1
                //    ///如果DATAGRID的当前页号小于P1就增加当前当前页号

                //    ///通过intNextStepIndex计算当前索引的页号P1
                //    int intPages = CalcPages(intPrevStepIndex, this.dgViewFldInfo.PageSize);
                //    ///如果DATAGRID的当前页号小于P1就增加当前当前页号
                //    if (this.dgViewFldInfo.CurrentPageIndex > intPages-1 ) 
                //    {
                //        this.dgViewFldInfo.CurrentPageIndex = intPages-1;
                //    }
                //    //BindDg_ViewFldInfo();
                //}
            }
        }

        protected void dgViewFldInfo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }


        protected void btnDelStep_Click(object sender, System.EventArgs e)
        {
            List<string> arrLst = new List<string>();
            int intStepIndex;
            //long lngIdForCurrStep;
            if (Request.Form["RadioName"] == null)
            {
                return;
            }
            rd.Value = Request.Form["RadioName"].ToString();
            intStepIndex = int.Parse(rd.Value);
            //2、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
            //arrLst = clsViewFldInfo.funGetFldValue("ViewFldInfo", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
            //lngIdForCurrStep =long.Parse(arrLst[0].ToString());
            //clsViewFldInfoEx.DelRecordEx(lngIdForCurrStep);
            //BindDg_ViewFldInfo();
        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackGeneCode4WinV5LinkStr);
        }


        protected void btnDelFld_Click(object sender, System.EventArgs e)
        {
            string strMId = (string)rd.Value;
            if (strMId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的字段记录!";
                return;
            }
            long lngMId = long.Parse(strMId);
            //clsViewFldInfo.DelRecord(lngMId);
            //BindDg_ViewFldInfo();
        }


        protected void btnSetFld_Click(object sender, System.EventArgs e)
        {
            string strMId = (string)rd.Value;
            if (strMId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的字段记录!";
                return;
            }
            long lngMId = long.Parse(strMId);
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            mId = lngMId;

            Response.Redirect("wfmViewSetField_Edit.aspx");

        }

        protected void ddlViewTypeCode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //if (ddlViewTypeCode.SelectedValue == "0011")
            //{
            //    ddlSubViewName.Items.Add("父界面：查询、删除界面_ListView");
            //    ddlSubViewName.Items.Add("编辑界面：修改、添加界面_ListView");
            //    ddlSubViewName.Items.Add("父界面：查询、删除界面_DataGridView");
            //    ddlSubViewName.Items.Add("编辑界面：修改、添加界面_DataGridView");
            //}
        }

        protected void btnGenViewCode_Click(object sender, System.EventArgs e)
        {

            GenViewCode(false);
        }
        protected void btnGenViewDesignCode_Click(object sender, EventArgs e)
        {
            GenViewCode(true);
        }
        private void GenViewCode(bool bolIsDesign)
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlSubViewName.SelectedIndex == 0)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                }
                else if (ddlSubViewName.SelectedIndex == 1)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;
                }
                else if (ddlSubViewName.SelectedIndex == 2)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                }
                else if (ddlSubViewName.SelectedIndex == 3)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;
                }

                objViewInfoENEx.IsDesign = bolIsDesign;
                //是否使用控件
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;


                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {
            string strFileName = clsCommonSession.UserId + "\\" + SimpleFName;
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab4Query(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
                //            autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //            autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //            ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
                //            txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //            SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
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
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab_Disp(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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

        protected void btnShowRelaFldList_Click(object sender, System.EventArgs e)
        {
            //界面所有字段列表
            if (cbkShowMode.Items[0].Selected == true)
            {
                divViewFldList.Visible = true;
            }
            else
            {
                divViewFldList.Visible = false;
            }
            //查询字段列表
            if (cbkShowMode.Items[1].Selected == true)
            {
                divQueryFldList.Visible = true;
            }
            else
            {
                divQueryFldList.Visible = false;
            }
            //显示信息字段列表
            if (cbkShowMode.Items[2].Selected == true)
            {
                divDispDataFldList.Visible = true;
            }
            else
            {
                divDispDataFldList.Visible = false;
            }
            //显示信息字段列表
            if (cbkShowMode.Items[3].Selected == true)
            {
                divEditCtrlFldList.Visible = true;
            }
            else
            {
                divEditCtrlFldList.Visible = false;
            }

        }

        protected void btnGenFunc_Click(object sender, System.EventArgs e)
        {
            //隐藏所有字段列表
            divViewFldList.Visible = false;
            divDispDataFldList.Visible = false;
            divEditCtrlFldList.Visible = false;
            divQueryFldList.Visible = false;

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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("界面中字段数为0，不能生成界面代码");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlFuncList.SelectedValue == "导出到EXCEL")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenbtnExportExcel4Dg_Click());
                }
                else if (ddlFuncList.SelectedValue == "绑定ListView")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenBindListView());
                }
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                //			SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
            //隐藏所有字段列表
            divViewFldList.Visible = false;
            divDispDataFldList.Visible = false;
            divEditCtrlFldList.Visible = false;
            divQueryFldList.Visible = false;

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