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
	public class clsUser_ViewsBLEx : clsUser_ViewsEN
	{

		public clsUser_ViewsBLEx(): base()
		{
		}

		public clsUser_ViewsBLEx(string strView_Name): base(strView_Name)
		{
		}

		public clsUser_ViewsBLEx(string strView_Name, bool bolIsGetUser_Views) : base(strView_Name,bolIsGetUser_Views)
		{
		}

		public clsUser_ViewsBLEx(string server,string strSID,string uid,string pwd):base(server, strSID, uid, pwd)
		{

		}
		public System.Data.DataTable GetUser_ViewsEx(string strCondition)
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
			strSQL = "Select * from User_Views where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}


		/////生成绑定ListView的代码
		///// <summary>
		///// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		/////			 并显示在ListView中。
		///// </summary>
		//public static int BindLv_User_Views(System.Windows.Forms.ListView lvUser_Views, string strWhereCond)
		//{
		//	//操作步骤：(共4步)
		//	//	1、组合界面条件串；
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	//	3、设置ListView的列头信息
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	//		在本界面中是把状态显示在控件lblRecCount中。

		//	System.Windows.Forms.ListViewItem lviUser_Views; 
		//	ArrayList arrUser_ViewsObjList;
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	arrUser_ViewsObjList = clsUser_ViewsBL.GetUser_ViewsObjList(strWhereCond);
		//	//	3、设置ListView的列头信息
		//	lvUser_Views.Items.Clear();//清除原来所有Item
		//	lvUser_Views.Columns.Clear();//清除原来所有列头信息
		//	lvUser_Views.Columns.Add("视图名", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.Columns.Add("文本内容", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.Columns.Add("文本长度", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.View = System.Windows.Forms.View.Details;
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	foreach (clsUser_ViewsEN objUser_Views in arrUser_ViewsObjList)
		//	{
		//		lviUser_Views = new System.Windows.Forms.ListViewItem();
		//		lviUser_Views.Tag = objUser_Views.View_Name;
		//		lviUser_Views.Text = objUser_Views.View_Name;
		//		lviUser_Views.SubItems.Add(objUser_Views.Text);
		//		lviUser_Views.SubItems.Add(objUser_Views.Text_Length.ToString());
		//		lvUser_Views.Items.Add(lviUser_Views);
		//	}
		//	//	4、设置记录数的状态，
		//	//		在本界面中是把状态显示在控件txtRecCount中。
		//	return arrUser_ViewsObjList.Count;
		//}
	}
}