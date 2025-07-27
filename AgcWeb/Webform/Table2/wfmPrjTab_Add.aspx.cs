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



using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;



namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTab_Add : CommWebPageBase
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
                wucPrjTab1.SetDdl_SqlDsTypeIdCache();
                wucPrjTab1.SetDdl_TabStateIdCache();
                wucPrjTab1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucPrjTab1.SetDdl_RelaTabId4View(clsPubVar.CurrSelPrjId);
                
                AddPrjTab();
            }
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strTabId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;

            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddPrjTabRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddPrjTabRecordSave();
                    break;

            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddPrjTab();
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





        protected void lbImportSQLTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportTabInfoFromSQL.aspx");
        }
        protected void lbImportSQLView_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportViewInfoFromSQL2.aspx");
        }


        protected void lbImportOracleTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Oracle/wfmALL_ALL_TABLES_Q.aspx");
        }
        protected void lbImportOracleView_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Oracle/wfmUser_Views_Q.aspx");
        }

        protected void lbSetModuleByObj_Click(object sender, EventArgs e)
        {

        }








    }
    public partial class wfmPrjTab_Add : CommWebPageBase
    {
        protected void ShowData(string strTabId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strTabId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsPrjTabBL.IsExist(strTabId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strTabId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            //4、获取类对象的所有属性；
            try
            {
                //clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objPrjTabEN", objPrjTabEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromPrjTabClass(objPrjTabEN);
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


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjPrjTab">表实体类对象</param>
        protected void GetDataFromPrjTabClass(clsPrjTabEN pobjPrjTab)
        {
            wucPrjTab1.TabId = pobjPrjTab.TabId;
            wucPrjTab1.DataBaseName = pobjPrjTab.DataBaseName;
            wucPrjTab1.TabName = pobjPrjTab.TabName;
            wucPrjTab1.TabCnName = pobjPrjTab.TabCnName;
            wucPrjTab1.FuncModuleAgcId = pobjPrjTab.FuncModuleAgcId;
            //wucPrjTab1.ObjId = pobjPrjTab.ObjId;
            wucPrjTab1.Owner = pobjPrjTab.Owner;
            wucPrjTab1.Memo = pobjPrjTab.Memo;
            wucPrjTab1.IsArchive = pobjPrjTab.IsArchive;
            wucPrjTab1.IsChecked = pobjPrjTab.IsChecked;
            wucPrjTab1.TabStateId = pobjPrjTab.TabStateId;
            wucPrjTab1.IsNationStandard = pobjPrjTab.IsNationStandard;
            wucPrjTab1.TabNameB = pobjPrjTab.TabNameB;
            wucPrjTab1.SqlDsTypeId = pobjPrjTab.SqlDsTypeId;
            wucPrjTab1.RelaTabId4View = pobjPrjTab.RelaTabId4View;

        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjPrjTab">数据传输的目的类对象</param>
        protected void PutDataToPrjTabClass(clsPrjTabEN pobjPrjTab)
        {
            pobjPrjTab.TabId = wucPrjTab1.TabId;
            pobjPrjTab.PrjId = clsPubVar.CurrSelPrjId;
            pobjPrjTab.DataBaseName = wucPrjTab1.DataBaseName;
            pobjPrjTab.Owner = wucPrjTab1.Owner;
            pobjPrjTab.TabName = wucPrjTab1.TabName;
            pobjPrjTab.TabCnName = wucPrjTab1.TabCnName;
            //pobjPrjTab.ObjId = wucPrjTab1.ObjId;
            pobjPrjTab.Memo = wucPrjTab1.Memo;
            pobjPrjTab.IsArchive = wucPrjTab1.IsArchive;
            pobjPrjTab.IsChecked = wucPrjTab1.IsChecked;
            pobjPrjTab.TabStateId = wucPrjTab1.TabStateId;
            pobjPrjTab.IsNationStandard = wucPrjTab1.IsNationStandard;
            pobjPrjTab.TabNameB = wucPrjTab1.TabNameB;
            pobjPrjTab.SqlDsTypeId = wucPrjTab1.SqlDsTypeId;
            pobjPrjTab.FuncModuleAgcId = wucPrjTab1.FuncModuleAgcId;
            pobjPrjTab.RelaTabId4View = wucPrjTab1.RelaTabId4View;

        }

     
        ///生成的插入记录准备过程代码for C#
        protected void AddPrjTabRecord()
        {
            wucPrjTab1.Clear();
            wucPrjTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认添加";
            wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucPrjTab1.DataBaseName = new clsCommonSession().PrjDataBaseName;
            wucPrjTab1.SqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            wucPrjTab1.TabStateId = "01";
        }
        ///插入记录存盘过程代码for C#
        protected void AddPrjTabRecordSave()
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
            clsPrjTabEN objPrjTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsPrjTabEN objPrjTabEN;	//定义对象
            objPrjTabEN = new clsPrjTabEN(wucPrjTab1.TabId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            ///3.1、判断是否有相同的函数名称存在。					
            if (clsPrjTabBLEx.IsExistSameTabName(clsPubVar.CurrSelPrjId, wucPrjTab1.TabName))	//判断是否有相同的关键字
            {
                strMsg = "相同的工程表名称已经存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                 clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);


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
            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";

        }
        ///插入记录存盘过程代码for C#
        protected void AddPrjTabRecordSaveV5()
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
            clsPrjTabEN objPrjTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsPrjTabEN objPrjTabEN;	//定义对象
            objPrjTabEN = new clsPrjTabEN(wucPrjTab1.TabId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                 clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);
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
            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";

        }
        /// <summary>
        /// 功能:显示编辑区域
        /// </summary>

        private void AddSysLogForPrjTab(string strTabId)
        {
            try
            {
                //添加日志
                string strUserId = UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "PrjTab";
                string strTableKey = strTabId;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                string strJournal = "执行了删除操作，删除表PrjTab! 表名：" + objPrjTabEN.TabCnName + "(" + objPrjTabEN.TabName + ")";
                
                bool IsSuccesful = true;
                IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                    strUserIp,
                    strOperationType,
                    strTableName,
                    strTableKey,
                    strJournal,
                   clsPubVar.CurrSelPrjId);
                if (IsSuccesful)
                {
                    //					Response.Write("<script>alert('日志添加成功!')</script>");
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
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
        private void AddPrjTab()
        {
            wucPrjTab1.Clear();
            wucPrjTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认添加";
            wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucPrjTab1.DataBaseName = new clsCommonSession().PrjDataBaseName;
            wucPrjTab1.SqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            wucPrjTab1.TabStateId = "01";


           

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