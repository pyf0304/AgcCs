
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPLinkButtonBLEx
表名:ASPNETLinkButton(00050230)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:21
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

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET链接按钮(ASPNETLinkButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPLinkButtonBLEx_Static
    {

        public static void GeneCode(this ASPLinkButtonEx objASPLinkButtonENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //<asp:Button ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:Button>
            strCodeForCs.AppendFormat("\r\n" + "<asp:LinkButton ID = \"{0}\" Style = \"z-index: 105;\" runat = \"server\" ", objASPLinkButtonENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPLinkButtonENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPLinkButtonENEx.CssClass);
            }
            if (objASPLinkButtonENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPLinkButtonENEx.Width);
            }
            if (objASPLinkButtonENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPLinkButtonENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPLinkButtonENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPLinkButtonENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPLinkButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPLinkButtonENEx.OnClick);
            }
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPLinkButtonENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:LinkButton>");

        }

        //public static void GeneCode4Html(this ASPLinkButtonEx objASPLinkButtonENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{          
        //    strCodeForCs.AppendFormat("\r\n" + "<asp:LinkButton ID = \"{0}\" Style = \"z-index: 105;\" runat = \"server\" ", objASPLinkButtonENEx.AspControlId);
        //    if (string.IsNullOrEmpty(objASPLinkButtonENEx.CssClass) == false)
        //    {
        //        strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPLinkButtonENEx.CssClass);
        //    }
        //    if (objASPLinkButtonENEx.Width > 0)
        //    {
        //        strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPLinkButtonENEx.Width);
        //    }
        //    if (objASPLinkButtonENEx.Height > 0)
        //    {
        //        strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPLinkButtonENEx.Height);
        //    }

        //    if (string.IsNullOrEmpty(objASPLinkButtonENEx.Text) == false)
        //    {
        //        strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPLinkButtonENEx.Text);
        //    }
        //    if (string.IsNullOrEmpty(objASPLinkButtonENEx.OnClick) == false)
        //    {
        //        strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPLinkButtonENEx.OnClick);
        //    }
        //    strCodeForCs.Append(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPLinkButtonENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.Append("\r\n" + "</asp:LinkButton>");

        //}


        public static void GeneCode4Mvc(this ASPLinkButtonEx objASPLinkButtonENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:Button ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:Button>
            strCodeForCs.AppendFormat("\r\n" + "<asp:LinkButton ID = \"{0}\" Style = \"z-index: 105;\" runat = \"server\" ", objASPLinkButtonENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPLinkButtonENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPLinkButtonENEx.CssClass);
            }
            if (objASPLinkButtonENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPLinkButtonENEx.Width);
            }
            if (objASPLinkButtonENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPLinkButtonENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPLinkButtonENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPLinkButtonENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPLinkButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPLinkButtonENEx.OnClick);
            }
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPLinkButtonENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:LinkButton>");

        }

    }
    /// <summary>
    /// ASPNET链接按钮(ASPNETLinkButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPLinkButtonBLEx 
        {


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLinkButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPLinkButtonEx objASPLinkButtonENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            //< android.support.design.widget.LinkButton
            //    android: id = "@+id/fab"
            //    android: layout_width = "wrap_content"
            //    android: layout_height = "wrap_content"
            //    android: layout_gravity = "bottom|end"
            //    android: layout_margin = "@dimen/fab_margin"
            //    app: srcCompat = "@android:drawable/ic_dialog_email" />

            strCodeForCs.AppendFormat("\r\n" + "<asp:LinkButton");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPLinkButtonENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPLinkButtonENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPLinkButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPLinkButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPLinkButtonENEx.OnClick) == false)
            {

                strCodeForCs.AppendFormat(" OnClick = \"{0}\"  ", objASPLinkButtonENEx.OnClick);

            }
            clsASPControlBLEx.GC4Text(objASPLinkButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPLinkButtonENEx.layout_gravity) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_gravity=\"{0}\"",
                    objASPLinkButtonENEx.layout_gravity);
            }

            if (string.IsNullOrEmpty(objASPLinkButtonENEx.srcCompat) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:srcCompat=\"{0}\"",
                    objASPLinkButtonENEx.srcCompat);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPLinkButtonENEx, strCodeForCs);
            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPLinkButtonENEx.arrSubASPNETControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}


        }
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPLinkButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPLinkButtonEx objASPLinkButtonENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private Button {0};",
                objASPLinkButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLinkButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPLinkButtonEx objASPLinkButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)findViewById(R.id.btn{0}); ",
                objASPLinkButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLinkButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPLinkButtonEx objASPLinkButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)view.findViewById(R.id.btn{0}); ",
                objASPLinkButtonENEx.CtrlId);

        }
    }
}
