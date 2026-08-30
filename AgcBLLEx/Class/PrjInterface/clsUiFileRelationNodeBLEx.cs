
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationNodeBLEx
 表名:UiFileRelationNode(00050654)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 public class RelatedActions_UiFileRelationNodeEx: RelatedActions_UiFileRelationNode
{
public override bool UpdRelaTabDate(long lngNodeId, string strOpUser)
{
return true;
}
}
public static class  clsUiFileRelationNodeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationNodeEN:objUiFileRelationNodeENT</returns>
 public static clsUiFileRelationNodeENEx CopyToEx(this clsUiFileRelationNodeEN objUiFileRelationNodeENS)
{
try
{
 clsUiFileRelationNodeENEx objUiFileRelationNodeENT = new clsUiFileRelationNodeENEx();
clsUiFileRelationNodeBL.UiFileRelationNodeDA.CopyTo(objUiFileRelationNodeENS, objUiFileRelationNodeENT);
 return objUiFileRelationNodeENT;
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
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationNodeEN:objUiFileRelationNodeENT</returns>
 public static clsUiFileRelationNodeEN CopyTo(this clsUiFileRelationNodeENEx objUiFileRelationNodeENS)
{
try
{
 clsUiFileRelationNodeEN objUiFileRelationNodeENT = new clsUiFileRelationNodeEN();
clsUiFileRelationNodeBL.CopyTo(objUiFileRelationNodeENS, objUiFileRelationNodeENT);
 return objUiFileRelationNodeENT;
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
 /// UiFileRelationNode(UiFileRelationNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsUiFileRelationNodeBLEx : clsUiFileRelationNodeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsUiFileRelationNodeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsUiFileRelationNodeDAEx UiFileRelationNodeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsUiFileRelationNodeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationNodeEN:objUiFileRelationNodeENT</returns>
 public static clsUiFileRelationNodeENEx CopyToEx(clsUiFileRelationNodeEN objUiFileRelationNodeENS)
{
try
{
 clsUiFileRelationNodeENEx objUiFileRelationNodeENT = new clsUiFileRelationNodeENEx();
clsUiFileRelationNodeBL.UiFileRelationNodeDA.CopyTo(objUiFileRelationNodeENS, objUiFileRelationNodeENT);
 return objUiFileRelationNodeENT;
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
public static List<clsUiFileRelationNodeENEx> GetObjExLst(string strCondition)
{
List <clsUiFileRelationNodeEN> arrObjLst = clsUiFileRelationNodeBL.GetObjLst(strCondition);
List <clsUiFileRelationNodeENEx> arrObjExLst = new List<clsUiFileRelationNodeENEx>();
foreach (clsUiFileRelationNodeEN objInFor in arrObjLst)
{
clsUiFileRelationNodeENEx objUiFileRelationNodeENEx = new clsUiFileRelationNodeENEx();
clsUiFileRelationNodeBL.CopyTo(objInFor, objUiFileRelationNodeENEx);
arrObjExLst.Add(objUiFileRelationNodeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngNodeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsUiFileRelationNodeENEx GetObjExByNodeId(long lngNodeId)
{
clsUiFileRelationNodeEN objUiFileRelationNodeEN = clsUiFileRelationNodeBL.GetObjByNodeId(lngNodeId);
clsUiFileRelationNodeENEx objUiFileRelationNodeENEx = new clsUiFileRelationNodeENEx();
clsUiFileRelationNodeBL.CopyTo(objUiFileRelationNodeEN, objUiFileRelationNodeENEx);
return objUiFileRelationNodeENEx;
}
}
}