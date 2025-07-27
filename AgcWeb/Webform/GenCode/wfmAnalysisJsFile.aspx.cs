
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
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
    /// wfmPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmAnalysisJsFile : CommPageBase
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {

            clsCommonSession.UserId = "pyf";
            clsPubVar.CheckUserSession();
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                InitParentPageInfo();
              

                //2、显示无条件的表内容在DATAGRID中
                if (string.IsNullOrEmpty(vsSortPrjTabBy) == true)
                {
                    vsSortPrjTabBy = "UpdDate Desc";
                }
                //2、显示无条件的表内容在DATAGRID中
                //是否显示详细列表;
                //   DispDetailListForPrjTab();
                BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。

                DispPrjTabListRegion();

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
            this.gvPrjTab.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvPrjTab, vsViewName, clsCommonSession.UserId);

            BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
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
        protected void gvPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjTab.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
        }
        private List<string> getAllCheckedTabIds()
        {
            List<string> arrTabId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTab, "chkCheckRec");
            if (arrTabId == null || arrTabId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return null;
            }
            lblMsgList.Text = "";
            return arrTabId;
        }
        private string getFirstCheckedTabId()
        {
            string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTab);
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return "";
            }
            lblMsgList.Text = "";
            return strTabId;
        }
        
        protected void gvPrjTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortPrjTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
                BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
                return;
            }
            //检查原来是升序
            intIndex = vsSortPrjTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortPrjTabBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
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

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTab.PageCount)
                {
                    this.gvPrjTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvPrjTab_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
                case "EditObjectAndTabFields":
                    //int deleteid = (int)GridView1.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value;  
                    strTabId = gvPrjTab.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value.ToString();
                    vsTabId_T = strTabId;
                    JumpOtherPages("EditTabAndObjectFields");
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjTab_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortPrjTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortPrjTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortPrjTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvPrjTab_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strTabId = gvPrjTab.DataKeys[e.RowIndex].Value.ToString();

        }
        ///
        protected void gvPrjTab_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strTabId = gvPrjTab.DataKeys[e.RowIndex].Value.ToString();

        }
        ///删除记录过程代码for C#
        protected void gvPrjTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTab.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
            }
        }
        protected void lbDispTabList_Click(object sender, EventArgs e)
        {
            DispPrjTabListRegion();
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
                    BindGv_PrjTab(vsarrWebSrvFunctionsObjLst);
                }
            }
        }


        protected void btnDIspFunctionInfo_Click(object sender, EventArgs e)
        {
            string strJsFile = "";//tzPubFun.js
            string strMsg = "";
            strJsFile = txtWebSrvUrl.Text;
            string strFolderName_Root = Server.MapPath("~");
            string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strJsFile);
            if (string.IsNullOrEmpty(strFindFileFullFile) == true)
            {
                 strMsg = string.Format("所引用的Js文件:[{0}]不存在！({1}->{2})",
             strJsFile,
             clsStackTrace.GetCurrClassFunctionByLevel(2),
             clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
            string strJsText = clsFile.GetContentFromTextFile(strFindFileFullFile);
            ShowCode(strJsText);
            List<string> arrTextLine = new List<string>();
            bool bolIsEnd = false;
            int iLastPos = 0;
            string strNewLine = "";
            while (bolIsEnd == false)
            {
                int iPosReturn = -1;//回车的位置
                iPosReturn = strJsText.IndexOf("\r\n", iLastPos);
                if (iPosReturn > 0)
                {
                    strNewLine = strJsText.Substring(iLastPos, iPosReturn - iLastPos);
                    iLastPos = iPosReturn + 2;
                }
                else
                {
                    strNewLine = strJsText.Substring(iLastPos);
                    bolIsEnd = true;
                }
                arrTextLine.Add(strNewLine);
            }
            List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst = new List<clsWebSrvFunctionsEN>();
            StringBuilder sbFunctionContent = new StringBuilder();
            bool bolIsFunctionStart = false;
            int intdegreeFunctHKH = 0;//开始查找函数左花括号
            string strFuncName = "";
            string strFuncParameters = "";
          
            int iLen_Temp = 0;
            int iLen_Line = 0;
            int iPos_LeftYKH;//左圆括号
            int iPos_RightYKH;//右圆括号
            int iPos_LeftFuncHKH = 0;
      
            string strChar = "";
            foreach (string strLine in arrTextLine)
            {
                clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
                string strLineP = strLine.TrimStart(' ');
                iLen_Line = strLineP.Length;
                if (strLineP.Substring(0, 2) == "//")
                {
                    sbFunctionContent.AppendLine(strLineP);
                    continue;
                }
                int iPos_Function = strLineP.IndexOf("Function");
                int iLen_Function = "Function".Length;
                strChar = strLineP.Substring(iPos_Function + iLen_Function, 1);
                if (strChar != " " && strChar !="(")
                {
                    if (bolIsFunctionStart == false)
                    {
                        sbFunctionContent.AppendLine(strLineP);
                        continue;
                    }
                }
                int iState = 0;
                if (iPos_Function == 0) iState = 0;
                else if (iPos_Function > 0) iState = 1;
                else if (iPos_Function == -1) iState = -1;

                //行开始是"Function"
                switch (iState)
                {
                    case 0://iPos_Function == 0 行开始是"function ",说明该行是函数定义

                        //行开始是"function ",说明该行是函数定义

                        iPos_LeftYKH = strLineP.IndexOf("(", iPos_Function + iLen_Function + 1);
                        if (iPos_LeftYKH > 0)
                        {
                            iLen_Temp = iPos_LeftYKH - (iPos_Function + iLen_Function + 1);
                            if (iLen_Temp == 0)
                            {
                                strMsg = string.Format("找不到函数名。该行文本:[{0}]({1})",
                                    strLineP, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            strFuncName = strLineP.Substring(iPos_Function + iLen_Function + 1, iLen_Temp);

                        }
                        iPos_RightYKH = strLineP.IndexOf(")", iPos_LeftYKH + 1);
                        if (iPos_RightYKH == -1)
                        {
                            strMsg = string.Format("找不到历括号。该行文本:[{0}]({1})",
                                 strLineP, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                        if (iPos_RightYKH == iPos_LeftYKH + 1)
                        {
                            strFuncParameters = "";
                        }
                        else
                        {
                            iLen_Temp = iPos_RightYKH - 1 - (iPos_LeftYKH + 1);
                            strFuncParameters = strLineP.Substring(iPos_LeftYKH + 1, iLen_Temp);
                        }

                
                        iPos_LeftFuncHKH = strLineP.IndexOf("{", iPos_RightYKH + 1);
                        if (iPos_LeftFuncHKH >= 0)
                        {
                            bolIsFunctionStart = true;
                            intdegreeFunctHKH += 1;
                        }
                        if (iPos_LeftFuncHKH == iLen_Line)
                        {
                            sbFunctionContent.AppendLine(strLineP);
                            continue;
                        }
                        for (int i = iPos_LeftFuncHKH; i <= iLen_Line; i++)
                        {
                            strChar = strLineP.Substring(i, 1);
                            if (strChar == "}") intdegreeFunctHKH -= 1;
                            if (strChar == "{") intdegreeFunctHKH += 1;
                            if (intdegreeFunctHKH == 0)
                            {
                                sbFunctionContent.AppendLine(strLineP);
                                continue;
                            }
                        }
                        break;
                    case 1://Function不在开始，查找前面是否有=
                        int iPosEqual = strLineP.IndexOf("=");
                        if (iPosEqual == -1) //找不到等号
                        {
                            strMsg = string.Format("应该在【Function】前面找到[=],但找不到。该行文本:[{0}]({1})",
                               strLineP, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                        if (iPos_Function < iPosEqual)
                        {
                            strMsg = string.Format("[=]应该在【Function】后面,但不正确。该行文本:[{0}]({1})",
                             strLineP, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                        //接下来找
                        iPos_LeftYKH = strLineP.IndexOf("(", iPos_Function + iLen_Function + 1);
                        if (iPos_LeftYKH > 0)
                        {
                            iLen_Temp = iPos_LeftYKH - (iPos_Function + iLen_Function + 1);
                            if (iLen_Temp == 0)
                            {
                                strMsg = string.Format("找不到函数名。该行文本:[{0}]({1})",
                                    strLineP, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            strFuncName = strLineP.Substring(iPos_Function + iLen_Function + 1, iLen_Temp);

                        }
                        iPos_RightYKH = strLineP.IndexOf(")", iPos_LeftYKH + 1);
                        if (iPos_RightYKH == -1)
                        {
                            strMsg = string.Format("找不到历括号。该行文本:[{0}]({1})",
                                 strLineP, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                        if (iPos_RightYKH == iPos_LeftYKH + 1)
                        {
                            strFuncParameters = "";
                        }
                        else
                        {
                            iLen_Temp = iPos_RightYKH - 1 - (iPos_LeftYKH + 1);
                            strFuncParameters = strLineP.Substring(iPos_LeftYKH + 1, iLen_Temp);
                        }

                  
                        iPos_LeftFuncHKH = strLineP.IndexOf("{", iPos_RightYKH + 1);
                        if (iPos_LeftFuncHKH >= 0)
                        {
                            bolIsFunctionStart = true;
                            intdegreeFunctHKH += 1;
                        }
                        if (iPos_LeftFuncHKH == iLen_Line)
                        {
                            sbFunctionContent.AppendLine(strLineP);
                            continue;
                        }
                        for (int i = iPos_LeftFuncHKH; i <= iLen_Line; i++)
                        {
                            strChar = strLineP.Substring(i, 1);
                            if (strChar == "}") intdegreeFunctHKH -= 1;
                            if (strChar == "{") intdegreeFunctHKH += 1;
                            if (intdegreeFunctHKH == 0)
                            {
                                sbFunctionContent.AppendLine(strLineP);
                                continue;
                            }
                        }

                        break;
                    case -1://
                        break;
                }
              

                ListBox1.Items.Add(strLine);
            }
            return;
            //string p_NameSpace = "EduHigh_WS";
            //try
            //{

            //    Assembly _WebServiceAssembly = clsGetAssembly.GetWebServiceAssembly(strJsFile, p_NameSpace);
            //    //   Type _Type = _WebServiceAssembly.GetType("TestTSPSubassemblyBase.TelDirectory");
            //    Type _Type = _WebServiceAssembly.GetType("EduHigh_WS.StudentInfoService");
            //    Type[] _AllType1 = _WebServiceAssembly.GetTypes();//.GetType("EduHigh_WS.StudentInfoExService");
            //    Type _Type_1 = _AllType1[0];
            //    txtFileName4GenCode.Text = _Type_1.FullName;
            //    MethodInfo[] _AllMethod = _Type_1.GetMethods();

            //    string strWhereExist = string.Format("{0}='{1}'",
            //        conWebSrvClass.WebSrvUrl, strJsFile);
            //    clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetFirstObj_S(strWhereExist);
            //    if (objWebSrvClassEN == null)
            //    {
            //        objWebSrvClassEN = new clsWebSrvClassEN();
            //        objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
            //        objWebSrvClassEN.WebSrvUrl = strJsFile;
            //        objWebSrvClassEN.ClsName = _Type_1.FullName;
            //        objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            //        objWebSrvClassEN.UpdUser = clsCommonSession.UserId;
            //        clsWebSrvClassBL.AddNewRecordBySql2(objWebSrvClassEN);
            //    }
            //    else
            //    {
            //        objWebSrvClassEN.WebSrvUrl = strJsFile;
            //        objWebSrvClassEN.ClsName = _Type_1.FullName;
            //        objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            //        objWebSrvClassEN.UpdUser = clsCommonSession.UserId;
            //        clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);
            //    }
            //    StringBuilder sbMsg = new StringBuilder();
            //    //List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst = new List<clsWebSrvFunctionsEN>();

            //    int intIndex = 1;

            //    foreach (MethodInfo _Method in _AllMethod)
            //    {

            //        clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
            //        //clsWebSrvFunctionsBLEx.get

            //        objWebSrvFunctionsEN.WebSrvClassId = objWebSrvClassEN.WebSrvClassId;
            //        objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();// string.Format("{0:D3}", intIndex);
            //        objWebSrvFunctionsEN.FunctionName = _Method.Name;
            //        objWebSrvFunctionsEN.FuncTypeId = "10";

            //        objWebSrvFunctionsEN.GetCustomAttributes = _Method.GetCustomAttributes(true).Length;
            //        objWebSrvFunctionsEN.FunctionSignature = _Method.ToString();
            //        strWhereExist = string.Format("{0}='{1}' And {2}='{3}'",
            //                                conWebSrvFunctions.WebSrvClassId,
            //                                objWebSrvFunctionsEN.WebSrvClassId,
            //                                conWebSrvFunctions.FunctionName,
            //                                 objWebSrvFunctionsEN.FunctionName);
            //        if (clsWebSrvFunctionsBL.IsExistRecord(strWhereExist) == false)
            //        {
            //            clsWebSrvFunctionsBL.AddNewRecordBySql2(objWebSrvFunctionsEN);
            //        }
            //        else
            //        {
            //            clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);

            //        }
            //        arrWebSrvFunctionsObjLst.Add(objWebSrvFunctionsEN);
            //        sbMsg.AppendFormat("Name={0}, GetCustomAttributes={1}.{2}\r\n",
            //            _Method.Name, _Method.GetCustomAttributes(true).Length, _Method.ToString());
            //        intIndex++;
            //    }
            //    ShowCode(sbMsg.ToString());
            //    vsarrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst;
            //    BindGv_PrjTab(arrWebSrvFunctionsObjLst);
            //    //MethodInfo _Method1 = _Type.GetMethod("GetId_StudentInfoByStuID");
            //    //object _Object = Activator.CreateInstance(_Type);

            //    //object _ReturnData = _Method1.Invoke(_Object, new object[] { });
            //}
            //catch (Exception objException)
            //{
            //    clsCommonJsFunc.Alert(this, objException.Message);
            //}
        }
    }
    public partial class wfmAnalysisJsFile : CommPageBase
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
        protected string CombinePrjTabCondition()
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
        protected void BindGv_PrjTab(List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst)
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
            if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            {
                int intPageSize = int.Parse(PageSize4PrjTab);
                gvPrjTab.PageSize = intPageSize;
            }
            else
            {
                PageSize4PrjTab = "10";
                gvPrjTab.PageSize = 10;
            }

            if (vsSortPrjTabBy.Contains("Asc") == true)
            {
                vsMySortOrder = System.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                vsMySortOrder = System.Data.SqlClient.SortOrder.Descending;
            }
            if (vsSortPrjTabBy.Contains(conWebSrvFunctions.FunctionName) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.FunctionName).ToList();

            }
            else if (vsSortPrjTabBy.Contains(conWebSrvFunctions.FunctionSignature) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.FunctionSignature).ToList();
            }
            else if (vsSortPrjTabBy.Contains(conWebSrvFunctions.GetCustomAttributes) == true)
            {
                arrWebSrvFunctionsObjLst = arrWebSrvFunctionsObjLst.OrderBy(x => x.GetCustomAttributes).ToList();
            }
            this.gvPrjTab.DataSource = arrWebSrvFunctionsObjLst;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjTab.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjTab.BottomPagerRow;
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
                lblAllPages.Text = this.gvPrjTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjTab.PageIndex == this.gvPrjTab.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
                {
                    ddlPagerRecCount.Text = PageSize4PrjTab;
                }
                else
                {
                    PageSize4PrjTab = "10";
                    ddlPagerRecCount.Text = PageSize4PrjTab;
                }
            }
            gvPrjTab.BottomPagerRow.Visible = true;
        }


        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabCondition();
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

            tabCode.Visible = false;
        }
        /// <summary>
        /// 显示列表区域
        /// </summary>
        private void DispPrjTabListRegion()
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
        private void CheckTabField1()
        {
            string strWhereCond = CombinePrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLst(strWhereCond);
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjList)
            {
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

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
                    string strTabId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTab);
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