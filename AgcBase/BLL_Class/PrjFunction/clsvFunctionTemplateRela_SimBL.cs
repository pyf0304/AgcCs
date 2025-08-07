
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRela_SimBL
 表名:vFunctionTemplateRela_Sim(00050604)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionTemplateRela_SimBL_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetFunctionTemplateId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strFunctionTemplateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convFunctionTemplateRela_Sim.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convFunctionTemplateRela_Sim.FunctionTemplateId);
}
objvFunctionTemplateRela_SimEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.FunctionTemplateId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.FunctionTemplateId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.FunctionTemplateId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetFuncId4GC(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strFuncId4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionTemplateRela_Sim.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionTemplateRela_Sim.FuncId4GC);
}
objvFunctionTemplateRela_SimEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.FuncId4GC) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetCodeTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionTemplateRela_Sim.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionTemplateRela_Sim.CodeTypeId);
}
objvFunctionTemplateRela_SimEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.CodeTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetRegionTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFunctionTemplateRela_Sim.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFunctionTemplateRela_Sim.RegionTypeId);
}
objvFunctionTemplateRela_SimEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.RegionTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.RegionTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.RegionTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetSqlDsTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunctionTemplateRela_Sim.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunctionTemplateRela_Sim.SqlDsTypeId);
}
objvFunctionTemplateRela_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.SqlDsTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetIsGeneCode(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvFunctionTemplateRela_SimEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.IsGeneCode) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.IsGeneCode, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.IsGeneCode] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <param name = "objvFunctionTemplateRela_SimENT">目标对象</param>
 public static void CopyTo(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENS, clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENT)
{
try
{
objvFunctionTemplateRela_SimENT.FunctionTemplateId = objvFunctionTemplateRela_SimENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRela_SimENT.FuncId4GC = objvFunctionTemplateRela_SimENS.FuncId4GC; //函数ID
objvFunctionTemplateRela_SimENT.CodeTypeId = objvFunctionTemplateRela_SimENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRela_SimENT.RegionTypeId = objvFunctionTemplateRela_SimENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRela_SimENT.SqlDsTypeId = objvFunctionTemplateRela_SimENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRela_SimENT.IsGeneCode = objvFunctionTemplateRela_SimENS.IsGeneCode; //是否生成代码
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
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionTemplateRela_SimEN:objvFunctionTemplateRela_SimENT</returns>
 public static clsvFunctionTemplateRela_SimEN CopyTo(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENS)
{
try
{
 clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENT = new clsvFunctionTemplateRela_SimEN()
{
FunctionTemplateId = objvFunctionTemplateRela_SimENS.FunctionTemplateId, //函数模板Id
FuncId4GC = objvFunctionTemplateRela_SimENS.FuncId4GC, //函数ID
CodeTypeId = objvFunctionTemplateRela_SimENS.CodeTypeId, //代码类型Id
RegionTypeId = objvFunctionTemplateRela_SimENS.RegionTypeId, //区域类型Id
SqlDsTypeId = objvFunctionTemplateRela_SimENS.SqlDsTypeId, //数据源类型Id
IsGeneCode = objvFunctionTemplateRela_SimENS.IsGeneCode, //是否生成代码
};
 return objvFunctionTemplateRela_SimENT;
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
public static void CheckProperty4Condition(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
 clsvFunctionTemplateRela_SimBL.vFunctionTemplateRela_SimDA.CheckProperty4Condition(objvFunctionTemplateRela_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.FunctionTemplateId, objvFunctionTemplateRela_SimCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.FuncId4GC, objvFunctionTemplateRela_SimCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.CodeTypeId, objvFunctionTemplateRela_SimCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.RegionTypeId, objvFunctionTemplateRela_SimCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.SqlDsTypeId, objvFunctionTemplateRela_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.IsGeneCode) == true)
{
if (objvFunctionTemplateRela_SimCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela_Sim.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela_Sim.IsGeneCode);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionTemplateRela_Sim
{
public virtual bool UpdRelaTabDate(string strFunctionTemplateId,string strFuncId4GC, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数模板关系_Sim(vFunctionTemplateRela_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTemplateRela_SimBL
{
public static RelatedActions_vFunctionTemplateRela_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionTemplateRela_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionTemplateRela_SimDA vFunctionTemplateRela_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionTemplateRela_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionTemplateRela_SimBL()
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
if (string.IsNullOrEmpty(clsvFunctionTemplateRela_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionTemplateRela_SimEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionTemplateRela_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionTemplateRela_SimDA.GetDataTable_vFunctionTemplateRela_Sim(strWhereCond);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable(strWhereCond);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionTemplateRela_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--vFunctionTemplateRela_Sim(v函数模板关系_Sim)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
//检测记录是否存在
string strResult = "";
strResult += objvFunctionTemplateRela_SimEN.FunctionTemplateId;
strResult += "|" + objvFunctionTemplateRela_SimEN.FuncId4GC;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionTemplateRela_SimEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLst_Sel =
arrvFunctionTemplateRela_SimObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrvFunctionTemplateRela_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionTemplateRela_SimEN> GetSubObjLstCache(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimCond)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionTemplateRela_Sim._AttributeName)
{
if (objvFunctionTemplateRela_SimCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTemplateRela_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRela_SimCond[strFldName].ToString());
}
else
{
if (objvFunctionTemplateRela_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRela_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTemplateRela_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRela_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRela_SimCond[strFldName]));
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
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
List<clsvFunctionTemplateRela_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionTemplateRela_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionTemplateRela_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
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
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
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
public static List<clsvFunctionTemplateRela_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLst = new List<clsvFunctionTemplateRela_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = new clsvFunctionTemplateRela_SimEN();
try
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objRow[convFunctionTemplateRela_Sim.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRela_SimEN.FuncId4GC = objRow[convFunctionTemplateRela_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRela_SimEN.CodeTypeId = objRow[convFunctionTemplateRela_Sim.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRela_SimEN.RegionTypeId = objRow[convFunctionTemplateRela_Sim.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objRow[convFunctionTemplateRela_Sim.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRela_SimEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela_Sim.IsGeneCode].ToString().Trim()); //是否生成代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRela_SimEN.FunctionTemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRela_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionTemplateRela_Sim(ref clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
bool bolResult = vFunctionTemplateRela_SimDA.GetvFunctionTemplateRela_Sim(ref objvFunctionTemplateRela_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateRela_SimEN GetObjByKeyLst(string strFunctionTemplateId,string strFuncId4GC)
{
if (strFunctionTemplateId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strFunctionTemplateId,strFuncId4GC]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strFuncId4GC.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strFunctionTemplateId,strFuncId4GC]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFunctionTemplateId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strFunctionTemplateId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strFuncId4GC]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = vFunctionTemplateRela_SimDA.GetObjByKeyLst(strFunctionTemplateId,strFuncId4GC);
return objvFunctionTemplateRela_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionTemplateRela_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = vFunctionTemplateRela_SimDA.GetFirstObj(strWhereCond);
 return objvFunctionTemplateRela_SimEN;
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
public static clsvFunctionTemplateRela_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = vFunctionTemplateRela_SimDA.GetObjByDataRow(objRow);
 return objvFunctionTemplateRela_SimEN;
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
public static clsvFunctionTemplateRela_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = vFunctionTemplateRela_SimDA.GetObjByDataRow(objRow);
 return objvFunctionTemplateRela_SimEN;
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
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <param name = "lstvFunctionTemplateRela_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateRela_SimEN GetObjByKeyLstFromList(string strFunctionTemplateId,string strFuncId4GC, List<clsvFunctionTemplateRela_SimEN> lstvFunctionTemplateRela_SimObjLst)
{
foreach (clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN in lstvFunctionTemplateRela_SimObjLst)
{
if (objvFunctionTemplateRela_SimEN.FunctionTemplateId == strFunctionTemplateId 
 && objvFunctionTemplateRela_SimEN.FuncId4GC == strFuncId4GC 
)
{
return objvFunctionTemplateRela_SimEN;
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
 string strFunctionTemplateId;
 try
 {
 strFunctionTemplateId = new clsvFunctionTemplateRela_SimDA().GetFirstID(strWhereCond);
 return strFunctionTemplateId;
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
 arrList = vFunctionTemplateRela_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionTemplateRela_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFunctionTemplateId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFunctionTemplateId,string strFuncId4GC)
{
//检测记录是否存在
bool bolIsExist = vFunctionTemplateRela_SimDA.IsExist(strFunctionTemplateId,strFuncId4GC);
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
 bolIsExist = clsvFunctionTemplateRela_SimDA.IsExistTable();
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
 bolIsExist = vFunctionTemplateRela_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <param name = "objvFunctionTemplateRela_SimENT">目标对象</param>
 public static void CopyTo(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENS, clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENT)
{
try
{
objvFunctionTemplateRela_SimENT.FunctionTemplateId = objvFunctionTemplateRela_SimENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRela_SimENT.FuncId4GC = objvFunctionTemplateRela_SimENS.FuncId4GC; //函数ID
objvFunctionTemplateRela_SimENT.CodeTypeId = objvFunctionTemplateRela_SimENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRela_SimENT.RegionTypeId = objvFunctionTemplateRela_SimENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRela_SimENT.SqlDsTypeId = objvFunctionTemplateRela_SimENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRela_SimENT.IsGeneCode = objvFunctionTemplateRela_SimENS.IsGeneCode; //是否生成代码
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
 /// <param name = "objvFunctionTemplateRela_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
try
{
objvFunctionTemplateRela_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionTemplateRela_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.FunctionTemplateId = objvFunctionTemplateRela_SimEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.FuncId4GC = objvFunctionTemplateRela_SimEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.CodeTypeId = objvFunctionTemplateRela_SimEN.CodeTypeId == "[null]" ? null :  objvFunctionTemplateRela_SimEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.RegionTypeId = objvFunctionTemplateRela_SimEN.RegionTypeId == "[null]" ? null :  objvFunctionTemplateRela_SimEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.SqlDsTypeId = objvFunctionTemplateRela_SimEN.SqlDsTypeId == "[null]" ? null :  objvFunctionTemplateRela_SimEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela_Sim.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRela_SimEN.IsGeneCode = objvFunctionTemplateRela_SimEN.IsGeneCode; //是否生成代码
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
 /// <param name = "objvFunctionTemplateRela_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
try
{
if (objvFunctionTemplateRela_SimEN.CodeTypeId == "[null]") objvFunctionTemplateRela_SimEN.CodeTypeId = null; //代码类型Id
if (objvFunctionTemplateRela_SimEN.RegionTypeId == "[null]") objvFunctionTemplateRela_SimEN.RegionTypeId = null; //区域类型Id
if (objvFunctionTemplateRela_SimEN.SqlDsTypeId == "[null]") objvFunctionTemplateRela_SimEN.SqlDsTypeId = null; //数据源类型Id
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
public static void CheckProperty4Condition(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN)
{
 vFunctionTemplateRela_SimDA.CheckProperty4Condition(objvFunctionTemplateRela_SimEN);
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
if (clsFunctionTemplateRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateRelaBL没有刷新缓存机制(clsFunctionTemplateRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionTemplateId");
//if (arrvFunctionTemplateRela_SimObjLstCache == null)
//{
//arrvFunctionTemplateRela_SimObjLstCache = vFunctionTemplateRela_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateRela_SimEN GetObjByKeyLstCache(string strFunctionTemplateId,string strFuncId4GC)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLst_Sel =
arrvFunctionTemplateRela_SimObjLstCache
.Where(x=> x.FunctionTemplateId == strFunctionTemplateId 
 && x.FuncId4GC == strFuncId4GC 
);
if (arrvFunctionTemplateRela_SimObjLst_Sel.Count() == 0)
{
   clsvFunctionTemplateRela_SimEN obj = clsvFunctionTemplateRela_SimBL.GetObjByKeyLst(strFunctionTemplateId,strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionTemplateRela_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetAllvFunctionTemplateRela_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = GetObjLstCache(); 
return arrvFunctionTemplateRela_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionTemplateRela_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionTemplateRela_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionTemplateRela_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionTemplateRela_SimEN._RefreshTimeLst[clsvFunctionTemplateRela_SimEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFunctionTemplateId,string strFuncId4GC)
{
if (strInFldName != convFunctionTemplateRela_Sim.FunctionTemplateId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionTemplateRela_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionTemplateRela_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionTemplateRela_Sim = clsvFunctionTemplateRela_SimBL.GetObjByKeyLstCache(strFunctionTemplateId,strFuncId4GC);
if (objvFunctionTemplateRela_Sim == null) return "";
return objvFunctionTemplateRela_Sim[strOutFldName].ToString();
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
int intRecCount = clsvFunctionTemplateRela_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionTemplateRela_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionTemplateRela_SimDA.GetRecCount();
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
int intRecCount = clsvFunctionTemplateRela_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimCond)
{
List<clsvFunctionTemplateRela_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionTemplateRela_Sim._AttributeName)
{
if (objvFunctionTemplateRela_SimCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTemplateRela_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRela_SimCond[strFldName].ToString());
}
else
{
if (objvFunctionTemplateRela_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRela_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTemplateRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTemplateRela_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRela_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRela_SimCond[strFldName]));
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
 List<string> arrList = clsvFunctionTemplateRela_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTemplateRela_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTemplateRela_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}