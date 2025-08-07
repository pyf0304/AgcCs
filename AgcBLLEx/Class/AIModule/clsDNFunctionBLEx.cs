
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFunctionBLEx
 表名:DnFunction(00050552)
 生成代码版本:2020.05.28.1
 生成日期:2020/06/02 01:32:40
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:AI模块
 模块英文名:AIModule
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
public static class clsDnFunctionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDnFunctionENS">源对象</param>
 /// <returns>目标对象=>clsDnFunctionEN:objDnFunctionENT</returns>
 public static clsDnFunctionENEx CopyToEx(this clsDnFunctionEN objDnFunctionENS)
{
try
{
 clsDnFunctionENEx objDnFunctionENT = new clsDnFunctionENEx();
clsDnFunctionBL.DnFunctionDA.CopyTo(objDnFunctionENS, objDnFunctionENT);
 return objDnFunctionENT;
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
 /// <param name = "objDnFunctionENS">源对象</param>
 /// <returns>目标对象=>clsDnFunctionEN:objDnFunctionENT</returns>
 public static clsDnFunctionEN CopyTo(this clsDnFunctionENEx objDnFunctionENS)
{
try
{
 clsDnFunctionEN objDnFunctionENT = new clsDnFunctionEN();
clsDnFunctionBL.CopyTo(objDnFunctionENS, objDnFunctionENT);
 return objDnFunctionENT;
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
 /// 数据结点函数(DnFunction)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDnFunctionBLEx : clsDnFunctionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDnFunctionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDnFunctionDAEx DnFunctionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDnFunctionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDnFunctionENS">源对象</param>
 /// <returns>目标对象=>clsDnFunctionEN:objDnFunctionENT</returns>
 public static clsDnFunctionENEx CopyToEx(clsDnFunctionEN objDnFunctionENS)
{
try
{
 clsDnFunctionENEx objDnFunctionENT = new clsDnFunctionENEx();
clsDnFunctionBL.DnFunctionDA.CopyTo(objDnFunctionENS, objDnFunctionENT);
 return objDnFunctionENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
public static List<clsDnFunctionENEx> GetObjExLst(string strCondition)
{
List <clsDnFunctionEN> arrObjLst = clsDnFunctionBL.GetObjLst(strCondition);
List <clsDnFunctionENEx> arrObjExLst = new List<clsDnFunctionENEx>();
foreach (clsDnFunctionEN objInFor in arrObjLst)
{
clsDnFunctionENEx objDnFunctionENEx = new clsDnFunctionENEx();
clsDnFunctionBL.CopyTo(objInFor, objDnFunctionENEx);
arrObjExLst.Add(objDnFunctionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDnFunctionENEx GetObjExByDnFunctionId(string strDnFunctionId)
{
clsDnFunctionEN objDnFunctionEN = clsDnFunctionBL.GetObjByDnFunctionId(strDnFunctionId);
clsDnFunctionENEx objDnFunctionENEx = new clsDnFunctionENEx();
clsDnFunctionBL.CopyTo(objDnFunctionEN, objDnFunctionENEx);
return objDnFunctionENEx;
}
}
}