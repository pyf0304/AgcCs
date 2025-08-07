
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraintWApi
 表名:vPrjConstraint(00050333)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjConstraintWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjConstraintId">约束表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjConstraintId(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, convPrjConstraint.PrjConstraintId);
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, convPrjConstraint.PrjConstraintId);
objvPrjConstraintEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjConstraintId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjConstraintId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjConstraintId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintName">约束名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintName(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, convPrjConstraint.ConstraintName);
clsCheckSql.CheckFieldLen(strConstraintName, 100, convPrjConstraint.ConstraintName);
objvPrjConstraintEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjId(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjConstraint.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjConstraint.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjConstraint.PrjId);
objvPrjConstraintEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjName(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjConstraint.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjConstraint.PrjName);
objvPrjConstraintEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabId(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjConstraint.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjConstraint.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjConstraint.TabId);
objvPrjConstraintEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabName(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjConstraint.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjConstraint.TabName);
objvPrjConstraintEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabCnName(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjConstraint.TabCnName);
objvPrjConstraintEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabCnName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabCnName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabCnName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeId">约束类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeId(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeId, convPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, convPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, convPrjConstraint.ConstraintTypeId);
objvPrjConstraintEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeName">约束类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeName(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeName, convPrjConstraint.ConstraintTypeName);
clsCheckSql.CheckFieldLen(strConstraintTypeName, 50, convPrjConstraint.ConstraintTypeName);
objvPrjConstraintEN.ConstraintTypeName = strConstraintTypeName; //约束类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeNameEN">约束类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeNameEN(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeNameEN, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstraintTypeNameEN, 50, convPrjConstraint.ConstraintTypeNameEN);
objvPrjConstraintEN.ConstraintTypeNameEN = strConstraintTypeNameEN; //约束类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeNameEN) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeNameEN, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeNameEN] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintDescription">约束说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintDescription(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstraintDescription, 500, convPrjConstraint.ConstraintDescription);
objvPrjConstraintEN.ConstraintDescription = strConstraintDescription; //约束说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintDescription) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintDescription, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintDescription] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetCreateUserId(this clsvPrjConstraintEN objvPrjConstraintEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convPrjConstraint.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convPrjConstraint.CreateUserId);
objvPrjConstraintEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.CreateUserId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.CreateUserId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.CreateUserId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetInUse(this clsvPrjConstraintEN objvPrjConstraintEN, bool bolInUse, string strComparisonOp="")
	{
objvPrjConstraintEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.InUse) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.InUse, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.InUse] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetUpdDate(this clsvPrjConstraintEN objvPrjConstraintEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjConstraint.UpdDate);
objvPrjConstraintEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.UpdDate) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.UpdDate, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.UpdDate] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetUpdUser(this clsvPrjConstraintEN objvPrjConstraintEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjConstraint.UpdUser);
objvPrjConstraintEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.UpdUser) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.UpdUser, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.UpdUser] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetMemo(this clsvPrjConstraintEN objvPrjConstraintEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjConstraint.Memo);
objvPrjConstraintEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.Memo) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.Memo, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.Memo] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjConstraintEN objvPrjConstraintCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjConstraintId, objvPrjConstraintCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintName) == true)
{
string strComparisonOpConstraintName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintName, objvPrjConstraintCond.ConstraintName, strComparisonOpConstraintName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjId, objvPrjConstraintCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjName, objvPrjConstraintCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabId) == true)
{
string strComparisonOpTabId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabId, objvPrjConstraintCond.TabId, strComparisonOpTabId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabName) == true)
{
string strComparisonOpTabName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabName, objvPrjConstraintCond.TabName, strComparisonOpTabName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabCnName, objvPrjConstraintCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeId, objvPrjConstraintCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeName) == true)
{
string strComparisonOpConstraintTypeName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeName, objvPrjConstraintCond.ConstraintTypeName, strComparisonOpConstraintTypeName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeNameEN) == true)
{
string strComparisonOpConstraintTypeNameEN = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeNameEN];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeNameEN, objvPrjConstraintCond.ConstraintTypeNameEN, strComparisonOpConstraintTypeNameEN);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintDescription) == true)
{
string strComparisonOpConstraintDescription = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintDescription, objvPrjConstraintCond.ConstraintDescription, strComparisonOpConstraintDescription);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.CreateUserId, objvPrjConstraintCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.InUse) == true)
{
if (objvPrjConstraintCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjConstraint.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjConstraint.InUse);
}
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.UpdDate, objvPrjConstraintCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.UpdUser, objvPrjConstraintCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.Memo) == true)
{
string strComparisonOpMemo = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.Memo, objvPrjConstraintCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v约束(vPrjConstraint)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjConstraintWApi
{
private static readonly string mstrApiControllerName = "vPrjConstraintApi";

 public clsvPrjConstraintWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjConstraintId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束]...","0");
List<clsvPrjConstraintEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PrjConstraintId";
objDDL.DataTextField="ConstraintName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_PrjConstraintId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjConstraint.PrjConstraintId); 
List<clsvPrjConstraintEN> arrObjLst = clsvPrjConstraintWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN()
{
PrjConstraintId = "0",
ConstraintName = "选[v约束]..."
};
arrObjLstSel.Insert(0, objvPrjConstraintEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjConstraint.PrjConstraintId;
objComboBox.DisplayMember = convPrjConstraint.ConstraintName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjConstraintEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
if (strPrjConstraintId == "") return null;
string strAction = "GetObjByPrjConstraintId";
clsvPrjConstraintEN objvPrjConstraintEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjConstraintId"] = strPrjConstraintId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjConstraintEN = JsonConvert.DeserializeObject<clsvPrjConstraintEN>(strJson);
return objvPrjConstraintEN;
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
public static clsvPrjConstraintEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjConstraintEN objvPrjConstraintEN;
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
objvPrjConstraintEN = JsonConvert.DeserializeObject<clsvPrjConstraintEN>(strJson);
return objvPrjConstraintEN;
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
//该表没有使用Cache,不需要生成[GetConstraintNameByPrjConstraintIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjConstraintEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
 /// <param name = "arrPrjConstraintId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLstByPrjConstraintIdLst(List<string> arrPrjConstraintId)
{
 List<clsvPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLstByPrjConstraintIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjConstraintId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
public static List<clsvPrjConstraintEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjConstraintEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
public static List<clsvPrjConstraintEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjConstraintEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
public static List<clsvPrjConstraintEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjConstraintEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
public static List<clsvPrjConstraintEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjConstraintEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjConstraintEN>>(strJson);
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
public static bool IsExist(string strPrjConstraintId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjConstraintId"] = strPrjConstraintId
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
 /// <param name = "objvPrjConstraintENS">源对象</param>
 /// <param name = "objvPrjConstraintENT">目标对象</param>
 public static void CopyTo(clsvPrjConstraintEN objvPrjConstraintENS, clsvPrjConstraintEN objvPrjConstraintENT)
{
try
{
objvPrjConstraintENT.PrjConstraintId = objvPrjConstraintENS.PrjConstraintId; //约束表Id
objvPrjConstraintENT.ConstraintName = objvPrjConstraintENS.ConstraintName; //约束名
objvPrjConstraintENT.PrjId = objvPrjConstraintENS.PrjId; //工程Id
objvPrjConstraintENT.PrjName = objvPrjConstraintENS.PrjName; //工程名称
objvPrjConstraintENT.TabId = objvPrjConstraintENS.TabId; //表ID
objvPrjConstraintENT.TabName = objvPrjConstraintENS.TabName; //表名
objvPrjConstraintENT.TabCnName = objvPrjConstraintENS.TabCnName; //表中文名
objvPrjConstraintENT.ConstraintTypeId = objvPrjConstraintENS.ConstraintTypeId; //约束类型Id
objvPrjConstraintENT.ConstraintTypeName = objvPrjConstraintENS.ConstraintTypeName; //约束类型名
objvPrjConstraintENT.ConstraintTypeNameEN = objvPrjConstraintENS.ConstraintTypeNameEN; //约束类型英文名
objvPrjConstraintENT.ConstraintDescription = objvPrjConstraintENS.ConstraintDescription; //约束说明
objvPrjConstraintENT.CreateUserId = objvPrjConstraintENS.CreateUserId; //建立用户Id
objvPrjConstraintENT.InUse = objvPrjConstraintENS.InUse; //是否在用
objvPrjConstraintENT.UpdDate = objvPrjConstraintENS.UpdDate; //修改日期
objvPrjConstraintENT.UpdUser = objvPrjConstraintENS.UpdUser; //修改者
objvPrjConstraintENT.Memo = objvPrjConstraintENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvPrjConstraintEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjConstraintEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjConstraintEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjConstraintEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjConstraintEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjConstraintEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjConstraintEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvPrjConstraintEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjConstraint.PrjConstraintId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.ConstraintName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.ConstraintTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.ConstraintTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.ConstraintTypeNameEN, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.ConstraintDescription, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjConstraint.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPrjConstraint.Memo, Type.GetType("System.String"));
foreach (clsvPrjConstraintEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjConstraint.PrjConstraintId] = objInFor[convPrjConstraint.PrjConstraintId];
objDR[convPrjConstraint.ConstraintName] = objInFor[convPrjConstraint.ConstraintName];
objDR[convPrjConstraint.PrjId] = objInFor[convPrjConstraint.PrjId];
objDR[convPrjConstraint.PrjName] = objInFor[convPrjConstraint.PrjName];
objDR[convPrjConstraint.TabId] = objInFor[convPrjConstraint.TabId];
objDR[convPrjConstraint.TabName] = objInFor[convPrjConstraint.TabName];
objDR[convPrjConstraint.TabCnName] = objInFor[convPrjConstraint.TabCnName];
objDR[convPrjConstraint.ConstraintTypeId] = objInFor[convPrjConstraint.ConstraintTypeId];
objDR[convPrjConstraint.ConstraintTypeName] = objInFor[convPrjConstraint.ConstraintTypeName];
objDR[convPrjConstraint.ConstraintTypeNameEN] = objInFor[convPrjConstraint.ConstraintTypeNameEN];
objDR[convPrjConstraint.ConstraintDescription] = objInFor[convPrjConstraint.ConstraintDescription];
objDR[convPrjConstraint.CreateUserId] = objInFor[convPrjConstraint.CreateUserId];
objDR[convPrjConstraint.InUse] = objInFor[convPrjConstraint.InUse];
objDR[convPrjConstraint.UpdDate] = objInFor[convPrjConstraint.UpdDate];
objDR[convPrjConstraint.UpdUser] = objInFor[convPrjConstraint.UpdUser];
objDR[convPrjConstraint.Memo] = objInFor[convPrjConstraint.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}