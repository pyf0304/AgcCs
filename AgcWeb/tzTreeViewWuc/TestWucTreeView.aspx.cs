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

namespace AGC.Webform
{
    public partial class TestWucTreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vsPrjId = "0116";
                //BindTv_PrjFeature();
                // BindTv_QxPrjMenuUp_Sub();
                //    BindTv_PrjFeature();
                //BindTv_PrjFeature_Function4CodeByAppId();
                //BindTv_PrjFeature_Function4GeneCodeByAppId();
                //BindTv_ViewInfo_PrjFeature_Function4Code();
                //BindTv_ProgLangType_ApplicationType_CodeType();
                //BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode();
                //BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode4ViewInfo();
                //BindTv_ProgLangType_ApplicationType_CodeType_Function4GeneCode4View();
                //Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View();
                wucTreeView1.Jsfunc_onclick = "ClearText();";
                //BindTv_FuncModule_Agc_PrjTab();
                //BindTv_FuncModule_Agc_ViewInfo();
                //BindTv_ApplicationType_CodeType_Function4GeneCode();
                //BindTv_ApplicationType_CodeType();
                //  mnuTopMenu.Items.Add(objMI);01160060
                //TreeView1.Attributes.Add("onclick", "ClearText('txtKeyId')");
                //clsTreeViewBindDoubleTable.Bindtv_PrjFeature4Js(TreeView1);
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


        private void BindTv_PrjFeature_Function4GeneCodeByAppId()
        {
            wucTreeView1.tmTreeModel = TreeModel.PrjFeature_Function4GeneCodeByAppId;
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
            
            wucTreeView1.tmTreeModel = TreeModel.FuncModule_Agc_PrjTab;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.PrjId = vsPrjId;

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

        private void BindTv_FuncModule_Agc_ViewInfo()
        {

            wucTreeView1.tmTreeModel = TreeModel.FuncModule_Agc_ViewInfo;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.PrjId = vsPrjId;

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
        private void BindTv_ApplicationType_CodeType_Function4GeneCode()
        {
            string strTabId = "01160003";//用户状态(UserState)

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_Function4GeneCode;
            wucTreeView1.DependsOn = "Table";
            wucTreeView1.TabId = strTabId;
            wucTreeView1.PrjId = "0116";
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


        private void BindTv_ApplicationType_CodeType_Function4GeneCode4View()
        {
            string strViewId = "01160008";//用户状态(UserState)

            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CodeType_Function4GeneCode4View;
            wucTreeView1.DependsOn = "View";
            wucTreeView1.ViewId = strViewId;
            wucTreeView1.PrjId = "0116";
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
  
            wucTreeView1.ViewId = "01160060";
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
            List<string> arrCurrPathNodeKeyIdLst =  wucTreeView1.GetCurrPathNodeKeyIdLst();
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            btnGetCurrNodeRelaValue_Click(null, null);
            //throw new NotImplementedException();
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
                case TreeModel.PrjFeature_Function4GeneCodeByAppId:
                    //conFunction4Code.FuncId4Code;

                    try
                    {
                        string strMsg = string.Format("结点类型:{0}, 功能:{1}， 函数:{2}",
                            wucTreeView1.CurrNodeType,
                           clsPrjFeatureBL.GetFeatureNameByFeatureIdCache(strFeatureId),
                           clsFunction4GeneCodeBL.GetNameByFuncId4GCCache(strFuncId4GC));
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
                //case TreeModel.ApplicationType_CodeType:

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
                default:
                    string strMsg1 = string.Format("树类型：{0}在函数中没有处理！({1})", wucTreeView1.tmTreeModel, 
                        clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg1);
                    break;
            }
        }
    }
}