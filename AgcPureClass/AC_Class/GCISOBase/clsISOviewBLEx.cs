using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOviewBLEx_Static
    {
        public static void GeneCode(this ISOviewEx objISOviewENEx, StringBuilder strCodeForCs)
        {
          
            //string strViewID = AgcCommBase.AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<view key=\"view\" contentMode=\"scaleToFill\" id=\"{0}\">",
                objISOviewENEx.IsoControlId);
            //string strrectID = AgcCommBase.AgcPubFun.getSwiftID();
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"0.0\" y=\"0.0\" width=\"375\" height=\"667\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" widthSizable=\"YES\" heightSizable=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<subviews>");
         
            foreach (ISOControlEx objSubISOControlENEx in objISOviewENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</subviews>");
            strCodeForCs.Append("\r\n" + "<color key=\"backgroundColor\" red=\"1\" green=\"1\" blue=\"1\" alpha=\"1\" colorSpace=\"custom\" customColorSpace=\"sRGB\"/>");
            strCodeForCs.Append("\r\n" + "<viewLayoutGuide key=\"safeArea\" id=\"20h-oV-DHU\"/>");
            strCodeForCs.Append("\r\n" + "</view>");
        
        }
    }
}
