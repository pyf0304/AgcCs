
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPCompareValidatorBLEx
表名:ASPCompareValidator(00050459)
生成代码版本:2019.04.30.1
生成日期:2019/04/30 16:15:26
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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

namespace AGC.PureClassEx
{
    public static class clsASPCompareValidatorBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPCompareValidatorENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPCompareValidatorEx objASPCompareValidatorENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
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
            //  < asp:CompareValidator ID = "ComValid_OrderNum" runat = "server" CssClass = "ErrMsg" ErrorMessage = "请输入整型数值!" ControlToValidate = "txtOrderNum"
            //Type = "Integer" Operator = "DataTypeCheck" EnableClientScript = "false" >

            //</ asp:CompareValidator >
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPCompareValidatorENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Runat(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPCompareValidatorENEx, strCodeForCs);

            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ErrorMessage) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " ErrorMessage=\"{0}\"",
                    objASPCompareValidatorENEx.ErrorMessage);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ControlToValidate) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " ControlToValidate=\"{0}\"",
                    objASPCompareValidatorENEx.ControlToValidate);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.type) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " Type=\"{0}\"",
                    objASPCompareValidatorENEx.type);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.Operator) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " Operator=\"{0}\"",
                    objASPCompareValidatorENEx.Operator);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.EnableClientScript) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " EnableClientScript=\"{0}\"",
                    objASPCompareValidatorENEx.EnableClientScript);
            }
            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPCompareValidatorENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPCompareValidatorENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPCompareValidatorENEx.orientation);
            //}
            
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPCompareValidatorENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }
            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");

        }

        //public static void GeneCode4Html(this ASPCompareValidatorEx objASPCompareValidatorENEx, enumApplicationType intApplicationTypeId,
        //  StringBuilder strCodeForCs)
        //{

        //    //  < asp:CompareValidator ID = "ComValid_OrderNum" runat = "server" CssClass = "ErrMsg" ErrorMessage = "请输入整型数值!" ControlToValidate = "txtOrderNum"
        //    //Type = "Integer" Operator = "DataTypeCheck" EnableClientScript = "false" >

        //    //</ asp:CompareValidator >
        //    string strActionId = AgcPubFun.getASPNETID();
        //    string strKey = "";
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.mKey) == true)
        //    {
        //        strKey = "";
        //    }
        //    else
        //    {
        //        strKey = string.Format("key=\"{0}\"", objASPCompareValidatorENEx.mKey);
        //    }

        //    strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator");

        //    //生成控件的Id、Name
        //    clsASPControlBLEx.GC4IdName(objASPCompareValidatorENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Runat(objASPCompareValidatorENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Style(objASPCompareValidatorENEx, strCodeForCs);

        //    //生成线性布局的子控件的布局方向-横向、纵向
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ErrorMessage) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + " ErrorMessage=\"{0}\"",
        //            objASPCompareValidatorENEx.ErrorMessage);
        //    }
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ControlToValidate) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + " ControlToValidate=\"{0}\"",
        //            objASPCompareValidatorENEx.ControlToValidate);
        //    }
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.type) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + " Type=\"{0}\"",
        //            objASPCompareValidatorENEx.type);
        //    }
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.Operator) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + " Operator=\"{0}\"",
        //            objASPCompareValidatorENEx.Operator);
        //    }
        //    if (string.IsNullOrEmpty(objASPCompareValidatorENEx.EnableClientScript) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + " EnableClientScript=\"{0}\"",
        //            objASPCompareValidatorENEx.EnableClientScript);
        //    }
        //    //生成控件的尺寸-高、宽
        //    clsASPControlBLEx.GC4Size(objASPCompareValidatorENEx, strCodeForCs);

        //    //生成控件的边界尺寸-即与四周的距离
        //    clsASPControlBLEx.GC4Margin(objASPCompareValidatorENEx, strCodeForCs);
        //    //生成线性布局的子控件的布局方向-横向、纵向
        //    //if (string.IsNullOrEmpty(objASPCompareValidatorENEx.orientation) == false)
        //    //{
        //    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
        //    //        objASPCompareValidatorENEx.orientation);
        //    //}

        //    strCodeForCs.AppendFormat(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPCompareValidatorENEx.arrSubAspControlLst2)
        //    {
        //        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");

        //}


        public static void GeneCode4Mvc(this ASPCompareValidatorEx objASPCompareValidatorENEx, enumApplicationType intApplicationTypeId,
       StringBuilder strCodeForCs)
        {

            //  < asp:CompareValidator ID = "ComValid_OrderNum" runat = "server" CssClass = "ErrMsg" ErrorMessage = "请输入整型数值!" ControlToValidate = "txtOrderNum"
            //Type = "Integer" Operator = "DataTypeCheck" EnableClientScript = "false" >

            //</ asp:CompareValidator >
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPCompareValidatorENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Runat(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPCompareValidatorENEx, strCodeForCs);

            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ErrorMessage) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " ErrorMessage=\"{0}\"",
                    objASPCompareValidatorENEx.ErrorMessage);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.ControlToValidate) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " ControlToValidate=\"{0}\"",
                    objASPCompareValidatorENEx.ControlToValidate);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.type) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " Type=\"{0}\"",
                    objASPCompareValidatorENEx.type);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.Operator) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " Operator=\"{0}\"",
                    objASPCompareValidatorENEx.Operator);
            }
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.EnableClientScript) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + " EnableClientScript=\"{0}\"",
                    objASPCompareValidatorENEx.EnableClientScript);
            }
            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPCompareValidatorENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPCompareValidatorENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPCompareValidatorENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPCompareValidatorENEx.orientation);
            //}

            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPCompareValidatorENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }
            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");

        }
        public static void GeneHtmlControl(this ASPCompareValidatorEx objASPCompareValidatorENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPCompareValidatorENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPCompareValidatorENEx.mKey);
            }
            HtmlGenericControl objSpan = new HtmlGenericControl("span");
            objSpan.Attributes["class"] = objASPCompareValidatorENEx.Class;
            objSpan.ID = objASPCompareValidatorENEx.CtrlId;
            objSpan.InnerHtml = objASPCompareValidatorENEx.ErrorMessage;
            objContainer.Controls.Add(objSpan);

            return;

        }

    }
    /// <summary>
    /// ASP校验(ASPCompareValidator)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsASPCompareValidatorBLEx 
    {
        
     
    }
}