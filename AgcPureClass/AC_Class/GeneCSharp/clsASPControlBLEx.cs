
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPControlBLEx
表名:ASPNETControl
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections.Generic;
using com.taishsoft.common;
using AGC.PureClass;
using AGC.DAL;
using AGC.BusinessLogic;
using System.Reflection;
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{

    public static class clsASPControlBLEx_Static
    {
        public static string GC_ViewModel(this  IEnumerable<ASPControlEx> arrControls)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            foreach (ASPControlEx objASPControl in arrControls)
            {
                string strFldName = objASPControl.FldName;
                string strCaption = objASPControl.Caption;
                string strCSType = objASPControl.CSType;

                strCodeForCs.AppendFormat("\r\n" + "[DisplayName(\"{0}\")]",
                    strCaption);
                strCodeForCs.AppendFormat("\r\n" + "[Required(ErrorMessage = \"请输入:{0}\")]",
                    strCaption);
                if (objASPControl.CtlTypeId == enumCtlTypeAbbr.DropDownList_Bool_18)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public string {1} {{ get; set; }}",
                     strCSType, strFldName);
                }
                else if (objASPControl.CtlTypeId == enumCtlTypeAbbr.DropDownList_06)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                        strCSType, strFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                    strCSType, strFldName);
                }
            }
            return strCodeForCs.ToString();
        }
        public static string GC_SetDefaultValue(this ASPControlEx objASPControlENEx)
        {
            string strCode = "";
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPControlEx":
                    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GC_SetDefaultValue();
                    }
                    break;
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    strCode = objASPControlGroupENEx.GC_SetDefaultValue();
                    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    strCode = objASPUlENEx.GC_SetDefaultValue();
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    strCode = objASPLiENEx.GC_SetDefaultValue();
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    strCode = objASPCodeENEx.GC_SetDefaultValue();
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                    strCode = objASPEmptyENEx.GC_SetDefaultValue();
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                    strCode = objASPSpanENEx.GC_SetDefaultValue();
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    strCode = objASPHeadENEx.GC_SetDefaultValue();
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    strCode = objASPBodyENEx.GC_SetDefaultValue();
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    strCode = objASPFormENEx.GC_SetDefaultValue();
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                    strCode = objASPHtmlTableENEx.GC_SetDefaultValue();
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                    strCode = objASPRowENEx.GC_SetDefaultValue();
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                    strCode = objASPColENEx.GC_SetDefaultValue();
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    strCode = objASPDivENEx.GC_SetDefaultValue();
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    strCode = objASPLabelENEx.GC_SetDefaultValue();
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    strCode = objASPTextBoxENEx.GC_SetDefaultValue();
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    strCode = objASPButtonENEx.GC_SetDefaultValue();
                    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                    strCode = objASPLinkButtonENEx.GC_SetDefaultValue();
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    strCode = objASPCheckBoxENEx.GC_SetDefaultValue();
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    strCode = objASPGridViewENEx.GC_SetDefaultValue();
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                    strCode = objASPTemplateFieldENEx.GC_SetDefaultValue();
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    strCode = objASPHeaderStyleENEx.GC_SetDefaultValue();
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    strCode = objASPHeaderTemplateENEx.GC_SetDefaultValue();
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                    strCode = objASPItemTemplateENEx.GC_SetDefaultValue();
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    strCode = objASPBoundFieldENEx.GC_SetDefaultValue();
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                    strCode = objASPWebUserControlENEx.GC_SetDefaultValue();
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                    strCode = objASPPagerTemplateENEx.GC_SetDefaultValue();
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                    strCode = objASPHrENEx.GC_SetDefaultValue();
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                    strCode = objASPHtmlButtonENEx.GC_SetDefaultValue();
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                    strCode = objASPHiddenFieldENEx.GC_SetDefaultValue();
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    strCode = objASPHtmlInputENEx.GC_SetDefaultValue();
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                    strCode = objASPH4ENEx.GC_SetDefaultValue();
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    strCode = objASPDropDownListENEx.GC_SetDefaultValue();
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                    strCode = objASPCompareValidatorENEx.GC_SetDefaultValue();
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!(In {1})", strType, clsStackTrace.GetCurrClassFunction()));
            }
            return strCode;
        }


        public static string GC_DefFldProperty(this ASPControlEx objASPControlENEx)
        {
            string strCode = "";
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPControlEx":
                    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GC_DefFldProperty();
                    }
                    break;
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    strCode = objASPControlGroupENEx.GC_DefFldProperty();
                    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    strCode = objASPUlENEx.GC_DefFldProperty();
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    strCode = objASPLiENEx.GC_DefFldProperty();
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    strCode = objASPCodeENEx.GC_DefFldProperty();
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                    strCode = objASPEmptyENEx.GC_DefFldProperty();
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                    strCode = objASPSpanENEx.GC_DefFldProperty();
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    strCode = objASPHeadENEx.GC_DefFldProperty();
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    strCode = objASPBodyENEx.GC_DefFldProperty();
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    strCode = objASPFormENEx.GC_DefFldProperty();
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                    strCode = objASPHtmlTableENEx.GC_DefFldProperty();
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                    strCode = objASPRowENEx.GC_DefFldProperty();
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                    strCode = objASPColENEx.GC_DefFldProperty();
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    strCode = objASPDivENEx.GC_DefFldProperty();
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    strCode = objASPLabelENEx.GC_DefFldProperty();
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    strCode = objASPTextBoxENEx.GC_DefFldProperty();
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    strCode = objASPButtonENEx.GC_DefFldProperty();
                    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                    strCode = objASPLinkButtonENEx.GC_DefFldProperty();
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    strCode = objASPCheckBoxENEx.GC_DefFldProperty();
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    strCode = objASPGridViewENEx.GC_DefFldProperty();
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                    strCode = objASPTemplateFieldENEx.GC_DefFldProperty();
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    strCode = objASPHeaderStyleENEx.GC_DefFldProperty();
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    strCode = objASPHeaderTemplateENEx.GC_DefFldProperty();
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                    strCode = objASPItemTemplateENEx.GC_DefFldProperty();
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    strCode = objASPBoundFieldENEx.GC_DefFldProperty();
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                    strCode = objASPWebUserControlENEx.GC_DefFldProperty();
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                    strCode = objASPPagerTemplateENEx.GC_DefFldProperty();
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                    strCode = objASPHrENEx.GC_DefFldProperty();
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                    strCode = objASPHtmlButtonENEx.GC_DefFldProperty();
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                    strCode = objASPHiddenFieldENEx.GC_DefFldProperty();
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    strCode = objASPHtmlInputENEx.GC_DefFldProperty();
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                    strCode = objASPH4ENEx.GC_DefFldProperty();
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    strCode = objASPDropDownListENEx.GC_DefFldProperty();
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                    strCode = objASPCompareValidatorENEx.GC_DefFldProperty();
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!(In {1})", strType, clsStackTrace.GetCurrClassFunction()));
            }
            return strCode;
        }

        /// <summary>
        /// 把一个编辑区的字段转变成一个控件
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>

        public static void GeneCode(this ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPControlEx":
                    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode(strCodeForCs);
                    }
                    break;
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    objASPControlGroupENEx.GeneCode(strCodeForCs);
                    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    objASPUlENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    objASPLiENEx.GeneCode( strCodeForCs);
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    objASPCodeENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                    objASPEmptyENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                    objASPSpanENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    objASPHeadENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    objASPBodyENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    objASPFormENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                    objASPHtmlTableENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                    objASPRowENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                    objASPColENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    objASPDivENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    objASPLabelENEx.GeneCode( strCodeForCs);
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    objASPTextBoxENEx.GeneCode( strCodeForCs);
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    objASPButtonENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                    objASPLinkButtonENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    objASPCheckBoxENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    objASPGridViewENEx.GeneCode(strCodeForCs);
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                    objASPTemplateFieldENEx.GeneCode( strCodeForCs);
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    objASPHeaderStyleENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    objASPHeaderTemplateENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                    objASPItemTemplateENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    objASPBoundFieldENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                    objASPWebUserControlENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                    objASPPagerTemplateENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                    objASPHrENEx.GeneCode( strCodeForCs);
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                    objASPHtmlButtonENEx.GeneCode( strCodeForCs);
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                    objASPHiddenFieldENEx.GeneCode( strCodeForCs);
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    objASPHtmlInputENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                    objASPH4ENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    objASPDropDownListENEx.GeneCode(strCodeForCs);
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                    objASPCompareValidatorENEx.GeneCode(strCodeForCs);
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!(In {1})", strType, clsStackTrace.GetCurrClassFunction()));
            }
        }

        public static void GeneCode4Mvc(this ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPControlEx":
                    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
                    }
                    break;
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    objASPControlGroupENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    objASPUlENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    objASPLiENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    objASPCodeENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                    objASPEmptyENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                    objASPSpanENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    objASPHeadENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    objASPBodyENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    objASPFormENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                    objASPHtmlTableENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                    objASPRowENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                    objASPColENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    objASPDivENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    objASPLabelENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    objASPTextBoxENEx.GeneCode4Mvc(strCodeForCs);
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    objASPButtonENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                    objASPLinkButtonENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    objASPCheckBoxENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    objASPGridViewENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                    objASPTemplateFieldENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    objASPHeaderStyleENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    objASPHeaderTemplateENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                    objASPItemTemplateENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    objASPBoundFieldENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                    objASPWebUserControlENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                    objASPPagerTemplateENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                    objASPHrENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                    objASPHtmlButtonENEx.GeneCode4Mvc(strCodeForCs);
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                    objASPHiddenFieldENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    objASPHtmlInputENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                    objASPH4ENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    objASPDropDownListENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                    objASPCompareValidatorENEx.GeneCode4Mvc(strCodeForCs);
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!(In {1})", strType, clsStackTrace.GetCurrClassFunction()));
            }
        }

        public static void GeneHtmlControl(this ASPControlEx objASPControlENEx, HtmlContainerControl objContainer)
        {
            string strType = objASPControlENEx.GetType().Name;
            //clsPubVar4BLEx.objLog4GC.WriteDebugLog(strType);
            switch (strType)
            {
                //case "ASPControlEx":
                //    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                //    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                //    {
                //return        objSubASPControlENEx.GeneHtmlControl();
                //    }
                //    return null;
         
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    objASPControlGroupENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    objASPUlENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    objASPLiENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    objASPCodeENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                     objASPEmptyENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                     objASPSpanENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                     objASPHeadENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                     objASPBodyENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                     objASPFormENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                     objASPHtmlTableENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                     objASPRowENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                     objASPColENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                     objASPDivENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                     objASPLabelENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                     objASPTextBoxENEx.GeneHtmlControl(objContainer);
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                     objASPButtonENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                     objASPLinkButtonENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                     objASPCheckBoxENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                     objASPGridViewENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                     objASPTemplateFieldENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                     objASPHeaderStyleENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                     objASPHeaderTemplateENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                     objASPItemTemplateENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                     objASPBoundFieldENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                     objASPWebUserControlENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                     objASPPagerTemplateENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                     objASPHrENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                     objASPHtmlButtonENEx.GeneHtmlControl(objContainer);
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                     objASPHiddenFieldENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    objASPHtmlInputENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                     objASPH4ENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                     objASPDropDownListENEx.GeneHtmlControl(objContainer);
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                     objASPCompareValidatorENEx.GeneHtmlControl(objContainer);
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!(In {1})", strType, clsStackTrace.GetCurrClassFunction()));
            }
        }

    }
    /// <summary>
    /// ASPNET控件(ASPNETControl)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPControlBLEx 
    {               
        public static bool InitStyleObj()
        {
            ASPControlEx.objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleId_Cache("0001");
            ASPControlEx.objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleId_Cache("0001");
            ASPControlEx.objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleId_Cache("0001");
            ASPControlEx.objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleId_Cache("0001");
            return true;
    }

        public static ASPControlEx GetControl_Asp(clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            //ASPControlEx objControl = new ASPControlEx();

            //objControl.CtrlId = objEditRegionFldsEx.CtrlId;
            //objControl.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objControl.Height = ASPControlEx.objLabelStyle_Text.Height;

            //objControl.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //objControl.Caption = objEditRegionFldsEx.LabelCaption;
            //objControl.CSType = objEditRegionFldsEx.objPrjTabFldENEx.CSType;
            //objControl.FldName = objEditRegionFldsEx.FldName;


            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPCheckBoxENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.CSType = objEditRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPCheckBoxENEx.FldName = objEditRegionFldsEx.FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPCheckBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPCheckBoxENEx;



                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPTextBoxENEx.CSType = objEditRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPTextBoxENEx.FldName = objEditRegionFldsEx.FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.Class = "ValueControl";
                    objASPTextBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;

                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new  ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("ddl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPDropDownListENEx.CSType = objEditRegionFldsEx.ObjPrjTabFldENEx.CSType;
               
                    objASPDropDownListENEx.FldName = objEditRegionFldsEx.ObjPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objEditRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objEditRegionFldsEx.DS_TabName;

                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPDropDownListENEx;

                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        public static ASPControlEx GetControl_Asp(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            //ASPControlEx objControl = new ASPControlEx();

            //objControl.CtrlId = objQryRegionFldsEx.CtrlId;
            //objControl.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objControl.Height = ASPControlEx.objLabelStyle_Text.Height;

            //objControl.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //objControl.Caption = objQryRegionFldsEx.LabelCaption;
            //objControl.CSType = objQryRegionFldsEx.objPrjTabFldENEx.CSType;
            //objControl.FldName = objQryRegionFldsEx.FldName;


            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPCheckBoxENEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.CSType = objQryRegionFldsEx.objPrjTabFldENEx.CSType;
                    objASPCheckBoxENEx.FldName = objQryRegionFldsEx.FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPCheckBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPCheckBoxENEx;



                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPTextBoxENEx.CSType = objQryRegionFldsEx.objPrjTabFldENEx.CSType;
                    objASPTextBoxENEx.FldName = objQryRegionFldsEx.FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.Class = "ValueControl";
                    objASPTextBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;

                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("ddl{0}", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPDropDownListENEx.CSType = objQryRegionFldsEx.objPrjTabFldENEx.CSType;
          
                    objASPDropDownListENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objQryRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objQryRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objQryRegionFldsEx.DS_TabName;

                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPDropDownListENEx;

                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        public static void GeneCodeBak(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;

            string strClassName = strType.Replace("ENEx", "BLEx");// objvFunction4GeneCodeEN.FuncName;
            strClassName = string.Format("AGC.PureClassEx.{0}", strClassName);
            string strFuncName = "GeneCode";
            try
            {
                string strCode = "";
                Type expType = Type.GetType(strClassName);
                if (expType == null)
                {
                    string strMsg = string.Format("类型:{0}不存在，请检查！", strClassName);
                    throw new Exception(strMsg);
                }

                //Type t = typeof(BusinessLogic4CSharp);
              
                MethodInfo mt = expType.GetMethod(strFuncName, BindingFlags.Static | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    //if (mt.GetParameters().Length == 0)
                    //{
                    //    strCode = (string)mt.Invoke(this, null);
                    //}
                    //else if (mt.GetParameters().Length == 1)
                    //{
                        mt.Invoke(null, new object[] { objASPControlENEx, strCodeForCs });
                    //}
                    //Console.WriteLine(str);
                }

                //return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

            //switch (strType)
            //{
            //    case "ASPUlEx":
            //        ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
            //        clsASPUlBLEx.GeneCode(objASPUlENEx, strCodeForCs);
            //        break;
            //    case "ASPLiEx":
            //        ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
            //        clsASPLiBLEx.GeneCode(objASPLiENEx, strCodeForCs);
            //        break;

            //    case "ASPCodeEx":
            //        ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
            //        clsASPCodeBLEx.GeneCode(objASPCodeENEx, strCodeForCs);
            //        break;
            //    case "ASPEmptyEx":
            //        ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
            //        clsASPEmptyBLEx.GeneCode(objASPEmptyENEx, strCodeForCs);
            //        break;
            //    case "ASPSpanEx":
            //        ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
            //        clsASPSpanBLEx.GeneCode(objASPSpanENEx, strCodeForCs);
            //        break;
            //    case "ASPHeadEx":
            //        ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
            //        clsASPHeadBLEx.GeneCode(objASPHeadENEx, strCodeForCs);
            //        break;
            //    case "ASPBodyEx":
            //        ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
            //        clsASPBodyBLEx.GeneCode(objASPBodyENEx, strCodeForCs);
            //        break;
            //    case "ASPFormEx":
            //        ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
            //        clsASPFormBLEx.GeneCode(objASPFormENEx, strCodeForCs);
            //        break;
            //    case "ASPHtmlTableEx":
            //        ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
            //        clsASPHtmlTableBLEx.GeneCode(objASPHtmlTableENEx, strCodeForCs);
            //        break;
            //    case "ASPRowEx":
            //        ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
            //        clsASPRowBLEx.GeneCode(objASPRowENEx, strCodeForCs);
            //        break;
            //    case "ASPColEx":
            //        ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
            //        clsASPColBLEx.GeneCode(objASPColENEx, strCodeForCs);
            //        break;
            //    case "ASPDivEx":
            //        ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
            //        clsASPDivBLEx.GeneCode(objASPDivENEx, strCodeForCs);
            //        break;
            //    case "ASPLabelEx":
            //        ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
            //        clsASPLabelBLEx.GeneCode(objASPLabelENEx, strCodeForCs);
            //        break;

            //    case "ASPTextBoxEx":
            //        ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
            //        clsASPTextBoxBLEx.GeneCode(objASPTextBoxENEx, strCodeForCs);
            //        break;


            //    case "ASPButtonEx":
            //        ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
            //        clsASPButtonBLEx.GeneCode(objASPButtonENEx, strCodeForCs);
            //        break;
            //    case "ASPLinkButtonEx":
            //        ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
            //        clsASPLinkButtonBLEx.GeneCode(objASPLinkButtonENEx, strCodeForCs);
            //        break;
            //    case "ASPCheckBoxEx":
            //        ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
            //        clsASPCheckBoxBLEx.GeneCode(objASPCheckBoxENEx, strCodeForCs);
            //        break;
            //    case "ASPGridViewEx":
            //        ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
            //        clsASPGridViewBLEx.GeneCode(objASPGridViewENEx, strCodeForCs);
            //        break;

            //    case "ASPTemplateFieldEx":
            //        ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
            //        clsASPTemplateFieldBLEx.GeneCode(objASPTemplateFieldENEx, strCodeForCs);
            //        break;

            //    case "ASPHeaderStyleEx":
            //        ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
            //        clsASPHeaderStyleBLEx.GeneCode(objASPHeaderStyleENEx, strCodeForCs);
            //        break;
            //    case "ASPHeaderTemplateEx":
            //        ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
            //        clsASPHeaderTemplateBLEx.GeneCode(objASPHeaderTemplateENEx, strCodeForCs);
            //        break;
            //    case "ASPItemTemplateEx":
            //        ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
            //        clsASPItemTemplateBLEx.GeneCode(objASPItemTemplateENEx, strCodeForCs);
            //        break;
            //    case "ASPBoundFieldEx":
            //        ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
            //        clsASPBoundFieldBLEx.GeneCode(objASPBoundFieldENEx, strCodeForCs);
            //        break;
            //    case "ASPWebUserControlEx":
            //        ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
            //        clsASPWebUserControlBLEx.GeneCode(objASPWebUserControlENEx, strCodeForCs);
            //        break;
            //    case "ASPPagerTemplateEx":
            //        ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
            //        clsASPPagerTemplateBLEx.GeneCode(objASPPagerTemplateENEx, strCodeForCs);
            //        break;
            //    case "ASPHrEx":
            //        ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
            //        clsASPHrBLEx.GeneCode(objASPHrENEx, strCodeForCs);
            //        break;

            //    case "ASPHtmlButtonEx":
            //        ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
            //        clsASPHtmlButtonBLEx.GeneCode(objASPHtmlButtonENEx, strCodeForCs);
            //        break;

            //    case "ASPHiddenFieldEx":
            //        ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
            //        clsASPHiddenFieldBLEx.GeneCode(objASPHiddenFieldENEx, strCodeForCs);
            //        break;
            //    default:
            //        throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            //}
        }

     
        public static int getSubObjNumForCtlTypeId(ASPControlEx objASPControlENEx, string strCtlTypeId)
        {
            int intNum = 0;
            foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
            {
                if (objSubASPControlENEx.CtlTypeId == strCtlTypeId) intNum++;

            }
            return intNum;
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Size(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPControlENEx.Width>0)
            {
                strCodeForCs.AppendFormat(" Width=\"{0}px\"",
                objASPControlENEx.Width);
            }
            //if (objASPControlENEx.Height>0)
            //{
            //    strCodeForCs.AppendFormat(" Height=\"{0}px\"",
            //    objASPControlENEx.Height);
            //}
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Style(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPControlENEx.Style);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" CssClass=\"{0}\"",
                    objASPControlENEx.CssClass);
            }
            else if (string.IsNullOrEmpty(objASPControlENEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPControlENEx.Class);
            }
        }

        /// <summary>
        /// 生成该对象runat相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Runat(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.Runat) == false)
            {
                strCodeForCs.AppendFormat(" runat=\"{0}\"",
                    objASPControlENEx.Runat);
            }
        }

        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Type(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.type) == false)
            {
                strCodeForCs.AppendFormat(" type=\"{0}\"",
                objASPControlENEx.type);
            }
        }


        /// <summary>
        /// 生成该对象data-dismiss相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Data_dismiss(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.data_dismiss) == false)
            {
                strCodeForCs.AppendFormat(" data-dismiss=\"{0}\"",
                objASPControlENEx.data_dismiss);
            }
        }

        /// <summary>
        /// 生成该对象tabindex相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Tabindex(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.tabindex) == false)
            {
                strCodeForCs.AppendFormat(" tabindex=\"{0}\"",
                objASPControlENEx.tabindex);
            }
        }

        /// <summary>
        /// 生成该对象aria-labelledby相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Aria_labelledby(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.aria_labelledby) == false)
            {
                strCodeForCs.AppendFormat(" aria-labelledby=\"{0}\"",
                objASPControlENEx.aria_labelledby);
            }
        }

        /// <summary>
        /// 生成该对象aria-label相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Aria_label(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.aria_label) == false)
            {
                strCodeForCs.AppendFormat(" aria-label=\"{0}\"",
                objASPControlENEx.aria_label);
            }
        }

        /// <summary>
        /// 生成该对象aria-hidden相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Aria_hidden(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.aria_hidden) == false)
            {
                strCodeForCs.AppendFormat(" aria-hidden=\"{0}\"",
                objASPControlENEx.aria_hidden);
            }
        }

        /// <summary>
        /// 生成该对象role相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Role(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.role) == false)
            {
                strCodeForCs.AppendFormat(" role=\"{0}\"",
                objASPControlENEx.role);
            }
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Tag(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.Tag) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:tag=\"{0}\"",
                objASPControlENEx.Tag);
            }
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Text(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.Text) == false)
            {
                strCodeForCs.AppendFormat(" Text=\"{0}\"",
                       objASPControlENEx.Text);
            }
        
        }

        /// <summary>
        /// 生成该对象值(Value)相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Value(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPControlENEx.Value);
            }

        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4IdName(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat(" id=\"{0}\"",
                objASPControlENEx.CtrlId);
            }

            if (string.IsNullOrEmpty(objASPControlENEx.CtrlName) == false)
            {
                strCodeForCs.AppendFormat(" name=\"{0}\"",
                objASPControlENEx.CtrlName);
            }
            else if (string.IsNullOrEmpty(objASPControlENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat(" name=\"{0}\"",
            objASPControlENEx.CtrlId);
            }
        }
        public static void GC4Id(ASPControlEx objASPControlENEx,
     StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objASPControlENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat(" id=\"{0}\"",
                objASPControlENEx.CtrlId);
            }
        }
        public static void GC4Name4MvcAjax(ASPControlEx objASPControlENEx,
                StringBuilder strCodeForCs)
        {
           
            if (string.IsNullOrEmpty(objASPControlENEx.Name4MvcAjax) == false)
            {
                strCodeForCs.AppendFormat(" Name=\"{0}\"",
                objASPControlENEx.Name4MvcAjax);
            }
        }
        /// <summary>
        /// 生成该对象边界相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Margin(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPControlENEx.layout_marginLeft > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_marginLeft=\"{0}dp\"",
                    objASPControlENEx.layout_marginLeft);
            }
            if (objASPControlENEx.layout_marginTop > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_marginTop=\"{0}dp\"",
                    objASPControlENEx.layout_marginTop);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.layout_margin) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_margin=\"{0}\" ",
                    objASPControlENEx.layout_margin);
            }
        }
        /// <summary>
        /// 生成该对象约束相关的代码
        /// </summary>
        /// <param name="objASPControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Constraint(ASPControlEx objASPControlENEx,
            StringBuilder strCodeForCs)
        {

            if (string.IsNullOrEmpty(objASPControlENEx.layout_constraintStart_toStartOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintStart_toStartOf=\"{0}\"",
                    objASPControlENEx.layout_constraintStart_toStartOf);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.layout_constraintLeft_toLeftOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintLeft_toLeftOf=\"{0}\" ",
                    objASPControlENEx.layout_constraintLeft_toLeftOf);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.layout_constraintLeft_toRightOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintLeft_toRightOf=\"{0}\" ",
                    objASPControlENEx.layout_constraintLeft_toRightOf);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.layout_constraintTop_toBottomOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintTop_toBottomOf=\"{0}\" ",
                    objASPControlENEx.layout_constraintTop_toBottomOf);
            }
            if (string.IsNullOrEmpty(objASPControlENEx.layout_constraintTop_toTopOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintTop_toTopOf=\"{0}\" ",
                    objASPControlENEx.layout_constraintTop_toTopOf);
            }


        }
        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objQryRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static ASPControlEx GetObjByQryFld(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objASPCheckBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPCheckBoxENEx;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("spn{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
              
                    objASPDropDownListENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objQryRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objQryRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objQryRegionFldsEx.DS_TabName;

                    return objASPDropDownListENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static ASPControlEx GetControl_Asp(clsDGRegionFldsENEx objDGRegionFldsEx)
        {

            switch (objDGRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPCheckBoxENEx.Caption = objDGRegionFldsEx.ColCaption;
                    objASPCheckBoxENEx.CSType = objDGRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPCheckBoxENEx.FldName = objDGRegionFldsEx.FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 0;
                    objASPCheckBoxENEx.Text = objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objASPCheckBoxENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objASPCheckBoxENEx;

                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Caption = objDGRegionFldsEx.ColCaption;
                    objASPTextBoxENEx.CSType = objDGRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPTextBoxENEx.FldName = objDGRegionFldsEx.FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;

                    objASPTextBoxENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("spn{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Caption = objDGRegionFldsEx.ColCaption;
                    objASPDropDownListENEx.CSType = objDGRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPDropDownListENEx.FldName = objDGRegionFldsEx.FldName;

                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 0;
                    objASPDropDownListENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    
                    objASPDropDownListENEx.FldName = objDGRegionFldsEx.ObjPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objDGRegionFldsEx.TabName;
                    //objASPDropDownListENEx.DDLItemsOptionId = objDGRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objDGRegionFldsEx.DS_TabName;

                    return objASPDropDownListENEx;
                case "Button":
                    ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                    if (objDGRegionFldsEx.ButtonValue.Contains( "修改"))
                    {
                        objASPButtonENEx.CtrlId = "btnUpdate";
                        objASPButtonENEx.Text = "修改";
                    }
                    else if (objDGRegionFldsEx.ButtonValue.Contains( "删除"))
                    {
                        objASPButtonENEx.CtrlId = "btnDelete";
                        objASPButtonENEx.Text = "删除";
                    }
                    //objASPButtonENEx.CtrlId = string.Format("btn{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPButtonENEx.Caption = objDGRegionFldsEx.ColCaption;
                    objASPButtonENEx.CSType = "";// objDGRegionFldsEx.ObjPrjTabFldENEx.CSType;
                    objASPButtonENEx.FldName = "";// objDGRegionFldsEx.FldName;
                    
                    objASPButtonENEx.Width = 200;
                    objASPButtonENEx.Height = 22;

                    objASPButtonENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objASPButtonENEx;
                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objDGRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        public static ASPControlEx GetControl_Asp(clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx)
        {


            ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
            objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objExcelExportRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            objASPTextBoxENEx.Caption = objExcelExportRegionFldsEx.ColCaption;
            objASPTextBoxENEx.CSType = objExcelExportRegionFldsEx.ObjPrjTabFldENEx.CSType;
            objASPTextBoxENEx.FldName = objExcelExportRegionFldsEx.ObjPrjTabFldENEx.FldName;

            objASPTextBoxENEx.Width = 200;
            objASPTextBoxENEx.Height = 22;

            objASPTextBoxENEx.objExcelExportRegionFldsENEx = objExcelExportRegionFldsEx;
            return objASPTextBoxENEx;


        }



        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">编辑区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static ASPControlEx GetObjByEditFld(clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            string strFldName = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 0;
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objASPCheckBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPCheckBoxENEx;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("spn{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 0;
                    objASPDropDownListENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
               
                    objASPDropDownListENEx.FldName = objEditRegionFldsEx.ObjPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objEditRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objEditRegionFldsEx.DS_TabName;

                    return objASPDropDownListENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_FieldVarDef(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_FieldVarDef(objASPLabelENEx, strCodeForCs);
                    break;
                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    clsASPButtonBLEx.Gen_FieldVarDef(objASPButtonENEx, strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    clsASPBodyBLEx.Gen_FieldVarDef(objASPBodyENEx, strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    clsASPBoundFieldBLEx.Gen_FieldVarDef(objASPBoundFieldENEx, strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    clsASPDivBLEx.Gen_FieldVarDef(objASPDivENEx, strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    clsASPFormBLEx.Gen_FieldVarDef(objASPFormENEx, strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    clsASPGridViewBLEx.Gen_FieldVarDef(objASPGridViewENEx, strCodeForCs);
                    break;

                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    clsASPHeadBLEx.Gen_FieldVarDef(objASPHeadENEx, strCodeForCs);
                    break;
                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    clsASPHeaderStyleBLEx.Gen_FieldVarDef(objASPHeaderStyleENEx, strCodeForCs);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_FieldVarDef(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_FieldVarDef(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_FieldVarDef(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_FieldVarDef(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_FieldVarDef(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(ASPControlEx objASPControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":

                case "ASPLabelEx":

                case "ASPButtonEx":

                case "ASPBodyEx":

                case "ASPBoundFieldEx":

                case "ASPDivEx":

                case "ASPFormEx":

                case "ASPGridViewEx":

                case "ASPHeadEx":

                case "ASPHeaderStyleEx":

                case "ASPHeaderTemplateEx":

                case "ASPCheckBoxEx":
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_BindDdl(objASPDropDownListENEx, objViewInfoENEx, strCodeForCs);
                    break;

                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_BindDdl(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_BindDdl(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }



        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(ASPControlEx objASPControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":

                case "ASPLabelEx":

                case "ASPButtonEx":

                case "ASPBodyEx":

                case "ASPBoundFieldEx":

                case "ASPDivEx":

                case "ASPFormEx":

                case "ASPGridViewEx":

                case "ASPHeadEx":

                case "ASPHeaderStyleEx":

                case "ASPHeaderTemplateEx":

                case "ASPCheckBoxEx":
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_BindDdlInTaskQueue(objASPDropDownListENEx, objViewInfoENEx, strCodeForCs);
                    break;

                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_BindDdl(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_BindDdl(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_DefDdlBindObj(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":

                case "ASPLabelEx":

                case "ASPButtonEx":

                case "ASPBodyEx":

                case "ASPBoundFieldEx":

                case "ASPDivEx":

                case "ASPFormEx":

                case "ASPGridViewEx":

                case "ASPHeadEx":

                case "ASPHeaderStyleEx":

                case "ASPHeaderTemplateEx":

                case "ASPCheckBoxEx":
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_DefDdlBindObj(objASPDropDownListENEx, strCodeForCs, arrDdlBindObjLst);
                    break;

                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_DefDdlBindObj(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_DefDdlBindObj(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_FieldVarBind(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_FieldVarBind(objASPLabelENEx, strCodeForCs);
                    break;
                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    clsASPButtonBLEx.Gen_FieldVarBind(objASPButtonENEx, strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    clsASPBodyBLEx.Gen_FieldVarBind(objASPBodyENEx, strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    clsASPBoundFieldBLEx.Gen_FieldVarBind(objASPBoundFieldENEx, strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    clsASPDivBLEx.Gen_FieldVarBind(objASPDivENEx, strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    clsASPFormBLEx.Gen_FieldVarBind(objASPFormENEx, strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    clsASPGridViewBLEx.Gen_FieldVarBind(objASPGridViewENEx, strCodeForCs);
                    break;

                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    clsASPHeadBLEx.Gen_FieldVarBind(objASPHeadENEx, strCodeForCs);
                    break;
                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    clsASPHeaderStyleBLEx.Gen_FieldVarBind(objASPHeaderStyleENEx, strCodeForCs);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_FieldVarBind(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_FieldVarBind(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_FieldVarBind(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_FieldVarBind(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_FieldVarBind(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        ///// <summary>
        ///// 字段变量绑定
        ///// </summary>
        ///// <param name="objASPControlENEx"></param>
        ///// <param name="strCodeForCs"></param>
        //public static void Gen_FieldVarBind4HeaderTemplate(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        //{
        //    string strType = objASPControlENEx.GetType().Name;
        //    switch (strType)
        //    {
        //        case "ASPTextBoxEx":
        //            ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
        //            clsASPTextBoxBLEx.Gen_FieldVarBind4HeaderTemplate(objASPTextBoxENEx, strCodeForCs);
        //            break;
        //        case "ASPLabelEx":
        //            ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
        //            clsASPLabelBLEx.Gen_FieldVarBind4HeaderTemplate(objASPLabelENEx, strCodeForCs);
        //            break;
        //        case "ASPButtonEx":
        //            ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
        //            clsASPButtonBLEx.Gen_FieldVarBind4HeaderTemplate(objASPButtonENEx, strCodeForCs);
        //            break;
        //        case "ASPBodyEx":
        //            ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
        //            clsASPBodyBLEx.Gen_FieldVarBind4HeaderTemplate(objASPBodyENEx, strCodeForCs);
        //            break;
        //        case "ASPBoundFieldEx":
        //            ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
        //            clsASPBoundFieldBLEx.Gen_FieldVarBind4HeaderTemplate(objASPBoundFieldENEx, strCodeForCs);
        //            break;
        //        case "ASPDivEx":
        //            ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
        //            clsASPDivBLEx.Gen_FieldVarBind4HeaderTemplate(objASPDivENEx, strCodeForCs);
        //            break;
        //        case "ASPFormEx":
        //            ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
        //            clsASPFormBLEx.Gen_FieldVarBind4HeaderTemplate(objASPFormENEx, strCodeForCs);
        //            break;
        //        case "ASPGridViewEx":
        //            ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
        //            clsASPGridViewBLEx.Gen_FieldVarBind4HeaderTemplate(objASPGridViewENEx, strCodeForCs);
        //            break;

        //        case "ASPHeadEx":
        //            ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
        //            clsASPHeadBLEx.Gen_FieldVarBind4HeaderTemplate(objASPHeadENEx, strCodeForCs);
        //            break;
        //        case "ASPHeaderStyleEx":
        //            ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
        //            clsASPHeaderStyleBLEx.Gen_FieldVarBind4HeaderTemplate(objASPHeaderStyleENEx, strCodeForCs);
        //            break;
        //        case "ASPHeaderTemplateEx":
        //            ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
        //            clsASPHeaderTemplateBLEx.Gen_FieldVarBind4HeaderTemplate(objASPHeaderTemplateENEx, strCodeForCs);
        //            break;
        //        case "ASPDropDownListEx":
        //            ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
        //            clsASPDropDownListBLEx.Gen_FieldVarBind4HeaderTemplate(objASPDropDownListENEx, strCodeForCs);
        //            break;
        //        case "ASPCheckBoxEx":
        //            ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
        //            clsASPCheckBoxBLEx.Gen_FieldVarBind4HeaderTemplate(objASPCheckBoxENEx, strCodeForCs);
        //            break;
        //        //case "ASPPagerTemplateEx":
        //        //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
        //        //    clsASPPagerTemplateBLEx.Gen_FieldVarBind4HeaderTemplate(objASPPagerTemplateENEx, strCodeForCs);
        //        //    break;
        //        //case "clsASPAutoresizingMaskENEx":
        //        //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
        //        //    clsASPAutoresizingMaskBLEx.Gen_FieldVarBind4HeaderTemplate(objASPAutoresizingMaskENEx, strCodeForCs);
        //        //    break;

        //        default:
        //            throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
        //    }
        //}

        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPControlEx objASPControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_LvFieldAssignment(objASPTextBoxENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_LvFieldAssignment(objASPLabelENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    clsASPButtonBLEx.Gen_LvFieldAssignment(objASPButtonENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    clsASPBodyBLEx.Gen_LvFieldAssignment(objASPBodyENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    clsASPBoundFieldBLEx.Gen_LvFieldAssignment(objASPBoundFieldENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    clsASPDivBLEx.Gen_LvFieldAssignment(objASPDivENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    clsASPFormBLEx.Gen_LvFieldAssignment(objASPFormENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    clsASPGridViewBLEx.Gen_LvFieldAssignment(objASPGridViewENEx, objViewInfoENEx, strCodeForCs);
                    break;

                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    clsASPHeadBLEx.Gen_LvFieldAssignment(objASPHeadENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_LvFieldAssignment(objASPHeaderStyleENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderTemplateEx":
                //    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                //    clsASPHeaderTemplateBLEx.Gen_LvFieldAssignment(objASPHeaderTemplateENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_LvFieldAssignment(objASPDropDownListENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_LvFieldAssignment(objASPCheckBoxENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_LvFieldAssignment(objASPPagerTemplateENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_LvFieldAssignment(objASPAutoresizingMaskENEx, objViewInfoENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_GetValue4FieldCtrl4Edit(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_GetValue4FieldCtrl4Edit(objASPLabelENEx, strCodeForCs);
                    break;
                //case "ASPButtonEx":
                //    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                //    clsASPButtonBLEx.Gen_GetValue4FieldCtrl4Edit(objASPButtonENEx, strCodeForCs);
                //    break;
                //case "ASPBodyEx":
                //    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                //    clsASPBodyBLEx.Gen_GetValue4FieldCtrl4Edit(objASPBodyENEx, strCodeForCs);
                //    break;
                //case "ASPBoundFieldEx":
                //    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                //    clsASPBoundFieldBLEx.Gen_GetValue4FieldCtrl4Edit(objASPBoundFieldENEx, strCodeForCs);
                //    break;
                //case "ASPDivEx":
                //    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                //    clsASPDivBLEx.Gen_GetValue4FieldCtrl4Edit(objASPDivENEx, strCodeForCs);
                //    break;
                //case "ASPFormEx":
                //    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                //    clsASPFormBLEx.Gen_GetValue4FieldCtrl4Edit(objASPFormENEx, strCodeForCs);
                //    break;
                //case "ASPGridViewEx":
                //    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                //    clsASPGridViewBLEx.Gen_GetValue4FieldCtrl4Edit(objASPGridViewENEx, strCodeForCs);
                //    break;

                //case "ASPHeadEx":
                //    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                //    clsASPHeadBLEx.Gen_GetValue4FieldCtrl4Edit(objASPHeadENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_GetValue4FieldCtrl4Edit(objASPHeaderStyleENEx, strCodeForCs);
                //    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_GetValue4FieldCtrl4Edit(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_GetValue4FieldCtrl4Edit(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_GetValue4FieldCtrl4Edit(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_GetValue4FieldCtrl4Edit(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_GetValue4FieldCtrl4Edit(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_GetValue4FieldCtrl4Qry(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_GetValue4FieldCtrl4Qry(objASPLabelENEx, strCodeForCs);
                    break;
                //case "ASPButtonEx":
                //    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                //    clsASPButtonBLEx.Gen_GetValue4FieldCtrl4Qry(objASPButtonENEx, strCodeForCs);
                //    break;
                //case "ASPBodyEx":
                //    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                //    clsASPBodyBLEx.Gen_GetValue4FieldCtrl4Qry(objASPBodyENEx, strCodeForCs);
                //    break;
                //case "ASPBoundFieldEx":
                //    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                //    clsASPBoundFieldBLEx.Gen_GetValue4FieldCtrl4Qry(objASPBoundFieldENEx, strCodeForCs);
                //    break;
                //case "ASPDivEx":
                //    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                //    clsASPDivBLEx.Gen_GetValue4FieldCtrl4Qry(objASPDivENEx, strCodeForCs);
                //    break;
                //case "ASPFormEx":
                //    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                //    clsASPFormBLEx.Gen_GetValue4FieldCtrl4Qry(objASPFormENEx, strCodeForCs);
                //    break;
                //case "ASPGridViewEx":
                //    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                //    clsASPGridViewBLEx.Gen_GetValue4FieldCtrl4Qry(objASPGridViewENEx, strCodeForCs);
                //    break;

                //case "ASPHeadEx":
                //    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                //    clsASPHeadBLEx.Gen_GetValue4FieldCtrl4Qry(objASPHeadENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_GetValue4FieldCtrl4Qry(objASPHeaderStyleENEx, strCodeForCs);
                //    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_GetValue4FieldCtrl4Qry(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_GetValue4FieldCtrl4Qry(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_GetValue4FieldCtrl4Qry(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_GetValue4FieldCtrl4Qry(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_GetValue4FieldCtrl4Qry(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_SetValue4FieldCtrl4Edit(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_SetValue4FieldCtrl4Edit(objASPLabelENEx, strCodeForCs);
                    break;
                //case "ASPButtonEx":
                //    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                //    clsASPButtonBLEx.Gen_SetValue4FieldCtrl4Edit(objASPButtonENEx, strCodeForCs);
                //    break;
                //case "ASPBodyEx":
                //    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                //    clsASPBodyBLEx.Gen_SetValue4FieldCtrl4Edit(objASPBodyENEx, strCodeForCs);
                //    break;
                //case "ASPBoundFieldEx":
                //    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                //    clsASPBoundFieldBLEx.Gen_SetValue4FieldCtrl4Edit(objASPBoundFieldENEx, strCodeForCs);
                //    break;
                //case "ASPDivEx":
                //    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                //    clsASPDivBLEx.Gen_SetValue4FieldCtrl4Edit(objASPDivENEx, strCodeForCs);
                //    break;
                //case "ASPFormEx":
                //    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                //    clsASPFormBLEx.Gen_SetValue4FieldCtrl4Edit(objASPFormENEx, strCodeForCs);
                //    break;
                //case "ASPGridViewEx":
                //    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                //    clsASPGridViewBLEx.Gen_SetValue4FieldCtrl4Edit(objASPGridViewENEx, strCodeForCs);
                //    break;

                //case "ASPHeadEx":
                //    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                //    clsASPHeadBLEx.Gen_SetValue4FieldCtrl4Edit(objASPHeadENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_SetValue4FieldCtrl4Edit(objASPHeaderStyleENEx, strCodeForCs);
                //    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_SetValue4FieldCtrl4Edit(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_SetValue4FieldCtrl4Edit(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_SetValue4FieldCtrl4Edit(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_SetValue4FieldCtrl4Edit(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_SetValue4FieldCtrl4Edit(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_ClearFieldCtrl4Edit(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_ClearFieldCtrl4Edit(objASPLabelENEx, strCodeForCs);
                    break;
                //case "ASPButtonEx":
                //    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                //    clsASPButtonBLEx.Gen_ClearFieldCtrl4Edit(objASPButtonENEx, strCodeForCs);
                //    break;
                //case "ASPBodyEx":
                //    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                //    clsASPBodyBLEx.Gen_ClearFieldCtrl4Edit(objASPBodyENEx, strCodeForCs);
                //    break;
                //case "ASPBoundFieldEx":
                //    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                //    clsASPBoundFieldBLEx.Gen_ClearFieldCtrl4Edit(objASPBoundFieldENEx, strCodeForCs);
                //    break;
                //case "ASPDivEx":
                //    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                //    clsASPDivBLEx.Gen_ClearFieldCtrl4Edit(objASPDivENEx, strCodeForCs);
                //    break;
                //case "ASPFormEx":
                //    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                //    clsASPFormBLEx.Gen_ClearFieldCtrl4Edit(objASPFormENEx, strCodeForCs);
                //    break;
                //case "ASPGridViewEx":
                //    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                //    clsASPGridViewBLEx.Gen_ClearFieldCtrl4Edit(objASPGridViewENEx, strCodeForCs);
                //    break;

                //case "ASPHeadEx":
                //    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                //    clsASPHeadBLEx.Gen_ClearFieldCtrl4Edit(objASPHeadENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_ClearFieldCtrl4Edit(objASPHeaderStyleENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderTemplateEx":
                //    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                //    clsASPHeaderTemplateBLEx.Gen_ClearFieldCtrl4Edit(objASPHeaderTemplateENEx, strCodeForCs);
                //    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_ClearFieldCtrl4Edit(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_ClearFieldCtrl4Edit(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_ClearFieldCtrl4Edit(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_ClearFieldCtrl4Edit(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_SetValue4FieldCtrl4Qry(objASPTextBoxENEx, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_SetValue4FieldCtrl4Qry(objASPLabelENEx, strCodeForCs);
                    break;
                //case "ASPButtonEx":
                //    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                //    clsASPButtonBLEx.Gen_SetValue4FieldCtrl4Qry(objASPButtonENEx, strCodeForCs);
                //    break;
                //case "ASPBodyEx":
                //    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                //    clsASPBodyBLEx.Gen_SetValue4FieldCtrl4Qry(objASPBodyENEx, strCodeForCs);
                //    break;
                //case "ASPBoundFieldEx":
                //    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                //    clsASPBoundFieldBLEx.Gen_SetValue4FieldCtrl4Qry(objASPBoundFieldENEx, strCodeForCs);
                //    break;
                //case "ASPDivEx":
                //    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                //    clsASPDivBLEx.Gen_SetValue4FieldCtrl4Qry(objASPDivENEx, strCodeForCs);
                //    break;
                //case "ASPFormEx":
                //    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                //    clsASPFormBLEx.Gen_SetValue4FieldCtrl4Qry(objASPFormENEx, strCodeForCs);
                //    break;
                //case "ASPGridViewEx":
                //    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                //    clsASPGridViewBLEx.Gen_SetValue4FieldCtrl4Qry(objASPGridViewENEx, strCodeForCs);
                //    break;

                //case "ASPHeadEx":
                //    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                //    clsASPHeadBLEx.Gen_SetValue4FieldCtrl4Qry(objASPHeadENEx, strCodeForCs);
                //    break;
                //case "ASPHeaderStyleEx":
                //    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                //    clsASPHeaderStyleBLEx.Gen_SetValue4FieldCtrl4Qry(objASPHeaderStyleENEx, strCodeForCs);
                //    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    clsASPHeaderTemplateBLEx.Gen_SetValue4FieldCtrl4Qry(objASPHeaderTemplateENEx, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListENEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_SetValue4FieldCtrl4Qry(objASPDropDownListENEx, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_SetValue4FieldCtrl4Qry(objASPCheckBoxENEx, strCodeForCs);
                    break;
                //case "ASPPagerTemplateEx":
                //    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                //    clsASPPagerTemplateBLEx.Gen_SetValue4FieldCtrl4Qry(objASPPagerTemplateENEx, strCodeForCs);
                //    break;
                //case "clsASPAutoresizingMaskENEx":
                //    clsASPAutoresizingMaskENEx objASPAutoresizingMaskENEx = objASPControlENEx as clsASPAutoresizingMaskENEx;
                //    clsASPAutoresizingMaskBLEx.Gen_SetValue4FieldCtrl4Qry(objASPAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        public static ASPControlEx GetControlGroup_Asp(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlEx objASPControlENEx = new ASPControlEx();

            ASPLabelEx objLabel = new ASPLabelEx();

            objLabel.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.FldName);
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;

            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            objLabel.CssClass = "text-secondary";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objQryRegionFldsEx.LabelCaption;

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objASPCheckBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    objASPControlENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
                    objASPDropDownListENEx.CtrlId = string.Format("ddl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.objQryRegionFldsENEx = objQryRegionFldsEx;

                    objASPDropDownListENEx.FldName = objQryRegionFldsEx.objPrjTabFldENEx.FldName;
                    objASPDropDownListENEx.TabName = objQryRegionFldsEx.TabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objQryRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objQryRegionFldsEx.DS_TabName;

                    objASPControlENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPDropDownListENEx);
                    break;
                default:
                    string strMsg = string.Format("查询区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

            return objASPControlENEx;
        }

          public static ASPControlEx GetControl_Asp(clsvViewFeatureFldsENEx objViewFeatureFldsEx, string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            //if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();

            //objViewFeatureFldsEx.ViewFeatureId
            //ASPControlEx objASPControlENEx = new ASPControlEx();

            string strAdditionalCtrlId = "";
            switch(objViewFeatureFldsEx.FeatureId)
            {
                case enumPrjFeature.SetFieldValue_0148:
                    strAdditionalCtrlId = "_SetFldValue";
                    break;

            }
            switch (objViewFeatureFldsEx.ObjCtlTypeAbbr.CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        objASPCheckBoxENEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                    }
                    else
                    {
                        objASPCheckBoxENEx.CtrlId = string.Format("chk{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId); 
                    }
                    objASPCheckBoxENEx.Class = "form-control";
                    objASPCheckBoxENEx.FldName = objASPCheckBoxENEx.CtrlId.Substring(3);
                    objASPCheckBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPCheckBoxENEx.CSType = objViewFeatureFldsEx.CSType;
                    objASPCheckBoxENEx.Caption = objViewFeatureFldsEx.Caption;
                    objASPCheckBoxENEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPCheckBoxENEx.GroupName = objViewFeatureFldsEx.GroupName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objViewFeatureFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objViewFeatureFldsENEx = objViewFeatureFldsEx;
                    return objASPCheckBoxENEx;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        objASPTextBoxENEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                    }
                    else
                    {
                        objASPTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId);
                    }
                    objASPTextBoxENEx.Class = "form-control";
                    objASPTextBoxENEx.FldName = objASPTextBoxENEx.CtrlId.Substring(3);
                    objASPTextBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPTextBoxENEx.CSType = objViewFeatureFldsEx.CSType;
                    objASPTextBoxENEx.Caption = objViewFeatureFldsEx.Caption;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPTextBoxENEx.GroupName = objViewFeatureFldsEx.GroupName;

                    objASPTextBoxENEx.objViewFeatureFldsENEx = objViewFeatureFldsEx;
                    return objASPTextBoxENEx;
                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();

                    objASPDropDownListENEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        objASPDropDownListENEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                    }
                    else
                    {
                        objASPDropDownListENEx.CtrlId = string.Format("ddl{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId);
                    }
                    objASPDropDownListENEx.Class = "form-control";
                    objASPDropDownListENEx.FldName = objASPDropDownListENEx.CtrlId.Substring(3);
                    objASPDropDownListENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPDropDownListENEx.CSType = objViewFeatureFldsEx.CSType;
                    objASPDropDownListENEx.Caption = objViewFeatureFldsEx.Caption;

                    objASPDropDownListENEx.TabName = objViewFeatureFldsEx.RelaTabName;
                    objASPDropDownListENEx.DDLItemsOptionId = objViewFeatureFldsEx.DDLItemsOptionId;
                    objASPDropDownListENEx.DS_TabName = objViewFeatureFldsEx.DS_TabName;

                    objASPDropDownListENEx.Width = 200;
                    objASPDropDownListENEx.Height = 22;
                    objASPDropDownListENEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPDropDownListENEx.GroupName = objViewFeatureFldsEx.GroupName;
                 
                    objASPDropDownListENEx.objViewFeatureFldsENEx = objViewFeatureFldsEx;
                    return objASPDropDownListENEx;

                default:
                    string strMsg = string.Format("界面功能字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objViewFeatureFldsEx.ObjCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

            //return objASPControlENEx;
        }

        /// <summary>
        /// 封装td
        /// </summary>
        /// <param name="objAspControl"></param>
        /// <returns></returns>
        public static ASPControlEx PackageTd(ASPControlEx objAspControl)
        {
            ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
            objCol.arrSubAspControlLst2.Add(objAspControl);
            return objCol;
        }
    }
}