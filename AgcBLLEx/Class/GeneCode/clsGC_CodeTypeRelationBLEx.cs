
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGC_CodeTypeRelationBLEx
 表名:GC_CodeTypeRelation(00050646)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/05 03:10:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx,0021)
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
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_GC_CodeTypeRelationEx: RelatedActions_GC_CodeTypeRelation
{
public override bool UpdRelaTabDate(long lngRelationId, string strOpUser)
{
return true;
}
}
public static class  clsGC_CodeTypeRelationBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <returns>目标对象=>clsGC_CodeTypeRelationEN:objGC_CodeTypeRelationENT</returns>
 public static clsGC_CodeTypeRelationENEx CopyToEx(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENS)
{
try
{
 clsGC_CodeTypeRelationENEx objGC_CodeTypeRelationENT = new clsGC_CodeTypeRelationENEx();
clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.CopyTo(objGC_CodeTypeRelationENS, objGC_CodeTypeRelationENT);
 return objGC_CodeTypeRelationENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <returns>目标对象=>clsGC_CodeTypeRelationEN:objGC_CodeTypeRelationENT</returns>
 public static clsGC_CodeTypeRelationEN CopyTo(this clsGC_CodeTypeRelationENEx objGC_CodeTypeRelationENS)
{
try
{
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENT = new clsGC_CodeTypeRelationEN();
clsGC_CodeTypeRelationBL.CopyTo(objGC_CodeTypeRelationENS, objGC_CodeTypeRelationENT);
 return objGC_CodeTypeRelationENT;
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
 /// GC_代码类型关系(GC_CodeTypeRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsGC_CodeTypeRelationBLEx : clsGC_CodeTypeRelationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsGC_CodeTypeRelationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsGC_CodeTypeRelationDAEx GC_CodeTypeRelationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsGC_CodeTypeRelationDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <returns>目标对象=>clsGC_CodeTypeRelationEN:objGC_CodeTypeRelationENT</returns>
 public static clsGC_CodeTypeRelationENEx CopyToEx(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENS)
{
try
{
 clsGC_CodeTypeRelationENEx objGC_CodeTypeRelationENT = new clsGC_CodeTypeRelationENEx();
clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.CopyTo(objGC_CodeTypeRelationENS, objGC_CodeTypeRelationENT);
 return objGC_CodeTypeRelationENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
public static List<clsGC_CodeTypeRelationENEx> GetObjExLst(string strCondition)
{
List <clsGC_CodeTypeRelationEN> arrObjLst = clsGC_CodeTypeRelationBL.GetObjLst(strCondition);
List <clsGC_CodeTypeRelationENEx> arrObjExLst = new List<clsGC_CodeTypeRelationENEx>();
foreach (clsGC_CodeTypeRelationEN objInFor in arrObjLst)
{
clsGC_CodeTypeRelationENEx objGC_CodeTypeRelationENEx = new clsGC_CodeTypeRelationENEx();
clsGC_CodeTypeRelationBL.CopyTo(objInFor, objGC_CodeTypeRelationENEx);
arrObjExLst.Add(objGC_CodeTypeRelationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngRelationId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsGC_CodeTypeRelationENEx GetObjExByRelationId(long lngRelationId)
{
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = clsGC_CodeTypeRelationBL.GetObjByRelationId(lngRelationId);
clsGC_CodeTypeRelationENEx objGC_CodeTypeRelationENEx = new clsGC_CodeTypeRelationENEx();
clsGC_CodeTypeRelationBL.CopyTo(objGC_CodeTypeRelationEN, objGC_CodeTypeRelationENEx);
return objGC_CodeTypeRelationENEx;
}
}
}