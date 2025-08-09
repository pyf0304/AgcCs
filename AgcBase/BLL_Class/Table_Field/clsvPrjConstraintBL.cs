
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraintBL
 表名:vPrjConstraint(00050333)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:41
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
public static class  clsvPrjConstraintBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjConstraintEN GetObj(this K_PrjConstraintId_vPrjConstraint myKey)
{
clsvPrjConstraintEN objvPrjConstraintEN = clsvPrjConstraintBL.vPrjConstraintDA.GetObjByPrjConstraintId(myKey.Value);
return objvPrjConstraintEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjConstraintId(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjConstraintId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, convPrjConstraint.PrjConstraintId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, convPrjConstraint.PrjConstraintId);
}
objvPrjConstraintEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjConstraintId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjConstraintId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjConstraintId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintName(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, convPrjConstraint.ConstraintName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintName, 100, convPrjConstraint.ConstraintName);
}
objvPrjConstraintEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjId(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjConstraint.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjConstraint.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjConstraint.PrjId);
}
objvPrjConstraintEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetPrjName(this clsvPrjConstraintEN objvPrjConstraintEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjConstraint.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjConstraint.PrjName);
}
objvPrjConstraintEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.PrjName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.PrjName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.PrjName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabId(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjConstraint.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjConstraint.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjConstraint.TabId);
}
objvPrjConstraintEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabName(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjConstraint.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjConstraint.TabName);
}
objvPrjConstraintEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetTabCnName(this clsvPrjConstraintEN objvPrjConstraintEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjConstraint.TabCnName);
}
objvPrjConstraintEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.TabCnName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.TabCnName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.TabCnName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeId(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeId, convPrjConstraint.ConstraintTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, convPrjConstraint.ConstraintTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, convPrjConstraint.ConstraintTypeId);
}
objvPrjConstraintEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeName(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeName, convPrjConstraint.ConstraintTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeName, 50, convPrjConstraint.ConstraintTypeName);
}
objvPrjConstraintEN.ConstraintTypeName = strConstraintTypeName; //约束类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeName) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeName, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeName] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintTypeNameEN(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintTypeNameEN, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeNameEN, 50, convPrjConstraint.ConstraintTypeNameEN);
}
objvPrjConstraintEN.ConstraintTypeNameEN = strConstraintTypeNameEN; //约束类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintTypeNameEN) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintTypeNameEN, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintTypeNameEN] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetConstraintDescription(this clsvPrjConstraintEN objvPrjConstraintEN, string strConstraintDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintDescription, 500, convPrjConstraint.ConstraintDescription);
}
objvPrjConstraintEN.ConstraintDescription = strConstraintDescription; //约束说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.ConstraintDescription) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.ConstraintDescription, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.ConstraintDescription] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetCreateUserId(this clsvPrjConstraintEN objvPrjConstraintEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convPrjConstraint.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convPrjConstraint.CreateUserId);
}
objvPrjConstraintEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.CreateUserId) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.CreateUserId, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.CreateUserId] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetInUse(this clsvPrjConstraintEN objvPrjConstraintEN, bool bolInUse, string strComparisonOp="")
	{
objvPrjConstraintEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.InUse) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.InUse, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.InUse] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetUpdDate(this clsvPrjConstraintEN objvPrjConstraintEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjConstraint.UpdDate);
}
objvPrjConstraintEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.UpdDate) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.UpdDate, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.UpdDate] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetUpdUser(this clsvPrjConstraintEN objvPrjConstraintEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjConstraint.UpdUser);
}
objvPrjConstraintEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.UpdUser) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.UpdUser, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.UpdUser] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjConstraintEN SetMemo(this clsvPrjConstraintEN objvPrjConstraintEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjConstraint.Memo);
}
objvPrjConstraintEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjConstraintEN.dicFldComparisonOp.ContainsKey(convPrjConstraint.Memo) == false)
{
objvPrjConstraintEN.dicFldComparisonOp.Add(convPrjConstraint.Memo, strComparisonOp);
}
else
{
objvPrjConstraintEN.dicFldComparisonOp[convPrjConstraint.Memo] = strComparisonOp;
}
}
return objvPrjConstraintEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjConstraintENS">源对象</param>
 /// <param name = "objvPrjConstraintENT">目标对象</param>
 public static void CopyTo(this clsvPrjConstraintEN objvPrjConstraintENS, clsvPrjConstraintEN objvPrjConstraintENT)
{
try
{
objvPrjConstraintENT.PrjConstraintId = objvPrjConstraintENS.PrjConstraintId; //约束表Id
objvPrjConstraintENT.ConstraintName = objvPrjConstraintENS.ConstraintName; //约束名
objvPrjConstraintENT.PrjId = objvPrjConstraintENS.PrjId; //工程Id
objvPrjConstraintENT.PrjName = objvPrjConstraintENS.PrjName; //工程名称
objvPrjConstraintENT.TabId = objvPrjConstraintENS.TabId; //表ID
objvPrjConstraintENT.TabName = objvPrjConstraintENS.TabName; //表名
objvPrjConstraintENT.TabCnName = objvPrjConstraintENS.TabCnName; //表中文名
objvPrjConstraintENT.ConstraintTypeId = objvPrjConstraintENS.ConstraintTypeId; //约束类型Id
objvPrjConstraintENT.ConstraintTypeName = objvPrjConstraintENS.ConstraintTypeName; //约束类型名
objvPrjConstraintENT.ConstraintTypeNameEN = objvPrjConstraintENS.ConstraintTypeNameEN; //约束类型英文名
objvPrjConstraintENT.ConstraintDescription = objvPrjConstraintENS.ConstraintDescription; //约束说明
objvPrjConstraintENT.CreateUserId = objvPrjConstraintENS.CreateUserId; //建立用户Id
objvPrjConstraintENT.InUse = objvPrjConstraintENS.InUse; //是否在用
objvPrjConstraintENT.UpdDate = objvPrjConstraintENS.UpdDate; //修改日期
objvPrjConstraintENT.UpdUser = objvPrjConstraintENS.UpdUser; //修改者
objvPrjConstraintENT.Memo = objvPrjConstraintENS.Memo; //说明
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
 /// <param name = "objvPrjConstraintENS">源对象</param>
 /// <returns>目标对象=>clsvPrjConstraintEN:objvPrjConstraintENT</returns>
 public static clsvPrjConstraintEN CopyTo(this clsvPrjConstraintEN objvPrjConstraintENS)
{
try
{
 clsvPrjConstraintEN objvPrjConstraintENT = new clsvPrjConstraintEN()
{
PrjConstraintId = objvPrjConstraintENS.PrjConstraintId, //约束表Id
ConstraintName = objvPrjConstraintENS.ConstraintName, //约束名
PrjId = objvPrjConstraintENS.PrjId, //工程Id
PrjName = objvPrjConstraintENS.PrjName, //工程名称
TabId = objvPrjConstraintENS.TabId, //表ID
TabName = objvPrjConstraintENS.TabName, //表名
TabCnName = objvPrjConstraintENS.TabCnName, //表中文名
ConstraintTypeId = objvPrjConstraintENS.ConstraintTypeId, //约束类型Id
ConstraintTypeName = objvPrjConstraintENS.ConstraintTypeName, //约束类型名
ConstraintTypeNameEN = objvPrjConstraintENS.ConstraintTypeNameEN, //约束类型英文名
ConstraintDescription = objvPrjConstraintENS.ConstraintDescription, //约束说明
CreateUserId = objvPrjConstraintENS.CreateUserId, //建立用户Id
InUse = objvPrjConstraintENS.InUse, //是否在用
UpdDate = objvPrjConstraintENS.UpdDate, //修改日期
UpdUser = objvPrjConstraintENS.UpdUser, //修改者
Memo = objvPrjConstraintENS.Memo, //说明
};
 return objvPrjConstraintENT;
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
public static void CheckProperty4Condition(this clsvPrjConstraintEN objvPrjConstraintEN)
{
 clsvPrjConstraintBL.vPrjConstraintDA.CheckProperty4Condition(objvPrjConstraintEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjConstraintEN objvPrjConstraintCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjConstraintId, objvPrjConstraintCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintName) == true)
{
string strComparisonOpConstraintName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintName, objvPrjConstraintCond.ConstraintName, strComparisonOpConstraintName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjId, objvPrjConstraintCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.PrjName, objvPrjConstraintCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabId) == true)
{
string strComparisonOpTabId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabId, objvPrjConstraintCond.TabId, strComparisonOpTabId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabName) == true)
{
string strComparisonOpTabName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabName, objvPrjConstraintCond.TabName, strComparisonOpTabName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.TabCnName, objvPrjConstraintCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeId, objvPrjConstraintCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeName) == true)
{
string strComparisonOpConstraintTypeName = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeName, objvPrjConstraintCond.ConstraintTypeName, strComparisonOpConstraintTypeName);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintTypeNameEN) == true)
{
string strComparisonOpConstraintTypeNameEN = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintTypeNameEN];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintTypeNameEN, objvPrjConstraintCond.ConstraintTypeNameEN, strComparisonOpConstraintTypeNameEN);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.ConstraintDescription) == true)
{
string strComparisonOpConstraintDescription = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.ConstraintDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.ConstraintDescription, objvPrjConstraintCond.ConstraintDescription, strComparisonOpConstraintDescription);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.CreateUserId, objvPrjConstraintCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.InUse) == true)
{
if (objvPrjConstraintCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjConstraint.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjConstraint.InUse);
}
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.UpdDate, objvPrjConstraintCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.UpdUser, objvPrjConstraintCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjConstraintCond.IsUpdated(convPrjConstraint.Memo) == true)
{
string strComparisonOpMemo = objvPrjConstraintCond.dicFldComparisonOp[convPrjConstraint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjConstraint.Memo, objvPrjConstraintCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjConstraint
{
public virtual bool UpdRelaTabDate(string strPrjConstraintId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v约束(vPrjConstraint)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjConstraintBL
{
public static RelatedActions_vPrjConstraint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjConstraintDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjConstraintDA vPrjConstraintDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjConstraintDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjConstraintBL()
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
if (string.IsNullOrEmpty(clsvPrjConstraintEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjConstraintEN._ConnectString);
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
public static DataTable GetDataTable_vPrjConstraint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjConstraintDA.GetDataTable_vPrjConstraint(strWhereCond);
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
objDT = vPrjConstraintDA.GetDataTable(strWhereCond);
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
objDT = vPrjConstraintDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjConstraintDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjConstraintDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjConstraintDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjConstraintDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjConstraintDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjConstraintDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLstByPrjConstraintIdLst(List<string> arrPrjConstraintIdLst)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjConstraintIdLst, true);
 string strWhereCond = string.Format("PrjConstraintId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjConstraintEN> GetObjLstByPrjConstraintIdLstCache(List<string> arrPrjConstraintIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjConstraintEN._CurrTabName, strPrjId);
List<clsvPrjConstraintEN> arrvPrjConstraintObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjConstraintEN> arrvPrjConstraintObjLst_Sel =
arrvPrjConstraintObjLstCache
.Where(x => arrPrjConstraintIdLst.Contains(x.PrjConstraintId));
return arrvPrjConstraintObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLst(string strWhereCond)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
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
public static List<clsvPrjConstraintEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjConstraintCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjConstraintEN> GetSubObjLstCache(clsvPrjConstraintEN objvPrjConstraintCond)
{
 string strPrjId = objvPrjConstraintCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjConstraintBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjConstraintEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjConstraintEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjConstraint._AttributeName)
{
if (objvPrjConstraintCond.IsUpdated(strFldName) == false) continue;
if (objvPrjConstraintCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraintCond[strFldName].ToString());
}
else
{
if (objvPrjConstraintCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjConstraintCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraintCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjConstraintCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjConstraintCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjConstraintCond[strFldName]));
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
public static List<clsvPrjConstraintEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
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
public static List<clsvPrjConstraintEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
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
List<clsvPrjConstraintEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjConstraintEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraintEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjConstraintEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
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
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
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
public static List<clsvPrjConstraintEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjConstraintEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
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
public static List<clsvPrjConstraintEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjConstraint(ref clsvPrjConstraintEN objvPrjConstraintEN)
{
bool bolResult = vPrjConstraintDA.GetvPrjConstraint(ref objvPrjConstraintEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjConstraintEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
if (strPrjConstraintId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjConstraintId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjConstraintId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjConstraintEN objvPrjConstraintEN = vPrjConstraintDA.GetObjByPrjConstraintId(strPrjConstraintId);
return objvPrjConstraintEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjConstraintEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjConstraintEN objvPrjConstraintEN = vPrjConstraintDA.GetFirstObj(strWhereCond);
 return objvPrjConstraintEN;
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
public static clsvPrjConstraintEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjConstraintEN objvPrjConstraintEN = vPrjConstraintDA.GetObjByDataRow(objRow);
 return objvPrjConstraintEN;
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
public static clsvPrjConstraintEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjConstraintEN objvPrjConstraintEN = vPrjConstraintDA.GetObjByDataRow(objRow);
 return objvPrjConstraintEN;
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
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <param name = "lstvPrjConstraintObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjConstraintEN GetObjByPrjConstraintIdFromList(string strPrjConstraintId, List<clsvPrjConstraintEN> lstvPrjConstraintObjLst)
{
foreach (clsvPrjConstraintEN objvPrjConstraintEN in lstvPrjConstraintObjLst)
{
if (objvPrjConstraintEN.PrjConstraintId == strPrjConstraintId)
{
return objvPrjConstraintEN;
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
 string strPrjConstraintId;
 try
 {
 strPrjConstraintId = new clsvPrjConstraintDA().GetFirstID(strWhereCond);
 return strPrjConstraintId;
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
 arrList = vPrjConstraintDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjConstraintDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjConstraintId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjConstraintDA.IsExist(strPrjConstraintId);
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
 bolIsExist = clsvPrjConstraintDA.IsExistTable();
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
 bolIsExist = vPrjConstraintDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjConstraintENS">源对象</param>
 /// <param name = "objvPrjConstraintENT">目标对象</param>
 public static void CopyTo(clsvPrjConstraintEN objvPrjConstraintENS, clsvPrjConstraintEN objvPrjConstraintENT)
{
try
{
objvPrjConstraintENT.PrjConstraintId = objvPrjConstraintENS.PrjConstraintId; //约束表Id
objvPrjConstraintENT.ConstraintName = objvPrjConstraintENS.ConstraintName; //约束名
objvPrjConstraintENT.PrjId = objvPrjConstraintENS.PrjId; //工程Id
objvPrjConstraintENT.PrjName = objvPrjConstraintENS.PrjName; //工程名称
objvPrjConstraintENT.TabId = objvPrjConstraintENS.TabId; //表ID
objvPrjConstraintENT.TabName = objvPrjConstraintENS.TabName; //表名
objvPrjConstraintENT.TabCnName = objvPrjConstraintENS.TabCnName; //表中文名
objvPrjConstraintENT.ConstraintTypeId = objvPrjConstraintENS.ConstraintTypeId; //约束类型Id
objvPrjConstraintENT.ConstraintTypeName = objvPrjConstraintENS.ConstraintTypeName; //约束类型名
objvPrjConstraintENT.ConstraintTypeNameEN = objvPrjConstraintENS.ConstraintTypeNameEN; //约束类型英文名
objvPrjConstraintENT.ConstraintDescription = objvPrjConstraintENS.ConstraintDescription; //约束说明
objvPrjConstraintENT.CreateUserId = objvPrjConstraintENS.CreateUserId; //建立用户Id
objvPrjConstraintENT.InUse = objvPrjConstraintENS.InUse; //是否在用
objvPrjConstraintENT.UpdDate = objvPrjConstraintENS.UpdDate; //修改日期
objvPrjConstraintENT.UpdUser = objvPrjConstraintENS.UpdUser; //修改者
objvPrjConstraintENT.Memo = objvPrjConstraintENS.Memo; //说明
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
 /// <param name = "objvPrjConstraintEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjConstraintEN objvPrjConstraintEN)
{
try
{
objvPrjConstraintEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjConstraintEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjConstraint.PrjConstraintId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.PrjConstraintId = objvPrjConstraintEN.PrjConstraintId; //约束表Id
}
if (arrFldSet.Contains(convPrjConstraint.ConstraintName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.ConstraintName = objvPrjConstraintEN.ConstraintName; //约束名
}
if (arrFldSet.Contains(convPrjConstraint.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.PrjId = objvPrjConstraintEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjConstraint.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.PrjName = objvPrjConstraintEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjConstraint.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.TabId = objvPrjConstraintEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjConstraint.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.TabName = objvPrjConstraintEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjConstraint.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.TabCnName = objvPrjConstraintEN.TabCnName == "[null]" ? null :  objvPrjConstraintEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convPrjConstraint.ConstraintTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.ConstraintTypeId = objvPrjConstraintEN.ConstraintTypeId; //约束类型Id
}
if (arrFldSet.Contains(convPrjConstraint.ConstraintTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.ConstraintTypeName = objvPrjConstraintEN.ConstraintTypeName; //约束类型名
}
if (arrFldSet.Contains(convPrjConstraint.ConstraintTypeNameEN, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.ConstraintTypeNameEN = objvPrjConstraintEN.ConstraintTypeNameEN == "[null]" ? null :  objvPrjConstraintEN.ConstraintTypeNameEN; //约束类型英文名
}
if (arrFldSet.Contains(convPrjConstraint.ConstraintDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.ConstraintDescription = objvPrjConstraintEN.ConstraintDescription == "[null]" ? null :  objvPrjConstraintEN.ConstraintDescription; //约束说明
}
if (arrFldSet.Contains(convPrjConstraint.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.CreateUserId = objvPrjConstraintEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convPrjConstraint.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.InUse = objvPrjConstraintEN.InUse; //是否在用
}
if (arrFldSet.Contains(convPrjConstraint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.UpdDate = objvPrjConstraintEN.UpdDate == "[null]" ? null :  objvPrjConstraintEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjConstraint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.UpdUser = objvPrjConstraintEN.UpdUser == "[null]" ? null :  objvPrjConstraintEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convPrjConstraint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjConstraintEN.Memo = objvPrjConstraintEN.Memo == "[null]" ? null :  objvPrjConstraintEN.Memo; //说明
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
 /// <param name = "objvPrjConstraintEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjConstraintEN objvPrjConstraintEN)
{
try
{
if (objvPrjConstraintEN.TabCnName == "[null]") objvPrjConstraintEN.TabCnName = null; //表中文名
if (objvPrjConstraintEN.ConstraintTypeNameEN == "[null]") objvPrjConstraintEN.ConstraintTypeNameEN = null; //约束类型英文名
if (objvPrjConstraintEN.ConstraintDescription == "[null]") objvPrjConstraintEN.ConstraintDescription = null; //约束说明
if (objvPrjConstraintEN.UpdDate == "[null]") objvPrjConstraintEN.UpdDate = null; //修改日期
if (objvPrjConstraintEN.UpdUser == "[null]") objvPrjConstraintEN.UpdUser = null; //修改者
if (objvPrjConstraintEN.Memo == "[null]") objvPrjConstraintEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvPrjConstraintEN objvPrjConstraintEN)
{
 vPrjConstraintDA.CheckProperty4Condition(objvPrjConstraintEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_PrjConstraintId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjConstraint.PrjConstraintId); 
List<clsvPrjConstraintEN> arrObjLst = clsvPrjConstraintBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN()
{
PrjConstraintId = "0",
ConstraintName = "选[v约束]..."
};
arrObjLstSel.Insert(0, objvPrjConstraintEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjConstraint.PrjConstraintId;
objComboBox.DisplayMember = convPrjConstraint.ConstraintName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_PrjConstraintId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjConstraint.PrjConstraintId); 
IEnumerable<clsvPrjConstraintEN> arrObjLst = clsvPrjConstraintBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convPrjConstraint.PrjConstraintId;
objDDL.DataTextField = convPrjConstraint.ConstraintName;
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
public static void BindDdl_PrjConstraintIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v约束]...","0");
List<clsvPrjConstraintEN> arrvPrjConstraintObjLst = GetAllvPrjConstraintObjLstCache(strPrjId); 
objDDL.DataValueField = convPrjConstraint.PrjConstraintId;
objDDL.DataTextField = convPrjConstraint.ConstraintName;
objDDL.DataSource = arrvPrjConstraintObjLst;
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by PrjConstraintId");
//if (arrvPrjConstraintObjLstCache == null)
//{
//arrvPrjConstraintObjLstCache = vPrjConstraintDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjConstraintEN GetObjByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjConstraintEN._CurrTabName, strPrjId);
List<clsvPrjConstraintEN> arrvPrjConstraintObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjConstraintEN> arrvPrjConstraintObjLst_Sel =
arrvPrjConstraintObjLstCache
.Where(x=> x.PrjConstraintId == strPrjConstraintId 
);
if (arrvPrjConstraintObjLst_Sel.Count() == 0)
{
   clsvPrjConstraintEN obj = clsvPrjConstraintBL.GetObjByPrjConstraintId(strPrjConstraintId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPrjConstraintId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjConstraintObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsvPrjConstraintEN objvPrjConstraint = GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objvPrjConstraint == null) return "";
return objvPrjConstraint.ConstraintName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsvPrjConstraintEN objvPrjConstraint = GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objvPrjConstraint == null) return "";
return objvPrjConstraint.ConstraintName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjConstraintEN> GetAllvPrjConstraintObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjConstraintEN> arrvPrjConstraintObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjConstraintObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjConstraintEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjConstraintEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjConstraintEN> arrvPrjConstraintObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjConstraintObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvPrjConstraintEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjConstraintEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjConstraintEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjConstraintEN._RefreshTimeLst[clsvPrjConstraintEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strPrjConstraintId, string strPrjId)
{
if (strInFldName != convPrjConstraint.PrjConstraintId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjConstraint._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjConstraint._AttributeName));
throw new Exception(strMsg);
}
var objvPrjConstraint = clsvPrjConstraintBL.GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objvPrjConstraint == null) return "";
return objvPrjConstraint[strOutFldName].ToString();
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
int intRecCount = clsvPrjConstraintDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjConstraintDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjConstraintDA.GetRecCount();
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
int intRecCount = clsvPrjConstraintDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjConstraintCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjConstraintEN objvPrjConstraintCond)
{
 string strPrjId = objvPrjConstraintCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjConstraintBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjConstraintEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjConstraintEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjConstraint._AttributeName)
{
if (objvPrjConstraintCond.IsUpdated(strFldName) == false) continue;
if (objvPrjConstraintCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraintCond[strFldName].ToString());
}
else
{
if (objvPrjConstraintCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjConstraintCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjConstraintCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjConstraintCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjConstraintCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjConstraintCond[strFldName]));
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
 List<string> arrList = clsvPrjConstraintDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjConstraintDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjConstraintDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}