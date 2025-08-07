
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjDataBaseBL
 表名:vPrjDataBase(00050175)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvPrjDataBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjDataBaseEN GetObj(this K_PrjDataBaseId_vPrjDataBase myKey)
{
clsvPrjDataBaseEN objvPrjDataBaseEN = clsvPrjDataBaseBL.vPrjDataBaseDA.GetObjByPrjDataBaseId(myKey.Value);
return objvPrjDataBaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetPrjDataBaseId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convPrjDataBase.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convPrjDataBase.PrjDataBaseId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetPrjDataBaseName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convPrjDataBase.PrjDataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseTypeName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeName, convPrjDataBase.DataBaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convPrjDataBase.DataBaseTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseTypeId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convPrjDataBase.DataBaseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convPrjDataBase.DataBaseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convPrjDataBase.DataBaseTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convPrjDataBase.DataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDatabaseOwner(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, convPrjDataBase.DatabaseOwner);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBasePwd(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convPrjDataBase.DataBasePwd);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetDataBaseUserId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convPrjDataBase.DataBaseUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetIpAddress(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convPrjDataBase.IpAddress);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetTableSpace(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableSpace, 50, convPrjDataBase.TableSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUpdDate(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjDataBase.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetSid(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strSid, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSid, 50, convPrjDataBase.Sid);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUserId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjDataBase.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetMemo(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjDataBase.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUseStateName(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convPrjDataBase.UseStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjDataBaseEN SetUseStateId(this clsvPrjDataBaseEN objvPrjDataBaseEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convPrjDataBase.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convPrjDataBase.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convPrjDataBase.UseStateId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjDataBaseENS">源对象</param>
 /// <param name = "objvPrjDataBaseENT">目标对象</param>
 public static void CopyTo(this clsvPrjDataBaseEN objvPrjDataBaseENS, clsvPrjDataBaseEN objvPrjDataBaseENT)
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
 /// <param name = "objvPrjDataBaseENS">源对象</param>
 /// <returns>目标对象=>clsvPrjDataBaseEN:objvPrjDataBaseENT</returns>
 public static clsvPrjDataBaseEN CopyTo(this clsvPrjDataBaseEN objvPrjDataBaseENS)
{
try
{
 clsvPrjDataBaseEN objvPrjDataBaseENT = new clsvPrjDataBaseEN()
{
PrjDataBaseId = objvPrjDataBaseENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objvPrjDataBaseENS.PrjDataBaseName, //项目数据库名
DataBaseTypeName = objvPrjDataBaseENS.DataBaseTypeName, //数据库类型名
DataBaseTypeId = objvPrjDataBaseENS.DataBaseTypeId, //数据库类型ID
DataBaseName = objvPrjDataBaseENS.DataBaseName, //数据库名
DatabaseOwner = objvPrjDataBaseENS.DatabaseOwner, //数据库拥有者
DataBasePwd = objvPrjDataBaseENS.DataBasePwd, //数据库的用户口令
DataBaseUserId = objvPrjDataBaseENS.DataBaseUserId, //数据库的用户ID
IpAddress = objvPrjDataBaseENS.IpAddress, //服务器
TableSpace = objvPrjDataBaseENS.TableSpace, //表空间
UpdDate = objvPrjDataBaseENS.UpdDate, //修改日期
Sid = objvPrjDataBaseENS.Sid, //SID
UserId = objvPrjDataBaseENS.UserId, //用户Id
Memo = objvPrjDataBaseENS.Memo, //说明
UseStateName = objvPrjDataBaseENS.UseStateName, //使用状态名称
UseStateId = objvPrjDataBaseENS.UseStateId, //使用状态Id
};
 return objvPrjDataBaseENT;
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
public static void CheckProperty4Condition(this clsvPrjDataBaseEN objvPrjDataBaseEN)
{
 clsvPrjDataBaseBL.vPrjDataBaseDA.CheckProperty4Condition(objvPrjDataBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjDataBase
{
public virtual bool UpdRelaTabDate(string strPrjDataBaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v数据库对象(vPrjDataBase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjDataBaseBL
{
public static RelatedActions_vPrjDataBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjDataBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjDataBaseDA vPrjDataBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjDataBaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjDataBaseBL()
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
if (string.IsNullOrEmpty(clsvPrjDataBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjDataBaseEN._ConnectString);
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
public static DataTable GetDataTable_vPrjDataBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjDataBaseDA.GetDataTable_vPrjDataBase(strWhereCond);
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
objDT = vPrjDataBaseDA.GetDataTable(strWhereCond);
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
objDT = vPrjDataBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjDataBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjDataBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjDataBaseDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjDataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLstByPrjDataBaseIdLst(List<string> arrPrjDataBaseIdLst)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjDataBaseIdLst, true);
 string strWhereCond = string.Format("PrjDataBaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjDataBaseEN> GetObjLstByPrjDataBaseIdLstCache(List<string> arrPrjDataBaseIdLst)
{
string strKey = string.Format("{0}", clsvPrjDataBaseEN._CurrTabName);
List<clsvPrjDataBaseEN> arrvPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjDataBaseEN> arrvPrjDataBaseObjLst_Sel =
arrvPrjDataBaseObjLstCache
.Where(x => arrPrjDataBaseIdLst.Contains(x.PrjDataBaseId));
return arrvPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLst(string strWhereCond)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
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
public static List<clsvPrjDataBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjDataBaseEN> GetSubObjLstCache(clsvPrjDataBaseEN objvPrjDataBaseCond)
{
List<clsvPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjDataBase._AttributeName)
{
if (objvPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objvPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objvPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjDataBaseCond[strFldName]));
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
public static List<clsvPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
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
public static List<clsvPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
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
List<clsvPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
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
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
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
public static List<clsvPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
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
public static List<clsvPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjDataBase(ref clsvPrjDataBaseEN objvPrjDataBaseEN)
{
bool bolResult = vPrjDataBaseDA.GetvPrjDataBase(ref objvPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
if (strPrjDataBaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjDataBaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjDataBaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjDataBaseEN objvPrjDataBaseEN = vPrjDataBaseDA.GetObjByPrjDataBaseId(strPrjDataBaseId);
return objvPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjDataBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjDataBaseEN objvPrjDataBaseEN = vPrjDataBaseDA.GetFirstObj(strWhereCond);
 return objvPrjDataBaseEN;
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
public static clsvPrjDataBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjDataBaseEN objvPrjDataBaseEN = vPrjDataBaseDA.GetObjByDataRow(objRow);
 return objvPrjDataBaseEN;
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
public static clsvPrjDataBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjDataBaseEN objvPrjDataBaseEN = vPrjDataBaseDA.GetObjByDataRow(objRow);
 return objvPrjDataBaseEN;
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
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <param name = "lstvPrjDataBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjDataBaseEN GetObjByPrjDataBaseIdFromList(string strPrjDataBaseId, List<clsvPrjDataBaseEN> lstvPrjDataBaseObjLst)
{
foreach (clsvPrjDataBaseEN objvPrjDataBaseEN in lstvPrjDataBaseObjLst)
{
if (objvPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId)
{
return objvPrjDataBaseEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strPrjDataBaseId;
 try
 {
 strPrjDataBaseId = new clsvPrjDataBaseDA().GetFirstID(strWhereCond);
 return strPrjDataBaseId;
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
 arrList = vPrjDataBaseDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjDataBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjDataBaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjDataBaseDA.IsExist(strPrjDataBaseId);
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
 bolIsExist = clsvPrjDataBaseDA.IsExistTable();
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
 bolIsExist = vPrjDataBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjDataBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjDataBaseEN objvPrjDataBaseEN)
{
try
{
objvPrjDataBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjDataBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjDataBase.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.PrjDataBaseId = objvPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convPrjDataBase.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.PrjDataBaseName = objvPrjDataBaseEN.PrjDataBaseName == "[null]" ? null :  objvPrjDataBaseEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convPrjDataBase.DataBaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DataBaseTypeName = objvPrjDataBaseEN.DataBaseTypeName; //数据库类型名
}
if (arrFldSet.Contains(convPrjDataBase.DataBaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DataBaseTypeId = objvPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
}
if (arrFldSet.Contains(convPrjDataBase.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DataBaseName = objvPrjDataBaseEN.DataBaseName == "[null]" ? null :  objvPrjDataBaseEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convPrjDataBase.DatabaseOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DatabaseOwner = objvPrjDataBaseEN.DatabaseOwner == "[null]" ? null :  objvPrjDataBaseEN.DatabaseOwner; //数据库拥有者
}
if (arrFldSet.Contains(convPrjDataBase.DataBasePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DataBasePwd = objvPrjDataBaseEN.DataBasePwd == "[null]" ? null :  objvPrjDataBaseEN.DataBasePwd; //数据库的用户口令
}
if (arrFldSet.Contains(convPrjDataBase.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.DataBaseUserId = objvPrjDataBaseEN.DataBaseUserId == "[null]" ? null :  objvPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
}
if (arrFldSet.Contains(convPrjDataBase.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.IpAddress = objvPrjDataBaseEN.IpAddress == "[null]" ? null :  objvPrjDataBaseEN.IpAddress; //服务器
}
if (arrFldSet.Contains(convPrjDataBase.TableSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.TableSpace = objvPrjDataBaseEN.TableSpace == "[null]" ? null :  objvPrjDataBaseEN.TableSpace; //表空间
}
if (arrFldSet.Contains(convPrjDataBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.UpdDate = objvPrjDataBaseEN.UpdDate == "[null]" ? null :  objvPrjDataBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjDataBase.Sid, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.Sid = objvPrjDataBaseEN.Sid == "[null]" ? null :  objvPrjDataBaseEN.Sid; //SID
}
if (arrFldSet.Contains(convPrjDataBase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.UserId = objvPrjDataBaseEN.UserId == "[null]" ? null :  objvPrjDataBaseEN.UserId; //用户Id
}
if (arrFldSet.Contains(convPrjDataBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.Memo = objvPrjDataBaseEN.Memo == "[null]" ? null :  objvPrjDataBaseEN.Memo; //说明
}
if (arrFldSet.Contains(convPrjDataBase.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.UseStateName = objvPrjDataBaseEN.UseStateName == "[null]" ? null :  objvPrjDataBaseEN.UseStateName; //使用状态名称
}
if (arrFldSet.Contains(convPrjDataBase.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjDataBaseEN.UseStateId = objvPrjDataBaseEN.UseStateId; //使用状态Id
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
 /// <param name = "objvPrjDataBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjDataBaseEN objvPrjDataBaseEN)
{
try
{
if (objvPrjDataBaseEN.PrjDataBaseName == "[null]") objvPrjDataBaseEN.PrjDataBaseName = null; //项目数据库名
if (objvPrjDataBaseEN.DataBaseName == "[null]") objvPrjDataBaseEN.DataBaseName = null; //数据库名
if (objvPrjDataBaseEN.DatabaseOwner == "[null]") objvPrjDataBaseEN.DatabaseOwner = null; //数据库拥有者
if (objvPrjDataBaseEN.DataBasePwd == "[null]") objvPrjDataBaseEN.DataBasePwd = null; //数据库的用户口令
if (objvPrjDataBaseEN.DataBaseUserId == "[null]") objvPrjDataBaseEN.DataBaseUserId = null; //数据库的用户ID
if (objvPrjDataBaseEN.IpAddress == "[null]") objvPrjDataBaseEN.IpAddress = null; //服务器
if (objvPrjDataBaseEN.TableSpace == "[null]") objvPrjDataBaseEN.TableSpace = null; //表空间
if (objvPrjDataBaseEN.UpdDate == "[null]") objvPrjDataBaseEN.UpdDate = null; //修改日期
if (objvPrjDataBaseEN.Sid == "[null]") objvPrjDataBaseEN.Sid = null; //SID
if (objvPrjDataBaseEN.UserId == "[null]") objvPrjDataBaseEN.UserId = null; //用户Id
if (objvPrjDataBaseEN.Memo == "[null]") objvPrjDataBaseEN.Memo = null; //说明
if (objvPrjDataBaseEN.UseStateName == "[null]") objvPrjDataBaseEN.UseStateName = null; //使用状态名称
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
public static void CheckProperty4Condition(clsvPrjDataBaseEN objvPrjDataBaseEN)
{
 vPrjDataBaseDA.CheckProperty4Condition(objvPrjDataBaseEN);
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
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjDataBaseId");
//if (arrvPrjDataBaseObjLstCache == null)
//{
//arrvPrjDataBaseObjLstCache = vPrjDataBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjDataBaseEN GetObjByPrjDataBaseIdCache(string strPrjDataBaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjDataBaseEN._CurrTabName);
List<clsvPrjDataBaseEN> arrvPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjDataBaseEN> arrvPrjDataBaseObjLst_Sel =
arrvPrjDataBaseObjLstCache
.Where(x=> x.PrjDataBaseId == strPrjDataBaseId 
);
if (arrvPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsvPrjDataBaseEN obj = clsvPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjDataBaseEN> GetAllvPrjDataBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjDataBaseEN> arrvPrjDataBaseObjLstCache = GetObjLstCache(); 
return arrvPrjDataBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjDataBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjDataBaseEN._CurrTabName);
List<clsvPrjDataBaseEN> arrvPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjDataBaseObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjDataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjDataBaseEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjDataBaseEN._RefreshTimeLst[clsvPrjDataBaseEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPrjDataBaseId)
{
if (strInFldName != convPrjDataBase.PrjDataBaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjDataBase._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjDataBase._AttributeName));
throw new Exception(strMsg);
}
var objvPrjDataBase = clsvPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
if (objvPrjDataBase == null) return "";
return objvPrjDataBase[strOutFldName].ToString();
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
int intRecCount = clsvPrjDataBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjDataBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjDataBaseDA.GetRecCount();
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
int intRecCount = clsvPrjDataBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjDataBaseEN objvPrjDataBaseCond)
{
List<clsvPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjDataBase._AttributeName)
{
if (objvPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objvPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objvPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjDataBaseCond[strFldName]));
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
 List<string> arrList = clsvPrjDataBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjDataBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjDataBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}