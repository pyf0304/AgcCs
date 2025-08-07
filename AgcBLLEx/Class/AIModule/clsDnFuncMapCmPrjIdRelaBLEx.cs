
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapCmPrjIdRelaBLEx
 表名:DnFuncMapCmPrjIdRela(00050619)
 * 版本:2023.03.02.1(服务器:WIN-SRV103-116)
 日期:2023/03/05 04:14:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_DnFuncMapCmPrjIdRelaEx: RelatedActions_DnFuncMapCmPrjIdRela
{
public override bool UpdRelaTabDate(string strDnFuncMapId,string strCmPrjId, string strOpUser)
{
return true;
}
}
public static class clsDnFuncMapCmPrjIdRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsDnFuncMapCmPrjIdRelaEN:objDnFuncMapCmPrjIdRelaENT</returns>
 public static clsDnFuncMapCmPrjIdRelaENEx CopyToEx(this clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaENS)
{
try
{
 clsDnFuncMapCmPrjIdRelaENEx objDnFuncMapCmPrjIdRelaENT = new clsDnFuncMapCmPrjIdRelaENEx();
clsDnFuncMapCmPrjIdRelaBL.DnFuncMapCmPrjIdRelaDA.CopyTo(objDnFuncMapCmPrjIdRelaENS, objDnFuncMapCmPrjIdRelaENT);
 return objDnFuncMapCmPrjIdRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsDnFuncMapCmPrjIdRelaEN:objDnFuncMapCmPrjIdRelaENT</returns>
 public static clsDnFuncMapCmPrjIdRelaEN CopyTo(this clsDnFuncMapCmPrjIdRelaENEx objDnFuncMapCmPrjIdRelaENS)
{
try
{
 clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaENT = new clsDnFuncMapCmPrjIdRelaEN();
clsDnFuncMapCmPrjIdRelaBL.CopyTo(objDnFuncMapCmPrjIdRelaENS, objDnFuncMapCmPrjIdRelaENT);
 return objDnFuncMapCmPrjIdRelaENT;
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
 /// 结点函数映射CmPrjId关系(DnFuncMapCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDnFuncMapCmPrjIdRelaBLEx : clsDnFuncMapCmPrjIdRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDnFuncMapCmPrjIdRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDnFuncMapCmPrjIdRelaDAEx DnFuncMapCmPrjIdRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDnFuncMapCmPrjIdRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsDnFuncMapCmPrjIdRelaEN:objDnFuncMapCmPrjIdRelaENT</returns>
 public static clsDnFuncMapCmPrjIdRelaENEx CopyToEx(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaENS)
{
try
{
 clsDnFuncMapCmPrjIdRelaENEx objDnFuncMapCmPrjIdRelaENT = new clsDnFuncMapCmPrjIdRelaENEx();
clsDnFuncMapCmPrjIdRelaBL.DnFuncMapCmPrjIdRelaDA.CopyTo(objDnFuncMapCmPrjIdRelaENS, objDnFuncMapCmPrjIdRelaENT);
 return objDnFuncMapCmPrjIdRelaENT;
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
public static List<clsDnFuncMapCmPrjIdRelaENEx> GetObjExLst(string strCondition)
{
List <clsDnFuncMapCmPrjIdRelaEN> arrObjLst = clsDnFuncMapCmPrjIdRelaBL.GetObjLst(strCondition);
List <clsDnFuncMapCmPrjIdRelaENEx> arrObjExLst = new List<clsDnFuncMapCmPrjIdRelaENEx>();
foreach (clsDnFuncMapCmPrjIdRelaEN objInFor in arrObjLst)
{
clsDnFuncMapCmPrjIdRelaENEx objDnFuncMapCmPrjIdRelaENEx = new clsDnFuncMapCmPrjIdRelaENEx();
clsDnFuncMapCmPrjIdRelaBL.CopyTo(objInFor, objDnFuncMapCmPrjIdRelaENEx);
arrObjExLst.Add(objDnFuncMapCmPrjIdRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDnFuncMapCmPrjIdRelaENEx GetObjExByKeyLst(string strDnFuncMapId,string strCmPrjId)
{
clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = clsDnFuncMapCmPrjIdRelaBL.GetObjByKeyLst(strDnFuncMapId,strCmPrjId);
clsDnFuncMapCmPrjIdRelaENEx objDnFuncMapCmPrjIdRelaENEx = new clsDnFuncMapCmPrjIdRelaENEx();
clsDnFuncMapCmPrjIdRelaBL.CopyTo(objDnFuncMapCmPrjIdRelaEN, objDnFuncMapCmPrjIdRelaENEx);
return objDnFuncMapCmPrjIdRelaENEx;
}
}
}