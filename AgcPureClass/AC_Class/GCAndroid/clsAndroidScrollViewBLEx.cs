
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidScrollViewBLEx
表名:AndroidScrollView
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
    public static class clsAndroidScrollViewBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidScrollViewENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidScrollViewEx objAndroidScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();

            strCodeForCs.AppendFormat("\r\n" + "<android.support.constraint.ScrollView ");
            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                          objAndroidScrollViewENEx.CtrlId);
            }

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidScrollViewENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.android) == false)
            {
                //   strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"http://schemas.android.com/apk/res/android\"");
                strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"{0}\"",
                    objAndroidScrollViewENEx.android);
            }
            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.app) == false)
            {
                //      strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"{0}\"",
                    objAndroidScrollViewENEx.app);
            }
            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.tools) == false)
            {
                //  strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"{0}\"",
                    objAndroidScrollViewENEx.tools);
            }
            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidScrollViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidScrollViewENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.layout_behavior) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    app:layout_behavior=\"@string/appbar_scrolling_view_behavior\"");
            }
            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.context) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:context=\"{0}\"",
                    objAndroidScrollViewENEx.context);
            }
            if (string.IsNullOrEmpty(objAndroidScrollViewENEx.showIn) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:showIn=\"{0}\"",
                    objAndroidScrollViewENEx.showIn);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidScrollViewENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");


            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidScrollViewENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.constraint.ScrollView>");
        }
    }
        /// <summary>
        /// Android约束布局(AndroidScrollView)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidScrollViewBLEx 
    {
               
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidScrollViewEx objAndroidScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private ScrollView {0};",
                objAndroidScrollViewENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidScrollViewEx objAndroidScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ScrollView)findViewById(R.id.{0}); ",
                objAndroidScrollViewENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidScrollViewEx objAndroidScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ScrollView)view.findViewById(R.id.{0}); ",
                objAndroidScrollViewENEx.CtrlId);

        }


        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidScrollViewENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidScrollViewEx objAndroidScrollViewENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidScrollViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidScrollViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidScrollViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidScrollViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidScrollViewENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }

    }
}