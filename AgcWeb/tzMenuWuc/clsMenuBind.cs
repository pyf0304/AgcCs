using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.comm_db_obj;


using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace AGC.web.menu
{
    public partial class clsMenuBind
    {
        private Menu mobjMenu;

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

        public Menu objTreeView
        {
            get
            {
                return this.mobjMenu;

            }
            set
            {
                if (value != null)
                {
                    this.mobjMenu = value;
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
         
  
        public clsMenuBind()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public clsMenuBind(Menu objTreeView)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjMenu = objTreeView;

        }

        public clsMenuBind(Menu objTreeView, DataTable Level1DataSource, DataTable Level2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjMenu = objTreeView;
            this.mobjLevel1Dt = Level1DataSource;
            this.mobjLevel2Dt = Level2DataSource;

        }


        public clsMenuBind(Menu objTreeView,
            DataTable Level1DataSource, DataTable Level2DataSource,
            string Level1NameField, string Level1ValueField, string Level2NameField, string Level2ValueField, string Level1IDFieldInLevel2DataSource)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

            this.mobjMenu = objTreeView;
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
            this.BindTreeView(this.mobjMenu, this.mobjLevel1Dt, this.mobjLevel2Dt, this.mstrLevel1NameField, this.mstrLevel1ValueField, this.mstrLevel2NameField, this.mstrLevel2ValueField, this.mstrLevel1IDFieldInLevel2DataSource);
            this.mobjMenu.StaticDisplayLevels=2;
        }


        private void BindTreeView(Menu pobjTreeView,
            DataTable pLevel1DataSource, DataTable pLevel2DataSource,
            string pLevel1NameField, string pLevel1ValueField, string pLevel2NameField, string pLevel2ValueField, string pLevel1IDFieldInLevel2DataSource)
        {
            if (pobjTreeView != null
                && pLevel1DataSource != null && pLevel2DataSource != null
                && pLevel1NameField != "" && pLevel1ValueField != "" && pLevel2NameField != "" && pLevel2ValueField != "" && pLevel1IDFieldInLevel2DataSource != "")
            {



                DataTable objLevel1DataTable, objLevel2DataTable;
                MenuItem tnRoot, tnLevel1, tnLevel2;

                pobjTreeView.Items.Clear();

                tnRoot = new MenuItem();
                tnRoot.Value = "Root,0000";
                tnRoot.Text = this.mstrRootTitle;
                //mobjMenu.CheckBoxes = false;

                pobjTreeView.Items.Add(tnRoot);


                objLevel1DataTable = pLevel1DataSource;
                objLevel2DataTable = pLevel2DataSource;



                foreach (DataRow Level1Dr in objLevel1DataTable.Rows)
                {
                    string strLevel1Id = Level1Dr[pLevel1ValueField].ToString();
                    string strLevel1Name = Level1Dr[pLevel1NameField].ToString();

                    tnLevel1 = new MenuItem();
                    tnLevel1.Value = "Level1," + strLevel1Id;
                    tnLevel1.Text = strLevel1Name;
                    tnRoot.ChildItems.Add(tnLevel1);

                    DataRow[] DrRows = objLevel2DataTable.Select(string.Format(" {0} = '{1}'", pLevel1IDFieldInLevel2DataSource, strLevel1Id));

                    foreach (DataRow Level2Dr in DrRows)
                    {
                        string strLevel2Id = Level2Dr[pLevel2ValueField].ToString();
                        string strLevel2Name = Level2Dr[pLevel2NameField].ToString();

                        tnLevel2 = new MenuItem();
                        tnLevel2.Value = "Level2," + strLevel2Id;
                        tnLevel2.Text = strLevel2Name;
                        tnLevel1.ChildItems.Add(tnLevel2);

                    }

                }

            }

        }
                 
 
        public static string GetCurrKeyTypeName(Menu objTreeView)
        {
            string strTabName = "";
            string strTag = objTreeView.SelectedItem.Value.ToString();
            string[] strArr = strTag.Split(',');
            strTabName = strArr[0];
            return strTabName;
        }
        public static string GetCurrKeyTypeName(MenuItem objTN)
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
        public static string GetCurrKey(Menu objTreeView)
        {
            string strKeyId = "";
            string strTag = objTreeView.SelectedItem.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
        /// <summary>
        /// 获取当前结点的关键字
        /// </summary>
        /// <param name="objTN"></param>
        /// <returns></returns>
		public static string GetCurrKey(MenuItem objTN)
        {
            string strKeyId = "";
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            strKeyId = strArr[1];
            return strKeyId;
        }
             
   
        public static void Bindtv_PrjFeature(Menu objMenu)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}", 
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01, 
                conPrjFeature.FeatureName);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);

          
            //			List<clsXzClgEN> arrCollegeObjList = clsXzClgBL.GetObjLst(" id_College !='0000' order by CollegeID");

            MenuItem tnRoot = new MenuItem();
            //MenuItem tnCollege = null;      //,tnMajor = null,tnGrade = null,tnRange = null;
            MenuItem tnPrjFeature = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getMenuItemByTabObj(objPrjFeature);
            
                objMenu.Items.Add(tnPrjFeature);

            
            }

            //			objMenu.StaticDisplayLevels=2;
            objMenu.Items[0].Selected=true;
            objMenu.Items[0].Selected=true;
        }

        public static void Bindtv_PrjFeature_Function4Code(Menu objMenu)
        {
            string strCondition_PrjFeature = string.Format("{0}='{1}'  order by {2}",
                  conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01,
                  conPrjFeature.FeatureName);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = clsPrjFeatureBL.GetObjLst(strCondition_PrjFeature);
            List<clsFunction4CodeEN> arrFunction4CodeObjList = clsFunction4CodeBL.GetObjLst(" 1=1 ");
       

            MenuItem tnRoot = new MenuItem();
            MenuItem tnFunction4Code = null; //,tnRange = null;
            MenuItem tnPrjFeature = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList) //XzPrjFeature
            {
                tnPrjFeature = getMenuItemByTabObj(objPrjFeature);
                objMenu.Items.Add(tnPrjFeature);
                foreach (clsFunction4CodeEN objFunction4Code in arrFunction4CodeObjList)  //Function4Code
                {
                    tnFunction4Code = getMenuItemByTabObj(objFunction4Code);
                    tnPrjFeature.ChildItems.Add(tnFunction4Code);
                }//foreach (clsFunction4CodeEN

            }
        

            //			objMenu.StaticDisplayLevels=2;
            try
            {
                objMenu.Items[0].Selected=true;
            }
            catch (Exception objException)
            {
                throw objException;

            }
        }

        public static void Bindtv_ApplicationType_CodeType(Menu objMenu)
        {
            string strCondition_ApplicationType = string.Format("1=1  order by {0}",
                                        conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(" 1=1 ");


            MenuItem tnRoot = new MenuItem();
            MenuItem tnCodeType = null; //,tnRange = null;
            MenuItem tnApplicationType = null;
            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getMenuItemByTabObj(objApplicationType);

                objMenu.Items.Add(tnApplicationType);


                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    tnCodeType = getMenuItemByTabObj(objCodeType);
                    tnApplicationType.ChildItems.Add(tnCodeType);

                    //if (tnXzGrade.ChildItems.Count == 0)
                    //{
                    //    tnCourse.ChildItems.Remove(tnXzGrade);
                    //}
                }
            }


            //			objMenu.ExpandAll();
            try
            {
                objMenu.Items[0].Selected = true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ProgLangType_CodeType(Menu objMenu)
        {
            string strCondition_ProgLangType = string.Format("1=1  order by {0}",
                                        conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrProgLangTypeObjList = clsProgLangTypeBL.GetObjLst(strCondition_ProgLangType);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(" 1=1 ");


            MenuItem tnRoot = new MenuItem();
            MenuItem tnCodeType = null; //,tnRange = null;
            MenuItem tnProgLangType = null;

            objMenu.Items.Clear();

            //tnRoot.Value = "Root,0000";
            //tnRoot.Text = "上海师范大学";
            //objMenu.Items.Add(tnRoot);
            foreach (clsProgLangTypeEN objProgLangType in arrProgLangTypeObjList) //XzProgLangType
            {
                tnProgLangType = getMenuItemByTabObj(objProgLangType);

                objMenu.Items.Add(tnProgLangType);


                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    tnCodeType = getMenuItemByTabObj(objCodeType);
                    tnProgLangType.ChildItems.Add(tnCodeType);

                    //if (tnXzGrade.ChildItems.Count == 0)
                    //{
                    //    tnCourse.ChildItems.Remove(tnXzGrade);
                    //}
                }
            }


            //			objMenu.ExpandAll();
            try
            {
                objMenu.Items[0].Selected = true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static void Bindtv_ViewInfo_ApplicationType_CodeType(Menu objMenu, string strViewId)
        {
            string strCondition_ApplicationType = string.Format("1=1  order by {0}",
                                        conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strCondition_ApplicationType);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(" 1=1 ");
            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);


            MenuItem tnRoot = new MenuItem();
            MenuItem tnCodeType = null; //,tnRange = null;
            MenuItem tnApplicationType = null;
            objMenu.Items.Clear();

            tnRoot = getMenuItemByTabObj(objViewInfoEN);
            //tnRoot.Text = "上海师范大学";
            objMenu.Items.Add(tnRoot);
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList) //XzApplicationType
            {
                tnApplicationType = getMenuItemByTabObj(objApplicationType);

                objMenu.Items.Add(tnApplicationType);


                foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)  //CodeType
                {
                    tnCodeType = getMenuItemByTabObj(objCodeType);
                    tnApplicationType.ChildItems.Add(tnCodeType);

                    //if (tnXzGrade.ChildItems.Count == 0)
                    //{
                    //    tnCourse.ChildItems.Remove(tnXzGrade);
                    //}
                }
            }


            //			objMenu.ExpandAll();
            try
            {
                objMenu.Items[0].Selected = true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        private static MenuItem getMenuItemByTabObj(clsEntityBase2 objTabObj)
        {
            if (string.IsNullOrEmpty(objTabObj._KeyId) == true)
            {
                string strMsg = string.Format("在绑定树的过程中，表对象({0})的关键字为空！", objTabObj._TabName_Curr);
                throw new Exception(strMsg);
            }
            MenuItem objTN = new MenuItem();
            objTN.Value = string.Format("{0},{1}",
                    objTabObj._TabName_Curr,
                    objTabObj._KeyId);
            objTN.Text = objTabObj._NameValue;
            return objTN;
        }
       
     

    }
}