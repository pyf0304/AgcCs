using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.BusinessLogic;
using AGC.Entity;
using AGC.PureClass;
using Agc.PureClassEx;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.common;
using System.Web.UI.HtmlControls;

namespace AGC.BusinessLogicEx
{

    public static class clsASPDropDownListBLEx_Static
    {
        public static bool IsUseCache_TS2(this clsPrjTabEN objPrjTabEN)
        {
            List<string> arrCacheModeId = new List<string>() { enumCacheMode.ClientCache_02, enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            if (arrCacheModeId.Contains(objPrjTabEN.CacheModeId) == true) return true;
            return false;
        }
        public static clsFieldTabEN objFieldTabCacheClassify(this ASPDropDownListEx objASPDropDownListEx)
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
                    if (objASPDropDownListEx.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04
                        || objASPDropDownListEx.DdlItemsOptionId == ""
                        || objASPDropDownListEx.DdlItemsOptionId == "00")
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
        public static string GC_BindDdl4Mvc(this ASPDropDownListEx objASPDropDownListEx)
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
        public static string GC_SetBindDdl4Bool_TS4QueryEdit(this ASPDropDownListEx objASPDropDownListEx, IImportClass objImportClass, string strBaseUrl)
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


        public static string GC_SetBindDdl4TabFeature4QueryEdit_TS(this ASPDropDownListEx objASPDropDownListEx, bool bolIsFstLcase, 
            string strRegionType, CacheClassify objCacheClassify_TS,
            List<clsTabFeatureFldsENEx> arrFieldLst_Cond, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll, string strFuncNameAddi, string strViewId, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendLine(objASPDropDownListEx.GC_SetBindDdl_Description_TS(clsStackTrace.GetCurrClassFunction()));

            //计算数据
            //计算绑定下拉框所需要的额外定义参数列表，以及调用其他函数所用的额外传递参数
            var objFuncParaLst = new FuncParaLst("DdlParaLst", bolIsFstLcase, enumAppLevel.InvokeFunc);
            //objFuncParaLst.AddParaByVar(objASPDropDownListEx.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            //objFuncParaLst.AddParaByVar(objASPDropDownListEx.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLst.AddParaByTabFeature(objASPDropDownListEx.objTabFeature, arrFieldLst_Cond, enumProgLangType.TypeScript_09);

            objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, strViewId, objASPDropDownListEx.PrjId);
            if (objFuncParaLstAll != null)
            {
                //objFuncParaLstAll.AddParaByVar(objASPDropDownListEx.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
                //objFuncParaLstAll.AddParaByVar(objASPDropDownListEx.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
                objFuncParaLstAll.AddParaByTabFeature(objASPDropDownListEx.objTabFeature, arrFieldLst_Cond, enumProgLangType.TypeScript_09);

                objFuncParaLstAll.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, strViewId, objASPDropDownListEx.PrjId);
            }
            //objASPDropDownListEx.DsTabId

            var strCondFldLst = objFuncParaLst.GetCondFldLst();
            var strCondFldLst4Para = objFuncParaLst.GetCondFldLst4Para();
            if (strCondFldLst.Length > 0) strCondFldLst = ", " + strCondFldLst;

            strCodeForCs.Append("\r\n" + $"public async SetDdl_{objASPDropDownListEx.FldName}InDiv{strFuncNameAddi}({strCondFldLst4Para})");

            strCodeForCs.Append("\r\n" + "{");

            string strFuncName = $"SetDdl_{objASPDropDownListEx.FldName}InDiv{strFuncNameAddi}";
            foreach (var objInfo in arrFieldLst_Cond)
            {
                string strDataTypeId = objInfo.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeId;
                var strTemp = clsPubFun.Gc_CheckVarEmpty_Ts(objInfo.ObjFieldTab_PC().PrivFuncName(), objInfo.ObjFieldTab_PC().ObjDataTypeAbbr_PC().TypeScriptType,
                    strDataTypeId,
                 "", strFuncName, objInfo.ObjFieldTab_PC().FldLength, strDataTypeId == enumDataTypeAbbr.char_04 ? true : false, objImportClass, strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }


            string strDataTypeId0 = objCacheClassify_TS.DataTypeId;
            var strTemp0 = clsPubFun.Gc_CheckVarEmpty_Ts(objCacheClassify_TS.PriVarName, objCacheClassify_TS.TypeScriptType,
                objCacheClassify_TS.DataTypeId,
             "", strFuncName, objCacheClassify_TS.FldLength, strDataTypeId0 == enumDataTypeAbbr.char_04 ? true : false, objImportClass, strBaseUrl);
            strCodeForCs.Append("\r\n" + strTemp0);


            var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objASPDropDownListEx.TabFeatureId4Ddl,
                objASPDropDownListEx.PrjId);
            var strEx = "";
            if (objTabFeature.IsExtendedClass == true)
            {
                strEx = "Ex";
            }
            var strFuncNameJs = objTabFeature.FuncNameJs;
            if (strFuncNameJs.IndexOf("InDiv") == -1)
            {
                strFuncNameJs = strFuncNameJs.Replace("Cache", "InDivCache");
                strFuncNameJs = strFuncNameJs.Replace("BindDdlInDivCache", "BindDdlCache");

            }
            var objPrjTab_TabFeature = clsPrjTabBL.GetObjByTabIdCache(objTabFeature.TabId, objTabFeature.PrjId);
            if (objPrjTab_TabFeature.IsUseCache_TS2() == true)
            {
                if (strFuncNameJs.IndexOf("Cache", 10) == -1)
                {
                    strFuncNameJs = strFuncNameJs + "Cache";
                }
            }
            strCodeForCs.Append("\r\n" + $"await {objASPDropDownListEx.DsTabName4GC}{strEx}_{strFuncNameJs}({strRegionType}, \"{objASPDropDownListEx.CtrlId}\" {strCondFldLst});//{""}");
            objImportClass.AddImportClass(objASPDropDownListEx.DsTabId, objASPDropDownListEx.DsTabName4GC + strEx, strFuncNameJs,
                objTabFeature.IsExtendedClass == true ? enumImportObjType.WApiExtendClassFunc : enumImportObjType.WApiClassFunc, strBaseUrl);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


    }
}
