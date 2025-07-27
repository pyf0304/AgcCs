
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPTextBoxBLEx
表名:ASPNETTextBox(00050224)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:37
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
using AgcCommBase;
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET文本框(ASPNETTextBox)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPTextBoxBLEx_Static
    {
        public static string GC_SetDefaultValue(this ASPTextBoxEx objASPTextBoxEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            switch (objASPTextBoxEx.CsType)
            {
                case "int":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objASPTextBoxEx.CtrlId);
                    break;
                case "double":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                        objASPTextBoxEx.CtrlId);
                    break;
                case "DateTime":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                        objASPTextBoxEx.CtrlId);
                    break;
                case "bool":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                        objASPTextBoxEx.CtrlId);
                    break;
                case "float":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                        objASPTextBoxEx.CtrlId);
                    break;
                case "long":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                        objASPTextBoxEx.CtrlId);
                    break;
                default:
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                        objASPTextBoxEx.CtrlId);
                    break;
            }


            return strCodeForCs.ToString();
        }


        public static string GC_DefFldProperty(this ASPTextBoxEx objASPTextBoxEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objASPTextBoxEx.Caption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objASPTextBoxEx.CsType,
                objASPTextBoxEx.FldName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            switch (objASPTextBoxEx.CsType)
            {
                case "int":
                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;

                case "short":
                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;

                case "double":

                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;
                case "DateTime":

                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;
                case "bool":
                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;
                case "float":
                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;
                case "long":
                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objASPTextBoxEx.CtrlId);
                    break;
                default:
                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objASPTextBoxEx.CtrlId);
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "set");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objASPTextBoxEx.CtrlId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPTextBoxENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPTextBoxEx objASPTextBoxENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                case enumApplicationType.WebApi_19:
                    if (string.IsNullOrEmpty(objASPTextBoxENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPTextBoxENEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPTextBoxENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    //        objASPTextBoxENEx.OnClick);
                    //}
                    clsASPControlBLEx.GC4Text(objASPTextBoxENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPTextBoxENEx.inputType) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:inputType=\"{0}\"",
                            objASPTextBoxENEx.inputType);
                    }
                    if (objASPTextBoxENEx.ems > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
                            objASPTextBoxENEx.ems);
                    }
                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPTextBoxENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPTextBoxENEx.TextMode) == false)
                    {
                        strCodeForCs.AppendFormat(" TextMode=\"{0}\" ", objASPTextBoxENEx.TextMode);
                    }
                    strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("/>");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    //if (objASPTextBoxENEx.Is4PureHtml == true)
                    //{
                    //    objASPTextBoxENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
                    //    return;
                    //}
                    //break;
                case enumApplicationType.SpaAppInCore_TS_18:

                    if (string.IsNullOrEmpty(objASPTextBoxENEx.TextMode) == false && objASPTextBoxENEx.TextMode == "MultiLine")
                    {
                        //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4IdName(objASPTextBoxENEx, strCodeForCs);

                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.Class);
                        }
                        if (objASPTextBoxENEx.Width > 0)
                        {
                            objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                            objASPTextBoxENEx.Width = 0;
                        }
                        //if (objASPTextBoxENEx.Height > 0)
                        //{
                        //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                        //    objASPTextBoxENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextBoxENEx.Style);
                        }
                        strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextBoxENEx.OnClick4MvcAjax);
                        }
                        strCodeForCs.AppendFormat(">");

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextBoxENEx.Value);
                        }

                        strCodeForCs.AppendFormat("</textarea>");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<input ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4IdName(objASPTextBoxENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.type) == false)
                        {
                            strCodeForCs.AppendFormat(" type=\"{0}\"",
                                objASPTextBoxENEx.type);
                        }
                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.Class);
                        }
                        if (objASPTextBoxENEx.Width > 0)
                        {
                            objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                            objASPTextBoxENEx.Width = 0;
                        }
                        //if (objASPTextBoxENEx.Height > 0)
                        //{
                        //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                        //    objASPTextBoxENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextBoxENEx.Style);
                        }

                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextBoxENEx.OnClick4MvcAjax);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextBoxENEx.Value);
                        }

                        strCodeForCs.AppendFormat("/>");

                    }
                    break;
                case enumApplicationType.VueAppInCore_TS_30:
    
                    if (string.IsNullOrEmpty(objASPTextBoxENEx.TextMode) == false && objASPTextBoxENEx.TextMode == "MultiLine")
                    {
                        //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4Id(objASPTextBoxENEx, strCodeForCs);
                        if (objASPTextBoxENEx.TypeScriptType == "number")
                        {
                            strCodeForCs.AppendFormat(" v-model.number=\"{0}\"",
                           clsString.FstLcaseS(objASPTextBoxENEx.DataProperty));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat(" v-model=\"{0}\"",
                              clsString.FstLcaseS(objASPTextBoxENEx.DataProperty));
                        }

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.ClickEvent) == false)
                        {
                            strCodeForCs.AppendFormat(" @click=\"{0}($event)\"",
                                objASPTextBoxENEx.ClickEvent);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.ChangeEvent) == false)
                        {
                            strCodeForCs.AppendFormat(" @change=\"{0}($event)\"",
                                objASPTextBoxENEx.ChangeEvent);
                        }

                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.Class);
                        }
                        if (objASPTextBoxENEx.Width > 0)
                        {
                            objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                            objASPTextBoxENEx.Width = 0;
                        }
                        //if (objASPTextBoxENEx.Height > 0)
                        //{
                        //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                        //    objASPTextBoxENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextBoxENEx.Style);
                        }
                        strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextBoxENEx.OnClick4MvcAjax);
                        }
                        strCodeForCs.AppendFormat(">");

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextBoxENEx.Value);
                        }

                        strCodeForCs.AppendFormat("</textarea>");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<input ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4Id(objASPTextBoxENEx, strCodeForCs);
                        if (objASPTextBoxENEx.TypeScriptType == "number")
                        {
                            strCodeForCs.AppendFormat(" v-model.number=\"{0}\"",
                           clsString.FstLcaseS(objASPTextBoxENEx.DataProperty));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat(" v-model=\"{0}\"",
                          clsString.FstLcaseS(objASPTextBoxENEx.DataProperty));
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.type) == false)
                        {
                            strCodeForCs.AppendFormat(" type=\"{0}\"",
                                objASPTextBoxENEx.type);
                        }
                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextBoxENEx.Class);
                        }
                        if (objASPTextBoxENEx.Width > 0)
                        {
                            objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                            objASPTextBoxENEx.Width = 0;
                        }
                        //if (objASPTextBoxENEx.Height > 0)
                        //{
                        //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                        //    objASPTextBoxENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextBoxENEx.Style);
                        }

                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextBoxENEx.OnClick4MvcAjax);
                        }
                        //if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                        //{
                        //    strCodeForCs.AppendFormat(" value=\"{0}\"",
                        //           objASPTextBoxENEx.Value);
                        //}
                  
                        strCodeForCs.AppendFormat("/>");

                    }
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
          

        }
        public static void GeneCode4Html(this ASPTextBoxEx objASPTextBoxENEx, enumApplicationType intApplicationTypeId,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            if (string.IsNullOrEmpty(objASPTextBoxENEx.TextMode) == false && objASPTextBoxENEx.TextMode == "MultiLine")
            {
                 //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                     strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                //生成控件的Id、Name
                clsASPControlBLEx.GC4IdName(objASPTextBoxENEx, strCodeForCs);
             
                //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                //生成控件的Tag
                clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                //生成控件的样式
                //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextBoxENEx.CssClass);
                }
                if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextBoxENEx.Class);
                }
                if (objASPTextBoxENEx.Width > 0)
                {
                    objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                    objASPTextBoxENEx.Width = 0;
                }
                //if (objASPTextBoxENEx.Height > 0)
                //{
                //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                //    objASPTextBoxENEx.Height = 0;
                //}
                if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                {
                    strCodeForCs.AppendFormat(" style=\"{0}\"",
                        objASPTextBoxENEx.Style);
                }
                strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                {
                    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                        objASPTextBoxENEx.OnClick4MvcAjax);
                }
                strCodeForCs.AppendFormat(">");

                if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                {
                    strCodeForCs.AppendFormat(" value=\"{0}\"",
                           objASPTextBoxENEx.Value);
                }

                strCodeForCs.AppendFormat("</textarea>");

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "<input ");

                //生成控件的Id、Name
                clsASPControlBLEx.GC4IdName(objASPTextBoxENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextBoxENEx.type) == false)
                {
                    strCodeForCs.AppendFormat(" type=\"{0}\"",
                        objASPTextBoxENEx.type);
                }
                //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                //生成控件的Tag
                clsASPControlBLEx.GC4Tag(objASPTextBoxENEx, strCodeForCs);

                //生成控件的样式
                //clsASPControlBLEx.GC4Style(objASPTextBoxENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextBoxENEx.CssClass);
                }
                if (string.IsNullOrEmpty(objASPTextBoxENEx.Class) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextBoxENEx.Class);
                }
                if (objASPTextBoxENEx.Width > 0)
                {
                    objASPTextBoxENEx.Style += string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                    objASPTextBoxENEx.Width = 0;
                }
                //if (objASPTextBoxENEx.Height > 0)
                //{
                //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
                //    objASPTextBoxENEx.Height = 0;
                //}
                if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
                {
                    strCodeForCs.AppendFormat(" style=\"{0}\"",
                        objASPTextBoxENEx.Style);
                }

                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPTextBoxENEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                clsASPControlBLEx.GC4Margin(objASPTextBoxENEx, strCodeForCs);

                if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4MvcAjax) == false)
                {
                    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                        objASPTextBoxENEx.OnClick4MvcAjax);
                }
                if (string.IsNullOrEmpty(objASPTextBoxENEx.Value) == false)
                {
                    strCodeForCs.AppendFormat(" value=\"{0}\"",
                           objASPTextBoxENEx.Value);
                }

                strCodeForCs.AppendFormat("/>");

            }
        }

        public static void GeneCode4Mvc(this ASPTextBoxEx objASPTextBoxENEx, enumApplicationType intApplicationTypeId,
       StringBuilder strCodeForCs)
        {
            //if (objASPTextBoxENEx.Is4PureHtml == true)
            //{
            //    objASPTextBoxENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
            //    return;
            //}
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPTextBoxENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPTextBoxENEx.mKey);
            }
            string strFldName = objASPTextBoxENEx.FldName;
            if (string.IsNullOrEmpty(objASPTextBoxENEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPTextBoxENEx.ItemName4MultiModel, objASPTextBoxENEx.FldName);
            }

            string strClass = string.IsNullOrEmpty(objASPTextBoxENEx.Class) ? objASPTextBoxENEx.CssClass : objASPTextBoxENEx.Class;

            strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ Name=\"{3}\" }} }})",
               objASPTextBoxENEx.TabName, strFldName, strClass, objASPTextBoxENEx.FldName);

     //       strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ @class = \"{2}\", Name=\"{3}\" }} }})",
     //objASPTextBoxENEx.TabName, strFldName, strClass, objASPTextBoxENEx.FldName);

        }
        public static void GeneHtmlControl(this ASPTextBoxEx objASPTextBoxENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPTextBoxENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPTextBoxENEx.mKey);
            }
            if (objASPTextBoxENEx.Parent != null
                && objASPTextBoxENEx.Parent.Parent != null)
            {
                switch (objASPTextBoxENEx.Parent.Parent.RowType)
                {
                    case "headrow":

                        HtmlGenericControl objSpan = new HtmlGenericControl("span");
                        objSpan.Attributes["class"] = objASPTextBoxENEx.Class;
                        objSpan.ID = objASPTextBoxENEx.CtrlId;
                        objSpan.InnerHtml = objASPTextBoxENEx.Caption;
                        if (string.IsNullOrEmpty(objASPTextBoxENEx.OnClick4Html) == false)
                        {
                            objSpan.Attributes.Add("onclick", objASPTextBoxENEx.OnClick4Html);
                        }
                        objContainer.Controls.Add(objSpan);
                        return;
                    case "datarow":
                        if (objASPTextBoxENEx.Parent.Parent.objDataRow == null)
                        {
                            throw new Exception("表行没有设置相应的DataRow.");
                        }
                        DataRow objDR = objASPTextBoxENEx.Parent.Parent.objDataRow;
                        HtmlGenericControl objSpan_Data = new HtmlGenericControl("span");
                        objSpan_Data.Attributes["class"] = objASPTextBoxENEx.Class;
                        objSpan_Data.ID = objASPTextBoxENEx.CtrlId;
                        objSpan_Data.InnerHtml = objDR[objASPTextBoxENEx.FldName].ToString();

                        objContainer.Controls.Add(objSpan_Data);
                        return;
                }
            }
            HtmlInputText objHtmlInputText = new HtmlInputText();
            objHtmlInputText.Attributes["class"] = "form-control form-control-sm";
            objHtmlInputText.Size = 10;
            objHtmlInputText.ID = objASPTextBoxENEx.CtrlId;
            objHtmlInputText.Name = objASPTextBoxENEx.CtrlName;
            objHtmlInputText.Value = objASPTextBoxENEx.Text;
            if (objASPTextBoxENEx.Width > 0)
            {
                objHtmlInputText.Style.Add("width", string.Format("{0}px", objASPTextBoxENEx.Width));
            }
            if (string.IsNullOrEmpty( objASPTextBoxENEx.OnClick4Html)  == false)
            {
                objHtmlInputText.Attributes.Add("onclick", objASPTextBoxENEx.OnClick4Html);
            }
            if (string.IsNullOrEmpty(objASPTextBoxENEx.placeholder) == false)
            {
                objHtmlInputText.Attributes.Add("placeholder", objASPTextBoxENEx.placeholder);
            }
            //if (objASPTextBoxENEx.Height > 0)
            //{
            //    objASPTextBoxENEx.Style += string.Format("height:{0}px;", objASPTextBoxENEx.Height);
            //    objASPTextBoxENEx.Height = 0;
            //}
            if (string.IsNullOrEmpty(objASPTextBoxENEx.Style) == false)
            {

            }


            objContainer.Controls.Add(objHtmlInputText);

        }

    }
    /// <summary>
    /// ASPNET文本框(ASPNETTextBox)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPTextBoxBLEx 
    {


        public static void GeneCodeBak(ASPTextBoxEx objASPTextBoxENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:TextBox ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:TextBox>
            strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objASPTextBoxENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPTextBoxENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPTextBoxENEx.CssClass);
            }
            if (objASPTextBoxENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPTextBoxENEx.Width);
            }
            if (objASPTextBoxENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPTextBoxENEx.Height);
            }
            strCodeForCs.AppendFormat(">{0}", objASPTextBoxENEx.Text);

            foreach (ASPControlEx objSubASPControlENEx in objASPTextBoxENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:TextBox>");

        }



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private TextBox {0};",
                objASPTextBoxENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (TextBox)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextBox)findViewById(R.id.{0}); ",
                objASPTextBoxENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (TextBox)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextBox)view.findViewById(R.id.{0}); ",
                objASPTextBoxENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                  string.Format("{0}.getText().toString()", objASPTextBoxENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                  string.Format("{0}.getText().toString()", objASPTextBoxENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPTextBoxENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPTextBoxEx objASPTextBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPTextBoxENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPTextBoxEx objASPTextBoxENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPTextBoxENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText({1});",
               objASPTextBoxENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName,
               AgcPubFun.getToStringCode4DataType4Java(
                   objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                   string.Format("obj{0}EN.get{1}()",
                   objViewInfoENEx.ObjOutRelaTab().TabName,
                   objASPTextBoxENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName)));
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPTextBoxENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPTextBoxEx objASPTextBoxENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText(\"\");",
               objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("// {0}", objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeName,
            objASPTextBoxENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldLength,
            objASPTextBoxENEx.objEditRegionFldsEN.IsTabNullable(strCmPrjId),
            objASPTextBoxENEx.objEditRegionFldsEN.MemoInTab(strCmPrjId));
        }
    }
}
