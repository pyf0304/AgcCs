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
	public class clsUser_Tab_ColumnsBLEx : clsUser_Tab_ColumnsEN
    {
        public clsUser_Tab_ColumnsBLEx(): base()
		{
        }

        public clsUser_Tab_ColumnsBLEx(string strTable_Name_Column_Name): base(strTable_Name_Column_Name)
		{
        }
        public clsUser_Tab_ColumnsBLEx(string server,string strSID,string uid,string pwd):base(server, strSID, uid, pwd)
		{

		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
		public System.Data.DataTable GetUser_Tab_ColumnsEx(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = null;
			if (this.IsHaveSpecialConnectString)
			{
				objSQL = new clsSpecSQLforOra(this.Server_Tz, this.SID, this.UserID, this.Password_Tz);
			}
			else
			{
				objSQL = new clsSpecSQLforOra();
			}
			strSQL = "Select  concat(Table_Name, Column_name) As Table_Name_Column_Name, User_Tab_Columns.* from User_Tab_Columns where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			
			return objDT;
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
		public ArrayList GetUser_Tab_ColumnsObjListEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = null;
			if (this.IsHaveSpecialConnectString)
			{
				objSQL = new clsSpecSQLforOra(this.Server_Tz, this.SID, this.UserID, this.Password_Tz);
			}
			else
			{
				objSQL = new clsSpecSQLforOra();
			}
			strSQL = "Select  concat(Table_Name, Column_name) As Table_Name_Column_Name, User_Tab_Columns.* from User_Tab_Columns where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsUser_Tab_ColumnsEN objUser_Tab_Columns = new clsUser_Tab_ColumnsEN();
				objUser_Tab_Columns.Table_Name_Column_Name = objRow["Table_Name_Column_Name"].ToString().Trim();
				objUser_Tab_Columns.Table_Name = objRow["Table_Name"].ToString().Trim();
				objUser_Tab_Columns.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
				objUser_Tab_Columns.Column_Name = objRow["Column_Name"].ToString().Trim();
				objUser_Tab_Columns.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
				objUser_Tab_Columns.Data_Precision = TransNullToInt(objRow["Data_Precision"].ToString().Trim());
				objUser_Tab_Columns.Data_Scale = objRow["Data_Scale"].ToString().Trim();
				objUser_Tab_Columns.Data_Type = objRow["Data_Type"].ToString().Trim();
				objUser_Tab_Columns.Nullable = objRow["Nullable"].ToString().Trim();
				arrObjList.Add(objUser_Tab_Columns);
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
		//public static int BindLv_User_Tab_Columns(System.Windows.Forms.ListView lvUser_Tab_Columns, string strWhereCond)
		//{
		//	//操作步骤：(共4步)
		//	//	1、组合界面条件串；
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	//	3、设置ListView的列头信息
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	//		在本界面中是把状态显示在控件lblRecCount中。

		//	System.Windows.Forms.ListViewItem lviUser_Tab_Columns; 
		//	ArrayList arrUser_Tab_ColumnsObjList;
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	arrUser_Tab_ColumnsObjList = clsUser_Tab_ColumnsBL.GetUser_Tab_ColumnsObjList(strWhereCond);
		//	//	3、设置ListView的列头信息
		//	lvUser_Tab_Columns.Items.Clear();//清除原来所有Item
		//	lvUser_Tab_Columns.Columns.Clear();//清除原来所有列头信息
		//	lvUser_Tab_Columns.Columns.Add("表名列名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("表名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("列号", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("列名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("数据长度", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("数据精度", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("Data_Scale", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("可空", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.View = System.Windows.Forms.View.Details;
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	foreach (clsUser_Tab_ColumnsEN objUser_Tab_Columns in arrUser_Tab_ColumnsObjList)
		//	{
		//		lviUser_Tab_Columns = new System.Windows.Forms.ListViewItem();
		//		lviUser_Tab_Columns.Tag = objUser_Tab_Columns.Table_Name_Column_Name;
		//		lviUser_Tab_Columns.Text = objUser_Tab_Columns.Table_Name_Column_Name;
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Table_Name);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Column_Id.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Column_Name);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Length.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Precision.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Scale);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Type);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Nullable);
		//		lvUser_Tab_Columns.Items.Add(lviUser_Tab_Columns);
		//	}
		//	//	4、设置记录数的状态，
		//	//		在本界面中是把状态显示在控件txtRecCount中。
		//	return arrUser_Tab_ColumnsObjList.Count;
		//}
	}
}