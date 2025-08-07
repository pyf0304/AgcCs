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
    public static class clsISOviewBLEx_Static
    {
        public static void GeneCode(this ISOviewEx objISOviewENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strViewID = AgcCommBase.AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<view key=\"view\" contentMode=\"scaleToFill\" id=\"{0}\">",
                objISOviewENEx.IsoControlId);
            //string strrectID = AgcCommBase.AgcPubFun.getSwiftID();
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"0.0\" y=\"0.0\" width=\"375\" height=\"667\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" widthSizable=\"YES\" heightSizable=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<subviews>");
         
            foreach (ISOControlEx objSubISOControlENEx in objISOviewENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</subviews>");
            strCodeForCs.Append("\r\n" + "<color key=\"backgroundColor\" red=\"1\" green=\"1\" blue=\"1\" alpha=\"1\" colorSpace=\"custom\" customColorSpace=\"sRGB\"/>");
            strCodeForCs.Append("\r\n" + "<viewLayoutGuide key=\"safeArea\" id=\"20h-oV-DHU\"/>");
            strCodeForCs.Append("\r\n" + "</view>");
        
        }
    }
}
