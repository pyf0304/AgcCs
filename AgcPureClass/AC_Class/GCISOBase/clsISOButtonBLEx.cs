using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{

    public static class clsISOButtonBLEx_Static
    {
        public static void GeneCode(this ISOButtonEx objISOButtonENEx, StringBuilder strCodeForCs)
        {

            //string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            string strKey = "";
            if (string.IsNullOrEmpty(objISOButtonENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objISOButtonENEx.mKey);
            }
            strCodeForCs.AppendFormat("\r\n" + " <button {1} opaque=\"NO\" contentMode=\"scaleToFill\" ambiguous=\"YES\" contentHorizontalAlignment=\"left\" contentVerticalAlignment=\"center\" buttonType=\"roundedRect\" lineBreakMode=\"middleTruncation\" translatesAutoresizingMaskIntoConstraints=\"NO\" id=\"{0}\">",
                objISOButtonENEx.IsoControlId, strKey);
            strCodeForCs.AppendFormat("\r\n" + "<rect key=\"frame\" x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\"/>",
                objISOButtonENEx.x,
                objISOButtonENEx.y,
                objISOButtonENEx.Width,
                objISOButtonENEx.Height);

            int intNum_AutoresizingMask = objISOButtonENEx.getSubObjNumForCtlTypeId(            enumCtlTypeAbbr.ISOAutoresizingMask_34);
            if (intNum_AutoresizingMask > 0)
            {
                foreach (ISOControlEx objSubISOControlENEx in objISOButtonENEx.arrSubIsoControlLst2)
                {
                    if (objSubISOControlENEx.CtlTypeId != enumCtlTypeAbbr.ISOAutoresizingMask_34) continue;
                    objSubISOControlENEx.GeneCode(strCodeForCs);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "<state key=\"normal\" title=\"{0}\"/>",
                objISOButtonENEx.Text);
            int intNum_Action = objISOButtonENEx.getSubObjNumForCtlTypeId(             enumCtlTypeAbbr.ISOAction_33);
            if (intNum_Action > 0)
            {
                strCodeForCs.Append("\r\n" + "<connections>");
                foreach (ISOControlEx objSubISOControlENEx in objISOButtonENEx.arrSubIsoControlLst2)
                {
                    if (objSubISOControlENEx.CtlTypeId != enumCtlTypeAbbr.ISOAction_33) continue;
                    objSubISOControlENEx.GeneCode(strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</connections>");
            }
            //strCodeForCs.Append("\r\n" + "<connections>");
            //strCodeForCs.AppendFormat("\r\n" + "<action selector=\"btn{0}_Click:\" destination=\"{1}\" eventType=\"touchDown\" id=\"{2}\"/>",
            //    objISOButtonENEx.IsoControlName, objISOButtonENEx.ParentViewControllerID, strActionId);
            //strCodeForCs.Append("\r\n" + "</connections>");          
            strCodeForCs.Append("\r\n" + "</button>");

            //strCodeForCs.AppendFormat("\r\n" + "<asp:Button ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objISOButtonENEx.IsoControlId);
            //if (string.IsNullOrEmpty(objISOButtonENEx.CssClass)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objISOButtonENEx.CssClass);
            //}
            //if (objISOButtonENEx.Width > 0)
            //{
            //    strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objISOButtonENEx.Width);
            //}
            //if (objISOButtonENEx.Height > 0)
            //{
            //    strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objISOButtonENEx.Height);
            //}

            //if (string.IsNullOrEmpty(objISOButtonENEx.Text)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("Text = \"{0}\"  ", objISOButtonENEx.Text);
            //}
            //if (string.IsNullOrEmpty(objISOButtonENEx.OnClick)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objISOButtonENEx.OnClick);
            //}
            //strCodeForCs.Append(">");

            //foreach (ISOControlEx objSubISOControlENEx in objISOButtonENEx.arrSubIsoControlLst2)
            //{
            //    objSubISOControlENEx.GeneCode(strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:Button>");

        }

    }
    public class clsISOButtonBLEx 
    {
        }
}
