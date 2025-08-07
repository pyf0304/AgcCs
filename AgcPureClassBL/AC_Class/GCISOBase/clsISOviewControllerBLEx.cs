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
    public static class clsISOviewControllerBLEx_Static
    {
        public static void GeneCode(this ISOviewControllerEx objISOviewControllerENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strViewControllerId = AgcPubFun.getSwiftID();

            strCodeForCs.AppendFormat("\r\n" + "<viewController storyboardIdentifier=\"First\" title=\"{0}\" id=\"{1}\" customClass=\"{2}\" customModule=\"{3}\" customModuleProvider=\"target\" sceneMemberID=\"viewController\">",
                objISOviewControllerENEx.Text,
                objISOviewControllerENEx.IsoControlId,
                objISOviewControllerENEx.customClass,
                objISOviewControllerENEx.customModule);
            int intNum = objISOviewControllerENEx.getSubObjNumForCtlTypeId(                enumCtlType.ISOviewControllerLayoutGuide_23);
            if (intNum > 0)
            {
                strCodeForCs.Append("\r\n" + "<layoutGuides>");
            }
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
            {
                if (objSubISOControlENEx.CtlTypeId != enumCtlType.ISOviewControllerLayoutGuide_23) continue;
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            if (intNum > 0)
            {
                strCodeForCs.Append("\r\n" + "</layoutGuides>");
            }
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
            {
                if (objSubISOControlENEx.CtlTypeId != enumCtlType.ISOview_24) continue;
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            int intNum_Outlet = objISOviewControllerENEx.getSubObjNumForCtlTypeId(                enumCtlType.ISOOutlet_32);
            if (intNum_Outlet > 0)
            {
                strCodeForCs.Append("\r\n" + "<connections>");
                //strCodeForCs.Append("\r\n" + "<outlet property=\"lblResult\" destination=\"f0F-if-kRC\" id=\"ZSz-sU-mpE\"/>");
                //strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
                {
                    if (objSubISOControlENEx.CtlTypeId != enumCtlType.ISOOutlet_32) continue;
                    objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }

                strCodeForCs.Append("\r\n" + "</connections>");
            }
            strCodeForCs.Append("\r\n" + "  </viewController>");
        }
    }
}
