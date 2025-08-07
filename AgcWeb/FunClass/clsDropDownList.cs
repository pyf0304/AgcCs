using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
//using SqlSv; 
using com.taishsoft.commdb;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace AGC
{
    /// <summary>
    /// clsCommForWebForm 的摘要说明。
    /// </summary>
    public class clsDropDownList
    {
        public static string SystemStatus = "NDEBUG";		///主要存贮当前系统的状态

        public clsDropDownList()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

      




        public static System.Data.DataTable GetMajor(string strClgId)
        {
            //获取某学院所有专业信息
            string strSQL = "select Name, MajorId from Major where ClgId='" + strClgId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static System.Data.DataTable GetTaskTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TaskTypeId, RWLBMC from RWLBB ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_TaskTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTaskTypeId();
            objDDL.DataValueField = "TaskTypeId";
            objDDL.DataTextField = "RWLBMC";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BingDdl_Major(System.Web.UI.WebControls.DropDownList objDDL,
            string strClgId)
        {
            //为下拉框专业设置内容	
            ListItem li = new ListItem("请选择...", "请选择...");
            System.Data.DataTable objDT = GetMajor(strClgId);
            if (objDT.Rows.Count > 0)
            {
                objDDL.DataValueField = "MajorId";
                objDDL.DataTextField = "Name";
                objDDL.DataSource = objDT;
                objDDL.DataBind();
            }
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


      

        //public static void BindDdl_ObjTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    //System.Data.DataTable objDT = GetObjTypeId();
        //    List<clsObjectTypeEN> arrObjTypeENObjLst = clsObjectTypeBLEx.GetObjectTypeObjLstForBindDdl();
      
        //    objDDL.DataValueField = "ObjectTypeId";
        //    objDDL.DataTextField = "ObjectType";
        //    objDDL.DataSource = arrObjTypeENObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}


        //		public static void BingDdl_DsTabName1(clsDBServer objDBServer, System.Web.UI.WebControls.DropDownList objDDL)
        public static void BingDdl_DsTabName(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为下拉框专业设置内容	
            //			ListItem li=new ListItem("请选择...","请选择...");
            //			clsSqlEx objSql = new clsSqlEx();
            //			System.Data.DataTable objDT = objDBServer.getTables();
            //			if (objDT.Rows.Count >0 )
            //			{
            //				objDDL.DataValueField="name";
            //				objDDL.DataTextField="name";
            //				objDDL.DataSource = objDT;
            //				objDDL.DataBind();
            //			}
            //			objDDL.Items.Insert(0, li);
            //			objDDL.SelectedIndex = 0;

        }

        //		public static void BingDdl_DS_TabColumn1(clsDBServer objDBServer, string strTabName, System.Web.UI.WebControls.DropDownList objDDL)
        public static void BingDdl_DS_TabColumn1(string strTabName, System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为下拉框专业设置内容	
            //			ListItem li=new ListItem("请选择...","0");
            //			System.Data.DataTable objDT = objDBServer.getTabColumns(strTabName);
            //			if (objDT.Rows.Count >0 )
            //			{
            //				objDDL.DataValueField="Column_Name";
            //				objDDL.DataTextField="Column_Name";
            //				objDDL.DataSource = objDT;
            //				objDDL.DataBind();
            //			}
            //			objDDL.Items.Insert(0, li);
            //			objDDL.SelectedIndex = 0;

        }

       
        public static System.Data.DataTable GetDsDataValueField(string strTabId)
        {
            //获取某学院所有专业信息
            string strSQL = "select FldId, FldName from vPrjTabFld where TabId = '" + strTabId + "' order by FldName";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DsDataValueField(System.Web.UI.WebControls.DropDownList objDDL, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDsDataValueField(strTabId);
            objDDL.DataValueField = "FldName";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetDsDataTextField(string strTabId)
        {
            //获取某学院所有专业信息
            string strSQL = "select FldId, FldName from vPrjTabFld where TabId = '" + strTabId + "' order by FldName";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DsDataTextField(System.Web.UI.WebControls.DropDownList objDDL, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDsDataTextField(strTabId);
            objDDL.DataValueField = "FldName";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

     
        //public static void BindDdl_FldStateId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    //System.Data.DataTable objDT = GetFldStateId();
        //    List<clsFldStateEN> arrFldStateENObjLst = clsFldStateBLEx.GetFldStateObjLstForBindDdl();
        //    objDDL.DataValueField = "FldStateId";
        //    objDDL.DataTextField = "FldStateName";
        //    objDDL.DataSource = arrFldStateENObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}
       
        //public static void BindDdl_TabStateId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    //System.Data.DataTable objDT = GetTabStateId();
        //    List<clsTabStateEN> arrTabStateENObjLst = clsTabStateBLEx.GetTabStateObjLstForBindDdl();
        //    objDDL.DataValueField = "TabStateId";
        //    objDDL.DataTextField = "TabStateName";
        //    objDDL.DataSource = arrTabStateENObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

        public static System.Data.DataTable GetReturnTypeID()
        {
            //获取某学院所有专业信息
            string strSQL = "select distinct DataTypeId, CsType from vReturnType";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_ReturnTypeID(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetReturnTypeID();
            objDDL.DataValueField = "DataTypeId";
            objDDL.DataTextField = "CsType";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        //public static System.Data.DataTable GetViewTypeCode(int strApplicationTypeId)
        //{
        //    //01  Win应用程序 NULL
        //    //02  Web应用程序 NULL
        //    //03  JavaWeb应用程序 NULL
        //    //04  Web网站 NULL
        //    //05  MobileApp NULL
        //    //获取某学院所有专业信息
        //    string strCondition = "";
        //    switch (strApplicationTypeId)
        //    {
        //        case 1://Win应用程序
        //            strCondition = string.Format("{0}='1'", clsViewTypeCodeTabEN.con_IsWinApp);
        //            break;
        //        case 2://Web应用程序
        //            strCondition = string.Format("{0}='1'", clsViewTypeCodeTabEN.con_IsWebApp);
        //            break;
        //        case 5://MobileApp
        //            strCondition = string.Format("{0}='1'", clsViewTypeCodeTabEN.con_IsMobileApp);
        //            break;
        //    }

        //    string strSQL = string.Format("select ViewTypeCode, ViewTypeName from ViewTypeCodeTab where {0}", strCondition);
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void B1indDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL, int strApplicationTypeId)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    System.Data.DataTable objDT = GetViewTypeCode(strApplicationTypeId);
        //    objDDL.DataValueField = "ViewTypeCode";
        //    objDDL.DataTextField = "ViewTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}
       
        public static List<clsPrjTabEN> GetRelaTabId(string strSqlDsTypeId, string strPrjId)
        {
            List<clsPrjTabEN> arrvPrjTabObjLst = clsPrjTabBL.GetObjLstCache(strPrjId)
                .Where(x=>x.SqlDsTypeId == strSqlDsTypeId)
                .OrderBy(x=>x.TabName).ToList();
            //获取某学院所有专业信息
           
            return arrvPrjTabObjLst;
        }
        public static void BindDdl_RelaTabId(System.Web.UI.WebControls.DropDownList objDDL, string strSqlDsTypeId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetRelaTabId(strSqlDsTypeId, strPrjId);
            List<clsPrjTabEN> arrPrjTabObjLst = GetRelaTabId(strSqlDsTypeId, strPrjId);
            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = arrPrjTabObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void SetDdlValue(System.Web.UI.WebControls.DropDownList objDDL, string strValue)
        {
            for (int i = 0; i < objDDL.Items.Count; i++)
            {
                if (objDDL.Items[i].Value == strValue)
                {
                    objDDL.SelectedIndex = i;
                }
            }
        }

       
        public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetApplicationTypeId();
            List<clsApplicationTypeEN> arrApplicationTypeENObjLst = clsApplicationTypeBLEx.GetApplicationTypeObjLstForBindDdl();
        
            objDDL.DataValueField = "ApplicationTypeId";
            objDDL.DataTextField = "ApplicationTypeName";
            objDDL.DataSource = arrApplicationTypeENObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
   
 

       

        public static System.Data.DataTable GetDsDataPrjTabFld(string strTabId)
        {
            //获取某学院所有专业信息
            string strSQL = "select FldId, FldName from vPrjTabFld where TabId = '" + strTabId + "' order by FldName";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DsDataPrjTabFld(System.Web.UI.WebControls.DropDownList objDDL, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDsDataPrjTabFld(strTabId);
            objDDL.DataValueField = "FldId";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        //public static System.Data.DataTable GetSqlDsTypeId()
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void BindDdl_SqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    System.Data.DataTable objDT = GetSqlDsTypeId();
        //    objDDL.DataValueField = "SqlDsTypeId";
        //    objDDL.DataTextField = "SqlDsTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}
     
        
        public static  void BindDdl_OutSqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetOutSqlDsTypeId();
            List<clsSQLDSTypeEN> arrSQLDSTypeENObjLst = clsSQLDSTypeBLEx.GetSQLDSTypeObjLstForBindDdl();
        
            objDDL.DataValueField = "SqlDsTypeId";
            objDDL.DataTextField = "SqlDsTypeName";
            objDDL.DataSource = arrSQLDSTypeENObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_RegionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetRegionTypeId();
            List<clsRegionTypeEN> arrRegionTypeENObjLst = clsRegionTypeBLEx.GetRegionTypeObjLstForBindDdl();
        
            objDDL.DataValueField = "RegionTypeId";
            objDDL.DataTextField = "RegionTypeName";
            objDDL.DataSource = arrRegionTypeENObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
     
 
       
        public static void BindDdl_InOutTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetInOutTypeId();
            List<clsInOutTypeEN> arrInOutTypeENObjLst = clsInOutTypeBLEx.GetInOutTypeObjLstForBindDdl();
        
            objDDL.DataValueField = "InOutTypeId";
            objDDL.DataTextField = "InOutTypeName";
            objDDL.DataSource = arrInOutTypeENObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        //public static System.Data.DataTable GetPrjViewId(string strPrjId)
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = string.Format("select TabId, TabName1 from PrjTab where PrjId = '{0}' and SqlDsTypeId = '02' order by TabName", strPrjId);
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void BindDdl_PrjViewId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    System.Data.DataTable objDT = GetPrjViewId(strPrjId);
        //    objDDL.DataValueField = "TabId";
        //    objDDL.DataTextField = "TabName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

        //public static System.Data.DataTable GetPrjTabId(string strPrjId)
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = string.Format("select TabId, TabName1 from PrjTab where PrjId = '{0}' and SqlDsTypeId = '01' order by TabName", strPrjId);
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        ///// <summary>
        ///// 绑定表，不包含视图
        ///// </summary>
        ///// <param name="objDDL">需要绑定的下拉框</param>
        ///// <param name="strPrjId">工程Id</param>
        //public static void BindDdl_PrjTabId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    System.Data.DataTable objDT = GetPrjTabId(strPrjId);
        //    objDDL.DataValueField = "TabId";
        //    objDDL.DataTextField = "TabName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}




     
        public static void BindDdl_PrimaryTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //System.Data.DataTable objDT = GetPrimaryTypeId();
            List<clsPrimaryTypeEN> arrPrimaryTypeENObjLst = clsPrimaryTypeBLEx.GetPrimaryTypeObjLstForBindDdl();
            arrPrimaryTypeENObjLst = arrPrimaryTypeENObjLst.OrderBy(x=>x.OrderNum).ToList();
            objDDL.DataValueField = "PrimaryTypeId";
            objDDL.DataTextField = "PrimaryTypeName";
            objDDL.DataSource = arrPrimaryTypeENObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
        //public static void BindDdl_FldType(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    ListItem li = new ListItem("请选择...", "0");
        //    //System.Data.DataTable objDT = GetFldType();
        //    List<clsDataTypeAbbrEN> arrDataTypeAbbrENObjLst = clsDataTypeAbbrBLEx.GetDataTypeAbbrObjLstForBindDdl();
        //    objDDL.DataValueField = "DataTypeId";
        //    objDDL.DataTextField = "DataTypeName";
        //    objDDL.DataSource = arrDataTypeAbbrENObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}
        public static System.Data.DataTable GetDataBaseTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
        {
            objDDL.Items.Clear();
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }
        public static void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
        {
            objDDL.Items.Clear();
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }
        public static void BindDdl_TrueAndFalse(System.Web.UI.WebControls.DropDownList objDDL)
        {
            objDDL.Items.Clear();
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }

        public static void BindDdl_TrueOrFalse(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            ListItem li1 = new ListItem("是", "01");
            ListItem li2 = new ListItem("否", "00");

            objDDL.Items.Insert(0, li);
            objDDL.Items.Add(li1);
            objDDL.Items.Add(li2);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }


        public static System.Data.DataTable GetUpMenuId(string strPrjId)
        {
            //string PrjId = clsCommonSession.UserPrjId;
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from PrjMenus where UpMenuId = '00000000' and PrjId = '" + strPrjId + "' union select MenuId, MenuName from PrjMenus where MenuId = '00000000'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_UpMenuId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUpMenuId(strPrjId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

    }
}
