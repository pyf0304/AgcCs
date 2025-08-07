
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCode_SimWApi
 表名:vFunction4GeneCode_Sim(00050605)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvFunction4GeneCode_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncId4GC(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunction4GeneCode_Sim.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunction4GeneCode_Sim.FuncId4GC);
objvFunction4GeneCode_SimEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncId4GC) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncId4GC, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4GC] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncName(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunction4GeneCode_Sim.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunction4GeneCode_Sim.FuncName);
objvFunction4GeneCode_SimEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncName) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncName, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncName] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncId4Code(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4GeneCode_Sim.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4GeneCode_Sim.FuncId4Code);
objvFunction4GeneCode_SimEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncId4Code) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetSqlDsTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convFunction4GeneCode_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunction4GeneCode_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunction4GeneCode_Sim.SqlDsTypeId);
objvFunction4GeneCode_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.SqlDsTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFeatureId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunction4GeneCode_Sim.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunction4GeneCode_Sim.FeatureId);
objvFunction4GeneCode_SimEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FeatureId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FeatureId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FeatureId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetInUse(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.InUse) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.InUse, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.InUse] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncGCTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4GeneCode_Sim.FuncGCTypeId);
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4GeneCode_Sim.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4GeneCode_Sim.FuncGCTypeId);
objvFunction4GeneCode_SimEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncGCTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intTemplateNum">TemplateNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetTemplateNum(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, int intTemplateNum, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.TemplateNum = intTemplateNum; //TemplateNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.TemplateNum) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.TemplateNum, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.TemplateNum] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetProgLangTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunction4GeneCode_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4GeneCode_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4GeneCode_Sim.ProgLangTypeId);
objvFunction4GeneCode_SimEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.ProgLangTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeId">函数代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetFuncCodeTypeId(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFunction4GeneCode_Sim.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFunction4GeneCode_Sim.FuncCodeTypeId);
objvFunction4GeneCode_SimEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.FuncCodeTypeId) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.FuncCodeTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncCodeTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCode_SimEN SetUsedTimes(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN, int intUsedTimes, string strComparisonOp="")
	{
objvFunction4GeneCode_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCode_SimEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode_Sim.UsedTimes) == false)
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp.Add(convFunction4GeneCode_Sim.UsedTimes, strComparisonOp);
}
else
{
objvFunction4GeneCode_SimEN.dicFldComparisonOp[convFunction4GeneCode_Sim.UsedTimes] = strComparisonOp;
}
}
return objvFunction4GeneCode_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncId4GC, objvFunction4GeneCode_SimCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncName) == true)
{
string strComparisonOpFuncName = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncName, objvFunction4GeneCode_SimCond.FuncName, strComparisonOpFuncName);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncId4Code, objvFunction4GeneCode_SimCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.SqlDsTypeId, objvFunction4GeneCode_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FeatureId, objvFunction4GeneCode_SimCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.InUse) == true)
{
if (objvFunction4GeneCode_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4GeneCode_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4GeneCode_Sim.InUse);
}
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncGCTypeId, objvFunction4GeneCode_SimCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.TemplateNum) == true)
{
string strComparisonOpTemplateNum = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.TemplateNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode_Sim.TemplateNum, objvFunction4GeneCode_SimCond.TemplateNum, strComparisonOpTemplateNum);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.ProgLangTypeId, objvFunction4GeneCode_SimCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode_Sim.FuncCodeTypeId, objvFunction4GeneCode_SimCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objvFunction4GeneCode_SimCond.IsUpdated(convFunction4GeneCode_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvFunction4GeneCode_SimCond.dicFldComparisonOp[convFunction4GeneCode_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode_Sim.UsedTimes, objvFunction4GeneCode_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4GeneCode_SimWApi
{
private static readonly string mstrApiControllerName = "vFunction4GeneCode_SimApi";

 public clsvFunction4GeneCode_SimWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId4GC(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数4GC_Sim]...","0");
List<clsvFunction4GeneCode_SimEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncId4GC";
objDDL.DataTextField="FuncName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindCbo_FuncId4GC(System.Windows.Forms.ComboBox objComboBox , string strFuncCodeTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFunction4GeneCode_Sim.FuncId4GC); 
List<clsvFunction4GeneCode_SimEN> arrObjLst = clsvFunction4GeneCode_SimWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN()
{
FuncId4GC = "0",
FuncName = "选[v函数4GC_Sim]..."
};
arrObjLstSel.Insert(0, objvFunction4GeneCode_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFunction4GeneCode_Sim.FuncId4GC;
objComboBox.DisplayMember = convFunction4GeneCode_Sim.FuncName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC == "") return null;
string strAction = "GetObjByFuncId4GC";
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4GC"] = strFuncId4GC,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunction4GeneCode_SimEN = JsonConvert.DeserializeObject<clsvFunction4GeneCode_SimEN>(strJson);
return objvFunction4GeneCode_SimEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvFunction4GeneCode_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunction4GeneCode_SimEN = JsonConvert.DeserializeObject<clsvFunction4GeneCode_SimEN>(strJson);
return objvFunction4GeneCode_SimEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel =
from objvFunction4GeneCode_SimEN in arrvFunction4GeneCode_SimObjLstCache
where objvFunction4GeneCode_SimEN.FuncId4GC == strFuncId4GC 
select objvFunction4GeneCode_SimEN;
if (arrvFunction4GeneCode_SimObjLst_Sel.Count() == 0)
{
   clsvFunction4GeneCode_SimEN obj = clsvFunction4GeneCode_SimWApi.GetObjByFuncId4GC(strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunction4GeneCode_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//初始化列表缓存
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel1 =
from objvFunction4GeneCode_SimEN in arrvFunction4GeneCode_SimObjLstCache
where objvFunction4GeneCode_SimEN.FuncId4GC == strFuncId4GC 
select objvFunction4GeneCode_SimEN;
List <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel = new List<clsvFunction4GeneCode_SimEN>();
foreach (clsvFunction4GeneCode_SimEN obj in arrvFunction4GeneCode_SimObjLst_Sel1)
{
arrvFunction4GeneCode_SimObjLst_Sel.Add(obj);
}
if (arrvFunction4GeneCode_SimObjLst_Sel.Count > 0)
{
return arrvFunction4GeneCode_SimObjLst_Sel[0].FuncName;
}
string strErrMsgForGetObjById = string.Format("在vFunction4GeneCode_Sim对象缓存列表中,找不到记录[FuncId4GC = {0}](函数:{1})", strFuncId4GC, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFunction4GeneCode_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//初始化列表缓存
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel1 =
from objvFunction4GeneCode_SimEN in arrvFunction4GeneCode_SimObjLstCache
where objvFunction4GeneCode_SimEN.FuncId4GC == strFuncId4GC 
select objvFunction4GeneCode_SimEN;
List <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel = new List<clsvFunction4GeneCode_SimEN>();
foreach (clsvFunction4GeneCode_SimEN obj in arrvFunction4GeneCode_SimObjLst_Sel1)
{
arrvFunction4GeneCode_SimObjLst_Sel.Add(obj);
}
if (arrvFunction4GeneCode_SimObjLst_Sel.Count > 0)
{
return arrvFunction4GeneCode_SimObjLst_Sel[0].FuncName;
}
string strErrMsgForGetObjById = string.Format("在vFunction4GeneCode_Sim对象缓存列表中,找不到记录的相关名称[FuncId4GC = {0}](函数:{1})", strFuncId4GC, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFunction4GeneCode_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrFuncId4GC">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GC)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetObjLstByFuncId4GCLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4GC);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4GC">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunction4GeneCode_SimEN> GetObjLstByFuncId4GCLstCache(List<string> arrFuncId4GC)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Sel =
from objvFunction4GeneCode_SimEN in arrvFunction4GeneCode_SimObjLstCache
where arrFuncId4GC.Contains(objvFunction4GeneCode_SimEN.FuncId4GC)
select objvFunction4GeneCode_SimEN;
return arrvFunction4GeneCode_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunction4GeneCode_SimEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCode_SimEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strFuncId4GC)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4GC"] = strFuncId4GC
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
 /// <param name = "objvFunction4GeneCode_SimENT">目标对象</param>
 public static void CopyTo(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS, clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT)
{
try
{
objvFunction4GeneCode_SimENT.FuncId4GC = objvFunction4GeneCode_SimENS.FuncId4GC; //函数ID
objvFunction4GeneCode_SimENT.FuncName = objvFunction4GeneCode_SimENS.FuncName; //函数名
objvFunction4GeneCode_SimENT.FuncId4Code = objvFunction4GeneCode_SimENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCode_SimENT.SqlDsTypeId = objvFunction4GeneCode_SimENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCode_SimENT.FeatureId = objvFunction4GeneCode_SimENS.FeatureId; //功能Id
objvFunction4GeneCode_SimENT.InUse = objvFunction4GeneCode_SimENS.InUse; //是否在用
objvFunction4GeneCode_SimENT.FuncGCTypeId = objvFunction4GeneCode_SimENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCode_SimENT.TemplateNum = objvFunction4GeneCode_SimENS.TemplateNum; //TemplateNum
objvFunction4GeneCode_SimENT.ProgLangTypeId = objvFunction4GeneCode_SimENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCode_SimENT.FuncCodeTypeId = objvFunction4GeneCode_SimENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCode_SimENT.UsedTimes = objvFunction4GeneCode_SimENS.UsedTimes; //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvFunction4GeneCode_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunction4GeneCode_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunction4GeneCode_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunction4GeneCode_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunction4GeneCode_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunction4GeneCode_SimEN._AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFunction4GeneCode_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4GeneCode_SimEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunction4GeneCode_SimEN._CurrTabName;
List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunction4GeneCode_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunction4GeneCode_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunction4GeneCode_Sim.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4GeneCode_Sim.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.TemplateNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4GeneCode_Sim.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.FuncCodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode_Sim.UsedTimes, Type.GetType("System.Int32"));
foreach (clsvFunction4GeneCode_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunction4GeneCode_Sim.FuncId4GC] = objInFor[convFunction4GeneCode_Sim.FuncId4GC];
objDR[convFunction4GeneCode_Sim.FuncName] = objInFor[convFunction4GeneCode_Sim.FuncName];
objDR[convFunction4GeneCode_Sim.FuncId4Code] = objInFor[convFunction4GeneCode_Sim.FuncId4Code];
objDR[convFunction4GeneCode_Sim.SqlDsTypeId] = objInFor[convFunction4GeneCode_Sim.SqlDsTypeId];
objDR[convFunction4GeneCode_Sim.FeatureId] = objInFor[convFunction4GeneCode_Sim.FeatureId];
objDR[convFunction4GeneCode_Sim.InUse] = objInFor[convFunction4GeneCode_Sim.InUse];
objDR[convFunction4GeneCode_Sim.FuncGCTypeId] = objInFor[convFunction4GeneCode_Sim.FuncGCTypeId];
objDR[convFunction4GeneCode_Sim.TemplateNum] = objInFor[convFunction4GeneCode_Sim.TemplateNum];
objDR[convFunction4GeneCode_Sim.ProgLangTypeId] = objInFor[convFunction4GeneCode_Sim.ProgLangTypeId];
objDR[convFunction4GeneCode_Sim.FuncCodeTypeId] = objInFor[convFunction4GeneCode_Sim.FuncCodeTypeId];
objDR[convFunction4GeneCode_Sim.UsedTimes] = objInFor[convFunction4GeneCode_Sim.UsedTimes];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}