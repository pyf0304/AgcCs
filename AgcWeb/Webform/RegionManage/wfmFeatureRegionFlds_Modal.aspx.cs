///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/07
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：区域管理
///模块英文名：RegionManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
///生成查询，修改，删除，添加记录的控制层代码
using AGC.BusinessLogic;
using AGC.FunClass;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.web.treeview;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using AutoGCLib;
using Agc;
using AgcCommBase;
using com.taishsoft.json;
using System.Web.UI.HtmlControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFeatureRegionFlds_Modal 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFeatureRegionFlds_Modal : CommWebPageBase
    {
        /// <summary>
        /// 操作, 限制在界面内：LimitInInterface
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
        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号

        private string seRegionId_Once
        {
            get
            {
                string lngRegionId;
                if (Session["RegionId"] == null)
                {
                    lngRegionId = "";
                }
                else
                {
                    string strRegionId = Session["RegionId"].ToString();
                    lngRegionId = strRegionId;
                }
                return lngRegionId;
            }
            set
            {
                string lngRegionId = value;
                Session.Add("RegionId", lngRegionId);
            }
        }
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        Response.Redirect("./error.aspx");
                        break;
                    case "1":
                        Response.Redirect("./error.aspx");
                        break;
                    case "2":
                        Response.Redirect("./error.aspx");
                        break;
                    case "3":
                        Response.Redirect("./error.aspx");
                        break;
                    case "4":
                        Response.Redirect("./error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("./error.aspx");
                        break;
                }
                //初始化界面需要的数据
                InitViewData();
                //1、为下拉框设置数据源，绑定列表数据
                wucFeatureRegionFldsB1.SetDdl_CtlTypeId(false);
                wucFeatureRegionFldsB1.SetDdl_ValueGivingModeId();
                wucFeatureRegionFldsB1.SetDdl_ViewImplId();
                wucFeatureRegionFldsB1.HiddenTrTabId();
                wucFeatureRegionFldsB1.SetDdl_FeatureId();
                wucFeatureRegionFldsB1.SetDdl_FieldTypeId();
                wucFeatureRegionFldsB1.SetDdl_FldId(vsMainTabId);
                //wucFeatureRegionFldsB1.SetDdl_TabFeatureId();

                clsValueGivingModeBL.BindDdl_ValueGivingModeIdCache(ddlValueGivingModeId);
                clsCtlTypeBL.BindDdl_CtlTypeIdCache(ddlCtlTypeIdq);
                //clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, 
                //    new List<string>() { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.FrontHiddenInterface_04 });

                clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(vsRegionId, clsPubVar.CurrSelPrjId);
                chkInUse.Checked = objViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);


                //                strSortFeatureRegionFldsBy = "SeqNum Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_vFeatureRegionFlds();
                BindTv_ViewRegion();
                BindTv_ViewFeatureRela();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                DispFeatureRegionFldsListRegion();

                if (qsOperator == "LimitInInterface")
                {
                    tabQuery.Visible = false;
                    trTitle.Visible = false;
                }
            }

            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                if (objPrjTab != null)
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId, chkInUse.Checked);

                }
                else
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "表名", clsPubVar.CurrSelPrjId, chkInUse.Checked);
                }
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000319)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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

        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFeatureRegionFldsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddFeatureRegionFldsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objFeatureRegionFldsEN = (clsFeatureRegionFldsEN)Session["objFeatureRegionFldsEN"];
                    UpdateFeatureRegionFldsRecordSave(objFeatureRegionFldsEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddFeatureRegionFldsRecord();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {

        }
        protected void gvFeatureRegionFlds_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortFeatureRegionFldsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Asc";
                BindGv_vFeatureRegionFlds();
                return;
            }
            //检查原来是升序
            intIndex = strSortFeatureRegionFldsBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Desc";
            }
            BindGv_vFeatureRegionFlds();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortFeatureRegionFldsBy
        {
            get
            {
                string sSortFeatureRegionFldsBy;
                sSortFeatureRegionFldsBy = (string)ViewState["SortFeatureRegionFldsBy"];
                if (sSortFeatureRegionFldsBy == null)
                {
                    sSortFeatureRegionFldsBy = "";
                }
                return sSortFeatureRegionFldsBy;
            }
            set
            {
                string sSortFeatureRegionFldsBy = value;
                ViewState.Add("SortFeatureRegionFldsBy", sSortFeatureRegionFldsBy);
            }
        }

        ///
        protected void btnCancelFeatureRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispFeatureRegionFldsListRegion();
        }

        protected void btnCopyFldFromTemplate_Click(object sender, EventArgs e)
        {
            //操作步骤：
            //1、获取当前区域ID的相关主表ID；
            //2、获取相关主表ID的字段ID的对象列表;
            //2、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            clsFeatureRegionFldsBLEx.ImportRelaFlds(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId, UserId);
            BindGv_vFeatureRegionFlds();
            ///恢复<确认添加>变成<添加>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");
        }


        private void SetOperate(string strValue)
        {
            string strJs = string.Format("<script type=\"text/javascript\">strOperate='{0}';</script>", strValue);
            //this.ClientScript.RegisterStartupScript(this.GetType(), "SetOperate", strJs, true);
            litScript.Text = strJs;

        }
        protected void btnSaveSet_Click(object sender, EventArgs e)
        {
            string strRelaFldId = ddlRelaFldId.SelectedValue;
            string strValueGivingModeId = ddlValueGivingModeId.SelectedValue;
            string strDefaValue = txtDefaultValue.Text;
            string strFuncName = txtFuncName.Text;

            //var objFeatureGroup = new Tuple<string, string, string, string, string, string>(vsFeatureId, vsMainTabId, strRelaFldId, strValueGivingModeId, strFuncName, strDefaValue);
            var objFeatureRegionFlds = new clsFeatureRegionFldsEN()
            {
                FeatureId = vsFeatureId,
                ReleTabId = vsMainTabId,
                ReleFldId = strRelaFldId,
                ValueGivingModeId = strValueGivingModeId,
                FuncName = strFuncName,
                DefaultValue = strDefaValue,
                CtlTypeId = enumCtlType.Button_01
            };

            try
            {
                clsFeatureRegionFldsBLEx.AddFeatureRegionFldsRecordSave(vsRegionId, vsApplicationTypeId, vsMainTabId, objFeatureRegionFlds, clsCommonSession.UserId);

                SetOperate("Finished");
                lblErrMsg.Text = "";
            }
            catch (Exception objException)
            {
                lblErrMsg.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
                SetOperate("Update");

            }

            BindGv_vFeatureRegionFlds();
            BindTv_ViewFeatureRela();
        }

        protected void btnSetGroupName_Click(object sender, EventArgs e)
        {

        }

        protected void btnGetTabFeature_Click(object sender, EventArgs e)
        {
            try
            {
                List<clsFeatureRegionFldsEN> arrObjLst = clsFeatureRegionFldsBLEx.GetObjLstByViewIdEx(clsCommonSession.ViewId);
                foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjLst)
                {
                    bool bolResult = objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);
                }
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {

            BindGv_vFeatureRegionFlds();
            GvShowSet_All();
            //BindTv_ViewFeatureRela();
        }

        protected void btnGeneTabFeature_Click(object sender, EventArgs e)
        {

        }
    }
    public partial class wfmFeatureRegionFlds_Modal : CommWebPageBase
    {
        protected void ShowData(string strViewFeatureId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (string.IsNullOrEmpty(strViewFeatureId)) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsFeatureRegionFldsBL.IsExist(strViewFeatureId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strViewFeatureId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN(strViewFeatureId);
            //4、获取类对象的所有属性；
            try
            {
                clsFeatureRegionFldsBL.GetFeatureRegionFlds(ref objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objFeatureRegionFldsEN", objFeatureRegionFldsEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromFeatureRegionFldsClass(objFeatureRegionFldsEN);
        }

        //生成权限等级的属性
        protected string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }



        /// <summary>
        /// 登录的用户ID，用于检查用户权限
        /// </summary>
        protected string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        /// <summary>
        /// 控件类型号
        /// </summary>
        protected string CtlTypeId
        {
            get
            {
                string strCtlTypeId;
                strCtlTypeId = (string)Session["CtlTypeId"];
                if (strCtlTypeId == null)
                {
                    strCtlTypeId = "";
                }
                return strCtlTypeId;
            }
            set
            {
                string strCtlTypeId = value;
                Session.Add("CtlTypeId", strCtlTypeId);
            }
        }


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
        /// 错误信息的Session属性，该Session传递给显示出错页面，显示相应的错误内容。
        /// </summary>
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


        //生成返回链接串的Session属性
        /// <summary>
        /// 返回链接串的Session属性，该Session用于告诉出错页面，哪一个页面是需要返回的页面。
        /// </summary>
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevFeatureRegionFldsCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";

            if (qsOperator == "LimitInInterface")
            {
                strWhereCond = " 1=1 and RegionId = " + vsRegionId;
                //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
                return strWhereCond;
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtButtonNameq.Text.Trim() != "")
            {
                strWhereCond += " And ButtonName like '%" + this.txtButtonNameq.Text.Trim() + "%'";
            }
            if (this.txtTextq.Text.Trim() != "")
            {
                strWhereCond += " And Text like '%" + this.txtTextq.Text.Trim() + "%'";
            }
            if (this.ddlCtlTypeIdq.SelectedValue != "" && this.ddlCtlTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And CtlTypeId='" + this.ddlCtlTypeIdq.SelectedValue + "'";
            }
            if (this.txtCssClassq.Text.Trim() != "")
            {
                strWhereCond += " And CssClass like '%" + this.txtCssClassq.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        protected void BindGv_vFeatureRegionFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                GvShowSet_All();
                //	1、组合界面条件串；
                string strWhereCond = CombinevFeatureRegionFldsCondition();
                //	2、调用控件中的绑定GridView函数；

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                if (objPrjTab != null)
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId, chkInUse.Checked);

                }
                else
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "表名", clsPubVar.CurrSelPrjId, chkInUse.Checked);
                }

                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000319)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }
        private void GvShowSet_All()
        {


        }
        private void GvShowSet_Sim()
        {


        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjFeatureRegionFldsEN">表实体类对象</param>
        protected void GetDataFromFeatureRegionFldsClass(clsFeatureRegionFldsEN pobjFeatureRegionFldsEN)
        {
            wucFeatureRegionFldsB1.SetDdl_TabFeatureId(pobjFeatureRegionFldsEN.ReleTabId, pobjFeatureRegionFldsEN.PrjId);

            wucFeatureRegionFldsB1.RegionId = pobjFeatureRegionFldsEN.RegionId;// 区域Id
            wucFeatureRegionFldsB1.DefaultValue = pobjFeatureRegionFldsEN.DefaultValue;// 缺省值
            wucFeatureRegionFldsB1.FieldTypeId = pobjFeatureRegionFldsEN.FieldTypeId;// 相关字段Id

            wucFeatureRegionFldsB1.FeatureId = pobjFeatureRegionFldsEN.FeatureId;// 区域Id

            wucFeatureRegionFldsB1.ButtonName = pobjFeatureRegionFldsEN.ButtonName;// 按钮名称
            wucFeatureRegionFldsB1.ButtonName4Mvc = pobjFeatureRegionFldsEN.ButtonName4Mvc;// 按钮名称
            wucFeatureRegionFldsB1.Text = pobjFeatureRegionFldsEN.Text;// 文本
            wucFeatureRegionFldsB1.TabId = pobjFeatureRegionFldsEN.ReleTabId;// 相关表Id
            wucFeatureRegionFldsB1.FldId = pobjFeatureRegionFldsEN.ReleFldId;// 相关字段Id
            wucFeatureRegionFldsB1.ValueGivingModeId = pobjFeatureRegionFldsEN.ValueGivingModeId;// 给值方式Id
            wucFeatureRegionFldsB1.FuncName = pobjFeatureRegionFldsEN.FuncName;// 函数名

            wucFeatureRegionFldsB1.ViewImplId = pobjFeatureRegionFldsEN.ViewImplId;// 界面实现Id
            wucFeatureRegionFldsB1.CtlTypeId = pobjFeatureRegionFldsEN.CtlTypeId;// 控件类型号
            wucFeatureRegionFldsB1.CssClass = pobjFeatureRegionFldsEN.CssClass;// 样式表
            wucFeatureRegionFldsB1.ImageUrl = pobjFeatureRegionFldsEN.ImageUrl;// 图片资源
            wucFeatureRegionFldsB1.InUse = pobjFeatureRegionFldsEN.InUse;// 是否在用
            //wucFeatureRegionFldsB1.Height = pobjFeatureRegionFldsEN.Height;// 高度
            wucFeatureRegionFldsB1.Width = pobjFeatureRegionFldsEN.Width ?? 0;// 宽
            wucFeatureRegionFldsB1.SeqNum = pobjFeatureRegionFldsEN.SeqNum ?? 0;// 字段序号
            //wucFeatureRegionFldsB1.Memo = pobjFeatureRegionFldsEN.Memo;// 说明
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjFeatureRegionFldsEN">数据传输的目的类对象</param>
        protected void PutDataToFeatureRegionFldsClass(clsFeatureRegionFldsEN pobjFeatureRegionFldsEN)
        {

            pobjFeatureRegionFldsEN.SetRegionId(wucFeatureRegionFldsB1.RegionId)// 区域Id
.SetButtonName(wucFeatureRegionFldsB1.ButtonName)// 按钮名称
.SetButtonName4Mvc(wucFeatureRegionFldsB1.ButtonName4Mvc)// 按钮名称
.SetText(wucFeatureRegionFldsB1.Text)// 文本
.SetReleTabId(vsMainTabId)// 文本
.SetReleFldId(wucFeatureRegionFldsB1.FldId)// 文本
.SetFieldTypeId(wucFeatureRegionFldsB1.FieldTypeId)// 文本

.SetFuncName(wucFeatureRegionFldsB1.FuncName)// 文本
.SetDefaultValue(wucFeatureRegionFldsB1.DefaultValue)// 文本
.SetValueGivingModeId(wucFeatureRegionFldsB1.ValueGivingModeId)// 文本

.SetViewImplId(wucFeatureRegionFldsB1.ViewImplId)// 界面实现Id
.SetCtlTypeId(wucFeatureRegionFldsB1.CtlTypeId)// 控件类型号
.SetCssClass(wucFeatureRegionFldsB1.CssClass)// 样式表
.SetImageUrl(wucFeatureRegionFldsB1.ImageUrl)// 图片资源
.SetInUse(wucFeatureRegionFldsB1.InUse)// 是否在用
                                       //.SetHeight(wucFeatureRegionFldsB1.Height)// 高度
.SetWidth(wucFeatureRegionFldsB1.Width)// 宽
.SetSeqNum(wucFeatureRegionFldsB1.SeqNum)// 字段序号
.SetUpdUser(clsCommonSession.UserId)// 修改者
.SetUpdDate(clsDateTime.getTodayDateTimeStr(1));// 修改日期
                                                //.SetMemo(wucFeatureRegionFldsB1.Memo);// 说明
            if (string.IsNullOrEmpty(clsCommonSession.UserId) == true)
            {
                pobjFeatureRegionFldsEN.UpdUser = "pyf";//    修改用户

            }
            else
            {
                pobjFeatureRegionFldsEN.UpdUser = clsCommonSession.UserId;//    修改用户
            }

        }


        ///生成的插入记录准备过程代码for C#
        protected void AddFeatureRegionFldsRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelFeatureRegionFldsEdit.Text = "取消添加";

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId(clsCommonSession.ViewId);
            wucFeatureRegionFldsB1.SetDdl_TabFeatureId(objViewInfo.MainTabId, objViewInfo.PrjId);

            DispEditFeatureRegionFldsRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddFeatureRegionFldsRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            ///3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFeatureRegionFldsEN objFeatureRegionFldsEN;	//定义对象
            objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN);
                objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureRegionFldsEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddFeatureRegionFldsRecordSaveV5()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFeatureRegionFldsEN objFeatureRegionFldsEN;	//定义对象
            objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureRegionFldsEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateFeatureRegionFldsRecord(string strViewFeatureId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strViewFeatureId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "确认修改";
            btnCancelFeatureRegionFldsEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFeatureRegionFldsRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateFeatureRegionFldsRecordSave(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);

            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureRegionFldsEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateFeatureRegionFldsRecordSaveV5(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureRegionFldsEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteFeatureRegionFldsRecord(string strViewFeatureId)
        {
            try
            {
                clsFeatureRegionFldsBL.DelRecord(strViewFeatureId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevFeatureRegionFldsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FeatureRegionFlds信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("RegionId"); arrCnName.Add("区域Id");
            arrColName.Add("ButtonName"); arrCnName.Add("按钮名称");
            arrColName.Add("Text"); arrCnName.Add("文本内容");
            arrColName.Add("CtlTypeId"); arrCnName.Add("控件类型号");
            arrColName.Add("CtlTypeName"); arrCnName.Add("CtlTypeName");
            arrColName.Add("Height"); arrCnName.Add("高度");
            arrColName.Add("Width"); arrCnName.Add("宽");
            arrColName.Add("ButtonStyleId"); arrCnName.Add("按钮样式Id");
            arrColName.Add("ButtonStyleName"); arrCnName.Add("ButtonStyleName");
            arrColName.Add("CssClass"); arrCnName.Add("样式表");
            arrColName.Add("CssClassP"); arrCnName.Add("CssClassP");
            arrColName.Add("ImageUrl"); arrCnName.Add("图片资源");
            arrColName.Add("ViewCnName"); arrCnName.Add("视图中文名");
            arrColName.Add("CtlCnName"); arrCnName.Add("CtlCnName");
            arrColName.Add("CtlTypeAbbr"); arrCnName.Add("CtlTypeAbbr");
            arrColName.Add("RegionTypeId"); arrCnName.Add("区域类型Id");
            arrColName.Add("RegionTypeName"); arrCnName.Add("区域类型名称");
            arrColName.Add("RegionName"); arrCnName.Add("区域名称");
            arrColName.Add("RegionFunction"); arrCnName.Add("区域功能");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("ViewId"); arrCnName.Add("界面ID");
            arrColName.Add("ViewName"); arrCnName.Add("界面名称");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("SeqNum"); arrCnName.Add("字段序号");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFeatureRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditFeatureRegionFldsRegion()
        {
            tabFeatureRegionFldsGridView.Visible = false;
            tabEditFeatureRegionFldsRegion.Visible = true;
        }
        private void DispFeatureRegionFldsListRegion()
        {
            tabFeatureRegionFldsGridView.Visible = true;
            tabEditFeatureRegionFldsRegion.Visible = false;
        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "请在左边界面区域树中选中一个区域！");
                return;
            }
            //string strMsg;

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "请在左边界面区域树中选中一个区域！");
                return;
            }
            //string strMsg;

        }
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "请在左边界面区域树中选中一个区域！");
                return;
            }
            //string strMsg;

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "请在左边界面区域树中选中一个区域！");
                return;
            }


        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "请在左边界面区域树中选中一个区域！");
                return;
            }
            clsFeatureRegionFldsBL.ReOrder(vsRegionId);
            BindGv_vFeatureRegionFlds();
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {

        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {

        }


        protected void btnBatchAddFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsCommonSession.ViewId) == true)
            {
                clsCommonJsFunc.Alert(this, "当前界面Id为空，请重新登录！");
                return;
            }
            //gvFeatureFuncRela.Visible = false


            GvShowSet_Sim();
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinePrjFeatureCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

            string strWhereCond = string.Format(" 1 = 1 and {0} not in (Select {0} From {1} Where {2} in ({3})) And {4}='{5}' And {6}='1' ",

              
                convPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName,

                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                conPrjFeature.FeatureTypeId,
                enumPrjFeatureType.FrontInterface_01,
                conPrjFeature.InUse);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            //clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
            //try
            //{

            //    if (this.txtFuncName4Codeq.Text.Trim() != "")
            //    {
            //        objvPrjFeatureEN.FuncName4Code = this.txtFuncName4Codeq.Text.Trim();
            //        strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.FuncName4Code, this.txtFuncName4Codeq.Text.Trim());
            //    }

            //    clsvPrjFeatureBL.CheckProperty4Condition(objvPrjFeatureEN);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombinePrjFeatureCondition)时出错!请联系管理员!" + objException.Message);
            //    throw new Exception(strMsg);
            //}
            return strWhereCond;

        }
        protected void btnConfirmBatchAddFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsCommonSession.ViewId) == true)
            {
                clsCommonJsFunc.Alert(this, "当前界面Id为空，请重新登录！");
                return;
            }
            BindGv_vFeatureRegionFlds();
            GvShowSet_All();
            BindTv_ViewFeatureRela();
        }
               
        private void BindTv_ViewFeatureRela()
        {
            // wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4GeneCode;
            wucTreeView1.ViewId = clsCommonSession.ViewId;
            wucTreeView1.BindTv();
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView1.ExpandLevel1();
            wucTreeView1.CollapseAll();
            wucTreeView1.Expand(1);

            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindTv_ViewRegion()
        {
            // wucTreeView4ViewRegion.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucTreeView4ViewRegion.tmTreeModel = TreeModel.ViewRegion;
            wucTreeView4ViewRegion.ViewId = clsCommonSession.ViewId;
            wucTreeView4ViewRegion.BindTv();
            wucTreeView4ViewRegion.ExpandAll();
            //wucTreeView4ViewRegion.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView4ViewRegion.CollapseAll();
            if (string.IsNullOrEmpty(strKeyId) == true)
            {
                wucTreeView4ViewRegion.SelectNodeEx(clsvViewRegionEN._CurrTabName, vsRegionId.ToString());
            }
            else
            {
                wucTreeView4ViewRegion.SelectNodeEx(strTypeName, strKeyId);
            }
        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }
        protected string vsMainTabId
        {
            get
            {
                string sMainTabId;
                sMainTabId = (string)ViewState["MainTabId"];
                if (sMainTabId == null)
                {
                    sMainTabId = "";
                }
                return sMainTabId;
            }
            set
            {
                string sMainTabId = value;
                ViewState.Add("MainTabId", sMainTabId);
            }
        }

        protected string vsFeatureId
        {
            get
            {
                string sFeatureId;
                sFeatureId = (string)ViewState["FeatureId"];
                if (sFeatureId == null)
                {
                    sFeatureId = "";
                }
                return sFeatureId;
            }
            set
            {
                string sFeatureId = value;
                ViewState.Add("FeatureId", sFeatureId);
            }
        }
        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strKeyId);
            string strFeatureId = wucTreeView1.NodeData.FeatureId;//
            string strHtml = string.Format("~/Webform/PrjFunction/wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}&ParentPage=../View/wfmViewFeatureRelaB_InMasterPage.aspx",
                strFeatureId);
            Response.Redirect(strHtml);

            //   btnGetCurrNodeRelaValue_Click(null, null);
            //throw new NotImplementedException();
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；

        }
        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(string strViewFeatureId)
        {
            try
            {
                K_ViewFeatureId_FeatureRegionFlds myKey = strViewFeatureId;
                clsFeatureRegionFldsEN objFeatureRegionFldsEN = myKey.GetObj();
                objFeatureRegionFldsEN.ButtonName = "C_" + objFeatureRegionFldsEN.ButtonName;
                objFeatureRegionFldsEN.ButtonName4Mvc = "C_" + objFeatureRegionFldsEN.ButtonName4Mvc;
                objFeatureRegionFldsEN.AddNewRecord();
                string strViewFeatureId_New = objFeatureRegionFldsEN.ViewFeatureId;
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureId(strViewFeatureId);
                foreach (clsViewFeatureFldsEN objInFor in arrViewFeatureFlds)
                {
                    objInFor.SetViewFeatureId(strViewFeatureId_New)
                       .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                       .SetUpdUser(clsCommonSession.UserId)
                        .AddNewRecord();
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在克隆记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }
        /// <summary>
        /// 初始化界面需要数据
        /// </summary>
        private void InitViewData()
        {
            if (string.IsNullOrEmpty( seRegionId_Once ) == false)
            {
                vsRegionId = seRegionId_Once;
            }
            K_ViewId_ViewInfo objKey = new K_ViewId_ViewInfo(clsCommonSession.ViewId);
            clsViewInfoEN objViewInfoEN = objKey.GetObj();
            vsMainTabId = objViewInfoEN.MainTabId;
            vsApplicationTypeId = objViewInfoEN.ApplicationTypeId;
            wucFeatureRegionFldsB1.vsMainTabId = objViewInfoEN.MainTabId;
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFeatureRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strViewFeatureId = e.KeyId;
            DeleteFeatureRegionFldsRecord(strViewFeatureId);
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFeatureRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strViewFeatureId = e.KeyId;
            UpdateFeatureRegionFldsRecord(strViewFeatureId);
        }

        protected void btnRefreshTv_Click(object sender, EventArgs e)
        {
            BindTv_ViewRegion();
        }

        protected void wucTreeView4ViewRegion_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //wucTreeView4TabFeature.CollapseAll();
            wucTreeView4ViewRegion.SelectNodeEx(strTypeName, strKeyId);
            //List<string> arrCurrPathNodeKeyIdLst = wucTreeView4ViewRegion.GetCurrPathNodeKeyIdLst();
            //wucTreeView4ViewRegion.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            if (strTypeName == clsViewRegionEN._CurrTabName || strTypeName == clsvViewRegionEN._CurrTabName)
            {
                vsRegionId = strKeyId;
                BindGv_vFeatureRegionFlds();
                return;
            }
        }

        protected void btnDeleteTabFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                string strMsg = string.Format("请在树中选择一个表功能.(In {0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //clsTabFeatureBLEx.DelRecordEx(vsRegionId);
                BindTv_ViewRegion();
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在删除记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }


        protected string vsRegionId
        {
            get
            {
                string sRegionId;
                sRegionId = (string)ViewState["RegionId"];
                if (sRegionId == null)
                {
                    return "";
                }
                return sRegionId;
            }
            set
            {
                string sRegionId = value.ToString();
                ViewState.Add("RegionId", sRegionId);
            }
        }

        protected int vsApplicationTypeId
        {
            get
            {
                string sApplicationTypeId;
                sApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (sApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(sApplicationTypeId);
            }
            set
            {
                string sApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
        }
        /// <summary
        /// 

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId , int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {

            bool bolInUse = chkInUse.Checked;

            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, vsRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetInUse(bolInUse)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                if (objPrjTab != null)
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId, chkInUse.Checked);
                }
                else
                {
                    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "表名", clsPubVar.CurrSelPrjId, chkInUse.Checked);
                }
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
    }
}