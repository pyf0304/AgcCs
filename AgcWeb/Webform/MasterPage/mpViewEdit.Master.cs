using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Linq;

namespace AGC.Webform
{
    public partial class mpViewEdit : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsViewInfoEN objViewInfo = clsViewInfoBLEx.GetObjByViewIdCache(getViewId, clsCommonSession.CurrSelPrjId);
            clsPubVar.CurrCmPrjId = objViewInfo.PrjId;
            clsCommonSession.ViewId = getViewId;
            clsCommonSession.ApplicationTypeId = objViewInfo.ApplicationTypeId;

            lblViewName.Text = objViewInfo.ViewCnName + "(" + objViewInfo.ViewName + ")";
            lblCmPrjName.Text = clsCMProjectBL.GetNameByCmPrjIdCache(objViewInfo.PrjId);

            if (!IsPostBack)
            {
                SetMenuNameByIsExistRegion();//根据是否存在区域设置菜单名称

                //switch (objViewInfo.ApplicationTypeId)
                //{
                //    case 1://WIN
                //        Menu1.Items.RemoveAt(13);
                //        Menu1.Items.RemoveAt(12);
                //        Menu1.Items.RemoveAt(11);
                //        Menu1.Items.RemoveAt(10);
                //        //Menu1.Items.RemoveAt(10);
                //        Menu1.Items.RemoveAt(8);

                //        break;
                //    case 2://WEB
                //        Menu1.Items.RemoveAt(13);
                //        Menu1.Items.RemoveAt(12);
                //        Menu1.Items.RemoveAt(11);
                //        Menu1.Items.RemoveAt(10);
                //        Menu1.Items.RemoveAt(9);
                //        break;
                //    case 3://enumApplicationType.JavaWeb_3
                //        Menu1.Items.RemoveAt(13);
                //        Menu1.Items.RemoveAt(12);
                //        //Menu1.Items.RemoveAt(12);
                //        Menu1.Items.RemoveAt(10);
                //        //Menu1.Items.RemoveAt(10);
                //        //Menu1.Items.RemoveAt(9);
                //        break;
                //    case 5://enumApplicationType.AndroidApp_5
                //        Menu1.Items.RemoveAt(13);
                //        Menu1.Items.RemoveAt(12);
                //        Menu1.Items.RemoveAt(10);
                //        Menu1.Items.RemoveAt(9);
                //        Menu1.Items.RemoveAt(8);
                //        break;
                //    case 13://enumApplicationType.AspMvc应用程序
                //        Menu1.Items.RemoveAt(13);
                //        Menu1.Items.RemoveAt(11);
                //        Menu1.Items.RemoveAt(10);
                //        Menu1.Items.RemoveAt(9);
                //        Menu1.Items.RemoveAt(8);
                //        break;
                //    case 18://enumApplicationType.Spa应用Asp-TS
                //        Menu1.Items.RemoveAt(12);
                //        Menu1.Items.RemoveAt(11);
                //        Menu1.Items.RemoveAt(10);
                //        Menu1.Items.RemoveAt(9);
                //        Menu1.Items.RemoveAt(8);
                //        break;
                //}
                DispReleButton();//显示相关按钮，表名傍边的3个LinkButton
                Menu1.Attributes["onclick"] = string.Format("ClearTextById('{0}');", "txtCode");
                //foreach (MenuItem objMI in Menu1.Items)
                //{
                //    //objMI.NavigateUrl = string.Format("javascript:{0}", string.Format("ClearTextById('{0}');", "txtCode"));
                //}

                Menu1.MenuItemClick += Menu1_MenuItemClick;
            }
        }
        /// <summary>
        /// 显示相关按钮，表名傍边的3个LinkButton
        /// </summary>
        private void DispReleButton()
        {
            string strViewId = getViewId;
            clsViewInfoEN objViewInfo = clsViewInfoBLEx.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
            if (objViewInfo.InSqlDsTypeId == "01")
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.InRelaTabId, clsPubVar.CurrSelPrjId);
                if (objPrjTabEN != null)
                {
                    hidTabId4RelaTab.Value = objPrjTabEN.TabId;
                    lbEditTab.Text = string.Format("编辑输入表({0})", objPrjTabEN.TabName);
                    lbEditTab.Visible = true;
                }
            }

            if (string.IsNullOrEmpty(objViewInfo.OutRelaTabId) == false)
            {
                clsPrjTabEN objPrjTabEN_OUT = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.OutRelaTabId, clsPubVar.CurrSelPrjId);

                if (objPrjTabEN_OUT != null)
                {
                    hidTabId4ReleView.Value = objPrjTabEN_OUT.TabId;
                    if (objViewInfo.OutSqlDsTypeId == "01")
                        lbEditView.Text = string.Format("编辑输出表({0})", objPrjTabEN_OUT.TabName);
                    else
                        lbEditView.Text = string.Format("编辑输出视图({0})", objPrjTabEN_OUT.TabName);

                    lbEditView.Visible = true;
                }
            }
            //            objViewInfoEN.MainTabId
        }
        public MenuItem GetMIByValue( string strValue)
        {
            foreach (MenuItem objMI in Menu1.Items)
            {
                if (objMI.Value == strValue)
                {
                    return objMI;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据是否存在区域设置菜单名称
        /// </summary>
        private void SetMenuNameByIsExistRegion()
        {
            //string strCondition = string.Format("ViewId='{0}'", getViewId);

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
            List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBL.GetObjLstCache(clsPubVar.CurrCmPrjId)
                .Where(x=> arrRegionId.Contains( x.RegionId)).ToList();
            bool bolIsExistQryRegion = false;//是否存在查询区域
            bool bolIsExistEditRegion = false;//是否存在编辑区域
            bool bolIsExistDetailRegion = false;//是否存在详细区域

            bool bolIsExistDGRegion = false;//是否存在列表区域
            //bool bolIsExistListViewRegion = false;//是否存在ListView区域
            bool bolIsExistFeatureRegion = false;//是否存在功能区域
            bool bolIsExistExportExcelRegion = false;//是否存在导出Excel区域
            //bool bolIsExistDetailRegion = false;//是否存在详细区域

            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.QueryRegion_0001)) bolIsExistQryRegion = true;
            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.ListRegion_0002)) bolIsExistDGRegion = true;
            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008)) bolIsExistFeatureRegion = true;
            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.ExcelExportRegion_0007)) bolIsExistExportExcelRegion = true;
            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.EditRegion_0003)) bolIsExistEditRegion = true;
            if (arrViewRegionObjLst.Exists(x => x.RegionTypeId == enumRegionType.DetailRegion_0006)) bolIsExistDetailRegion = true;

            //if (arrViewRegionObjLst.Exists(x => x.RegionName == "详细区域")) bolIsExistDetailRegion = true;


            MenuItem objMI = GetMIByValue("2");
            if (bolIsExistQryRegion == true)
            {

                objMI.Text = "查询区域-编辑";
            }
            else
            {
                objMI.Text = "查询区域-添加";
            }
            objMI = GetMIByValue("3");
            if (bolIsExistFeatureRegion == true)
            {
                objMI.Text = "功能区域-编辑";
            }
            else
            {
                objMI.Text = "功能区域-添加";
            }
            objMI = GetMIByValue("5");
            if (bolIsExistDGRegion == true)
            {
                objMI.Text = "列表区域-编辑";
            }
            else
            {
                objMI.Text = "列表区域-添加";
            }

            //if (bolIsExistListViewRegion == true)
            //{
            //    Menu1.Items[5].Text = "LV1列表区域-编辑";
            //}
            //else
            //{
            //    Menu1.Items[5].Text = "LV1列表区域-添加";
            //}
            objMI = GetMIByValue("6");
            if (bolIsExistEditRegion == true)
            {
                objMI.Text = "编辑区域-编辑";
            }
            else
            {
                objMI.Text = "编辑区域-添加";
            }

            objMI = GetMIByValue("DetailRegion");
            if (bolIsExistDetailRegion == true)
            {
                objMI.Text = "详细区域-编辑";
            }
            else
            {
                objMI.Text = "详细区域-添加";
            }


            objMI = GetMIByValue("7");
            if (bolIsExistExportExcelRegion == true)
            {
                objMI.Text = "导出区域-编辑";
            }
            else
            {
                objMI.Text = "导出区域-添加";
            }
            //            objViewInfoEN.MainTabId
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string lngRegionId = "";
            //void   QueryButton_Click(object   src,EventArgs   e){   
            //System.Text.StringBuilder   sb=new   System.Text.StringBuilder("<script   Language=\"Javascript\">");   
            //sb.Append("parent.frames.Main.location.href=\"main.aspx?time1=");   
            //sb.Append(textbox1.Text);   
            //sb.Append("&time2=").Append(textbox2.Text);   
            //sb.Append("&reporttype=").Append(textbox3.Text);   
            //sb.Append("\";");   
            //sb.Append(">").Append("/").Append("script>");   
            //if(!Page.IsStartupScriptRegistered("myscript"))   
            //Page.RegisterStartupScript("myscript",sb.ToString());   
            //}   

            //在main.aspx中通过Request.QueryString["time1"]来获得第一个时间值，类似地可以获得第二个时间及报表类型值。
            switch (e.Item.Value)
            {
                case "0"://编辑界面属性

                    //string c1 = "<script language='javascript'>window.parent.location.href='wfmViewInfo_U.aspx' window.parent.location.target='View_main'; </script>";
                    //Response.Write(c1);
                    Response.Redirect("../View/wfmViewInfo_U.aspx");
                    //StringBuilder sbHtml = new StringBuilder();
                    //sbHtml.Append("<script language='javascript'>");
                    //sbHtml.AppendFormat("window.parent.{0}location.href=", "View_main.");
                    //sbHtml.AppendFormat("'{0}'", "wfmViewInfo_U.aspx");
                    //sbHtml.Append("; </script>");
                    //Response.Write(sbHtml.ToString());
                    break;
                case "1"://区域列表-维护

                    Response.Redirect("../View/wfmViewRegion_QUDI2.aspx");
                    break;
                case "ReferFiles"://界面引用文件

                    Response.Redirect("../GenCode/wfmViewReferFilesB_InViewEdit.aspx");
                    break;
                case "ViewRelaTab"://界面引用文件
                    Response.Redirect("../View/wfmViewRelaTab_InViewEdit.aspx");
                    break;
                case "2"://查询区域字段编辑

                    if (e.Item.Text == "查询区域-添加")
                    {

                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                clsRegionTypeENEx.QUERYREGION,              //区域类型
                                //"查询区域",                              //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "查询区域添加成功！");
                            e.Item.Text = "查询区域-编辑";
                        }
                    }
                    else
                    {
                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.QUERYREGION, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;
                        Response.Redirect("../View/wfmQryRegionFlds_QUDI2.aspx");
                        //StringBuilder sbHtml = new StringBuilder();
                        //sbHtml.Append("<script language='javascript'>");
                        //sbHtml.AppendFormat("window.parent.{0}location.href=", "View_main.");
                        //sbHtml.AppendFormat("'{0}'", "wfmQryRegionFlds_QUDI2.aspx");
                        //sbHtml.Append("; </script>");
                        //Response.Write(sbHtml.ToString());
                    }
                    //string c1 = "<script language='javascript'>window.parent.location.href='wfmViewInfo_QUDI.aspx'; window.parent.location.target='View_main'; </script>";
                    //Response.Write(c1);
                    break;
                case "3"://功能区域字段编辑

                    if (e.Item.Text == "功能区域-添加")
                    {

                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                clsRegionTypeENEx.FEATUREREGION,               //区域类型
                                //"功能区域"  ,                            //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "功能区域添加成功！");
                            e.Item.Text = "功能区域-编辑";
                        }
                    }
                    else
                    {
                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.FEATUREREGION, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;

                        Response.Redirect("../RegionManage/wfmFeatureRegionFldsB_QUDI.aspx?Operator=LimitInInterface");
                                          
                    }
                    //string c1 = "<script language='javascript'>window.parent.location.href='wfmViewInfo_QUDI.aspx'; window.parent.location.target='View_main'; </script>";
                    //Response.Write(c1);
                    break;

                case "4"://预览
                    lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.FEATUREREGION, clsPubVar.CurrCmPrjId);
                    new clsCommonSession().RegionId = lngRegionId;

                    Response.Redirect("../RegionManage/wfmViewFeatureFldsB_QUDI.aspx");            
                    break;


                case "5"://DG列表区域字段编辑

                    if (e.Item.Text == "列表区域-添加")
                    {

                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                clsRegionTypeENEx.DGREGION,             //区域类型
                                //"列表区域"               ,               //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "列表区域添加成功！");
                            e.Item.Text = "列表区域-编辑";
                        }
                    }
                    else
                    {

                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.DGREGION, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;
                        Response.Redirect("../View/wfmDGRegionFlds_QUDI2.aspx");
                
                    }
                    break;

                //    break;
                case "6"://编辑区域字段编辑
                    if (e.Item.Text == "编辑区域-添加")
                    {
                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                clsRegionTypeENEx.EDITREGION,               //区域类型
                                //"编辑区域"               ,               //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "编辑区域添加成功！");
                            e.Item.Text = "编辑区域-编辑";
                        }
                    }
                    else
                    {
                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.EDITREGION, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;
                        Response.Redirect("../View/wfmEditRegionFlds_QUDI2.aspx?AutoAddRegion=true");
                   
                    }
                    //string c1 = "<script language='javascript'>window.parent.location.href='wfmViewInfo_QUDI.aspx'; window.parent.location.target='View_main'; </script>";
                    //Response.Write(c1);
                    break;


                case "DetailRegion"://编辑区域字段编辑
                    if (e.Item.Text == "详细区域-添加")
                    {
                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                enumRegionType.DetailRegion_0006,               //区域类型
                                //"详细区域"               ,               //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "详细区域添加成功！");
                            e.Item.Text = "详细区域-编辑";
                        }
                    }
                    else
                    {
                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, enumRegionType.DetailRegion_0006, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;
                        Response.Redirect("../View/wfmDetailRegionFlds_QUDI2.aspx?AutoAddRegion=true");

                    }

                    break;
                case "7"://Excel导出区域字段编辑

                    if (e.Item.Text == "导出区域-添加")
                    {

                        bool bolResult = clsViewInfoBLEx.ImportRegionAndFlds1(getViewId, //视图ID(ViewId)
                                clsRegionTypeENEx.EXCELEXPORT_REGION,               //区域类型
                                //"Excel导出区域"          ,                   //区域名称
                                clsCommonSession.UserId
                                );
                        if (bolResult)
                        {
                            clsCommonJsFunc.Alert(this, "导出区域添加成功！");
                            e.Item.Text = "导出区域-编辑";
                        }
                    }
                    else
                    {
                        lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(getViewId, clsRegionTypeENEx.EXCELEXPORT_REGION, clsPubVar.CurrCmPrjId);
                        new clsCommonSession().RegionId = lngRegionId;
                        Response.Redirect("../View/wfmExcelExportRegionFlds_QUDI2.aspx");
                        //StringBuilder sbHtml = new StringBuilder();
                        //sbHtml.Append("<script language='javascript'>");
                        //sbHtml.AppendFormat("window.parent.{0}location.href=", "View_main.");
                        //sbHtml.AppendFormat("'{0}'", "wfmExcelExportRegionFlds_QUDI2.aspx");
                        //sbHtml.Append("; </script>");
                        //Response.Write(sbHtml.ToString());
                        //string c1 = "<script language='javascript'>window.parent.location.href='wfmViewInfo_QUDI.aspx'; window.parent.location.target='View_main'; </script>";
                        //Response.Write(c1);
                    }
                    break;
                case "8"://预览

                    Response.Redirect("../ViewDesign/wfmPreviewViewRegion3.aspx");
                    //StringBuilder sbHtml = new StringBuilder();
                    //sbHtml.Append("<script language='javascript'>");
                    //sbHtml.AppendFormat("window.parent.{0}location.href=", "View_main.");
                    //sbHtml.AppendFormat("'../ViewDesign/{0}'", "wfmPreviewViewRegion3.aspx");
                    //sbHtml.Append("; </script>");
                    //Response.Write(sbHtml.ToString());
                    break;

                //    break;
                case "9"://生成代码

                    Response.Redirect("../View/wfmGenViewCode.aspx");

                    break;
                case "TestModal"://生成代码

                    Response.Redirect("../RegionManage/wfmFeatureRegionFlds_Modal.aspx?Operator=LimitInInterface");

                    break;

                    
            }
        }

        protected void lbEditView_Click(object sender, EventArgs e)
        {

            if (lbEditView.Text.IndexOf("编辑") >= 0)
            {
                clsCommonSession.TabId = hidTabId4ReleView.Value;
                if (string.IsNullOrEmpty(hidTabId4ReleView.Value) == false)
                {
                    StringBuilder sbHtml = new StringBuilder();
                    sbHtml.Append("<script language='javascript'>");
                    sbHtml.AppendFormat("window.location.href=", "main");
                    sbHtml.AppendFormat("'{0}?TabId={1}'",
                            "../Table/wfmEditTabAndObjectFields.aspx",
                            hidTabId4ReleView.Value);
                    sbHtml.Append("; </script>");
                    Response.Write(sbHtml.ToString());

                }
                else
                {
                    lblMsgList.Text = "没有相关的视图表，请检查！";
                    clsCommonJsFunc.Alert(this, lblMsgList.Text);
                }
            }

        }

        protected void lbEditTab_Click(object sender, EventArgs e)
        {
            if (lbEditTab.Text.IndexOf("编辑") >= 0)
            {
                clsCommonSession.TabId = hidTabId4RelaTab.Value;
                if (string.IsNullOrEmpty(hidTabId4RelaTab.Value) == false)
                {
                    StringBuilder sbHtml = new StringBuilder();
                    sbHtml.Append("<script language='javascript'>");
                    sbHtml.AppendFormat("window.location.href=", "main");
                    sbHtml.AppendFormat("'{0}?TabId={1}'",
                            "../Table/wfmEditTabAndObjectFields.aspx",
                            hidTabId4RelaTab.Value);
                    sbHtml.Append("; </script>");
                    Response.Write(sbHtml.ToString());
                }
                else
                {
                    lblMsgList.Text = "没有相关的视图表，请检查！";
                    clsCommonJsFunc.Alert(this, lblMsgList.Text);
                }
            }
        }

        //定义从外面传来的ViewId
        private string qsViewId
        {
            get
            {
                string strViewId = Request.QueryString["ViewId"] ?? "".ToString();
                if ((strViewId != null) && (strViewId != ""))
                {
                    return strViewId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的ParentPage(前调用页面)
        private string qsParentPage
        {
            get
            {
                string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
                if ((strParentPage != null) && (strParentPage != ""))
                {
                    return strParentPage;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getViewId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.ViewId4get) == false) return clsCommonSession.ViewId4get;
                if (string.IsNullOrEmpty(qsViewId) == false) return qsViewId;
                return "";
            }
            //set
            //{
            //    clsCommonSession.ViewId4get = value;
            //}
        }

        protected void lbReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/wfmViewInfo_QUDI.aspx");
        }
    }
}
