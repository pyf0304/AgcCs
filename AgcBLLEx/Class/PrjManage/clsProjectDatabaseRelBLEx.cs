using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public class clsProjectDatabaseRelBLEx : clsProjectDatabaseRelBL
    {
        /// <summary>
        /// 检查唯一性(Uniqueness)
        /// </summary>
        /// <param name = "objProjectDatabaseRelEN">对象</param>
        /// <returns>如果存在,就返回FALSE,如果不存在,就返回TRUE。</returns>
        public static bool CheckUniquenessEx(clsProjectDatabaseRelEN objProjectDatabaseRelEN)
        {
            //检测记录是否存在
            //bool bolIsUniqueness;
            if (objProjectDatabaseRelEN  ==  null) return true;

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", objProjectDatabaseRelEN.PrjId);
            sbCondition.AppendFormat(" And PrjDataBaseId = '{0}'", objProjectDatabaseRelEN.PrjDataBaseId);
            if (clsProjectDatabaseRelBL.IsExistRecord(sbCondition.ToString())  ==  false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPrjDataBaseId(string strPrjId, string strPrjDataBaseId )
        {
            //检测记录是否存在
            //bool bolIsUniqueness;
            if (string.IsNullOrEmpty( strPrjId ) == true || string.IsNullOrEmpty(strPrjDataBaseId) == true) return true;

            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            //sbCondition.AppendFormat(" And PrjDataBaseId = '{0}'", strPrjDataBaseId);
            var arr = clsProjectDatabaseRelBL.GetObjLstCache(strPrjId);
            var intCOunt = arr.Count(x => x.PrjDataBaseId == strPrjDataBaseId);
            if (intCOunt == 0)
            {
                string strTemp = $"在工程:{clsProjectsBL.GetNameByPrjIdCache(strPrjId)}({strPrjId})中，没有相关的数据库:{clsPrjDataBaseBL.GetNameByPrjDataBaseIdCache(strPrjDataBaseId)}({strPrjDataBaseId}), 请重新登录Web版，并选择正确的数据库。";
                throw new Exception(strTemp);
            }
            else
            {
                return true;
            }
        }

    }
}
