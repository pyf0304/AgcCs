
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmCmFuncParaIdB_QUDI
表名:CMFuncPara
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:46
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using AGC.Entity;
using AGC.BusinessLogic;
using AGC.FunClass;

using AGC.BusinessLogicEx;

using System.Linq;

namespace AGC.Webform
{
    /// <summary>
    /// wfmCMFuncPara_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmCMFuncPara_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "函数参数4Code维护";
                vsTabName = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":
                        Response.Redirect("../error.aspx");
                        break;
                    case "2":
                        Response.Redirect("../error.aspx");
                        break;
                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }


                //1、为下拉框设置数据源,绑定列表数据
                wucCMFuncPara1.SetDdl_CmFunctionId();
                wucCMFuncPara1.SetDdl_DataTypeId();
                clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlDataTypeIdq);
                clsCMFunctionBLEx.BindDdl_CmFunctionIdEx(ddlCmFunctionIdq);
                clsCMFunctionBLEx.BindDdl_CmFunctionIdEx(ddlCmFunctionId);
                vsSortCMFuncParaBy = string.Format("{0} Asc", conCMFuncPara.ParaName);
                //2、显示无条件的表内容在GridView中
                BindGv_CMFuncPara();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucCMFuncPara1.SetKeyReadOnly(true);
                DispCMFuncParaListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsCMFuncParaBL.objCommFun4BL = new clsCommFun4BL4CMFuncPara();
                if (string.IsNullOrEmpty(qsCmFunctionId) == false)
                {
                    clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionIdCache(qsCmFunctionId);
                    lblCMFuncParaList.Text = string.Format("<red>[{0}]</red>的参数列表",
                        objCMFunctionEN.FunctionName);
                }
            }
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvCMFuncPara.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_CMFuncPara();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_CMFuncPara()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineCMFuncParaCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvCMFuncParaBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI000001)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortCMFuncParaBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                                ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvCMFuncPara.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvCMFuncPara.PageSize = 10;
            }
            this.gvCMFuncPara.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvCMFuncPara.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvCMFuncPara.BottomPagerRow;
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
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvCMFuncPara.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvCMFuncPara.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvCMFuncPara.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvCMFuncPara.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvCMFuncPara.PageIndex == this.gvCMFuncPara.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
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
            gvCMFuncPara.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvCMFuncPara.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvCMFuncPara.PageCount)
                {
                    this.gvCMFuncPara.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_CMFuncPara();
            }
        }


        /// <summary>
        /// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
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
                    BindGv_CMFuncPara();
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFuncPara_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvCMFuncPara, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvCMFuncPara, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFuncPara_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortCMFuncParaBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvCMFuncPara.Columns.Count; i++)
                {
                    strSortEx = this.gvCMFuncPara.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortCMFuncParaBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = vsSortCMFuncParaBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序,而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvCMFuncPara_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvCMFuncPara.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_CMFuncPara();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineCMFuncParaCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            //string strWhereCond = string.Format(" 1 = 1 and {0}='0' and {1}='0'", 
            //    convCMFuncPara.IsAsyncFunc,
            //    convCMFuncPara.IsSysFunction);

            string strWhereCond = string.Format(" 1 = 1 ");
            
            if (qsFuncTypeId == enumFunctionType.ExGCFunc_13 && chkIsLimitedCurrPrjId.Checked == true)
            {
                strWhereCond += string.Format(" and {0} = '{1}' ", convCMFuncPara.PrjId, clsPubVar.CurrSelPrjId);
            }
            else
            {
                strWhereCond += string.Format(" and {0} Not In (Select {0} From {1} Where {2} = '{3}') ", 
                    convCMFuncPara.ParaName,
                    clsvCMFuncParaEN._CurrTabName,
                    convCMFuncPara.PrjId,
                    clsPubVar.CurrSelPrjId);
            }
            //if (string.IsNullOrEmpty(qsCmFunctionId) == false)
            //{
            //    strWhereCond += string.Format(" and {0}='{1}'",
            //        conCMFuncPara.CmFunctionId,
            //          qsCmFunctionId);
            //}
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
            try
            {
                if (this.ddlDataTypeIdq.SelectedValue != "" && this.ddlDataTypeIdq.SelectedValue != "0")
                {
                    objvCMFuncParaEN.DataTypeId = this.ddlDataTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMFuncPara.DataTypeId, this.ddlDataTypeIdq.SelectedValue);
                }
                if (this.txtParameterTypeq.Text.Trim() != "")
                {
                    objvCMFuncParaEN.ParameterType = this.txtParameterTypeq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMFuncPara.ParameterType, this.txtParameterTypeq.Text.Trim());
                }
                if (this.txtParaNameq.Text.Trim() != "")
                {
                    objvCMFuncParaEN.ParaName = this.txtParaNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMFuncPara.ParaName, this.txtParaNameq.Text.Trim());
                }
                //if (this.txtFuncNameq.Text.Trim() != "")
                //{
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMFuncPara.FunctionName, this.txtFuncNameq.Text.Trim());
                //}
                //if (this.ddlCmFunctionIdq.SelectedValue != "" && this.ddlCmFunctionIdq.SelectedValue != "0")
                //{
                //    objvCMFuncParaEN.CmFunctionId = this.ddlCmFunctionIdq.SelectedValue;
                //    strWhereCond += string.Format(" And {0} = '{1}'", convCMFuncPara.CmFunctionId, this.ddlCmFunctionIdq.SelectedValue);
                //}
                clsvCMFuncParaBL.CheckProperty4Condition(objvCMFuncParaEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineCMFuncParaCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
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

        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFuncPara_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortCMFuncParaBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortCMFuncParaBy = e.SortExpression + " Asc";
                BindGv_CMFuncPara();
                return;
            }
            //检查原来是升序
            intIndex = vsSortCMFuncParaBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortCMFuncParaBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortCMFuncParaBy = e.SortExpression + " Desc";
            }
            BindGv_CMFuncPara();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortCMFuncParaBy
        {
            get
            {
                string sSortCMFuncParaBy;
                sSortCMFuncParaBy = (string)ViewState["SortCMFuncParaBy"];
                if (sSortCMFuncParaBy == null)
                {
                    sSortCMFuncParaBy = "";
                }
                return sSortCMFuncParaBy;
            }
            set
            {
                string sSortCMFuncParaBy = value;
                ViewState.Add("SortCMFuncParaBy", sSortCMFuncParaBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddCMFuncParaRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddCMFuncParaRecord()
        {
            wucCMFuncPara1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelCMFuncParaEdit.Text = "取消添加";
            wucCMFuncPara1.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
            if (string.IsNullOrEmpty(qsCmFunctionId) == false)
            {
                wucCMFuncPara1.CmFunctionId = qsCmFunctionId;
            }
            DispEditCMFuncParaRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMFuncParaRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsCMFuncParaEN objCMFuncParaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMFuncPara1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMFuncParaEN objCMFuncParaEN;	//定义对象
            objCMFuncParaEN = new clsCMFuncParaEN(wucCMFuncPara1.CmFuncParaId);  //初始化新对象
                                                                                              //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFuncParaClass(objCMFuncParaEN);        //把界面的值传到
                                                                    //5.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFuncParaBL.CheckPropertyNew(objCMFuncParaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsCMFuncParaBL.AddNewRecordBySql2(objCMFuncParaEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_CMFuncPara();
            DispCMFuncParaListRegion();
            wucCMFuncPara1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFuncParaEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMFuncParaRecordSaveV5()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsCMFuncParaEN objCMFuncParaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMFuncPara1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000006)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMFuncParaEN objCMFuncParaEN;	//定义对象
            objCMFuncParaEN = new clsCMFuncParaEN(wucCMFuncPara1.CmFuncParaId);  //初始化新对象
                                                                                              //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000007)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFuncParaClass(objCMFuncParaEN);        //把界面的值传到
                                                                    //5.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFuncParaBL.CheckPropertyNew(objCMFuncParaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsCMFuncParaBL.AddNewRecordBySql2(objCMFuncParaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI000008)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_CMFuncPara();
            DispCMFuncParaListRegion();
            wucCMFuncPara1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFuncParaEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstCmFuncParaId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvCMFuncPara, "CmFuncParaId");
            if (lstCmFuncParaId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI000009)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strCmFuncParaId = lstCmFuncParaId[0];
            UpdateCMFuncParaRecord(strCmFuncParaId);
        }
        ///
        protected void gvCMFuncPara_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strCmFuncParaId = gvCMFuncPara.DataKeys[e.RowIndex]["CmFuncParaId"].ToString();
            UpdateCMFuncParaRecord(strCmFuncParaId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strCmFuncParaId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strCmFuncParaId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strCmFuncParaId == "") return;     //如果关键字为空就返回退出
                                                      //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsCMFuncParaBL.IsExist(strCmFuncParaId) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[CMFuncPara]中,关键字为:[strCmFuncParaId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN(strCmFuncParaId);
            //4、获取类对象的所有属性；
            try
            {
                clsCMFuncParaBL.GetCMFuncPara(ref objCMFuncParaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objCMFuncParaEN", objCMFuncParaEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMFuncParaClass(objCMFuncParaEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMFuncParaEN">表实体类对象</param>
        protected void GetDataFromCMFuncParaClass(clsCMFuncParaEN pobjCMFuncParaEN)
        {
            wucCMFuncPara1.CmFuncParaId = pobjCMFuncParaEN.CmFuncParaId;// CmFuncParaId
            wucCMFuncPara1.ParaName = pobjCMFuncParaEN.ParaName;// 参数名
            wucCMFuncPara1.ParaCnName = pobjCMFuncParaEN.ParaCnName;// 参数中文名
            //wucCMFuncPara1.CmFunctionId = pobjCMFuncParaEN.CmFunctionId;// 函数Id4Code
            wucCMFuncPara1.DataTypeId = pobjCMFuncParaEN.DataTypeId;// 数据类型Id
            wucCMFuncPara1.ParameterType = pobjCMFuncParaEN.ParameterType;// 参数类型
            wucCMFuncPara1.ParameterTypeFullName = pobjCMFuncParaEN.ParameterTypeFullName;// 参数类型全名
            wucCMFuncPara1.IsByRef = pobjCMFuncParaEN.IsByRef;// 是否引用型参数            
            wucCMFuncPara1.Memo = pobjCMFuncParaEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateCMFuncParaRecord(string strCmFuncParaId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strCmFuncParaId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucCMFuncPara1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelCMFuncParaEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditCMFuncParaRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objCMFuncParaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMFuncParaRecordSave(clsCMFuncParaEN objCMFuncParaEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucCMFuncPara1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFuncParaClass(objCMFuncParaEN);        //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFuncParaBL.CheckPropertyNew(objCMFuncParaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsCMFuncParaBL.UpdateBySql2(objCMFuncParaEN);
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
            //5、把修改后的内容显示在GridView中
            BindGv_CMFuncPara();
            DispCMFuncParaListRegion();
            wucCMFuncPara1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFuncParaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMFuncPara{0}'", objCMFuncParaEN.CmFuncParaId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objCMFuncParaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMFuncParaRecordSaveV5(clsCMFuncParaEN objCMFuncParaEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucCMFuncPara1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000012)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFuncParaClass(objCMFuncParaEN);        //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFuncParaBL.CheckPropertyNew(objCMFuncParaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsCMFuncParaBL.UpdateBySql2(objCMFuncParaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_CMFuncPara();
            DispCMFuncParaListRegion();
            wucCMFuncPara1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFuncParaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMFuncPara{0}'", objCMFuncParaEN.CmFuncParaId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsCMFuncParaEN objCMFuncParaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMFuncParaRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMFuncParaRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objCMFuncParaEN = (clsCMFuncParaEN)Session["objCMFuncParaEN"];
                    UpdateCMFuncParaRecordSave(objCMFuncParaEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelCMFuncParaEdit_Click(object sender, EventArgs e)
        {
            DispCMFuncParaListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjCMFuncParaEN">数据传输的目的类对象</param>
        protected void PutDataToCMFuncParaClass(clsCMFuncParaEN pobjCMFuncParaEN)
        {
            pobjCMFuncParaEN.CmFuncParaId = wucCMFuncPara1.CmFuncParaId;// CmFuncParaId
            pobjCMFuncParaEN.ParaName = wucCMFuncPara1.ParaName;// 参数名
            pobjCMFuncParaEN.ParaCnName = wucCMFuncPara1.ParaCnName;// 参数中文名
            //pobjCMFuncParaEN.CmFunctionId = wucCMFuncPara1.CmFunctionId;// 函数Id4Code
            pobjCMFuncParaEN.DataTypeId = wucCMFuncPara1.DataTypeId;// 数据类型Id
            pobjCMFuncParaEN.ParameterType = wucCMFuncPara1.ParameterType;// 参数类型
            pobjCMFuncParaEN.ParameterTypeFullName = wucCMFuncPara1.ParameterTypeFullName;// 参数类型全名
            pobjCMFuncParaEN.IsByRef = wucCMFuncPara1.IsByRef;// 是否引用型参数
            pobjCMFuncParaEN.PrjId = clsPubVar.CurrSelPrjId;// 是否引用型参数

            pobjCMFuncParaEN.UpdDate = wucCMFuncPara1.UpdDate;// 修改日期
            pobjCMFuncParaEN.UpdUser = wucCMFuncPara1.UpdUser;// 修改者
            pobjCMFuncParaEN.Memo = wucCMFuncPara1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstCmFuncParaId = clsCommForWebForm.GetAllCheckedItemFromGv(gvCMFuncPara, "chkCheckRec", "CmFuncParaId");
            if (lstCmFuncParaId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI000013)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strCmFuncParaId in lstCmFuncParaId)
                {
                    clsCMFuncParaBL.DelRecord(strCmFuncParaId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_CMFuncPara();
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFuncPara_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strCmFuncParaId = gvCMFuncPara.DataKeys[e.RowIndex]["CmFuncParaId"].ToString();
            DeleteCMFuncParaRecord(strCmFuncParaId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strCmFuncParaId">给定关键字</param>
        protected void DeleteCMFuncParaRecord(string strCmFuncParaId)
        {
            try
            {
                clsCMFuncParaBL.DelRecord(strCmFuncParaId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_CMFuncPara();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }


        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vCMFuncPara]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineCMFuncParaCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "CMFuncPara信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convCMFuncPara.CmFuncParaId); arrCnName.Add("CmFuncParaId");
            arrColName.Add(convCMFuncPara.ParaName); arrCnName.Add("参数名");
            arrColName.Add(convCMFuncPara.ParaCnName); arrCnName.Add("参数中文名");
            //arrColName.Add(convCMFuncPara.CmFunctionId); arrCnName.Add("函数Id4Code");
            //arrColName.Add(convCMFuncPara.FunctionName); arrCnName.Add("函数名4Code");
            //arrColName.Add(convCMFuncPara.FunctionSignature); arrCnName.Add("函数签名");
            arrColName.Add(convCMFuncPara.DataTypeId); arrCnName.Add("数据类型Id");
            arrColName.Add(convCMFuncPara.DataTypeName); arrCnName.Add("数据类型名称");
            arrColName.Add(convCMFuncPara.DataCnName); arrCnName.Add("数据类型中文名称");
            arrColName.Add(convCMFuncPara.CsType); arrCnName.Add("CS类型");
            arrColName.Add(convCMFuncPara.JavaType); arrCnName.Add("JAVA类型");
            arrColName.Add(convCMFuncPara.JavaObjType); arrCnName.Add("JAVA对象类型");
            arrColName.Add(convCMFuncPara.SwiftType); arrCnName.Add("SwiftType");
            arrColName.Add(convCMFuncPara.IsNeedQuote); arrCnName.Add("是否需要引号");
            arrColName.Add(convCMFuncPara.OraDbType); arrCnName.Add("Ora数据类型");
            arrColName.Add(convCMFuncPara.MySqlType); arrCnName.Add("MySqlType");
            arrColName.Add(convCMFuncPara.ParameterType); arrCnName.Add("参数类型");
            arrColName.Add(convCMFuncPara.ParameterTypeFullName); arrCnName.Add("参数类型全名");
            arrColName.Add(convCMFuncPara.IsByRef); arrCnName.Add("是否引用型参数");
            arrColName.Add(convCMFuncPara.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convCMFuncPara.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convCMFuncPara.Memo); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvCMFuncParaBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditCMFuncParaRegion()
        {
            divList.Visible = false;
            tabEditCMFuncParaRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispCMFuncParaListRegion()
        {
            divList.Visible = true;
            tabEditCMFuncParaRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
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


        /// <summary>
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
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

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// QueryString属性:通过QueryString传递过来的CMFuncPara参数。
        /// 姓名:潘以锋
        /// 日期:2018-3-4
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        private string qsCmFunctionId
        {
            get
            {
                string strCmFunctionId = Request.QueryString["CmFunctionId"] ?? "".ToString();
                if ((strCmFunctionId != null) && (strCmFunctionId != ""))
                {
                    return strCmFunctionId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
        /// </summary>
        protected string seUserId
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
        ///if (pobjUser == null) 
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



        #endregion 权限处理函数

        protected void btnReturnParent_Click(object sender, EventArgs e)
        {
            string strHtml = string.Format("wfmCMFunctionB_QUDI.aspx?");
            Response.Redirect(strHtml);
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstCmFuncParaId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvCMFuncPara, "CmFuncParaId");
            if (lstCmFuncParaId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strCmFuncParaId = lstCmFuncParaId[0];
            {
                //string[] strKeys = strFuncId4GC.Split(',');
                //string strFeatureId = strKeys[0];
                try
                {
                    clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBLEx.CloneRecord(strCmFuncParaId, clsCommonSession.UserId);
                    UpdateCMFuncParaRecord(objCMFuncParaEN.CmFuncParaId);
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            //            string strWhereCond = CombineCMFuncParaCondition();
//            BindGv_CMFuncPara();

        }

        protected void btnCopyTo_Click(object sender, EventArgs e)
        {
            
        }
        protected void btnAccessSamePara_Click(object sender, EventArgs e)
        {
            List<clsCMFuncParaEN> arrCMFuncPara = clsCMFuncParaBL.GetObjLst("1=1").OrderByDescending(x => x.CmFuncParaId).ToList();
            foreach (clsCMFuncParaEN objInFor in arrCMFuncPara)
            {
                clsCMFuncParaEN objInFor_Cond = new clsCMFuncParaEN();
                string strCondition = objInFor_Cond.SetParaName(objInFor.ParaName, "=")
                    .SetDataTypeId(objInFor.DataTypeId, "=")
                    .SetParameterType(objInFor.ParameterType, "=")
                    .SetCmFuncParaId(objInFor.CmFuncParaId, "<>")
                    .GetCombineCondition();

                IEnumerable<clsCMFuncParaEN> arrCMFuncPara_Find = clsCMFuncParaBL.GetObjLst(strCondition).OrderBy(x => x.CmFuncParaId);
                if (arrCMFuncPara_Find.Count() > 0)
                {
                    clsCMFuncParaEN objCMFuncPara_First = arrCMFuncPara_Find.First();
                    strCondition = string.Format("{0}='{1}'", conCMFuncParaRela.CmFuncParaId, objInFor.CmFuncParaId);
                    List<clsCMFuncParaRelaEN> arrCMFuncParaRela_Upd = clsCMFuncParaRelaBL.GetObjLst(strCondition);
                    arrCMFuncParaRela_Upd.ForEach(x => x.SetCmFuncParaId(objCMFuncPara_First.CmFuncParaId).Update());
                    clsCMFuncParaBL.DelRecord(objInFor.CmFuncParaId);

                }
            }
        }

        protected void gvCMFuncPara_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView drv = (DataRowView)e.Row.DataItem;
                //DataRow objDR = (DataRow)e.Row.DataItem ;

                clsvCMFuncParaEN objCurr = clsvCMFuncParaBL.GetObjByDataRow_S(drv);//.DataItem
            
                    int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvCMFuncPara,
                       convCMFuncPara.ParaName);
                if (objCurr.ParaCnName != objCurr.ParaName)
                {
                    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.ParaName, objCurr.ParaCnName);
                }

                intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvCMFuncPara,
                       convCMFuncPara.DataTypeName);
                if (objCurr.DataCnName != objCurr.DataTypeName)
                {
                    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.DataTypeName, objCurr.DataCnName);
                }

            }
        }
        /// <summary>
        /// 函数类型
        /// </summary>
        private string qsFuncTypeId
        {
            get
            {
                string strFuncTypeId = Request.QueryString["FuncTypeId"] ?? "".ToString();
                if ((strFuncTypeId != null) && (strFuncTypeId != ""))
                {
                    return strFuncTypeId;
                }
                else
                {
                    return "";
                }
            }
        }

        protected void btnCopyToCurrPrjId_Click(object sender, EventArgs e)
        {
            List<string> lstCmFuncParaId = clsCommForWebForm.GetAllCheckedItemFromGv(gvCMFuncPara, "chkCheckRec", "CmFuncParaId");
            if (lstCmFuncParaId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI000013)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strCmFuncParaId in lstCmFuncParaId)
                {
                    clsCMFuncParaEN objCMFuncPara = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);
                    objCMFuncPara.SetPrjId ( clsPubVar.CurrSelPrjId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId);
                    objCMFuncPara.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();

                    string strCondition = objCMFuncPara.GetUniCondStr();
                    if (clsCMFuncParaBL.IsExistRecord(strCondition) == false)
                    {
                        objCMFuncPara.AddNewRecord();
                    }
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_CMFuncPara();
        }
    }
}