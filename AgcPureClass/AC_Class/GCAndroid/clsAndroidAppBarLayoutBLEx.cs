
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidAppBarLayoutBLEx
表名:AndroidAppBarLayout
生成代码版本:2018.03.19.1
生成日期:2018/03/27 14:02:27
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
    public static class clsAndroidAppBarLayoutBLEx_Static 
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidAppBarLayoutENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidAppBarLayoutEx objAndroidAppBarLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //    string strActionId = AgcPubFun.getAndroidID();
            //      < android.support.design.widget.AppBarLayout
            //android: layout_width = "match_parent"
            //android: layout_height = "wrap_content"
            //android: theme = "@style/AppTheme.AppBarOverlay" >

            strCodeForCs.AppendFormat("\r\n" + "<android.support.design.widget.AppBarLayout");
            if (string.IsNullOrEmpty(objAndroidAppBarLayoutENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidAppBarLayoutENEx.CtrlId);
            }

            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidAppBarLayoutENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidAppBarLayoutENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidAppBarLayoutENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objAndroidAppBarLayoutENEx.theme) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:theme=\"{0}\"",
                    objAndroidAppBarLayoutENEx.theme);
            }
            strCodeForCs.AppendFormat(">");

            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidAppBarLayoutENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.design.widget.AppBarLayout>");
        }
    }
        /// <summary>
        /// AndroidAppBar布局(AndroidAppBarLayout)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidAppBarLayoutBLEx 
    {

        
    
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidAppBarLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidAppBarLayoutEx objAndroidAppBarLayoutENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private LinearLayout ll{0};",
                objAndroidAppBarLayoutENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidAppBarLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidAppBarLayoutEx objAndroidAppBarLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (LinearLayout)findViewById(R.id.ll{0}); ",
                objAndroidAppBarLayoutENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidAppBarLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidAppBarLayoutEx objAndroidAppBarLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (LinearLayout)view.findViewById(R.id.ll{0}); ",
                objAndroidAppBarLayoutENEx.CtrlId);

        }
    }
}