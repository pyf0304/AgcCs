
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_CodeSymbolBLEx
 表名:FR_CodeSymbol(00050657)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:46:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx,0021)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_FR_CodeSymbolEx: RelatedActions_FR_CodeSymbol
{
public override bool UpdRelaTabDate(long lngSymbolId, string strOpUser)
{
return true;
}
}
public static class  clsFR_CodeSymbolBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <returns>目标对象=>clsFR_CodeSymbolEN:objFR_CodeSymbolENT</returns>
 public static clsFR_CodeSymbolENEx CopyToEx(this clsFR_CodeSymbolEN objFR_CodeSymbolENS)
{
try
{
 clsFR_CodeSymbolENEx objFR_CodeSymbolENT = new clsFR_CodeSymbolENEx();
clsFR_CodeSymbolBL.FR_CodeSymbolDA.CopyTo(objFR_CodeSymbolENS, objFR_CodeSymbolENT);
 return objFR_CodeSymbolENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <returns>目标对象=>clsFR_CodeSymbolEN:objFR_CodeSymbolENT</returns>
 public static clsFR_CodeSymbolEN CopyTo(this clsFR_CodeSymbolENEx objFR_CodeSymbolENS)
{
try
{
 clsFR_CodeSymbolEN objFR_CodeSymbolENT = new clsFR_CodeSymbolEN();
clsFR_CodeSymbolBL.CopyTo(objFR_CodeSymbolENS, objFR_CodeSymbolENT);
 return objFR_CodeSymbolENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsFR_CodeSymbolBLEx : clsFR_CodeSymbolBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsFR_CodeSymbolDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsFR_CodeSymbolDAEx FR_CodeSymbolDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsFR_CodeSymbolDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <returns>目标对象=>clsFR_CodeSymbolEN:objFR_CodeSymbolENT</returns>
 public static clsFR_CodeSymbolENEx CopyToEx(clsFR_CodeSymbolEN objFR_CodeSymbolENS)
{
try
{
 clsFR_CodeSymbolENEx objFR_CodeSymbolENT = new clsFR_CodeSymbolENEx();
clsFR_CodeSymbolBL.FR_CodeSymbolDA.CopyTo(objFR_CodeSymbolENS, objFR_CodeSymbolENT);
 return objFR_CodeSymbolENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsFR_CodeSymbolENEx> GetObjExLst(string strCondition)
{
List <clsFR_CodeSymbolEN> arrObjLst = clsFR_CodeSymbolBL.GetObjLst(strCondition);
List <clsFR_CodeSymbolENEx> arrObjExLst = new List<clsFR_CodeSymbolENEx>();
foreach (clsFR_CodeSymbolEN objInFor in arrObjLst)
{
clsFR_CodeSymbolENEx objFR_CodeSymbolENEx = new clsFR_CodeSymbolENEx();
clsFR_CodeSymbolBL.CopyTo(objInFor, objFR_CodeSymbolENEx);
arrObjExLst.Add(objFR_CodeSymbolENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngSymbolId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsFR_CodeSymbolENEx GetObjExBySymbolId(long lngSymbolId)
{
clsFR_CodeSymbolEN objFR_CodeSymbolEN = clsFR_CodeSymbolBL.GetObjBySymbolId(lngSymbolId);
clsFR_CodeSymbolENEx objFR_CodeSymbolENEx = new clsFR_CodeSymbolENEx();
clsFR_CodeSymbolBL.CopyTo(objFR_CodeSymbolEN, objFR_CodeSymbolENEx);
return objFR_CodeSymbolENEx;
}
}
}