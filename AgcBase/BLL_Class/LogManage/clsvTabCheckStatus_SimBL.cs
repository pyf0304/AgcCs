
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckStatus_SimBL
 表名:vTabCheckStatus_Sim(00050599)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:57:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvTabCheckStatus_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckStatus_SimEN GetObj(this K_mId_vTabCheckStatus_Sim myKey)
{
clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = clsvTabCheckStatus_SimBL.vTabCheckStatus_SimDA.GetObjBymId(myKey.Value);
return objvTabCheckStatus_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetmId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, long lngmId, string strComparisonOp="")
	{
objvTabCheckStatus_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.mId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.mId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.mId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetPrjId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabCheckStatus_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabCheckStatus_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabCheckStatus_Sim.PrjId);
}
objvTabCheckStatus_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.PrjId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.PrjId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.PrjId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetTabId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabCheckStatus_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabCheckStatus_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabCheckStatus_Sim.TabId);
}
objvTabCheckStatus_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.TabId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.TabId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.TabId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetErrorLevelId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, convTabCheckStatus_Sim.ErrorLevelId);
objvTabCheckStatus_SimEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.ErrorLevelId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.ErrorLevelId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorLevelId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetErrorMsg(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strErrorMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, convTabCheckStatus_Sim.ErrorMsg);
}
objvTabCheckStatus_SimEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.ErrorMsg) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.ErrorMsg, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorMsg] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckStatus_SimEN SetPrjDataBaseId(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convTabCheckStatus_Sim.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convTabCheckStatus_Sim.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convTabCheckStatus_Sim.PrjDataBaseId);
}
objvTabCheckStatus_SimEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckStatus_SimEN.dicFldComparisonOp.ContainsKey(convTabCheckStatus_Sim.PrjDataBaseId) == false)
{
objvTabCheckStatus_SimEN.dicFldComparisonOp.Add(convTabCheckStatus_Sim.PrjDataBaseId, strComparisonOp);
}
else
{
objvTabCheckStatus_SimEN.dicFldComparisonOp[convTabCheckStatus_Sim.PrjDataBaseId] = strComparisonOp;
}
}
return objvTabCheckStatus_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <param name = "objvTabCheckStatus_SimENT">目标对象</param>
 public static void CopyTo(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENS, clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENT)
{
try
{
objvTabCheckStatus_SimENT.mId = objvTabCheckStatus_SimENS.mId; //mId
objvTabCheckStatus_SimENT.PrjId = objvTabCheckStatus_SimENS.PrjId; //工程Id
objvTabCheckStatus_SimENT.TabId = objvTabCheckStatus_SimENS.TabId; //表ID
objvTabCheckStatus_SimENT.ErrorLevelId = objvTabCheckStatus_SimENS.ErrorLevelId; //错误等级Id
objvTabCheckStatus_SimENT.ErrorMsg = objvTabCheckStatus_SimENS.ErrorMsg; //错误信息
objvTabCheckStatus_SimENT.PrjDataBaseId = objvTabCheckStatus_SimENS.PrjDataBaseId; //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <returns>目标对象=>clsvTabCheckStatus_SimEN:objvTabCheckStatus_SimENT</returns>
 public static clsvTabCheckStatus_SimEN CopyTo(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENS)
{
try
{
 clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENT = new clsvTabCheckStatus_SimEN()
{
mId = objvTabCheckStatus_SimENS.mId, //mId
PrjId = objvTabCheckStatus_SimENS.PrjId, //工程Id
TabId = objvTabCheckStatus_SimENS.TabId, //表ID
ErrorLevelId = objvTabCheckStatus_SimENS.ErrorLevelId, //错误等级Id
ErrorMsg = objvTabCheckStatus_SimENS.ErrorMsg, //错误信息
PrjDataBaseId = objvTabCheckStatus_SimENS.PrjDataBaseId, //项目数据库Id
};
 return objvTabCheckStatus_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN)
{
 clsvTabCheckStatus_SimBL.vTabCheckStatus_SimDA.CheckProperty4Condition(objvTabCheckStatus_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabCheckStatus_SimEN objvTabCheckStatus_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.mId) == true)
{
string strComparisonOpmId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckStatus_Sim.mId, objvTabCheckStatus_SimCond.mId, strComparisonOpmId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.PrjId, objvTabCheckStatus_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.TabId) == true)
{
string strComparisonOpTabId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.TabId, objvTabCheckStatus_SimCond.TabId, strComparisonOpTabId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckStatus_Sim.ErrorLevelId, objvTabCheckStatus_SimCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.ErrorMsg, objvTabCheckStatus_SimCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objvTabCheckStatus_SimCond.IsUpdated(convTabCheckStatus_Sim.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvTabCheckStatus_SimCond.dicFldComparisonOp[convTabCheckStatus_Sim.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckStatus_Sim.PrjDataBaseId, objvTabCheckStatus_SimCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabCheckStatus_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表检查状态_Sim(vTabCheckStatus_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabCheckStatus_SimBL
{
public static RelatedActions_vTabCheckStatus_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabCheckStatus_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabCheckStatus_SimDA vTabCheckStatus_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabCheckStatus_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabCheckStatus_SimBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvTabCheckStatus_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabCheckStatus_SimEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vTabCheckStatus_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable_vTabCheckStatus_Sim(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabCheckStatus_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabCheckStatus_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId, string strPrjDataBaseId)
{
string strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = GetObjLstCache(strPrjId, strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLst_Sel =
arrvTabCheckStatus_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvTabCheckStatus_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLst(string strWhereCond)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabCheckStatus_SimEN> GetSubObjLstCache(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimCond)
{
 string strPrjId = objvTabCheckStatus_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTabCheckStatus_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
 string strPrjDataBaseId = objvTabCheckStatus_SimCond.PrjDataBaseId;
 if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
string strMsg = string.Format("(errid:Busi000175)在表中,缓存分类字段值2不能为空!(clsvTabCheckStatus_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTabCheckStatus_SimEN> arrObjLstCache = GetObjLstCache(strPrjId, strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabCheckStatus_Sim._AttributeName)
{
if (objvTabCheckStatus_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabCheckStatus_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckStatus_SimCond[strFldName].ToString());
}
else
{
if (objvTabCheckStatus_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabCheckStatus_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckStatus_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabCheckStatus_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabCheckStatus_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabCheckStatus_SimCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabCheckStatus_SimEN> arrObjLst = new List<clsvTabCheckStatus_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = new clsvTabCheckStatus_SimEN();
try
{
objvTabCheckStatus_SimEN.mId = Int32.Parse(objRow[convTabCheckStatus_Sim.mId].ToString().Trim()); //mId
objvTabCheckStatus_SimEN.PrjId = objRow[convTabCheckStatus_Sim.PrjId].ToString().Trim(); //工程Id
objvTabCheckStatus_SimEN.TabId = objRow[convTabCheckStatus_Sim.TabId].ToString().Trim(); //表ID
objvTabCheckStatus_SimEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckStatus_Sim.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckStatus_SimEN.ErrorMsg = objRow[convTabCheckStatus_Sim.ErrorMsg] == DBNull.Value ? null : objRow[convTabCheckStatus_Sim.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckStatus_SimEN.PrjDataBaseId = objRow[convTabCheckStatus_Sim.PrjDataBaseId].ToString().Trim(); //项目数据库Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckStatus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckStatus_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabCheckStatus_Sim(ref clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN)
{
bool bolResult = vTabCheckStatus_SimDA.GetvTabCheckStatus_Sim(ref objvTabCheckStatus_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckStatus_SimEN GetObjBymId(long lngmId)
{
clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = vTabCheckStatus_SimDA.GetObjBymId(lngmId);
return objvTabCheckStatus_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabCheckStatus_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = vTabCheckStatus_SimDA.GetFirstObj(strWhereCond);
 return objvTabCheckStatus_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTabCheckStatus_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = vTabCheckStatus_SimDA.GetObjByDataRow(objRow);
 return objvTabCheckStatus_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTabCheckStatus_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN = vTabCheckStatus_SimDA.GetObjByDataRow(objRow);
 return objvTabCheckStatus_SimEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvTabCheckStatus_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabCheckStatus_SimEN GetObjBymIdFromList(long lngmId, List<clsvTabCheckStatus_SimEN> lstvTabCheckStatus_SimObjLst)
{
foreach (clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN in lstvTabCheckStatus_SimObjLst)
{
if (objvTabCheckStatus_SimEN.mId == lngmId)
{
return objvTabCheckStatus_SimEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvTabCheckStatus_SimDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vTabCheckStatus_SimDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vTabCheckStatus_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vTabCheckStatus_SimDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvTabCheckStatus_SimDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vTabCheckStatus_SimDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimENS">源对象</param>
 /// <param name = "objvTabCheckStatus_SimENT">目标对象</param>
 public static void CopyTo(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENS, clsvTabCheckStatus_SimEN objvTabCheckStatus_SimENT)
{
try
{
objvTabCheckStatus_SimENT.mId = objvTabCheckStatus_SimENS.mId; //mId
objvTabCheckStatus_SimENT.PrjId = objvTabCheckStatus_SimENS.PrjId; //工程Id
objvTabCheckStatus_SimENT.TabId = objvTabCheckStatus_SimENS.TabId; //表ID
objvTabCheckStatus_SimENT.ErrorLevelId = objvTabCheckStatus_SimENS.ErrorLevelId; //错误等级Id
objvTabCheckStatus_SimENT.ErrorMsg = objvTabCheckStatus_SimENS.ErrorMsg; //错误信息
objvTabCheckStatus_SimENT.PrjDataBaseId = objvTabCheckStatus_SimENS.PrjDataBaseId; //项目数据库Id
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN)
{
try
{
objvTabCheckStatus_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabCheckStatus_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabCheckStatus_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.mId = objvTabCheckStatus_SimEN.mId; //mId
}
if (arrFldSet.Contains(convTabCheckStatus_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.PrjId = objvTabCheckStatus_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabCheckStatus_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.TabId = objvTabCheckStatus_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabCheckStatus_Sim.ErrorLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.ErrorLevelId = objvTabCheckStatus_SimEN.ErrorLevelId; //错误等级Id
}
if (arrFldSet.Contains(convTabCheckStatus_Sim.ErrorMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.ErrorMsg = objvTabCheckStatus_SimEN.ErrorMsg == "[null]" ? null :  objvTabCheckStatus_SimEN.ErrorMsg; //错误信息
}
if (arrFldSet.Contains(convTabCheckStatus_Sim.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckStatus_SimEN.PrjDataBaseId = objvTabCheckStatus_SimEN.PrjDataBaseId; //项目数据库Id
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN)
{
try
{
if (objvTabCheckStatus_SimEN.ErrorMsg == "[null]") objvTabCheckStatus_SimEN.ErrorMsg = null; //错误信息
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimEN)
{
 vTabCheckStatus_SimDA.CheckProperty4Condition(objvTabCheckStatus_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsTabCheckStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckStatusBL没有刷新缓存机制(clsTabCheckStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTabCheckStatus_SimObjLstCache == null)
//{
//arrvTabCheckStatus_SimObjLstCache = vTabCheckStatus_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strPrjDataBaseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabCheckStatus_SimEN GetObjBymIdCache(long lngmId, string strPrjId, string strPrjDataBaseId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
  var strMsg = string.Format("参数:[strPrjDataBaseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjDataBaseId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjDataBaseId]的长度:[{0}]不正确!(In {1})", strPrjDataBaseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = GetObjLstCache(strPrjId, strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLst_Sel =
arrvTabCheckStatus_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvTabCheckStatus_SimObjLst_Sel.Count() == 0)
{
   clsvTabCheckStatus_SimEN obj = clsvTabCheckStatus_SimBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTabCheckStatus_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetAllvTabCheckStatus_SimObjLstCache(string strPrjId, string strPrjDataBaseId)
{
//获取缓存中的对象列表
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = GetObjLstCache(strPrjId, strPrjDataBaseId); 
return arrvTabCheckStatus_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckStatus_SimEN> GetObjLstCache(string strPrjId, string strPrjDataBaseId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
  var strMsg = string.Format("参数:[strPrjDataBaseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjDataBaseId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjDataBaseId]的长度:[{0}]不正确!(In {1})", strPrjDataBaseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
strCondition += string.Format(" and PrjDataBaseId='{0}'", strPrjDataBaseId); 
List<clsvTabCheckStatus_SimEN> arrvTabCheckStatus_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition);});
return arrvTabCheckStatus_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId, string strPrjDataBaseId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}_{2}", clsvTabCheckStatus_SimEN._CurrTabName, strPrjId, strPrjDataBaseId);
CacheHelper.Remove(strKey);
clsvTabCheckStatus_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvTabCheckStatus_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvTabCheckStatus_SimEN._RefreshTimeLst[clsvTabCheckStatus_SimEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strPrjDataBaseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId, string strPrjDataBaseId)
{
if (strInFldName != convTabCheckStatus_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabCheckStatus_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabCheckStatus_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvTabCheckStatus_Sim = clsvTabCheckStatus_SimBL.GetObjBymIdCache(lngmId, strPrjId, strPrjDataBaseId);
if (objvTabCheckStatus_Sim == null) return "";
return objvTabCheckStatus_Sim[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvTabCheckStatus_SimDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvTabCheckStatus_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabCheckStatus_SimDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvTabCheckStatus_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabCheckStatus_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabCheckStatus_SimEN objvTabCheckStatus_SimCond)
{
 string strPrjId = objvTabCheckStatus_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTabCheckStatus_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
 string strPrjDataBaseId = objvTabCheckStatus_SimCond.PrjDataBaseId;
 if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
string strMsg = string.Format("(errid:Busi000176)在表中,缓存分类字段值2不能为空!(clsvTabCheckStatus_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTabCheckStatus_SimEN> arrObjLstCache = GetObjLstCache(strPrjId, strPrjDataBaseId);
IEnumerable <clsvTabCheckStatus_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabCheckStatus_Sim._AttributeName)
{
if (objvTabCheckStatus_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabCheckStatus_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckStatus_SimCond[strFldName].ToString());
}
else
{
if (objvTabCheckStatus_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabCheckStatus_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckStatus_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabCheckStatus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabCheckStatus_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabCheckStatus_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabCheckStatus_SimCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvTabCheckStatus_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vTabCheckStatus_SimDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vTabCheckStatus_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}