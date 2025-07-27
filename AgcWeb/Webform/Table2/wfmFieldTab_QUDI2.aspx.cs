using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CommFunc4WebForm;
using com.taishsoft.commexception;
using com.taishsoft.common;

using com.taishsoft.sql;
using com.taishsoft.commdb;


using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;


namespace AGC.Webform
{

    public partial class wfmFieldTab_QUDI2 : CommWebPageBase
    {
        //定义从外面传来的ObjId(对象ID)
        private string ObjId_qs
        {
            get
            {
                string strObjId = Request.QueryString["ObjId"] ?? "".ToString();
                if ((strObjId != null) && (strObjId != ""))
                {
                    return strObjId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的ObjId(对象ID)
        private string TabId_qs
        {
            get
            {
                string strTabId = Request.QueryString["TabId"] ?? "".ToString();
                if ((strTabId != null) && (strTabId != ""))
                {
                    return strTabId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的FromWebForm(从什么页面传来)
        private string FromWebForm_qs
        {
            get
            {
                string strFromWebForm = Request.QueryString["FromWebForm"] ?? "".ToString();
                if ((strFromWebForm != null) && (strFromWebForm != ""))
                {
                    return strFromWebForm;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(ObjId_qs) == false)
                {
                    new clsCommonSession().ObjId = ObjId_qs;

                    string strTabId = clsPrjTabBLEx.GetTabIdByObjId(ObjId_qs);
                    clsCommonSession.TabId = strTabId;

                    //编辑工程对象
                    //EditPrjObject(ObjId_qs);
                }
                else if (string.IsNullOrEmpty(TabId_qs) == false)
                {
                    clsCommonSession.TabId = TabId_qs;

                    //转换成相关表ID(TabId)
                    //string strObjId = clsPrjTabBLEx.GetObjIdByTabId(TabId_qs);
                    //new clsCommonSession().ObjId = strObjId;


                    //编辑工程对象
                    //EditPrjTab(TabId_qs);
                }
                else if (string.IsNullOrEmpty(FromWebForm_qs) == false)
                {
                }
                else
                {
                    EditTabFieldByObjId(new clsCommonSession().ObjId);
                }
            }
        }

        protected void lbDispObjList_Click(object sender, System.EventArgs e)
        {
            DispObjList();
        }

        private void DispObjList()
        {
            //tabQuery.Visible = true;
            //tabLayout.Visible = false;
        }

        #region "编辑对象相关字段"
        private void EditTabFieldByObjId(string strObjId)
        {
            btnOKUpdFieldTab.Text = "确认修改";
            BindDdl4FieldTabByObj();
            BindGv_FieldTab();
            DispFieldTabListRegion();
            //            ShowFieldTabData(strTabId);

        }
        /// <summary>
        /// 绑定专门用于工程表的下拉框
        /// </summary>
        private void BindDdl4FieldTabByObj()
        {
            wucFieldTab1.SetDdl_PrjId();
            wucFieldTab1.SetDdl_FldType();
            wucFieldTab1.SetDdl_IsNull();
            //				wucFieldTab1.SetDdl_IsPrimaryKey();
            wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);
            wucFieldTab1.SetDdl_CodeTab();
            wucFieldTab1.SetDdl_FldStateId();

            clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
            clsDropDownList.BindDdl_IsNull(ddlIsNull);
            clsDropDownList.BindDdl_IsPrimaryKey(ddlIsPrimaryKey);
            //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId_AddTo, clsPubVar.CurrSelPrjId);

        }

        protected void lbAddNewFld_Click(object sender, EventArgs e)
        {
            wucFieldTab1.Clear();
            wucFieldTab1.SetKeyReadOnly(false);
            wucFieldTab1.PrjId = clsPubVar.CurrSelPrjId;
            
            wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            btnOKUpdFieldTab.Text = "确认添加";

        }
        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //复制字段
            CopyField();
        }
        /// <summary>
        /// 复制字段
        /// </summary>
        private void CopyField()
        {
            //string strMsg;
            //判断是否有选中的对象ID
            string strObjId = new clsCommonSession().ObjId;
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab, "chkCheckRec");
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (string strFldId in objArr)
                {
                    clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    //clsFieldTabBLEx.CopyField2Bak20170705(clsPubVar.CurrSelPrjId, strFldId,
                    // objFieldTabEN.FldName + "_Copy", strObjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "复制字段不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

        }
        protected void lbDelFld_Click(object sender, EventArgs e)
        {
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab, "chkCheckRec");
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in objArr)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    string strJournal = "执行了删除操作，删除表FieldTab! 字段名："
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                       clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                //clsFieldTabBLEx.DelFieldTabEx(objArr);
                foreach (string strFldId in objArr)
                {
                    clsFieldTabBLEx.DelFieldTabBySp(strFldId, new clsCommonSession().ObjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

        }
        protected void lbUpdate_Click(object sender, EventArgs e)
        {
            string strFldID = clsCommForWebForm.GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ShowFieldTabData(strFldID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpdFieldTab, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpdFieldTab.Text = "确认修改";
            DispEditFieldTabRegion();
        }
        protected void lbDelFieldTabEx_Click(object sender, EventArgs e)
        {

        }
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_FieldTab();
        }
        protected void gvFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvFieldTab.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_FieldTab();
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFieldTab.PageIndex = e.NewPageIndex;
                this.BindGv_FieldTab();
            }
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (vsSortFieldTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvFieldTab.Columns.Count; i++)
                {
                    strSortEx = this.gvFieldTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortFieldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortFieldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvFieldTab_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
            DeleteFieldTabRecord(strFldID);
        }
        ///
        protected void gvFieldTab_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
            UpdateFieldTabRecord(strFldID);
        }
        protected void BindGv_FieldTab()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFieldTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            //////设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvFieldTab.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvFieldTab.PageSize = 10;
            }
            this.gvFieldTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvFieldTab.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            if (pagerRow == null) return;
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
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvFieldTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == this.gvFieldTab.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }

            }
        }

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
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
        ///删除记录过程代码for C#
        protected void DeleteFieldTabRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                clsFieldTabBLEx.DelFieldTabBySp(strFldId, new clsCommonSession().ObjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FieldTab();
        }
        ///修改存盘准备过程代码 for C#
        private void UpdateFieldTabRecordSave(clsFieldTabEN objFieldTabEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucFieldTab1.IsValid())
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFieldTabClass(objFieldTabEN);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                //6、把数据实体层的数据存贮到数据库中
                objFieldTabEN.UpdateRecordEx();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "修改记录成功!";
            wucFieldTab1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpdFieldTab.Text = "添加";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_FieldTab();
            DispFieldTabListRegion();
        }
        private void UpdateFieldTabRecord(string strFldID)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowFieldTabData(strFldID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpdFieldTab, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpdFieldTab.Text = "确认修改";
            lblMsg.Text = "";
            DispEditFieldTabRegion();
        }
        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineFieldTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            strWhereCond += " and PrjId='" + clsPubVar.CurrSelPrjId + "'";
            strWhereCond += " and Fldid in (select fldid from FldObjTab where ObjId='" + new clsCommonSession().ObjId + "')";

            return strWhereCond;
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strFldID">表记录的关键字，显示该表关键字的内容</param>
        private void ShowFieldTabData(string strFldID)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFldID == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsFieldTabBL.IsExist(strFldID) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strFldID + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldID);
            //4、获取类对象的所有属性；
            clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            Session.Add("objFieldTabEN", objFieldTabEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromFieldTabClass(objFieldTabEN);
        }
        private void DispFieldTabListRegion()
        {

            tabEditTabField.Visible = false;
        }
        private void DispEditFieldTabRegion()
        {

            tabEditTabField.Visible = true;
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjFieldTab">数据传输的目的类对象</param>
        private void PutDataToFieldTabClass(clsFieldTabEN pobjFieldTab)
        {
            pobjFieldTab.FldId = wucFieldTab1.FldId;
            pobjFieldTab.PrjId = wucFieldTab1.PrjId;
            pobjFieldTab.FldName = wucFieldTab1.FldName;
            pobjFieldTab.DataTypeId = wucFieldTab1.DataTypeId;
            pobjFieldTab.FldLength = wucFieldTab1.FldLength;
            pobjFieldTab.Caption = wucFieldTab1.Caption;
            pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
            pobjFieldTab.IsNull = wucFieldTab1.IsNull;
            pobjFieldTab.IsPrimaryKey = wucFieldTab1.IsPrimaryKey;
            pobjFieldTab.IsIdentity = wucFieldTab1.IsIdentity;
            pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
            pobjFieldTab.MinValue = wucFieldTab1.MinValue;
            pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
            //pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            //pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            //pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
            pobjFieldTab.UpdUser = wucFieldTab1.UserId;
            pobjFieldTab.FldStateId = wucFieldTab1.FldStateId;
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjFieldTab">数据传输的目的类对象</param>
        private void PutDataToFieldTabClass2(clsFieldTabEN pobjFieldTab)
        {
            pobjFieldTab.PrjId = clsPubVar.CurrSelPrjId;
            pobjFieldTab.FldName = FldName;
            pobjFieldTab.DataTypeId = DataTypeId;
            pobjFieldTab.FldLength = FldLength;
            pobjFieldTab.Caption = Caption;
            //			pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
            pobjFieldTab.IsNull = IsNull;
            pobjFieldTab.IsPrimaryKey = IsPrimaryKey;
            //			pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
            //			pobjFieldTab.MinValue = wucFieldTab1.MinValue;
            //			pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
            //			pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //			pobjFieldTab.CodeTab = wucFieldTab1.CodeTab;
            //			pobjFieldTab.CodeTabName = wucFieldTab1.CodeTabName;
            //			pobjFieldTab.CodeTabCode = wucFieldTab1.CodeTabCode;
            pobjFieldTab.UpdDate = wucFieldTab1.getTodayStr(0);
            pobjFieldTab.UpdUser = clsCommonSession.UserId;
            pobjFieldTab.FldStateId = "01";
            //			pobjFieldTab.AppliedScope = wucFieldTab1.AppliedScope;
        }

        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjFieldTab">表实体类对象</param>
        private void GetDataFromFieldTabClass(clsFieldTabEN pobjFieldTab)
        {
            wucFieldTab1.FldId = pobjFieldTab.FldId;
            wucFieldTab1.PrjId = pobjFieldTab.PrjId;
            wucFieldTab1.FldName = pobjFieldTab.FldName;
            wucFieldTab1.DataTypeId = pobjFieldTab.DataTypeId;
            wucFieldTab1.FldLength = pobjFieldTab.FldLength;
            wucFieldTab1.Caption = pobjFieldTab.Caption;
            wucFieldTab1.FldInfo = pobjFieldTab.FldInfo;
            wucFieldTab1.IsNull = pobjFieldTab.IsNull;
            wucFieldTab1.IsPrimaryKey = pobjFieldTab.IsPrimaryKey;
            wucFieldTab1.IsIdentity = pobjFieldTab.IsIdentity;
            wucFieldTab1.MaxValue = pobjFieldTab.MaxValue;
            wucFieldTab1.MinValue = pobjFieldTab.MinValue;
            wucFieldTab1.DefaultValue = pobjFieldTab.DefaultValue;
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                wucFieldTab1.IsNeedTransCode = true;
                wucFieldTab1.CodeTabId = objFieldTab4CodeConv.CodeTabId;
                wucFieldTab1.CodeTabNameId = objFieldTab4CodeConv.CodeTabNameId;
                wucFieldTab1.CodeTabCodeId = objFieldTab4CodeConv.CodeTabCodeId;
            }
            wucFieldTab1.FldStateId = pobjFieldTab.FldStateId;

            ///设置对象列表
            List<ObjStruct> arrLst = new List<ObjStruct>();
            string strCondition = string.Format("{0} = '{1}'",
               convPrjTabFld.FldId,
               pobjFieldTab.FldId);

            List<clsvPrjTabFldEN> arrvPrjTabFldLst = clsvPrjTabFldBL.GetObjLst(strCondition);
            ObjStruct objStruct;
            if (arrvPrjTabFldLst.Count > 0)
            {
                foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldLst)
                {
                    objStruct.strObjId = objvPrjTabFldEN.TabId;
                    objStruct.strObjName = objvPrjTabFldEN.TabName;
                    arrLst.Add(objStruct);
                }
                wucFieldTab1.TabList = arrLst;
            }
        }
        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFieldTab.PageCount)
                {
                    this.gvFieldTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FieldTab();
            }
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
                    PageSize = intPageSize.ToString();
                    BindGv_FieldTab();
                }
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvFieldTab_RowCommand(object sender, GridViewCommandEventArgs e)
        {
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
                        Set_GridViewAllChecked(gvFieldTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        Set_GridViewAllChecked(gvFieldTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }
        
        protected void gvFieldTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortFieldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
                BindGv_FieldTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortFieldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortFieldTabBy = e.SortExpression + " Desc";
            }
            BindGv_FieldTab();
        }
        protected void lbInsNewRec_Click(object sender, System.EventArgs e)
        {
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
            //2、定义对象并初始化对象

            string strMsg;
            string strFldId;
            lblMsg4AddRecord.Text = "";
            clsFieldTabEN objFieldTabEN;
            strFldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            objFieldTabEN = new clsFieldTabEN(strFldId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //检查是否存在相同字段名
            string strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                          clsPubVar.CurrSelPrjId, FldName, DataTypeId);
            if (clsFieldTabBL.IsExistRecord(strCondition))	//判断是否有相同的关键字
            {
                strMsg = "在当前工程中已存在相同的字段名称，请重新换一个字段名称!";
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                strFldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, FldName, DataTypeId);
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(clsCommonSession.TabId, strFldId, clsCommonSession.UserId);
                BindGv_FieldTab();
                return;
            }

            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFieldTabClass2(objFieldTabEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }
            try
            {
                //6、把数据实体层的数据存贮到数据库中
                if (objFieldTabEN.AddRecordEx() == false)
                {
                    strMsg = "添加不成功!";
                    //                clsCommonJsFunc.Alert(this, strMsg);
                    lblMsg.Text = "添加记录不成功!";
                }
                else
                {
                    lblMsg.Text = "添加记录成功!";
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(clsCommonSession.TabId, strFldId, clsCommonSession.UserId);
                    //				}
                }
                //7、把新添的记录内容显示在DATAGRID中
                BindGv_FieldTab();
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }
            wucFieldTab1.Clear();		//清空控件中内容
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //删除记录;
                string strTableName = "FieldTab";
                string strTableKey = objFieldTabEN.FldId;
                string strJournal = "执行了添加操作，添加表FieldTab! 字段名："
                    + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                
                bool IsSuccesful = true;
                IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                    strUserIp,
                    strOperationType,
                    strTableName,
                    strTableKey,
                    strJournal,
                    clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录的添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


            ///恢复<确认添加>变成<添加>
            //			btnOKUpd.Text = "添加";
            //			tabLayout.Visible = false;
            //			tabQuery.Visible = true;

        }
        public string FldName
        {
            get
            {
                return txtFldName.Text.Trim();
            }
            set
            {
                txtFldName.Text = value.ToString();
            }
        }

        public string DataTypeId
        {
            get
            {
                if (ddlFldType.SelectedValue == "0")
                {
                    return "";
                }
                return ddlFldType.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFldType.SelectedValue = "0";
                }
                else
                {
                    ddlFldType.SelectedValue = value;
                }
            }
        }

        public int FldLength
        {
            get
            {
                return int.Parse(txtFldLength.Text.Trim());
            }
            set
            {
                txtFldLength.Text = value.ToString();
            }
        }

        public string Caption
        {
            get
            {
                return txtCaption.Text.Trim();
            }
            set
            {
                txtCaption.Text = value.ToString();
            }
        }
        public bool IsNull
        {
            get
            {
                if (ddlIsNull.SelectedItem.Text == "是")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsNull.SelectedValue = "是";
                }
                else
                {
                    ddlIsNull.SelectedValue = "否";
                }
            }
        }

        public bool IsPrimaryKey
        {
            get
            {
                if (ddlIsPrimaryKey.SelectedItem.Text == "是")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsPrimaryKey.SelectedValue = "是";
                }
                else
                {
                    ddlIsPrimaryKey.SelectedValue = "否";
                }
            }
        }
        protected void lbDispFieldList_Click(object sender, System.EventArgs e)
        {


        }

        protected void lbAddToObj_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            if (ddlTabId_AddTo.SelectedIndex == 0)
            {
                strMsg = "请选择一个对象!";
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = "请选择一个对象!";
                return;
            }
            string strTabId = ddlTabId_AddTo.SelectedValue.ToString();
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab, "chkCheckRec");
            try
            {

                //clsFieldTabBLEx.DelFieldTabEx(objArr);
                foreach (string strFldId in objArr)
                {
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, clsCommonSession.UserId);
                }
                //clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "建立对象、字段关系不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "把字段添加到对象成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = strMsg;
            //BindGv_FieldTab();
        }

        protected void btnOKUpdFieldTab_Click(object sender, EventArgs e)
        {

            string strMsg;	//专门用于传递信息的变量
            string strCommandText;
            clsFieldTabEN objFieldTabEN;

            List<ObjStruct> arrObjStructLst;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;

            switch (strCommandText)
            {
                case "添加":
                    wucFieldTab1.SetKeyReadOnly(false);
                    wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    btnOKUpdFieldTab.Text = "确认添加";
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
                    if (!wucFieldTab1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    //clsFieldTabEN objFieldTabEN;	//定义对象
                    objFieldTabEN = new clsFieldTabEN(wucFieldTab1.FldId);	//初始化新对象
                
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//判断是否有相同的关键字
                    {
                        strMsg = "关键字字段已有相同的值";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToFieldTabClass(objFieldTabEN);		//把界面的值传到
                    //5、检查传进去的对象属性是否合法
                    ///
                    try
                    {
                        clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    if (objFieldTabEN.AddRecordEx() == false)
                    {
                        strMsg = "添加不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "添加记录不成功!";
                    }
                    else
                    {
                        strMsg = "添加记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "添加记录成功!";
                        arrObjStructLst = wucFieldTab1.TabList;
                        List<string> arrTarTabIdLst = new List<string>();
                        foreach (ObjStruct objTab in arrObjStructLst)
                        {
                            arrTarTabIdLst.Add(objTab.strObjId);
                        }
                        clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);

                    }
                    //7、把新添的记录内容显示在DATAGRID中
                    BindGv_FieldTab();
                    wucFieldTab1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpdFieldTab.Text = "添加";
                    DispFieldTabListRegion();
                    try
                    {
                        //添加日志
                        string strUserId = clsCommonSession.UserId;
                        string strUserIp = Request.UserHostAddress;
                        string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                        string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //删除记录;
                        string strTableName = "FieldTab";
                        string strTableKey = objFieldTabEN.FldId;
                        string strJournal = "执行了添加操作，添加表FieldTab! 字段名："
                            + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                        
                        bool IsSuccesful = true;
                        IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                            strUserIp,
                            strOperationType,
                            strTableName,
                            strTableKey,
                            strJournal,
                            clsPubVar.CurrSelPrjId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = "添加记录的添加日志不成功!\r\n" + objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

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
                    if (!wucFieldTab1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objFieldTabEN = (clsFieldTabEN)Session["objFieldTabEN"];
                    if (clsFieldTabBLEx.IsCanDelUpd(objFieldTabEN.FldId) == false)
                    {
                        strMsg = "该记录已核实或归档，不能修改!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "该记录已核实或归档，不能修改!";
                        //return ;
                    }
                    else
                    {
                        PutDataToFieldTabClass(objFieldTabEN);		//把界面的值传到
                        //3、检查传进去的对象属性是否合法
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                        //4、把数据实体层的数据修改同步到数据库中
                        try
                        {
                            if (objFieldTabEN.UpdateRecordEx() == false)
                            {
                                strMsg = "修改记录不成功!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "修改记录不成功!";
                            }
                            else
                            {
                                strMsg = "修改记录成功!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "修改记录成功!";
                 
                                arrObjStructLst = wucFieldTab1.TabList;
                                List<string> arrTarTabIdLst = new List<string>();
                                foreach (ObjStruct objTab in arrObjStructLst)
                                {
                                    arrTarTabIdLst.Add(objTab.strObjId);
                                }
                                clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);

                            }
                            //5、把修改后的内容显示在DATAGRID中
                            BindGv_FieldTab();
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                        wucFieldTab1.Clear();//添空控件中的内容
                    }
                    //恢复<确认修改>变成<添加>
                    btnOKUpdFieldTab.Text = "添加";
                    DispFieldTabListRegion();
                    try
                    {
                        //添加日志
                        string strUserId = clsCommonSession.UserId;
                        string strUserIp = Request.UserHostAddress;
                        string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                        string strOperationType = clsOperationTypeBLEx.UPDATE_RECORD; //删除记录;
                        string strTableName = "FieldTab";
                        string strTableKey = objFieldTabEN.FldId;
                        string strJournal = "执行了修改操作，修改表FieldTab! 字段名："
                            + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                        
                        bool IsSuccesful = true;
                        IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                            strUserIp,
                            strOperationType,
                            strTableName,
                            strTableKey,
                            strJournal,
                            clsPubVar.CurrSelPrjId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = "修改记录添加日志不成功!\r\n" + objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    break;
            }
        }
        #endregion
        private void CheckField()
        {
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTabByCodeTab(objFieldTabEN);
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
    }
}