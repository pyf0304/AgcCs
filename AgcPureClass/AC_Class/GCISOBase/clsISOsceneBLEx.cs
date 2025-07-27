using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOsceneBLEx_Static
    {
        public static void GeneCode(this ISOsceneEx objISOsceneENEx, StringBuilder strCodeForCs)
        {
            //string strsceneId = AgcPubFun.getSwiftID();

            strCodeForCs.AppendFormat("\r\n" + "<!--{0}-->", objISOsceneENEx.Text);
         
            strCodeForCs.AppendFormat("\r\n" + "<scene sceneID=\"{0}\">",
                objISOsceneENEx.IsoControlId);
            strCodeForCs.Append("\r\n" + "<objects>");
            foreach (ISOControlEx objSubISOControlENEx in objISOsceneENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
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
            //    objSubISOControlENEx.GeneCode(strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:scene>");

        }
    }
}
