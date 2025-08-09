
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraint_SimBL
 表名:vPrjConstraint_Sim(00050638)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjConstraint_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjConstraint_SimEN GetObj(this K_PrjConstraintId_vPrjConstraint_Sim myKey)
{
clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = clsvPrjConstraint_SimBL.vPrjConstraint_SimDA.GetObjByPrjConstraintId(myKey.Value);
return objvPrjConstraint_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetPrjConstraintId(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, string strPrjConstraintId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, convPrjConstraint_Sim.PrjConstraintId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, convPrjConstraint_Sim.PrjConstraintId);
}
objvPrjConstraint_SimEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.PrjConstraintId) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.PrjConstraintId, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.PrjConstraintId] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetConstraintName(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, convPrjConstraint_Sim.ConstraintName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintName, 100, convPrjConstraint_Sim.ConstraintName);
}
objvPrjConstraint_SimEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.ConstraintName) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.ConstraintName, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.ConstraintName] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetPrjId(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjConstraint_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjConstraint_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjConstraint_Sim.PrjId);
}
objvPrjConstraint_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.PrjId) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.PrjId, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.PrjId] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetTabId(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjConstraint_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjConstraint_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjConstraint_Sim.TabId);
}
objvPrjConstraint_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.TabId) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.TabId, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.TabId] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetConstraintTypeId(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeId, convPrjConstraint_Sim.ConstraintTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, convPrjConstraint_Sim.ConstraintTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, convPrjConstraint_Sim.ConstraintTypeId);
}
objvPrjConstraint_SimEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.ConstraintTypeId) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.ConstraintTypeId, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.ConstraintTypeId] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraint_SimEN SetInUse(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, convPrjConstraint_Sim.InUse);
objvPrjConstraint_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraint_SimEN.dicFldComparisonOp.ContainsKey(convPrjConstraint_Sim.InUse) == false)
{
objvPrjConstraint_SimEN.dicFldComparisonOp.Add(convPrjConstraint_Sim.InUse, strComparisonOp);
}
else
{
objvPrjConstraint_SimEN.dicFldComparisonOp[convPrjConstraint_Sim.InUse] = strComparisonOp;
}
}
return objvPrjConstraint_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimENS">源对象</param>
 /// <param name = "objvPrjConstraint_SimENT">目标对象</param>
 public static void CopyTo(this clsvPrjConstraint_SimEN objvPrjConstraint_SimENS, clsvPrjConstraint_SimEN objvPrjConstraint_SimENT)
{
try
{
objvPrjConstraint_SimENT.PrjConstraintId = objvPrjConstraint_SimENS.PrjConstraintId; //约束表Id
objvPrjConstraint_SimENT.ConstraintName = objvPrjConstraint_SimENS.ConstraintName; //约束名
objvPrjConstraint_SimENT.PrjId = objvPrjConstraint_SimENS.PrjId; //工程Id
objvPrjConstraint_SimENT.TabId = objvPrjConstraint_SimENS.TabId; //表ID
objvPrjConstraint_SimENT.ConstraintTypeId = objvPrjConstraint_SimENS.ConstraintTypeId; //约束类型Id
objvPrjConstraint_SimENT.InUse = objvPrjConstraint_SimENS.InUse; //是否在用
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
 /// <param name = "objvPrjConstraint_SimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjConstraint_SimEN:objvPrjConstraint_SimENT</returns>
 public static clsvPrjConstraint_SimEN CopyTo(this clsvPrjConstraint_SimEN objvPrjConstraint_SimENS)
{
try
{
 clsvPrjConstraint_SimEN objvPrjConstraint_SimENT = new clsvPrjConstraint_SimEN()
{
PrjConstraintId = objvPrjConstraint_SimENS.PrjConstraintId, //约束表Id
ConstraintName = objvPrjConstraint_SimENS.ConstraintName, //约束名
PrjId = objvPrjConstraint_SimENS.PrjId, //工程Id
TabId = objvPrjConstraint_SimENS.TabId, //表ID
ConstraintTypeId = objvPrjConstraint_SimENS.ConstraintTypeId, //约束类型Id
InUse = objvPrjConstraint_SimENS.InUse, //是否在用
};
 return objvPrjConstraint_SimENT;
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
public static void CheckProperty4Condition(this clsvPrjConstraint_SimEN objvPrjConstraint_SimEN)
{
 clsvPrjConstraint_SimBL.vPrjConstraint_SimDA.CheckProperty4Condition(objvPrjConstraint_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjConstraint_SimEN objvPrjConstraint_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objvPrjConstraint_SimCond.dicFldComparisonOp[convPrjConstraint_Sim.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint_Sim.PrjConstraintId, objvPrjConstraint_SimCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.ConstraintName) == true)
{
string strComparisonOpConstraintName = objvPrjConstraint_SimCond.dicFldComparisonOp[convPrjConstraint_Sim.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint_Sim.ConstraintName, objvPrjConstraint_SimCond.ConstraintName, strComparisonOpConstraintName);
}
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjConstraint_SimCond.dicFldComparisonOp[convPrjConstraint_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint_Sim.PrjId, objvPrjConstraint_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.TabId) == true)
{
string strComparisonOpTabId = objvPrjConstraint_SimCond.dicFldComparisonOp[convPrjConstraint_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint_Sim.TabId, objvPrjConstraint_SimCond.TabId, strComparisonOpTabId);
}
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objvPrjConstraint_SimCond.dicFldComparisonOp[convPrjConstraint_Sim.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint_Sim.ConstraintTypeId, objvPrjConstraint_SimCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objvPrjConstraint_SimCond.IsUpdated(convPrjConstraint_Sim.InUse) == true)
{
if (objvPrjConstraint_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjConstraint_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjConstraint_Sim.InUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjConstraint_Sim
{
public virtual bool UpdRelaTabDate(string strPrjConstraintId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjConstraint_Sim(vPrjConstraint_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjConstraint_SimBL
{
public static RelatedActions_vPrjConstraint_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjConstraint_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjConstraint_SimDA vPrjConstraint_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjConstraint_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjConstraint_SimBL()
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
if (string.IsNullOrEmpty(clsvPrjConstraint_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjConstraint_SimEN._ConnectString);
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
public static DataTable GetDataTable_vPrjConstraint_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjConstraint_SimDA.GetDataTable_vPrjConstraint_Sim(strWhereCond);
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
objDT = vPrjConstraint_SimDA.GetDataTable(strWhereCond);
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
objDT = vPrjConstraint_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjConstraint_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjConstraint_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjConstraint_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjConstraint_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjConstraint_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjConstraint_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetObjLstByPrjConstraintIdLst(List<string> arrPrjConstraintIdLst)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjConstraintIdLst, true);
 string strWhereCond = string.Format("PrjConstraintId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjConstraint_SimEN> GetObjLstByPrjConstraintIdLstCache(List<string> arrPrjConstraintIdLst)
{
string strKey = string.Format("{0}", clsvPrjConstraint_SimEN._CurrTabName);
List<clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLst_Sel =
arrvPrjConstraint_SimObjLstCache
.Where(x => arrPrjConstraintIdLst.Contains(x.PrjConstraintId));
return arrvPrjConstraint_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetObjLst(string strWhereCond)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
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
public static List<clsvPrjConstraint_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjConstraint_SimEN> GetSubObjLstCache(clsvPrjConstraint_SimEN objvPrjConstraint_SimCond)
{
List<clsvPrjConstraint_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjConstraint_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjConstraint_Sim._AttributeName)
{
if (objvPrjConstraint_SimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjConstraint_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraint_SimCond[strFldName].ToString());
}
else
{
if (objvPrjConstraint_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjConstraint_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraint_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjConstraint_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjConstraint_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjConstraint_SimCond[strFldName]));
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
public static List<clsvPrjConstraint_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
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
public static List<clsvPrjConstraint_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
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
List<clsvPrjConstraint_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjConstraint_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjConstraint_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
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
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
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
public static List<clsvPrjConstraint_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjConstraint_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
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
public static List<clsvPrjConstraint_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjConstraint_SimEN> arrObjLst = new List<clsvPrjConstraint_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = new clsvPrjConstraint_SimEN();
try
{
objvPrjConstraint_SimEN.PrjConstraintId = objRow[convPrjConstraint_Sim.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraint_SimEN.ConstraintName = objRow[convPrjConstraint_Sim.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraint_SimEN.PrjId = objRow[convPrjConstraint_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjConstraint_SimEN.TabId = objRow[convPrjConstraint_Sim.TabId].ToString().Trim(); //表ID
objvPrjConstraint_SimEN.ConstraintTypeId = objRow[convPrjConstraint_Sim.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraint_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint_Sim.InUse].ToString().Trim()); //是否在用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraint_SimEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraint_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjConstraint_Sim(ref clsvPrjConstraint_SimEN objvPrjConstraint_SimEN)
{
bool bolResult = vPrjConstraint_SimDA.GetvPrjConstraint_Sim(ref objvPrjConstraint_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjConstraint_SimEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
if (strPrjConstraintId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjConstraintId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjConstraintId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = vPrjConstraint_SimDA.GetObjByPrjConstraintId(strPrjConstraintId);
return objvPrjConstraint_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjConstraint_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = vPrjConstraint_SimDA.GetFirstObj(strWhereCond);
 return objvPrjConstraint_SimEN;
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
public static clsvPrjConstraint_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = vPrjConstraint_SimDA.GetObjByDataRow(objRow);
 return objvPrjConstraint_SimEN;
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
public static clsvPrjConstraint_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjConstraint_SimEN objvPrjConstraint_SimEN = vPrjConstraint_SimDA.GetObjByDataRow(objRow);
 return objvPrjConstraint_SimEN;
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
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <param name = "lstvPrjConstraint_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjConstraint_SimEN GetObjByPrjConstraintIdFromList(string strPrjConstraintId, List<clsvPrjConstraint_SimEN> lstvPrjConstraint_SimObjLst)
{
foreach (clsvPrjConstraint_SimEN objvPrjConstraint_SimEN in lstvPrjConstraint_SimObjLst)
{
if (objvPrjConstraint_SimEN.PrjConstraintId == strPrjConstraintId)
{
return objvPrjConstraint_SimEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strPrjConstraintId;
 try
 {
 strPrjConstraintId = new clsvPrjConstraint_SimDA().GetFirstID(strWhereCond);
 return strPrjConstraintId;
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
 arrList = vPrjConstraint_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjConstraint_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjConstraintId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjConstraint_SimDA.IsExist(strPrjConstraintId);
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
 bolIsExist = clsvPrjConstraint_SimDA.IsExistTable();
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
 bolIsExist = vPrjConstraint_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjConstraint_SimENS">源对象</param>
 /// <param name = "objvPrjConstraint_SimENT">目标对象</param>
 public static void CopyTo(clsvPrjConstraint_SimEN objvPrjConstraint_SimENS, clsvPrjConstraint_SimEN objvPrjConstraint_SimENT)
{
try
{
objvPrjConstraint_SimENT.PrjConstraintId = objvPrjConstraint_SimENS.PrjConstraintId; //约束表Id
objvPrjConstraint_SimENT.ConstraintName = objvPrjConstraint_SimENS.ConstraintName; //约束名
objvPrjConstraint_SimENT.PrjId = objvPrjConstraint_SimENS.PrjId; //工程Id
objvPrjConstraint_SimENT.TabId = objvPrjConstraint_SimENS.TabId; //表ID
objvPrjConstraint_SimENT.ConstraintTypeId = objvPrjConstraint_SimENS.ConstraintTypeId; //约束类型Id
objvPrjConstraint_SimENT.InUse = objvPrjConstraint_SimENS.InUse; //是否在用
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
 /// <param name = "objvPrjConstraint_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjConstraint_SimEN objvPrjConstraint_SimEN)
{
try
{
objvPrjConstraint_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjConstraint_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjConstraint_Sim.PrjConstraintId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.PrjConstraintId = objvPrjConstraint_SimEN.PrjConstraintId; //约束表Id
}
if (arrFldSet.Contains(convPrjConstraint_Sim.ConstraintName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.ConstraintName = objvPrjConstraint_SimEN.ConstraintName; //约束名
}
if (arrFldSet.Contains(convPrjConstraint_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.PrjId = objvPrjConstraint_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjConstraint_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.TabId = objvPrjConstraint_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjConstraint_Sim.ConstraintTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.ConstraintTypeId = objvPrjConstraint_SimEN.ConstraintTypeId; //约束类型Id
}
if (arrFldSet.Contains(convPrjConstraint_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraint_SimEN.InUse = objvPrjConstraint_SimEN.InUse; //是否在用
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
 /// <param name = "objvPrjConstraint_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjConstraint_SimEN objvPrjConstraint_SimEN)
{
try
{
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
public static void CheckProperty4Condition(clsvPrjConstraint_SimEN objvPrjConstraint_SimEN)
{
 vPrjConstraint_SimDA.CheckProperty4Condition(objvPrjConstraint_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjConstraintIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjConstraint_Sim]...","0");
List<clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLst = GetAllvPrjConstraint_SimObjLstCache(); 
objDDL.DataValueField = convPrjConstraint_Sim.PrjConstraintId;
objDDL.DataTextField = convPrjConstraint_Sim.ConstraintName;
objDDL.DataSource = arrvPrjConstraint_SimObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPrjConstraintBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjConstraintBL没有刷新缓存机制(clsPrjConstraintBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjConstraintId");
//if (arrvPrjConstraint_SimObjLstCache == null)
//{
//arrvPrjConstraint_SimObjLstCache = vPrjConstraint_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjConstraint_SimEN GetObjByPrjConstraintIdCache(string strPrjConstraintId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjConstraint_SimEN._CurrTabName);
List<clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLst_Sel =
arrvPrjConstraint_SimObjLstCache
.Where(x=> x.PrjConstraintId == strPrjConstraintId 
);
if (arrvPrjConstraint_SimObjLst_Sel.Count() == 0)
{
   clsvPrjConstraint_SimEN obj = clsvPrjConstraint_SimBL.GetObjByPrjConstraintId(strPrjConstraintId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjConstraint_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameByPrjConstraintIdCache(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsvPrjConstraint_SimEN objvPrjConstraint_Sim = GetObjByPrjConstraintIdCache(strPrjConstraintId);
if (objvPrjConstraint_Sim == null) return "";
return objvPrjConstraint_Sim.ConstraintName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjConstraintIdCache(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsvPrjConstraint_SimEN objvPrjConstraint_Sim = GetObjByPrjConstraintIdCache(strPrjConstraintId);
if (objvPrjConstraint_Sim == null) return "";
return objvPrjConstraint_Sim.ConstraintName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetAllvPrjConstraint_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLstCache = GetObjLstCache(); 
return arrvPrjConstraint_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjConstraint_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjConstraint_SimEN._CurrTabName);
List<clsvPrjConstraint_SimEN> arrvPrjConstraint_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjConstraint_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvPrjConstraint_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjConstraint_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjConstraint_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjConstraint_SimEN._RefreshTimeLst[clsvPrjConstraint_SimEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPrjConstraintId)
{
if (strInFldName != convPrjConstraint_Sim.PrjConstraintId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjConstraint_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjConstraint_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvPrjConstraint_Sim = clsvPrjConstraint_SimBL.GetObjByPrjConstraintIdCache(strPrjConstraintId);
if (objvPrjConstraint_Sim == null) return "";
return objvPrjConstraint_Sim[strOutFldName].ToString();
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
int intRecCount = clsvPrjConstraint_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjConstraint_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjConstraint_SimDA.GetRecCount();
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
int intRecCount = clsvPrjConstraint_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjConstraint_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjConstraint_SimEN objvPrjConstraint_SimCond)
{
List<clsvPrjConstraint_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjConstraint_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjConstraint_Sim._AttributeName)
{
if (objvPrjConstraint_SimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjConstraint_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraint_SimCond[strFldName].ToString());
}
else
{
if (objvPrjConstraint_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjConstraint_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraint_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjConstraint_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjConstraint_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjConstraint_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjConstraint_SimCond[strFldName]));
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
 List<string> arrList = clsvPrjConstraint_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjConstraint_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjConstraint_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}