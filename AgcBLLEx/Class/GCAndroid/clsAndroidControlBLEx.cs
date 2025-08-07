
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using CommonTable.Entity;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public static class clsAndroidControlBLEx_Static
    {
        public static void GeneCode(this clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    objAndroidEditTextENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    objAndroidTextViewENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidButtonENEx":
                    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                    objAndroidButtonENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidTabHostENEx":
                    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                    objAndroidTabHostENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidLinearLayoutENEx":
                    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                    objAndroidLinearLayoutENEx.GeneCode( strCodeForCs);
                    break;
                case "clsAndroidTabWidgetENEx":
                    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                    objAndroidTabWidgetENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidFrameLayoutENEx":
                    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                    objAndroidFrameLayoutENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidHorizontalScrollViewENEx":
                    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                    objAndroidHorizontalScrollViewENEx.GeneCode(strCodeForCs);
                    break;

                case "clsAndroidConstraintLayoutENEx":
                    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                    objAndroidConstraintLayoutENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidIncludeENEx":
                    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                    objAndroidIncludeENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    objAndroidListViewENEx.GeneCode( strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    objAndroidSpinnerENEx.GeneCode( strCodeForCs);
                    break;
                case "clsAndroidAppBarLayoutENEx":
                    clsAndroidAppBarLayoutENEx objAndroidAppBarLayoutENEx = objAndroidControlENEx as clsAndroidAppBarLayoutENEx;
                    objAndroidAppBarLayoutENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidToolbarENEx":
                    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
                    objAndroidToolbarENEx.GeneCode( strCodeForCs);
                    break;
                case "clsAndroidFloatingActionButtonENEx":
                    clsAndroidFloatingActionButtonENEx objAndroidFloatingActionButtonENEx = objAndroidControlENEx as clsAndroidFloatingActionButtonENEx;
                    objAndroidFloatingActionButtonENEx.GeneCode(strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    objAndroidCheckBoxENEx.GeneCode(strCodeForCs);
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


        public static int getSubObjNumForCtlTypeId(clsAndroidControlENEx objAndroidControlENEx, string strCtlTypeId)
        {
            int intNum = 0;
            foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidControlENEx.arrSubAndroidControlLst2)
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
        public static void GC4Size(clsAndroidControlENEx objAndroidControlENEx,
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
        public static void GC4Style(clsAndroidControlENEx objAndroidControlENEx,
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
        public static void GC4Tag(clsAndroidControlENEx objAndroidControlENEx,
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
        public static void GC4Margin(clsAndroidControlENEx objAndroidControlENEx,
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
        public static void GC4Constraint(clsAndroidControlENEx objAndroidControlENEx,
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
        public static clsAndroidControlENEx GetAndroidControlObjByQryFld(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = new clsAndroidCheckBoxENEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objAndroidCheckBoxENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidCheckBoxENEx;


                case "TextBox":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = new clsAndroidSpinnerENEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static clsAndroidControlENEx GetAndroidControlObjByDGFld(clsDGRegionFldsENEx objDGRegionFldsEx)
        {

            switch (objDGRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = new clsAndroidCheckBoxENEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objAndroidCheckBoxENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objAndroidCheckBoxENEx;

                case "TextBox":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = new clsAndroidSpinnerENEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}_q", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objDGRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }


        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objQryRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static clsAndroidTextViewENEx GetAndroidTextViewObjByQryFld(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objAndroidTextViewENEx.layout_width = "100dp";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidTextViewENEx;


                case "TextBox":
                    clsAndroidTextViewENEx objAndroidTextViewENEx_TextBox = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx_TextBox.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidTextViewENEx_TextBox.layout_width = "100dp";
                    objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
                    objAndroidTextViewENEx_TextBox.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx_TextBox.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidTextViewENEx_TextBox;

                case "DropDownList":
                    clsAndroidTextViewENEx objAndroidTextViewENEx_Spinner = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx_Spinner.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidTextViewENEx_Spinner.layout_width = "100dp";
                    objAndroidTextViewENEx_Spinner.layout_height = "wrap_content";
                    objAndroidTextViewENEx_Spinner.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx_Spinner.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objAndroidTextViewENEx_Spinner;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static clsAndroidTextViewENEx GetAndroidTextViewObjByDGFld(clsDGRegionFldsENEx objDGRegionFldsEx)
        {
            clsAndroidTextViewENEx objAndroidTextViewENEx_TextBox = new clsAndroidTextViewENEx();
            objAndroidTextViewENEx_TextBox.CtrlId = string.Format("tv{0}", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            objAndroidTextViewENEx_TextBox.Style = "tvStyle4ListItem";
            objAndroidTextViewENEx_TextBox.layout_width = "30dp";
            objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
            objAndroidTextViewENEx_TextBox.Text = objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
            objAndroidTextViewENEx_TextBox.objDGRegionFldsENEx = objDGRegionFldsEx;
            return objAndroidTextViewENEx_TextBox;

        }


        /// <summary>
        /// 编辑区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static clsAndroidTextViewENEx GetAndroidTextViewObjByEditFld(clsEditRegionFldsENEx objEditRegionFldsEx)
        {

            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objAndroidTextViewENEx.layout_width = "100dp";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidTextViewENEx;


                case "TextBox":
                    clsAndroidTextViewENEx objAndroidTextViewENEx_TextBox = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx_TextBox.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidTextViewENEx_TextBox.layout_width = "100dp";
                    objAndroidTextViewENEx_TextBox.layout_height = "wrap_content";
                    objAndroidTextViewENEx_TextBox.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx_TextBox.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidTextViewENEx_TextBox;

                case "DropDownList":
                    clsAndroidTextViewENEx objAndroidTextViewENEx_Spinner = new clsAndroidTextViewENEx();
                    objAndroidTextViewENEx_Spinner.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidTextViewENEx_Spinner.layout_width = "100dp";
                    objAndroidTextViewENEx_Spinner.layout_height = "wrap_content";
                    objAndroidTextViewENEx_Spinner.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objAndroidTextViewENEx_Spinner.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidTextViewENEx_Spinner;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 查询区域字段转换成安卓控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">编辑区域字段对象</param>
        /// <returns>转换成的安卓控件</returns>
        public static clsAndroidControlENEx GetAndroidControlObjByEditFld(clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            string strFldName = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = new clsAndroidCheckBoxENEx();
                    objAndroidCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objAndroidCheckBoxENEx.layout_width = "200dp";
                    objAndroidCheckBoxENEx.layout_height = "wrap_content";
                    objAndroidCheckBoxENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldCnName;
                    objAndroidCheckBoxENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidCheckBoxENEx;


                case "TextBox":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidEditTextENEx.layout_width = "200dp";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidEditTextENEx;

                case "DropDownList":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = new clsAndroidSpinnerENEx();
                    objAndroidSpinnerENEx.CtrlId = string.Format("spn{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objAndroidSpinnerENEx.layout_width = "200dp";
                    objAndroidSpinnerENEx.layout_height = "wrap_content";
                    objAndroidSpinnerENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objAndroidSpinnerENEx;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 字段变量定义
        /// </summary>
        /// <param name="objAndroidControlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarDef(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarDef(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "clsAndroidButtonENEx":
                    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                    clsAndroidButtonBLEx.Gen_FieldVarDef(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "clsAndroidTabHostENEx":
                    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarDef(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "clsAndroidLinearLayoutENEx":
                    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarDef(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidTabWidgetENEx":
                    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarDef(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "clsAndroidFrameLayoutENEx":
                    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarDef(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidHorizontalScrollViewENEx":
                    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarDef(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "clsAndroidConstraintLayoutENEx":
                    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarDef(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidIncludeENEx":
                    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarDef(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_FieldVarDef(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarDef(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarDef(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_BindDdl(clsAndroidControlENEx objAndroidControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                
                case "clsAndroidTextViewENEx":
                
                case "clsAndroidButtonENEx":
                
                case "clsAndroidTabHostENEx":
                
                case "clsAndroidLinearLayoutENEx":
                
                case "clsAndroidTabWidgetENEx":
                
                case "clsAndroidFrameLayoutENEx":
                
                case "clsAndroidHorizontalScrollViewENEx":
                
                case "clsAndroidConstraintLayoutENEx":
                   
                case "clsAndroidIncludeENEx":
                   
                case "clsAndroidListViewENEx":
                   
                case "clsAndroidCheckBoxENEx":
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_BindDdl(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;
              
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_BindDdlInTaskQueue(clsAndroidControlENEx objAndroidControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":

                case "clsAndroidTextViewENEx":

                case "clsAndroidButtonENEx":

                case "clsAndroidTabHostENEx":

                case "clsAndroidLinearLayoutENEx":

                case "clsAndroidTabWidgetENEx":

                case "clsAndroidFrameLayoutENEx":

                case "clsAndroidHorizontalScrollViewENEx":

                case "clsAndroidConstraintLayoutENEx":

                case "clsAndroidIncludeENEx":

                case "clsAndroidListViewENEx":

                case "clsAndroidCheckBoxENEx":
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_BindDdlInTaskQueue(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;

                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_DefDdlBindObj(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":

                case "clsAndroidTextViewENEx":

                case "clsAndroidButtonENEx":

                case "clsAndroidTabHostENEx":

                case "clsAndroidLinearLayoutENEx":

                case "clsAndroidTabWidgetENEx":

                case "clsAndroidFrameLayoutENEx":

                case "clsAndroidHorizontalScrollViewENEx":

                case "clsAndroidConstraintLayoutENEx":

                case "clsAndroidIncludeENEx":

                case "clsAndroidListViewENEx":

                case "clsAndroidCheckBoxENEx":
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_DefDdlBindObj(objAndroidSpinnerENEx, strCodeForCs, arrDdlBindObjLst);
                    break;

                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_FieldVarBind(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarBind(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarBind(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "clsAndroidButtonENEx":
                    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                    clsAndroidButtonBLEx.Gen_FieldVarBind(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "clsAndroidTabHostENEx":
                    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarBind(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "clsAndroidLinearLayoutENEx":
                    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarBind(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidTabWidgetENEx":
                    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarBind(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "clsAndroidFrameLayoutENEx":
                    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarBind(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidHorizontalScrollViewENEx":
                    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarBind(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "clsAndroidConstraintLayoutENEx":
                    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarBind(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidIncludeENEx":
                    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarBind(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_FieldVarBind(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarBind(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarBind(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_FieldVarBind4ListView(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_FieldVarBind4ListView(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_FieldVarBind4ListView(objAndroidTextViewENEx, strCodeForCs);
                    break;
                case "clsAndroidButtonENEx":
                    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                    clsAndroidButtonBLEx.Gen_FieldVarBind4ListView(objAndroidButtonENEx, strCodeForCs);
                    break;
                case "clsAndroidTabHostENEx":
                    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                    clsAndroidTabHostBLEx.Gen_FieldVarBind4ListView(objAndroidTabHostENEx, strCodeForCs);
                    break;
                case "clsAndroidLinearLayoutENEx":
                    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                    clsAndroidLinearLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidLinearLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidTabWidgetENEx":
                    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                    clsAndroidTabWidgetBLEx.Gen_FieldVarBind4ListView(objAndroidTabWidgetENEx, strCodeForCs);
                    break;
                case "clsAndroidFrameLayoutENEx":
                    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                    clsAndroidFrameLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidFrameLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidHorizontalScrollViewENEx":
                    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_FieldVarBind4ListView(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                    break;

                case "clsAndroidConstraintLayoutENEx":
                    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                    clsAndroidConstraintLayoutBLEx.Gen_FieldVarBind4ListView(objAndroidConstraintLayoutENEx, strCodeForCs);
                    break;
                case "clsAndroidIncludeENEx":
                    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                    clsAndroidIncludeBLEx.Gen_FieldVarBind4ListView(objAndroidIncludeENEx, strCodeForCs);
                    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_FieldVarBind4ListView(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_FieldVarBind4ListView(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_FieldVarBind4ListView(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_LvFieldAssignment(clsAndroidControlENEx objAndroidControlENEx, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_LvFieldAssignment(objAndroidEditTextENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_LvFieldAssignment(objAndroidTextViewENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidButtonENEx":
                    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                    clsAndroidButtonBLEx.Gen_LvFieldAssignment(objAndroidButtonENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidTabHostENEx":
                    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                    clsAndroidTabHostBLEx.Gen_LvFieldAssignment(objAndroidTabHostENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidLinearLayoutENEx":
                    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                    clsAndroidLinearLayoutBLEx.Gen_LvFieldAssignment(objAndroidLinearLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidTabWidgetENEx":
                    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                    clsAndroidTabWidgetBLEx.Gen_LvFieldAssignment(objAndroidTabWidgetENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidFrameLayoutENEx":
                    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                    clsAndroidFrameLayoutBLEx.Gen_LvFieldAssignment(objAndroidFrameLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidHorizontalScrollViewENEx":
                    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                    clsAndroidHorizontalScrollViewBLEx.Gen_LvFieldAssignment(objAndroidHorizontalScrollViewENEx, objViewInfoENEx, strCodeForCs);
                    break;

                case "clsAndroidConstraintLayoutENEx":
                    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                    clsAndroidConstraintLayoutBLEx.Gen_LvFieldAssignment(objAndroidConstraintLayoutENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_LvFieldAssignment(objAndroidIncludeENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                //case "clsAndroidListViewENEx":
                //    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                //    clsAndroidListViewBLEx.Gen_LvFieldAssignment(objAndroidListViewENEx, objViewInfoENEx, strCodeForCs);
                //    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_LvFieldAssignment(objAndroidSpinnerENEx, objViewInfoENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_LvFieldAssignment(objAndroidCheckBoxENEx, objViewInfoENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_GetValue4FieldCtrl4Edit(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "clsAndroidButtonENEx":
                //    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                //    clsAndroidButtonBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabHostENEx":
                //    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                //    clsAndroidTabHostBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "clsAndroidLinearLayoutENEx":
                //    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                //    clsAndroidLinearLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabWidgetENEx":
                //    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                //    clsAndroidTabWidgetBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "clsAndroidFrameLayoutENEx":
                //    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                //    clsAndroidFrameLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidHorizontalScrollViewENEx":
                //    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "clsAndroidConstraintLayoutENEx":
                //    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_GetValue4FieldCtrl4Qry(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "clsAndroidButtonENEx":
                //    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                //    clsAndroidButtonBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabHostENEx":
                //    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                //    clsAndroidTabHostBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "clsAndroidLinearLayoutENEx":
                //    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                //    clsAndroidLinearLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabWidgetENEx":
                //    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                //    clsAndroidTabWidgetBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "clsAndroidFrameLayoutENEx":
                //    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                //    clsAndroidFrameLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidHorizontalScrollViewENEx":
                //    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "clsAndroidConstraintLayoutENEx":
                //    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_SetValue4FieldCtrl4Edit(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "clsAndroidButtonENEx":
                //    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                //    clsAndroidButtonBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabHostENEx":
                //    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                //    clsAndroidTabHostBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "clsAndroidLinearLayoutENEx":
                //    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                //    clsAndroidLinearLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabWidgetENEx":
                //    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                //    clsAndroidTabWidgetBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "clsAndroidFrameLayoutENEx":
                //    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                //    clsAndroidFrameLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidHorizontalScrollViewENEx":
                //    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "clsAndroidConstraintLayoutENEx":
                //    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_ClearFieldCtrl4Edit(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_ClearFieldCtrl4Edit(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "clsAndroidButtonENEx":
                //    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                //    clsAndroidButtonBLEx.Gen_ClearFieldCtrl4Edit(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabHostENEx":
                //    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                //    clsAndroidTabHostBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "clsAndroidLinearLayoutENEx":
                //    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                //    clsAndroidLinearLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabWidgetENEx":
                //    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                //    clsAndroidTabWidgetBLEx.Gen_ClearFieldCtrl4Edit(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "clsAndroidFrameLayoutENEx":
                //    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                //    clsAndroidFrameLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidHorizontalScrollViewENEx":
                //    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "clsAndroidConstraintLayoutENEx":
                //    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_ClearFieldCtrl4Edit(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_ClearFieldCtrl4Edit(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                //case "clsAndroidListViewENEx":
                //    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                //    clsAndroidListViewBLEx.Gen_ClearFieldCtrl4Edit(objAndroidListViewENEx, strCodeForCs);
                //    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_ClearFieldCtrl4Edit(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_ClearFieldCtrl4Edit(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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
        public static void Gen_SetValue4FieldCtrl4Qry(clsAndroidControlENEx objAndroidControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objAndroidControlENEx.GetType().Name;
            switch (strType)
            {
                case "clsAndroidEditTextENEx":
                    clsAndroidEditTextENEx objAndroidEditTextENEx = objAndroidControlENEx as clsAndroidEditTextENEx;
                    clsAndroidEditTextBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidEditTextENEx, strCodeForCs);
                    break;
                case "clsAndroidTextViewENEx":
                    clsAndroidTextViewENEx objAndroidTextViewENEx = objAndroidControlENEx as clsAndroidTextViewENEx;
                    clsAndroidTextViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTextViewENEx, strCodeForCs);
                    break;
                //case "clsAndroidButtonENEx":
                //    clsAndroidButtonENEx objAndroidButtonENEx = objAndroidControlENEx as clsAndroidButtonENEx;
                //    clsAndroidButtonBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidButtonENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabHostENEx":
                //    clsAndroidTabHostENEx objAndroidTabHostENEx = objAndroidControlENEx as clsAndroidTabHostENEx;
                //    clsAndroidTabHostBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTabHostENEx, strCodeForCs);
                //    break;
                //case "clsAndroidLinearLayoutENEx":
                //    clsAndroidLinearLayoutENEx objAndroidLinearLayoutENEx = objAndroidControlENEx as clsAndroidLinearLayoutENEx;
                //    clsAndroidLinearLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidLinearLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidTabWidgetENEx":
                //    clsAndroidTabWidgetENEx objAndroidTabWidgetENEx = objAndroidControlENEx as clsAndroidTabWidgetENEx;
                //    clsAndroidTabWidgetBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidTabWidgetENEx, strCodeForCs);
                //    break;
                //case "clsAndroidFrameLayoutENEx":
                //    clsAndroidFrameLayoutENEx objAndroidFrameLayoutENEx = objAndroidControlENEx as clsAndroidFrameLayoutENEx;
                //    clsAndroidFrameLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidFrameLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidHorizontalScrollViewENEx":
                //    clsAndroidHorizontalScrollViewENEx objAndroidHorizontalScrollViewENEx = objAndroidControlENEx as clsAndroidHorizontalScrollViewENEx;
                //    clsAndroidHorizontalScrollViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidHorizontalScrollViewENEx, strCodeForCs);
                //    break;

                //case "clsAndroidConstraintLayoutENEx":
                //    clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = objAndroidControlENEx as clsAndroidConstraintLayoutENEx;
                //    clsAndroidConstraintLayoutBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidConstraintLayoutENEx, strCodeForCs);
                //    break;
                //case "clsAndroidIncludeENEx":
                //    clsAndroidIncludeENEx objAndroidIncludeENEx = objAndroidControlENEx as clsAndroidIncludeENEx;
                //    clsAndroidIncludeBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidIncludeENEx, strCodeForCs);
                //    break;
                case "clsAndroidListViewENEx":
                    clsAndroidListViewENEx objAndroidListViewENEx = objAndroidControlENEx as clsAndroidListViewENEx;
                    clsAndroidListViewBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidListViewENEx, strCodeForCs);
                    break;
                case "clsAndroidSpinnerENEx":
                    clsAndroidSpinnerENEx objAndroidSpinnerENEx = objAndroidControlENEx as clsAndroidSpinnerENEx;
                    clsAndroidSpinnerBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidSpinnerENEx, strCodeForCs);
                    break;
                case "clsAndroidCheckBoxENEx":
                    clsAndroidCheckBoxENEx objAndroidCheckBoxENEx = objAndroidControlENEx as clsAndroidCheckBoxENEx;
                    clsAndroidCheckBoxBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidCheckBoxENEx, strCodeForCs);
                    break;
                //case "clsAndroidToolbarENEx":
                //    clsAndroidToolbarENEx objAndroidToolbarENEx = objAndroidControlENEx as clsAndroidToolbarENEx;
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