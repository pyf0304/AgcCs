
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidEditTextBLEx
表名:AndroidEditText
生成代码版本:2018.02.11.1
生成日期:2018/02/24 10:39:29
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成Android
模块英文名:GCAndroid
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using CommonTable.Entity;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.BusinessLogicEx
{
    public static class clsAndroidEditTextBLEx_Static 
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidEditTextENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidEditTextENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidEditTextENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<EditText");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidEditTextENEx.CtrlId);

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidEditTextENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidEditTextENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidEditTextENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidEditTextENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objAndroidEditTextENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objAndroidEditTextENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidEditTextENEx.Text);
            if (string.IsNullOrEmpty(objAndroidEditTextENEx.inputType) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:inputType=\"{0}\"",
                    objAndroidEditTextENEx.inputType);
            }
            if (objAndroidEditTextENEx.ems > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
                    objAndroidEditTextENEx.ems);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidEditTextENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidEditTextENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}


        }
    }
        /// <summary>
        /// Android编辑文本框(AndroidEditText)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidEditTextBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
           
            strCodeForCs.AppendFormat("\r\n" + "private EditText {0};",
                objAndroidEditTextENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (EditText)findViewById(R.id.{0}); ",
                objAndroidEditTextENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (EditText)view.findViewById(R.id.{0}); ",
                objAndroidEditTextENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                  string.Format("{0}.getText().toString()", objAndroidEditTextENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                  string.Format("{0}.getText().toString()", objAndroidEditTextENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
         
            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objAndroidEditTextENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(clsAndroidEditTextENEx objAndroidEditTextENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objAndroidEditTextENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(clsAndroidEditTextENEx objAndroidEditTextENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidEditTextENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText({1});",               
               objAndroidEditTextENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName,
               AgcPubFun.getToStringCode4DataType4Java(
                   objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                   string.Format("obj{0}EN.get{1}()",
                   objViewInfoENEx.objOutRelaTab.TabName,
                   objAndroidEditTextENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName)));
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objAndroidEditTextENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(clsAndroidEditTextENEx objAndroidEditTextENEx, StringBuilder strCodeForCs)
        {           
            strCodeForCs.AppendFormat("\r\n" + "txt{0}.setText(\"\");",
               objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("// {0}", objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objAndroidEditTextENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);
        }
    }
}