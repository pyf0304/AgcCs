
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_ProcessBLEx
 表名:vwf_Process(00050492)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/20 01:31:12
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理
 模块英文名:WorkFlow
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
public static class clsvwf_ProcessBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvwf_ProcessENS">源对象</param>
 /// <returns>目标对象=>clsvwf_ProcessEN:objvwf_ProcessENT</returns>
 public static clsvwf_ProcessENEx CopyToEx(this clsvwf_ProcessEN objvwf_ProcessENS)
{
try
{
 clsvwf_ProcessENEx objvwf_ProcessENT = new clsvwf_ProcessENEx();
clsvwf_ProcessBL.CopyTo(objvwf_ProcessENS, objvwf_ProcessENT);
 return objvwf_ProcessENT;
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
 /// <param name = "objvwf_ProcessENS">源对象</param>
 /// <returns>目标对象=>clsvwf_ProcessEN:objvwf_ProcessENT</returns>
 public static clsvwf_ProcessEN CopyTo(this clsvwf_ProcessENEx objvwf_ProcessENS)
{
try
{
 clsvwf_ProcessEN objvwf_ProcessENT = new clsvwf_ProcessEN();
clsvwf_ProcessBL.CopyTo(objvwf_ProcessENS, objvwf_ProcessENT);
 return objvwf_ProcessENT;
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
 /// v工作流过程表(vwf_Process)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvwf_ProcessBLEx : clsvwf_ProcessBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvwf_ProcessDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvwf_ProcessDAEx vwf_ProcessDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvwf_ProcessDAEx();
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
public static List<clsvwf_ProcessENEx> GetObjExLst(string strCondition)
{
List <clsvwf_ProcessEN> arrObjLst = clsvwf_ProcessBL.GetObjLst(strCondition);
List <clsvwf_ProcessENEx> arrObjExLst = new List<clsvwf_ProcessENEx>();
foreach (clsvwf_ProcessEN objInFor in arrObjLst)
{
clsvwf_ProcessENEx objvwf_ProcessENEx = new clsvwf_ProcessENEx();
clsvwf_ProcessBL.CopyTo(objInFor, objvwf_ProcessENEx);
arrObjExLst.Add(objvwf_ProcessENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvwf_ProcessENEx GetObjExByProcessId(string strProcessId)
{
clsvwf_ProcessEN objvwf_ProcessEN = clsvwf_ProcessBL.GetObjByProcessId(strProcessId);
clsvwf_ProcessENEx objvwf_ProcessENEx = new clsvwf_ProcessENEx();
clsvwf_ProcessBL.CopyTo(objvwf_ProcessEN, objvwf_ProcessENEx);
return objvwf_ProcessENEx;
}
}
}