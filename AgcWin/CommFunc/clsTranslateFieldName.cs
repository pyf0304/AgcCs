using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC4WS;
using CommonTable.BusinessLogic;

namespace Agc_CsWin.CommFunc
{
    public class clsTranslateFieldName : ITranslate
    {
        public string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            string strFieldCnName = clsTranslateWS.GetFieldCnNameByFieldName(strPrjId, strTabName, strFieldName);
            return strFieldCnName;
        }

    }
}
