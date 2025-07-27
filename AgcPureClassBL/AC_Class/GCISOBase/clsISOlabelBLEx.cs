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
    public static class clsISOlabelBLEx_Static 
    {
        public static void GeneCode(this ISOlabelEx objISOlabelENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + " </label>");

        }
    }
}
