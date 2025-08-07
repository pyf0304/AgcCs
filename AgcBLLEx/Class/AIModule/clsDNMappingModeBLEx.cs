
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnMappingModeBLEx
 表名:DnMappingMode(00050571)
 生成代码版本:2021.07.30.2
 生成日期:2021/08/02 02:49:23
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
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
public static class clsDnMappingModeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <returns>目标对象=>clsDnMappingModeEN:objDnMappingModeENT</returns>
 public static clsDnMappingModeENEx CopyToEx(this clsDnMappingModeEN objDnMappingModeENS)
{
try
{
 clsDnMappingModeENEx objDnMappingModeENT = new clsDnMappingModeENEx();
clsDnMappingModeBL.DnMappingModeDA.CopyTo(objDnMappingModeENS, objDnMappingModeENT);
 return objDnMappingModeENT;
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
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <returns>目标对象=>clsDnMappingModeEN:objDnMappingModeENT</returns>
 public static clsDnMappingModeEN CopyTo(this clsDnMappingModeENEx objDnMappingModeENS)
{
try
{
 clsDnMappingModeEN objDnMappingModeENT = new clsDnMappingModeEN();
clsDnMappingModeBL.CopyTo(objDnMappingModeENS, objDnMappingModeENT);
 return objDnMappingModeENT;
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
 /// 结点映射模式(DnMappingMode)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDnMappingModeBLEx : clsDnMappingModeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDnMappingModeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDnMappingModeDAEx DnMappingModeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDnMappingModeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <returns>目标对象=>clsDnMappingModeEN:objDnMappingModeENT</returns>
 public static clsDnMappingModeENEx CopyToEx(clsDnMappingModeEN objDnMappingModeENS)
{
try
{
 clsDnMappingModeENEx objDnMappingModeENT = new clsDnMappingModeENEx();
clsDnMappingModeBL.DnMappingModeDA.CopyTo(objDnMappingModeENS, objDnMappingModeENT);
 return objDnMappingModeENT;
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
public static List<clsDnMappingModeENEx> GetObjExLst(string strCondition)
{
List <clsDnMappingModeEN> arrObjLst = clsDnMappingModeBL.GetObjLst(strCondition);
List <clsDnMappingModeENEx> arrObjExLst = new List<clsDnMappingModeENEx>();
foreach (clsDnMappingModeEN objInFor in arrObjLst)
{
clsDnMappingModeENEx objDnMappingModeENEx = new clsDnMappingModeENEx();
clsDnMappingModeBL.CopyTo(objInFor, objDnMappingModeENEx);
arrObjExLst.Add(objDnMappingModeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strMappingModeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDnMappingModeENEx GetObjExByMappingModeId(string strMappingModeId)
{
clsDnMappingModeEN objDnMappingModeEN = clsDnMappingModeBL.GetObjByMappingModeId(strMappingModeId);
clsDnMappingModeENEx objDnMappingModeENEx = new clsDnMappingModeENEx();
clsDnMappingModeBL.CopyTo(objDnMappingModeEN, objDnMappingModeENEx);
return objDnMappingModeENEx;
}
}
}