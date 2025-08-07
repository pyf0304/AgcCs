
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
                string strCsType = objASPControl.CsType;

                strCodeForCs.AppendFormat("\r\n" + "[DisplayName(\"{0}\")]",
                    strCaption);
                strCodeForCs.AppendFormat("\r\n" + "[Required(ErrorMessage = \"请输入:{0}\")]",
                    strCaption);
                if (objASPControl.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public string {1} {{ get; set; }}",
                     strCsType, strFldName);
                }
                else if (objASPControl.CtlTypeId == enumCtlType.DropDownList_06)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                        strCsType, strFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                    strCsType, strFldName);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    strCode = objASPTextAreaENEx.GC_SetDefaultValue();
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    strCode = objASPDropDownListEx.GC_SetDefaultValue();
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    strCode = objASPTextAreaENEx.GC_DefFldProperty();
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    strCode = objASPDropDownListEx.GC_DefFldProperty();
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

        public static void GeneCode(this ASPControlEx objASPControlENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPControlEx":
                    //ASPControlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    foreach (ASPControlEx objSubASPControlENEx in objASPControlENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
                    }
                    break;
                case "ASPControlGroupEx":
                    ASPControlGroupEx objASPControlGroupENEx = objASPControlENEx as ASPControlGroupEx;
                    objASPControlGroupENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                //case "VueControlGroupEx":
                //    VueControlGroupEx objVueControlGroupENEx = objASPControlENEx as VueControlGroupEx;
                //    objVueControlGroupENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                //    break;

                case "ASPUlEx":
                    ASPUlEx objASPUlENEx = objASPControlENEx as ASPUlEx;
                    objASPUlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "VueComponentEx":
                    VueComponentEx objVueComponentEx = objASPControlENEx as VueComponentEx;
                    objVueComponentEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPLiEx":
                    ASPLiEx objASPLiENEx = objASPControlENEx as ASPLiEx;
                    objASPLiENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPCodeEx":
                    ASPCodeEx objASPCodeENEx = objASPControlENEx as ASPCodeEx;
                    objASPCodeENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPEmptyEx":
                    ASPEmptyEx objASPEmptyENEx = objASPControlENEx as ASPEmptyEx;
                    objASPEmptyENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPSpanEx":
                    ASPSpanEx objASPSpanENEx = objASPControlENEx as ASPSpanEx;
                    objASPSpanENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPHeadEx":
                    ASPHeadEx objASPHeadENEx = objASPControlENEx as ASPHeadEx;
                    objASPHeadENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPBodyEx":
                    ASPBodyEx objASPBodyENEx = objASPControlENEx as ASPBodyEx;
                    objASPBodyENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPFormEx":
                    ASPFormEx objASPFormENEx = objASPControlENEx as ASPFormEx;
                    objASPFormENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPHtmlTableEx":
                    ASPHtmlTableEx objASPHtmlTableENEx = objASPControlENEx as ASPHtmlTableEx;
                    objASPHtmlTableENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPRowEx":
                    ASPRowEx objASPRowENEx = objASPControlENEx as ASPRowEx;
                    objASPRowENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPColEx":
                    ASPColEx objASPColENEx = objASPControlENEx as ASPColEx;
                    objASPColENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPDivEx":
                    ASPDivEx objASPDivENEx = objASPControlENEx as ASPDivEx;
                    objASPDivENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    objASPLabelENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    objASPTextBoxENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    objASPTextAreaENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;


                case "ASPButtonEx":
                    ASPButtonEx objASPButtonENEx = objASPControlENEx as ASPButtonEx;
                    objASPButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                //case "VueButtonEx":
                //    VueButtonEx objVueButtonENEx = objASPControlENEx as VueButtonEx;
                //    objVueButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                //    break;
                case "ASPLinkButtonEx":
                    ASPLinkButtonEx objASPLinkButtonENEx = objASPControlENEx as ASPLinkButtonEx;
                    objASPLinkButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    objASPCheckBoxENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPGridViewEx":
                    ASPGridViewEx objASPGridViewENEx = objASPControlENEx as ASPGridViewEx;
                    objASPGridViewENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPTemplateFieldEx":
                    ASPTemplateFieldEx objASPTemplateFieldENEx = objASPControlENEx as ASPTemplateFieldEx;
                    objASPTemplateFieldENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPHeaderStyleEx":
                    ASPHeaderStyleEx objASPHeaderStyleENEx = objASPControlENEx as ASPHeaderStyleEx;
                    objASPHeaderStyleENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPHeaderTemplateEx":
                    ASPHeaderTemplateEx objASPHeaderTemplateENEx = objASPControlENEx as ASPHeaderTemplateEx;
                    objASPHeaderTemplateENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPItemTemplateEx":
                    ASPItemTemplateEx objASPItemTemplateENEx = objASPControlENEx as ASPItemTemplateEx;
                    objASPItemTemplateENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPBoundFieldEx":
                    ASPBoundFieldEx objASPBoundFieldENEx = objASPControlENEx as ASPBoundFieldEx;
                    objASPBoundFieldENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPWebUserControlEx":
                    ASPWebUserControlEx objASPWebUserControlENEx = objASPControlENEx as ASPWebUserControlEx;
                    objASPWebUserControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPPagerTemplateEx":
                    ASPPagerTemplateEx objASPPagerTemplateENEx = objASPControlENEx as ASPPagerTemplateEx;
                    objASPPagerTemplateENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPHrEx":
                    ASPHrEx objASPHrENEx = objASPControlENEx as ASPHrEx;
                    objASPHrENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPHtmlButtonEx":
                    ASPHtmlButtonEx objASPHtmlButtonENEx = objASPControlENEx as ASPHtmlButtonEx;
                    objASPHtmlButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "ASPHiddenFieldEx":
                    ASPHiddenFieldEx objASPHiddenFieldENEx = objASPControlENEx as ASPHiddenFieldEx;
                    objASPHiddenFieldENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPHtmlInputEx":
                    ASPHtmlInputEx objASPHtmlInputENEx = objASPControlENEx as ASPHtmlInputEx;
                    objASPHtmlInputENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPH4Ex":
                    ASPH4Ex objASPH4ENEx = objASPControlENEx as ASPH4Ex;
                    objASPH4ENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPDropDownListEx":
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    //if (objASPDropDownListEx.CtlTypeId == null) return;
                    objASPDropDownListEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "ASPCompareValidatorEx":
                    ASPCompareValidatorEx objASPCompareValidatorENEx = objASPControlENEx as ASPCompareValidatorEx;
                    objASPCompareValidatorENEx.GeneCode(intApplicationTypeId, strCodeForCs);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    objASPTextAreaENEx.GeneCode4Mvc(strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    objASPDropDownListEx.GeneCode4Mvc(strCodeForCs);
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
            if (objContainer == null) return;
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    objASPTextAreaENEx.GeneHtmlControl(objContainer);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                     objASPDropDownListEx.GeneHtmlControl(objContainer);
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
        public static List<string> arrCtrlId = new List<string>();

        public static bool InitStyleObj()
        {
            ASPControlEx.objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            ASPControlEx.objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            ASPControlEx.objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            ASPControlEx.objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            return true;
    }

        public static ASPControlEx GetControl_Asp(clsEditRegionFldsEN objEditRegionFldsEx, string strCmPrjId)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            //ASPControlEx objControl = new ASPControlEx();

            //objControl.CtrlId = objEditRegionFldsEx.CtrlId();
            //objControl.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objControl.Height = ASPControlEx.objLabelStyle_Text.Height;

            //objControl.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //objControl.Caption = objEditRegionFldsEx.LabelCaption;
            //objControl.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            //objControl.FldName = objEditRegionFldsEx.FldName();


            switch (objEditRegionFldsEx.CtlTypeId)
            {

                case enumCtlType.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPCheckBoxENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPCheckBoxENEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objASPCheckBoxENEx;



                case enumCtlType.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPTextBoxENEx.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPTextBoxENEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.Class = "ValueControl";
                    objASPTextBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;

                    return objASPTextBoxENEx;
                case enumCtlType.TextArea_41:
                    ASPTextAreaEx objASPTextAreaENEx = new ASPTextAreaEx();
                    objASPTextAreaENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextAreaENEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPTextAreaENEx.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPTextAreaENEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPTextAreaENEx.Width = 200;
                    objASPTextAreaENEx.Height = 22;
                    objASPTextAreaENEx.Class = "ValueControl";
                    objASPTextAreaENEx.objEditRegionFldsEN = objEditRegionFldsEx;

                    return objASPTextAreaENEx;
                case enumCtlType.DropDownList_06:
                    ASPDropDownListEx objASPDropDownListEx = new  ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Caption = objEditRegionFldsEx.LabelCaption;
                    objASPDropDownListEx.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
               
                    objASPDropDownListEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objEditRegionFldsEx.ObjPrjTab_PC().TabName;
                    objASPDropDownListEx.DdlItemsOptionId = objEditRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = objEditRegionFldsEx.DsTabName();

                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objASPDropDownListEx;


                case enumCtlType.ViewVariable_38:
                case enumCtlType.None_00:
                    return null;
                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        public static ASPControlEx GetControl_Asp(clsDetailRegionFldsEN objDetailRegionFldsEx, string strCmPrjId)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            //ASPControlEx objControl = new ASPControlEx();

            //objControl.CtrlId = objDetailRegionFldsEx.CtrlId();
            //objControl.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objControl.Height = ASPControlEx.objLabelStyle_Text.Height;

            //objControl.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //objControl.Caption = objDetailRegionFldsEx.LabelCaption;
            //objControl.CsType = objDetailRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            //objControl.FldName = objDetailRegionFldsEx.FldName();


            switch (objDetailRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objDetailRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPCheckBoxENEx.Caption = objDetailRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.CsType = objDetailRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPCheckBoxENEx.FldName = objDetailRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objDetailRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    return objASPCheckBoxENEx;



                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objDetailRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Caption = objDetailRegionFldsEx.LabelCaption;
                    objASPTextBoxENEx.CsType = objDetailRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPTextBoxENEx.FldName = objDetailRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.Class = "ValueControl";
                    objASPTextBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;

                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPLabelEx objASPDropDownListEx = new ASPLabelEx();
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objDetailRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Caption = objDetailRegionFldsEx.LabelCaption;
                    objASPDropDownListEx.CsType = objDetailRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;

                    objASPDropDownListEx.FldName = objDetailRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objDetailRegionFldsEx.ObjPrjTab_PC().TabName;
                    
                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    return objASPDropDownListEx;

                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objDetailRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        public static ASPControlEx GetControl_Asp(clsQryRegionFldsEN objQryRegionFldsEx, string strCmPrjId)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            //ASPControlEx objControl = new ASPControlEx();

            //objControl.CtrlId = objQryRegionFldsEx.CtrlId();
            //objControl.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objControl.Height = ASPControlEx.objLabelStyle_Text.Height;

            //objControl.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //objControl.Caption = objQryRegionFldsEx.LabelCaption;
            //objControl.CsType = objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            //objControl.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;


            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPCheckBoxENEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.CsType = objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPCheckBoxENEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objASPCheckBoxENEx;



                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPTextBoxENEx.CsType = objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPTextBoxENEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.Class = "ValueControl";
                    objASPTextBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;

                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Caption = objQryRegionFldsEx.LabelCaption;
                    objASPDropDownListEx.CsType = objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
          
                    objASPDropDownListEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objQryRegionFldsEx.ObjPrjTab_PC().TabName;
                    objASPDropDownListEx.DdlItemsOptionId = objQryRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = objQryRegionFldsEx.DsTabName();

                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objASPDropDownListEx;

                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
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
        public static ASPControlEx GetObjByQryFld(clsQryRegionFldsEN objQryRegionFldsEx, string strCmPrjId)
        {

            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objASPCheckBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objASPCheckBoxENEx;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("spn{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.objQryRegionFldsEN = objQryRegionFldsEx;
              
                    objASPDropDownListEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objQryRegionFldsEx.ObjPrjTab_PC().TabName;
                    objASPDropDownListEx.DdlItemsOptionId = objQryRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = objQryRegionFldsEx.DsTabName();

                    return objASPDropDownListEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static ASPControlEx GetControl_Asp(clsDGRegionFldsEN objDGRegionFldsEx, string strCmPrjId)
        {

            switch (objDGRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPCheckBoxENEx.OnClick4Html = string.Format("chk_Click('{0}')", objASPCheckBoxENEx.CtrlId);
                    //objASPCheckBoxENEx.Is4PureHtml = true;
                    objASPCheckBoxENEx.Caption = objDGRegionFldsEx.HeaderText;
                    objASPCheckBoxENEx.CsType = objDGRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPCheckBoxENEx.FldName = objDGRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 0;
                    
                    objASPCheckBoxENEx.Text = objDGRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objASPCheckBoxENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objASPCheckBoxENEx;

                case "TextBox":
                case "Label":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    string strCtrlId = "";
                    if (string.IsNullOrEmpty(objDGRegionFldsEx.OutFldId) == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.OutFldId, strCmPrjId);
                        if (objFieldTab != null)
                        {
                            strCtrlId = string.Format("dn_txt{0}_q", objFieldTab.FldName);
                        }
                        else
                        {
                            strCtrlId = string.Format("dn_txt{0}_q", objDGRegionFldsEx.mId);                          
                        }
                    }
                    else
                    {

                        strCtrlId = string.Format("txt{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    }
                    int intIndex = 1;
                    string strNewCtrlId = strCtrlId;
                    if (arrCtrlId == null) arrCtrlId = new List<string>();
                    while (true)
                    {
                        if (arrCtrlId.Contains(strNewCtrlId) == false)
                        {
                            objASPTextBoxENEx.CtrlId = strNewCtrlId;
                            arrCtrlId.Add(strNewCtrlId);
                            break;
                        }
                        else
                        {
                            intIndex++;
                            strNewCtrlId = string.Format("{0}_{1}", strCtrlId, intIndex);

                        }
                    }
                objASPTextBoxENEx.OnClick4Html = string.Format("txt_Click('{0}')", objASPTextBoxENEx.CtrlId);
                    //objASPTextBoxENEx.Is4PureHtml = true;
                    objASPTextBoxENEx.Caption = objDGRegionFldsEx.HeaderText;
                    objASPTextBoxENEx.CsType = objDGRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPTextBoxENEx.FldName = objDGRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;

                    objASPTextBoxENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                case enumCtlType.DropDownList_Bool_18:
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("spn{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.OnClick4Html = string.Format("ddl_Click('{0}')", objASPDropDownListEx.CtrlId);

                    //objASPDropDownListEx.Is4PureHtml = true;
                    objASPDropDownListEx.Caption = objDGRegionFldsEx.HeaderText;
                    objASPDropDownListEx.CsType = objDGRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPDropDownListEx.FldName = objDGRegionFldsEx.ObjFieldTab_PC().FldName;

                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 0;
                    objASPDropDownListEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    
                    objASPDropDownListEx.FldName = objDGRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objDGRegionFldsEx.ObjPrjTab_PC().TabName;
                    //objASPDropDownListEx.DdlItemsOptionId = objDGRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = "";// objDGRegionFldsEx.DsTabName;

                    return objASPDropDownListEx;
                case "Button":
                    ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                    if (objDGRegionFldsEx.ButtonValue().Contains( "修改"))
                    {
                        objASPButtonENEx.CtrlId = "btnUpdate";
                        objASPButtonENEx.Text = "修改";
                    }
                    else if (objDGRegionFldsEx.ButtonValue().Contains( "删除"))
                    {
                        objASPButtonENEx.CtrlId = "btnDelete";
                        objASPButtonENEx.Text = "删除";
                    }
                    objASPButtonENEx.OnClick4Html = string.Format("btnClick('{0}')", objASPButtonENEx.CtrlId);

                    //objASPButtonENEx.Is4PureHtml = true;
                    //objASPButtonENEx.CtrlId = string.Format("btn{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPButtonENEx.Caption = objDGRegionFldsEx.HeaderText;
                    objASPButtonENEx.CsType = "";// objDGRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                    objASPButtonENEx.FldName = "";// objDGRegionFldsEx.ObjFieldTab_PC().FldName;
                    
                    objASPButtonENEx.Width = 200;
                    objASPButtonENEx.Height = 22;

                    objASPButtonENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objASPButtonENEx;
                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objDGRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        public static ASPControlEx GetControl_Asp(clsExcelExportRegionFldsEN objExcelExportRegionFldsEx)
        {

            ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
            objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objExcelExportRegionFldsEx.ObjFieldTab_PC().FldName);
            objASPTextBoxENEx.OnClick4Html = string.Format("txt_Click('{0}')", objASPTextBoxENEx.CtrlId);

            objASPTextBoxENEx.Caption = objExcelExportRegionFldsEx.ColCaption;
            objASPTextBoxENEx.CsType = objExcelExportRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            objASPTextBoxENEx.FldName = objExcelExportRegionFldsEx.ObjFieldTab_PC().FldName;

            objASPTextBoxENEx.Width = 200;
            objASPTextBoxENEx.Height = 22;

            objASPTextBoxENEx.objExcelExportRegionFldsEN = objExcelExportRegionFldsEx;
            return objASPTextBoxENEx;


        }



        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">编辑区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static ASPControlEx GetObjByEditFld(clsEditRegionFldsEN objEditRegionFldsEx, string strCmPrjId)
        {
            string strFldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;
            switch (objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 0;
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objASPCheckBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objASPCheckBoxENEx;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objASPTextBoxENEx;

                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("spn{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 0;
                    objASPDropDownListEx.objEditRegionFldsEN = objEditRegionFldsEx;
               
                    objASPDropDownListEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objEditRegionFldsEx.ObjPrjTab_PC().TabName;
                    objASPDropDownListEx.DdlItemsOptionId = objEditRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = objEditRegionFldsEx.DsTabName();

                    return objASPDropDownListEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_FieldVarDef(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_FieldVarDef(objASPDropDownListEx, strCodeForCs);
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
        public static void Gen_BindDdl(ASPControlEx objASPControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                case "ASPTextAreaEx":

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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_BindDdl(objASPDropDownListEx, objViewInfoENEx, strCodeForCs);
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
        public static void Gen_BindDdlInTaskQueue(ASPControlEx objASPControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                case "ASPTextAreaEx":

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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_BindDdlInTaskQueue(objASPDropDownListEx, objViewInfoENEx, strCodeForCs);
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
                case "ASPTextAreaEx":

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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_DefDdlBindObj(objASPDropDownListEx, strCodeForCs, arrDdlBindObjLst);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_FieldVarBind(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_FieldVarBind(objASPDropDownListEx, strCodeForCs);
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

   
        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objASPControlENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPControlEx objASPControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_LvFieldAssignment(objASPTextBoxENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_LvFieldAssignment(objASPTextAreaENEx, objViewInfoENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_LvFieldAssignment(objASPDropDownListEx, objViewInfoENEx, strCodeForCs);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_GetValue4FieldCtrl4Edit(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_GetValue4FieldCtrl4Edit(objASPDropDownListEx, strCodeForCs);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_GetValue4FieldCtrl4Qry(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_GetValue4FieldCtrl4Qry(objASPDropDownListEx, strCodeForCs);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_SetValue4FieldCtrl4Edit(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_SetValue4FieldCtrl4Edit(objASPDropDownListEx, strCodeForCs);
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
        public static void Gen_ClearFieldCtrl4Edit(ASPControlEx objASPControlENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            string strType = objASPControlENEx.GetType().Name;
            switch (strType)
            {
                case "ASPTextBoxEx":
                    ASPTextBoxEx objASPTextBoxENEx = objASPControlENEx as ASPTextBoxEx;
                    clsASPTextBoxBLEx.Gen_ClearFieldCtrl4Edit(objASPTextBoxENEx, strCodeForCs, strCmPrjId);
                    break;
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_ClearFieldCtrl4Edit(objASPTextAreaENEx, strCodeForCs, strCmPrjId);
                    break;
                case "ASPLabelEx":
                    ASPLabelEx objASPLabelENEx = objASPControlENEx as ASPLabelEx;
                    clsASPLabelBLEx.Gen_ClearFieldCtrl4Edit(objASPLabelENEx, strCodeForCs, strCmPrjId);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_ClearFieldCtrl4Edit(objASPDropDownListEx, strCodeForCs, strCmPrjId);
                    break;
                case "ASPCheckBoxEx":
                    ASPCheckBoxEx objASPCheckBoxENEx = objASPControlENEx as ASPCheckBoxEx;
                    clsASPCheckBoxBLEx.Gen_ClearFieldCtrl4Edit(objASPCheckBoxENEx, strCodeForCs, strCmPrjId);
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
                case "ASPTextAreaEx":
                    ASPTextAreaEx objASPTextAreaENEx = objASPControlENEx as ASPTextAreaEx;
                    clsASPTextAreaBLEx.Gen_SetValue4FieldCtrl4Qry(objASPTextAreaENEx, strCodeForCs);
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
                    ASPDropDownListEx objASPDropDownListEx = objASPControlENEx as ASPDropDownListEx;
                    clsASPDropDownListBLEx.Gen_SetValue4FieldCtrl4Qry(objASPDropDownListEx, strCodeForCs);
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

        public static ASPControlEx GetControlGroup_Asp(clsQryRegionFldsEN objQryRegionFldsEx, string strCmPrjId)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlEx objASPControlENEx = new ASPControlEx();

            ASPLabelEx objLabel = new ASPLabelEx();

            objLabel.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width ?? 0;
            objLabel.Height = ASPControlEx.objLabelStyle_Text.Height ?? 0;

            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            objLabel.CssClass = "text-secondary";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objQryRegionFldsEx.LabelCaption;

            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {

                case "CheckBox":
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);

                    objASPCheckBoxENEx.Width = 200;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objASPCheckBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case "TextBox":
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPTextBoxENEx.Width = 200;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    objASPControlENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case "DropDownList":
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objASPDropDownListEx.Width = 200;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.objQryRegionFldsEN = objQryRegionFldsEx;

                    objASPDropDownListEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;
                    objASPDropDownListEx.TabName = objQryRegionFldsEx.ObjPrjTab_PC().TabName;
                    objASPDropDownListEx.DdlItemsOptionId = objQryRegionFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.DsTabName = objQryRegionFldsEx.DsTabName();

                    objASPControlENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;
                default:
                    string strMsg = string.Format("查询区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

            return objASPControlENEx;
        }

        public static ASPControlEx GetControl_Asp(clsViewFeatureFldsENEx objViewFeatureFldsEx, string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            //if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();

            //objViewFeatureFldsEx.ViewFeatureId
            //ASPControlEx objASPControlENEx = new ASPControlEx();

            string strAdditionalCtrlId = "";
            switch (objViewFeatureFldsEx.FeatureId)
            {
                case enumPrjFeature.SetFieldValue_0148:
                    if (objViewFeatureFldsEx.CtrlId.IndexOf("_SetFldValue") == -1)
                    {
                        strAdditionalCtrlId = "_SetFldValue";
                    }
                    break;
                default:
                    //objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    if (objViewFeatureFldsEx.CtrlId.IndexOf("_f") == -1)
                    {
                        strAdditionalCtrlId = "_f";
                    }
                    break;
            }
            switch (objViewFeatureFldsEx.CtlTypeId)
            {

                case enumCtlType.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    //objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        objASPCheckBoxENEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                    }
                    else
                    {
                        objASPCheckBoxENEx.CtrlId = string.Format("chk{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId); 
                    }
                    objASPCheckBoxENEx.Class = "form-control form-control-sm";
                    objASPCheckBoxENEx.FldName = objASPCheckBoxENEx.CtrlId.Substring(3);
                    objASPCheckBoxENEx.CtlTypeId= objASPCheckBoxENEx.CtlTypeId;

                    objASPCheckBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPCheckBoxENEx.CsType = objViewFeatureFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr_PC().CsType;
                    objASPCheckBoxENEx.Caption = objViewFeatureFldsEx.ObjFieldTabENEx.Caption;
                    objASPCheckBoxENEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPCheckBoxENEx.GroupName = objViewFeatureFldsEx.GroupName;

                    objASPCheckBoxENEx.Width = 100;
                    objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.Text = objViewFeatureFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objViewFeatureFldsEN = objViewFeatureFldsEx;
                    return objASPCheckBoxENEx;


                case enumCtlType.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    //objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        if (objViewFeatureFldsEx.CtrlId.Contains(strAdditionalCtrlId) == false)
                        {
                            objASPTextBoxENEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                        }
                        else
                        {
                            objASPTextBoxENEx.CtrlId = objViewFeatureFldsEx.CtrlId;
                        }
                    }
                    else
                    {
                        objASPTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId);
                    }
                    objASPTextBoxENEx.Class = "form-control form-control-sm";
                    objASPTextBoxENEx.FldName = objASPTextBoxENEx.CtrlId.Substring(3);
                    objASPTextBoxENEx.DataProperty = string.Format("{0}_f", objViewFeatureFldsEx.ObjFieldTabENEx.FldName); ;
                    objASPTextBoxENEx.CtlTypeId = objASPTextBoxENEx.CtlTypeId;

                    objASPTextBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPTextBoxENEx.CsType = objViewFeatureFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr_PC().CsType;
                    objASPTextBoxENEx.Caption = objViewFeatureFldsEx.ObjFieldTabENEx.Caption;

                    objASPTextBoxENEx.Width = 60;
                    objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPTextBoxENEx.GroupName = objViewFeatureFldsEx.GroupName;

                    objASPTextBoxENEx.objViewFeatureFldsEN = objViewFeatureFldsEx;
                    return objASPTextBoxENEx;
                case enumCtlType.DropDownList_06:
                case enumCtlType.DropDownList_Bool_18:
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();

                    //objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtrlId) == false)
                    {
                        objASPDropDownListEx.CtrlId = string.Format("{0}{1}", objViewFeatureFldsEx.CtrlId, strAdditionalCtrlId);
                    }
                    else
                    {
                        objASPDropDownListEx.CtrlId = string.Format("ddl{0}{1}", objViewFeatureFldsEx.ObjFieldTabENEx.FldName, strAdditionalCtrlId);
                    }
                    objASPDropDownListEx.CtrlId = objASPDropDownListEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                objASPDropDownListEx.Class = "form-control form-control-sm";
                    objASPDropDownListEx.FldName = objASPDropDownListEx.CtrlId.Substring(3);
                   objASPDropDownListEx.DataProperty = string.Format("{0}_f", objViewFeatureFldsEx.ObjFieldTabENEx.FldName); ;
                    objASPDropDownListEx.CtlTypeId = objViewFeatureFldsEx.CtlTypeId;

                    objASPDropDownListEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPDropDownListEx.CsType = objViewFeatureFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr_PC().CsType;
                    objASPDropDownListEx.Caption = objViewFeatureFldsEx.ObjFieldTabENEx.Caption;

                    objASPDropDownListEx.TabName = objViewFeatureFldsEx.RelaTabName;
                    objASPDropDownListEx.DdlItemsOptionId = objViewFeatureFldsEx.DdlItemsOptionId;
                    objASPDropDownListEx.TabFeatureId4Ddl = objViewFeatureFldsEx.TabFeatureId4Ddl;
                    objASPDropDownListEx.DsTabName = objViewFeatureFldsEx.DsTabName;
              
                    objASPDropDownListEx.Width = 60;
                    objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.OrderNum = objViewFeatureFldsEx.SeqNum;
                    objASPDropDownListEx.GroupName = objViewFeatureFldsEx.GroupName;
                 
                    objASPDropDownListEx.objViewFeatureFldsEN = objViewFeatureFldsEx;
                    objASPDropDownListEx.ValueFieldName = objViewFeatureFldsEx.ValueFieldName;
                    objASPDropDownListEx.TextFieldName = objViewFeatureFldsEx.TextFieldName;
                    return objASPDropDownListEx;
                case enumCtlType.GivenValue_35:
                case enumCtlType.ViewVariable_38:
                case enumCtlType.None_00:


                    return null;
                default:
                    string strMsg = string.Format("界面功能字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objViewFeatureFldsEx.ObjCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
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