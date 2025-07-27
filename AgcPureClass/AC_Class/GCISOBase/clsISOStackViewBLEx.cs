using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOStackViewBLEx_Static
    {
        public static void GeneCode(this ISOStackViewEx objISOStackViewENEx, StringBuilder strCodeForCs)
        {
         
            //string strStackViewId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<stackView opaque=\"NO\" contentMode=\"scaleToFill\" fixedFrame=\"YES\" restorationIdentifier=\"VStack\" axis=\"vertical\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOStackViewENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"6\" y=\"80\" width=\"138\" height=\"270\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" flexibleMaxX=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<subviews>");
            foreach (ISOControlEx objSubISOControlENEx in objISOStackViewENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</subviews>");
            strCodeForCs.Append("\r\n" + "</stackView>");
        }
    }
}
