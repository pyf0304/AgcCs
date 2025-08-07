
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidConstraintLayoutBLEx
表名:AndroidConstraintLayout
生成代码版本:2018.02.11.1
生成日期:2018/02/25 16:22:39
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
    public static class clsAndroidConstraintLayoutBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidConstraintLayoutENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();

            strCodeForCs.AppendFormat("\r\n" + "<android.support.constraint.ConstraintLayout ");
            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                          objAndroidConstraintLayoutENEx.CtrlId);
            }

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidConstraintLayoutENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.android) == false)
            {
                //   strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"http://schemas.android.com/apk/res/android\"");
                strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"{0}\"",
                    objAndroidConstraintLayoutENEx.android);
            }
            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.app) == false)
            {
                //      strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"{0}\"",
                    objAndroidConstraintLayoutENEx.app);
            }
            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.tools) == false)
            {
                //  strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"{0}\"",
                    objAndroidConstraintLayoutENEx.tools);
            }
            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidConstraintLayoutENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidConstraintLayoutENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.layout_behavior) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    app:layout_behavior=\"@string/appbar_scrolling_view_behavior\"");
            }
            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.context) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:context=\"{0}\"",
                    objAndroidConstraintLayoutENEx.context);
            }
            if (string.IsNullOrEmpty(objAndroidConstraintLayoutENEx.showIn) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:showIn=\"{0}\"",
                    objAndroidConstraintLayoutENEx.showIn);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidConstraintLayoutENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");


            foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.constraint.ConstraintLayout>");
        }
    }

        /// <summary>
        /// Android约束布局(AndroidConstraintLayout)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidConstraintLayoutBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidConstraintLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private ConstraintLayout {0};",
                objAndroidConstraintLayoutENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidConstraintLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ConstraintLayout)findViewById(R.id.{0}); ",
                objAndroidConstraintLayoutENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidConstraintLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ConstraintLayout)view.findViewById(R.id.{0}); ",
                objAndroidConstraintLayoutENEx.CtrlId);

        }


        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidConstraintLayoutENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidConstraintLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidConstraintLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidConstraintLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidConstraintLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidConstraintLayoutENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }

    }
}