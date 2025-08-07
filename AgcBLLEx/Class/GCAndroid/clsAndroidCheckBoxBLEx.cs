
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidCheckBoxBLEx
表名:AndroidCheckBox
生成代码版本:2018.03.11.1
生成日期:2018/03/13 12:01:55
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
    public static class clsAndroidCheckBoxBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidCheckBoxENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidCheckBoxENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<CheckBox");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidCheckBoxENEx.CtrlId);

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidCheckBoxENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidCheckBoxENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidCheckBoxENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidCheckBoxENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objAndroidCheckBoxENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objAndroidCheckBoxENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidCheckBoxENEx.Text);
            if (string.IsNullOrEmpty(objAndroidCheckBoxENEx.scaleX) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scaleX=\"{0}\"",
                    objAndroidCheckBoxENEx.scaleX);
            }
            if (string.IsNullOrEmpty(objAndroidCheckBoxENEx.scaleY) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scaleY=\"{0}\"",
                    objAndroidCheckBoxENEx.scaleY);
            }
            //if (objAndroidCheckBoxENEx.ems > 0)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
            //        objAndroidCheckBoxENEx.ems);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidCheckBoxENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidCheckBoxENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}
        }
    }
        /// <summary>
        /// Android复选框(AndroidCheckBox)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidCheckBoxBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private CheckBox {0};",
                objAndroidCheckBoxENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (CheckBox)findViewById(R.id.{0}); ",
                objAndroidCheckBoxENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (CheckBox)view.findViewById(R.id.{0}); ",
                objAndroidCheckBoxENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            //strCodeForCs.AppendFormat("\r\n return {0}.getText().toString();", objAndroidCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n return {0}.isChecked();", objAndroidCheckBoxENEx.CtrlId);
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
               objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", 
                objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
            strCodeForCs.Append("\r\n {");
            //            strCodeForCs.AppendFormat("\r\n return {0}.getText().toString();", objAndroidCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n return {0}.isChecked();", objAndroidCheckBoxENEx.CtrlId);
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
              objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setChecked({1});", objAndroidCheckBoxENEx.CtrlId, "value");

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;           
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setChecked({1});",
    objAndroidCheckBoxENEx.CtrlId, "value");

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.setChecked(obj{0}EN.get{2}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidCheckBoxENEx.CtrlId, objAndroidCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objAndroidCheckBoxENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(clsAndroidCheckBoxENEx objAndroidCheckBoxENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setChecked(false);",
               objAndroidCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objAndroidCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }
    }
}