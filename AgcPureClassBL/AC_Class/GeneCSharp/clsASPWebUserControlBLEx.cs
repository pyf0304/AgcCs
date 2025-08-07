
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPWebUserControlBLEx
表名:ASPNETWebUserControl(00050234)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:41
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
    /// ASPNETWeb用户控件(ASPNETWebUserControl)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPWebUserControlBLEx_Static
    {
        //<uc1:wucSexB ID = "wucSexB1" runat = "server" />
        public static void GeneCode(this ASPWebUserControlEx objASPWebUserControlENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            strCodeForCs.AppendFormat("\r\n" + "<{0}:{1} ID = \"{2}\" runat = \"server\"  ",
                objASPWebUserControlENEx.TagPrefix,
                objASPWebUserControlENEx.wucClassName,
                objASPWebUserControlENEx.AspControlId);

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPWebUserControlENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }
            strCodeForCs.AppendFormat("\r\n" + "</{0}:{1}>",
                 objASPWebUserControlENEx.TagPrefix,
                objASPWebUserControlENEx.wucClassName);

        }
        //public static void GeneCode4Html(this ASPWebUserControlEx objASPWebUserControlENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{
        //    strCodeForCs.AppendFormat("\r\n" + "<{0}:{1} ID = \"{2}\" runat = \"server\"  ",
        //        objASPWebUserControlENEx.TagPrefix,
        //        objASPWebUserControlENEx.wucClassName,
        //        objASPWebUserControlENEx.AspControlId);

        //    strCodeForCs.Append(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPWebUserControlENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "</{0}:{1}>",
        //         objASPWebUserControlENEx.TagPrefix,
        //        objASPWebUserControlENEx.wucClassName);

        //}
    }
        /// <summary>
        /// ASPNETWeb用户控件(ASPNETWebUserControl)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPWebUserControlBLEx 
        {
        


    }
}