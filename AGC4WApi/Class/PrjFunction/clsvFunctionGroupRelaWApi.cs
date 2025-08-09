
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupRelaWApi
 表名:vFunctionGroupRela(00050329)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvFunctionGroupRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetmId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, long lngmId, string strComparisonOp="")
	{
objvFunctionGroupRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.mId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.mId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.mId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFunctionGroupId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convFunctionGroupRela.FunctionGroupId);
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionGroupRela.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionGroupRela.FunctionGroupId);
objvFunctionGroupRelaEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FunctionGroupId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FunctionGroupId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupName">函数组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFunctionGroupName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionGroupRela.FunctionGroupName);
objvFunctionGroupRelaEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FunctionGroupName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FunctionGroupName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetProgLangTypeId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionGroupRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionGroupRela.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionGroupRela.ProgLangTypeId);
objvFunctionGroupRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.ProgLangTypeId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetProgLangTypeName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionGroupRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionGroupRela.ProgLangTypeName);
objvFunctionGroupRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.ProgLangTypeName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetCreateUserId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionGroupRela.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionGroupRela.CreateUserId);
objvFunctionGroupRelaEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.CreateUserId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.CreateUserId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.CreateUserId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFuncId4GC(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionGroupRela.FuncId4GC);
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionGroupRela.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionGroupRela.FuncId4GC);
objvFunctionGroupRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FuncId4GC) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFuncName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionGroupRela.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionGroupRela.FuncName);
objvFunctionGroupRelaEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FuncName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FuncName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FuncName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetIsTemplate(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convFunctionGroupRela.IsTemplate);
objvFunctionGroupRelaEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.IsTemplate) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.IsTemplate, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.IsTemplate] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetUpdDate(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionGroupRela.UpdDate);
objvFunctionGroupRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.UpdDate) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.UpdDate, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.UpdDate] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetUpdUser(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionGroupRela.UpdUser);
objvFunctionGroupRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.UpdUser) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.UpdUser, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.UpdUser] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetMemo(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionGroupRela.Memo);
objvFunctionGroupRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.Memo) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.Memo, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.Memo] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionGroupRelaEN objvFunctionGroupRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.mId) == true)
{
string strComparisonOpmId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionGroupRela.mId, objvFunctionGroupRelaCond.mId, strComparisonOpmId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FunctionGroupId, objvFunctionGroupRelaCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FunctionGroupName, objvFunctionGroupRelaCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.ProgLangTypeId, objvFunctionGroupRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.ProgLangTypeName, objvFunctionGroupRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.CreateUserId, objvFunctionGroupRelaCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FuncId4GC, objvFunctionGroupRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FuncName) == true)
{
string strComparisonOpFuncName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FuncName, objvFunctionGroupRelaCond.FuncName, strComparisonOpFuncName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.IsTemplate) == true)
{
if (objvFunctionGroupRelaCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionGroupRela.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionGroupRela.IsTemplate);
}
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.UpdDate, objvFunctionGroupRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.UpdUser, objvFunctionGroupRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.Memo) == true)
{
string strComparisonOpMemo = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.Memo, objvFunctionGroupRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数与组关系(vFunctionGroupRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionGroupRelaWApi
{
private static readonly string mstrApiControllerName = "vFunctionGroupRelaApi";

 public clsvFunctionGroupRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFunctionGroupRelaEN objvFunctionGroupRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunctionGroupRelaEN = JsonConvert.DeserializeObject<clsvFunctionGroupRelaEN>(strJson);
return objvFunctionGroupRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
public static clsvFunctionGroupRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionGroupRelaEN objvFunctionGroupRelaEN;
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
objvFunctionGroupRelaEN = JsonConvert.DeserializeObject<clsvFunctionGroupRelaEN>(strJson);
return objvFunctionGroupRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionGroupRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLst_Sel =
from objvFunctionGroupRelaEN in arrvFunctionGroupRelaObjLstCache
where objvFunctionGroupRelaEN.mId == lngmId 
select objvFunctionGroupRelaEN;
if (arrvFunctionGroupRelaObjLst_Sel.Count() == 0)
{
   clsvFunctionGroupRelaEN obj = clsvFunctionGroupRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunctionGroupRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunctionGroupRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLst_Sel =
from objvFunctionGroupRelaEN in arrvFunctionGroupRelaObjLstCache
where arrMId.Contains(objvFunctionGroupRelaEN.mId)
select objvFunctionGroupRelaEN;
return arrvFunctionGroupRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionGroupRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvFunctionGroupRelaENS">源对象</param>
 /// <param name = "objvFunctionGroupRelaENT">目标对象</param>
 public static void CopyTo(clsvFunctionGroupRelaEN objvFunctionGroupRelaENS, clsvFunctionGroupRelaEN objvFunctionGroupRelaENT)
{
try
{
objvFunctionGroupRelaENT.mId = objvFunctionGroupRelaENS.mId; //mId
objvFunctionGroupRelaENT.FunctionGroupId = objvFunctionGroupRelaENS.FunctionGroupId; //函数组Id
objvFunctionGroupRelaENT.FunctionGroupName = objvFunctionGroupRelaENS.FunctionGroupName; //函数组名称
objvFunctionGroupRelaENT.ProgLangTypeId = objvFunctionGroupRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupRelaENT.ProgLangTypeName = objvFunctionGroupRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupRelaENT.CreateUserId = objvFunctionGroupRelaENS.CreateUserId; //建立用户Id
objvFunctionGroupRelaENT.FuncId4GC = objvFunctionGroupRelaENS.FuncId4GC; //函数ID
objvFunctionGroupRelaENT.FuncName = objvFunctionGroupRelaENS.FuncName; //函数名
objvFunctionGroupRelaENT.IsTemplate = objvFunctionGroupRelaENS.IsTemplate; //是否模板
objvFunctionGroupRelaENT.UpdDate = objvFunctionGroupRelaENS.UpdDate; //修改日期
objvFunctionGroupRelaENT.UpdUser = objvFunctionGroupRelaENS.UpdUser; //修改者
objvFunctionGroupRelaENT.Memo = objvFunctionGroupRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFunctionGroupRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionGroupRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionGroupRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionGroupRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionGroupRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionGroupRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunctionGroupRelaEN._CurrTabName;
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunctionGroupRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionGroupRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionGroupRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFunctionGroupRela.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.FunctionGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunctionGroupRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroupRela.Memo, Type.GetType("System.String"));
foreach (clsvFunctionGroupRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionGroupRela.mId] = objInFor[convFunctionGroupRela.mId];
objDR[convFunctionGroupRela.FunctionGroupId] = objInFor[convFunctionGroupRela.FunctionGroupId];
objDR[convFunctionGroupRela.FunctionGroupName] = objInFor[convFunctionGroupRela.FunctionGroupName];
objDR[convFunctionGroupRela.ProgLangTypeId] = objInFor[convFunctionGroupRela.ProgLangTypeId];
objDR[convFunctionGroupRela.ProgLangTypeName] = objInFor[convFunctionGroupRela.ProgLangTypeName];
objDR[convFunctionGroupRela.CreateUserId] = objInFor[convFunctionGroupRela.CreateUserId];
objDR[convFunctionGroupRela.FuncId4GC] = objInFor[convFunctionGroupRela.FuncId4GC];
objDR[convFunctionGroupRela.FuncName] = objInFor[convFunctionGroupRela.FuncName];
objDR[convFunctionGroupRela.IsTemplate] = objInFor[convFunctionGroupRela.IsTemplate];
objDR[convFunctionGroupRela.UpdDate] = objInFor[convFunctionGroupRela.UpdDate];
objDR[convFunctionGroupRela.UpdUser] = objInFor[convFunctionGroupRela.UpdUser];
objDR[convFunctionGroupRela.Memo] = objInFor[convFunctionGroupRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}