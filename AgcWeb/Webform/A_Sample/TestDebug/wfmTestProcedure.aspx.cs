using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.syspara;
using com.taishsoft.sql;
using System.Collections.Generic;
namespace AGC.Webform
{
	/// <summary>
	/// wfmTestProcedure 的摘要说明。
	/// </summary>
	public partial class wfmTestProcedure : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strFileFolder = Server.MapPath("~");
            ArrayList arrLst = new ArrayList();
			objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add("AA");
			values.Add("1");
			arrLst = objSQL.ExecSpWithOutPut("TCallProc",values);
			string ss = arrLst[0].ToString();
//			return true;
		}

		protected void lbExecProcWithReturnDataTable_Click(object sender, System.EventArgs e)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strFileFolder = Server.MapPath("~");
			System.Data.DataTable objDT;
			objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add("AA");
			values.Add("1");
			objDT = objSQL.ExecSpReturnDT("TCallProcWithReDT",values);

			DataGrid1.DataSource = objDT;
			DataGrid1.DataBind();
		}

		protected void lbCallFuncReDataTable_Click(object sender, System.EventArgs e)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strFileFolder = Server.MapPath("~");
			System.Data.DataTable objDT;
			objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add("AA");
			values.Add("1");
			objDT = objSQL.GetDataTable("select * from TCallFuncReDataTable('pyf')");
			DataGrid1.DataSource = objDT;
			DataGrid1.DataBind();
		}

		protected void lbGetDaBaseTime_Click(object sender, System.EventArgs e)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strFileFolder = Server.MapPath("~");
            ArrayList arrLst = new ArrayList();
			objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add("1");
			values.Add("1");
			arrLst = objSQL.ExecSpWithOutPut("GetDaBaseTime",values);
			string ss = arrLst[0].ToString();
			lblMsg.Text = ss;
		}

		protected void lbGetDaBaseDate_Click(object sender, System.EventArgs e)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strFileFolder = Server.MapPath("~");
            ArrayList arrLst = new ArrayList();
			objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add("1");
			values.Add("1");
			arrLst = objSQL.ExecSpWithOutPut("GetDaBaseToday",values);
			string ss = arrLst[0].ToString();
			lblMsg.Text = ss;
		}
        protected void lbTestGetSP_Para_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            clsSqlStoreProcedureEx objSqlSP = com.taishsoft.syspara.clsPubVar_PubDataBase.getSqlStoreProcedure(objSQL.ConnectionString, "AA");
        }
}
}
