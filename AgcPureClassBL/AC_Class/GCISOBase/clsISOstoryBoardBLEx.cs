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
    public static class clsISOstoryBoardBLEx_Static
    {
        public static void GeneCode(this ISOstoryBoardEx objISOstoryBoardENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //string strstoryBoardId = AgcPubFun.getSwiftID();

            strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            strCodeForCs.Append("\r\n" + "<document type=\"com.apple.InterfaceBuilder3.CocoaTouch.Storyboard.XIB\" version=\"3.0\" toolsVersion=\"13196\" targetRuntime=\"iOS.CocoaTouch\" propertyAccessControl=\"none\" useAutolayout=\"YES\" useTraitCollections=\"YES\" useSafeAreas=\"YES\" colorMatched=\"YES\">");
            strCodeForCs.Append("\r\n" + "<device id=\"retina4_7\" orientation=\"portrait\">");
            strCodeForCs.Append("\r\n" + "<adaptation id=\"fullscreen\"/>");
            strCodeForCs.Append("\r\n" + "</device>");
            strCodeForCs.Append("\r\n" + "<dependencies>");
            strCodeForCs.Append("\r\n" + "<deployment identifier=\"iOS\"/>");
            strCodeForCs.Append("\r\n" + "<plugIn identifier=\"com.apple.InterfaceBuilder.IBCocoaTouchPlugin\" version=\"13，174\"/>");
            strCodeForCs.Append("\r\n" + "<capability name=\"Safe area layout guides\" minToolsVersion=\"9.0\"/>");
            strCodeForCs.Append("\r\n" + "<capability name=\"documents saved in the Xcode 8 format\" minToolsVersion=\"8.0\"/>");
            strCodeForCs.Append("\r\n" + "</dependencies>");
            strCodeForCs.Append("\r\n" + "<scenes>");
            foreach (ISOControlEx objSubISOControlENEx in objISOstoryBoardENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</scenes>");
            strCodeForCs.Append("\r\n" + "</document>");

            //strCodeForCs.AppendFormat("\r\n" + "<asp:storyBoard ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objISOstoryBoardENEx.IsoControlId);
            //if (string.IsNullOrEmpty(objISOstoryBoardENEx.CssClass)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objISOstoryBoardENEx.CssClass);
            //}
            //if (objISOstoryBoardENEx.Width > 0)
            //{
            //    strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objISOstoryBoardENEx.Width);
            //}
            //if (objISOstoryBoardENEx.Height > 0)
            //{
            //    strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objISOstoryBoardENEx.Height);
            //}
           
            //if (string.IsNullOrEmpty(objISOstoryBoardENEx.Text)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("Text = \"{0}\"  ", objISOstoryBoardENEx.Text);
            //}
            //if (string.IsNullOrEmpty(objISOstoryBoardENEx.OnClick)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objISOstoryBoardENEx.OnClick);
            //}
            //strCodeForCs.Append(">");

            //foreach (ISOControlEx objSubISOControlENEx in objISOstoryBoardENEx.arrSubIsoControlLst2)
            //{
            //    objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:storyBoard>");

        }
    }
}
