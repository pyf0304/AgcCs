
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPRowBLEx
表名:ASPNETRow(00050219)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:29
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
    /// ASPNET行(ASPNETRow)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPRowBLEx_Static
    {
        public static void GeneCode(this ASPRowEx objASPRowENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<tr>");

            foreach (ASPControlEx objSubASPControlENEx in objASPRowENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</tr>");

        }
        public static void GeneCode4Mvc(this ASPRowEx objASPRowENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<tr>");

            foreach (ASPControlEx objSubASPControlENEx in objASPRowENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</tr>");

        }

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPRowENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPRowEx objASPRowENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlTableRow objTableRow = new HtmlTableRow();
            objTableRow.Attributes["class"] = objASPRowENEx.Class;
            objTableRow.ID = objASPRowENEx.CtrlId;
            objContainer.Controls.Add(objTableRow);
            foreach (ASPControlEx objSubASPControlENEx in objASPRowENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.Parent = objASPRowENEx;
                 objSubASPControlENEx.GeneHtmlControl(objTableRow);
                
            }
            //return objTable;
        }
    }
    
    /// <summary>
        /// ASPNET行(ASPNETRow)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPRowBLEx 
        {

     

        /// <summary>
        /// 建立[空行tr]
        /// </summary>
        /// <returns></returns>
        public static ASPRowEx GetEmptyTr()
        {
            ASPRowEx objASPRowENEx = new ASPRowEx();
            //objASPRowENEx.CtrlId = "tr1";         
            //objASPRowENEx.Style = "width: 100%; height: 32px; ";
            //objASPRowENEx.Class = "msgtable";
            return objASPRowENEx;
        }
    }
}