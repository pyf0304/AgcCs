///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;

using com.taishsoft.common;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.datetime;
using AGC.Entity;



namespace AGC.Webform
{
    /// <summary>
    /// wfmFuncModule_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFuncModule_QUDI : CommWebPageBase
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


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

                //1、为下拉框设置数据源，绑定列表数据
                wucFuncModule1.SetDdl_PrjId();
                wucFuncModule1.SetDdl_UserId();
                wucFuncModule1.SetDdl_UseStateId();
                clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                ddlPrjIdq.Enabled = false;
                strSortFuncModuleBy = "OrderNum Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_FuncModule();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucFuncModule1.SetKeyReadOnly(true);
                DispFuncModuleListRegion();
            }
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


        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId == null)
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


        //生成错误信息的Session属性
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
        protected string CombineFuncModuleCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtFuncModuleNameq.Text.Trim() != "")
            {
                strWhereCond += " And FuncModuleName like '%" + this.txtFuncModuleNameq.Text.Trim() + "%'";
            }
            if (this.txtFuncModuleEnNameq.Text.Trim() != "")
            {
                strWhereCond += " And FuncModuleEnName like '%" + this.txtFuncModuleEnNameq.Text.Trim() + "%'";
            }
            if (this.ddlUseStateId.SelectedValue != "" && this.ddlUseStateId.SelectedValue != "0")
            {
                strWhereCond += " And UseStateId='" + this.ddlUseStateId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_FuncModule()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineFuncModuleCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFuncModule_AgcBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
             clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortFuncModuleBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvFuncModule.PageSize = intPageSize;
            }
            else
            {
                PageSize = "20";
                gvFuncModule.PageSize = 20;
            }
            this.gvFuncModule.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvFuncModule.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvFuncModule.BottomPagerRow;
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
                lblAllPages.Text = this.gvFuncModule.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvFuncModule.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvFuncModule.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvFuncModule.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvFuncModule.PageIndex == this.gvFuncModule.PageCount - 1)
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
                    PageSize = "20";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        protected int CalcPages(int intRecCount, int intPageSize)
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
            this.gvFuncModule.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_FuncModule();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvFuncModule_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvFuncModule.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_FuncModule();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strFuncModuleId">表记录的关键字，显示该表关键字的内容</param>
        protected void ShowData(string strFuncModuleId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFuncModuleId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsFuncModule_AgcBL.IsExist(strFuncModuleId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strFuncModuleId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFuncModule_AgcEN objFuncModule = new clsFuncModule_AgcEN(strFuncModuleId);
            //4、获取类对象的所有属性；
            try
            {
                clsFuncModule_AgcBL .GetFuncModule_Agc(ref objFuncModule);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objFuncModule", objFuncModule);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromFuncModuleClass(objFuncModule);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjFuncModule">表实体类对象</param>
        protected void GetDataFromFuncModuleClass(clsFuncModule_AgcEN pobjFuncModule)
        {
            wucFuncModule1.FuncModuleAgcId = pobjFuncModule.FuncModuleAgcId;
            wucFuncModule1.FuncModuleName = pobjFuncModule.FuncModuleName;
            wucFuncModule1.FuncModuleEnName = pobjFuncModule.FuncModuleEnName;
            wucFuncModule1.PrjId = pobjFuncModule.PrjId;
            wucFuncModule1.UserId = pobjFuncModule.UpdUser;
            wucFuncModule1.UseStateId = pobjFuncModule.UseStateId;
           
            wucFuncModule1.Memo = pobjFuncModule.Memo;
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsFuncModule_AgcEN objFuncModule;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFuncModuleRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddFuncModuleRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objFuncModule = (clsFuncModule_AgcEN)Session["objFuncModule"];
                    UpdateFuncModuleRecordSave(objFuncModule);
                    break;
            }
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjFuncModule">数据传输的目的类对象</param>
        protected void PutDataToFuncModuleClass(clsFuncModule_AgcEN pobjFuncModule)
        {
            pobjFuncModule.FuncModuleAgcId = wucFuncModule1.FuncModuleAgcId;
            pobjFuncModule.FuncModuleName = wucFuncModule1.FuncModuleName;
            pobjFuncModule.FuncModuleEnName = wucFuncModule1.FuncModuleEnName;
            pobjFuncModule.PrjId = wucFuncModule1.PrjId;
            pobjFuncModule.UpdUser = wucFuncModule1.UserId;
            pobjFuncModule.UseStateId = wucFuncModule1.UseStateId;

            pobjFuncModule.UpdDate =clsDateTime.getTodayDateTimeStr(1);
            //pobjFuncModule.OrderNum = 100;
            pobjFuncModule.Memo = wucFuncModule1.Memo;
        }


        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucFuncModule1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsgEdit.Text = "";
            wucFuncModule1.FuncModuleAgcId = clsFuncModule_AgcBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucFuncModule1.PrjId = clsPubVar.CurrSelPrjId;
            DispEditFuncModuleRegion();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineFuncModuleCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FuncModule_Agc信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("TabNum"); arrCnName.Add("TabNum");
            arrColName.Add("ViewNum"); arrCnName.Add("ViewNum");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFuncModule_AgcBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        protected bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrFuncModuleId = clsCommForWebForm.GetAllCheckedItemFromGv(gvFuncModule, "chkCheckRec");
            if (arrFuncModuleId == null || arrFuncModuleId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsFuncModule_AgcBL.DelFuncModule_Agcs(arrFuncModuleId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FuncModule();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strFuncModuleId = clsCommForWebForm.GetFirstCheckedItemFromGvByOneKey(gvFuncModule, "FuncModuleAgcId");
            if (strFuncModuleId == null || strFuncModuleId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            UpdateFuncModuleRecord(strFuncModuleId);
           
        }
     
        
        protected void gvFuncModule_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortFuncModuleBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortFuncModuleBy = e.SortExpression + " Asc";
                BindGv_FuncModule();
                return;
            }
            //检查原来是升序
            intIndex = strSortFuncModuleBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortFuncModuleBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortFuncModuleBy = e.SortExpression + " Desc";
            }
            BindGv_FuncModule();
        }

        protected string strSortFuncModuleBy
        {
            get
            {
                string sSortFuncModuleBy;
                sSortFuncModuleBy = (string)ViewState["SortFuncModuleBy"];
                if (sSortFuncModuleBy == null)
                {
                    sSortFuncModuleBy = "";
                }
                return sSortFuncModuleBy;
            }
            set
            {
                string sSortFuncModuleBy = value;
                ViewState.Add("SortFuncModuleBy", sSortFuncModuleBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFuncModule.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFuncModule.PageCount)
                {
                    this.gvFuncModule.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FuncModule();
            }
        }

        ///生成的插入记录准备过程代码for C#
        protected void AddFuncModuleRecord()
        {
            wucFuncModule1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            wucFuncModule1.FuncModuleAgcId = clsFuncModule_AgcBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucFuncModule1.PrjId = clsPubVar.CurrSelPrjId;
        }
        ///插入记录存盘过程代码for C#
        protected void AddFuncModuleRecordSave()
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
            clsFuncModule_AgcEN objFuncModule;
            //1、检查控件中输入数据类型是否正确
            if (!wucFuncModule1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsFuncModule_AgcEN objFuncModule;	//定义对象
            objFuncModule = new clsFuncModule_AgcEN(wucFuncModule1.FuncModuleAgcId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFuncModule_AgcBL.IsExist(wucFuncModule1.FuncModuleAgcId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFuncModuleClass(objFuncModule);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsFuncModule_AgcBL .CheckPropertyNew(objFuncModule);
                //6、把数据实体层的数据存贮到数据库中
                clsFuncModule_AgcBL .AddNewRecordBySql2(objFuncModule);
                clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_FuncModule();
            wucFuncModule1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            DispFuncModuleListRegion();
        }
        ///插入记录存盘过程代码for C#
        protected void AddFuncModuleRecordSaveV5()
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
            clsFuncModule_AgcEN objFuncModule;
            //1、检查控件中输入数据类型是否正确
            if (!wucFuncModule1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsFuncModule_AgcEN objFuncModule;	//定义对象
            objFuncModule = new clsFuncModule_AgcEN(wucFuncModule1.FuncModuleAgcId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFuncModule_AgcBL.IsExist(wucFuncModule1.FuncModuleAgcId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFuncModuleClass(objFuncModule);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsFuncModule_AgcBL.CheckPropertyNew(objFuncModule);
                //6、把数据实体层的数据存贮到数据库中
                clsFuncModule_AgcBL .AddNewRecordBySql2(objFuncModule);
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
            BindGv_FuncModule();
            wucFuncModule1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            DispFuncModuleListRegion();
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateFuncModuleRecord(string strFuncModuleId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFuncModuleId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFuncModule1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsgEdit.Text = "";
            DispEditFuncModuleRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdateFuncModuleRecordSave(clsFuncModule_AgcEN objFuncModule)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucFuncModule1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFuncModuleClass(objFuncModule);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsFuncModule_AgcBL.CheckPropertyNew(objFuncModule);
                //6、把数据实体层的数据存贮到数据库中
                clsFuncModule_AgcBL .UpdateBySql2(objFuncModule);
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
            BindGv_FuncModule();
            wucFuncModule1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            DispFuncModuleListRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdateFuncModuleRecordSaveV5(clsFuncModule_AgcEN objFuncModule)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucFuncModule1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFuncModuleClass(objFuncModule);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsFuncModule_AgcBL.CheckPropertyNew(objFuncModule);
                //6、把数据实体层的数据存贮到数据库中
                clsFuncModule_AgcBL .UpdateBySql2(objFuncModule);
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
            BindGv_FuncModule();
            wucFuncModule1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            DispFuncModuleListRegion();
        }
        ///删除记录过程代码for C#
        protected void DeleteFuncModuleRecord(string strFuncModuleId)
        {
            try
            {
                clsFuncModule_AgcBL.DelRecord(strFuncModuleId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FuncModule();
            DispFuncModuleListRegion();
        }
        ///生成GridView行命令的事件代码
        protected void gvFuncModule_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvFuncModule, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvFuncModule, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvFuncModule_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortFuncModuleBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvFuncModule.Columns.Count; i++)
                {
                    strSortEx = this.gvFuncModule.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortFuncModuleBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortFuncModuleBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvFuncModule_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strFuncModuleId = gvFuncModule.DataKeys[e.RowIndex].Value.ToString();
            DeleteFuncModuleRecord(strFuncModuleId);
        }
        ///
        protected void gvFuncModule_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strFuncModuleId = gvFuncModule.DataKeys[e.RowIndex].Value.ToString();
            UpdateFuncModuleRecord(strFuncModuleId);
        }
        ///删除记录过程代码for C#
        protected void gvFuncModule_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFuncModule.PageIndex = e.NewPageIndex;
                this.BindGv_FuncModule();
            }
        }
        ///
        protected void lbDispFuncModuleList_Click(object sender, EventArgs e)
        {
            DispFuncModuleListRegion();
        }
        private void DispEditFuncModuleRegion()
        {
            tabFuncModuleGridView.Visible = false;
            tabEditFuncModuleRegion.Visible = true;
        }
        private void DispFuncModuleListRegion()
        {
            tabFuncModuleGridView.Visible = true;
            tabEditFuncModuleRegion.Visible = false;
        }
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strFuncModuleId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvFuncModule);
            if (strFuncModuleId == null || strFuncModuleId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
        
    
            try
            {
                clsFuncModule_AgcBLEx.AdjustSequenceNumber("UP", strFuncModuleId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"./GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FuncModule();
            clsCommForWebForm.SetCheckedItemForGv(gvFuncModule, 1, strFuncModuleId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strFuncModuleId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvFuncModule);
            if (strFuncModuleId == null || strFuncModuleId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
          
            try
            {
                clsFuncModule_AgcBLEx.AdjustSequenceNumber("DOWN", strFuncModuleId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FuncModule();
            clsCommForWebForm.SetCheckedItemForGv(gvFuncModule, 1, strFuncModuleId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsFuncModule_AgcBLEx.ReOrder(clsPubVar.CurrSelPrjId);
            BindGv_FuncModule();

        }


        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrQuestionID = clsCommForWebForm.GetAllCheckedItemFromGv(gvFuncModule, "chkCheckRec");
            if (arrQuestionID == null || arrQuestionID.Count == 0)
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
                    clsFuncModule_AgcBLEx.GoTop(arrQuestionID, clsPubVar.CurrSelPrjId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_FuncModule();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrQuestionID = clsCommForWebForm.GetAllCheckedItemFromGv(gvFuncModule, "chkCheckRec");
            if (arrQuestionID == null || arrQuestionID.Count == 0)
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
                    clsFuncModule_AgcBLEx.GoBottom(arrQuestionID, clsPubVar.CurrSelPrjId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_FuncModule();
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)Session["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                Session.Add("PageSize", strPageSize);
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
                    BindGv_FuncModule();
                }
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