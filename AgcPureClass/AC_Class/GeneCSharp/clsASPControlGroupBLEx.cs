
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPControlGroupBLEx
表名:ASPNETControlGroup(00050220)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:32
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;


using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsASPControlGroupBLEx_Static
    {
        public static void GeneCode(this ASPControlGroupEx objASPControlGroupENEx, StringBuilder strCodeForCs)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty( objASPControlGroupENEx.GroupName) == false)
            {
                strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode(strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode(strCodeForCs);
                }
            }
            //strCodeForCs.Append("\r\n" + "</td>");

        }

        public static void GeneCode4Mvc(this ASPControlGroupEx objASPControlGroupENEx, StringBuilder strCodeForCs)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty(objASPControlGroupENEx.GroupName) == false)
            {
                strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
                }
            }
            //strCodeForCs.Append("\r\n" + "</td>");

        }

        public static void GeneHtmlControl(this ASPControlGroupEx objASPControlGroupENEx, HtmlContainerControl objContainer)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty(objASPControlGroupENEx.GroupName) == false)
            {
                HtmlGenericControl objDiv = new HtmlGenericControl("div");
                objDiv.Attributes["class"] = "btn-group";
                objDiv.Attributes["role"] = "group";
                objDiv.Attributes["aria-label"] = "Basic example";
                objContainer.Controls.Add(objDiv);
                //strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    //               objSubASPControlENEx.GeneCode(strCodeForCs);
                    objSubASPControlENEx.GeneHtmlControl(objDiv);
                    //objDiv.Controls.Add(objControl);
                }
                //return objDiv;
                //strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneHtmlControl(objContainer);
                    //HtmlControl objControl = objSubASPControlENEx.GeneHtmlControl();
                    //objDiv.Controls.Add(objControl);
                    //return objSubASPControlENEx.GeneHtmlControl(objDiv);
                }
            }
            //return null;
            //strCodeForCs.Append("\r\n" + "</td>");

        }

    }
    /// <summary>
    /// ASPNET列(ASPNETControlGroup)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPControlGroupBLEx
    {

        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public static ASPCheckBoxEx GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {


            //生成CheckBox的代码;

            //生成控件的<Id>

            ASPCheckBoxEx objControl = new ASPCheckBoxEx();
            objControl.CtrlId = strCheckId;

            //生成<控件样式Style>
            //生成<高度>和<宽度>
            objControl.Width = objCheckStyle.Width;
            objControl.Height = objCheckStyle.Height;
            //strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
            //  objCheckStyle.Style_Zindex,
            //  objCheckStyle.Width, objCheckStyle.Height);
            //生成运行模式是否在服务器运行
            objControl.Runat = objCheckStyle.Runat;
            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
            //  objCheckStyle.Runat);


            //生成<显示文本> 
            objControl.Text = strCheckText;
            //strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);


            //生成<样式>
            objControl.CssClass = "Check_Defa";
            //strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");
            return objControl;


        }
      
            public static ASPControlGroupEx PackageTd(ASPControlGroupEx objGroup)
        {
            
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            foreach(ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.arrSubAspControlLst2.Add(objInfor);
                objASPControlGroupENEx.arrSubAspControlLst2.Add(objCol);
            }
            return objASPControlGroupENEx;
        }

        public static ASPControlGroupEx PackageTr(ASPControlGroupEx objGroup)
        {

            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            ASPRowEx objRow = clsASPRowBLEx.GetEmptyTr();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objRow);

            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.arrSubAspControlLst2.Add(objInfor);
                objRow.arrSubAspControlLst2.Add(objCol);
            }
            int intCount = objGroup.arrSubAspControlLst2.Count;
            while (intCount<=4)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
              
                objRow.arrSubAspControlLst2.Add(objCol);
                intCount++;
            }
            return objASPControlGroupENEx;
        }
        public static ASPControlGroupEx PackageTr4Wuc(ASPControlGroupEx objGroup)
        {

            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            ASPRowEx objRow = clsASPRowBLEx.GetEmptyTr();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objRow);
            int intCount = 0;
            List<string> arrClass = new List<string>() { "NameTD", "ValueTD", "", "" };
            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.Class = arrClass[intCount++];

                if (objInfor.GetType() == typeof(ASPCheckBoxEx))           
                {
                    
                    objRow.arrSubAspControlLst2.Add(objCol);

                    objCol = clsASPColBLEx.GetEmptyTd();
                    objCol.Class = arrClass[intCount++];
                    objCol.arrSubAspControlLst2.Add(objInfor);
                    objRow.arrSubAspControlLst2.Add(objCol);

                }
                else
                {
                    objCol.arrSubAspControlLst2.Add(objInfor);
                    objRow.arrSubAspControlLst2.Add(objCol);
                }
            }
            //intCount = objGroup.arrSubAspControlLst2.Count;
            while (intCount < 4)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.Class = arrClass[intCount++];
                objRow.arrSubAspControlLst2.Add(objCol);
        
            }
            return objASPControlGroupENEx;
        }
      

        public static ASPControlGroupEx GetControlGroup_Asp(clsQryRegionFldsENEx objQryRegionFldsEx, string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();

            ASPLabelEx objLabel = new ASPLabelEx();
            objLabel.Is4PureHtml = bolIs4PureHtml;
            objLabel.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.FldName);
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;
            objLabel.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
            objLabel.ItemName4MultiModel = strItemName4MultiModel;

            objLabel.TabName = objQryRegionFldsEx.TabName;
            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            objLabel.CssClass = "col-form-label text-right";
            objLabel.Style = "width:80px;";
            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objQryRegionFldsEx.LabelCaption;

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPCheckBoxENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPCheckBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPCheckBoxENEx.TabName = objQryRegionFldsEx.TabName;

                    objASPCheckBoxENEx.Width = 200;
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control";

                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPCheckBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPTextBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPTextBoxENEx.TabName = objQryRegionFldsEx.TabName;

                    objASPTextBoxENEx.Width = 200;
                    //objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.CssClass = "form-control";
                    objASPTextBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListENEx.CtrlId = string.Format("ddl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPDropDownListENEx.TabName = objQryRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objQryRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objQryRegionFldsEx.DS_TabName;

                    objASPDropDownListENEx.Width = 200;
                    //objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.CssClass = "form-control";
                    objASPDropDownListENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListENEx);
                    break;
                default:
                    string strMsg = string.Format("查询区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

            return objASPControlGroupENEx;
        }

        public static ASPControlGroupEx GetControlGroup_Asp(clsEditRegionFldsENEx objEditRegionFldsEx, bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();

            ASPLabelEx objLabel = new ASPLabelEx();
            objLabel.Is4PureHtml = bolIs4PureHtml;
            objLabel.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.FldName);
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;

            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //  objLabel.CssClass = "text-secondary text-right";
            objLabel.CssClass = "col-form-label text-right";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objEditRegionFldsEx.LabelCaption;

            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPCheckBoxENEx.Width = 200;
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control";
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPCheckBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Width = 200;
                    //objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.CssClass = "form-control";
                    objASPTextBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListENEx.CtrlId = string.Format("ddl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Width = 200;
                    //objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.CssClass = "form-control";
                    objASPDropDownListENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    objASPDropDownListENEx.FldName = objEditRegionFldsEx.ObjPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objEditRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objEditRegionFldsEx.DS_TabName;

                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListENEx);
                    break;
                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            ASPCompareValidatorEx objCompareValidator = new ASPCompareValidatorEx();
            objCompareValidator.CtrlId = string.Format("ComValid_{0}", objEditRegionFldsEx.FldName);
            objCompareValidator.Runat = "server";
            objCompareValidator.CssClass = "ErrMsg";
            objCompareValidator.ControlToValidate = objEditRegionFldsEx.CtrlId;
            objCompareValidator.Operator = "DataTypeCheck";
            objCompareValidator.EnableClientScript = "false";
            //objCompareValidator.Runat = "server";

            switch (objEditRegionFldsEx.ObjPrjTabFldENEx.CSType)
            {
                case "int":
                case "short":
                case "long":
                    objCompareValidator.type = "Integer";
                    objCompareValidator.ErrorMessage = "请输入整型数值!";
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                    //    objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                    //strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                    break;
                case "DateTime":
                    objCompareValidator.type = "Date";
                    objCompareValidator.ErrorMessage = "请输入日期型数值!";
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                    //    objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                    //strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                    break;
                case "double":
                    objCompareValidator.type = "Double";
                    objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                    //    objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                    //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                    break;

                case "float":
                    objCompareValidator.type = "Double";
                    objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                    //    objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                    //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                    break;
            }
            return objASPControlGroupENEx;
        }

    

        /// <summary>
        /// 建立[空行td]
        /// </summary>
        /// <returns></returns>
        public static ASPControlGroupEx GetEmptyTd()
        {
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            //objASPControlGroupENEx.CtrlId = "tr1";         
            //objASPControlGroupENEx.Style = "width: 100%; height: 32px; ";
            //objASPControlGroupENEx.Class = "msgtable";
            return objASPControlGroupENEx;
        }

        public static ASPControlGroupEx GetbtnQuery(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = clsASPButtonBLEx.GetbtnQuery(bolIs4Mvc, bolIs4Ajax);

            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
            return objASPControlGroupENEx;
        }
        public static ASPControlGroupEx GetControlGroup(ASPControlEx objASPButtonENEx)
        {
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            objASPControlGroupENEx.OrderNum = objASPButtonENEx.OrderNum;
            objASPControlGroupENEx.GroupName = objASPButtonENEx.GroupName;

            objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
            return objASPControlGroupENEx;
        }
        /// <summary>
        /// 合并控件组，即把组名一样的控件，合并成一个组
        /// </summary>
        /// <param name="arrControlGroupLst"></param>
        /// <returns></returns>
        public static IEnumerable<ASPControlGroupEx> MergeControlGroup(List<ASPControlGroupEx> arrControlGroupLst)
        {
            int iLen = arrControlGroupLst.Count;
            //在设置字段值的按钮前按需要添加一个输入控件，用于输入一个值
            //for (int i = 0; i < iLen; i++)
            //{
            //    ASPControlGroupEx objInFor = arrControlGroupLst[i];
            //    ASPControlEx objASPButtonENEx = objInFor.arrSubAspControlLst2[0] as ASPControlEx;
            //    if (objASPButtonENEx.FeatureId == enumPrjFeature.SetFieldValue_0148
            //      && objASPButtonENEx.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
            //    {
            //        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds_Sub = arrvViewFeatureFlds.Where(x =>
            //        x.ViewFeatureId == objASPButtonENEx.ViewFeatureId).ToList();
            //        if (arrViewFeatureFlds_Sub.Count > 0)
            //        {
            //            clsvViewFeatureFldsENEx objViewFeatureFlds = arrViewFeatureFlds_Sub[0];
            //            ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
            //            objInFor.arrSubAspControlLst2.Insert(0, objASPDropDownListENEx);
            //        }
            //    }
            //}
            for (int i = 0; i < iLen; i++)
            {
                ASPControlGroupEx objInFor = arrControlGroupLst[i];
                if (objInFor._StrTag == "Delete") continue;
                if (string.IsNullOrEmpty(objInFor.GroupName) == false)
                {
                    for (int j = i + 1; j < iLen; j++)
                    {
                        ASPControlGroupEx objInFor_J = arrControlGroupLst[j];
                        if (objInFor_J.GroupName == objInFor.GroupName)
                        {
                            if (objInFor_J.OrderNum > objInFor.OrderNum) objInFor.OrderNum = objInFor_J.OrderNum;
                            foreach (ASPControlEx objInFor_Sub in objInFor_J.arrSubAspControlLst2)
                            {
                                objInFor.arrSubAspControlLst2.Add(objInFor_Sub);
                            }
                            objInFor_J._StrTag = "Delete";
                        }
                    }
                }
            }
            IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = arrControlGroupLst.Where(x => x._StrTag != "Delete").OrderBy(x => x.OrderNum);
            return arrControlGroupLst_New;
        }
    }
}
