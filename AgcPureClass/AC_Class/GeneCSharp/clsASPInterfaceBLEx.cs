
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPInterfaceBLEx
表名:ASPNETInterface(00050213)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:07
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

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET界面(ASPNETInterface)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPInterfaceBLEx_Static
    {

        public static void GeneCode(this ASPInterfaceEx objASPInterfaceENEx, StringBuilder strCodeForCs)
        {

            //strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wuc{0}B\" Src = \"wuc{1}B.ascx\" %>",
            //                 objViewInfoENEx.TabName, objViewInfoENEx.TabName);
            //             if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
            //             {
            //                 strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeFile = \"{0}.aspx.cs\" Inherits = \"{1}.Webform.{2}\" %>",
            //                      objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
            //             }
            //             else
            //             {
            //                 strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.Webform.{2}\" %>",
            //                     objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
            //             }
            //             strCodeForCs.Append("\r\n" + "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd\">");
            //                }

            strCodeForCs.Append("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wucSexB\" Src = \"wucSexB.ascx\" %>");
            strCodeForCs.Append("\r\n" + "<%@ Page Language = \"c#\" AutoEventWireup = \"True\" CodeBehind = \"wfmSexB_QUDI.aspx.cs\" Inherits = \"SimplePrj.Webform.wfmSexB_QUDI\" %>");
            strCodeForCs.Append("\r\n" + "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd\">");
            strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
            foreach (ASPControlEx objSubASPControlENEx in objASPInterfaceENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</html>");
        }
    }
        /// <summary>
        /// ASPNET界面(ASPNETInterface)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPInterfaceBLEx 
        {
        

    }

}