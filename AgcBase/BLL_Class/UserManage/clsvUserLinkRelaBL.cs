
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLinkRelaBL
 表名:vUserLinkRela(00050166)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvUserLinkRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserLinkRelaEN GetObj(this K_mId_vUserLinkRela myKey)
{
clsvUserLinkRelaEN objvUserLinkRelaEN = clsvUserLinkRelaBL.vUserLinkRelaDA.GetObjBymId(myKey.Value);
return objvUserLinkRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetUserId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convUserLinkRela.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserLinkRela.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetLinkName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strLinkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLinkName, convUserLinkRela.LinkName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkName, 30, convUserLinkRela.LinkName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseTypeName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeName, convUserLinkRela.DataBaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convUserLinkRela.DataBaseTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseTypeId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convUserLinkRela.DataBaseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convUserLinkRela.DataBaseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convUserLinkRela.DataBaseTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetIpAddress(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convUserLinkRela.IpAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convUserLinkRela.IpAddress);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBasePwd(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBasePwd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convUserLinkRela.DataBasePwd);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseUserId(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convUserLinkRela.DataBaseUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetDataBaseName(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convUserLinkRela.DataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetSid(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSid, convUserLinkRela.Sid);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSid, 50, convUserLinkRela.Sid);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetConnectionString(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strConnectionString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConnectionString, convUserLinkRela.ConnectionString);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectionString, 200, convUserLinkRela.ConnectionString);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserLinkRelaEN SetMemo(this clsvUserLinkRelaEN objvUserLinkRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserLinkRela.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserLinkRelaENS">源对象</param>
 /// <param name = "objvUserLinkRelaENT">目标对象</param>
 public static void CopyTo(this clsvUserLinkRelaEN objvUserLinkRelaENS, clsvUserLinkRelaEN objvUserLinkRelaENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvUserLinkRelaENS">源对象</param>
 /// <returns>目标对象=>clsvUserLinkRelaEN:objvUserLinkRelaENT</returns>
 public static clsvUserLinkRelaEN CopyTo(this clsvUserLinkRelaEN objvUserLinkRelaENS)
{
try
{
 clsvUserLinkRelaEN objvUserLinkRelaENT = new clsvUserLinkRelaEN()
{
mId = objvUserLinkRelaENS.mId, //mId
UserId = objvUserLinkRelaENS.UserId, //用户Id
LinkName = objvUserLinkRelaENS.LinkName, //链接名称
DataBaseTypeName = objvUserLinkRelaENS.DataBaseTypeName, //数据库类型名
DataBaseTypeId = objvUserLinkRelaENS.DataBaseTypeId, //数据库类型ID
IpAddress = objvUserLinkRelaENS.IpAddress, //服务器
DataBasePwd = objvUserLinkRelaENS.DataBasePwd, //数据库的用户口令
DataBaseUserId = objvUserLinkRelaENS.DataBaseUserId, //数据库的用户ID
DataBaseName = objvUserLinkRelaENS.DataBaseName, //数据库名
Sid = objvUserLinkRelaENS.Sid, //SID
ConnectionString = objvUserLinkRelaENS.ConnectionString, //连接串
Memo = objvUserLinkRelaENS.Memo, //说明
};
 return objvUserLinkRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvUserLinkRelaEN objvUserLinkRelaEN)
{
 clsvUserLinkRelaBL.vUserLinkRelaDA.CheckProperty4Condition(objvUserLinkRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserLinkRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户链接关系(vUserLinkRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserLinkRelaBL
{
public static RelatedActions_vUserLinkRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserLinkRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserLinkRelaDA vUserLinkRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserLinkRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserLinkRelaBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvUserLinkRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserLinkRelaEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vUserLinkRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable_vUserLinkRela(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vUserLinkRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserLinkRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvUserLinkRelaEN._CurrTabName);
List<clsvUserLinkRelaEN> arrvUserLinkRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvUserLinkRelaEN> arrvUserLinkRelaObjLst_Sel =
arrvUserLinkRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvUserLinkRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLst(string strWhereCond)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserLinkRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserLinkRelaEN> GetSubObjLstCache(clsvUserLinkRelaEN objvUserLinkRelaCond)
{
List<clsvUserLinkRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserLinkRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserLinkRela._AttributeName)
{
if (objvUserLinkRelaCond.IsUpdated(strFldName) == false) continue;
if (objvUserLinkRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserLinkRelaCond[strFldName].ToString());
}
else
{
if (objvUserLinkRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserLinkRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserLinkRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserLinkRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserLinkRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserLinkRelaCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvUserLinkRelaEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserLinkRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserLinkRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserLinkRela(ref clsvUserLinkRelaEN objvUserLinkRelaEN)
{
bool bolResult = vUserLinkRelaDA.GetvUserLinkRela(ref objvUserLinkRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserLinkRelaEN GetObjBymId(long lngmId)
{
clsvUserLinkRelaEN objvUserLinkRelaEN = vUserLinkRelaDA.GetObjBymId(lngmId);
return objvUserLinkRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserLinkRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserLinkRelaEN objvUserLinkRelaEN = vUserLinkRelaDA.GetFirstObj(strWhereCond);
 return objvUserLinkRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvUserLinkRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserLinkRelaEN objvUserLinkRelaEN = vUserLinkRelaDA.GetObjByDataRow(objRow);
 return objvUserLinkRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvUserLinkRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserLinkRelaEN objvUserLinkRelaEN = vUserLinkRelaDA.GetObjByDataRow(objRow);
 return objvUserLinkRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvUserLinkRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserLinkRelaEN GetObjBymIdFromList(long lngmId, List<clsvUserLinkRelaEN> lstvUserLinkRelaObjLst)
{
foreach (clsvUserLinkRelaEN objvUserLinkRelaEN in lstvUserLinkRelaObjLst)
{
if (objvUserLinkRelaEN.mId == lngmId)
{
return objvUserLinkRelaEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvUserLinkRelaDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vUserLinkRelaDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vUserLinkRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vUserLinkRelaDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvUserLinkRelaDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vUserLinkRelaDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserLinkRelaEN objvUserLinkRelaEN)
{
try
{
objvUserLinkRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserLinkRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserLinkRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.mId = objvUserLinkRelaEN.mId; //mId
}
if (arrFldSet.Contains(convUserLinkRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.UserId = objvUserLinkRelaEN.UserId; //用户Id
}
if (arrFldSet.Contains(convUserLinkRela.LinkName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.LinkName = objvUserLinkRelaEN.LinkName; //链接名称
}
if (arrFldSet.Contains(convUserLinkRela.DataBaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.DataBaseTypeName = objvUserLinkRelaEN.DataBaseTypeName; //数据库类型名
}
if (arrFldSet.Contains(convUserLinkRela.DataBaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.DataBaseTypeId = objvUserLinkRelaEN.DataBaseTypeId; //数据库类型ID
}
if (arrFldSet.Contains(convUserLinkRela.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.IpAddress = objvUserLinkRelaEN.IpAddress; //服务器
}
if (arrFldSet.Contains(convUserLinkRela.DataBasePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.DataBasePwd = objvUserLinkRelaEN.DataBasePwd == "[null]" ? null :  objvUserLinkRelaEN.DataBasePwd; //数据库的用户口令
}
if (arrFldSet.Contains(convUserLinkRela.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.DataBaseUserId = objvUserLinkRelaEN.DataBaseUserId == "[null]" ? null :  objvUserLinkRelaEN.DataBaseUserId; //数据库的用户ID
}
if (arrFldSet.Contains(convUserLinkRela.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.DataBaseName = objvUserLinkRelaEN.DataBaseName == "[null]" ? null :  objvUserLinkRelaEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convUserLinkRela.Sid, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.Sid = objvUserLinkRelaEN.Sid; //SID
}
if (arrFldSet.Contains(convUserLinkRela.ConnectionString, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.ConnectionString = objvUserLinkRelaEN.ConnectionString; //连接串
}
if (arrFldSet.Contains(convUserLinkRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserLinkRelaEN.Memo = objvUserLinkRelaEN.Memo == "[null]" ? null :  objvUserLinkRelaEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserLinkRelaEN objvUserLinkRelaEN)
{
try
{
if (objvUserLinkRelaEN.DataBasePwd == "[null]") objvUserLinkRelaEN.DataBasePwd = null; //数据库的用户口令
if (objvUserLinkRelaEN.DataBaseUserId == "[null]") objvUserLinkRelaEN.DataBaseUserId = null; //数据库的用户ID
if (objvUserLinkRelaEN.DataBaseName == "[null]") objvUserLinkRelaEN.DataBaseName = null; //数据库名
if (objvUserLinkRelaEN.Memo == "[null]") objvUserLinkRelaEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvUserLinkRelaEN objvUserLinkRelaEN)
{
 vUserLinkRelaDA.CheckProperty4Condition(objvUserLinkRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsDataBaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataBaseTypeBL没有刷新缓存机制(clsDataBaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserLinkRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserLinkRelaBL没有刷新缓存机制(clsUserLinkRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvUserLinkRelaObjLstCache == null)
//{
//arrvUserLinkRelaObjLstCache = vUserLinkRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserLinkRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUserLinkRelaEN._CurrTabName);
List<clsvUserLinkRelaEN> arrvUserLinkRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvUserLinkRelaEN> arrvUserLinkRelaObjLst_Sel =
arrvUserLinkRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvUserLinkRelaObjLst_Sel.Count() == 0)
{
   clsvUserLinkRelaEN obj = clsvUserLinkRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUserLinkRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserLinkRelaEN> GetAllvUserLinkRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvUserLinkRelaEN> arrvUserLinkRelaObjLstCache = GetObjLstCache(); 
return arrvUserLinkRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserLinkRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUserLinkRelaEN._CurrTabName);
List<clsvUserLinkRelaEN> arrvUserLinkRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserLinkRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvUserLinkRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvUserLinkRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvUserLinkRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvUserLinkRelaEN._RefreshTimeLst[clsvUserLinkRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convUserLinkRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserLinkRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserLinkRela._AttributeName));
throw new Exception(strMsg);
}
var objvUserLinkRela = clsvUserLinkRelaBL.GetObjBymIdCache(lngmId);
if (objvUserLinkRela == null) return "";
return objvUserLinkRela[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvUserLinkRelaDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvUserLinkRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserLinkRelaDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvUserLinkRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserLinkRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserLinkRelaEN objvUserLinkRelaCond)
{
List<clsvUserLinkRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserLinkRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserLinkRela._AttributeName)
{
if (objvUserLinkRelaCond.IsUpdated(strFldName) == false) continue;
if (objvUserLinkRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserLinkRelaCond[strFldName].ToString());
}
else
{
if (objvUserLinkRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserLinkRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserLinkRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserLinkRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserLinkRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserLinkRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserLinkRelaCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvUserLinkRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vUserLinkRelaDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vUserLinkRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}