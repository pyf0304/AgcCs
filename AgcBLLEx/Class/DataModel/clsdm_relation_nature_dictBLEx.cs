
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_relation_nature_dictBLEx
 表名:dm_relation_nature_dict(00050660)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 10:53:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型(DataModel)
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
 public class RelatedActions_dm_relation_nature_dictEx: RelatedActions_dm_relation_nature_dict
{
public override bool UpdRelaTabDate(string strnature_code, string strOpUser)
{
return true;
}
}
public static class  clsdm_relation_nature_dictBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objdm_relation_nature_dictENS">源对象</param>
 /// <returns>目标对象=>clsdm_relation_nature_dictEN:objdm_relation_nature_dictENT</returns>
 public static clsdm_relation_nature_dictENEx CopyToEx(this clsdm_relation_nature_dictEN objdm_relation_nature_dictENS)
{
try
{
 clsdm_relation_nature_dictENEx objdm_relation_nature_dictENT = new clsdm_relation_nature_dictENEx();
clsdm_relation_nature_dictBL.dm_relation_nature_dictDA.CopyTo(objdm_relation_nature_dictENS, objdm_relation_nature_dictENT);
 return objdm_relation_nature_dictENT;
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
 /// <param name = "objdm_relation_nature_dictENS">源对象</param>
 /// <returns>目标对象=>clsdm_relation_nature_dictEN:objdm_relation_nature_dictENT</returns>
 public static clsdm_relation_nature_dictEN CopyTo(this clsdm_relation_nature_dictENEx objdm_relation_nature_dictENS)
{
try
{
 clsdm_relation_nature_dictEN objdm_relation_nature_dictENT = new clsdm_relation_nature_dictEN();
clsdm_relation_nature_dictBL.CopyTo(objdm_relation_nature_dictENS, objdm_relation_nature_dictENT);
 return objdm_relation_nature_dictENT;
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
 /// 关系性质字典表(dm_relation_nature_dict)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsdm_relation_nature_dictBLEx : clsdm_relation_nature_dictBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsdm_relation_nature_dictDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsdm_relation_nature_dictDAEx dm_relation_nature_dictDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsdm_relation_nature_dictDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objdm_relation_nature_dictENS">源对象</param>
 /// <returns>目标对象=>clsdm_relation_nature_dictEN:objdm_relation_nature_dictENT</returns>
 public static clsdm_relation_nature_dictENEx CopyToEx(clsdm_relation_nature_dictEN objdm_relation_nature_dictENS)
{
try
{
 clsdm_relation_nature_dictENEx objdm_relation_nature_dictENT = new clsdm_relation_nature_dictENEx();
clsdm_relation_nature_dictBL.dm_relation_nature_dictDA.CopyTo(objdm_relation_nature_dictENS, objdm_relation_nature_dictENT);
 return objdm_relation_nature_dictENT;
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
public static List<clsdm_relation_nature_dictENEx> GetObjExLst(string strCondition)
{
List <clsdm_relation_nature_dictEN> arrObjLst = clsdm_relation_nature_dictBL.GetObjLst(strCondition);
List <clsdm_relation_nature_dictENEx> arrObjExLst = new List<clsdm_relation_nature_dictENEx>();
foreach (clsdm_relation_nature_dictEN objInFor in arrObjLst)
{
clsdm_relation_nature_dictENEx objdm_relation_nature_dictENEx = new clsdm_relation_nature_dictENEx();
clsdm_relation_nature_dictBL.CopyTo(objInFor, objdm_relation_nature_dictENEx);
arrObjExLst.Add(objdm_relation_nature_dictENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strnature_code">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsdm_relation_nature_dictENEx GetObjExBynature_code(string strnature_code)
{
clsdm_relation_nature_dictEN objdm_relation_nature_dictEN = clsdm_relation_nature_dictBL.GetObjBynature_code(strnature_code);
clsdm_relation_nature_dictENEx objdm_relation_nature_dictENEx = new clsdm_relation_nature_dictENEx();
clsdm_relation_nature_dictBL.CopyTo(objdm_relation_nature_dictEN, objdm_relation_nature_dictENEx);
return objdm_relation_nature_dictENEx;
}
}
}