
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRetrievalMethodBLEx
 表名:RetrievalMethod(00050632)
 * 版本:2024.05.19.1(服务器:WIN-SRV103-116)
 日期:2024/05/23 20:25:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
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
 public class RelatedActions_RetrievalMethodEx: RelatedActions_RetrievalMethod
{
public override bool UpdRelaTabDate(string strRetrievalMethodId, string strOpUser)
{
return true;
}
}
public static class  clsRetrievalMethodBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <returns>目标对象=>clsRetrievalMethodEN:objRetrievalMethodENT</returns>
 public static clsRetrievalMethodENEx CopyToEx(this clsRetrievalMethodEN objRetrievalMethodENS)
{
try
{
 clsRetrievalMethodENEx objRetrievalMethodENT = new clsRetrievalMethodENEx();
clsRetrievalMethodBL.RetrievalMethodDA.CopyTo(objRetrievalMethodENS, objRetrievalMethodENT);
 return objRetrievalMethodENT;
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
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <returns>目标对象=>clsRetrievalMethodEN:objRetrievalMethodENT</returns>
 public static clsRetrievalMethodEN CopyTo(this clsRetrievalMethodENEx objRetrievalMethodENS)
{
try
{
 clsRetrievalMethodEN objRetrievalMethodENT = new clsRetrievalMethodEN();
clsRetrievalMethodBL.CopyTo(objRetrievalMethodENS, objRetrievalMethodENT);
 return objRetrievalMethodENT;
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
 /// 获取方式(RetrievalMethod)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsRetrievalMethodBLEx : clsRetrievalMethodBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsRetrievalMethodDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsRetrievalMethodDAEx RetrievalMethodDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsRetrievalMethodDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <returns>目标对象=>clsRetrievalMethodEN:objRetrievalMethodENT</returns>
 public static clsRetrievalMethodENEx CopyToEx(clsRetrievalMethodEN objRetrievalMethodENS)
{
try
{
 clsRetrievalMethodENEx objRetrievalMethodENT = new clsRetrievalMethodENEx();
clsRetrievalMethodBL.RetrievalMethodDA.CopyTo(objRetrievalMethodENS, objRetrievalMethodENT);
 return objRetrievalMethodENT;
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
public static List<clsRetrievalMethodENEx> GetObjExLst(string strCondition)
{
List <clsRetrievalMethodEN> arrObjLst = clsRetrievalMethodBL.GetObjLst(strCondition);
List <clsRetrievalMethodENEx> arrObjExLst = new List<clsRetrievalMethodENEx>();
foreach (clsRetrievalMethodEN objInFor in arrObjLst)
{
clsRetrievalMethodENEx objRetrievalMethodENEx = new clsRetrievalMethodENEx();
clsRetrievalMethodBL.CopyTo(objInFor, objRetrievalMethodENEx);
arrObjExLst.Add(objRetrievalMethodENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strRetrievalMethodId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsRetrievalMethodENEx GetObjExByRetrievalMethodId(string strRetrievalMethodId)
{
clsRetrievalMethodEN objRetrievalMethodEN = clsRetrievalMethodBL.GetObjByRetrievalMethodId(strRetrievalMethodId);
clsRetrievalMethodENEx objRetrievalMethodENEx = new clsRetrievalMethodENEx();
clsRetrievalMethodBL.CopyTo(objRetrievalMethodEN, objRetrievalMethodENEx);
return objRetrievalMethodENEx;
}
}
}