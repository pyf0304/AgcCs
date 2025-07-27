
// /*-- -- -- -- -- -- -- -- -- -- --
// 类名:clscss_ControlBLEx
// 表名:css_Control(00050467)
// * 版本:2023.02.21.1(服务器:WIN-SRV103-116)
// 日期:2023/02/21 23:06:42
// 生成者:pyf
// 生成服务器IP:
// 工程名称:AGC(0005)
// CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
// 相关数据库:103.116.76.183,9433AGC_CS12
// PrjDataBaseId:0005
// 模块中文名:样式表管理(CssManage)
// 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
// 编程语言:CSharp
// 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
//        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
// == == == == == == == == == == == == 
// **/
//using System;
//using System.Text; 
//using System.Collections; 
//using System.Collections.Generic; 
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.ComponentModel;
//using System.Xml;
//using com.taishsoft.file;
//using com.taishsoft.common;

//using com.taishsoft.comm_db_obj;
//using AGC.Entity;
//using System.Data; 
//using System.Data.SqlClient; 
//using AGC.DAL;
//using AGC.BusinessLogic;

//namespace AGC.BusinessLogicEx
//{
//// /// <summary>
//// /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
//// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
//// /// </summary>
//// public class RelatedActions_css_ControlEx: RelatedActions_css_Control
////{
////public override bool UpdRelaTabDate(string strControlId, string strOpUser)
////{
////return true;
////}
////}
//public static class clscss_ControlBLEx_Static
//{

// /// <summary>
// /// 把同一个类的对象,复制到另一个对象
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
// /// </summary>
// /// <param name = "objcss_ControlENS">源对象</param>
// /// <returns>目标对象=>clscss_ControlEN:objcss_ControlENT</returns>
// public static clscss_ControlENEx CopyToEx(this clscss_ControlEN objcss_ControlENS)
//{
//try
//{
// clscss_ControlENEx objcss_ControlENT = new clscss_ControlENEx();
//clscss_ControlBL.css_ControlDA.CopyTo(objcss_ControlENS, objcss_ControlENT);
// return objcss_ControlENT;
//}
//catch (Exception objException)
//{
//string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
//clsStackTrace.GetCurrClassFunction(),
//objException.Message); 
//throw new Exception(strMsg); 
//}
//}

// /// <summary>
// /// 把同一个类的对象,复制到另一个对象
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
// /// </summary>
// /// <param name = "objcss_ControlENS">源对象</param>
// /// <returns>目标对象=>clscss_ControlEN:objcss_ControlENT</returns>
// public static clscss_ControlEN CopyTo(this clscss_ControlENEx objcss_ControlENS)
//{
//try
//{
// clscss_ControlEN objcss_ControlENT = new clscss_ControlEN();
//clscss_ControlBL.CopyTo(objcss_ControlENS, objcss_ControlENT);
// return objcss_ControlENT;
//}
//catch (Exception objException)
//{
//string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
//clsStackTrace.GetCurrClassFunction(),
//objException.Message); 
//throw new Exception(strMsg); 
//}
//}
//}
// /// <summary>
// /// 控件(css_Control)
// /// 数据源类型:表
// /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
// /// </summary>
//public partial class clscss_ControlBLEx : clscss_ControlBL
//{

// /// <summary>
///// 单例模式:访问数据访问扩展层的单例模式
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
///// </summary>
//private static clscss_ControlDAEx uniqueInstanceEx = null;
///// <summary>
///// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
///// </summary>
//private static clscss_ControlDAEx css_ControlDAEx
//{
//    get
//{
//if (uniqueInstanceEx == null)
//{
//uniqueInstanceEx = new clscss_ControlDAEx();
//}
//return uniqueInstanceEx;
//}
//}

// /// <summary>
// /// 把同一个类的对象,复制到另一个对象
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
// /// </summary>
// /// <param name = "objcss_ControlENS">源对象</param>
// /// <returns>目标对象=>clscss_ControlEN:objcss_ControlENT</returns>
// public static clscss_ControlENEx CopyToEx(clscss_ControlEN objcss_ControlENS)
//{
//try
//{
// clscss_ControlENEx objcss_ControlENT = new clscss_ControlENEx();
//clscss_ControlBL.css_ControlDA.CopyTo(objcss_ControlENS, objcss_ControlENT);
// return objcss_ControlENT;
//}
//catch (Exception objException)
//{
//string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
//clsStackTrace.GetCurrClassFunction(),
//objException.Message); 
//throw new Exception(strMsg); 
//}
//}

// /// <summary>
// /// 根据条件获取扩展对象列表
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
// /// </summary>
// /// <param name = "strCondition">给定条件</param>
// /// <returns>返回扩展对象列表</returns>
//public static List<clscss_ControlENEx> GetObjExLst(string strCondition)
//{
//List <clscss_ControlEN> arrObjLst = clscss_ControlBL.GetObjLst(strCondition);
//List <clscss_ControlENEx> arrObjExLst = new List<clscss_ControlENEx>();
//foreach (clscss_ControlEN objInFor in arrObjLst)
//{
//clscss_ControlENEx objcss_ControlENEx = new clscss_ControlENEx();
//clscss_ControlBL.CopyTo(objInFor, objcss_ControlENEx);
//arrObjExLst.Add(objcss_ControlENEx);
//}
//return arrObjExLst;
//}

// /// <summary>
// /// 获取当前关键字的记录对象,用扩展对象的形式表示.
// /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
// /// </summary>
// /// <param name = "strControlId">表关键字</param>
// /// <returns>表扩展对象</returns>
//public static clscss_ControlENEx GetObjExByControlId(string strControlId)
//{
//clscss_ControlEN objcss_ControlEN = clscss_ControlBL.GetObjByControlId(strControlId);
//clscss_ControlENEx objcss_ControlENEx = new clscss_ControlENEx();
//clscss_ControlBL.CopyTo(objcss_ControlEN, objcss_ControlENEx);
//return objcss_ControlENEx;
//}
//}
//}