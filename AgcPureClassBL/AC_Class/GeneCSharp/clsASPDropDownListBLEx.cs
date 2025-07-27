
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPDropDownListBLEx
表名:ASPNETDropDownList(00050414)
生成代码版本:2018.06.28.1
生成日期:2018/06/29 13:56:07
生成者:潘以锋
生成服务器IP:202.121.63.42
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
using Agc.PureClass;
using Agc.PureClassEx;
using AGC.BusinessLogic;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI.HtmlControls;

namespace AGC.PureClassEx
{

    public static class clsASPDropDownListBLEx_Static
    {
        public static bool IsUseCache_TS2(this clsPrjTabEN objPrjTabEN)
        {
            List<string> arrCacheModeId = new List<string>() { enumCacheMode.ClientCache_02, enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            if (arrCacheModeId.Contains(objPrjTabEN.CacheModeId) == true) return true;
            return false;
        }
        public static clsFieldTabEN objFieldTabCacheClassify2(this ASPDropDownListEx objASPDropDownListEx)
        {
            if (objASPDropDownListEx.objPrjTab_CodeTab == null) return null;
            if (string.IsNullOrEmpty(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField) == false)
            {
                var objFieldTabCacheClassify1 = clsFieldTabBL.GetObjByFldIdCache(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField, objASPDropDownListEx.objPrjTab_CodeTab.PrjId);
                return objFieldTabCacheClassify1;
            }
            return null;
        }


        public static string GC_SetDefaultValue(this ASPDropDownListEx objASPDropDownListEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                objASPDropDownListEx.CtrlId);


            return strCodeForCs.ToString();
        }

        public static string GC_DefFldProperty(this ASPDropDownListEx objASPDropDownListEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objASPDropDownListEx.Caption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objASPDropDownListEx.CsType,
                objASPDropDownListEx.FldName);
            strCodeForCs.Append("\r\n" + "{");


            if (objASPDropDownListEx.CsType == "bool")
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objASPDropDownListEx.CsType == "int"
                || objASPDropDownListEx.CsType == "bigint"
                || objASPDropDownListEx.CsType == "short"
               )
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.AppendFormat("\r\n" + "return 0;");
                strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                    objASPDropDownListEx.CtrlId, objASPDropDownListEx.CsType);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public static void GeneCode4Html(this ASPDropDownListEx objASPDropDownListEx,
       StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<select");
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPDropDownListEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPDropDownListEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPDropDownListEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPDropDownListEx.CssClass);
            }
            if (string.IsNullOrEmpty(objASPDropDownListEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPDropDownListEx.Class);
            }

            if (objASPDropDownListEx.Width > 0)
            {
                objASPDropDownListEx.Style += string.Format("width:{0}px;", objASPDropDownListEx.Width);
                objASPDropDownListEx.Width = 0;
            }
            //if (objASPDropDownListEx.Height > 0)
            //{
            //    objASPDropDownListEx.Style += string.Format("height:{0}px;", objASPDropDownListEx.Height);
            //    objASPDropDownListEx.Height = 0;
            //}
            if (string.IsNullOrEmpty(objASPDropDownListEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPDropDownListEx.Style);
            }


            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPDropDownListEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPDropDownListEx, strCodeForCs);

            //   clsASPControlBLEx.GC4Text(objASPDropDownListEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPDropDownListEx.entries) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                    objASPDropDownListEx.entries);
            }

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPDropDownListEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("></select>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPDropDownListEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            //}


        }
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPDropDownListEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPDropDownListEx objASPDropDownListEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            //if (objASPDropDownListEx.CtlTypeId == null) return;
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<asp:DropDownList");
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPDropDownListEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDropDownListEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPDropDownListEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDropDownListEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDropDownListEx, strCodeForCs);

                    //   clsASPControlBLEx.GC4Text(objASPDropDownListEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPDropDownListEx.entries) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                            objASPDropDownListEx.entries);
                    }

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPDropDownListEx, strCodeForCs);
                    strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("/>");

                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                //if (objASPDropDownListEx.Is4PureHtml == true)
                //{
                //    objASPDropDownListEx.GeneCode(intApplicationTypeId, strCodeForCs);
                //    return;
                //}
                //break;
                case enumApplicationType.SpaAppInCore_TS_18:

                    if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<select");
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPDropDownListEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDropDownListEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPDropDownListEx.CssClass) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPDropDownListEx.CssClass);
                    }
                    if (string.IsNullOrEmpty(objASPDropDownListEx.Class) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPDropDownListEx.Class);
                    }

                    if (objASPDropDownListEx.Width > 0)
                    {
                        objASPDropDownListEx.Style += string.Format("width:{0}px;", objASPDropDownListEx.Width);
                        objASPDropDownListEx.Width = 0;
                    }
                    //if (objASPDropDownListEx.Height > 0)
                    //{
                    //    objASPDropDownListEx.Style += string.Format("height:{0}px;", objASPDropDownListEx.Height);
                    //    objASPDropDownListEx.Height = 0;
                    //}
                    if (string.IsNullOrEmpty(objASPDropDownListEx.Style) == false)
                    {
                        strCodeForCs.AppendFormat(" style=\"{0}\"",
                            objASPDropDownListEx.Style);
                    }


                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDropDownListEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDropDownListEx, strCodeForCs);

                    //   clsASPControlBLEx.GC4Text(objASPDropDownListEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPDropDownListEx.entries) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                            objASPDropDownListEx.entries);
                    }

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPDropDownListEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("></select>");

                    //foreach (ASPControlEx objSubASPControlENEx in objASPDropDownListEx.arrSubAspControlLst2)
                    //{
                    //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
                    //}

                    break;
                case enumApplicationType.VueAppInCore_TS_30:

                    if (string.IsNullOrEmpty(objASPDropDownListEx.ValueFieldName) == true)
                    {
                        if (objASPDropDownListEx.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                        {

                        }
                        else if (objASPDropDownListEx.CtlTypeId == enumCtlType.DropDownList_06 && objASPDropDownListEx.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                        {

                        }
                        else
                        {
                            return;
                        }
                    }
                    if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<select");
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4Id(objASPDropDownListEx, strCodeForCs);
                    if (objASPDropDownListEx.TypeScriptType == "number")
                    {
                        strCodeForCs.Append($" v-model.number='{clsString.FirstLcaseS(objASPDropDownListEx.DataProperty)}'");
                    }
                    else
                    {
                        strCodeForCs.Append($" v-model='{clsString.FirstLcaseS(objASPDropDownListEx.DataProperty)}'");
                    }
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDropDownListEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPDropDownListEx.CssClass) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPDropDownListEx.CssClass);
                    }
                    if (string.IsNullOrEmpty(objASPDropDownListEx.Class) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPDropDownListEx.Class);
                    }
                    if (string.IsNullOrEmpty(objASPDropDownListEx.ClickEvent) == false)
                    {
                        strCodeForCs.AppendFormat(" @click=\"{0}($event)\"",
                            objASPDropDownListEx.ClickEvent);
                    }
                    if (string.IsNullOrEmpty(objASPDropDownListEx.ChangeEvent) == false)
                    {
                        strCodeForCs.AppendFormat(" @change=\"{0}($event)\"",
                            objASPDropDownListEx.ChangeEvent);
                    }

                    if (objASPDropDownListEx.Width > 0)
                    {
                        objASPDropDownListEx.Style += string.Format("width:{0}px;", objASPDropDownListEx.Width);
                        objASPDropDownListEx.Width = 0;
                    }
                    //if (objASPDropDownListEx.Height > 0)
                    //{
                    //    objASPDropDownListEx.Style += string.Format("height:{0}px;", objASPDropDownListEx.Height);
                    //    objASPDropDownListEx.Height = 0;
                    //}
                    if (string.IsNullOrEmpty(objASPDropDownListEx.Style) == false)
                    {
                        strCodeForCs.AppendFormat(" style=\"{0}\"",
                            objASPDropDownListEx.Style);
                    }


                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDropDownListEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDropDownListEx, strCodeForCs);

                    //   clsASPControlBLEx.GC4Text(objASPDropDownListEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPDropDownListEx.entries) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                            objASPDropDownListEx.entries);
                    }

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPDropDownListEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.Append(">");
                    if (objASPDropDownListEx.DdlItemsOptionId == enumDDLItemsOption.DataSourceTable_02                        
                        && string.IsNullOrEmpty(objASPDropDownListEx.DsTabName) == false)
                    {
                        strCodeForCs.Append("\r\n" + $"<option v-for=\"(item, index) in arr{objASPDropDownListEx.DsTabName} \" :key = \"index\" :value = \"item.{clsString.FstLcaseS(objASPDropDownListEx.ValueFieldName)}\" >");
                        strCodeForCs.Append("\r\n" + $"{{{{ item.{clsString.FstLcaseS(objASPDropDownListEx.TextFieldName)} }}}}");
                        strCodeForCs.Append("\r\n" + $"</option>");
                    }
                    else if (objASPDropDownListEx.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04
                        || string.IsNullOrEmpty( objASPDropDownListEx.TabFeatureId4Ddl) == true
                        || string.IsNullOrEmpty(objASPDropDownListEx.DsTabName) == true)
                    {
                        strCodeForCs.Append("\r\n" + $"<option value=\"0\">选择是/否</option>");
                        strCodeForCs.Append("\r\n" + $"<option value=\"true\">是</option>");
                        strCodeForCs.Append("\r\n" + $"<option value=\"false\">否</option>");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"<option v-for=\"(item, index) in arr{objASPDropDownListEx.DsTabName} \" :key = \"index\" :value = \"item.{clsString.FstLcaseS(objASPDropDownListEx.ValueFieldName)}\" >");
                        strCodeForCs.Append("\r\n" + $"{{{{ item.{clsString.FstLcaseS(objASPDropDownListEx.TextFieldName)} }}}}");
                        strCodeForCs.Append("\r\n" + $"</option>");
                    }
                    strCodeForCs.Append("</select>");

                    //foreach (ASPControlEx objSubASPControlENEx in objASPDropDownListEx.arrSubAspControlLst2)
                    //{
                    //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
                    //}

                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }


        }

        public static void GeneCode4Mvc(this ASPDropDownListEx objASPDropDownListEx,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
            }
            string strFldName = objASPDropDownListEx.FldName;
            if (string.IsNullOrEmpty(objASPDropDownListEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPDropDownListEx.ItemName4MultiModel, objASPDropDownListEx.FldName);
            }
            if (objASPDropDownListEx.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
            {
                strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>, new {{ Name=\"{2}\" }})",
                    objASPDropDownListEx.TabName, strFldName, objASPDropDownListEx.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"{2}List\"] as List<SelectListItem>, new {{ Name=\"{3}\" }})",
                    objASPDropDownListEx.TabName, strFldName, objASPDropDownListEx.DsTabName4GC, objASPDropDownListEx.FldName);
            }

        }

        public static void GeneHtmlControl(this ASPDropDownListEx objASPDropDownListEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListEx.mKey);
            }
            HtmlSelect objSelect = new HtmlSelect();
            objSelect.Attributes["class"] = "form-control form-control-sm";
            objSelect.ID = objASPDropDownListEx.CtrlId;
            objSelect.Name = objASPDropDownListEx.CtrlName;
            if (objASPDropDownListEx.Width > 0)
            {
                objSelect.Style.Add("width", string.Format("{0}px", objASPDropDownListEx.Width));
            }
            if (string.IsNullOrEmpty(objASPDropDownListEx.OnClick4Html) == false)
            {
                objSelect.Attributes.Add("onclick", objASPDropDownListEx.OnClick4Html);
            }
            objContainer.Controls.Add(objSelect);
            return;

        }



        /// <summary>
        /// 生成绑定下拉框的代码
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <returns></returns>
        public static string GC_BindDdl4Mvc2(this ASPDropDownListEx objASPDropDownListEx)
        {
            string strCodeForCs = "";
            if (objASPDropDownListEx.CsType == "bool")
            {
                //strCodeForCs = string.Format("clsCommForWebForm.BindDdlTrueAndFalse({0});", objASPDropDownListEx.CtrlId);
                strCodeForCs = string.Format("  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
            }
            else
            {

                if (objASPDropDownListEx.objPrjTab_CodeTab == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                        objASPDropDownListEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                //if (objASPDropDownListEx.objFieldTab_ValueField == null)
                //{
                //    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                //        objASPDropDownListEx.CtrlName,
                //        clsStackTrace.GetCurrClassFunction());
                //    throw new Exception(strMsg);
                //}
                //if (objASPDropDownListEx.objFieldTab_TextField == null)
                //{
                //    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                //        objASPDropDownListEx.CtrlName,
                //        clsStackTrace.GetCurrClassFunction());
                //    throw new Exception(strMsg);
                //}

                //strCodeForCs = string.Format("cls{2}BL.BindDdl{0}({1});",
                //        objASPDropDownListEx.objFieldTab_ValueField.FldName,
                //        objASPDropDownListEx.CtrlId,
                //        objASPDropDownListEx.objPrjTab_CodeTab.TabName);
                strCodeForCs = string.Format("ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                      objASPDropDownListEx.DsTabName4GC);

            }
            return strCodeForCs;
        }



        /// <summary>
        /// 函数名说明
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <returns></returns>
        public static string GC_SetBindDdl_Description_TS(this ASPDropDownListEx objASPDropDownListEx, string strCurrClassFunction)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * 设置绑定下拉框，针对字段:[{0}]",
              objASPDropDownListEx.FldName);
            strCodeForCs.AppendFormat("\r\n * ({0})", strCurrClassFunction);
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }
        public static string GC_SetBindDdl4Bool_TS4QueryEdit1(this ASPDropDownListEx objASPDropDownListEx, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objASPDropDownListEx.CsType == "bool")
            {
                strCodeForCs.AppendLine(objASPDropDownListEx.GC_SetBindDdl_Description_TS(clsStackTrace.GetCurrClassFunction()));

                strCodeForCs.AppendFormat("\r\n" + "public async SetDdl_{0}()", objASPDropDownListEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "BindDdl_TrueAndFalseInDiv({0}, \"{1}\");", objASPDropDownListEx.DivName, objASPDropDownListEx.CtrlId);

                objImportClass.AddImportClass(objASPDropDownListEx.DsTabId, "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDiv", enumImportObjType.CustomFunc, strBaseUrl);


                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        public static string GC_BindDdl4Bool_TS(this ASPDropDownListEx objASPDropDownListEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objASPDropDownListEx.CsType == "bool")
            {
                strCodeForCs.AppendLine(objASPDropDownListEx.GC_SetBindDdl_Description_TS(clsStackTrace.GetCurrClassFunction()));

                strCodeForCs.AppendFormat("\r\n" + "public async SetDdl{0}()", objASPDropDownListEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");", objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }



    }
    /// <summary>
    /// ASPNET下拉框(ASPNETDropDownList)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPDropDownListBLEx
    {



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private DropDownList {0};",
                objASPDropDownListEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (DropDownList)findViewById(R.id.{0}); ",
                objASPDropDownListEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (DropDownList)view.findViewById(R.id.{0}); ",
                objASPDropDownListEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
            string strDdlTabName = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                             objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
                             strDdlTabName,
                             objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName,
                         objASPDropDownListEx.CtrlId);

            //strCodeForCs.AppendFormat("\r\n" + "String {0} = (String){1}.getSelectedItem();",
            //  objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
            //  objASPDropDownListEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
              objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName());
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}", objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName())));


            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;
            string strDdlTabName = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            //String strCollegeId = mobjddlBindCollege.getDdlAdapterCollege().getCollegeId((int)spnCollegeId.getSelectedItemId());

            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                                objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
                                strDdlTabName,
                                objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName,
                            objASPDropDownListEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
                objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName());

            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}", objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName())));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
                objASPDropDownListEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPDropDownListEx objASPDropDownListEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
 objASPDropDownListEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPDropDownListEx objASPDropDownListEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPDropDownListEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlBak20180403(ASPDropDownListEx objASPDropDownListEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            }
            if (objASPDropDownListEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            }

        }

        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(ASPDropDownListEx objASPDropDownListEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl{0}\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objASPDropDownListEx.CtrlId);

            }
            if (objASPDropDownListEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl{0}_q\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objASPDropDownListEx.CtrlId);

            }

        }

        /// <summary>
        /// 绑定下拉框, 在任务队列中 
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(ASPDropDownListEx objASPDropDownListEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strValueFld = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTab_Code();
                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl{0}\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0} = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}.BindDdl{1}(myTask.getDropDownList(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }
            if (objASPDropDownListEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strValueFld = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTab_Code();

                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl{0}_q\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0}_q = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}_q.BindDdl{1}(myTask.getDropDownList(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }

        }


        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>        
        /// <param name="strCodeForCs"></param>
        /// <param name="arrDdlBindObjLst"></param>
        public static void Gen_DefDdlBindObj(ASPDropDownListEx objASPDropDownListEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            if (objASPDropDownListEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }
            if (objASPDropDownListEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objASPDropDownListEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }

        }


        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPDropDownListEx objASPDropDownListEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setSelection(0);",
               objASPDropDownListEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeName,
            objASPDropDownListEx.objEditRegionFldsEN.ObjFieldTab_PC().FldLength,
            objASPDropDownListEx.objEditRegionFldsEN.IsTabNullable(strCmPrjId),
            objASPDropDownListEx.objEditRegionFldsEN.MemoInTab(strCmPrjId));

        }

        //public static ASPDropDownListEx GetDropDownLst_Asp(clsViewFeatureFldsENEx objViewFeatureFldsEx)
        //{
        //    if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
        //    ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();


        //    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
        //    objASPDropDownListEx.CtrlId = objViewFeatureFldsEx.CtrlId;
        //    objASPDropDownListEx.Width = 200;
        //    objASPDropDownListEx.CssClass = "form-control";
        //    objASPDropDownListEx.objViewFeatureFldsEN = objViewFeatureFldsEx;
        //    objASPDropDownListEx.CsType = objViewFeatureFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
        //    if (objViewFeatureFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType == "bool")
        //    {
        //    }
        //    else
        //    {
        //        objASPDropDownListEx.objPrjTab_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objViewFeatureFldsEx.DsTabId);
        //        objASPDropDownListEx.objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldIDCache(objViewFeatureFldsEx.DsDataValueFieldId, 
        //            objViewFeatureFldsEx.ObjFieldTab_PC().PrjId);
        //        objASPDropDownListEx.objFieldTab_TextField = clsFieldTabBLEx.GetObjByFldIDCache(objViewFeatureFldsEx.Ds_DataTextFieldId, 
        //            objViewFeatureFldsEx.ObjFieldTab_PC().PrjId);

        //    }
        //    return objASPDropDownListEx;
        //}


        public static ASPDropDownListEx GetDropDownLst_Asp(clsViewFeatureFldsENEx objViewFeatureFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();

            var strPrjId = objViewFeatureFldsEx.PrjId;

            ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
            objASPDropDownListEx.CtrlId = objViewFeatureFldsEx.CtrlId;
            objASPDropDownListEx.RegionTypeId = enumRegionType.FeatureRegion_0008;

            objASPDropDownListEx.FldName = objViewFeatureFldsEx.ObjFieldTabENEx.FldName;
            objASPDropDownListEx.FeatureId = objViewFeatureFldsEx.FeatureId;
            objASPDropDownListEx.ViewFeatureId = objViewFeatureFldsEx.ViewFeatureId;
            objASPDropDownListEx.TabFeatureId4Ddl = objViewFeatureFldsEx.TabFeatureId4Ddl;
            objASPDropDownListEx.FldIdCond1 = objViewFeatureFldsEx.FldIdCond1;

            objASPDropDownListEx.VarIdCond1 = objViewFeatureFldsEx.VarIdCond1;
            objASPDropDownListEx.FldIdCond2 = objViewFeatureFldsEx.FldIdCond2;

            objASPDropDownListEx.VarIdCond2 = objViewFeatureFldsEx.VarIdCond2;
            objASPDropDownListEx.PrjId = strPrjId;

            objASPDropDownListEx.Width = 200;
            objASPDropDownListEx.CssClass = "form-control form-control-sm";
            objASPDropDownListEx.objViewFeatureFldsEN = objViewFeatureFldsEx;
            objASPDropDownListEx.CsType = objViewFeatureFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr_PC().CsType;
            if (objViewFeatureFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr_PC().CsType == "bool")
            {
                objASPDropDownListEx.DsTabName = "TrueAndFalse";
            }
            else
            {
                objASPDropDownListEx.objPrjTab_CodeTab = objGetTabFieldObj.GetObjByTabId(objViewFeatureFldsEx.DsTabId,
                    objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
                //objASPDropDownListEx.objFieldTab_ValueField =
                //    string.IsNullOrEmpty(objViewFeatureFldsEx.DsDataValueFieldId)?null:
                //    objGetTabFieldObj.GetObjByFldId(objViewFeatureFldsEx.DsDataValueFieldId,                    objViewFeatureFldsEx.ObjFieldTab_PC().PrjId);
                //objASPDropDownListEx.objFieldTab_TextField =
                //    string.IsNullOrEmpty(objViewFeatureFldsEx.Ds_DataTextFieldId) ?null:
                //    objGetTabFieldObj.GetObjByFldId(objViewFeatureFldsEx.Ds_DataTextFieldId,
                //    objViewFeatureFldsEx.ObjFieldTab_PC().PrjId);
                objASPDropDownListEx.DsTabName = objASPDropDownListEx.objPrjTab_CodeTab.TabName;
                objASPDropDownListEx.DsTabId = objViewFeatureFldsEx.DsTabId;
                if (string.IsNullOrEmpty(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField) == false)
                {
                    //objASPDropDownListEx.objFieldTabCacheClassify = clsFieldTabBL.GetObjByFldIdCache(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField, objViewFeatureFldsEx.PrjId);
                }
                IEnumerable<clsTabFeatureEN> arrTabFeatureCache = clsTabFeatureBL.GetObjLstCache(objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
                List<string> arrPrjFeature = new List<string>() { enumPrjFeature.Tab_BindDdl_0173, enumPrjFeature.Tab_BindDdl_0221 };
                //objPrjTabENEx.arrTabFeatureSet =  clsTabFeatureBLEx.GetObjExLst(strCondition);
                List<clsTabFeatureEN> arrTabFeatureSet = arrTabFeatureCache.Where(x =>
                        x.TabId == objViewFeatureFldsEx.DsTabId
                        && x.InUse == true
                        && arrPrjFeature.Contains(x.FeatureId)
                ).ToList();
                if (arrTabFeatureSet.Count > 0)
                {
                    IEnumerable<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsBL.GetObjLstCache(strPrjId).Where(x => x.TabFeatureId == arrTabFeatureSet[0].TabFeatureId);
                    List<clsTabFeatureFldsEN> arrObjLst_Sel = arrObjLst.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    //if (arrObjLst_Sel.Count > 0)
                    //{
                    //    objASPDropDownListEx.objFieldTab_ConditionField = clsFieldTabBL.GetObjByFldIdCache(arrObjLst_Sel[0].FldId, strPrjId);
                    //}
                }
            }
            return objASPDropDownListEx;
        }


        public static ASPDropDownListEx GetDropDownLst_Asp(clsQryRegionFldsENEx objQryRegionFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            string strPrjId_p = objQryRegionFldsEx.PrjId;

            ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();

            objASPDropDownListEx.CtrlId = objQryRegionFldsEx.CtrlId();
            objASPDropDownListEx.RegionTypeId = enumRegionType.QueryRegion_0001;
            if (objQryRegionFldsEx.IsUseFunc_PC() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName_PC()) == false)
            {
                objASPDropDownListEx.FldName = objQryRegionFldsEx.DataPropertyName_PC();
            }
            else
            {
                objASPDropDownListEx.FldName = objQryRegionFldsEx.ObjFieldTab_PC().FldName;
            }
            objASPDropDownListEx.Width = 200;
            objASPDropDownListEx.CssClass = "form-control form-control-sm";
            objASPDropDownListEx.objQryRegionFldsEN = objQryRegionFldsEx;
            objASPDropDownListEx.CsType = objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            if (objQryRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType == "bool")
            {
                objASPDropDownListEx.DsTabName = "TrueAndFalse";
            }
            else
            {
                objASPDropDownListEx.objPrjTab_CodeTab = objGetTabFieldObj.GetObjByTabId(objQryRegionFldsEx.DsTabId, strPrjId_p);
                if (objASPDropDownListEx.objPrjTab_CodeTab == null)
                {
                    string strMsg = string.Format("查询区下拉框代码表不存在！(DsTabId:{0})", objQryRegionFldsEx.DsTabId);
                    throw new Exception(strMsg);
                }
                //if (string.IsNullOrEmpty(objQryRegionFldsEx.DsDataValueFieldId) == false)
                //{
                //    objASPDropDownListEx.objFieldTab_ValueField = objGetTabFieldObj.GetObjByFldId(objQryRegionFldsEx.DsDataValueFieldId,
                //        strPrjId_p);
                //}
                //if (string.IsNullOrEmpty(objQryRegionFldsEx.Ds_DataTextFieldId) == false)
                //{
                //    objASPDropDownListEx.objFieldTab_TextField = objGetTabFieldObj.GetObjByFldId(objQryRegionFldsEx.Ds_DataTextFieldId, strPrjId_p);
                //}
                objASPDropDownListEx.DsTabId = objQryRegionFldsEx.DsTabId;
                objASPDropDownListEx.TabFeatureId4Ddl = objQryRegionFldsEx.TabFeatureId4Ddl;
                objASPDropDownListEx.FldIdCond1 = objQryRegionFldsEx.FldIdCond1;

                objASPDropDownListEx.VarIdCond1 = objQryRegionFldsEx.VarIdCond1;
                objASPDropDownListEx.FldIdCond2 = objQryRegionFldsEx.FldIdCond2;

                objASPDropDownListEx.VarIdCond2 = objQryRegionFldsEx.VarIdCond2;
                objASPDropDownListEx.PrjId = strPrjId_p;

                objASPDropDownListEx.DsTabName = objASPDropDownListEx.objPrjTab_CodeTab.TabName;

                if (string.IsNullOrEmpty(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField) == false)
                {
                    //objASPDropDownListEx.objFieldTabCacheClassify = clsFieldTabBL.GetObjByFldIdCache(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField, objQryRegionFldsEx.PrjId);
                }

                IEnumerable<clsTabFeatureEN> arrTabFeatureCache = clsTabFeatureBL.GetObjLstCache(strPrjId_p);

                List<string> arrPrjFeature = new List<string>() { enumPrjFeature.Tab_BindDdl_0173, enumPrjFeature.Tab_BindDdl_0221 };
                //objPrjTabENEx.arrTabFeatureSet =  clsTabFeatureBLEx.GetObjExLst(strCondition);
                List<clsTabFeatureEN> arrTabFeatureSet = arrTabFeatureCache.Where(x =>
                        x.TabId == objQryRegionFldsEx.DsTabId
                        && x.InUse == true
                        && arrPrjFeature.Contains(x.FeatureId)
                ).ToList();
                if (arrTabFeatureSet.Count > 0)
                {
                    IEnumerable<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsBL.GetObjLstCache(strPrjId_p).Where(x => x.TabFeatureId == arrTabFeatureSet[0].TabFeatureId);
                    List<clsTabFeatureFldsEN> arrObjLst_Sel = arrObjLst.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    //if (arrObjLst_Sel.Count > 0)
                    //{
                    //    objASPDropDownListEx.objFieldTab_ConditionField = clsFieldTabBL.GetObjByFldIdCache(arrObjLst_Sel[0].FldId, strPrjId_p);
                    //}
                }
            }
            return objASPDropDownListEx;
        }


        public static ASPDropDownListEx GetDropDownLst_Asp(clsEditRegionFldsENEx objEditRegionFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            string strPrjId_p = objEditRegionFldsEx.PrjId;

            ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
            objASPDropDownListEx.CtrlId = objEditRegionFldsEx.CtrlId();
            objASPDropDownListEx.RegionTypeId = enumRegionType.EditRegion_0003;

            objASPDropDownListEx.Width = 200;
            objASPDropDownListEx.CssClass = "form-control form-control-sm";
            objASPDropDownListEx.objEditRegionFldsEN = objEditRegionFldsEx;
            objASPDropDownListEx.CsType = objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
            objASPDropDownListEx.FldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;
            objASPDropDownListEx.ItemsString = objEditRegionFldsEx.ItemsString;
            objASPDropDownListEx.DsCondStr = objEditRegionFldsEx.DsCondStr;
            objASPDropDownListEx.DsSqlStr = objEditRegionFldsEx.DsSqlStr;

            objASPDropDownListEx.DdlItemsOptionId = objEditRegionFldsEx.DdlItemsOptionId;
            if (objEditRegionFldsEx.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType == "bool")
            {
            }
            else if (string.IsNullOrEmpty(objEditRegionFldsEx.DsTabId) == true)
            {
            }
            else
            {
                objASPDropDownListEx.objPrjTab_CodeTab = objGetTabFieldObj.GetObjByTabId(objEditRegionFldsEx.DsTabId, strPrjId_p);
                objASPDropDownListEx.DsTabName = objASPDropDownListEx.objPrjTab_CodeTab.TabName;
                objASPDropDownListEx.DsTabId = objEditRegionFldsEx.DsTabId;
                objASPDropDownListEx.TabFeatureId4Ddl = objEditRegionFldsEx.TabFeatureId4Ddl;
                objASPDropDownListEx.FldIdCond1 = objEditRegionFldsEx.FldIdCond1;

                objASPDropDownListEx.VarIdCond1 = objEditRegionFldsEx.VarIdCond1;
                objASPDropDownListEx.FldIdCond2 = objEditRegionFldsEx.FldIdCond2;

                objASPDropDownListEx.VarIdCond2 = objEditRegionFldsEx.VarIdCond2;
                objASPDropDownListEx.PrjId = strPrjId_p;

                if (string.IsNullOrEmpty(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField) == false)
                {
                    //objASPDropDownListEx.objFieldTabCacheClassify = clsFieldTabBL.GetObjByFldIdCache(objASPDropDownListEx.objPrjTab_CodeTab.CacheClassifyField, objEditRegionFldsEx.PrjId);
                }
                IEnumerable<clsTabFeatureEN> arrTabFeatureCache = clsTabFeatureBL.GetObjLstCache(strPrjId_p);
                List<string> arrPrjFeature = new List<string>() { enumPrjFeature.Tab_BindDdl_0173, enumPrjFeature.Tab_BindDdl_0221 };
                //objPrjTabENEx.arrTabFeatureSet =  clsTabFeatureBLEx.GetObjExLst(strCondition);
                List<clsTabFeatureEN> arrTabFeatureSet = arrTabFeatureCache.Where(x =>
                        x.TabId == objEditRegionFldsEx.DsTabId
                        && x.InUse == true
                        && arrPrjFeature.Contains(x.FeatureId)
                ).ToList();
                if (arrTabFeatureSet.Count > 0)
                {
                    IEnumerable<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsBL.GetObjLstCache(strPrjId_p).Where(x => x.TabFeatureId == arrTabFeatureSet[0].TabFeatureId);
                    List<clsTabFeatureFldsEN> arrObjLst_Sel = arrObjLst.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    //if (arrObjLst_Sel.Count > 0)
                    //{
                    //    objASPDropDownListEx.objFieldTab_ConditionField = clsFieldTabBL.GetObjByFldIdCache(arrObjLst_Sel[0].FldId, strPrjId_p);
                    //    objASPDropDownListEx.objTabFeatureFlds = arrObjLst_Sel[0];
                    //}

                }
            }
            return objASPDropDownListEx;
        }

    }
    public class FourItem
    {
        public string Item1 { set; get; }
        public string Item2 { set; get; }
        public string Item3 { set; get; }
        public string Item4 { set; get; }
    }
}