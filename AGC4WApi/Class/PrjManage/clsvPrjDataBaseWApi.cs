
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjDataBaseWApi
 表名:vPrjDataBase(00050175)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:56
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
public static class  clsvPrjDataBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetPrjDataBaseId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convPrjDataBase.PrjDataBaseId);
objvPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.PrjDataBaseId) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.PrjDataBaseId, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.PrjDataBaseId] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetPrjDataBaseName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convPrjDataBase.PrjDataBaseName);
objvPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.PrjDataBaseName) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeName">数据库类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseTypeName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeName, convPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convPrjDataBase.DataBaseTypeName);
objvPrjDataBaseEN.DataBaseTypeName = strDataBaseTypeName; //数据库类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DataBaseTypeName) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DataBaseTypeName, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DataBaseTypeName] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseTypeId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convPrjDataBase.DataBaseTypeId);
objvPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DataBaseTypeId) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convPrjDataBase.DataBaseName);
objvPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DataBaseName) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDatabaseOwner">数据库拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDatabaseOwner(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, convPrjDataBase.DatabaseOwner);
objvPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DatabaseOwner) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库的用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBasePwd(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convPrjDataBase.DataBasePwd);
objvPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DataBasePwd) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库的用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseUserId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convPrjDataBase.DataBaseUserId);
objvPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.DataBaseUserId) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetIpAddress(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convPrjDataBase.IpAddress);
objvPrjDataBaseEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.IpAddress) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetTableSpace(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 50, convPrjDataBase.TableSpace);
objvPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.TableSpace) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUpdDate(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjDataBase.UpdDate);
objvPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.UpdDate) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSid">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetSid(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSid, 50, convPrjDataBase.Sid);
objvPrjDataBaseEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.Sid) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.Sid, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.Sid] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUserId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjDataBase.UserId);
objvPrjDataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.UserId) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.UserId, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.UserId] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetMemo(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjDataBase.Memo);
objvPrjDataBaseEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.Memo) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.Memo, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.Memo] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUseStateName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convPrjDataBase.UseStateName);
objvPrjDataBaseEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.UseStateName) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.UseStateName, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.UseStateName] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUseStateId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convPrjDataBase.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, convPrjDataBase.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convPrjDataBase.UseStateId);
objvPrjDataBaseEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convPrjDataBase.UseStateId) == false)
{
objvPrjDataBaseEN.dicFldComparisonOp.Add(convPrjDataBase.UseStateId, strComparisonOp);
}
else
{
objvPrjDataBaseEN.dicFldComparisonOp[convPrjDataBase.UseStateId] = strComparisonOp;
}
}
return objvPrjDataBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjDataBaseEN objvPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.PrjDataBaseId, objvPrjDataBaseCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.PrjDataBaseName, objvPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DataBaseTypeName) == true)
{
string strComparisonOpDataBaseTypeName = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DataBaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DataBaseTypeName, objvPrjDataBaseCond.DataBaseTypeName, strComparisonOpDataBaseTypeName);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DataBaseTypeId, objvPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DataBaseName, objvPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DatabaseOwner, objvPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DataBasePwd, objvPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.DataBaseUserId, objvPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.IpAddress, objvPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.TableSpace, objvPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.UpdDate, objvPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.Sid) == true)
{
string strComparisonOpSid = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.Sid, objvPrjDataBaseCond.Sid, strComparisonOpSid);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.UserId, objvPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.Memo, objvPrjDataBaseCond.Memo, strComparisonOpMemo);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.UseStateName) == true)
{
string strComparisonOpUseStateName = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.UseStateName, objvPrjDataBaseCond.UseStateName, strComparisonOpUseStateName);
}
if (objvPrjDataBaseCond.IsUpdated(convPrjDataBase.UseStateId) == true)
{
string strComparisonOpUseStateId = objvPrjDataBaseCond.dicFldComparisonOp[convPrjDataBase.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjDataBase.UseStateId, objvPrjDataBaseCond.UseStateId, strComparisonOpUseStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v数据库对象(vPrjDataBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjDataBaseWApi
{
private static readonly string mstrApiControllerName = "vPrjDataBaseApi";

 public clsvPrjDataBaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
if (strPrjDataBaseId == "") return null;
string strAction = "GetObjByPrjDataBaseId";
clsvPrjDataBaseEN objvPrjDataBaseEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjDataBaseId"] = strPrjDataBaseId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjDataBaseEN = JsonConvert.DeserializeObject<clsvPrjDataBaseEN>(strJson);
return objvPrjDataBaseEN;
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
public static clsvPrjDataBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjDataBaseEN objvPrjDataBaseEN;
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
objvPrjDataBaseEN = JsonConvert.DeserializeObject<clsvPrjDataBaseEN>(strJson);
return objvPrjDataBaseEN;
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
public static List<clsvPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
 /// <param name = "arrPrjDataBaseId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLstByPrjDataBaseIdLst(List<string> arrPrjDataBaseId)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
string strAction = "GetObjLstByPrjDataBaseIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjDataBaseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
public static List<clsvPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
public static List<clsvPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
public static List<clsvPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
public static List<clsvPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjDataBaseEN>>(strJson);
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
public static bool IsExist(string strPrjDataBaseId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjDataBaseId"] = strPrjDataBaseId
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
 /// <param name = "objvPrjDataBaseENS">源对象</param>
 /// <param name = "objvPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsvPrjDataBaseEN objvPrjDataBaseENS, clsvPrjDataBaseEN objvPrjDataBaseENT)
{
try
{
objvPrjDataBaseENT.PrjDataBaseId = objvPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objvPrjDataBaseENT.PrjDataBaseName = objvPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvPrjDataBaseENT.DataBaseTypeName = objvPrjDataBaseENS.DataBaseTypeName; //数据库类型名
objvPrjDataBaseENT.DataBaseTypeId = objvPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objvPrjDataBaseENT.DataBaseName = objvPrjDataBaseENS.DataBaseName; //数据库名
objvPrjDataBaseENT.DatabaseOwner = objvPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objvPrjDataBaseENT.DataBasePwd = objvPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objvPrjDataBaseENT.DataBaseUserId = objvPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objvPrjDataBaseENT.IpAddress = objvPrjDataBaseENS.IpAddress; //服务器
objvPrjDataBaseENT.TableSpace = objvPrjDataBaseENS.TableSpace; //表空间
objvPrjDataBaseENT.UpdDate = objvPrjDataBaseENS.UpdDate; //修改日期
objvPrjDataBaseENT.Sid = objvPrjDataBaseENS.Sid; //SID
objvPrjDataBaseENT.UserId = objvPrjDataBaseENS.UserId; //用户Id
objvPrjDataBaseENT.Memo = objvPrjDataBaseENS.Memo; //说明
objvPrjDataBaseENT.UseStateName = objvPrjDataBaseENS.UseStateName; //使用状态名称
objvPrjDataBaseENT.UseStateId = objvPrjDataBaseENS.UseStateId; //使用状态Id
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
public static DataTable ToDataTable(List<clsvPrjDataBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjDataBaseEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjDataBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjDataBaseEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjDataBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjDataBaseEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjDataBaseEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvPrjDataBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjDataBase.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DataBaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DatabaseOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.Sid, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjDataBase.UseStateId, Type.GetType("System.String"));
foreach (clsvPrjDataBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjDataBase.PrjDataBaseId] = objInFor[convPrjDataBase.PrjDataBaseId];
objDR[convPrjDataBase.PrjDataBaseName] = objInFor[convPrjDataBase.PrjDataBaseName];
objDR[convPrjDataBase.DataBaseTypeName] = objInFor[convPrjDataBase.DataBaseTypeName];
objDR[convPrjDataBase.DataBaseTypeId] = objInFor[convPrjDataBase.DataBaseTypeId];
objDR[convPrjDataBase.DataBaseName] = objInFor[convPrjDataBase.DataBaseName];
objDR[convPrjDataBase.DatabaseOwner] = objInFor[convPrjDataBase.DatabaseOwner];
objDR[convPrjDataBase.DataBasePwd] = objInFor[convPrjDataBase.DataBasePwd];
objDR[convPrjDataBase.DataBaseUserId] = objInFor[convPrjDataBase.DataBaseUserId];
objDR[convPrjDataBase.IpAddress] = objInFor[convPrjDataBase.IpAddress];
objDR[convPrjDataBase.TableSpace] = objInFor[convPrjDataBase.TableSpace];
objDR[convPrjDataBase.UpdDate] = objInFor[convPrjDataBase.UpdDate];
objDR[convPrjDataBase.Sid] = objInFor[convPrjDataBase.Sid];
objDR[convPrjDataBase.UserId] = objInFor[convPrjDataBase.UserId];
objDR[convPrjDataBase.Memo] = objInFor[convPrjDataBase.Memo];
objDR[convPrjDataBase.UseStateName] = objInFor[convPrjDataBase.UseStateName];
objDR[convPrjDataBase.UseStateId] = objInFor[convPrjDataBase.UseStateId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}