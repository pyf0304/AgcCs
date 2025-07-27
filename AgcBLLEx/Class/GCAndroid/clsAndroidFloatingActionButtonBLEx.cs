
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidFloatingActionButtonBLEx
表名:AndroidFloatingActionButton
生成代码版本:2018.03.19.1
生成日期:2018/03/27 14:02:22
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
    public static class clsAndroidFloatingActionButtonBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidFloatingActionButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidFloatingActionButtonENEx objAndroidFloatingActionButtonENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();


            //< android.support.design.widget.FloatingActionButton
            //    android: id = "@+id/fab"
            //    android: layout_width = "wrap_content"
            //    android: layout_height = "wrap_content"
            //    android: layout_gravity = "bottom|end"
            //    android: layout_margin = "@dimen/fab_margin"
            //    app: srcCompat = "@android:drawable/ic_dialog_email" />

            strCodeForCs.AppendFormat("\r\n" + "<android.support.design.widget.FloatingActionButton");

            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidFloatingActionButtonENEx.CtrlId);

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidFloatingActionButtonENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidFloatingActionButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidFloatingActionButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objAndroidFloatingActionButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    objAndroidFloatingActionButtonENEx.OnClick);
            }
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidFloatingActionButtonENEx.Text);
            if (string.IsNullOrEmpty(objAndroidFloatingActionButtonENEx.layout_gravity) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:layout_gravity=\"{0}\"",
                    objAndroidFloatingActionButtonENEx.layout_gravity);
            }

            if (string.IsNullOrEmpty(objAndroidFloatingActionButtonENEx.srcCompat) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "app:srcCompat=\"{0}\"",
                    objAndroidFloatingActionButtonENEx.srcCompat);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidFloatingActionButtonENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidFloatingActionButtonENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(strCodeForCs);
            //}


        }
    }
        /// <summary>
        /// Android悬浮按钮(AndroidFloatingActionButton)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidFloatingActionButtonBLEx 
    {
    
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidFloatingActionButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidFloatingActionButtonENEx objAndroidFloatingActionButtonENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private Button {0};",
                objAndroidFloatingActionButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidFloatingActionButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidFloatingActionButtonENEx objAndroidFloatingActionButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)findViewById(R.id.btn{0}); ",
                objAndroidFloatingActionButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidFloatingActionButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidFloatingActionButtonENEx objAndroidFloatingActionButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)view.findViewById(R.id.btn{0}); ",
                objAndroidFloatingActionButtonENEx.CtrlId);

        }
    }
}
    