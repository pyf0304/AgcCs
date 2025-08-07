using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agc.PureClass;
using AGC.BusinessLogic;
using AGC.Entity;

namespace AGC.BusinessLogicEx
{
    public class clsGetTabFieldObj : IGetTabFieldObj
    {
        public clsPrjTabEN GetObjByTabId(string strTabId, string strPrjId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            return objPrjTab;
        }
        public clsFieldTabEN GetObjByFldId(string strFldId, string strPrjId)
        {
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
            return objFieldTab;
        }

    }
}
