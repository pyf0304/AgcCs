
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHtmlInputBLEx
表名:ASPHtmlInput(00050449)
生成代码版本:2019.04.19.1
生成日期:2019/04/19 15:46:42
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

namespace AGC.PureClassEx
{
    public static class clsASPHtmlInputBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPHtmlInputENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPHtmlInputEx objASPHtmlInputENEx, enumApplicationType intApplicationTypeId,
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
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<input ");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlInputENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.type) == false)
            {
                strCodeForCs.AppendFormat(" type=\"{0}\"",
                    objASPHtmlInputENEx.type);
            }
            //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPHtmlInputENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPHtmlInputENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHtmlInputENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPHtmlInputENEx.OnClick);
            }
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHtmlInputENEx.Value);
            }
            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPHtmlInputENEx, strCodeForCs);

            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPHtmlInputENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}


        }
        public static void GeneCode4Html(this ASPHtmlInputEx objASPHtmlInputENEx,
           StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<input ");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlInputENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.type) == false)
            {
                strCodeForCs.AppendFormat(" type=\"{0}\"",
                    objASPHtmlInputENEx.type);
            }
            //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPHtmlInputENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPHtmlInputENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHtmlInputENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPHtmlInputENEx.OnClick);
            }
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHtmlInputENEx.Value);
            }
            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPHtmlInputENEx, strCodeForCs);

            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPHtmlInputENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}


        }


        public static void GeneCode4Mvc(this ASPHtmlInputEx objASPHtmlInputENEx,
         StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<input ");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlInputENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.type) == false)
            {
                strCodeForCs.AppendFormat(" type=\"{0}\"",
                    objASPHtmlInputENEx.type);
            }
            //strCodeForCs.AppendFormat("\r\n" + " type=\"button\" ");

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPHtmlInputENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPHtmlInputENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHtmlInputENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPHtmlInputENEx.OnClick);
            }
            if (string.IsNullOrEmpty(objASPHtmlInputENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHtmlInputENEx.Value);
            }
            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPHtmlInputENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPHtmlInputENEx, strCodeForCs);

            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPHtmlInputENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}


        }
       
       
    }
    /// <summary>
    /// ASPHtmlInput(ASPHtmlInput)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsASPHtmlInputBLEx 
    {



        public static ASPHtmlInputEx GetEmptyHtmlInput()
        {
            ASPHtmlInputEx objASPHtmlInputENEx = new ASPHtmlInputEx();
            //objASPHtmlInputENEx.CtrlId = "divFunction";
            //objASPHtmlInputENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlInputENEx.Text = "添加记录";
            //objASPHtmlInputENEx.Style = "width: 100%; height: 32px; ";
            //objASPHtmlInputENEx.Class = "msgtable";
            //objASPHtmlInputENEx.Width = 80;
            //objASPHtmlInputENEx.Height = 0;
            return objASPHtmlInputENEx;
        }

        public static ASPHtmlInputEx GetInput_Submit()
        {
            ASPHtmlInputEx objASPHtmlInputENEx = new ASPHtmlInputEx();
            //objASPHtmlInputENEx.CtrlId = "divFunction";
            objASPHtmlInputENEx.type = "submit";
            //objASPHtmlInputENEx.Text = "添加记录";
            //objASPHtmlInputENEx.Style = "width: 100%; height: 32px; ";
            //objASPHtmlInputENEx.Class = "msgtable";
            //objASPHtmlInputENEx.Width = 80;
            //objASPHtmlInputENEx.Height = 0;
            return objASPHtmlInputENEx;
        }
    }
}