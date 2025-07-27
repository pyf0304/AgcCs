using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOtextFieldBLEx_Static
    {
        public static void GeneCode(this ISOtextFieldEx objISOtextFieldENEx, StringBuilder strCodeForCs)
        {
     
            //string strtextFieldId = AgcPubFun.getSwiftID();
      
            strCodeForCs.AppendFormat("\r\n" + " <textField opaque=\"NO\" clipsSubviews=\"YES\" contentMode=\"scaleToFill\" fixedFrame=\"YES\" contentHorizontalAlignment=\"left\" contentVerticalAlignment=\"center\" borderStyle=\"roundedRect\" textAlignment=\"natural\" minimumFontSize=\"17\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOtextFieldENEx.IsoControlId);
            strCodeForCs.AppendFormat("\r\n" + "    <rect key=\"frame\" x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\"/>", 
                  objISOtextFieldENEx.x,
                objISOtextFieldENEx.y,
                objISOtextFieldENEx.Width,
                objISOtextFieldENEx.Height);
            strCodeForCs.Append("\r\n" + "    <autoresizingMask key=\"autoresizingMask\" flexibleMaxX=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "   <fontDescription key=\"fontDescription\" type=\"system\" pointSize=\"14\"/>");
            strCodeForCs.Append("\r\n" + "   <textInputTraits key=\"textInputTraits\"/>");

            foreach (ISOControlEx objSubISOControlENEx in objISOtextFieldENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "  </textField>");
        }
    }
}
