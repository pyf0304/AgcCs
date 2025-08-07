using System;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.syspara;
using CommonTable.Entity;
using System.Text;
namespace DynamicCompilerWin
{
    public class AgcCs
    {
        private clsPrjTabENEx objPrjTabENEx = null;
        public void InitGeneCode()
        {
            try
            {

                Console.WriteLine("执行开始！");
                string strTabId = "01160052";
                string strPrjDataBaseId = "0111";
                string strPrjId = "0116";
                AutoGCEx.AppSet("server=101.251.68.133,9433;uid=agccs;pwd=a1b2c3@tz4300;database=AGC_CS12;Pooling=true; Min Pool Size=50;Max Pool Size=150;");
                AutoGCEx.SetCommFun4BL();
                objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);
                Console.WriteLine("执行完成！" + objPrjTabENEx.TabName);
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException.Message);
            }

        }
        private string KeyWhereStr()
        {
            return "";

        }
        public string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 ==  == ;
            return strBuilder.ToString();

        }
        public string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据Sql语句获取DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strSql\">Sql语句</param>");
            strBuilder.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一SQL串的DataTable ==  == ;
            return strBuilder.ToString();

        }

    }
}