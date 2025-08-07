
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPTextAreaBLEx
表名:ASPNETTextArea(00050224)
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
    /// ASPNET文本框(ASPNETTextArea)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPTextAreaBLEx_Static
    {
        public static string GC_SetDefaultValue(this ASPTextAreaEx objASPTextAreaEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            switch (objASPTextAreaEx.CsType)
            {
                case "int":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objASPTextAreaEx.CtrlId);
                    break;
                case "double":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                        objASPTextAreaEx.CtrlId);
                    break;
                case "DateTime":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                        objASPTextAreaEx.CtrlId);
                    break;
                case "bool":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                        objASPTextAreaEx.CtrlId);
                    break;
                case "float":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                        objASPTextAreaEx.CtrlId);
                    break;
                case "long":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                        objASPTextAreaEx.CtrlId);
                    break;
                default:
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                        objASPTextAreaEx.CtrlId);
                    break;
            }


            return strCodeForCs.ToString();
        }


        public static string GC_DefFldProperty(this ASPTextAreaEx objASPTextAreaEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objASPTextAreaEx.Caption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objASPTextAreaEx.CsType,
                objASPTextAreaEx.FldName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            switch (objASPTextAreaEx.CsType)
            {
                case "int":
                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;

                case "short":
                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;

                case "double":

                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;
                case "DateTime":

                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;
                case "bool":
                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;
                case "float":
                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;
                case "long":
                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objASPTextAreaEx.CtrlId);
                    break;
                default:
                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objASPTextAreaEx.CtrlId);
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "set");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objASPTextAreaEx.CtrlId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPTextAreaENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPTextAreaEx objASPTextAreaENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                case enumApplicationType.WebApi_19:
                    if (string.IsNullOrEmpty(objASPTextAreaENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPTextAreaENEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<asp:TextArea");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    //        objASPTextAreaENEx.OnClick);
                    //}
                    clsASPControlBLEx.GC4Text(objASPTextAreaENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPTextAreaENEx.inputType) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:inputType=\"{0}\"",
                            objASPTextAreaENEx.inputType);
                    }
                    if (objASPTextAreaENEx.ems > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
                            objASPTextAreaENEx.ems);
                    }
                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPTextAreaENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPTextAreaENEx.TextMode) == false)
                    {
                        strCodeForCs.AppendFormat(" TextMode=\"{0}\" ", objASPTextAreaENEx.TextMode);
                    }
                    strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("/>");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    //if (objASPTextAreaENEx.Is4PureHtml == true)
                    //{
                    //    objASPTextAreaENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
                    //    return;
                    //}
                    //break;
                case enumApplicationType.SpaAppInCore_TS_18:

                    if (string.IsNullOrEmpty(objASPTextAreaENEx.TextMode) == false && objASPTextAreaENEx.TextMode == "MultiLine")
                    {
                        //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);

                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.Class);
                        }
                        if (objASPTextAreaENEx.Rows > 0)
                        {
                            strCodeForCs.AppendFormat(" rows=\"{0}\"",
                               objASPTextAreaENEx.Rows);
                        }

                        if (objASPTextAreaENEx.Cols > 0)
                        {
                            strCodeForCs.AppendFormat(" cols=\"{0}\"",
                               objASPTextAreaENEx.Cols);
                        }

                        if (objASPTextAreaENEx.Width > 0)
                        {
                            objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                            objASPTextAreaENEx.Width = 0;
                        }
                        //if (objASPTextAreaENEx.Height > 0)
                        //{
                        //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                        //    objASPTextAreaENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextAreaENEx.Style);
                        }
                        strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextAreaENEx.OnClick4MvcAjax);
                        }
                        strCodeForCs.AppendFormat(">");

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextAreaENEx.Value);
                        }

                        strCodeForCs.AppendFormat("</textarea>");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4Id(objASPTextAreaENEx, strCodeForCs);
                        if (objASPTextAreaENEx.TypeScriptType == "number")
                        {
                            strCodeForCs.AppendFormat(" v-model.number=\"{0}\"", clsString.FstLcaseS(objASPTextAreaENEx.DataProperty));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat(" v-model=\"{0}\"", clsString.FstLcaseS(objASPTextAreaENEx.DataProperty));
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.type) == false)
                        {
                            strCodeForCs.AppendFormat(" type=\"{0}\"",
                                objASPTextAreaENEx.type);
                        }
                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.Class);
                        }
                        if (objASPTextAreaENEx.Rows > 0)
                        {
                            strCodeForCs.AppendFormat(" rows=\"{0}\"",
                               objASPTextAreaENEx.Rows);
                        }

                        if (objASPTextAreaENEx.Cols > 0)
                        {
                            strCodeForCs.AppendFormat(" cols=\"{0}\"",
                               objASPTextAreaENEx.Cols);
                        }
                        if (objASPTextAreaENEx.Width > 0)
                        {
                            objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                            objASPTextAreaENEx.Width = 0;
                        }
                        //if (objASPTextAreaENEx.Height > 0)
                        //{
                        //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                        //    objASPTextAreaENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextAreaENEx.Style);
                        }

                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextAreaENEx.OnClick4MvcAjax);
                        }
                        //if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                        //{
                        //    strCodeForCs.AppendFormat(" value=\"{0}\"",
                        //           objASPTextAreaENEx.Value);
                        //}
                    
                        strCodeForCs.AppendFormat("/>");

                    }
                    break;
                case enumApplicationType.VueAppInCore_TS_30:
    
                    if (string.IsNullOrEmpty(objASPTextAreaENEx.TextMode) == false && objASPTextAreaENEx.TextMode == "MultiLine")
                    {
                        //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);

                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.Class);
                        }

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.ClickEvent) == false)
                        {
                            strCodeForCs.AppendFormat(" @click=\"{0}($event)\"",
                                objASPTextAreaENEx.ClickEvent);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.ChangeEvent) == false)
                        {
                            strCodeForCs.AppendFormat(" @change=\"{0}($event)\"",
                                objASPTextAreaENEx.ChangeEvent);
                        }

                        if (objASPTextAreaENEx.Rows > 0)
                        {
                            strCodeForCs.AppendFormat(" rows=\"{0}\"",
                               objASPTextAreaENEx.Rows);
                        }

                        if (objASPTextAreaENEx.Cols > 0)
                        {
                            strCodeForCs.AppendFormat(" cols=\"{0}\"",
                               objASPTextAreaENEx.Cols);
                        }

                        if (objASPTextAreaENEx.Width > 0)
                        {
                            objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                            objASPTextAreaENEx.Width = 0;
                        }
                        //if (objASPTextAreaENEx.Height > 0)
                        //{
                        //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                        //    objASPTextAreaENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextAreaENEx.Style);
                        }
                        strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextAreaENEx.OnClick4MvcAjax);
                        }
                        strCodeForCs.AppendFormat(">");

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextAreaENEx.Value);
                        }

                        strCodeForCs.AppendFormat("</textarea>");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                        //生成控件的Id、Name
                        clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.type) == false)
                        {
                            strCodeForCs.AppendFormat(" type=\"{0}\"",
                                objASPTextAreaENEx.type);
                        }
                        //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                        //生成控件的Tag
                        clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                        //生成控件的样式
                        //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.CssClass);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                        {
                            strCodeForCs.AppendFormat(" class=\"{0}\"",
                                objASPTextAreaENEx.Class);
                        }
                        if (objASPTextAreaENEx.Rows > 0)
                        {
                            strCodeForCs.AppendFormat(" rows=\"{0}\"",
                               objASPTextAreaENEx.Rows);
                        }

                        if (objASPTextAreaENEx.Cols > 0)
                        {
                            strCodeForCs.AppendFormat(" cols=\"{0}\"",
                               objASPTextAreaENEx.Cols);
                        }
                        if (objASPTextAreaENEx.Width > 0)
                        {
                            objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                            objASPTextAreaENEx.Width = 0;
                        }
                        //if (objASPTextAreaENEx.Height > 0)
                        //{
                        //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                        //    objASPTextAreaENEx.Height = 0;
                        //}
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                        {
                            strCodeForCs.AppendFormat(" style=\"{0}\"",
                                objASPTextAreaENEx.Style);
                        }

                        //生成控件的尺寸-高、宽
                        //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                        //生成控件的边界尺寸-即与四周的距离
                        clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                        if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                        {
                            strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                                objASPTextAreaENEx.OnClick4MvcAjax);
                        }
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                        {
                            strCodeForCs.AppendFormat(" value=\"{0}\"",
                                   objASPTextAreaENEx.Value);
                        }

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
        public static void GeneCode4Html(this ASPTextAreaEx objASPTextAreaENEx, enumApplicationType intApplicationTypeId,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            if (string.IsNullOrEmpty(objASPTextAreaENEx.TextMode) == false && objASPTextAreaENEx.TextMode == "MultiLine")
            {
                 //< textarea id = "TextArea1" cols = "20" rows = "2" ></ textarea >
                     strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                //生成控件的Id、Name
                clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);
             
                //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                //生成控件的Tag
                clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                //生成控件的样式
                //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextAreaENEx.CssClass);
                }
                if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextAreaENEx.Class);
                }
                if (objASPTextAreaENEx.Rows > 0)
                {
                    strCodeForCs.AppendFormat(" rows=\"{0}\"",
                       objASPTextAreaENEx.Rows);
                }

                if (objASPTextAreaENEx.Cols > 0)
                {
                    strCodeForCs.AppendFormat(" cols=\"{0}\"",
                       objASPTextAreaENEx.Cols);
                }
                if (objASPTextAreaENEx.Width > 0)
                {
                    objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                    objASPTextAreaENEx.Width = 0;
                }
                //if (objASPTextAreaENEx.Height > 0)
                //{
                //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                //    objASPTextAreaENEx.Height = 0;
                //}
                if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                {
                    strCodeForCs.AppendFormat(" style=\"{0}\"",
                        objASPTextAreaENEx.Style);
                }
                strCodeForCs.AppendFormat(" cols = \"20\" rows = \"2\"");
                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                {
                    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                        objASPTextAreaENEx.OnClick4MvcAjax);
                }
                strCodeForCs.AppendFormat(">");

                if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                {
                    strCodeForCs.AppendFormat(" value=\"{0}\"",
                           objASPTextAreaENEx.Value);
                }

                strCodeForCs.AppendFormat("</textarea>");

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "<textarea ");

                //生成控件的Id、Name
                clsASPControlBLEx.GC4IdName(objASPTextAreaENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextAreaENEx.type) == false)
                {
                    strCodeForCs.AppendFormat(" type=\"{0}\"",
                        objASPTextAreaENEx.type);
                }
                //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

                //生成控件的Tag
                clsASPControlBLEx.GC4Tag(objASPTextAreaENEx, strCodeForCs);

                //生成控件的样式
                //clsASPControlBLEx.GC4Style(objASPTextAreaENEx, strCodeForCs);
                if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextAreaENEx.CssClass);
                }
                if (string.IsNullOrEmpty(objASPTextAreaENEx.Class) == false)
                {
                    strCodeForCs.AppendFormat(" class=\"{0}\"",
                        objASPTextAreaENEx.Class);
                }
                if (objASPTextAreaENEx.Rows > 0)
                {
                    strCodeForCs.AppendFormat(" rows=\"{0}\"",
                       objASPTextAreaENEx.Rows);
                }

                if (objASPTextAreaENEx.Cols > 0)
                {
                    strCodeForCs.AppendFormat(" cols=\"{0}\"",
                       objASPTextAreaENEx.Cols);
                }
                if (objASPTextAreaENEx.Width > 0)
                {
                    objASPTextAreaENEx.Style += string.Format("width:{0}px;", objASPTextAreaENEx.Width);
                    objASPTextAreaENEx.Width = 0;
                }
                //if (objASPTextAreaENEx.Height > 0)
                //{
                //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
                //    objASPTextAreaENEx.Height = 0;
                //}
                if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
                {
                    strCodeForCs.AppendFormat(" style=\"{0}\"",
                        objASPTextAreaENEx.Style);
                }

                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPTextAreaENEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                clsASPControlBLEx.GC4Margin(objASPTextAreaENEx, strCodeForCs);

                if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4MvcAjax) == false)
                {
                    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                        objASPTextAreaENEx.OnClick4MvcAjax);
                }
                if (string.IsNullOrEmpty(objASPTextAreaENEx.Value) == false)
                {
                    strCodeForCs.AppendFormat(" value=\"{0}\"",
                           objASPTextAreaENEx.Value);
                }

                strCodeForCs.AppendFormat("/>");

            }
        }

        public static void GeneCode4Mvc(this ASPTextAreaEx objASPTextAreaENEx, enumApplicationType intApplicationTypeId,
       StringBuilder strCodeForCs)
        {
            //if (objASPTextAreaENEx.Is4PureHtml == true)
            //{
            //    objASPTextAreaENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
            //    return;
            //}
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPTextAreaENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPTextAreaENEx.mKey);
            }
            string strFldName = objASPTextAreaENEx.FldName;
            if (string.IsNullOrEmpty(objASPTextAreaENEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPTextAreaENEx.ItemName4MultiModel, objASPTextAreaENEx.FldName);
            }

            string strClass = string.IsNullOrEmpty(objASPTextAreaENEx.Class) ? objASPTextAreaENEx.CssClass : objASPTextAreaENEx.Class;

            strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ Name=\"{3}\" }} }})",
               objASPTextAreaENEx.TabName, strFldName, strClass, objASPTextAreaENEx.FldName);

     //       strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ @class = \"{2}\", Name=\"{3}\" }} }})",
     //objASPTextAreaENEx.TabName, strFldName, strClass, objASPTextAreaENEx.FldName);

        }
        public static void GeneHtmlControl(this ASPTextAreaEx objASPTextAreaENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPTextAreaENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPTextAreaENEx.mKey);
            }
            if (objASPTextAreaENEx.Parent != null
                && objASPTextAreaENEx.Parent.Parent != null)
            {
                switch (objASPTextAreaENEx.Parent.Parent.RowType)
                {
                    case "headrow":

                        HtmlGenericControl objSpan = new HtmlGenericControl("span");
                        objSpan.Attributes["class"] = objASPTextAreaENEx.Class;
                        objSpan.ID = objASPTextAreaENEx.CtrlId;
                        objSpan.InnerHtml = objASPTextAreaENEx.Caption;
                        if (string.IsNullOrEmpty(objASPTextAreaENEx.OnClick4Html) == false)
                        {
                            objSpan.Attributes.Add("onclick", objASPTextAreaENEx.OnClick4Html);
                        }
                        objContainer.Controls.Add(objSpan);
                        return;
                    case "datarow":
                        if (objASPTextAreaENEx.Parent.Parent.objDataRow == null)
                        {
                            throw new Exception("表行没有设置相应的DataRow.");
                        }
                        DataRow objDR = objASPTextAreaENEx.Parent.Parent.objDataRow;
                        HtmlGenericControl objSpan_Data = new HtmlGenericControl("span");
                        objSpan_Data.Attributes["class"] = objASPTextAreaENEx.Class;
                        objSpan_Data.ID = objASPTextAreaENEx.CtrlId;
                        objSpan_Data.InnerHtml = objDR[objASPTextAreaENEx.FldName].ToString();

                        objContainer.Controls.Add(objSpan_Data);
                        return;
                }
            }
            HtmlTextArea objHtmlTextArea = new HtmlTextArea();
            objHtmlTextArea.Attributes["class"] = "form-control form-control-sm";
            
            objHtmlTextArea.ID = objASPTextAreaENEx.CtrlId;
            objHtmlTextArea.Name = objASPTextAreaENEx.CtrlName;
            objHtmlTextArea.Value = objASPTextAreaENEx.Text;
            if (objASPTextAreaENEx.Rows > 0)
            {
                objHtmlTextArea.Rows =                   objASPTextAreaENEx.Rows;
            }

            if (objASPTextAreaENEx.Cols > 0)
            {
                objHtmlTextArea.Cols = objASPTextAreaENEx.Cols;
            }
            if (objASPTextAreaENEx.Width > 0)
            {
                objHtmlTextArea.Style.Add("width", string.Format("{0}px", objASPTextAreaENEx.Width));
            }
            if (string.IsNullOrEmpty( objASPTextAreaENEx.OnClick4Html)  == false)
            {
                objHtmlTextArea.Attributes.Add("onclick", objASPTextAreaENEx.OnClick4Html);
            }
            if (string.IsNullOrEmpty(objASPTextAreaENEx.placeholder) == false)
            {
                objHtmlTextArea.Attributes.Add("placeholder", objASPTextAreaENEx.placeholder);
            }
            //if (objASPTextAreaENEx.Height > 0)
            //{
            //    objASPTextAreaENEx.Style += string.Format("height:{0}px;", objASPTextAreaENEx.Height);
            //    objASPTextAreaENEx.Height = 0;
            //}
            if (string.IsNullOrEmpty(objASPTextAreaENEx.Style) == false)
            {

            }


            objContainer.Controls.Add(objHtmlTextArea);

        }

    }
    /// <summary>
    /// ASPNET文本框(ASPNETTextArea)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPTextAreaBLEx 
    {


        public static void GeneCodeBak(ASPTextAreaEx objASPTextAreaENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:TextArea ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:TextArea>
            strCodeForCs.AppendFormat("\r\n" + "<asp:TextArea ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objASPTextAreaENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPTextAreaENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPTextAreaENEx.CssClass);
            }
            if (objASPTextAreaENEx.Rows > 0)
            {
                strCodeForCs.AppendFormat(" rows=\"{0}\"",
                   objASPTextAreaENEx.Rows);
            }

            if (objASPTextAreaENEx.Cols > 0)
            {
                strCodeForCs.AppendFormat(" cols=\"{0}\"",
                   objASPTextAreaENEx.Cols);
            }
            if (objASPTextAreaENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPTextAreaENEx.Width);
            }
            if (objASPTextAreaENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPTextAreaENEx.Height);
            }
            strCodeForCs.AppendFormat(">{0}", objASPTextAreaENEx.Text);

            foreach (ASPControlEx objSubASPControlENEx in objASPTextAreaENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:TextArea>");

        }



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private TextArea {0};",
                objASPTextAreaENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (TextArea)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextArea)findViewById(R.id.{0}); ",
                objASPTextAreaENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (TextArea)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextArea)view.findViewById(R.id.{0}); ",
                objASPTextAreaENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                  string.Format("{0}.getText().toString()", objASPTextAreaENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                  string.Format("{0}.getText().toString()", objASPTextAreaENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPTextAreaENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPTextAreaEx objASPTextAreaENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPTextAreaENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPTextAreaEx objASPTextAreaENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPTextAreaENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText({1});",
               objASPTextAreaENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName,
               AgcPubFun.getToStringCode4DataType4Java(
                   objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                   string.Format("obj{0}EN.get{1}()",
                   objViewInfoENEx.ObjOutRelaTab().TabName,
                   objASPTextAreaENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName)));
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPTextAreaENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPTextAreaEx objASPTextAreaENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText(\"\");",
               objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("// {0}", objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeName,
            objASPTextAreaENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldLength,
            objASPTextAreaENEx.objEditRegionFldsEN.IsTabNullable(strCmPrjId),
            objASPTextAreaENEx.objEditRegionFldsEN.MemoInTab(strCmPrjId));
        }
    }
}
