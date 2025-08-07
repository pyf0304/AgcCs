
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidListViewBLEx
表名:AndroidListView
生成代码版本:2018.03.11.1
生成日期:2018/03/13 00:17:20
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

namespace AGC.PureClassEx
{
    public static class clsAndroidListViewBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidListViewENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidListViewEx objAndroidListViewENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidListViewENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidListViewENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<ListView");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidListViewENEx.CtrlId);
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidListViewENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidListViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidListViewENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidListViewENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objAndroidListViewENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objAndroidListViewENEx.orientation);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidListViewENEx, strCodeForCs);
            if (objAndroidListViewENEx.arrSubAndroidControlLst2.Count == 0)
            {
                strCodeForCs.AppendFormat("/>");
            }
            else
            {
                strCodeForCs.AppendFormat(">");

                foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidListViewENEx.arrSubAndroidControlLst2)
                {
                    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlType.AndroidAutoresizingMask) continue;
                    objSubAndroidControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }
                strCodeForCs.AppendFormat("\r\n" + "</ListView>");
            }
        }
    }
        /// <summary>
        /// Android列表(AndroidListView)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidListViewBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private ListView {0};",
                objAndroidListViewENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ListView)findViewById(R.id.{0}); ",
                objAndroidListViewENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (ListView)view.findViewById(R.id.{0}); ",
                objAndroidListViewENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}.getText().toString()", objAndroidListViewENEx.CtrlId)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}.getText().toString()", objAndroidListViewENEx.CtrlId)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidListViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objAndroidListViewENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidListViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(AndroidListViewEx objAndroidListViewENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objAndroidListViewENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidListViewENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

    }
}