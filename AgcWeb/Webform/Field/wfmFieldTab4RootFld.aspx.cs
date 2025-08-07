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
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.datetime;



//public class ObjStruct
//{
//    public string strObjId;
//    public string strObjName;
//}

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFieldTab4RootFld : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                lbDelFld.Attributes.Add("onclick", "return confirm('您真的要删除所选的记录吗？');");
                //1、为下拉框设置数据源，绑定列表数据
                wucFieldTab1.SetDdl_PrjId();
                wucFieldTab1.SetDdl_FldType();
                wucFieldTab1.SetDdl_IsNull();
                //				wucFieldTab1.SetDdl_IsPrimaryKey();
                wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);
                wucFieldTab1.SetDdl_CodeTab();
                wucFieldTab1.SetDdl_FldStateId();

                //clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
                BindDdl_IsNull(ddlIsNullq);
                BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                clsDropDownList.BindDdl_TrueAndFalse(ddlIsRootFld);
                //ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
                BindDdl_IsNull(ddlIsNull);
                BindDdl_IsPrimaryKey(ddlIsPrimaryKey);
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
                //				clsDropDownList.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsFieldTabBLEx.BindDdl_FldID4RootEx(ddlFldId4Root, clsPubVar.CurrSelPrjId);
                ddlFldStateIdq.SelectedValue = "01";

                vsSortFieldTabBy = "FldName Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_vFieldTab4RootFld();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucFieldTab1.SetKeyReadOnly(true);
                tabLayout.Visible = false;
                txtFldLength.Text = "0";
                HideAdvanceQuery();

                if (clsCommonSession.RoleId == "00050001" || clsCommonSession.RoleId == "00050006")
                {
                    lbDelFieldTabEx.Visible = true;
                }
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
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
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
        ///生成专门用于记录GridView中的每页记录数
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
        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinevFieldTab4RootFldCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。

            if (this.txtFldNameq.Text.Trim() != "")
            {
                strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim() + "%'";
            }
            if (this.txtCaptionq.Text.Trim() != "")
            {
                strWhereCond += " and Caption like '%" + this.txtCaptionq.Text.Trim() + "%'";
            }
            if (this.ddlFldTypeq.SelectedValue != "" && this.ddlFldTypeq.SelectedValue != "0")
            {
                strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
            }
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                //      strWhereCond += " and Fldid in (select fldid from PrjTabFld where TabId='" + this.ddlTabIdq.SelectedValue + "')";
                strWhereCond += string.Format(" and TabId='{0}'",
                    this.ddlTabIdq.SelectedValue);
            }
            if (this.ddlIsNullq.SelectedValue == "是")
            {
                strWhereCond += " and IsNull='1'";
            }
            else if (this.ddlIsNullq.SelectedValue == "否")
            {
                strWhereCond += " and IsNull='0'";
            }
            if (this.ddlIsPrimaryKeyq.SelectedValue == "是")
            {
                strWhereCond += " and IsPrimaryKey='1'";
            }
            else if (this.ddlIsPrimaryKeyq.SelectedValue == "否")
            {
                strWhereCond += " and IsPrimaryKey='0'";
            }
            if (this.ddlIsRootFld.SelectedValue == "是")
            {
                strWhereCond += string.Format(" and {0}='1'", conFieldTab4RootFld.IsRootFld);
            }
            else if (this.ddlIsRootFld.SelectedValue == "否")
            {
                strWhereCond += string.Format(" and {0}='0'", conFieldTab4RootFld.IsRootFld);
            }
            if (this.ddlFldStateIdq.SelectedValue != "" && this.ddlFldStateIdq.SelectedValue != "0")
            {
                strWhereCond += " And FldStateId='" + this.ddlFldStateIdq.SelectedValue + "'";
            }

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

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.wucvFieldTab4RootFld4Gv1.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_vFieldTab4RootFld();
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strFldID">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strFldID)
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
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);
            Session.Add("objFieldTabEN", objFieldTabEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromFieldTabClass(objFieldTabEN);
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
            wucFieldTab1.FldPrecision = pobjFieldTab.FldPrecision ?? 0;

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
                    btnOKUpd.Text = "确认添加";
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
                        foreach (ObjStruct objObjStruct in arrObjStructLst)
                        {
                            if (clsPrjTabFldBLEx .Add_FieldTabToPrjTabFld(objObjStruct.strObjId, objFieldTabEN.FldId, clsCommonSession.UserId) == false) break;
                        }
                    }
                    //7、把新添的记录内容显示在DATAGRID中
                    BindGv_vFieldTab4RootFld();
                    wucFieldTab1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpd.Text = "添加";
                    tabLayout.Visible = false;
                    tabQuery.Visible = true;
                    try
                    {
                        //添加日志
                        string strUserId = clsCommonSession.UserId;
                        string strUserIp = Request.UserHostAddress;
                        string strUserName = clsUsersBL.GetObjByUserId(strUserId).UserName;
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
                        try
                        {
                            if (objFieldTabEN.CheckUniqueness() == false)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在工程：{0}中，", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                                sbMsg.AppendFormat("字段名：{0}，", objFieldTabEN.FldName);
                                sbMsg.AppendFormat("字段类型：{0}已经存在，请从当前表字段中删除该字段，重新添加新的字段。", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                                return;
                            }

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
                                clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(objFieldTabEN.FldId, clsCommonSession.UserId);

                                strMsg = "修改记录成功!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "修改记录成功!";
                           
                                arrObjStructLst = wucFieldTab1.TabList;
                                List<string> arrTarTabIdLst = new List<string>();
                                foreach(ObjStruct objTab in arrObjStructLst)
                                {
                                    arrTarTabIdLst.Add(objTab.strObjId);
                                }
                                clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);

                            }
                            //5、把修改后的内容显示在DATAGRID中
                            BindGv_vFieldTab4RootFld();
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
//                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                        wucFieldTab1.Clear();//添空控件中的内容
                    }
                    //恢复<确认修改>变成<添加>
                    btnOKUpd.Text = "添加";
                    tabLayout.Visible = false;
                    tabQuery.Visible = true;
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
            pobjFieldTab.FldPrecision = wucFieldTab1.FldPrecision;

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

        private void DeleteRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                clsFieldTabBL.DelRecord(strFldId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFieldTab4RootFld();

        }
        private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }

            }
        }


        
     
       
        public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }
        public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }

        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 8;
                iNum[1] = 9;
                iNum[2] = 10;
                for (int i = 0; i < 3; i++)
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
        /// <summary>
        /// 导入Excel文件的字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
        {
           Response.Redirect("wfmImportFldInfoFromExcel.aspx");
        }

        protected void lbAddNewFld_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = false;
            tabLayout.Visible = true;
            wucFieldTab1.Clear();
            wucFieldTab1.SetKeyReadOnly(false);
            wucFieldTab1.PrjId = clsPubVar.CurrSelPrjId;
            
            wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            btnOKUpd.Text = "确认添加";
        }

        protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromSQL.aspx");

        }

        protected void lbDispFieldList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
            tabLayout.Visible = false;
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

                BindGv_vFieldTab4RootFld();
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
                }
                //7、把新添的记录内容显示在DATAGRID中
                BindGv_vFieldTab4RootFld();
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
            pobjFieldTab.FldPrecision = FldPrecision;

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


        protected void lbDelFld_Click(object sender, System.EventArgs e)
        {
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in lstFldID)
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
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex >= 1)
                {
                    foreach (string strFldId in lstFldID)
                    {
                        clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
                    }
                    //string strMsg = "请选择一个合适的对象名!";
                    //clsCommonJsFunc.Alert(this, strMsg);
                    //return;
                }
                else
                {
                    foreach (string strFldId in lstFldID)
                    {
                        clsFieldTabBL.DelRecord(strFldId);
                    }
                }
                //clsFieldTabBLEx.DelFieldTabEx(objArr);

            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");
        }

        //protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    string strObjId = ddlTabIdq.SelectedValue;
        //    List<string> arrLst = new List<string>();
        //    arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
        //    if (arrLst == null || arrLst.Count == 0)
        //        return;
          
        //}
        /// <summary>
        /// 将所选对象的所有字段，复制到相关表中，同时删除对象中没有的字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        {
            //操作步骤：
            //1、获取当前表ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环，把字段信息插入到一个ArrayList
            //4、在插入过程中，要注意字段ID的重复，不能插入重复
            //			string strWhereCond;
            string strObjId;
            //1、获取当前表ID的相关对象ID；
            strObjId = ddlTabIdq.SelectedValue;
            if (strObjId == null || strObjId.Length == 0)
            {
                return;
            }
            //if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
            //{
            //    Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！！')</script>");
            //}



        }

        protected void btnQueryForAdvanced_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.wucvFieldTab4RootFld4Gv1.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_vFieldTab4RootFld();
        }
        private void DispAdvanceQuery()
        {
            tabAdvanceQuery.Visible = true;
        }
        private void HideAdvanceQuery()
        {
            tabAdvanceQuery.Visible = false;
        }

        protected void lbAdvanceQuery_Click(object sender, System.EventArgs e)
        {
            DispAdvanceQuery();
        }

        protected void lbHideAdvanceQuery_Click(object sender, System.EventArgs e)
        {
            HideAdvanceQuery();
        }

        protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlFuncModuleIdq.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void lbDelFieldTabEx_Click(object sender, System.EventArgs e)
        {
            string strUserIp = Request.UserHostAddress;
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
        
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in lstFldID)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

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
                if (strUserIp =="::1" || strUserIp == "127.0.0.1" 
                    || strUserIp == "59.78.151.114" || strUserIp == "59.78.151.116")
                {
                    clsFieldTabBLEx.DelFieldTabEx2(lstFldID);
                }
                else
                {
                    clsCommonJsFunc.Alert(this, "删除该字段应该在特定的IP地址！不能在：" + strUserIp);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

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
        /// <summary>
        /// 小数位数
        /// </summary>
        public int FldPrecision
        {
            get
            {
                return int.Parse(txtFldPrecision.Text.Trim());
            }
            set
            {
                txtFldPrecision.Text = value.ToString();
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
        //public string ObjId
        //{
        //    get
        //    {
        //        if (ddlObjId.SelectedValue == "0")
        //        {
        //            return "";
        //        }
        //        return ddlObjId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlObjId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            ddlObjId.SelectedValue = value;
        //        }
        //    }

        //}

        protected void lbUpdate_Click(object sender, EventArgs e)
        {
            string strFldID = wucvFieldTab4RootFld4Gv1.GetFirstCheckedKeyFromGv();
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ShowData(strFldID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            DispEditFieldTabRegion();
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
                clsPubFun4BLEx.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);

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
            btnOKUpd.Text = "添加";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_vFieldTab4RootFld();
            DispFieldTabListRegion();
        }
        private void UpdateFieldTabRecord(string strFldID)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFldID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsg.Text = "";
            DispEditFieldTabRegion();
        }
        private void DispFieldTabListRegion()
        {
            tabQuery.Visible = true;
            tabLayout.Visible = false;
        }
        private void DispEditFieldTabRegion()
        {
            tabQuery.Visible = false;
            tabLayout.Visible = true;
        }
       
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vFieldTab4RootFld()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevFieldTab4RootFldCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvFieldTab4RootFld4Gv1.BindGv_FieldTab(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvFieldTab4RootFld4Gv1.SetGvVisibility(constwucvFieldTab4RootFld4Gv.UpdDate, false);
                //wucvFieldTab4RootFld4Gv1.SetGvVisibility(constFieldTab.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //foreach (GridViewRow di in objGv.Rows)
                //{
                //    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                //    if (chkCheckRec != null && chkCheckRec.Checked)
                //    {
                //        return di.Cells[1].Text;

                //    }
                //}
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return objGv.DataKeys[iRow].Value.ToString();
                    }
                }
            }
            return "";
        }
        protected ArrayList GetAllCheckedItemFromGv1(System.Web.UI.WebControls.GridView objGv, string strChkName)
        {
            ArrayList arr = new ArrayList();
            if (objGv.Rows.Count == 0)
            {
                return arr;
            }
            else
            {
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl(strChkName);
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(objGv.DataKeys[iRow].Value.ToString());
                    }
                }
                return arr;
            }
        }
        ///删除记录过程代码for C#
        protected void DeleteFieldTabRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                //判断是否有选中的对象ID
                string strTabId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex < 1)
                {
                    string strMsg = "请选择一个合适的表名!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                clsFieldTabBLEx.DelFieldTabBySp(strFldId, strTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFieldTab4RootFld();
        }
       
        
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_vFieldTab4RootFld();
        }
        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //复制字段
            CopyField();
        }

        protected void btnExportExcel4Gv_Click(object sender, EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevFieldTab4RootFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FieldTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("FldId"); arrCnName.Add("字段ID");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("Caption"); arrCnName.Add("标题");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("FldLength"); arrCnName.Add("字段长度");
            arrColName.Add("IsNull"); arrCnName.Add("是否可空");
            arrColName.Add("IsPrimaryKey"); arrCnName.Add("是否主键");
            arrColName.Add("IsIdentity"); arrCnName.Add("是否Identity");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("是否唯一");
            arrColName.Add("TabNum"); arrCnName.Add("表数");

            arrColName.Add("MaxValue"); arrCnName.Add("最大值");
            arrColName.Add("MinValue"); arrCnName.Add("最小值");
            arrColName.Add("DefaultValue"); arrCnName.Add("缺省值");
            arrColName.Add("FldName_G"); arrCnName.Add("字段名_国标");
            arrColName.Add("FldName_B"); arrCnName.Add("字段名_后备");
            arrColName.Add("IsNationStandard"); arrCnName.Add("是否国标");

            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("CodeTab"); arrCnName.Add("代码表");
            arrColName.Add("CodeTabName"); arrCnName.Add("代码表_名称");
            arrColName.Add("CodeTabCode"); arrCnName.Add("代码表_代码");
            arrColName.Add("AppliedScope"); arrCnName.Add("应用范围");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("OraDbType"); arrCnName.Add("Ora数据类型");
            arrColName.Add("FldBName_B"); arrCnName.Add("FldBName_B");
            arrColName.Add("FldInfo"); arrCnName.Add("字段信息");
            
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
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

        protected void lbRefreshUpdDate4RelaTab_Click(object sender, EventArgs e)
        {

            string strFldID = wucvFieldTab4RootFld4Gv1.GetFirstCheckedKeyFromGv();
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(strFldID, clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, "刷新相关表修改日期完成！");
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnSetIsRootFld_Click(object sender, EventArgs e)
        {
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFldID in lstFldID)
                {
                    //clsFieldTab4RootFldEN objFieldTabEN = clsFieldTab4RootFldBLEx.GetObjBy(strFldID);
                    //if (objFieldTabEN.IsRootFld == true)
                    //{
                    //    objFieldTabEN.IsRootFld = false;
                    //}
                    //else
                    //{
                    //    objFieldTabEN.IsRootFld = true;
                    //}
                    //objFieldTabEN.UpdateRecordEx();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "设置是否根字段不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFieldTab4RootFld();
        }

        protected void btnSetRootFld_Click(object sender, EventArgs e)
        {
            if (ddlFldId4Root.SelectedIndex<=0)
            {
                ddlFldId4Root.Focus();
                string strMsg = "请选择根字段!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strFldId4Root = ddlFldId4Root.SelectedValue;
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFldID in lstFldID)
                {
                    //clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);                    
                    //    objFieldTabEN.RootFldId = strFldId4Root;
                    //objFieldTabEN.UpdateRecordEx();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "设置根字段不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFieldTab4RootFld();
        }

        protected void lbAutoSetRootFld_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}' order by {4}", 
                conPrjTab.PrjId, clsCommonSession.CurrSelPrjId, 
                conPrjTab.TabStateId, enumTabState.Normal_01,
                conPrjTab.SqlDsTypeId);
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            foreach(clsPrjTabEN objInFor in arrPrjTabObjLst)
            {                
                List<clsPrjTabFldEN> arrPrjTabFldObjLst = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objInFor.TabId, objInFor.PrjId);
                foreach(clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjLst)
                {
                    strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                       conFieldTab4RootFld.TabId, objInFor.TabId,
                       conFieldTab4RootFld.FldId, objPrjTabFldEN.FldId);

                    clsFieldTab4RootFldEN objFieldTab = clsFieldTab4RootFldBL.GetFirstObj_S(strCondition);
                    bool bolIsExist = true;
                    if (objFieldTab == null)
                    {
                        objFieldTab = new clsFieldTab4RootFldEN();
                        objFieldTab.TabId = objInFor.TabId;
                        objFieldTab.FldId = objPrjTabFldEN.FldId;
                        objFieldTab.PrjId = objInFor.PrjId;
                        bolIsExist = false;
                    }

                    if (objPrjTabFldEN.FldId == objInFor.KeyFldId())
                    {
                   
                        objFieldTab.IsRootFld = true;
                        objFieldTab.Root4TabId = objInFor.TabId;
                        objFieldTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                        objFieldTab.UpdUser = clsCommonSession.UserId;
                        if (bolIsExist == true)
                        {
                            clsFieldTab4RootFldBL.UpdateBySql2(objFieldTab);
                        }
                        else
                        {
                            clsFieldTab4RootFldBL.AddNewRecordBySql2(objFieldTab);
                        }
                    }
                    else
                    {                    
                        objFieldTab.RootFldId = objInFor.KeyFldId();
                        objFieldTab.RootTabId = objInFor.TabId;
                        objFieldTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                        objFieldTab.UpdUser = clsCommonSession.UserId;
                        if (bolIsExist == true)
                        {
                            clsFieldTab4RootFldBL.UpdateBySql2(objFieldTab);
                        }
                        else
                        {
                            clsFieldTab4RootFldBL.AddNewRecordBySql2(objFieldTab);
                        }
                    }
                }
            }

            BindGv_vFieldTab4RootFld();
            clsCommonJsFunc.Alert(this, "自动设置根字段完成！");
        }
    }
    public partial class wfmFieldTab4RootFld : CommWebPageBase
    {
        private void CheckField()
        {
            string strWhereCond = CombinevFieldTab4RootFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTab(objFieldTabEN.FldId, clsPubVar.CurrSelPrjId);
            }
        }
        /// <summary>
        /// 复制字段
        /// </summary>
        private void CopyField()
        {
            string strMsg;
            //判断是否有选中的对象ID
            string strObjId = ddlTabIdq.SelectedValue;
            if (ddlTabIdq.SelectedIndex < 1)
            {
                strMsg = "请选择一个合适的对象名!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (string strFldId in lstFldID)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

                    //clsFieldTabBLEx.CopyField2Bak20170705(clsPubVar.CurrSelPrjId, strFldId,
                        //objFieldTabEN.FldName + "_Copy", strObjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "复制字段不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

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