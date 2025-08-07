using com.taishsoft.web.treeview;
using CommFunc4WebForm;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.web.treeview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogicEx;
using com.taishsoft.common;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using AGC.PureClass;
using AGC.PureClassEx;
using Agc;
using com.taishsoft.json;
using System.Web.Services;

namespace AGC.Webform
{
    public partial class TestWucTreeView4GC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsCommonSession.UserId = "pyf";
                vsPrjId = "0116";
                clsPubVar.CurrPrjDataBaseId = "0111";//133
                clsPubVar.CurrPrjDataBaseId = "0215";//tzar.ddns.net


                //vsViewId = "01160052";//AspMvc应用,,,ac_ExamType_QUDI
                //vsViewId = "01160053";//AndroidApp,,,ac_AllDataType_QUDI
                //vsViewId = "01160054";//AndroidApp,,,ac_Users_QUDI
                //                      //vsViewId = "01160055";//AndroidApp
                //vsViewId = "01160064";//WebApp,,,wfmDepartmentInfo_QUDI
                vsViewId = "01160066";//WebApp,,,wfmXzMajor_QUDI

                ////vsViewId = "01160069";//AspMvcApp-AllDataTypeCRUD
                //vsViewId = "01160071";//AspMvc应用,,,CollegeCRUD
                //vsViewId = "01160072";//AspMvcApp-XzMajorCRUD
                //vsViewId = "01160076";//frmExamType_QU_LV--Win应用程序的样例      
                //vsViewId = "01160080";//WebApp-wfmExamType_QUDI
                //vsViewId = "01160081";//WebApp-wfmUsers_QUDI

                //vsViewId = "01160084";//AspMvc应用,,,StudentCRUD
                //vsViewId = "01160086";//AspMvcAjax应用,,,UsersCRUDAjax
                //vsViewId = "01160087";//WebApp,,,wfmCollege_QUDI
                //vsViewId = "01160088";//WebApp,,,wfmExamType_QUDI


                vsTabId = "01160001";//DepartmentInfo                
                vsTabId = "01160002";//Users  

                vsTabId = "01160003";//UserState
                vsTabId = "01160017";//UserState
                
                //vsTabId = "01160026";//XzMajor

                //vsTabId = "01160035";//vUsers 

                //vsTabId = "01160036";//Student  

                //vsTabId = "01160053";//ExamType
                //vsTabId = "01160057";//vClassRoom

                //vsTabId = "01160062";//UserIdentity
                //vsTabId = "01160063";//AllDataType



                //vsPrjId = "0005";
                //clsPubVar.CurrPrjDataBaseId = "0005";
                //vsTabId = "00050124";

                //vsViewId = "00050198";//AndroidApp,,,ac_ViewInfo_QUDI
                //vsViewId = "00050197";//AspMvc应用,,,ac_PrjTab_QUDI

                //vsViewId = "00050196";//AspMvc应用,,,ac_UserState_QUDI
                //vsViewId = "00050205";//AspMvc应用,,,ViewRegionCRUD
                //vsViewId = "00050208";//AspMvc应用,,,EditRegionFldsCRUD
                //vsViewId = "00050221";//AspMvc应用,,,FeatureAppTypeRelaCRUDAjax

                //vsPrjId = "0112";
                //clsPubVar.CurrPrjDataBaseId = "0170";
                //vsTabId = "01120056";//AllDataType
                //vsTabId = "01120035";//UserState
                //vsTabId = "00050021";//FieldTab




                clsPubVar.CurrSelPrjId = vsPrjId;
               

                vsTypeParas = "";
                vsDataBaseType = clsPubConst.DataBaseType.MsSql;
                bool bolIsGeneTable = true;//是否生成表
                //bool bolIsGeneTable = false;//是否生成表
                vsIsGeneTable = bolIsGeneTable;

                if (bolIsGeneTable)
                {
                    //生成以表为主的代码
                    if (clsPrjTabBL.IsExist(vsTabId) == false)
                    {
                        clsCommonJsFunc.Alert(this, string.Format("TabId='{0}'不存在！", vsTabId));
                        return;
                    }
                    BindTv_FuncModule_Agc_PrjTab();
                    BindTv_ApplicationType_CodeType_Function4GeneCode(vsTabId);
                }
                else
                {
                    //生成以界面为主的代码
                    if (clsViewInfoBL.IsExist(vsViewId) == false)
                    {
                        clsCommonJsFunc.Alert(this, string.Format("ViewId='{0}'不存在！", vsViewId));
                        return;
                    }
                    BindTv_FuncModule_Agc_ViewInfo();
                    BindTv_ApplicationType_CodeType_Function4GeneCode4View(vsViewId);
                }
                // BindTv_PrjFeature();
                // BindTv_QxPrjMenuUp_Sub();
                //    BindTv_PrjFeature();
                //   BindTv_PrjFeature_Function4CodeByAppId();
                //BindTv_ViewInfo_PrjFeature_Function4Code();
                //BindTv_ProgLangType_ApplicationType_CodeType();

                //BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode();

                //Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View();
                //BindTv_FuncModule_Agc_PrjTab();
                //BindTv_FuncModule_Agc_ViewInfo();
                //BindTv_ApplicationType_CodeType_Function4GeneCode();
                //BindTv_ApplicationType_CodeType();
                //BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode4ViewInfo();
                //wucTreeView1.JsFunc_onclick = "ClearText();";
            }

        }
        private void BindTv_PrjFeature()
        {
            wucTreeView1.tmTreeModel = TreeModel.PrjFeature;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_PrjFeature_Function4Code()
        {
            wucTreeView1.tmTreeModel = TreeModel.PrjFeature_Function4Code;
            wucTreeView1.ApplicationTypeId = 2;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_PrjFeature_Function4CodeByAppId()
        {
            wucTreeView1.tmTreeModel = TreeModel.PrjFeature_Function4CodeByAppId;
            wucTreeView1.ApplicationTypeId = 2;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindTv_ApplicationType_CodeType()
        {
            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }
          


        private void BindTv_FuncModule_Agc_PrjTab()
        {

            wucTreeView4PrjTab.tmTreeModel = TreeModel.FuncModule_Agc_PrjTab;
            wucTreeView4PrjTab.DependsOn = "Table";
            wucTreeView4PrjTab.PrjId = vsPrjId;

            try
            {
                wucTreeView4PrjTab.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView4PrjTab.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView4PrjTab.CollapseAll();
            wucTreeView4PrjTab.ExpandLevel1();
            wucTreeView4PrjTab.Nodes[1].Expand();
            wucTreeView4PrjTab.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindTv_FuncModule_Agc_ViewInfo()
        {

            wucTreeView4ViewInfo.tmTreeModel = TreeModel.FuncModule_Agc_ViewInfo;
            wucTreeView4ViewInfo.DependsOn = "Table";
            wucTreeView4ViewInfo.PrjId = vsPrjId;

            try
            {
                wucTreeView4ViewInfo.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView4ViewInfo.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView4ViewInfo.CollapseAll();
            wucTreeView4ViewInfo.ExpandLevel1();
            wucTreeView4ViewInfo.Nodes[1].Expand();
            wucTreeView4ViewInfo.SelectNodeEx(strTypeName, strKeyId);

        }
        private void BindTv_ApplicationType_CodeType_Function4GeneCode(string strTabId)
        {
            
            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_Function4GeneCode;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.TabId = strTabId;
            wucTreeView1.PrjId = vsPrjId;
            wucTreeView1.IsUseJsEvent = true;
            wucTreeView1.FunctionTemplateId = "0001";
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.ExpandLevel1();
            wucTreeView1.Nodes[1].Expand();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
          
        }
     

        //private void BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode4ViewInfo()
        //{
        //    string strViewId = "01160008";//用户状态(UserState)

        //    wucTreeView1.tmTreeModel = TreeModel.ProgLangType_ApplicationType_CodeType_Function4GeneCode4View;
        //    wucTreeView1.DependsOn = "View";          
        //    wucTreeView1.ViewId = strViewId;
        //    wucTreeView1.PrjId = "0116";
        //    wucTreeView1.FunctionTemplateId = "0001";
        //    wucTreeView1.BindTv();
        //    wucTreeView1.Expand(1);
        //    //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
        //    string strKeyId = vsKeyId;
        //    string strTypeName = vsTreeNodeType;
        //    wucTreeView1.CollapseAll();
        //    wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        //}


        private void BindTv_ApplicationType_CodeType_Function4GeneCode4View(string strViewId)
        {
             //= vsViewId;// "01160008";//用户状态(UserState)

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_Function4GeneCode4View;
            wucTreeView1.DependsOn = "View";
            wucTreeView1.ViewId = strViewId;
            wucTreeView1.PrjId = vsPrjId;
            wucTreeView1.FunctionTemplateId = "0001";
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void Bindtv_ApplicationType_CodeType_Function4GeneCode4View1()
        {
            string strTabId = "01160003";//用户状态(UserState)

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_Function4GeneCode;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.TabId = strTabId;
            wucTreeView1.PrjId = "0116";
       //
            wucTreeView1.ProgLangTypeId = enumProgLangType.JAVA_02;

            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View()
        {           
            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View;
  
            wucTreeView1.ViewId = vsViewId;
            wucTreeView1.PrjId = "0116";
            wucTreeView1.FunctionTemplateId = "0001";
            wucTreeView1.ProgLangTypeId = enumProgLangType.JAVA_02;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindTv_ProgLangType_CodeType()
        {
            wucTreeView1.tmTreeModel = TreeModel.ProgLangType_CodeType;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindTv_ViewInfo_PrjFeature_Function4Code()
        {
            wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucTreeView1.ViewId = "01160060";
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
      
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
   
            btnGetCurrNodeRelaValue_Click(null, null);
         
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            if (string.IsNullOrEmpty(strFuncId4GC) == true)
            {
                GeneCode4Level();
            }
            else
            {
                GeneCode4Func();
            }
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
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
                               //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = vsTabId;
            string strViewId = "";
            strViewId = vsViewId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            if (string.IsNullOrEmpty(strProgLangTypeId) == true)
            {
                clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(int.Parse(strApplicationTypeId));
                if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId;
                }
                else if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId2) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId2;
                }
                else if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId3) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId3;
                }
            }
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangType.ProgLangTypeName);

            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

             
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";
                //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);
                txtFileName4GenCode.Text = strRe_ClsName;
                ShowCode( strCodeText);

            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
            //    DispGenCodeRegion();


        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
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

                               //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = vsTabId;
            string strViewId = "";
            string strCmPrjId = "";
            strViewId = vsViewId;

            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            if (string.IsNullOrEmpty( strProgLangTypeId) == true)
            {
                clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(int.Parse(strApplicationTypeId));
                if (string.IsNullOrEmpty( objApplicationTypeEN.ProgLangTypeId ) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId;
                }
                else if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId2) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId2;
                }
                else if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId3) == false)
                {
                    strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId3;
                }
            }
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            string strCondition = string.Format("{0}='{1}'", conAppCodeTypeRela.CodeTypeId, objCodeType.CodeTypeId);
            clsAppCodeTypeRelaEN objAppCodeTypeRelaEN  = clsAppCodeTypeRelaBL.GetFirstObj_S(strCondition);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            //clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangType.ProgLangTypeName);
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

        
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                string strCodeText = AutoGC.GeneCode(strCodeTypeId, vsTypeParas, vsDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, objAppCodeTypeRelaEN.ApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                txtFileName4GenCode.Text = strRe_ClsName;
             ShowCode( strCodeText);

            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //显示生成代码区域
            //  DispGenCodeRegion();


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

        protected string vsTabId
        {
            get
            {
                string sTabId;
                sTabId = (string)ViewState["TabId"];
                if (sTabId == null)
                {
                    sTabId = "";
                }
                return sTabId;
            }
            set
            {
                string sTabId = value;
                ViewState.Add("TabId", sTabId);
            }
        }

        protected bool vsIsGeneTable
        {
            get
            {
                string sIsGeneTable;
                sIsGeneTable = (string)ViewState["IsGeneTable"];
                if (sIsGeneTable == null)
                {
                    return false;
                }
                return bool.Parse( sIsGeneTable);
            }
            set
            {
                string sIsGeneTable = value.ToString();
                ViewState.Add("IsGeneTable", sIsGeneTable);
            }
        }
        protected string vsViewId
        {
            get
            {
                string sViewId;
                sViewId = (string)ViewState["ViewId"];
                if (sViewId == null)
                {
                    sViewId = "";
                }
                return sViewId;
            }
            set
            {
                string sViewId = value;
                ViewState.Add("ViewId", sViewId);
            }
        }
        protected string vsPrjId
        {
            get
            {
                string sPrjId;
                sPrjId = (string)ViewState["PrjId"];
                if (sPrjId == null)
                {
                    sPrjId = "";
                }
                return sPrjId;
            }
            set
            {
                string sPrjId = value;
                ViewState.Add("PrjId", sPrjId);
            }
        }
        
        protected void btnSelectNode_Click(object sender, EventArgs e)
        {
            string strKeyId = txtKeyId2.Text;
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strKeyId);
        }

        protected void btnExpandNode_Click(object sender, EventArgs e)
        {
            string strKeyId = txtKeyId_Sel.Text;
            wucTreeView1.Expand(strKeyId);
        }

        protected void btnTestStruct_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            Object strTT = wucTreeView1.GetPropertyValue(objNodeData, "TT");

            wucTreeView1.InitPropertyValue4Obj(objNodeData);
            lblMsg.Text = string.Format("SS:{0}, TT:{1}", objNodeData.SS, strTT);
        }
        //public string GetVal(object obj, string name)
        //{
        //    Type type = obj.GetType();
        //    PropertyInfo[] pros = type.GetProperties();
        //    foreach (PropertyInfo p in pros)
        //    {
        //        Console.WriteLine(p.GetValue(obj, null));
        //    }
        //    PropertyInfo objP = type.GetProperty(name);
        //    return objP.GetValue(obj, null).ToString();
        //}

        protected void btnGetPropNameLst_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            List<string> arrPropName = wucTreeView1.GetPropertyNameLst4Obj(objNodeData);
            ListBox1.Items.Clear();
            foreach (string strPropName in arrPropName)
            {
                ListBox1.Items.Add(strPropName);
            }

        }

        protected void btnGetAllPropNameValue_Click(object sender, EventArgs e)
        {
            TreeNodeData objNodeData = new TreeNodeData();
            objNodeData.SS = "111";
            objNodeData.TT = 222;
            //objNodeData = new NodeData();
            StringBuilder sbMsg = new StringBuilder();
            Type type = typeof(TreeNodeData);
            FieldInfo[] fileds = type.GetFields();
            foreach (FieldInfo f in fileds)
            {
                sbMsg.AppendFormat("{0}:{1}", f.Name, f.Name);
                Console.WriteLine(f.Name);//id name
            }
            List<string> arrPropName = wucTreeView1.GetPropertyNameLst4Obj(objNodeData);
            ListBox1.Items.Clear();
            foreach (string strPropName in arrPropName)
            {
                Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strMsg);
            }

        }

        protected void btnGetAllCheckedNodeValueLst_Click(object sender, EventArgs e)
        {
            List<string> arrCheckedValue = wucTreeView1.GetCheckedNodeKeyIdLst();
            ListBox1.Items.Clear();
            foreach (string strValue in arrCheckedValue)
            {
                //Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                //string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strValue);
            }
        }

        protected void btnBindTv_Click(object sender, EventArgs e)
        {
            BindTv_ApplicationType_CodeType();
        }

        protected void btnGetCurrNodeValuePath_Click(object sender, EventArgs e)
        {
            string strValuePath = wucTreeView1.GetCurrPathNodeKeyId();
            List<string> arrValuePath = wucTreeView1.GetCurrPathNodeKeyIdLst();
            List<string> arrNodeTypePath = wucTreeView1.GetCurrPathNodeTypeLst();
            ListBox1.Items.Clear();
            ListBox1.Items.Add(strValuePath);
            int intLen = arrValuePath.Count;
            for (int i = 0; i < intLen; i++)
            {
                string strValue = arrValuePath[i];

                string strNodeType = arrNodeTypePath[i];
                string strMsg = string.Format("NodeType:{0}, Value:{1}", strNodeType, strValue);
                ListBox1.Items.Add(strMsg);
            }
        }

        protected void btnGetAllCheckedPathNodeValueLst_Click(object sender, EventArgs e)
        {
            List<string> arrCheckedValue = wucTreeView1.GetCheckedPathNodeKeyIdLst();
            ListBox1.Items.Clear();
            foreach (string strValue in arrCheckedValue)
            {
                //Object objValue = wucTreeView1.GetPropertyValue(objNodeData, strPropName);
                //string strMsg = string.Format("Key:{0}, Value:{1}", strPropName, objValue);
                ListBox1.Items.Add(strValue);
            }
        }

        protected void btnGetCurrNodeRelaValue_Click(object sender, EventArgs e)
        {
            string strFeatureId = wucTreeView1.NodeData.FeatureId;
            string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;
            string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strViewId = wucTreeView1.NodeData.ViewId;
            string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            string strFuncModuleAgcId = wucTreeView1.NodeData.FuncModuleAgcId;
            string strTabId = wucTreeView1.NodeData.TabId;

            //string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            string strExamDate = wucTreeView1.NodeData.ExamDate;
            //conApplicationType.ApplicationTypeId;
            switch (wucTreeView1.tmTreeModel)
            {
                case TreeModel.PrjFeature:
                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 功能:{1}",
                            wucTreeView1.CurrNodeType,
                           clsPrjFeatureBL.GetFeatureNameByFeatureIdCache(strFeatureId));
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.PrjFeature_Function4Code:
                    //conFunction4Code.FuncId4Code;

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 功能:{1}， 函数:{2}",
                            wucTreeView1.CurrNodeType,
                           clsPrjFeatureBL.GetFeatureNameByFeatureIdCache(strFeatureId),
                           clsFunction4CodeBL.GetFuncName4CodeByFuncId4CodeCache(strFuncId4Code)                            );
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.FuncModule_Agc_PrjTab:
                    //conFunction4Code.FuncId4Code;

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 模块:{1}，工程表:{2}",
                            wucTreeView1.CurrNodeType,
                           clsFuncModule_AgcBL.GetFuncModuleNameByFuncModuleAgcIdCache(strFuncModuleAgcId, clsPubVar.CurrSelPrjId),
                           clsPrjTabBL.GetObjByTabIdCache(strTabId, vsPrjId).TabName);
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.FuncModule_Agc_ViewInfo:
                    //conFunction4Code.FuncId4Code;

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 模块:{1}，界面:{2}",
                            wucTreeView1.CurrNodeType,
                           clsFuncModule_AgcBL.GetFuncModuleNameByFuncModuleAgcIdCache(strFuncModuleAgcId, clsPubVar.CurrSelPrjId),
                           clsViewInfoBLEx.GetObjByViewIdCache(strViewId, vsPrjId).ViewName);
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.ApplicationType_CodeType:                   

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 应用:{1}， 代码类型:{2}",
                            wucTreeView1.CurrNodeType,                         
                            clsApplicationTypeBL.GetApplicationTypeNameByApplicationTypeIdCache(int.Parse( strApplicationTypeId)),
                            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId)                            );                      
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                //case TreeModel.ProgLangType_ApplicationType_CodeType:

                //    try
                //    {
                //        string strMsg = string.Format("结点类型:{0}, 语言:{1}, 应用:{2}， 代码类型:{3}",
                //            wucTreeView1.CurrNodeType,
                //            clsProgLangTypeBL.GetNameByProgLangTypeIdCache(strProgLangTypeId),
                //            clsApplicationTypeBL.GetApplicationTypeNameByApplicationTypeIdCache(int.Parse(strApplicationTypeId)),
                //            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId));
                //        lblMsg2.Text = strMsg;
                //    }
                //    catch (Exception objException)
                //    {
                //        lblMsg2.Text = objException.Message;
                //    }
                //    break;
                case TreeModel.ApplicationType_CodeType_Function4GeneCode:

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 语言:{1}, 应用:{2}， 代码类型:{3}, 函数:{4}-{5}",
                            wucTreeView1.CurrNodeType,
                            clsProgLangTypeBL.GetNameByProgLangTypeIdCache(strProgLangTypeId),
                            clsApplicationTypeBL.GetApplicationTypeNameByApplicationTypeIdCache(int.Parse(strApplicationTypeId)),
                            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId),
                            strFuncId4GC,
                            clsFunction4GeneCodeBL.GetNameByFuncId4GCCache(strFuncId4GC));
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                //case TreeModel.ProgLangType_ApplicationType_CodeType_Function4GeneCode:

                //    try
                //    {
                //        string strMsg = string.Format("结点类型:{0}, 语言:{1}, 应用:{2}， 代码类型:{3}, 函数:{4}-{5}",
                //            wucTreeView1.CurrNodeType,
                //            clsProgLangTypeBL.GetNameByProgLangTypeIdCache(strProgLangTypeId),
                //            clsApplicationTypeBL.GetApplicationTypeNameByApplicationTypeIdCache(int.Parse(strApplicationTypeId)),
                //            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId),
                //            strFuncId4GC,
                //            clsFunction4GeneCodeBL.GetNameByFuncId4GCCache(strFuncId4GC));
                //        lblMsg2.Text = strMsg;
                //    }
                //    catch (Exception objException)
                //    {
                //        lblMsg2.Text = objException.Message;
                //    }
                //    break;
                  
                case TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View:

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 应用:{1}， 代码类型:{2}, 功能:{3} 函数:{4}-{5}",
                            wucTreeView1.CurrNodeType,
                            clsApplicationTypeBL.GetApplicationTypeNameByApplicationTypeIdCache(int.Parse(strApplicationTypeId)),

                            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId),
                            strFeatureId,
                            strFuncId4GC,
                            clsFunction4GeneCodeBL.GetNameByFuncId4GCCache(strFuncId4GC));
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.ViewInfo_PrjFeature_Function4Code:
                    //conFunction4Code.FuncId4Code;
                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 界面Id:{1}，功能Id:{2}, 函数Id:{3}",
                            wucTreeView1.CurrNodeType,
                            clsViewInfoBL.GetViewNameByViewIdCache(strViewId, clsPubVar.CurrSelPrjId),
                            clsPrjFeatureBL.GetFeatureNameByFeatureIdCache(strFeatureId),
                        clsFunction4CodeBL.GetFuncName4CodeByFuncId4CodeCache(strFuncId4Code));
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                case TreeModel.ApplicationType_CodeType_Function4GeneCode4View:
                    //conFunction4Code.FuncId4Code;
                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 应用:{1}, 代码类型:{2}, 函数:{3}",
                            wucTreeView1.CurrNodeType,
                            //clsProgLangTypeBL.GetNameByProgLangTypeIdCache(strProgLangTypeId),
                            clsApplicationTypeBL.GetNameByApplicationTypeIdCache(int.Parse(strApplicationTypeId)),
                            clsCodeTypeBL.GetCodeTypeNameByCodeTypeIdCache(strCodeTypeId),
                            clsFunction4CodeBL.GetFuncName4CodeByFuncId4CodeCache(strFuncId4Code));
                        lblMsg2.Text = strMsg;
                    }
                    catch (Exception objException)
                    {
                        lblMsg2.Text = objException.Message;
                    }
                    break;
                default:
                    string strMsg1 = string.Format("树类型：{0}在函数中没有处理！({1})", wucTreeView1.tmTreeModel, 
                        clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg1);
                    break;
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
        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string vsTypeParas
        {
            get
            {
                string strTypeParas = "";
                if (ViewState["TypeParas"] == null)
                {
                    //if (ddlAppPageTypeId.SelectedIndex > 0)
                    //{
                    //    string strAppPageTypeId = ddlAppPageTypeId.SelectedValue;
                    //    clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeBL.GetObjByAppPageTypeId(strAppPageTypeId);
                    //    strTypeParas = strTypeParas + string.Format("{0}|",
                    //        objAppPageTypeEN.AppPageTypeENName);
                    //    return strTypeParas;
                    //}
                }
                strTypeParas = (string)ViewState["TypeParas"];

                return strTypeParas;
            }
            set
            {
                string strTypeParas = value;
                ViewState.Add("TypeParas", strTypeParas);
            }
        }
        public static string TestF1()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = clsASPHtmlTableBLEx.GetEmptyTable();
            ASPRowEx objASPRowENEx = clsASPRowBLEx.GetEmptyTr();
            ASPColEx objASPColENEx = clsASPColBLEx.GetEmptyTd();
            ASPLabelEx objASPLabelENEx = clsASPLabelBLEx.GetEmptyLabel();
            objASPLabelENEx.Text = "AAA";
            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);
            objASPHtmlTableENEx.arrSubAspControlLst2.Add(objASPRowENEx);

            StringBuilder sbCode = new StringBuilder();
            objASPHtmlTableENEx.GeneCode(enumApplicationType.WebApp_2, sbCode);
            return sbCode.ToString();
        }
        protected void btnModalDialogTest_Click(object sender, EventArgs e)
        {
            StringBuilder sbCode = new StringBuilder();
            ASPModalDialogEx obj = new ASPModalDialogEx();
            obj.CtrlId = "MyTestDialog";
            obj.modal_title = "测试对话框";
            obj.ContentFunc = TestF1;
            obj.GeneCode(enumApplicationType.WebApp_2, sbCode);
            ShowCode(  sbCode.ToString());
        }

        private void BindTv_FuncModule_Agc_PrjTabBak()
        {
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            //if (string.IsNullOrEmpty(strTabId) == true) return;
            wucTreeView4PrjTab.tmTreeModel = TreeModel.FuncModule_Agc_PrjTab;
            wucTreeView4PrjTab.DependsOn = "Table";
            wucTreeView4PrjTab.FunctionTemplateId = "0001";
            //wucTreeView4PrjTab.IsUseJsEvent = true;
            wucTreeView4PrjTab.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView4PrjTab.BindTv();
            wucTreeView4PrjTab.Expand(1);
            //wucTreeView4PrjTab.afterSelect_Tz += wucTreeView4PrjTab_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView4PrjTab.CollapseAll();
            //            wucTreeView4PrjTab.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4PrjTab.ExpandLevel1();
            wucTreeView4PrjTab.Nodes[1].Expand();
        }

        protected void wucTreeView4PrjTab_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView4PrjTab.CollapseAll();
      
            string strTabId = strKeyId;
            //string strFuncModuleAgcId = wucTreeView1.NodeData.FuncModuleAgcId;
            //            if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return;
            if (strTypeName != "PrjTab")
            {
                return;
            }
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();

            BindTv_ApplicationType_CodeType_Function4GeneCode(strTabId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4PrjTab.GetCurrPathNodeKeyIdLst();
            wucTreeView4PrjTab.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            //throw new NotImplementedException();
        }

        protected void wucTreeView4ViewInfo_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView4ViewInfo.CollapseAll();

            string strViewId = strKeyId;
            //string strFuncModuleAgcId = wucTreeView1.NodeData.FuncModuleAgcId;
            //            if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return;
            if (strTypeName !=  clsViewInfoEN._CurrTabName)
            {
                return;
            }
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();

            BindTv_ApplicationType_CodeType_Function4GeneCode4View(strViewId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4ViewInfo.GetCurrPathNodeKeyIdLst();
            wucTreeView4ViewInfo.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            //throw new NotImplementedException();
        }

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strTabId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {
            //string strFeatureId = wucTreeView1.NodeData.FeatureId;
            //string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            //string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            //string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            //string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;

            ////string strViewId = wucTreeView1.NodeData.ViewId;
            ////string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            ////string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strExamDate = wucTreeView1.NodeData.ExamDate;


            //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
      

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
                return strCodeText;
            }
            catch (Exception objException)
            {
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

    }
}