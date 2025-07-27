using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsTranslateBLEx
    {
        public static string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            string strFieldCnName = clsFieldTabBLEx.GetFieldCnNameByFieldName(strPrjId, strTabName, strFieldName);
            return strFieldCnName;
        }
    }
}
