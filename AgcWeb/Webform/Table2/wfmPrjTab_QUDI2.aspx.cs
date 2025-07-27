using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CommFunc4WebForm;
using com.taishsoft.commexception;
using com.taishsoft.common;

using com.taishsoft.sql;
using com.taishsoft.commdb;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;




namespace AGC.Webform
{

    public partial class wfmPrjTab_QUDI2 : CommWebPageBase
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
                    EditPrjTab(TabId_qs);
                }
                else if (string.IsNullOrEmpty(FromWebForm_qs) == false)
                {
                    //EditPrjTabFieldByTabId(clsCommonSession.TabId);
                }
                else
                {
                    //编辑工程表
                    EditPrjTab(clsCommonSession.TabId);
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

        #region "编辑工程表(PrjTab)"
        private void EditPrjTab(string strTabId)
        {
            btnOKUpd4Tab.Text = "确认修改";
            BindDdl4PrjTab();
            ShowPrjTabData(strTabId);

        }
        /// <summary>
        /// 绑定专门用于工程表的下拉框
        /// </summary>
        private void BindDdl4PrjTab()
        {
            wucPrjTab1.SetDdl_SqlDsTypeIdCache();
            wucPrjTab1.SetDdl_TabStateIdCache();
            wucPrjTab1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
            wucPrjTab1.SetDdl_RelaTabId4View(clsPubVar.CurrSelPrjId);
        }

        protected void ShowPrjTabData(string strTabId)
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
        ///生成的插入记录准备过程代码for C#
        protected void AddPrjTabRecord()
        {
            wucPrjTab1.SetKeyReadOnly(false);
            btnOKUpd4Tab.Text = "确认添加";
            //wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S("");
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
                lblMsgEdit.Text = strMsg;
                return;
            }
            ///3.1、判断是否有相同的函数名称存在。					
            if (clsPrjTabBLEx.IsExistSameTabName(clsPubVar.CurrSelPrjId, wucPrjTab1.TabName))	//判断是否有相同的关键字
            {
                strMsg = "相同的工程表名称已经存在!";
                lblMsgEdit.Text = strMsg;
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
                lblMsgEdit.Text = strMsg;
                return;
            }
            strMsg = "添加记录成功!";
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中

            //            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            //            btnOKUpd4Tab.Text = "添加";
        }
        ///插入记录存盘过程代码for C#
        //protected void AddPrjTabRecordSaveV5()
        //{
        //    //操作步骤：
        //    //1、检查控件中输入数据类型是否正确
        //    //2、定义对象并初始化对象
        //    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
        //    //4、把值从界面层传到逻辑层或数据实体层
        //    //5、检查传进去的对象属性是否合法
        //    //6、把数据实体层的数据存贮到数据库中
        //    //7、把新添的记录内容显示在DATAGRID中
        //    string strMsg;	//专门用于传递信息的变量
        //    clsPrjTabEN objPrjTabEN;
        //    //1、检查控件中输入数据类型是否正确
        //    if (!wucPrjTab1.IsValid())
        //    {
        //        lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
        //        return;
        //    }
        //    //2、定义对象并初始化对象
        //    //clsPrjTabEN objPrjTabEN;	//定义对象
        //    objPrjTabEN = new clsPrjTabEN(wucPrjTab1.TabId);	//初始化新对象
        //    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
        //    if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
        //    {
        //        strMsg = "关键字字段已有相同的值";
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }
        //    //4、把值从界面层传到逻辑层或数据实体层
        //    PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
        //    //5、检查传进去的对象属性是否合法
        //    try
        //    {
        //         clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
        //        //6、把数据实体层的数据存贮到数据库中
        //        clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //    strMsg = "添加记录成功!";
        //    clsCommonJsFunc.Alert(this, strMsg);
        //    lblMsgEdit.Text = "添加记录成功!";
        //    //7、把新添的记录内容显示在DATAGRID中
        //    //            wucPrjTab1.Clear();		//清空控件中内容
        //    ///恢复<确认添加>变成<添加>
        //    //            btnOKUpd4Tab.Text = "添加";
        //}
        ///生成修改记录准备过程代码 for C#
        protected void UpdatePrjTabRecord(string strTabId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowPrjTabData(strTabId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd4Tab, true);
            wucPrjTab1.SetKeyReadOnly(true);
            btnOKUpd4Tab.Text = "确认修改";
            lblMsgEdit.Text = "";
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdatePrjTabRecordSave(clsPrjTabEN objPrjTabEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //判断是否可以修改
            if (clsPrjTabBLEx.IsCanDelUpd(objPrjTabEN.TabId) == false)
            {
                lblMsgEdit.Text = "本表已经核实或归档，不能修改!";
                return;
            }

            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                lblMsgEdit.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            //            wucPrjTab1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd4Tab.Text = "添加";
        }
        ///修改存盘准备过程代码 for C#
        protected void UpdatePrjTabRecordSaveV5(clsPrjTabEN objPrjTabEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjTab1.IsValid())
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到

            //3、检查传进去的对象属性是否合法
            try
            {
                 clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabEN.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);
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
            //            wucPrjTab1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            //btnOKUpd4Tab.Text = "添加";
        }
        protected void btnOKUpd4Tab_Click(object sender, EventArgs e)
        {
            string strCommandText;
            clsPrjTabEN objPrjTabEN;
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
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objPrjTabEN = (clsPrjTabEN)Session["objPrjTabEN"];
                    UpdatePrjTabRecordSave(objPrjTabEN);
                    break;
            }
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjPrjTab">数据传输的目的类对象</param>
        private void PutDataToPrjTabClass(clsPrjTabEN pobjPrjTab)
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