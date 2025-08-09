
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectDatabaseRelWApi
 表名:vProjectDatabaseRel(00050193)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvProjectDatabaseRelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetmId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, long lngmId, string strComparisonOp="")
	{
objvProjectDatabaseRelEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.mId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.mId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.mId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convProjectDatabaseRel.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convProjectDatabaseRel.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convProjectDatabaseRel.PrjId);
objvProjectDatabaseRelEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convProjectDatabaseRel.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convProjectDatabaseRel.PrjName);
objvProjectDatabaseRelEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetIpAddress(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convProjectDatabaseRel.IpAddress);
clsCheckSql.CheckFieldLen(strIpAddress, 25, convProjectDatabaseRel.IpAddress);
objvProjectDatabaseRelEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.IpAddress) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.IpAddress, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.IpAddress] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjDataBaseId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convProjectDatabaseRel.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convProjectDatabaseRel.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convProjectDatabaseRel.PrjDataBaseId);
objvProjectDatabaseRelEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjDataBaseId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjDataBaseId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjDataBaseName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convProjectDatabaseRel.PrjDataBaseName);
objvProjectDatabaseRelEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjDataBaseName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjDataBaseName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseName, convProjectDatabaseRel.DataBaseName);
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convProjectDatabaseRel.DataBaseName);
objvProjectDatabaseRelEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库的用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBasePwd(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convProjectDatabaseRel.DataBasePwd);
objvProjectDatabaseRelEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBasePwd) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBasePwd, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBasePwd] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库的用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseUserId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convProjectDatabaseRel.DataBaseUserId);
objvProjectDatabaseRelEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseUserId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseUserId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseUserId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDatabaseOwner">数据库拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDatabaseOwner(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDatabaseOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, convProjectDatabaseRel.DatabaseOwner);
objvProjectDatabaseRelEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DatabaseOwner) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DatabaseOwner, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DatabaseOwner] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseTypeId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convProjectDatabaseRel.DataBaseTypeId);
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convProjectDatabaseRel.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convProjectDatabaseRel.DataBaseTypeId);
objvProjectDatabaseRelEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseTypeId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseTypeId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeName">数据库类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseTypeName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convProjectDatabaseRel.DataBaseTypeName);
objvProjectDatabaseRelEN.DataBaseTypeName = strDataBaseTypeName; //数据库类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseTypeName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseTypeName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strSid">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetSid(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSid, convProjectDatabaseRel.Sid);
clsCheckSql.CheckFieldLen(strSid, 50, convProjectDatabaseRel.Sid);
objvProjectDatabaseRelEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.Sid) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.Sid, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.Sid] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetTableSpace(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 50, convProjectDatabaseRel.TableSpace);
objvProjectDatabaseRelEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.TableSpace) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.TableSpace, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.TableSpace] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetUseStateId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convProjectDatabaseRel.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convProjectDatabaseRel.UseStateId);
objvProjectDatabaseRelEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.UseStateId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.UseStateId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.UseStateId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetUseStateName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convProjectDatabaseRel.UseStateName);
objvProjectDatabaseRelEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.UseStateName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.UseStateName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.UseStateName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProjectDatabaseRelEN objvProjectDatabaseRelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.mId) == true)
{
string strComparisonOpmId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convProjectDatabaseRel.mId, objvProjectDatabaseRelCond.mId, strComparisonOpmId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjId) == true)
{
string strComparisonOpPrjId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjId, objvProjectDatabaseRelCond.PrjId, strComparisonOpPrjId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjName) == true)
{
string strComparisonOpPrjName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjName, objvProjectDatabaseRelCond.PrjName, strComparisonOpPrjName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.IpAddress) == true)
{
string strComparisonOpIpAddress = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.IpAddress, objvProjectDatabaseRelCond.IpAddress, strComparisonOpIpAddress);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjDataBaseId, objvProjectDatabaseRelCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjDataBaseName, objvProjectDatabaseRelCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseName, objvProjectDatabaseRelCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBasePwd, objvProjectDatabaseRelCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseUserId, objvProjectDatabaseRelCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DatabaseOwner, objvProjectDatabaseRelCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseTypeId, objvProjectDatabaseRelCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseTypeName) == true)
{
string strComparisonOpDataBaseTypeName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseTypeName, objvProjectDatabaseRelCond.DataBaseTypeName, strComparisonOpDataBaseTypeName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.Sid) == true)
{
string strComparisonOpSid = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.Sid, objvProjectDatabaseRelCond.Sid, strComparisonOpSid);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.TableSpace) == true)
{
string strComparisonOpTableSpace = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.TableSpace, objvProjectDatabaseRelCond.TableSpace, strComparisonOpTableSpace);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.UseStateId) == true)
{
string strComparisonOpUseStateId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.UseStateId, objvProjectDatabaseRelCond.UseStateId, strComparisonOpUseStateId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.UseStateName) == true)
{
string strComparisonOpUseStateName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.UseStateName, objvProjectDatabaseRelCond.UseStateName, strComparisonOpUseStateName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程数据库关系(vProjectDatabaseRel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvProjectDatabaseRelWApi
{
private static readonly string mstrApiControllerName = "vProjectDatabaseRelApi";

 public clsvProjectDatabaseRelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectDatabaseRelEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvProjectDatabaseRelEN objvProjectDatabaseRelEN;
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
objvProjectDatabaseRelEN = JsonConvert.DeserializeObject<clsvProjectDatabaseRelEN>(strJson);
return objvProjectDatabaseRelEN;
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
public static clsvProjectDatabaseRelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvProjectDatabaseRelEN objvProjectDatabaseRelEN;
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
objvProjectDatabaseRelEN = JsonConvert.DeserializeObject<clsvProjectDatabaseRelEN>(strJson);
return objvProjectDatabaseRelEN;
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
public static clsvProjectDatabaseRelEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLst_Sel =
from objvProjectDatabaseRelEN in arrvProjectDatabaseRelObjLstCache
where objvProjectDatabaseRelEN.mId == lngmId 
select objvProjectDatabaseRelEN;
if (arrvProjectDatabaseRelObjLst_Sel.Count() == 0)
{
   clsvProjectDatabaseRelEN obj = clsvProjectDatabaseRelWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvProjectDatabaseRelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLst(string strWhereCond)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
public static IEnumerable<clsvProjectDatabaseRelEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLst_Sel =
from objvProjectDatabaseRelEN in arrvProjectDatabaseRelObjLstCache
where arrMId.Contains(objvProjectDatabaseRelEN.mId)
select objvProjectDatabaseRelEN;
return arrvProjectDatabaseRelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvProjectDatabaseRelEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProjectDatabaseRelEN>>(strJson);
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
 /// <param name = "objvProjectDatabaseRelENS">源对象</param>
 /// <param name = "objvProjectDatabaseRelENT">目标对象</param>
 public static void CopyTo(clsvProjectDatabaseRelEN objvProjectDatabaseRelENS, clsvProjectDatabaseRelEN objvProjectDatabaseRelENT)
{
try
{
objvProjectDatabaseRelENT.mId = objvProjectDatabaseRelENS.mId; //mId
objvProjectDatabaseRelENT.PrjId = objvProjectDatabaseRelENS.PrjId; //工程Id
objvProjectDatabaseRelENT.PrjName = objvProjectDatabaseRelENS.PrjName; //工程名称
objvProjectDatabaseRelENT.IpAddress = objvProjectDatabaseRelENS.IpAddress; //服务器
objvProjectDatabaseRelENT.PrjDataBaseId = objvProjectDatabaseRelENS.PrjDataBaseId; //项目数据库Id
objvProjectDatabaseRelENT.PrjDataBaseName = objvProjectDatabaseRelENS.PrjDataBaseName; //项目数据库名
objvProjectDatabaseRelENT.DataBaseName = objvProjectDatabaseRelENS.DataBaseName; //数据库名
objvProjectDatabaseRelENT.DataBasePwd = objvProjectDatabaseRelENS.DataBasePwd; //数据库的用户口令
objvProjectDatabaseRelENT.DataBaseUserId = objvProjectDatabaseRelENS.DataBaseUserId; //数据库的用户ID
objvProjectDatabaseRelENT.DatabaseOwner = objvProjectDatabaseRelENS.DatabaseOwner; //数据库拥有者
objvProjectDatabaseRelENT.DataBaseTypeId = objvProjectDatabaseRelENS.DataBaseTypeId; //数据库类型ID
objvProjectDatabaseRelENT.DataBaseTypeName = objvProjectDatabaseRelENS.DataBaseTypeName; //数据库类型名
objvProjectDatabaseRelENT.Sid = objvProjectDatabaseRelENS.Sid; //SID
objvProjectDatabaseRelENT.TableSpace = objvProjectDatabaseRelENS.TableSpace; //表空间
objvProjectDatabaseRelENT.UseStateId = objvProjectDatabaseRelENS.UseStateId; //使用状态Id
objvProjectDatabaseRelENT.UseStateName = objvProjectDatabaseRelENS.UseStateName; //使用状态名称
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
public static DataTable ToDataTable(List<clsvProjectDatabaseRelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvProjectDatabaseRelEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvProjectDatabaseRelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvProjectDatabaseRelEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvProjectDatabaseRelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvProjectDatabaseRelEN._AttributeName)
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
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvProjectDatabaseRelEN._CurrTabName;
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvProjectDatabaseRelObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvProjectDatabaseRelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convProjectDatabaseRel.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convProjectDatabaseRel.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DatabaseOwner, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.DataBaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.Sid, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convProjectDatabaseRel.UseStateName, Type.GetType("System.String"));
foreach (clsvProjectDatabaseRelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convProjectDatabaseRel.mId] = objInFor[convProjectDatabaseRel.mId];
objDR[convProjectDatabaseRel.PrjId] = objInFor[convProjectDatabaseRel.PrjId];
objDR[convProjectDatabaseRel.PrjName] = objInFor[convProjectDatabaseRel.PrjName];
objDR[convProjectDatabaseRel.IpAddress] = objInFor[convProjectDatabaseRel.IpAddress];
objDR[convProjectDatabaseRel.PrjDataBaseId] = objInFor[convProjectDatabaseRel.PrjDataBaseId];
objDR[convProjectDatabaseRel.PrjDataBaseName] = objInFor[convProjectDatabaseRel.PrjDataBaseName];
objDR[convProjectDatabaseRel.DataBaseName] = objInFor[convProjectDatabaseRel.DataBaseName];
objDR[convProjectDatabaseRel.DataBasePwd] = objInFor[convProjectDatabaseRel.DataBasePwd];
objDR[convProjectDatabaseRel.DataBaseUserId] = objInFor[convProjectDatabaseRel.DataBaseUserId];
objDR[convProjectDatabaseRel.DatabaseOwner] = objInFor[convProjectDatabaseRel.DatabaseOwner];
objDR[convProjectDatabaseRel.DataBaseTypeId] = objInFor[convProjectDatabaseRel.DataBaseTypeId];
objDR[convProjectDatabaseRel.DataBaseTypeName] = objInFor[convProjectDatabaseRel.DataBaseTypeName];
objDR[convProjectDatabaseRel.Sid] = objInFor[convProjectDatabaseRel.Sid];
objDR[convProjectDatabaseRel.TableSpace] = objInFor[convProjectDatabaseRel.TableSpace];
objDR[convProjectDatabaseRel.UseStateId] = objInFor[convProjectDatabaseRel.UseStateId];
objDR[convProjectDatabaseRel.UseStateName] = objInFor[convProjectDatabaseRel.UseStateName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}