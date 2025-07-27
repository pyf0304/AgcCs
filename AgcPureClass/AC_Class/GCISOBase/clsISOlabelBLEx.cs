using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOlabelBLEx_Static 
    {
        public static void GeneCode(this ISOlabelEx objISOlabelENEx, StringBuilder strCodeForCs)
        {
        
            //string strlabelId = AgcPubFun.getSwiftID();
        
            strCodeForCs.AppendFormat("\r\n" + "   <label opaque=\"NO\" userInteractionEnabled=\"NO\" contentMode=\"left\" horizontalHuggingPriority=\"251\" verticalHuggingPriority=\"251\" fixedFrame=\"YES\" text=\"{1}\" textAlignment=\"natural\" lineBreakMode=\"tailTruncation\" baselineAdjustment=\"alignBaselines\" adjustsFontSizeToFit=\"NO\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOlabelENEx.IsoControlId, objISOlabelENEx.Text);
            strCodeForCs.AppendFormat("\r\n" + "    <rect key=\"frame\" x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\"/>",
                objISOlabelENEx.x,
                objISOlabelENEx.y,
                objISOlabelENEx.Width,
                objISOlabelENEx.Height);
            strCodeForCs.Append("\r\n" + " <autoresizingMask key=\"autoresizingMask\" flexibleMaxX=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + " <fontDescription key=\"fontDescription\" type=\"system\" pointSize=\"17\"/>");
            strCodeForCs.Append("\r\n" + " <color key=\"textColor\" red=\"0.0\" green=\"0.0\" blue=\"0.0\" alpha=\"1\" colorSpace=\"custom\" customColorSpace=\"sRGB\"/>");
            strCodeForCs.Append("\r\n" + " <nil key=\"highlightedColor\"/>");
            
            foreach (ISOControlEx objSubISOControlENEx in objISOlabelENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + " </label>");

        }
    }
}
