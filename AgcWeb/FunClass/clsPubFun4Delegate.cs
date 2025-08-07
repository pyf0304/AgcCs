using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGC.FunClass
{
    public class clsPubFun4Delegate
    {
        public static void InitDelegateEvent()
        {
            //clsPrjTabBL.onUpdateRecord += ClsPrjTabBL_onUpdateRecord;
        }
        public static void ClsPrjTabBL_onUpdateRecord(object objObject4Update)
        {
            clsPrjTabEN objPrjTabEN = objObject4Update as clsPrjTabEN;
            if (objPrjTabEN.SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW) return;
            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(objPrjTabEN.TabId, objPrjTabEN.PrjId);
            foreach (string strRelaTabId in arrTabId)
            {
                string strCondition = string.Format("{0}='{1}'", conLog4GeneTabCode.TabId, strRelaTabId);

                clsLog4GeneTabCodeBL.SetFldValue(clsLog4GeneTabCodeEN._CurrTabName, conLog4GeneTabCode.IsNeedGene, '1', strCondition);

            }
            //            throw new NotImplementedException();
        }

    }
}