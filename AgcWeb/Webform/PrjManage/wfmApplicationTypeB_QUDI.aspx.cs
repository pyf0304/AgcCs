
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;

using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

///----------------------
///生成代码版本：2013.04.17.1
///生成日期：2014/06/09
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：工程管理
///模块英文名：PrjManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2013.11.06.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2013.11.08.1
///========================
///生成查询，修改，删除，添加记录的控制层代码


namespace AGC.Webform
{
    /// <summary>
    /// wfmApplicationTypeB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmApplicationTypeB_QUDI : CommWebPageBase
    {

        //生成有关的变量定义代码
        /// <summary>
        /// 当前操作的界面功能名称
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
        /// 当前操作的导出表名称
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
        /// 通过QueryString传递过来的UserId参数。这里是样例，大家可以参考这个样例。
        /// 姓名：
        /// 日期：
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
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                //clsApplicationTypeBL.onAddNewRecord += ClsApplicationTypeBL_myAddNewRecord;
                vsViewName = "应用程序类型维护";
                vsTabName = "ApplicationType";
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
                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeIdq);
                wucApplicationTypeB1.SetDdl_ProgLangTypeId();
                wucApplicationTypeB1.SetDdl_ProgLangTypeId2();
                wucApplicationTypeB1.SetDdl_ProgLangTypeId3();
                wucApplicationTypeB1.SetDdl_ProgLangTypeId4();

                //1、为下拉框设置数据源，绑定列表数据
                strSortApplicationTypeBy = string.Format("{0} Asc", conApplicationType.OrderNum);
                //2、显示无条件的表内容在DATAGRID中
                BindGv_ApplicationType();
                //3、设置表控件中字控件的ReadOnly属性，
                // 使之只读，因为在修改功能中关键字是不能被修改的。
                wucApplicationTypeB1.SetKeyReadOnly(true);
                DispApplicationTypeListRegion();
            }
        }

        private void ClsApplicationTypeBL_myAddNewRecord(object objNewObject4Add)
        {
            clsApplicationTypeEN objApplicationTypeEN = objNewObject4Add as clsApplicationTypeEN;
            clsCommonJsFunc.Alert(this, objApplicationTypeEN.ApplicationTypeName);
            //throw new NotImplementedException();
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
            this.gvApplicationType.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_ApplicationType();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvApplicationType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvApplicationType.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_ApplicationType();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　 在这里是把值传到表控件中
        /// </summary>
        /// <param name="intApplicationTypeId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        /// 具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsApplicationTypeEN objApplicationTypeEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddApplicationTypeRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddApplicationTypeRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objApplicationTypeEN = (clsApplicationTypeEN)Session["objApplicationTypeEN"];
                    UpdateApplicationTypeRecordSave(objApplicationTypeEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddApplicationTypeRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvApplicationType, "chkCheckRec", "ApplicationTypeId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    int intApplicationTypeId = int.Parse( strKeys[0]);
                    clsApplicationTypeBL.DelRecord(intApplicationTypeId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ApplicationType();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvApplicationType, "ApplicationTypeId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            int intApplicationTypeId = int.Parse( strKeys[0]);
            UpdateApplicationTypeRecord(intApplicationTypeId);
        }

        /// <summary>
        ///设置当前用户的Excel导出字段
        /// </summary>
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);//当前界面
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);//当前导出的使用的表
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);//当前用户
            //根据条件获取Excel设置Id
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请先导出一次Excel，再不行可与管理员联系！", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //弹出导出Excel字段界面进行设置
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "导出Excel字段设置", sbScript.ToString());
            // Response.Write(sbScript.ToString());
        }
        protected void gvApplicationType_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortApplicationTypeBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortApplicationTypeBy = e.SortExpression + " Asc";
                BindGv_ApplicationType();
                return;
            }
            //检查原来是升序
            intIndex = strSortApplicationTypeBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortApplicationTypeBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortApplicationTypeBy = e.SortExpression + " Desc";
            }
            BindGv_ApplicationType();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortApplicationTypeBy
        {
            get
            {
                string sSortApplicationTypeBy;
                sSortApplicationTypeBy = (string)ViewState["SortApplicationTypeBy"];
                if (sSortApplicationTypeBy == null)
                {
                    sSortApplicationTypeBy = "";
                }
                return sSortApplicationTypeBy;
            }
            set
            {
                string sSortApplicationTypeBy = value;
                ViewState.Add("SortApplicationTypeBy", sSortApplicationTypeBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvApplicationType.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvApplicationType.PageCount)
                {
                    this.gvApplicationType.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ApplicationType();
            }
        }


        ///生成的改变GridView中每页记录数的下拉框相关函数
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
                    BindGv_ApplicationType();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvApplicationType_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvApplicationType, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvApplicationType, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvApplicationType_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortApplicationTypeBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvApplicationType.Columns.Count; i++)
                {
                    strSortEx = this.gvApplicationType.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortApplicationTypeBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortApplicationTypeBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvApplicationType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int intApplicationTypeId = int.Parse( gvApplicationType.DataKeys[e.RowIndex]["ApplicationTypeId"].ToString());
            DeleteApplicationTypeRecord(intApplicationTypeId);
        }
        ///
        protected void gvApplicationType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int intApplicationTypeId = int.Parse( gvApplicationType.DataKeys[e.RowIndex]["ApplicationTypeId"].ToString());
            UpdateApplicationTypeRecord(intApplicationTypeId);
        }
        ///删除记录过程代码for C#
        protected void gvApplicationType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvApplicationType.PageIndex = e.NewPageIndex;
                this.BindGv_ApplicationType();
            }
        }
        ///
        protected void btnCancelApplicationTypeEdit_Click(object sender, EventArgs e)
        {
            DispApplicationTypeListRegion();
        }

    }
    public partial class wfmApplicationTypeB_QUDI : CommWebPageBase
    {
        protected void ShowData(int intApplicationTypeId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (intApplicationTypeId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsApplicationTypeBL.IsExist(intApplicationTypeId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + intApplicationTypeId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN(intApplicationTypeId);
            //4、获取类对象的所有属性；
            try
            {
                clsApplicationTypeBL.GetApplicationType(ref objApplicationTypeEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objApplicationTypeEN", objApplicationTypeEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromApplicationTypeClass(objApplicationTypeEN);
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
        protected string CombineApplicationTypeCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtApplicationTypeIdq.Text.Trim() != "")
            {
                strWhereCond += " And ApplicationTypeId like '%" + this.txtApplicationTypeIdq.Text.Trim() + "%'";
            }
            if (this.txtApplicationTypeNameq.Text.Trim() != "")
            {
                strWhereCond += " And ApplicationTypeName like '%" + this.txtApplicationTypeNameq.Text.Trim() + "%'";
            }
            if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
            {
                seProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
                strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
            }
            else
            {
                seProgLangTypeId = "";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_ApplicationType()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineApplicationTypeCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvApplicationTypeBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortApplicationTypeBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvApplicationType.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvApplicationType.PageSize = 10;
            }
            this.gvApplicationType.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvApplicationType.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvApplicationType.BottomPagerRow;
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
                lblAllPages.Text = this.gvApplicationType.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvApplicationType.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvApplicationType.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvApplicationType.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvApplicationType.PageIndex == this.gvApplicationType.PageCount - 1)
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
            gvApplicationType.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        /// 如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjApplicationTypeEN">表实体类对象</param>
        protected void GetDataFromApplicationTypeClass(clsApplicationTypeEN pobjApplicationTypeEN)
        {
            wucApplicationTypeB1.ApplicationTypeId = pobjApplicationTypeEN.ApplicationTypeId;// 应用程序类型ID
            wucApplicationTypeB1.ApplicationTypeName = pobjApplicationTypeEN.ApplicationTypeName;// 应用程序类型名称
            wucApplicationTypeB1.ApplicationTypeENName = pobjApplicationTypeEN.ApplicationTypeENName;// 应用程序类型英文名称
            wucApplicationTypeB1.ProgLangTypeId = pobjApplicationTypeEN.ProgLangTypeId;// 应用程序类型英文名称
            wucApplicationTypeB1.ProgLangTypeId2 = pobjApplicationTypeEN.ProgLangTypeId2;// 应用程序类型英文名称
            wucApplicationTypeB1.ProgLangTypeId3 = pobjApplicationTypeEN.ProgLangTypeId3;// 应用程序类型英文名称
            wucApplicationTypeB1.ProgLangTypeId4 = pobjApplicationTypeEN.ProgLangTypeId4;// 应用程序类型英文名称
            wucApplicationTypeB1.IsVible = pobjApplicationTypeEN.IsVisible;// 应用程序类型英文名称
            wucApplicationTypeB1.Memo = pobjApplicationTypeEN.Memo;// 说明
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjApplicationTypeEN">数据传输的目的类对象</param>
        protected void PutDataToApplicationTypeClass(clsApplicationTypeEN pobjApplicationTypeEN)
        {
            pobjApplicationTypeEN.ApplicationTypeId = wucApplicationTypeB1.ApplicationTypeId;// 应用程序类型ID
            pobjApplicationTypeEN.ApplicationTypeName = wucApplicationTypeB1.ApplicationTypeName;// 应用程序类型名称
            pobjApplicationTypeEN.ApplicationTypeENName = wucApplicationTypeB1.ApplicationTypeENName;// 应用程序类型英文名称
            pobjApplicationTypeEN.ProgLangTypeId = wucApplicationTypeB1.ProgLangTypeId;// 应用程序类型英文名称
            pobjApplicationTypeEN.ProgLangTypeId2 = wucApplicationTypeB1.ProgLangTypeId2;// 应用程序类型英文名称
            pobjApplicationTypeEN.ProgLangTypeId3 = wucApplicationTypeB1.ProgLangTypeId3;// 应用程序类型英文名称
            pobjApplicationTypeEN.ProgLangTypeId4 = wucApplicationTypeB1.ProgLangTypeId4;// 应用程序类型英文名称
            pobjApplicationTypeEN.IsVisible = wucApplicationTypeB1.IsVible;// 应用程序类型英文名称
            pobjApplicationTypeEN.Memo = wucApplicationTypeB1.Memo;// 说明
        }

        ///生成的插入记录准备过程代码for C#
        protected void AddApplicationTypeRecord()
        {
            wucApplicationTypeB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelApplicationTypeEdit.Text = "取消添加";
            //wucApplicationTypeB1.ApplicationTypeId = clsApplicationType.GetMaxStrId("ApplicationType","ApplicationTypeId", 2, "");
            DispEditApplicationTypeRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddApplicationTypeRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsApplicationTypeEN objApplicationTypeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucApplicationTypeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsApplicationTypeEN objApplicationTypeEN;	//定义对象
            objApplicationTypeEN = new clsApplicationTypeEN(wucApplicationTypeB1.ApplicationTypeId);	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsApplicationTypeBL.IsExist(objApplicationTypeEN.ApplicationTypeId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToApplicationTypeClass(objApplicationTypeEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsApplicationTypeBL.CheckPropertyNew(objApplicationTypeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsApplicationTypeBL.AddNewRecordBySql2(objApplicationTypeEN);
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
            BindGv_ApplicationType();
            DispApplicationTypeListRegion();
            wucApplicationTypeB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelApplicationTypeEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddApplicationTypeRecordSaveV5()
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
            clsApplicationTypeEN objApplicationTypeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucApplicationTypeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsApplicationTypeEN objApplicationTypeEN;	//定义对象
            objApplicationTypeEN = new clsApplicationTypeEN(wucApplicationTypeB1.ApplicationTypeId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsApplicationTypeBL.IsExist(objApplicationTypeEN.ApplicationTypeId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToApplicationTypeClass(objApplicationTypeEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsApplicationTypeBL.CheckPropertyNew(objApplicationTypeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsApplicationTypeBL.AddNewRecordBySql2(objApplicationTypeEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_ApplicationType();
            DispApplicationTypeListRegion();
            wucApplicationTypeB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelApplicationTypeEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateApplicationTypeRecord(int intApplicationTypeId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(intApplicationTypeId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucApplicationTypeB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelApplicationTypeEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditApplicationTypeRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateApplicationTypeRecordSave(clsApplicationTypeEN objApplicationTypeEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucApplicationTypeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToApplicationTypeClass(objApplicationTypeEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsApplicationTypeBL.CheckPropertyNew(objApplicationTypeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsApplicationTypeBL.UpdateBySql2(objApplicationTypeEN);
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
            BindGv_ApplicationType();
            DispApplicationTypeListRegion();
            wucApplicationTypeB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelApplicationTypeEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateApplicationTypeRecordSaveV5(clsApplicationTypeEN objApplicationTypeEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucApplicationTypeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToApplicationTypeClass(objApplicationTypeEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsApplicationTypeBL.CheckPropertyNew(objApplicationTypeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsApplicationTypeBL.UpdateBySql2(objApplicationTypeEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_ApplicationType();
            DispApplicationTypeListRegion();
            wucApplicationTypeB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelApplicationTypeEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteApplicationTypeRecord(int intApplicationTypeId)
        {
            try
            {
                clsApplicationTypeBL.DelRecord(intApplicationTypeId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ApplicationType();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineApplicationTypeCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ApplicationType信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("ApplicationTypeId"); arrCnName.Add("应用程序类型ID");
            arrColName.Add("ApplicationTypeName"); arrCnName.Add("应用程序类型名称");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//当前界面
            objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图
            objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;//当前工程在生成代码系统中所用的工程Id，为了翻译字段名的中文名
            objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名，也是Excel文件中的标题名
            objExportExcelSetENEx.arrColName = arrColName;//数据表的列名
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名
                arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名，也是Excel文件中的标题名
                arrColName = objExportExcelSetENEx.arrColName;//数据表的列名
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版，复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsApplicationTypeBL.GetDataTable_ApplicationType(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007，可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditApplicationTypeRegion()
        {
            divList.Visible = false;
            tabEditApplicationTypeRegion.Visible = true;
        }
        private void DispApplicationTypeListRegion()
        {
            divList.Visible = true;
            tabEditApplicationTypeRegion.Visible = false;
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



        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strApplicationTypeId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvApplicationType);
            if (strApplicationTypeId == null || strApplicationTypeId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";


            try
            {
                int intApplicationTypeId = int.Parse(strApplicationTypeId);
                clsApplicationTypeBLEx.AdjustSequenceNumber("UP", intApplicationTypeId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ApplicationType();
            clsCommForWebForm.SetCheckedItemForGv(gvApplicationType, 1, strApplicationTypeId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strApplicationTypeId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvApplicationType);
            if (strApplicationTypeId == null || strApplicationTypeId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";

            try
            {
                int intApplicationTypeId = int.Parse(strApplicationTypeId);
                clsApplicationTypeBLEx.AdjustSequenceNumber("DOWN", intApplicationTypeId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ApplicationType();
            clsCommForWebForm.SetCheckedItemForGv(gvApplicationType, 1, strApplicationTypeId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsApplicationTypeBLEx.ReOrder();
            BindGv_ApplicationType();

        }


        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrApplicationTypeId = clsCommForWebForm.GetAllCheckedItemFromGv(gvApplicationType, "chkCheckRec");
            if (arrApplicationTypeId == null || arrApplicationTypeId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";


                try
                {
                    clsApplicationTypeBLEx.GoTop(arrApplicationTypeId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_ApplicationType();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrApplicationTypeId = clsCommForWebForm.GetAllCheckedItemFromGv(gvApplicationType, "chkCheckRec");
            if (arrApplicationTypeId == null || arrApplicationTypeId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";
                try
                {
                    clsApplicationTypeBLEx.GoBottom(arrApplicationTypeId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_ApplicationType();
        }
        /// <summary>
        /// 编程语言类型Id。ddlProgLangTypeId
        /// </summary>
        protected string seProgLangTypeId
        {
            get
            {
                string sProgLangTypeId;
                sProgLangTypeId = (string)Session["ProgLangTypeId"];
                if (sProgLangTypeId == null)
                {
                    sProgLangTypeId = "";
                }
                return sProgLangTypeId;
            }
            set
            {
                string sProgLangTypeId = value;
                Session.Add("ProgLangTypeId", sProgLangTypeId);
            }
        }
    }
}