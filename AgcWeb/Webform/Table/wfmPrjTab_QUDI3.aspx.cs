
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.web.treeview;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTab_QUDI3 : CommPageBase
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strLangType = Request.Form["hidLangType"] != null ? Request.Form["hidLangType"] : "";
            string strDataBaseType = Request.Form["hidDataBaseType"] != null ? Request.Form["hidDataBaseType"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "ChangeLangType":
                    ChangeLangType(strLangType); //调用该函数
                    //lblLangTypeName.Text = strLangType;
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                    //lblDataBaseType.Text = strDataBaseType;
                    break;

                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            clsPubVar.CheckUserSession();
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                InitParentPageInfo();
               
                //clsPubFun.ShowUserDefaLangType(rblNetOrJava);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        clsPubFun4Web.AccessError(this, conCurrPageName);

                        break;
                    case "1":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "2":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "3":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "4":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "9":
                        break;
                    default:
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                }
           
                vsViewName = "vPrjTab";
                wucSetFieldVisibilityB_QU1.SetDdl_UserId();


                wucSetFieldVisibilityB_QU1.UserId = clsCommonSession.UserId;
                wucSetFieldVisibilityB_QU1.ViewName = vsViewName;
                wucSetFieldVisibilityB_QU1.myClickGetFldLstFromGridView += wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView;
                //1、为下拉框设置数据源，绑定列表数据
                wucPrjTab1.SetDdl_SqlDsTypeIdCache();
                wucPrjTab1.SetDdl_TabStateIdCache();
                wucPrjTab1.SetDdl_TabTypeIdCache();
                wucPrjTab1.SetDdl_TabMainTypeIdCache();
                wucPrjTab1.SetDdl_CacheModeIdCache();
                wucPrjTab1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucPrjTab1.SetDdl_RelaTabId4View(clsPubVar.CurrSelPrjId);

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                //				clsDropDownList.BindDdl_ObjId(ddlObjIdq, PrjId);
                clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateIdq);
                clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
                clsAppPageTypeBL.BindDdl_AppPageTypeIdCache(ddlAppPageTypeId);
                clsDropDownList.BindDdl_TrueAndFalse(ddlIsUseCache);
                clsTabTypeBL.BindDdl_TabTypeIdCache(ddlTabTypeId);
                clsTabMainTypeBL.BindDdl_TabMainTypeIdCache(ddlTabMainTypeId);
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsCacheModeBL.BindDdl_CacheModeIdCache(ddlCacheModeId_SetFldValue);
                clsCacheModeBL.BindDdl_CacheModeIdCache(ddlCacheModeIdq);
                clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeIdq);

                ddlAppPageTypeId.SelectedIndex = 1;

                //恢复上一次在此界面的状态
                if (new clsCommonSession().FuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleId, new clsCommonSession().FuncModuleAgcId);
                }
                if (string.IsNullOrEmpty( clsCommonSession.CmPrjId)  == false)
                {
                    ddlCmPrjIdq.SelectedValue = clsCommonSession.CmPrjId;
                }

                //if (ObjId != "")
                //{
                //    clsDropDownList.SetDdlValue(ddlObjIdq, ObjId);
                //}
                if (string.IsNullOrEmpty(DispAllErrMsg) == false)
                {
                    chkDispAllErrMsg.Checked = bool.Parse(DispAllErrMsg);
                }
                txtTabNameq.Text = new clsCommonSession().TabName;
                txtTabCnNameq.Text = new clsCommonSession().TabCnName;
                txtIncludeFieldName.Text = new clsCommonSession().IncludeFieldName;
                chkDispProbableErrTab.Checked = new clsCommonSession().IsDispProbableErrTab;

                //=====================================================

                ddlTabStateIdq.SelectedValue = "01";
                if (new clsCommonSession().SqlDsTypeId == "")
                {
                    ddlSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlSqlDsTypeId.SelectedValue = new clsCommonSession().SqlDsTypeId;
                }

              
                if (new clsCommonSession().PrimaryTypeId == "")
                {
                    ddlPrimaryTypeIdq.SelectedValue = "0";
                }
                else
                {
                    ddlPrimaryTypeIdq.SelectedValue = new clsCommonSession().PrimaryTypeId;
                }

                //2、显示无条件的表内容在DATAGRID中
                if (string.IsNullOrEmpty(vsSortPrjTabBy) == true)
                {
                    vsSortPrjTabBy = "UpdDate Desc";
                    wucvPrjTab4Gv1.SetSortBy("UpdDate Desc");
                }
                else
                {
                    wucvPrjTab4Gv1.SetSortBy(vsSortPrjTabBy);
                }

                //2、显示无条件的表内容在DATAGRID中
                //是否显示详细列表;
                wucvPrjTab4Gv1.DispDetailListForPrjTab(lbIsDetailList);
                try
                {
                    BindGv_vPrjTab();
                }
                catch(Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucPrjTab1.SetKeyReadOnly(true);
                DispPrjTabListRegion();
                if (clsCommonSession.RoleId == "00050001" || clsCommonSession.RoleId == "00050006")
                {
                    lbDelPrjTabEx.Visible = true;
                }

                //显示不同操作显示区域
                DispDiv4Operate("DotNet", "Ms Sql");
                //divAdvanceOperate.Visible = false;
                // trAdvanceQuery.Visible = false;
                //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvPrjTab, vsViewName, clsCommonSession.UserId);
                clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 20);
                //ArrayList arrText = clsCommForWebForm.GetAllTextBoxInPage(this);
            }
            if (vsDivIsVisible == true)
            {
                //clsPubFun.js_Tz_ShowDiv("divSetFieldVisibilityB_QU", this, 10);
            }
            else
            {
                clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 10);
            }
            //wucSetFieldVisibilityB_QU1.myClickSubmitSet += wucSetFieldVisibilityB_QU1_myClickSubmitSet;
        }

        protected void wucSetFieldVisibilityB_QU1_myClickSubmitSet(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            vsDivIsVisible = false;
            //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvPrjTab, vsViewName, clsCommonSession.UserId);
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 0);
        }

        protected void wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                //clsSetFieldVisibilityBLEx.GetFldNameLstByGridView(gvPrjTab, vsViewName, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
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
            wucvPrjTab4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在DATAGRID中
            //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvPrjTab, vsViewName, clsCommonSession.UserId);
            new clsCommonSession().FuncModuleAgcId = ddlFuncModuleId.SelectedValue;
            DispAllErrMsg = chkDispAllErrMsg.Checked.ToString();
            //ObjId = ddlObjIdq.SelectedValue;
            new clsCommonSession().TabName = txtTabNameq.Text;
            new clsCommonSession().TabCnName = txtTabCnNameq.Text;
            new clsCommonSession().SqlDsTypeId = ddlSqlDsTypeId.SelectedValue;
            new clsCommonSession().IncludeFieldName = txtIncludeFieldName.Text;
            new clsCommonSession().IsDispProbableErrTab = chkDispProbableErrTab.Checked;
            new clsCommonSession().PrimaryTypeId = ddlPrimaryTypeIdq.SelectedValue;
             clsCommonSession.CmPrjId = ddlCmPrjIdq.SelectedValue;

            try
            {
                BindGv_vPrjTab();
            }
            catch(Exception objExcepiton)
            {
                clsCommonJsFunc.Alert(this, objExcepiton.Message);
                return;
            }
            //保存这次查询条件，为下一次再来该界面服务
         

        }
       
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strTabId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsPrjTabEN objPrjTabEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddPrjTabRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddPrjTabRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objPrjTabEN = (clsPrjTabEN)Session["objPrjTabEN"];
                    UpdatePrjTabRecordSave(objPrjTabEN);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddPrjTab();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrTabId = getAllCheckedTabIds();
            if (arrTabId == null) return;
            try
            {
                foreach (string strTabId in arrTabId)
                {
                    clsPrjTabBLEx.DelRecordEx(strTabId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }
        private List<string> getAllCheckedTabIds()
        {

            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return null;
            lblMsgList.Text = "";
            return lstTabId;
        }
        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strTabId = getFirstCheckedTabId();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdatePrjTabRecord(strTabId);
        }
        private string getFirstCheckedTabId()
        {
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return null;
            lblMsgList.Text = "";
            return strTabId;
        }
       
        protected string vsSortPrjTabBy
        {
            get
            {
                string sSortPrjTabBy;
                sSortPrjTabBy = (string)ViewState["SortPrjTabBy"];
                if (sSortPrjTabBy == null)
                {
                    sSortPrjTabBy = "";
                }
                return sSortPrjTabBy;
            }
            set
            {
                string sSortPrjTabBy = value;
                ViewState.Add("SortPrjTabBy", sSortPrjTabBy);
            }
        }

      
       
        protected void lbDispPrjTabList_Click(object sender, EventArgs e)
        {
            DispPrjTabListRegion();
        }

        //protected void ddlFuncModuleId_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    if (ddlFuncModuleId.SelectedIndex > 0)
        //    {
        //        string strFuncModuleId = ddlFuncModuleId.SelectedValue;
        //        clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
        //    }
        //}

        protected void lbAddField_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsgList.Text = "";
            Session.Add("TabId", strTabId);
            string strFileFolder = Server.MapPath("~");

            clsPrjTabFldBLEx.ReNumber(strTabId);
            new clsCommonSession().BackErrPageEditFldLinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("wfmPrjTabFld_QUDI.aspx");
        }
       
        protected void lbImportSQLTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportTabInfoFromSQL.aspx");
        }
        protected void lbImportSQLView_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportViewInfoFromSQL2.aspx");
        }
        protected void lbDelPrjTabEx_Click(object sender, EventArgs e)
        {
            DelMultiTabEx();
        }

        protected void btnGenTabRecNum_Click(object sender, EventArgs e)
        {
            GetTabRecNum();
        }

        protected void btnGenTabTestKeyValue_Click(object sender, EventArgs e)
        {
            GenTabTestKeyValue();
        }
        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            JumpOtherPages("CheckConsistency");
        }
        protected void lbCheckTabFld_Click1(object sender, EventArgs e)
        {
            CheckTabField1();
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }
        protected void lbImportOracleTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Oracle/wfmALL_ALL_TABLES_Q.aspx");
        }
        protected void lbImportOracleView_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Oracle/wfmUser_Views_Q.aspx");
        }
        protected void lbDispTabList_Click(object sender, EventArgs e)
        {
            DispPrjTabListRegion();
        }
        protected void lbSetModuleByObj_Click(object sender, EventArgs e)
        {

        }
        protected void lbSetSameModuleForViewRelaTab_Click(object sender, EventArgs e)
        {
            SetSameModuleNameForViewRelaTab();
        }
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize4PrjTab = intPageSize.ToString();
                    try
                    {
                        BindGv_vPrjTab();
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

                }
            }
        }


        protected void lbGeneLogicCode_j2ee_sql_Click(object sender, EventArgs e)
        {
            //
            lblMsgList.Text = "";
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            if (CheckTabFieldBySqlTab(strTabId) == false)
            {
                return;
            }
        }
        protected void lbGeneLogicEx_j2ee_sql_Click(object sender, EventArgs e)
        {
            //
            lblMsgList.Text = "";
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            if (CheckTabFieldBySqlTab(strTabId) == false)
            {
                return;
            }


            //显示生成代码区域
            DispGenCodeRegion();

        }

        protected void btnEditEx_Click(object sender, EventArgs e)
        {

            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsgList.Text = "";
            clsCommonSession.TabId = strTabId;
            //1、显示该关键字的数据让用户修改该关键字记录；
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../../FrameSetForTable.htm','EditTable'); </script>";
            Response.Write(c1);
        }
        protected void btnCloneTab_Click(object sender, EventArgs e)
        {
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsgList.Text = "";
            string strNewTabId = "";
            try
            {
                strNewTabId = clsPrjTabBLEx.CopyPrjTabInSameProject(clsPubVar.CurrSelPrjId, clsPubVar.CurrCmPrjId, strTabId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "克隆表不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdatePrjTabRecord(strNewTabId);
        }
        protected void lbGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsgList.Text = "";
            clsCommonSession.TabId = strTabId;
            string c1 = @"<script language='javascript'>window.open('../Table/wfmGeneStoreProcedure.aspx','生成存储过程'); </script>";
            Response.Write(c1);
        }
        //protected void lbGeneWebServiceCode_Click(object sender, EventArgs e)
        //{
        //    GeneWebServiceCode();
        //}
        //protected void GeneWebServiceCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    //
        //    lblMsgList.Text = "";

        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}
        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Srv;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType, vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GenWebServiceCode(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //    strCharEncodingId, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);

        //    }

        //    //Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    //lblMsgList.Text = "";
        //    //string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTab);

        //    //if (strTabId == null || strTabId.Trim().Length == 0)
        //    //{
        //    //    lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
        //    //    return;
        //    //}
        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}

        //    //string strSqlDsTypeId = clsPrjTabBL.GetObjByTabId(strTabId).SQLDSType1Id;
        //    //AutoGC6Cs_WS autoGC5Cs_M = new AutoGC6Cs_WS(strTabId, clsPubVar.CurrPrjDataBaseId);
        //    //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\";

        //    //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //    //try
        //    //{
        //    //    if (strSqlDsTypeId == "01")
        //    //    {
        //    //        ShowCode(autoGC5Cs_M.A_GenWebServiceCode(myEncoding);	//已完成
        //    //    }
        //    //    else if (strSqlDsTypeId == "02")
        //    //    {
        //    //        ShowCode(autoGC5Cs_M.A_GenWebServiceCode4View(myEncoding);	//已完成
        //    //    }
        //    //}
        //    //catch (Exception objException)
        //    //{
        //    //    clsCommonSession.seErrMessage = objException.Message;
        //    //    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //    //    clsPubFun4Web.AccessError(this, conCurrPageName);
        //    //}


        //}
        //protected void lbGeneWebServiceTransCode_Click(object sender, EventArgs e)
        //{
        //    GenWebServiceTransCode();
        //}
        //protected void GenWebServiceTransCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    //
        //    lblMsgList.Text = "";

        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}
        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Access;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);

        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GenWebServiceTransCode(strTabId,
        //        //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //    strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }

        //    //Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    //lblMsgList.Text = "";
        //    //string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTab);

        //    //if (strTabId == null || strTabId.Trim().Length == 0)
        //    //{
        //    //    lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
        //    //    return;
        //    //}
        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}
        //    //string strSqlDsTypeId = clsPrjTabBL.GetObjByTabId(strTabId).SQLDSType1Id;
        //    //AutoGC6Cs_WS autoGC5Cs_M = new AutoGC6Cs_WS(strTabId, clsPubVar.CurrPrjDataBaseId);
        //    //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\";
        //    //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //    //try
        //    //{
        //    //    if (strSqlDsTypeId == "01")
        //    //    {
        //    //        ShowCode(autoGC5Cs_M.A_GenWebServiceTransCode(myEncoding);	//已完成
        //    //    }
        //    //    else if (strSqlDsTypeId == "02")
        //    //    {
        //    //        ShowCode(autoGC5Cs_M.A_GenWebServiceTransCode4View(myEncoding);	//已完成
        //    //    }
        //    //}
        //    //catch (Exception objException)
        //    //{
        //    //    clsCommonSession.seErrMessage = objException.Message;
        //    //    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //    //    clsPubFun4Web.AccessError(this, conCurrPageName);
        //    //}


        //}
        protected void lbIsDetailList_Click(object sender, EventArgs e)
        {
            
         wucvPrjTab4Gv1.DispDetailListForPrjTab(lbIsDetailList);
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }
      
        private void DispAdvanceOperate()
        {
            //if (lbDispAdvanceDiv.Text == "高级操作")
            //{
            //    divAdvanceOperate.Visible = true;
            //    lbDispAdvanceDiv.Text = "隐藏高级操作";
            //}
            //else
            //{
            //    divAdvanceOperate.Visible = false;
            //    lbDispAdvanceDiv.Text = "高级操作";

            //}
        }
        //private void Hide_txtCode_Sim()
        //{
        //    txtCode_Sim.Visible = false;
        //    //txtCode.Height = 600;

        //}
        //private void Show_txtCode_Sim()
        //{
        //    txtCode_Sim.Visible = true;
        //    //txtCode.Height = 338;
        //}
        private void ChangeLangType(string strLangType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = strLangType;
            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = clsPubConst.GetDataBaseTypeStrByDataBaseType(vsDataBaseType);
            //vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType(vsLangType);
            //            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = strDataBaseType;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }
        private void DispDiv4Operate(string strNetOrJava, string strSqlOrOracle)
        {
            //string strNetOrJava, strSqlOrOracle;
            //strNetOrJava = rblNetOrJava.SelectedValue;
            //strSqlOrOracle = rblSqlOrOracle.SelectedValue;
            List<Control> arrControls = clsPubFun.GetControl4Type(this, "ImageMap");
            foreach (Control ctrl in arrControls)
            {
                ctrl.Visible = false;
            }
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            //lbGeneDALCode.Visible = true;
            //lbGeneDALExCode.Visible = false;
            //lbGeneBusinessLogicExCode.Visible = false;
            //lbGeneCommFun4BL.Visible = false;

            //lbGeneWebServiceCode.Visible = true;
            //lbGeneController.Visible = true;
            //lbGeneControllerInvokeWS.Visible = true;
            //lbGeneController4UnitTest.Visible = true;
            //lbGeneDict_PageName_Dir.Visible = false;

            if (strNetOrJava == "DotNet")
            {
                //imGeneCode_CSharp.Visible = true;
                vsLangType = clsPubConst.LangType.CSharp;
                //lbGeneController.Visible = false;
                //lbGeneController4UnitTest.Visible = false;
                //lbGeneControllerInvokeWS.Visible = false;
                //lbGeneDict_PageName_Dir.Visible = true;
                //lbGeneDALExCode.Visible = true;
                //lbGeneBusinessLogicExCode.Visible = true;
                //lbGeneCommFun4BL.Visible = true;

            }
            else if (strNetOrJava == "Java")
            {
                //imGeneCode_Java.Visible = true;
                vsLangType = clsPubConst.LangType.JAVA;
                //lbGeneWebServiceCode.Visible = false;

            }
            else if (strNetOrJava == "Swift" || strNetOrJava == "Swift3" || strNetOrJava == "Swift4")
            {
                //imGeneCode_Swift.Visible = true;
                //vsLangType = clsPubConst.LangType.Swift;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "JavaScript")
            {
                //imGeneCode_JavaScript.Visible = true;
                vsLangType = clsPubConst.LangType.JavaScript;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "SilverLight")
            {
                vsLangType = clsPubConst.LangType.SilverLight;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            try
            {
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言", vsLangType.ToString());
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        //private void DispDiv4Operate()
        //{
        //    string strNetOrJava, strSqlOrOracle;
        //    strNetOrJava = rblNetOrJava.SelectedValue;
        //    strSqlOrOracle = rblSqlOrOracle.SelectedValue;
        //    vsDataBaseType = clsPubConst.GetDataBaseTypeByString( strSqlOrOracle);
        //    lbGeneDALCode.Visible = true;
        //    lbGeneWebServiceCode.Visible = true;
        //    lbGeneController.Visible = true;
        //    lbGeneControllerInvokeWS.Visible = true;
        //    if (strNetOrJava == "DotNet")
        //    {
        //        vsLangType = clsPubConst.LangType.CSharp;
        //        lbGeneController.Visible = false;
        //        lbGeneControllerInvokeWS.Visible = false;
        //    }
        //    else if (strNetOrJava == "Java")
        //    {
        //        vsLangType = clsPubConst.LangType.JAVA;
        //        lbGeneWebServiceCode.Visible = false;

        //    }
        //    else if (strNetOrJava == "Swift")
        //    {
        //        vsLangType = clsPubConst.LangType.Swift;
        //        lbGeneDALCode.Visible = false;
        //        lbGeneWebServiceCode.Visible = false;
        //    }
        //    else if (strNetOrJava == "JavaScript")
        //    {
        //        vsLangType = clsPubConst.LangType.JavaScript;
        //        lbGeneDALCode.Visible = false;
        //        lbGeneWebServiceCode.Visible = false;
        //    }
        //    else if (strNetOrJava == "SilverLight")
        //    {
        //        vsLangType = clsPubConst.LangType.SilverLight;
        //        lbGeneDALCode.Visible = false;
        //        lbGeneWebServiceCode.Visible = false;
        //    }
        //    try
        //    {
        //        clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言", vsLangType.ToString());
        //    }
        //    catch(Exception objException)
        //    {
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}
        //protected void rblNetOrJava_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DispDiv4Operate();
        //}
        //protected void rblSqlOrOracle_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DispDiv4Operate();
        //}
        protected void lbDispAdvanceDiv_Click(object sender, EventArgs e)
        {
            DispAdvanceOperate();
        }
        //protected void lbAdvanceQuery_Click(object sender, EventArgs e)
        //{
        //    if (lbAdvanceQuery.Text == "高级查询")
        //    {
        //        lbAdvanceQuery.Text = "简单查询";
        //        trAdvanceQuery.Visible = true;
        //    }
        //    else
        //    {
        //        lbAdvanceQuery.Text = "高级查询";
        //        trAdvanceQuery.Visible = false;
        //    }
        //}
        //protected void lbGeneEntityLayer_Click(object sender, EventArgs e)
        //{
        //    GeneEntityLayer();
        //}
        //protected void GeneEntityLayer()
        //{
        //    Show_txtCode_Sim();//显示简化实体层代码文本框
        //                       //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {
        //        //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_ClsNameSim = "";

        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
        //        clsPubConst.ClassName cnClassNameSim = clsPubConst.ClassName.EntityLayer_Sim;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        string strCodeText_Sim = AutoGC.GeneCode(cnClassNameSim, "", vsLangType, vsDataBaseType, strTabId,
        //                            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsNameSim,
        //                            ref strRe_FileNameWithModuleName);

        //        txtCode_Sim.Text = strCodeText_Sim;
        //        txtFileName4GC.Text = strRe_ClsName;
        //        ShowCode(strCodeText);

        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //    //显示生成代码区域
        //    DispGenCodeRegion();


        //}

        //protected void lbGeneCondEntityLayer_Click(object sender, EventArgs e)
        //{
        //    GeneCondEntityLayer();
        //}
        //protected void GeneCondEntityLayer()
        //{
        //    Hide_txtCode_Sim();//显示简化实体层代码文本框
        //                       //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {
        //        //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //        string strViewId = "";
        //        string strRe_ClsName = "";

        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.CondEntityLayer;
              
        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
            
        //        txtFileName4GC.Text = strRe_ClsName;
        //        ShowCode(strCodeText);

        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //    //显示生成代码区域
        //    DispGenCodeRegion();


        //}


        //protected void lbGeneDALCode_Click(object sender, EventArgs e)
        //{
        //    GenDALCode();
        //}
        //protected void GenDALCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //                       //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}

        //    try
        //    {
        //        //            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DALCode;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);


        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GeneDataLayer(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        // clsCommonSession.UserId,
        //        //  clsCommonSession.UserName, "", "",
        //        //strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);


        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;

        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);


        //    }
        //    //显示生成代码区域
        //    DispGenCodeRegion();


        //}
        //protected void lbGeneBusinessLogicCode_Click(object sender, EventArgs e)
        //{
        //    BindTv_FuncModule_Agc_PrjTab();
        //    BusinessLogicCode();
        //}
        //protected void BusinessLogicCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.BusinessLogic;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);

        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //     strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);

        //        lblMsgList.Text = objException.Message;

        //    } //显示生成代码区域
        //    DispGenCodeRegion();

        //}


        protected void btnEditObjectAndTabFields_Click(object sender, EventArgs e)
        {
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            vsTabId_T = strTabId;
            JumpOtherPages("EditTabAndObjectFields");
        }
        //protected void lbGeneEntityLayer4MySql_Click(object sender, EventArgs e)
        //{
        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    lblMsgList.Text = "";
        //    string strTabId = clsCommonSession.TabId;
        //    if (strTabId == null || strTabId.Trim().Length == 0)
        //    {
        //        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
        //        return;
        //    }
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.BusinessLogic;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GeneEntityLayer_MySql(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //    strCharEncodingId, ref strClsName, ref strCodePath, ref strFileName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }

        //}


        protected void lbCheckAllTabField_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";



            int intCount = 0;

            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

                intCount = clsTabCheckStatusBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);

                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");

            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //显示生成代码区域



        }

        protected void lbCheckCheckedTabField_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";

            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;

            int intCount = 0;

            try
            {

                intCount = clsTabCheckStatusBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, lstTabId);
                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //显示生成代码区域



        }

        protected void chkDispAllErrMsg_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }

        protected void btnSetFieldLst4Show_Click(object sender, EventArgs e)
        {
            //vsDivIsVisible = true;
            wucSetFieldVisibilityB_QU1.BindGv();
            clsPubFun.js_Tz_ShowDiv("divSetFieldVisibilityB_QU", this, 150);
        }

        protected void btnSetDefaMainTab4View_Click(object sender, EventArgs e)
        {
            try
            {
                clsPrjTabBLEx.SetRelaDefaMainTabId4View(clsPubVar.CurrSelPrjId);
                try
                {
                    BindGv_vPrjTab();
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }

                clsCommonJsFunc.Alert(this, "设置默认相关主表完成！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }

        protected void btnSetDefaKeyFld_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.SetKeyFld4ViewByRelaTabId(strTabId);
                }
                clsCommonJsFunc.Alert(this, "为视图设置默认关键字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }

        protected void btnSetFldOrderNum4View_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.SetFldOrderNum4ViewByRelaTabId(strTabId);
                }
                clsCommonJsFunc.Alert(this, "为视图设置字段序号成功！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }

        //protected void lbGeneController_Click(object sender, EventArgs e)
        //{
        //    GenController();
        //}
        //protected void GenController()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    //
        //    lblMsgList.Text = "";

        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppController;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);

        //    }
        //}

        //protected void GenDesktopController()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    //
        //    lblMsgList.Text = "";

        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DesktopController;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);

        //    }
        //}
        //protected void lbGeneController4UnitTest_Click(object sender, EventArgs e)
        //{
        //    GenController4UnitTest();
        //}
        //protected void GenController4UnitTest()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUnitTest;
        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}

        //protected void GenDesktopController4UnitTest()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DesktopViewUnitTest;
        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}
        //protected void GenController4UTScript()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScript;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}
        //protected void GenDesktopController4UTScript()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DesktopViewUTScript;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}


        //protected void GenController4UTScriptCS()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScriptCS;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}

        //protected void GenDesktopController4UTScriptCS()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;
        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DesktopViewUTScriptCS;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }
        //}

        //protected void lbGeneControllerInvokeWS_Click(object sender, EventArgs e)
        //{
        //    GenControllerInvokeWS();
        //}
        //protected void GenControllerInvokeWS()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    //
        //    lblMsgList.Text = "";

        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}
        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_AccessHigh;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);

        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        //显示生成代码区域
        //        DispGenCodeRegion();
        //    }
        //    catch (Exception objException)
        //    {
        //        //lblErrMsg4AGC.Text = objException.Message;
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //    }

        //}

        //protected void lbGeneDict_PageName_Dir_Click(object sender, EventArgs e)
        //{
        //    GeneDict_PageName_Dir();
        //}
        //protected void GeneDict_PageName_Dir()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.Dict_PageName_Dic;

        //    //          clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WinCtlControlCode;
        //    clsPubConst.LangType ltLangType = clsPubConst.LangType.CSharp;
        //    clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.DataBaseType.MsSql;
        //    string strTabId = "";
        //    //string strViewId = "01690058";//4Web
        //    string strViewId = "";//4Win

        //    string strPrjId = clsPubVar.CurrSelPrjId;
        //    string strPrjDataBaseId = "0199";
        //    string strUserId = "pyf";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";

        //    try
        //    {
        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, ltLangType, dbtDataBaseType, strTabId,
        //            strViewId, strPrjId, strPrjDataBaseId, strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        //string strCodeText = clsAutoGeneCodeWS.GeneCode(cnClassName, ltLangType, dbtDataBaseType, strTabId, strViewId, strPrjId, strPrjDataBaseId, strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        txtFileName4GC.Text = strRe_ClsName;
        //        ShowCode(strCodeText);
        //        //显示生成代码区域
        //        DispGenCodeRegion();

        //        //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(strPrjId, strUserId);

        //        //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

        //        //string strClassFName = objAutoGC6Cs_WS.objPrjTabENEx.FolderName + strRe_FileNameWithModuleName;
        //        //clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeText, objAutoGC6Cs_WS.objPrjTabENEx.FolderName_Root,
        //        //    objAutoGC6Cs_WS.objPrjTabENEx.BackupFolderName, myEncoding);


        //        //MessageBox.Show(strRe_ClsName + " : " + strRe_FileNameWithModuleName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //        //MessageBox.Show(objException.Message);
        //    }
        //}

        //protected void lbGeneCommFun4BL_Click(object sender, EventArgs e)
        //{
        //    GeneCommFun4BL();
        //}
        //protected void GeneCommFun4BL()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //                       //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    //if (CheckTabFieldBySqlTab(strTabId) == false)
        //    //{
        //    //    return;
        //    //}

        //    try
        //    {
        //        //            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.CommFun4BL;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);


        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GeneDataLayer(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        // clsCommonSession.UserId,
        //        //  clsCommonSession.UserName, "", "",
        //        //strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);

        //        if (string.IsNullOrEmpty(strCodeText) == true)
        //        {
        //            ShowCode("该表可能是表视图，不需要生成缓存刷新函数。");
        //        }
        //        else
        //        {
        //            ShowCode(strCodeText);
        //        }
        //        txtFileName4GC.Text = strRe_ClsName;

        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);


        //    }
        //    //显示生成代码区域
        //    DispGenCodeRegion();


        //}

        protected void lbSetKeyFldId_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.SetKeyFld4PrjTabByTabId(strTabId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }


        }


        protected void lbSetIsUseCache_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.SetIsUseCache(strTabId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }


        }

        protected void lbSetIsNotUseCache_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.SetIsNotUseCache(strTabId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }


        }
        //protected void lbGeneBusinessLogicExCode_Click(object sender, EventArgs e)
        //{
        //    GeneBusinessLogicExCode();
        //}
        //protected void GeneBusinessLogicExCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框

        //    //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {

        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.BusinessLogicEx;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);

        //        //string strCodeText = clsPrjTabBLEx_GeneCode.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //     strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);

        //        lblMsgList.Text = objException.Message;

        //    } //显示生成代码区域
        //    DispGenCodeRegion();

        //}

        //protected void lbGeneDALExCode_Click(object sender, EventArgs e)
        //{
        //    GenDALExCode();
        //}
        //protected void GenDALExCode()
        //{
        //    Hide_txtCode_Sim();//隐藏简化实体层代码文本框
        //                       //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        //    lblMsgList.Text = "";
        //    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strTabId) == true) return;

        //    try
        //    {
        //        string strViewId = "";
        //        string strRe_ClsName = "";
        //        string strRe_FileNameWithModuleName = "";
        //        clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DALExCode;

        //        string strCodeText = AutoGC.GeneCode(cnClassName, vsTypeParas, vsLangType,vsDataBaseType, strTabId,
        //            strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
        //            ref strRe_FileNameWithModuleName);

        //        ShowCode(strCodeText);
        //        txtFileName4GC.Text = strRe_ClsName;

        //    }
        //    catch (Exception objException)
        //    {
        //        ShowCode( objException.Message);
        //        clsCommonJsFunc.Alert(this, objException.Message);


        //    }
        //    //显示生成代码区域
        //    DispGenCodeRegion();

        //}

        protected void btnSetFuncModule_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;

            if (ddlFuncModuleId.SelectedIndex <= 0)
            {
                lblMsgList.Text = "没有选择模块名称，请选择一个有效的模块名称!";

                ddlFuncModuleId.Focus();
                return;
            }
            string strFuncModuleId = ddlFuncModuleId.SelectedValue;
            lblMsgList.Text = "";
            foreach (string strTabId in lstTabId)
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                objPrjTabEN.FuncModuleAgcId = strFuncModuleId;
                if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);

            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }

        protected void btnCopyPrjTab_Click(object sender, EventArgs e)
        {
            string strTarPrjId = clsPubVar.CurrSelPrjId;
            string strSouTabId = hidTabId.Value;
            if (string.IsNullOrEmpty(strSouTabId) == true)
            {
                string strMsg = string.Format("需要复制的源表Id为空，无法复制！");
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            strSouTabId = strSouTabId.Substring(3, 8);
            List<string> arrSouTabId = new List<string>();
            arrSouTabId.Add(strSouTabId);
            if (clsPrjTabBLEx.CopyPrjTab(strTarPrjId, arrSouTabId, UserId) == true)
            {
                lblMsgEdit.Text = "复制源工程表对象列表成功!";
                lblMsgEdit.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblMsgEdit.Text = "复制源工程表对象列表不成功!";
            }
            clsCommonJsFunc.Alert(this, lblMsgEdit.Text);
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

            DispPrjTabListRegion();
            hidTabId.Value = "";
        }

        protected void ddlAppPageTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            DispGenCodeRegion();
            BindTv_FuncModule_Agc_PrjTab();
            return;
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            //BindTv_ApplicationType_CodeType_Function4GeneCode(strTabId);
            
        }
        protected void btnSetTabState_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;

            if (ddlTabStateIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "没有选择表状态，请选择一个有效的表状态!";

                ddlTabStateIdq.Focus();
                return;
            }
            string strTabStateId = ddlTabStateIdq.SelectedValue;
            lblMsgList.Text = "";
            foreach (string strTabId in lstTabId)
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                objPrjTabEN.TabStateId = strTabStateId;
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabEN.UpdUserId = clsCommonSession.UserId;
                if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnAddTabFeature_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("TabId not in (Select {0} From {1} Where {2}='{3}') and {4}='{5}'", 
                conTabFeature.TabId, clsTabFeatureEN._CurrTabName,
                conTabFeature.FeatureId, enumPrjFeature.Tab_BindDdl_0173,
                conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            List<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach(clsPrjTabEN objInFor in  arrObjLst)
            {
                try
                {
                    clsTabFeatureFldsBLEx.AddBindDdl(objInFor.TabId, objInFor.PrjId, clsCommonSession.UserId);
                    clsPrjTabBLEx.SetUpdDate(objInFor.TabId, clsCommonSession.UserId);
                    intCount++;
                }
                catch(Exception objException)
                {

                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }

            }
            strCondition = string.Format("TabId not in (Select {0} From {1} Where {2}='{3}') and {4}='{5}'",
               conTabFeature.TabId, clsTabFeatureEN._CurrTabName,
               conTabFeature.FeatureId, enumPrjFeature.Tab_AdjustOrderNum_0167,
               conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            arrObjLst = clsPrjTabBL.GetObjLst(strCondition);
            int intCount2 = 0;
            foreach (clsPrjTabEN objInFor in arrObjLst)
            {
                try
                {
                    clsTabFeatureFldsBLEx.AddAdjustOrderNum(objInFor.TabId, enumPrjFeature.Tab_AdjustOrderNum_0167, objInFor.PrjId, clsCommonSession.UserId);
                    clsPrjTabBLEx.SetUpdDate(objInFor.TabId, clsCommonSession.UserId);
                    intCount2++;
                }
                catch (Exception objException)
                {

                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }

            }
            string strMsg = string.Format("共添加了:{0}个绑定下拉框功能，{1}个调整记录次序功能！", intCount, intCount2);
            clsCommonJsFunc.Alert(this, strMsg);
        }

        protected void btnSetTabTypeId_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;

            if (ddlTabTypeId.SelectedIndex <= 0)
            {
                lblMsgList.Text = "没有选择模块名称，请选择一个有效的模块名称!";

                ddlTabTypeId.Focus();
                return;
            }
            string strTabTypeId = ddlTabTypeId.SelectedValue;
            lblMsgList.Text = "";
            foreach (string strTabId in lstTabId)
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                objPrjTabEN.TabTypeId = strTabTypeId;
                if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);

            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

        }

        protected void btnSetViewTabCnName_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4}={5}",
                conPrjTab.PrjId, clsPubVar.CurrSelPrjId,
                conPrjTab.SqlDsTypeId, enumSQLDSType.SqlView_02,
                conPrjTab.TabCnName, conPrjTab.TabName);
            List<clsPrjTabEN> arrPrjTab = clsPrjTabBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach (clsPrjTabEN objPrjView in arrPrjTab)
            {
                if (objPrjView.TabName.Substring(0, 1) != "v") continue;
                clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabNameExCache(clsPubVar.CurrSelPrjId, objPrjView.TabName.Substring(1));
                if (objPrjTab == null) continue;
                objPrjView.TabCnName = string.Format("v{0}", objPrjTab.TabCnName);
                objPrjView.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUserId(clsCommonSession.UserId);
                objPrjView.Update();
                intCount++;
            }
            string strMsg = string.Format("共修改:{0}个视图的中文名！", intCount);
            clsCommonJsFunc.Alert(this, strMsg);

        }

        protected void chkDispProbableErrTab_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                new clsCommonSession().IsDispProbableErrTab = chkDispProbableErrTab.Checked;

                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void chkDispTabCnName_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vPrjTab();
        }

        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsCommonSession.CmPrjId = strCmPrjId;
            clsCMProjectFuncModuleBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strCmPrjId);
        }

        protected void btnSetIsFresh4RelaView_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            foreach(var strTabId in lstTabId)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabId(strTabId);
                if (objPrjTab.IsRefresh4RelaView == true)
                {
                    objPrjTab.IsRefresh4RelaView = false;
                }
                else
                {
                    objPrjTab.IsRefresh4RelaView = true;
                }
                objPrjTab.Update();
            }
            BindGv_vPrjTab();
        }
    }
    public partial class wfmPrjTab_QUDI3 : CommPageBase
    {
        protected void ShowData(string strTabId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strTabId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsPrjTabBL.IsExist(strTabId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strTabId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            //4、获取类对象的所有属性；
            try
            {
                clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objPrjTabEN", objPrjTabEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromPrjTabClass(objPrjTabEN);
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


        ///生成专门用于BINDgv中的跳页相关代码
        protected string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                Session.Add("ObjId", strObjId);
            }
        }
        ///生成专门用于记录GridView中的每页记录数
        protected string PageSize4PrjTab
        {
            get
            {
                string strPageSize4PrjTab;
                strPageSize4PrjTab = (string)Session["PageSize4PrjTab"];
                if (strPageSize4PrjTab == null)
                {
                    strPageSize4PrjTab = "";
                }
                return strPageSize4PrjTab;
            }
            set
            {
                string strPageSize4PrjTab = value;
                Session.Add("PageSize4PrjTab", strPageSize4PrjTab);
            }
        }


        ///生成专门用于记录GridView中的每页记录数
        protected string DispAllErrMsg
        {
            get
            {
                string strPageSize4PrjTab;
                strPageSize4PrjTab = (string)Session["DispAllErrMsg"];
                if (strPageSize4PrjTab == null)
                {
                    strPageSize4PrjTab = "";
                }
                return strPageSize4PrjTab;
            }
            set
            {
                string strPageSize4PrjTab = value;
                Session.Add("DispAllErrMsg", strPageSize4PrjTab);
            }
        }



        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevPrjTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";

            if (this.ddlIsUseCache.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" and {0}='1'", convPrjTab.IsUseCache);
            }
            else if (this.ddlIsUseCache.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" and {0}='0'", convPrjTab.IsUseCache);
            }
            if (chkShowPureClass.Checked == false)
            {
                strWhereCond += string.Format(" And {0} <> '{1}'", convPrjTab_Sim.TabTypeId, enumTabType.PureClass_0008);
            }
            if (chkOnlyShowNotIsReleToSqlTab.Checked == true)
            {
                strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsReleToSqlTab);
            }
            
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.txtIncludeFieldName.Text.Trim() != "")
            {
                string strIncludeFieldName = this.txtIncludeFieldName.Text.Trim();
                if (strIncludeFieldName.EndsWith("%") == true)
                {
                    string strCondition = string.Format("{0} Like '{1}' And {2}='{3}'",
                        convPrjTabFld.FldName, strIncludeFieldName,
                        convPrjTabFld.PrjId, clsPubVar.CurrSelPrjId);
                    if (clsvPrjTabFldBL.IsExistRecord(strCondition) == false)
                    {
                        string strMsg = string.Format("所输入字段名:[{0}]在当前工程表不存在！", strIncludeFieldName);
                        throw new Exception(strMsg);
                    }

                    strWhereCond += string.Format(" and {0} In (Select {0} From {1} Where {2}='{3}' And {4} Like '{5}')",
                        convPrjTabFld.TabId, clsvPrjTabFldEN._CurrTabName,
                        convPrjTabFld.PrjId, clsPubVar.CurrSelPrjId,
                        convPrjTabFld.FldName, strIncludeFieldName);
                }
                else
                {
                    string strCondition = string.Format("{0} = '{1}' And {2}='{3}'",
                       convPrjTabFld.FldName, strIncludeFieldName,
                       convPrjTabFld.PrjId, clsPubVar.CurrSelPrjId);
                    if (clsvPrjTabFldBL.IsExistRecord(strCondition) == false)
                    {
                        string strMsg = string.Format("所输入字段名:[{0}]在当前工程表不存在！", strIncludeFieldName);
                        throw new Exception(strMsg);
                    }

                    strWhereCond += string.Format(" and {0} In (Select {0} From {1} Where {2}='{3}' And {4} = '{5}')",
                        convPrjTabFld.TabId, clsvPrjTabFldEN._CurrTabName,
                        convPrjTabFld.PrjId, clsPubVar.CurrSelPrjId,
                        convPrjTabFld.FldName, strIncludeFieldName);
                }                  
            }
            if (this.ddlPrimaryTypeIdq.SelectedValue != "" && this.ddlPrimaryTypeIdq.SelectedValue != "0")
            {
                strWhereCond += string.Format(" and {0}='{1}'", conPrjTabFld.PrimaryTypeId, this.ddlPrimaryTypeIdq.SelectedValue);
            }

            if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
            {

                strWhereCond += string.Format(" And {0} in (Select {0} From {1} Where {2}='{3}')",
              conPrjTab.TabId, conCMProjectPrjTab._CurrTabName, conCMProjectPrjTab.CmPrjId, 
                        this.ddlCmPrjIdq.SelectedValue);
                
            }
            if (chkDispProbableErrTab.Checked)
            {
               
               strWhereCond += string.Format(" and {0} in ('{1}','{2}') and {3} not in (Select {3} From {4} where {5}='{6}') and {7}='{8}'", 
                   
                   convPrjTabFld.PrimaryTypeId, enumPrimaryType.Identity_02, enumPrimaryType.StringAutoAddPrimaryKey_03,
                   conPrjConstraint.TabId, clsPrjConstraintEN._CurrTabName, 
                   conPrjConstraint.ConstraintTypeId, enumConstraintType.Uniqueness_01,
                   conPrjTab.SqlDsTypeId, enumSQLDSType.SqlTab_01);
               
            }
            if (this.ddlCacheModeIdq.SelectedValue != "" && this.ddlCacheModeIdq.SelectedValue != "0")
            {
                strWhereCond += " and CacheModeId='" + this.ddlCacheModeIdq.SelectedValue + "'";
            }
            if (chkFuncModuleIdq.Checked)
            {
                if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
                {
                    strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
                }
            }
            if (chkTabTypeIdq.Checked)
            {
                if (this.ddlTabTypeId.SelectedValue != "" && this.ddlTabTypeId.SelectedValue != "0")
                {
                    strWhereCond += " and TabTypeId='" + this.ddlTabTypeId.SelectedValue + "'";
                }
            }
            if (chkTabMainTypeIdq.Checked)
            {
                if (this.ddlTabMainTypeId.SelectedValue != "" && this.ddlTabMainTypeId.SelectedValue != "0")
                {
                    strWhereCond += " and TabMainTypeId='" + this.ddlTabMainTypeId.SelectedValue + "'";
                }
            }
            if (chkTabStateIdq.Checked)
            {
                if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
                {
                    strWhereCond += " And TabStateId='" + this.ddlTabStateIdq.SelectedValue + "'";
                }
            }
            if (this.ddlSqlDsTypeId.SelectedValue != "" && this.ddlSqlDsTypeId.SelectedValue != "0")
            {
                strWhereCond += " And SqlDsTypeId='" + this.ddlSqlDsTypeId.SelectedValue + "'";
            }

            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vPrjTab(string strCondition = "")
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.SqlDsTypeName, true);
                wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.FuncModuleName, true);
                wucvPrjTab4Gv1.SetGvVisibility(convTabFeatureFlds.TabFeatureName, true);
                wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.RelaTabName4View, false);
                wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.TabTypeName, true);
                if (chkDispTabCnName.Checked == true)
                {
                    wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.TabCnName, true);
                }
                else
                {
                    wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.TabCnName, false);
                }
                if (ddlTabStateIdq.SelectedValue != enumTabState.Normal_01)
                {
                    wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.TabStateName, true);
                }
                else
                {
                    wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.TabStateName, false);
                }
                if (chkDispAllErrMsg.Checked)
                {
                    wucvPrjTab4Gv1.vsDispErrorMsg = "true";
                    wucvPrjTab4Gv1.SetGvVisibility("ErrMsg", true);
                }
                else
                {
                    wucvPrjTab4Gv1.SetGvVisibility("ErrMsg", false);
                }
                //	1、组合界面条件串；
                string strWhereCond = "";
                if (string.IsNullOrEmpty(strCondition) == true)
                {
                    strWhereCond = CombinevPrjTabCondition();
                }
                else
                {
                    strWhereCond = string.Format("{0} And {1}='01'", strCondition, convPrjTab.TabStateId);
                    wucvPrjTab4Gv1.SetSortBy(convPrjTab.OrderNum4Refer);
                }
                //	2、调用控件中的绑定GridView函数；
                wucvPrjTab4Gv1.BindGv_vPrjTab(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
  
                //wucvPrjTab4Gv1.SetGvVisibility(convPrjTab.UpdUser, false);
                //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvPrjTab, vsViewName, clsCommonSession.UserId);

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
        protected void BindGv_PrjTabBak(params string[] args)
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = "";
            if (args.Length == 0)
            {
                try
                {
                    strWhereCond = CombinevPrjTabCondition();
                }
                catch(Exception objException)
                {
                    throw objException;
                }
            }
            else if (args.Length == 1)
            {
                strWhereCond = string.Format("{0} And {1}='01' order by {2}",
                    args[0], convPrjTab.TabStateId, convPrjTab.OrderNum4Refer);
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                if (chkDispAllErrMsg.Checked == true)
                {
                    objDT = clsvPrjTab4ErrMsgBL.GetDataTable_vPrjTab4ErrMsg(strWhereCond);
                }
                else
                {
                    objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortPrjTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                             ///设置GridView中每页的记录数
            //if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            //{
            //    int intPageSize = int.Parse(PageSize4PrjTab);
            //    gvPrjTab.PageSize = intPageSize;
            //}
            //else
            //{
            //    PageSize4PrjTab = "10";
            //    gvPrjTab.PageSize = 10;
            //}

            //this.gvPrjTab.DataSource = objDV;
            ////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //this.gvPrjTab.DataBind();

            /////生成专门用于BindGv中的跳页相关代码
            //GridViewRow pagerRow = gvPrjTab.BottomPagerRow;
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
            //    lblAllPages.Text = this.gvPrjTab.PageCount.ToString();
            //    //当前页序数
            //    lblCurrentPage.Text = (this.gvPrjTab.PageIndex + 1).ToString();
            //    //当前即将跳到的页序数
            //    txtJump2Page.Text = (this.gvPrjTab.PageIndex + 1).ToString();
            //    //如果当前页序数为0，则<前一页>按钮无效
            //    if (this.gvPrjTab.PageIndex == 0)
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, true);
            //    }
            //    //如果当前页序数已为最后一页，则<前一页>按钮无效
            //    if (this.gvPrjTab.PageIndex == this.gvPrjTab.PageCount - 1)
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, true);
            //    }
            //    //设置分页器中每页记录数的下拉框的值
            //    if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            //    {
            //        ddlPagerRecCount.Text = PageSize4PrjTab;
            //    }
            //    else
            //    {
            //        PageSize4PrjTab = "10";
            //        ddlPagerRecCount.Text = PageSize4PrjTab;
            //    }
            //}
            //gvPrjTab.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjPrjTab">表实体类对象</param>
        protected void GetDataFromPrjTabClass(clsPrjTabEN pobjPrjTab)
        {
            wucPrjTab1.TabId = pobjPrjTab.TabId;
            wucPrjTab1.DataBaseName = pobjPrjTab.DataBaseName;
            wucPrjTab1.TabName = pobjPrjTab.TabName;
            wucPrjTab1.TabCnName = pobjPrjTab.TabCnName;
            wucPrjTab1.FuncModuleAgcId = pobjPrjTab.FuncModuleAgcId;
            //wucPrjTab1.ObjId = pobjPrjTab.ObjId;
            wucPrjTab1.Owner = pobjPrjTab.Owner;
            wucPrjTab1.ParentClass = pobjPrjTab.ParentClass;
            wucPrjTab1.Memo = pobjPrjTab.Memo;
            wucPrjTab1.IsArchive = pobjPrjTab.IsArchive;
            wucPrjTab1.IsChecked = pobjPrjTab.IsChecked;
            wucPrjTab1.TabStateId = pobjPrjTab.TabStateId;
            wucPrjTab1.IsNationStandard = pobjPrjTab.IsNationStandard;
            wucPrjTab1.TabNameB = pobjPrjTab.TabNameB;
            wucPrjTab1.SqlDsTypeId = pobjPrjTab.SqlDsTypeId;
            wucPrjTab1.RelaTabId4View = pobjPrjTab.RelaTabId4View;
            wucPrjTab1.IsReleToSqlTab = pobjPrjTab.IsReleToSqlTab;
            //wucPrjTab1.IsNeedGeneIndexer = pobjPrjTab.IsNeedGeneIndexer;
            wucPrjTab1.TabTypeId = pobjPrjTab.TabTypeId;
            wucPrjTab1.TabMainTypeId = pobjPrjTab.TabMainTypeId;

            wucPrjTab1.IsUseCache = pobjPrjTab.IsUseCache;            
            wucPrjTab1.SetDdl_CacheClassifyField(pobjPrjTab.TabId);
            wucPrjTab1.SetDdl_CacheClassifyField2(pobjPrjTab.TabId);

            wucPrjTab1.CacheClassifyField = pobjPrjTab.CacheClassifyField;
            wucPrjTab1.CacheClassifyField2 = pobjPrjTab.CacheClassifyField2;
                        
            wucPrjTab1.CacheModeId = pobjPrjTab.CacheModeId;
            wucPrjTab1.CacheClassifyFieldTS = pobjPrjTab.CacheClassifyFieldTS;
            wucPrjTab1.CacheClassifyField2TS = pobjPrjTab.CacheClassifyField2TS;

            wucPrjTab1.IsRefresh4RelaView = pobjPrjTab.IsRefresh4RelaView;
            
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjPrjTab">数据传输的目的类对象</param>
        protected void PutDataToPrjTabClass(clsPrjTabEN pobjPrjTab)
        {
            pobjPrjTab.TabId = wucPrjTab1.TabId;
            pobjPrjTab.PrjId = clsPubVar.CurrSelPrjId;
            pobjPrjTab.DataBaseName = wucPrjTab1.DataBaseName;
            pobjPrjTab.Owner = wucPrjTab1.Owner;
            pobjPrjTab.TabName = wucPrjTab1.TabName;
            pobjPrjTab.TabCnName = wucPrjTab1.TabCnName;
            //pobjPrjTab.ObjId = wucPrjTab1.ObjId;
            pobjPrjTab.ParentClass = wucPrjTab1.ParentClass;
            pobjPrjTab.Memo = wucPrjTab1.Memo;
            pobjPrjTab.IsArchive = wucPrjTab1.IsArchive;
            pobjPrjTab.IsChecked = wucPrjTab1.IsChecked;
            pobjPrjTab.TabStateId = wucPrjTab1.TabStateId;
            pobjPrjTab.IsNationStandard = wucPrjTab1.IsNationStandard;
            pobjPrjTab.TabNameB = wucPrjTab1.TabNameB;
            pobjPrjTab.SqlDsTypeId = wucPrjTab1.SqlDsTypeId;
            pobjPrjTab.FuncModuleAgcId = wucPrjTab1.FuncModuleAgcId;
            if (string.IsNullOrEmpty(wucPrjTab1.RelaTabId4View))
            {
                pobjPrjTab.RelaTabId4View = null;
            }
            else
            {
                pobjPrjTab.RelaTabId4View = wucPrjTab1.RelaTabId4View;
            }
            pobjPrjTab.IsReleToSqlTab = wucPrjTab1.IsReleToSqlTab;
            pobjPrjTab.IsNeedGeneIndexer = true;// wucPrjTab1.IsNeedGeneIndexer;
            pobjPrjTab.TabTypeId = wucPrjTab1.TabTypeId;
            pobjPrjTab.TabMainTypeId = wucPrjTab1.TabMainTypeId;

            pobjPrjTab.IsUseCache = wucPrjTab1.IsUseCache;

            pobjPrjTab.CacheClassifyField = wucPrjTab1.CacheClassifyField;
            pobjPrjTab.CacheClassifyField2 = wucPrjTab1.CacheClassifyField2;
                        
            pobjPrjTab.CacheModeId = wucPrjTab1.CacheModeId;
            pobjPrjTab.CacheClassifyFieldTS = wucPrjTab1.CacheClassifyFieldTS;
            pobjPrjTab.CacheClassifyField2TS = wucPrjTab1.CacheClassifyField2TS;

            pobjPrjTab.IsRefresh4RelaView = wucPrjTab1.IsRefresh4RelaView;

            pobjPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            pobjPrjTab.UpdUserId = clsCommonSession.UserId;

        }



        ///生成的插入记录准备过程代码for C#
        protected void AddPrjTabRecord()
        {
            wucPrjTab1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            //wucPrjTab1.TabId = clsPrjTab.GetMaxStrId("PrjTab","TabId", 8, "");
        }
        ///插入记录存盘过程代码for C#
        protected void AddPrjTabRecordSave()
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
            clsPrjTabEN objPrjTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsPrjTabEN objPrjTabEN;	//定义对象
            objPrjTabEN = new clsPrjTabEN(wucPrjTab1.TabId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            ///3.1、判断是否有相同的函数名称存在。					
            if (clsPrjTabBLEx.IsExistSameTabName(clsPubVar.CurrSelPrjId, wucPrjTab1.TabName))	//判断是否有相同的关键字
            {
                strMsg = "相同的工程表名称已经存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);


            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            try
            {
                BindGv_vPrjTab();
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            DispPrjTabListRegion();
        }
        ///插入记录存盘过程代码for C#
        protected void AddPrjTabRecordSaveV5()
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
            clsPrjTabEN objPrjTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsPrjTabEN objPrjTabEN;	//定义对象
            objPrjTabEN = new clsPrjTabEN(wucPrjTab1.TabId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);
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
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            DispPrjTabListRegion();
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdatePrjTabRecord(string strTabId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strTabId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucPrjTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsgEdit.Text = "";
            DispEditPrjTabRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdatePrjTabRecordSave(clsPrjTabEN objPrjTabEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //判断是否可以修改
            if (clsPrjTabBLEx.IsCanDelUpd(objPrjTabEN.TabId) == false)
            {
                lblMsgEdit.Text = "本表已经核实或归档，不能修改!";
                return;
            }

            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);


            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucPrjTab1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            DispPrjTabListRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdatePrjTabRecordSaveV5(clsPrjTabEN objPrjTabEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到

            //3、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);

                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

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
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucPrjTab1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            DispPrjTabListRegion();
        }
        ///删除记录过程代码for C#
        protected void DeletePrjTabRecord(string strTabId)
        {
            try
            {
                clsPrjTabBL.DelRecord(strTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevPrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convPrjTab.TabName); arrCnName.Add("表名");
            arrColName.Add(convPrjTab.TabCnName); arrCnName.Add("表中文名");
            arrColName.Add(convPrjTab.TabId); arrCnName.Add("表ID");
            arrColName.Add(convPrjTab.Memo); arrCnName.Add("说明");
            arrColName.Add(convPrjTab.DataBaseNameTab); arrCnName.Add("数据库名");

            arrColName.Add(convPrjTab.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convPrjTab.TabStateName); arrCnName.Add("表状态名称");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;

            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
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
        /// <summary>
        /// 功能:显示编辑区域
        /// </summary>
        private void DispEditPrjTabRegion()
        {
            divList.Visible = false;
            tabQueryCondition.Visible = false;
            tabEditPrjTabRegion.Visible = true;
            divCode.Visible = false;
        }
        /// <summary>
        /// 显示列表区域
        /// </summary>
        private void DispPrjTabListRegion()
        {
            divList.Visible = true;
            tabQueryCondition.Visible = true;
            //divBaseOperate.Visible = true;
            tabEditPrjTabRegion.Visible = false;
            divCode.Visible = false;
        }
        /// <summary>
        /// 显示生成代码区域
        /// </summary>
        private void DispGenCodeRegion()
        {
            divList.Visible = false;
            tabQueryCondition.Visible = false;
            tabEditPrjTabRegion.Visible = false;
            //            divBaseOperate.Visible = false;
            divCode.Visible = true;
      
        }
        private void CheckTabField1()
        {
            string strWhereCond = CombinevPrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLst(strWhereCond);
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjList)
            {
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

            }
        }

        private void AddSysLogForPrjTab(string strTabId)
        {
            try
            {
                //添加日志
                string strUserId = UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "PrjTab";
                string strTableKey = strTabId;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                string strJournal = "执行了删除操作，删除表PrjTab! 表名：" + objPrjTabEN.TabCnName + "(" + objPrjTabEN.TabName + ")";

                bool IsSuccesful = true;
                IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                    strUserIp,
                    strOperationType,
                    strTableName,
                    strTableKey,
                    strJournal,
                   clsPubVar.CurrSelPrjId);
                if (IsSuccesful)
                {
                    //					Response.Write("<script>alert('日志添加成功!')</script>");
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        //生成返回链接串的Session属性
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
            }
        }
        private void AddPrjTab()
        {
            DispEditPrjTabRegion();
            wucPrjTab1.Clear();
            wucPrjTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认添加";
            wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucPrjTab1.DataBaseName = new clsCommonSession().PrjDataBaseName;
            wucPrjTab1.SqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            wucPrjTab1.TabStateId = "01";
            wucPrjTab1.IsReleToSqlTab = true;
            wucPrjTab1.TabTypeId = "0001";
            wucPrjTab1.TabMainTypeId = "0001";
            wucPrjTab1.IsUseCache = true;


            //wucPrjTab1.SetKeyReadOnly(false);
            //btnOKUpd.Text = "确认添加";
            //lblMsgEdit.Text = "";
            //wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S("");
            //wucPrjTab1.Clear();
            //DispEditPrjTabRegion();

        }
        private void DelSingleTabEx()
        {
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsgList.Text = "";
            //判断是否可以删除
            if (clsPrjTabBLEx.IsCanDelUpd(strTabId) == false)
            {
                lblMsgList.Text = "本表已经核实或归档，不能删除!";
                return;
            }
            try
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                AddSysLogForPrjTab(strTabId);
                clsPrjTabBLEx.DelRecordEx(strTabId);
                try
                {
                    BindGv_vPrjTab();
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除表记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        /// <summary>
        /// 同时删除多表
        /// </summary>
        private void DelMultiTabEx()
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    //判断是否可以删除
                    if (clsPrjTabBLEx.IsCanDelUpd(strTabId) == false)
                    {
                        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                        lblMsgList.Text = string.Format("{0}({1})表已经核实或归档，不能删除!", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
                        return;
                    }
                    try
                    {
                        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                        AddSysLogForPrjTab(strTabId);
                        clsPrjTabBLEx.DelRecordEx(strTabId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = "删除表记录添加日志不成功!\r\n" + objException.Message;
                        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }


        private void GetTabRecNum()
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                StringBuilder sbError = new StringBuilder();

                int intCount = 0;
                int intErrCount = 0;

                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabEN objPrjTabEN = null;
                    try
                    {
                        clsPrjTabBLEx.GetTabRecNum(strTabId, clsPubVar.CurrPrjDataBaseId);
                        intCount++;
                    }
                    catch (Exception objException)
                    {
                        var strMsg0 = string.Format("表:{0}计算表记录数不成功!错误：{1}", objPrjTabEN.TabName, objException.Message);
                        sbError.AppendLine(strMsg0);
                        intErrCount++;
                    }
                }
                var strMsg = string.Format("共计算了{0}个表的记录表！错误数:{1}\r\n{2}", 
                    intCount, intErrCount, sbError.ToString());
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        private void GenTabTestKeyValue()
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                StringBuilder sbError = new StringBuilder();

                int intCount = 0;
                int intErrCount = 0;

                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabEN objPrjTabEN = null;
                    try
                    {
                        objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);

                        List<string> arrKeyValue = clsPrjTabBLEx.GetKeyValuesByTabId(strTabId, clsPubVar.CurrCmPrjId, clsPubVar.CurrPrjDataBaseId);
                        string strKeyValueStr = string.Join(",", arrKeyValue);
                        objPrjTabEN.KeyId4Test = strKeyValueStr;
                        objPrjTabEN.Update();
                        intCount++;
                    }
                    catch (Exception objException)
                    {
                        var strMsg0 = string.Format("表:{0}设置关键字段值不成功!错误：{1}", objPrjTabEN.TabName, objException.Message);
                        sbError.AppendLine(strMsg0);
                        intErrCount++;
                    }
                }

                var strMsg = string.Format("共设置了{0}个表的关键字值！错误数:{1}\r\n{2}",
                    intCount, intErrCount, sbError.ToString());
                clsCommonJsFunc.Alert(this, strMsg);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        private bool SetSameModuleNameForViewRelaTab()
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return false;
            lblMsgList.Text = "";
            foreach (string strTabId in lstTabId)
            {
                try
                {
                    //判断是否可以删除
                    if (clsPrjTabBLEx.SetSameModuleNameForViewRelaTab(strTabId, clsPubVar.CurrSelPrjId) == false)
                    {
                        lblMsgList.Text = "设置与视图相关表相同模块名称不成功!";
                        return false;
                    }
                }
                catch (Exception objException)
                {
                    lblMsgList.Text = objException.Message;
                    return false;
                }
            }
            try
            {
                BindGv_vPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return false;
            }
            return true;
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
                    lblMsgList.Text = "检查表字段不成功!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }


        public override string FuncModuleAgcId
        {
            get
            {
                return "";
            }
        }
        public override void SetMenuTitle()
        {
            return;
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
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string vsTypeParas
        {
            get
            {
                string strTypeParas = "";
                if (ViewState["TypeParas"] == null)
                {
                    if (ddlAppPageTypeId.SelectedIndex > 0)
                    {
                        string strAppPageTypeId = ddlAppPageTypeId.SelectedValue;
                        clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeBL.GetObjByAppPageTypeIdCache(strAppPageTypeId);
                        strTypeParas = strTypeParas + string.Format("{0}|",
                            objAppPageTypeEN.AppPageTypeENName);
                        return strTypeParas;
                    }
                }
                strTypeParas = (string)ViewState["TypeParas"];

                return strTypeParas;
            }
            set
            {
                string strTypeParas = value;
                ViewState.Add("TypeParas", strTypeParas);
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
            vsParentPage = PretreatmentParentPage(qsParentPage);
            switch (vsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    //                lbReturnPrjTabList.Text = "返回[工程表列表]";
                    break;
                case "wfmEditTabAndObjectFields.aspx":
                    //                lbReturnPrjTabList.Text = "返回[工程表列表]";
                    break;
                case "wfmPrjTab_CheckConsistency.aspx":
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
                case "CheckConsistency":
                    string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strTabId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.TabId = strTabId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    clsPubFun4Web.CheckConsistency(this, strTabId, strCurrPageName);

                    break;
                case "EditTabFields":
                    if (string.IsNullOrEmpty(vsTabId_T) == true)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.TabId = vsTabId_T;
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
                    clsPubFun4Web.JumpToEditTabAndFields(this, vsTabId_T, strCurrPageName);
                    break;
                case "EditTabAndObjectFields":
                    if (string.IsNullOrEmpty(vsTabId_T) == true)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.TabId = vsTabId_T;
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
                    clsPubFun4Web.JumpToEditTabAndFields(this, vsTabId_T, strCurrPageName);
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息


        protected void btnQueryReferedTabAndView_Click(object sender, EventArgs e)
        {
            string strTabId = getFirstCheckedTabId();
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                if (string.IsNullOrEmpty(vsReferTabId) == true)
                {
                    lblReferedTabName.Text = "";
                    return;
                }

                strTabId = vsReferTabId;
                lblMsgList.Text = "";
            }
            else
            {
                vsReferTabId = strTabId;
                lblReferedTabName.Text = string.Format("被参考表:[{0}]",
                    clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId).TabName);
            }
            List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "所选表没有相关父结点表！");
                return;
            }
            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
       
            try
            {
                BindGv_vPrjTab(strCondition);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnQueryViewReferThisTab_Click(object sender, EventArgs e)
        {
            string strTabId = getFirstCheckedTabId();
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                if (string.IsNullOrEmpty(vsReferTabId) == true)
                {
                    lblReferedTabName.Text = "";
                    return;
                }
                strTabId = vsReferTabId;
                lblMsgList.Text = "";
            }
            else
            {
                vsReferTabId = strTabId;
                lblReferedTabName.Text = string.Format("参考表:[{0}]",
                    clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId).TabName);

            }

            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "所选表没有引用该表的相关视图！");
                return;
            }

            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
            try
            {
                BindGv_vPrjTab(strCondition);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }
        /// <summary>
        /// 当前操作用户的Id_User,如果是教师就返回Id_Teacher,如果是学生就返回Id_StudentInfo。
        /// </summary>
        protected string vsReferTabId
        {
            get
            {
                string sReferTabId;
                sReferTabId = (string)ViewState["ReferTabId"];
                if (sReferTabId == null)
                {
                    sReferTabId = "";
                }
                return sReferTabId;
            }
            set
            {
                string sReferTabId = value;
                ViewState.Add("ReferTabId", sReferTabId);
            }
        }

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_QUDI3.aspx";
            }
        }
        //protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        //{
        //    switch (e.PostBackValue)
        //    {
        //        case "Entity":
        //            GeneEntityLayer();
        //            break;
        //        case "CondEntity":
        //            GeneCondEntityLayer();
        //            break;
        //        case "DAL":
        //            GenDALCode();
        //            break;

        //        case "DALEx":
        //            GenDALExCode();
        //            break;
        //        case "Business":
        //            BusinessLogicCode();
        //            break;
        //        case "BusinessEx":
        //            GeneBusinessLogicExCode();
        //            break;
        //        case "CommFun4BL":
        //            GeneCommFun4BL();
        //            break;
        //        case "WebService":
        //            GeneWebServiceCode();
        //            break;

        //        case "WS_Access":
        //            GenWebServiceTransCode();
        //            break;
        //        case "WS_AccessHigh":
        //            GenControllerInvokeWS();
        //            break;
        //        case "AppController":
        //            GenController();
        //            break;
        //        case "DesktopController":
        //            GenDesktopController();
        //            break;
        //        case "AppViewUnitTest":
        //            GenController4UnitTest();
        //            break;
        //        case "DesktopViewUnitTest":
        //            GenDesktopController4UnitTest();
        //            break;
        //        case "AppViewUTScript":
        //            GenController4UTScript();
        //            break;
        //        case "DesktopViewUTScript":
        //            GenDesktopController4UTScript();
        //            break;
        //        case "AppViewUTScriptCS":
        //            GenController4UTScriptCS();
        //            break;
        //        case "DesktopViewUTScriptCS":
        //            GenDesktopController4UTScriptCS();
        //            break;
        //        case "Dict_PageName_Dir":
        //            GeneDict_PageName_Dir();
        //            break;

        //        default:
        //            clsCommonJsFunc.Alert(this, e.PostBackValue);
        //            break;
        //            //{

        //            //            }
        //            //else             if (e.PostBackValue == "A2")
        //            //            {
        //            //                clsCommonJsFunc.Alert(this, e.PostBackValue);
        //            //            }
        //    }
        //}
        

             protected void wucTreeView4PrjTab_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView4PrjTab.CollapseAll();
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4PrjTab.GetCurrPathNodeKeyIdLst();
            wucTreeView4PrjTab.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            string strTabId = strKeyId;
            //string strFuncModuleAgcId = wucTreeView1.NodeData.FuncModuleAgcId;
//            if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return;
            if (strTypeName != "PrjTab")
            {
                return;
            }
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            BindTv_ApplicationType_CodeType_Function4GeneCode(strTabId);

            //throw new NotImplementedException();
        }


        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            if (string.IsNullOrEmpty(strFuncId4GC) == true)
            {
                GeneCode4Level();
            }
            else
            {
                GeneCode4Func();
            }
            //throw new NotImplementedException();
        }
        protected void GeneCode4Func()
        {
            string strFeatureId = wucTreeView1.NodeData.FeatureId;
            string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strViewId = wucTreeView1.NodeData.ViewId;
            string strCmPrjId = clsCommonSession.CmPrjId;
            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strExamDate = wucTreeView1.NodeData.ExamDate;

            //Hide_txtCode_Sim();//显示简化实体层代码文本框
                               //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangType.ProgLangTypeName);

            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                string strViewId = "";
                string strRe_ClsName = "";
               
                string strRe_FileNameWithModuleName = "";
                //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);
                txtFileName4GC.Text = strRe_ClsName;
                ShowCode(strCodeText);

            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
        //    DispGenCodeRegion();


        }

        protected void GeneCode4Level()
        {
            string strFeatureId = wucTreeView1.NodeData.FeatureId;
            string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strViewId = wucTreeView1.NodeData.ViewId;
            //string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strExamDate = wucTreeView1.NodeData.ExamDate;
            string strCmPrjId = "";
            //Hide_txtCode_Sim();//显示简化实体层代码文本框
            //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                string strViewId = "";
                string strRe_ClsName = "";
             
                string strRe_FileNameWithModuleName = "";
              
                string strCodeText = AutoGC.GeneCode(strCodeTypeId, vsTypeParas, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, int.Parse( strApplicationTypeId), clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                txtFileName4GC.Text = strRe_ClsName;
                ShowCode(strCodeText);

            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
          //  DispGenCodeRegion();


        }

        private void BindTv_FuncModule_Agc_PrjTab()
        {
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            //if (string.IsNullOrEmpty(strTabId) == true) return;
            wucTreeView4PrjTab.tmTreeModel = TreeModel.FuncModule_Agc_PrjTab;
            wucTreeView4PrjTab.DependsOn = "Table";
            wucTreeView4PrjTab.FunctionTemplateId = "0001";            
            //wucTreeView4PrjTab.IsUseJsEvent = true;
            wucTreeView4PrjTab.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView4PrjTab.BindTv();
            wucTreeView4PrjTab.Expand(1);
            //wucTreeView4PrjTab.afterSelect_Tz += wucTreeView4PrjTab_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView4PrjTab.CollapseAll();
            //            wucTreeView4PrjTab.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4PrjTab.ExpandLevel1();
            wucTreeView4PrjTab.Nodes[1].Expand();
        }


        private void BindTv_ApplicationType_CodeType_Function4GeneCode(string strTabId)
        {
//            string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId);

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_ClassName_Function4GeneCode;
            if (objPrjTab.TabTypeId == enumTabType.PureClass_0008)
            {
                wucTreeView1.DependsOn = "PureClass";
            }
            else
            {
                wucTreeView1.DependsOn = "Table";
            }
                 
            wucTreeView1.FunctionTemplateId = "0001";
            wucTreeView1.TabId = strTabId;
            wucTreeView1.IsUseJsEvent = true;
            wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            //wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView1.ExpandLevel1();
            wucTreeView1.Nodes[1].Expand();
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
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvPrjTab4Gv1_GvEditTabFieldsClick(object sender, clsEventArgs4EditTabFields e)
        {
            string strTabId = e.KeyId;
            vsTabId_T = strTabId;
            JumpOtherPages("EditTabFields");
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            //litCode.Text = sbJs.ToString();
        }

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strTabId, string strViewId, string strCmPrjId, int intApplicationTypeId)
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

                string strCodeText = AutoGC.GeneCode(strCodeTypeId, "", clsPubConst.DataBaseType.MsSql, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //txtFileName4GC.Text = strRe_ClsName;
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
                clsGCType objGCType1 = new clsGCType();
                objGCType1.Code = objException.Message;
                return clsJSON.GetJsonFromObj(objGCType1);
          //      return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
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


        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetCacheModeId_Click(object sender, System.EventArgs e)
        {
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            if (ddlCacheModeId_SetFldValue.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入缓存方式Id(CacheModeId)!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlCacheModeId_SetFldValue.Focus();
                return;
            }
            string strCacheModeId = ddlCacheModeId_SetFldValue.SelectedValue;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    K_TabId_PrjTab objKey = new K_TabId_PrjTab(strTabId);
                    clsPrjTabEN objPrjTab = objKey.GetObj();
                    objPrjTab.SetCacheModeId(strCacheModeId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUserId(clsCommonSession.UserId);
                    if (string.IsNullOrEmpty(objPrjTab.RelaTabId4View) == true) objPrjTab.RelaTabId4View = null;
                    objPrjTab.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000089)设置缓存方式Id不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vPrjTab();
        }
        protected void btnCheckTabFlds_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择CmPrjId!");
                ddlCmPrjIdq.Focus();
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            List<string> lstTabId = wucvPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBLEx.CheckTabFlds(strTabId, strCmPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vPrjTab();
        }

    }
}