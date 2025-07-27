using AGC.BusinessLogic;
using AGC.DAL;
using com.taishsoft.commdb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsSqlViewFldBLEx : clsSqlViewFldBL
    {
        public static bool GoTop(List<string> arrKeyId, string strSqlViewId)
        {
            try
            {
                bool bolResult = new clsSqlViewFldDAEx().GoTop(arrKeyId);
                bolResult = new clsSqlViewFldDAEx().ReOrder(strSqlViewId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool GoTop(string strKeyId, string strSqlViewId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsSqlViewFldDAEx().GoTop(arrKeyId);
                bolResult = new clsSqlViewFldDAEx().ReOrder(strSqlViewId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId, string strSqlViewId)
        {
            try
            {
                bool bolResult = new clsSqlViewFldDAEx().GoBottom(arrKeyId);
                bolResult = new clsSqlViewFldDAEx().ReOrder(strSqlViewId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId, string strSqlViewId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsSqlViewFldDAEx().GoBottom(arrKeyId);
                bolResult = new clsSqlViewFldDAEx().ReOrder(strSqlViewId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }


        public static bool AdjustSequenceNumber(string strDirect, long lngmId)
        {
            try
            {
                bool bolResult = new clsSqlViewFldDAEx().AdjustSequenceNumber(strDirect, lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder(string strSqlViewId)
        {
            try
            {
                bool bolResult = new clsSqlViewFldDAEx().ReOrder(strSqlViewId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }

        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static bool ReplaceField(string strPrjId, string strSourceFldId, string strTargetFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            strSQL = string.Format("Update SqlViewFld Set FldId = '{0}' where PrjId = '{1}' And FldId = '{2}'",
                                                strTargetFldId, strPrjId, strSourceFldId);
            return objSQL.ExecSql(strSQL);
        }
    }
}
