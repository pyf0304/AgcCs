
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeType_SimBLEx
 表名:vCodeType_Sim(00050623)
 * 版本:2023.03.02.1(服务器:WIN-SRV103-116)
 日期:2023/03/03 12:34:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 public class RelatedActions_vCodeType_SimEx: RelatedActions_vCodeType_Sim
{
public override bool UpdRelaTabDate(string strCodeTypeId, string strOpUser)
{
return true;
}
}
public static class clsvCodeType_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCodeType_SimEN:objvCodeType_SimENT</returns>
 public static clsvCodeType_SimENEx CopyToEx(this clsvCodeType_SimEN objvCodeType_SimENS)
{
try
{
 clsvCodeType_SimENEx objvCodeType_SimENT = new clsvCodeType_SimENEx();
clsvCodeType_SimBL.vCodeType_SimDA.CopyTo(objvCodeType_SimENS, objvCodeType_SimENT);
 return objvCodeType_SimENT;
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
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCodeType_SimEN:objvCodeType_SimENT</returns>
 public static clsvCodeType_SimEN CopyTo(this clsvCodeType_SimENEx objvCodeType_SimENS)
{
try
{
 clsvCodeType_SimEN objvCodeType_SimENT = new clsvCodeType_SimEN();
clsvCodeType_SimBL.CopyTo(objvCodeType_SimENS, objvCodeType_SimENT);
 return objvCodeType_SimENT;
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
 /// vCodeType_Sim(vCodeType_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvCodeType_SimBLEx : clsvCodeType_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCodeType_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCodeType_SimDAEx vCodeType_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCodeType_SimDAEx();
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
public static List<clsvCodeType_SimENEx> GetObjExLst(string strCondition)
{
List <clsvCodeType_SimEN> arrObjLst = clsvCodeType_SimBL.GetObjLst(strCondition);
List <clsvCodeType_SimENEx> arrObjExLst = new List<clsvCodeType_SimENEx>();
foreach (clsvCodeType_SimEN objInFor in arrObjLst)
{
clsvCodeType_SimENEx objvCodeType_SimENEx = new clsvCodeType_SimENEx();
clsvCodeType_SimBL.CopyTo(objInFor, objvCodeType_SimENEx);
arrObjExLst.Add(objvCodeType_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCodeType_SimENEx GetObjExByCodeTypeId(string strCodeTypeId)
{
clsvCodeType_SimEN objvCodeType_SimEN = clsvCodeType_SimBL.GetObjByCodeTypeId(strCodeTypeId);
clsvCodeType_SimENEx objvCodeType_SimENEx = new clsvCodeType_SimENEx();
clsvCodeType_SimBL.CopyTo(objvCodeType_SimEN, objvCodeType_SimENEx);
return objvCodeType_SimENEx;
}
}
}