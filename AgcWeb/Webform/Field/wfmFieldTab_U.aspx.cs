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
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;



using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFieldTab_U : CommWebPageBase
    {
        /// <summary>
        /// 操作:1、纯字段修改：Update;
        ///      2、表中字段修改：UpdateInTab, 应传参数：TabId, ObjId, FldId
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        
        /// <summary>
        /// 操作:1、纯字段修改：Update;
        ///      2、表中字段修改：UpdateInTab, 应传参数：TabId, ObjId, FldId
        /// </summary>
        private string qsObjId
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

        /// <summary>
        /// 操作:1、纯字段修改：Update;
        ///      2、表中字段修改：UpdateInTab, 应传参数：TabId, ObjId, FldId
        /// </summary>
        private string qsFldId
        {
            get
            {
                string strFldId = Request.QueryString["FldId"] ?? "".ToString();
                if ((strFldId != null) && (strFldId != ""))
                {
                    return strFldId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                try
                {
                    //预处理QueryString和Session等身份状态信息
                    rf_PretreatmentQueryString();
                    if (string.IsNullOrEmpty(qsOperator) == true)
                    {
                        clsCommonJsFunc.Alert(this, "操作类型为空，请检查");
                        return;
                    }
                    //1、为下拉框设置数据源，绑定列表数据
                    wucFieldTab1.SetDdl_PrjId();
                    wucFieldTab1.SetDdl_FldType();
                    wucFieldTab1.SetDdl_IsNull();
                    //				wucFieldTab1.SetDdl_IsPrimaryKey();
                    wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);
                    wucFieldTab1.SetDdl_CodeTab();
                    wucFieldTab1.SetDdl_FldStateId();
                    wucFieldTab1.SetDdl_FieldTypeId();
                    wucFieldTab1.SetDdl_HomologousFldId(clsPubVar.CurrSelPrjId);

                    //3、设置表控件中字控件的ReadOnly属性，
                    //   使之只读，因为在修改功能中关键字是不能被修改的。
                    wucFieldTab1.SetKeyReadOnly(true);
                    btnOKUpd.Text = "确认修改";
                    ShowData(vsFldId);
                }
                catch(Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    return;
                }
            }
        }
        /// <summary>
        /// 常规函数：预处理QueryString和Session等身份状态信息。
        /// 注释：常规函数-Regular Function
        ///       预处理-Pretreatment
        /// </summary>
        private void rf_PretreatmentQueryString()
        {
            try
            {
                if (string.IsNullOrEmpty(qsFldId) == false)
                {
                    vsFldId = qsFldId.ToString();
                }
                else if (string.IsNullOrEmpty(seFldId) == false)
                {
                    vsFldId = seFldId;
                }
                if (string.IsNullOrEmpty(vsFldId) == true)
                {
                    clsCommonJsFunc.Alert(this, "需要修改的关键字为空！");
                    throw new Exception("需要修改的关键字为空！");
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
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
        
      

   
        /// <summary>
        /// 登录的用户ID，用于检查用户权限
        /// </summary>
        protected string vsFldId
        {
            get
            {
                string strFldId;
                strFldId = (string)ViewState["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                ViewState.Add("FldId", strFldId);
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

        private string seFldId
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
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldID);
            //4、获取类对象的所有属性；
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
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
            wucFieldTab1.FieldTypeId = pobjFieldTab.FieldTypeId;
            wucFieldTab1.HomologousFldId = pobjFieldTab.HomologousFldId;


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

                        ///3.1、检查传进去的对象属性是否合法
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }

                        ///3.2、检查传进去的对象属性是否有逻辑性错误
                        if (clsFieldTabBLEx.CheckFieldTabNnUpdate(objFieldTabEN) == false)
                        {
                            clsCommonJsFunc.Alert(this, objFieldTabEN.Memo);
                            return;
                        }
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("PrjId='{0}' and FldName='{1}' and DataTypeId = '{2}' And FldId<>'{3}'",
                            objFieldTabEN.PrjId,
                            objFieldTabEN.FldName,
                            objFieldTabEN.DataTypeId, objFieldTabEN.FldId);
                        if (objFieldTabEN.CheckUniqueness() == true)//检查合法，不存在唯一性问题
                        {
                            if (qsOperator == "UpdateInTab")
                            {
                                while (true)
                                {
                                    if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == true)
                                    {
                                        break;
                                    }
                                    string strFldId = clsFieldTabBL.GetFirstID_S(sbCondition.ToString());

                                    if (string.IsNullOrEmpty(strFldId) == true)
                                    {
                                        break;
                                    }
                                    string strFldId_S = qsFldId;

                                    try
                                    {
                                        clsPrjTabFldBLEx.ReplaceFieldInPrjTabFld(clsCommonSession.qsTabId, strFldId_S, strFldId);


                                    }
                                    catch (Exception objException)
                                    {
                                        clsCommonSession.seErrMessage = "修改字段（替换字段）不成功!请与管理员联系！\r\n" + objException.Message;
                                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                                        clsPubFun4Web.AccessError(this, conCurrPageName);
                                    }
                                    ReturnParentPage();
                                }
                            }
                            else
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在工程：{0}中，", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                                sbMsg.AppendFormat("字段名：{0}，", objFieldTabEN.FldName);
                                sbMsg.AppendFormat("字段类型：{0}已经存在，请从当前表字段中删除该字段，重新添加新的字段。", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                                return;
                            }
                        }
                        else
                        {
                            StringBuilder sbMsg = new StringBuilder();
                            sbMsg.AppendFormat("在工程：{0}中，", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                            sbMsg.AppendFormat("字段名：{0}，", objFieldTabEN.FldName);
                            sbMsg.AppendFormat("字段类型：{0}已经存在，请从当前表字段中删除该字段，重新添加新的字段。", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                            clsCommonJsFunc.Alert(this, sbMsg.ToString());
                            return;
                        }
                        //4、把数据实体层的数据修改同步到数据库中
                        if (objFieldTabEN.UpdateRecordEx() == false)
                        {
                           strMsg = "修改记录不成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "修改记录不成功!";
                        }
                        else
                        {
                            var objFieldTab4CodeConv = new clsFieldTab4CodeConvEN(objFieldTabEN.FldId);  //初始化新对象
                            PutDataToFieldTab4CodeConvClass(objFieldTab4CodeConv);      //把界面的值传到
                                                                                        //5、检查传进去的对象属性是否合法
                                                                                        ///
                            try
                            {
                                clsFieldTab4CodeConvBL.CheckPropertyNew(objFieldTab4CodeConv);
                            }
                            catch (Exception objException)
                            {
                                clsCommonJsFunc.Alert(this, objException.Message);
                                return;
                            }
                            if (objFieldTab4CodeConv.EditRecordEx() == false)
                            {
                                strMsg = "修改记录不成功!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "修改记录不成功!";
                                return;
                            }

                            clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(objFieldTabEN.FldId, clsCommonSession.UserId);
                            clsFieldTabBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                            clsPubFun4BLEx.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);
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
                        wucFieldTab1.Clear();//添空控件中的内容
                    }
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
                    //恢复<确认修改>变成<添加>
                    //					btnOKUpd.Text = "添加";
                    //					tabLayout.Visible = false;
                    ReturnParentPage();
                    break;
            }
        }
        private void PutDataToFieldTab4CodeConvClass(clsFieldTab4CodeConvEN pobjFieldTab)
        {
            pobjFieldTab.FldId = wucFieldTab1.FldId;
            pobjFieldTab.PrjId = wucFieldTab1.PrjId;

            pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
            pobjFieldTab.UpdUser = wucFieldTab1.UserId;

        }
        private void ReturnToParentPage1()
        {
            

            string strBackLinkStr = new clsCommonSession().BackPageEditFldLinkStr;

            if (strBackLinkStr != "")
            {
                Response.Redirect(strBackLinkStr + "?FromWebForm=FieldTab_U");
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
            pobjFieldTab.FieldTypeId = wucFieldTab1.FieldTypeId;
            pobjFieldTab.HomologousFldId = wucFieldTab1.HomologousFldId;


        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            //返回主页面
            ReturnParentPage(); 
            if (string.IsNullOrEmpty(BackPageLinkStrFromUpdField) == false)
            {
                Response.Redirect(BackPageLinkStrFromUpdField);
            }
            else if (string.IsNullOrEmpty(new clsCommonSession().BackPageEditFldLinkStr) == false)
            {
                Response.Redirect(new clsCommonSession().BackPageEditFldLinkStr);
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
                case "wfmEditTabAndObjectFields.aspx|":
                case "wfmEditTabAndObjectFields.aspx|wfmPrjTab_QUDI3.aspx":
                    string strTabId = clsCommonSession.TabId;
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, strTabId, strCurrPageName);
                        return;
                    }
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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