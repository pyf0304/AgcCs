using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOOutletBLEx_Static
    {
        public static void GeneCode(this ISOOutletEx objISOOutletENEx, StringBuilder strCodeForCs)
        {
            //string strOutletId = AgcPubFun.getSwiftID();
                
            strCodeForCs.AppendFormat("\r\n" + "<outlet property=\"{0}\" destination=\"{1}\" id=\"{2}\"/>",
                objISOOutletENEx.property, objISOOutletENEx.destination, objISOOutletENEx.IsoControlId);

            foreach (ISOControlEx objSubISOControlENEx in objISOOutletENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }

        }
    }
}
