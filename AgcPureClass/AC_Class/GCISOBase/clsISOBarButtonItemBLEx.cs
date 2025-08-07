using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOBarButtonItemBLEx_Static
    {
        public static void GeneCode(this ISOBarButtonItemEx objISOBarButtonItemENEx, StringBuilder strCodeForCs)
        {
          
            //string strBarButtonItemId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<barButtonItem key=\"{1}\" style=\"done\" id=\"{0}\">",
                objISOBarButtonItemENEx.IsoControlId, objISOBarButtonItemENEx.mKey);
            foreach (ISOControlEx objSubISOControlENEx in objISOBarButtonItemENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</barButtonItem>");
        }
    }
}
