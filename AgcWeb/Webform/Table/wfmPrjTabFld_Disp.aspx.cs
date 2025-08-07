///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv;
using com.taishsoft.commdb;
//using ProjectDesign;
using System.Text;
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTabFld_Disp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {

            string js1 = "";
            js1 += "<script>\r\r\n";
            js1 += "function ld(){\r\r\n";
            js1 += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n";
            js1 += "if(document.getElementsByName('RadioName')[i].value==";
            js1 += "document.getElementById('" + rd.ClientID + "').value) \r\r\n";
            js1 += "document.getElementsByName('RadioName')[i].checked=true;\r\r\n";
            js1 += "}\r\r\n";

            js1 += "window.onload=ld\r\r\n";
            js1 += "</" + "script>\r\r\n";
            //			Page.RegisterStartupScript("js",js1);
            ClientScript.RegisterStartupScript(this.GetType(), "js", js1);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //1、为下拉框设置数据源，绑定列表数据

                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);

                this.ddlTabIdq.SelectedValue = this.TabId;

                clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeIdq);
                BindDdl_IsPrimary(ddlIsPrimaryq);

                //2、显示无条件的表内容在DATAGRID中
                strSortPrjTabFldBy = "SequenceNumber Asc";
                strSortObjFldTabBy = "FldName Asc";
                BindDg_PrjTabFld();
                ///显示当前表名：
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
                lblCurrTabName.Text = "当前表名:" + objPrjTabEN.TabName + "(" + objPrjTabEN.TabCnName + ")";


                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
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
        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

        private string TabId
        {
            get
            {
                string strTabId;
                strTabId = (string)Session["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                Session.Add("TabId", strTabId);
            }
        }
        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinePrjTabFldCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " and TabId='" + this.ddlTabIdq.SelectedValue + "'";
            }

            if (this.ddlIsPrimaryq.SelectedValue == "是")
            {
                strWhereCond += " and IsPrimary='1'";
            }
            else if (this.ddlIsPrimaryq.SelectedValue == "否")
            {
                strWhereCond += " and IsPrimary='0'";
            }
            if (this.ddlPrimaryTypeIdq.SelectedValue != "" && this.ddlPrimaryTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrimaryTypeId='" + this.ddlPrimaryTypeIdq.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_PrjTabFld()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //	4、设置DATAGRID的数据源(DataSource)；
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond;
            strWhereCond = CombinePrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsPrjTabFldBLEx.GetPrjTabFldT1(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTabFld1.PageSize);
            if (intPages == 0)
            {
                this.dgPrjTabFld1.CurrentPageIndex = 0;
            }
            else if (this.dgPrjTabFld1.CurrentPageIndex > intPages - 1)
            {
                this.dgPrjTabFld1.CurrentPageIndex = intPages - 1;
            }
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFldBy;
            this.dgPrjTabFld1.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgPrjTabFld1.DataBind();
            //	6、设置记录数的状态，
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
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

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.dgPrjTabFld1.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_PrjTabFld();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgPrjTabFld1.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_PrjTabFld();
        }

        protected void dgPrjTabFld_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
            }
            int intIndex;
            if (strSortPrjTabFldBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjTabFld1.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjTabFld1.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPrjTabFldBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }


        public void BindDdl_IsPrimary(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Insert(0, li);
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.SelectedIndex = 0;
        }


        //private void BindDdl_PrjObjects(DropDownList objDdl, string PrjId)
        //{

        //    ListItem li = new ListItem("请选择...", "0");
        //    DataTable objDt = clsPrjObjectsBLEx.GetPrjObjectsEx(" PrjId='" + PrjId + "'", "ObjName");
        //    objDdl.DataSource = objDt;
        //    objDdl.DataTextField = "ObjName";
        //    objDdl.DataValueField = "ObjId";
        //    objDdl.DataBind();
        //    objDdl.Items.Insert(0, li);
        //    objDdl.SelectedIndex = 0;

        //}


        private void Get_ObjectFldArrylist(DataGrid objDg, ArrayList objArr)
        {
            if (objArr == null || objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                objArr.Clear();
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");
                    if (cb != null && cb.Checked)
                    {
                        objArr.Add(di.Cells[1].Text);
                    }
                }
            }
        }

        private void Set_DataGridAllChecked(DataGrid objDg, CheckBox objCkb)
        {
            if (objCkb == null || objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");
                    if (cb != null)
                    {
                        cb.Checked = objCkb.Checked;
                    }
                }

            }
        }

        protected void btnDelRec_Click(object sender, System.EventArgs e)
        {
            string mid = (string)rd.Value;
            if (mid.Trim().Length == 0)
            {
                Response.Write("<script>alert('请先选择一条记录！')</script>");
            }
            else
            {
                clsPrjTabFldBLEx.DelRecordEx(long.Parse(mid));
                rd.Value = "";
                BindDg_PrjTabFld();
            }
        }
        protected void dgPrjTabFld_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsPrimary;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 7;
                iNum[1] = 8;
                iNum[2] = 10;
                iNum[3] = 11;
                for (int i = 0; i < 4; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "√";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "×";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }

            }
        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmPrjTab_Disp.aspx");
        }

        protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
            AdjustSequenceNumber("UP");

        }

        protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
            AdjustSequenceNumber("DOWN");
        }
        private bool AdjustSequenceNumber(string strDirect)
        {
            //操作步骤：
            //1、获取当前所选中的关键字Mid。
            //2、根据关键字Mid来获取字的序号
            //3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字Mid
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            //7、重新显示DATAGRID
            ///
            int intSequenceNumber;	//当前记录的序号
            int intPrevSeqNum, intNextSeqNum;	//上下两条记录的序号
            string strMid;
            long lngMid;		//当前所选记录的关键字MId
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。
            strMid = (string)rd.Value;
            if (strMid.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的字段记录!";
                return false;
            }
            lblMsg2.Text = "";
            //2、根据关键字Mid来获取字的序号
            lngMid = long.Parse(strMid);
            clsPrjTabFldEN objPrjTabEN = clsPrjTabFldBL.GetObjBymId(lngMid);
            intSequenceNumber = objPrjTabEN.SequenceNumber ?? 0;
            intPrevSeqNum = intSequenceNumber - 1;
            intNextSeqNum = intSequenceNumber + 1;
            //3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            strCurrTabId = objPrjTabEN.TabId;		//获取当前记录的{表ID}
            intTabRecNum = clsPrjTabBL.GetRecCountByCond("TabId = '" + strCurrTabId + "'");	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intSequenceNumber <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
            
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSequenceNumber >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");

                }
            }
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("TabId = '{0}' and SequenceNumber = {1}",
                    strCurrTabId, intSequenceNumber - 1);
                arrID = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new Exception("获取上一条记录的关键字出错!");

                }
                if (arrID.Count <= 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");

                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("TabId = '{0}' and SequenceNumber = {1}",
                    strCurrTabId, intSequenceNumber + 1);
                arrID = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
       
                }
                if (arrID.Count <= 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
             
                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else
            {
                throw new Exception("方向参数出错!");    
            }
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            if (strDirect == "UP")
            {
             new   clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber - 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber + 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            //7、重新显示DATAGRID
            BindDg_PrjTabFld();
            return true;
        }

        protected void dgPrjTabFld_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
                BindDg_PrjTabFld();
                return;
            }
            //检查原来是升序
            intIndex = strSortPrjTabFldBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPrjTabFldBy = e.SortExpression + " Desc";
            }
            BindDg_PrjTabFld();
        }

        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
            string strFileName = objPrjTabEN.TabCnName + "(" + objPrjTabEN.TabName + ")字段信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("Caption"); arrCnName.Add("标题");
            arrColName.Add("DataTypeName"); arrCnName.Add("类型");
            arrColName.Add("FldLength"); arrCnName.Add("字段长度");
            arrColName.Add("IsTabNullable"); arrCnName.Add("是否可空");
            arrColName.Add("MinValue"); arrCnName.Add("最小值");
            arrColName.Add("MaxValue"); arrCnName.Add("最大值");
            arrColName.Add("DefaultValue"); arrCnName.Add("缺省值");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("是否唯一");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("主键类型");
            arrColName.Add("FieldTypeName"); arrCnName.Add("字段类型");
            arrColName.Add("IsParentObj"); arrCnName.Add("是否父对象");
            arrColName.Add("IsTabForeignKey"); arrCnName.Add("是否表外键");
            arrColName.Add("ForeignTabName"); arrCnName.Add("外键表名");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);

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


        private string strSortPrjTabFldBy
        {
            get
            {
                string sSortPrjTabFldBy;
                sSortPrjTabFldBy = (string)ViewState["SortPrjTabFldBy"];
                if (sSortPrjTabFldBy == null)
                {
                    sSortPrjTabFldBy = "";
                }
                return sSortPrjTabFldBy;
            }
            set
            {
                string sSortPrjTabFldBy = value;
                ViewState.Add("SortPrjTabFldBy", sSortPrjTabFldBy);
            }
        }
        private string strSortObjFldTabBy
        {
            get
            {
                string sSortObjFldTabBy;
                sSortObjFldTabBy = (string)ViewState["SortObjFldTabBy"];
                if (sSortObjFldTabBy == null)
                {
                    sSortObjFldTabBy = "";
                }
                return sSortObjFldTabBy;
            }
            set
            {
                string sSortObjFldTabBy = value;
                ViewState.Add("SortObjFldTabBy", sSortObjFldTabBy);
            }
        }

    }
}