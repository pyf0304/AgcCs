using System;
using System.Text;
using com.taishsoft.commdb;


namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsUserPrjGrantEx 的摘要说明。
	/// </summary>
	public partial class clsUserPrjGrantBLEx
	{
		/// <summary>
		/// 功能：获取某一条件的DataTable，其中的代码转换成相应的名称
		/// </summary>
		/// <param name="strCondition">条件串</param>
		/// <returns>返回已经转换代码的DataTable</returns>
		public static System.Data.DataTable GetUserPrjGrantT1(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL.Append("Select UserPrjGrant.* ");
			strSQL.Append(", Projects.PrjName ProjectsPrjName ");
			strSQL.Append(" from UserPrjGrant ");
			strSQL.Append(" left JOIN Projects on UserPrjGrant.PrjId = Projects.PrjId ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}
	}
}
