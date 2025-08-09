
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConstraintFieldsBL
 表名:vConstraintFields(00050413)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvConstraintFieldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConstraintFieldsEN GetObj(this K_mId_vConstraintFields myKey)
{
clsvConstraintFieldsEN objvConstraintFieldsEN = clsvConstraintFieldsBL.vConstraintFieldsDA.GetObjBymId(myKey.Value);
return objvConstraintFieldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetPrjConstraintId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjConstraintId, convConstraintFields.PrjConstraintId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, convConstraintFields.PrjConstraintId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, convConstraintFields.PrjConstraintId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, convConstraintFields.ConstraintName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintName, 100, convConstraintFields.ConstraintName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintTypeId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, convConstraintFields.ConstraintTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, convConstraintFields.ConstraintTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetConstraintTypeName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strConstraintTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeName, 50, convConstraintFields.ConstraintTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convConstraintFields.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convConstraintFields.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convConstraintFields.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convConstraintFields.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convConstraintFields.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetTabCnName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convConstraintFields.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convConstraintFields.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convConstraintFields.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convConstraintFields.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convConstraintFields.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convConstraintFields.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetFldCnName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convConstraintFields.FldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMaxValue(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMaxValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convConstraintFields.MaxValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMinValue(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMinValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, convConstraintFields.MinValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetSortTypeId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strSortTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeId, convConstraintFields.SortTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSortTypeId, 2, convConstraintFields.SortTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSortTypeId, 2, convConstraintFields.SortTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetSortTypeName(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strSortTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeName, convConstraintFields.SortTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSortTypeName, 30, convConstraintFields.SortTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetPrjId(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convConstraintFields.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convConstraintFields.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetUpdDate(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convConstraintFields.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetUpdUser(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convConstraintFields.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConstraintFieldsEN SetMemo(this clsvConstraintFieldsEN objvConstraintFieldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convConstraintFields.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvConstraintFieldsENS">源对象</param>
 /// <param name = "objvConstraintFieldsENT">目标对象</param>
 public static void CopyTo(this clsvConstraintFieldsEN objvConstraintFieldsENS, clsvConstraintFieldsEN objvConstraintFieldsENT)
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
 /// <param name = "objvConstraintFieldsENS">源对象</param>
 /// <returns>目标对象=>clsvConstraintFieldsEN:objvConstraintFieldsENT</returns>
 public static clsvConstraintFieldsEN CopyTo(this clsvConstraintFieldsEN objvConstraintFieldsENS)
{
try
{
 clsvConstraintFieldsEN objvConstraintFieldsENT = new clsvConstraintFieldsEN()
{
mId = objvConstraintFieldsENS.mId, //mId
PrjConstraintId = objvConstraintFieldsENS.PrjConstraintId, //约束表Id
ConstraintName = objvConstraintFieldsENS.ConstraintName, //约束名
ConstraintTypeId = objvConstraintFieldsENS.ConstraintTypeId, //约束类型Id
ConstraintTypeName = objvConstraintFieldsENS.ConstraintTypeName, //约束类型名
TabId = objvConstraintFieldsENS.TabId, //表ID
TabName = objvConstraintFieldsENS.TabName, //表名
TabCnName = objvConstraintFieldsENS.TabCnName, //表中文名
FldId = objvConstraintFieldsENS.FldId, //字段Id
FldName = objvConstraintFieldsENS.FldName, //字段名
FldCnName = objvConstraintFieldsENS.FldCnName, //字段中文详名
MaxValue = objvConstraintFieldsENS.MaxValue, //最大值
MinValue = objvConstraintFieldsENS.MinValue, //最小值
SortTypeId = objvConstraintFieldsENS.SortTypeId, //排序类型Id
SortTypeName = objvConstraintFieldsENS.SortTypeName, //排序类型名称
InUse = objvConstraintFieldsENS.InUse, //是否在用
OrderNum = objvConstraintFieldsENS.OrderNum, //序号
PrjId = objvConstraintFieldsENS.PrjId, //工程Id
UpdDate = objvConstraintFieldsENS.UpdDate, //修改日期
UpdUser = objvConstraintFieldsENS.UpdUser, //修改者
Memo = objvConstraintFieldsENS.Memo, //说明
};
 return objvConstraintFieldsENT;
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
public static void CheckProperty4Condition(this clsvConstraintFieldsEN objvConstraintFieldsEN)
{
 clsvConstraintFieldsBL.vConstraintFieldsDA.CheckProperty4Condition(objvConstraintFieldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vConstraintFields
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v约束字段(vConstraintFields)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvConstraintFieldsBL
{
public static RelatedActions_vConstraintFields relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvConstraintFieldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvConstraintFieldsDA vConstraintFieldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvConstraintFieldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvConstraintFieldsBL()
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
if (string.IsNullOrEmpty(clsvConstraintFieldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConstraintFieldsEN._ConnectString);
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
public static DataTable GetDataTable_vConstraintFields(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vConstraintFieldsDA.GetDataTable_vConstraintFields(strWhereCond);
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
objDT = vConstraintFieldsDA.GetDataTable(strWhereCond);
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
objDT = vConstraintFieldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vConstraintFieldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vConstraintFieldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vConstraintFieldsDA.GetDataTable_Top(objTopPara);
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
objDT = vConstraintFieldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vConstraintFieldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vConstraintFieldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvConstraintFieldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
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
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvConstraintFieldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel =
arrvConstraintFieldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvConstraintFieldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLst(string strWhereCond)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
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
public static List<clsvConstraintFieldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvConstraintFieldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvConstraintFieldsEN> GetSubObjLstCache(clsvConstraintFieldsEN objvConstraintFieldsCond)
{
 string strPrjId = objvConstraintFieldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvConstraintFieldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvConstraintFieldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConstraintFields._AttributeName)
{
if (objvConstraintFieldsCond.IsUpdated(strFldName) == false) continue;
if (objvConstraintFieldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConstraintFieldsCond[strFldName].ToString());
}
else
{
if (objvConstraintFieldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConstraintFieldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConstraintFieldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConstraintFieldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConstraintFieldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConstraintFieldsCond[strFldName]));
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
public static List<clsvConstraintFieldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
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
public static List<clsvConstraintFieldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
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
List<clsvConstraintFieldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvConstraintFieldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConstraintFieldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvConstraintFieldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
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
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
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
public static List<clsvConstraintFieldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvConstraintFieldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
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
public static List<clsvConstraintFieldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvConstraintFields(ref clsvConstraintFieldsEN objvConstraintFieldsEN)
{
bool bolResult = vConstraintFieldsDA.GetvConstraintFields(ref objvConstraintFieldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConstraintFieldsEN GetObjBymId(long lngmId)
{
clsvConstraintFieldsEN objvConstraintFieldsEN = vConstraintFieldsDA.GetObjBymId(lngmId);
return objvConstraintFieldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvConstraintFieldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvConstraintFieldsEN objvConstraintFieldsEN = vConstraintFieldsDA.GetFirstObj(strWhereCond);
 return objvConstraintFieldsEN;
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
public static clsvConstraintFieldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvConstraintFieldsEN objvConstraintFieldsEN = vConstraintFieldsDA.GetObjByDataRow(objRow);
 return objvConstraintFieldsEN;
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
public static clsvConstraintFieldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvConstraintFieldsEN objvConstraintFieldsEN = vConstraintFieldsDA.GetObjByDataRow(objRow);
 return objvConstraintFieldsEN;
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
 /// <param name = "lstvConstraintFieldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConstraintFieldsEN GetObjBymIdFromList(long lngmId, List<clsvConstraintFieldsEN> lstvConstraintFieldsObjLst)
{
foreach (clsvConstraintFieldsEN objvConstraintFieldsEN in lstvConstraintFieldsObjLst)
{
if (objvConstraintFieldsEN.mId == lngmId)
{
return objvConstraintFieldsEN;
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
 lngmId = new clsvConstraintFieldsDA().GetFirstID(strWhereCond);
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
 arrList = vConstraintFieldsDA.GetID(strWhereCond);
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
bool bolIsExist = vConstraintFieldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vConstraintFieldsDA.IsExist(lngmId);
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
 bolIsExist = clsvConstraintFieldsDA.IsExistTable();
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
 bolIsExist = vConstraintFieldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvConstraintFieldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvConstraintFieldsEN objvConstraintFieldsEN)
{
try
{
objvConstraintFieldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvConstraintFieldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convConstraintFields.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.mId = objvConstraintFieldsEN.mId; //mId
}
if (arrFldSet.Contains(convConstraintFields.PrjConstraintId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.PrjConstraintId = objvConstraintFieldsEN.PrjConstraintId; //约束表Id
}
if (arrFldSet.Contains(convConstraintFields.ConstraintName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.ConstraintName = objvConstraintFieldsEN.ConstraintName; //约束名
}
if (arrFldSet.Contains(convConstraintFields.ConstraintTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.ConstraintTypeId = objvConstraintFieldsEN.ConstraintTypeId == "[null]" ? null :  objvConstraintFieldsEN.ConstraintTypeId; //约束类型Id
}
if (arrFldSet.Contains(convConstraintFields.ConstraintTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.ConstraintTypeName = objvConstraintFieldsEN.ConstraintTypeName == "[null]" ? null :  objvConstraintFieldsEN.ConstraintTypeName; //约束类型名
}
if (arrFldSet.Contains(convConstraintFields.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.TabId = objvConstraintFieldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convConstraintFields.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.TabName = objvConstraintFieldsEN.TabName; //表名
}
if (arrFldSet.Contains(convConstraintFields.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.TabCnName = objvConstraintFieldsEN.TabCnName == "[null]" ? null :  objvConstraintFieldsEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convConstraintFields.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.FldId = objvConstraintFieldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convConstraintFields.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.FldName = objvConstraintFieldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convConstraintFields.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.FldCnName = objvConstraintFieldsEN.FldCnName == "[null]" ? null :  objvConstraintFieldsEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(convConstraintFields.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.MaxValue = objvConstraintFieldsEN.MaxValue == "[null]" ? null :  objvConstraintFieldsEN.MaxValue; //最大值
}
if (arrFldSet.Contains(convConstraintFields.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.MinValue = objvConstraintFieldsEN.MinValue == "[null]" ? null :  objvConstraintFieldsEN.MinValue; //最小值
}
if (arrFldSet.Contains(convConstraintFields.SortTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.SortTypeId = objvConstraintFieldsEN.SortTypeId; //排序类型Id
}
if (arrFldSet.Contains(convConstraintFields.SortTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.SortTypeName = objvConstraintFieldsEN.SortTypeName; //排序类型名称
}
if (arrFldSet.Contains(convConstraintFields.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.InUse = objvConstraintFieldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convConstraintFields.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.OrderNum = objvConstraintFieldsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convConstraintFields.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.PrjId = objvConstraintFieldsEN.PrjId == "[null]" ? null :  objvConstraintFieldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convConstraintFields.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.UpdDate = objvConstraintFieldsEN.UpdDate == "[null]" ? null :  objvConstraintFieldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convConstraintFields.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.UpdUser = objvConstraintFieldsEN.UpdUser == "[null]" ? null :  objvConstraintFieldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convConstraintFields.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvConstraintFieldsEN.Memo = objvConstraintFieldsEN.Memo == "[null]" ? null :  objvConstraintFieldsEN.Memo; //说明
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
 /// <param name = "objvConstraintFieldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvConstraintFieldsEN objvConstraintFieldsEN)
{
try
{
if (objvConstraintFieldsEN.ConstraintTypeId == "[null]") objvConstraintFieldsEN.ConstraintTypeId = null; //约束类型Id
if (objvConstraintFieldsEN.ConstraintTypeName == "[null]") objvConstraintFieldsEN.ConstraintTypeName = null; //约束类型名
if (objvConstraintFieldsEN.TabCnName == "[null]") objvConstraintFieldsEN.TabCnName = null; //表中文名
if (objvConstraintFieldsEN.FldCnName == "[null]") objvConstraintFieldsEN.FldCnName = null; //字段中文详名
if (objvConstraintFieldsEN.MaxValue == "[null]") objvConstraintFieldsEN.MaxValue = null; //最大值
if (objvConstraintFieldsEN.MinValue == "[null]") objvConstraintFieldsEN.MinValue = null; //最小值
if (objvConstraintFieldsEN.PrjId == "[null]") objvConstraintFieldsEN.PrjId = null; //工程Id
if (objvConstraintFieldsEN.UpdDate == "[null]") objvConstraintFieldsEN.UpdDate = null; //修改日期
if (objvConstraintFieldsEN.UpdUser == "[null]") objvConstraintFieldsEN.UpdUser = null; //修改者
if (objvConstraintFieldsEN.Memo == "[null]") objvConstraintFieldsEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvConstraintFieldsEN objvConstraintFieldsEN)
{
 vConstraintFieldsDA.CheckProperty4Condition(objvConstraintFieldsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convConstraintFields.mId); 
List<clsvConstraintFieldsEN> arrObjLst = clsvConstraintFieldsBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束字段]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convConstraintFields.mId); 
IEnumerable<clsvConstraintFieldsEN> arrObjLst = clsvConstraintFieldsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convConstraintFields.mId;
objDDL.DataTextField = convConstraintFields.ConstraintName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束字段]...","0");
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLst = GetAllvConstraintFieldsObjLstCache(strPrjId); 
objDDL.DataValueField = convConstraintFields.mId;
objDDL.DataTextField = convConstraintFields.ConstraintName;
objDDL.DataSource = arrvConstraintFieldsObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConstraintFieldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConstraintFieldsBL没有刷新缓存机制(clsConstraintFieldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSortTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSortTypeBL没有刷新缓存机制(clsSortTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjConstraintBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjConstraintBL没有刷新缓存机制(clsPrjConstraintBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConstraintTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConstraintTypeBL没有刷新缓存机制(clsConstraintTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvConstraintFieldsObjLstCache == null)
//{
//arrvConstraintFieldsObjLstCache = vConstraintFieldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConstraintFieldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrvConstraintFieldsObjLst_Sel =
arrvConstraintFieldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvConstraintFieldsObjLst_Sel.Count() == 0)
{
   clsvConstraintFieldsEN obj = clsvConstraintFieldsBL.GetObjBymId(lngmId);
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
return arrvConstraintFieldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameBymIdCache(long lngmId, string strPrjId)
{
//获取缓存中的对象列表
clsvConstraintFieldsEN objvConstraintFields = GetObjBymIdCache(lngmId, strPrjId);
if (objvConstraintFields == null) return "";
return objvConstraintFields.ConstraintName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId, string strPrjId)
{
//获取缓存中的对象列表
clsvConstraintFieldsEN objvConstraintFields = GetObjBymIdCache(lngmId, strPrjId);
if (objvConstraintFields == null) return "";
return objvConstraintFields.ConstraintName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConstraintFieldsEN> GetAllvConstraintFieldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConstraintFieldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvConstraintFieldsEN> arrvConstraintFieldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvConstraintFieldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvConstraintFieldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvConstraintFieldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvConstraintFieldsEN._RefreshTimeLst.Count == 0) return "";
return clsvConstraintFieldsEN._RefreshTimeLst[clsvConstraintFieldsEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convConstraintFields.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convConstraintFields._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convConstraintFields._AttributeName));
throw new Exception(strMsg);
}
var objvConstraintFields = clsvConstraintFieldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvConstraintFields == null) return "";
return objvConstraintFields[strOutFldName].ToString();
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
int intRecCount = clsvConstraintFieldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvConstraintFieldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvConstraintFieldsDA.GetRecCount();
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
int intRecCount = clsvConstraintFieldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvConstraintFieldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvConstraintFieldsEN objvConstraintFieldsCond)
{
 string strPrjId = objvConstraintFieldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvConstraintFieldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvConstraintFieldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvConstraintFieldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConstraintFields._AttributeName)
{
if (objvConstraintFieldsCond.IsUpdated(strFldName) == false) continue;
if (objvConstraintFieldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConstraintFieldsCond[strFldName].ToString());
}
else
{
if (objvConstraintFieldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConstraintFieldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConstraintFieldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConstraintFieldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConstraintFieldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConstraintFieldsCond[strFldName]));
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
 List<string> arrList = clsvConstraintFieldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vConstraintFieldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vConstraintFieldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}