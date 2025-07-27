///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using com.taishsoft.common;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;
using AGC.Entity;



namespace AGC.Webform
{
    /// <summary>
    /// wfmViewInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmViewInfo_U : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            //            this.RegisterStartupScript("js", js); 
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //1、为下拉框设置数据源，绑定列表数据
                wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_PrjId();
                wucViewInfo1.SetDdl_ApplicationTypeId();
                //				wucViewInfo1.SetDdl_ViewTypeCode();
                wucViewInfo1.SetDdl_ViewGroupId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_InSqlDsTypeId();
                wucViewInfo1.SetDdl_OutSqlDsTypeId();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucViewInfo1.SetKeyReadOnly(true);
                //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
                //{
                //    wucViewInfo1.HideViewGroup();
                //}
                //编辑界面属性
                UpdateViewInfo();

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


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }
        private void UpdateViewInfo()
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            string strViewId = getViewId;

            if (string.IsNullOrEmpty( strViewId) == true)
            {
                lblMsg.Text = "没有选择界面，请选择一个有效的界面记录!";
                return;
            }
            clsCommonSession.ViewId = strViewId;
            lblMsg.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ShowData(strViewId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewInfo1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsg.Text = "";
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strViewId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strViewId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strViewId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsViewInfoBL.IsExist(strViewId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strViewId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
            //4、获取类对象的所有属性；
            clsViewInfoBL.GetViewInfo(ref objViewInfo);
            Session.Add("objViewInfo", objViewInfo);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromViewInfoClass(objViewInfo);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjViewInfo">表实体类对象</param>
        private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            wucViewInfo1.ViewId = pobjViewInfo.ViewId;
            wucViewInfo1.ViewName = pobjViewInfo.ViewName;
            wucViewInfo1.ViewCnName = pobjViewInfo.ViewCnName;
            wucViewInfo1.FileName = pobjViewInfo.FileName;
            wucViewInfo1.FilePath = pobjViewInfo.FilePath;
            wucViewInfo1.DefaMenuName = pobjViewInfo.DefaMenuName;
            wucViewInfo1.ApplicationTypeId = pobjViewInfo.ApplicationTypeId;
            wucViewInfo1.ViewGroupId = pobjViewInfo.ViewGroupId;

            wucViewInfo1.FuncModuleAgcId = pobjViewInfo.FuncModuleAgcId;

            wucViewInfo1.DataBaseName = pobjViewInfo.DataBaseName;
            wucViewInfo1.MainTabId = pobjViewInfo.MainTabId;
            wucViewInfo1.DetailTabId = pobjViewInfo.DetailTabId;
            wucViewInfo1.KeyForMainTab = pobjViewInfo.KeyForMainTab;
            wucViewInfo1.KeyForDetailTab = pobjViewInfo.KeyForDetailTab;
            wucViewInfo1.IsNeedSort = pobjViewInfo.IsNeedSort;
            wucViewInfo1.IsNeedTransCode = pobjViewInfo.IsNeedTransCode;
            wucViewInfo1.UserId = pobjViewInfo.UserId;
            wucViewInfo1.PrjId = pobjViewInfo.PrjId;
            wucViewInfo1.ViewFunction = pobjViewInfo.ViewFunction;
            wucViewInfo1.ViewDetail = pobjViewInfo.ViewDetail;
            wucViewInfo1.InSqlDsTypeId = pobjViewInfo.InSqlDsTypeId;
            wucViewInfo1.InRelaTabId = pobjViewInfo.InRelaTabId;
            wucViewInfo1.OutSqlDsTypeId = pobjViewInfo.OutSqlDsTypeId;
            wucViewInfo1.OutRelaTabId = pobjViewInfo.OutRelaTabId;
            wucViewInfo1.IsNeedSetExportFld = pobjViewInfo.IsNeedSetExportFld;
            wucViewInfo1.KeyId4Test = pobjViewInfo.KeyId4Test;
            wucViewInfo1.ViewMasterId = pobjViewInfo.ViewMasterId;


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
            clsViewInfoEN objViewInfo;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "确认添加";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = clsCommonSession.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    //clsViewInfoEN objViewInfo;	//定义对象
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    objViewInfo = new clsViewInfoEN(wucViewInfo1.ViewId);	//初始化新对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    if (clsViewInfoBL .IsExist(objViewInfo.ViewId))	//判断是否有相同的关键字
                    {
                        strMsg = "关键字字段已有相同的值";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //检查在当前工程中是否含有同名界面名称
                    if (clsViewInfoBL.IsExistRecord("PrjId = '" + clsPubVar.CurrSelPrjId + "' and ViewName = '" + wucViewInfo1.ViewName + "'"))	//判断是否有相同的关键字
                    {
                        strMsg = "本项目中已存在同名的界面名称!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToViewInfoClass(objViewInfo);		//把界面的值传到

                    //5、检查传进去的对象属性是否合法

                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    try
                    {
                        if (clsViewInfoBL .AddNewRecordBySql2(objViewInfo) == false)
                        {
                            strMsg = "添加不成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "添加记录不成功!";
                        }
                        else
                        {
                            //添加默认的界面模式
                            clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                            strMsg = "添加记录成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "添加记录成功!";
                        }
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    //7、把新添的记录内容显示在DATAGRID中
                    wucViewInfo1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpd.Text = "添加";
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objViewInfo = (clsViewInfoEN)Session["objViewInfo"];
                    //检查在当前工程中是否含有同名界面名称
                    StringBuilder sbCondition = new StringBuilder();
                    sbCondition.AppendFormat("PrjId = '{0}'", clsPubVar.CurrSelPrjId);
                    sbCondition.AppendFormat(" and ViewName = '{0}'", wucViewInfo1.ViewName);
                    sbCondition.AppendFormat(" and {0} = {1}", conViewInfo.ApplicationTypeId,  wucViewInfo1.ApplicationTypeId);
                    sbCondition.AppendFormat(" and ViewId <> '{0}'", wucViewInfo1.ViewId);

                    if (clsViewInfoBL.IsExistRecord(sbCondition.ToString()))	//判断是否有相同的关键字
                    {
                        strMsg = "本项目中已存在同名的界面名称!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }

                    PutDataToViewInfoClass(objViewInfo);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法
                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsViewInfoBL.UpdateBySql2(objViewInfo) == false)
                    {
                        strMsg = "修改记录不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录不成功!";
                    }
                    else
                    {
                        //添加默认的界面模式
                        clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                        strMsg = "修改记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录成功!";
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    wucViewInfo1.Clear();//添空控件中的内容
                    //恢复<确认修改>变成<添加>
                    btnOKUpd.Text = "添加";
                    break;

            }
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjViewInfo">数据传输的目的类对象</param>
        private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            pobjViewInfo.ViewId = wucViewInfo1.ViewId;
            pobjViewInfo.ViewName = wucViewInfo1.ViewName;
            pobjViewInfo.ViewCnName = wucViewInfo1.ViewCnName;
            pobjViewInfo.FileName = wucViewInfo1.FileName;
            pobjViewInfo.FilePath = wucViewInfo1.FilePath;
            pobjViewInfo.DefaMenuName = wucViewInfo1.DefaMenuName;
            pobjViewInfo.ApplicationTypeId = wucViewInfo1.ApplicationTypeId;
            pobjViewInfo.ViewGroupId = wucViewInfo1.ViewGroupId;
            pobjViewInfo.FuncModuleAgcId = wucViewInfo1.FuncModuleAgcId;
            pobjViewInfo.DataBaseName = wucViewInfo1.DataBaseName;
            pobjViewInfo.MainTabId = wucViewInfo1.MainTabId;
            pobjViewInfo.DetailTabId = wucViewInfo1.DetailTabId;
            pobjViewInfo.KeyForMainTab = wucViewInfo1.KeyForMainTab;
            pobjViewInfo.KeyForDetailTab = wucViewInfo1.KeyForDetailTab;
            pobjViewInfo.IsNeedSort = wucViewInfo1.IsNeedSort;
            pobjViewInfo.IsNeedTransCode = wucViewInfo1.IsNeedTransCode;
            pobjViewInfo.UserId = wucViewInfo1.UserId;
            pobjViewInfo.PrjId = wucViewInfo1.PrjId;
            pobjViewInfo.ViewFunction = wucViewInfo1.ViewFunction;
            pobjViewInfo.ViewDetail = wucViewInfo1.ViewDetail;
            pobjViewInfo.InRelaTabId = wucViewInfo1.InRelaTabId;
            pobjViewInfo.InSqlDsTypeId = wucViewInfo1.InSqlDsTypeId;
            pobjViewInfo.OutSqlDsTypeId = wucViewInfo1.OutSqlDsTypeId;
            pobjViewInfo.OutRelaTabId = wucViewInfo1.OutRelaTabId;
            pobjViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            pobjViewInfo.UpdUserId = clsCommonSession.UserId;
            pobjViewInfo.IsNeedSetExportFld = wucViewInfo1.IsNeedSetExportFld;
            pobjViewInfo.KeyId4Test = wucViewInfo1.KeyId4Test;
            pobjViewInfo.ViewMasterId = wucViewInfo1.ViewMasterId;

        }



        public System.Data.DataTable GetViewTypeCode()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewTypeCode();
            objDDL.DataValueField = "ViewTypeCode";
            objDDL.DataTextField = "ViewTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 11;
                iNum[1] = 12;
                for (int i = 0; i < 2; i++)
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


        //定义从外面传来的ViewId
        private string qsViewId
        {
            get
            {
                string strViewId = Request.QueryString["ViewId"] ?? "".ToString();
                if ((strViewId != null) && (strViewId != ""))
                {
                    return strViewId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getViewId
        {
            get
            {
                if (string.IsNullOrEmpty(qsViewId) == false) return qsViewId;
                if (string.IsNullOrEmpty(clsCommonSession.ViewId4get) == false) return clsCommonSession.ViewId4get;
        
                return "";
            }
            //set
            //{
            //    clsCommonSession.ViewId4get = value;
            //}
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