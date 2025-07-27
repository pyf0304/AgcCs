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
    public static class clsISOsceneBLEx_Static
    {
        public static void GeneCode(this ISOsceneEx objISOsceneENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strsceneId = AgcPubFun.getSwiftID();

            strCodeForCs.AppendFormat("\r\n" + "<!--{0}-->", objISOsceneENEx.Text);
         
            strCodeForCs.AppendFormat("\r\n" + "<scene sceneID=\"{0}\">",
                objISOsceneENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<objects>");
            foreach (ISOControlEx objSubISOControlENEx in objISOsceneENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            string strplaceholderID = AgcCommBase.AgcPubFun.getSwiftID();

            strCodeForCs.AppendFormat("\r\n" + "<placeholder placeholderIdentifier=\"IBFirstResponder\" id=\"{0}\" userLabel=\"First Responder\" sceneMemberID=\"firstResponder\"/>",
                strplaceholderID);
            strCodeForCs.Append("\r\n" + "</objects>");
            strCodeForCs.Append("\r\n" + "<point key=\"canvasLocation\" x=\"-3302\" y=\"-1221\"/>");
            strCodeForCs.Append("\r\n" + "</scene>");

            //strCodeForCs.AppendFormat("\r\n" + "<asp:scene ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objISOsceneENEx.IsoControlId);
            //if (string.IsNullOrEmpty(objISOsceneENEx.CssClass)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objISOsceneENEx.CssClass);
            //}
            //if (objISOsceneENEx.Width > 0)
            //{
            //    strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objISOsceneENEx.Width);
            //}
            //if (objISOsceneENEx.Height > 0)
            //{
            //    strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objISOsceneENEx.Height);
            //}
           
            //if (string.IsNullOrEmpty(objISOsceneENEx.Text)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("Text = \"{0}\"  ", objISOsceneENEx.Text);
            //}
            //if (string.IsNullOrEmpty(objISOsceneENEx.OnClick)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objISOsceneENEx.OnClick);
            //}
            //strCodeForCs.Append(">");

            //foreach (ISOControlEx objSubISOControlENEx in objISOsceneENEx.arrSubIsoControlLst2)
            //{
            //    objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:scene>");

        }
    }
}
