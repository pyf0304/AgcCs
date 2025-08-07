
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPCodeBLEx
表名:ASPNETCode(00050433)
生成代码版本:2019.03.09.1
生成日期:2019/03/13 00:11:21
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET代码(ASPNETCode)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public static class clsASPCodeBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPCodeENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPCodeEx objASPCodeENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            if (string.IsNullOrEmpty(objASPCodeENEx.CodeText) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}", objASPCodeENEx.CodeText);
            }

            foreach (ASPControlEx objSubASPControlENEx in objASPCodeENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }

        }

        public static void GeneCode4Mvc(this ASPCodeEx objASPCodeENEx,
         StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            if (string.IsNullOrEmpty(objASPCodeENEx.CodeText) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}", objASPCodeENEx.CodeText);
            }

            foreach (ASPControlEx objSubASPControlENEx in objASPCodeENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }

        }
    }
        /// <summary>
         /// ASPNET代码(ASPNETCode)
         /// 数据源类型:SQL表
         /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
         /// </summary>
        public partial class clsASPCodeBLEx 
        {
        
      


    
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPCodeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPCodeEx objASPCodeENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Div tw{0};",
                objASPCodeENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPCodeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPCodeEx objASPCodeENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)findViewById(R.id.tw{0}); ",
                objASPCodeENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPCodeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPCodeEx objASPCodeENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)view.findViewById(R.id.tw{0}); ",
                objASPCodeENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPCodeENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPCodeEx objASPCodeENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPCodeENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPCodeENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPCodeENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPCodeENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPCodeENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
    }
}