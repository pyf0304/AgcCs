
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidToolbarBLEx
表名:AndroidToolbar
生成代码版本:2018.03.19.1
生成日期:2018/03/27 14:02:24
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
    /// <summary>
    /// Android工具栏(AndroidToolbar)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsAndroidToolbarBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidToolbarENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this clsAndroidToolbarENEx objAndroidToolbarENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            //string strKey = "";
            //< android.support.v7.widget.Toolbar
            // android: id = "@+id/toolbar"
            // android: layout_width = "match_parent"
            // android: layout_height = "?attr/actionBarSize"
            // android: background = "?attr/colorPrimary"
            // app: popupTheme = "@style/AppTheme.PopupOverlay" />

            strCodeForCs.AppendFormat("\r\n" + "<android.support.v7.widget.Toolbar");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidToolbarENEx.CtrlId);
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidToolbarENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidToolbarENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidToolbarENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objAndroidToolbarENEx.background) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:background=\"{0}\"",
                    objAndroidToolbarENEx.background);
            }
            if (string.IsNullOrEmpty(objAndroidToolbarENEx.popupTheme) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:popupTheme=\"{0}\"",
                    objAndroidToolbarENEx.popupTheme);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidToolbarENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (clsAndroidControlENEx objSubAndroidControlENEx in objAndroidToolbarENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.v7.widget.Toolbar>");
        }
    }
    
    
    /// <summary>
     /// Android工具栏(AndroidToolbar)
     /// 数据源类型:SQL表
     /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
     /// </summary>
    public class clsAndroidToolbarBLEx 
        {
             
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidToolbarENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(clsAndroidToolbarENEx objAndroidToolbarENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private TabHost th{0};",
                objAndroidToolbarENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidToolbarENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(clsAndroidToolbarENEx objAndroidToolbarENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "th{0} = (TabHost)findViewById(R.id.th{0}); ",
                objAndroidToolbarENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidToolbarENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(clsAndroidToolbarENEx objAndroidToolbarENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "th{0} = (TabHost)view.findViewById(R.id.th{0}); ",
                objAndroidToolbarENEx.CtrlId);

        }
    }
}