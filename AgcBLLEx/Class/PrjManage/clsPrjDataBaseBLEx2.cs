///----------------------
///生成代码版本:8.2.0.0
///生成日期:2009/06/14
///生成者:潘以锋
///注意:需要数据底层(PubDataBase.dll)的版本:09.01.02.2
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 数据库对象(PrjDataBase)
    /// </summary>
    public partial class clsPrjDataBaseBLEx 
    {
      
        private int mintConnectWay;

        public int ConnectWay
        {
            get { return mintConnectWay; }
            set { mintConnectWay = value; }
        }


        ///// <summary>
        ///// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        ///// </summary>
        ///// <param name = "strPrjDataBaseId">所给的关键字</param>
        ///// <returns>根据关键字获取的对象</returns>
        //public static clsPrjDataBaseEN GetPrjDataBaseObjByPrjDataBaseId(string strPrjDataBaseId)
        //{
        //    if (arrPrjDataBaseObjLst  ==  null)
        //    {
        //        arrPrjDataBaseObjLst = clsPrjDataBaseBL.GetObjLst("1 = 1");
        //    }
        //    foreach (clsPrjDataBaseEN objPrjDataBase in arrPrjDataBaseObjLst)
        //    {
        //        if (objPrjDataBase.PrjDataBaseId  ==  strPrjDataBaseId)
        //        {
        //            return objPrjDataBase;
        //        }
        //    }
        //    return null;
        //}
        //public string ConnectStringEx
        //{
        //    get
        //    {
        //        //获得连接字符串
        //        StringBuilder sbConnectString = new StringBuilder();
        //        if (objViewInfoENEx.DataBaseTypeId  ==  "01" || objViewInfoENEx.DataBaseTypeId  ==  "02")
        //        {
        //            sbConnectString.AppendFormat("server = {0};", objViewInfoENEx.IpAddress);
        //            sbConnectString.AppendFormat("database = {0};", objViewInfoENEx.DataBaseName);
        //            sbConnectString.AppendFormat("uid = {0};", objViewInfoENEx.DataBaseUserId);
        //            sbConnectString.AppendFormat("pwd = {0};", objViewInfoENEx.DataBasePwd);
        //        }
        //        else if (objViewInfoENEx.DataBaseTypeId  ==  "03")
        //        {
        //            if (ConnectWay  ==  2)
        //            {
        //                sbConnectString.Append("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)");
        //                sbConnectString.AppendFormat("(HOST = {0})",
        //                    objViewInfoENEx.IpAddress);
        //                sbConnectString.Append("(PORT = 1521)))");
        //                sbConnectString.AppendFormat("(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {0})));",
        //                    objViewInfoENEx.SID);
        //                sbConnectString.AppendFormat("User Id = {0};Password = {1};",
        //                    objViewInfoENEx.DataBaseUserId,
        //                    objViewInfoENEx.DataBasePwd);
        //            }
        //            else
        //            {
        //                sbConnectString.AppendFormat("Data Source = {0};Persist Security Info = True;", objViewInfoENEx.SID);
        //                sbConnectString.AppendFormat("User Id = {0};Password = {1};Unicode = True;",
        //                   objViewInfoENEx.DataBaseUserId,
        //                   objViewInfoENEx.DataBasePwd);
        //            }
        //        }
        //        else
        //        {
        //            return "";
        //        }
        //        return sbConnectString.ToString();

        //    }
        //}
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static  System.Data.DataTable getTables(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(
                objPrjDataBaseEN.IpAddress,
                objPrjDataBaseEN.DataBaseName,
                objPrjDataBaseEN.DataBaseUserId,
                objPrjDataBaseEN.DataBasePwd);
            objDT = objSQL.getTables();
            return objDT;

        }
        /// <summary>
        /// 功能:获取给定表的所有字段名
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable getTabColumns(string strTabName, string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSqlSvr = 
                new clsSpecSQLforSql(objPrjDataBaseEN.IpAddress,
                objPrjDataBaseEN.DataBaseName,
                objPrjDataBaseEN.DataBaseUserId,
                objPrjDataBaseEN.DataBasePwd);

            objDT = objSqlSvr.GetColumns(strTabName, objPrjDataBaseEN.DatabaseOwner);
            objSqlSvr = null;
            return objDT;

        }
        /// <summary>
        /// 根据关键字strPrjDataBaseId获取连接串
        /// </summary>
        /// <param name = "strPrjDataBaseId">关键字</param>
        /// <returns>连接串</returns>
        //public static string GetConnectString(string strPrjDataBaseId)
        //{
        //    clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
        //    //objPrjDataBaseEN.PrjDataBaseId
      
        //    //获得连接字符串
        //    StringBuilder sbConnectString = new StringBuilder();
        //    if (objPrjDataBaseEN.DataBaseTypeId  ==  "01" || objPrjDataBaseEN.DataBaseTypeId  ==  "02")
        //    {
        //        sbConnectString.AppendFormat("server = {0};", objPrjDataBaseEN.IpAddress);
        //        sbConnectString.AppendFormat("database = {0};", objPrjDataBaseEN.DataBaseName);
        //        sbConnectString.AppendFormat("uid = {0};", objPrjDataBaseEN.DataBaseUserId);
        //        sbConnectString.AppendFormat("pwd = {0};", objPrjDataBaseEN.DataBasePwd);
        //    }
        //    else if (objPrjDataBaseEN.DataBaseTypeId  ==  "03")
        //    {

        //        sbConnectString.Append("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)");
        //        sbConnectString.AppendFormat("(HOST = {0})",
        //            objPrjDataBaseEN.IpAddress);
        //        sbConnectString.Append("(PORT = 1521)))");
        //        sbConnectString.AppendFormat("(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {0})));",
        //            objPrjDataBaseEN.SID);
        //        sbConnectString.AppendFormat("User Id = {0};Password = {1};",
        //            objPrjDataBaseEN.DataBaseUserId,
        //            objPrjDataBaseEN.DataBasePwd);

        //    }
        //    else
        //    {
        //        return "";
        //    }
        //    return sbConnectString.ToString();
        //}
    }
}