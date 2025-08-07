
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFldBL
 表名:vPrjTabFld(00050122)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjTabFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFldEN GetObj(this K_mId_vPrjTabFld myKey)
{
clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBL.vPrjTabFldDA.GetObjBymId(myKey.Value);
return objvPrjTabFldEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabId(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjTabFld.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabFld.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabName(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTabFld.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTabFld.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetTabCnName(this clsvPrjTabFldEN objvPrjTabFldEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTabFld.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjName(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTabFld.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetSqlDsTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTabFld.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFuncModuleAgcId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTabFld.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTabFld.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFuncModuleName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTabFld.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetOrderNum4Refer(this clsvPrjTabFldEN objvPrjTabFldEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabFld.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetOraDbType(this clsvPrjTabFldEN objvPrjTabFldEN, string strOraDbType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convPrjTabFld.OraDbType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convPrjTabFld.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convPrjTabFld.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldCnName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convPrjTabFld.FldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetCaption(this clsvPrjTabFldEN objvPrjTabFldEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convPrjTabFld.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convPrjTabFld.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDataTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strDataTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convPrjTabFld.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convPrjTabFld.DataTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDataTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convPrjTabFld.DataTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convPrjTabFld.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldPrecision(this clsvPrjTabFldEN objvPrjTabFldEN, int? intFldPrecision, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMaxValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convPrjTabFld.MaxValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convPrjTabFld.MaxValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMinValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convPrjTabFld.MinValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, convPrjTabFld.MinValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetDefaultValue(this clsvPrjTabFldEN objvPrjTabFldEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convPrjTabFld.DefaultValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convPrjTabFld.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetHomologousFldId(this clsvPrjTabFldEN objvPrjTabFldEN, string strHomologousFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convPrjTabFld.HomologousFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convPrjTabFld.HomologousFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjId(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabFld.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFieldTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabFld.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabFld.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFieldTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convPrjTabFld.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrimaryTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabFld.PrimaryTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabFld.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabFld.PrimaryTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrimaryTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeName, convPrjTabFld.PrimaryTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabFld.PrimaryTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetForeignKeyTabId(this clsvPrjTabFldEN objvPrjTabFldEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignKeyTabId, convPrjTabFld.ForeignKeyTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, convPrjTabFld.ForeignKeyTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, convPrjTabFld.ForeignKeyTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldOpTypeId(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeId, convPrjTabFld.FldOpTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeId, 4, convPrjTabFld.FldOpTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldOpTypeId, 4, convPrjTabFld.FldOpTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetFldOpTypeName(this clsvPrjTabFldEN objvPrjTabFldEN, string strFldOpTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeName, 100, convPrjTabFld.FldOpTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetMemoInTab(this clsvPrjTabFldEN objvPrjTabFldEN, string strMemoInTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemoInTab, 1000, convPrjTabFld.MemoInTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjId4Fld(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjId4Fld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId4Fld, 4, convPrjTabFld.PrjId4Fld);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId4Fld, 4, convPrjTabFld.PrjId4Fld);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetPrjName4Fld(this clsvPrjTabFldEN objvPrjTabFldEN, string strPrjName4Fld, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName4Fld, 30, convPrjTabFld.PrjName4Fld);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFldEN SetForeignTabName(this clsvPrjTabFldEN objvPrjTabFldEN, string strForeignTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignTabName, convPrjTabFld.ForeignTabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignTabName, 40, convPrjTabFld.ForeignTabName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTabFldENS">源对象</param>
 /// <param name = "objvPrjTabFldENT">目标对象</param>
 public static void CopyTo(this clsvPrjTabFldEN objvPrjTabFldENS, clsvPrjTabFldEN objvPrjTabFldENT)
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
 /// <param name = "objvPrjTabFldENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTabFldEN:objvPrjTabFldENT</returns>
 public static clsvPrjTabFldEN CopyTo(this clsvPrjTabFldEN objvPrjTabFldENS)
{
try
{
 clsvPrjTabFldEN objvPrjTabFldENT = new clsvPrjTabFldEN()
{
mId = objvPrjTabFldENS.mId, //mId
TabId = objvPrjTabFldENS.TabId, //表ID
TabName = objvPrjTabFldENS.TabName, //表名
TabCnName = objvPrjTabFldENS.TabCnName, //表中文名
PrjName = objvPrjTabFldENS.PrjName, //工程名称
SqlDsTypeName = objvPrjTabFldENS.SqlDsTypeName, //Sql数据源名
FuncModuleAgcId = objvPrjTabFldENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvPrjTabFldENS.FuncModuleName, //功能模块名称
OrderNum4Refer = objvPrjTabFldENS.OrderNum4Refer, //引用序号
FldId = objvPrjTabFldENS.FldId, //字段Id
OraDbType = objvPrjTabFldENS.OraDbType, //Ora数据类型
IsNeedTransCode = objvPrjTabFldENS.IsNeedTransCode, //是否需要转换代码
FldName = objvPrjTabFldENS.FldName, //字段名
FldCnName = objvPrjTabFldENS.FldCnName, //字段中文详名
Caption = objvPrjTabFldENS.Caption, //标题
DataTypeId = objvPrjTabFldENS.DataTypeId, //数据类型Id
DataTypeName = objvPrjTabFldENS.DataTypeName, //数据类型名称
FldLength = objvPrjTabFldENS.FldLength, //字段长度
FldPrecision = objvPrjTabFldENS.FldPrecision, //精确度
MaxValue = objvPrjTabFldENS.MaxValue, //最大值
MinValue = objvPrjTabFldENS.MinValue, //最小值
DefaultValue = objvPrjTabFldENS.DefaultValue, //缺省值
HomologousFldId = objvPrjTabFldENS.HomologousFldId, //同源字段Id
PrjId = objvPrjTabFldENS.PrjId, //工程Id
FieldTypeId = objvPrjTabFldENS.FieldTypeId, //字段类型Id
FieldTypeName = objvPrjTabFldENS.FieldTypeName, //字段类型名
IsTabNullable = objvPrjTabFldENS.IsTabNullable, //是否表中可空
IsTabUnique = objvPrjTabFldENS.IsTabUnique, //是否表中唯一
IsTabForeignKey = objvPrjTabFldENS.IsTabForeignKey, //是否表外键
IsSortFld = objvPrjTabFldENS.IsSortFld, //是否排序字段
IsForExtendClass = objvPrjTabFldENS.IsForExtendClass, //用于扩展类
IsParentObj = objvPrjTabFldENS.IsParentObj, //是否父对象
PrimaryTypeId = objvPrjTabFldENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objvPrjTabFldENS.PrimaryTypeName, //主键类型名
ForeignKeyTabId = objvPrjTabFldENS.ForeignKeyTabId, //外键表ID
FldOpTypeId = objvPrjTabFldENS.FldOpTypeId, //字段操作类型Id
FldOpTypeName = objvPrjTabFldENS.FldOpTypeName, //字段操作类型名称
SequenceNumber = objvPrjTabFldENS.SequenceNumber, //顺序号
MemoInTab = objvPrjTabFldENS.MemoInTab, //表中说明
PrjId4Fld = objvPrjTabFldENS.PrjId4Fld, //PrjId4Fld
PrjName4Fld = objvPrjTabFldENS.PrjName4Fld, //PrjName4Fld
ForeignTabName = objvPrjTabFldENS.ForeignTabName, //外键表
};
 return objvPrjTabFldENT;
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
public static void CheckProperty4Condition(this clsvPrjTabFldEN objvPrjTabFldEN)
{
 clsvPrjTabFldBL.vPrjTabFldDA.CheckProperty4Condition(objvPrjTabFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTabFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表字段(vPrjTabFld)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabFldBL
{
public static RelatedActions_vPrjTabFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTabFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTabFldDA vPrjTabFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTabFldDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTabFldBL()
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
if (string.IsNullOrEmpty(clsvPrjTabFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabFldEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTabFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabFldDA.GetDataTable_vPrjTabFld(strWhereCond);
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
objDT = vPrjTabFldDA.GetDataTable(strWhereCond);
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
objDT = vPrjTabFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTabFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTabFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTabFldDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTabFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTabFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTabFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPrjTabFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
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
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTabFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel =
arrvPrjTabFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPrjTabFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
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
public static List<clsvPrjTabFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTabFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTabFldEN> GetSubObjLstCache(clsvPrjTabFldEN objvPrjTabFldCond)
{
 string strPrjId = objvPrjTabFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTabFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabFld._AttributeName)
{
if (objvPrjTabFldCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFldCond[strFldName].ToString());
}
else
{
if (objvPrjTabFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabFldCond[strFldName]));
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
public static List<clsvPrjTabFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
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
public static List<clsvPrjTabFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
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
List<clsvPrjTabFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTabFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTabFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
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
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
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
public static List<clsvPrjTabFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTabFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
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
public static List<clsvPrjTabFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTabFld(ref clsvPrjTabFldEN objvPrjTabFldEN)
{
bool bolResult = vPrjTabFldDA.GetvPrjTabFld(ref objvPrjTabFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFldEN GetObjBymId(long lngmId)
{
clsvPrjTabFldEN objvPrjTabFldEN = vPrjTabFldDA.GetObjBymId(lngmId);
return objvPrjTabFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTabFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTabFldEN objvPrjTabFldEN = vPrjTabFldDA.GetFirstObj(strWhereCond);
 return objvPrjTabFldEN;
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
public static clsvPrjTabFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTabFldEN objvPrjTabFldEN = vPrjTabFldDA.GetObjByDataRow(objRow);
 return objvPrjTabFldEN;
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
public static clsvPrjTabFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTabFldEN objvPrjTabFldEN = vPrjTabFldDA.GetObjByDataRow(objRow);
 return objvPrjTabFldEN;
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
 /// <param name = "lstvPrjTabFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabFldEN GetObjBymIdFromList(long lngmId, List<clsvPrjTabFldEN> lstvPrjTabFldObjLst)
{
foreach (clsvPrjTabFldEN objvPrjTabFldEN in lstvPrjTabFldObjLst)
{
if (objvPrjTabFldEN.mId == lngmId)
{
return objvPrjTabFldEN;
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
 lngmId = new clsvPrjTabFldDA().GetFirstID(strWhereCond);
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
 arrList = vPrjTabFldDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTabFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPrjTabFldDA.IsExist(lngmId);
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
 bolIsExist = clsvPrjTabFldDA.IsExistTable();
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
 bolIsExist = vPrjTabFldDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTabFldEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTabFldEN objvPrjTabFldEN)
{
try
{
objvPrjTabFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTabFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTabFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.mId = objvPrjTabFldEN.mId; //mId
}
if (arrFldSet.Contains(convPrjTabFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.TabId = objvPrjTabFldEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTabFld.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.TabName = objvPrjTabFldEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTabFld.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.TabCnName = objvPrjTabFldEN.TabCnName == "[null]" ? null :  objvPrjTabFldEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convPrjTabFld.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrjName = objvPrjTabFldEN.PrjName == "[null]" ? null :  objvPrjTabFldEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjTabFld.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.SqlDsTypeName = objvPrjTabFldEN.SqlDsTypeName == "[null]" ? null :  objvPrjTabFldEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convPrjTabFld.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FuncModuleAgcId = objvPrjTabFldEN.FuncModuleAgcId == "[null]" ? null :  objvPrjTabFldEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTabFld.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FuncModuleName = objvPrjTabFldEN.FuncModuleName == "[null]" ? null :  objvPrjTabFldEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convPrjTabFld.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.OrderNum4Refer = objvPrjTabFldEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convPrjTabFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldId = objvPrjTabFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(convPrjTabFld.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.OraDbType = objvPrjTabFldEN.OraDbType == "[null]" ? null :  objvPrjTabFldEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convPrjTabFld.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsNeedTransCode = objvPrjTabFldEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convPrjTabFld.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldName = objvPrjTabFldEN.FldName; //字段名
}
if (arrFldSet.Contains(convPrjTabFld.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldCnName = objvPrjTabFldEN.FldCnName == "[null]" ? null :  objvPrjTabFldEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(convPrjTabFld.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.Caption = objvPrjTabFldEN.Caption; //标题
}
if (arrFldSet.Contains(convPrjTabFld.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.DataTypeId = objvPrjTabFldEN.DataTypeId == "[null]" ? null :  objvPrjTabFldEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convPrjTabFld.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.DataTypeName = objvPrjTabFldEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convPrjTabFld.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldLength = objvPrjTabFldEN.FldLength; //字段长度
}
if (arrFldSet.Contains(convPrjTabFld.FldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldPrecision = objvPrjTabFldEN.FldPrecision; //精确度
}
if (arrFldSet.Contains(convPrjTabFld.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.MaxValue = objvPrjTabFldEN.MaxValue; //最大值
}
if (arrFldSet.Contains(convPrjTabFld.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.MinValue = objvPrjTabFldEN.MinValue; //最小值
}
if (arrFldSet.Contains(convPrjTabFld.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.DefaultValue = objvPrjTabFldEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convPrjTabFld.HomologousFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.HomologousFldId = objvPrjTabFldEN.HomologousFldId == "[null]" ? null :  objvPrjTabFldEN.HomologousFldId; //同源字段Id
}
if (arrFldSet.Contains(convPrjTabFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrjId = objvPrjTabFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjTabFld.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FieldTypeId = objvPrjTabFldEN.FieldTypeId == "[null]" ? null :  objvPrjTabFldEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convPrjTabFld.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FieldTypeName = objvPrjTabFldEN.FieldTypeName == "[null]" ? null :  objvPrjTabFldEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convPrjTabFld.IsTabNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsTabNullable = objvPrjTabFldEN.IsTabNullable; //是否表中可空
}
if (arrFldSet.Contains(convPrjTabFld.IsTabUnique, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsTabUnique = objvPrjTabFldEN.IsTabUnique; //是否表中唯一
}
if (arrFldSet.Contains(convPrjTabFld.IsTabForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsTabForeignKey = objvPrjTabFldEN.IsTabForeignKey; //是否表外键
}
if (arrFldSet.Contains(convPrjTabFld.IsSortFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsSortFld = objvPrjTabFldEN.IsSortFld; //是否排序字段
}
if (arrFldSet.Contains(convPrjTabFld.IsForExtendClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsForExtendClass = objvPrjTabFldEN.IsForExtendClass; //用于扩展类
}
if (arrFldSet.Contains(convPrjTabFld.IsParentObj, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.IsParentObj = objvPrjTabFldEN.IsParentObj; //是否父对象
}
if (arrFldSet.Contains(convPrjTabFld.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrimaryTypeId = objvPrjTabFldEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convPrjTabFld.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrimaryTypeName = objvPrjTabFldEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convPrjTabFld.ForeignKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.ForeignKeyTabId = objvPrjTabFldEN.ForeignKeyTabId; //外键表ID
}
if (arrFldSet.Contains(convPrjTabFld.FldOpTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldOpTypeId = objvPrjTabFldEN.FldOpTypeId; //字段操作类型Id
}
if (arrFldSet.Contains(convPrjTabFld.FldOpTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.FldOpTypeName = objvPrjTabFldEN.FldOpTypeName == "[null]" ? null :  objvPrjTabFldEN.FldOpTypeName; //字段操作类型名称
}
if (arrFldSet.Contains(convPrjTabFld.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.SequenceNumber = objvPrjTabFldEN.SequenceNumber; //顺序号
}
if (arrFldSet.Contains(convPrjTabFld.MemoInTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.MemoInTab = objvPrjTabFldEN.MemoInTab == "[null]" ? null :  objvPrjTabFldEN.MemoInTab; //表中说明
}
if (arrFldSet.Contains(convPrjTabFld.PrjId4Fld, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrjId4Fld = objvPrjTabFldEN.PrjId4Fld == "[null]" ? null :  objvPrjTabFldEN.PrjId4Fld; //PrjId4Fld
}
if (arrFldSet.Contains(convPrjTabFld.PrjName4Fld, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.PrjName4Fld = objvPrjTabFldEN.PrjName4Fld == "[null]" ? null :  objvPrjTabFldEN.PrjName4Fld; //PrjName4Fld
}
if (arrFldSet.Contains(convPrjTabFld.ForeignTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFldEN.ForeignTabName = objvPrjTabFldEN.ForeignTabName; //外键表
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
 /// <param name = "objvPrjTabFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTabFldEN objvPrjTabFldEN)
{
try
{
if (objvPrjTabFldEN.TabCnName == "[null]") objvPrjTabFldEN.TabCnName = null; //表中文名
if (objvPrjTabFldEN.PrjName == "[null]") objvPrjTabFldEN.PrjName = null; //工程名称
if (objvPrjTabFldEN.SqlDsTypeName == "[null]") objvPrjTabFldEN.SqlDsTypeName = null; //Sql数据源名
if (objvPrjTabFldEN.FuncModuleAgcId == "[null]") objvPrjTabFldEN.FuncModuleAgcId = null; //功能模块Id
if (objvPrjTabFldEN.FuncModuleName == "[null]") objvPrjTabFldEN.FuncModuleName = null; //功能模块名称
if (objvPrjTabFldEN.OraDbType == "[null]") objvPrjTabFldEN.OraDbType = null; //Ora数据类型
if (objvPrjTabFldEN.FldCnName == "[null]") objvPrjTabFldEN.FldCnName = null; //字段中文详名
if (objvPrjTabFldEN.DataTypeId == "[null]") objvPrjTabFldEN.DataTypeId = null; //数据类型Id
if (objvPrjTabFldEN.HomologousFldId == "[null]") objvPrjTabFldEN.HomologousFldId = null; //同源字段Id
if (objvPrjTabFldEN.FieldTypeId == "[null]") objvPrjTabFldEN.FieldTypeId = null; //字段类型Id
if (objvPrjTabFldEN.FieldTypeName == "[null]") objvPrjTabFldEN.FieldTypeName = null; //字段类型名
if (objvPrjTabFldEN.FldOpTypeName == "[null]") objvPrjTabFldEN.FldOpTypeName = null; //字段操作类型名称
if (objvPrjTabFldEN.MemoInTab == "[null]") objvPrjTabFldEN.MemoInTab = null; //表中说明
if (objvPrjTabFldEN.PrjId4Fld == "[null]") objvPrjTabFldEN.PrjId4Fld = null; //PrjId4Fld
if (objvPrjTabFldEN.PrjName4Fld == "[null]") objvPrjTabFldEN.PrjName4Fld = null; //PrjName4Fld
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
public static void CheckProperty4Condition(clsvPrjTabFldEN objvPrjTabFldEN)
{
 vPrjTabFldDA.CheckProperty4Condition(objvPrjTabFldEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFldOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFldOperationTypeBL没有刷新缓存机制(clsFldOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPrjTabFldObjLstCache == null)
//{
//arrvPrjTabFldObjLstCache = vPrjTabFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabFldEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel =
arrvPrjTabFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPrjTabFldObjLst_Sel.Count() == 0)
{
   clsvPrjTabFldEN obj = clsvPrjTabFldBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTabFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFldEN> GetAllvPrjTabFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTabFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFldEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTabFldObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:TabId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrvPrjTabFldObjLst">需要排序的对象列表</param>
public static List <clsvPrjTabFldEN> GetSubSet4vPrjTabFldObjLstByTabIdCache(string strTabId, string strPrjId)
{
   if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
from objvPrjTabFldEN in arrvPrjTabFldObjLstCache
where objvPrjTabFldEN.TabId == strTabId
select objvPrjTabFldEN;
List <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldEN>();
foreach (clsvPrjTabFldEN obj in arrvPrjTabFldObjLst_Sel1)
{
arrvPrjTabFldObjLst_Sel.Add(obj);
}
return arrvPrjTabFldObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrvPrjTabFldObjLst">需要排序的对象列表</param>
public static List <clsvPrjTabFldEN> GetSubSet4vPrjTabFldObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
List<clsvPrjTabFldEN> arrvPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
from objvPrjTabFldEN in arrvPrjTabFldObjLstCache
where objvPrjTabFldEN.PrjId == strPrjId
select objvPrjTabFldEN;
List <clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldEN>();
foreach (clsvPrjTabFldEN obj in arrvPrjTabFldObjLst_Sel1)
{
arrvPrjTabFldObjLst_Sel.Add(obj);
}
return arrvPrjTabFldObjLst_Sel;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTabFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTabFldEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTabFldEN._RefreshTimeLst[clsvPrjTabFldEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convPrjTabFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTabFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTabFld._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTabFld = clsvPrjTabFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvPrjTabFld == null) return "";
return objvPrjTabFld[strOutFldName].ToString();
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
int intRecCount = clsvPrjTabFldDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTabFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTabFldDA.GetRecCount();
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
int intRecCount = clsvPrjTabFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTabFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTabFldEN objvPrjTabFldCond)
{
 string strPrjId = objvPrjTabFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTabFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabFld._AttributeName)
{
if (objvPrjTabFldCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFldCond[strFldName].ToString());
}
else
{
if (objvPrjTabFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabFldCond[strFldName]));
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
 List<string> arrList = clsvPrjTabFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}