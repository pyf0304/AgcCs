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
	public partial class clsSQLDSTypeBLEx 
	{
		public const string 
			SQLTAB                               = "01", //SQL表
			SQLVIEW                              = "02"; //SQL视图

		

		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能:根据界面上查询控件中所设置内容查询表记录,
		///			 并显示在ListView中。
		/// </summary>
		public static int BindLv_SQLDSType(System.Windows.Forms.ListView lvSQLDSType, string strWhereCond)
		{
			//操作步骤:(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviSQLDSType;
            List<clsSQLDSTypeEN> arrSQLDSTypeObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrSQLDSTypeObjList = clsSQLDSTypeBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvSQLDSType.Items.Clear();//清除原来所有Item
			lvSQLDSType.Columns.Clear();//清除原来所有列头信息
			lvSQLDSType.Columns.Add("输出数据源类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.Columns.Add("Sql数据源名", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsSQLDSTypeEN objSQLDSType in arrSQLDSTypeObjList)
			{
				lviSQLDSType = new System.Windows.Forms.ListViewItem();
				lviSQLDSType.Tag = objSQLDSType.SqlDsTypeId;
				lviSQLDSType.Text = objSQLDSType.SqlDsTypeId;
				lviSQLDSType.SubItems.Add(objSQLDSType.SqlDsTypeName);
				lviSQLDSType.SubItems.Add(objSQLDSType.Memo);
				lvSQLDSType.Items.Add(lviSQLDSType);
			}
			//	4、设置记录数的状态,
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrSQLDSTypeObjList.Count;
		}
	}
}