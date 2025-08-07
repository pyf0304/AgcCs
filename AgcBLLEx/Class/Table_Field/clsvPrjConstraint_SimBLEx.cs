
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraint_SimBLEx
 表名:vPrjConstraint_Sim(00050638)
 * 版本:2025.01.04.1(服务器:WIN-SRV103-116)
 日期:2025/02/06 07:38:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 public class RelatedActions_vPrjConstraint_SimEx: RelatedActions_vPrjConstraint_Sim
{
public override bool UpdRelaTabDate(string strPrjConstraintId, string strOpUser)
{
return true;
}
}
public static class  clsvPrjConstraint_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjConstraint_SimEN:objvPrjConstraint_SimENT</returns>
 public static clsvPrjConstraint_SimENEx CopyToEx(this clsvPrjConstraint_SimEN objvPrjConstraint_SimENS)
{
try
{
 clsvPrjConstraint_SimENEx objvPrjConstraint_SimENT = new clsvPrjConstraint_SimENEx();
clsvPrjConstraint_SimBL.vPrjConstraint_SimDA.CopyTo(objvPrjConstraint_SimENS, objvPrjConstraint_SimENT);
 return objvPrjConstraint_SimENT;
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
 /// <param name = "objvPrjConstraint_SimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjConstraint_SimEN:objvPrjConstraint_SimENT</returns>
 public static clsvPrjConstraint_SimEN CopyTo(this clsvPrjConstraint_SimENEx objvPrjConstraint_SimENS)
{
try
{
 clsvPrjConstraint_SimEN objvPrjConstraint_SimENT = new clsvPrjConstraint_SimEN();
clsvPrjConstraint_SimBL.CopyTo(objvPrjConstraint_SimENS, objvPrjConstraint_SimENT);
 return objvPrjConstraint_SimENT;
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
 /// vPrjConstraint_Sim(vPrjConstraint_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvPrjConstraint_SimBLEx : clsvPrjConstraint_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvPrjConstraint_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvPrjConstraint_SimDAEx vPrjConstraint_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvPrjConstraint_SimDAEx();
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
public static List<clsvPrjConstraint_SimENEx> GetObjExLst(string strCondition)
{
List <clsvPrjConstraint_SimEN> arrObjLst = clsvPrjConstraint_SimBL.GetObjLst(strCondition);
List <clsvPrjConstraint_SimENEx> arrObjExLst = new List<clsvPrjConstraint_SimENEx>();
foreach (clsvPrjConstraint_SimEN objInFor in arrObjLst)
{
clsvPrjConstraint_SimENEx objvPrjConstraint_SimENEx = new clsvPrjConstraint_SimENEx();
clsvPrjConstraint_SimBL.CopyTo(objInFor, objvPrjConstraint_SimENEx);
arrObjExLst.Add(objvPrjConstraint_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvPrjConstraint_SimENEx GetObjExByPrjConstraintId(string strPrjConstraintId)
{
clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = clsvPrjConstraint_SimBL.GetObjByPrjConstraintId(strPrjConstraintId);
clsvPrjConstraint_SimENEx objvPrjConstraint_SimENEx = new clsvPrjConstraint_SimENEx();
clsvPrjConstraint_SimBL.CopyTo(objvPrjConstraint_SimEN, objvPrjConstraint_SimENEx);
return objvPrjConstraint_SimENEx;
}
}
}