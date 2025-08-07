using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOviewControllerLayoutGuideBLEx_Static
    {
        public static void GeneCode(this ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideENEx, StringBuilder strCodeForCs)
        {

            //string strviewControllerLayoutGuideId = AgcPubFun.getSwiftID();
          
            strCodeForCs.AppendFormat("\r\n" + "<viewControllerLayoutGuide type=\"{1}\" id=\"{0}\"/>",
                objISOviewControllerLayoutGuideENEx.IsoControlId,
                objISOviewControllerLayoutGuideENEx.type);
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerLayoutGuideENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            
        }
    }
}
