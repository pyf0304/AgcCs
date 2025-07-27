
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPColBLEx
表名:ASPNETCol(00050220)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:32
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
using System.Web.UI.HtmlControls;
using AgcCommBase;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET列(ASPNETCol)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPColBLEx_Static
    {

        public static void GeneCode(this ASPColEx objASPColENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    strCodeForCs.Append("\r\n" + "<td");
                    clsASPControlBLEx.GC4Style(objASPColENEx, strCodeForCs);
                    if (objASPColENEx.ColSpan_Ctrl > 1)
                    {
                        strCodeForCs.AppendFormat(" " + "ColSpan={0}", objASPColENEx.ColSpan_Ctrl);
                    }
                    strCodeForCs.Append("" + ">");
                    foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    strCodeForCs.Append("\r\n" + "</td>");

                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    strCodeForCs.Append("\r\n" + "<td");
                    clsASPControlBLEx.GC4Style(objASPColENEx, strCodeForCs);
                    if (objASPColENEx.ColSpan_Ctrl > 1)
                    {
                        strCodeForCs.AppendFormat(" " + "ColSpan={0}", objASPColENEx.ColSpan_Ctrl);
                    }
                    strCodeForCs.Append("" + ">");
                    foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    strCodeForCs.Append("\r\n" + "</td>");

                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:

                    strCodeForCs.Append("\r\n" + "<td");
                    clsASPControlBLEx.GC4Style(objASPColENEx, strCodeForCs);
                    if (objASPColENEx.ColSpan_Ctrl > 1)
                    {
                        strCodeForCs.AppendFormat(" " + "ColSpan={0}", objASPColENEx.ColSpan_Ctrl);
                    }
                    strCodeForCs.Append("" + ">");
                    foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
                    {
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    strCodeForCs.Append("\r\n" + "</td>");

                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
         
        }


        //public static void GeneCode4Html(this ASPColEx objASPColENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{
        //    strCodeForCs.Append("\r\n" + "<td");
        //    clsASPControlBLEx.GC4Style(objASPColENEx, strCodeForCs);
        //    if (objASPColENEx.ColSpan_Ctrl > 1)
        //    {
        //        strCodeForCs.AppendFormat(" " + "ColSpan={0}", objASPColENEx.ColSpan_Ctrl);
        //    }
        //    strCodeForCs.Append("" + ">");
        //    foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.Append("\r\n" + "</td>");

        //}

        public static void GeneCode4Mvc(this ASPColEx objASPColENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<td");
            clsASPControlBLEx.GC4Style(objASPColENEx, strCodeForCs);
            strCodeForCs.Append("" + ">");
            foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</td>");

        }
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPColENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPColEx objASPColENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlTableCell objTableCell = new HtmlTableCell();
            objTableCell.Attributes["class"] = objASPColENEx.Class;
            objTableCell.ID = objASPColENEx.CtrlId;
            if (objASPColENEx.ColSpan_Ctrl>1)
            {
                objTableCell.ColSpan = objASPColENEx.ColSpan_Ctrl;
            }
            objContainer.Controls.Add(objTableCell);
            foreach (ASPControlEx objSubASPControlENEx in objASPColENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.Parent = objASPColENEx;
                objSubASPControlENEx.GeneHtmlControl(objTableCell);
            }
            //return objTableCell;
        }
    }
    /// <summary>
    /// ASPNET列(ASPNETCol)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPColBLEx 
        {

      
        /// <summary>
        /// 建立[空行td]
        /// </summary>
        /// <returns></returns>
        public static ASPColEx GetEmptyTd()
        {
            ASPColEx objASPColENEx = new ASPColEx();
            //objASPColENEx.CtrlId = "tr1";         
            //objASPColENEx.Style = "width: 100%; height: 32px; ";
            //objASPColENEx.Class = "msgtable";
            return objASPColENEx;
        }
    }
}
