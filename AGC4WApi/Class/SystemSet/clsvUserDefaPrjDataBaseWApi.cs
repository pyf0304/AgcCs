
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserDefaPrjDataBaseWApi
 表名:vUserDefaPrjDataBase(00050275)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserDefaPrjDataBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetmId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, long lngmId, string strComparisonOp="")
	{
objvUserDefaPrjDataBaseEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.mId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.mId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.mId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserDefaPrjDataBase.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserDefaPrjDataBase.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserDefaPrjDataBase.PrjId);
objvUserDefaPrjDataBaseEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserDefaPrjDataBase.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserDefaPrjDataBase.PrjName);
objvUserDefaPrjDataBaseEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserDefaPrjDataBase.UserId);
objvUserDefaPrjDataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUserName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserDefaPrjDataBase.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convUserDefaPrjDataBase.UserName);
objvUserDefaPrjDataBaseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UserName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UserName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UserName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjDataBaseId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convUserDefaPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convUserDefaPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convUserDefaPrjDataBase.PrjDataBaseId);
objvUserDefaPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjDataBaseId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjDataBaseId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjDataBaseName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convUserDefaPrjDataBase.PrjDataBaseName);
objvUserDefaPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjDataBaseName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetDataBaseName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseName, convUserDefaPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convUserDefaPrjDataBase.DataBaseName);
objvUserDefaPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.DataBaseName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetIpAddress(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convUserDefaPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(strIpAddress, 25, convUserDefaPrjDataBase.IpAddress);
objvUserDefaPrjDataBaseEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.IpAddress) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库的用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetDataBaseUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convUserDefaPrjDataBase.DataBaseUserId);
objvUserDefaPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.DataBaseUserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUpdUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserDefaPrjDataBase.UpdUserId);
objvUserDefaPrjDataBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UpdUserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UpdUserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UpdUserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUpdDate(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserDefaPrjDataBase.UpdDate);
objvUserDefaPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UpdDate) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetMemo(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserDefaPrjDataBase.Memo);
objvUserDefaPrjDataBaseEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.Memo) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.Memo, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.Memo] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.mId) == true)
{
string strComparisonOpmId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserDefaPrjDataBase.mId, objvUserDefaPrjDataBaseCond.mId, strComparisonOpmId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjId) == true)
{
string strComparisonOpPrjId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjId, objvUserDefaPrjDataBaseCond.PrjId, strComparisonOpPrjId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjName) == true)
{
string strComparisonOpPrjName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjName, objvUserDefaPrjDataBaseCond.PrjName, strComparisonOpPrjName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UserId, objvUserDefaPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UserName) == true)
{
string strComparisonOpUserName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UserName, objvUserDefaPrjDataBaseCond.UserName, strComparisonOpUserName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjDataBaseId, objvUserDefaPrjDataBaseCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjDataBaseName, objvUserDefaPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.DataBaseName, objvUserDefaPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.IpAddress, objvUserDefaPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.DataBaseUserId, objvUserDefaPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UpdUserId, objvUserDefaPrjDataBaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UpdDate, objvUserDefaPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.Memo, objvUserDefaPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户默认数据库(vUserDefaPrjDataBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserDefaPrjDataBaseWApi
{
private static readonly string mstrApiControllerName = "vUserDefaPrjDataBaseApi";

 public clsvUserDefaPrjDataBaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserDefaPrjDataBaseEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN;
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
objvUserDefaPrjDataBaseEN = JsonConvert.DeserializeObject<clsvUserDefaPrjDataBaseEN>(strJson);
return objvUserDefaPrjDataBaseEN;
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
public static clsvUserDefaPrjDataBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN;
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
objvUserDefaPrjDataBaseEN = JsonConvert.DeserializeObject<clsvUserDefaPrjDataBaseEN>(strJson);
return objvUserDefaPrjDataBaseEN;
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
public static List<clsvUserDefaPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUserDefaPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserDefaPrjDataBaseEN>>(strJson);
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
 /// <param name = "objvUserDefaPrjDataBaseENS">源对象</param>
 /// <param name = "objvUserDefaPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENS, clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENT)
{
try
{
objvUserDefaPrjDataBaseENT.mId = objvUserDefaPrjDataBaseENS.mId; //mId
objvUserDefaPrjDataBaseENT.PrjId = objvUserDefaPrjDataBaseENS.PrjId; //工程Id
objvUserDefaPrjDataBaseENT.PrjName = objvUserDefaPrjDataBaseENS.PrjName; //工程名称
objvUserDefaPrjDataBaseENT.UserId = objvUserDefaPrjDataBaseENS.UserId; //用户Id
objvUserDefaPrjDataBaseENT.UserName = objvUserDefaPrjDataBaseENS.UserName; //用户名
objvUserDefaPrjDataBaseENT.PrjDataBaseId = objvUserDefaPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objvUserDefaPrjDataBaseENT.PrjDataBaseName = objvUserDefaPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvUserDefaPrjDataBaseENT.DataBaseName = objvUserDefaPrjDataBaseENS.DataBaseName; //数据库名
objvUserDefaPrjDataBaseENT.IpAddress = objvUserDefaPrjDataBaseENS.IpAddress; //服务器
objvUserDefaPrjDataBaseENT.DataBaseUserId = objvUserDefaPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objvUserDefaPrjDataBaseENT.UpdUserId = objvUserDefaPrjDataBaseENS.UpdUserId; //修改用户Id
objvUserDefaPrjDataBaseENT.UpdDate = objvUserDefaPrjDataBaseENS.UpdDate; //修改日期
objvUserDefaPrjDataBaseENT.Memo = objvUserDefaPrjDataBaseENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvUserDefaPrjDataBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserDefaPrjDataBaseEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserDefaPrjDataBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserDefaPrjDataBaseEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserDefaPrjDataBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserDefaPrjDataBaseEN._AttributeName)
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
string strKey = string.Format("{0}", clsvUserDefaPrjDataBaseEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvUserDefaPrjDataBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserDefaPrjDataBase.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserDefaPrjDataBase.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserDefaPrjDataBase.Memo, Type.GetType("System.String"));
foreach (clsvUserDefaPrjDataBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserDefaPrjDataBase.mId] = objInFor[convUserDefaPrjDataBase.mId];
objDR[convUserDefaPrjDataBase.PrjId] = objInFor[convUserDefaPrjDataBase.PrjId];
objDR[convUserDefaPrjDataBase.PrjName] = objInFor[convUserDefaPrjDataBase.PrjName];
objDR[convUserDefaPrjDataBase.UserId] = objInFor[convUserDefaPrjDataBase.UserId];
objDR[convUserDefaPrjDataBase.UserName] = objInFor[convUserDefaPrjDataBase.UserName];
objDR[convUserDefaPrjDataBase.PrjDataBaseId] = objInFor[convUserDefaPrjDataBase.PrjDataBaseId];
objDR[convUserDefaPrjDataBase.PrjDataBaseName] = objInFor[convUserDefaPrjDataBase.PrjDataBaseName];
objDR[convUserDefaPrjDataBase.DataBaseName] = objInFor[convUserDefaPrjDataBase.DataBaseName];
objDR[convUserDefaPrjDataBase.IpAddress] = objInFor[convUserDefaPrjDataBase.IpAddress];
objDR[convUserDefaPrjDataBase.DataBaseUserId] = objInFor[convUserDefaPrjDataBase.DataBaseUserId];
objDR[convUserDefaPrjDataBase.UpdUserId] = objInFor[convUserDefaPrjDataBase.UpdUserId];
objDR[convUserDefaPrjDataBase.UpdDate] = objInFor[convUserDefaPrjDataBase.UpdDate];
objDR[convUserDefaPrjDataBase.Memo] = objInFor[convUserDefaPrjDataBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}