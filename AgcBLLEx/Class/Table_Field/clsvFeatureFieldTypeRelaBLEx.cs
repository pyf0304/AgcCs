
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFieldTypeRelaBLEx
 表名:vFeatureFieldTypeRela(00050458)
 生成代码版本:2019.04.27.1
 生成日期:2019/04/30 04:19:39
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
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
public static class clsvFeatureFieldTypeRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFieldTypeRelaEN:objvFeatureFieldTypeRelaENT</returns>
 public static clsvFeatureFieldTypeRelaENEx CopyToEx(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENS)
{
try
{
 clsvFeatureFieldTypeRelaENEx objvFeatureFieldTypeRelaENT = new clsvFeatureFieldTypeRelaENEx();
clsvFeatureFieldTypeRelaBL.CopyTo(objvFeatureFieldTypeRelaENS, objvFeatureFieldTypeRelaENT);
 return objvFeatureFieldTypeRelaENT;
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
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFieldTypeRelaEN:objvFeatureFieldTypeRelaENT</returns>
 public static clsvFeatureFieldTypeRelaEN CopyTo(this clsvFeatureFieldTypeRelaENEx objvFeatureFieldTypeRelaENS)
{
try
{
 clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENT = new clsvFeatureFieldTypeRelaEN();
clsvFeatureFieldTypeRelaBL.CopyTo(objvFeatureFieldTypeRelaENS, objvFeatureFieldTypeRelaENT);
 return objvFeatureFieldTypeRelaENT;
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
 /// vFeatureFieldTypeRela(vFeatureFieldTypeRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFeatureFieldTypeRelaBLEx : clsvFeatureFieldTypeRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFeatureFieldTypeRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFeatureFieldTypeRelaDAEx vFeatureFieldTypeRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFeatureFieldTypeRelaDAEx();
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
public static List<clsvFeatureFieldTypeRelaENEx> GetObjExLst(string strCondition)
{
List <clsvFeatureFieldTypeRelaEN> arrObjLst = clsvFeatureFieldTypeRelaBL.GetObjLst(strCondition);
List <clsvFeatureFieldTypeRelaENEx> arrObjExLst = new List<clsvFeatureFieldTypeRelaENEx>();
foreach (clsvFeatureFieldTypeRelaEN objInFor in arrObjLst)
{
clsvFeatureFieldTypeRelaENEx objvFeatureFieldTypeRelaENEx = new clsvFeatureFieldTypeRelaENEx();
clsvFeatureFieldTypeRelaBL.CopyTo(objInFor, objvFeatureFieldTypeRelaENEx);
arrObjExLst.Add(objvFeatureFieldTypeRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFeatureFieldTypeRelaENEx GetObjExBymId(long lngmId)
{
clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = clsvFeatureFieldTypeRelaBL.GetObjBymId(lngmId);
clsvFeatureFieldTypeRelaENEx objvFeatureFieldTypeRelaENEx = new clsvFeatureFieldTypeRelaENEx();
clsvFeatureFieldTypeRelaBL.CopyTo(objvFeatureFieldTypeRelaEN, objvFeatureFieldTypeRelaENEx);
return objvFeatureFieldTypeRelaENEx;
}
}
}