using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public class clsTabCheckResultBLEx : clsTabCheckResultBL
    {
        public static bool AddErrorResult(string strPrjId, string strPrjDataBaseId,
            string strTabId, string strFldId, string strErrMsg, int strErrorLevelId, string strTabCheckErrorTypeId, string strUserId)
        {
            clsTabCheckResultEN objTabCheckResultEn = new clsTabCheckResultEN();
            objTabCheckResultEn.PrjId = strPrjId;
            objTabCheckResultEn.PrjDataBaseId = strPrjDataBaseId;

            objTabCheckResultEn.TabId = strTabId;
            objTabCheckResultEn.FldId = strFldId;

            objTabCheckResultEn.ErrorLevelId = strErrorLevelId;
            objTabCheckResultEn.ErrorMsg = strErrMsg;
            objTabCheckResultEn.CheckDate = clsDateTime.getTodayDateTimeStr(1);
            objTabCheckResultEn.CheckUser = strUserId;
            objTabCheckResultEn.TabCheckErrorTypeId = strTabCheckErrorTypeId;
            try
            {
                clsTabCheckResultBL.AddNewRecordBySql2(objTabCheckResultEn);
            }
            catch(Exception objException)
            {
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
            }
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            var objTabCheckStatus = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, strPrjId, strPrjDataBaseId);
            if (objTabCheckStatus.ErrorLevelId< strErrorLevelId)
            {
                objTabCheckStatus.ErrorLevelId = strErrorLevelId;
                objTabCheckStatus.ErrorMsg = strErrMsg;
                objTabCheckStatus.TabCheckErrorTypeId = strTabCheckErrorTypeId;
                objTabCheckStatus.UpdUser = strUserId;
                objTabCheckStatus.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objTabCheckStatus.Update();
            }
            return true;
        }
        /// <summary>
        /// 删除表错误结果
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strPrjDataBaseId">数据库Id</param>
        /// <param name="strTabId">表Id</param>
        /// <param name="strTabCheckErrorTypeId">错误类型Id</param>
        /// <param name="strFldId">字段Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns>是否成功</returns>
        public static bool DeleteErrorResult(string strPrjId, string strPrjDataBaseId, string strTabId, string strTabCheckErrorTypeId, string strFldId, string strUserId)
        {
            if (string.IsNullOrEmpty(strFldId) == true && string.IsNullOrEmpty(strTabCheckErrorTypeId) == true)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("PrjId='{0}' And PrjDataBaseId='{2}' And TabId='{1}'", strPrjId, strTabId, strPrjDataBaseId);
                clsTabCheckResultBL.DelTabCheckResultsByCond(sbCondition.ToString());
            }
            else if (string.IsNullOrEmpty(strFldId) == true && string.IsNullOrEmpty(strTabCheckErrorTypeId) == false)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("PrjId='{0}' And PrjDataBaseId='{2}' And TabId='{1}' And TabCheckErrorTypeId='{3}'",
                    strPrjId, strTabId, strPrjDataBaseId, strTabCheckErrorTypeId);
                clsTabCheckResultBL.DelTabCheckResultsByCond(sbCondition.ToString());
            }
            else
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("PrjId='{0}'  And PrjDataBaseId='{3}' And TabId='{1}' And FldId='{2}'",
                    strPrjId, strTabId, strFldId, strPrjDataBaseId);
                clsTabCheckResultBL.DelTabCheckResultsByCond(sbCondition.ToString());
            }
            return true;
        }
    }
}
