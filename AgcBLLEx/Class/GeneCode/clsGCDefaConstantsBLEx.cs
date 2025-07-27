
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCDefaConstantsBLEx
 表名:GCDefaConstants(00050640)
 * 版本:2025.06.13.1(服务器:WIN-SRV103-116)
 日期:2025/06/17 16:31:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 public class RelatedActions_GCDefaConstantsEx: RelatedActions_GCDefaConstants
{
public override bool UpdRelaTabDate(string strConstId, string strOpUser)
{
return true;
}
}
public static class  clsGCDefaConstantsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <returns>目标对象=>clsGCDefaConstantsEN:objGCDefaConstantsENT</returns>
 public static clsGCDefaConstantsENEx CopyToEx(this clsGCDefaConstantsEN objGCDefaConstantsENS)
{
try
{
 clsGCDefaConstantsENEx objGCDefaConstantsENT = new clsGCDefaConstantsENEx();
clsGCDefaConstantsBL.GCDefaConstantsDA.CopyTo(objGCDefaConstantsENS, objGCDefaConstantsENT);
 return objGCDefaConstantsENT;
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
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <returns>目标对象=>clsGCDefaConstantsEN:objGCDefaConstantsENT</returns>
 public static clsGCDefaConstantsEN CopyTo(this clsGCDefaConstantsENEx objGCDefaConstantsENS)
{
try
{
 clsGCDefaConstantsEN objGCDefaConstantsENT = new clsGCDefaConstantsEN();
clsGCDefaConstantsBL.CopyTo(objGCDefaConstantsENS, objGCDefaConstantsENT);
 return objGCDefaConstantsENT;
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
 /// GC常量(GCDefaConstants)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsGCDefaConstantsBLEx : clsGCDefaConstantsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsGCDefaConstantsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsGCDefaConstantsDAEx GCDefaConstantsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsGCDefaConstantsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <returns>目标对象=>clsGCDefaConstantsEN:objGCDefaConstantsENT</returns>
 public static clsGCDefaConstantsENEx CopyToEx(clsGCDefaConstantsEN objGCDefaConstantsENS)
{
try
{
 clsGCDefaConstantsENEx objGCDefaConstantsENT = new clsGCDefaConstantsENEx();
clsGCDefaConstantsBL.GCDefaConstantsDA.CopyTo(objGCDefaConstantsENS, objGCDefaConstantsENT);
 return objGCDefaConstantsENT;
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
public static List<clsGCDefaConstantsENEx> GetObjExLst(string strCondition)
{
List <clsGCDefaConstantsEN> arrObjLst = clsGCDefaConstantsBL.GetObjLst(strCondition);
List <clsGCDefaConstantsENEx> arrObjExLst = new List<clsGCDefaConstantsENEx>();
foreach (clsGCDefaConstantsEN objInFor in arrObjLst)
{
clsGCDefaConstantsENEx objGCDefaConstantsENEx = new clsGCDefaConstantsENEx();
clsGCDefaConstantsBL.CopyTo(objInFor, objGCDefaConstantsENEx);
arrObjExLst.Add(objGCDefaConstantsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strConstId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsGCDefaConstantsENEx GetObjExByConstId(string strConstId)
{
clsGCDefaConstantsEN objGCDefaConstantsEN = clsGCDefaConstantsBL.GetObjByConstId(strConstId);
clsGCDefaConstantsENEx objGCDefaConstantsENEx = new clsGCDefaConstantsENEx();
clsGCDefaConstantsBL.CopyTo(objGCDefaConstantsEN, objGCDefaConstantsENEx);
return objGCDefaConstantsENEx;
}
}
}