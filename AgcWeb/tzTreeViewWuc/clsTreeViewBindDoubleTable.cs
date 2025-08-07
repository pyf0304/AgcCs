using AGC.BusinessLogic;
using AGC.FunClass;
using AGC.BusinessLogicEx;

using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using com.taishsoft.datetime;

namespace AGC.web.treeview
{
    public partial class clsTreeViewBindDoubleTable
    {
        private TreeView mobjTv;

        private DataTable mobjLevel1Dt;

        private DataTable mobjLevel2Dt;

        private string mstrLevel1NameField = "";

        private string mstrLevel1ValueField = "";

        private string mstrLevel2NameField = "";

        private string mstrLevel2ValueField = "";

        private string mstrLevel1IDFieldInLevel2DataSource;

        private int mintExpandLevel = 1;

        private bool mbolLevel1HasCheckBox = true;

        private bool mbolLevel2HasCheckBox = true;

        private string mstrRootTitle = "以下是详细信息列表：";

        public TreeView objTreeView
        {
            get
            {
                return this.mobjTv;

            }
            set
            {
                if (value != null)
                {
                    this.mobjTv = value;
                }

            }
        }

        public int ExpandLevel
        {
            get
            {
                return this.mintExpandLevel;
            }
            set
            {
                if (value >= 0)
                {
                    this.mintExpandLevel = value;
                }
            }
        }

        public bool Level1CheckBox
        {
            get
            {
                return this.mbolLevel1HasCheckBox;
            }
            set
            {

                this.mbolLevel1HasCheckBox = value;

            }
        }

        public bool Level2CheckBox
        {
            get
            {
                return this.mbolLevel2HasCheckBox;
            }
            set
            {

                this.mbolLevel2HasCheckBox = value;

            }
        }

        public string RootTitle
        {
            get
            {
                return this.mstrRootTitle;
            }
            set
            {
                if (value != null)
                {
                    this.mstrRootTitle = value;
                }
            }
        }

        public DataTable Level1DataSource
        {
            get
            {
                return this.mobjLevel1Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel1Dt = value;
                }
            }
        }

        public DataTable Level2DataSource
        {
            get
            {
                return this.mobjLevel2Dt;
            }
            set
            {
                if (value != null)
                {
                    this.mobjLevel2Dt = value;
                }
            }
        }

        public string Level1NameField
        {
            get
            {

                return this.mstrLevel1NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1NameField = value;
                }

            }
        }

        public string Level1ValueField
        {
            get
            {

                return this.mstrLevel1ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1ValueField = value;
                }

            }
        }

        public string Level2NameField
        {
            get
            {

                return this.mstrLevel2NameField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2NameField = value;
                }

            }
        }

        public string Level2ValueField
        {
            get
            {

                return this.mstrLevel2ValueField;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel2ValueField = value;
                }

            }
        }

        public string Level1IDFieldInLevel2DataSource
        {
            get
            {

                return this.mstrLevel1IDFieldInLevel2DataSource;

            }
            set
            {

                if (value != null)
                {
                    this.mstrLevel1IDFieldInLevel2DataSource = value;
                }

            }
        }

        public List<string> CheckedLevel1NodesIDArr
        {
            get
            {

                List<string> objArr = new List<string>();

                this.GetCheckedNodeId(this.mobjTv.Nodes[0], objArr, "Level1");

                return objArr;

            }
            set
            {
                if (value != null && value.Count > 0 && this.mobjTv != null)
                {
                    foreach (string TreeNodeId in value)
                    {
                        string ss = TreeNodeId;
                        this.CheckSubNodeById(mobjTv.Nodes[0], value, "Level1");
                    }
                }

            }
        }

        public List<string> CheckedLevel2NodesIDArr
        {
            get
            {

                List<string> objArr = new List<string>();

                this.GetCheckedNodeId(this.mobjTv.Nodes[0], objArr, "Level2");

                return objArr;

            }
            set
            {
                if (value != null && value.Count > 0 && this.mobjTv != null)
                {
                    foreach (string TreeNodeId in value)
                    {
                        string ss = TreeNodeId;
                        this.CheckSubNodeById(mobjTv.Nodes[0], value, "Level2");
                    }
                }
            }
        }

        public clsTreeViewBindDoubleTable()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public clsTreeViewBindDoubleTable(TreeView objTreeView)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;

        }

        public clsTreeViewBindDoubleTable(TreeView objTreeView, DataTable Level1DataSource, DataTable Level2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;

        }


        public clsTreeViewBindDoubleTable(TreeView objTreeView,
            DataTable Level1DataSource, DataTable Level2DataSource,
            string Level1NameField, string Level1ValueField, string Level2NameField, string Level2ValueField, string Level1IDFieldInLevel2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjTv = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;
            this.mstrLevel1NameField = Level1NameField;
            this.mstrLevel1ValueField = Level1ValueField;
            this.mstrLevel2NameField = Level2NameField;
            this.mstrLevel2ValueField = Level2ValueField;
            this.mstrLevel1IDFieldInLevel2DataSource = Level1IDFieldInLevel2DataSource;
        }

        public void DataBind()
        {
            this.BindTreeView(this.mobjTv, this.mobjLevel1Dt, this.mobjLevel2Dt, this.mstrLevel1NameField, this.mstrLevel1ValueField, this.mstrLevel2NameField, this.mstrLevel2ValueField, this.mstrLevel1IDFieldInLevel2DataSource);
            this.mobjTv.Nodes[0].Expand();
        }


        private void BindTreeView(TreeView pobjTreeView,
            DataTable pLevel1DataSource, DataTable pLevel2DataSource,
            string pLevel1NameField, string pLevel1ValueField, string pLevel2NameField, string pLevel2ValueField, string pLevel1IDFieldInLevel2DataSource)
        {
            if (pobjTreeView != null
                && pLevel1DataSource != null && pLevel2DataSource != null
                && pLevel1NameField != "" && pLevel1ValueField != "" && pLevel2NameField != "" && pLevel2ValueField != "" && pLevel1IDFieldInLevel2DataSource != "")
            {



                DataTable objLevel1DataTable, objLevel2DataTable;
                TreeNode tnRoot, tnLevel1, tnLevel2;

                pobjTreeView.Nodes.Clear();

                tnRoot = new TreeNode();
                tnRoot.Value = "Root,0000";
                tnRoot.Text = this.mstrRootTitle;
                //mobjTv.CheckBoxes = false;

                pobjTreeView.Nodes.Add(tnRoot);


                objLevel1DataTable = pLevel1DataSource;
                objLevel2DataTable = pLevel2DataSource;



                foreach (DataRow Level1Dr in objLevel1DataTable.Rows)
                {
                    string strLevel1Id = Level1Dr[pLevel1ValueField].ToString();
                    string strLevel1Name = Level1Dr[pLevel1NameField].ToString();

                    tnLevel1 = new TreeNode();
                    tnLevel1.Value = "Level1," + strLevel1Id;
                    tnLevel1.Text = strLevel1Name;
                    tnLevel1.ShowCheckBox = this.mbolLevel1HasCheckBox;
                    tnRoot.ChildNodes.Add(tnLevel1);

                    DataRow[] DrRows = objLevel2DataTable.Select(string.Format(" {0} = '{1}'", pLevel1IDFieldInLevel2DataSource, strLevel1Id));

                    foreach (DataRow Level2Dr in DrRows)
                    {
                        string strLevel2Id = Level2Dr[pLevel2ValueField].ToString();
                        string strLevel2Name = Level2Dr[pLevel2NameField].ToString();

                        tnLevel2 = new TreeNode();
                        tnLevel2.Value = "Level2," + strLevel2Id;
                        tnLevel2.Text = strLevel2Name;
                        tnLevel2.ShowCheckBox = this.mbolLevel2HasCheckBox;
                        tnLevel1.ChildNodes.Add(tnLevel2);

                    }

                }

            }

        }


        private void CheckSubNode(TreeNode tnTemp, bool bolIsChecked)
        {
            //if (mobjTv.CheckBoxes == true)
            //{
            //    tnTemp._Checked = bolIsChecked;
            //}
            tnTemp.Checked = bolIsChecked;
            if (tnTemp.ChildNodes.Count > 0)
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    CheckSubNode(tn, bolIsChecked);
                }
            }
        }

        public static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.ChildNodes)
            {
                node.Checked = nodeChecked;
                if (node.ChildNodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    clsTreeViewBindDoubleTable.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        public static string GetCurrKeyTypeName(TreeView objTreeView)
        {
            string strTabName = "";
            string strTag = objTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
        }
        public static string GetCurrKeyTypeName(TreeNode objTN)
        {
            string strTabName = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            if (strArr[0] != "Root")
            {
                strTabName = strArr[0];
            }

            return strTabName;
        }
        public static string GetCurrKey(TreeView objTreeView)
        {
            string strKeyId = "";
            string strTag = objTreeView.SelectedNode.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取当前结点的关键字
        /// </summary>
        /// <param name="objTN"></param>
        /// <returns></returns>
		public static string GetCurrKey(TreeNode objTN)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }

        private void CheckSubNodeById(TreeNode tnTemp, List<string> TreeNodeIdArr, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);
            if (tnTemp.ShowCheckBox == true && strNodeType == TreeNodeType)
            {

                if (TreeNodeIdArr.Contains(strNodeKeyId))
                {
                    tnTemp.Checked = true;
                }
                else
                {
                    tnTemp.Checked = false;

                }
            }

            if (tnTemp.ChildNodes.Count > 0)
            {
                foreach (TreeNode tn in tnTemp.ChildNodes)
                {
                    CheckSubNodeById(tn, TreeNodeIdArr, TreeNodeType);
                }
            }

        }


        private void GetCheckedNodeId(TreeNode tnTemp, List<string> arrLst, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);

            if (tnTemp.Checked == true && tnTemp.Checked == true && strNodeType == TreeNodeType)
            {
                arrLst.Add(strNodeKeyId);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeId(tn, arrLst, TreeNodeType);
            }
        }

        private void GetCheckedNodeName(TreeNode tnTemp, List<string> arrLst, string TreeNodeType)
        {
            string strNodeType = GetCurrKeyTypeName(tnTemp);
            string strNodeKeyId = GetCurrKey(tnTemp);

            if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true && strNodeType == TreeNodeType)
            {
                arrLst.Add(tnTemp.Text);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedNodeName(tn, arrLst, TreeNodeType);
            }
        }

        public static void Bindtv_PrjFeature4Js(TreeView objTV)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                     conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                     conPrjFeature.OrderNum);

            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);


            TreeNode tnRoot = new TreeNode();
            //TreeNode tnFunction4Code = null, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                tnPrjFeature.Text = string.Format("<a onclick='TestNodeClick(\"{0}\")'>{1}</a>", objPrjFeature.FeatureId, objPrjFeature.FeatureName);
                objTV.Nodes.Add(tnPrjFeature);


            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;

            }
        }

        public static void Bindtv_PrjFeature(TreeView objTV)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                     conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                     conPrjFeature.OrderNum);

            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);


            TreeNode tnRoot = new TreeNode();
            //TreeNode tnFunction4Code = null, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);

                objTV.Nodes.Add(tnPrjFeature);


            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;

            }
        }

        public static void Bindtv_PrjFeature_Function4Code(TreeView objTV, int intApplicationTypeId)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                    conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                    conPrjFeature.OrderNum);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);
            //List<clsFunction4CodeEN> arrFunction4CodeObjList = clsFunction4CodeBL.GetObjLst(" 1=1 ");
            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId("1=1", intApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4Code = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);

                objTV.Nodes.Add(tnPrjFeature);


                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //Function4Code
                {
                    if (objvFeatureFuncRela.FeatureId != objPrjFeature.FeatureId) continue;
                    clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFeatureFuncRela.FuncId4Code);
                    tnFunction4Code = getTreeNodeByTabObj(objFunction4Code);
                    tnPrjFeature.ChildNodes.Add(tnFunction4Code);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ConstraintType_PrjConstraint(TreeView objTV, string strTabId)
        {

            List<clsConstraintTypeEN> arrConstraintTypeObjList = clsConstraintTypeBL.GetObjLstCache();
            //List<clsPrjConstraintEN> arrPrjConstraintObjList = clsPrjConstraintBL.GetObjLst(" 1=1 ");

            string strCondition = string.Format("{0}='{1}'  order by {2}",
                    convPrjConstraint.TabId, strTabId,
                    convPrjConstraint.ConstraintName);
            List<clsvPrjConstraintEN> arrvPrjConstraintObjList = clsvPrjConstraintBL.GetObjLst(strCondition);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnPrjConstraint = null; //,tnRange = null;
            TreeNode tnConstraintType = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsConstraintTypeEN objConstraintType in arrConstraintTypeObjList) //XzConstraintType
            {
                tnConstraintType = getTreeNodeByTabObj(objConstraintType);

                objTV.Nodes.Add(tnConstraintType);

                IEnumerable<clsvPrjConstraintEN> arrObjLst = arrvPrjConstraintObjList.Where(x => x.ConstraintTypeId == objConstraintType.ConstraintTypeId);
                foreach (clsvPrjConstraintEN objvPrjConstraint in arrObjLst)  //PrjConstraint
                {

                    tnPrjConstraint = getTreeNodeByTabObj(objvPrjConstraint);
                    if (objvPrjConstraint.InUse == false)
                    {
                        tnPrjConstraint.Text = String.Format("<span class=text-danger>(不用)</span>{0}", tnPrjConstraint.Text);
                    }
                    tnConstraintType.ChildNodes.Add(tnPrjConstraint);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_PrjFeature_Function4CodeByAppId(TreeView objTV, int intApplicationTypeId)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                    conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                    conPrjFeature.OrderNum);
            DataTable dtvPrjFeature = clsvPrjFeatureBLEx.GetDataTableByAppId(strCondition_PrjFeature, intApplicationTypeId);
            //clsPrjFeatureBL.
            List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstFromDataTable(dtvPrjFeature);
            List<clsFunction4CodeEN> arrFunction4CodeObjList = clsFunction4CodeBL.GetObjLst(" 1=1 ");
            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId("1=1", intApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4Code = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsvPrjFeatureEN objPrjFeature in arrvPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                tnPrjFeature.Text = objPrjFeature.FeatureName2;
                objTV.Nodes.Add(tnPrjFeature);


                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //Function4Code
                {
                    if (objvFeatureFuncRela.FeatureId != objPrjFeature.FeatureId) continue;
                    clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFeatureFuncRela.FuncId4Code);
                    tnFunction4Code = getTreeNodeByTabObj(objFunction4Code);
                    tnPrjFeature.ChildNodes.Add(tnFunction4Code);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }



        public static void Bindtv_PrjFeature_Function4GeneCodeByAppId(TreeView objTV, int intApplicationTypeId)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                    conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                    conPrjFeature.OrderNum);
            DataTable dtvPrjFeature = clsvPrjFeatureBLEx.GetDataTableByAppId(strCondition_PrjFeature, intApplicationTypeId);
            //clsPrjFeatureBL.
            List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstFromDataTable(dtvPrjFeature);

            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(" 1=1 ");

            string strCondition_vFeatureFuncRela = string.Format("{0}={1}  order by {2}",
                       convFeatureFuncRela.ApplicationTypeId, intApplicationTypeId,
                           convFeatureFuncRela.OrderNum);

            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId(strCondition_vFeatureFuncRela,
                intApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4GeneCode = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "功能-函数列表";
            objTV.Nodes.Add(tnRoot);
            foreach (clsvPrjFeatureEN objPrjFeature in arrvPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                tnPrjFeature.Text = objPrjFeature.FeatureName2;
                tnRoot.ChildNodes.Add(tnPrjFeature);


                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //Function4GeneCode
                {
                    if (objvFeatureFuncRela.FeatureId != objPrjFeature.FeatureId) continue;
                    clsFunction4GeneCodeEN objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFeatureFuncRela.FuncId4GC);
                    tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                    tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_PrjFeatureType_PrjFeature_Function4GeneCodeByAppId(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            int intApplicationTypeId = myTreeView.ApplicationTypeId;

            string strCondition_PrjFeature = string.Format("{0} in ('{1}', '{2}')  order by {3}",
                    conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03,
                    conPrjFeature.OrderNum);
            DataTable dtvPrjFeature = clsvPrjFeatureBLEx.GetDataTableByAppId(strCondition_PrjFeature, intApplicationTypeId);
            //clsPrjFeatureBL.
            List<string> arrFeatureTypeId = new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 };

            IEnumerable<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst = clsPrjFeatureTypeBL.GetObjLstCache()
                .OrderBy(x => x.OrderNum);
            List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstFromDataTable(dtvPrjFeature)
                                .Where(x => arrFeatureTypeId.Contains(x.FeatureTypeId) && x.InUse == true).ToList();

            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(" 1=1 ");

            string strCondition_vFeatureFuncRela = string.Format("{0}={1}  order by {2}",
                       convFeatureFuncRela.ApplicationTypeId, intApplicationTypeId,
                           convFeatureFuncRela.OrderNum);

            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId(strCondition_vFeatureFuncRela,
                intApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4GeneCode = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;

            TreeNode tnPrjFeatureType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "功能-函数列表";
            objTV.Nodes.Add(tnRoot);

            foreach (clsPrjFeatureTypeEN objPrjFeatureType in arrPrjFeatureTypeObjLst) //XzPrjFeature
            {
                tnPrjFeatureType = getTreeNodeByTabObj(objPrjFeatureType);
                tnPrjFeatureType.Text = objPrjFeatureType.FeatureTypeName;
                tnRoot.ChildNodes.Add(tnPrjFeatureType);
                IEnumerable<clsvPrjFeatureEN> arrvPrjFeatureObjList_Sub = arrvPrjFeatureObjList.Where(x => x.FeatureTypeId == objPrjFeatureType.FeatureTypeId);

                foreach (clsvPrjFeatureEN objPrjFeature in arrvPrjFeatureObjList_Sub) //XzPrjFeature
                {
                    tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                    tnPrjFeature.Text = objPrjFeature.FeatureName2;
                    tnPrjFeatureType.ChildNodes.Add(tnPrjFeature);

                    IEnumerable<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList_Sub = arrvFeatureFuncRelaObjList.Where(x => x.FeatureId == objPrjFeature.FeatureId);
                    foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList_Sub)  //Function4GeneCode
                    {
                        clsFunction4GeneCodeEN objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFeatureFuncRela.FuncId4GC);
                        tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                        clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4GeneCode.FuncCodeTypeId);
                        clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4GeneCode.FuncId4Code);
                        if (objCodeType != null && objFunction4Code != null)
                        {
                            tnFunction4GeneCode.Value = string.Format("{0},{1}-{2}",
                    objFunction4GeneCode._TabName_Curr, objPrjFeature.FeatureId, objFunction4GeneCode._KeyId);
                            tnFunction4GeneCode.Text = string.Format("{0}({1})", objFunction4Code.FuncName4Code, objCodeType.CodeTypeName);
                        }
                        tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

                        //if (tnXzGrade.ChildNodes.Count == 0)
                        //{
                        //    tnCourse.ChildNodes.Remove(tnXzGrade);
                        //}
                    }
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_CodeType_PrjFeature_Function4GeneCode(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strProgLangTypeId = myTreeView.ProgLangTypeId;
            string strDependsOn = myTreeView.DependsOn;
            string strGroupName = myTreeView.GroupName;
            //IEnumerable<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLstCache().
            //    Where(x=>x.IsVisible == true)
            //    .OrderBy(x=>x.OrderNum);

            IEnumerable<clsCodeTypeEN> arrCodeTypeObjLst = clsCodeTypeBL.GetObjLstCache()
                      .Where(x => x.InUse == true)
                .OrderBy(x => x.CodeTypeName);
            if (string.IsNullOrEmpty(strProgLangTypeId) == false)
            {
                arrCodeTypeObjLst = arrCodeTypeObjLst.Where(x => x.ProgLangTypeId == strProgLangTypeId);
            }
            if (string.IsNullOrEmpty(strDependsOn) == false)
            {
                arrCodeTypeObjLst = arrCodeTypeObjLst.Where(x => x.DependsOn == strDependsOn);
            }
            if (string.IsNullOrEmpty(strGroupName) == false)
            {
                arrCodeTypeObjLst = arrCodeTypeObjLst.Where(x => x.GroupName.Contains(strGroupName));
            }


            List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstCache()
                                .Where(x => x.FeatureTypeId == enumPrjFeatureType.GeneralFeature_05 && x.InUse == true)
                                .OrderBy(x => x.OrderNum)
                                .ToList();

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = clsvFunction4GeneCodeBL.GetObjLstCache()
                                .Where(x => x.InUse == true).OrderBy(x => x.FuncName4Code).ToList();
            if (string.IsNullOrEmpty(strProgLangTypeId) == false)
            {
                arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst.Where(x => x.ProgLangTypeId == strProgLangTypeId);
            }

            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4GeneCode = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;

            TreeNode tnCodeType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "功能-函数列表";
            objTV.Nodes.Add(tnRoot);

            foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjLst) //XzPrjFeature
            {
                tnCodeType = getTreeNodeByTabObj(objCodeType);
                tnCodeType.Text = objCodeType.CodeTypeName;
                tnRoot.ChildNodes.Add(tnCodeType);

                foreach (clsvPrjFeatureEN objPrjFeature in arrvPrjFeatureObjList) //XzPrjFeature
                {
                    tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                    tnPrjFeature.Text = objPrjFeature.FeatureName2;
                    tnPrjFeature.Value = string.Format("{0},{1}-{2}",
 objPrjFeature._TabName_Curr, objCodeType.CodeTypeId, objPrjFeature._KeyId);


                    IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjList_Sub
                        = arrvFunction4GeneCodeObjLst
                        .Where(x => x.FeatureId == objPrjFeature.FeatureId && x.FuncCodeTypeId == objCodeType.CodeTypeId);
                    if (arrvFunction4GeneCodeObjList_Sub.Count() > 0)
                    {
                        tnPrjFeature.Text = string.Format("{0}({1})", objPrjFeature.FeatureName, arrvFunction4GeneCodeObjList_Sub.Count());
                        tnCodeType.ChildNodes.Add(tnPrjFeature);
                    }
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjList_Sub)  //Function4GeneCode
                    {
                        if (string.IsNullOrEmpty(objvFunction4GeneCode.FuncId4Code)) continue;
                        tnFunction4GeneCode = getTreeNodeByTabObj(objvFunction4GeneCode);
                        clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCode.FuncId4Code);
                        if (objFunction4Code != null)
                        {
                            tnFunction4GeneCode.Text = objFunction4Code.GetFunctionSignature(strProgLangTypeId);

                        }
                        tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

                        //if (tnXzGrade.ChildNodes.Count == 0)
                        //{
                        //    tnCourse.ChildNodes.Remove(tnXzGrade);
                        //}
                    }
                }

                if (tnCodeType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnCodeType);
                }

            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_PrjFeatureType_PrjFeature(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            int intApplicationTypeId = myTreeView.ApplicationTypeId;
            string strCondition_PrjFeature = string.Format("{0} in ('{1}', '{2}') and {3}='1'  order by {4}",
                    conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03,
                    conPrjFeature.InUse,
                    conPrjFeature.OrderNum);


            //DataTable dtvPrjFeature = clsvPrjFeatureBLEx.GetDataTableByAppId(strCondition_PrjFeature, intApplicationTypeId);
            //clsPrjFeatureBL.
            IEnumerable<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst = clsPrjFeatureTypeBL.GetObjLstCache()
                .OrderBy(x => x.OrderNum);
            //List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstFromDataTable(dtvPrjFeature);

            IEnumerable<clsPrjFeatureEN> arrPrjFeatureObjLst = clsPrjFeatureBL.GetObjLstCache();
            IEnumerable<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst = clsvFeatureFuncRela_GroupByTtlBL.GetObjLstCache();

            TreeNode tnRoot = new TreeNode();

            TreeNode tnPrjFeature = null;

            TreeNode tnPrjFeatureType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "功能-函数列表";
            objTV.Nodes.Add(tnRoot);

            foreach (clsPrjFeatureTypeEN objPrjFeatureType in arrPrjFeatureTypeObjLst) //XzPrjFeature
            {
                IEnumerable<clsPrjFeatureEN> arrPrjFeatureObjList_Sub = arrPrjFeatureObjLst.Where(x => x.FeatureTypeId == objPrjFeatureType.FeatureTypeId);
                if (arrPrjFeatureObjList_Sub.Count() == 0) continue;
                tnPrjFeatureType = getTreeNodeByTabObj(objPrjFeatureType);
                tnPrjFeatureType.Text = objPrjFeatureType.FeatureTypeName;
                tnRoot.ChildNodes.Add(tnPrjFeatureType);

                foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList_Sub) //XzPrjFeature
                {
                    IEnumerable<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst_Sel =
                        arrvFeatureFuncRela_GroupByTtlObjLst.Where(x => x.FeatureId == objPrjFeature.FeatureId);
                    if (intApplicationTypeId > 0)
                    {
                        arrvFeatureFuncRela_GroupByTtlObjLst_Sel = arrvFeatureFuncRela_GroupByTtlObjLst_Sel.Where(x => x.ApplicationTypeId == intApplicationTypeId);
                    }
                    int intSum = arrvFeatureFuncRela_GroupByTtlObjLst_Sel.Sum(x => x.FuncCount??0);
                    tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                    tnPrjFeature.Text = string.Format("{0}({1})", objPrjFeature.FeatureName, intSum);
                    tnPrjFeatureType.ChildNodes.Add(tnPrjFeature);
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_PrjFeatureType(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            //int intApplicationTypeId = myTreeView.ApplicationTypeId;
            //string strCondition_PrjFeature = string.Format("{0} in ('{1}', '{2}') and {3}='1'  order by {4}",
            //        conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03,
            //        conPrjFeature.InUse,
            //        conPrjFeature.OrderNum);


            //DataTable dtvPrjFeature = clsvPrjFeatureBLEx.GetDataTableByAppId(strCondition_PrjFeature, intApplicationTypeId);
            //clsPrjFeatureBL.
            IEnumerable<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst = clsPrjFeatureTypeBL.GetObjLstCache()
                .OrderBy(x => x.OrderNum);
            //List<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstFromDataTable(dtvPrjFeature);

            IEnumerable<clsPrjFeatureEN> arrPrjFeatureObjLst = clsPrjFeatureBL.GetObjLstCache();

            TreeNode tnRoot = new TreeNode();

            //TreeNode tnPrjFeature = null;

            TreeNode tnPrjFeatureType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "功能-函数列表";
            objTV.Nodes.Add(tnRoot);

            foreach (clsPrjFeatureTypeEN objPrjFeatureType in arrPrjFeatureTypeObjLst) //XzPrjFeature
            {
                IEnumerable<clsPrjFeatureEN> arrPrjFeatureObjList_Sub = arrPrjFeatureObjLst.Where(x => x.FeatureTypeId == objPrjFeatureType.FeatureTypeId);
                if (arrPrjFeatureObjList_Sub.Count() == 0) continue;
                tnPrjFeatureType = getTreeNodeByTabObj(objPrjFeatureType);
                tnPrjFeatureType.Text = string.Format("{0}({1})", objPrjFeatureType.FeatureTypeName, arrPrjFeatureObjList_Sub.Count());
                tnRoot.ChildNodes.Add(tnPrjFeatureType);

                //foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList_Sub) //XzPrjFeature
                //{
                //    IEnumerable<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst_Sel =
                //        arrvFeatureFuncRela_GroupByTtlObjLst.Where(x => x.FeatureId == objPrjFeature.FeatureId);
                //    if (intApplicationTypeId > 0)
                //    {
                //        arrvFeatureFuncRela_GroupByTtlObjLst_Sel = arrvFeatureFuncRela_GroupByTtlObjLst_Sel.Where(x => x.ApplicationTypeId == intApplicationTypeId);
                //    }
                //    int intSum = arrvFeatureFuncRela_GroupByTtlObjLst_Sel.Sum(x => x.FuncCount);
                //    tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                //    tnPrjFeature.Text = string.Format("{0}({1})", objPrjFeature.FeatureName, intSum);
                //    tnPrjFeatureType.ChildNodes.Add(tnPrjFeature);
                //}
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_PrjFeature_TabFeature(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strTabId = myTreeView.TabId;
            List<string> arrFeatureTypeId = new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 };
            //string strCondition_PrjFeature = string.Format("{0} in ('{1}', '{2}')  order by {3}",
            //        conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03,
            //        conPrjFeature.OrderNum);
            IEnumerable<clsvPrjFeatureEN> arrvPrjFeatureObjList = clsvPrjFeatureBL.GetObjLstCache()
                .Where(x => arrFeatureTypeId.Contains(x.FeatureTypeId))
                .OrderBy(x => x.OrderNum);

            string strCondition_TabFeature = string.Format("{0} = '{1}'",
                    conTabFeature.TabId, strTabId);
            //clsPrjFeatureBL.
            IEnumerable<clsvTabFeatureEN> arrTabFeatureObjLst = clsvTabFeatureBL.GetObjLst(strCondition_TabFeature).OrderBy(x => x.OrderNum);
            List<clsvTabFeatureEN> arrParentObjLst = new List<clsvTabFeatureEN>();
            bool bolIsHasParentObj = false;

            foreach (clsvTabFeatureEN objTabFeature in arrTabFeatureObjLst)
            {
                if (string.IsNullOrEmpty(objTabFeature.ParentFeatureId) == false)
                {
                    if (arrTabFeatureObjLst.Any(x => x.FeatureId == objTabFeature.ParentFeatureId) == true)
                    {
                        bolIsHasParentObj = true;
                        break;
                    }
                }
            }
            foreach (clsvTabFeatureEN objTabFeature in arrTabFeatureObjLst)
            {
                if (string.IsNullOrEmpty(objTabFeature.ParentFeatureId) == false)
                {
                    clsvTabFeatureEN objTabFeature_Parent = arrTabFeatureObjLst.ToList().Find(x => x.FeatureId == objTabFeature.ParentFeatureId);
                    if (objTabFeature_Parent != null)
                    {
                        if (arrParentObjLst.Any(x => x.TabFeatureId == objTabFeature_Parent.TabFeatureId) == false)
                        {
                            arrParentObjLst.Add(objTabFeature_Parent);
                        }
                    }
                }
                else
                {
                    if (arrParentObjLst.Any(x => x.TabFeatureId == objTabFeature.TabFeatureId) == false)
                    {
                        arrParentObjLst.Add(objTabFeature);
                    }
                }
            }

            TreeNode tnRoot = new TreeNode();

            TreeNode tnPrjFeature = null;

            TreeNode tnTabFeature_Parent = null;
            TreeNode tnTabFeature = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            //     tnRoot.Text = string.Format("<span class='rootNode'>{0}</span>", "功能-表功能");
            tnRoot.Text = string.Format("<h6>{0}</h6>", "功能-表功能");
            objTV.Nodes.Add(tnRoot);


            foreach (clsvPrjFeatureEN objPrjFeature in arrvPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);
                tnPrjFeature.Text = objPrjFeature.FeatureName2;
                tnRoot.ChildNodes.Add(tnPrjFeature);
                if (bolIsHasParentObj == true)
                {
                    IEnumerable<clsvTabFeatureEN> arrParentObjLst_Sub = arrParentObjLst.Where(x => x.FeatureId == objPrjFeature.FeatureId);
                    if (arrParentObjLst_Sub.Count() > 0)
                    {
                        foreach (clsvTabFeatureEN objTabFeature_Parent in arrParentObjLst_Sub) //XzPrjFeature
                        {
                            tnTabFeature_Parent = getTreeNodeByTabObj(objTabFeature_Parent);
                            tnTabFeature_Parent.Text = string.Format("{0}({1})",
                                    objTabFeature_Parent.TabFeatureName,
                                    objTabFeature_Parent.FldNum);
                            tnPrjFeature.ChildNodes.Add(tnTabFeature_Parent);
                            foreach (clsvTabFeatureEN objTabFeature in arrTabFeatureObjLst) //XzPrjFeature
                            {
                                if (objTabFeature.ParentFeatureId != objTabFeature_Parent.FeatureId) continue;
                                tnTabFeature = getTreeNodeByTabObj(objTabFeature);
                                tnTabFeature.Text = string.Format("{0}({1})",
                                    objTabFeature.TabFeatureName,
                                    objTabFeature.FldNum);
                                tnTabFeature_Parent.ChildNodes.Add(tnTabFeature);
                            }
                        }

                    }
                }
                else
                {
                    IEnumerable<clsvTabFeatureEN> arrTabFeatureObjList_Sub = arrTabFeatureObjLst.Where(x => x.FeatureId == objPrjFeature.FeatureId);
                    if (arrTabFeatureObjList_Sub.Count() > 0)
                    {
                        foreach (clsvTabFeatureEN objTabFeature in arrTabFeatureObjList_Sub) //XzPrjFeature
                        {
                            tnTabFeature = getTreeNodeByTabObj(objTabFeature);
                            tnTabFeature.Text = string.Format("{0}({1})",
       objTabFeature.TabFeatureName,
       objTabFeature.FldNum);
                            tnPrjFeature.ChildNodes.Add(tnTabFeature);
                        }

                    }
                }
                if (tnPrjFeature.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnPrjFeature);
                }

            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ViewRegion_PrjFeature(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strViewId = myTreeView.ViewId;
            string strPrjId = myTreeView.PrjId;
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            string strCondition_vFeatureRegionFlds = string.Format("{0} in ({1})",
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            //clsViewRegionBL.
            IEnumerable<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst = clsvFeatureRegionFldsBL.GetObjLst(strCondition_vFeatureRegionFlds);
            IEnumerable<IGrouping<string, clsvFeatureRegionFldsEN>> arrGroupByRegionName = arrvFeatureRegionFldsObjLst.GroupBy(x => x.RegionName);
            TreeNode tnRoot = new TreeNode();

            TreeNode tnViewRegion = null;

            TreeNode tnvFeatureRegionFlds = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            //     tnRoot.Text = string.Format("<span class='rootNode'>{0}</span>", "功能-表功能");
            tnRoot.Text = string.Format("<h6>{0}</h6>", "区域-功能");
            objTV.Nodes.Add(tnRoot);


            foreach (IGrouping<string, clsvFeatureRegionFldsEN> item in arrGroupByRegionName) //XzViewRegion
            {
                string strRegionName = item.Key;
                clsvFeatureRegionFldsEN obj = arrvFeatureRegionFldsObjLst.Where(x => x.RegionName == strRegionName).ToList()[0];

                tnViewRegion = getTreeNodeByTabObj(obj);
                tnViewRegion.Value = string.Format("{0},{1}",
                  clsViewRegionEN._CurrTabName,
                  obj.RegionId);
                tnViewRegion.Text = strRegionName;

                tnRoot.ChildNodes.Add(tnViewRegion);
                foreach (clsvFeatureRegionFldsEN objvFeatureRegionFlds in item) //XzViewRegion
                {
                    tnvFeatureRegionFlds = getTreeNodeByTabObj(objvFeatureRegionFlds);
                    tnvFeatureRegionFlds.Value = string.Format("{0},{1}",
                  clsPrjFeatureEN._CurrTabName,
                  objvFeatureRegionFlds.FeatureId);
                    tnvFeatureRegionFlds.Text = objvFeatureRegionFlds.FeatureName;
                    tnViewRegion.ChildNodes.Add(tnvFeatureRegionFlds);

                }


            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ViewRegion_ViewFeature(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strViewId = myTreeView.ViewId;
            string strCmPrjId = myTreeView.CmPrjId;

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strCmPrjId);


            string strCondition_vFeatureRegionFlds_Ttl = string.Format("{0} in ({1})",
                    convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));

            IEnumerable<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLst = clsvFeatureRegionFlds_TtlBL.GetObjLst(strCondition_vFeatureRegionFlds_Ttl);
            IEnumerable<IGrouping<string, clsvFeatureRegionFlds_TtlEN>> arrGroupByRegionName = arrvFeatureRegionFlds_TtlObjLst.GroupBy(x => x.RegionName);
            TreeNode tnRoot = new TreeNode();

            TreeNode tnViewRegion = null;

            TreeNode tnvFeatureRegionFlds_Ttl = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            //     tnRoot.Text = string.Format("<span class='rootNode'>{0}</span>", "功能-表功能");
            tnRoot.Text = string.Format("<h6>{0}</h6>", "区域-界面功能");
            objTV.Nodes.Add(tnRoot);


            foreach (IGrouping<string, clsvFeatureRegionFlds_TtlEN> item in arrGroupByRegionName) //XzViewRegion
            {
                string strRegionName = item.Key;
                clsvFeatureRegionFlds_TtlEN obj = arrvFeatureRegionFlds_TtlObjLst.Where(x => x.RegionName == strRegionName).ToList()[0];

                tnViewRegion = getTreeNodeByTabObj(obj);
                tnViewRegion.Value = string.Format("{0},{1}",
                  clsViewRegionEN._CurrTabName,
                  obj.RegionId);
                tnViewRegion.Text = strRegionName;

                tnRoot.ChildNodes.Add(tnViewRegion);
                foreach (clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_Ttl in item) //XzViewRegion
                {
                    tnvFeatureRegionFlds_Ttl = getTreeNodeByTabObj(objvFeatureRegionFlds_Ttl);
                    tnvFeatureRegionFlds_Ttl.Value = string.Format("{0},{1}",
                    clsFeatureRegionFldsEN._CurrTabName,
                  objvFeatureRegionFlds_Ttl.ViewFeatureId);
                    tnvFeatureRegionFlds_Ttl.Text = string.Format("{0}({1})",
                        objvFeatureRegionFlds_Ttl.FeatureName,
                        objvFeatureRegionFlds_Ttl.FldNum);
                    tnViewRegion.ChildNodes.Add(tnvFeatureRegionFlds_Ttl);

                }


            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ViewRegion(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strViewId = myTreeView.ViewId;
            string strPrjId = myTreeView.PrjId;

            //string strCondition_ViewRegion = string.Format("{0} = '{1}'",
            //        clsViewRegionEN.con_ViewId, strViewId);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            //clsViewRegionBL.
            IEnumerable<clsvViewRegionEN> arrViewRegionObjLst = clsvViewRegionBL.GetObjLstCache(strPrjId).Where(x => arrRegionId.Contains(x.RegionId));
            //IEnumerable<IGrouping<string, clsViewRegionEN>> arrGroupByRegionName = arrViewRegionObjLst.GroupBy(x => x.RegionName);
            TreeNode tnRoot = new TreeNode();

            TreeNode tnViewRegion = null;


            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            //     tnRoot.Text = string.Format("<span class='rootNode'>{0}</span>", "功能-表功能");
            tnRoot.Text = string.Format("<h6>{0}</h6>", "界面区域：");
            objTV.Nodes.Add(tnRoot);


            foreach (clsvViewRegionEN item in arrViewRegionObjLst) //XzViewRegion
            {
                tnViewRegion = getTreeNodeByTabObj(item);
                int intFeatureNum = clsvRegionFeatureCountBLEx.GetFeatureNum(strPrjId, item.RegionId);
                tnViewRegion.Text = string.Format("{0}({1})", item.RegionName, intFeatureNum);
                tnRoot.ChildNodes.Add(tnViewRegion);
            }
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CodeTypeByProgLangTypeId(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            string strProgLangTypeId = myTreeView.ProgLangTypeId;
            string strDependsOn = myTreeView.DependsOn;
            string strGroupName = myTreeView.GroupName;

            //string strCondition_ApplicationType = string.Format(" {0}='1'  order by {1}",
            //                            conApplicationType.IsVisible,
            //                            conApplicationType.OrderNum);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLstCache()
                .OrderByDescending(x => x.IsVisible).ThenBy(x => x.OrderNum);

            IEnumerable<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()
                .OrderBy(x => x.OrderNum);
            if (string.IsNullOrEmpty(strProgLangTypeId) == false)
            {
                arrvAppCodeTypeRelaObjList = arrvAppCodeTypeRelaObjList.Where(x => x.ProgLangTypeId == strProgLangTypeId);
            }
            if (string.IsNullOrEmpty(strDependsOn) == false)
            {
                arrvAppCodeTypeRelaObjList = arrvAppCodeTypeRelaObjList.Where(x => x.DependsOn == strDependsOn);
            }
            if (string.IsNullOrEmpty(strGroupName) == false)
            {
                arrvAppCodeTypeRelaObjList = arrvAppCodeTypeRelaObjList.Where(x => x.GroupName.Contains(strGroupName));
            }
            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                if (objApplicationType.ApplicationTypeName == "未知") continue;
                if (objApplicationType.IsVisible == false)
                {
                    tnApplicationType.Text = string.Format("{0}(弃用)", objApplicationType.ApplicationTypeName);
                }
                IEnumerable<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjList_Sel = arrvAppCodeTypeRelaObjList
                    .Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId)
                       .OrderBy(x => x.OrderNum);
                if (arrvAppCodeTypeRelaObjList_Sel.Count() == 0) continue;
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objvAppCodeTypeRela in arrvAppCodeTypeRelaObjList_Sel)  //vAppCodeTypeRela
                {
                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objvAppCodeTypeRela.CodeTypeId);
                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    tnApplicationType.ChildNodes.Add(tnCodeType);
                }
                //if (tnApplicationType.ChildNodes.Count == 0)
                //{
                //    objTV.Nodes.Remove(tnApplicationType);
                //}
            }

            try
            {
                if (objTV.Nodes.Count > 0)
                {
                    objTV.Nodes[0].Select();
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CodeType(TreeView objTV)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            //string strProgLangTypeId = myTreeView.ProgLangTypeId;
            string strDependsOn = myTreeView.DependsOn;
            string strGroupName = myTreeView.GroupName;

            string strCondition_ApplicationType = string.Format(" {0}='1'  order by {1}",
                                        conApplicationType.IsVisible,
                                        conApplicationType.OrderNum);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLstCache()
                  .OrderByDescending(x => x.IsVisible).ThenBy(x => x.OrderNum);

            IEnumerable<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLstCache();
            if (string.IsNullOrEmpty(strDependsOn) == false)
            {
                arrCodeTypeObjList = arrCodeTypeObjList.Where(x => x.DependsOn == strDependsOn);
            }
            if (string.IsNullOrEmpty(strGroupName) == false)
            {
                arrCodeTypeObjList = arrCodeTypeObjList.Where(x => x.GroupName.Contains(strGroupName));
            }

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);

                objTV.Nodes.Add(tnApplicationType);

                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;
                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    tnApplicationType.ChildNodes.Add(tnCodeType);
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnApplicationType);
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ProgLangType_ApplicationType_CodeType(TreeView objTV, string strDependsOn)
        {
            string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
                                        conProgLangType.IsVisible,
                                        conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_ApplicationType = string.Format("{0}='1'  order by {1}",
                                     conApplicationType.IsVisible,
                                     conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='{1}'  order by {2}",
                                      conCodeType.DependsOn, strDependsOn,
                                      conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            {
                tnProgLangType = getTreeNodeByTabObj(objProgLangType);
                objTV.Nodes.Add(tnProgLangType);

                foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
                {
                    if (objApplicationType.ProgLangTypeId != objProgLangType.ProgLangTypeId
                        && objApplicationType.ProgLangTypeId2 != objProgLangType.ProgLangTypeId
                        && objApplicationType.ProgLangTypeId3 != objProgLangType.ProgLangTypeId
                        ) continue;
                    tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                    tnProgLangType.ChildNodes.Add(tnApplicationType);

                    foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                    {
                        if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

                        tnCodeType = getTreeNodeByTabObj(objCodeType);
                        tnApplicationType.ChildNodes.Add(tnCodeType);
                    }
                    if (tnApplicationType.ChildNodes.Count == 0)
                    {
                        tnProgLangType.ChildNodes.Remove(tnApplicationType);
                    }
                }
                if (tnProgLangType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnProgLangType);
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public class FuncId4CodeComparer : IEqualityComparer<string>
        {
            public bool Equals(string t1, string t2)
            {
                return (t1 == t2);
            }
            public int GetHashCode(string t)
            {
                return t.ToString().GetHashCode();
            }
        }

        public static void Bindtv_ApplicationType_CodeType_Function4GeneCode(TreeView objTV,
            string strDependsOn, string strFunctionTemplateId, string strTabId, string strPrjId)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);
            string strCondition_CodeType = string.Format("{0}='{1}'  order by {2}",
                                      convAppCodeTypeRela.DependsOn, strDependsOn,
                                      convAppCodeTypeRela.OrderNum);
            IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()//strCondition_CodeType);
                .Where(x => x.DependsOn == strDependsOn)
                .OrderBy(x => x.OrderNum);

            string strCondition_Function4GeneCode = string.Format(" {0}='1' and {1} in (select {1} from {2} where {3}='{4}') order by {5}",
                                                                conFunction4GeneCode.InUse,
                                                                conFunction4GeneCode.FuncId4GC,
                                                                conFunctionTemplateRela._CurrTabName,
                                                                conFunctionTemplateRela.FunctionTemplateId,
                                                                strFunctionTemplateId,
                                                                conFunction4GeneCode.OrderNum);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(strCondition_Function4GeneCode);
            List<string> arrFuncId4Code = arrFunction4GeneCodeObjList.Select(x => x.FuncId4Code).Distinct(new FuncId4CodeComparer()).ToList();

            string strCondition_Function4Code = string.Format(" {0} in ({1})",
                                                                conFunction4Code.FuncId4Code,
                                                                clsArray.GetSqlInStrByArray(arrFuncId4Code, true));
            List<clsFunction4CodeEN> arrFunction4CodeObjLst = clsFunction4CodeBL.GetObjLst(strCondition_Function4Code);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFunction4GeneCode = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objAppCodeTypeRelaEN.ApplicationTypeId) continue;

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        string strClassName = clsCodeTypeBLEx.GetClassNameByTabId(objCodeType.CodeTypeId,
                           objCodeType.ProgLangTypeId, strTabId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}({2})", objCodeType._NameValue,
                            strClassName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        if (bolIsUseJsEvent)
                        {
                            tnCodeType.Text = string.Format("<a onclick=\"GeneCode('C{3}','{4}','{5}');\">{0}-{1}({2})</a>", objCodeType._NameValue,
                                strClassName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId),
                                objCodeType.CodeTypeId, strTabId, objAppCodeTypeRelaEN.ApplicationTypeId);

                        }
                    }
                    else
                    {
                        if (bolIsUseJsEvent)
                        {
                            tnCodeType.Text = string.Format("<a onclick=\"GeneCode('C{2}','{3}','{4}');\">{0}({1})</a>", objCodeType._NameValue,
                                clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId),
                                objCodeType.CodeTypeId, strTabId, objAppCodeTypeRelaEN.ApplicationTypeId);

                        }
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    List<string> arrText = new List<string>();
                    foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)  //Function4GeneCode
                    {
                        if (objFunction4GeneCode.FuncCodeTypeId != objCodeType.CodeTypeId) continue;

                        tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                        clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4GeneCode.FuncGCTypeId);
                        if (string.IsNullOrEmpty(objFunction4GeneCode.FuncId4Code) == true)
                        {
                            tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
                                objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCode._NameValue);
                            if (bolIsUseJsEvent)
                            {
                                tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{2}','{3}','{4}', '{5}');\">{0}(?)-{1}</a>",
                                    objFuncGCTypeEN.FuncGCTypeName,
                                    objFunction4GeneCode._NameValue,
                                    objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, objAppCodeTypeRelaEN.ApplicationTypeId);

                            }

                        }
                        else
                        {
                            clsFunction4CodeEN objFunction4CodeEN = arrFunction4CodeObjLst.Find(x => x.FuncId4Code == objFunction4GeneCode.FuncId4Code);
                            if (objFunction4CodeEN != null)
                            {
                                tnFunction4GeneCode.Text = string.Format("{0}:{1}",
                                    objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue, objFunction4GeneCode._NameValue);
                                if (bolIsUseJsEvent)
                                {
                                    tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{2}','{3}','{4}', '{5}');\">{0}:{1}</a>",
                                        objFuncGCTypeEN.FuncGCTypeName,
                                        objFunction4CodeEN._NameValue,
                                        objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, objAppCodeTypeRelaEN.ApplicationTypeId);

                                }
                                if (arrText.Contains(tnFunction4GeneCode.Text) == true)
                                {
                                    tnFunction4GeneCode.Text = string.Format("{0}({2})-{1}",
                                      objFuncGCTypeEN.FuncGCTypeName,
                                      objFunction4GeneCode._NameValue,
                                      objFunction4CodeEN._NameValue);

                                    if (bolIsUseJsEvent)
                                    {
                                        tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{3}','{4}','{5}', '{6}');\">{0}){2}:{1}</a>",
                                            objFuncGCTypeEN.FuncGCTypeName,
                                            objFunction4GeneCode._NameValue,
                                            objFunction4CodeEN._NameValue,
                                            objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, objAppCodeTypeRelaEN.ApplicationTypeId);

                                    }

                                }
                                tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCode._NameValue);
                            }
                        }
                        arrText.Add(tnFunction4GeneCode.Text);
                        tnCodeType.ChildNodes.Add(tnFunction4GeneCode);
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnApplicationType);
                }
            }
            //    if (tnProgLangType.ChildNodes.Count == 0)
            //    {
            //        objTV.Nodes.Remove(tnProgLangType);
            //    }
            //}

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CodeType_ClassName_Function4GeneCode(TreeView objTV,
          string strDependsOn, string strFunctionTemplateId, string strTabId, string strCmPrjId, string strPrjId)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            string strTabMainTypeId = myTreeView.TabMainTypeId;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);
            string strCondition_CodeType = string.Format("{0}='{1}'  order by {2}",
                                      convAppCodeTypeRela.DependsOn, strDependsOn,
                                      convAppCodeTypeRela.OrderNum);
            IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()//strCondition_CodeType);
                .Where(x => x.DependsOn == strDependsOn && x.TabMainTypeId == strTabMainTypeId)
                .OrderBy(x => x.OrderNum);

            string strCondition_Function4GeneCode = string.Format(" {0}='1' and {1} in (select {1} from {2} where {3}='{4}') order by {5}",
                                                                conFunction4GeneCode.InUse,
                                                                conFunction4GeneCode.FuncId4GC,
                                                                conFunctionTemplateRela._CurrTabName,
                                                                conFunctionTemplateRela.FunctionTemplateId,
                                                                strFunctionTemplateId,
                                                                conFunction4GeneCode.OrderNum);
            IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(strCondition_Function4GeneCode);
            List<string> arrFuncId4Code = arrFunction4GeneCodeObjList.Select(x => x.FuncId4Code).Distinct(new FuncId4CodeComparer()).ToList();

            string strCondition_Function4Code = string.Format(" {0} in ({1})",
                                                                conFunction4Code.FuncId4Code,
                                                                clsArray.GetSqlInStrByArray(arrFuncId4Code, true));
            List<clsFunction4CodeEN> arrFunction4CodeObjLst = clsFunction4CodeBL.GetObjLst(strCondition_Function4Code);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnClassName = null;
            string strClassName = "";
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);
                IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList_Sel = arrAppCodeTypeRelaObjList.Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId);
                if (arrAppCodeTypeRelaObjList_Sel.Count() == 0) continue;
                foreach (clsvAppCodeTypeRelaEN objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objAppCodeTypeRelaEN.ApplicationTypeId) continue;

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        strClassName = clsCodeTypeBLEx.GetClassNameByTabId(objCodeType.CodeTypeId,
                           objCodeType.ProgLangTypeId, strTabId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}({2})", objCodeType._NameValue,
                            strClassName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        if (bolIsUseJsEvent)
                        {
                            tnCodeType.Text = string.Format("<a onclick=\"GeneCode('C{3}','{4}','{5}', '{6}');\">{0}-{1}({2})</a>", objCodeType._NameValue,
                                strClassName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId),
                                objCodeType.CodeTypeId, strTabId, strCmPrjId, objAppCodeTypeRelaEN.ApplicationTypeId);

                        }
                    }
                    else
                    {
                        if (bolIsUseJsEvent)
                        {
                            tnCodeType.Text = string.Format("<a onclick=\"GeneCode('C{2}','{3}','{4}', '{5}');\">{0}({1})</a>", objCodeType._NameValue,
                                clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId),
                                objCodeType.CodeTypeId, strTabId, strCmPrjId, objAppCodeTypeRelaEN.ApplicationTypeId);

                        }
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    List<string> arrText = new List<string>();
                    IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList_Sel = arrFunction4GeneCodeObjList.Where(x => x.FuncCodeTypeId == objCodeType.CodeTypeId);
                    if (arrFunction4GeneCodeObjList_Sel.Count() == 0) continue;
                    //strClassName = string.Format(objCodeType.ClassNameFormat, objprj);
                    IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList_Static = arrFunction4GeneCodeObjList.Where(
                        x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12 && x.FuncCodeTypeId == objCodeType.CodeTypeId);
                    IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList_NotStatic = arrFunction4GeneCodeObjList.Where(
                        x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12 && x.FuncCodeTypeId == objCodeType.CodeTypeId);
                    if (arrFunction4GeneCodeObjList_Static.Count() > 0)
                    {
                        tnClassName = new TreeNode();
                        tnClassName.Value = string.Format("{0},{1}",
                                objCodeType._TabName_Curr,
                                objCodeType._KeyId);
                        tnClassName.Text = string.Format("{0}_Static", strClassName);
                        tnCodeType.ChildNodes.Add(tnClassName);
                        Bindtv_Function4GeneCode(arrFunction4GeneCodeObjList_Static, arrFunction4CodeObjLst, tnClassName, objCodeType, strTabId, strCmPrjId, objApplicationType.ApplicationTypeId, bolIsUseJsEvent);
                    }

                    if (arrFunction4GeneCodeObjList_Static.Count() == 0)
                    {
                        tnClassName = new TreeNode();
                        tnClassName.Value = string.Format("{0},{1}",
                                objCodeType._TabName_Curr,
                                objCodeType._KeyId);
                        tnClassName.Text = string.Format("{0}", strClassName);
                        tnCodeType.ChildNodes.Add(tnClassName);
                        Bindtv_Function4GeneCode(arrFunction4GeneCodeObjList_Sel, arrFunction4CodeObjLst, tnClassName, objCodeType, strTabId, strCmPrjId, objApplicationType.ApplicationTypeId, bolIsUseJsEvent);
                    }
                    else
                    {
                        if (arrFunction4GeneCodeObjList_NotStatic.Count() > 0)
                        {
                            tnClassName = new TreeNode();
                            tnClassName.Value = string.Format("{0},{1}",
                                    objCodeType._TabName_Curr,
                                    objCodeType._KeyId);
                            tnClassName.Text = string.Format("{0}", strClassName);
                            tnCodeType.ChildNodes.Add(tnClassName);

                            Bindtv_Function4GeneCode(arrFunction4GeneCodeObjList_NotStatic, arrFunction4CodeObjLst, tnClassName, objCodeType, strTabId, strCmPrjId, objApplicationType.ApplicationTypeId, bolIsUseJsEvent);
                        }
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnApplicationType);
                }
            }
            //    if (tnProgLangType.ChildNodes.Count == 0)
            //    {
            //        objTV.Nodes.Remove(tnProgLangType);
            //    }
            //}

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        public static void Bindtv_Function4GeneCode(IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList, List<clsFunction4CodeEN> arrFunction4CodeObjLst,
            TreeNode tnParentNode, clsCodeTypeEN objCodeType, string strTabId, string strCmPrjId, int intApplicationTypeId, bool bolIsUseJsEvent)
        {
            List<string> arrText = new List<string>();
            TreeNode tnFunction4GeneCode = null;

            foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)  //Function4GeneCode
            {
                tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4GeneCode.FuncGCTypeId);
                if (string.IsNullOrEmpty(objFunction4GeneCode.FuncId4Code) == true)
                {
                    tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
                        objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCode._NameValue);
                    if (bolIsUseJsEvent)
                    {
                        tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{2}','{3}','{4}','{5}', '{6}');\">{0}(?)-{1}</a>",
                            objFuncGCTypeEN.FuncGCTypeName,
                            objFunction4GeneCode._NameValue,
                            objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, strCmPrjId, intApplicationTypeId);

                    }

                }
                else
                {
                    clsFunction4CodeEN objFunction4CodeEN = arrFunction4CodeObjLst.Find(x => x.FuncId4Code == objFunction4GeneCode.FuncId4Code);
                    if (objFunction4CodeEN != null)
                    {
                        tnFunction4GeneCode.Text = string.Format("{0}:{1}",
                            objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue, objFunction4GeneCode._NameValue);
                        if (bolIsUseJsEvent)
                        {
                            tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{2}','{3}','{4}', '{5}', '{6}');\">{0}:{1}</a>",
                                objFuncGCTypeEN.FuncGCTypeName,
                                objFunction4CodeEN._NameValue,
                                objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, strCmPrjId, intApplicationTypeId);

                        }
                        if (arrText.Contains(tnFunction4GeneCode.Text) == true)
                        {
                            tnFunction4GeneCode.Text = string.Format("{0}({2})-{1}",
                              objFuncGCTypeEN.FuncGCTypeName,
                              objFunction4GeneCode._NameValue,
                              objFunction4CodeEN._NameValue);

                            if (bolIsUseJsEvent)
                            {
                                tnFunction4GeneCode.Text = string.Format("<a onclick=\"GeneCode4Func('C{3}','{4}','{5}', '{6}');\">{0}){2}:{1}</a>",
                                    objFuncGCTypeEN.FuncGCTypeName,
                                    objFunction4GeneCode._NameValue,
                                    objFunction4CodeEN._NameValue,
                                    objCodeType.CodeTypeId, strTabId, objFunction4GeneCode._KeyId, intApplicationTypeId);

                            }

                        }
                        tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCode._NameValue);
                    }
                }
                arrText.Add(tnFunction4GeneCode.Text);
                tnParentNode.ChildNodes.Add(tnFunction4GeneCode);
            }
        }

        public static void Bindtv_ApplicationType_CodeType_CMClass(TreeView objTV, string strPrjId)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);
            string strCondition_CodeType = string.Format("1=1  order by {0}",
                                      convAppCodeTypeRela.OrderNum);
            IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()//strCondition_CodeType);                
                .OrderBy(x => x.OrderNum);

            string strCondition_CMClass = string.Format(" {0}='1' and {1}='{2}' order by {3}",
                                                                conCMClass.IsOpen,
                                                                conCMClass.PrjId,
                                                                strPrjId,
                                                                conCMClass.ClsName);
            if (string.IsNullOrEmpty(strPrjId))
            {
                strCondition_CMClass = string.Format(" {0}='1' order by {1}",
                                                                conCMClass.IsOpen,
                                                                conCMClass.ClsName);
            }
            List<clsvCMClassEN> arrCMClassObjList = clsvCMClassBL.GetObjLst(strCondition_CMClass).OrderBy(x => x.ClsName).ToList();
            //List<string> arrCmClassId = arrCMClassObjList.Select(x => x.CmClassId).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnCMClass = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有类";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objAppCodeTypeRelaEN.ApplicationTypeId) continue;

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);

                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    List<string> arrText = new List<string>();
                    foreach (clsvCMClassEN objCMClass in arrCMClassObjList)  //CMClass
                    {
                        if (objCMClass.CodeTypeId != objCodeType.CodeTypeId) continue;
                        if (objCMClass.FuncNum == 0) continue;
                        tnCMClass = getTreeNodeByTabObj(objCMClass);
                        //if (string.IsNullOrEmpty(objCMClass.CmClassId) == true)
                        //{
                        tnCMClass.Text = string.Format("{0}({1})",
                            objCMClass.ClsName, objCMClass.FuncNum);
                        //}

                        arrText.Add(tnCMClass.Text);
                        tnCodeType.ChildNodes.Add(tnCMClass);
                    }
                    if (tnCodeType.ChildNodes.Count == 0)
                    {
                        tnApplicationType.ChildNodes.Remove(tnCodeType);
                    }
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }
            //if (tnRoot.ChildNodes.Count == 0)
            //{
            //    tnRoot.ChildNodes.Remove(tnApplicationType);
            //}


            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public class NameSpaceComparer : IEqualityComparer<CodeTypeIdNameSpace>
        {
            public bool Equals(CodeTypeIdNameSpace t1, CodeTypeIdNameSpace t2)
            {
                return (t1.NameSpace == t2.NameSpace && t1.CodeTypeId == t2.CodeTypeId);
            }
            public int GetHashCode(CodeTypeIdNameSpace t)
            {
                return t.ToString().GetHashCode();
            }
        }

        public class CodeTypeIdNameSpace
        {
            public string CodeTypeId { get; set; }
            public string NameSpace { get; set; }
        }
        public static void Bindtv_ApplicationType_CodeType_NameSpace_CMClassBak(TreeView objTV, string strPrjId)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);
            string strCondition_CodeType = string.Format("1=1  order by {0}",
                                      convAppCodeTypeRela.OrderNum);
            IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()//strCondition_CodeType);                
                .OrderBy(x => x.OrderNum);

            string strCondition_CMClass = string.Format(" {0}='1' and {1}='{2}' order by {3}",
                                                                conCMClass.IsOpen,
                                                                conCMClass.PrjId,
                                                                strPrjId,
                                                                conCMClass.ClsName);
            if (string.IsNullOrEmpty(strPrjId))
            {
                strCondition_CMClass = string.Format(" {0}='1' order by {1}",
                                                                conCMClass.IsOpen,
                                                                conCMClass.ClsName);
            }
            List<clsvCMClassEN> arrCMClassObjList = clsvCMClassBL.GetObjLst(strCondition_CMClass).OrderBy(x => x.ClsName).ToList();
            List<CodeTypeIdNameSpace> arrNameSpace = arrCMClassObjList.Select(x => new CodeTypeIdNameSpace()
            {
                CodeTypeId = x.CodeTypeId,
                NameSpace = x.NameSpace
            }).Distinct(new NameSpaceComparer()).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnNameSpace = null;
            TreeNode tnCMClass = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有类";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objAppCodeTypeRelaEN.ApplicationTypeId) continue;

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);

                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    foreach (CodeTypeIdNameSpace objNameSpace in arrNameSpace)  //CodeType
                    {
                        if (objNameSpace.CodeTypeId != objAppCodeTypeRelaEN.CodeTypeId) continue;


                        //tnNameSpace = getTreeNodeByTabObj(objCodeType);
                        tnNameSpace = new TreeNode();
                        tnNameSpace.Value = string.Format("NameSpace,{0}",
                                                                objNameSpace.NameSpace);
                        tnNameSpace.Text = objNameSpace.NameSpace;

                        tnCodeType.ChildNodes.Add(tnNameSpace);
                        //List<string> arrText = new List<string>();
                        foreach (clsvCMClassEN objCMClass in arrCMClassObjList)  //CMClass
                        {
                            if (objCMClass.CodeTypeId != objNameSpace.CodeTypeId) continue;
                            if (objCMClass.NameSpace != objNameSpace.NameSpace) continue;
                            if (objCMClass.FuncNum == 0) continue;
                            tnCMClass = getTreeNodeByTabObj(objCMClass);
                            //if (string.IsNullOrEmpty(objCMClass.CmClassId) == true)
                            //{
                            tnCMClass.Text = string.Format("{0}({2})-{1}",
                                objCMClass.ClsName, objCMClass.UserId, objCMClass.FuncNum);
                            //}

                            //arrText.Add(tnCMClass.Text);
                            tnNameSpace.ChildNodes.Add(tnCMClass);
                        }
                        if (tnNameSpace.ChildNodes.Count == 0)
                        {
                            tnCodeType.ChildNodes.Remove(tnNameSpace);
                        }
                    }
                    if (tnCodeType.ChildNodes.Count == 0)
                    {
                        tnApplicationType.ChildNodes.Remove(tnCodeType);
                    }
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }
            //if (tnRoot.ChildNodes.Count == 0)
            //{
            //    tnRoot.ChildNodes.Remove(tnApplicationType);
            //}


            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CodeType_NameSpace_CMClass(TreeView objTV, string strPrjId, string strUserId, bool bolDispNoFunctionClass = false)
        {
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);
            string strCondition_CodeType = string.Format("1=1  order by {0}",
                                      convAppCodeTypeRela.OrderNum);
            IEnumerable<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLstCache()//strCondition_CodeType);                
                .OrderBy(x => x.OrderNum);

            string strCondition_CMClass = string.Format(" {0}='1' ",
                                                            conCMClass.IsOpen);

            if (string.IsNullOrEmpty(strPrjId) == false)
            {
                strCondition_CMClass += string.Format(" and {0}='{1}' ",
                                                                    conCMClass.PrjId,
                                                                    strPrjId);
            }
            if (string.IsNullOrEmpty(strUserId) == false)
            {
                strCondition_CMClass += string.Format(" and {0}='{1}' ",
                                                                    conCMClass.UserId,
                                                                    strUserId);
            }
            IEnumerable<clsvCMClassEN> arrCMClassObjList = clsvCMClassBL.GetObjLst(strCondition_CMClass).OrderBy(x => x.ClsName);
            List<CodeTypeIdNameSpace> arrNameSpace = arrCMClassObjList.Select(x => new CodeTypeIdNameSpace()
            {
                CodeTypeId = x.CodeTypeId,
                NameSpace = x.NameSpace
            }).Distinct(new NameSpaceComparer()).OrderBy(x => x.NameSpace).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnNameSpace = null;
            TreeNode tnCMClass = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有类";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objAppCodeTypeRelaEN.ApplicationTypeId) continue;

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);

                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    foreach (CodeTypeIdNameSpace objNameSpace in arrNameSpace)  //CodeType
                    {
                        if (objNameSpace.CodeTypeId != objAppCodeTypeRelaEN.CodeTypeId) continue;
                        IEnumerable<clsvCMClassEN> arrCMClassObjList_Sel = null;
                        if (bolDispNoFunctionClass == true)
                        {
                            arrCMClassObjList_Sel = arrCMClassObjList.Where(x => x.CodeTypeId == objNameSpace.CodeTypeId
                                && x.NameSpace == objNameSpace.NameSpace);
                        }
                        else
                        {
                            arrCMClassObjList_Sel = arrCMClassObjList.Where(x => x.CodeTypeId == objNameSpace.CodeTypeId
                                && x.NameSpace == objNameSpace.NameSpace
                                && x.FuncNum > 0);
                        }
                        if (arrCMClassObjList_Sel.Count() == 0) continue;

                        //tnNameSpace = getTreeNodeByTabObj(objCodeType);
                        tnNameSpace = new TreeNode();
                        tnNameSpace.Value = string.Format("NameSpace,{0}",
                                                                objNameSpace.NameSpace);
                        tnNameSpace.Text = objNameSpace.NameSpace;

                        tnCodeType.ChildNodes.Add(tnNameSpace);
                        //List<string> arrText = new List<string>();
                        foreach (clsvCMClassEN objCMClass in arrCMClassObjList_Sel)  //CMClass
                        {
                            //if (objCMClass.CodeTypeId != objNameSpace.CodeTypeId) continue;
                            //if (objCMClass.NameSpace != objNameSpace.NameSpace) continue;
                            //if (objCMClass.FuncNum == 0) continue;
                            tnCMClass = getTreeNodeByTabObj(objCMClass);
                            //if (string.IsNullOrEmpty(objCMClass.CmClassId) == true)
                            //{
                            tnCMClass.Text = string.Format("{0}({2})-{1}",
                                objCMClass.ClsName, objCMClass.UserId, objCMClass.FuncNum);
                            //}

                            //arrText.Add(tnCMClass.Text);
                            tnNameSpace.ChildNodes.Add(tnCMClass);
                        }
                        //if (tnNameSpace.ChildNodes.Count == 0)
                        //{
                        //    tnCodeType.ChildNodes.Remove(tnNameSpace);
                        //}
                    }
                    if (tnCodeType.ChildNodes.Count == 0)
                    {
                        tnApplicationType.ChildNodes.Remove(tnCodeType);
                    }
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }
            //if (tnRoot.ChildNodes.Count == 0)
            //{
            //    tnRoot.ChildNodes.Remove(tnApplicationType);
            //}


            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CMProject_FuncModule_Agc4Requirement(TreeView objTV, string strPrjId, string strUserId, bool bolDispNoFunctionClass = false)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) throw new Exception("PrjId不能为空！");

            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);


            //string strCondition_CMProject = string.Format(" {0}='{1}' ",
            //                                                conCMProject.UseStateId, enumUseState.InUse_0001);


            //    strCondition_CMProject += string.Format(" and {0}='{1}' ",
            //                                                        conCMProject.PrjId,
            //                                                        strPrjId);


            List<clsCMProjectEN> arrCMProject = clsCMProjectBL.GetObjLstCache();
            IEnumerable<clsCMProjectEN> arrCMProjectObjList = arrCMProject.Where(x => x.PrjId == strPrjId).OrderBy(x => x.CmPrjName);

            //string strCondition_FuncModule = string.Format(" {0} in (Select {0} from {1}) ",
            //                                                conFuncModule_Agc.FuncModuleAgcId,
            //                                                conCMRequirement._CurrTabName);

            IEnumerable<clsCMRequirementEN> arrCMRequirement_Cache = clsCMRequirementBL.GetObjLstCache(strPrjId);
            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_Cache = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);
            IEnumerable<string> arrFuncModuleAgcId = null;
            if (string.IsNullOrEmpty(strUserId) == false)
            {
                arrFuncModuleAgcId = arrCMRequirement_Cache
                    .Where(x => x.UpdUser == strUserId)
                    .Select(x => x.FuncModuleAgcId);
            }
            else
            {
                arrFuncModuleAgcId = arrCMRequirement_Cache
                    .Select(x => x.FuncModuleAgcId);
            }

            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = arrFuncModule_Cache
                .Where(x => arrFuncModuleAgcId.Contains(x.FuncModuleAgcId))
                .OrderBy(x => x.FuncModuleName);

            TreeNode tnRoot = new TreeNode();
            TreeNode tnCMProject = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFuncModule_Agc = null;

            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有需求";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                IEnumerable<clsCMProjectEN> arrCMProjectObjList_Sel = arrCMProjectObjList
                    .Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId)
                    .OrderBy(x => x.CmPrjName);
                if (arrCMProjectObjList_Sel.Count() == 0) continue;

                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsCMProjectEN objCMProjectEN in arrCMProjectObjList_Sel)  //CMProject
                {
                    tnCMProject = getTreeNodeByTabObj(objCMProjectEN);
                    IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList_Sel = arrFuncModule_AgcObjList
                        .Where(x => x.PrjId == objCMProjectEN.PrjId)
                        .OrderBy(x => x.FuncModuleName);
                    if (arrFuncModule_AgcObjList_Sel.Count() == 0) continue;

                    tnApplicationType.ChildNodes.Add(tnCMProject);
                    foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList_Sel)  //CMProject
                    {
                        tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);
                        tnCMProject.ChildNodes.Add(tnFuncModule_Agc);
                    }
                    if (tnCMProject.ChildNodes.Count == 0)
                    {
                        tnApplicationType.ChildNodes.Remove(tnCMProject);
                    }
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }



            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ApplicationType_CMProject_FuncModule_Agc4Feature(TreeView objTV, string strPrjId, string strUserId, bool bolDispNoFunctionClass = false)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                throw new Exception("工程Id不能为空！");
            }
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);


            string strCondition_CMProject = string.Format(" {0}='{1}' ",
                                                            conCMProject.UseStateId, enumUseState.InUse_0001);

            if (string.IsNullOrEmpty(strPrjId) == false)
            {
                strCondition_CMProject += string.Format(" and {0}='{1}' ",
                                                                    conCMProject.PrjId,
                                                                    strPrjId);
            }
            List<clsCMProjectEN> arrCMProject = clsCMProjectBL.GetObjLstCache();
            IEnumerable<clsCMProjectEN> arrCMProjectObjList = arrCMProject.Where(x => x.PrjId == strPrjId).OrderBy(x => x.CmPrjName);

            //string strCondition_FuncModule = string.Format(" {0} in (Select {0} from {1}) ",
            //                                                conFuncModule_Agc.FuncModuleAgcId,
            //                                                conCMFeature._CurrTabName);

            IEnumerable<clsCMFeatureEN> arrCMFeature_Cache = clsCMFeatureBL.GetObjLstCache(strPrjId);
            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_Cache = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);
            IEnumerable<string> arrFuncModuleAgcId = null;
            if (string.IsNullOrEmpty(strUserId) == false)
            {
                arrFuncModuleAgcId = arrCMFeature_Cache
                    .Where(x => x.UpdUser == strUserId)
                    .Select(x => x.FuncModuleAgcId);
            }
            else
            {
                arrFuncModuleAgcId = arrCMFeature_Cache
                    .Select(x => x.FuncModuleAgcId);
            }
            //if (string.IsNullOrEmpty(strUserId) == false)
            //{
            //    strCondition_FuncModule = string.Format(" {0} in (Select {0} from {1} Where {2}='{3}') ",
            //                                                conFuncModule_Agc.FuncModuleAgcId,
            //                                                conCMFeature._CurrTabName,
            //                                                        conCMFeature.UpdUser,
            //                                                        strUserId);
            //}
            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = arrFuncModule_Cache
                .Where(x => arrFuncModuleAgcId.Contains(x.FuncModuleAgcId))
                .OrderBy(x => x.FuncModuleName);

            //string strCondition_Feature = string.Format(" {0} in (Select {0} from {1} Where {2}='{3}') ",
            //                                           conCMFeature.CmPrjId,
            //                                           conCMProject._CurrTabName,
            //                                                   conCMProject.PrjId,
            //                                                   strPrjId);

            IEnumerable<clsCMFeatureEN> arrCMFeature = clsCMFeatureBL.GetObjLstCache(strPrjId)
                .OrderBy(x => x.OrderNum);



            TreeNode tnRoot = new TreeNode();
            TreeNode tnCMProject = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFuncModule_Agc = null;
            TreeNode tnCMFeature = null;
            TreeNode tnCMFeature_Sub = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有需求";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                IEnumerable<clsCMProjectEN> arrCMProjectObjList_Sel = arrCMProjectObjList
                    .Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId)
                    .OrderBy(x => x.CmPrjName);
                if (arrCMProjectObjList_Sel.Count() == 0) continue;

                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsCMProjectEN objCMProjectEN in arrCMProjectObjList_Sel)  //CMProject
                {
                    tnCMProject = getTreeNodeByTabObj(objCMProjectEN);
                    IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList_Sel = arrFuncModule_AgcObjList
                        .Where(x => x.PrjId == objCMProjectEN.PrjId)
                        .OrderBy(x => x.FuncModuleName);
                    if (arrFuncModule_AgcObjList_Sel.Count() == 0) continue;

                    tnApplicationType.ChildNodes.Add(tnCMProject);
                    foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList_Sel)  //CMProject
                    {
                        tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                        IEnumerable<clsCMFeatureEN> arrCMFeature_Sel = arrCMFeature
                                .Where(x => x.FuncModuleAgcId == objFuncModule_Agc.FuncModuleAgcId
                                            && x.CmPrjId == objCMProjectEN.CmPrjId)
                                .OrderBy(x => x.OrderNum);
                        if (arrCMFeature_Sel.Count() == 0) continue;
                        tnCMProject.ChildNodes.Add(tnFuncModule_Agc);

                        IEnumerable<clsCMFeatureEN> arrCMFeature_Sel_Parent = arrCMFeature_Sel
                                .Where(x => string.IsNullOrEmpty(x.CmParentFeatureId) == true)
                                .OrderBy(x => x.OrderNum);
                        IEnumerable<clsCMFeatureEN> arrCMFeature_Sel_Sub = arrCMFeature_Sel
                             .Where(x => string.IsNullOrEmpty(x.CmParentFeatureId) == false)
                             .OrderBy(x => x.OrderNum);

                        foreach (clsCMFeatureEN objCMFeature in arrCMFeature_Sel_Parent)  //CMProject
                        {
                            tnCMFeature = getTreeNodeByTabObj(objCMFeature);
                            tnFuncModule_Agc.ChildNodes.Add(tnCMFeature);
                            foreach (clsCMFeatureEN objCMFeature_Sub in arrCMFeature_Sel_Sub)  //CMProject
                            {
                                if (objCMFeature_Sub.CmParentFeatureId != objCMFeature.CmFeatureId) continue;
                                tnCMFeature_Sub = getTreeNodeByTabObj(objCMFeature_Sub);
                                tnCMFeature.ChildNodes.Add(tnCMFeature_Sub);
                            }
                            //IEnumerable<clsCMFeatureEN> arrCMFeature_Sel = arrCMFeature
                            //        .Where(x => x.FuncModuleAgcId == objFuncModule_Agc.FuncModuleAgcId)
                            //        .OrderBy(x => x.OrderNum);
                            //if (arrCMFeature_Sel.Count() == 0) continue;

                        }
                    }
                    if (tnCMProject.ChildNodes.Count == 0)
                    {
                        tnApplicationType.ChildNodes.Remove(tnCMProject);
                    }
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }



            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ApplicationType_CMProject_FuncModule_PrjTab(TreeView objTV, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                throw new Exception("工程Id不能为空！");
            }
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);


            string strCondition_CMProject = string.Format(" {0}='{1}' ",
                                                            conCMProject.UseStateId, enumUseState.InUse_0001);

            if (string.IsNullOrEmpty(strPrjId) == false)
            {
                strCondition_CMProject += string.Format(" and {0}='{1}' ",
                                                                    conCMProject.PrjId,
                                                                    strPrjId);
            }
            List<clsCMProjectEN> arrCMProject = clsCMProjectBL.GetObjLstCache();
            IEnumerable<clsCMProjectEN> arrCMProjectObjList = arrCMProject
                .Where(x => x.PrjId == strPrjId).
                OrderBy(x => x.CmPrjName);

            //string strCondition_FuncModule = string.Format(" {0} = '{1}' ",
            //                                                  conFuncModule_Agc.PrjId,
            //                                                  strPrjId);

            List<clsFuncModule_AgcEN> arrFuncModule_Agc = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);
            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = arrFuncModule_Agc
                .Where(x => x.PrjId == strPrjId)
                .OrderBy(x => x.FuncModuleName);

            string strCondition_vCMProjectPrjTab = string.Format(" {0} = '{1}' ",
                                                       convCMProjectPrjTab.PrjId,
                                                       strPrjId);

            IEnumerable<clsvCMProjectPrjTabEN> arrvCMProjectPrjTab = clsvCMProjectPrjTabBL.GetObjLst(strCondition_vCMProjectPrjTab)
                .OrderBy(x => x.TabName);



            TreeNode tnRoot = new TreeNode();
            TreeNode tnCMProject = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFuncModule_Agc = null;
            TreeNode tnvCMProjectPrjTab = null;
            //TreeNode tnvCMProjectPrjTab_Sub = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有需求";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                IEnumerable<clsCMProjectEN> arrCMProjectObjList_Sel = arrCMProjectObjList
                    .Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId)
                    .OrderBy(x => x.CmPrjName);
                if (arrCMProjectObjList_Sel.Count() == 0) continue;

                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsCMProjectEN objCMProjectEN in arrCMProjectObjList_Sel)  //CMProject
                {
                    tnCMProject = getTreeNodeByTabObj(objCMProjectEN);
                    IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjList_Sel = arrFuncModule_AgcObjList
                        .Where(x => x.PrjId == objCMProjectEN.PrjId)
                        .OrderBy(x => x.FuncModuleName);
                    if (arrFuncModule_AgcObjList_Sel.Count() == 0) continue;

                    tnApplicationType.ChildNodes.Add(tnCMProject);
                    foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList_Sel)  //CMProject
                    {
                        tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                        IEnumerable<clsvCMProjectPrjTabEN> arrvCMProjectPrjTab_Sel = arrvCMProjectPrjTab
                                .Where(x => x.FuncModuleAgcId == objFuncModule_Agc.FuncModuleAgcId)
                                .OrderBy(x => x.TabName);
                        if (arrvCMProjectPrjTab_Sel.Count() == 0) continue;
                        tnCMProject.ChildNodes.Add(tnFuncModule_Agc);


                        foreach (clsvCMProjectPrjTabEN objvCMProjectPrjTab in arrvCMProjectPrjTab_Sel)  //CMProject
                        {
                            tnvCMProjectPrjTab = getTreeNodeByTabObj(objvCMProjectPrjTab);
                            tnvCMProjectPrjTab.Text = string.Format("{0}({1})",
                                objvCMProjectPrjTab.TabName, objvCMProjectPrjTab.TabId);
                            tnFuncModule_Agc.ChildNodes.Add(tnvCMProjectPrjTab);
                        }
                    }
                    //if (tnCMProject.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCMProject);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }



            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CMProject_FuncModule(TreeView objTV, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                throw new Exception("工程Id不能为空！");
            }
            object myParent = objTV.Parent;
            wucTreeView myTreeView = (wucTreeView)myParent;
            bool bolIsUseJsEvent = myTreeView.IsUseJsEvent;
            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            IEnumerable<clsApplicationTypeEN> arrApplicationTypeObjLst = clsApplicationTypeBL.GetObjLstCache().Where(x => x.IsVisible == true).OrderBy(x => x.OrderNum);


            string strCondition_CMProject = string.Format(" {0}='{1}' ",
                                                            conCMProject.UseStateId, enumUseState.InUse_0001);

            if (string.IsNullOrEmpty(strPrjId) == false)
            {
                strCondition_CMProject += string.Format(" and {0}='{1}' ",
                                                                    conCMProject.PrjId,
                                                                    strPrjId);
            }
            List<clsCMProjectEN> arrCMProject = clsCMProjectBL.GetObjLstCache();
            IEnumerable<clsCMProjectEN> arrCMProjectObjList = arrCMProject
                .Where(x => x.PrjId == strPrjId).
                OrderBy(x => x.CmPrjName);


            string strCondition_vCMProjectFuncModule = string.Format(" {0} = '{1}' ",
                                                       convCMProjectFuncModule.PrjId,
                                                       strPrjId);

            IEnumerable<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModule = clsvCMProjectFuncModuleBL.GetObjLst(strCondition_vCMProjectFuncModule)
                .OrderBy(x => x.FuncModuleName);



            TreeNode tnRoot = new TreeNode();
            TreeNode tnCMProject = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            //TreeNode tnFuncModule_Agc = null;
            TreeNode tnvCMProjectFuncModule = null;
            //TreeNode tnvCMProjectFuncModule_Sub = null;
            //            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            tnRoot.Value = "Root,0000";
            tnRoot.Text = "所有需求";
            objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjLst) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                IEnumerable<clsCMProjectEN> arrCMProjectObjList_Sel = arrCMProjectObjList
                    .Where(x => x.ApplicationTypeId == objApplicationType.ApplicationTypeId)
                    .OrderBy(x => x.CmPrjName);
                if (arrCMProjectObjList_Sel.Count() == 0) continue;

                tnRoot.ChildNodes.Add(tnApplicationType);

                foreach (clsCMProjectEN objCMProjectEN in arrCMProjectObjList_Sel)  //CMProject
                {
                    tnCMProject = getTreeNodeByTabObj(objCMProjectEN);
                    IEnumerable<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModule_Sel = arrvCMProjectFuncModule
                        .Where(x => x.CmPrjId == objCMProjectEN.CmPrjId)
                        .OrderBy(x => x.FuncModuleName);
                    //   if (arrvCMProjectFuncModule_Sel.Count() == 0) continue;

                    tnApplicationType.ChildNodes.Add(tnCMProject);


                    foreach (clsvCMProjectFuncModuleEN objvCMProjectFuncModule in arrvCMProjectFuncModule_Sel)  //CMProject
                    {
                        tnvCMProjectFuncModule = getTreeNodeByTabObj(objvCMProjectFuncModule);
                        tnvCMProjectFuncModule.Text = string.Format("{0}({1})",
                            objvCMProjectFuncModule.FuncModuleName, objvCMProjectFuncModule.FuncModuleAgcId);
                        tnCMProject.ChildNodes.Add(tnvCMProjectFuncModule);
                    }

                    //if (tnCMProject.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCMProject);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnRoot.ChildNodes.Remove(tnApplicationType);
                }
            }



            //			objTV.ExpandAll();
            try
            {
                objTV.ExpandDepth = 2;
                objTV.Nodes[0].Expand();
                if (objTV.Nodes[0].ChildNodes.Count > 0)
                {
                    objTV.Nodes[0].ChildNodes[0].Expand();
                }
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }



        public static void Bindtv_ApplicationType_CodeType_Function4GeneCode4View(TreeView objTV,
       string strDependsOn, string strFunctionTemplateId, string strViewId, string strPrjId)
        {

            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_ApplicationType = string.Format("{0}='1'  order by {1}",
                                     conApplicationType.IsVisible,
                                     conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='{1}'  order by {2}",
                                      convAppCodeTypeRela.DependsOn, strDependsOn,
                                      convAppCodeTypeRela.OrderNum);
            List<clsvAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLst(strCondition_CodeType);

            string strCondition_Function4GeneCode = string.Format(" {0}='1' and {1} in (select {1} from {2} where {3}='{4}') order by {5}",
                                                                conFunction4GeneCode.InUse,
                                                                conFunction4GeneCode.FuncId4GC,
                                                                conFunctionTemplateRela._CurrTabName,
                                                                conFunctionTemplateRela.FunctionTemplateId,
                                                                strFunctionTemplateId,
                                                                conFunction4GeneCode.OrderNum);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(strCondition_Function4GeneCode);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFunction4GeneCode = null;
            //TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            //foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            //{
            //    tnProgLangType = getTreeNodeByTabObj(objProgLangType);
            //    objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                //if (objApplicationType.ProgLangTypeId != objProgLangType.ProgLangTypeId
                //    && objApplicationType.ProgLangTypeId2 != objProgLangType.ProgLangTypeId
                //    && objApplicationType.ProgLangTypeId3 != objProgLangType.ProgLangTypeId
                //    ) continue;
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN in arrAppCodeTypeRelaObjList)  //CodeType
                {
                    if (objApplicationType.ApplicationTypeId != objvAppCodeTypeRelaEN.ApplicationTypeId) continue;
                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objvAppCodeTypeRelaEN.CodeTypeId);

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strViewId) == false)
                    {
                        string strClassName = clsCodeTypeBLEx.GetClassNameByViewId(objCodeType.CodeTypeId,
                            strViewId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}({2})", objCodeType._NameValue,
                            strClassName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);

                    foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)  //Function4GeneCode
                    {

                        if (objFunction4GeneCode.FuncCodeTypeId != objCodeType.CodeTypeId) continue;

                        tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                        clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4GeneCode.FuncGCTypeId);
                        if (string.IsNullOrEmpty(objFunction4GeneCode.FuncId4Code) == true)
                        {
                            tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
                                objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCode._NameValue);
                        }
                        else
                        {
                            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4GeneCode.FuncId4Code);
                            if (objFunction4CodeEN != null)
                            {
                                tnFunction4GeneCode.Text = string.Format("{0}:{1}",
                                    objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue, objFunction4GeneCode._NameValue);
                                tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCode._NameValue);
                            }
                        }
                        tnCodeType.ChildNodes.Add(tnFunction4GeneCode);
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnApplicationType);
                }
            }
            //if (tnProgLangType.ChildNodes.Count == 0)
            //{
            //    objTV.Nodes.Remove(tnProgLangType);
            //}


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ApplicationType_CodeType_PrjFeature_vFeatureFuncRela4View(TreeView objTV,
             string strFunctionTemplateId, string strViewId, string strPrjId)
        {

            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_ApplicationType = string.Format("{0} = (select {0} from {1} where {2}='{3}')",
                                     conApplicationType.ApplicationTypeId,
                                     conViewInfo._CurrTabName,
                                     conViewInfo.ViewId, strViewId);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='View'  order by {1}",
                                      conCodeType.DependsOn,
                                      conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            string strCondition_PrjFeature = string.Format("{0} in (select {0} from {1} where {2}='{3}') order by {4}",
                                        conPrjFeature.FeatureId,
                                      convFeatureRegionFlds._CurrTabName,
                                      convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                                      conPrjFeature.OrderNum);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);


            string strCondition_vFeatureFuncRela = string.Format(" {0} in (select {0} from {1} where {2}='{3}') order by {4}",
                                                                convFeatureFuncRela.FuncId4Code,
                                                                conFunctionTemplateRela._CurrTabName,
                                                                conFunctionTemplateRela.FunctionTemplateId,
                                                                strFunctionTemplateId,
                                                                convFeatureFuncRela.OrderNum);
            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLst(strCondition_vFeatureFuncRela);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnvFeatureFuncRela = null;
            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);


            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strViewId) == false)
                    {
                        string strClassName = clsCodeTypeBLEx.GetClassNameByViewId(objCodeType.CodeTypeId,
                            strViewId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}", objCodeType._NameValue,
                            strClassName);
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);

                    foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //vFeatureFuncRela
                    {
                        clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFeatureFuncRela.FuncId4Code);
                        tnvFeatureFuncRela = getTreeNodeByTabObj(objFunction4CodeEN);
                        clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4CodeEN.FuncGCTypeId);
                        if (string.IsNullOrEmpty(objvFeatureFuncRela.FuncId4Code) == true)
                        {
                            tnvFeatureFuncRela.Text = string.Format("{0}(?)-{1}",
                                objFuncGCTypeEN.FuncGCTypeName, objvFeatureFuncRela._NameValue);
                        }
                        else
                        {
                            if (objFunction4CodeEN != null)
                            {
                                tnvFeatureFuncRela.Text = string.Format("{0}:{1}",
                                    objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue,
                                    objvFeatureFuncRela._NameValue);
                                tnvFeatureFuncRela.ToolTip = string.Format("原函数:{0}", objvFeatureFuncRela._NameValue);
                            }
                        }
                        tnCodeType.ChildNodes.Add(tnvFeatureFuncRela);
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnProgLangType.ChildNodes.Remove(tnApplicationType);
                }
            }
            //if (tnProgLangType.ChildNodes.Count == 0)
            //{
            //    objTV.Nodes.Remove(tnProgLangType);
            //}


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        //public static void Bindtv_ApplicationType_CodeType_PrjFeature(TreeView objTV, string strPrjId)
        //{
        //    object myParent = objTV.Parent;
        //    wucTreeView myTreeView = (wucTreeView)myParent;
        //    int intApplicationTypeId = myTreeView.ApplicationTypeId;

        //    //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
        //    //                            conProgLangType.IsVisible,
        //    //                            conProgLangType.OrderNum);
        //    //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
        //    string strCondition_ApplicationType = string.Format(" 1=1 and {0}='1'", conApplicationType.IsVisible);

        //    if (intApplicationTypeId > 0)
        //    {
        //        strCondition_ApplicationType += string.Format("{0} = {1} ",
        //                                 conApplicationType.ApplicationTypeId,
        //                                 intApplicationTypeId);
        //    }
        //    List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
        //    string strCondition_CodeType = string.Format("1=1");

        //    List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjList = clsvAppCodeTypeRelaBL.GetObjLst(strCondition_CodeType);

        //    string strCondition_PrjFeature = string.Format("{0} in ('{1}','{2}')",
        //                                conPrjFeature.FeatureId,
        //                              enumPrjFeatureType.FrontInterface_01,
        //                              enumPrjFeatureType.TabFeature_03);
        //    List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);



        //    TreeNode tnRoot = new TreeNode();
        //    TreeNode tnCodeType = null, tnPrjFeature = null; //,tnRange = null;
        //    TreeNode tnApplicationType = null;
        //    TreeNode tnFunction4GeneCode = null;

        //    objTV.Nodes.Clear();

        //    //tnRoot.Value = "Root,0000";
        //    //tnRoot.Text = "上海师范大学";
        //    //objTV.Nodes.Add(tnRoot);


        //    foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
        //    {
        //        tnApplicationType = getTreeNodeByTabObj(objApplicationType);
        //        objTV.Nodes.Add(tnApplicationType);

        //        IEnumerable<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRela_Sub = arrvAppCodeTypeRelaObjList.Where(x=>x.ApplicationTypeId == objApplicationType.ApplicationTypeId);
        //        foreach (clsvAppCodeTypeRelaEN objCodeType in arrvAppCodeTypeRela_Sub)  //CodeType
        //        {
        //            //if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

        //            tnCodeType = getTreeNodeByTabObj(objCodeType);
        //            tnCodeType.Text = string.Format("{0}", objCodeType.CodeTypeName);

        //            tnApplicationType.ChildNodes.Add(tnCodeType);

        //            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
        //            {
        //                tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);

        //                tnCodeType.ChildNodes.Add(tnPrjFeature);
        //                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //Function4GeneCode
        //                {

        //                    if (objPrjFeature.FeatureId != objvFeatureFuncRela.FeatureId) continue;
        //                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFeatureFuncRela.FuncId4GC);

        //                    if (objvFeatureFuncRela.CodeTypeId != objCodeType.CodeTypeId) continue;

        //                    clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code);
        //                    tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCodeEN);
        //                    clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4CodeEN.FuncGCTypeId);
        //                    if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4Code) == true)
        //                    {
        //                        tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
        //                            objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCodeEN._NameValue);
        //                    }
        //                    else
        //                    {
        //                        if (objFunction4CodeEN != null)
        //                        {
        //                            tnFunction4GeneCode.Text = string.Format("{0}:{1}",
        //                                objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue);
        //                            tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCodeEN._NameValue);
        //                        }
        //                    }
        //                    tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

        //                }
        //                if (tnPrjFeature.ChildNodes.Count == 0)
        //                {
        //                    tnCodeType.ChildNodes.Remove(tnPrjFeature);
        //                }
        //            }
        //            //if (tnCodeType.ChildNodes.Count == 0)
        //            //{
        //            //    tnApplicationType.ChildNodes.Remove(tnCodeType);
        //            //}
        //        }
        //        //if (tnApplicationType.ChildNodes.Count == 0)
        //        //{
        //        //    tnProgLangType.ChildNodes.Remove(tnApplicationType);
        //        //}

        //    }
        //    //if (tnProgLangType.ChildNodes.Count == 0)
        //    //{
        //    //    objTV.Nodes.Remove(tnProgLangType);
        //    //}


        //    //			objTV.ExpandAll();
        //    try
        //    {
        //        if (objTV.Nodes.Count == 0) return;
        //        objTV.Nodes[0].Select();
        //    }
        //    catch (Exception objException)
        //    {
        //        throw objException;
        //    }
        //}


        public static void Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View(TreeView objTV,
       string strFunctionTemplateId, string strViewId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strViewId) == true)
            {
                string strMsg = string.Format("strViewId为空, 不能给定相关树！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(strFunctionTemplateId) == true)
            {
                string strMsg = string.Format("strFunctionTemplateId为空, 不能给定相关树！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_ApplicationType = string.Format("{0} = (select {0} from {1} where {2}='{3}')[exclude]select [/exclude]",
                                     conApplicationType.ApplicationTypeId,
                                     conViewInfo._CurrTabName,
                                     conViewInfo.ViewId, strViewId);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='View'  order by {1}",
                                      conCodeType.DependsOn,
                                      conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);


            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);


            string strCondition_PrjFeature = string.Format("{0} in (select {0} from {1} where {2} in ({3})) order by {4}",
                                        conPrjFeature.FeatureId,
                                      convFeatureRegionFlds._CurrTabName,
            convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                                      conPrjFeature.OrderNum);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);


            string strCondition_vFeatureFuncRela = string.Format(" {0} in (select {0} from {1} where {2} in ({3})) order by {4}",
                                                                convFeatureFuncRela.FeatureId,
                                                                convFeatureRegionFlds._CurrTabName,
                                                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                                                                convFeatureFuncRela.OrderNum);
            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLst(strCondition_vFeatureFuncRela);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null, tnPrjFeature = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFunction4GeneCode = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);


            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strViewId) == false)
                    {
                        string strClassName = clsCodeTypeBLEx.GetClassNameByViewId(objCodeType.CodeTypeId,
                            strViewId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}", objCodeType._NameValue,
                            strClassName);
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);
                    foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
                    {
                        tnPrjFeature = getTreeNodeByTabObj(objPrjFeature);

                        tnCodeType.ChildNodes.Add(tnPrjFeature);
                        foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //Function4GeneCode
                        {

                            if (objPrjFeature.FeatureId != objvFeatureFuncRela.FeatureId) continue;
                            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFeatureFuncRela.FuncId4GC);

                            if (objvFeatureFuncRela.FuncCodeTypeId != objCodeType.CodeTypeId) continue;

                            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code);
                            tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCodeEN);
                            clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4CodeEN.FuncGCTypeId);
                            if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4Code) == true)
                            {
                                tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
                                    objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCodeEN._NameValue);
                            }
                            else
                            {
                                if (objFunction4CodeEN != null)
                                {
                                    tnFunction4GeneCode.Text = string.Format("{0}:{1}",
                                        objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue);
                                    tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCodeEN._NameValue);
                                }
                            }
                            tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

                        }
                        if (tnPrjFeature.ChildNodes.Count == 0)
                        {
                            tnCodeType.ChildNodes.Remove(tnPrjFeature);
                        }
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                //if (tnApplicationType.ChildNodes.Count == 0)
                //{
                //    tnProgLangType.ChildNodes.Remove(tnApplicationType);
                //}

            }
            //if (tnProgLangType.ChildNodes.Count == 0)
            //{
            //    objTV.Nodes.Remove(tnProgLangType);
            //}


            //			objTV.ExpandAll();
            try
            {
                if (objTV.Nodes.Count == 0) return;
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ApplicationType_CodeType_Function4GeneCode4View(TreeView objTV,
                  string strFunctionTemplateId, string strViewId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strViewId) == true)
            {
                string strMsg = string.Format("strViewId为空, 不能给定相关树！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(strFunctionTemplateId) == true)
            {
                string strMsg = string.Format("strFunctionTemplateId为空, 不能给定相关树！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            //string strCondition_ProgLangType = string.Format("{0}='1'  order by {1}",
            //                            conProgLangType.IsVisible,
            //                            conProgLangType.OrderNum);
            //List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_ApplicationType = string.Format("{0} = (select {0} from {1} where {2}='{3}')[exclude]select [/exclude]",
                                     conApplicationType.ApplicationTypeId,
                                     conViewInfo._CurrTabName,
                                     conViewInfo.ViewId, strViewId);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='View'  order by {1}",
                                      conCodeType.DependsOn,
                                      conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            string strCondition_PrjFeature = string.Format("{0} in (select {0} from {1} where {2}='{3}') order by {4}",
                                        conPrjFeature.FeatureId,
                                      convFeatureRegionFlds._CurrTabName,
                                        convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),

                                      conPrjFeature.OrderNum);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);


            string strCondition_Function4GeneCode = string.Format(" {0} in (select {0} from {1} where {2}='{3}') order by {4}",
                                                                conFunction4GeneCode.FuncId4GC,
                                                                conFunctionTemplateRela._CurrTabName,
                                                                conFunctionTemplateRela.FunctionTemplateId,
                                                                strFunctionTemplateId,
                                                                conFunction4GeneCode.OrderNum);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(strCondition_Function4GeneCode);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFunction4GeneCode = null;
            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);


            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    if (string.IsNullOrEmpty(strViewId) == false)
                    {
                        string strClassName = clsCodeTypeBLEx.GetClassNameByViewId(objCodeType.CodeTypeId,
                           strViewId, strPrjId);
                        tnCodeType.Text = string.Format("{0}-{1}", objCodeType._NameValue,
                            strClassName);
                    }
                    tnApplicationType.ChildNodes.Add(tnCodeType);

                    foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)  //Function4GeneCode
                    {
                        if (objFunction4GeneCode.FuncCodeTypeId != objCodeType.CodeTypeId) continue;

                        clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4GeneCode.FuncId4Code);
                        tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                        clsFuncGCTypeEN objFuncGCTypeEN = clsFuncGCTypeBL.GetObjByFuncGCTypeIdCache(objFunction4CodeEN.FuncGCTypeId);
                        if (string.IsNullOrEmpty(objFunction4GeneCode.FuncId4Code) == true)
                        {
                            tnFunction4GeneCode.Text = string.Format("{0}(?)-{1}",
                                objFuncGCTypeEN.FuncGCTypeName, objFunction4GeneCode._NameValue);
                        }
                        else
                        {
                            if (objFunction4CodeEN != null)
                            {
                                tnFunction4GeneCode.Text = string.Format("{0}:{1}",
                                    objFuncGCTypeEN.FuncGCTypeName, objFunction4CodeEN._NameValue,
                                    objFunction4GeneCode._NameValue);
                                tnFunction4GeneCode.ToolTip = string.Format("原函数:{0}", objFunction4GeneCode._NameValue);
                            }
                        }
                        tnCodeType.ChildNodes.Add(tnFunction4GeneCode);
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    tnProgLangType.ChildNodes.Remove(tnApplicationType);
                }
            }
            //if (tnProgLangType.ChildNodes.Count == 0)
            //{
            //    objTV.Nodes.Remove(tnProgLangType);
            //}


            //			objTV.ExpandAll();
            try
            {
                if (objTV.Nodes.Count == 0) return;
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }




        public static void Bindtv_ApplicationType_CodeType_Function4GeneCodeBak(TreeView objTV,
                        string strDependsOn, string strFunctionTemplateId)
        {
            //string strCondition_ProgLangType = string.Format("{0}='{1}'  order by {1}",
            //                            conProgLangType.ProgLangTypeId,
            //                            conProgLangType.OrderNum);
            //clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeId(strProgLangTypeId);
            string strCondition_ApplicationType = string.Format("{0}='1'  order by {1}",
                                     conApplicationType.IsVisible,
                                     conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            string strCondition_CodeType = string.Format("{0}='{1}'  order by {2}",
                                      conCodeType.DependsOn, strDependsOn,
                                      conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);

            string strCondition_Function4GeneCode = string.Format(" {0}='1' and {1} in (select {1} from {2} where {3}='{4}') order by {5}",
                                                             conFunction4GeneCode.InUse,
                                                             conFunction4GeneCode.FuncId4GC,
                                                             conFunctionTemplateRela._CurrTabName,
                                                             conFunctionTemplateRela.FunctionTemplateId,
                                                             strFunctionTemplateId,
                                                             conFunction4GeneCode.OrderNum);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList = clsFunction4GeneCodeBL.GetObjLst(strCondition_Function4GeneCode);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnApplicationType = null;
            TreeNode tnFunction4GeneCode = null;
            //TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);

            //objTV.Nodes.Add(tnProgLangType);

            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getTreeNodeByTabObj(objApplicationType);
                objTV.Nodes.Add(tnApplicationType);

                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objApplicationType.ApplicationTypeId) == false) continue;

                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    tnApplicationType.ChildNodes.Add(tnCodeType);

                    foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)  //Function4GeneCode
                    {
                        string strFuncName = objFunction4GeneCode.FuncName;
                        if (strFuncName == "Gen_Controller_Java_btnClickfunGetRecCountByCond")
                        {
                            //string ss = "AA";
                        }

                        if (objFunction4GeneCode.FuncCodeTypeId != objCodeType.CodeTypeId) continue;

                        tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GeneCode);
                        tnCodeType.ChildNodes.Add(tnFunction4GeneCode);
                    }
                    //if (tnCodeType.ChildNodes.Count == 0)
                    //{
                    //    tnApplicationType.ChildNodes.Remove(tnCodeType);
                    //}
                }
                if (tnApplicationType.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnApplicationType);
                }
            }

            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ProgLangType_CodeType(TreeView objTV)
        {
            string strCondition_ProgLangType = string.Format(" {0}='1' order by {1}",
                                        conProgLangType.IsVisible,
                                        conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            string strCondition_CodeType = string.Format(" 1=1  order by {0}",
                                      conCodeType.OrderNum);

            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition_CodeType);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnCodeType = null; //,tnRange = null;
            TreeNode tnProgLangType = null;
            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            {
                tnProgLangType = getTreeNodeByTabObj(objProgLangType);

                objTV.Nodes.Add(tnProgLangType);


                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    if (clsCodeTypeBLEx.IsMatchLangType(objCodeType, objProgLangType.ProgLangTypeId) == false) continue;
                    tnCodeType = getTreeNodeByTabObj(objCodeType);
                    tnProgLangType.ChildNodes.Add(tnCodeType);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_FuncModule_Agc_PrjTab_ClassName_FuncName(TreeView objTV, string strPrjId)
        {
            string strCondition_FuncModule_Agc = string.Format(" {0}='0001' and {1}='{2}' order by {1}",
                                        conFuncModule_Agc.UseStateId,
                                        conFuncModule_Agc.PrjId, strPrjId,
                                        conFuncModule_Agc.OrderNum);

            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLst(strCondition_FuncModule_Agc);
            string strCondition_PrjTab = string.Format(" {0}='{1}' and {2}='{3}' order by {4}",
                                        conPrjTab.TabStateId,
                                        "01",
                                        conPrjTab.PrjId, strPrjId,
                                        conPrjTab.TabName);

            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLst(strCondition_PrjTab);

            string strCondition_ClassName = string.Format(" {0}='{1}' order by {2}",
                                    conFunction4Code.PrjId, strPrjId,
                                    conFunction4Code.FuncName4Code);

            List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition_ClassName);
            IEnumerable<string> arrTabName = arrFunction4Code.Select(x => x.TabName);

            arrPrjTabObjList = arrPrjTabObjList.Where(x => arrTabName.Contains(x.TabName)).ToList();
            IEnumerable<string> arrFuncModuleId = arrPrjTabObjList.Select(x => x.FuncModuleAgcId);
            List<clsFuncModule_AgcEN> arrFuncModule_Agc = arrFuncModule_AgcObjList.Where(x => arrFuncModuleId.Contains(x.FuncModuleAgcId)).ToList();

            //var arrFunction4Code_Class = from x in arrFunction4Code
            //                             select new { TabName = x.TabName, ClassName = x.ClsName };

            var arrFunction4Code_Class = arrFunction4Code.Select(x => new { TabName = x.TabName, ClsName = x.ClsName })
                .Distinct().ToList();

            // clsFunction4CodeBL.GetObjLst(strCondition_ClassName);
            //            var arrFunction4Code_Class = arrFunction4Code.GroupBy(x => new { x.TabName, x.ClsName });// clsFunction4CodeBL.GetObjLst(strCondition_ClassName);
            //var groupList = personList.GroupBy(m => new { m.Name, m.Age }).
            //            Select(a => new
            //            {
            //                Name = a.Key.Name,
            //                Salary = a.Sum(c => c.Salary)
            //            }).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnPrjTab = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnFuncModule_Agc = null;
            TreeNode tnClassName = null;
            TreeNode tnFunctionName = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_Agc) //XzFuncModule_Agc
            {
                tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                objTV.Nodes.Add(tnFuncModule_Agc);


                foreach (clsPrjTabEN objPrjTab in arrPrjTabObjList)  //PrjTab
                {
                    if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnPrjTab = getTreeNodeByTabObj(objPrjTab);
                    tnFuncModule_Agc.ChildNodes.Add(tnPrjTab);
                    var arrFunction4Code_Class_Sel = arrFunction4Code_Class.Where(x => x.TabName == objPrjTab.TabName).ToList();
                    if (arrFunction4Code_Class_Sel.Count == 0) continue;
                    foreach (var objClassName in arrFunction4Code_Class_Sel)  //PrjTab
                    {
                        //if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                        tnClassName = new TreeNode();
                        tnClassName.Value = string.Format("{0},{1}",
                            "ClsName",
                            objClassName.ClsName);
                        tnClassName.Text = objClassName.ClsName;
                        tnPrjTab.ChildNodes.Add(tnClassName);

                        List<clsFunction4CodeEN> arrFunction4Code_Sel = arrFunction4Code
                            .Where(x => x.TabName == objPrjTab.TabName && x.ClsName == objClassName.ClsName).ToList();
                        if (arrFunction4Code_Sel.Count == 0) continue;
                        foreach (clsFunction4CodeEN objFunction4Code in arrFunction4Code_Sel)  //PrjTab
                        {
                            //if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                            tnFunctionName = getTreeNodeByTabObj(objFunction4Code);
                            string strFuncAccessModeName = clsFuncAccessModeBLEx.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId);
                            string strFunctionSignature = objFunction4Code.GetFunctionSignature();
                            string strHtml = string.Format("({0}){1}", strFuncAccessModeName, strFunctionSignature);
                            if (strFunctionSignature.Length > 60)
                            {
                                int intPos = strFunctionSignature.IndexOf("(");

                                string strFirstLine = strFunctionSignature.Substring(0, intPos);
                                string strSecondLine = strFunctionSignature.Substring(intPos);
                                strHtml = string.Format("({2}){0}<br/>{1}", strFirstLine, strSecondLine, strFuncAccessModeName);
                            }
                            tnFunctionName.Text = strHtml;
                            tnClassName.ChildNodes.Add(tnFunctionName);
                        }
                    }
                }
                if (tnFuncModule_Agc.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnFuncModule_Agc);
                }
            }


            //			objTV.ExpandAll();
            try
            {
                if (objTV.Nodes.Count > 0)
                {
                    objTV.Nodes[0].Select();
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_FuncModule_Agc_PrjTab_RegionName(TreeView objTV, string strPrjId, int intApplicationTypeId, string strRegionTypeId = "")
        {
            //string strCondition_FuncModule_Agc = string.Format(" {0}='0001' and {1}='{2}' order by {1}",
            //                            conFuncModule_Agc.UseStateId,
            //                            conFuncModule_Agc.PrjId, strPrjId,
            //                            conFuncModule_Agc.OrderNum);

            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLstCache(strPrjId)
                .Where(x => x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x => x.OrderNum)
                .ToList();

            //string strCondition_PrjTab = string.Format(" {0}='{1}' and {2}='{3}' order by {4}",
            //                            conPrjTab.TabStateId,
            //                            "01",
            //                            conPrjTab.PrjId, strPrjId,
            //                            conPrjTab.TabName);

            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLstCache(strPrjId)
                .Where(x => x.TabStateId == enumTabState.Normal_01)
                .OrderBy(x => x.TabName)
                .ToList();

            //string strCondition_RegionName = string.Format(" {0}='{1}' order by {2}",
            //                        conFunction4Code.PrjId, strPrjId,
            //                        conFunction4Code.FuncName4Code);

            IEnumerable<clsViewRegionEN> arrViewRegion0 = clsViewRegionBL.GetObjLstCache(strPrjId);
                
            if (string.IsNullOrEmpty(strRegionTypeId) == false)
            {
                arrViewRegion0 = arrViewRegion0.Where(x => x.RegionTypeId == strRegionTypeId);
            }
            List<clsvViewRegionRelaEN> arrViewRegionRela = clsvViewRegionRelaBL.GetObjLstCache(strPrjId).Where(x => x.ApplicationTypeId == intApplicationTypeId).ToList();

            List<clsViewRegionEN> arrViewRegion = arrViewRegion0
                                .OrderBy(x => x.RegionName).ToList();
            foreach (var objInFor in arrViewRegion)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, strPrjId);
                if (objPrjTab == null)
                {
                    objInFor._StrTag = objInFor.TabId;
                    continue;
                }
                if (string.IsNullOrEmpty(objPrjTab.RelaTabId4View) == false)
                {
                    objInFor._StrTag = objPrjTab.RelaTabId4View;
                }
                else
                {
                    objInFor._StrTag = objInFor.TabId;
                }
            }
            IEnumerable<string> arrFuncModuleId = arrPrjTabObjList.Select(x => x.FuncModuleAgcId);
            List<clsFuncModule_AgcEN> arrFuncModule_Agc = arrFuncModule_AgcObjList.Where(x => arrFuncModuleId.Contains(x.FuncModuleAgcId)).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnPrjTab = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnFuncModule_Agc = null;
            TreeNode tnRegionName = null;
            //TreeNode tnFunctionName = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_Agc) //XzFuncModule_Agc
            {
                tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                objTV.Nodes.Add(tnFuncModule_Agc);


                foreach (clsPrjTabEN objPrjTab in arrPrjTabObjList)  //PrjTab
                {
                    if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnPrjTab = getTreeNodeByTabObj(objPrjTab);
                    var arrViewRegion_Sel = arrViewRegion.Where(x => x._StrTag == objPrjTab.TabId).OrderBy(x => x.RegionName).ToList();
                    if (arrViewRegion_Sel.Count == 0) continue;
                    if (objPrjTab.TabName == "vXzClg")
                    {
                        //string strSS = "";
                    }
                    tnFuncModule_Agc.ChildNodes.Add(tnPrjTab);
                    foreach (var objRegionName in arrViewRegion_Sel)  //PrjTab
                    {
                        //if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                        tnRegionName = new TreeNode();

                        tnRegionName.Value = string.Format("{0},{1}",
                                objRegionName._TabName_Curr,
                            objRegionName._KeyId);
                        var arrViewRegionRela_Sel = arrViewRegionRela.Where(x => x.RegionId == objRegionName.RegionId).ToList();

                        tnRegionName.Text = string.Format("{0}({1}/{2})R:{4}", objRegionName.RegionName.Replace(objPrjTab.TabName, "{0}"),
                            objRegionName.FldCountInUse(), objRegionName.FldCount(),
                            clsDateTime.GetDateTime_Sim2(objRegionName.UpdDate),
                            arrViewRegionRela_Sel.Count);
                        var arrViewName = arrViewRegionRela_Sel.Select(x => x.ViewName).ToList();
                        var strViewNameList = "";
                        if (arrViewName.Count > 0)
                        {
                            strViewNameList = clsArray.GetSqlInStrByArray(arrViewName, false);
                        }

                        tnRegionName.ToolTip = string.Format("{0}(有用字段数:{1}/总字段数:{2})(被引用数:{4}, 界面列表:{5})", objRegionName.RegionName,
                                                objRegionName.FldCountInUse(), objRegionName.FldCount(),
                                                clsDateTime.GetDateTime_Sim2(objRegionName.UpdDate), arrViewRegionRela_Sel.Count, strViewNameList);

                        tnPrjTab.ChildNodes.Add(tnRegionName);
                    }
                }
                if (tnFuncModule_Agc.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnFuncModule_Agc);
                }
            }


            //			objTV.ExpandAll();
            try
            {
                if (objTV.Nodes.Count > 0)
                {
                    objTV.Nodes[0].Select();
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_PrjTab_RegionName(TreeView objTV, string strPrjId, int intApplicationTypeId, string strRegionTypeId = "")
        {

            //List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLstCache(strPrjId)
            //    .Where(x => x.UseStateId == enumUseState.InUse_0001)
            //    .OrderBy(x => x.OrderNum)
            //    .ToList();

            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLstCache(strPrjId)
                .Where(x => x.TabStateId == enumTabState.Normal_01)
                .OrderBy(x => x.TabName)
                .ToList();
            string strCmPrjId = clsUserDefaValue_LocalBLEx.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认CM工程");

            if (string.IsNullOrEmpty( clsPubVar.CurrCmPrjId) == true)
            {
                clsPubVar.CurrCmPrjId = strCmPrjId;
            }
            IEnumerable<clsViewRegionEN> arrViewRegion0 = clsViewRegionBL.GetObjLstCache(clsPubVar.CurrSelPrjId);
            if (string.IsNullOrEmpty(strRegionTypeId) == false)
            {
                arrViewRegion0 = arrViewRegion0.Where(x => x.RegionTypeId == strRegionTypeId);
            }
            List<clsvViewRegionRelaEN> arrViewRegionRela = clsvViewRegionRelaBL.GetObjLstCache(clsPubVar.CurrSelPrjId).Where(x => x.ApplicationTypeId == intApplicationTypeId).ToList();

            List<clsViewRegionEN> arrViewRegion = arrViewRegion0
                                .OrderBy(x => x.RegionName).ToList();
            foreach (var objInFor in arrViewRegion)
            {
                if (objInFor.RegionId == "0000016803")
                {
                    //string ss = "";
                }
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, strPrjId);
                if (objPrjTab == null)
                {
                    objInFor._StrTag = objInFor.TabId;
                    continue;
                }
                if (string.IsNullOrEmpty(objPrjTab.RelaTabId4View) == false)
                {
                    objInFor._StrTag = objPrjTab.RelaTabId4View;
                }
                else
                {
                    objInFor._StrTag = objInFor.TabId;
                }
            }
            //IEnumerable<string> arrFuncModuleId = arrPrjTabObjList.Select(x => x.FuncModuleAgcId);
            //List<clsFuncModule_AgcEN> arrFuncModule_Agc = arrFuncModule_AgcObjList.Where(x => arrFuncModuleId.Contains(x.FuncModuleAgcId)).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnPrjTab = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            //TreeNode tnFuncModule_Agc = null;
            TreeNode tnRegionName = null;
            //TreeNode tnFunctionName = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            //foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_Agc) //XzFuncModule_Agc
            //{
            //    tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

            //    objTV.Nodes.Add(tnFuncModule_Agc);


            foreach (clsPrjTabEN objPrjTab in arrPrjTabObjList)  //PrjTab
            {
                //if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                tnPrjTab = getTreeNodeByTabObj(objPrjTab);
                var arrViewRegion_Sel = arrViewRegion.Where(x => x._StrTag == objPrjTab.TabId).OrderBy(x => x.RegionName).ToList();
                if (arrViewRegion_Sel.Count == 0) continue;
                if (objPrjTab.TabName == "vXzClg")
                {
                    //string strSS = "";
                }
                objTV.Nodes.Add(tnPrjTab);
                foreach (var objRegionName in arrViewRegion_Sel)  //PrjTab
                {
                    //if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnRegionName = new TreeNode();

                    tnRegionName.Value = string.Format("{0},{1}",
                            objRegionName._TabName_Curr,
                        objRegionName._KeyId);
                    var arrViewRegionRela_Sel = arrViewRegionRela.Where(x => x.RegionId == objRegionName.RegionId).ToList();

                    tnRegionName.Text = string.Format("{0}({1}/{2})R:{4}", objRegionName.ClsName.Replace(objPrjTab.TabName, "{0}"),
                        objRegionName.FldCountInUse(), objRegionName.FldCount(),
                        clsDateTime.GetDateTime_Sim2(objRegionName.UpdDate),
                        arrViewRegionRela_Sel.Count);
                    var arrViewName = arrViewRegionRela_Sel.Select(x => x.ViewName).ToList();
                    var strViewNameList = "";
                    if (arrViewName.Count > 0)
                    {
                        strViewNameList = clsArray.GetSqlInStrByArray(arrViewName, false);
                    }

                    tnRegionName.ToolTip = string.Format("{0}(有用字段数:{1}/总字段数:{2})(被引用数:{4}, 界面列表:{5})", objRegionName.ClsName,
                                            objRegionName.FldCountInUse(), objRegionName.FldCount(),
                                            clsDateTime.GetDateTime_Sim2(objRegionName.UpdDate), arrViewRegionRela_Sel.Count, strViewNameList);

                    tnPrjTab.ChildNodes.Add(tnRegionName);
                }
            }
            //if (tnFuncModule_Agc.ChildNodes.Count == 0)
            //{
            //    objTV.Nodes.Remove(tnFuncModule_Agc);
            //}
            //}


            //			objTV.ExpandAll();
            try
            {
                if (objTV.Nodes.Count > 0)
                {
                    objTV.Nodes[0].Select();
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_FuncModule_Agc_ViewInfo_RegionName(TreeView objTV, string strPrjId, int intApplicationTypeId, string strRegionTypeId = "")
        {
            //string strCondition_FuncModule_Agc = string.Format(" {0}='0001' and {1}='{2}' order by {1}",
            //                            conFuncModule_Agc.UseStateId,
            //                            conFuncModule_Agc.PrjId, strPrjId,
            //                            conFuncModule_Agc.OrderNum);
            //string strPrjId0 = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLstCache(strPrjId)
                .Where(x => x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x => x.OrderNum)
                .ToList();

            //string strCondition_ViewInfo = string.Format(" {0}='{1}' and {2}='{3}' order by {4}",
            //                            conViewInfo.TabStateId,
            //                            "01",
            //                            conViewInfo.PrjId, strPrjId,
            //                            conViewInfo.TabName);
        
            List<clsViewInfoEN> arrViewInfoObjList = clsViewInfoBL.GetObjLstCache(strPrjId)
                .Where(x => x.ApplicationTypeId == intApplicationTypeId && x.PrjId == strPrjId)
                .OrderBy(x => x.ViewName)
                .ToList();

            //string strCondition_RegionName = string.Format(" {0}='{1}' order by {2}",
            //                        conFunction4Code.PrjId, strPrjId,
            //                        conFunction4Code.FuncName4Code);

            List<clsvViewRegionRelaEN> arrViewRegionRela = clsvViewRegionRelaBL.GetObjLstCache(strPrjId)
                                .OrderBy(x => x.ClsName).ToList();

            //.Where(x => x.ApplicationTypeId == intApplicationTypeId);
            //if (string.IsNullOrEmpty(strRegionTypeId) == false)
            //{
            //    arrViewRegionRela0 = arrViewRegionRela0.Where(x => x.RegionTypeId == strRegionTypeId);
            //}


            IEnumerable<string> arrFuncModuleId = arrViewInfoObjList.Select(x => x.FuncModuleAgcId);
            List<clsFuncModule_AgcEN> arrFuncModule_Agc = arrFuncModule_AgcObjList.Where(x => arrFuncModuleId.Contains(x.FuncModuleAgcId)).ToList();

            TreeNode tnRoot = new TreeNode();
            TreeNode tnViewInfo = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnFuncModule_Agc = null;
            TreeNode tnRegionName = null;
            //TreeNode tnFunctionName = null;


            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_Agc) //XzFuncModule_Agc
            {
                tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                objTV.Nodes.Add(tnFuncModule_Agc);


                foreach (clsViewInfoEN objViewInfo in arrViewInfoObjList)  //ViewInfo
                {
                    if (objViewInfo.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnViewInfo = getTreeNodeByTabObj(objViewInfo);
                    tnFuncModule_Agc.ChildNodes.Add(tnViewInfo);
                    var arrViewRegionRela_Sel = arrViewRegionRela.Where(x => x.ViewId == objViewInfo.ViewId).OrderBy(x => x.ClsName).ToList();
                    if (arrViewRegionRela_Sel.Count == 0) continue;

                    foreach (var objViewRegionRela in arrViewRegionRela_Sel)  //ViewInfo
                    {
                        //if (objViewInfo.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                        var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(objViewRegionRela.RegionId, strPrjId);
                        if (objViewRegion == null) continue;
                        tnRegionName = new TreeNode();
                        tnRegionName = getTreeNodeByTabObj(objViewRegion);
                        tnRegionName.Value = string.Format("{0},{1}",
                                objViewRegion._TabName_Curr,
                            objViewRegion._KeyId);
                        var arrViewRegionRela_Sel_Count = arrViewRegionRela.Where(x => x.RegionId == objViewRegion.RegionId).ToList();


                        var objPrjTab_Out = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.OutRelaTabId, objViewRegion.PrjId());
                        tnRegionName.Text = string.Format("{0}({1}/{2})R:{3}", objViewRegion.ClsName.Replace(objPrjTab_Out.TabName, "{0}"),
                            objViewRegion.FldCountInUse(), objViewRegion.FldCount(), arrViewRegionRela_Sel_Count.Count);

                        var objPrjTab_In = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.InRelaTabId, objViewRegion.PrjId());
                        tnRegionName.Text = string.Format("{0}({1}/{2})R:{3}", objViewRegion.ClsName.Replace(objPrjTab_In.TabName, "{0}"),
                            objViewRegion.FldCountInUse(), objViewRegion.FldCount(), arrViewRegionRela_Sel_Count.Count);

                        var arrViewName = arrViewRegionRela_Sel_Count.Select(x => x.ViewName).ToList();
                        var strViewNameList = "无";
                        if (arrViewName.Count > 0)
                        {
                            strViewNameList = clsArray.GetSqlInStrByArray(arrViewName, false);
                        }
                        tnRegionName.ToolTip = string.Format("{0}(有用字段数:{1}/总字段数:{2})(被引用数:{3}, 界面列表:{4})", objViewRegion.ClsName,
                            objViewRegion.FldCountInUse(), objViewRegion.FldCount(), arrViewRegionRela_Sel.Count, strViewNameList);

                        tnViewInfo.ChildNodes.Add(tnRegionName);
                    }
                }
                if (tnFuncModule_Agc.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnFuncModule_Agc);
                }
            }


            //			objTV.ExpandAll();
            if (objTV.Nodes.Count == 0) return;
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_FuncModule_Agc_PrjTab(TreeView objTV, string strPrjId)
        {
            string strCondition_FuncModule_Agc = string.Format(" {0}='0001' and {1}='{2}' order by {1}",
                                        conFuncModule_Agc.UseStateId,
                                        conFuncModule_Agc.PrjId, strPrjId,
                                        conFuncModule_Agc.OrderNum);

            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLst(strCondition_FuncModule_Agc);
            string strCondition_PrjTab = string.Format(" {0}='{1}' and {2}='{3}' order by {4}",
                                        conPrjTab.TabStateId,
                                        "01",
                                        conPrjTab.PrjId, strPrjId,
                                        conPrjTab.TabName);

            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLst(strCondition_PrjTab);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnPrjTab = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnFuncModule_Agc = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList) //XzFuncModule_Agc
            {
                tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                objTV.Nodes.Add(tnFuncModule_Agc);


                foreach (clsPrjTabEN objPrjTab in arrPrjTabObjList)  //PrjTab
                {
                    if (objPrjTab.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnPrjTab = getTreeNodeByTabObj(objPrjTab);
                    tnFuncModule_Agc.ChildNodes.Add(tnPrjTab);

                }
                if (tnFuncModule_Agc.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnFuncModule_Agc);
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_FuncModule_Agc_ViewInfo(TreeView objTV, string strPrjId)
        {
            string strCondition_FuncModule_Agc = string.Format(" {0}='0001' and {1}='{2}' order by {1}",
                                        conFuncModule_Agc.UseStateId,
                                        conFuncModule_Agc.PrjId, strPrjId,
                                        conFuncModule_Agc.OrderNum);

            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = clsFuncModule_AgcBL.GetObjLst(strCondition_FuncModule_Agc);
            string strCondition_ViewInfo = string.Format(" 1=1 and {2}='{3}' order by {4}",
                                        conViewInfo.DataBaseName,
                                        "01",
                                        conViewInfo.PrjId, strPrjId,
                                        conViewInfo.ViewName);

            List<clsViewInfoEN> arrViewInfoObjList = clsViewInfoBL.GetObjLst(strCondition_ViewInfo);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnViewInfo = null;//, tnXzGrade = null, tnExamBatch = null; //,tnRange = null;
            TreeNode tnFuncModule_Agc = null;

            objTV.Nodes.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objTV.Nodes.Add(tnRoot);
            foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList) //XzFuncModule_Agc
            {
                tnFuncModule_Agc = getTreeNodeByTabObj(objFuncModule_Agc);

                objTV.Nodes.Add(tnFuncModule_Agc);


                foreach (clsViewInfoEN objViewInfo in arrViewInfoObjList)  //ViewInfo
                {
                    if (objViewInfo.FuncModuleAgcId != objFuncModule_Agc.FuncModuleAgcId) continue;
                    tnViewInfo = getTreeNodeByTabObj(objViewInfo);
                    tnFuncModule_Agc.ChildNodes.Add(tnViewInfo);

                }
                if (tnFuncModule_Agc.ChildNodes.Count == 0)
                {
                    objTV.Nodes.Remove(tnFuncModule_Agc);
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ViewInfo_PrjFeature_Function4Code(TreeView objTV, string strViewId, string strPrjId)
        {
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            string strCondition_FeatureRegionFlds = string.Format(" {0}='{1}'  order by {2}",
                                        convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                                        convFeatureRegionFlds.SeqNum);
            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);

            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjList = clsvFeatureRegionFldsBL.GetObjLst(strCondition_FeatureRegionFlds);
            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId("1=1", objViewInfoEN.ApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4Code = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;
            objTV.Nodes.Clear();

            tnRoot = getTreeNodeByTabObj(objViewInfoEN);
            //tnRoot.Text = "上海师范大学";
            objTV.Nodes.Add(tnRoot);
            foreach (clsvFeatureRegionFldsEN objFeatureRegionFlds in arrvFeatureRegionFldsObjList) //XzFeatureRegionFlds
            {
                clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFlds.FeatureId);
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeatureEN);

                tnRoot.ChildNodes.Add(tnPrjFeature);


                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList)  //vFeatureFuncRela
                {
                    if (objvFeatureFuncRela.FeatureId != objFeatureRegionFlds.FeatureId) continue;
                    clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFeatureFuncRela.FuncId4Code);
                    tnFunction4Code = getTreeNodeByTabObj(objFunction4Code);


                    tnPrjFeature.ChildNodes.Add(tnFunction4Code);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public static void Bindtv_ViewInfo_PrjFeature_Function4GeneCode(TreeView objTV, string strViewId, string strPrjId)
        {
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            string strCondition_FeatureRegionFlds = string.Format(" {0} in ({1}) order by {2}",
                                        convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                                        convFeatureRegionFlds.SeqNum);
            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);

            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjList = clsvFeatureRegionFldsBL.GetObjLst(strCondition_FeatureRegionFlds);
            DataTable dtvFeatureFuncRela = clsvFeatureFuncRelaBLEx.GetDataTableByAppId("1=1", objViewInfoEN.ApplicationTypeId);

            List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList = clsvFeatureFuncRelaBL.GetObjLstFromDataTable(dtvFeatureFuncRela);


            TreeNode tnRoot = new TreeNode();
            TreeNode tnFunction4GeneCode = null; //,tnRange = null;
            TreeNode tnPrjFeature = null;
            objTV.Nodes.Clear();

            tnRoot = getTreeNodeByTabObj(objViewInfoEN);
            tnRoot.Text = string.Format("<h6>{0}</h6>", "界面-功能-函数列表");
            //tnRoot.Text = "上海师范大学";
            objTV.Nodes.Add(tnRoot);
            foreach (clsvFeatureRegionFldsEN objFeatureRegionFlds in arrvFeatureRegionFldsObjList) //XzFeatureRegionFlds
            {
                if (string.IsNullOrEmpty(objFeatureRegionFlds.FeatureId)) continue;
                clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFlds.FeatureId);
                tnPrjFeature = getTreeNodeByTabObj(objPrjFeatureEN);

                tnRoot.ChildNodes.Add(tnPrjFeature);

                List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjList_Sub = arrvFeatureFuncRelaObjList.FindAll(x => x.FeatureId == objFeatureRegionFlds.FeatureId);
                foreach (clsvFeatureFuncRelaEN objvFeatureFuncRela in arrvFeatureFuncRelaObjList_Sub)  //vFeatureFuncRela
                {
                    //if (objvFeatureFuncRela.FeatureId != objFeatureRegionFlds.FeatureId) continue;
                    clsFunction4GeneCodeEN objFunction4GC = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFeatureFuncRela.FuncId4GC);
                    tnFunction4GeneCode = getTreeNodeByTabObj(objFunction4GC);

                    tnPrjFeature.ChildNodes.Add(tnFunction4GeneCode);

                    //if (tnXzGrade.ChildNodes.Count == 0)
                    //{
                    //    tnCourse.ChildNodes.Remove(tnXzGrade);
                    //}
                }
            }


            //			objTV.ExpandAll();
            try
            {
                objTV.Nodes[0].Select();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        private static TreeNode getTreeNodeByTabObj(clsEntityBase2 objTabObj)
        {
            if (string.IsNullOrEmpty(objTabObj._KeyId) == true)
            {
                string strMsg = string.Format("在绑定树的过程中，表对象({0})的关键字为空！", objTabObj._TabName_Curr);
                throw new Exception(strMsg);
            }
            TreeNode objTN = new TreeNode();
            objTN.Value = string.Format("{0},{1}",
                    objTabObj._TabName_Curr,
                    objTabObj._KeyId);
            objTN.Text = objTabObj._NameValue;
            return objTN;
        }
        //教学计划公共必修课模式

    }
}