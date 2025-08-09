
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjDataBaseWApi
 表名:PrjDataBase(00050176)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:17
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
public static class  clsPrjDataBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetPrjDataBaseId(this clsPrjDataBaseEN objPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
objPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.PrjDataBaseId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.PrjDataBaseId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.PrjDataBaseId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetPrjDataBaseName(this clsPrjDataBaseEN objPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseName, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, conPrjDataBase.PrjDataBaseName);
objPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.PrjDataBaseName) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseName(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conPrjDataBase.DataBaseName);
objPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseName) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDatabaseOwner">数据库拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDatabaseOwner(this clsPrjDataBaseEN objPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, conPrjDataBase.DatabaseOwner);
objPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DatabaseOwner) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库的用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBasePwd(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBasePwd, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, conPrjDataBase.DataBasePwd);
objPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBasePwd) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseTypeId(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
objPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseTypeId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库的用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseUserId(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, conPrjDataBase.DataBaseUserId);
objPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseUserId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetIpAddress(this clsPrjDataBaseEN objPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 25, conPrjDataBase.IpAddress);
objPrjDataBaseEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.IpAddress) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSid">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetSid(this clsPrjDataBaseEN objPrjDataBaseEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSid, 50, conPrjDataBase.Sid);
objPrjDataBaseEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.Sid) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.Sid, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.Sid] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetTableSpace(this clsPrjDataBaseEN objPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 50, conPrjDataBase.TableSpace);
objPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.TableSpace) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUseStateId(this clsPrjDataBaseEN objPrjDataBaseEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conPrjDataBase.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, conPrjDataBase.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conPrjDataBase.UseStateId);
objPrjDataBaseEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UseStateId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UseStateId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UseStateId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUserId(this clsPrjDataBaseEN objPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conPrjDataBase.UserId);
objPrjDataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UserId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UserId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UserId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUpdDate(this clsPrjDataBaseEN objPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjDataBase.UpdDate);
objPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UpdDate) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetMemo(this clsPrjDataBaseEN objPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjDataBase.Memo);
objPrjDataBaseEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.Memo) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.Memo, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.Memo] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjDataBaseEN objPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.PrjDataBaseId, objPrjDataBaseCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.PrjDataBaseName, objPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseName, objPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DatabaseOwner, objPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBasePwd, objPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseTypeId, objPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseUserId, objPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.IpAddress, objPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.Sid) == true)
{
string strComparisonOpSid = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.Sid, objPrjDataBaseCond.Sid, strComparisonOpSid);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.TableSpace, objPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UseStateId) == true)
{
string strComparisonOpUseStateId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UseStateId, objPrjDataBaseCond.UseStateId, strComparisonOpUseStateId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UserId, objPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UpdDate, objPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.Memo, objPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjDataBaseEN objPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjDataBaseEN.sfUpdFldSetStr = objPrjDataBaseEN.getsfUpdFldSetStr();
clsPrjDataBaseWApi.CheckPropertyNew(objPrjDataBaseEN); 
bool bolResult = clsPrjDataBaseWApi.UpdateRecord(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--PrjDataBase(数据库对象), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjDataBaseEN objPrjDataBaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjDataBaseEN == null) return "";
if (objPrjDataBaseEN.PrjDataBaseId == null || objPrjDataBaseEN.PrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjDataBaseId !=  '{0}'", objPrjDataBaseEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseWApi.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseWApi.GetMaxStrId();
 }
clsPrjDataBaseWApi.CheckPropertyNew(objPrjDataBaseEN); 
bool bolResult = clsPrjDataBaseWApi.AddNewRecord(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
clsPrjDataBaseWApi.CheckPropertyNew(objPrjDataBaseEN); 
string strPrjDataBaseId = clsPrjDataBaseWApi.AddNewRecordWithMaxId(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
return strPrjDataBaseId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjDataBaseEN objPrjDataBaseEN, string strWhereCond)
{
try
{
clsPrjDataBaseWApi.CheckPropertyNew(objPrjDataBaseEN); 
bool bolResult = clsPrjDataBaseWApi.UpdateWithCondition(objPrjDataBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjDataBaseWApi
{
private static readonly string mstrApiControllerName = "PrjDataBaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsPrjDataBaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
List<clsPrjDataBaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PrjDataBaseId";
objDDL.DataTextField="PrjDataBaseName";
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

public static void BindCbo_PrjDataBaseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjDataBase.PrjDataBaseId); 
List<clsPrjDataBaseEN> arrObjLst = clsPrjDataBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN()
{
PrjDataBaseId = "0",
PrjDataBaseName = "选[数据库对象]..."
};
arrObjLst.Insert(0, objPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjDataBase.PrjDataBaseId;
objComboBox.DisplayMember = conPrjDataBase.PrjDataBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjDataBaseEN objPrjDataBaseEN)
{
if (!Object.Equals(null, objPrjDataBaseEN.PrjDataBaseId) && GetStrLen(objPrjDataBaseEN.PrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjDataBaseEN.PrjDataBaseName) && GetStrLen(objPrjDataBaseEN.PrjDataBaseName) > 50)
{
 throw new Exception("字段[项目数据库名]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjDataBaseEN.DataBaseName) && GetStrLen(objPrjDataBaseEN.DataBaseName) > 50)
{
 throw new Exception("字段[数据库名]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjDataBaseEN.DatabaseOwner) && GetStrLen(objPrjDataBaseEN.DatabaseOwner) > 30)
{
 throw new Exception("字段[数据库拥有者]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjDataBaseEN.DataBasePwd) && GetStrLen(objPrjDataBaseEN.DataBasePwd) > 30)
{
 throw new Exception("字段[数据库的用户口令]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjDataBaseEN.DataBaseTypeId) && GetStrLen(objPrjDataBaseEN.DataBaseTypeId) > 2)
{
 throw new Exception("字段[数据库类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjDataBaseEN.DataBaseUserId) && GetStrLen(objPrjDataBaseEN.DataBaseUserId) > 30)
{
 throw new Exception("字段[数据库的用户ID]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjDataBaseEN.IpAddress) && GetStrLen(objPrjDataBaseEN.IpAddress) > 25)
{
 throw new Exception("字段[服务器]的长度不能超过25!");
}
if (!Object.Equals(null, objPrjDataBaseEN.Sid) && GetStrLen(objPrjDataBaseEN.Sid) > 50)
{
 throw new Exception("字段[SID]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjDataBaseEN.TableSpace) && GetStrLen(objPrjDataBaseEN.TableSpace) > 50)
{
 throw new Exception("字段[表空间]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjDataBaseEN.UseStateId) && GetStrLen(objPrjDataBaseEN.UseStateId) > 4)
{
 throw new Exception("字段[使用状态Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjDataBaseEN.UserId) && GetStrLen(objPrjDataBaseEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objPrjDataBaseEN.UpdDate) && GetStrLen(objPrjDataBaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjDataBaseEN.Memo) && GetStrLen(objPrjDataBaseEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objPrjDataBaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
if (strPrjDataBaseId == "") return null;
string strAction = "GetObjByPrjDataBaseId";
clsPrjDataBaseEN objPrjDataBaseEN;
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
objPrjDataBaseEN = JsonConvert.DeserializeObject<clsPrjDataBaseEN>(strJson);
return objPrjDataBaseEN;
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
public static clsPrjDataBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjDataBaseEN objPrjDataBaseEN;
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
objPrjDataBaseEN = JsonConvert.DeserializeObject<clsPrjDataBaseEN>(strJson);
return objPrjDataBaseEN;
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
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjDataBaseEN GetObjByPrjDataBaseIdCache(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel =
from objPrjDataBaseEN in arrPrjDataBaseObjLstCache
where objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId 
select objPrjDataBaseEN;
if (arrPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsPrjDataBaseEN obj = clsPrjDataBaseWApi.GetObjByPrjDataBaseId(strPrjDataBaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjDataBaseNameByPrjDataBaseIdCache(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return "";
//初始化列表缓存
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel1 =
from objPrjDataBaseEN in arrPrjDataBaseObjLstCache
where objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId 
select objPrjDataBaseEN;
List <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel = new List<clsPrjDataBaseEN>();
foreach (clsPrjDataBaseEN obj in arrPrjDataBaseObjLst_Sel1)
{
arrPrjDataBaseObjLst_Sel.Add(obj);
}
if (arrPrjDataBaseObjLst_Sel.Count > 0)
{
return arrPrjDataBaseObjLst_Sel[0].PrjDataBaseName;
}
string strErrMsgForGetObjById = string.Format("在PrjDataBase对象缓存列表中,找不到记录[PrjDataBaseId = {0}](函数:{1})", strPrjDataBaseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjDataBaseIdCache(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return "";
//初始化列表缓存
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel1 =
from objPrjDataBaseEN in arrPrjDataBaseObjLstCache
where objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId 
select objPrjDataBaseEN;
List <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel = new List<clsPrjDataBaseEN>();
foreach (clsPrjDataBaseEN obj in arrPrjDataBaseObjLst_Sel1)
{
arrPrjDataBaseObjLst_Sel.Add(obj);
}
if (arrPrjDataBaseObjLst_Sel.Count > 0)
{
return arrPrjDataBaseObjLst_Sel[0].PrjDataBaseName;
}
string strErrMsgForGetObjById = string.Format("在PrjDataBase对象缓存列表中,找不到记录的相关名称[PrjDataBaseId = {0}](函数:{1})", strPrjDataBaseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
public static List<clsPrjDataBaseEN> GetObjLstByPrjDataBaseIdLst(List<string> arrPrjDataBaseId)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
 /// <param name = "arrPrjDataBaseId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsPrjDataBaseEN> GetObjLstByPrjDataBaseIdLstCache(List<string> arrPrjDataBaseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel =
from objPrjDataBaseEN in arrPrjDataBaseObjLstCache
where arrPrjDataBaseId.Contains(objPrjDataBaseEN.PrjDataBaseId)
select objPrjDataBaseEN;
return arrPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
public static List<clsPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
public static List<clsPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
public static List<clsPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjDataBaseEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strPrjDataBaseId)
{
string strAction = "DelRecord";
try
{
 clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseId(strPrjDataBaseId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPrjDataBaseId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjDataBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPrjDataBases(List<string> arrPrjDataBaseId)
{
string strAction = "DelPrjDataBases";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjDataBaseId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjDataBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPrjDataBasesByCond(string strWhereCond)
{
string strAction = "DelPrjDataBasesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsPrjDataBaseEN objPrjDataBaseEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjDataBaseEN>(objPrjDataBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsPrjDataBaseEN objPrjDataBaseEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjDataBaseEN>(objPrjDataBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshCache();
var strPrjDataBaseId = (string)jobjReturn0["returnStr"];
return strPrjDataBaseId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPrjDataBaseEN objPrjDataBaseEN)
{
if (string.IsNullOrEmpty(objPrjDataBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjDataBaseEN.PrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjDataBaseEN>(objPrjDataBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjDataBaseEN objPrjDataBaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjDataBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjDataBaseEN.PrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjDataBaseEN.PrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjDataBaseEN>(objPrjDataBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objPrjDataBaseENS">源对象</param>
 /// <param name = "objPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsPrjDataBaseEN objPrjDataBaseENS, clsPrjDataBaseEN objPrjDataBaseENT)
{
try
{
objPrjDataBaseENT.PrjDataBaseId = objPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objPrjDataBaseENT.PrjDataBaseName = objPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objPrjDataBaseENT.DataBaseName = objPrjDataBaseENS.DataBaseName; //数据库名
objPrjDataBaseENT.DatabaseOwner = objPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objPrjDataBaseENT.DataBasePwd = objPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objPrjDataBaseENT.DataBaseTypeId = objPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objPrjDataBaseENT.DataBaseUserId = objPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objPrjDataBaseENT.IpAddress = objPrjDataBaseENS.IpAddress; //服务器
objPrjDataBaseENT.Sid = objPrjDataBaseENS.Sid; //SID
objPrjDataBaseENT.TableSpace = objPrjDataBaseENS.TableSpace; //表空间
objPrjDataBaseENT.UseStateId = objPrjDataBaseENS.UseStateId; //使用状态Id
objPrjDataBaseENT.UserId = objPrjDataBaseENS.UserId; //用户Id
objPrjDataBaseENT.UpdDate = objPrjDataBaseENS.UpdDate; //修改日期
objPrjDataBaseENT.Memo = objPrjDataBaseENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsPrjDataBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjDataBaseEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjDataBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjDataBaseEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjDataBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjDataBaseEN._AttributeName)
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
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPrjDataBaseWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjDataBaseWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsPrjDataBaseEN._CurrTabName;
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjDataBaseObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjDataBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjDataBase.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.DatabaseOwner, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.Sid, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjDataBase.Memo, Type.GetType("System.String"));
foreach (clsPrjDataBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjDataBase.PrjDataBaseId] = objInFor[conPrjDataBase.PrjDataBaseId];
objDR[conPrjDataBase.PrjDataBaseName] = objInFor[conPrjDataBase.PrjDataBaseName];
objDR[conPrjDataBase.DataBaseName] = objInFor[conPrjDataBase.DataBaseName];
objDR[conPrjDataBase.DatabaseOwner] = objInFor[conPrjDataBase.DatabaseOwner];
objDR[conPrjDataBase.DataBasePwd] = objInFor[conPrjDataBase.DataBasePwd];
objDR[conPrjDataBase.DataBaseTypeId] = objInFor[conPrjDataBase.DataBaseTypeId];
objDR[conPrjDataBase.DataBaseUserId] = objInFor[conPrjDataBase.DataBaseUserId];
objDR[conPrjDataBase.IpAddress] = objInFor[conPrjDataBase.IpAddress];
objDR[conPrjDataBase.Sid] = objInFor[conPrjDataBase.Sid];
objDR[conPrjDataBase.TableSpace] = objInFor[conPrjDataBase.TableSpace];
objDR[conPrjDataBase.UseStateId] = objInFor[conPrjDataBase.UseStateId];
objDR[conPrjDataBase.UserId] = objInFor[conPrjDataBase.UserId];
objDR[conPrjDataBase.UpdDate] = objInFor[conPrjDataBase.UpdDate];
objDR[conPrjDataBase.Memo] = objInFor[conPrjDataBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjDataBase : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseWApi.ReFreshThisCache();
}
}

}