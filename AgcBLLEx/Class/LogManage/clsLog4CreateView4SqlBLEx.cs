using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsLog4CreateView4SqlBLEx
    {
        /// <summary>
        /// 为在Sql服务器上建立视图,而添加日志
        /// 作者:潘以锋
        /// 日期:20141007
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjDataBaseId">项目数据库Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool AddLog4CreateView4Sql(string strSqlViewId, string strPrjDataBaseId, string strPrjId, string strUserId)
        {
            clsLog4CreateView4SqlEN objLog4CreateView4SqlEN = new clsLog4CreateView4SqlEN();
        
            objLog4CreateView4SqlEN.SqlViewId = strSqlViewId;
            objLog4CreateView4SqlEN.PrjDataBaseId = strPrjDataBaseId;
            objLog4CreateView4SqlEN.CreateViewDate = clsDateTime_Db.GetDataBaseDateTime14();
            objLog4CreateView4SqlEN.UserId = strUserId;
            objLog4CreateView4SqlEN.PrjId = strPrjId;
         
            string strCondition = objLog4CreateView4SqlEN.GetUniCondStr();
            if (clsLog4CreateView4SqlBL.IsExistRecord(strCondition)  ==  false)
            {
                clsLog4CreateView4SqlBL.AddNewRecordBySql2(objLog4CreateView4SqlEN);
            }
            else
            {
                objLog4CreateView4SqlEN.UpdateWithCondition(strCondition);
            }
            return true;
        }
    }
}
