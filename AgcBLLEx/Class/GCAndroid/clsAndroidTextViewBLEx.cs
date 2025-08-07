
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidTextViewBLEx
表名:AndroidTextView
生成代码版本:2018.02.11.1
生成日期:2018/02/24 10:39:32
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
    /// <summary>
    /// Android文本视图(AndroidTextView)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsAndroidTextViewBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidTextViewENEx">文本视图对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidTextViewENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidTextViewENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<TextView");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidTextViewENEx.CtrlId);

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidTextViewENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidTextViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidTextViewENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidTextViewENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objAndroidTextViewENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objAndroidTextViewENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidTextViewENEx.Text);
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidTextViewENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidTextViewENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}
        }
    }

        /// <summary>
        /// Android文本视图(AndroidTextView)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidTextViewBLEx 
    {
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private TextView {0};",
                objAndroidTextViewENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextView)findViewById(R.id.{0});",
                objAndroidTextViewENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (TextView)view.findViewById(R.id.{0});",
                objAndroidTextViewENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                  string.Format("{0}.getText().toString()", objAndroidTextViewENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}.getText().toString()", objAndroidTextViewENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
    objAndroidTextViewENEx.CtrlId,
    AgcPubFun.getToStringCode4DataType4Java(objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(clsAndroidTextViewENEx objAndroidTextViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp,
                objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});", 
                objAndroidTextViewENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));
            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(clsAndroidTextViewENEx objAndroidTextViewENEx, clsViewInfoENEx objViewInfoENEx, 
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidTextViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
            //   objViewInfoENEx.objOutRelaTab.TabName,
            //   objAndroidTextViewENEx.objDGRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText({1});",
            objAndroidTextViewENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName,
            AgcPubFun.getToStringCode4DataType4Java(
                objAndroidTextViewENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                string.Format("obj{0}EN.get{1}()",
                objViewInfoENEx.objOutRelaTab.TabName,
                objAndroidTextViewENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName)));

            //strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(clsAndroidTextViewENEx objAndroidTextViewENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText(\"\");",
               objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("// {0}", objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objAndroidTextViewENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }

    }
}