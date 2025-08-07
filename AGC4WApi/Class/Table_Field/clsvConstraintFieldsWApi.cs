
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConstraintFieldsWApi
 表名:vConstraintFields(00050413)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:34
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
public static class  clsvConstraintFieldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetmId(this clsvConstraintFieldsEN objvConstraintFieldsEN, long lngmId, string strComparisonOp="")
	{
objvConstraintFieldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.mId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.mId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.mId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjConstraintId">约束表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetPrjConstraintId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjConstraintId, convConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, convConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, convConstraintFields.PrjConstraintId);
objvConstraintFieldsEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.PrjConstraintId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.PrjConstraintId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.PrjConstraintId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintName">约束名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, convConstraintFields.ConstraintName);
clsCheckSql.CheckFieldLen(strConstraintName, 100, convConstraintFields.ConstraintName);
objvConstraintFieldsEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.ConstraintName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.ConstraintName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.ConstraintName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeId">约束类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintTypeId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, convConstraintFields.ConstraintTypeId);
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, convConstraintFields.ConstraintTypeId);
objvConstraintFieldsEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.ConstraintTypeId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.ConstraintTypeId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.ConstraintTypeId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeName">约束类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintTypeName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstraintTypeName, 50, convConstraintFields.ConstraintTypeName);
objvConstraintFieldsEN.ConstraintTypeName = strConstraintTypeName; //约束类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.ConstraintTypeName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.ConstraintTypeName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.ConstraintTypeName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convConstraintFields.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convConstraintFields.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convConstraintFields.TabId);
objvConstraintFieldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.TabId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.TabId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.TabId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convConstraintFields.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convConstraintFields.TabName);
objvConstraintFieldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.TabName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.TabName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.TabName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabCnName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convConstraintFields.TabCnName);
objvConstraintFieldsEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.TabCnName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.TabCnName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.TabCnName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convConstraintFields.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convConstraintFields.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convConstraintFields.FldId);
objvConstraintFieldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.FldId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.FldId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.FldId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convConstraintFields.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convConstraintFields.FldName);
objvConstraintFieldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.FldName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.FldName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.FldName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldCnName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convConstraintFields.FldCnName);
objvConstraintFieldsEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.FldCnName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.FldCnName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.FldCnName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMaxValue(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convConstraintFields.MaxValue);
objvConstraintFieldsEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.MaxValue) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.MaxValue, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.MaxValue] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMinValue(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMinValue, 50, convConstraintFields.MinValue);
objvConstraintFieldsEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.MinValue) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.MinValue, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.MinValue] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSortTypeId">排序类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetSortTypeId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strSortTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeId, convConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(strSortTypeId, 2, convConstraintFields.SortTypeId);
clsCheckSql.CheckFieldForeignKey(strSortTypeId, 2, convConstraintFields.SortTypeId);
objvConstraintFieldsEN.SortTypeId = strSortTypeId; //排序类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.SortTypeId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.SortTypeId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.SortTypeId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSortTypeName">排序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetSortTypeName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strSortTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeName, convConstraintFields.SortTypeName);
clsCheckSql.CheckFieldLen(strSortTypeName, 30, convConstraintFields.SortTypeName);
objvConstraintFieldsEN.SortTypeName = strSortTypeName; //排序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.SortTypeName) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.SortTypeName, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.SortTypeName] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetInUse(this clsvConstraintFieldsEN objvConstraintFieldsEN, bool bolInUse, string strComparisonOp="")
	{
objvConstraintFieldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.InUse) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.InUse, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.InUse] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetOrderNum(this clsvConstraintFieldsEN objvConstraintFieldsEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convConstraintFields.OrderNum);
objvConstraintFieldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.OrderNum) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.OrderNum, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.OrderNum] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetPrjId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convConstraintFields.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convConstraintFields.PrjId);
objvConstraintFieldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.PrjId) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.PrjId, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.PrjId] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetUpdDate(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convConstraintFields.UpdDate);
objvConstraintFieldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.UpdDate) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.UpdDate, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.UpdDate] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetUpdUser(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convConstraintFields.UpdUser);
objvConstraintFieldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.UpdUser) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.UpdUser, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.UpdUser] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMemo(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convConstraintFields.Memo);
objvConstraintFieldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConstraintFieldsEN.dicFldComparisonOp.ContainsKey(convConstraintFields.Memo) == false)
{
objvConstraintFieldsEN.dicFldComparisonOp.Add(convConstraintFields.Memo, strComparisonOp);
}
else
{
objvConstraintFieldsEN.dicFldComparisonOp[convConstraintFields.Memo] = strComparisonOp;
}
}
return objvConstraintFieldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvConstraintFieldsEN objvConstraintFieldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.mId) == true)
{
string strComparisonOpmId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convConstraintFields.mId, objvConstraintFieldsCond.mId, strComparisonOpmId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.PrjConstraintId, objvConstraintFieldsCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.ConstraintName) == true)
{
string strComparisonOpConstraintName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.ConstraintName, objvConstraintFieldsCond.ConstraintName, strComparisonOpConstraintName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.ConstraintTypeId, objvConstraintFieldsCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.ConstraintTypeName) == true)
{
string strComparisonOpConstraintTypeName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.ConstraintTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.ConstraintTypeName, objvConstraintFieldsCond.ConstraintTypeName, strComparisonOpConstraintTypeName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.TabId) == true)
{
string strComparisonOpTabId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.TabId, objvConstraintFieldsCond.TabId, strComparisonOpTabId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.TabName) == true)
{
string strComparisonOpTabName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.TabName, objvConstraintFieldsCond.TabName, strComparisonOpTabName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.TabCnName) == true)
{
string strComparisonOpTabCnName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.TabCnName, objvConstraintFieldsCond.TabCnName, strComparisonOpTabCnName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.FldId) == true)
{
string strComparisonOpFldId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.FldId, objvConstraintFieldsCond.FldId, strComparisonOpFldId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.FldName) == true)
{
string strComparisonOpFldName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.FldName, objvConstraintFieldsCond.FldName, strComparisonOpFldName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.FldCnName) == true)
{
string strComparisonOpFldCnName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.FldCnName, objvConstraintFieldsCond.FldCnName, strComparisonOpFldCnName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.MaxValue) == true)
{
string strComparisonOpMaxValue = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.MaxValue, objvConstraintFieldsCond.MaxValue, strComparisonOpMaxValue);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.MinValue) == true)
{
string strComparisonOpMinValue = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.MinValue, objvConstraintFieldsCond.MinValue, strComparisonOpMinValue);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.SortTypeId) == true)
{
string strComparisonOpSortTypeId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.SortTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.SortTypeId, objvConstraintFieldsCond.SortTypeId, strComparisonOpSortTypeId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.SortTypeName) == true)
{
string strComparisonOpSortTypeName = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.SortTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.SortTypeName, objvConstraintFieldsCond.SortTypeName, strComparisonOpSortTypeName);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.InUse) == true)
{
if (objvConstraintFieldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convConstraintFields.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convConstraintFields.InUse);
}
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.OrderNum) == true)
{
string strComparisonOpOrderNum = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convConstraintFields.OrderNum, objvConstraintFieldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.PrjId) == true)
{
string strComparisonOpPrjId = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.PrjId, objvConstraintFieldsCond.PrjId, strComparisonOpPrjId);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.UpdDate) == true)
{
string strComparisonOpUpdDate = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.UpdDate, objvConstraintFieldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.UpdUser) == true)
{
string strComparisonOpUpdUser = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.UpdUser, objvConstraintFieldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvConstraintFieldsCond.IsUpdated(convConstraintFields.Memo) == true)
{
string strComparisonOpMemo = objvConstraintFieldsCond.dicFldComparisonOp[convConstraintFields.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConstraintFields.Memo, objvConstraintFieldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v约束字段(vConstraintFields)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvConstraintFieldsWApi
{
private static readonly string mstrApiControllerName = "vConstraintFieldsApi";

 public clsvConstraintFieldsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束字段]...","0");
List<clsvConstraintFieldsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="mId";
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
public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convConstraintFields.mId); 
List<clsvConstraintFieldsEN> arrObjLst = clsvConstraintFieldsWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN()
{
mId = 0,
ConstraintName = "选[v约束字段]..."
};
arrObjLstSel.Insert(0, objvConstraintFieldsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convConstraintFields.mId;
objComboBox.DisplayMember = convConstraintFields.ConstraintName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConstraintFieldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvConstraintFieldsEN objvConstraintFieldsEN;
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
objvConstraintFieldsEN = JsonConvert.DeserializeObject<clsvConstraintFieldsEN>(strJson);
return objvConstraintFieldsEN;
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
public static clsvConstraintFieldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvConstraintFieldsEN objvConstraintFieldsEN;
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
objvConstraintFieldsEN = JsonConvert.DeserializeObject<clsvConstraintFieldsEN>(strJson);
return objvConstraintFieldsEN;
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
public static clsvConstraintFieldsEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel =
from objvConstraintFieldsEN in arrvConstraintFieldsObjLstCache
where objvConstraintFieldsEN.mId == lngmId 
select objvConstraintFieldsEN;
if (arrvConstraintFieldsObjLst_Sel.Count() == 0)
{
   clsvConstraintFieldsEN obj = clsvConstraintFieldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvConstraintFieldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel1 =
from objvConstraintFieldsEN in arrvConstraintFieldsObjLstCache
where objvConstraintFieldsEN.mId == lngmId 
select objvConstraintFieldsEN;
List <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel = new List<clsvConstraintFieldsEN>();
foreach (clsvConstraintFieldsEN obj in arrvConstraintFieldsObjLst_Sel1)
{
arrvConstraintFieldsObjLst_Sel.Add(obj);
}
if (arrvConstraintFieldsObjLst_Sel.Count > 0)
{
return arrvConstraintFieldsObjLst_Sel[0].ConstraintName;
}
string strErrMsgForGetObjById = string.Format("在vConstraintFields对象缓存列表中,找不到记录[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvConstraintFieldsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel1 =
from objvConstraintFieldsEN in arrvConstraintFieldsObjLstCache
where objvConstraintFieldsEN.mId == lngmId 
select objvConstraintFieldsEN;
List <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel = new List<clsvConstraintFieldsEN>();
foreach (clsvConstraintFieldsEN obj in arrvConstraintFieldsObjLst_Sel1)
{
arrvConstraintFieldsObjLst_Sel.Add(obj);
}
if (arrvConstraintFieldsObjLst_Sel.Count > 0)
{
return arrvConstraintFieldsObjLst_Sel[0].ConstraintName;
}
string strErrMsgForGetObjById = string.Format("在vConstraintFields对象缓存列表中,找不到记录的相关名称[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvConstraintFieldsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLst(string strWhereCond)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
public static List<clsvConstraintFieldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
public static IEnumerable<clsvConstraintFieldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel =
from objvConstraintFieldsEN in arrvConstraintFieldsObjLstCache
where arrMId.Contains(objvConstraintFieldsEN.mId)
select objvConstraintFieldsEN;
return arrvConstraintFieldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConstraintFieldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
public static List<clsvConstraintFieldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
public static List<clsvConstraintFieldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
public static List<clsvConstraintFieldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvConstraintFieldsEN>>(strJson);
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
 /// <param name = "objvConstraintFieldsENS">源对象</param>
 /// <param name = "objvConstraintFieldsENT">目标对象</param>
 public static void CopyTo(clsvConstraintFieldsEN objvConstraintFieldsENS, clsvConstraintFieldsEN objvConstraintFieldsENT)
{
try
{
objvConstraintFieldsENT.mId = objvConstraintFieldsENS.mId; //mId
objvConstraintFieldsENT.PrjConstraintId = objvConstraintFieldsENS.PrjConstraintId; //约束表Id
objvConstraintFieldsENT.ConstraintName = objvConstraintFieldsENS.ConstraintName; //约束名
objvConstraintFieldsENT.ConstraintTypeId = objvConstraintFieldsENS.ConstraintTypeId; //约束类型Id
objvConstraintFieldsENT.ConstraintTypeName = objvConstraintFieldsENS.ConstraintTypeName; //约束类型名
objvConstraintFieldsENT.TabId = objvConstraintFieldsENS.TabId; //表ID
objvConstraintFieldsENT.TabName = objvConstraintFieldsENS.TabName; //表名
objvConstraintFieldsENT.TabCnName = objvConstraintFieldsENS.TabCnName; //表中文名
objvConstraintFieldsENT.FldId = objvConstraintFieldsENS.FldId; //字段Id
objvConstraintFieldsENT.FldName = objvConstraintFieldsENS.FldName; //字段名
objvConstraintFieldsENT.FldCnName = objvConstraintFieldsENS.FldCnName; //字段中文详名
objvConstraintFieldsENT.MaxValue = objvConstraintFieldsENS.MaxValue; //最大值
objvConstraintFieldsENT.MinValue = objvConstraintFieldsENS.MinValue; //最小值
objvConstraintFieldsENT.SortTypeId = objvConstraintFieldsENS.SortTypeId; //排序类型Id
objvConstraintFieldsENT.SortTypeName = objvConstraintFieldsENS.SortTypeName; //排序类型名称
objvConstraintFieldsENT.InUse = objvConstraintFieldsENS.InUse; //是否在用
objvConstraintFieldsENT.OrderNum = objvConstraintFieldsENS.OrderNum; //序号
objvConstraintFieldsENT.PrjId = objvConstraintFieldsENS.PrjId; //工程Id
objvConstraintFieldsENT.UpdDate = objvConstraintFieldsENS.UpdDate; //修改日期
objvConstraintFieldsENT.UpdUser = objvConstraintFieldsENS.UpdUser; //修改者
objvConstraintFieldsENT.Memo = objvConstraintFieldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvConstraintFieldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvConstraintFieldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvConstraintFieldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvConstraintFieldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvConstraintFieldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvConstraintFieldsEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvConstraintFieldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvConstraintFieldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
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
public static List<clsvConstraintFieldsEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvConstraintFieldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvConstraintFieldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvConstraintFieldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvConstraintFieldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convConstraintFields.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvConstraintFieldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvConstraintFieldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvConstraintFieldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvConstraintFieldsObjLstCache = CacheHelper.Get<List<clsvConstraintFieldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvConstraintFieldsObjLstCache = CacheHelper.Get<List<clsvConstraintFieldsEN>>(strKey);
}
return arrvConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvConstraintFieldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convConstraintFields.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convConstraintFields.PrjConstraintId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.ConstraintName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.ConstraintTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.ConstraintTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.SortTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.SortTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convConstraintFields.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convConstraintFields.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convConstraintFields.Memo, Type.GetType("System.String"));
foreach (clsvConstraintFieldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convConstraintFields.mId] = objInFor[convConstraintFields.mId];
objDR[convConstraintFields.PrjConstraintId] = objInFor[convConstraintFields.PrjConstraintId];
objDR[convConstraintFields.ConstraintName] = objInFor[convConstraintFields.ConstraintName];
objDR[convConstraintFields.ConstraintTypeId] = objInFor[convConstraintFields.ConstraintTypeId];
objDR[convConstraintFields.ConstraintTypeName] = objInFor[convConstraintFields.ConstraintTypeName];
objDR[convConstraintFields.TabId] = objInFor[convConstraintFields.TabId];
objDR[convConstraintFields.TabName] = objInFor[convConstraintFields.TabName];
objDR[convConstraintFields.TabCnName] = objInFor[convConstraintFields.TabCnName];
objDR[convConstraintFields.FldId] = objInFor[convConstraintFields.FldId];
objDR[convConstraintFields.FldName] = objInFor[convConstraintFields.FldName];
objDR[convConstraintFields.FldCnName] = objInFor[convConstraintFields.FldCnName];
objDR[convConstraintFields.MaxValue] = objInFor[convConstraintFields.MaxValue];
objDR[convConstraintFields.MinValue] = objInFor[convConstraintFields.MinValue];
objDR[convConstraintFields.SortTypeId] = objInFor[convConstraintFields.SortTypeId];
objDR[convConstraintFields.SortTypeName] = objInFor[convConstraintFields.SortTypeName];
objDR[convConstraintFields.InUse] = objInFor[convConstraintFields.InUse];
objDR[convConstraintFields.OrderNum] = objInFor[convConstraintFields.OrderNum];
objDR[convConstraintFields.PrjId] = objInFor[convConstraintFields.PrjId];
objDR[convConstraintFields.UpdDate] = objInFor[convConstraintFields.UpdDate];
objDR[convConstraintFields.UpdUser] = objInFor[convConstraintFields.UpdUser];
objDR[convConstraintFields.Memo] = objInFor[convConstraintFields.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}