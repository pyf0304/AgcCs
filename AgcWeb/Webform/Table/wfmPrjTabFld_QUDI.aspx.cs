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
using com.taishsoft.common;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;


using com.taishsoft.datetime;


namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI:表字段的维护
    /// </summary>
    public partial class wfmPrjTabFld_QUDI : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {

           
            //            Page.RegisterStartupScript("js", js1);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //1、为下拉框设置数据源，绑定列表数据
                //				wucPrjTabFld1.SetDdl_TabId();
                //				wucPrjTabFld1.SetDdl_FldID();
                wucPrjTabFld1.SetDdl_PrimaryTypeId();
                wucPrjTabFld1.SetDdl_ForeignKeyTabId(clsPubVar.CurrSelPrjId);
                wucPrjTabFld1.SetDdl_FieldTypeId();


                //BindDdl_PrjObjects(ddlPrjObject, clsPubVar.CurrSelPrjId);
                //2、显示无条件的表内容在DATAGRID中
                strSortPrjTabFldBy = "SequenceNumber Asc";
                strSortObjFldTabBy = "FldName Asc";

                BindDg_FldObjTab();
                BindGv_PrjTabFld();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                this.tabEditPrjTabFld.Visible = false;
                this.tabFieldTab.Visible = false;

                btnDelRec.Attributes.Add("onclick", "return confirm('您真的要删除所选记录吗？');");
                ///显示当前表名：
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
                lblCurrTabName.Text = objPrjTabEN.TabName + "(" + objPrjTabEN.TabCnName + ")";
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
        private string FldId
        {
            get
            {
                string strFldId;
                strFldId = (string)Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                Session.Add("FldId", strFldId);
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
            string strWhereCond = " 1=1 and TabId='" + TabId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。

            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
 
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
            this.dgObjFld4Sel.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_FldObjTab();
        }
       
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngMId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngMId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngMId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsPrjTabFldBL.IsExist(lngMId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngMId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjTabFldEN objPrjTabFld = new clsPrjTabFldEN(lngMId);
            //4、获取类对象的所有属性；
            clsPrjTabFldBL .GetPrjTabFld(ref objPrjTabFld);
            Session.Add("objPrjTabFld", objPrjTabFld);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromPrjTabFldClass(objPrjTabFld);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjPrjTabFld">表实体类对象</param>
        private void GetDataFromPrjTabFldClass(clsPrjTabFldEN pobjPrjTabFld)
        {
            wucPrjTabFld1.FldId = pobjPrjTabFld.FldId;
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(pobjPrjTabFld.FldId);
            clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            wucPrjTabFld1.FldName = objFieldTabEN.FldName + "(" + objFieldTabEN.Caption + ")";

            wucPrjTabFld1.IsTabUnique = pobjPrjTabFld.IsTabUnique;
            wucPrjTabFld1.IsTabNullable = pobjPrjTabFld.IsTabNullable;
            wucPrjTabFld1.IsParentObj = pobjPrjTabFld.IsParentObj;
            wucPrjTabFld1.PrimaryTypeId = pobjPrjTabFld.PrimaryTypeId;
            wucPrjTabFld1.FldOpTypeId = pobjPrjTabFld.FldOpTypeId;

            wucPrjTabFld1.IsTabForeignKey = pobjPrjTabFld.IsTabForeignKey;
            wucPrjTabFld1.ForeignKeyTabId = pobjPrjTabFld.ForeignKeyTabId;
            wucPrjTabFld1.FieldTypeId = pobjPrjTabFld.FieldTypeId;
            wucPrjTabFld1.MemoInTab = pobjPrjTabFld.MemoInTab;
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
            clsPrjTabFldEN objPrjTabFld;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    //					btnOKUpd.Text = "确认添加";
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
                    if (!wucPrjTabFld1.IsValid())
                    {
                        //						lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    //clsPrjTabFldEN objPrjTabFld;	//定义对象
                    objPrjTabFld = new clsPrjTabFldEN();	//初始化新对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToPrjTabFldClass(objPrjTabFld);		//把界面的值传到
                    //5、检查传进去的对象属性是否合法
                    ///
                    try
                    {
                         clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    if (clsPrjTabFldBL .AddNewRecordBySql2(objPrjTabFld) == false)
                    {
                        strMsg = "添加不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "添加记录不成功!";
                    }
                    else
                    {
                        strMsg = "添加记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "添加记录成功!";
                    }
                    //7、把新添的记录内容显示在DATAGRID中
                    BindGv_PrjTabFld();
                    wucPrjTabFld1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    //					btnOKUpd.Text = "添加";
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
                    if (!wucPrjTabFld1.IsValid())
                    {
                        //						lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objPrjTabFld = (clsPrjTabFldEN)Session["objPrjTabFld"];
                    PutDataToPrjTabFldClass(objPrjTabFld);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法
                    try
                    {
                         clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFld) == false)
                    {
                        strMsg = "修改记录不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "修改记录不成功!";
                    }
                    else
                    {
                        strMsg = "修改记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "修改记录成功!";
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    BindGv_PrjTabFld();
                    wucPrjTabFld1.Clear();//添空控件中的内容
                    //恢复<确认修改>变成<添加>
                    //					btnOKUpd.Text = "添加";
                    break;
            }
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjPrjTabFld">数据传输的目的类对象</param>
        private void PutDataToPrjTabFldClass(clsPrjTabFldEN pobjPrjTabFld)
        {
            pobjPrjTabFld.TabId = TabId;
            pobjPrjTabFld.FldId = wucPrjTabFld1.FldId;

            pobjPrjTabFld.IsTabUnique = wucPrjTabFld1.IsTabUnique;

            pobjPrjTabFld.IsTabNullable = wucPrjTabFld1.IsTabNullable;
            pobjPrjTabFld.IsParentObj = wucPrjTabFld1.IsParentObj;
            pobjPrjTabFld.PrimaryTypeId = wucPrjTabFld1.PrimaryTypeId;
            pobjPrjTabFld.FldOpTypeId = wucPrjTabFld1.FldOpTypeId;
            pobjPrjTabFld.IsTabForeignKey = wucPrjTabFld1.IsTabForeignKey;
            pobjPrjTabFld.ForeignKeyTabId = wucPrjTabFld1.ForeignKeyTabId;
            pobjPrjTabFld.FieldTypeId = wucPrjTabFld1.FieldTypeId;
            pobjPrjTabFld.MemoInTab = wucPrjTabFld1.MemoInTab;

        }

        protected void dgPrjTabFld_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngMId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngMId = long.Parse(e.Item.Cells[0].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsPrjTabFldBLEx.DelRecordEx(lngMId);
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //操作步骤：（总共2步）
                        //1、显示该关键字记录的内容在界面上；
                        //2、清空提示信息的内容,同时使<确定修改>按钮可用；

                        //1、显示该关键字记录的内容在界面上；
                        ShowData(lngMId);
                        //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                        //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                        //						btnOKUpd.Text = "确认修改";
                        //						lblMsg.Text = "";
                        break;

                    default:
                        // Do nothing.
                        break;
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

        private void BindDg_FldObjTab()
        {
            ///如何选择当前默认工程中的所有字段
            ///
            string strObjId = this.ddlPrjObject.SelectedValue;
            string strFldName = this.txtFldName.Text.Trim();

            StringBuilder sb = new StringBuilder();

            sb.Append("Select * ,");
            sb.Append(" DataTypeAbbr.DataTypeName DataTypeName");
            sb.Append(" from FieldTab");
            sb.Append(" left join DataTypeAbbr on (FieldTab.DataTypeId=DataTypeAbbr.DataTypeId)");
            if (strObjId == "0")
            {
                sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "'");
            }
            else
            {
                sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "' and  FldId in (select FldId from FldObjTab where ObjId='" + strObjId + "')");
            }
            if (string.IsNullOrEmpty(strFldName) == false)
            {
                sb.AppendFormat(" and FldName like '{0}%'", strFldName);
            }
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            DataTable objDt = objSQL.GetDataTable(sb.ToString());

            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDt.Rows.Count, dgObjFld4Sel.PageSize);
            if (intPages == 0)
            {
                dgObjFld4Sel.CurrentPageIndex = 0;
            }
            else if (dgObjFld4Sel.CurrentPageIndex > intPages - 1)
            {
                dgObjFld4Sel.CurrentPageIndex = intPages - 1;
            }
            DataView objDV = objDt.DefaultView;
            objDV.Sort = strSortObjFldTabBy;
            dgObjFld4Sel.DataSource = objDV;
            dgObjFld4Sel.DataBind();
            txtRecCount_PrjTabFld.Text = objDt.Rows.Count.ToString();
            chkSelAll_CheckedChanged(new object(), new System.EventArgs());
        }

        private void Add_ObjectFldtoPrjTabFld(ArrayList objArr)
        {
            string strTabId;
            bool bolIsnullable;
            int intTabFldCount;
            if (objArr.Count == 0)
            {
                return;
            }
            else
            {
                strTabId = TabId;
                if (strTabId.Length == 0)
                {
                    lblMsg1.Text = "请选择合适的表名";
                    return;
                }
                clsPrjTabFldEN objPrjTabFld;
                intTabFldCount = clsPrjTabFldBL.GetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
                foreach (string FldId in objArr)
                {

                    clsFieldTabEN objFieldTabEN = new clsFieldTabEN(FldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    bolIsnullable = objFieldTabEN.IsNull;
                    objPrjTabFld = new clsPrjTabFldEN();
                    objPrjTabFld.TabId = this.TabId;
                    objPrjTabFld.PrjId = clsPubVar.CurrSelPrjId;
                    objPrjTabFld.FldId = FldId;

                    objPrjTabFld.IsTabNullable = bolIsnullable;
                    objPrjTabFld.PrimaryTypeId = "00";
                    objPrjTabFld.FldOpTypeId = "0001";

                    objPrjTabFld.FieldTypeId = "01";
                    ///3.1、判断是否有相同的字段存在。					
                    if (clsPrjTabFldBLEx.IsExistSameFldId(TabId, FldId))	//判断是否有相同的关键字
                    {
                    }
                    else
                    {
                        objPrjTabFld.SequenceNumber = intTabFldCount + 1;
                        intTabFldCount++;
                        clsPrjTabFldBL .AddNewRecordBySql2(objPrjTabFld);
                    }
                }
            }
        }

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


        protected void btnAdd_Click(object sender, System.EventArgs e)
        {
            lblMsgEdit.Text = "";

            DispFieldTab();
        }

        protected void btnSetProperty_Click(object sender, System.EventArgs e)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；

            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //clsPubFun.SetButtonEnabled(btnOKUpd, true);
            //btnOKUpd.Text = "确认修改";

            lblMsgEdit.Text = "";

            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            lngmId = long.Parse(strmId);
            DispEditPrjTabFld();
            ShowData(lngmId);
            this.wucPrjTabFld1.SetKeyReadOnly(true);
                //				lblMsg.Text = "";
        }

        protected void btnDelRec_Click(object sender, System.EventArgs e)
        {
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            lngmId = long.Parse(strmId);
            clsPrjTabFldBLEx.DelRecordEx(lngmId);
            BindGv_PrjTabFld();
        }

        protected void btnOKEdit_Click(object sender, System.EventArgs e)
        {

            string strMsg;	//专门用于传递信息的变量
            //			string strCommandText;
            clsPrjTabFldEN objPrjTabFld;
            //这是一个单表的修改的代码，由于逻辑层太简单，
            //就把逻辑层合并到控制层,
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTabFld1.IsValid())
            {
                //				lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            objPrjTabFld = (clsPrjTabFldEN)Session["objPrjTabFld"];
            PutDataToPrjTabFldClass(objPrjTabFld);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            ///
            try
            {
                 clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
            }
            catch (Exception objException)
            {
                strMsg = "检查字段属性出错!\r\n" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }

            //4、把数据实体层的数据修改同步到数据库中
            ///
            try
            {
                if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFld) == false)
                {
                    strMsg = "修改记录不成功!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    //				lblMsg.Text = "修改记录不成功!";
                }
                else
                {
                    strMsg = "修改记录成功!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    //				lblMsg.Text = "修改记录成功!";
                    this.tabEditPrjTabFld.Visible = false;
                    //修改相关字段属性

                    if (clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabFld.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId) == false)
                    {
                        clsTabCheckStatusEN objPrjTab_CheckEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objPrjTabFld.TabId, objPrjTabFld.PrjId, clsPubVar.CurrPrjDataBaseId);
                        clsCommonJsFunc.Alert(this, objPrjTab_CheckEN.ErrorMsg);
                        //return;
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //5、把修改后的内容显示在DATAGRID中
            BindGv_PrjTabFld();
            wucPrjTabFld1.Clear();//添空控件中的内容
            DispPrjTabFldList();
            //恢复<确认修改>变成<添加>
            //			btnOKUpd.Text = "添加";
        }

        protected void btnOkAdd_Click(object sender, System.EventArgs e)
        {
            //			string strWhereCond;
            //string strFldId;
            //System.Data.DataTable objDT;
            ArrayList objArr = new ArrayList();
            //if (chkSelAll.Checked == true)
            //{
            //    //	1、组合界面条件串；
            //    //	2、根据条件串获取该表满足条件的DataTable；
           
            this.Add_ObjectFldtoPrjTabFld(objArr);
            BindGv_PrjTabFld();
            Response.Write("<script>alert('所选字段添加成功！！')</script>");
        }

        protected void dgObjFld4Sel_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgObjFld4Sel.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_FldObjTab();
        }

        protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Set_DataGridAllChecked(this.dgObjFld4Sel, this.chkSelAll);
        }

        protected void ddlPrjObject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindDg_FldObjTab();
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
                iNum[2] = 11;
                iNum[3] = 12;
                iNum[4] = 13;
                for (int i = 0; i < 5; i++)
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
            Response.Redirect(new clsCommonSession().BackErrPageEditFldLinkStr);
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
            long lngMid;		//当前所选记录的关键字MId
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。
            ///
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return false;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            lngMid = long.Parse(strmId);
            lblMsg2.Text = "";
            //2、根据关键字Mid来获取字的序号
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
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber - 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber + 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            //7、重新显示DATAGRID
            BindGv_PrjTabFld();
            clsCommForWebForm.SetCheckedItemForGv(gvPrjTabFld, 0, strmId);
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
                BindGv_PrjTabFld();
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
            BindGv_PrjTabFld();
        }

        protected void dgObjFld4Sel_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortObjFldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortObjFldTabBy = e.SortExpression + " Asc";
                BindDg_FldObjTab();
                return;
            }
            //检查原来是升序
            intIndex = strSortObjFldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortObjFldTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortObjFldTabBy = e.SortExpression + " Desc";
            }
            BindDg_FldObjTab();
        }

        protected void dgObjFld4Sel_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortObjFldTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgObjFld4Sel.Columns.Count; i++)
                {
                    strSortEx = this.dgObjFld4Sel.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortObjFldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortObjFldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        protected void dgObjFld4Sel_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 5;
                //				iNum[1] = 7;
                for (int i = 0; i < 1; i++)
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

        //protected void btnCopyFldFromRelaObj_Click(object sender, System.EventArgs e)
        //{
        //    //操作步骤：
        //    //1、获取当前表ID的相关对象ID；
        //    //2、获取相关对象ID的字段ID的DataTable;
        //    //3、对该表进行循环，把字段信息插入到一个ArrayList
        //    //4、在插入过程中，要注意字段ID的重复，不能插入重复
        //    //			string strWhereCond;
        //    string strFldId;
        //    System.Data.DataTable objDT;
        //    ArrayList objArr = new ArrayList();
        //    string strObjId;

        //    //1、获取当前表ID的相关对象ID；
        //    strObjId = (clsPrjTabBL.GetObjByTabId(TabId).ObjId);
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    //2、获取相关对象ID的字段ID的DataTable;
        //    objDT = clsFldObjTabBL.GetDataTable_FldObjTab("ObjId = '" + strObjId + "'");
        //    //3、对该表进行循环，把字段信息插入到一个ArrayList
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        strFldId = objRow["FldId"].ToString();
        //        objArr.Add(strFldId);
        //    }
        //    //4、在插入过程中，要注意字段ID的重复，不能插入重复
        //    this.Add_ObjectFldtoPrjTabFld(objArr);
        //    BindGv_PrjTabFld();
        //    Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");

        //}

        protected void btnSetFldProperty_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("FieldTab_U");
        }

        protected void lbDispTabFld_Click(object sender, System.EventArgs e)
        {
            DispPrjTabFldList();
        }

        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond + " order by SequenceNumber");
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
            arrColName.Add("FieldTypeName"); arrCnName.Add("字段类型");

            arrColName.Add("PrimaryTypeName"); arrCnName.Add("主键类型");
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

        protected void lbMoveRecTo_Click(object sender, System.EventArgs e)
        {
            long lngMid;
            int intNewSeqNum = 0;	//准备移到的新序号
            List<string> arrList = new List<string>();
            int intSeqNum;
            lblMsg2.Text = "";
            
            //获取当前记录的序号
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            lngMid = long.Parse(strmId);
            arrList = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "Mid = " + lngMid.ToString());
            if (arrList == null)
            {
                lblMsg2.Text = "序号不正常!";
                return;
            }
            intSeqNum = int.Parse(arrList[0].ToString());
            if (rblSeqNum.SelectedIndex == 0)
            {
                intNewSeqNum = 1;
            }
            else if (rblSeqNum.SelectedIndex == 1)
            {
                intNewSeqNum = -1;
            }
            else if (rblSeqNum.SelectedIndex == 2)
            {
                if (txtRecSeqNum.Text == "")
                {
                    lblMsg2.Text = "请输入新的序号!";
                    return;
                }
                intNewSeqNum = int.Parse(txtRecSeqNum.Text);
            }
            string strFileFolder = Server.MapPath("~");
            bool bolIsSuccess = (new clsPrjTabFldBLEx().MoveRecSeqTo(TabId, intSeqNum, intNewSeqNum));
            if (bolIsSuccess == true)
            {
                BindGv_PrjTabFld();
                clsCommForWebForm.SetCheckedItemForGv(gvPrjTabFld, 0, strmId);
            }

        }

        protected void lbDispTabFld2_Click(object sender, System.EventArgs e)
        {
            DispPrjTabFldList();
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
                string sSortBy;
                sSortBy = (string)ViewState["SortObjFldTabBy"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("SortObjFldTabBy", sSortBy);
            }
        }
        private void DispEditPrjTabFld()
        {
            tabEditPrjTabFld.Visible = true;
            tabPrjTabFld.Visible = false;
            this.tabFieldTab.Visible = false;

        }
        private void DispFieldTab()
        {
            this.tabFieldTab.Visible = true;
            tabEditPrjTabFld.Visible = false;
            tabPrjTabFld.Visible = false;

        }

        private void DispPrjTabFldList()
        {
            tabPrjTabFld.Visible = true;
            tabEditPrjTabFld.Visible = false;
            tabFieldTab.Visible = false;
        }

        //protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        //{
        //    //操作步骤：
        //    //1、获取当前表ID的相关对象ID；
        //    //2、获取相关对象ID的字段ID的DataTable;
        //    //3、对该表进行循环，把字段信息插入到一个ArrayList
        //    //4、在插入过程中，要注意字段ID的重复，不能插入重复
        //    //			string strWhereCond;
        //    string strObjId;
        //    //1、获取当前表ID的相关对象ID；

        //    strObjId = clsPrjTabBL.GetObjByTabId(TabId).ObjId;
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
        //        {
        //            Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！！')</script>");
        //        }
        //        BindGv_PrjTabFld();
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = "同步对象字段与表字段不成功!\r\n" + objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsPrjTabFldBLEx.ReOrder(TabId);
            BindGv_PrjTabFld();
        }

        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;

            Response.Redirect("wfmPrjTab_CheckConsistency.aspx");
        }
        protected void lbGeneLogicCode_Click(object sender, EventArgs e)
        {
            new clsCommonSession().GenCode4TabType = "Logic";
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenCode4TabV6.aspx','aa'); </script>";
            Response.Write(c1);

        }
        protected void lbGeneLogicCodeEx_Click(object sender, EventArgs e)
        {
            new clsCommonSession().GenCode4TabType = "LogicEx";
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenCode4TabV6.aspx','aa'); </script>";
            Response.Write(c1);

        }
        protected void gvPrjTabFld_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int[] iNum = new int[20];
                iNum[0] = 6;
                iNum[1] = 7;
                iNum[2] = 10;
                iNum[3] = 11;
                iNum[4] = 12;
                for (int i = 0; i < 5; i++)
                {
                    if (e.Row.Cells[iNum[i]].Text == "True")
                    {
                        e.Row.Cells[iNum[i]].Text = "√";
                        e.Row.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Row.Cells[iNum[i]].Text = "×";
                        e.Row.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }

            }
        }
}

    public partial class wfmPrjTabFld_QUDI : CommWebPageBase
    {

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTabFld.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTabFld.PageCount)
                {
                    this.gvPrjTabFld.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTabFld();
            }
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjTabFld.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjTabFld();
        }
        protected void gvPrjTabFld_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld();
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvPrjTabFld_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjTabFld_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjTabFldBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPrjTabFldBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvPrjTabFld_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvPrjTabFld.DataKeys[e.RowIndex].Value.ToString();
            long lngmId = long.Parse(strmId);
            DeletePrjTabFldRecord(lngmId);
        }
        ///
        protected void gvPrjTabFld_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvPrjTabFld.DataKeys[e.RowIndex].Value.ToString();
            long lngmId = long.Parse(strmId);
            UpdatePrjTabFldRecord(lngmId);
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_PrjTabFld()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFldBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvPrjTabFld.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvPrjTabFld.PageSize = 10;
            }
            this.gvPrjTabFld.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjTabFld.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjTabFld.BottomPagerRow;
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
                lblAllPages.Text = this.gvPrjTabFld.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjTabFld.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjTabFld.PageIndex == this.gvPrjTabFld.PageCount - 1)
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
            gvPrjTabFld.BottomPagerRow.Visible = true;
        }

        ///删除记录过程代码for C#
        protected void DeletePrjTabFldRecord(long lngmId)
        {
            try
            {
                clsPrjTabFldBLEx.DelRecordEx(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld();
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdatePrjTabFldRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKEdit, true);
            btnOKEdit.Text = "确认修改";
            lbDispTabFld2.Text = "取消修改";
            lblMsgEdit.Text = "";
            //DispEditPrjTabFldRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdatePrjTabFldRecordSave(clsPrjTabFldEN objPrjTabFld)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTabFld1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabFldClass(objPrjTabFld);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                 clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjTabFldBL .UpdateBySql2(objPrjTabFld);
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
            //BindGv_PrjTabFld();
            //DispPrjTabFldListRegion();
            wucPrjTabFld1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKEdit.Text = "添加";
            //btnCancelPrjTabFldEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdatePrjTabFldRecordSaveV5(clsPrjTabFldEN objPrjTabFld)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
          
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTabFld1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabFldClass(objPrjTabFld);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjTabFldBL .UpdateBySql2(objPrjTabFld);
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
            BindGv_PrjTabFld();
            //DispPrjTabFldListRegion();
            wucPrjTabFld1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKEdit.Text = "添加";
            //btnCancelPrjTabFldEdit.Text = "取消编辑";
            return true;
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
                    BindGv_PrjTabFld();
                }
            }
        }
        protected void gvPrjTabFld_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld();
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
            BindGv_PrjTabFld();
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

            switch (strPageName)
            {
                case "FieldTab_U":
                    string strMid;
                    long lngMid;        //当前所选记录的关键字MId
                                        //1、获取当前所选中的字段ID。
                    strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
                    if (strMid.Trim().Length == 0)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的字段记录!";
                        return;
                    }
                    lngMid = long.Parse(strMid);
                    string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;
                    FldId = strFldId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToFieldTab_U(this, "", strFldId, strCurrPageName);
                    break;

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