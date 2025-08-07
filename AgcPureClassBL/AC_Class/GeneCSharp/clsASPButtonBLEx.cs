
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPButtonBLEx
表名:ASPNETButton(00050223)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:23
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
using System.Web.UI.WebControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsASPButtonBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPButtonEx objASPButtonENEx, enumApplicationType intApplicationTypeId, 
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                case enumApplicationType.WebApi_19:
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Button");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4Id(objASPButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPButtonENEx.OnClick) == false)
                    {
                        strCodeForCs.AppendFormat(" OnClick=\"{0}\"",
                            objASPButtonENEx.OnClick);
                    }

                    //生成控件的样式
                    clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
                    strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("/>");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    strCodeForCs.AppendFormat("\r\n" + "<input ");

                    //生成控件的Value
                    clsASPControlBLEx.GC4Value(objASPButtonENEx, strCodeForCs);

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPButtonENEx, strCodeForCs);

                    //生成控件的Type
                    clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPButtonENEx.OnClick) == false)
                    {
                        strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                            objASPButtonENEx.OnClick);
                    }

                    //生成控件的样式
                    clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");

                    strCodeForCs.AppendFormat("/>");
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                    
                    strCodeForCs.AppendFormat("\r\n" + "<button ");
                    
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Data_dismiss(objASPButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Aria_label(objASPButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPButtonENEx.CssClass) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPButtonENEx.CssClass);
                    }
                    else if (string.IsNullOrEmpty(objASPButtonENEx.Class) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPButtonENEx.Class);
                    }
                    if (string.IsNullOrEmpty(objASPButtonENEx.Style) == false)
                    {
                        strCodeForCs.AppendFormat(" style=\"{0}\"",
                            objASPButtonENEx.Style);
                    }
                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPButtonENEx.OnClick4Html) == false)
                    //{
                    //    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    //        objASPButtonENEx.OnClick4Html);
                    //}
                    strCodeForCs.AppendFormat(" onclick=\"btnClick('{0}')\"",
                        objASPButtonENEx.CommandName);

                    clsASPControlBLEx.GC4Tabindex(objASPButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    //clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
                    strCodeForCs.Append(">");
                    if (string.IsNullOrEmpty(objASPButtonENEx.Value) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPButtonENEx.Value);
                    }
                    else if (string.IsNullOrEmpty(objASPButtonENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPButtonENEx.Text);
                    }

                    foreach (ASPControlEx objSubASPControlENEx in objASPButtonENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
                    }

                    strCodeForCs.AppendFormat("</button>");
                    break;
                case enumApplicationType.VueAppInCore_TS_30:
                  
                    strCodeForCs.AppendFormat("\r\n" + "<button ");
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPButtonENEx, strCodeForCs);
                    
                    clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Data_dismiss(objASPButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Aria_label(objASPButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPButtonENEx.CssClass) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPButtonENEx.CssClass);
                    }
                    else if (string.IsNullOrEmpty(objASPButtonENEx.Class) == false)
                    {
                        strCodeForCs.AppendFormat(" class=\"{0}\"",
                            objASPButtonENEx.Class);
                    }
                    if (string.IsNullOrEmpty(objASPButtonENEx.Style) == false)
                    {
                        strCodeForCs.AppendFormat(" style=\"{0}\"",
                            objASPButtonENEx.Style);
                    }
                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPButtonENEx.OnClick4Html) == false)
                    //{
                    //    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    //        objASPButtonENEx.OnClick4Html);
                    //}
                   
                        strCodeForCs.Append($" @click=\"{ objASPButtonENEx.OnClick}\"");
            
                    clsASPControlBLEx.GC4Tabindex(objASPButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    //clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
                    strCodeForCs.Append(">");
                    if (string.IsNullOrEmpty(objASPButtonENEx.Value) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPButtonENEx.Value);
                    }
                    else if (string.IsNullOrEmpty(objASPButtonENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPButtonENEx.Text);
                    }

                    foreach (ASPControlEx objSubASPControlENEx in objASPButtonENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }

                    strCodeForCs.AppendFormat("</button>");
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
            //if (objASPButtonENEx.Is4PureHtml)
            //{
            //    objASPButtonENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
            //    return;
            //}
            //string strActionId = AgcPubFun.getASPNETID();
            


        }
        public static void GeneCode4Html(this ASPButtonEx objASPButtonENEx, enumApplicationType intApplicationTypeId,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<button ");
                       
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Data_dismiss(objASPButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Aria_label(objASPButtonENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPButtonENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPButtonENEx.CssClass);
            }
            else if (string.IsNullOrEmpty(objASPButtonENEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPButtonENEx.Class);
            }
            if (string.IsNullOrEmpty(objASPButtonENEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPButtonENEx.Style);
            }
            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPButtonENEx.OnClick4Html) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPButtonENEx.OnClick4Html);
            }


            clsASPControlBLEx.GC4Tabindex(objASPButtonENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objASPButtonENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPButtonENEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
            strCodeForCs.Append(">");
            if (string.IsNullOrEmpty(objASPButtonENEx.Value) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                       objASPButtonENEx.Value);
            }
            else if (string.IsNullOrEmpty(objASPButtonENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                       objASPButtonENEx.Text);
            }

            foreach (ASPControlEx objSubASPControlENEx in objASPButtonENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }

            strCodeForCs.AppendFormat("</button>");
        }

        public static void GeneCode4Mvc(this ASPButtonEx objASPButtonENEx, enumApplicationType intApplicationTypeId,
     StringBuilder strCodeForCs)
        {
            //if (objASPButtonENEx.Is4PureHtml)
            //{
            //    objASPButtonENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
            //    return;
            //}
            string strActionId = AgcPubFun.getASPNETID();

            //       < input value = "重序" id = "btnReOrder" name = "action:ReOrder" type = "submit" class="btn btn-outline-info" />
            //< input value = "查询" id = "btnQuery" Name = "action:QueryAjax" type = "submit" class="btn btn-outline-warning" onclick="OnClickInFeatureRegion()" />

            strCodeForCs.AppendFormat("\r\n" + "<input ");

            //生成控件的Value
            clsASPControlBLEx.GC4Value(objASPButtonENEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4Id(objASPButtonENEx, strCodeForCs);
            clsASPControlBLEx.GC4Name4MvcAjax(objASPButtonENEx, strCodeForCs);

            //生成控件的Type
            clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPButtonENEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPButtonENEx.Class);
            }
            ////生成控件的样式
            //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPButtonENEx.OnClick4MvcAjax) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPButtonENEx.OnClick4MvcAjax);
            }

            //生成控件的样式
            //       clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");


        }

        public static void GeneHtmlControl(this ASPButtonEx objASPButtonENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            HtmlInputButton objHtmlInputButton = new HtmlInputButton();
            objHtmlInputButton.ID = objASPButtonENEx.CtrlId;

            objHtmlInputButton.Name = objASPButtonENEx.CtrlName;
            objHtmlInputButton.Attributes["class"] = objASPButtonENEx.Class;
            objHtmlInputButton.Value = objASPButtonENEx.Value;
            if (string.IsNullOrEmpty(objASPButtonENEx.OnClick4Html) == false)
            {
                objHtmlInputButton.Attributes.Add("onclick", objASPButtonENEx.OnClick4Html);
            }

            if (objASPButtonENEx.Is4Mvc == true)
            {


                //生成控件的Type
                //clsASPControlBLEx.GC4Type(objASPButtonENEx, strCodeForCs);

                //生成控件的样式
                //objHtmlInputButton.Style = objASPButtonENEx.Style;

                //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);


                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                //clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                //if (string.IsNullOrEmpty(objASPButtonENEx.OnClick) == false)
                //{
                //    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                //        objASPButtonENEx.OnClick);
                //}

                objContainer.Controls.Add(objHtmlInputButton);
                return;
            }
            else
            {
                objHtmlInputButton.Attributes["class"] = objASPButtonENEx.CssClass;

                objHtmlInputButton.Value = objASPButtonENEx.Text;

                ////生成控件的Id、Name
                //clsASPControlBLEx.GC4IdName(objASPButtonENEx, strCodeForCs);

                ////生成控件的Tag
                //clsASPControlBLEx.GC4Tag(objASPButtonENEx, strCodeForCs);

                ////生成控件的样式
                //clsASPControlBLEx.GC4Style(objASPButtonENEx, strCodeForCs);

                ////生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objASPButtonENEx, strCodeForCs);
                ////生成控件的边界尺寸-即与四周的距离
                //clsASPControlBLEx.GC4Margin(objASPButtonENEx, strCodeForCs);

                //if (string.IsNullOrEmpty(objASPButtonENEx.OnClick) == false)
                //{
                //    strCodeForCs.AppendFormat(" OnClick=\"{0}\"",
                //        objASPButtonENEx.OnClick);
                //}

                ////生成控件的样式
                //clsASPControlBLEx.GC4Text(objASPButtonENEx, strCodeForCs);

                ////生成控件的约束-即与四周控件的约束关系
                //clsASPControlBLEx.GC4Constraint(objASPButtonENEx, strCodeForCs);
                //strCodeForCs.AppendFormat(" runat=\"server\" ");

                objContainer.Controls.Add(objHtmlInputButton);
                return;
            }
            //foreach (ASPControlEx objSubASPControlENEx in objASPButtonENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            //}


        }
    }

    /// <summary>
    /// ASPNET按钮(ASPNETButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPButtonBLEx
    {

        public static void GeneCodeBak(ASPButtonEx objASPButtonENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:Button ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:Button>
            strCodeForCs.AppendFormat("\r\n" + "<asp:Button ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objASPButtonENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPButtonENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPButtonENEx.CssClass);
            }
            if (objASPButtonENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPButtonENEx.Width);
            }
            if (objASPButtonENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPButtonENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPButtonENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPButtonENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPButtonENEx.OnClick);
            }
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPButtonENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }
            strCodeForCs.Append("\r\n" + "</asp:Button>");

        }



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPButtonEx objASPButtonENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private Button {0};",
                objASPButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPButtonEx objASPButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)findViewById(R.id.btn{0}); ",
                objASPButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPButtonEx objASPButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)view.findViewById(R.id.btn{0}); ",
                objASPButtonENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPButtonENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPButtonEx objASPButtonENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPButtonENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }


        /// <summary>
        /// 建立修改按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnUpdate4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="修改" id="btnUpdate" name="action:Update" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnUpdate";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:UpdateAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Update";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "修改";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnUpdate4Gv";
                objASPButtonENEx.OnClick = "btnUpdate4Gv_Click";
                objASPButtonENEx.Text = "修改记录";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立详细信息按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnDetail4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnDetail";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:DetailAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Detail";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "详细";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnDetail4Gv";
                objASPButtonENEx.OnClick = "btnDetail4Gv_Click";
                objASPButtonENEx.Text = "详细信息";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立删除按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnDelete4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnDeletes";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:DeletesAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Deletes";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "删除";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnDelete4Gv";
                objASPButtonENEx.OnClick = "btnDelete4Gv_Click";
                objASPButtonENEx.Text = "删除记录";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立删除按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnDeleteBySign(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnDeleteBySign";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:DeleteBySignAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:DeleteBySign";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "标志性删除";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnDeleteBySign";
                objASPButtonENEx.OnClick = "btnDeleteBySign_Click";
                objASPButtonENEx.Text = "标志性删除";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 90;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        public static ASPButtonEx GetbtnUnDeleteBySign(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnUnDeleteBySign";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:UnDeleteBySignAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:UnDeleteBySign";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "恢复删除";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnUnDeleteBySign";
                objASPButtonENEx.OnClick = "btnUnDeleteBySign_Click";
                objASPButtonENEx.Text = "恢复删除";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }


        /// <summary>
        /// 建立添加记录按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnAddNewRec4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnCreate";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:CreateAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Create";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "添加";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnAddNewRec4Gv";
                objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Text = "添加记录";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }
        public static ASPButtonEx GetbtnQuery(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnQuery";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:QueryAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Query";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "查询";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnQuery";
                objASPButtonENEx.OnClick = "btnQuery_Click";
                objASPButtonENEx.Text = "查询";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-warning btn-sm";
                //objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }


        public static ASPButtonEx GetbtnClone(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnClone";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:CloneAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:Clone";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "复制";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnClone";
                objASPButtonENEx.OnClick = "btnClone_Click";
                objASPButtonENEx.Text = "复制";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }


        //<td>
        //                    <asp:Button ID = "btnGoTop" runat="server" Height="24px" Style="z-index: 109; left: 616px;"
        //                        Text="移顶" Width="48px" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnUpMove" runat="server" Height="24px" OnClick="btnUpMove_Click"
        //                        Style="z-index: 109; left: 616px;" Text="上移" Width="48px" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnDownMove" runat="server" Height="24px" OnClick="btnDownMove_Click"
        //                        Style="z-index: 110; left: 664px;" Text="下移" Width="48px" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnGoBottum" runat="server" Height="24px" Style="z-index: 110; left: 664px;"
        //                        Text="移底" Width="48px" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnReOrder" runat="server" Height="24px" OnClick="btnReOrder_Click"
        //                        Style="z-index: 111; left: 712px;" Text="重序" Width="40px" CssClass="btn btn-outline-info" />
        //                </td>
        /// <summary>
        /// 建立[移顶]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnGoTop(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="移顶" id="btnGoTop" name="action:GoTop" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnGoTop";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:GoTopAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:GoTop";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "移顶";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnGoTop";
                objASPButtonENEx.OnClick = "btnGoTop_Click";
                objASPButtonENEx.Text = "移顶";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 48;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立[移底]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnGoBottum(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="移底" id="btnGoBottum" name="action:GoBottum" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnGoBottum";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:GoBottumAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:GoBottum";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "移底";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnGoBottum";
                objASPButtonENEx.OnClick = "btnGoBottum_Click";
                objASPButtonENEx.Text = "移底";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 48;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立[重序]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnReOrder(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="重序" id="btnReOrder" name="action:ReOrder" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnReOrder";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:ReOrderAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:ReOrder";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "重序";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnReOrder";
                objASPButtonENEx.OnClick = "btnReOrder_Click";
                objASPButtonENEx.Text = "重序";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 48;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立[上移]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnUpMove(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="上移" id="btnUpMove" name="action:UpMove" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnUpMove";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:UpMoveAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:UpMove";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "上移";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnUpMove";
                objASPButtonENEx.OnClick = "btnUpMove_Click";
                objASPButtonENEx.Text = "上移";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 48;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立[下移]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnDownMove(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnDownMove";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:DownMoveAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:DownMove";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "下移";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnDownMove";
                objASPButtonENEx.OnClick = "btnDownMove_Click";
                objASPButtonENEx.Text = "下移";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 48;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnExportExcel4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnExportExcel";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:ExportExcelAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:ExportExcel";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "导出";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnExportExcel4Gv";
                objASPButtonENEx.OnClick = "btnExportExcel4Gv_Click";
                objASPButtonENEx.Text = "导出Excel";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 80;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }
        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPButtonEx GetbtnSetExportExcel4User(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = "btnSetExportExcel4User";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = "action:SetExportExcel4UserAjax";
                }
                else
                {
                    objASPButtonENEx.CtrlName = "action:SetExportExcel4User";
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = "OnClickInFeatureRegion()";

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = "设置导出";
                objASPButtonENEx.Style = "";
                objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {
                objASPButtonENEx.CtrlId = "btnSetExportExcel4User";
                objASPButtonENEx.OnClick = "btnSetExportExcel4User_Click";
                objASPButtonENEx.Text = "设置导出字段";
                objASPButtonENEx.Style = "z-index: 107;";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";
                objASPButtonENEx.Width = 100;
                objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }

        public static List<ASPButtonEx> GetButton(clsPrjFeatureEN objPrjFeature, int intApplicationTypeId)
        {
            List<ASPButtonEx> arrButton = new List<ASPButtonEx>();
            var arrFeatureButtonRela = clsFeatureButtonRelaBL.GetObjLstCache();
            var arrFeatureButtonRela_Sel = arrFeatureButtonRela.Where(x=>x.ApplicationTypeId == intApplicationTypeId && x.FeatureId == objPrjFeature.FeatureId);
            foreach (var objInFor in arrFeatureButtonRela_Sel)
            {
                var objButtonTab = clsButtonTabBL.GetObjByButtonIdCache(objInFor.ButtonId);
                ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                //objASPButtonENEx.Is4PureHtml = bolIs4PureHtml;
                //objASPButtonENEx.Is4Mvc = bolIs4Mvc;
                objASPButtonENEx.objPrjFeature = objPrjFeature;
                objASPButtonENEx.OrderNum = objPrjFeature.OrderNum + 20;
                objASPButtonENEx.FeatureId = objPrjFeature.FeatureId;
                objASPButtonENEx.CommandName = objButtonTab.CommandName;
                //objASPButtonENEx.ValueGivingModeId = objPrjFeature.ValueGivingModeId;
                //objASPButtonENEx.ViewFeatureId = objPrjFeature.ViewFeatureId;
                objASPButtonENEx.GroupName = objPrjFeature.GroupName;
                clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(enumCtlType.Button_01);

                objASPButtonENEx.CtrlId = string.Format("{0}{1}", objCtlTypeAbbr.CtlTypeAbbr, objPrjFeature.FeatureId);
                objASPButtonENEx.OnClick4Html = string.Format("btnSel_Click('{0}')", objASPButtonENEx.CtrlId);

                objASPButtonENEx.OnClick = string.Format("{0}{1}_Click", objCtlTypeAbbr.CtlTypeAbbr, objPrjFeature.FeatureENName);

                objASPButtonENEx.Text = objPrjFeature.FeatureName;// "添加记录";
                if (objASPButtonENEx.Text.Length > 4) objASPButtonENEx.ColSpan_Ctrl = 2;
                else objASPButtonENEx.ColSpan_Ctrl = 1;
                //objASPButtonENEx.Class = "btn btn-outline-info";
                objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm";

                //objASPButtonENEx.Style = "z-index: 107;";

                //objASPButtonENEx.Width = objPrjFeature.Width;
                //objASPButtonENEx.Height = 0;
                arrButton.Add(objASPButtonENEx);
             
            }
            return arrButton;
        }
        public static ASPButtonEx GetButton(clsButtonTabENEx objButtonTabENEx)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            //objASPButtonENEx.Is4PureHtml = bolIs4PureHtml;
            //objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            objASPButtonENEx.objButtonTabENEx = objButtonTabENEx;
            objASPButtonENEx.OrderNum = objButtonTabENEx.SeqNum + 20;
            objASPButtonENEx.FeatureId = objButtonTabENEx.FeatureId;
            objASPButtonENEx.ValueGivingModeId = objButtonTabENEx.ValueGivingModeId;
            objASPButtonENEx.ViewFeatureId = objButtonTabENEx.ViewFeatureId;
            objASPButtonENEx.GroupName = objButtonTabENEx.GroupName;
            objASPButtonENEx.CommandName =$"btn{objButtonTabENEx.CommandName}_Click";

            //if (bolIs4Mvc == true)
            //{
            //    //<input value="重序" id="btnReOrder" name="action:ReOrder" type="submit" class="btn btn-outline-info" />
            //    objASPButtonENEx.CtrlId = objButtonTabENEx.ButtonName4Mvc;// "btnReOrder";
            //    if (bolIs4Ajax == true)
            //    {
            //        objASPButtonENEx.CtrlName = string.Format("action:{0}Ajax", objButtonTabENEx.ButtonName4Mvc.Substring(3));
            //    }
            //    else
            //    {
            //        objASPButtonENEx.CtrlName = string.Format("action:{0}", objButtonTabENEx.ButtonName4Mvc.Substring(3));
            //    }
            //    objASPButtonENEx.type = "submit";
            //    objASPButtonENEx.OnClick = string.Format("OnClickInFeatureRegion()");
            //    objASPButtonENEx.Name4MvcAjax = string.Format("action:{0}Ajax", objButtonTabENEx.ButtonName4Mvc.Substring(3));
            //    objASPButtonENEx.OnClick4MvcAjax = string.Format("OnClickInFeatureRegion()");
            //    objASPButtonENEx.OnClick4Html = string.Format("{0}_Click()", objButtonTabENEx.ButtonName);

            //    //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
            //    objASPButtonENEx.Value = objButtonTabENEx.Text;
            //    objASPButtonENEx.Style = "";

            //    if (objASPButtonENEx.Text == "导出Excel")
            //    {
            //        objASPButtonENEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
            //        //objASPButtonENEx.CssClass = "btn btn-outline-warning";
            //    }
            //    else
            //    {
            //        objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
            //        //objASPButtonENEx.CssClass = "btn btn-outline-info";
            //    }
            //    objASPButtonENEx.CssClass = "";
            //    //objASPButtonENEx.Width = 80;
            //    //objASPButtonENEx.Height = 0;
            //}
            //else
            //{

                objASPButtonENEx.CtrlId = objButtonTabENEx.ButtonName;
                objASPButtonENEx.OnClick = string.Format("btn{0}_Click", objButtonTabENEx.CommandName);
                if (objButtonTabENEx.Is4Visible == true)
                {
                    objASPButtonENEx.OnClick4Html = string.Format("btnClick('{0}')", objASPButtonENEx.CtrlId);
                }
                else
                {
                    if (string.IsNullOrEmpty(objButtonTabENEx.EventFuncName) == false)
                    {
                        objASPButtonENEx.OnClick4Html = objButtonTabENEx.EventFuncName.Replace("''", "'").Replace("''", "'").Replace("''", "'").Replace("''", "'");
                    }
                    else
                    {
                        objASPButtonENEx.OnClick4Html = string.Format("btn{0}_Click()", objButtonTabENEx.CommandName);
                    }
                }
                objASPButtonENEx.Text = objButtonTabENEx.Text;// "添加记录";

                if (objASPButtonENEx.Text == "导出Excel")
                {
                    objASPButtonENEx.CssClass = "btn btn-outline-warning btn-sm text-nowrap";
                }
                else
                {
                    objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm text-nowrap";
                }
            
            return objASPButtonENEx;
        }



        public static ASPButtonEx GetButtonBak202110221(clsFeatureRegionFldsENEx objFeatureRegionFldsENEx, bool bolIs4Mvc = false, bool bolIs4Ajax = false, bool bolIs4PureHtml = false)
        {
            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            //objASPButtonENEx.Is4PureHtml = bolIs4PureHtml;
            objASPButtonENEx.Is4Mvc = bolIs4Mvc;
            objASPButtonENEx.objFeatureRegionFldsENEx = objFeatureRegionFldsENEx;
            if (objFeatureRegionFldsENEx.SeqNum != null)
            {
                objASPButtonENEx.OrderNum = (int)objFeatureRegionFldsENEx.SeqNum + 20;
            }
            objASPButtonENEx.FeatureId = objFeatureRegionFldsENEx.FeatureId;
            objASPButtonENEx.ValueGivingModeId = objFeatureRegionFldsENEx.ValueGivingModeId;
            objASPButtonENEx.ViewFeatureId = objFeatureRegionFldsENEx.ViewFeatureId;
            objASPButtonENEx.GroupName = objFeatureRegionFldsENEx.GroupName;

            if (bolIs4Mvc == true)
            {
                //<input value="重序" id="btnReOrder" name="action:ReOrder" type="submit" class="btn btn-outline-info" />
                objASPButtonENEx.CtrlId = objFeatureRegionFldsENEx.ButtonName4Mvc;// "btnReOrder";
                if (bolIs4Ajax == true)
                {
                    objASPButtonENEx.CtrlName = string.Format("action:{0}Ajax", objFeatureRegionFldsENEx.ButtonName4Mvc.Substring(3));
                }
                else
                {
                    objASPButtonENEx.CtrlName = string.Format("action:{0}", objFeatureRegionFldsENEx.ButtonName4Mvc.Substring(3));
                }
                objASPButtonENEx.type = "submit";
                objASPButtonENEx.OnClick = string.Format("OnClickInFeatureRegion()");
                objASPButtonENEx.Name4MvcAjax = string.Format("action:{0}Ajax", objFeatureRegionFldsENEx.ButtonName4Mvc.Substring(3));
                objASPButtonENEx.OnClick4MvcAjax = string.Format("OnClickInFeatureRegion()");
                objASPButtonENEx.OnClick4Html = string.Format("{0}_Click()", objFeatureRegionFldsENEx.ButtonName);

                //objASPButtonENEx.OnClick = "btnAddNewRec4Gv_Click";
                objASPButtonENEx.Value = objFeatureRegionFldsENEx.Text;
                objASPButtonENEx.Style = "";

                if (objASPButtonENEx.Text == "导出Excel")
                {
                    objASPButtonENEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
                    //objASPButtonENEx.CssClass = "btn btn-outline-warning";
                }
                else
                {
                    objASPButtonENEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                    //objASPButtonENEx.CssClass = "btn btn-outline-info";
                }
                objASPButtonENEx.CssClass = "";
                //objASPButtonENEx.Width = 80;
                //objASPButtonENEx.Height = 0;
            }
            else
            {

                objASPButtonENEx.CtrlId = objFeatureRegionFldsENEx.ButtonName;
                
                objASPButtonENEx.OnClick = string.Format("{0}_Click", objFeatureRegionFldsENEx.ButtonName);
                if (objFeatureRegionFldsENEx.Is4Visible == true)
                {
                    objASPButtonENEx.OnClick4Html = string.Format("btnClick('{0}')", objASPButtonENEx.CtrlId);
                }
                else
                {
                   
                }
                objASPButtonENEx.Text = objFeatureRegionFldsENEx.Text;// "添加记录";

                if (objASPButtonENEx.Text == "导出Excel")
                {
                    //objASPButtonENEx.Class = "btn btn-outline-warning";
                    objASPButtonENEx.CssClass = "btn btn-outline-warning btn-sm text-nowrap";

                }
                else
                {
                    //objASPButtonENEx.Class = "btn btn-outline-info";
                    objASPButtonENEx.CssClass = "btn btn-outline-info btn-sm text-nowrap";
                }
                //objASPButtonENEx.Style = "z-index: 107;";

                //objASPButtonENEx.Width = objFeatureRegionFldsENEx.Width;
                //objASPButtonENEx.Height = 0;
            }
            return objASPButtonENEx;
        }
        //public static Func<clsFeatureRegionFldsENEx, ASPButtonEx> GetButton4Asp = obj => GetButton(obj, false, false);
        //public static Func<clsFeatureRegionFldsENEx, ASPButtonEx> GetButton4MvcAjax = obj => GetButton(obj, true, true);
        //public static Func<clsFeatureRegionFldsENEx, ASPButtonEx> GetButton4PureHtml = obj => GetButton(obj, false, false, true);
        //public static void GetButtonLstByFeatureRegionFldsBak20211022(List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsENEx, int intApplicationTypeId)
        //{
                   
        //    IEnumerable<ASPButtonEx> arrButtonLst = arrFeatureRegionFldsENEx.Select(obj => GetButton(obj, false, false));

        //    List<clsUserStateEN> arrObjLst = clsUserStateBL.GetObjLst("1=1");
        //    IEnumerable<clsUserStateEN> arrObjLst2 = arrObjLst.Where(x => x.UserStateId.CompareTo("66") >= 0);
        //}


    }
}