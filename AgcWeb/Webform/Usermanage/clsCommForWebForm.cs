using System;
using System.Web.UI.WebControls;
using com.taishsoft.commdb;

namespace AGC.Webform
{
	/// <summary>
	/// clsCommForWebForm 的摘要说明。
	/// </summary>
	public class clsCommForWebFormBak
	{
//		public const string strPrjId = "0001";
		public clsCommForWebFormBak()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static System.Data.DataTable GetCollege()
		{
			//获取学院所有信息
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable("select Name, clgId from college");
			return objDT;
		}

		public static System.Data.DataTable GetMajor(string strClgId)
		{
			//获取某学院所有专业信息
			string strSQL = "select Name, MajorId from Major where ClgId='" + strClgId + "'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}

		public static void BindDdl_College(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为下拉框学院设置内容
			ListItem li=new ListItem("请选择...","请选择...");
			System.Data.DataTable objDT = clsCommForWebFormBak.GetCollege();
			objDDL.DataValueField="ClgId";
			objDDL.DataTextField="Name";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		public static void BingDdl_Major(System.Web.UI.WebControls.DropDownList objDDL, 
									string strClgId)
		{
			//为下拉框专业设置内容	
			ListItem li=new ListItem("请选择...","请选择...");
			System.Data.DataTable objDT = clsCommForWebFormBak.GetMajor(strClgId);
			if (objDT.Rows.Count >0 )
			{
				objDDL.DataValueField="MajorId";
				objDDL.DataTextField="Name";
				objDDL.DataSource = objDT;
				objDDL.DataBind();
			}
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		

	}
}
