
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFlds_TtlBLEx
 表名:vFeatureRegionFlds_Ttl(00050474)
 生成代码版本:2019.05.25.1
 生成日期:2019/05/25 23:38:39
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理
 模块英文名:RegionManage
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
public static class clsvFeatureRegionFlds_TtlBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureRegionFlds_TtlEN:objvFeatureRegionFlds_TtlENT</returns>
 public static clsvFeatureRegionFlds_TtlENEx CopyToEx(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENS)
{
try
{
 clsvFeatureRegionFlds_TtlENEx objvFeatureRegionFlds_TtlENT = new clsvFeatureRegionFlds_TtlENEx();
clsvFeatureRegionFlds_TtlBL.CopyTo(objvFeatureRegionFlds_TtlENS, objvFeatureRegionFlds_TtlENT);
 return objvFeatureRegionFlds_TtlENT;
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
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureRegionFlds_TtlEN:objvFeatureRegionFlds_TtlENT</returns>
 public static clsvFeatureRegionFlds_TtlEN CopyTo(this clsvFeatureRegionFlds_TtlENEx objvFeatureRegionFlds_TtlENS)
{
try
{
 clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENT = new clsvFeatureRegionFlds_TtlEN();
clsvFeatureRegionFlds_TtlBL.CopyTo(objvFeatureRegionFlds_TtlENS, objvFeatureRegionFlds_TtlENT);
 return objvFeatureRegionFlds_TtlENT;
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
 /// v功能区域字段列表_Ttl(vFeatureRegionFlds_Ttl)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFeatureRegionFlds_TtlBLEx : clsvFeatureRegionFlds_TtlBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFeatureRegionFlds_TtlDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFeatureRegionFlds_TtlDAEx vFeatureRegionFlds_TtlDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFeatureRegionFlds_TtlDAEx();
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
public static List<clsvFeatureRegionFlds_TtlENEx> GetObjExLst(string strCondition)
{
List <clsvFeatureRegionFlds_TtlEN> arrObjLst = clsvFeatureRegionFlds_TtlBL.GetObjLst(strCondition);
List <clsvFeatureRegionFlds_TtlENEx> arrObjExLst = new List<clsvFeatureRegionFlds_TtlENEx>();
foreach (clsvFeatureRegionFlds_TtlEN objInFor in arrObjLst)
{
clsvFeatureRegionFlds_TtlENEx objvFeatureRegionFlds_TtlENEx = new clsvFeatureRegionFlds_TtlENEx();
clsvFeatureRegionFlds_TtlBL.CopyTo(objInFor, objvFeatureRegionFlds_TtlENEx);
arrObjExLst.Add(objvFeatureRegionFlds_TtlENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFeatureRegionFlds_TtlENEx GetObjExByViewFeatureId(string strViewFeatureId)
{
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = clsvFeatureRegionFlds_TtlBL.GetObjByViewFeatureId(strViewFeatureId);
clsvFeatureRegionFlds_TtlENEx objvFeatureRegionFlds_TtlENEx = new clsvFeatureRegionFlds_TtlENEx();
clsvFeatureRegionFlds_TtlBL.CopyTo(objvFeatureRegionFlds_TtlEN, objvFeatureRegionFlds_TtlENEx);
return objvFeatureRegionFlds_TtlENEx;
}
}
}