
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgcCommBase
{
    public class clsPubConst
    {
        public const string con_CSharp = "C#.NET";
        public const string con_Java = "Java";
        public const string con_swift = "swift";
        public const string con_JavaScript = "JavaScript";

//01	MS Sql Sever2000 MsSql2000   MsSql NULL
//02	MS Sql Server2005 MsSql2005   MsSql NULL
//03	Oracle10 Oracle  Oracle NULL
//04	My Sql  MySql MySql   NULL


        public const string con_MsSql = "Ms Sql";
        public const string con_MsSql01 = "01";
        public const string con_MsSql02 = "02";
        public const string con_MySql = "MySql";
        public const string con_MySql04 = "04";

        public const string con_Oracle = "Oracle";
        public const string con_Oracle03 = "03";

        public enum DataBaseType
        {
            /// <summary>
            /// Microsoft Sql Server
            /// </summary>
            MsSql,
            /// <summary>
            /// My Sql
            /// </summary>
            MySql,
            /// <summary>
            /// Oracle
            /// </summary>
            Oracle,
            NULL
        }
        public static DataBaseType GetDataBaseTypeByString(string strDataBaseType)
        {
            switch (strDataBaseType)
            {
                case "MsSql":
                case "Ms Sql":
                case con_MsSql01:
                case con_MsSql02:

                    return DataBaseType.MsSql;
                case "MySql":
                case con_MySql04:
                    return DataBaseType.MySql;
                case "Oracle":
                case con_Oracle03:
                    return DataBaseType.Oracle;               
                //case "":
                //    return DataBaseType.NULL;
                default:
                    string strMsg = string.Format("提供的数据库类型串：[{0}]不存在，无法处理！({1})", strDataBaseType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }

        public static string GetDataBaseTypeStrByDataBaseType(DataBaseType dbtDataBaseType)
        {
            switch (dbtDataBaseType)
            {
                case DataBaseType.MsSql:
                    return "MsSql" ;
                case DataBaseType.MySql:
                    return "MySql";
                case DataBaseType.Oracle:
                    return "Oracle";

                case DataBaseType.NULL:
                    return "";
                default:
                    string strMsg = string.Format("提供的数据库类型：[{0}]不存在，无法处理！({1})", dbtDataBaseType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg); 

            }
        }

        public enum LangType
        {
            /// <summary>
            /// C#.NET
            /// </summary>
            CSharp,
            /// <summary>
            /// JAVA
            /// </summary>
            JAVA,
            /// <summary>
            /// Swift
            /// </summary>
            Swift,
            /// <summary>
            /// Swift3
            /// </summary>
            Swift3,
            /// <summary>
            /// Swift4
            /// </summary>
            Swift4,
            /// <summary>
            /// JavaScript
            /// </summary>
            JavaScript,
            /// <summary>
            /// TypeScript
            /// </summary>
            TypeScript,

            /// <summary>
            /// Html
            /// </summary>
            Html,
            /// <summary>
            /// Visual Basic
            /// </summary>
            VB,
            /// <summary>
            /// SilverLight
            /// </summary>
            SilverLight,
            NULL
        }
        public static LangType GetLangTypeByString(string strLangType)
        {
            switch(strLangType)
            {
                case "CSharp":
                case "C#.NET":
                case "DotNet":
                    return LangType.CSharp;
                case "JAVA":
                case "Java":
                    return LangType.JAVA;
                case "Swift":
                case "swift":
                    return LangType.Swift;
                case "Swift3":
                case "swift3":
                    return LangType.Swift3;

                case "Swift4":
                case "swift4":
                    return LangType.Swift4;
                case "JavaScript":
                    return LangType.JavaScript;
                case "TypeScript":
                    return LangType.TypeScript;
                case "Html":
                    return LangType.Html;
                case "VB":
                    return LangType.VB;
                case "SilverLight":
                    return LangType.SilverLight;
                //case "":
                //    return LangType.NULL;
                default:
                    string strMsg = string.Format("提供的语言类型串：[{0}]不存在，无法处理！({1})", strLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }
        public static string GetLangTypeStringByLangType(LangType ltLangType)
        {
            switch (ltLangType)
            {
                case LangType.CSharp:                
                    return "CSharp";
                case LangType.JAVA:                
                    return "JAVA";
                case LangType.Swift:                
                    return "Swift";
                case LangType.Swift3:
                    return "Swift3";
                case LangType.Swift4:
                    return "Swift4";
                case LangType.JavaScript:
                    return "JavaScript";
                case LangType.TypeScript:
                    return "TypeScript";
                case LangType.Html:
                    return "Html";

                case LangType.VB:
                    return "VB";
                case LangType.SilverLight:
                    return "SilverLight";
                case LangType.NULL:
                    return "";
                default:
                    string strMsg = string.Format("提供的语言类型：[{0}]不存在，无法处理！({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        public enum ClassName
        {
            /// <summary>
            /// 实体层代码
            /// </summary>
            EntityLayer,
            /// <summary>
            /// 实体层扩展
            /// </summary>
            EntityLayerEx,
            /// <summary>
            /// 表字段常量
            /// </summary>
            TableFldConst,
            /// <summary>
            /// 简化实体层代码
            /// </summary>
            EntityLayer_Sim,
            /// <summary>
            /// 条件实体层代码
            /// </summary>
            CondEntityLayer,
            /// <summary>
            /// 数据处理层
            /// </summary>
            DALCode,
            /// <summary>
            /// 数据处理扩展层
            /// </summary>
            DALExCode,
            /// <summary>
            /// 业务逻辑层
            /// </summary>
            BusinessLogic,
            /// <summary>
            /// 业务逻辑层4Mvc
            /// </summary>
            BusinessLogic4Mvc,
            /// <summary>
            /// 业务逻辑扩展层
            /// </summary>
            BusinessLogicEx,
            /// <summary>
            /// WebApi层
            /// </summary>
            WA_Srv,
            /// <summary>
            /// Web服务层-后台
            /// </summary>
            WS_Srv,
            /// <summary>
            /// Web服务层-前台
            /// </summary>
            WS_Srv4Front,
            /// <summary>
            /// WA_Srv访问层
            /// </summary>
            WA_Access,
            /// <summary>
            /// WEB服务访问层
            /// </summary>
            WS_Access,
            /// <summary>
            /// Web服务转换高层
            /// </summary>
            WS_AccessHigh,
            /// <summary>
            /// WApi转换高层
            /// </summary>
            WA_AccessHigh,
            /// <summary>
            /// App控制层
            /// </summary>
            AppController,
            /// <summary>
            /// WA_App控制层
            /// </summary>
            WA_AppController,
            /// <summary>
            /// App业务逻辑层
            /// </summary>
            AppBusiness,
            /// <summary>
            /// 桌面控制层
            /// </summary>
            DesktopController,
            /// <summary>
            /// App界面单元测试(UnitTest)
            /// </summary>            
            AppViewUnitTest,
            /// <summary>
            /// WA_App界面单元测试(UnitTest)
            /// </summary>            
            WA_AppViewUT,
            /// <summary>
            /// App界面Ddl绑定
            /// </summary>            
            AppViewDdlBind,
            /// <summary>
            /// App界面Ddl适配器
            /// </summary>            
            AppViewDdlAdapter,

            /// <summary>
            /// 桌面单元测试
            /// </summary>            
            DesktopViewUnitTest,
            /// <summary>
            /// App界面单元测试脚本(UTScript)
            /// </summary>            
            AppViewUTScript,
            /// <summary>
            /// WA_App界面单元测试脚本(UTScript)
            /// </summary>            
            WA_AppViewUTScript,
            /// <summary>
            /// WApi界面单元测试脚本(UTScript)
            /// </summary>            
            WA_ViewUTScript,
            /// <summary>
            /// WApi界面单元测试脚本(UTScript)_TS
            /// </summary>            
            WA_ViewUTScript_TS,
            /// <summary>
            /// WApi界面脚本(UTScript)_TS
            /// </summary>            
            WA_ViewScript_TS,
            /// <summary>
            /// App界面脚本(Script)主页
            /// </summary>  
            AppViewScriptMain,
            /// <summary>
            /// App界面脚本(Script)内容页
            /// </summary>  
            AppViewScriptContent,

            /// <summary>
            /// App界面ListViewAdapter
            /// </summary>  
            AppViewListViewAdapter,

            /// <summary>
            /// App界面查询控件脚本(Script)
            /// </summary>            
            AppViewQryScript,

            /// <summary>
            /// App界面编辑脚本(Script)
            /// </summary>            
            AppViewEdtScript,
            /// <summary>
            /// App界面编辑脚本后台(Script)
            /// </summary>            
            AppViewEdtScriptCS,

            /// <summary>
            /// App界面编辑控件脚本(Script)
            /// </summary>            
            AppViewUCEdtScript,

            /// <summary>
            /// App界面ListViewItem控件脚本(Script)
            /// </summary>            
            AppViewLvItemScript,

            /// <summary>
            /// App界面ListView头控件脚本(Script)
            /// </summary>            
            AppViewLvHeadScript,

            /// <summary>
            /// 桌面界面单元测试脚本(UTScript)
            /// </summary>            
            DesktopViewUTScript,
            /// <summary>
            /// App界面单元测试脚本后台(UTScript)
            /// </summary>            
            AppViewUTScriptCS,
            /// <summary>
            /// WA_App界面单元测试脚本后台(UTScript)
            /// </summary>            
            WA_AppViewUTScriptCS,
            /// <summary>
            /// WApi界面单元测试脚本后台(UTScript)
            /// </summary>            
            WA_ViewUTScriptCS,
            /// <summary>
            /// WApi界面单元测试脚本后台(UTScript)_TS
            /// </summary>            
            WA_ViewUTScriptCS_TS,
            /// <summary>
            /// WApi界面脚本后台(UTScript)_TS
            /// </summary>            
            WA_ViewScriptCS_TS,
            /// <summary>
            /// App界面脚本后台(Script)
            /// </summary>            
            AppViewScriptCS,
            /// <summary>
            /// 桌面界面单元测试脚本后台(UTScript)
            /// </summary>            
            DesktopViewUTScriptCS,
            /// <summary>
            /// Win主界面前台代码
            /// </summary>
            WinViewCode_QD,
            /// <summary>
            /// Win主界面前台代码-Gv
            /// </summary>
            WinViewCode_QD_Gv,
            /// <summary>
            /// Win主界面前台设计代码
            /// </summary>
            WinViewCode_QD_Design,

            /// <summary>
            /// Win主界面前台设计代码-Gv
            /// </summary>
            WinViewCode_QD_Gv_Design,

            /// <summary>
            /// Win子界面前台代码
            /// </summary>
            WinViewCode_UI,
            /// <summary>
            /// Win子界面前台设计代码
            /// </summary>
            WinViewCode_UI_Design,
            /// <summary>
            /// Web界面前台代码（HTML）
            /// </summary>
            WebViewCode,
            /// <summary>
            /// Mvc界面代码（HTML）
            /// </summary>
            Mvc_View,
            /// <summary>
            /// Mvc界面Ajax代码（HTML）
            /// </summary>
            Mvc_ViewAjax,
            /// <summary>
            /// Mvc界面单页应用代码（HTML）
            /// </summary>
            Mvc_ViewSpa,
            /// <summary>
            /// Mvc界面列表Ajax代码（HTML）
            /// </summary>
            Mvc_ViewLstAjax,
            /// <summary>
            /// 界面后台控制代码
            /// </summary>
            WebViewControlCode,
            /// <summary>
            /// Mvc控制层代码
            /// </summary>
            Mvc_Controller,
            /// <summary>
            /// Mvc控制层Base
            /// </summary>
            Mvc_ControllerBase,
            /// <summary>
            /// Mvc扩展模型
            /// </summary>
            Mvc_ModelEx,
            /// <summary>
            /// Mvc查询区模型
            /// </summary>
            Mvc_Model4Query,
            /// <summary>
            /// Web用户控件前台代码（HTML）
            /// </summary>
            WebCtlViewCode,
            /// <summary>
            /// Web用户Gv控件前台代码（HTML）
            /// </summary>
            WebCtlViewCode4Gv,
            /// <summary>
            /// Web用户控件后台代码
            /// </summary>
            WebCtlControlCode,
            /// <summary>
            /// Web用户Gv控件后台代码
            /// </summary>
            WebCtlControlCode4Gv,
            ///// <summary>
            ///// Win用户控件前台代码（HTML）
            ///// </summary>
            //WinCtlViewCode,

            ///// <summary>
            ///// Win用户控件后台控制代码
            ///// </summary>
            //WinCtlControlCode,
            /// <summary>
            /// 页面名称-目录-字典
            /// </summary>
            Dict_PageName_Dic,
            /// <summary>
            /// 在逻辑层中的公共函数
            /// </summary>
            CommFun4BL,
            NULL
        }
        public static ClassName GetClassNameByStringBak(string strClassName)
        {
            switch (strClassName)
            {
                case "EntityLayer":
                    return ClassName.EntityLayer;
                case "EntityLayerEx":
                    return ClassName.EntityLayerEx;

                case "TableFldConst":
                    return ClassName.TableFldConst;

                case "EntityLayer_Sim":
                    return ClassName.EntityLayer_Sim;
                case "CondEntityLayer":
                    return ClassName.CondEntityLayer;
                case "DALCode":
                    return ClassName.DALCode;
                case "DALExCode":
                    return ClassName.DALExCode;
                case "BusinessLogic":
                    return ClassName.BusinessLogic;

                case "BusinessLogic4Mvc":
                    return ClassName.BusinessLogic4Mvc;
                case "BusinessLogicEx":
                    return ClassName.BusinessLogicEx;
                case "WA_Srv":
                    return ClassName.WA_Srv;
                case "WS_Srv":
                    return ClassName.WS_Srv;
                case "WS_Srv4Front":
                    return ClassName.WS_Srv4Front;
                case "WS_Access":
                    return ClassName.WS_Access;
                case "WA_Access":
                    return ClassName.WA_Access;
                case "WS_AccessHigh":
                    return ClassName.WS_AccessHigh;
                case "WA_AccessHigh":
                    return ClassName.WA_AccessHigh;
                case "AppController":
                    return ClassName.AppController;
                case "WA_AppController":
                    return ClassName.WA_AppController;
                case "AppBusiness":
                    return ClassName.AppBusiness;
                case "DesktopController":
                    return ClassName.DesktopController;

                case "AppViewUnitTest":
                    return ClassName.AppViewUnitTest;
                case "WA_AppViewUT":
                    return ClassName.WA_AppViewUT;

                case "AppViewDdlBind":
                    return ClassName.AppViewDdlBind;
                case "AppViewDdlAdapter":
                    return ClassName.AppViewDdlAdapter;

                case "DesktopViewUnitTest":
                    return ClassName.DesktopViewUnitTest;

                case "AppViewUTScript":
                    return ClassName.AppViewUTScript;
                case "WA_AppViewUTScript":
                    return ClassName.WA_AppViewUTScript;
                case "WA_ViewUTScript":
                    return ClassName.WA_ViewUTScript;

                case "WA_ViewUTScript_TS":
                    return ClassName.WA_ViewUTScript_TS;
                case "WA_ViewScript_TS":
                    return ClassName.WA_ViewScript_TS;

                case "AppViewScriptMain":
                    return ClassName.AppViewScriptMain;

                case "AppViewScriptContent":
                    return ClassName.AppViewScriptContent;

                case "AppViewListViewAdapter":
                    return ClassName.AppViewListViewAdapter;

                case "AppViewQryScript":
                    return ClassName.AppViewQryScript;

                case "AppViewEdtScript":
                    return ClassName.AppViewEdtScript;

                case "AppViewLvItemScript":
                    return ClassName.AppViewLvItemScript;

                case "AppViewLvHeadScript":
                    return ClassName.AppViewLvHeadScript;
                                        
                case "DesktopViewUTScript":
                    return ClassName.DesktopViewUTScript;

                case "AppViewUTScriptCS":
                    return ClassName.AppViewUTScriptCS;

                case "WA_AppViewUTScriptCS":
                    return ClassName.WA_AppViewUTScriptCS;

                case "WA_ViewUTScriptCS":
                    return ClassName.WA_ViewUTScriptCS;

                case "WA_ViewUTScriptCS_TS":
                    return ClassName.WA_ViewUTScriptCS_TS;

                case "WA_ViewScriptCS_TS":
                    return ClassName.WA_ViewScriptCS_TS;

                case "AppViewScriptCS":
                    return ClassName.AppViewScriptCS;
                case "DesktopViewUTScriptCS":
                    return ClassName.DesktopViewUTScriptCS;
                    
                case "WebViewCode":
                    return ClassName.WebViewCode;
                case "Mvc_View":
                    return ClassName.Mvc_View;
                case "Mvc_ViewAjax":
                    return ClassName.Mvc_ViewAjax;
                case "Mvc_ViewSpa":
                    return ClassName.Mvc_ViewSpa;
                case "Mvc_ViewLstAjax":
                    return ClassName.Mvc_ViewLstAjax;
                case "Mvc_Controller":
                    return ClassName.Mvc_Controller;
                case "Mvc_ControllerBase":
                    return ClassName.Mvc_ControllerBase;
                case "Mvc_ModelEx":
                    return ClassName.Mvc_ModelEx;
                case "Mvc_Model4Query":
                    return ClassName.Mvc_Model4Query;
                case "WinViewCode_QD":
                    return ClassName.WinViewCode_QD;
                case "WinViewCode_QD_Gv":
                    return ClassName.WinViewCode_QD_Gv;
                case "WinViewCode_QD_Design":
                    return ClassName.WinViewCode_QD_Design;
                case "WinViewCode_QD_Gv_Design":
                    return ClassName.WinViewCode_QD_Gv_Design;
                case "WinViewCode_UI":
                    return ClassName.WinViewCode_UI;
                case "WinViewCode_UI_Design":
                    return ClassName.WinViewCode_UI_Design;
                case "WebViewControlCode":
                    return ClassName.WebViewControlCode;
                case "WebCtlViewCode":
                    return ClassName.WebCtlViewCode;
                case "WebCtlViewCode4Gv":
                    return ClassName.WebCtlViewCode4Gv;
                    
                //case "WinCtlViewCode":
                //    return ClassName.WinCtlViewCode;
                case "WebCtlControlCode":
                    return ClassName.WebCtlControlCode;
                case "WebCtlControlCode4Gv":
                    return ClassName.WebCtlControlCode4Gv;
            
                //case "WinCtlControlCode":
                //    return ClassName.WinCtlControlCode;
                case "Dict_PageName_Dic":
                    return ClassName.Dict_PageName_Dic;
                case "CommFun4BL":
                    return ClassName.CommFun4BL;
                default:
                    string strMsg = string.Format("提供的类名串：[{0}]不存在，无法处理！({1})", strClassName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }

        public static string GetClassNameStringByClassName(ClassName cnClassName)
        {
            switch (cnClassName)
            {
                case ClassName.EntityLayer:
                    return "EntityLayer";
                case ClassName.EntityLayerEx:
                    return "EntityLayerEx";

                case ClassName.TableFldConst:
                    return "TableFldConst";

                case ClassName.EntityLayer_Sim:
                    return "EntityLayer_Sim";
                case ClassName.CondEntityLayer:
                    return "CondEntityLayer";
                case ClassName.DALCode:
                    return "DALCode";
                case ClassName.DALExCode:
                    return "DALExCode";
                case ClassName.BusinessLogic:
                    return "BusinessLogic";
                case ClassName.BusinessLogic4Mvc:
                    return "BusinessLogic4Mvc";

                case ClassName.BusinessLogicEx:
                    return "BusinessLogicEx";
                case ClassName.WA_Srv:
                    return "WA_Srv";
                case ClassName.WS_Srv:
                    return "WS_Srv";
                case ClassName.WS_Srv4Front:
                    return "WS_Srv4Front";
                case ClassName.WS_Access:
                    return "WS_Access";
                case ClassName.WA_Access:
                    return "WA_Access";
                case ClassName.WS_AccessHigh:
                    return "WS_AccessHigh";
                case ClassName.WA_AccessHigh:
                    return "WA_AccessHigh";
                case ClassName.AppController:
                    return "AppController";
                case ClassName.WA_AppController:
                    return "WA_AppController";
                case ClassName.AppBusiness:
                    return "AppBusiness";
                case ClassName.DesktopController:
                    return "DesktopController";

                case ClassName.WA_AppViewUT:
                    return "WA_AppViewUT";

                case ClassName.AppViewDdlBind:
                    return "AppViewDdlBind";

                case ClassName.AppViewDdlAdapter:
                    return "AppViewDdlAdapter";

                case ClassName.DesktopViewUnitTest:
                    return "DesktopViewUnitTest";

                case ClassName.AppViewUTScript:
                    return "AppViewUTScript";
                case ClassName.WA_AppViewUTScript:
                    return "WA_AppViewUTScript";

                case ClassName.WA_ViewUTScript:
                    return "WA_ViewUTScript";

                case ClassName.WA_ViewUTScript_TS:
                    return "WA_ViewUTScript_TS";

                case ClassName.WA_ViewScript_TS:
                    return "WA_ViewScript_TS";

                case ClassName.AppViewScriptMain:
                    return "AppViewScriptMain";

                case ClassName.AppViewScriptContent:
                    return "AppViewScriptContent";

                case ClassName.AppViewListViewAdapter:
                    return "AppViewListViewAdapter";

                    

                case ClassName.AppViewQryScript:
                    return "AppViewQryScript";

                case ClassName.AppViewEdtScript:
                    return "AppViewEdtScript";

                case ClassName.AppViewLvItemScript:
                    return "AppViewLvItemScript";

                case ClassName.AppViewLvHeadScript:
                    return "AppViewLvHeadScript";


                case ClassName.DesktopViewUTScript:
                    return "DesktopViewUTScript";

                case ClassName.AppViewUTScriptCS:
                    return "AppViewUTScriptCS";

                case ClassName.WA_AppViewUTScriptCS:
                    return "WA_AppViewUTScriptCS";

                case ClassName.WA_ViewUTScriptCS:
                    return "WA_ViewUTScriptCS";

                case ClassName.WA_ViewUTScriptCS_TS:
                    return "WA_ViewUTScriptCS_TS";

                case ClassName.WA_ViewScriptCS_TS:
                    return "WA_ViewScriptCS_TS";

                case ClassName.AppViewScriptCS:
                    return "AppViewScriptCS";
                case ClassName.DesktopViewUTScriptCS:
                    return "DesktopViewUTScriptCS";
                    
                case ClassName.WebViewCode:
                    return "WebViewCode";
                case ClassName.Mvc_View:
                    return "Mvc_View";
                case ClassName.Mvc_ViewAjax:
                    return "Mvc_ViewAjax";
                case ClassName.Mvc_ViewSpa:
                    return "Mvc_ViewSpa";

                case ClassName.Mvc_ViewLstAjax:
                    return "Mvc_ViewLstAjax";
                case ClassName.Mvc_Controller:
                    return "Mvc_Controller";
                case ClassName.Mvc_ControllerBase:
                    return "Mvc_ControllerBase";

                case ClassName.Mvc_ModelEx:
                    return "Mvc_ModelEx";
                case ClassName.Mvc_Model4Query:
                    return "Mvc_Model4Query";
                case ClassName.WinViewCode_QD:
                    return "WinViewCode_QD";
                case ClassName.WinViewCode_QD_Gv:
                    return "WinViewCode_QD_Gv";

                case ClassName.WinViewCode_QD_Design:
                    return "WinViewCode_QD_Design";
                case ClassName.WinViewCode_QD_Gv_Design:
                    return "WinViewCode_QD_Gv_Design";

                case ClassName.WinViewCode_UI:
                    return "WinViewCode_UI";
                case ClassName.WinViewCode_UI_Design:
                    return "WinViewCode_UI_Design";
                case ClassName.WebViewControlCode:
                    return "WebViewControlCode";
                case ClassName.WebCtlViewCode:
                    return "WebCtlViewCode";
                case ClassName.WebCtlViewCode4Gv:
                    return "WebCtlViewCode4Gv";

                //case ClassName.WinCtlViewCode:
                //    return "WinCtlViewCode";
                case ClassName.WebCtlControlCode:
                    return "WebCtlControlCode";
                case ClassName.WebCtlControlCode4Gv:
                    return "WebCtlControlCode4Gv";

                //case ClassName.WinCtlControlCode:
                //    return "WinCtlControlCode";
                case ClassName.Dict_PageName_Dic:
                    return "Dict_PageName_Dic";
                case ClassName.CommFun4BL:
                    return "CommFun4BL";
                default:
                    string strMsg = string.Format("提供的类名：[{0}]不存在，无法处理！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }

        public static string GetProgLevelTypeNameByClassNameBak20180512(ClassName cnClassName)
        {
            switch (cnClassName)
            {
                case ClassName.EntityLayer:
                    return "实体层";
                case ClassName.TableFldConst:
                    return "表字段常量";

                case ClassName.EntityLayer_Sim:
                    return "简化实体层";
                case ClassName.CondEntityLayer:
                    return "条件实体层";
                case ClassName.DALCode:
                    return "数据处理层";
                case ClassName.DALExCode:
                    return "数据处理扩展层";
                case ClassName.BusinessLogic:
                    return "业务逻辑层";
                case ClassName.BusinessLogic4Mvc:
                    return "业务逻辑层4Mvc";

                case ClassName.BusinessLogicEx:
                    return "业务逻辑扩展层";
                case ClassName.WA_Srv:
                    return "WebApi层";
                case ClassName.WS_Srv:
                    return "Web服务层";
                case ClassName.WS_Srv4Front:
                    return "Web服务层";
                case ClassName.WS_Access:
                    return "WEB服务访问层";
                case ClassName.WA_Access:
                    return "WebApi访问层";


                case ClassName.WS_AccessHigh:
                    return "Web服务访问高层";
                case ClassName.WA_AccessHigh:
                    return "WApi访问高层";
                case ClassName.AppController:
                    return "App控制层";
                case ClassName.WA_AppController:
                    return "WA_App控制层";
                case ClassName.AppBusiness:
                    return "App业务逻辑层";

                case ClassName.DesktopController:
                    return "桌面控制层";

                case ClassName.WA_AppViewUT:
                    return "WA_App界面单元测试";

                case ClassName.AppViewDdlBind:
                    return "App界面Ddl绑定";

                case ClassName.AppViewDdlAdapter:
                    return "App界面Ddl适配器";

                case ClassName.DesktopViewUnitTest:
                    return "桌面界面层4单元测试";

                case ClassName.AppViewUTScript:
                    return "App界面单元测试脚本";

                case ClassName.WA_AppViewUTScript:
                    return "WA_App界面单元测试脚本";

                case ClassName.WA_ViewUTScript:
                    return "WApi界面单元测试脚本";

                case ClassName.WA_ViewUTScript_TS:
                    return "WApi界面单元测试脚本_TS";

                case ClassName.WA_ViewScript_TS:
                    return "WApi界面脚本_TS";

                case ClassName.AppViewScriptMain:
                    return "App界面脚本主页";

                case ClassName.AppViewScriptContent:
                    return "App界面脚本内容页";

                case ClassName.AppViewListViewAdapter:
                    return "App界面ListViewAdapter";
                    
                case ClassName.AppViewQryScript:
                    return "App界面查询控件脚本";

                case ClassName.AppViewEdtScript:
                    return "App界面编辑控件脚本";

                case ClassName.AppViewLvItemScript:
                    return "App界面ListViewItem控件脚本";

                case ClassName.AppViewLvHeadScript:
                    return "App界面ListView头控件脚本";
                    
                case ClassName.DesktopViewUTScript:
                    return "桌面界面层4单元测试脚本";

                case ClassName.AppViewUTScriptCS:
                    return "App界面单元测试脚本后台";

                case ClassName.WA_AppViewUTScriptCS:
                    return "WA_App界面单测脚本后台";

                case ClassName.WA_ViewUTScriptCS:
                    return "WApi界面单元测试脚本后台";

                case ClassName.WA_ViewUTScriptCS_TS:
                    return "WApi界面单元测试脚本后台_TS";

                case ClassName.WA_ViewScriptCS_TS:
                    return "WApi界面脚本后台_TS";

                case ClassName.AppViewScriptCS:
                    return "App界面脚本后台";

                case ClassName.DesktopViewUTScriptCS:
                    return "桌面界面层4单元测试脚本后台";
                    
                case ClassName.WebViewCode:
                    return "Web界面层";
                case ClassName.Mvc_View:
                    return "Mvc界面层";
                case ClassName.Mvc_ViewAjax:
                    return "Mvc界面层Ajax";
                case ClassName.Mvc_ViewSpa:
                    return "Mvc界面层Spa";

                case ClassName.Mvc_ViewLstAjax:
                    return "Mvc界面列表Ajax";
                case ClassName.Mvc_Controller:
                    return "Mvc控制层";
                case ClassName.Mvc_ControllerBase:
                    return "Mvc控制层Base";
                case ClassName.Mvc_ModelEx:
                    return "Mvc扩展模型";
                case ClassName.Mvc_Model4Query:
                    return "Mvc查询区模型";
                case ClassName.WinViewCode_QD:
                    return "Win界面层";
                case ClassName.WinViewCode_QD_Gv:
                    return "Win界面层-Gv";
                case ClassName.WinViewCode_QD_Design:
                    return "Win界面层";
                case ClassName.WinViewCode_QD_Gv_Design:
                    return "Win界面层-Gv";
                case ClassName.WinViewCode_UI:
                    return "Win界面层";
                case ClassName.WinViewCode_UI_Design:
                    return "Win界面层";
                case ClassName.WebViewControlCode:
                    return "Web界面层";
                case ClassName.WebCtlViewCode:
                    return "Web界面层";
                case ClassName.WebCtlViewCode4Gv:
                    return "Web界面层";

                //case ClassName.WinCtlViewCode:
                //    return "WinCtlViewCode";
                case ClassName.WebCtlControlCode:
                    return "Web界面层";
                case ClassName.WebCtlControlCode4Gv:
                    return "Web界面层";

                //case ClassName.WinCtlControlCode:
                //    return "WinCtlControlCode";
                case ClassName.Dict_PageName_Dic:
                    return "Web服务层";
                case ClassName.CommFun4BL:
                    return "逻辑层公共函数类扩展";
                default:
                    string strMsg = string.Format("提供的类名：[{0}]不存在，无法处理！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }


        public enum MainSubViewType
        {
            /// <summary>
            /// 主界面
            /// </summary>
            MainView,
            /// <summary>
            /// 子界面
            /// </summary>
            SubView,
            NULL
        }
        public static MainSubViewType GetMainSubViewTypeByString(string strMainSubViewType)
        {
            switch (strMainSubViewType)
            {
                case "MAINVIEW":
                case "MainView":
                    return MainSubViewType.MainView;
                case "SUBVIEW":
                case "SubView":
                    return MainSubViewType.SubView;
                case "":
                    return MainSubViewType.NULL;
                default:
                    string strMsg = string.Format("提供的主子界面类型：[{0}]不存在，无法处理！({1})", strMainSubViewType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }

        public static string GetMainSubViewTypeStrByMainSubViewType(MainSubViewType dbtMainSubViewType)
        {
            switch (dbtMainSubViewType)
            {
                case MainSubViewType.MainView:
                    return "MainView";
                case MainSubViewType.SubView:
                    return "SubView";

                case MainSubViewType.NULL:
                    return "";
                default:
                    string strMsg = string.Format("提供的主子界面类型：[{0}]不存在，无法处理！({1})", dbtMainSubViewType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }

    }
}
