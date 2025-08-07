using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	public partial class clsRegionTypeBLEx 
	{
        //public const string
        //    QUERYREGION = "0001",
        //    FUNCTIONREGION = "0008",
        //    DGREGION = "0002",
        //    EDITREGION = "0003",
        //    LISTVIEWREGION = "0004",
        //    TREEVIEWREGION = "0005",
        //    DETAILREGION = "0006",
        //    EXCELEXPORT_REGION = "0007";

		

		public static System.Data.DataTable GetRegionTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select RegionTypeId, RegionTypeName from RegionType ";
			clsSpecSQLforSql mySql = new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
        //public static void BindCbo_RegionTypeId(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //为数据源为表的下拉框设置内容
        //    System.Data.DataTable objDT = GetRegionTypeId();
        //    clsRegionTypeEN objRegionType;
        //    //初始化一个对象列表
        //    ArrayList RegionTypeList = new ArrayList();
        //    //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
        //    objRegionType = new clsRegionTypeEN();
        //    objRegionType.RegionTypeId = "0";
        //    objRegionType.RegionTypeName = "请选择...";
        //    RegionTypeList.Add(objRegionType);
        //    //把DataTable中的所有项均加到对象列表中
        //    foreach(DataRow objRow in objDT.Rows)
        //    {
        //        objRegionType = new clsRegionTypeEN();
        //        objRegionType.RegionTypeId = objRow["RegionTypeId"].ToString();
        //        objRegionType.RegionTypeName = objRow["RegionTypeName"].ToString();
        //        RegionTypeList.Add(objRegionType);
        //    }
        //    //设置下拉框的数据源、以及设置值项、显示项
        //    objComboBox.DataSource = RegionTypeList;
        //    objComboBox.ValueMember = "RegionTypeId";
        //    objComboBox.DisplayMember = "RegionTypeName";
        //    objComboBox.SelectedIndex = 0;
        //}

		///绑定下拉框的函数 代码
        //public static void BindDdl_RegionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...","0");
        //    System.Data.DataTable objDT = GetRegionTypeId();
        //    objDDL.DataValueField = "RegionTypeId";
        //    objDDL.DataTextField = "RegionTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能:根据界面上查询控件中所设置内容查询表记录,
		///			 并显示在ListView中。
		/// </summary>
		public static int BindLv_RegionType(System.Windows.Forms.ListView lvRegionType, string strWhereCond)
		{
			//操作步骤:(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviRegionType;
            List<clsRegionTypeEN> arrRegionTypeObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrRegionTypeObjList = clsRegionTypeBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvRegionType.Items.Clear();//清除原来所有Item
			lvRegionType.Columns.Clear();//清除原来所有列头信息
			lvRegionType.Columns.Add("区域类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.Columns.Add("区域类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsRegionTypeEN objRegionType in arrRegionTypeObjList)
			{
				lviRegionType = new System.Windows.Forms.ListViewItem();
				lviRegionType.Tag = objRegionType.RegionTypeId;
				lviRegionType.Text = objRegionType.RegionTypeId;
				lviRegionType.SubItems.Add(objRegionType.RegionTypeName);
				lviRegionType.SubItems.Add(objRegionType.Memo);
				lvRegionType.Items.Add(lviRegionType);
			}
			//	4、设置记录数的状态,
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrRegionTypeObjList.Count;
		}
	}
}