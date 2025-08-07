
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidHorizontalScrollViewBLEx
表名:AndroidHorizontalScrollView
生成代码版本:2018.02.11.1
生成日期:2018/02/28 17:13:58
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
    public static class clsAndroidHorizontalScrollViewBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidHorizontalScrollViewENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx, enumApplicationType intApplicationTypeId,
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

            strCodeForCs.AppendFormat("\r\n" + "<HorizontalScrollView");
            if (string.IsNullOrEmpty(objAndroidHorizontalScrollViewENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                    objAndroidHorizontalScrollViewENEx.CtrlId);
            }
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidHorizontalScrollViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidHorizontalScrollViewENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidHorizontalScrollViewENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objAndroidHorizontalScrollViewENEx.scrollbars) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scrollbars=\"{0}\"",
                        objAndroidHorizontalScrollViewENEx.scrollbars);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidHorizontalScrollViewENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidHorizontalScrollViewENEx.arrSubAndroidControlLst2)
            {
                objSubAndroidControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</HorizontalScrollView>");

        }
    }
        /// <summary>
        /// Android水平滚动视图(AndroidHorizontalScrollView)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidHorizontalScrollViewBLEx 
    {

             

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidHorizontalScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private HorizontalScrollView {0};",
                objAndroidHorizontalScrollViewENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidHorizontalScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (HorizontalScrollView)findViewById(R.id.{0}); ",
                objAndroidHorizontalScrollViewENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidHorizontalScrollViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "hsv{0} = (HorizontalScrollView)view.findViewById(R.id.hsv{0}); ",
                objAndroidHorizontalScrollViewENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidHorizontalScrollViewENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidHorizontalScrollViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidHorizontalScrollViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objAndroidHorizontalScrollViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidHorizontalScrollViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objAndroidHorizontalScrollViewENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }
    }
}