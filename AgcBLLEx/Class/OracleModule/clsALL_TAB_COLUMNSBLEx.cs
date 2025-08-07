using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdbfororacle;

using AGC.Entity;

namespace AGC.BusinessLogicEx
{
	public class clsALL_TAB_COLUMNSBLEx : clsALL_TAB_COLUMNSEN
	{

		public clsALL_TAB_COLUMNSBLEx(): base()
		{
		}

		public clsALL_TAB_COLUMNSBLEx(string strOwnerTable_Name): base(strOwnerTable_Name)
		{
		}

		public clsALL_TAB_COLUMNSBLEx(string strOwnerTable_Name, bool bolIsGetALL_TAB_COLUMNS) : base(strOwnerTable_Name,bolIsGetALL_TAB_COLUMNS)
		{
		}

		public static System.Data.DataTable GetALL_TAB_COLUMNSEx(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}
		public ArrayList GetALL_TAB_COLUMNSObjListEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select  concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS = new clsALL_TAB_COLUMNSEN();
				objALL_TAB_COLUMNS.OwnerTable_Name = objRow["OwnerTable_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Owner = objRow["Owner"].ToString().Trim();
				objALL_TAB_COLUMNS.Table_Name = objRow["Table_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Name = objRow["Column_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Type = objRow["Data_Type"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Precision = clsGeneralTab2.TransNullToInt_S(objRow["Data_Precision"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Scale = objRow["Data_Scale"].ToString().Trim();
				objALL_TAB_COLUMNS.Nullable = objRow["Nullable"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
				arrObjList.Add(objALL_TAB_COLUMNS);
			}
			objDT = null;
			return arrObjList;
		}



		///绑定下拉框的函数代码

		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在ListView中。
		/// </summary>
		//public static int BindLv_ALL_TAB_COLUMNS(System.Windows.Forms.ListView lvALL_TAB_COLUMNS, string strWhereCond)
		//{
		//	//操作步骤：(共4步)
		//	//	1、组合界面条件串；
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	//	3、设置ListView的列头信息
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	//		在本界面中是把状态显示在控件lblRecCount中。

		//	System.Windows.Forms.ListViewItem lviALL_TAB_COLUMNS; 
		//	ArrayList arrALL_TAB_COLUMNSObjList;
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	arrALL_TAB_COLUMNSObjList = clsALL_TAB_COLUMNSBL.GetALL_TAB_COLUMNSObjList(strWhereCond);
		//	//	3、设置ListView的列头信息
		//	lvALL_TAB_COLUMNS.Items.Clear();//清除原来所有Item
		//	lvALL_TAB_COLUMNS.Columns.Clear();//清除原来所有列头信息
		//	lvALL_TAB_COLUMNS.Columns.Add("拥有者表名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("表名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("列名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("数据长度", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("数据精度", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("Data_Scale", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("可空", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("列号", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.View = System.Windows.Forms.View.Details;
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	foreach (clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS in arrALL_TAB_COLUMNSObjList)
		//	{
		//		lviALL_TAB_COLUMNS = new System.Windows.Forms.ListViewItem();
		//		lviALL_TAB_COLUMNS.Tag = objALL_TAB_COLUMNS.OwnerTable_Name;
		//		lviALL_TAB_COLUMNS.Text = objALL_TAB_COLUMNS.OwnerTable_Name;
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Owner);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Table_Name);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Column_Name);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Type);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Length.ToString());
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Precision.ToString());
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Scale);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Nullable);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Column_Id.ToString());
		//		lvALL_TAB_COLUMNS.Items.Add(lviALL_TAB_COLUMNS);
		//	}
		//	//	4、设置记录数的状态，
		//	//		在本界面中是把状态显示在控件txtRecCount中。
		//	return arrALL_TAB_COLUMNSObjList.Count;
		//}
	}
}