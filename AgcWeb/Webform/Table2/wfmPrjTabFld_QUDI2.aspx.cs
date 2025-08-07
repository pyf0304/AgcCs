
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{

    public partial class wfmPrjTabFld_QUDI2 : CommWebPageBase
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
                    EditPrjTabFieldByTabId(clsCommonSession.TabId);
                }
                else
                {
                    EditPrjTabFieldByTabId(clsCommonSession.TabId);
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

        #region "编辑工程表字段(PrjTabFields)"
        private void EditPrjTabFieldByTabId(string strTabId)
        {
            btnOKEdit.Text = "确认修改";
            BindDdl4PrjTabFieldByTable();
            BindGv_PrjTabFld();
            //3、设置表控件中字控件的ReadOnly属性，
            //   使之只读，因为在修改功能中关键字是不能被修改的。
            this.tabEditPrjTabFld.Visible = false;
            this.tabFieldTab.Visible = false;

            //            DispFieldTabListRegion();
            //            ShowFieldTabData(strTabId);

        }
        /// <summary>
        /// 绑定专门用于工程表的下拉框
        /// </summary>
        private void BindDdl4PrjTabFieldByTable()
        {
            wucPrjTabFld1.SetDdl_PrimaryTypeId();
            wucPrjTabFld1.SetDdl_ForeignKeyTabId(clsPubVar.CurrSelPrjId);
            wucPrjTabFld1.SetDdl_FieldTypeId();
            //clsvPrjObjects4DdlBLEx.BindDdl_PrjObjects(ddlPrjObject, clsPubVar.CurrSelPrjId);
            //2、显示无条件的表内容在DATAGRID中
            strSortPrjTabFldBy = "SequenceNumber Asc";
            strSortObjFldTabBy = "FldName Asc";

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
            clsPrjTabFldBL.GetPrjTabFld(ref objPrjTabFld);
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
                        clsPrjTabFldBL.CheckPropertyNew(objPrjTabFld);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    if (clsPrjTabFldBL.AddNewRecordBySql2(objPrjTabFld) == false)
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
                        clsPrjTabFldBL.CheckPropertyNew(objPrjTabFld);
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
            pobjPrjTabFld.TabId = clsCommonSession.TabId;
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
                        BindGv_PrjTabFld();
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

        private void BindDg_FldObjTab()
        {
            ///如何选择当前默认工程中的所有字段
            ///
            string strObjId = this.ddlPrjObject.SelectedValue;
            string strFldName = this.txtFldName.Text.Trim();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Select * ,");
            //sb.Append(" DataTypeAbbr.DataTypeName DataTypeName");
            //sb.Append(" from FieldTab");
            //sb.Append(" left join DataTypeAbbr on (FieldTab.DataTypeId=DataTypeAbbr.DataTypeId)");
            //if (strObjId == "0")
            //{
            //    sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "'");
            //}
            //else
            //{
            //    sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "' and  FldId in (select FldId from FldObjTab where ObjId='" + strObjId + "')");
            //}
            //if (string.IsNullOrEmpty(strFldName) == false)
            //{
            //    sb.AppendFormat(" and FldName like '{0}%'", strFldName);
            //}

            StringBuilder sbCondition = new StringBuilder();
            if (strObjId == "0")
            {
                sbCondition.Append(" PrjId='" + clsPubVar.CurrSelPrjId + "'");
            }
            else
            {
                sbCondition.Append(" PrjId='" + clsPubVar.CurrSelPrjId + "' and  FldId in (select FldId from FldObjTab where ObjId='" + strObjId + "')");
            }
            if (string.IsNullOrEmpty(strFldName) == false)
            {
                sbCondition.AppendFormat(" and FldName like '{0}%'", strFldName);
            }
            DataTable objDt = clsvFieldTabBL.GetDataTable_vFieldTab(sbCondition.ToString());

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
                strTabId = clsCommonSession.TabId;
                if (strTabId.Length == 0)
                {
                    lblMsg_Field.Text = "请选择合适的表名";
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
                    objPrjTabFld.TabId = clsCommonSession.TabId;
                    objPrjTabFld.PrjId = clsPubVar.CurrSelPrjId;
                    objPrjTabFld.FldId = FldId;

                    objPrjTabFld.IsTabNullable = bolIsnullable;
                    objPrjTabFld.PrimaryTypeId = "00";
                    objPrjTabFld.FldOpTypeId = "0001";

                    objPrjTabFld.FieldTypeId = "01";
                    ///3.1、判断是否有相同的字段存在。					
                    if (clsPrjTabFldBLEx.IsExistSameFldId(clsCommonSession.TabId, FldId))	//判断是否有相同的关键字
                    {
                    }
                    else
                    {
                        objPrjTabFld.SequenceNumber = intTabFldCount + 1;
                        intTabFldCount++;
                        clsPrjTabFldBL.AddNewRecordBySql2(objPrjTabFld);
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
            lblMsg_Field.Text = "";

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
            long lngMid;		//当前所选记录的关键字MId
            //1、获取当前所选中的字段ID。
            ///
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            lngMid = long.Parse(strmId);
            string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;

            lblMsgList.Text = "";

            DispEditPrjTabFld();
            ShowData(lngMid);
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
                clsPrjTabFldBL.CheckPropertyNew(objPrjTabFld);
            }
            catch (Exception objException)
            {
                strMsg = "检查字段属性出错!\r\n" + objException.Message;
                lblMsg_Field.Text = strMsg;
                return;
            }

            //4、把数据实体层的数据修改同步到数据库中
            ///
            try
            {
                if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFld) == false)
                {
                    strMsg = "修改记录不成功!";
                    lblMsg_Field.Text = "修改记录不成功!";
                }
                else
                {
                    strMsg = "修改记录成功!";
                    lblMsg_Field.Text = "修改记录成功!";
                    this.tabEditPrjTabFld.Visible = false;
                    //修改相关字段属性

                    if (clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabFld.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId) == false)
                    {
                        clsTabCheckStatusEN objPrjTab_CheckEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objPrjTabFld.TabId, objPrjTabFld.PrjId, clsPubVar.CurrPrjDataBaseId);
                        lblMsg_Field.Text = objPrjTab_CheckEN.ErrorMsg;
                        //return;
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
            ArrayList objArr = new ArrayList();
            //if (chkSelAll.Checked == true)
            //{
            //    //	1、组合界面条件串；
            //    //	2、根据条件串获取该表满足条件的DataTable；
            //    objDT = clsFldObjTabBL.GetDataTable_FldObjTab("ObjId = '" + ddlPrjObject.SelectedValue + "'");
            //    foreach (DataRow objRow in objDT.Rows)
            //    {
            //        strFldId = objRow["FldId"].ToString();
            //        objArr.Add(strFldId);
            //    }
            //}
            //else
            //{
            //    this.Get_ObjectFldArrylist(this.dgObjFld4Sel, objArr);
            //}
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
            //JumpOtherPages();
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
            //string strMid;
            long lngMid;		//当前所选记录的关键字MId
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。
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
        //    //strObjId = (clsPrjTabBL.GetObjByTabId(clsCommonSession.TabId).ObjId);
        //    //if (strObjId == null || strObjId.Length == 0)
        //    //{
        //    //    return;
        //    //}
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
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(clsCommonSession.TabId);
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
            bool bolIsSuccess = (new clsPrjTabFldBLEx().MoveRecSeqTo(clsCommonSession.TabId, intSeqNum, intNewSeqNum));
            if (bolIsSuccess == true)
            {
                BindGv_PrjTabFld();
                clsCommForWebForm.SetCheckedItemForGv(gvPrjTabFld, 0, strmId);
            }

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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
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
        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            string strTabId = clsCommonSession.TabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            clsCommonSession.TabId = strTabId;
            clsCommonSession.ParentPage = "wfmEditTabAndObjectFields";
            BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
            if (clsPubVar.CurrDataBaseTypeId == "03")
            {
                Response.Redirect("wfmPrjTab_CheckConsistency_Ora.aspx");
            }
            else
            {
                Response.Redirect("wfmPrjTab_CheckConsistency.aspx");
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

        //    strObjId = clsPrjTabBL.GetObjByTabId(clsCommonSession.TabId).ObjId;
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
        //        {
        //            lblErrMsg.Text = "与相关对象复制字段信息成功！！";
        //        }
        //        else
        //        {
        //            lblErrMsg.Text = "该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！";
        //        }
        //        BindGv_PrjTabFld();
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = "同步对象字段与表字段不成功!" + objException.Message;
        //        ErrorInformationBL.AddInformation("", "lbSynchWithTab_Click", "同步对象字段与表字段不成功!" + objException.Message, clsCommonSession.UserId);
        //        lblErrMsg.Text = strMsg;
        //        //clsCommonSession.seErrMessage = "同步对象字段与表字段不成功!\r\n" + objException.Message;
        //        //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        //clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsPrjTabFldBLEx.ReOrder(clsCommonSession.TabId);
            BindGv_PrjTabFld();
        }

        ///生成与跳页的相关函数
        protected void btnJumpPagePrjTabFld_Click(object sender, EventArgs e)
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
        protected void btnSetCanNull_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsTabNullable = true;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
            }
            BindGv_PrjTabFld();
        }
        protected void btnSetCanNotNull_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsTabNullable = false;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
            }
            BindGv_PrjTabFld();
        }


        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinePrjTabFldCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and TabId='" + clsCommonSession.TabId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。

            return strWhereCond;
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

        #endregion

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