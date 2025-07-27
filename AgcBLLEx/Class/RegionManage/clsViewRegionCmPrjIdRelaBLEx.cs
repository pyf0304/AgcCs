
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionCmPrjIdRelaBLEx
 表名:ViewRegionCmPrjIdRela(00050622)
 * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
 日期:2023/03/01 23:24:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 public class RelatedActions_ViewRegionCmPrjIdRelaEx: RelatedActions_ViewRegionCmPrjIdRela
{
public override bool UpdRelaTabDate(string strRegionId,string strCmPrjId, string strOpUser)
{
return true;
}
}
public static class clsViewRegionCmPrjIdRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionCmPrjIdRelaEN:objViewRegionCmPrjIdRelaENT</returns>
 public static clsViewRegionCmPrjIdRelaENEx CopyToEx(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS)
{
try
{
 clsViewRegionCmPrjIdRelaENEx objViewRegionCmPrjIdRelaENT = new clsViewRegionCmPrjIdRelaENEx();
clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.CopyTo(objViewRegionCmPrjIdRelaENS, objViewRegionCmPrjIdRelaENT);
 return objViewRegionCmPrjIdRelaENT;
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
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionCmPrjIdRelaEN:objViewRegionCmPrjIdRelaENT</returns>
 public static clsViewRegionCmPrjIdRelaEN CopyTo(this clsViewRegionCmPrjIdRelaENEx objViewRegionCmPrjIdRelaENS)
{
try
{
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENT = new clsViewRegionCmPrjIdRelaEN();
clsViewRegionCmPrjIdRelaBL.CopyTo(objViewRegionCmPrjIdRelaENS, objViewRegionCmPrjIdRelaENT);
 return objViewRegionCmPrjIdRelaENT;
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
 /// 界面区域CmPrjId关系(ViewRegionCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsViewRegionCmPrjIdRelaBLEx : clsViewRegionCmPrjIdRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsViewRegionCmPrjIdRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsViewRegionCmPrjIdRelaDAEx ViewRegionCmPrjIdRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsViewRegionCmPrjIdRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionCmPrjIdRelaEN:objViewRegionCmPrjIdRelaENT</returns>
 public static clsViewRegionCmPrjIdRelaENEx CopyToEx(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS)
{
try
{
 clsViewRegionCmPrjIdRelaENEx objViewRegionCmPrjIdRelaENT = new clsViewRegionCmPrjIdRelaENEx();
clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.CopyTo(objViewRegionCmPrjIdRelaENS, objViewRegionCmPrjIdRelaENT);
 return objViewRegionCmPrjIdRelaENT;
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
public static List<clsViewRegionCmPrjIdRelaENEx> GetObjExLst(string strCondition)
{
List <clsViewRegionCmPrjIdRelaEN> arrObjLst = clsViewRegionCmPrjIdRelaBL.GetObjLst(strCondition);
List <clsViewRegionCmPrjIdRelaENEx> arrObjExLst = new List<clsViewRegionCmPrjIdRelaENEx>();
foreach (clsViewRegionCmPrjIdRelaEN objInFor in arrObjLst)
{
clsViewRegionCmPrjIdRelaENEx objViewRegionCmPrjIdRelaENEx = new clsViewRegionCmPrjIdRelaENEx();
clsViewRegionCmPrjIdRelaBL.CopyTo(objInFor, objViewRegionCmPrjIdRelaENEx);
arrObjExLst.Add(objViewRegionCmPrjIdRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsViewRegionCmPrjIdRelaENEx GetObjExByKeyLst(string strRegionId,string strCmPrjId)
{
clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = clsViewRegionCmPrjIdRelaBL.GetObjByKeyLst(strRegionId,strCmPrjId);
clsViewRegionCmPrjIdRelaENEx objViewRegionCmPrjIdRelaENEx = new clsViewRegionCmPrjIdRelaENEx();
clsViewRegionCmPrjIdRelaBL.CopyTo(objViewRegionCmPrjIdRelaEN, objViewRegionCmPrjIdRelaENEx);
return objViewRegionCmPrjIdRelaENEx;
}
}
}