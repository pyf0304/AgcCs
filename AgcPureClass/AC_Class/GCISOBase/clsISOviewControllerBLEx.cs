using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOviewControllerBLEx_Static
    {
        public static void GeneCode(this ISOviewControllerEx objISOviewControllerENEx, StringBuilder strCodeForCs)
        {
         
            //string strViewControllerId = AgcPubFun.getSwiftID();
            
            strCodeForCs.AppendFormat("\r\n" + "<viewController storyboardIdentifier=\"First\" title=\"{0}\" id=\"{1}\" customClass=\"{2}\" customModule=\"{3}\" customModuleProvider=\"target\" sceneMemberID=\"viewController\">",
                objISOviewControllerENEx.Text,
                objISOviewControllerENEx.IsoControlId,
                objISOviewControllerENEx.customClass,
                objISOviewControllerENEx.customModule);
            int intNum = objISOviewControllerENEx.getSubObjNumForCtlTypeId(                enumCtlTypeAbbr.ISOviewControllerLayoutGuide_23);
            if (intNum > 0)
            {
                strCodeForCs.Append("\r\n" + "<layoutGuides>");
            }
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
            {
                if (objSubISOControlENEx.CtlTypeId != enumCtlTypeAbbr.ISOviewControllerLayoutGuide_23) continue;
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            if (intNum > 0)
            {
                strCodeForCs.Append("\r\n" + "</layoutGuides>");
            }
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
            {
                if (objSubISOControlENEx.CtlTypeId != enumCtlTypeAbbr.ISOview_24) continue;
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            int intNum_Outlet = objISOviewControllerENEx.getSubObjNumForCtlTypeId(                enumCtlTypeAbbr.ISOOutlet_32);
            if (intNum_Outlet > 0)
            {
                strCodeForCs.Append("\r\n" + "<connections>");
                //strCodeForCs.Append("\r\n" + "<outlet property=\"lblResult\" destination=\"f0F-if-kRC\" id=\"ZSz-sU-mpE\"/>");
                //strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerENEx.arrSubIsoControlLst2)
                {
                    if (objSubISOControlENEx.CtlTypeId != enumCtlTypeAbbr.ISOOutlet_32) continue;
                    objSubISOControlENEx.GeneCode(strCodeForCs);
                }

                strCodeForCs.Append("\r\n" + "</connections>");
            }
            strCodeForCs.Append("\r\n" + "  </viewController>");
        }
    }
}
