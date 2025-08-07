
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.WebSrv;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace AGC.Webform
{

    public partial class wfmEditTab : CommWebPageBase
    {
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmEditTabAndObjectFields.aspx";
            }
        }
        //定义从外面传来的ObjId(对象ID)
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
     
        //定义从外面传来的FromWebForm(从什么页面传来)
        private string qsFromWebForm
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
            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strLangType = Request.Form["hidLangType"] != null ? Request.Form["hidLangType"] : "";
            string strDataBaseType = Request.Form["hidDataBaseType"] != null ? Request.Form["hidDataBaseType"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "ChangeLangType":
                    ChangeLangType(strLangType); //调用该函数
                  
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                  
                    break;

                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            if (!IsPostBack)
            {

                try
                {

                    //预处理QueryString和Session等身份状态信息
                    rf_PretreatmentQueryString();
                    //初始化父页面传递过来的信息
                    InitParentPageInfo();
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    return;
                }

                List<Control> lstControl = clsCommForWebForm.GetControlListInPageByTypeName(this, "Button");
              
                //rblNetOrJava.Attributes["onclick"] = string.Format("ClearText('{0}');", txtCode.ClientID);
                //rblSqlOrOracle.Attributes["onclick"] = string.Format("ClearText('{0}');", txtCode.ClientID);

                //clsPubFun.ShowUserDefaLangType(rblNetOrJava);

                vsViewName = "表字段维护";
                vsExportTabName = "vPrjTabFld";
              

                clsPrjTabEN objPrjTabEN = null;
                if (string.IsNullOrEmpty(vsTabId) == false)
                {

                    objPrjTabEN = clsPrjTabBL.GetObjByTabId(vsTabId);
                    vsSqlDsTypeId = objPrjTabEN.SqlDsTypeId;
                    
                }

                else if (string.IsNullOrEmpty(qsFromWebForm) == false)
                {
                    //EditPrjTabFieldByTabId(clsCommonSession.TabId);
                }
                
                else
                {
                    clsCommonJsFunc.Alert(this, "传递过来的对象Id或者TabId均为空，不正确！请联系管理员！");
                    return;
                }


                if (objPrjTabEN == null)
                {
                    if (string.IsNullOrEmpty(vsTabId) == false)
                    {
                        objPrjTabEN = clsPrjTabBL.GetObjByTabId(vsTabId);
                    }
                }

                if (objPrjTabEN != null)
                {
                    vsTabName = objPrjTabEN.TabName;
                    vsSqlDsTypeId = objPrjTabEN.SqlDsTypeId;
                    if (vsSqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
                    {

                        lblTabNameObjName.Text = lblTabNameObjName.Text +
                            string.Format("   表名：{0}({1})", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
                      

                    }
                    else
                    {
                        if (objPrjTabEN.TabName == objPrjTabEN.TabCnName)
                        {
                            lblTabNameObjName.Text = lblTabNameObjName.Text +
                              string.Format("   视图名:{0}", objPrjTabEN.TabName);
                        }
                        else
                        {
                            lblTabNameObjName.Text = lblTabNameObjName.Text +
                                 string.Format("   视图名：{0}({1})", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
                        }
                        //btnAnalysis.Visible = false;
                    }
                }



                try
                {
                   
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            //把字段类型的所有数据送到前后
            string strJSONStr = clsDataTypeAbbrBL.GetJSONObjLst("1=1");
            hidDataTypeAbbrObjLstJsonStr.Value = strJSONStr;
            //txtFldName.Attributes.Add("onblur", "txtFldName_onblur();");
            //txtCaption.Attributes.Add("onblur", "txtFldName_onblur();");

        }


        private void ChangeLangType(string strLangType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = strLangType;
            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = clsPubConst.GetDataBaseTypeStrByDataBaseType(vsDataBaseType);
            //vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType(vsLangType);
            //            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = strDataBaseType;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            
        }
      
        /// <summary>
        /// 当前操作的界面功能名称
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// 当前操作的导出表名称
        /// </summary>
        protected string vsExportTabName
        {
            get
            {
                string sExportTabName;
                sExportTabName = (string)ViewState["ExportTabName"];
                if (sExportTabName == null)
                {
                    sExportTabName = "";
                }
                return sExportTabName;
            }
            set
            {
                string sExportTabName = value;
                ViewState.Add("ExportTabName", sExportTabName);
            }
        }
      
      

     

        #region "编辑工程表(PrjTab)"
        private void EditPrjTab(string strTabId)
        {
            //MultiView1.ActiveViewIndex = 1;
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
            wucPrjTab1.SetDdl_TabTypeIdCache();

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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
            wucPrjTab1.ParentClass = pobjPrjTab.ParentClass;
            wucPrjTab1.Memo = pobjPrjTab.Memo;

            wucPrjTab1.IsArchive = pobjPrjTab.IsArchive;
            wucPrjTab1.IsChecked = pobjPrjTab.IsChecked;
            wucPrjTab1.TabStateId = pobjPrjTab.TabStateId;
            wucPrjTab1.IsNationStandard = pobjPrjTab.IsNationStandard;
            wucPrjTab1.TabNameB = pobjPrjTab.TabNameB;
            wucPrjTab1.SqlDsTypeId = pobjPrjTab.SqlDsTypeId;
            wucPrjTab1.RelaTabId4View = pobjPrjTab.RelaTabId4View;
            wucPrjTab1.IsReleToSqlTab = pobjPrjTab.IsReleToSqlTab;
            //wucPrjTab1.IsNeedGeneIndexer = pobjPrjTab.IsNeedGeneIndexer;

            wucPrjTab1.TabTypeId = pobjPrjTab.TabTypeId;
            wucPrjTab1.IsUseCache = pobjPrjTab.IsUseCache;

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
            pobjPrjTab.ParentClass = wucPrjTab1.ParentClass;
            pobjPrjTab.Memo = wucPrjTab1.Memo;
            pobjPrjTab.IsArchive = wucPrjTab1.IsArchive;
            pobjPrjTab.IsChecked = wucPrjTab1.IsChecked;
            pobjPrjTab.TabStateId = wucPrjTab1.TabStateId;
            pobjPrjTab.IsNationStandard = wucPrjTab1.IsNationStandard;
            pobjPrjTab.TabNameB = wucPrjTab1.TabNameB;
            pobjPrjTab.SqlDsTypeId = wucPrjTab1.SqlDsTypeId;
            pobjPrjTab.FuncModuleAgcId = wucPrjTab1.FuncModuleAgcId;
            pobjPrjTab.RelaTabId4View = wucPrjTab1.RelaTabId4View;
            pobjPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            pobjPrjTab.IsReleToSqlTab = wucPrjTab1.IsReleToSqlTab;
            pobjPrjTab.IsNeedGeneIndexer = true;// wucPrjTab1.IsNeedGeneIndexer;

            pobjPrjTab.TabTypeId = wucPrjTab1.TabTypeId;
            pobjPrjTab.IsUseCache = wucPrjTab1.IsUseCache;

        }
        ///生成的插入记录准备过程代码for C#
        protected void AddPrjTabRecord()
        {
            wucPrjTab1.SetKeyReadOnly(false);
            btnOKUpd4Tab.Text = "确认添加";
            //wucPrjTab1.TabId = clsPrjTab.GetMaxStrId("PrjTab","TabId", 8, "");
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

            //            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            //            btnOKUpd4Tab.Text = "添加";
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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            //            wucPrjTab1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            //            btnOKUpd4Tab.Text = "添加";
        }
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
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
        #endregion

      
      
      
      
        protected void lbRefresh_Click(object sender, EventArgs e)
        {
            WS_FieldName.autoCompleteWordList = null;

            //WS_FieldName obj = new WS_FieldName();
            //obj.RefreshWorkList();
            //localhost.WebService1 oService = new localhost.WebService1();

            //string mfCommand = TextBox1.Text;

            //ds = oService.GetByUser(mfCommand);


        }

      
        public string vsTabName
        {
            get
            {
                string strTabName;
                strTabName = (string)ViewState["TabName"];
                if (strTabName == null)
                {
                    strTabName = "";
                }
                return strTabName;
            }
            set
            {
                string strTabName = value;
                ViewState.Add("TabName", strTabName);
            }
        }
        //public string vsSqlDsTypeId
        //{
        //    get
        //    {
        //        string strSqlDsTypeId;
        //        strSqlDsTypeId = (string)ViewState["SqlDsTypeId"];
        //        if (strSqlDsTypeId == null)
        //        {
        //            strSqlDsTypeId = "";
        //        }
        //        return strSqlDsTypeId;
        //    }
        //    set
        //    {
        //        string strSqlDsTypeId = value;
        //        ViewState.Add("SqlDsTypeId", strSqlDsTypeId);
        //    }
        //}

        /// <summary>
        /// 是否绑定对象属性
        /// </summary>
        public string vsIsBindObjProp
        {
            get
            {
                string strIsBindObjProp;
                strIsBindObjProp = (string)ViewState["IsBindObjProp"];
                if (strIsBindObjProp == null)
                {
                    strIsBindObjProp = "";
                }
                return strIsBindObjProp;
            }
            set
            {
                string strIsBindObjProp = value;
                ViewState.Add("IsBindObjProp", strIsBindObjProp);
            }
        }
        /// <summary>
        /// 是否绑定表属性
        /// </summary>
        public string vsIsBindTabProp
        {
            get
            {
                string strIsBindTabProp;
                strIsBindTabProp = (string)ViewState["IsBindTabProp"];
                if (strIsBindTabProp == null)
                {
                    strIsBindTabProp = "";
                }
                return strIsBindTabProp;
            }
            set
            {
                string strIsBindTabProp = value;
                ViewState.Add("IsBindTabProp", strIsBindTabProp);
            }
        }
        /// <summary>
        /// 是否绑定表字段
        /// </summary>
        public string vsIsBindTabField
        {
            get
            {
                string strIsBindTabField;
                strIsBindTabField = (string)ViewState["IsBindTabField"];
                if (strIsBindTabField == null)
                {
                    strIsBindTabField = "";
                }
                return strIsBindTabField;
            }
            set
            {
                string strIsBindTabField = value;
                ViewState.Add("IsBindTabField", strIsBindTabField);
            }
        }

        /// <summary>
        /// 是否绑定对象字段
        /// </summary>
        public string vsIsBindObjField
        {
            get
            {
                string strIsBindObjField;
                strIsBindObjField = (string)ViewState["IsBindObjField"];
                if (strIsBindObjField == null)
                {
                    strIsBindObjField = "";
                }
                return strIsBindObjField;
            }
            set
            {
                string strIsBindObjField = value;
                ViewState.Add("IsBindObjField", strIsBindObjField);
            }
        }
        /// <summary>
        /// 是否绑定下拉框For对象字段
        /// </summary>
        public string vsIsBindDdl4ObjField
        {
            get
            {
                string strIsBindDdl4ObjField;
                strIsBindDdl4ObjField = (string)ViewState["IsBindDdl4ObjField"];
                if (strIsBindDdl4ObjField == null)
                {
                    strIsBindDdl4ObjField = "";
                }
                return strIsBindDdl4ObjField;
            }
            set
            {
                string strIsBindDdl4ObjField = value;
                ViewState.Add("IsBindDdl4ObjField", strIsBindDdl4ObjField);
            }
        }
        /// <summary>
        /// 是否绑定下拉框For表字段
        /// </summary>
        public string vsIsBindDdl4TabField
        {
            get
            {
                string strIsBindDdl4TabField;
                strIsBindDdl4TabField = (string)ViewState["IsBindDdl4TabField"];
                if (strIsBindDdl4TabField == null)
                {
                    strIsBindDdl4TabField = "";
                }
                return strIsBindDdl4TabField;
            }
            set
            {
                string strIsBindDdl4TabField = value;
                ViewState.Add("IsBindDdl4TabField", strIsBindDdl4TabField);
            }
        }
        /// <summary>
        /// 是否绑定对象字段
        /// </summary>
        public string vsIsBindGeneCode
        {
            get
            {
                string strIsBindGeneCode;
                strIsBindGeneCode = (string)ViewState["IsBindGeneCode"];
                if (strIsBindGeneCode == null)
                {
                    strIsBindGeneCode = "";
                }
                return strIsBindGeneCode;
            }
            set
            {
                string strIsBindGeneCode = value;
                ViewState.Add("IsBindGeneCode", strIsBindGeneCode);
            }
        }
        public string vsTabId
        {
            get
            {
                string strTabId;
                strTabId = (string)ViewState["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                ViewState.Add("TabId", strTabId);
            }
        }

        /// <summary>
        /// 表记录数
        /// </summary>
        public int vsTabRecNum
        {
            get
            {
                string strTabRecNum;
                strTabRecNum = (string)ViewState["TabRecNum"];
                if (strTabRecNum == null)
                {
                    string strCondition = string.Format("{0}='{1}' and {2}='0'", 
                        conPrjTabFld.TabId, vsTabId, conPrjTabFld.IsForExtendClass);
                    int intTabRecNum = clsPrjTabFldBL.GetRecCountByCond(strCondition);
                    strTabRecNum = intTabRecNum.ToString();
                    ViewState.Add("TabRecNum", strTabRecNum);
                }
                return int.Parse(strTabRecNum);
            }
            set
            {
                string strTabRecNum = value.ToString();
                ViewState.Add("TabRecNum", strTabRecNum);
            }
        }
        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public string vsSqlDsTypeId
        {
            get
            {
                string strSqlDsTypeId;
                strSqlDsTypeId = (string)ViewState["SqlDsTypeId"];
                if (strSqlDsTypeId == null)
                {
                    strSqlDsTypeId = "";
                }
                return strSqlDsTypeId;
            }
            set
            {
                string strSqlDsTypeId = value;
                ViewState.Add("SqlDsTypeId", strSqlDsTypeId);
            }
        }
        /// <summary>
        /// 视图表Id的相关表Id
        /// </summary>
        public string vsRelaTabId4View
        {
            get
            {
                string strRelaTabId4View;
                strRelaTabId4View = (string)ViewState["RelaTabId4View"];
                if (strRelaTabId4View == null)
                {
                    strRelaTabId4View = "";
                }
                return strRelaTabId4View;
            }
            set
            {
                string strRelaTabId4View = value;
                ViewState.Add("RelaTabId4View", strRelaTabId4View);
            }
        }
        //public string vsObjId
        //{
        //    get
        //    {
        //        string strObjId;
        //        strObjId = (string)ViewState["ObjId"];
        //        if (strObjId == null)
        //        {
        //            strObjId = "";
        //        }
        //        return strObjId;
        //    }
        //    set
        //    {
        //        string strObjId = value;
        //        ViewState.Add("ObjId", strObjId);
        //    }
        //}

      
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {

            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", vsExportTabName);
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsExportTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请先导出一次Excel，再不行可与管理员联系！", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }

            StringBuilder sbScript = new StringBuilder();

            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SystemSet/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");

            Response.Write(sbScript.ToString());


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
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }

    

        protected void btnReturnPrjTabList_Click(object sender, EventArgs e)
        {
            ReturnParentPage();
            //  Response.Redirect(@"wfmPrjTab_QUDI3.aspx");
        }
        #region 处理父页面信息以及跳转到其他页面
        public override void InitParentPageInfo()
        {
            string strParentPage = qsParentPage;
            strParentPage = strParentPage.Replace("wfmPrjTab_CheckConsistency.aspx", "").Replace("||", "|");
            vsParentPage = PretreatmentParentPage(strParentPage);
            switch (vsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    //                lbReturnPrjTabList.Text = "返回[工程表列表]";
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
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

            switch (vsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        
        #endregion 处理父页面信息

        /// <summary>
        /// 常规函数：预处理QueryString和Session等身份状态信息。
        /// 注释：常规函数-Regular Function
        ///       预处理-Pretreatment
        /// </summary>
        private void rf_PretreatmentQueryString()
        {
            try
            {
                if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == false)
                {
                    vsTabId = clsCommonSession.qsTabId.ToString();
                }
                else if (string.IsNullOrEmpty(seTabId) == false)
                {
                    vsTabId = seTabId;
                }
                //if (string.IsNullOrEmpty(qsObjId) == false)
                //{
                //    vsObjId = qsObjId.ToString();
                //}
                //else if (string.IsNullOrEmpty(seObjId) == false)
                //{
                //    vsObjId = seObjId;
                //}


                if (string.IsNullOrEmpty(vsTabId) == true)
                {
                    clsCommonJsFunc.Alert(this, "传递过来的TabId为空，不正确！请联系管理员！");
                    throw new Exception("传递过来的TabId为空，不正确！请联系管理员！");
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }

        private string seTabId
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

        //private string seObjId
        //{
        //    get
        //    {
        //        string strObjId;
        //        strObjId = (string)Session["ObjId"];
        //        if (strObjId == null)
        //        {
        //            strObjId = "";
        //        }
        //        return strObjId;
        //    }
        //    set
        //    {
        //        string strObjId = value;
        //        Session.Add("ObjId", strObjId);
        //    }
        //}

        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string vsTypeParas
        {
            get
            {
                string strTypeParas = "";
                //if (ViewState["TypeParas"] == null)
                //{
                //    if (ddlAppPageTypeId.SelectedIndex > 0)
                //    {
                //        string strAppPageTypeId = ddlAppPageTypeId.SelectedValue;
                //        clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeBL.GetObjByAppPageTypeId(strAppPageTypeId);
                //        strTypeParas = strTypeParas + string.Format("{0}|",
                //            objAppPageTypeEN.AppPageTypeENName);
                //        return strTypeParas;
                //    }
                //}
                //strTypeParas = (string)ViewState["TypeParas"];

                return strTypeParas;
            }
            set
            {
                string strTypeParas = value;
                ViewState.Add("TypeParas", strTypeParas);
            }
        }

      

        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            //switch (strPageName)
            //{
            //    case "CheckConsistency":
            //        string strTabId = vsTabId;
            //        if (strTabId == null || strTabId.Trim().Length == 0)
            //        {
            //            lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
            //            return;
            //        }
            //        lblMsgList.Text = "";

            //        clsPubFun4Web.CheckConsistency(this, strTabId, strCurrPageName);
            //        break;
            //    case "EditTabAndObjectFields":
            //        strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            //        if (string.IsNullOrEmpty(vsTabId_T) == false)
            //        {
            //            clsPubFun4Web.JumpToEditTabAndFields(this, vsTabId_T, strCurrPageName);
            //        }
            //        else
            //        {
            //            lblMsgList.Text = "没有相关的代码表(视图、外键表)，请检查！";
            //            clsCommonJsFunc.Alert(this, lblMsgList.Text);
            //        }

            //        break;
            //    case "FieldTab_U":
            //        string strMid;
            //        long lngMid;        //当前所选记录的关键字MId
            //                            //1、获取当前所选中的字段ID。
            //        strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            //        if (strMid.Trim().Length == 0)
            //        {
            //            lblMsgList.Text = "没有选择记录，请选择一个有效的字段记录!";
            //            return;
            //        }
            //        lngMid = long.Parse(strMid);
            //        string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;

            //        BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
            //        clsPubFun4Web.JumpToFieldTab_U(this, vsTabId, strFldId, strCurrPageName);
            //        break;

            //    default:
            //        clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
            //        break;
            //}
        }
    }
}