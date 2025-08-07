
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLinkRelaWApi
 表名:vUserLinkRela(00050166)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class  clsvUserLinkRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetmId(this clsvUserLinkRelaEN objvUserLinkRelaEN, long lngmId, string strComparisonOp="")
	{
objvUserLinkRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.mId) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.mId, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.mId] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetUserId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convUserLinkRela.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convUserLinkRela.UserId);
objvUserLinkRelaEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.UserId) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.UserId, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.UserId] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkName">链接名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetLinkName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strLinkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLinkName, convUserLinkRela.LinkName);
clsCheckSql.CheckFieldLen(strLinkName, 30, convUserLinkRela.LinkName);
objvUserLinkRelaEN.LinkName = strLinkName; //链接名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.LinkName) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.LinkName, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.LinkName] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeName">数据库类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseTypeName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeName, convUserLinkRela.DataBaseTypeName);
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convUserLinkRela.DataBaseTypeName);
objvUserLinkRelaEN.DataBaseTypeName = strDataBaseTypeName; //数据库类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.DataBaseTypeName) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.DataBaseTypeName, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.DataBaseTypeName] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseTypeId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convUserLinkRela.DataBaseTypeId);
objvUserLinkRelaEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.DataBaseTypeId) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.DataBaseTypeId, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.DataBaseTypeId] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetIpAddress(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convUserLinkRela.IpAddress);
clsCheckSql.CheckFieldLen(strIpAddress, 25, convUserLinkRela.IpAddress);
objvUserLinkRelaEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.IpAddress) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.IpAddress, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.IpAddress] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库的用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBasePwd(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convUserLinkRela.DataBasePwd);
objvUserLinkRelaEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.DataBasePwd) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.DataBasePwd, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.DataBasePwd] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库的用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseUserId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convUserLinkRela.DataBaseUserId);
objvUserLinkRelaEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.DataBaseUserId) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.DataBaseUserId, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.DataBaseUserId] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convUserLinkRela.DataBaseName);
objvUserLinkRelaEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.DataBaseName) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.DataBaseName, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.DataBaseName] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSid">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetSid(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSid, convUserLinkRela.Sid);
clsCheckSql.CheckFieldLen(strSid, 50, convUserLinkRela.Sid);
objvUserLinkRelaEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.Sid) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.Sid, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.Sid] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strConnectionString">连接串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetConnectionString(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strConnectionString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConnectionString, convUserLinkRela.ConnectionString);
clsCheckSql.CheckFieldLen(strConnectionString, 200, convUserLinkRela.ConnectionString);
objvUserLinkRelaEN.ConnectionString = strConnectionString; //连接串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.ConnectionString) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.ConnectionString, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.ConnectionString] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetMemo(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserLinkRela.Memo);
objvUserLinkRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserLinkRelaEN.dicFldComparisonOp.ContainsKey(convUserLinkRela.Memo) == false)
{
objvUserLinkRelaEN.dicFldComparisonOp.Add(convUserLinkRela.Memo, strComparisonOp);
}
else
{
objvUserLinkRelaEN.dicFldComparisonOp[convUserLinkRela.Memo] = strComparisonOp;
}
}
return objvUserLinkRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserLinkRelaEN objvUserLinkRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.mId) == true)
{
string strComparisonOpmId = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserLinkRela.mId, objvUserLinkRelaCond.mId, strComparisonOpmId);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.UserId) == true)
{
string strComparisonOpUserId = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.UserId, objvUserLinkRelaCond.UserId, strComparisonOpUserId);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.LinkName) == true)
{
string strComparisonOpLinkName = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.LinkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.LinkName, objvUserLinkRelaCond.LinkName, strComparisonOpLinkName);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.DataBaseTypeName) == true)
{
string strComparisonOpDataBaseTypeName = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.DataBaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.DataBaseTypeName, objvUserLinkRelaCond.DataBaseTypeName, strComparisonOpDataBaseTypeName);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.DataBaseTypeId, objvUserLinkRelaCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.IpAddress) == true)
{
string strComparisonOpIpAddress = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.IpAddress, objvUserLinkRelaCond.IpAddress, strComparisonOpIpAddress);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.DataBasePwd, objvUserLinkRelaCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.DataBaseUserId, objvUserLinkRelaCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.DataBaseName, objvUserLinkRelaCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.Sid) == true)
{
string strComparisonOpSid = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.Sid, objvUserLinkRelaCond.Sid, strComparisonOpSid);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.ConnectionString) == true)
{
string strComparisonOpConnectionString = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.ConnectionString];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.ConnectionString, objvUserLinkRelaCond.ConnectionString, strComparisonOpConnectionString);
}
if (objvUserLinkRelaCond.IsUpdated(convUserLinkRela.Memo) == true)
{
string strComparisonOpMemo = objvUserLinkRelaCond.dicFldComparisonOp[convUserLinkRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserLinkRela.Memo, objvUserLinkRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户链接关系(vUserLinkRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserLinkRelaWApi
{
private static readonly string mstrApiControllerName = "vUserLinkRelaApi";

 public clsvUserLinkRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserLinkRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvUserLinkRelaEN objvUserLinkRelaEN;
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
objvUserLinkRelaEN = JsonConvert.DeserializeObject<clsvUserLinkRelaEN>(strJson);
return objvUserLinkRelaEN;
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
public static clsvUserLinkRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUserLinkRelaEN objvUserLinkRelaEN;
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
objvUserLinkRelaEN = JsonConvert.DeserializeObject<clsvUserLinkRelaEN>(strJson);
return objvUserLinkRelaEN;
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
public static List<clsvUserLinkRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
public static List<clsvUserLinkRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
public static List<clsvUserLinkRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
public static List<clsvUserLinkRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
public static List<clsvUserLinkRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
public static List<clsvUserLinkRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUserLinkRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserLinkRelaEN>>(strJson);
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
 /// <param name = "objvUserLinkRelaENS">源对象</param>
 /// <param name = "objvUserLinkRelaENT">目标对象</param>
 public static void CopyTo(clsvUserLinkRelaEN objvUserLinkRelaENS, clsvUserLinkRelaEN objvUserLinkRelaENT)
{
try
{
objvUserLinkRelaENT.mId = objvUserLinkRelaENS.mId; //mId
objvUserLinkRelaENT.UserId = objvUserLinkRelaENS.UserId; //用户Id
objvUserLinkRelaENT.LinkName = objvUserLinkRelaENS.LinkName; //链接名称
objvUserLinkRelaENT.DataBaseTypeName = objvUserLinkRelaENS.DataBaseTypeName; //数据库类型名
objvUserLinkRelaENT.DataBaseTypeId = objvUserLinkRelaENS.DataBaseTypeId; //数据库类型ID
objvUserLinkRelaENT.IpAddress = objvUserLinkRelaENS.IpAddress; //服务器
objvUserLinkRelaENT.DataBasePwd = objvUserLinkRelaENS.DataBasePwd; //数据库的用户口令
objvUserLinkRelaENT.DataBaseUserId = objvUserLinkRelaENS.DataBaseUserId; //数据库的用户ID
objvUserLinkRelaENT.DataBaseName = objvUserLinkRelaENS.DataBaseName; //数据库名
objvUserLinkRelaENT.Sid = objvUserLinkRelaENS.Sid; //SID
objvUserLinkRelaENT.ConnectionString = objvUserLinkRelaENS.ConnectionString; //连接串
objvUserLinkRelaENT.Memo = objvUserLinkRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvUserLinkRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserLinkRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserLinkRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserLinkRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserLinkRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserLinkRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvUserLinkRelaEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvUserLinkRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserLinkRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserLinkRela.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.LinkName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.DataBaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.Sid, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.ConnectionString, Type.GetType("System.String"));
objDT.Columns.Add(convUserLinkRela.Memo, Type.GetType("System.String"));
foreach (clsvUserLinkRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserLinkRela.mId] = objInFor[convUserLinkRela.mId];
objDR[convUserLinkRela.UserId] = objInFor[convUserLinkRela.UserId];
objDR[convUserLinkRela.LinkName] = objInFor[convUserLinkRela.LinkName];
objDR[convUserLinkRela.DataBaseTypeName] = objInFor[convUserLinkRela.DataBaseTypeName];
objDR[convUserLinkRela.DataBaseTypeId] = objInFor[convUserLinkRela.DataBaseTypeId];
objDR[convUserLinkRela.IpAddress] = objInFor[convUserLinkRela.IpAddress];
objDR[convUserLinkRela.DataBasePwd] = objInFor[convUserLinkRela.DataBasePwd];
objDR[convUserLinkRela.DataBaseUserId] = objInFor[convUserLinkRela.DataBaseUserId];
objDR[convUserLinkRela.DataBaseName] = objInFor[convUserLinkRela.DataBaseName];
objDR[convUserLinkRela.Sid] = objInFor[convUserLinkRela.Sid];
objDR[convUserLinkRela.ConnectionString] = objInFor[convUserLinkRela.ConnectionString];
objDR[convUserLinkRela.Memo] = objInFor[convUserLinkRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}