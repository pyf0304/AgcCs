
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFunctionWApi
 表名:vPrjFunction(00050259)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:00
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
public static class  clsvPrjFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncId(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId, 10, convPrjFunction.FuncId);
objvPrjFunctionEN.FuncId = strFuncId; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncName(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convPrjFunction.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convPrjFunction.FuncName);
objvPrjFunctionEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetPrjId(this clsvPrjFunctionEN objvPrjFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjFunction.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjFunction.PrjId);
objvPrjFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.PrjId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.PrjId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.PrjId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetReturnTypeId(this clsvPrjFunctionEN objvPrjFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnTypeId, convPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convPrjFunction.ReturnTypeId);
objvPrjFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.ReturnTypeId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.ReturnTypeId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.ReturnTypeId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetDataTypeName(this clsvPrjFunctionEN objvPrjFunctionEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convPrjFunction.DataTypeName);
objvPrjFunctionEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.DataTypeName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.DataTypeName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.DataTypeName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetDataCnName(this clsvPrjFunctionEN objvPrjFunctionEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convPrjFunction.DataCnName);
objvPrjFunctionEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.DataCnName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.DataCnName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.DataCnName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetCsType(this clsvPrjFunctionEN objvPrjFunctionEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCsType, 100, convPrjFunction.CsType);
objvPrjFunctionEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.CsType) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.CsType, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.CsType] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncTypeId(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convPrjFunction.FuncTypeId);
objvPrjFunctionEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncTypeId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncTypeId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncTypeId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncTypeName(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convPrjFunction.FuncTypeName);
objvPrjFunctionEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncTypeName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncTypeName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncTypeName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetIsTemplate(this clsvPrjFunctionEN objvPrjFunctionEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convPrjFunction.IsTemplate);
objvPrjFunctionEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.IsTemplate) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.IsTemplate, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.IsTemplate] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCode">函数代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncCode(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncCode, string strComparisonOp="")
	{
objvPrjFunctionEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncCode) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncCode, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncCode] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUserId(this clsvPrjFunctionEN objvPrjFunctionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjFunction.UserId);
objvPrjFunctionEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UserId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UserId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UserId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUpdDate(this clsvPrjFunctionEN objvPrjFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFunction.UpdDate);
objvPrjFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UpdDate) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UpdDate, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UpdDate] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUpdUser(this clsvPrjFunctionEN objvPrjFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFunction.UpdUser);
objvPrjFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UpdUser) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UpdUser, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UpdUser] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetMemo(this clsvPrjFunctionEN objvPrjFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFunction.Memo);
objvPrjFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.Memo) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.Memo, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.Memo] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFunctionEN objvPrjFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncId) == true)
{
string strComparisonOpFuncId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncId, objvPrjFunctionCond.FuncId, strComparisonOpFuncId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncName) == true)
{
string strComparisonOpFuncName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncName, objvPrjFunctionCond.FuncName, strComparisonOpFuncName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.PrjId, objvPrjFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.ReturnTypeId, objvPrjFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.DataTypeName, objvPrjFunctionCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.DataCnName) == true)
{
string strComparisonOpDataCnName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.DataCnName, objvPrjFunctionCond.DataCnName, strComparisonOpDataCnName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.CsType) == true)
{
string strComparisonOpCsType = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.CsType, objvPrjFunctionCond.CsType, strComparisonOpCsType);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncTypeId, objvPrjFunctionCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncTypeName, objvPrjFunctionCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.IsTemplate) == true)
{
if (objvPrjFunctionCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFunction.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFunction.IsTemplate);
}
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UserId) == true)
{
string strComparisonOpUserId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UserId, objvPrjFunctionCond.UserId, strComparisonOpUserId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UpdDate, objvPrjFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UpdUser, objvPrjFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.Memo) == true)
{
string strComparisonOpMemo = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.Memo, objvPrjFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程函数(vPrjFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFunctionWApi
{
private static readonly string mstrApiControllerName = "vPrjFunctionApi";

 public clsvPrjFunctionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程函数]...","0");
List<clsvPrjFunctionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncId";
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

public static void BindCbo_FuncId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjFunction.FuncId); 
List<clsvPrjFunctionEN> arrObjLst = clsvPrjFunctionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN()
{
FuncId = "0",
FuncName = "选[v工程函数]..."
};
arrObjLst.Insert(0, objvPrjFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjFunction.FuncId;
objComboBox.DisplayMember = convPrjFunction.FuncName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFunctionEN GetObjByFuncId(string strFuncId)
{
if (strFuncId == "") return null;
string strAction = "GetObjByFuncId";
clsvPrjFunctionEN objvPrjFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId"] = strFuncId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjFunctionEN = JsonConvert.DeserializeObject<clsvPrjFunctionEN>(strJson);
return objvPrjFunctionEN;
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
public static clsvPrjFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjFunctionEN objvPrjFunctionEN;
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
objvPrjFunctionEN = JsonConvert.DeserializeObject<clsvPrjFunctionEN>(strJson);
return objvPrjFunctionEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
//该表没有使用Cache,不需要生成[GetFuncNameByFuncIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
 /// <param name = "arrFuncId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLstByFuncIdLst(List<string> arrFuncId)
{
 List<clsvPrjFunctionEN> arrObjLst; 
string strAction = "GetObjLstByFuncIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
public static List<clsvPrjFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
public static List<clsvPrjFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
public static List<clsvPrjFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFunctionEN>>(strJson);
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
public static bool IsExist(string strFuncId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId"] = strFuncId
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
 /// <param name = "objvPrjFunctionENS">源对象</param>
 /// <param name = "objvPrjFunctionENT">目标对象</param>
 public static void CopyTo(clsvPrjFunctionEN objvPrjFunctionENS, clsvPrjFunctionEN objvPrjFunctionENT)
{
try
{
objvPrjFunctionENT.FuncId = objvPrjFunctionENS.FuncId; //函数ID
objvPrjFunctionENT.FuncName = objvPrjFunctionENS.FuncName; //函数名
objvPrjFunctionENT.PrjId = objvPrjFunctionENS.PrjId; //工程Id
objvPrjFunctionENT.ReturnTypeId = objvPrjFunctionENS.ReturnTypeId; //返回类型ID
objvPrjFunctionENT.DataTypeName = objvPrjFunctionENS.DataTypeName; //数据类型名称
objvPrjFunctionENT.DataCnName = objvPrjFunctionENS.DataCnName; //数据类型中文名称
objvPrjFunctionENT.CsType = objvPrjFunctionENS.CsType; //CS类型
objvPrjFunctionENT.FuncTypeId = objvPrjFunctionENS.FuncTypeId; //函数类型Id
objvPrjFunctionENT.FuncTypeName = objvPrjFunctionENS.FuncTypeName; //函数类型名
objvPrjFunctionENT.IsTemplate = objvPrjFunctionENS.IsTemplate; //是否模板
objvPrjFunctionENT.FuncCode = objvPrjFunctionENS.FuncCode; //函数代码
objvPrjFunctionENT.UserId = objvPrjFunctionENS.UserId; //用户Id
objvPrjFunctionENT.UpdDate = objvPrjFunctionENS.UpdDate; //修改日期
objvPrjFunctionENT.UpdUser = objvPrjFunctionENS.UpdUser; //修改者
objvPrjFunctionENT.Memo = objvPrjFunctionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvPrjFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjFunctionEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjFunctionEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjFunction.FuncId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjFunction.FuncCode, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFunction.Memo, Type.GetType("System.String"));
foreach (clsvPrjFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjFunction.FuncId] = objInFor[convPrjFunction.FuncId];
objDR[convPrjFunction.FuncName] = objInFor[convPrjFunction.FuncName];
objDR[convPrjFunction.PrjId] = objInFor[convPrjFunction.PrjId];
objDR[convPrjFunction.ReturnTypeId] = objInFor[convPrjFunction.ReturnTypeId];
objDR[convPrjFunction.DataTypeName] = objInFor[convPrjFunction.DataTypeName];
objDR[convPrjFunction.DataCnName] = objInFor[convPrjFunction.DataCnName];
objDR[convPrjFunction.CsType] = objInFor[convPrjFunction.CsType];
objDR[convPrjFunction.FuncTypeId] = objInFor[convPrjFunction.FuncTypeId];
objDR[convPrjFunction.FuncTypeName] = objInFor[convPrjFunction.FuncTypeName];
objDR[convPrjFunction.IsTemplate] = objInFor[convPrjFunction.IsTemplate];
objDR[convPrjFunction.FuncCode] = objInFor[convPrjFunction.FuncCode];
objDR[convPrjFunction.UserId] = objInFor[convPrjFunction.UserId];
objDR[convPrjFunction.UpdDate] = objInFor[convPrjFunction.UpdDate];
objDR[convPrjFunction.UpdUser] = objInFor[convPrjFunction.UpdUser];
objDR[convPrjFunction.Memo] = objInFor[convPrjFunction.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}