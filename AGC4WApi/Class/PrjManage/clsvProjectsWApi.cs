
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectsWApi
 表名:vProjects(00050167)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvProjectsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjId(this clsvProjectsEN objvProjectsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convProjects.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convProjects.PrjId);
objvProjectsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjName(this clsvProjectsEN objvProjectsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convProjects.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convProjects.PrjName);
objvProjectsEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDomain">域/包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjDomain(this clsvProjectsEN objvProjectsEN, string strPrjDomain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, convProjects.PrjDomain);
objvProjectsEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjDomain) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjDomain, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjDomain] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strIsoPrjName">ISO工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsoPrjName(this clsvProjectsEN objvProjectsEN, string strIsoPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIsoPrjName, 50, convProjects.IsoPrjName);
objvProjectsEN.IsoPrjName = strIsoPrjName; //ISO工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsoPrjName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsoPrjName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsoPrjName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaPackageName">Java包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetJavaPackageName(this clsvProjectsEN objvProjectsEN, string strJavaPackageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaPackageName, 200, convProjects.JavaPackageName);
objvProjectsEN.JavaPackageName = strJavaPackageName; //Java包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.JavaPackageName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.JavaPackageName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.JavaPackageName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRelaDataBase">是否关联数据库</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsRelaDataBase(this clsvProjectsEN objvProjectsEN, bool bolIsRelaDataBase, string strComparisonOp="")
	{
objvProjectsEN.IsRelaDataBase = bolIsRelaDataBase; //是否关联数据库
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsRelaDataBase) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsRelaDataBase, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsRelaDataBase] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSoftStructureId">架构ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetSoftStructureId(this clsvProjectsEN objvProjectsEN, string strSoftStructureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSoftStructureId, convProjects.SoftStructureId);
clsCheckSql.CheckFieldLen(strSoftStructureId, 4, convProjects.SoftStructureId);
clsCheckSql.CheckFieldForeignKey(strSoftStructureId, 4, convProjects.SoftStructureId);
objvProjectsEN.SoftStructureId = strSoftStructureId; //架构ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.SoftStructureId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.SoftStructureId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.SoftStructureId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSoftStructureName">架构名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetSoftStructureName(this clsvProjectsEN objvProjectsEN, string strSoftStructureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSoftStructureName, 50, convProjects.SoftStructureName);
objvProjectsEN.SoftStructureName = strSoftStructureName; //架构名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.SoftStructureName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.SoftStructureName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.SoftStructureName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetApplicationTypeId(this clsvProjectsEN objvProjectsEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convProjects.ApplicationTypeId);
objvProjectsEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.ApplicationTypeId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.ApplicationTypeId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.ApplicationTypeId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetApplicationTypeName(this clsvProjectsEN objvProjectsEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convProjects.ApplicationTypeName);
objvProjectsEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.ApplicationTypeName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.ApplicationTypeName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.ApplicationTypeName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUseStateId(this clsvProjectsEN objvProjectsEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convProjects.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, convProjects.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convProjects.UseStateId);
objvProjectsEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UseStateId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UseStateId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UseStateId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUseStateName(this clsvProjectsEN objvProjectsEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convProjects.UseStateName);
objvProjectsEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UseStateName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UseStateName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UseStateName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSupportMvc">是否支持Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsSupportMvc(this clsvProjectsEN objvProjectsEN, bool bolIsSupportMvc, string strComparisonOp="")
	{
objvProjectsEN.IsSupportMvc = bolIsSupportMvc; //是否支持Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsSupportMvc) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsSupportMvc, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsSupportMvc] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUserId(this clsvProjectsEN objvProjectsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convProjects.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convProjects.UserId);
objvProjectsEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UserId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UserId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UserId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUpdDate(this clsvProjectsEN objvProjectsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convProjects.UpdDate);
objvProjectsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UpdDate) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UpdDate, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UpdDate] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetMemo(this clsvProjectsEN objvProjectsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convProjects.Memo);
objvProjectsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.Memo) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.Memo, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.Memo] = strComparisonOp;
}
}
return objvProjectsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProjectsEN objvProjectsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProjectsCond.IsUpdated(convProjects.PrjId) == true)
{
string strComparisonOpPrjId = objvProjectsCond.dicFldComparisonOp[convProjects.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjId, objvProjectsCond.PrjId, strComparisonOpPrjId);
}
if (objvProjectsCond.IsUpdated(convProjects.PrjName) == true)
{
string strComparisonOpPrjName = objvProjectsCond.dicFldComparisonOp[convProjects.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjName, objvProjectsCond.PrjName, strComparisonOpPrjName);
}
if (objvProjectsCond.IsUpdated(convProjects.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objvProjectsCond.dicFldComparisonOp[convProjects.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjDomain, objvProjectsCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objvProjectsCond.IsUpdated(convProjects.IsoPrjName) == true)
{
string strComparisonOpIsoPrjName = objvProjectsCond.dicFldComparisonOp[convProjects.IsoPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.IsoPrjName, objvProjectsCond.IsoPrjName, strComparisonOpIsoPrjName);
}
if (objvProjectsCond.IsUpdated(convProjects.JavaPackageName) == true)
{
string strComparisonOpJavaPackageName = objvProjectsCond.dicFldComparisonOp[convProjects.JavaPackageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.JavaPackageName, objvProjectsCond.JavaPackageName, strComparisonOpJavaPackageName);
}
if (objvProjectsCond.IsUpdated(convProjects.IsRelaDataBase) == true)
{
if (objvProjectsCond.IsRelaDataBase == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProjects.IsRelaDataBase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProjects.IsRelaDataBase);
}
}
if (objvProjectsCond.IsUpdated(convProjects.SoftStructureId) == true)
{
string strComparisonOpSoftStructureId = objvProjectsCond.dicFldComparisonOp[convProjects.SoftStructureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.SoftStructureId, objvProjectsCond.SoftStructureId, strComparisonOpSoftStructureId);
}
if (objvProjectsCond.IsUpdated(convProjects.SoftStructureName) == true)
{
string strComparisonOpSoftStructureName = objvProjectsCond.dicFldComparisonOp[convProjects.SoftStructureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.SoftStructureName, objvProjectsCond.SoftStructureName, strComparisonOpSoftStructureName);
}
if (objvProjectsCond.IsUpdated(convProjects.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvProjectsCond.dicFldComparisonOp[convProjects.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convProjects.ApplicationTypeId, objvProjectsCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvProjectsCond.IsUpdated(convProjects.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvProjectsCond.dicFldComparisonOp[convProjects.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.ApplicationTypeName, objvProjectsCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvProjectsCond.IsUpdated(convProjects.UseStateId) == true)
{
string strComparisonOpUseStateId = objvProjectsCond.dicFldComparisonOp[convProjects.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UseStateId, objvProjectsCond.UseStateId, strComparisonOpUseStateId);
}
if (objvProjectsCond.IsUpdated(convProjects.UseStateName) == true)
{
string strComparisonOpUseStateName = objvProjectsCond.dicFldComparisonOp[convProjects.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UseStateName, objvProjectsCond.UseStateName, strComparisonOpUseStateName);
}
if (objvProjectsCond.IsUpdated(convProjects.IsSupportMvc) == true)
{
if (objvProjectsCond.IsSupportMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProjects.IsSupportMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProjects.IsSupportMvc);
}
}
if (objvProjectsCond.IsUpdated(convProjects.UserId) == true)
{
string strComparisonOpUserId = objvProjectsCond.dicFldComparisonOp[convProjects.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UserId, objvProjectsCond.UserId, strComparisonOpUserId);
}
if (objvProjectsCond.IsUpdated(convProjects.UpdDate) == true)
{
string strComparisonOpUpdDate = objvProjectsCond.dicFldComparisonOp[convProjects.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UpdDate, objvProjectsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvProjectsCond.IsUpdated(convProjects.Memo) == true)
{
string strComparisonOpMemo = objvProjectsCond.dicFldComparisonOp[convProjects.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.Memo, objvProjectsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程(vProjects)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvProjectsWApi
{
private static readonly string mstrApiControllerName = "vProjectsApi";

 public clsvProjectsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectsEN GetObjByPrjId(string strPrjId)
{
if (strPrjId == "") return null;
string strAction = "GetObjByPrjId";
clsvProjectsEN objvProjectsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjId"] = strPrjId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvProjectsEN = JsonConvert.DeserializeObject<clsvProjectsEN>(strJson);
return objvProjectsEN;
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
public static clsvProjectsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvProjectsEN objvProjectsEN;
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
objvProjectsEN = JsonConvert.DeserializeObject<clsvProjectsEN>(strJson);
return objvProjectsEN;
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

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectsEN> GetObjLst(string strWhereCond)
{
 List<clsvProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
 /// <param name = "arrPrjId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectsEN> GetObjLstByPrjIdLst(List<string> arrPrjId)
{
 List<clsvProjectsEN> arrObjLst; 
string strAction = "GetObjLstByPrjIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
public static List<clsvProjectsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
public static List<clsvProjectsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
public static List<clsvProjectsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
public static List<clsvProjectsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectsEN>>(strJson);
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
public static bool IsExist(string strPrjId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjId"] = strPrjId
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
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
 public static void CopyTo(clsvProjectsEN objvProjectsENS, clsvProjectsEN objvProjectsENT)
{
try
{
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程Id
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.IsoPrjName = objvProjectsENS.IsoPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvProjectsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvProjectsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvProjectsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvProjectsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvProjectsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvProjectsEN._AttributeName)
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
string strKey = string.Format("{0}", clsvProjectsEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvProjectsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convProjects.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.PrjDomain, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.IsoPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.JavaPackageName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.IsRelaDataBase, Type.GetType("System.Boolean"));
objDT.Columns.Add(convProjects.SoftStructureId, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.SoftStructureName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convProjects.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.IsSupportMvc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convProjects.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convProjects.Memo, Type.GetType("System.String"));
foreach (clsvProjectsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convProjects.PrjId] = objInFor[convProjects.PrjId];
objDR[convProjects.PrjName] = objInFor[convProjects.PrjName];
objDR[convProjects.PrjDomain] = objInFor[convProjects.PrjDomain];
objDR[convProjects.IsoPrjName] = objInFor[convProjects.IsoPrjName];
objDR[convProjects.JavaPackageName] = objInFor[convProjects.JavaPackageName];
objDR[convProjects.IsRelaDataBase] = objInFor[convProjects.IsRelaDataBase];
objDR[convProjects.SoftStructureId] = objInFor[convProjects.SoftStructureId];
objDR[convProjects.SoftStructureName] = objInFor[convProjects.SoftStructureName];
objDR[convProjects.ApplicationTypeId] = objInFor[convProjects.ApplicationTypeId];
objDR[convProjects.ApplicationTypeName] = objInFor[convProjects.ApplicationTypeName];
objDR[convProjects.UseStateId] = objInFor[convProjects.UseStateId];
objDR[convProjects.UseStateName] = objInFor[convProjects.UseStateName];
objDR[convProjects.IsSupportMvc] = objInFor[convProjects.IsSupportMvc];
objDR[convProjects.UserId] = objInFor[convProjects.UserId];
objDR[convProjects.UpdDate] = objInFor[convProjects.UpdDate];
objDR[convProjects.Memo] = objInFor[convProjects.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}