
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidCoordinatorLayoutBLEx
表名:AndroidCoordinatorLayout
生成代码版本:2018.03.19.1
生成日期:2018/03/27 14:02:30
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
    public static class clsAndroidCoordinatorLayoutBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidCoordinatorLayoutENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidCoordinatorLayoutEx objAndroidCoordinatorLayoutENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidCoordinatorLayoutENEx.mKey);
            }
            //        < android.support.design.widget.CoordinatorLayout xmlns: android = "http://schemas.android.com/apk/res/android"
            //xmlns: app = "http://schemas.android.com/apk/res-auto"
            //xmlns: tools = "http://schemas.android.com/tools"
            //android: layout_width = "match_parent"
            //android: layout_height = "match_parent"
            //tools: context = "com.taishsoft.simpleprj.L7_UI.BaseInfo.acUserState_QUDI" >

            strCodeForCs.AppendFormat("\r\n" + "<android.support.design.widget.CoordinatorLayout ");
            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidCoordinatorLayoutENEx.CtrlId);
            }
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidCoordinatorLayoutENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.android) == false)
            {
                //      strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:android=\"{0}\"",
                    objAndroidCoordinatorLayoutENEx.android);
            }
            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.app) == false)
            {
                //      strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"{0}\"",
                    objAndroidCoordinatorLayoutENEx.app);
            }
            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.tools) == false)
            {
                //  strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"{0}\"",
                    objAndroidCoordinatorLayoutENEx.tools);
            }
            if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.context) == false)
            {
                //  strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.AppendFormat("\r\n" + "    tools:context=\"{0}\"",
                    objAndroidCoordinatorLayoutENEx.context);
            }
            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidCoordinatorLayoutENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidCoordinatorLayoutENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidCoordinatorLayoutENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objAndroidCoordinatorLayoutENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objAndroidCoordinatorLayoutENEx.orientation);
            //}
            strCodeForCs.AppendFormat(">");

            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidCoordinatorLayoutENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.design.widget.CoordinatorLayout>");
        }
    }
        /// <summary>
        /// Android协调布局(AndroidCoordinatorLayout)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidCoordinatorLayoutBLEx 
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidCoordinatorLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidCoordinatorLayoutEx objAndroidCoordinatorLayoutENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private CoordinatorLayout ll{0};",
                objAndroidCoordinatorLayoutENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidCoordinatorLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidCoordinatorLayoutEx objAndroidCoordinatorLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (CoordinatorLayout)findViewById(R.id.ll{0}); ",
                objAndroidCoordinatorLayoutENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidCoordinatorLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidCoordinatorLayoutEx objAndroidCoordinatorLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (CoordinatorLayout)view.findViewById(R.id.ll{0}); ",
                objAndroidCoordinatorLayoutENEx.CtrlId);

        }
    }
}