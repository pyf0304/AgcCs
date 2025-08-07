
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHiddenFieldBLEx
表名:ASPNETHiddenField(00050417)
生成代码版本:2018.08.16.1
生成日期:2018/08/20 10:39:15
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
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET隐藏字段(ASPNETHiddenField)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHiddenFieldBLEx_Static
    {

        public static void GeneCode(this ASPHiddenFieldEx objASPHiddenFieldENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<asp:HiddenField ");
            //生成控件的Id、Name
            //clsASPControlBLEx.GC4IdName(objASPHiddenFieldENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPHiddenFieldENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat(" id=\"{0}\"",
                objASPHiddenFieldENEx.CtrlId);
            }
            ////生成控件的Tag
            //clsASPControlBLEx.GC4Style(objASPHiddenFieldENEx, strCodeForCs);

            strCodeForCs.Append(" runat = \"server\" ");

            if (string.IsNullOrEmpty(objASPHiddenFieldENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHiddenFieldENEx.Value);
            }
            strCodeForCs.Append(" />");
        }
        public static void GeneCode4Mvc(this ASPHiddenFieldEx objASPHiddenFieldENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<asp:HiddenField ");
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHiddenFieldENEx, strCodeForCs);

            ////生成控件的Tag
            //clsASPControlBLEx.GC4Style(objASPHiddenFieldENEx, strCodeForCs);

            strCodeForCs.Append(" runat = \"server\" ");

            if (string.IsNullOrEmpty(objASPHiddenFieldENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHiddenFieldENEx.Value);
            }
            strCodeForCs.Append(" />");
        }
    }
    /// <summary>
    /// ASPNET隐藏字段(ASPNETHiddenField)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPHiddenFieldBLEx 
        {


        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPHiddenFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPHiddenFieldEx objASPHiddenFieldENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Hr {0};",
                objASPHiddenFieldENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHiddenFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPHiddenFieldEx objASPHiddenFieldENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Hr)findViewById(R.id.{0}); ",
                objASPHiddenFieldENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHiddenFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPHiddenFieldEx objASPHiddenFieldENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Hr)view.findViewById(R.id.{0}); ",
                objASPHiddenFieldENEx.CtrlId);

        }


        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPHiddenFieldENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPHiddenFieldEx objASPHiddenFieldENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPHiddenFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPHiddenFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPHiddenFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPHiddenFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPHiddenFieldENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }

    }
}