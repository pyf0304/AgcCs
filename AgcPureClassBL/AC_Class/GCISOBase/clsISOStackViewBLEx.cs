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
    public static class clsISOStackViewBLEx_Static
    {
        public static void GeneCode(this ISOStackViewEx objISOStackViewENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strStackViewId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<stackView opaque=\"NO\" contentMode=\"scaleToFill\" fixedFrame=\"YES\" restorationIdentifier=\"VStack\" axis=\"vertical\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOStackViewENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<rect key=\"frame\" x=\"6\" y=\"80\" width=\"138\" height=\"270\"/>");
            strCodeForCs.Append("\r\n" + "<autoresizingMask key=\"autoresizingMask\" flexibleMaxX=\"YES\" flexibleMaxY=\"YES\"/>");
            strCodeForCs.Append("\r\n" + "<subviews>");
            foreach (ISOControlEx objSubISOControlENEx in objISOStackViewENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</subviews>");
            strCodeForCs.Append("\r\n" + "</stackView>");
        }
    }
}
