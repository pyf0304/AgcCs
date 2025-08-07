using AGC.BusinessLogic;
using AGC.Entity;

using com.taishsoft.commdb;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsLog4GeneViewCodeBLEx
    {
        public static clsLog4GeneViewCodeEN GetObjByViewId(List<clsLog4GeneViewCodeEN> arrObjLst, string strViewId)
        {
            IEnumerable<clsLog4GeneViewCodeEN> arrLog4GeneViewCodeObjLst_Sel1 =
            from objLog4GeneViewCodeEN in arrObjLst
            where objLog4GeneViewCodeEN.ViewId == strViewId
            select objLog4GeneViewCodeEN;
            List<clsLog4GeneViewCodeEN> arrLog4GeneViewCodeObjLst_Sel = new List<clsLog4GeneViewCodeEN>();
            foreach (clsLog4GeneViewCodeEN obj in arrLog4GeneViewCodeObjLst_Sel1)
            {
                arrLog4GeneViewCodeObjLst_Sel.Add(obj);
            }
            if (arrLog4GeneViewCodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrLog4GeneViewCodeObjLst_Sel[0];
        }


        public static bool AddLog4GeneViewCode(string strViewId, string strUserId, string strVersion)
        {
            clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
            objLog4GeneViewCodeEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objLog4GeneViewCodeEN.VersionGeneCode = strVersion;
            objLog4GeneViewCodeEN.UserId = strUserId;
            objLog4GeneViewCodeEN.ViewId = strViewId;
            objLog4GeneViewCodeEN.PrjId = strViewId.Substring(0,4);

            string strCondition = objLog4GeneViewCodeEN.GetUniCondStr();
            if (clsLog4GeneViewCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneViewCodeBL.AddNewRecordBySql2(objLog4GeneViewCodeEN);
            }
            else
            {
                objLog4GeneViewCodeEN.UpdateWithCondition(strCondition);
            }
            return true;
        }

        public static bool AddLog4GeneViewCode(string strViewId, string strFuncId4GC, string strUserId, string strVersion)
        {
            clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
            objLog4GeneViewCodeEN.GeneCodeDate = clsDateTime_Db.GetDataBaseDateTime14();
            objLog4GeneViewCodeEN.VersionGeneCode = strVersion;
            objLog4GeneViewCodeEN.UserId = strUserId;
            objLog4GeneViewCodeEN.ViewId = strViewId;
            string strCondition = objLog4GeneViewCodeEN.GetUniCondStr();
            if (clsLog4GeneViewCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneViewCodeBL.AddNewRecordBySql2(objLog4GeneViewCodeEN);
            }
            else
            {
                objLog4GeneViewCodeEN.UpdateWithCondition(strCondition);
            }
            return true;
        }
    }
}
