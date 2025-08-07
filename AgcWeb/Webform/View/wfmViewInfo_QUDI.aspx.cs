///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
//using SqlSv; 
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using GeneralPlatform.Entity;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmViewInfo_QUDI : CommWebPageBase
    {
        /// <summary>
        /// 操作方式：（添加：AddRec, 修改：UpdRec）
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

    

        protected void Page_Load(object sender, System.EventArgs e)
        {

            //            this.RegisterStartupScript("js", js); 
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                string strCmPrjId = clsUserDefaValue_LocalBLEx.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认CM工程");
                vsCmPrjId = strCmPrjId;

                btnDelete.Attributes.Add("onclick", "return confirm('您真的要删除所选界面吗？');");
                ///隐藏应该隐藏的控件内容
                ///
                tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus == "DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
                //1、为下拉框设置数据源，绑定列表数据
                wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_PrjId();
                wucViewInfo1.SetDdl_CmPrjId(clsPubVar.CurrSelPrjId);

                wucViewInfo1.SetDdl_ApplicationTypeId();
                //				wucViewInfo1.SetDdl_ViewTypeCode();
                wucViewInfo1.SetDdl_ViewGroupId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_InSqlDsTypeId();
                wucViewInfo1.SetDdl_OutSqlDsTypeId();
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsCmPrjId) == false) ddlCmPrjIdq.SelectedValue = vsCmPrjId;
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId_Set, clsPubVar.CurrSelPrjId);

                //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
                //{
                //    wucViewInfo1.HideViewGroup();
                //}
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                clsDropDownList.BindDdl_ApplicationTypeId(ddlApplicationTypeIdq);
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                if (seApplicationTypeId>0)
                {
                    ddlApplicationTypeIdq.SelectedValue = seApplicationTypeId.ToString();
                }
                //                clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCodeq);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupIdq, clsPubVar.CurrSelPrjId);
                SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                //恢复上一次在此界面的状态
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }
                if (seViewTypeCode != 0)
                {
                    clsDropDownList.SetDdlValue(ddlViewTypeCodeq, seViewTypeCode.ToString());
                }
                txtViewNameq.Text = ViewName;
                //===============================
                strSortViewInfoBy = "UpdDate Desc";
                wucvViewInfo4Gv1.SetSortBy("UpdDate Desc");
                ///设置当前登录用户的默认工程
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                //2、显示无条件的表内容在DATAGRID中
                if (qsOperator == "AddRec")
                {
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "确认添加";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = objUser.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
                    wucViewInfo1.MainTabId = clsCommonSession.qsTabId;
                    if (string.IsNullOrEmpty(strCmPrjId) == false)
                    {
                        wucViewInfo1.CmPrjId = strCmPrjId;
                        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                        wucViewInfo1.ApplicationTypeId = objCMProject.ApplicationTypeId;

                    }
                    wucViewInfo1.DataBaseName = new clsCommonSession().PrjDataBaseName;
                    
                    tabQueryRegion.Visible = false;
                    tabEditRegion.Visible = true;
             
                    //wucViewInfo1.SetDefaValueByMainTabId4WebApp(clsCommonSession.qsTabId);
                }
                else
                {
                    BindGv_vViewInfo();
                    tabQueryRegion.Visible = true;
                    tabEditRegion.Visible = false;
                }
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucViewInfo1.SetKeyReadOnly(true);
                if (clsCommonSession.RoleId == "00050001" || clsCommonSession.RoleId == "00050006")
                {
                    btnDelViewEx.Visible = true;
                }

             
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


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private int seApplicationTypeId
        {
            get
            {
                if (Session["ApplicationTypeId4Qry"] == null) return 0;
                int strFuncModuleId;
                strFuncModuleId = (int)Session["ApplicationTypeId4Qry"];
                return strFuncModuleId;
            }
            set
            {
                int strFuncModuleId = value;
                Session.Add("ApplicationTypeId4Qry", strFuncModuleId);
            }
        }
        private int seViewTypeCode
        {
            get
            {
                int intViewTypeCode;
                if (Session["ViewTypeCode"] == null)
                {
                    return 0;
                }
                if (string.IsNullOrEmpty(Session["ViewTypeCode"].ToString()) == true)
                {
                    return 0;
                }
                intViewTypeCode = int.Parse(Session["ViewTypeCode"].ToString());

                return intViewTypeCode;
            }
            set
            {
                int intViewTypeCode = value;
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
        private clsQxUsersEN objUser
        {
            get
            {
                clsQxUsersEN pobjUser;
                pobjUser = (clsQxUsersEN)Session["objUser"];
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
                clsQxUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }
       
     

        private string BackViewInfoLinkStr
        {
            get
            {
                string strBackViewInfoLinkStr;
                strBackViewInfoLinkStr = (string)Session["BackViewInfoLinkStr"];
                if (strBackViewInfoLinkStr == null)
                {
                    strBackViewInfoLinkStr = "";
                }
                return strBackViewInfoLinkStr;
            }
            set
            {
                string strBackViewInfoLinkStr = value;
                Session.Add("BackViewInfoLinkStr", strBackViewInfoLinkStr);
            }
        }


        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinevViewInfoCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond =  " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (ddlCmPrjIdq.SelectedIndex>0)

            {
                strWhereCond += string.Format(" and ViewId in (Select ViewId from ViewInfoCmPrjIdRela where CmPrjId='{0}')", ddlCmPrjIdq.SelectedValue);
            }
            if (vsCmPrjId != ddlCmPrjIdq.SelectedValue)
            {
                var strCmPrjId = ddlCmPrjIdq.SelectedValue;
                vsCmPrjId = strCmPrjId;
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            }
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.ddlViewTypeCodeq.SelectedValue != "" && this.ddlViewTypeCodeq.SelectedValue != "0")
            {
                strWhereCond += " and ViewTypeCode like '" + this.ddlViewTypeCodeq.SelectedValue + "%'";
            }
            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }

            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue + "'";
            }
            if (this.ddlViewGroupIdq.SelectedValue != "" && this.ddlViewGroupIdq.SelectedValue != "0")
            {
                strWhereCond += " And ViewGroupId='" + this.ddlViewGroupIdq.SelectedValue + "'";
            }
            if (this.ddlMainTabIdq.SelectedValue != "" && this.ddlMainTabIdq.SelectedValue != "0")
            {
                strWhereCond += string.Format(" And {0}='{1}'", convViewInfo.MainTabId, ddlMainTabIdq.SelectedValue);
            }

            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vViewInfo()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.DgStyleName, false);
                wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.TitleStyleName, false);
                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.ViewTypeName, false);

                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.ViewCnName, false);

                //	1、组合界面条件串；
                string strWhereCond = CombinevViewInfoCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvViewInfo4Gv1.BindGv_vViewInfo(strWhereCond);
                //	3、设置Gv控件的某些列不可见；

                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_ViewInfoBak()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombinevViewInfoCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = strSortViewInfoBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            /////设置GridView中每页的记录数
            //if (string.IsNullOrEmpty(PageSize) == false)
            //{
            //    int intPageSize = int.Parse(PageSize);
            //    gvViewInfo.PageSize = intPageSize;
            //}
            //else
            //{
            //    PageSize = "10";
            //    gvViewInfo.PageSize = 10;
            //}
            //this.gvViewInfo.DataSource = objDV;
            ////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //this.gvViewInfo.DataBind();

            /////生成专门用于BindGv中的跳页相关代码
            //GridViewRow pagerRow = gvViewInfo.BottomPagerRow;
            //if (pagerRow == null)
            //{
            //    return;
            //}
            //Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            //Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            //Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            //TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            //Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            //Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            //Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            //DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            //if (lblRecCount != null)
            //{
            //    //当前记录数
            //    lblRecCount.Text = objDT.Rows.Count.ToString();
            //    //当前页数
            //    lblAllPages.Text = this.gvViewInfo.PageCount.ToString();
            //    //当前页序数
            //    lblCurrentPage.Text = (this.gvViewInfo.PageIndex + 1).ToString();
            //    //当前即将跳到的页序数
            //    txtJump2Page.Text = (this.gvViewInfo.PageIndex + 1).ToString();
            //    //如果当前页序数为0，则<前一页>按钮无效
            //    if (this.gvViewInfo.PageIndex == 0)
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage,  false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, true);
            //    }
            //    //如果当前页序数已为最后一页，则<前一页>按钮无效
            //    if (this.gvViewInfo.PageIndex == this.gvViewInfo.PageCount - 1)
            //    {
            //         clsPubFun.SetButtonEnabled(btnNextPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, true);
            //    }
            //    //设置分页器中每页记录数的下拉框的值
            //    if (string.IsNullOrEmpty(PageSize) == false)
            //    {
            //        ddlPagerRecCount.Text = PageSize;
            //    }
            //    else
            //    {
            //        PageSize = "10";
            //        ddlPagerRecCount.Text = PageSize;
            //    }
            //}
            //gvViewInfo.BottomPagerRow.Visible = true;
        }
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
        public string Substring(string strSource, int intStart, int intLen)
        {
            if (strSource.Length > intStart + intLen)
            {
                return strSource.Substring(intStart, intLen);
            }
            else if (strSource.Length > intStart)
            {
                return strSource.Substring(intStart);
            }
            else
            {
                return strSource;
            }
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
            wucvViewInfo4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在DATAGRID中
            BindGv_vViewInfo();
            //保存这次查询条件，为下一次再来该界面服务================
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            seApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            if (string.IsNullOrEmpty(ddlViewTypeCodeq.SelectedValue) == true)
            {

            }
            else
            {
                seViewTypeCode = int.Parse(ddlViewTypeCodeq.SelectedValue);
            }
            ViewName = txtViewNameq.Text;
            //=====================================================
        }
       
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strViewId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strViewId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strViewId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsViewInfoBL.IsExist(strViewId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strViewId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
            //4、获取类对象的所有属性；
            clsViewInfoBL .GetViewInfo(ref  objViewInfo);
            Session.Add("objViewInfo", objViewInfo);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromViewInfoClass(objViewInfo);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjViewInfo">表实体类对象</param>
        private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            wucViewInfo1.ViewId = pobjViewInfo.ViewId;
            wucViewInfo1.ViewName = pobjViewInfo.ViewName;
            wucViewInfo1.ViewCnName = pobjViewInfo.ViewCnName;
            wucViewInfo1.FileName = pobjViewInfo.FileName;
            wucViewInfo1.FilePath = pobjViewInfo.FilePath;
            wucViewInfo1.DefaMenuName = pobjViewInfo.DefaMenuName;
            wucViewInfo1.ApplicationTypeId = pobjViewInfo.ApplicationTypeId;
            wucViewInfo1.ViewGroupId = pobjViewInfo.ViewGroupId;
            
            wucViewInfo1.FuncModuleAgcId = pobjViewInfo.FuncModuleAgcId;

            wucViewInfo1.DataBaseName = pobjViewInfo.DataBaseName;
            wucViewInfo1.MainTabId = pobjViewInfo.MainTabId;
            wucViewInfo1.DetailTabId = pobjViewInfo.DetailTabId;
            wucViewInfo1.KeyForMainTab = pobjViewInfo.KeyForMainTab;
            wucViewInfo1.KeyForDetailTab = pobjViewInfo.KeyForDetailTab;
            wucViewInfo1.IsNeedSort = pobjViewInfo.IsNeedSort;
            wucViewInfo1.IsNeedTransCode = pobjViewInfo.IsNeedTransCode;
            wucViewInfo1.UserId = pobjViewInfo.UserId;
            wucViewInfo1.PrjId = pobjViewInfo.PrjId;
            wucViewInfo1.CmPrjId = pobjViewInfo.PrjId;

            wucViewInfo1.ViewFunction = pobjViewInfo.ViewFunction;
            wucViewInfo1.ViewDetail = pobjViewInfo.ViewDetail;
            wucViewInfo1.InSqlDsTypeId = pobjViewInfo.InSqlDsTypeId;
            wucViewInfo1.InRelaTabId = pobjViewInfo.InRelaTabId;
            wucViewInfo1.OutSqlDsTypeId = pobjViewInfo.OutSqlDsTypeId;
            wucViewInfo1.OutRelaTabId = pobjViewInfo.OutRelaTabId;
            wucViewInfo1.IsNeedSetExportFld = pobjViewInfo.IsNeedSetExportFld;
            wucViewInfo1.KeyId4Test = pobjViewInfo.KeyId4Test;
            wucViewInfo1.ViewMasterId = pobjViewInfo.ViewMasterId;


        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;	//专门用于传递信息的变量
            string strCommandText;
            clsViewInfoEN objViewInfo;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "确认添加";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = objUser.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    //操作步骤：
                    //1、检查控件中输入数据类型是否正确
                    //2、定义对象并初始化对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //4、把值从界面层传到逻辑层或数据实体层
                    //5、检查传进去的对象属性是否合法
                    //6、把数据实体层的数据存贮到数据库中
                    //7、把新添的记录内容显示在DATAGRID中
                    //1、检查控件中输入数据类型是否正确
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    //clsViewInfoEN objViewInfo;	//定义对象
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    objViewInfo = new clsViewInfoEN(wucViewInfo1.ViewId);	//初始化新对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    if (clsViewInfoBL.IsExist(objViewInfo.ViewId))	//判断是否有相同的关键字
                    {
                        strMsg = "关键字字段已有相同的值";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //检查在当前工程中是否含有同名界面名称
                    if (clsViewInfoBL.IsExistRecord("PrjId = '" + clsPubVar.CurrSelPrjId + "' and ViewName = '" + wucViewInfo1.ViewName + "'"))	//判断是否有相同的关键字
                    {
                        strMsg = "本项目中已存在同名的界面名称!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToViewInfoClass(objViewInfo);		//把界面的值传到

                    //5、检查传进去的对象属性是否合法

                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    try
                    {
                        if (clsViewInfoBL.AddNewRecordBySql2(objViewInfo) == false)
                        {
                            strMsg = "添加不成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "添加记录不成功!";
                        }
                        else
                        {
                            //添加默认的界面模式
                            clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                            strMsg = "添加记录成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "添加记录成功!";
                            tabQueryRegion.Visible = true;
                            tabEditRegion.Visible = false;
                        }
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    //7、把新添的记录内容显示在DATAGRID中
                    BindGv_vViewInfo();
                    wucViewInfo1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpd.Text = "添加";
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    //操作步骤：
                    //1、检查控件中输入数据类型是否正确
                    //2、把值从界面层传到逻辑层或数据实体层
                    //3、检查传进去的对象属性是否合法
                    //4、把数据实体层的数据存贮到数据库中
                    //5、把修改后的内容显示在DATAGRID中
                    //1、检查控件中输入数据类型是否正确
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objViewInfo = (clsViewInfoEN)Session["objViewInfo"];
                    //检查在当前工程中是否含有同名界面名称
                    StringBuilder sbCondition = new StringBuilder();
                    sbCondition.AppendFormat("PrjId = '{0}'", clsPubVar.CurrSelPrjId);
                    sbCondition.AppendFormat(" and ViewName = '{0}'", wucViewInfo1.ViewName);
                    sbCondition.AppendFormat(" and ViewId <> '{0}'", wucViewInfo1.ViewId);

                    if (clsViewInfoBL.IsExistRecord(sbCondition.ToString()))	//判断是否有相同的关键字
                    {
                        strMsg = "本项目中已存在同名的界面名称!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }

                    PutDataToViewInfoClass(objViewInfo);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法
                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsViewInfoBL .UpdateBySql2(objViewInfo) == false)
                    {
                        strMsg = "修改记录不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录不成功!";
                    }
                    else
                    {
                        //添加默认的界面模式
                        clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                        strMsg = "修改记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录成功!";
                        tabQueryRegion.Visible = true;
                        tabEditRegion.Visible = false;
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    BindGv_vViewInfo();
                    wucViewInfo1.Clear();//添空控件中的内容
                    //恢复<确认修改>变成<添加>
                    btnOKUpd.Text = "添加";
                    break;

            }
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjViewInfo">数据传输的目的类对象</param>
        private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            pobjViewInfo.ViewId = wucViewInfo1.ViewId;
            pobjViewInfo.ViewName = wucViewInfo1.ViewName;
            pobjViewInfo.ViewCnName = wucViewInfo1.ViewCnName;
            pobjViewInfo.FileName = wucViewInfo1.FileName;
            pobjViewInfo.FilePath = wucViewInfo1.FilePath;
            pobjViewInfo.DefaMenuName = wucViewInfo1.DefaMenuName;
            pobjViewInfo.ApplicationTypeId = wucViewInfo1.ApplicationTypeId;
            pobjViewInfo.ViewGroupId = wucViewInfo1.ViewGroupId;

            pobjViewInfo.FuncModuleAgcId = wucViewInfo1.FuncModuleAgcId;
            pobjViewInfo.DataBaseName = wucViewInfo1.DataBaseName;
            pobjViewInfo.MainTabId = wucViewInfo1.MainTabId;
            pobjViewInfo.DetailTabId = wucViewInfo1.DetailTabId;
            pobjViewInfo.KeyForMainTab = wucViewInfo1.KeyForMainTab;
            pobjViewInfo.KeyForDetailTab = wucViewInfo1.KeyForDetailTab;
            pobjViewInfo.IsNeedSort = wucViewInfo1.IsNeedSort;
            pobjViewInfo.IsNeedTransCode = wucViewInfo1.IsNeedTransCode;
            pobjViewInfo.UserId = wucViewInfo1.UserId;
            pobjViewInfo.PrjId = wucViewInfo1.PrjId;
            pobjViewInfo.PrjId = wucViewInfo1.CmPrjId;

            pobjViewInfo.ViewFunction = wucViewInfo1.ViewFunction;
            pobjViewInfo.ViewDetail = wucViewInfo1.ViewDetail;
            pobjViewInfo.InRelaTabId = wucViewInfo1.InRelaTabId;
            pobjViewInfo.InSqlDsTypeId = wucViewInfo1.InSqlDsTypeId;
            pobjViewInfo.OutSqlDsTypeId = wucViewInfo1.OutSqlDsTypeId;
            pobjViewInfo.OutRelaTabId = wucViewInfo1.OutRelaTabId;
            pobjViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            pobjViewInfo.IsNeedSetExportFld = wucViewInfo1.IsNeedSetExportFld;
            pobjViewInfo.KeyId4Test = wucViewInfo1.KeyId4Test;

            pobjViewInfo.UpdUserId = clsCommonSession.UserId;
            pobjViewInfo.ViewMasterId = wucViewInfo1.ViewMasterId;


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

      
        /// <summary>
        /// 功能：修改界面记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, System.EventArgs e)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ShowData(strViewId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewInfo1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsg.Text = "";
            tabQueryRegion.Visible = false;
            tabEditRegion.Visible = true;
        }

        /// <summary>
        /// 功能：删除界面记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, System.EventArgs e)
        {
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            lblMsgList.Text = "";

            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBL.DelRecord(strViewId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();

        }

        /// <summary>
        /// 功能：为界面添加操作流程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewOptStep_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewOptSteps_QUDI.aspx");
        }

        /// <summary>
        /// 功能：编辑界面的相关表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewRelaTab_QUDI.aspx");
        }

        /// <summary>
        /// 功能：编辑界面的按钮操作步骤；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewBtnOptSteps_QUDI.aspx");
        }
        /// <summary>
        /// 功能：编辑界面的字段信息，为界面添加、删除等维护字段信息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditViewField_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewAddField.aspx");
           
        }
        /// <summary>
        /// 功能：本函数仅仅设置界面的字段信息，不添加、删除字段信息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSetViewFld_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewSetField.aspx");
          

        }

        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQueryRegion.Visible = true;
            tabEditRegion.Visible = false;
        }

        protected void btnAddNewView_Click(object sender, System.EventArgs e)
        {
            wucViewInfo1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucViewInfo1.UserId = objUser.UserId;
            wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
            wucViewInfo1.CmPrjId = vsCmPrjId;
            wucViewInfo1.DataBaseName = new clsCommonSession().PrjDataBaseName;
            wucViewInfo1.FilePath = "webform/";
            tabQueryRegion.Visible = false;
            tabEditRegion.Visible = true;
        }

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnExportExcel_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }
        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vViewInfo]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevViewInfoCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ViewInfo信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convViewInfo.ViewId); arrCnName.Add("界面ID");
            arrColName.Add(convViewInfo.ViewName); arrCnName.Add("界面名称");
            arrColName.Add(convViewInfo.ViewCnName); arrCnName.Add("视图中文名");
            //arrColName.Add(convViewInfo.ViewTypeName); arrCnName.Add("界面类型");
            arrColName.Add(convViewInfo.FuncModuleName); arrCnName.Add("模块");
            arrColName.Add(convViewInfo.FuncModuleEnName); arrCnName.Add("模块英文名");
            arrColName.Add(convViewInfo.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convViewInfo.DefaMenuName); arrCnName.Add("缺省菜单名");
            arrColName.Add(convViewInfo.FileName); arrCnName.Add("文件名");
            arrColName.Add(convViewInfo.FilePath); arrCnName.Add("文件路径");
            arrColName.Add(convViewInfo.MainTabName); arrCnName.Add("主表名");
            arrColName.Add(convViewInfo.DetailTabName); arrCnName.Add("详细表名");
            arrColName.Add(convViewInfo.UpdDate); arrCnName.Add("修改日期");
            //arrColName.Add(convViewInfo.RegionNum); arrCnName.Add("区域数");
            arrColName.Add(convViewInfo.ViewFunction); arrCnName.Add("界面功能");
            strFolderName = Entity.clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取数据出错,请联系管理员！错误:{0}.({1})",
                objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                try
                {
                    Entity.clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);
                    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                    //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
                }
                catch (Exception objException2)
                {
                    string strMsg = string.Format("导出Excel出错,请联系管理员！错误:{0}.({1})",
                    objException2.Message, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
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

        protected void btnDesignView_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmDesignView3.aspx");           
        }

        protected void btnSetViewStyle_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewRegion_QUDI.aspx");
        }

        protected void btnDelViewEx_Click(object sender, System.EventArgs e)
        {
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.DelRecordEx(strViewId);
                }
                clsViewInfoBL.ReFreshCache(clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vViewInfo();
        }

        //private string strSortBy
        //{
        //    get
        //    {
        //        string sSortBy;
        //        sSortBy = (string)ViewState["SortBy"];
        //        if (sSortBy == null)
        //        {
        //            sSortBy = "";
        //        }
        //        return sSortBy;
        //    }
        //    set
        //    {
        //        string sSortBy = value;
        //        ViewState.Add("SortBy", sSortBy);
        //    }
        //}

        //生成错误信息的Session属性
        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }
        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortViewInfoBy
        {
            get
            {
                string sSortViewInfoBy;
                sSortViewInfoBy = (string)ViewState["SortViewInfoBy"];
                if (sSortViewInfoBy == null)
                {
                    sSortViewInfoBy = "";
                }
                return sSortViewInfoBy;
            }
            set
            {
                string sSortViewInfoBy = value;
                ViewState.Add("SortViewInfoBy", sSortViewInfoBy);
            }
        }
        protected void ddlApplicationTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;
            if (strApplicationTypeId != null && strApplicationTypeId != "")
            {
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, int.Parse( strApplicationTypeId));
            }
        }
        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            lblMsgList.Text = "";
            clsCommonSession.ViewId = strViewId;
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenViewCodeV6.aspx','aa'); </script>";
            Response.Write(c1);
        }
        protected void btnEditViewAll_Click(object sender, EventArgs e)
        {
            JumpOtherPages("wfmViewInfo_U.aspx");
        }
        ///生成与跳页的相关函数
      
    
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
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
            string strViewId = "";
            switch (strPageName)
            {
                case "wfmViewOptSteps_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewOptSteps_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewRelaTab_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewRelaTab_QUDI(this, strCurrPageName);
          
                    break;
                case "wfmViewBtnOptSteps_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewBtnOptSteps_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewAddField.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewAddField(this, strCurrPageName);
             
                    break;
                case "wfmViewSetField.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewSetField(this, strCurrPageName);
                    break;
                case "wfmDesignView3.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToDesignView3(this, strCurrPageName);
             
                    break;
                case "wfmViewRegion_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    BackViewInfoLinkStr = "../View/wfmViewInfo_QUDI.aspx";
                    clsPubFun4Web.JumpToViewRegion_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewInfo_U.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToViewInfo_U(this, strCurrPageName);

                    break;
                case "wfmViewInfo_U.aspx1":
                    //int deleteid = (int)GridView1.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value;  
                  //  strViewId = gvViewInfo.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value.ToString();
                  
                    if (string.IsNullOrEmpty( vsViewId_T) == true)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = vsViewId_T;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToViewInfo_U(this, strCurrPageName);

                    break;

                case "AddViewRegion":

                    if (string.IsNullOrEmpty(vsViewId_T) == true)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = vsViewId_T;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToAddViewRelaRegion(this, strCurrPageName);
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
                return "wfmViewInfo_QUDI.aspx";
            }
        }

        protected void btnClone_Click(object sender, EventArgs e)
        {
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            try
            {
                clsViewInfoBLEx.Clone(strViewId, clsCommonSession.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vViewInfo();
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("在克隆界面时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        protected void btnCheckRegion_Click(object sender, EventArgs e)
        {
            int intTotal = 0;
            //int intRegionNum = clsViewRegionRelaBLEx.GetRegionNumByViewId()
            string strCondition = string.Format("1=1");
            List<clsvViewInfoEN> arrObjLst = clsvViewInfoBL.GetObjLst(strCondition);
            foreach (clsvViewInfoEN objInFor in arrObjLst)
            {
             
                string strRegionName = "";
                List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(objInFor.ViewId, clsPubVar.CurrSelPrjId);
                //var result = arrViewRegionObjLst.GroupBy(d => d.RegionName);
                //var ee = result.Where(d => d.Key == 1).FirstOrDefault() == null ? 0 : result.Where(d => d.Key == 1).FirstOrDefault().Count();
                //Console.WriteLine(ee);
                //Console.ReadLine();

                var groupList = arrViewRegionObjLst.GroupBy(m => new { m.RegionName }).
                       Select(a => new
                       {
                           RegionName = a.Key.RegionName,
                           RegionNum = a.Count()
                       }).ToList();
                foreach (var item in groupList)
                {
                    if (item.RegionNum == 1) continue;
                    strRegionName = item.RegionName;
                    break;
                    //Console.WriteLine("RegionName:{0}--RegionNum:{1}", item.RegionName, item.RegionNum);
                }
                if (string.IsNullOrEmpty(strRegionName) == true) continue;
                if (strRegionName != "列表区域") continue;
                IEnumerable<clsViewRegionEN> arrViewRegionObjLst_Sel1 =
from objViewRegionEN in arrViewRegionObjLst
where objViewRegionEN.RegionName == strRegionName
orderby objViewRegionEN.RegionId
select objViewRegionEN;
                List<clsViewRegionEN> arrViewRegionObjLst_Sel = new List<clsViewRegionEN>();
                string lngRegionId = "";
                foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
                {
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId , obj.RegionId);
                    int intRecNum = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                    if (intRecNum == 0)
                    {
                        lngRegionId =  obj.RegionId;
                        break;
                    }
                    arrViewRegionObjLst_Sel.Add(obj);
                }
                if (string.IsNullOrEmpty(lngRegionId ) == false)
                {
                    clsViewRegionBL.DelRecord(lngRegionId);
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, lngRegionId);
                    clsDGRegionFldsBL.DelDGRegionFldssByCond(strCondition);
                    intTotal++;
                    continue;
                }
                int intRecNum1 = 0;
                int intRecNum2 = 0;
                string lngRegionId0 = "";
                string lngRegionId1 = "";
                string lngRegionId2 = "";

                foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
                {
                    if (string.IsNullOrEmpty( lngRegionId0 ) == true) lngRegionId0 = obj.RegionId;
                     strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, obj.RegionId);
                    if (intRecNum1 == 0)
                    {
                        intRecNum1 = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                        lngRegionId1 = obj.RegionId;
                    }
                    else
                    {
                        intRecNum2 = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                        lngRegionId2 = obj.RegionId;
                    }
                    if (intRecNum1 < intRecNum2)
                    {
                        lngRegionId = lngRegionId2;
                    }
                    else if (intRecNum1 > intRecNum2)
                    {
                        lngRegionId = lngRegionId1;
                    }
                    else
                    {
                        lngRegionId = lngRegionId0;
                    }
                }
                if (string.IsNullOrEmpty(lngRegionId ) == false)
                {
                    clsViewRegionBL.DelRecord(lngRegionId);
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, lngRegionId);
                    clsDGRegionFldsBL.DelDGRegionFldssByCond(strCondition);
                    intTotal++;
                    continue;
                }
            }
            clsCommonJsFunc.Alert(this, "检查完成！总共删除了："+ intTotal.ToString());
        }

        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewInfo4Gv1_GvAddViewRegionClick(object sender, clsEventArgs4AddViewRegion e)
        {
            string strViewId = e.KeyId;
            vsViewId_T = strViewId;
            JumpOtherPages("AddViewRegion");
            //DeleteViewInfoRecord(strViewId);
        }

        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewInfo4Gv1_GvEditViewRegionClick(object sender, clsEventArgs4EditViewRegion e)
        {
            string strViewId = e.KeyId;
            vsViewId_T = strViewId;
            int intRegionNum = clsViewRegionRelaBLEx.GetRegionNumByViewId(strViewId);
            if (intRegionNum == 0)
            {
                JumpOtherPages("AddViewRegion");
            }
            else
            {
                JumpOtherPages("wfmViewInfo_U.aspx1");
            }
            //UpdateViewInfoRecord(strViewId);
        }

        public void SetDdl_MainTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdEx4QueryCache(ddlMainTabIdq, strPrjId);
        }
        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsCMProjectFuncModuleBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, strCmPrjId);
        }

        protected void btnSetCmPrjId_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjId_Set.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjId_Set.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjId_Set.SelectedValue;

            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.SetCmPrjId(strViewId, strCmPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();
            //clsUserDefaValue_LocalBLEx.setUserDefaValue(vsPrjId_Cache, clsPubVar.CurrPrjId, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            //vsCmPrjId = strCmPrjId;

        }
        protected string vsCmPrjId
        {
            get
            {
                string sCmPrjId;
                sCmPrjId = (string)ViewState["CmPrjId"];
                if (sCmPrjId == null)
                {
                    sCmPrjId = "";
                }
                return sCmPrjId;
            }
            set
            {
                string sCmPrjId = value;
                ViewState.Add("CmPrjId", sCmPrjId);
            }
        }

        protected void btnAutoGetPath4RegionFlds_Click(object sender, EventArgs e)
        {
            try
            {
                //int intCount = clsDnPathBLEx.AutoGetPath4RegionFlds(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //string strMsg = string.Format("共设置:[{0}]个路径。(In {1})",
                //        intCount, clsStackTrace.GetCurrClassFunction());
                //clsCommonJsFunc.Alert(this, strMsg);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnCheckRegionFlds_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.CheckRegionFlds(strViewId, strCmPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();
        }
    }
}