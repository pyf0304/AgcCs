
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidControlBLEx
表名:AndroidControl
生成代码版本:2018.02.11.1
生成日期:2018/02/17 10:21:27
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsAndroidControlBLEx_Static
    {
        public static void GeneCode(this AndroidControlEx objAndroidControlENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    objAndroidEditTextENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    objAndroidTextViewENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidButtonEx":
                    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                    objAndroidButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidTabHostEx":
                    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                    objAndroidTabHostENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidLinearLayoutEx":
                    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                    objAndroidLinearLayoutENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidTabWidgetEx":
                    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                    objAndroidTabWidgetENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidFrameLayoutEx":
                    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                    objAndroidFrameLayoutENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidHorizontalScrollViewEx":
                    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                    objAndroidHorizontalScrollViewENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;

                case "AndroidConstraintLayoutEx":
                    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                    objAndroidConstraintLayoutENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidIncludeEx":
                    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                    objAndroidIncludeENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    objAndroidListViewENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    objAndroidSpinnerENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidAppBarLayoutEx":
                    AndroidAppBarLayoutEx objAndroidAppBarLayoutENEx = objAndroidControlENEx as AndroidAppBarLayoutEx;
                    objAndroidAppBarLayoutENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidToolbarEx":
                    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                    objAndroidToolbarENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidFloatingActionButtonEx":
                    AndroidFloatingActionButtonEx objAndroidFloatingActionButtonENEx = objAndroidControlENEx as AndroidFloatingActionButtonEx;
                    objAndroidFloatingActionButtonENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    objAndroidCheckBoxENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

    }
    /// <summary>
    /// Android控件(AndroidControl)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsAndroidControlBLEx 
    {       

        public static int getSubObjNumForCtlTypeId(AndroidControlEx objAndroidControlENEx, string strCtlTypeId)
        {
            int intNum = 0;
            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidControlENEx.arrSubAndroidControlLst2)
            {
                if (objSubAndroidControlENEx.CtlTypeId == strCtlTypeId) intNum++;

            }
            return intNum;
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objAndroidControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Size(AndroidControlEx objAndroidControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_width) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_width=\"{0}\"",
                objAndroidControlENEx.layout_width);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_height) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_height=\"{0}\"",
                objAndroidControlENEx.layout_height);
            }
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objAndroidControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Style(AndroidControlEx objAndroidControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objAndroidControlENEx.Style) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "style=\"@style/{0}\"",
                    objAndroidControlENEx.Style);
            }
        }
        /// <summary>
        /// 生成该对象尺寸相关的代码
        /// </summary>
        /// <param name="objAndroidControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Tag(AndroidControlEx objAndroidControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objAndroidControlENEx.Tag) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:tag=\"{0}\"",
                objAndroidControlENEx.Tag);
            }
        }
        /// <summary>
        /// 生成该对象边界相关的代码
        /// </summary>
        /// <param name="objAndroidControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Margin(AndroidControlEx objAndroidControlENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidControlENEx.layout_marginLeft > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_marginLeft=\"{0}dp\"",
                    objAndroidControlENEx.layout_marginLeft);
            }
            if (objAndroidControlENEx.layout_marginTop > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_marginTop=\"{0}dp\"",
                    objAndroidControlENEx.layout_marginTop);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_margin) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_margin=\"{0}\" ",
                    objAndroidControlENEx.layout_margin);
            }
        }
        /// <summary>
        /// 生成该对象约束相关的代码
        /// </summary>
        /// <param name="objAndroidControlENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GC4Constraint(AndroidControlEx objAndroidControlENEx,
            StringBuilder strCodeForCs)
        {
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_constraintStart_toStartOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintStart_toStartOf=\"{0}\"",
                    objAndroidControlENEx.layout_constraintStart_toStartOf);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_constraintLeft_toLeftOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintLeft_toLeftOf=\"{0}\" ",
                    objAndroidControlENEx.layout_constraintLeft_toLeftOf);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_constraintLeft_toRightOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintLeft_toRightOf=\"{0}\" ",
                    objAndroidControlENEx.layout_constraintLeft_toRightOf);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_constraintTop_toBottomOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintTop_toBottomOf=\"{0}\" ",
                    objAndroidControlENEx.layout_constraintTop_toBottomOf);
            }
            if (string.IsNullOrEmpty(objAndroidControlENEx.layout_constraintTop_toTopOf) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:layout_constraintTop_toTopOf=\"{0}\" ",
                    objAndroidControlENEx.layout_constraintTop_toTopOf);
            }
           
           
        }
        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objQryRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static AndroidControlEx GetAndroidControlObjByQryFld(clsQryRegionFldsEN objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = new AndroidCheckBoxEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objQryRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objAndroidCheckBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidCheckBoxENEx;


                case "TextBox":
                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    AndroidSpinnerEx objAndroidSpinnerENEx = new AndroidSpinnerEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static AndroidControlEx GetAndroidControlObjByDGFld(clsDGRegionFldsEN objDGRegionFldsEx)
        {

            switch (objDGRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = new AndroidCheckBoxEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objDGRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objAndroidCheckBoxENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objAndroidCheckBoxENEx;

                case "TextBox":
                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    AndroidSpinnerEx objAndroidSpinnerENEx = new AndroidSpinnerEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}_q", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objDGRegionFldsEN = objDGRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objDGRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }


        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objQryRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static AndroidTextViewEx GetAndroidTextViewObjByQryFld(clsQryRegionFldsEN objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);

                    objAndroidTextViewENEx.layout_width = "100dp";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.Text = objQryRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidTextViewENEx;


                case "TextBox":
                    AndroidTextViewEx objAndroidTextViewENEx_TextBox = new AndroidTextViewEx();
                    objAndroidTextViewENEx_TextBox.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidTextViewENEx_TextBox.layout_width = "100dp";
                    objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
                    objAndroidTextViewENEx_TextBox.Text = objQryRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx_TextBox.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidTextViewENEx_TextBox;

                case "DropDownList":
                    AndroidTextViewEx objAndroidTextViewENEx_Spinner = new AndroidTextViewEx();
                    objAndroidTextViewENEx_Spinner.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidTextViewENEx_Spinner.layout_width = "100dp";
                    objAndroidTextViewENEx_Spinner.layout_height = "wrap_content";
                    objAndroidTextViewENEx_Spinner.Text = objQryRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx_Spinner.objQryRegionFldsEN = objQryRegionFldsEx;
                    return objAndroidTextViewENEx_Spinner;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static AndroidTextViewEx GetAndroidTextViewObjByDGFld(clsDGRegionFldsEN objDGRegionFldsEx)
        {
            AndroidTextViewEx objAndroidTextViewENEx_TextBox = new AndroidTextViewEx();
            objAndroidTextViewENEx_TextBox.CtrlId = string.Format("tv{0}", objDGRegionFldsEx.ObjFieldTab_PC().FldName);
            objAndroidTextViewENEx_TextBox.Style = "tvStyle4ListItem";
            objAndroidTextViewENEx_TextBox.layout_width = "30dp";
            objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
            objAndroidTextViewENEx_TextBox.Text = objDGRegionFldsEx.ObjFieldTab_PC().Caption;
            objAndroidTextViewENEx_TextBox.objDGRegionFldsEN = objDGRegionFldsEx;
            return objAndroidTextViewENEx_TextBox;

        }


        /// <summary>
        /// 编辑区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static AndroidTextViewEx GetAndroidTextViewObjByEditFld(clsEditRegionFldsEN objEditRegionFldsEx)
        {

            switch (objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);

                    objAndroidTextViewENEx.layout_width = "100dp";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.Text = objEditRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidTextViewENEx;


                case "TextBox":
                    AndroidTextViewEx objAndroidTextViewENEx_TextBox = new AndroidTextViewEx();
                    objAndroidTextViewENEx_TextBox.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidTextViewENEx_TextBox.layout_width = "100dp";
                    objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
                    objAndroidTextViewENEx_TextBox.Text = objEditRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx_TextBox.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidTextViewENEx_TextBox;

                case "DropDownList":
                    AndroidTextViewEx objAndroidTextViewENEx_Spinner = new AndroidTextViewEx();
                    objAndroidTextViewENEx_Spinner.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidTextViewENEx_Spinner.layout_width = "100dp";
                    objAndroidTextViewENEx_Spinner.layout_height = "wrap_content";
                    objAndroidTextViewENEx_Spinner.Text = objEditRegionFldsEx.LabelCaption;
                    objAndroidTextViewENEx_Spinner.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidTextViewENEx_Spinner;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">编辑区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static AndroidControlEx GetAndroidControlObjByEditFld(clsEditRegionFldsEN objEditRegionFldsEx)
        {
            string strFldName = objEditRegionFldsEx.ObjFieldTab_PC().FldName;
            switch (objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName)
            {
                case "CheckBox":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = new AndroidCheckBoxEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objEditRegionFldsEx.ObjFieldTab_PC().FldCnName;
                    objAndroidCheckBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidCheckBoxENEx;


                case "TextBox":
                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    AndroidSpinnerEx objAndroidSpinnerENEx = new AndroidSpinnerEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}", objEditRegionFldsEx.ObjFieldTab_PC().FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarDef(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarDef(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "AndroidButtonEx":
                    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                    clsAndroidButtonBLEx.Gen_FieldVarDef(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "AndroidTabHostEx":
                    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarDef(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "AndroidLinearLayoutEx":
                    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarDef(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "AndroidTabWidgetEx":
                    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarDef(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "AndroidFrameLayoutEx":
                    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarDef(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "AndroidHorizontalScrollViewEx":
                    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarDef(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "AndroidConstraintLayoutEx":
                    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarDef(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "AndroidIncludeEx":
                    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarDef(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_FieldVarDef(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarDef(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarDef(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_FieldVarDef(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_FieldVarDef(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(AndroidControlEx objAndroidControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                
                case "AndroidTextViewEx":
                
                case "AndroidButtonEx":
                
                case "AndroidTabHostEx":
                
                case "AndroidLinearLayoutEx":
                
                case "AndroidTabWidgetEx":
                
                case "AndroidFrameLayoutEx":
                
                case "AndroidHorizontalScrollViewEx":
                
                case "AndroidConstraintLayoutEx":
                   
                case "AndroidIncludeEx":
                   
                case "AndroidListViewEx":
                   
                case "AndroidCheckBoxEx":
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_BindDdl(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;
              
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_BindDdl(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_BindDdl(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }



        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(AndroidControlEx objAndroidControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":

                case "AndroidTextViewEx":

                case "AndroidButtonEx":

                case "AndroidTabHostEx":

                case "AndroidLinearLayoutEx":

                case "AndroidTabWidgetEx":

                case "AndroidFrameLayoutEx":

                case "AndroidHorizontalScrollViewEx":

                case "AndroidConstraintLayoutEx":

                case "AndroidIncludeEx":

                case "AndroidListViewEx":

                case "AndroidCheckBoxEx":
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_BindDdlInTaskQueue(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;

                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_BindDdl(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_BindDdl(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_DefDdlBindObj(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":

                case "AndroidTextViewEx":

                case "AndroidButtonEx":

                case "AndroidTabHostEx":

                case "AndroidLinearLayoutEx":

                case "AndroidTabWidgetEx":

                case "AndroidFrameLayoutEx":

                case "AndroidHorizontalScrollViewEx":

                case "AndroidConstraintLayoutEx":

                case "AndroidIncludeEx":

                case "AndroidListViewEx":

                case "AndroidCheckBoxEx":
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_DefDdlBindObj(objAndroidSpinnerENEx, strCodeForCs, arrDdlBindObjLst);
                    break;

                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_DefDdlBindObj(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_DefDdlBindObj(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }
        
        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarBind(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarBind(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "AndroidButtonEx":
                    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                    clsAndroidButtonBLEx.Gen_FieldVarBind(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "AndroidTabHostEx":
                    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarBind(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "AndroidLinearLayoutEx":
                    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarBind(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "AndroidTabWidgetEx":
                    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarBind(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "AndroidFrameLayoutEx":
                    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarBind(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "AndroidHorizontalScrollViewEx":
                    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarBind(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "AndroidConstraintLayoutEx":
                    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarBind(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "AndroidIncludeEx":
                    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarBind(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_FieldVarBind(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarBind(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarBind(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_FieldVarBind(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_FieldVarBind(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarBind4ListView(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarBind4ListView(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "AndroidButtonEx":
                    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                    clsAndroidButtonBLEx.Gen_FieldVarBind4ListView(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "AndroidTabHostEx":
                    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarBind4ListView(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "AndroidLinearLayoutEx":
                    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "AndroidTabWidgetEx":
                    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarBind4ListView(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "AndroidFrameLayoutEx":
                    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "AndroidHorizontalScrollViewEx":
                    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarBind4ListView(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "AndroidConstraintLayoutEx":
                    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "AndroidIncludeEx":
                    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarBind4ListView(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_FieldVarBind4ListView(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarBind4ListView(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarBind4ListView(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_FieldVarBind4ListView(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_FieldVarBind4ListView(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 字段变量绑定
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidControlEx objAndroidControlENEx, clsViewInfoEN objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_LvFieldAssignment(objAndroidEditTextENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_LvFieldAssignment(objAndroidTextViewENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidButtonEx":
                    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                    clsAndroidButtonBLEx.Gen_LvFieldAssignment(objAndroidButtonENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidTabHostEx":
                    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                    clsAndroidTabHostBLEx.Gen_LvFieldAssignment(objAndroidTabHostENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidLinearLayoutEx":
                    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                    clsAndroidLinearLayoutBLEx.Gen_LvFieldAssignment(objAndroidLinearLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidTabWidgetEx":
                    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                    clsAndroidTabWidgetBLEx.Gen_LvFieldAssignment(objAndroidTabWidgetENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidFrameLayoutEx":
                    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                    clsAndroidFrameLayoutBLEx.Gen_LvFieldAssignment(objAndroidFrameLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidHorizontalScrollViewEx":
                    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_LvFieldAssignment(objAndroidHorizontalScrollViewENEx, objViewInfoENEx, strCodeForCs);
                    break;

                case "AndroidConstraintLayoutEx":
                    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                    clsAndroidConstraintLayoutBLEx.Gen_LvFieldAssignment(objAndroidConstraintLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_LvFieldAssignment(objAndroidIncludeENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                //case "AndroidListViewEx":
                //    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                //    clsAndroidListViewBLEx.Gen_LvFieldAssignment(objAndroidListViewENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_LvFieldAssignment(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_LvFieldAssignment(objAndroidCheckBoxENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_LvFieldAssignment(objAndroidToolbarENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_LvFieldAssignment(objAndroidAutoresizingMaskENEx, objViewInfoENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }
        
        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "AndroidButtonEx":
                //    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                //    clsAndroidButtonBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "AndroidTabHostEx":
                //    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                //    clsAndroidTabHostBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "AndroidLinearLayoutEx":
                //    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                //    clsAndroidLinearLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidTabWidgetEx":
                //    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                //    clsAndroidTabWidgetBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "AndroidFrameLayoutEx":
                //    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                //    clsAndroidFrameLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidHorizontalScrollViewEx":
                //    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "AndroidConstraintLayoutEx":
                //    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "AndroidButtonEx":
                //    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                //    clsAndroidButtonBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "AndroidTabHostEx":
                //    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                //    clsAndroidTabHostBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "AndroidLinearLayoutEx":
                //    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                //    clsAndroidLinearLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidTabWidgetEx":
                //    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                //    clsAndroidTabWidgetBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "AndroidFrameLayoutEx":
                //    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                //    clsAndroidFrameLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidHorizontalScrollViewEx":
                //    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "AndroidConstraintLayoutEx":
                //    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "AndroidButtonEx":
                //    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                //    clsAndroidButtonBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "AndroidTabHostEx":
                //    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                //    clsAndroidTabHostBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "AndroidLinearLayoutEx":
                //    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                //    clsAndroidLinearLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidTabWidgetEx":
                //    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                //    clsAndroidTabWidgetBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "AndroidFrameLayoutEx":
                //    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                //    clsAndroidFrameLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidHorizontalScrollViewEx":
                //    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "AndroidConstraintLayoutEx":
                //    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_ClearFieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs, strCmPrjId);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs, strCmPrjId);
                    break;
                //case "AndroidButtonEx":
                //    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                //    clsAndroidButtonBLEx.Gen_ClearFieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "AndroidTabHostEx":
                //    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                //    clsAndroidTabHostBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "AndroidLinearLayoutEx":
                //    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                //    clsAndroidLinearLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidTabWidgetEx":
                //    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                //    clsAndroidTabWidgetBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "AndroidFrameLayoutEx":
                //    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                //    clsAndroidFrameLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidHorizontalScrollViewEx":
                //    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "AndroidConstraintLayoutEx":
                //    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_ClearFieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                //case "AndroidListViewEx":
                //    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                //    clsAndroidListViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                //    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_ClearFieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs, strCmPrjId);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_ClearFieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs, strCmPrjId);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_ClearFieldCtrl4Edit(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_ClearFieldCtrl4Edit(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(AndroidControlEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "AndroidEditTextEx":
                    AndroidEditTextEx objAndroidEditTextENEx = objAndroidControlENEx as AndroidEditTextEx;
                    clsAndroidEditTextBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "AndroidTextViewEx":
                    AndroidTextViewEx objAndroidTextViewENEx = objAndroidControlENEx as AndroidTextViewEx;
                    clsAndroidTextViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "AndroidButtonEx":
                //    AndroidButtonEx objAndroidButtonENEx = objAndroidControlENEx as AndroidButtonEx;
                //    clsAndroidButtonBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "AndroidTabHostEx":
                //    AndroidTabHostEx objAndroidTabHostENEx = objAndroidControlENEx as AndroidTabHostEx;
                //    clsAndroidTabHostBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "AndroidLinearLayoutEx":
                //    AndroidLinearLayoutEx objAndroidLinearLayoutENEx = objAndroidControlENEx as AndroidLinearLayoutEx;
                //    clsAndroidLinearLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidTabWidgetEx":
                //    AndroidTabWidgetEx objAndroidTabWidgetENEx = objAndroidControlENEx as AndroidTabWidgetEx;
                //    clsAndroidTabWidgetBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "AndroidFrameLayoutEx":
                //    AndroidFrameLayoutEx objAndroidFrameLayoutENEx = objAndroidControlENEx as AndroidFrameLayoutEx;
                //    clsAndroidFrameLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidHorizontalScrollViewEx":
                //    AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as AndroidHorizontalScrollViewEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "AndroidConstraintLayoutEx":
                //    AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as AndroidConstraintLayoutEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "AndroidIncludeEx":
                //    AndroidIncludeEx objAndroidIncludeENEx = objAndroidControlENEx as AndroidIncludeEx;
                //    clsAndroidIncludeBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "AndroidListViewEx":
                    AndroidListViewEx objAndroidListViewENEx = objAndroidControlENEx as AndroidListViewEx;
                    clsAndroidListViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "AndroidSpinnerEx":
                    AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidSpinnerEx;
                    clsAndroidSpinnerBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "AndroidCheckBoxEx":
                    AndroidCheckBoxEx objAndroidCheckBoxENEx = objAndroidControlENEx as AndroidCheckBoxEx;
                    clsAndroidCheckBoxBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "AndroidToolbarEx":
                //    AndroidToolbarEx objAndroidToolbarENEx = objAndroidControlENEx as AndroidToolbarEx;
                //    clsAndroidToolbarBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidToolbarENEx, strCodeForCs);
                //    break;
                //case "clsAndroidAutoresizingMaskENEx":
                //    clsAndroidAutoresizingMaskENEx objAndroidAutoresizingMaskENEx = objAndroidControlENEx as clsAndroidAutoresizingMaskENEx;
                //    clsAndroidAutoresizingMaskBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidAutoresizingMaskENEx, strCodeForCs);
                //    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }


    }
}