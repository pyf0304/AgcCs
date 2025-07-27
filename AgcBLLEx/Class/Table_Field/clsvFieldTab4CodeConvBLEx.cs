
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4CodeConvBLEx
 表名:vFieldTab4CodeConv(00050594)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/18 17:54:18
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
public static class clsvFieldTab4CodeConvBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab4CodeConvEN:objvFieldTab4CodeConvENT</returns>
 public static clsvFieldTab4CodeConvENEx CopyToEx(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS)
{
try
{
 clsvFieldTab4CodeConvENEx objvFieldTab4CodeConvENT = new clsvFieldTab4CodeConvENEx();
clsvFieldTab4CodeConvBL.vFieldTab4CodeConvDA.CopyTo(objvFieldTab4CodeConvENS, objvFieldTab4CodeConvENT);
 return objvFieldTab4CodeConvENT;
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
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab4CodeConvEN:objvFieldTab4CodeConvENT</returns>
 public static clsvFieldTab4CodeConvEN CopyTo(this clsvFieldTab4CodeConvENEx objvFieldTab4CodeConvENS)
{
try
{
 clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT = new clsvFieldTab4CodeConvEN();
clsvFieldTab4CodeConvBL.CopyTo(objvFieldTab4CodeConvENS, objvFieldTab4CodeConvENT);
 return objvFieldTab4CodeConvENT;
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
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFieldTab4CodeConvBLEx : clsvFieldTab4CodeConvBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFieldTab4CodeConvDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFieldTab4CodeConvDAEx vFieldTab4CodeConvDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFieldTab4CodeConvDAEx();
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
public static List<clsvFieldTab4CodeConvENEx> GetObjExLst(string strCondition)
{
List <clsvFieldTab4CodeConvEN> arrObjLst = clsvFieldTab4CodeConvBL.GetObjLst(strCondition);
List <clsvFieldTab4CodeConvENEx> arrObjExLst = new List<clsvFieldTab4CodeConvENEx>();
foreach (clsvFieldTab4CodeConvEN objInFor in arrObjLst)
{
clsvFieldTab4CodeConvENEx objvFieldTab4CodeConvENEx = new clsvFieldTab4CodeConvENEx();
clsvFieldTab4CodeConvBL.CopyTo(objInFor, objvFieldTab4CodeConvENEx);
arrObjExLst.Add(objvFieldTab4CodeConvENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFieldTab4CodeConvENEx GetObjExByFldId(string strFldId)
{
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = clsvFieldTab4CodeConvBL.GetObjByFldId(strFldId);
clsvFieldTab4CodeConvENEx objvFieldTab4CodeConvENEx = new clsvFieldTab4CodeConvENEx();
clsvFieldTab4CodeConvBL.CopyTo(objvFieldTab4CodeConvEN, objvFieldTab4CodeConvENEx);
return objvFieldTab4CodeConvENEx;
}
}
}