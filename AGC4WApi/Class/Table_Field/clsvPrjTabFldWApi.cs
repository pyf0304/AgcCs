
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFldWApi
 表名:vPrjTabFld(00050122)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:37
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
public static class  clsvPrjTabFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetmId(this clsvPrjTabFldEN objvPrjTabFldEN, long lngmId, string strComparisonOp="")
	{
objvPrjTabFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.mId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.mId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.mId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabId(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabFld.TabId);
objvPrjTabFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.TabId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.TabId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.TabId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabName(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTabFld.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTabFld.TabName);
objvPrjTabFldEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.TabName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.TabName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.TabName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabCnName(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTabFld.TabCnName);
objvPrjTabFldEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.TabCnName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.TabCnName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.TabCnName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjName(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTabFld.PrjName);
objvPrjTabFldEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrjName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrjName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrjName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetSqlDsTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTabFld.SqlDsTypeName);
objvPrjTabFldEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.SqlDsTypeName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.SqlDsTypeName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.SqlDsTypeName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFuncModuleAgcId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTabFld.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTabFld.FuncModuleAgcId);
objvPrjTabFldEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FuncModuleAgcId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFuncModuleName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTabFld.FuncModuleName);
objvPrjTabFldEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FuncModuleName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FuncModuleName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FuncModuleName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetOrderNum4Refer(this clsvPrjTabFldEN objvPrjTabFldEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvPrjTabFldEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.OrderNum4Refer) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.OrderNum4Refer, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.OrderNum4Refer] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabFld.FldId);
objvPrjTabFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetOraDbType(this clsvPrjTabFldEN objvPrjTabFldEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convPrjTabFld.OraDbType);
objvPrjTabFldEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.OraDbType) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.OraDbType, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.OraDbType] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsNeedTransCode(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convPrjTabFld.IsNeedTransCode);
objvPrjTabFldEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsNeedTransCode) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsNeedTransCode, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsNeedTransCode] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convPrjTabFld.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convPrjTabFld.FldName);
objvPrjTabFldEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldCnName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convPrjTabFld.FldCnName);
objvPrjTabFldEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldCnName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldCnName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldCnName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetCaption(this clsvPrjTabFldEN objvPrjTabFldEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convPrjTabFld.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convPrjTabFld.Caption);
objvPrjTabFldEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.Caption) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.Caption, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.Caption] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDataTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convPrjTabFld.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convPrjTabFld.DataTypeId);
objvPrjTabFldEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.DataTypeId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.DataTypeId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.DataTypeId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDataTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convPrjTabFld.DataTypeName);
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convPrjTabFld.DataTypeName);
objvPrjTabFldEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.DataTypeName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.DataTypeName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.DataTypeName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldLength(this clsvPrjTabFldEN objvPrjTabFldEN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convPrjTabFld.FldLength);
objvPrjTabFldEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldLength) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldLength, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldLength] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldPrecision">精确度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldPrecision(this clsvPrjTabFldEN objvPrjTabFldEN, int intFldPrecision, string strComparisonOp="")
	{
objvPrjTabFldEN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldPrecision) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldPrecision, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldPrecision] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMaxValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convPrjTabFld.MaxValue);
clsCheckSql.CheckFieldLen(strMaxValue, 50, convPrjTabFld.MaxValue);
objvPrjTabFldEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.MaxValue) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.MaxValue, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.MaxValue] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMinValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convPrjTabFld.MinValue);
clsCheckSql.CheckFieldLen(strMinValue, 50, convPrjTabFld.MinValue);
objvPrjTabFldEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.MinValue) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.MinValue, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.MinValue] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDefaultValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convPrjTabFld.DefaultValue);
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convPrjTabFld.DefaultValue);
objvPrjTabFldEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.DefaultValue) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.DefaultValue, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.DefaultValue] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strHomologousFldId">同源字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetHomologousFldId(this clsvPrjTabFldEN objvPrjTabFldEN, string strHomologousFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convPrjTabFld.HomologousFldId);
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convPrjTabFld.HomologousFldId);
objvPrjTabFldEN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.HomologousFldId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.HomologousFldId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.HomologousFldId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjId(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabFld.PrjId);
objvPrjTabFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrjId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrjId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrjId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFieldTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabFld.FieldTypeId);
objvPrjTabFldEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FieldTypeId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFieldTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convPrjTabFld.FieldTypeName);
objvPrjTabFldEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FieldTypeName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FieldTypeName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FieldTypeName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabNullable">是否表中可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsTabNullable(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsTabNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTabNullable, convPrjTabFld.IsTabNullable);
objvPrjTabFldEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsTabNullable) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsTabNullable, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsTabNullable] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabUnique">是否表中唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsTabUnique(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objvPrjTabFldEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsTabUnique) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsTabUnique, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsTabUnique] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabForeignKey">是否表外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsTabForeignKey(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTabForeignKey, convPrjTabFld.IsTabForeignKey);
objvPrjTabFldEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsTabForeignKey) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsTabForeignKey, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsTabForeignKey] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSortFld">是否排序字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsSortFld(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsSortFld, string strComparisonOp="")
	{
objvPrjTabFldEN.IsSortFld = bolIsSortFld; //是否排序字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsSortFld) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsSortFld, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsSortFld] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForExtendClass">用于扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsForExtendClass(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsForExtendClass, string strComparisonOp="")
	{
objvPrjTabFldEN.IsForExtendClass = bolIsForExtendClass; //用于扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsForExtendClass) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsForExtendClass, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsForExtendClass] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParentObj">是否父对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetIsParentObj(this clsvPrjTabFldEN objvPrjTabFldEN, bool bolIsParentObj, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsParentObj, convPrjTabFld.IsParentObj);
objvPrjTabFldEN.IsParentObj = bolIsParentObj; //是否父对象
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.IsParentObj) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.IsParentObj, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.IsParentObj] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrimaryTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabFld.PrimaryTypeId);
objvPrjTabFldEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrimaryTypeId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrimaryTypeId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrimaryTypeId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrimaryTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeName, convPrjTabFld.PrimaryTypeName);
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabFld.PrimaryTypeName);
objvPrjTabFldEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrimaryTypeName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrimaryTypeName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrimaryTypeName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyTabId">外键表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetForeignKeyTabId(this clsvPrjTabFldEN objvPrjTabFldEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignKeyTabId, convPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, convPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, convPrjTabFld.ForeignKeyTabId);
objvPrjTabFldEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.ForeignKeyTabId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.ForeignKeyTabId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.ForeignKeyTabId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldOpTypeId">字段操作类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldOpTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeId, convPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(strFldOpTypeId, 4, convPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldForeignKey(strFldOpTypeId, 4, convPrjTabFld.FldOpTypeId);
objvPrjTabFldEN.FldOpTypeId = strFldOpTypeId; //字段操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldOpTypeId) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldOpTypeId, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldOpTypeId] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldOpTypeName">字段操作类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldOpTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldOpTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldOpTypeName, 100, convPrjTabFld.FldOpTypeName);
objvPrjTabFldEN.FldOpTypeName = strFldOpTypeName; //字段操作类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.FldOpTypeName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.FldOpTypeName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.FldOpTypeName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intSequenceNumber">顺序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetSequenceNumber(this clsvPrjTabFldEN objvPrjTabFldEN, int intSequenceNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSequenceNumber, convPrjTabFld.SequenceNumber);
objvPrjTabFldEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.SequenceNumber) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.SequenceNumber, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.SequenceNumber] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemoInTab">表中说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMemoInTab(this clsvPrjTabFldEN objvPrjTabFldEN, string strMemoInTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemoInTab, 1000, convPrjTabFld.MemoInTab);
objvPrjTabFldEN.MemoInTab = strMemoInTab; //表中说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.MemoInTab) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.MemoInTab, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.MemoInTab] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId4Fld">PrjId4Fld</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjId4Fld(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjId4Fld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId4Fld, 4, convPrjTabFld.PrjId4Fld);
clsCheckSql.CheckFieldForeignKey(strPrjId4Fld, 4, convPrjTabFld.PrjId4Fld);
objvPrjTabFldEN.PrjId4Fld = strPrjId4Fld; //PrjId4Fld
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrjId4Fld) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrjId4Fld, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrjId4Fld] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName4Fld">PrjName4Fld</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjName4Fld(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjName4Fld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName4Fld, 30, convPrjTabFld.PrjName4Fld);
objvPrjTabFldEN.PrjName4Fld = strPrjName4Fld; //PrjName4Fld
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.PrjName4Fld) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.PrjName4Fld, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.PrjName4Fld] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignTabName">外键表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetForeignTabName(this clsvPrjTabFldEN objvPrjTabFldEN, string strForeignTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignTabName, convPrjTabFld.ForeignTabName);
clsCheckSql.CheckFieldLen(strForeignTabName, 40, convPrjTabFld.ForeignTabName);
objvPrjTabFldEN.ForeignTabName = strForeignTabName; //外键表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFldEN.dicFldComparisonOp.ContainsKey(convPrjTabFld.ForeignTabName) == false)
{
objvPrjTabFldEN.dicFldComparisonOp.Add(convPrjTabFld.ForeignTabName, strComparisonOp);
}
else
{
objvPrjTabFldEN.dicFldComparisonOp[convPrjTabFld.ForeignTabName] = strComparisonOp;
}
}
return objvPrjTabFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabFldEN objvPrjTabFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.mId) == true)
{
string strComparisonOpmId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld.mId, objvPrjTabFldCond.mId, strComparisonOpmId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.TabId, objvPrjTabFldCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.TabName) == true)
{
string strComparisonOpTabName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.TabName, objvPrjTabFldCond.TabName, strComparisonOpTabName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.TabCnName, objvPrjTabFldCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrjName, objvPrjTabFldCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.SqlDsTypeName, objvPrjTabFldCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FuncModuleAgcId, objvPrjTabFldCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FuncModuleName, objvPrjTabFldCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld.OrderNum4Refer, objvPrjTabFldCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FldId, objvPrjTabFldCond.FldId, strComparisonOpFldId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.OraDbType) == true)
{
string strComparisonOpOraDbType = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.OraDbType, objvPrjTabFldCond.OraDbType, strComparisonOpOraDbType);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsNeedTransCode) == true)
{
if (objvPrjTabFldCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsNeedTransCode);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldName) == true)
{
string strComparisonOpFldName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FldName, objvPrjTabFldCond.FldName, strComparisonOpFldName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldCnName) == true)
{
string strComparisonOpFldCnName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FldCnName, objvPrjTabFldCond.FldCnName, strComparisonOpFldCnName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.Caption) == true)
{
string strComparisonOpCaption = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.Caption, objvPrjTabFldCond.Caption, strComparisonOpCaption);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.DataTypeId, objvPrjTabFldCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.DataTypeName, objvPrjTabFldCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldLength) == true)
{
string strComparisonOpFldLength = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld.FldLength, objvPrjTabFldCond.FldLength, strComparisonOpFldLength);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld.FldPrecision, objvPrjTabFldCond.FldPrecision, strComparisonOpFldPrecision);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.MaxValue) == true)
{
string strComparisonOpMaxValue = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.MaxValue, objvPrjTabFldCond.MaxValue, strComparisonOpMaxValue);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.MinValue) == true)
{
string strComparisonOpMinValue = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.MinValue, objvPrjTabFldCond.MinValue, strComparisonOpMinValue);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.DefaultValue, objvPrjTabFldCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.HomologousFldId, objvPrjTabFldCond.HomologousFldId, strComparisonOpHomologousFldId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrjId, objvPrjTabFldCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FieldTypeId, objvPrjTabFldCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FieldTypeName, objvPrjTabFldCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsTabNullable) == true)
{
if (objvPrjTabFldCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsTabNullable);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsTabUnique) == true)
{
if (objvPrjTabFldCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsTabUnique);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsTabForeignKey) == true)
{
if (objvPrjTabFldCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsTabForeignKey);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsSortFld) == true)
{
if (objvPrjTabFldCond.IsSortFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsSortFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsSortFld);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsForExtendClass) == true)
{
if (objvPrjTabFldCond.IsForExtendClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsForExtendClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsForExtendClass);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.IsParentObj) == true)
{
if (objvPrjTabFldCond.IsParentObj == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld.IsParentObj);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld.IsParentObj);
}
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrimaryTypeId, objvPrjTabFldCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrimaryTypeName, objvPrjTabFldCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.ForeignKeyTabId, objvPrjTabFldCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldOpTypeId) == true)
{
string strComparisonOpFldOpTypeId = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldOpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FldOpTypeId, objvPrjTabFldCond.FldOpTypeId, strComparisonOpFldOpTypeId);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.FldOpTypeName) == true)
{
string strComparisonOpFldOpTypeName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.FldOpTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.FldOpTypeName, objvPrjTabFldCond.FldOpTypeName, strComparisonOpFldOpTypeName);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld.SequenceNumber, objvPrjTabFldCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.MemoInTab) == true)
{
string strComparisonOpMemoInTab = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.MemoInTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.MemoInTab, objvPrjTabFldCond.MemoInTab, strComparisonOpMemoInTab);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrjId4Fld) == true)
{
string strComparisonOpPrjId4Fld = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrjId4Fld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrjId4Fld, objvPrjTabFldCond.PrjId4Fld, strComparisonOpPrjId4Fld);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.PrjName4Fld) == true)
{
string strComparisonOpPrjName4Fld = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.PrjName4Fld];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.PrjName4Fld, objvPrjTabFldCond.PrjName4Fld, strComparisonOpPrjName4Fld);
}
if (objvPrjTabFldCond.IsUpdated(convPrjTabFld.ForeignTabName) == true)
{
string strComparisonOpForeignTabName = objvPrjTabFldCond.dicFldComparisonOp[convPrjTabFld.ForeignTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld.ForeignTabName, objvPrjTabFldCond.ForeignTabName, strComparisonOpForeignTabName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表字段(vPrjTabFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabFldWApi
{
private static readonly string mstrApiControllerName = "vPrjTabFldApi";

 public clsvPrjTabFldWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFldEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvPrjTabFldEN objvPrjTabFldEN;
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
objvPrjTabFldEN = JsonConvert.DeserializeObject<clsvPrjTabFldEN>(strJson);
return objvPrjTabFldEN;
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
public static clsvPrjTabFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTabFldEN objvPrjTabFldEN;
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
objvPrjTabFldEN = JsonConvert.DeserializeObject<clsvPrjTabFldEN>(strJson);
return objvPrjTabFldEN;
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
public static clsvPrjTabFldEN GetObjBymIdCache(long lngmId,string strTabId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strTabId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strTabId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel =
from objvPrjTabFldEN in arrvPrjTabFldObjLstCache
where objvPrjTabFldEN.mId == lngmId 
select objvPrjTabFldEN;
if (arrvPrjTabFldObjLst_Sel.Count() == 0)
{
   clsvPrjTabFldEN obj = clsvPrjTabFldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTabFldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
public static List<clsvPrjTabFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
public static IEnumerable<clsvPrjTabFldEN> GetObjLstByMIdLstCache(List<long> arrMId, string strTabId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strTabId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strTabId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel =
from objvPrjTabFldEN in arrvPrjTabFldObjLstCache
where arrMId.Contains(objvPrjTabFldEN.mId)
select objvPrjTabFldEN;
return arrvPrjTabFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
public static List<clsvPrjTabFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
public static List<clsvPrjTabFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
public static List<clsvPrjTabFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFldEN>>(strJson);
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
 /// <param name = "objvPrjTabFldENS">源对象</param>
 /// <param name = "objvPrjTabFldENT">目标对象</param>
 public static void CopyTo(clsvPrjTabFldEN objvPrjTabFldENS, clsvPrjTabFldEN objvPrjTabFldENT)
{
try
{
objvPrjTabFldENT.mId = objvPrjTabFldENS.mId; //mId
objvPrjTabFldENT.TabId = objvPrjTabFldENS.TabId; //表ID
objvPrjTabFldENT.TabName = objvPrjTabFldENS.TabName; //表名
objvPrjTabFldENT.TabCnName = objvPrjTabFldENS.TabCnName; //表中文名
objvPrjTabFldENT.PrjName = objvPrjTabFldENS.PrjName; //工程名称
objvPrjTabFldENT.SqlDsTypeName = objvPrjTabFldENS.SqlDsTypeName; //Sql数据源名
objvPrjTabFldENT.FuncModuleAgcId = objvPrjTabFldENS.FuncModuleAgcId; //功能模块Id
objvPrjTabFldENT.FuncModuleName = objvPrjTabFldENS.FuncModuleName; //功能模块名称
objvPrjTabFldENT.OrderNum4Refer = objvPrjTabFldENS.OrderNum4Refer; //引用序号
objvPrjTabFldENT.FldId = objvPrjTabFldENS.FldId; //字段Id
objvPrjTabFldENT.OraDbType = objvPrjTabFldENS.OraDbType; //Ora数据类型
objvPrjTabFldENT.IsNeedTransCode = objvPrjTabFldENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabFldENT.FldName = objvPrjTabFldENS.FldName; //字段名
objvPrjTabFldENT.FldCnName = objvPrjTabFldENS.FldCnName; //字段中文详名
objvPrjTabFldENT.Caption = objvPrjTabFldENS.Caption; //标题
objvPrjTabFldENT.DataTypeId = objvPrjTabFldENS.DataTypeId; //数据类型Id
objvPrjTabFldENT.DataTypeName = objvPrjTabFldENS.DataTypeName; //数据类型名称
objvPrjTabFldENT.FldLength = objvPrjTabFldENS.FldLength; //字段长度
objvPrjTabFldENT.FldPrecision = objvPrjTabFldENS.FldPrecision; //精确度
objvPrjTabFldENT.MaxValue = objvPrjTabFldENS.MaxValue; //最大值
objvPrjTabFldENT.MinValue = objvPrjTabFldENS.MinValue; //最小值
objvPrjTabFldENT.DefaultValue = objvPrjTabFldENS.DefaultValue; //缺省值
objvPrjTabFldENT.HomologousFldId = objvPrjTabFldENS.HomologousFldId; //同源字段Id
objvPrjTabFldENT.PrjId = objvPrjTabFldENS.PrjId; //工程Id
objvPrjTabFldENT.FieldTypeId = objvPrjTabFldENS.FieldTypeId; //字段类型Id
objvPrjTabFldENT.FieldTypeName = objvPrjTabFldENS.FieldTypeName; //字段类型名
objvPrjTabFldENT.IsTabNullable = objvPrjTabFldENS.IsTabNullable; //是否表中可空
objvPrjTabFldENT.IsTabUnique = objvPrjTabFldENS.IsTabUnique; //是否表中唯一
objvPrjTabFldENT.IsTabForeignKey = objvPrjTabFldENS.IsTabForeignKey; //是否表外键
objvPrjTabFldENT.IsSortFld = objvPrjTabFldENS.IsSortFld; //是否排序字段
objvPrjTabFldENT.IsForExtendClass = objvPrjTabFldENS.IsForExtendClass; //用于扩展类
objvPrjTabFldENT.IsParentObj = objvPrjTabFldENS.IsParentObj; //是否父对象
objvPrjTabFldENT.PrimaryTypeId = objvPrjTabFldENS.PrimaryTypeId; //主键类型ID
objvPrjTabFldENT.PrimaryTypeName = objvPrjTabFldENS.PrimaryTypeName; //主键类型名
objvPrjTabFldENT.ForeignKeyTabId = objvPrjTabFldENS.ForeignKeyTabId; //外键表ID
objvPrjTabFldENT.FldOpTypeId = objvPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objvPrjTabFldENT.FldOpTypeName = objvPrjTabFldENS.FldOpTypeName; //字段操作类型名称
objvPrjTabFldENT.SequenceNumber = objvPrjTabFldENS.SequenceNumber; //顺序号
objvPrjTabFldENT.MemoInTab = objvPrjTabFldENS.MemoInTab; //表中说明
objvPrjTabFldENT.PrjId4Fld = objvPrjTabFldENS.PrjId4Fld; //PrjId4Fld
objvPrjTabFldENT.PrjName4Fld = objvPrjTabFldENS.PrjName4Fld; //PrjName4Fld
objvPrjTabFldENT.ForeignTabName = objvPrjTabFldENS.ForeignTabName; //外键表
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
public static DataTable ToDataTable(List<clsvPrjTabFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTabFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTabFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTabFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTabFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTabFldEN._AttributeName)
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
public static void ReFreshThisCache(string strTabId = "")
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsvPrjTabFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsvPrjTabFldWApi.ReFreshThisCache)", strTabId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strTabId);
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
public static List<clsvPrjTabFldEN> GetObjLstCache(string strTabId)
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsvPrjTabFldWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsvPrjTabFldWApi.GetObjLstCache)", strTabId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTabFldEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTabFldEN._WhereFormat, strTabId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTabFld.TabId, strTabId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strTabId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTabFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLstCacheFromObjLst(string strTabId,List<clsvPrjTabFldEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsvPrjTabFldWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsvPrjTabFldWApi.GetObjLstCacheFromObjLst)", strTabId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strTabId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTabFldObjLstCache = CacheHelper.Get<List<clsvPrjTabFldEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.TabId == strTabId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTabFldObjLstCache = CacheHelper.Get<List<clsvPrjTabFldEN>>(strKey);
}
return arrvPrjTabFldObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTabFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTabFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPrjTabFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTabFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTabFld.FldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTabFld.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.HomologousFldId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.IsTabNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.IsTabUnique, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.IsTabForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.IsSortFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.IsForExtendClass, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.IsParentObj, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTabFld.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.ForeignKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FldOpTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.FldOpTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.SequenceNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTabFld.MemoInTab, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.PrjId4Fld, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.PrjName4Fld, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld.ForeignTabName, Type.GetType("System.String"));
foreach (clsvPrjTabFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTabFld.mId] = objInFor[convPrjTabFld.mId];
objDR[convPrjTabFld.TabId] = objInFor[convPrjTabFld.TabId];
objDR[convPrjTabFld.TabName] = objInFor[convPrjTabFld.TabName];
objDR[convPrjTabFld.TabCnName] = objInFor[convPrjTabFld.TabCnName];
objDR[convPrjTabFld.PrjName] = objInFor[convPrjTabFld.PrjName];
objDR[convPrjTabFld.SqlDsTypeName] = objInFor[convPrjTabFld.SqlDsTypeName];
objDR[convPrjTabFld.FuncModuleAgcId] = objInFor[convPrjTabFld.FuncModuleAgcId];
objDR[convPrjTabFld.FuncModuleName] = objInFor[convPrjTabFld.FuncModuleName];
objDR[convPrjTabFld.OrderNum4Refer] = objInFor[convPrjTabFld.OrderNum4Refer];
objDR[convPrjTabFld.FldId] = objInFor[convPrjTabFld.FldId];
objDR[convPrjTabFld.OraDbType] = objInFor[convPrjTabFld.OraDbType];
objDR[convPrjTabFld.IsNeedTransCode] = objInFor[convPrjTabFld.IsNeedTransCode];
objDR[convPrjTabFld.FldName] = objInFor[convPrjTabFld.FldName];
objDR[convPrjTabFld.FldCnName] = objInFor[convPrjTabFld.FldCnName];
objDR[convPrjTabFld.Caption] = objInFor[convPrjTabFld.Caption];
objDR[convPrjTabFld.DataTypeId] = objInFor[convPrjTabFld.DataTypeId];
objDR[convPrjTabFld.DataTypeName] = objInFor[convPrjTabFld.DataTypeName];
objDR[convPrjTabFld.FldLength] = objInFor[convPrjTabFld.FldLength];
objDR[convPrjTabFld.FldPrecision] = objInFor[convPrjTabFld.FldPrecision];
objDR[convPrjTabFld.MaxValue] = objInFor[convPrjTabFld.MaxValue];
objDR[convPrjTabFld.MinValue] = objInFor[convPrjTabFld.MinValue];
objDR[convPrjTabFld.DefaultValue] = objInFor[convPrjTabFld.DefaultValue];
objDR[convPrjTabFld.HomologousFldId] = objInFor[convPrjTabFld.HomologousFldId];
objDR[convPrjTabFld.PrjId] = objInFor[convPrjTabFld.PrjId];
objDR[convPrjTabFld.FieldTypeId] = objInFor[convPrjTabFld.FieldTypeId];
objDR[convPrjTabFld.FieldTypeName] = objInFor[convPrjTabFld.FieldTypeName];
objDR[convPrjTabFld.IsTabNullable] = objInFor[convPrjTabFld.IsTabNullable];
objDR[convPrjTabFld.IsTabUnique] = objInFor[convPrjTabFld.IsTabUnique];
objDR[convPrjTabFld.IsTabForeignKey] = objInFor[convPrjTabFld.IsTabForeignKey];
objDR[convPrjTabFld.IsSortFld] = objInFor[convPrjTabFld.IsSortFld];
objDR[convPrjTabFld.IsForExtendClass] = objInFor[convPrjTabFld.IsForExtendClass];
objDR[convPrjTabFld.IsParentObj] = objInFor[convPrjTabFld.IsParentObj];
objDR[convPrjTabFld.PrimaryTypeId] = objInFor[convPrjTabFld.PrimaryTypeId];
objDR[convPrjTabFld.PrimaryTypeName] = objInFor[convPrjTabFld.PrimaryTypeName];
objDR[convPrjTabFld.ForeignKeyTabId] = objInFor[convPrjTabFld.ForeignKeyTabId];
objDR[convPrjTabFld.FldOpTypeId] = objInFor[convPrjTabFld.FldOpTypeId];
objDR[convPrjTabFld.FldOpTypeName] = objInFor[convPrjTabFld.FldOpTypeName];
objDR[convPrjTabFld.SequenceNumber] = objInFor[convPrjTabFld.SequenceNumber];
objDR[convPrjTabFld.MemoInTab] = objInFor[convPrjTabFld.MemoInTab];
objDR[convPrjTabFld.PrjId4Fld] = objInFor[convPrjTabFld.PrjId4Fld];
objDR[convPrjTabFld.PrjName4Fld] = objInFor[convPrjTabFld.PrjName4Fld];
objDR[convPrjTabFld.ForeignTabName] = objInFor[convPrjTabFld.ForeignTabName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}