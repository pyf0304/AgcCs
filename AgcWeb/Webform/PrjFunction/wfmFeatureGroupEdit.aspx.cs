

using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Services;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.web.treeview;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using com.taishsoft.json;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;

namespace AGC.Webform
{

    public partial class wfmFeatureGroupEdit : CommWebPageBase
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

                    //初始化父页面传递过来的信息
                    InitParentPageInfo();
                    SetDdl_ApplicationTypeId();
                    int intAppliTypeId = clsApplicationTypeBLEx.GetAppTypeIdByMaxVisitedNum();
                    ddlApplicationTypeId.SelectedValue = intAppliTypeId.ToString();
                    vsApplicationTypeId = intAppliTypeId;
                    BindTv_PrjFeatureType_PrjFeature();

                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    return;
                }



            }


        }
        private void setIFrameByFeatureId(string strFeatureId)
        {
            if (string.IsNullOrEmpty(strFeatureId) == false)
            {
                myIframe1.Src = string.Format("wfmFeatureFieldTypeRelaB_QUDI.aspx?FeatureId={0}", strFeatureId);
                myIframe2.Src = string.Format("wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}", strFeatureId);
                myIframe3.Src = string.Format("wfmFeatureButtonRelaB_QUDI.aspx?FeatureId={0}", strFeatureId);
                myIframe4.Src = string.Format("wfmFeatureAppTypeRela_QUDI.aspx?FeatureId={0}", strFeatureId);

            }
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
        public string vsFeatureId
        {
            get
            {
                string strFeatureId;
                strFeatureId = (string)ViewState["FeatureId"];
                if (strFeatureId == null)
                {
                    strFeatureId = "";
                }
                return strFeatureId;
            }
            set
            {
                string strFeatureId = value;
                ViewState.Add("FeatureId", strFeatureId);
            }
        }



        /// <summary>
        /// 视图表Id的相关表Id
        /// </summary>
        public string vsRelaFeatureId4View
        {
            get
            {
                string strRelaFeatureId4View;
                strRelaFeatureId4View = (string)ViewState["RelaFeatureId4View"];
                if (strRelaFeatureId4View == null)
                {
                    strRelaFeatureId4View = "";
                }
                return strRelaFeatureId4View;
            }
            set
            {
                string strRelaFeatureId4View = value;
                ViewState.Add("RelaFeatureId4View", strRelaFeatureId4View);
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

                //if (string.IsNullOrEmpty(qsObjId) == false)
                //{
                //    vsObjId = qsObjId.ToString();
                //}
                //else if (string.IsNullOrEmpty(seObjId) == false)
                //{
                //    vsObjId = seObjId;
                //}



            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }

        public string seFeatureId
        {
            get
            {
                string strFeatureId;
                strFeatureId = (string)Session["FeatureId"];
                if (strFeatureId == null)
                {
                    strFeatureId = "";
                }
                return strFeatureId;
            }
            set
            {
                string strFeatureId = value;
                Session.Add("FeatureId", strFeatureId);
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
            string strPrjFeatureTypeId = wucTreeView1.NodeData.PrjFeatureTypeId;
            string strFeatureId = wucTreeView1.NodeData.FeatureId;

            if (string.IsNullOrEmpty(strFeatureId) == true) return;
            vsFeatureId = strFeatureId;
            setIFrameByFeatureId(strFeatureId);
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

        private void BindTv_PrjFeatureType_PrjFeature()
        {
            string strFeatureId = vsFeatureId;
            wucTreeView1.tmTreeModel = TreeModel.PrjFeatureType_PrjFeature;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.FunctionTemplateId = "0001";
            wucTreeView1.ApplicationTypeId = vsApplicationTypeId;
            wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView1.IsUseJsEvent = true;
            wucTreeView1.BindTv();
            //wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.ExpandAll();
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



        private void SetTabIndexBak(int intTabIndex)
        {
            StringBuilder sbJs = new StringBuilder();
            sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("strTabIndexCurr='{0}';", intTabIndex);
            sbJs.Append("</script>");
            litTabIndex.Text = sbJs.ToString();

        }


        public int vsApplicationTypeId
        {
            get
            {
                string sApplicationTypeId;
                sApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (sApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(sApplicationTypeId);
            }
            set
            {
                string sApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
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


        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strFeatureId, string strViewId, int intApplicationTypeId)
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
                string strCmPrjId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                string strCodeText = AutoGC.GeneCode(strCodeTypeId, "", clsPubConst.DataBaseType.MsSql, strFeatureId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

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
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
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
                    string strFeatureId = vsFeatureId;
                    if (strFeatureId == null || strFeatureId.Trim().Length == 0)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                        return;
                    }
                    lblMsgList.Text = "";

                    clsPubFun4Web.CheckConsistency(this, strFeatureId, strCurrPageName);
                    break;



                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }

        public void SetDdl_ApplicationTypeId()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
        }

        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex <= 0)
            {
                return;
            }
            string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;
            vsApplicationTypeId = int.Parse(strApplicationTypeId);
            clsApplicationTypeBLEx.IncreaseVisitedNum(vsApplicationTypeId);
            BindTv_PrjFeatureType_PrjFeature();
        }
    }
}