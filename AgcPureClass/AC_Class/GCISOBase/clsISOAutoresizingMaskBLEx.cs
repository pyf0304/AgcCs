using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOAutoresizingMaskBLEx_Static
    {
        public static void GeneCode(this ISOAutoresizingMaskEx objISOAutoresizingMaskENEx, StringBuilder strCodeForCs)
        {
            //string strAutoresizingMaskId = AgcPubFun.getSwiftID();
            strCodeForCs.Append("\r\n" + " <autoresizingMask key=\"autoresizingMask\" flexibleMaxX=\"YES\" flexibleMaxY=\"YES\"/> "     );
            foreach (ISOControlEx objSubISOControlENEx in objISOAutoresizingMaskENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }                       
        }
    }
}
