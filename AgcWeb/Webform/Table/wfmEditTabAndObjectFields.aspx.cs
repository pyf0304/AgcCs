
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AGC.web.treeview;
using AGC.WebSrv;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using com.taishsoft.sql;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;



namespace AGC.Webform
{

    public partial class wfmEditTabAndObjectFields : CommWebPageBase
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
                    //lblLangTypeName.Text = strLangType;
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                    //lblDataBaseType.Text = strDataBaseType;
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
                vsCurrTabIndex = 1;
                try
                {
                    //预处理QueryString和Session等身份状态信息
                    rf_PretreatmentQueryString();
                    if (string.IsNullOrEmpty( clsCommonSession.qsTabId) == false)
                    {
                        myIframe1.Src = string.Format("wfmPrjConstraintB_QUDI.aspx?TabId={0}", clsCommonSession.qsTabId);
                        //myIframe2.Src = string.Format("wfmConstraintFieldsB_QUDI.aspx?TabId={0}", clsCommonSession.qsTabId);
                        myIframe3.Src = string.Format("wfmPrjTab_CheckConsistency_InTabs.aspx?TabId={0}", clsCommonSession.qsTabId);
                        myIframe4.Src = string.Format("wfmTabFeatureFldsB_QUDI.aspx?TabId={0}", clsCommonSession.qsTabId);
                        myIframe6.Src = string.Format("wfmTabFunctionProp_QUDI.aspx?TabId={0}", clsCommonSession.qsTabId);

                    }
                    else if (string.IsNullOrEmpty(clsCommonSession.TabId) == false)
                    {
                        clsCommonJsFunc.Alert(this, "TabId不能为空！");
                        return;
                        //myIframe1.Src = "";
                        //myIframe2.Src = "";
                        //myIframe3.Src = "";
                        //myIframe4.Src = "";
                        //myIframe6.Src = "";
                    }
                    //初始化父页面传递过来的信息
                    InitParentPageInfo();

                    BindTv_ApplicationType_CodeType_Function4GeneCode();
                    clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId_SetField);
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    return;
                }


                //clsPubFun.ShowUserDefaLangType(rblNetOrJava);

                vsViewName = "表字段维护";
                vsExportTabName = "vPrjTabFld";
                strSortPrjTabFldBy = "SequenceNumber Asc";
                strSortObjFldTabBy = "FldName Asc";

                clsPrjTabBLEx.BindDdl_TabIdByPrjIdEx(ddlPrjTab_SetField, clsPubVar.CurrSelPrjId);

                clsPrjTabEN objPrjTabEN = null;
                if (string.IsNullOrEmpty(vsTabId) == false)
                {

                    objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId, clsPubVar.CurrSelPrjId);
                    vsSqlDsTypeId = objPrjTabEN.SqlDsTypeId;
                    //转换成相关表ID(TabId)
                    //string strObjId = objPrjTabEN.ObjId;// clsPrjTabBLEx.GetObjIdByTabId(vsTabId);
                    //vsObjId = strObjId;
                    //tabAllPrjTab.ActiveTabIndex = 1;
                    //表字段区域
                    if (string.IsNullOrEmpty(vsIsBindTabField) == true)
                    {
                        EditPrjTabFieldByTabId(vsTabId);
                        vsIsBindTabField = "true";
                    }
                }

                else if (string.IsNullOrEmpty(qsFromWebForm) == false)
                {
                    //EditPrjTabFieldByTabId(clsCommonSession.TabId);
                }
                else if (string.IsNullOrEmpty(new clsCommonSession().ActiveViewIndex) == false)
                {
                    DispMenuItemClick(new clsCommonSession().ActiveViewIndex);
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
                        objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId, clsPubVar.CurrSelPrjId);
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
                        btnSetFldOrderNum4View.Visible = false;
                        btnCreateView4Sql.Visible = false;
                        btnImportSqlViewFromSqlServer.Visible = false;
                        btnAnalysis.Visible = false;

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
                    //EditPrjTab(vsTabId);
                    //DispGeneCode();
                    //DispGeneStoreProcedure();
                    //设置是否显示3个相关LinkButton
                    DispReleButton();
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            //为字段类型添加改变事件
            ddlFldType.Attributes.Add("onchange", "return ddlFldType_OnSelectIndexChange();");
            //把字段类型的所有数据送到前后
            string strJSONStr = clsDataTypeAbbrBLEx.GetJSONObjLstCacheEx();
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
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType(vsLangType);
            //            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = strDataBaseType;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }
        private void DispDiv4Operate(string strNetOrJava, string strSqlOrOracle)
        {
            //string strNetOrJava, strSqlOrOracle;
            //strNetOrJava = rblNetOrJava.SelectedValue;
            //strSqlOrOracle = rblSqlOrOracle.SelectedValue;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
           
            try
            {
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言", vsLangType.ToString());
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
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
        private void DispMenuItemClick(string strActiveViewIndex)
        {
            int intActiveViewIndex = int.Parse(strActiveViewIndex);
            switch (intActiveViewIndex)
            {
                case 0:

                case 1:
                    //获取
                    EditPrjTab(vsTabId);
                    break;
                case 2:

                case 3:
                    //获取
                    EditPrjTabFieldByTabId(vsTabId);
                    break;
                case 4:
                    //获取
                    DispGeneCode();
                    break;
                case 5:
                    //获取
                    try
                    {
                        DispGeneStoreProcedure(clsPubVar.CurrPrjDataBaseId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                    }
                    break;
                default:
                    break;
            }
        }


        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //MultiView1.ActiveViewIndex = int.Parse(e.Item.Value);
            //new clsCommonSession().ActiveViewIndex = MultiView1.ActiveViewIndex.ToString();
            //switch (MultiView1.ActiveViewIndex)
            //{
            //    case 0:

            //        EditPrjObject(vsObjId);
            //        break;
            //    case 1:
            //        //获取
            //        EditPrjTab(vsTabId);
            //        break;
            //    case 2:
            //        //获取
            //        EditTabFieldByObjId(vsObjId);
            //        break;
            //    case 3:
            //        //获取
            //        EditPrjTabFieldByTabId(vsTabId);
            //        break;
            //    case 4:
            //        //获取
            //        DispGeneCode();
            //        break;
            //    case 5:
            //        //获取
            //        DispGeneStoreProcedure();
            //        break;
            //    default:
            //        break;
            //}
        }


        //private void DispObjList()
        //{
        //    //tabQuery.Visible = true;
        //    //tabLayout.Visible = false;
        //}
        #region "编辑工程对象(PrjObject)"


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
            if (string.IsNullOrEmpty(wucPrjTab1.RelaTabId4View))
            {
                pobjPrjTab.RelaTabId4View = null;
            }
            else
            {
                pobjPrjTab.RelaTabId4View = wucPrjTab1.RelaTabId4View;
            }
            pobjPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            pobjPrjTab.IsReleToSqlTab = wucPrjTab1.IsReleToSqlTab;
            pobjPrjTab.IsNeedGeneIndexer = true;// wucPrjTab1.IsNeedGeneIndexer;

            pobjPrjTab.TabTypeId = wucPrjTab1.TabTypeId;
            pobjPrjTab.TabMainTypeId = wucPrjTab1.TabMainTypeId;

            pobjPrjTab.IsUseCache = wucPrjTab1.IsUseCache;            
            pobjPrjTab.CacheClassifyField = wucPrjTab1.CacheClassifyField;
            pobjPrjTab.CacheClassifyField2 = wucPrjTab1.CacheClassifyField2;
                        
            pobjPrjTab.CacheModeId = wucPrjTab1.CacheModeId;
            pobjPrjTab.CacheClassifyFieldTS = wucPrjTab1.CacheClassifyFieldTS;
            pobjPrjTab.CacheClassifyField2TS = wucPrjTab1.CacheClassifyField2TS;


        }

        private bool AddPrjTabSave()
        {

            clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            objPrjTabEN.DataBaseName = new clsCommonSession().PrjDataBaseName;

            if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
            {
                throw new clsDbObjException("关键字字段已有相同的值!");
            }

            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjTabClass(objPrjTabEN);		//把界面的值传到
            ///3.1、判断是否有相同的函数名称存在。					
            if (clsPrjTabBLEx.IsExistSameTabName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName))	//判断是否有相同的关键字
            {
                throw new clsDbObjException("相同的工程表名称已经存在!");
            }
            //5、检查传进去的对象属性是否合法
            try
            {
                clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return false;
            }

            if (clsPrjTabBL.IsExistRecord("PrjId = '" + clsPubVar.CurrSelPrjId + "' and TabName = '" + objPrjTabEN.TabName + "'") == true)
            {
                throw new clsDbObjException("在工程表中已经存在相同的表名：" + objPrjTabEN.TabName);
            }
            //6、把数据实体层的数据存贮到数据库中
            if (clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN) == false)
            {
                throw new clsDbObjException("添加工程表不成功");
            }

            return true;
        }

        #endregion

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
            wucPrjTab1.SetDdl_TabMainTypeIdCache();
            wucPrjTab1.SetDdl_CacheModeIdCache();

            wucPrjTab1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
            wucPrjTab1.SetDdl_CacheClassifyField(seTabId);
            wucPrjTab1.SetDdl_CacheClassifyField2(seTabId);

            wucPrjTab1.SetDdl_CacheClassifyFieldTS(seTabId);
            wucPrjTab1.SetDdl_CacheClassifyField2TS(seTabId);

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
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId);
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
            wucPrjTab1.TabMainTypeId = pobjPrjTab.TabMainTypeId;

            wucPrjTab1.IsUseCache = pobjPrjTab.IsUseCache;
            
            wucPrjTab1.CacheClassifyField = pobjPrjTab.CacheClassifyField;
            wucPrjTab1.CacheClassifyField2 = pobjPrjTab.CacheClassifyField2;
                        
            wucPrjTab1.CacheModeId = pobjPrjTab.CacheModeId;
            wucPrjTab1.CacheClassifyFieldTS = pobjPrjTab.CacheClassifyFieldTS;
            wucPrjTab1.CacheClassifyField2TS = pobjPrjTab.CacheClassifyField2TS;


        }
        ///生成的插入记录准备过程代码for C#
        protected void AddPrjTabRecord()
        {
            wucPrjTab1.SetKeyReadOnly(false);
            btnOKUpd4Tab.Text = "确认添加";
            //wucPrjTab1.TabId = clsPrjTabBL.GetMaxStrId("PrjTab","TabId", 8, "");
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

        #region "编辑对象相关字段"


        /// <summary>
        /// 绑定专门用于工程表的下拉框
        /// </summary>
        private void BindDdl4FieldTabByObj2()
        {
            clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
            clsDropDownList.BindDdl_IsNull(ddlIsNull);
            clsDropDownList.BindDdl_IsPrimaryKey(ddlIsPrimaryKey);

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

        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //复制字段
            CopyField();
        }
        /// <summary>
        /// 复制字段
        /// </summary>
        private void CopyField()
        {
            //string strMsg;
            //判断是否有选中的对象ID
            //string strObjId = vsObjId;
            
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (long lngMId in lstMId)
                {
                    clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngMId);
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);

                    clsFieldTabBLEx.CopyField4PrjTab(clsPubVar.CurrSelPrjId, objFieldTabEN.FldId,
                        objFieldTabEN.FldName + "_Copy", objPrjTabFldEN.TabId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "复制字段不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vPrjTabFld();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

        }
        protected void lbDelFieldTabEx_Click(object sender, EventArgs e)
        {

        }
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_vPrjTabFld();
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineFieldTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            strWhereCond += " and PrjId='" + clsPubVar.CurrSelPrjId + "'";

            return strWhereCond;
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
            string strFldId = "";
            string strCondition = "";
            lblMsg4AddRecord.Text = "";
            if (string.IsNullOrEmpty(hidFldId.Value) == false)
            {
                strFldId = hidFldId.Value.Substring(3, 8);
                AddFieldTabByFldId(strFldId);
                hidFldId.Value = "";
                return;
            }
            clsFieldTabEN objFieldTabEN;

            List<clsFieldTabEN> arrFieldTabObjLst = null;
            if (string.IsNullOrEmpty(DataTypeId) == true)
            {
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' ",
                           clsPubVar.CurrSelPrjId, FldName);
                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 1)
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
                else if (arrFieldTabObjLst.Count > 1)
                {
                    strMsg = "请选择字段类型!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    ddlFldType.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == true)
            {
                //检查是否存在相同字段名
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                              clsPubVar.CurrSelPrjId, FldName, DataTypeId);

                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count > 0)    //判断是否有相同的关键字
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == false)
            {

                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(vsTabId);
                clsPrjTabBL.GetPrjTab(ref objPrjTabEN);

                strMsg = string.Format("在当前工程的《字段表》中已存在相同的字段名称:[{1}]，已经添加到当前表：{0}的字段中!",
                                  objPrjTabEN.TabName,
                                FldName);
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                //strFldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, FldName, DataTypeId);
                //                clsPrjTabFldBLEx.CreateFldObjRelation(vsObjId, strFldId);
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(objPrjTabEN.TabId, strFldId, clsCommonSession.UserId);

                BindGv_vPrjTabFld();

                return;
            }
            try
            {
                strFldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                objFieldTabEN = new clsFieldTabEN(strFldId);	//初始化新对象
                //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                if (clsFieldTabBL.IsExist(objFieldTabEN.FldId)) //判断是否有相同的关键字
                {
                    strMsg = "关键字字段已有相同的值";
                    lblMsg4AddRecord.Text = strMsg;
                    //                clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToFieldTabClass2(objFieldTabEN);		//把界面的值传到
                //5、检查传进去的对象属性是否合法

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
                    lblMsg4AddRecord.Text = "添加记录不成功!";
                }
                else
                {
                    lblMsg4AddRecord.Text = "添加记录成功!";
                    //clsPrjTabFldBLEx.CreateFldObjRelation(vsObjId, strFldId);
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(vsTabId,
                        strFldId, clsCommonSession.UserId);
                    //                    clsPrjTabBLEx.SetKeyFld4PrjTabByTabId(vsTabId, clsCommonSession.UserId);
                }
                //7、把新添的记录内容显示在DATAGRID中

                BindGv_vPrjTabFld();
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }

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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        private bool AddFieldTabByFldId(string strFldId)
        {
            clsFieldTabEN objFieldTabEN;
            string strMsg = "";
            //List<clsFieldTabEN> arrFieldTabObjLst = null;
            if (string.IsNullOrEmpty(strFldId) == true)
            {
                return false;
            }
            try
            {
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(vsTabId);
                clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
                objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
                if (objFieldTabEN.PrjId != clsPubVar.CurrSelPrjId)
                {
                    string strCondition = string.Format("{0}='{1}' And {2}='{3}' And {4}='{5}'",
                        conFieldTab.PrjId, clsPubVar.CurrSelPrjId,
                        conFieldTab.FldName, objFieldTabEN.FldName,
                        conFieldTab.DataTypeId, objFieldTabEN.DataTypeId);
                    if (clsFieldTabBL.IsExistRecord(strCondition) == true)
                    {
                        objFieldTabEN = clsFieldTabBL.GetFirstObj_S(strCondition);
                    }
                    else
                    {
                        objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                        objFieldTabEN.PrjId = clsPubVar.CurrSelPrjId;
                        objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                        objFieldTabEN.UpdUser = clsCommonSession.UserId;
                        //6、把数据实体层的数据存贮到数据库中
                        if (objFieldTabEN.AddRecordEx() == false)
                        {
                            strMsg = string.Format("添加字段:[{0}]记录不成功!({1})",
                                objFieldTabEN.FldName, clsStackTrace.GetCurrClassFunction());
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg4AddRecord.Text = strMsg;
                            return false;
                        }
                    }
                }
                strMsg = string.Format("在《字段表》中已存在相同的字段名称:[{1}]，已经添加到当前表：{0}的字段中!",
                                  objPrjTabEN.TabName,
                                objFieldTabEN.FldName);
                lblMsg4AddRecord.Text = strMsg;
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(objPrjTabEN.TabId, objFieldTabEN.FldId, clsCommonSession.UserId);

                BindGv_vPrjTabFld();

                return true;
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return false;
            }

            //try
            //{
            //    //添加日志
            //    string strUserId = clsCommonSession.UserId;
            //    string strUserIp = Request.UserHostAddress;
            //    string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
            //    string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //删除记录;
            //    string strTableName = "FieldTab";
            //    string strTableKey = objFieldTabEN.FldId;
            //    string strJournal = "执行了添加操作，添加表FieldTab! 字段名："
            //        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";

            //    bool IsSuccesful = true;
            //    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
            //        strUserIp,
            //        strOperationType,
            //        strTableName,
            //        strTableKey,
            //        strJournal,
            //        clsPubVar.CurrSelPrjId);
            //}
            //catch (Exception objException)
            //{
            //    clsCommonSession.seErrMessage = "添加记录的添加日志不成功!\r\n" + objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //}
            //return true;
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
            if (DataTypeId == enumDataTypeAbbr.bigint_01
                || DataTypeId == enumDataTypeAbbr.int_09
                || DataTypeId == enumDataTypeAbbr.char_04
                || DataTypeId == enumDataTypeAbbr.varchar_25
                || DataTypeId == enumDataTypeAbbr.nvarchar_15
                || DataTypeId == enumDataTypeAbbr.text_20
                || DataTypeId == enumDataTypeAbbr.bit_03
                )
            {
                pobjFieldTab.FldPrecision = 0;
            }
            else
            {
                pobjFieldTab.FldPrecision = FldPrecision;
            }

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
            pobjFieldTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            pobjFieldTab.UpdUser = clsCommonSession.UserId;
            pobjFieldTab.FldStateId = "01";
   
            //			pobjFieldTab.AppliedScope = wucFieldTab1.AppliedScope;
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
                if (clsString.IsNumeric(txtFldLength.Text.Trim()) == false)
                {
                    throw new Exception("【字段长度】应该为整数！");
                }
                return int.Parse(txtFldLength.Text.Trim());
            }
            set
            {
                txtFldLength.Text = value.ToString();
            }
        }

        /// <summary>
        /// 小数位数，精确度
        /// </summary>
        public int FldPrecision
        {
            get
            {
                if (string.IsNullOrEmpty(txtFldPrecision.Text.Trim()) == true) return 0;
                if (clsString.IsNumeric(txtFldPrecision.Text.Trim()) == false)
                {
                    throw new Exception("【小数位数】应该为整数！");
                }
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

        #endregion
        #region "编辑工程表字段(PrjTabFields)"
        private void EditPrjTabFieldByTabId(string strTabId)
        {
            //MultiView1.ActiveViewIndex = 3;
            btnOKEdit.Text = "确认修改";
            BindDdl4FieldTabByObj2();
            //BindDdl4PrjTabFieldByTable();
            BindGv_vPrjTabFld();
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
            wucPrjTabFld1.SetDdl_FldOpTypeId();
            //2、显示无条件的表内容在DATAGRID中

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
            this.dgFieldTab4Sel.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_PrjTabFld();
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
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(pobjPrjTabFld.FldId);

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
                    BindGv_vPrjTabFld();
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
                        try
                        {
                            clsTabFeatureFldsBLEx.AddBindDdl(objPrjTabFld.TabId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                        }

                        strMsg = "修改记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "修改记录成功!";
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    BindGv_vPrjTabFld();
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
            pobjPrjTabFld.SetTabId(vsTabId)
                .SetFldId(wucPrjTabFld1.FldId)
            .SetIsTabUnique (wucPrjTabFld1.IsTabUnique)
.SetIsTabNullable ( wucPrjTabFld1.IsTabNullable)
            .SetIsParentObj ( wucPrjTabFld1.IsParentObj)
.SetPrimaryTypeId ( wucPrjTabFld1.PrimaryTypeId)
.SetFldOpTypeId ( wucPrjTabFld1.FldOpTypeId)
            .SetIsTabForeignKey (wucPrjTabFld1.IsTabForeignKey)
.SetForeignKeyTabId ( wucPrjTabFld1.ForeignKeyTabId)
            .SetFieldTypeId ( wucPrjTabFld1.FieldTypeId)
            .SetMemoInTab ( wucPrjTabFld1.MemoInTab)
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            .SetUpdUser(clsCommonSession.UserId)          ;

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
                        BindGv_vPrjTabFld();
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

        private void BindDg_PrjTabFld()
        {
            ///如何选择当前默认工程中的所有字段
            ///
            string strTabId = this.ddlPrjTab.SelectedValue;
            string strFldName = this.txtFldNameq.Text.Trim();

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" PrjId='{0}'",
                clsPubVar.CurrSelPrjId);
            sbCondition.AppendFormat(" And FldId not in (select FldId from {0} where {1}='{2}')",
                             clsPrjTabFldEN._CurrTabName,
                              conPrjTabFld.TabId,
                              vsTabId);

            if (ddlPrjTab.SelectedIndex > 0)
            {
                sbCondition.AppendFormat(" And FldId in (select FldId from {0} where {1}='{2}')",
                    clsPrjTabFldEN._CurrTabName,
                    conPrjTabFld.TabId,
                    strTabId);
            }
            if (string.IsNullOrEmpty(strFldName) == false)
            {
                sbCondition.AppendFormat(" and FldName like '{0}%'", strFldName);
            }
            DataTable objDt = clsvFieldTabBL.GetDataTable_vFieldTab(sbCondition.ToString());


            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDt.Rows.Count, dgFieldTab4Sel.PageSize);
            if (intPages == 0)
            {
                dgFieldTab4Sel.CurrentPageIndex = 0;
            }
            else if (dgFieldTab4Sel.CurrentPageIndex > intPages - 1)
            {
                dgFieldTab4Sel.CurrentPageIndex = intPages - 1;
            }
            DataView objDV = objDt.DefaultView;
            objDV.Sort = strSortObjFldTabBy;
            dgFieldTab4Sel.DataSource = objDV;
            dgFieldTab4Sel.DataBind();
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
                strTabId = vsTabId;
                if (strTabId.Length == 0)
                {
                    lblMsg1.Text = "请选择合适的表名";
                    return;
                }
                clsPrjTabFldEN objPrjTabFld;
                intTabFldCount = clsPrjTabFldBL.GetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
                foreach (string FldId in objArr)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(FldId);
                    

                    bolIsnullable = objFieldTabEN.IsNull;
                    objPrjTabFld = new clsPrjTabFldEN();
                    objPrjTabFld.TabId = vsTabId;
                    objPrjTabFld.PrjId = clsPubVar.CurrSelPrjId;
                    objPrjTabFld.FldId = FldId;

                    objPrjTabFld.IsTabNullable = bolIsnullable;
                    objPrjTabFld.PrimaryTypeId = "00";
                    objPrjTabFld.FldOpTypeId = "0001";

                    objPrjTabFld.FieldTypeId = "01";
                    ///3.1、判断是否有相同的字段存在。					
                    if (clsPrjTabFldBLEx.IsExistSameFldId(vsTabId, FldId))	//判断是否有相同的关键字
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

        protected void btnSetProperty_Click(object sender, System.EventArgs e)
        {
            long lngmId = wucvPrjTabFld4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            SetProperty(lngmId);
        }
            protected void SetProperty(long lngmId)
            {
                //操作步骤：（总共2步）
                //1、显示该关键字记录的内容在界面上；
                //2、清空提示信息的内容,同时使<确定修改>按钮可用；

                //1、显示该关键字记录的内容在界面上；

                //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                //clsPubFun.SetButtonEnabled(btnOKUpd, true);
                //btnOKUpd.Text = "确认修改";
                //long lngmId;        //当前所选记录的关键字MId
                //1、获取当前所选中的字段ID。
                ///
       

            lblMsgList.Text = "";
            if (string.IsNullOrEmpty(vsIsBindDdl4TabField) == true)
            {
                BindDdl4PrjTabFieldByTable();
                vsIsBindDdl4TabField = "true";
            }

            //1、显示该关键字的数据让用户修改该关键字记录；
            //lngmId = long.Parse(strmId);
            string strFldId = clsPrjTabFldBL.GetObjBymId(lngmId).FldId;



            DispEditPrjTabFld();
            ShowData(lngmId);
            this.wucPrjTabFld1.SetKeyReadOnly(true);
            //				lblMsg.Text = "";

        }

        protected void btnDelRec_Click(object sender, System.EventArgs e)
        {
            List<long> arrmId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (arrmId.Count == 0) return;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            arrmId.ForEach(x=> clsPrjTabFldBLEx.DelRecordEx(x));
            
            BindGv_vPrjTabFld();
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
            try
            {
                PutDataToPrjTabFldClass(objPrjTabFld);      //把界面的值传到
            }
            catch (Exception objException)
            {
                strMsg = string.Format("为对象属性赋值出错!\r\n{0}. (In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit3.Text = strMsg;
                return;
            }
            //3、检查传进去的对象属性是否合法
            
            try
            {
                clsPrjTabFldBL.CheckPropertyNew(objPrjTabFld);
            }
            catch (Exception objException)
            {
                strMsg = string.Format("检查字段属性出错!\r\n{0}. (In {1})" , objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit3.Text = strMsg;
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
                        clsTabCheckStatusEN objPrjTab_CheckEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objPrjTabFld.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                        clsCommonJsFunc.Alert(this, objPrjTab_CheckEN.ErrorMsg);
                        //return;
                    }
                    //clsPrjTabBLEx.SetUpdDate(objPrjTabFld.TabId);
                    clsPrjTabBLEx.SetKeyFld4PrjTabByTabId(objPrjTabFld.TabId, clsCommonSession.UserId);



                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //5、把修改后的内容显示在DATAGRID中
            BindGv_vPrjTabFld();
            wucPrjTabFld1.Clear();//添空控件中的内容
            DispPrjTabFldList();
            //恢复<确认修改>变成<添加>
            //			btnOKUpd.Text = "添加";
        }

        protected void btnOkAdd_Click(object sender, System.EventArgs e)
        {
            //			string strWhereCond;
            string strFldId;
            System.Data.DataTable objDT;
            ArrayList objArr = new ArrayList();
            if (chkSelAll.Checked == true)
            {
                //	1、组合界面条件串；
                //	2、根据条件串获取该表满足条件的DataTable；
                string strCondition = string.Format("{0} = '{1}'",
                    conPrjTabFld.TabId,
                    ddlPrjTab.SelectedValue);
                objDT = clsPrjTabFldBL.GetDataTable_PrjTabFld(strCondition);
                foreach (DataRow objRow in objDT.Rows)
                {
                    strFldId = objRow["FldId"].ToString();
                    objArr.Add(strFldId);
                }
            }
            else
            {
                this.Get_ObjectFldArrylist(this.dgFieldTab4Sel, objArr);
            }
            this.Add_ObjectFldtoPrjTabFld(objArr);
            BindGv_vPrjTabFld();
            Response.Write("<script>alert('所选字段添加成功！！')</script>");
        }

        protected void dgFieldTab4Sel_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgFieldTab4Sel.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_PrjTabFld();
        }

        protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Set_DataGridAllChecked(this.dgFieldTab4Sel, this.chkSelAll);
        }

        protected void ddlPrjTab_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindDg_PrjTabFld();
        }

        
        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            ReturnParentPage();
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
            
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。
            long lngmId = wucvPrjTabFld4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return false;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            
            //lblMsg2.Text = "";
            //2、根据关键字Mid来获取字的序号
            clsPrjTabFldEN objPrjTabEN = clsPrjTabFldBL.GetObjBymId(lngmId);
            intSequenceNumber = objPrjTabEN.SequenceNumber ?? 0;
            intPrevSeqNum = intSequenceNumber - 1;
            intNextSeqNum = intSequenceNumber + 1;
            //3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            strCurrTabId = objPrjTabEN.TabId;		//获取当前记录的{表ID}
            intTabRecNum = clsPrjTabFldBL.GetRecCountByCond("TabId = '" + strCurrTabId + "'");	//获取当前{表ID}的记录数
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
                new clsPrjTabFldBL().SetFldValue(conPrjTabFld.SequenceNumber, intSequenceNumber - 1, "MId = " + lngmId);
                new clsPrjTabFldBL().SetFldValue(conPrjTabFld.SequenceNumber, intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                new clsPrjTabFldBL().SetFldValue(conPrjTabFld.SequenceNumber, intSequenceNumber + 1, "MId = " + lngmId);
                new clsPrjTabFldBL().SetFldValue(conPrjTabFld.SequenceNumber, intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            //7、重新显示DATAGRID
            BindGv_vPrjTabFld();
            wucvPrjTabFld4Gv1.SetCheckedItemForGv(lngmId);
            if (vsTabRecNum > 20)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_PrjTabFld{0}'",
                       lngmId), true);
            }
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
                BindGv_vPrjTabFld();
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
            BindGv_vPrjTabFld();
        }

        protected void dgFieldTab4Sel_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortObjFldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortObjFldTabBy = e.SortExpression + " Asc";
                BindDg_PrjTabFld();
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
            BindDg_PrjTabFld();
        }

        protected void dgFieldTab4Sel_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortObjFldTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgFieldTab4Sel.Columns.Count; i++)
                {
                    strSortEx = this.dgFieldTab4Sel.Columns[i].SortExpression;
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

        protected void dgFieldTab4Sel_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                //iNum[0] = 6;
                iNum[0] = clsCommForWebForm.GetIndexByDataField4DataGrid(dgFieldTab4Sel, convFieldTab.IsNull);// 6;
                //iNum[1] = 9;
                //iNum[2] = clsCommForWebForm.GetIndexByDataField4GridView(gvPrjTabFld, convPrjTabFld.IsTabUnique);//11;
                //iNum[3] = clsCommForWebForm.GetIndexByDataField4GridView(gvPrjTabFld, convPrjTabFld.IsTabForeignKey);//13;
                //iNum[4] = clsCommForWebForm.GetIndexByDataField4GridView(gvPrjTabFld, convPrjTabFld.IsSortFld);//14;
                //iNum[5] = clsCommForWebForm.GetIndexByDataField4GridView(gvPrjTabFld, convPrjTabFld.IsParentObj);//15;
                //				iNum[1] = 7;
                for (int i = 0; i < 1; i++)
                {
                    try
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
                    catch(Exception objException)
                    {

                    }
                }

            }
        }


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
            string strWhereCond = CombinevPrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsvPrjTabFldBL.GetDataTable(strWhereCond + " order by SequenceNumber");
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId,clsPubVar.CurrSelPrjId);
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
            //arrColName.Add("Memo"); arrCnName.Add("说明");




            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;
            objExportExcelSetENEx.TabName = vsExportTabName;
            objExportExcelSetENEx.ExportFileName = strFileName;
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;
            objExportExcelSetENEx.arrCnName = arrCnName;
            objExportExcelSetENEx.arrColName = arrColName;
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;
                arrCnName = objExportExcelSetENEx.arrCnName;
                arrColName = objExportExcelSetENEx.arrColName;
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                ///	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
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
        private void MoveRecTo(int intNewSeqNum)
        {
            bool bolIsSuccess = false;
                  //int intNewSeqNum = 0;	//准备移到的新序号
                  List<string> arrList = new List<string>();
            int intSeqNum;

            //获取当前记录的序号
        var  arrmId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (arrmId.Count == 0) return;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (long lngmId in arrmId)
            {
                arrList = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "Mid = " + lngmId.ToString());
                if (arrList == null)
                {
                    return;
                }
                intSeqNum = int.Parse(arrList[0].ToString());

                string strFileFolder = Server.MapPath("~");
                bolIsSuccess = (new clsPrjTabFldBLEx().MoveRecSeqTo(vsTabId, intSeqNum, intNewSeqNum));
            }
            if (bolIsSuccess == true)
            {
                BindGv_vPrjTabFld();
                wucvPrjTabFld4Gv1.SetCheckedItemForGv(arrmId[0]);
                if (vsTabRecNum > 20)
                {
                    this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_PrjTabFld{0}'",
                                arrmId[0]), true);
                }
            }

        }

        protected void lbMoveRecTo_Click(object sender, System.EventArgs e)
        {
 
            int intNewSeqNum = 0;	//准备移到的新序号
            List<string> arrList = new List<string>();
            int intSeqNum;
            //lblMsg2.Text = "";
            bool bolIsSuccess = false;
         //获取当前记录的序号
         var arrmId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            
            if (arrmId.Count == 0) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (long lngmId in arrmId)
            {
                arrList = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "Mid = " + lngmId.ToString());
                if (arrList == null)
                {
                    //lblMsg2.Text = "序号不正常!";
                    return;
                }
                intSeqNum = int.Parse(arrList[0].ToString());

                if (string.IsNullOrEmpty(txtRecSeqNum.Text) == true)
                {
                    //lblMsg2.Text = ;
                    clsCommonJsFunc.Alert(this, "请输入新的序号!");
                }
                intNewSeqNum = int.Parse(txtRecSeqNum.Text);

                string strFileFolder = Server.MapPath("~");
                bolIsSuccess = (new clsPrjTabFldBLEx().MoveRecSeqTo(vsTabId, intSeqNum, intNewSeqNum));
            }
            if (bolIsSuccess == true)
            {
                BindGv_vPrjTabFld();
                wucvPrjTabFld4Gv1.SetCheckedItemForGv(arrmId[0]);
                this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_PrjTabFld{0}'",
                            arrmId[0].ToString()), true);
            }

        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vPrjTabFld()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevPrjTabFldCondition();
                wucvPrjTabFld4Gv1.SetSortBy(conPrjTabFld.SequenceNumber);
                //	2、调用控件中的绑定GridView函数；
                wucvPrjTabFld4Gv1.BindGv_PrjTabFld(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvPrjTabFld4Gv1.SetGvVisibility(convPrjTabFld.UpdDate, false);
                //wucvPrjTabFld4Gv1.SetGvVisibility(convPrjTabFld.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        //protected void BindGv_vPrjTabFld()
        //{
        //    //操作步骤：(共5步)
        //    //	1、组合界面条件串；
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    //	4、设置GridView的数据源(DataSource)；
        //    //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
        //    //	6、设置记录数的状态，
        //    //		在本界面中是把状态显示在控件txtRecCount中。

        //    //	1、组合界面条件串；
        //    string strWhereCond = CombinePrjTabFldCondition();
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    System.Data.DataTable objDT = null;
        //    try
        //    {
        //        objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
        //        vsTabRecNum = objDT.Rows.Count;
        //        if (vsSqlDsTypeId == "02")//视图
        //        {
        //            clsPrjTabFldBLEx.AddColumn_SourceTabName(ref objDT);
        //        }
        //        else
        //        {
        //            objDT.Columns.Add("SourceTabName");
        //        }
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //    //	4、设置GRIDView的数据源(DataSource)；
        //    DataView objDV = objDT.DefaultView;
        //    objDV.Sort = strSortPrjTabFldBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
        //                                         ///设置GridView中每页的记录数
        //    if (string.IsNullOrEmpty(PageSize) == false)
        //    {
        //        int intPageSize = int.Parse(PageSize);
        //        gvPrjTabFld.PageSize = intPageSize;
        //    }
        //    else
        //    {
        //        PageSize = "100";
        //        gvPrjTabFld.PageSize = 100;
        //    }
        //    this.gvPrjTabFld.DataSource = objDV;
        //    //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
        //    this.gvPrjTabFld.DataBind();

        //    ///生成专门用于BindGv中的跳页相关代码
        //    GridViewRow pagerRow = gvPrjTabFld.BottomPagerRow;
        //    if (pagerRow == null)
        //    {
        //        return;
        //    }
        //    Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
        //    Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
        //    Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
        //    TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
        //    Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
        //    Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
        //    Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
        //    DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
        //    if (lblRecCount != null)
        //    {
        //        //当前记录数
        //        lblRecCount.Text = objDT.Rows.Count.ToString();
        //        //当前页数
        //        lblAllPages.Text = this.gvPrjTabFld.PageCount.ToString();
        //        //当前页序数
        //        lblCurrentPage.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
        //        //当前即将跳到的页序数
        //        txtJump2Page.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
        //        //如果当前页序数为0，则<前一页>按钮无效
        //        if (this.gvPrjTabFld.PageIndex == 0)
        //        {
        //            clsPubFun.SetButtonEnabled(btnPrevPage, false);
        //        }
        //        else
        //        {
        //            clsPubFun.SetButtonEnabled(btnPrevPage, true);
        //        }
        //        //如果当前页序数已为最后一页，则<前一页>按钮无效
        //        if (this.gvPrjTabFld.PageIndex == this.gvPrjTabFld.PageCount - 1)
        //        {
        //            clsPubFun.SetButtonEnabled(btnNextPage, false);
        //        }
        //        else
        //        {
        //            clsPubFun.SetButtonEnabled(btnNextPage, true);
        //        }
        //        //设置分页器中每页记录数的下拉框的值
        //        if (string.IsNullOrEmpty(PageSize) == false)
        //        {
        //            ddlPagerRecCount.Text = PageSize;
        //        }
        //        else
        //        {
        //            PageSize = "100";
        //            ddlPagerRecCount.Text = PageSize;
        //        }
        //    }
        //    gvPrjTabFld.BottomPagerRow.Visible = true;
        //}
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
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlPrjTab, clsPubVar.CurrSelPrjId);
        }

        private void DispPrjTabFldList()
        {
            tabPrjTabFld.Visible = true;
            tabEditPrjTabFld.Visible = false;
            tabFieldTab.Visible = false;
        }

        //protected void btnSynchWithTab_Click(object sender, System.EventArgs e)
        //{
        //    //操作步骤：
        //    //1、获取当前表ID的相关对象ID；
        //    //2、获取相关对象ID的字段ID的DataTable;
        //    //3、对该表进行循环，把字段信息插入到一个ArrayList
        //    //4、在插入过程中，要注意字段ID的重复，不能插入重复
        //    //			string strWhereCond;
        //    string strObjId;
        //    //1、获取当前表ID的相关对象ID；
        //    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(vsTabId);
        //    strObjId = objPrjTabEN.ObjId;
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, objPrjTabEN.PrjId) == true)
        //        {
        //            Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！！')</script>");
        //        }
        //        clsPrjTabBLEx.SetUpdDate(vsTabId);
        //        BindGv_vPrjTabFld();
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = "同步对象字段与表字段不成功!\r\n" + objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsPrjTabFldBLEx.ReOrder(vsTabId);
            BindGv_vPrjTabFld();
        }
             
        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinevPrjTabFldCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = string.Format(" 1=1 and TabId='{0}'",  vsTabId);
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

        #region "生成代码"

        private void DispGeneCode()
        {
            //显示不同操作显示区域
            //DispDiv4Operate();
        }
          protected void lbImportSQLTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportTabInfoFromSQL.aspx");
        }
        protected void lbImportSQLView_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmImportViewInfoFromSQL2.aspx");
        }
        protected void btnCheckConsistency_Click(object sender, EventArgs e)
        {
            JumpOtherPages("CheckConsistency");
        }

        protected void btnImportExtendFld_Click(object sender, EventArgs e)
        {
            //JumpOtherPages("CheckConsistency");
            var arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByPrjIdCache(clsPubVar.CurrSelPrjId);
            var arrDGRegionFlds_Extend = arrDGRegionFlds.Where(x=> string.IsNullOrEmpty( x.OutFldId) == false).ToList();
            var arrDGRegionFldsEx_Extend = arrDGRegionFlds_Extend.Select(clsDGRegionFldsBLEx.CopyToEx).ToList();
            foreach (var objInFor in arrDGRegionFldsEx_Extend)
            {
                var objViewRegion = objInFor.ObjViewRegion();
             
                if (string.IsNullOrEmpty(objInFor.OutFldId) == true) continue;
                //var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, clsCommonSession.CmPrjId);
                //if (objDataNode == null) continue;
                //AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objInFor.DataPropertyName, objInFor.HeaderText, objInFor.DnPathId);
            }

            var arrExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjLstByPrjIdCache(clsPubVar.CurrSelPrjId);
            var arrExcelExportRegionFlds_Extend = arrExcelExportRegionFlds.Where(x => string.IsNullOrEmpty(x.OutFldId) == false).ToList();
            var arrExcelExportRegionFldsEx_Extend = arrExcelExportRegionFlds_Extend.Select(clsExcelExportRegionFldsBLEx.CopyToEx).ToList();

            foreach (var objInFor in arrExcelExportRegionFldsEx_Extend)
            {
                var objViewRegion = objInFor.ObjViewRegion();

                //if (string.IsNullOrEmpty(objInFor.DataPropertyName) == true) continue;
                //var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, clsCommonSession.CmPrjId);
                //if (objDataNode == null) continue;
                //AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objInFor.DataPropertyName, objInFor.ColCaption, objInFor.DnPathId);

            }


            //var arrDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjLstByPrjIdCache(clsCommonSession.CmPrjId, clsPubVar.CurrSelPrjId);
            //var arrDetailRegionFlds_Extend = arrDetailRegionFlds.Where(x => x.IsUseFunc == true).ToList();
            //foreach (var objInFor in arrDetailRegionFlds_Extend)
            //{
            //    var objViewRegion = objInFor.ObjViewRegion(clsPubVar.CurrCmPrjId);
                                
            //    if (string.IsNullOrEmpty(objInFor.DataPropertyName) == true) continue;
            //    var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, clsCommonSession.CmPrjId);
            //    if (objDataNode == null) continue;
            //    AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objInFor.DataPropertyName, objInFor.LabelCaption, objInFor.DnPathId);

            //}
            BindDg_PrjTabFld();
            clsCommonJsFunc.Alert(this, "导入扩展类字段已经完成！");
        }

        private bool AddExtendClassToPrjTabFld(clsDataNodeEN objDataNode, clsViewRegionEN objViewRegion, string strDataPropertyName, string strCaption, string strDnPathId)
        {
            var objFieldTab_S = objDataNode.ObjFieldTab();
            if (objFieldTab_S == null) return false;
            if (objFieldTab_S.FldName == strDataPropertyName)
            {
                if (clsPrjTabFldBLEx.IsExistSameFldId(objViewRegion.TabId, objFieldTab_S.FldId))   //判断是否有相同的关键字
                {
                    var lngMid = clsPrjTabFldBLEx.GetPrimaryKeyByTabIdAndFldId(objViewRegion.TabId, objFieldTab_S.FldId);
                    var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
                    objPrjTabFld.IsForExtendClass = true;
                    objPrjTabFld.DnPathId = strDnPathId;
                    objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objPrjTabFld.UpdUser = clsCommonSession.UserId;
                    objPrjTabFld.Update();
                }
                else
                {
                    clsPrjTabFldBLEx.AddNewRec(objViewRegion.TabId, objFieldTab_S.FldId, true, clsCommonSession.UserId, true, strDnPathId);
                }
            }
            else
            {
                var strFldId = clsFieldTabBLEx.AddNewRec(strDataPropertyName, strCaption, objFieldTab_S.DataTypeId,
                    objFieldTab_S.FldLength, objFieldTab_S.FldPrecision ?? 0, true, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                if (string.IsNullOrEmpty(strFldId) == true) return false;
                if (clsPrjTabFldBLEx.IsExistSameFldId(objViewRegion.TabId, strFldId))   //判断是否有相同的关键字
                {
                    var lngMid = clsPrjTabFldBLEx.GetPrimaryKeyByTabIdAndFldId(objViewRegion.TabId, strFldId);
                    var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
                    objPrjTabFld.IsForExtendClass = true;
                    objPrjTabFld.DnPathId = strDnPathId;
                    objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objPrjTabFld.UpdUser = clsCommonSession.UserId;
                    objPrjTabFld.Update();
                }
                else
                {
                    clsPrjTabFldBLEx.AddNewRec(objViewRegion.TabId, strFldId, true, clsCommonSession.UserId, true, strDnPathId);
                }
            }

            return true;
        }
        
        protected void btnCreateView4Sql_Click(object sender, EventArgs e)
        {
            try
            {
                string strCondition = string.Format("{0}='{1}'", conSqlView.RelaTabId, vsTabId);
                clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition);
                if (objSqlViewEN == null)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabIdEx(vsTabId);
                    string strMsg = string.Format("表名：{0}({1})没有相关的SqlView,请检查！", objPrjTab.TabName, objPrjTab.TabCnName);

                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                string strSqlViewId = objSqlViewEN.SqlViewId;
                //进行尝试生成视图，看视图文本是否合法
                clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, true);
                //正式地生成视图
                clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, false);

                clsCommonJsFunc.Alert(this, "在SQL中建立视图完成！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

            clsCommonJsFunc.Alert(this, "在Sql中建立视图成功！");
        }

        protected void btnImportSqlViewFromSqlServer_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlViewId = "";// clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                try
                {
                    strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                }
                catch (Exception objException)
                {

                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId, clsPubVar.CurrSelPrjId);
                    clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName, clsCommonSession.UserId);
                    strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                }
                clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);
                clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                BindGv_vPrjTabFld();
                clsCommonJsFunc.Alert(this, "导入Sql视图并分析字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                string strRelaTabId = clsSqlViewBLEx.GetRelaTabIdBySqlViewIdCache(clsPubVar.CurrSelPrjId, strSqlViewId);
                if (string.IsNullOrEmpty(strRelaTabId) == false)
                {
                    clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strRelaTabId, "15", "", clsCommonSession.UserId);
                }

                BindGv_vPrjTabFld();
                clsCommonJsFunc.Alert(this, "分析字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void lbImportOracleTab_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Oracle/wfmALL_ALL_TABLES_Q.aspx");
        }
        protected void lbImportOracleView_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Oracle/wfmUser_Views_Q.aspx");
        }
     protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
      
            protected void btnEditEx_Click(object sender, EventArgs e)
        {

            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            vsTabId = strTabId;
            //1、显示该关键字的数据让用户修改该关键字记录；
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../../FrameSetForTable.htm','EditTable'); </script>";
            Response.Write(c1);
        }
        protected void btnCloneTab_Click(object sender, EventArgs e)
        {
            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            string strNewTabId = "";
            try
            {
                strNewTabId = clsPrjTabBLEx.CopyPrjTabInSameProject(clsPubVar.CurrSelPrjId, clsPubVar.CurrCmPrjId, strTabId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "克隆表不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdatePrjTabRecord(strNewTabId);
        }
        protected void lbGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            vsTabId = strTabId;
            string c1 = @"<script language='javascript'>window.open('../Table/wfmGeneStoreProcedure.aspx','生成存储过程'); </script>";
            Response.Write(c1);
        }
              /// <summary>
        /// 显示相关按钮，表名傍边的3个LinkButton
        /// </summary>
        private void DispReleButton()
        {
            string strTabId4ReleTab = "";//表相关视图的TabId
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            string strTabName4ReleTab = "";
            if (vsSqlDsTypeId == "01")
            {
                string strTabId4ReleView = "";//表相关视图的TabId
                strTabId4ReleView = clsPrjTabBLEx.GetRelaViewTabIdByTabName(clsPubVar.CurrSelPrjId, vsTabName);

                if (string.IsNullOrEmpty(strTabId4ReleView) == false)
                {
                    hidTabId4ReleView.Value = strTabId4ReleView;
                    vsTabId_T = strTabId4ReleView;
                    lbEditView.Text = string.Format("编辑相关视图(v{0})", vsTabName);
                    lbEditView.Visible = true;
                }
                else
                {
                    //检查数据库里是否有相关视图
                    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
                    if (objSQL.IsExistView("v" + vsTabName) == true)
                    {
                        lbEditView.Text = string.Format("导入相关视图(v{0})", vsTabName);
                        lbEditView.Visible = true;
                    }
                    else
                    {
                        lbEditView.Visible = false;
                    }
                }
            }
            else if (vsSqlDsTypeId == "02")
            {

                strTabId4ReleTab = clsPrjTabBLEx.GetRelaTabIdByViewName(clsPubVar.CurrSelPrjId, vsTabName);
                strTabName4ReleTab = clsPrjTabBLEx.GetReleTabNameByViewName(vsTabName);
                if (string.IsNullOrEmpty(strTabId4ReleTab) == false)
                {
                    vsRelaTabId4View = strTabId4ReleTab;
                    hidTabId4ReleView.Value = strTabId4ReleTab;
                    vsTabId_T = strTabId4ReleTab;
                    lbEditView.Text = string.Format("编辑相关表({0})", strTabName4ReleTab);
                    lbEditView.Visible = true;
                }
                else
                {

                    //检查数据库里是否有相关视图
                    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
                    if (objSQL.IsExistTable(strTabName4ReleTab) == true)
                    {
                        hidTabName4RelaTab.Value = strTabName4ReleTab;
                        lbEditView.Text = string.Format("导入相关表", strTabName4ReleTab);
                        lbEditView.ToolTip = string.Format("导入相关表({0})", strTabName4ReleTab);
                        lbEditView.Visible = true;
                    }
                    else
                    {
                        lbEditView.Visible = false;
                    }
                }
            }
            //设置相关界面编辑按钮
            string strCondition = "";
            string strMainTabId = "";
            if (vsSqlDsTypeId == "01")
            {
                strCondition = string.Format("MainTabId='{0}'", vsTabId);
                strMainTabId = vsTabId;
            }
            else
            {
                strCondition = string.Format("MainTabId='{0}'", strTabId4ReleTab);
                strMainTabId = strTabId4ReleTab;
            }
            List<clsViewInfoEN> arrViewInfoObjList = clsViewInfoBL.GetSubSet4ViewInfoObjLstByMainTabIdCache(strMainTabId, clsPubVar.CurrSelPrjId);

            if (string.IsNullOrEmpty(vsTabName) == true) return;
            if (arrViewInfoObjList == null || arrViewInfoObjList.Count == 0)
            {
                //检查数据库里是否有相关视图
                if (vsSqlDsTypeId == "02")
                {
                    lbEditInterface.Text = string.Format("新建界面(wfm{0}_QUDI.aspx)", strTabName4ReleTab);
                }
                else
                {
                    lbEditInterface.Text = string.Format("新建界面(wfm{0}_QUDI.aspx)", vsTabName);
                }
                lbEditInterface.Visible = true;

            }
            else
            {
                hidViewId.Value = arrViewInfoObjList[0].ViewId;
                StringBuilder sbHtml = new StringBuilder();
                int intCount = 1;
                foreach (clsViewInfoEN objViewInfoEN in arrViewInfoObjList)
                {
                    sbHtml.AppendFormat(" <a href = '../View/wfmViewInfo_U.aspx?ViewId={0}&ParentPage={1}' class='btn btn-secondary btn-sm'>编辑{3}:{2}</a>",
                        objViewInfoEN.ViewId, Page.Request.Url.AbsolutePath, objViewInfoEN.ViewName,
                        intCount);
                    intCount++;
                }
                litEditInterface.Text = sbHtml.ToString();
                if (vsSqlDsTypeId == "02")
                {
                    lbEditInterface.Text = string.Format("新建界面(wfm{0}_QUDI.aspx)", strTabName4ReleTab);
                }
                else
                {
                    lbEditInterface.Text = string.Format("新建界面(wfm{0}_QUDI.aspx)", vsTabName);
                }
                //if (vsSqlDsTypeId == "02")
                //{
                //    lbEditInterface.Text = string.Format("编辑界面(wfm{0}_QUDI.aspx)", strTabName4ReleTab);
                //}
                //else
                //{
                //    lbEditInterface.Text = string.Format("编辑界面(wfm{0}_QUDI.aspx)", vsTabName);
                //}
                lbEditInterface.Visible = true;

            }
            //            objViewInfoEN.MainTabId
        }
        
        private bool CheckTabFieldBySqlTab(string strTabId)
        {
            if (clsPubVar.objCurrSelProject.IsRelaDataBase == false) return true;
            try
            {
                //判断是否可以删除
                if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId,
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId) == false)
                {
                    lblErrMsg4AGC.Text = "检查表字段不成功!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblErrMsg4AGC.Text = objException.Message;
                //clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }

        #endregion

        #region "生成MSSQL的存储过程"
        private void DispGeneStoreProcedure(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            //显示不同操作显示区域
            string strTabId = vsTabId;
            if (string.IsNullOrEmpty(strTabId) == true) return;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId);
            //lblTabName.Text = string.Format("{0}({1})", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
            clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(objPrjTabEN.PrjId);
            string strStoreProcedure = "";
            bool bolIsExist;
            strStoreProcedure = objPrjTabEN.TabName + "_Add";
            try
            {
                string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("获取存储过程：{0}出错，可能是访问数据出错，数据库名:{1}.错误信息：{2} ",
                    strStoreProcedure, objPrjDataBase.PrjDataBaseName, objException.Message);
                lblMsgList.Text = sbMsg.ToString();
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
                //return;
            }
            if (bolIsExist == true)
            {
                chkStoreProcedure_Add.Checked = true;
                chkStoreProcedure_Add.Enabled = false;
            }
            else
            {
                chkStoreProcedure_Add.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_Update";
            try
            {
                string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_Update.Checked = true;
                    chkStoreProcedure_Update.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_Update.Checked = false;
                }

                strStoreProcedure = objPrjTabEN.TabName + "_Delete";

                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_Delete.Checked = true;
                    chkStoreProcedure_Delete.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_Delete.Checked = false;
                }

                strStoreProcedure = objPrjTabEN.TabName + "_Select";
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_Select.Checked = true;
                    chkStoreProcedure_Select.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_Select.Checked = false;
                }
                strStoreProcedure = objPrjTabEN.TabName + "_SelectOne";
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_SelectOne.Checked = true;
                    chkStoreProcedure_SelectOne.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_SelectOne.Checked = false;
                }

                strStoreProcedure = objPrjTabEN.TabName + "_SelectByCond";
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_SelectByCond.Checked = true;
                    chkStoreProcedure_SelectByCond.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_SelectByCond.Checked = false;
                }

                strStoreProcedure = objPrjTabEN.TabName + "_SelectTop1ByCond";
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_SelTop1ByCond.Checked = true;
                    chkStoreProcedure_SelTop1ByCond.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_SelTop1ByCond.Checked = false;
                }
                strStoreProcedure = objPrjTabEN.TabName + "_IsExist";
                bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
                if (bolIsExist == true)
                {
                    chkStoreProcedure_IsExist.Checked = true;
                    chkStoreProcedure_IsExist.Enabled = false;
                }
                else
                {
                    chkStoreProcedure_IsExist.Checked = false;
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.ShowMessage(objException.Message);
            }
        }

        protected void btnGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            //string strStoreProcedure = "";
            //bool bolIsExist;

            string strTabId = vsTabId;

           
        }

        protected void btnGeneSPXmlPara_Click(object sender, EventArgs e)
        {

            string strTabId = vsTabId;

           

        }
        #endregion
        protected void btnSetCanNull_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            
            foreach (long lngmId in lstMId)
            {       
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsTabNullable = true;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            BindGv_vPrjTabFld();
        }

        protected void btnSetFieldTypeId_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (ddlFieldTypeId_SetField.SelectedIndex<=0)
            {
                string strMsg = string.Format("请选择字段类型！");
                clsCommonJsFunc.Alert(this, strMsg);
                ddlFieldTypeId_SetField.Focus();
                return;
            }
            string strFieldTypeId = ddlFieldTypeId_SetField.SelectedValue;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
     

            foreach (long lngmId in lstMId)
            {
                clsPrjTabFldBLEx.SetFieldTypeId(lngmId, strFieldTypeId, clsCommonSession.UserId);

                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabIdCache(objPrjTabFld.TabId, objPrjTabFld.PrjId);
                if (objPrjTab.SqlDsTypeId == enumSQLDSType.SqlView_02) continue;
                List<string> arrRelaViewTabId = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabFld.TabId, objPrjTabFld.PrjId);
                string strCondition = "";
                if (arrRelaViewTabId.Count > 0)
                {
                    strCondition = string.Format("{0}='{1}' and TabId in ({2})",
                        conPrjTabFld.FldId, objPrjTabFld.FldId,
                        clsArray.GetSqlInStrByArray(arrRelaViewTabId, true));
                    List<string> arrMid = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition);
                    if (arrMid == null) continue;
                    IEnumerable<long> arrLngMid = arrMid.Select(x => long.Parse(x));
                    foreach (long lngInFor in arrLngMid)
                    {
                        clsPrjTabFldBLEx.SetFieldTypeId(lngInFor, strFieldTypeId, clsCommonSession.UserId);
                    }
                }

            }
            BindGv_vPrjTabFld();
        }

        protected void btnCopyToPrjTab_Click(object sender, EventArgs e)
        {
            string strMsg;
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (ddlPrjTab_SetField.SelectedIndex <= 0)
            {
                strMsg = string.Format("请选择复制到的工程表！");
                clsCommonJsFunc.Alert(this, strMsg);
                ddlPrjTab_SetField.Focus();
                return;
            }
            string strTabId = ddlPrjTab_SetField.SelectedValue;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            foreach (long lngmId in lstMId)
            {
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                                
                objPrjTabFld.SetTabId(strTabId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(clsCommonSession.UserId)
                    .SetSequenceNumber(100);

                objPrjTabFld.EditRecordEx();
                try
                {
                    clsPrjTabBLEx.AlterTab4AddField(objPrjTabFld, clsPubVar.CurrPrjDataBaseId);
                }
                catch(Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }
           
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId);
            clsPrjTabBLEx.SetUpdDate(objPrjTab, clsCommonSession.UserId);       
            strMsg = string.Format("已经复制了{0}个字段到工程表:{1}！", objPrjTab.TabName, lstMId.Count);
            clsCommonJsFunc.Alert(this, strMsg);
            //BindGv_vPrjTabFld();
        }
        
        protected void btnSetIsForExtendClass_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            foreach (long lngmId in lstMId)
            {
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsForExtendClass = true;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            BindGv_vPrjTabFld();
        }

        protected void btnSetIsNotForExtendClass_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            foreach (long lngmId in lstMId)
            {
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsForExtendClass = false;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            BindGv_vPrjTabFld();
        }
        protected void btnSetCanNotNull_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
       
            foreach (long lngmId in lstMId)
            {          
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsTabNullable = false;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabEN.PrjId = objPrjTabFld.PrjId;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            BindGv_vPrjTabFld();
        }
        private void CheckField()
        {
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTabByCodeTab(objFieldTabEN);
            }
        }

        protected void lbRefresh_Click(object sender, EventArgs e)
        {
            WS_FieldName.autoCompleteWordList = null;

            //WS_FieldName obj = new WS_FieldName();
            //obj.RefreshWorkList();
            //localhost.WebService1 oService = new localhost.WebService1();

            //string mfCommand = TextBox1.Text;

            //ds = oService.GetByUser(mfCommand);


        }

        protected void lbEditView_Click(object sender, EventArgs e)
        {
            string strTabId = vsTabId;
            string strTabName = new clsCommonSession().TabName;
            if (lbEditView.Text.IndexOf("编辑相关视图") >= 0)
            {
                if (string.IsNullOrEmpty(vsTabId_T))
                {
                    string strMsg = string.Format("相关视图表Id(vsTabId_T)为空，不能编辑相关视图！(In {0})", clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                JumpOtherPages("EditTabAndObjectFields");
            }
            else if (lbEditView.Text.IndexOf("编辑相关表") >= 0)
            {
                if (string.IsNullOrEmpty(vsTabId_T))
                {
                    string strMsg = string.Format("相关视图表Id(vsTabId_T)为空，不能编辑相关视图！(In {0})", clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                JumpOtherPages("EditTabAndObjectFields");
            }
            else if (lbEditView.Text.IndexOf("导入相关视图") >= 0)
            {
                string strvTabName = "v" + vsTabName;
                string strSqlDsTypeId = "02";
                try
                {
                 string strTabId_View = clsPrjTabBLEx.ImportTableViewFromSQLByTabName(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strvTabName, strSqlDsTypeId, clsCommonSession.UserId);

                    string strCondition = string.Format("PrjId='{0}' And {2} in (Select {3} from PrjTab where TabName = '{1}')",
                        clsPubVar.CurrSelPrjId, strvTabName,
                        conSqlView.RelaTabId, conPrjTab.TabId);
                    if (clsSqlViewBL.IsExistRecord(strCondition) == false)
                    {

                        clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, strvTabName, clsCommonSession.UserId);
                        string strSqlViewId = "";
                        try
                        {
                            strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabId(strTabId_View);
                            if (string.IsNullOrEmpty(strSqlViewId) == true)
                            {
                                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId_View, clsPubVar.CurrSelPrjId);
                                clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName, clsCommonSession.UserId);
                                strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabId(strTabId_View);
                            }
                        }
                        catch (Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId_View, clsPubVar.CurrSelPrjId);
                            clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName, clsCommonSession.UserId);
                            strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, strTabId_View);
                        }
                        //导入视图文本从SqlServer
                        clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);
                        clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);

                    }

                    lblMsgList.Text = "导入相关视图成功！";
                    string strTabId4ReleView = "";//表相关视图的TabId
                    strTabId4ReleView = clsPrjTabBLEx.GetRelaViewTabIdByTabName(clsPubVar.CurrSelPrjId, vsTabName);

                    if (string.IsNullOrEmpty(strTabId4ReleView) == false)
                    {
                        hidTabId4ReleView.Value = strTabId4ReleView;
                        vsTabId_T = strTabId4ReleView;
                        lbEditView.Text = string.Format("编辑相关视图(v{0})", vsTabName);
                        lbEditView.Visible = true;
                    }

                    clsCommonJsFunc.Alert(this, lblMsgList.Text);

                }
                catch (Exception objException)
                {
                    lblMsgList.Text = objException.Message;

                    clsCommonJsFunc.Alert(this, lblMsgList.Text);
                }

            }
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
                    string strCondition = string.Format("{0}='{1}'", conPrjTabFld.TabId, vsTabId);
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
                wucvPrjTabFld4Gv1.vsSqlDsTypeId = value;
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

        protected void lbEditInterface_Click(object sender, EventArgs e)
        {
            if (lbEditInterface.Text.IndexOf("编辑界面") >= 0)
            {
                string strViewId = hidViewId.Value;
                if (strViewId == null || strViewId.Trim().Length == 0)
                {
                    lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                    return;
                }
                lblMsgList.Text = "";
                //clsCommonSession.ViewId = strViewId;
                //clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                string strNextPage = string.Format(@"..\View\wfmViewInfo_U.aspx?ViewId={0}&ParentPage={1}",
                    strViewId, Page.Request.Url.AbsolutePath);
                if (string.IsNullOrEmpty(strViewId) == false)
                {
                    Response.Redirect(strNextPage);
                }
                else
                {
                    lblMsgList.Text = "没有相关的界面，请检查！";
                    clsCommonJsFunc.Alert(this, lblMsgList.Text);
                }
            }
            else if (lbEditInterface.Text.IndexOf("新建界面") >= 0)
            {
                if (string.IsNullOrEmpty(vsTabId) == false)
                {
                    string strTabId = "";
                    if (vsSqlDsTypeId == "02")
                    {
                        strTabId = clsPrjTabBLEx.GetRelaTabIdByViewTabId(vsTabId);
                        if (string.IsNullOrEmpty(strTabId) == true)
                        {
                            strTabId = vsTabId;
                        }
                    }
                    else
                    {
                        strTabId = vsTabId;
                    }
                    Response.Redirect(@"..\View\wfmViewInfo_QUDI.Aspx?Operator=AddRec&TabId=" + strTabId);
                }
                else
                {
                    lblMsgList.Text = "没有相关的表，请检查！";
                    clsCommonJsFunc.Alert(this, lblMsgList.Text);
                }
            }
        }

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

        protected void btnSumbitReplace_Click(object sender, EventArgs e)
        {
            string strSourceFieldStr = txtSourceField.Text;
            string strTargetFieldStr = txtTargetField.Text;
            try
            {
                clsPrjTabFldBLEx.ReplaceStringInField(clsPubVar.CurrSelPrjId, vsTabId, strSourceFieldStr, strTargetFieldStr, clsCommonSession.UserId);

                BindGv_vPrjTabFld();


                clsCommonJsFunc.Alert(this, "替换字段名内字符串成功！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this.Page, objException.Message);
            }
        }

    
        protected void btnSetFldOrderNum4View_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(vsTabId) == true)
            {
                lblMsgList.Text = "表Id为空，请与管理员联系！";
                return;
            }
            lblMsgList.Text = "";
            try
            {

                clsPrjTabBLEx.SetFldOrderNum4ViewByRelaTabId(vsTabId);

                clsCommonJsFunc.Alert(this, "为视图设置字段序号成功！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;

                clsCommonJsFunc.Alert(this, ErrMessage);
            }
            BindGv_vPrjTabFld();
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

        //private void Hide_txtCode_Sim()
        //{
        //    txtCode_Sim.Visible = false;
           

        //}
        //private void Show_txtCode_Sim()
        //{
        //    txtCode_Sim.Visible = true;
           
        //}
       

        protected void lbMoveToFirst_Click(object sender, EventArgs e)
        {
            MoveRecTo(1);
        }

        protected void lbMoveToLast_Click(object sender, EventArgs e)
        {
            MoveRecTo(-1);
        }

        protected void lbMoveUp_Click(object sender, EventArgs e)
        {
            AdjustSequenceNumber("UP");
        }

        protected void lbMoveDown_Click(object sender, EventArgs e)
        {
            AdjustSequenceNumber("DOWN");
        }

        protected void lbReOrder_Click(object sender, EventArgs e)
        {
            clsPrjTabFldBLEx.ReOrder(vsTabId);
            BindGv_vPrjTabFld();
        }

        protected void lbSetIsSortFld_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            foreach (long lngmId in lstMId)
            {
          
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsSortFld = true;
                objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabFld.UpdUser = clsCommonSession.UserId;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);



            }
            BindGv_vPrjTabFld();
        }

        protected void lbSetIsNotSorFld_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            foreach (long lngmId in lstMId)
            { 
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.IsSortFld = false;
                objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabFld.UpdUser = clsCommonSession.UserId;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);

            }
            BindGv_vPrjTabFld();
        }

        protected void lbSetIsSynField_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (long lngmId in lstMId)
            {
    
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.FieldTypeId = enumFieldType.SynField_08;
                objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabFld.UpdUser = clsCommonSession.UserId;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);



            }
            BindGv_vPrjTabFld();
        }

        protected void lbSetIsNotSynField_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvPrjTabFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            
            foreach (long lngmId in lstMId)
            {
            
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.FieldTypeId = enumFieldType.NormalField_01;
                objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabFld.UpdUser = clsCommonSession.UserId;
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);



            }
            BindGv_vPrjTabFld();
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
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (strPageName)
            {
                case "CheckConsistency":
                    string strTabId = vsTabId;
                    if (strTabId == null || strTabId.Trim().Length == 0)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";

                    clsPubFun4Web.CheckConsistency(this, strTabId, strCurrPageName);
                    break;
                case "EditTabAndObjectFields":
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    if (string.IsNullOrEmpty(vsTabId_T) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, vsTabId_T, strCurrPageName);
                    }
                    else
                    {
                        lblMsgList.Text = "没有相关的代码表(视图、外键表)，请检查！";
                        clsCommonJsFunc.Alert(this, lblMsgList.Text);
                    }

                    break;
                case "FieldTab_U":
                
                                        //1、获取当前所选中的字段ID。
                    long lngmId = wucvPrjTabFld4Gv1.GetFirstCheckedKeyFromGv();
                    if (lngmId == 0) return;
                    string strFldId = clsPrjTabFldBL.GetObjBymId(lngmId).FldId;

                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToFieldTab_U(this, vsTabId, strFldId, strCurrPageName);
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

        public string seTabId
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

        protected void lbInsNewRec2_ClickBak20170707(object sender, EventArgs e)
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
            string strFldId = "";
            string strCondition = "";
            lblMsg4AddRecord.Text = "";
            clsFieldTabEN objFieldTabEN;
            if (string.IsNullOrEmpty(FldName) == true)
            {
                strMsg = "请输入字段名!";
                clsCommonJsFunc.Alert(this, strMsg);
                txtFldName.Focus();
                return;
            }
            List<clsFieldTabEN> arrFieldTabObjLst = null;
            if (string.IsNullOrEmpty(DataTypeId) == true)
            {
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' ",
                           clsPubVar.CurrSelPrjId, FldName);
                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 1)
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
                else if (arrFieldTabObjLst.Count > 1)
                {
                    strMsg = "请选择字段类型!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    ddlFldType.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == true)
            {
                //检查是否存在相同字段名
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                              clsPubVar.CurrSelPrjId, FldName, DataTypeId);

                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count > 0)    //判断是否有相同的关键字
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == false)
            {

                clsPrjTabEN objPrjTabEN = new clsPrjTabEN(vsTabId);
                clsPrjTabBL.GetPrjTab(ref objPrjTabEN);

                strMsg = string.Format("在当前工程的《字段表》中已存在相同的字段名称:[{1}]，已经添加到当前表：{0}的字段中!",
                    objPrjTabEN.TabName,
                    FldName);
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                //strFldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, FldName, DataTypeId);
                //                clsPrjTabFldBLEx.CreateFldObjRelation(vsObjId, strFldId);
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(objPrjTabEN.TabId, strFldId, clsCommonSession.UserId);

                BindGv_vPrjTabFld();

                return;
            }
            try
            {
                strFldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                objFieldTabEN = new clsFieldTabEN(strFldId);	//初始化新对象
                //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                if (clsFieldTabBL.IsExist(objFieldTabEN.FldId)) //判断是否有相同的关键字
                {
                    strMsg = "关键字字段已有相同的值";
                    lblMsg4AddRecord.Text = strMsg;
                    //                clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                //4、把值从界面层传到逻辑层或数据实体层
                //PutDataToFieldTabClass2(objFieldTabEN);		//把界面的值传到
                //5、检查传进去的对象属性是否合法

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
                    lblMsg4AddRecord.Text = "添加记录不成功!";
                }
                else
                {
                    lblMsg4AddRecord.Text = "添加记录成功!";
                    //clsPrjTabFldBLEx.CreateFldObjRelation(vsObjId, strFldId);
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(vsTabId,
                        strFldId, clsCommonSession.UserId);
                    //                    clsPrjTabBLEx.SetKeyFld4PrjTabByTabId(vsTabId, clsCommonSession.UserId);
                }
                //7、把新添的记录内容显示在DATAGRID中

                BindGv_vPrjTabFld();
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }

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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnAdd_Click(object sender, System.EventArgs e)
        {
            //lblMsg.Text = "";

            DispFieldTab();
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
                    BindGv_vPrjTabFld();
                }
            }
        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            //string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            //if (string.IsNullOrEmpty(strFuncId4GC) == true)
            //{
            //    GeneCode4Level();
            //}
            //else
            //{
            //    GeneCode4Func();
            //}
            //throw new NotImplementedException();
        }
        protected void GeneCode4Func()
        {
            string strFeatureId = wucTreeView1.NodeData.FeatureId;
            string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strViewId = wucTreeView1.NodeData.ViewId;
            string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strExamDate = wucTreeView1.NodeData.ExamDate;
            string strCmPrjId = "";
            //Hide_txtCode_Sim();//显示简化实体层代码文本框
            //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangType.ProgLangTypeName);

            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";
                //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);
                txtFileName4GC.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                vsCurrTabIndex = 6;
            }
            catch (Exception objException)
            {
                //ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
            //    DispGenCodeRegion();


        }

        protected void GeneCode4Level()
        {
            string strFeatureId = wucTreeView1.NodeData.FeatureId;
            string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strViewId = wucTreeView1.NodeData.ViewId;
            string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strExamDate = wucTreeView1.NodeData.ExamDate;
            string strCmPrjId = clsCommonSession.CmPrjId;
            if (string.IsNullOrEmpty( strCmPrjId) == true)
            {
                lblMsgList.Text = "没有选择CM工程，请选择一个有效的CM工程!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }

            //Hide_txtCode_Sim();//显示简化实体层代码文本框
            //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangType.ProgLangTypeName);
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                string strCodeText = AutoGC.GeneCode(objCodeType.CodeTypeENName, "", ltLangType, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, int.Parse(strApplicationTypeId), clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                txtFileName4GC.Text = strRe_ClsName;
                //ShowCode( strCodeText);
                vsCurrTabIndex =6;
            }
            catch (Exception objException)
            {
                //ShowCode(objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
            //  DispGenCodeRegion();


        }

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

        private void BindTv_ApplicationType_CodeType_Function4GeneCode()
        {
            if (string.IsNullOrEmpty(clsCommonSession.CmPrjId) || clsCommonSession.CmPrjId == "0")
            {
                lblMsgList.Text = "请选择一个CM工程!";
                
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            string strTabId = vsTabId;
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, clsPubVar.CurrSelPrjId);

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_ClassName_Function4GeneCode;
            if (objPrjTab.TabTypeId == enumTabType.PureClass_0008)
            {
                wucTreeView1.DependsOn = "PureClass";
            }
            else
            {
                wucTreeView1.DependsOn = "Table";
            }
            wucTreeView1.FunctionTemplateId = "0001";
            wucTreeView1.TabId = strTabId;
            wucTreeView1.TabMainTypeId = objPrjTab.TabMainTypeId;
            wucTreeView1.CmPrjId = clsCommonSession.CmPrjId;
            wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView1.IsUseJsEvent = true;
            wucTreeView1.BindTv();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

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

        protected void btnSetNewCaption_Click(object sender, EventArgs e)
        {
            long lngmId = wucvPrjTabFld4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            string strCaption = txtCaption_New.Text;
            if (string.IsNullOrEmpty(strCaption) == true)
            {
                lblMsgList.Text = "请输入一个新的标题!";
                txtCaption_New.Focus();
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
        
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);
            try
            {
                objFieldTabEN.SetCaption(strCaption).
                    SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(clsCommonSession.UserId)
                    .Update();
                BindGv_vPrjTabFld();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }

        protected void btnReplaceFldName_Click(object sender, EventArgs e)
        {
            long lngmId = wucvPrjTabFld4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            string strFldName = txtFldName_Replace.Text.Trim();
            if (string.IsNullOrEmpty(strFldName) == true)
            {
                lblMsgList.Text = "请输入一个新的字段名!";
           
                txtCaption_New.Focus();
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
     
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);
            if (objFieldTabEN.FldName == strFldName)
            {

                lblMsgList.Text = "请输入一个新的字段名!";
                txtCaption_New.Focus();
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;

            }
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", 
                conFieldTab.FldName, strFldName, conFieldTab.PrjId, clsPubVar.CurrSelPrjId);
            try
            {
                List<clsFieldTabEN> arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 0)
                {
                    objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(objFieldTabEN.PrjId);
                    objFieldTabEN.SetFldName(strFldName)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .AddRecordEx();

                    objPrjTabFldEN.SetFldId(objFieldTabEN.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .Update();

                }
                else if (arrFieldTabObjLst.Count == 1)
                {

                    objFieldTabEN = arrFieldTabObjLst[0];
                    objPrjTabFldEN.SetFldId(objFieldTabEN.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .Update();

                }
                else
                {
                    clsFieldTabEN objFieldTabEN_New = arrFieldTabObjLst.Find(x => x.DataTypeId == objFieldTabEN.DataTypeId);
                    if (objFieldTabEN_New == null)
                    {
                        objFieldTabEN_New = arrFieldTabObjLst[0];
                    }
                    objPrjTabFldEN.SetFldId(objFieldTabEN_New.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .Update();
                }
                BindGv_vPrjTabFld();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }


        private void SetTabIndexBak(int intTabIndex)
        {
            StringBuilder sbJs = new StringBuilder();
            sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("strTabIndexCurr='{0}';", intTabIndex);
            sbJs.Append("</script>");
            litTabIndex.Text = sbJs.ToString();

        }

        protected void btnEditTabProperty_Click(object sender, EventArgs e)
        {
            EditPrjTab(vsTabId);
            vsCurrTabIndex =0;
        }
        public int vsCurrTabIndex
        {
            get
            {
                string sCurrTabIndex;
                sCurrTabIndex = (string)ViewState["CurrTabIndex"];
                if (sCurrTabIndex == null)
                {
                    return 0;
                }
                return int.Parse(sCurrTabIndex);
            }
            set
            {
                string sCurrTabIndex = value.ToString();
                ViewState.Add("CurrTabIndex", sCurrTabIndex);
            }
        }
        public string CurrTabClass(int intTabIndex)
        {
            if (vsCurrTabIndex == intTabIndex)
            {
                return "nav-item active";
            }
            else
            {
                return "nav-item";
            }

        }

        public string CurrTabAClass(int intTabIndex)
        {
            if (vsCurrTabIndex == intTabIndex)
            {
                return "nav-link active";
            }
            else
            {
                return "nav-link";
            }
        }

        public string CurrTabContentClass(int intTabIndex)
        {
            if (vsCurrTabIndex == intTabIndex)
            {
                return "tab-pane active";
            }
            else
            {
                return "tab-pane";
            }

        }

        //public void ShowCode(string strCode)
        //{
        //    StringBuilder sbJs = new StringBuilder();
        //    //sbJs.Append("<script type=\"text/javascript\">");
        //    sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
        //    sbJs.AppendFormat("{0}", strCode);
        //    sbJs.AppendFormat("</textarea>", strCode);
        //    //sbJs.Append("</script>");
        //    litCode.Text = sbJs.ToString();
        //}

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strTabId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {           
            
            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                string strCodeText = AutoGC.GeneCode(strCodeTypeId, "", clsPubConst.DataBaseType.MsSql, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj( objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);
                
                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }


        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGv_vPrjTabFld();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvPrjTabFld4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeletePrjTabFldRecord(lngmId);
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvPrjTabFld4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            SetProperty(lngmId);

        }

        protected void wucvPrjTabFld4Gv1_GvUpdateFieldClick(object sender, clsEventArgs4Update e)
        {
            string strFldId = e.KeyId;
            BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            clsPubFun4Web.JumpToFieldTab_U(this, vsTabId, strFldId, strCurrPageName);
            //break;
            //JumpOtherPages("FieldTab_U");

        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeletePrjTabFldRecord(long lngmId)
        {
            try
            {
                clsPrjTabFldBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vPrjTabFld();
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdatePrjTabFldRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //btnOKUpd.Enabled = true;
            //btnOKUpd.Text = "确认修改";
            //btnCancelPrjTabFldEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditPrjTabFldRegion();
        }
    }
}