
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncMapModeBLEx
 表名:FuncMapMode(00050551)
 生成代码版本:2020.05.28.1
 生成日期:2020/06/02 01:33:09
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
public static class clsFuncMapModeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <returns>目标对象=>clsFuncMapModeEN:objFuncMapModeENT</returns>
 public static clsFuncMapModeENEx CopyToEx(this clsFuncMapModeEN objFuncMapModeENS)
{
try
{
 clsFuncMapModeENEx objFuncMapModeENT = new clsFuncMapModeENEx();
clsFuncMapModeBL.FuncMapModeDA.CopyTo(objFuncMapModeENS, objFuncMapModeENT);
 return objFuncMapModeENT;
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
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <returns>目标对象=>clsFuncMapModeEN:objFuncMapModeENT</returns>
 public static clsFuncMapModeEN CopyTo(this clsFuncMapModeENEx objFuncMapModeENS)
{
try
{
 clsFuncMapModeEN objFuncMapModeENT = new clsFuncMapModeEN();
clsFuncMapModeBL.CopyTo(objFuncMapModeENS, objFuncMapModeENT);
 return objFuncMapModeENT;
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
 /// 函数映射模式(FuncMapMode)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsFuncMapModeBLEx : clsFuncMapModeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsFuncMapModeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsFuncMapModeDAEx FuncMapModeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsFuncMapModeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <returns>目标对象=>clsFuncMapModeEN:objFuncMapModeENT</returns>
 public static clsFuncMapModeENEx CopyToEx(clsFuncMapModeEN objFuncMapModeENS)
{
try
{
 clsFuncMapModeENEx objFuncMapModeENT = new clsFuncMapModeENEx();
clsFuncMapModeBL.FuncMapModeDA.CopyTo(objFuncMapModeENS, objFuncMapModeENT);
 return objFuncMapModeENT;
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
public static List<clsFuncMapModeENEx> GetObjExLst(string strCondition)
{
List <clsFuncMapModeEN> arrObjLst = clsFuncMapModeBL.GetObjLst(strCondition);
List <clsFuncMapModeENEx> arrObjExLst = new List<clsFuncMapModeENEx>();
foreach (clsFuncMapModeEN objInFor in arrObjLst)
{
clsFuncMapModeENEx objFuncMapModeENEx = new clsFuncMapModeENEx();
clsFuncMapModeBL.CopyTo(objInFor, objFuncMapModeENEx);
arrObjExLst.Add(objFuncMapModeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFuncMapModeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsFuncMapModeENEx GetObjExByFuncMapModeId(string strFuncMapModeId)
{
clsFuncMapModeEN objFuncMapModeEN = clsFuncMapModeBL.GetObjByFuncMapModeId(strFuncMapModeId);
clsFuncMapModeENEx objFuncMapModeENEx = new clsFuncMapModeENEx();
clsFuncMapModeBL.CopyTo(objFuncMapModeEN, objFuncMapModeENEx);
return objFuncMapModeENEx;
}
}
}