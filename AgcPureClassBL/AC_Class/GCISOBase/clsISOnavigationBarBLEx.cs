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
    public static class clsISOnavigationBarBLEx_Static
    {
        public static void GeneCode(this ISOnavigationBarEx objISOnavigationBarENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strnavigationBarId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<navigationBar contentMode=\"scaleToFill\" fixedFrame=\"YES\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOnavigationBarENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"0.0\" y=\"20\" width=\"375\" height=\"44\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" widthSizable=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<items>");
                      
            foreach (ISOControlEx objSubISOControlENEx in objISOnavigationBarENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</items>");
            strCodeForCs.Append("\r\n" + "</navigationBar>");
        }
    }
}
