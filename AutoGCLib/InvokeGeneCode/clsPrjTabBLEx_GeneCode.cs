using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.commdb;

namespace AutoGCLib
{
    public class clsPrjTabBLEx_GeneCode
    {

      
        /// <summary>
        /// 在Sql中生成表
        /// </summary>
        /// <param name = "strTabId"></param>
        /// <param name = "strPrjId"></param>
        /// <param name = "strPrjDataBaseId"></param>
        /// <returns>返回是否成功?</returns>
        public static bool GenSQLCode4CreateTab(string strTabId, string strPrjId, string strPrjDataBaseId)
        {
            
            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            
            AutoGC6Cs_M autoGC5Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId, strPrjId);
            
            string strSql = autoGC5Cs_M.A_GenSQLCode4CreateTab(strPrjDataBaseId);   //已完成

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(
                objPrjDataBase.IpAddress,
                objPrjDataBase.DataBaseName,
                objPrjDataBase.DataBaseUserId,
                objPrjDataBase.DataBasePwd);
            string strTabName = clsPrjTabBL.GetObjByTabId(strTabId).TabName;
            if (objSQL.IsExistTable(strTabName) == true)
            {
                throw new Exception(strTabName + "表已存在!!");
            }
            return objSQL.ExecSql(strSql);
           

            //return strCodeText;
        }
    }
}
