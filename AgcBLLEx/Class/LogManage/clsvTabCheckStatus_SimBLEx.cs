
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckStatus_SimBLEx
 表名:vTabCheckStatus_Sim(00050599)
 生成代码版本:2021.12.12.1
 生成日期:2021/12/14 01:04:14
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class clsvTabCheckStatus_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <returns>目标对象=>clsvTabCheckStatus_SimEN:objvTabCheckStatus_SimENT</returns>
 public static clsvTabCheckStatus_SimENEx CopyToEx(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENS)
{
try
{
 clsvTabCheckStatus_SimENEx objvTabCheckStatus_SimENT = new clsvTabCheckStatus_SimENEx();
clsvTabCheckStatus_SimBL.vTabCheckStatus_SimDA.CopyTo(objvTabCheckStatus_SimENS, objvTabCheckStatus_SimENT);
 return objvTabCheckStatus_SimENT;
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
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <returns>目标对象=>clsvTabCheckStatus_SimEN:objvTabCheckStatus_SimENT</returns>
 public static clsvTabCheckStatus_SimEN CopyTo(this clsvTabCheckStatus_SimENEx objvTabCheckStatus_SimENS)
{
try
{
 clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENT = new clsvTabCheckStatus_SimEN();
clsvTabCheckStatus_SimBL.CopyTo(objvTabCheckStatus_SimENS, objvTabCheckStatus_SimENT);
 return objvTabCheckStatus_SimENT;
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
 /// v表检查状态_Sim(vTabCheckStatus_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvTabCheckStatus_SimBLEx : clsvTabCheckStatus_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvTabCheckStatus_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvTabCheckStatus_SimDAEx vTabCheckStatus_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvTabCheckStatus_SimDAEx();
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
public static List<clsvTabCheckStatus_SimENEx> GetObjExLst(string strCondition)
{
List <clsvTabCheckStatus_SimEN> arrObjLst = clsvTabCheckStatus_SimBL.GetObjLst(strCondition);
List <clsvTabCheckStatus_SimENEx> arrObjExLst = new List<clsvTabCheckStatus_SimENEx>();
foreach (clsvTabCheckStatus_SimEN objInFor in arrObjLst)
{
clsvTabCheckStatus_SimENEx objvTabCheckStatus_SimENEx = new clsvTabCheckStatus_SimENEx();
clsvTabCheckStatus_SimBL.CopyTo(objInFor, objvTabCheckStatus_SimENEx);
arrObjExLst.Add(objvTabCheckStatus_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvTabCheckStatus_SimENEx GetObjExBymId(long lngmId)
{
clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = clsvTabCheckStatus_SimBL.GetObjBymId(lngmId);
clsvTabCheckStatus_SimENEx objvTabCheckStatus_SimENEx = new clsvTabCheckStatus_SimENEx();
clsvTabCheckStatus_SimBL.CopyTo(objvTabCheckStatus_SimEN, objvTabCheckStatus_SimENEx);
return objvTabCheckStatus_SimENEx;
}
}
}