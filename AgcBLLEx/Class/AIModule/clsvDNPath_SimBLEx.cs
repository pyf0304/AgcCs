
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnPath_SimBLEx
 表名:vDnPath_Sim(00050603)
 生成代码版本:2022.01.17.1
 生成日期:2022/01/23 20:59:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
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
public static class clsvDnPath_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvDnPath_SimENS">源对象</param>
 /// <returns>目标对象=>clsvDnPath_SimEN:objvDnPath_SimENT</returns>
 public static clsvDnPath_SimENEx CopyToEx(this clsvDnPath_SimEN objvDnPath_SimENS)
{
try
{
 clsvDnPath_SimENEx objvDnPath_SimENT = new clsvDnPath_SimENEx();
clsvDnPath_SimBL.vDnPath_SimDA.CopyTo(objvDnPath_SimENS, objvDnPath_SimENT);
 return objvDnPath_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvDnPath_SimENS">源对象</param>
 /// <returns>目标对象=>clsvDnPath_SimEN:objvDnPath_SimENT</returns>
 public static clsvDnPath_SimEN CopyTo(this clsvDnPath_SimENEx objvDnPath_SimENS)
{
try
{
 clsvDnPath_SimEN objvDnPath_SimENT = new clsvDnPath_SimEN();
clsvDnPath_SimBL.CopyTo(objvDnPath_SimENS, objvDnPath_SimENT);
 return objvDnPath_SimENT;
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
 /// vDnPath_Sim(vDnPath_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvDnPath_SimBLEx : clsvDnPath_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvDnPath_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvDnPath_SimDAEx vDnPath_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvDnPath_SimDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvDnPath_SimENEx> GetObjExLst(string strCondition)
{
List <clsvDnPath_SimEN> arrObjLst = clsvDnPath_SimBL.GetObjLst(strCondition);
List <clsvDnPath_SimENEx> arrObjExLst = new List<clsvDnPath_SimENEx>();
foreach (clsvDnPath_SimEN objInFor in arrObjLst)
{
clsvDnPath_SimENEx objvDnPath_SimENEx = new clsvDnPath_SimENEx();
clsvDnPath_SimBL.CopyTo(objInFor, objvDnPath_SimENEx);
arrObjExLst.Add(objvDnPath_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvDnPath_SimENEx GetObjExByDnPathId(string strDnPathId)
{
clsvDnPath_SimEN objvDnPath_SimEN = clsvDnPath_SimBL.GetObjByDnPathId(strDnPathId);
clsvDnPath_SimENEx objvDnPath_SimENEx = new clsvDnPath_SimENEx();
clsvDnPath_SimBL.CopyTo(objvDnPath_SimEN, objvDnPath_SimENEx);
return objvDnPath_SimENEx;
}
}
}