
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceBLEx
 表名:vFileResource(00050540)
 生成代码版本:2020.05.09.1
 生成日期:2020/05/09 23:52:42
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:资源管理
 模块英文名:ResourceMan
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
public static class clsvFileResourceBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <returns>目标对象=>clsvFileResourceEN:objvFileResourceENT</returns>
 public static clsvFileResourceENEx CopyToEx(this clsvFileResourceEN objvFileResourceENS)
{
try
{
 clsvFileResourceENEx objvFileResourceENT = new clsvFileResourceENEx();
clsvFileResourceBL.vFileResourceDA.CopyTo(objvFileResourceENS, objvFileResourceENT);
 return objvFileResourceENT;
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
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <returns>目标对象=>clsvFileResourceEN:objvFileResourceENT</returns>
 public static clsvFileResourceEN CopyTo(this clsvFileResourceENEx objvFileResourceENS)
{
try
{
 clsvFileResourceEN objvFileResourceENT = new clsvFileResourceEN();
clsvFileResourceBL.CopyTo(objvFileResourceENS, objvFileResourceENT);
 return objvFileResourceENT;
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
 /// v文件资源(vFileResource)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFileResourceBLEx : clsvFileResourceBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFileResourceDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFileResourceDAEx vFileResourceDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFileResourceDAEx();
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
public static List<clsvFileResourceENEx> GetObjExLst(string strCondition)
{
List <clsvFileResourceEN> arrObjLst = clsvFileResourceBL.GetObjLst(strCondition);
List <clsvFileResourceENEx> arrObjExLst = new List<clsvFileResourceENEx>();
foreach (clsvFileResourceEN objInFor in arrObjLst)
{
clsvFileResourceENEx objvFileResourceENEx = new clsvFileResourceENEx();
clsvFileResourceBL.CopyTo(objInFor, objvFileResourceENEx);
arrObjExLst.Add(objvFileResourceENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFileResourceENEx GetObjExByFileResourceID(long lngFileResourceID)
{
clsvFileResourceEN objvFileResourceEN = clsvFileResourceBL.GetObjByFileResourceID(lngFileResourceID);
clsvFileResourceENEx objvFileResourceENEx = new clsvFileResourceENEx();
clsvFileResourceBL.CopyTo(objvFileResourceEN, objvFileResourceENEx);
return objvFileResourceENEx;
}
}
}