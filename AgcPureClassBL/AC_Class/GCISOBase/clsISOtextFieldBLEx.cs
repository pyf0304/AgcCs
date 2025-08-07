using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.PureClassEx
{
    public static class clsISOtextFieldBLEx_Static
    {
        public static void GeneCode(this ISOtextFieldEx objISOtextFieldENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
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
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "  </textField>");
        }
    }
}
