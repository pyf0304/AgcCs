using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOnavigationBarBLEx_Static
    {
        public static void GeneCode(this ISOnavigationBarEx objISOnavigationBarENEx, StringBuilder strCodeForCs)
        {
       
            //string strnavigationBarId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<navigationBar contentMode=\"scaleToFill\" fixedFrame=\"YES\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOnavigationBarENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"0.0\" y=\"20\" width=\"375\" height=\"44\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" widthSizable=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<items>");
                      
            foreach (ISOControlEx objSubISOControlENEx in objISOnavigationBarENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</items>");
            strCodeForCs.Append("\r\n" + "</navigationBar>");
        }
    }
}
