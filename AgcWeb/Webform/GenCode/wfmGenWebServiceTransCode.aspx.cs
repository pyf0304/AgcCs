
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace AGC.Webform
{
    /// <summary>
    /// wfmWebSrvFunctions_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmGenWebServiceTransCode : CommPageBase
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
                    lblLangTypeName.Text = strLangType;
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                    lblDataBaseType.Text = strDataBaseType;
                    break;
                    
                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            clsCommonSession.UserId = "pyf";
            clsPubVar.CheckUserSession();
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                InitParentPageInfo();
               
               
                vsViewName = "vWebSrvFunctions";
                

                txtWebSrvUrl.Text = new clsCommonSession().TabName;
                txtTabCnNameq.Text = new clsCommonSession().TabCnName;
                //=====================================================

                //2、显示无条件的表内容在DATAGRID中
                if (string.IsNullOrEmpty(vsSortWebSrvFunctionsBy) == true)
                {
                    vsSortWebSrvFunctionsBy = "UpdDate Desc";
                }
                //2、显示无条件的表内容在DATAGRID中
                //是否显示详细列表;
             //   DispDetailListForWebSrvFunctions();
                BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
      
                DispWebSrvFunctionsListRegion();
               

                //显示不同操作显示区域
                DispDiv4Operate("DotNet", "Ms Sql");
                //divAdvanceOperate.Visible = false;
               // trAdvanceQuery.Visible = false;
                clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvWebSrvFunctions, vsViewName, clsCommonSession.UserId);
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
            clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvWebSrvFunctions, vsViewName, clsCommonSession.UserId);
            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
            clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 0);
        }

        protected void wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                clsSetFieldVisibilityBLEx.GetFldNameLstByGridView(gvWebSrvFunctions, vsViewName, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
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
            this.gvWebSrvFunctions.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvWebSrvFunctions, vsViewName, clsCommonSession.UserId);

            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
            //保存这次查询条件，为下一次再来该界面服务
          
            new clsCommonSession().TabName = txtWebSrvUrl.Text;
            new clsCommonSession().TabCnName = txtTabCnNameq.Text;
          

        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvWebSrvFunctions_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvWebSrvFunctions.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
        }
      


        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrTabId = getAllCheckedTabIds();
            if (arrTabId == null) return;
            try
            {
                clsWebSrvFunctionsBL.DelWebSrvFunctionss(arrTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
        }
        private List<string> getAllCheckedTabIds()
        {
            List<string> arrTabId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvFunctions, "chkCheckRec");
            if (arrTabId == null || arrTabId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return null;
            }
            lblMsgList.Text = "";
            return arrTabId;
        }
        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strTabId = getFirstCheckedTabId();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            //1、显示该关键字的数据让用户修改该关键字记录；
         
        }
        private string getFirstCheckedTabId()
        {
            string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions);
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return "";
            }
            lblMsgList.Text = "";
            return strTabId;
        }
        
        protected void gvWebSrvFunctions_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortWebSrvFunctionsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Asc";
                BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
                return;
            }
            //检查原来是升序
            intIndex = vsSortWebSrvFunctionsBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Desc";
            }
            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
        }

        protected string vsSortWebSrvFunctionsBy
        {
            get
            {
                string sSortWebSrvFunctionsBy;
                sSortWebSrvFunctionsBy = (string)ViewState["SortWebSrvFunctionsBy"];
                if (sSortWebSrvFunctionsBy == null)
                {
                    sSortWebSrvFunctionsBy = "";
                }
                return sSortWebSrvFunctionsBy;
            }
            set
            {
                string sSortWebSrvFunctionsBy = value;
                ViewState.Add("SortWebSrvFunctionsBy", sSortWebSrvFunctionsBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvWebSrvFunctions.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvWebSrvFunctions.PageCount)
                {
                    this.gvWebSrvFunctions.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvWebSrvFunctions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strTabId = "";
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvFunctions, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvFunctions, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
                case "EditObjectAndTabFields":
                    //int deleteid = (int)GridView1.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value;  
                    strTabId = gvWebSrvFunctions.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value.ToString();
                    vsTabId_T = strTabId;
                    JumpOtherPages("EditTabAndObjectFields");
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvWebSrvFunctions_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }

                LinkButton lbEditObjectAndTabFields = (LinkButton)e.Row.FindControl("lbEditObjectAndTabFields");
                if (lbEditObjectAndTabFields != null)
                {
                    lbEditObjectAndTabFields.CommandArgument = e.Row.RowIndex.ToString();
                }
            }
            int intIndex;
            if (vsSortWebSrvFunctionsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvWebSrvFunctions.Columns.Count; i++)
                {
                    strSortEx = this.gvWebSrvFunctions.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortWebSrvFunctionsBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortWebSrvFunctionsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvWebSrvFunctions_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strTabId = gvWebSrvFunctions.DataKeys[e.RowIndex].Value.ToString();
           
        }
        ///
        protected void gvWebSrvFunctions_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strTabId = gvWebSrvFunctions.DataKeys[e.RowIndex].Value.ToString();
           
        }
        ///删除记录过程代码for C#
        protected void gvWebSrvFunctions_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvWebSrvFunctions.PageIndex = e.NewPageIndex;
                this.BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
            }
        }
        ///
        protected void lbDispWebSrvFunctionsList_Click(object sender, EventArgs e)
        {
            DispWebSrvFunctionsListRegion();
        }
        protected void lbImportSQLTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportTabInfoFromSQL.aspx");
        }
        protected void lbImportSQLView_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportViewInfoFromSQL2.aspx");
        }
     
        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            JumpOtherPages("CheckConsistency");
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
            DispWebSrvFunctionsListRegion();
        }
        protected void lbSetModuleByObj_Click(object sender, EventArgs e)
        {

        }
        protected void lbSetSameModuleByObj_Click(object sender, EventArgs e)
        {
            SetSameModuleNameByObject();
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
                    PageSize4WebSrvFunctions = intPageSize.ToString();
                    BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
                }
            }
        }


       protected void btnEditEx_Click(object sender, EventArgs e)
        {

            string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions);
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            clsCommonSession.TabId = strTabId;
            //1、显示该关键字的数据让用户修改该关键字记录；
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../../FrameSetForTable.htm','EditTable'); </script>";
            Response.Write(c1);
        }
           protected void lbGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions);
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            clsCommonSession.TabId = strTabId;
            string c1 = @"<script language='javascript'>window.open('../Table/wfmGeneStoreProcedure.aspx','生成存储过程'); </script>";
            Response.Write(c1);
        }
         protected void lbGeneWebServiceTransCode_Click(object sender, EventArgs e)
        {
            Hide_txtCode_Sim();//隐藏简化实体层代码文本框

            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            //
            lblMsgList.Text = "";

         
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择一个WebService记录，请选择一个有效的表记录!";
                return;
            }

            //if (CheckTabFieldBySqlTab(strTabId) == false)
            //{
            //    return;
            //}
            try
            {  
              
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Access;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "",
                    vsLangType, vsDataBaseType, vsWebSrvClassId, 
                    clsPubVar.CurrSelPrjId, 
                    clsPubVar.CurrPrjDataBaseId, 
                    clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenWebServiceTransCode(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //    strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }         
        }
      
        private void Hide_txtCode_Sim()
        {
            txtCode_Sim.Visible = false;
            //txtCode.Height = 600;

        }
        private void Show_txtCode_Sim()
        {
            txtCode_Sim.Visible = true;
            //txtCode.Height = 338;
        }
        private void ChangeLangType(string strLangType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = strLangType;
            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = clsPubConst.GetDataBaseTypeStrByDataBaseType( vsDataBaseType);
            //vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType( vsLangType);
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
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
          
            lbGeneController.Visible = true;
            lbGeneControllerInvokeWS.Visible = true;
            if (strNetOrJava == "DotNet")
            {
                vsLangType = clsPubConst.LangType.CSharp;
                lbGeneController.Visible = false;
                lbGeneControllerInvokeWS.Visible = false;
            }
            else if (strNetOrJava == "Java")
            {
                vsLangType = clsPubConst.LangType.JAVA;
               

            }
            else if (strNetOrJava == "Swift")
            {
                vsLangType = clsPubConst.LangType.Swift;
              
            }
            else if (strNetOrJava == "JavaScript")
            {
                vsLangType = clsPubConst.LangType.JavaScript;
               
            }
            else if (strNetOrJava == "SilverLight")
            {
                vsLangType = clsPubConst.LangType.SilverLight;
               
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

 
        protected void lbGeneController_Click(object sender, EventArgs e)
        {
            Hide_txtCode_Sim();//隐藏简化实体层代码文本框

            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            //
            lblMsgList.Text = "";
                      
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppController;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
    
            }
        }

        protected void lbGeneControllerInvokeWS_Click(object sender, EventArgs e)
        {
            Hide_txtCode_Sim();//隐藏简化实体层代码文本框

            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            //
            lblMsgList.Text = "";

           
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_AccessHigh;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }

        //protected void lbGeneDict_PageName_Dir_Click(object sender, EventArgs e)
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
        //        string strCodeText = AutoGC.GeneCode(cnClassName, "", ltLangType, dbtDataBaseType, strTabId, 
        //            strViewId, strPrjId, strPrjDataBaseId, strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        //string strCodeText = clsAutoGeneCodeWS.GeneCode(cnClassName, ltLangType, dbtDataBaseType, strTabId, strViewId, strPrjId, strPrjDataBaseId, strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        txtFileName4GenCode.Text = strRe_ClsName;
        //        ShowCode(strCodeText);
        //        //显示生成代码区域
        //        DispGenCodeRegion();

        //        //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(strPrjId, strUserId);

        //        //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

        //        //string strClassFName = objAutoGC6Cs_WS.objWebSrvFunctionsENEx.FolderName + strRe_FileNameWithModuleName;
        //        //clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeText, objAutoGC6Cs_WS.objWebSrvFunctionsENEx.FolderName_Root,
        //        //    objAutoGC6Cs_WS.objWebSrvFunctionsENEx.BackupFolderName, myEncoding);


        //        //MessageBox.Show(strRe_ClsName + " : " + strRe_FileNameWithModuleName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonJsFunc.Alert(this, objException.Message);
        //        //MessageBox.Show(objException.Message);
        //    }
        //}

 
        protected void lbGeneBusinessLogicExCode_Click(object sender, EventArgs e)
        {
            Hide_txtCode_Sim();//隐藏简化实体层代码文本框

            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions);
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            try
            {
                string strCmPrjId = "";
                string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.BusinessLogicEx;

                string strCodeText = AutoGC.GeneCode(cnClassName, "", vsLangType,vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.ApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //     strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

                lblMsgList.Text = objException.Message;

            } //显示生成代码区域
            DispGenCodeRegion();

        }

  
        protected void btnDIspFunctionInfo_Click(object sender, EventArgs e)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strp_Url = "";// "http://101.251.68.133/EduHigh/WebService/UserManage/StudentInfoService.asmx?WSDL";
            //http://101.251.68.133/EduHigh/WebService/UserManage/StudentInfoExService.asmx
            //?op = GetId_StudentInfoByStuID
            string strUrl_Sim = "";
            strp_Url = txtWebSrvUrl.Text;
            string strPageName = "";
            if (strp_Url.IndexOf("?WSDL")<0)
            {
                strUrl_Sim = strp_Url;
                strp_Url += "?WSDL";
                txtWebSrvUrl.Text = strp_Url;
                clsCommonJsFunc.Alert(this, "检查一下地址是否正确！");
                return;
            }
            else
            {
                int iPos = strp_Url.IndexOf("?WSDL");
                strUrl_Sim = strp_Url.Remove(iPos);
            }

            strPageName = clsString.GetSimpleFName_S(strUrl_Sim);
            //    string p_NameSpace = "EduHigh_WS";
                string p_NameSpace = string.Format("{0}_WS", clsPubVar.objCurrSelProject.PrjDomain);
            try
            {

                Assembly _WebServiceAssembly = clsGetAssembly.GetWebServiceAssembly(strp_Url, p_NameSpace);
                //   Type _Type = _WebServiceAssembly.GetType("TestTSPSubassemblyBase.TelDirectory");
                //Type _Type = _WebServiceAssembly.GetType("EduHigh_WS.StudentInfoService");
                Type[] _AllType1 = _WebServiceAssembly.GetTypes();//.GetType("EduHigh_WS.StudentInfoExService");
                Type _Type_1 = _AllType1[0];
                txtFileName4GenCode.Text = _Type_1.FullName;
                MethodInfo[] _AllMethod = _Type_1.GetMethods();

                string strWhereExist = string.Format("{0}='{1}'", 
                    conWebSrvClass.WebSrvUrl, strp_Url);
                clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetFirstObj_S(strWhereExist);
                if (objWebSrvClassEN == null)
                {
                     objWebSrvClassEN = new clsWebSrvClassEN();
                    objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
                    objWebSrvClassEN.WebSrvUrl = strp_Url;
                    objWebSrvClassEN.PageName = strPageName;
                    objWebSrvClassEN.NameSpace = p_NameSpace;
                    objWebSrvClassEN.ClsName = _Type_1.Name;
                    objWebSrvClassEN.PrjId = clsPubVar.CurrSelPrjId;
                    objWebSrvClassEN.UpdDate = strCurrDate;
                    objWebSrvClassEN.UpdUser = clsCommonSession.UserId;
                    clsWebSrvClassBL.AddNewRecordBySql2(objWebSrvClassEN);
                    vsWebSrvClassId = objWebSrvClassEN.WebSrvClassId;
                }
                else
                {
                    objWebSrvClassEN.WebSrvUrl = strp_Url;
                    objWebSrvClassEN.NameSpace = p_NameSpace;
                    objWebSrvClassEN.ClsName = _Type_1.Name;
                    objWebSrvClassEN.PageName = strPageName;
                    objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objWebSrvClassEN.UpdUser = clsCommonSession.UserId;
                    clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);
                    vsWebSrvClassId = objWebSrvClassEN.WebSrvClassId;
                }
                StringBuilder sbMsg = new StringBuilder();
                List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst = new List<clsWebSrvFunctionsEN>();

                int intIndex = 1;
                string strCondition_Del = string.Format("{0}='{1}'",
                      conWebSrvFunctions.WebSrvClassId,
                      objWebSrvClassEN.WebSrvClassId);
                clsWebSrvFunctionsBL.DelWebSrvFunctionssByCond(strCondition_Del);

                foreach (MethodInfo _Method in _AllMethod)
                {
                    if (clsWebSrvFunctionsBLEx.IsSysFunction(_Method.Name) == true) continue;
                    clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
                    //clsWebSrvFunctionsBLEx.get
                        
                    objWebSrvFunctionsEN.WebSrvClassId = objWebSrvClassEN.WebSrvClassId;
                    objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();// string.Format("{0:D3}", intIndex);
                    objWebSrvFunctionsEN.FunctionName = _Method.Name;
                    objWebSrvFunctionsEN.FuncTypeId= "10";
                    objWebSrvFunctionsEN.ReturnTypeFullName = _Method.ReturnType.FullName;
                    objWebSrvFunctionsEN.ReturnType = _Method.ReturnType.Name;
                    if (objWebSrvFunctionsEN.ReturnType == "IAsyncResult")
                    {
                        objWebSrvFunctionsEN.IsAsyncFunc = true;
                        objWebSrvFunctionsEN.SourceFunction = objWebSrvFunctionsEN.FunctionName.Substring(5);
                    }
                    try
                    {
                        objWebSrvFunctionsEN.ReturnTypeId = clsDataTypeAbbrBLEx.GetReturnTypeIdByReturnType(objWebSrvFunctionsEN.ReturnTypeFullName);
                    }
                    catch(Exception objException)
                    {
                        clsPubVar.objLog.WriteDebugLog(objException.Message);
                        objWebSrvFunctionsEN.ReturnTypeId = "00";
                    }
                    objWebSrvFunctionsEN.GetCustomAttributes = _Method.GetCustomAttributes(true).Length;
                    objWebSrvFunctionsEN.FunctionSignature = _Method.ToString();
                    objWebSrvFunctionsEN.UpdDate = strCurrDate;
                    objWebSrvFunctionsEN.UpdUser = clsCommonSession.UserId;
                    ParameterInfo[] myParameterInfoLst = _Method.GetParameters();
                    //strWhereExist = string.Format("{0}='{1}' And {2}='{3}'", 
                    //                        conWebSrvFunctions.WebSrvClassId,
                    //                        objWebSrvFunctionsEN.WebSrvClassId,
                    //                        conWebSrvFunctions.FunctionName,
                    //                         objWebSrvFunctionsEN.FunctionName);
                    //if (clsWebSrvFunctionsBL.IsExistRecord(strWhereExist) == false)
                    //{
                        clsWebSrvFunctionsBL.AddNewRecordBySql2(objWebSrvFunctionsEN);
                    //}
                    //else
                    //{
                    //    clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);

                    //}
                    arrWebSrvFunctionsObjLst.Add(objWebSrvFunctionsEN);
                    strCondition_Del = string.Format("{0}='{1}'", 
                        conWebSrvFunctions.WebSrvFunctionId,
                        objWebSrvFunctionsEN.WebSrvFunctionId);
                    clsWebSrvFuncParaBL.DelWebSrvFuncParasByCond(strCondition_Del);
                    foreach (ParameterInfo objPI in myParameterInfoLst)
                    {
                  
                        clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
                        //clsWebSrvFuncParaBLEx.get

                        objWebSrvFuncParaEN.WebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId;
                        objWebSrvFuncParaEN.WebSrvFuncParaId = clsWebSrvFuncParaBL.GetMaxStrId_S();// string.Format("{0:D3}", intIndex);
                        objWebSrvFuncParaEN.ParaName = objPI.Name;
                        objWebSrvFuncParaEN.ParaCnName = objPI.Name;
                        objWebSrvFuncParaEN.ParameterType = objPI.ParameterType.Name;
                        if (objWebSrvFuncParaEN.ParameterType == "IAsyncResult")
                        {
                            objWebSrvFunctionsEN.IsAsyncFunc = true;
                            objWebSrvFunctionsEN.SourceFunction = objWebSrvFunctionsEN.FunctionName.Substring(3);
                            clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);
                        }
                        objWebSrvFuncParaEN.ParameterTypeFullName = objPI.ParameterType.FullName;
                        if (objWebSrvFuncParaEN.ParameterType.IndexOf("&")>=0)
                        {
                            objWebSrvFuncParaEN.IsByRef = true;
                            objWebSrvFuncParaEN.ParameterType = objWebSrvFuncParaEN.ParameterType.Replace("&", "").Trim();
                            objWebSrvFuncParaEN.ParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("&", "").Trim();
                        }
                        else
                        {
                            objWebSrvFuncParaEN.IsByRef = false;
                        }
                        try
                        {
                            objWebSrvFuncParaEN.DataTypeId = clsDataTypeAbbrBLEx.GetReturnTypeIdByReturnType(objWebSrvFuncParaEN.ParameterTypeFullName);
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                            objWebSrvFuncParaEN.DataTypeId = "00";
                        }
                        objWebSrvFuncParaEN.UpdDate = strCurrDate;
                        objWebSrvFuncParaEN.UpdUser = clsCommonSession.UserId;
                     
                        //strWhereExist = string.Format("{0}='{1}' And {2}='{3}'",
                        //                        clsWebSrvFuncParaEN.con_WebSrvFunctionId,
                        //                        objWebSrvFuncParaEN.WebSrvFunctionId,
                        //                        clsWebSrvFuncParaEN.con_ParaName,
                        //                         objWebSrvFuncParaEN.ParaName);
                        //if (clsWebSrvFuncParaBL.IsExistRecord(strWhereExist) == false)
                        //{
                            clsWebSrvFuncParaBL.AddNewRecordBySql2(objWebSrvFuncParaEN);
                        //}
                        //else
                        //{
                        //    clsWebSrvFuncParaBL.UpdateBySql2(objWebSrvFuncParaEN);

                        //}
                      
                    }
                    sbMsg.AppendFormat("Name={0}, GetCustomAttributes={1}.{2}\r\n",
                        _Method.Name, _Method.GetCustomAttributes(true).Length, _Method.ToString());
                    intIndex++;
                }
                ShowCode(sbMsg.ToString());
                vsarrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst;
                BindGv_WebSrvFunctions(arrWebSrvFunctionsObjLst);
                //MethodInfo _Method1 = _Type.GetMethod("GetId_StudentInfoByStuID");
                //object _Object = Activator.CreateInstance(_Type);

                //object _ReturnData = _Method1.Invoke(_Object, new object[] { });
            }
            catch (Exception objException)
            {
            clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

    }
    public partial class wfmGenWebServiceTransCode : CommPageBase
    {

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
        protected string PageSize4WebSrvFunctions
        {
            get
            {
                string strPageSize4WebSrvFunctions;
                strPageSize4WebSrvFunctions = (string)Session["PageSize4WebSrvFunctions"];
                if (strPageSize4WebSrvFunctions == null)
                {
                    strPageSize4WebSrvFunctions = "";
                }
                return strPageSize4WebSrvFunctions;
            }
            set
            {
                string strPageSize4WebSrvFunctions = value;
                Session.Add("PageSize4WebSrvFunctions", strPageSize4WebSrvFunctions);
            }
        }


        ///生成专门用于记录GridView中的每页记录数
        protected string DispAllErrMsg
        {
            get
            {
                string strPageSize4WebSrvFunctions;
                strPageSize4WebSrvFunctions = (string)Session["DispAllErrMsg"];
                if (strPageSize4WebSrvFunctions == null)
                {
                    strPageSize4WebSrvFunctions = "";
                }
                return strPageSize4WebSrvFunctions;
            }
            set
            {
                string strPageSize4WebSrvFunctions = value;
                Session.Add("DispAllErrMsg", strPageSize4WebSrvFunctions);
            }
        }



        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineWebSrvFunctionsCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.txtWebSrvUrl.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtWebSrvUrl.Text.Trim() + "%'";
            }
          

            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_WebSrvFunctions(List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst)
        {
   
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；

            //	2、根据条件串获取该表满足条件的DataTable；
            if (arrWebSrvFunctionsObjLst == null 
                || arrWebSrvFunctionsObjLst.Count == 0) return;
            //	4、设置GRIDView的数据源(DataSource)；
            if (string.IsNullOrEmpty(PageSize4WebSrvFunctions) == false)
            {
                int intPageSize = int.Parse(PageSize4WebSrvFunctions);
                gvWebSrvFunctions.PageSize = intPageSize;
            }
            else
            {
                PageSize4WebSrvFunctions = "10";
                gvWebSrvFunctions.PageSize = 10;
            }
             
            if (vsSortWebSrvFunctionsBy.Contains("Asc") == true)
            {
                vsMySortOrder = System.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                vsMySortOrder = System.Data.SqlClient.SortOrder.Descending;
            }
            if (vsSortWebSrvFunctionsBy.Contains(conWebSrvFunctions.FunctionName) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x=>x.FunctionName).ToList();
            }
            else if (vsSortWebSrvFunctionsBy.Contains(conWebSrvFunctions.FunctionSignature) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.FunctionSignature).ToList();

            }
            else if (vsSortWebSrvFunctionsBy.Contains(conWebSrvFunctions.GetCustomAttributes) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.GetCustomAttributes).ToList();

            }
            else if (vsSortWebSrvFunctionsBy.Contains(conWebSrvFunctions.ReturnTypeId) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.ReturnTypeId).ToList();

            }
            this.gvWebSrvFunctions.DataSource = arrWebSrvFunctionsObjLst;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvWebSrvFunctions.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvWebSrvFunctions.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = arrWebSrvFunctionsObjLst.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvWebSrvFunctions.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvWebSrvFunctions.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvWebSrvFunctions.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvWebSrvFunctions.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvWebSrvFunctions.PageIndex == this.gvWebSrvFunctions.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize4WebSrvFunctions) == false)
                {
                    ddlPagerRecCount.Text = PageSize4WebSrvFunctions;
                }
                else
                {
                    PageSize4WebSrvFunctions = "10";
                    ddlPagerRecCount.Text = PageSize4WebSrvFunctions;
                }
            }
            gvWebSrvFunctions.BottomPagerRow.Visible = true;
        }


        /// <summary>
        /// 功能:显示编辑区域
        /// </summary>
        private void DispEditWebSrvFunctionsRegion()
        {
            divList.Visible = false;
            tabQueryCondition.Visible = false;
         
            tabCode.Visible = false;
        }
        /// <summary>
        /// 显示列表区域
        /// </summary>
        private void DispWebSrvFunctionsListRegion()
        {
            divList.Visible = true;
            tabQueryCondition.Visible = true;
     
         
            tabCode.Visible = true;
        }
        /// <summary>
        /// 显示生成代码区域
        /// </summary>
        private void DispGenCodeRegion()
        {
            divList.Visible = false;
            tabQueryCondition.Visible = false;
           
//            divBaseOperate.Visible = false;
            tabCode.Visible = true;
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
       
        private bool SetSameModuleNameByObject()
        {
            List<string> arrLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvFunctions, "chkCheckRec");
            if (arrLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return false;
            }
            lblMsgList.Text = "";
            foreach (string strTabId in arrLst)
            {
                try
                {
                    //判断是否可以删除
                    //if (clsWebSrvFunctionsBLEx.SetSameModuleNameByObject(strTabId) == false)
                    //{
                    //    lblMsgList.Text = "设置与相关对象相同模块名称不成功!";
                    //    return false;
                    //}
                }
                catch (Exception objException)
                {
                    lblMsgList.Text = objException.Message;
                    return false;
                }
            }
            BindGv_WebSrvFunctions(vsarrWebSrvFunctionsObjLst);
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


        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected List<clsWebSrvFunctionsEN> vsarrWebSrvFunctionsObjLst
        {
            get
            {
                List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst;


                arrWebSrvFunctionsObjLst = (List<clsWebSrvFunctionsEN>)ViewState["arrWebSrvFunctionsObjLst"];
                return arrWebSrvFunctionsObjLst;
            }
            set
            {
                List<clsWebSrvFunctionsEN> strarrWebSrvFunctionsObjLst = value;
                ViewState.Add("arrWebSrvFunctionsObjLst", strarrWebSrvFunctionsObjLst);
            }
        }
        #region 处理父页面信息以及跳转到其他页面
        public override void InitParentPageInfo()
        {
            vsParentPage = PretreatmentParentPage(qsParentPage);
            switch (vsParentPage)
            {
                case "wfmWebSrvFunctions_QUDI3.aspx":
                    //                lbReturnWebSrvFunctionsList.Text = "返回[工程表列表]";
                    break;
                case "wfmEditTabAndObjectFields.aspx":
                    //                lbReturnWebSrvFunctionsList.Text = "返回[工程表列表]";
                    break;
                case "wfmWebSrvFunctions_CheckConsistency.aspx":
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
                    string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions);
                    if (strTabId == null || strTabId.Trim().Length == 0)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.TabId = strTabId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
                
                    clsPubFun4Web.CheckConsistency(this, strTabId, strCurrPageName);
                   
                    break;
                case "EditTabAndObjectFields":
                    if (string.IsNullOrEmpty( vsTabId_T) == true)
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
        /// WebService的相关类Id
        /// </summary>
        protected string vsWebSrvClassId
        {
            get
            {
                string sWebSrvClassId;
                sWebSrvClassId = (string)ViewState["WebSrvClassId"];
                if (sWebSrvClassId == null)
                {
                    sWebSrvClassId = "";
                }
                return sWebSrvClassId;
            }
            set
            {
                string sWebSrvClassId = value;
                ViewState.Add("WebSrvClassId", sWebSrvClassId);
            }
        }
        
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmWebSrvFunctions_QUDI3.aspx";
            }
        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {                
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
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