using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsUserDefaPrjDataBaseBLEx
    {
        public static string GetPrjDataBaseIdByPrjIdAndUserId(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            clsUserDefaPrjDataBaseEN objUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBL.GetFirstObj_S(strCondition);
            if (objUserDefaPrjDataBaseEN == null)
            {
                return "";
            }
            return objUserDefaPrjDataBaseEN.PrjDataBaseId;
        }
        public static clsvUserDefaPrjDataBaseEN GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            clsvUserDefaPrjDataBaseEN objUserDefaPrjDataBaseEN = clsvUserDefaPrjDataBaseBL.GetFirstObj_S(strCondition);
            return objUserDefaPrjDataBaseEN;
        }
        public static bool SetPrjDataBaseIdByPrjIdAndUserId(string strPrjId, string strUserId, string strPrjDataBaseId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            clsUserDefaPrjDataBaseEN objUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBL.GetFirstObj_S(strCondition);
            if (objUserDefaPrjDataBaseEN == null)
            {
                objUserDefaPrjDataBaseEN = new clsUserDefaPrjDataBaseEN();
                objUserDefaPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId;
                objUserDefaPrjDataBaseEN.UserId = strUserId;
                objUserDefaPrjDataBaseEN.PrjId = strPrjId;
                objUserDefaPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objUserDefaPrjDataBaseEN.UpdUserId = strUserId;
                return clsUserDefaPrjDataBaseBL.AddNewRecordBySql2(objUserDefaPrjDataBaseEN);
                
            }
            objUserDefaPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId;
     
            objUserDefaPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objUserDefaPrjDataBaseEN.UpdUserId = strUserId;

            return clsUserDefaPrjDataBaseBL.UpdateBySql2(objUserDefaPrjDataBaseEN);
        }
    }
}
