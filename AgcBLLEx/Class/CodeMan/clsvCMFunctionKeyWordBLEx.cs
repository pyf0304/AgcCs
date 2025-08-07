
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionKeyWordBLEx
 表名:vCMFunctionKeyWord(00050516)
 生成代码版本:2019.11.08.1
 生成日期:2019/11/11 11:55:39
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理
 模块英文名:CodeMan
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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


using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;


namespace AGC.BusinessLogicEx
{
public static class clsvCMFunctionKeyWordBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <returns>目标对象=>clsvCMFunctionKeyWordEN:objvCMFunctionKeyWordENT</returns>
 public static clsvCMFunctionKeyWordENEx CopyToEx(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS)
{
try
{
 clsvCMFunctionKeyWordENEx objvCMFunctionKeyWordENT = new clsvCMFunctionKeyWordENEx();
clsvCMFunctionKeyWordBL.CopyTo(objvCMFunctionKeyWordENS, objvCMFunctionKeyWordENT);
 return objvCMFunctionKeyWordENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <returns>目标对象=>clsvCMFunctionKeyWordEN:objvCMFunctionKeyWordENT</returns>
 public static clsvCMFunctionKeyWordEN CopyTo(this clsvCMFunctionKeyWordENEx objvCMFunctionKeyWordENS)
{
try
{
 clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT = new clsvCMFunctionKeyWordEN();
clsvCMFunctionKeyWordBL.CopyTo(objvCMFunctionKeyWordENS, objvCMFunctionKeyWordENT);
 return objvCMFunctionKeyWordENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// vCMFunctionKeyWord(vCMFunctionKeyWord)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvCMFunctionKeyWordBLEx : clsvCMFunctionKeyWordBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCMFunctionKeyWordDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCMFunctionKeyWordDAEx vCMFunctionKeyWordDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCMFunctionKeyWordDAEx();
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
public static List<clsvCMFunctionKeyWordENEx> GetObjExLst(string strCondition)
{
List <clsvCMFunctionKeyWordEN> arrObjLst = clsvCMFunctionKeyWordBL.GetObjLst(strCondition);
List <clsvCMFunctionKeyWordENEx> arrObjExLst = new List<clsvCMFunctionKeyWordENEx>();
foreach (clsvCMFunctionKeyWordEN objInFor in arrObjLst)
{
clsvCMFunctionKeyWordENEx objvCMFunctionKeyWordENEx = new clsvCMFunctionKeyWordENEx();
clsvCMFunctionKeyWordBL.CopyTo(objInFor, objvCMFunctionKeyWordENEx);
arrObjExLst.Add(objvCMFunctionKeyWordENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCMFunctionKeyWordENEx GetObjExBymId(long lngmId)
{
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = clsvCMFunctionKeyWordBL.GetObjBymId(lngmId);
clsvCMFunctionKeyWordENEx objvCMFunctionKeyWordENEx = new clsvCMFunctionKeyWordENEx();
clsvCMFunctionKeyWordBL.CopyTo(objvCMFunctionKeyWordEN, objvCMFunctionKeyWordENEx);
return objvCMFunctionKeyWordENEx;
}
}
}