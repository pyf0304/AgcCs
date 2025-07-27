///----------------------
///生成代码版本：6.3.0.0
///生成日期：2008/03/10
///生成者：尹华蓓
///注意：需要数据底层（PubDataBase.dll）的版本：4.3.0.0
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace EcardDataClass
{
    public class clsperson_qEx : clsPERSON_q
    {

        public clsperson_qEx()
            : base()
        {
        }

        public clsperson_qEx(string strACCOUNT)
            : base(strACCOUNT)
        {
        }

        public clsperson_qEx(string strACCOUNT, bool bolIsGetperson_q)
            : base(strACCOUNT, bolIsGetperson_q)
        {
        }
        public static DataTable GetPerson_qDataTable(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            DataTable objDT = new DataTable();
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from person_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "person_q");
            objDT = objDS.Tables[0];
            return objDT;
        }
    }
}