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
    public class clsUserLogBLEx : clsUserLogBL
    {
        public static bool SetUsedLog(string strUserId, string strObjectTable, string strValue)
        {
            clsUserLogEN objUserLogEN = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId = '{0}'", strUserId);
            sbCondition.AppendFormat(" And ObjectTable = '{0}'", strObjectTable);
            bool bolIsExist = clsUserLogBL.IsExistRecord(sbCondition.ToString());
            if (bolIsExist == true)
            {
                objUserLogEN = clsUserLogBL.GetFirstObj_S(sbCondition.ToString());
                objUserLogEN.UserId = strUserId;
                objUserLogEN.ObjectTable = strObjectTable;
                objUserLogEN.UsedValue = strValue;
                objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                //objUserLogEN.UpdTime = clsDateTime.getCurrTime(0);
                clsUserLogBL.CheckPropertyNew(objUserLogEN);
                return clsUserLogBL.UpdateBySql2(objUserLogEN);
            }
            else
            {
                objUserLogEN = new clsUserLogEN();
                objUserLogEN.UserId = strUserId;
                objUserLogEN.ObjectTable = strObjectTable;
                objUserLogEN.UsedValue = strValue;
                objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                //objUserLogEN.UpdTime = clsDateTime.getCurrTime(0);
                clsUserLogBL.CheckPropertyNew(objUserLogEN);
                return clsUserLogBL.AddNewRecordBySql2(objUserLogEN);
            }
        }

    }
}
