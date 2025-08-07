
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidSpinnerBLEx
表名:AndroidSpinner
生成代码版本:2018.03.11.1
生成日期:2018/03/13 12:01:52
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
    public static class clsAndroidSpinnerBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidSpinnerENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidSpinnerENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidSpinnerENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<Spinner");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidSpinnerENEx.CtrlId);
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidSpinnerENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objAndroidSpinnerENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objAndroidSpinnerENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidSpinnerENEx.Text);
            if (string.IsNullOrEmpty(objAndroidSpinnerENEx.entries) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                    objAndroidSpinnerENEx.entries);
            }
            //if (objAndroidSpinnerENEx.ems > 0)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
            //        objAndroidSpinnerENEx.ems);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidSpinnerENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidSpinnerENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}


        }
    }
        /// <summary>
        /// Android下拉框(AndroidSpinner)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidSpinnerBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Spinner {0};",
                objAndroidSpinnerENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Spinner)findViewById(R.id.{0}); ",
                objAndroidSpinnerENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Spinner)view.findViewById(R.id.{0}); ",
                objAndroidSpinnerENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            string strDdlTabName = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                             objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                             strDdlTabName,
                             objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                         objAndroidSpinnerENEx.CtrlId);

            //strCodeForCs.AppendFormat("\r\n" + "String {0} = (String){1}.getSelectedItem();",
            //  objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
            //  objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
              objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}", objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName)));


            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            string strDdlTabName = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            //String strCollegeId = mobjddlBindCollege.getDdlAdapterCollege().getCollegeId((int)spnCollegeId.getSelectedItemId());

            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                                objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                strDdlTabName,
                                objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName,
                            objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
                objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}", objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
           
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
                objAndroidSpinnerENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(clsAndroidSpinnerENEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
 objAndroidSpinnerENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(clsAndroidSpinnerENEx objAndroidSpinnerENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidSpinnerENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlBak20180403(clsAndroidSpinnerENEx objAndroidSpinnerENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl_{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }
            if (objAndroidSpinnerENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl_{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }

        }

        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(clsAndroidSpinnerENEx objAndroidSpinnerENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl_{0}\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.CtrlId);

            }
            if (objAndroidSpinnerENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                
                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl_{0}_q\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.CtrlId);

            }

        }

        /// <summary>
        /// 绑定下拉框, 在任务队列中 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(clsAndroidSpinnerENEx objAndroidSpinnerENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strValueFld = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTab_Code;
                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl_{0}\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0} = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);                
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}.BindDdl_{1}(myTask.getSpinner(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }
            if (objAndroidSpinnerENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strValueFld = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTab_Code;

                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl_{0}_q\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0}_q = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}_q.BindDdl_{1}(myTask.getSpinner(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }

        }


        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>        
        /// <param name="strCodeForCs"></param>
        /// <param name="arrDdlBindObjLst"></param>
        public static void Gen_DefDdlBindObj(clsAndroidSpinnerENEx objAndroidSpinnerENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }
            if (objAndroidSpinnerENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }

        }


        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(clsAndroidSpinnerENEx objAndroidSpinnerENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setSelection(0);",
               objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objAndroidSpinnerENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }
    }
}