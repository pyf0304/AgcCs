
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFieldRelaWApi
 表名:TabFieldRela(00050266)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsTabFieldRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngIdFieldTabRela">字段表关系流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIdFieldTabRela(this clsTabFieldRelaEN objTabFieldRelaEN, long lngIdFieldTabRela, string strComparisonOp="")
	{
objTabFieldRelaEN.IdFieldTabRela = lngIdFieldTabRela; //字段表关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IdFieldTabRela) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IdFieldTabRela, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IdFieldTabRela] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFldId(this clsTabFieldRelaEN objTabFieldRelaEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, conTabFieldRela.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conTabFieldRela.FldId);
objTabFieldRelaEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FldId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FldId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FldId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTabId(this clsTabFieldRelaEN objTabFieldRelaEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conTabFieldRela.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabFieldRela.TabId);
objTabFieldRelaEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TabId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TabId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TabId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlFldName">Sql字段名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetSqlFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strSqlFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlFldName, 100, conTabFieldRela.SqlFldName);
objTabFieldRelaEN.SqlFldName = strSqlFldName; //Sql字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.SqlFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.SqlFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.SqlFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strExcelFieldName">Excel字段名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetExcelFieldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strExcelFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcelFieldName, 100, conTabFieldRela.ExcelFieldName);
objTabFieldRelaEN.ExcelFieldName = strExcelFieldName; //Excel字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.ExcelFieldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.ExcelFieldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.ExcelFieldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetDefaultValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conTabFieldRela.DefaultValue);
objTabFieldRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.DefaultValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.DefaultValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.DefaultValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTrans">是否需要转换</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsNeedTrans(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedTrans, string strComparisonOp="")
	{
objTabFieldRelaEN.IsNeedTrans = bolIsNeedTrans; //是否需要转换
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsNeedTrans) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsNeedTrans, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsNeedTrans] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransWayId">转换方式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransWayId(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTransWayId, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(strTransWayId, 2, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldForeignKey(strTransWayId, 2, conTabFieldRela.TransWayId);
objTabFieldRelaEN.TransWayId = strTransWayId; //转换方式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransWayId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransWayId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransWayId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransTabName">转换表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransTabName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransTabName, 50, conTabFieldRela.TransTabName);
objTabFieldRelaEN.TransTabName = strTransTabName; //转换表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransTabName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransTabName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransTabName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransInFldName">转换IN字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransInFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransInFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransInFldName, 50, conTabFieldRela.TransInFldName);
objTabFieldRelaEN.TransInFldName = strTransInFldName; //转换IN字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransInFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransInFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransInFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransOutFldName">转换Out字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransOutFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransOutFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransOutFldName, 50, conTabFieldRela.TransOutFldName);
objTabFieldRelaEN.TransOutFldName = strTransOutFldName; //转换Out字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransOutFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransOutFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransOutFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabPrimary">是否作为表中主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabPrimary(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabPrimary, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabPrimary = bolIsTabPrimary; //是否作为表中主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabPrimary) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabPrimary, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabPrimary] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabForeignKey">是否表外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabForeignKey(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabForeignKey) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabForeignKey, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabForeignKey] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryTypeId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
objTabFieldRelaEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryTypeId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryTypeId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryTypeId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsIdentity(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsIdentity, string strComparisonOp="")
	{
objTabFieldRelaEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsIdentity) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsIdentity, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsIdentity] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabUnique">是否表中唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabUnique(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabUnique) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabUnique, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabUnique] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabNullable">是否表中可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabNullable(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabNullable, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabNullable) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabNullable, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabNullable] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFieldTypeId(this clsTabFieldRelaEN objTabFieldRelaEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conTabFieldRela.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conTabFieldRela.FieldTypeId);
objTabFieldRelaEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FieldTypeId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FieldTypeId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FieldTypeId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedCheckPriForeignKey">是否检查主外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsNeedCheckPriForeignKey(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckPriForeignKey, string strComparisonOp="")
	{
objTabFieldRelaEN.IsNeedCheckPriForeignKey = bolIsNeedCheckPriForeignKey; //是否检查主外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsNeedCheckPriForeignKey) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsNeedCheckPriForeignKey, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsNeedCheckPriForeignKey] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyTabName">主键表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryKeyTabName(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabName, 50, conTabFieldRela.PrimaryKeyTabName);
objTabFieldRelaEN.PrimaryKeyTabName = strPrimaryKeyTabName; //主键表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryKeyTabName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryKeyTabName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryKeyTabName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyFieldName">主键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryKeyFieldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryKeyFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyFieldName, 50, conTabFieldRela.PrimaryKeyFieldName);
objTabFieldRelaEN.PrimaryKeyFieldName = strPrimaryKeyFieldName; //主键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryKeyFieldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryKeyFieldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryKeyFieldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransMissingValue">转换失败值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransMissingValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransMissingValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransMissingValue, 50, conTabFieldRela.TransMissingValue);
objTabFieldRelaEN.TransMissingValue = strTransMissingValue; //转换失败值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransMissingValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransMissingValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransMissingValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransNullValue">转换空值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransNullValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransNullValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransNullValue, 50, conTabFieldRela.TransNullValue);
objTabFieldRelaEN.TransNullValue = strTransNullValue; //转换空值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransNullValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransNullValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransNullValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrjId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFieldRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFieldRela.PrjId);
objTabFieldRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrjId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrjId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrjId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsVisible(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objTabFieldRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsVisible) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsVisible, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsVisible] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intSequenceNumber">顺序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetSequenceNumber(this clsTabFieldRelaEN objTabFieldRelaEN, int intSequenceNumber, string strComparisonOp="")
	{
objTabFieldRelaEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.SequenceNumber) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.SequenceNumber, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.SequenceNumber] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetMemo(this clsTabFieldRelaEN objTabFieldRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFieldRela.Memo);
objTabFieldRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.Memo) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.Memo, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.Memo] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeIdS">FieldTypeId_S</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFieldTypeIdS(this clsTabFieldRelaEN objTabFieldRelaEN, string strFieldTypeIdS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
clsCheckSql.CheckFieldForeignKey(strFieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
objTabFieldRelaEN.FieldTypeIdS = strFieldTypeIdS; //FieldTypeId_S
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FieldTypeIdS) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FieldTypeIdS, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FieldTypeIdS] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLengthS">FldLength_S</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFldLengthS(this clsTabFieldRelaEN objTabFieldRelaEN, int intFldLengthS, string strComparisonOp="")
	{
objTabFieldRelaEN.FldLengthS = intFldLengthS; //FldLength_S
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FldLengthS) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FldLengthS, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FldLengthS] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyTabId">外键表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetForeignKeyTabId(this clsTabFieldRelaEN objTabFieldRelaEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
objTabFieldRelaEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.ForeignKeyTabId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.ForeignKeyTabId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.ForeignKeyTabId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intHashIndex">HASH表序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetHashIndex(this clsTabFieldRelaEN objTabFieldRelaEN, int intHashIndex, string strComparisonOp="")
	{
objTabFieldRelaEN.HashIndex = intHashIndex; //HASH表序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.HashIndex) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.HashIndex, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.HashIndex] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseHash">是否用HASH表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsUseHash(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsUseHash, string strComparisonOp="")
	{
objTabFieldRelaEN.IsUseHash = bolIsUseHash; //是否用HASH表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsUseHash) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsUseHash, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsUseHash] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefix">前缀</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrefix(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 10, conTabFieldRela.Prefix);
objTabFieldRelaEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.Prefix) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.Prefix, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.Prefix] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefixFldId">前缀字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrefixFldId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrefixFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefixFldId, 8, conTabFieldRela.PrefixFldId);
clsCheckSql.CheckFieldForeignKey(strPrefixFldId, 8, conTabFieldRela.PrefixFldId);
objTabFieldRelaEN.PrefixFldId = strPrefixFldId; //前缀字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrefixFldId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrefixFldId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrefixFldId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strvFieldCnName">视图字段中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetvFieldCnName(this clsTabFieldRelaEN objTabFieldRelaEN, string strvFieldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strvFieldCnName, 100, conTabFieldRela.vFieldCnName);
objTabFieldRelaEN.vFieldCnName = strvFieldCnName; //视图字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.vFieldCnName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.vFieldCnName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.vFieldCnName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFieldRelaEN objTabFieldRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IdFieldTabRela) == true)
{
string strComparisonOpIdFieldTabRela = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.IdFieldTabRela];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.IdFieldTabRela, objTabFieldRelaCond.IdFieldTabRela, strComparisonOpIdFieldTabRela);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FldId) == true)
{
string strComparisonOpFldId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FldId, objTabFieldRelaCond.FldId, strComparisonOpFldId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TabId) == true)
{
string strComparisonOpTabId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TabId, objTabFieldRelaCond.TabId, strComparisonOpTabId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.SqlFldName) == true)
{
string strComparisonOpSqlFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.SqlFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.SqlFldName, objTabFieldRelaCond.SqlFldName, strComparisonOpSqlFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.ExcelFieldName) == true)
{
string strComparisonOpExcelFieldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.ExcelFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.ExcelFieldName, objTabFieldRelaCond.ExcelFieldName, strComparisonOpExcelFieldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.DefaultValue, objTabFieldRelaCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsNeedTrans) == true)
{
if (objTabFieldRelaCond.IsNeedTrans == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsNeedTrans);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsNeedTrans);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransWayId) == true)
{
string strComparisonOpTransWayId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransWayId, objTabFieldRelaCond.TransWayId, strComparisonOpTransWayId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransTabName) == true)
{
string strComparisonOpTransTabName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransTabName, objTabFieldRelaCond.TransTabName, strComparisonOpTransTabName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransInFldName) == true)
{
string strComparisonOpTransInFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransInFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransInFldName, objTabFieldRelaCond.TransInFldName, strComparisonOpTransInFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransOutFldName) == true)
{
string strComparisonOpTransOutFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransOutFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransOutFldName, objTabFieldRelaCond.TransOutFldName, strComparisonOpTransOutFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabPrimary) == true)
{
if (objTabFieldRelaCond.IsTabPrimary == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabPrimary);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabPrimary);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabForeignKey) == true)
{
if (objTabFieldRelaCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabForeignKey);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryTypeId, objTabFieldRelaCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsIdentity) == true)
{
if (objTabFieldRelaCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsIdentity);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabUnique) == true)
{
if (objTabFieldRelaCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabUnique);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabNullable) == true)
{
if (objTabFieldRelaCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabNullable);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FieldTypeId, objTabFieldRelaCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey) == true)
{
if (objTabFieldRelaCond.IsNeedCheckPriForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsNeedCheckPriForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsNeedCheckPriForeignKey);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryKeyTabName) == true)
{
string strComparisonOpPrimaryKeyTabName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryKeyTabName, objTabFieldRelaCond.PrimaryKeyTabName, strComparisonOpPrimaryKeyTabName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryKeyFieldName) == true)
{
string strComparisonOpPrimaryKeyFieldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryKeyFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryKeyFieldName, objTabFieldRelaCond.PrimaryKeyFieldName, strComparisonOpPrimaryKeyFieldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransMissingValue) == true)
{
string strComparisonOpTransMissingValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransMissingValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransMissingValue, objTabFieldRelaCond.TransMissingValue, strComparisonOpTransMissingValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransNullValue) == true)
{
string strComparisonOpTransNullValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransNullValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransNullValue, objTabFieldRelaCond.TransNullValue, strComparisonOpTransNullValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrjId) == true)
{
string strComparisonOpPrjId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrjId, objTabFieldRelaCond.PrjId, strComparisonOpPrjId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsVisible) == true)
{
if (objTabFieldRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsVisible);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.SequenceNumber, objTabFieldRelaCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.Memo) == true)
{
string strComparisonOpMemo = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.Memo, objTabFieldRelaCond.Memo, strComparisonOpMemo);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FieldTypeIdS) == true)
{
string strComparisonOpFieldTypeIdS = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FieldTypeIdS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FieldTypeIdS, objTabFieldRelaCond.FieldTypeIdS, strComparisonOpFieldTypeIdS);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FldLengthS) == true)
{
string strComparisonOpFldLengthS = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FldLengthS];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.FldLengthS, objTabFieldRelaCond.FldLengthS, strComparisonOpFldLengthS);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.ForeignKeyTabId, objTabFieldRelaCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.HashIndex) == true)
{
string strComparisonOpHashIndex = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.HashIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.HashIndex, objTabFieldRelaCond.HashIndex, strComparisonOpHashIndex);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsUseHash) == true)
{
if (objTabFieldRelaCond.IsUseHash == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsUseHash);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsUseHash);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.Prefix) == true)
{
string strComparisonOpPrefix = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.Prefix, objTabFieldRelaCond.Prefix, strComparisonOpPrefix);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrefixFldId) == true)
{
string strComparisonOpPrefixFldId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrefixFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrefixFldId, objTabFieldRelaCond.PrefixFldId, strComparisonOpPrefixFldId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.vFieldCnName) == true)
{
string strComparisonOpvFieldCnName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.vFieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.vFieldCnName, objTabFieldRelaCond.vFieldCnName, strComparisonOpvFieldCnName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN.IdFieldTabRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabFieldRelaEN.sfUpdFldSetStr = objTabFieldRelaEN.getsfUpdFldSetStr();
clsTabFieldRelaWApi.CheckPropertyNew(objTabFieldRelaEN); 
bool bolResult = clsTabFieldRelaWApi.UpdateRecord(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaWApi.ReFreshCache();
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
 /// 获取唯一性条件串--TabFieldRela(表字段关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldId_TabId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTabFieldRelaEN objTabFieldRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFieldRelaEN == null) return "";
if (objTabFieldRelaEN.IdFieldTabRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdFieldTabRela !=  {0}", objTabFieldRelaEN.IdFieldTabRela);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFieldRelaEN objTabFieldRelaEN)
{
try
{
clsTabFieldRelaWApi.CheckPropertyNew(objTabFieldRelaEN); 
bool bolResult = clsTabFieldRelaWApi.AddNewRecord(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFieldRelaEN objTabFieldRelaEN, string strWhereCond)
{
try
{
clsTabFieldRelaWApi.CheckPropertyNew(objTabFieldRelaEN); 
bool bolResult = clsTabFieldRelaWApi.UpdateWithCondition(objTabFieldRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaWApi.ReFreshCache();
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
 /// 表字段关系(TabFieldRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabFieldRelaWApi
{
private static readonly string mstrApiControllerName = "TabFieldRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsTabFieldRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabFieldRelaEN objTabFieldRelaEN)
{
if (!Object.Equals(null, objTabFieldRelaEN.FldId) && GetStrLen(objTabFieldRelaEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TabId) && GetStrLen(objTabFieldRelaEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFieldRelaEN.SqlFldName) && GetStrLen(objTabFieldRelaEN.SqlFldName) > 100)
{
 throw new Exception("字段[Sql字段名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFieldRelaEN.ExcelFieldName) && GetStrLen(objTabFieldRelaEN.ExcelFieldName) > 100)
{
 throw new Exception("字段[Excel字段名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFieldRelaEN.DefaultValue) && GetStrLen(objTabFieldRelaEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransWayId) && GetStrLen(objTabFieldRelaEN.TransWayId) > 2)
{
 throw new Exception("字段[转换方式ID]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransTabName) && GetStrLen(objTabFieldRelaEN.TransTabName) > 50)
{
 throw new Exception("字段[转换表名]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransInFldName) && GetStrLen(objTabFieldRelaEN.TransInFldName) > 50)
{
 throw new Exception("字段[转换IN字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransOutFldName) && GetStrLen(objTabFieldRelaEN.TransOutFldName) > 50)
{
 throw new Exception("字段[转换Out字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.PrimaryTypeId) && GetStrLen(objTabFieldRelaEN.PrimaryTypeId) > 2)
{
 throw new Exception("字段[主键类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFieldRelaEN.FieldTypeId) && GetStrLen(objTabFieldRelaEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFieldRelaEN.PrimaryKeyTabName) && GetStrLen(objTabFieldRelaEN.PrimaryKeyTabName) > 50)
{
 throw new Exception("字段[主键表]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.PrimaryKeyFieldName) && GetStrLen(objTabFieldRelaEN.PrimaryKeyFieldName) > 50)
{
 throw new Exception("字段[主键字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransMissingValue) && GetStrLen(objTabFieldRelaEN.TransMissingValue) > 50)
{
 throw new Exception("字段[转换失败值]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.TransNullValue) && GetStrLen(objTabFieldRelaEN.TransNullValue) > 50)
{
 throw new Exception("字段[转换空值]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFieldRelaEN.PrjId) && GetStrLen(objTabFieldRelaEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabFieldRelaEN.Memo) && GetStrLen(objTabFieldRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objTabFieldRelaEN.FieldTypeIdS) && GetStrLen(objTabFieldRelaEN.FieldTypeIdS) > 2)
{
 throw new Exception("字段[FieldTypeId_S]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFieldRelaEN.ForeignKeyTabId) && GetStrLen(objTabFieldRelaEN.ForeignKeyTabId) > 8)
{
 throw new Exception("字段[外键表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFieldRelaEN.Prefix) && GetStrLen(objTabFieldRelaEN.Prefix) > 10)
{
 throw new Exception("字段[前缀]的长度不能超过10!");
}
if (!Object.Equals(null, objTabFieldRelaEN.PrefixFldId) && GetStrLen(objTabFieldRelaEN.PrefixFldId) > 8)
{
 throw new Exception("字段[前缀字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFieldRelaEN.vFieldCnName) && GetStrLen(objTabFieldRelaEN.vFieldCnName) > 100)
{
 throw new Exception("字段[视图字段中文名称]的长度不能超过100!");
}
 objTabFieldRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
if (lngIdFieldTabRela == 0) return null;
string strAction = "GetObjByIdFieldTabRela";
clsTabFieldRelaEN objTabFieldRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngIdFieldTabRela"] = lngIdFieldTabRela.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objTabFieldRelaEN = JsonConvert.DeserializeObject<clsTabFieldRelaEN>(strJson);
return objTabFieldRelaEN;
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
public static clsTabFieldRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabFieldRelaEN objTabFieldRelaEN;
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
objTabFieldRelaEN = JsonConvert.DeserializeObject<clsTabFieldRelaEN>(strJson);
return objTabFieldRelaEN;
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
 /// <param name = "lngIdFieldTabRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFieldRelaEN GetObjByIdFieldTabRelaCache(long lngIdFieldTabRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrTabFieldRelaObjLst_Sel =
from objTabFieldRelaEN in arrTabFieldRelaObjLstCache
where objTabFieldRelaEN.IdFieldTabRela == lngIdFieldTabRela 
select objTabFieldRelaEN;
if (arrTabFieldRelaObjLst_Sel.Count() == 0)
{
   clsTabFieldRelaEN obj = clsTabFieldRelaWApi.GetObjByIdFieldTabRela(lngIdFieldTabRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabFieldRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLst(string strWhereCond)
{
 List<clsTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
 /// <param name = "arrIdFieldTabRela">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstByIdFieldTabRelaLst(List<long> arrIdFieldTabRela)
{
 List<clsTabFieldRelaEN> arrObjLst; 
string strAction = "GetObjLstByIdFieldTabRelaLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdFieldTabRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
 /// <param name = "arrIdFieldTabRela">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsTabFieldRelaEN> GetObjLstByIdFieldTabRelaLstCache(List<long> arrIdFieldTabRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrTabFieldRelaObjLst_Sel =
from objTabFieldRelaEN in arrTabFieldRelaObjLstCache
where arrIdFieldTabRela.Contains(objTabFieldRelaEN.IdFieldTabRela)
select objTabFieldRelaEN;
return arrTabFieldRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
public static List<clsTabFieldRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
public static List<clsTabFieldRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
public static List<clsTabFieldRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFieldRelaEN>>(strJson);
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
public static int DelRecord(long lngIdFieldTabRela)
{
string strAction = "DelRecord";
try
{
 clsTabFieldRelaEN objTabFieldRelaEN = clsTabFieldRelaWApi.GetObjByIdFieldTabRela(lngIdFieldTabRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngIdFieldTabRela.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabFieldRelaWApi.ReFreshCache();
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
public static int DelTabFieldRelas(List<string> arrIdFieldTabRela)
{
string strAction = "DelTabFieldRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdFieldTabRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabFieldRelaWApi.ReFreshCache();
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
public static int DelTabFieldRelasByCond(string strWhereCond)
{
string strAction = "DelTabFieldRelasByCond";
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
public static bool AddNewRecord(clsTabFieldRelaEN objTabFieldRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFieldRelaEN>(objTabFieldRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsTabFieldRelaEN objTabFieldRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFieldRelaEN>(objTabFieldRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsTabFieldRelaEN objTabFieldRelaEN)
{
if (string.IsNullOrEmpty(objTabFieldRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFieldRelaEN.IdFieldTabRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFieldRelaEN>(objTabFieldRelaEN);
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
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabFieldRelaEN objTabFieldRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabFieldRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFieldRelaEN.IdFieldTabRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFieldRelaEN.IdFieldTabRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFieldRelaEN>(objTabFieldRelaEN);
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
public static bool IsExist(long lngIdFieldTabRela)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngIdFieldTabRela"] = lngIdFieldTabRela.ToString()
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
 /// <param name = "objTabFieldRelaENS">源对象</param>
 /// <param name = "objTabFieldRelaENT">目标对象</param>
 public static void CopyTo(clsTabFieldRelaEN objTabFieldRelaENS, clsTabFieldRelaEN objTabFieldRelaENT)
{
try
{
objTabFieldRelaENT.IdFieldTabRela = objTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objTabFieldRelaENT.FldId = objTabFieldRelaENS.FldId; //字段Id
objTabFieldRelaENT.TabId = objTabFieldRelaENS.TabId; //表ID
objTabFieldRelaENT.SqlFldName = objTabFieldRelaENS.SqlFldName; //Sql字段名称
objTabFieldRelaENT.ExcelFieldName = objTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objTabFieldRelaENT.DefaultValue = objTabFieldRelaENS.DefaultValue; //缺省值
objTabFieldRelaENT.IsNeedTrans = objTabFieldRelaENS.IsNeedTrans; //是否需要转换
objTabFieldRelaENT.TransWayId = objTabFieldRelaENS.TransWayId; //转换方式ID
objTabFieldRelaENT.TransTabName = objTabFieldRelaENS.TransTabName; //转换表名
objTabFieldRelaENT.TransInFldName = objTabFieldRelaENS.TransInFldName; //转换IN字段名
objTabFieldRelaENT.TransOutFldName = objTabFieldRelaENS.TransOutFldName; //转换Out字段名
objTabFieldRelaENT.IsTabPrimary = objTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objTabFieldRelaENT.IsTabForeignKey = objTabFieldRelaENS.IsTabForeignKey; //是否表外键
objTabFieldRelaENT.PrimaryTypeId = objTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objTabFieldRelaENT.IsIdentity = objTabFieldRelaENS.IsIdentity; //是否Identity
objTabFieldRelaENT.IsTabUnique = objTabFieldRelaENS.IsTabUnique; //是否表中唯一
objTabFieldRelaENT.IsTabNullable = objTabFieldRelaENS.IsTabNullable; //是否表中可空
objTabFieldRelaENT.FieldTypeId = objTabFieldRelaENS.FieldTypeId; //字段类型Id
objTabFieldRelaENT.IsNeedCheckPriForeignKey = objTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objTabFieldRelaENT.PrimaryKeyTabName = objTabFieldRelaENS.PrimaryKeyTabName; //主键表
objTabFieldRelaENT.PrimaryKeyFieldName = objTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objTabFieldRelaENT.TransMissingValue = objTabFieldRelaENS.TransMissingValue; //转换失败值
objTabFieldRelaENT.TransNullValue = objTabFieldRelaENS.TransNullValue; //转换空值
objTabFieldRelaENT.PrjId = objTabFieldRelaENS.PrjId; //工程Id
objTabFieldRelaENT.IsVisible = objTabFieldRelaENS.IsVisible; //是否显示
objTabFieldRelaENT.SequenceNumber = objTabFieldRelaENS.SequenceNumber; //顺序号
objTabFieldRelaENT.Memo = objTabFieldRelaENS.Memo; //说明
objTabFieldRelaENT.FieldTypeIdS = objTabFieldRelaENS.FieldTypeIdS; //FieldTypeId_S
objTabFieldRelaENT.FldLengthS = objTabFieldRelaENS.FldLengthS; //FldLength_S
objTabFieldRelaENT.ForeignKeyTabId = objTabFieldRelaENS.ForeignKeyTabId; //外键表ID
objTabFieldRelaENT.HashIndex = objTabFieldRelaENS.HashIndex; //HASH表序号
objTabFieldRelaENT.IsUseHash = objTabFieldRelaENS.IsUseHash; //是否用HASH表
objTabFieldRelaENT.Prefix = objTabFieldRelaENS.Prefix; //前缀
objTabFieldRelaENT.PrefixFldId = objTabFieldRelaENS.PrefixFldId; //前缀字段Id
objTabFieldRelaENT.vFieldCnName = objTabFieldRelaENS.vFieldCnName; //视图字段中文名称
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
public static DataTable ToDataTable(List<clsTabFieldRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabFieldRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabFieldRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabFieldRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabFieldRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabFieldRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
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
if (clsTabFieldRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabFieldRelaWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsTabFieldRelaEN._CurrTabName;
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabFieldRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabFieldRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabFieldRela.IdFieldTabRela, Type.GetType("System.Int64"));
objDT.Columns.Add(conTabFieldRela.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.SqlFldName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.ExcelFieldName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.IsNeedTrans, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.TransWayId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TransTabName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TransInFldName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TransOutFldName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.IsTabPrimary, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.IsTabForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.IsTabUnique, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.IsTabNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.IsNeedCheckPriForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.PrimaryKeyTabName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.PrimaryKeyFieldName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TransMissingValue, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.TransNullValue, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.SequenceNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFieldRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.FieldTypeIdS, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.FldLengthS, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFieldRela.ForeignKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.HashIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFieldRela.IsUseHash, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFieldRela.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.PrefixFldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFieldRela.vFieldCnName, Type.GetType("System.String"));
foreach (clsTabFieldRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabFieldRela.IdFieldTabRela] = objInFor[conTabFieldRela.IdFieldTabRela];
objDR[conTabFieldRela.FldId] = objInFor[conTabFieldRela.FldId];
objDR[conTabFieldRela.TabId] = objInFor[conTabFieldRela.TabId];
objDR[conTabFieldRela.SqlFldName] = objInFor[conTabFieldRela.SqlFldName];
objDR[conTabFieldRela.ExcelFieldName] = objInFor[conTabFieldRela.ExcelFieldName];
objDR[conTabFieldRela.DefaultValue] = objInFor[conTabFieldRela.DefaultValue];
objDR[conTabFieldRela.IsNeedTrans] = objInFor[conTabFieldRela.IsNeedTrans];
objDR[conTabFieldRela.TransWayId] = objInFor[conTabFieldRela.TransWayId];
objDR[conTabFieldRela.TransTabName] = objInFor[conTabFieldRela.TransTabName];
objDR[conTabFieldRela.TransInFldName] = objInFor[conTabFieldRela.TransInFldName];
objDR[conTabFieldRela.TransOutFldName] = objInFor[conTabFieldRela.TransOutFldName];
objDR[conTabFieldRela.IsTabPrimary] = objInFor[conTabFieldRela.IsTabPrimary];
objDR[conTabFieldRela.IsTabForeignKey] = objInFor[conTabFieldRela.IsTabForeignKey];
objDR[conTabFieldRela.PrimaryTypeId] = objInFor[conTabFieldRela.PrimaryTypeId];
objDR[conTabFieldRela.IsIdentity] = objInFor[conTabFieldRela.IsIdentity];
objDR[conTabFieldRela.IsTabUnique] = objInFor[conTabFieldRela.IsTabUnique];
objDR[conTabFieldRela.IsTabNullable] = objInFor[conTabFieldRela.IsTabNullable];
objDR[conTabFieldRela.FieldTypeId] = objInFor[conTabFieldRela.FieldTypeId];
objDR[conTabFieldRela.IsNeedCheckPriForeignKey] = objInFor[conTabFieldRela.IsNeedCheckPriForeignKey];
objDR[conTabFieldRela.PrimaryKeyTabName] = objInFor[conTabFieldRela.PrimaryKeyTabName];
objDR[conTabFieldRela.PrimaryKeyFieldName] = objInFor[conTabFieldRela.PrimaryKeyFieldName];
objDR[conTabFieldRela.TransMissingValue] = objInFor[conTabFieldRela.TransMissingValue];
objDR[conTabFieldRela.TransNullValue] = objInFor[conTabFieldRela.TransNullValue];
objDR[conTabFieldRela.PrjId] = objInFor[conTabFieldRela.PrjId];
objDR[conTabFieldRela.IsVisible] = objInFor[conTabFieldRela.IsVisible];
objDR[conTabFieldRela.SequenceNumber] = objInFor[conTabFieldRela.SequenceNumber];
objDR[conTabFieldRela.Memo] = objInFor[conTabFieldRela.Memo];
objDR[conTabFieldRela.FieldTypeIdS] = objInFor[conTabFieldRela.FieldTypeIdS];
objDR[conTabFieldRela.FldLengthS] = objInFor[conTabFieldRela.FldLengthS];
objDR[conTabFieldRela.ForeignKeyTabId] = objInFor[conTabFieldRela.ForeignKeyTabId];
objDR[conTabFieldRela.HashIndex] = objInFor[conTabFieldRela.HashIndex];
objDR[conTabFieldRela.IsUseHash] = objInFor[conTabFieldRela.IsUseHash];
objDR[conTabFieldRela.Prefix] = objInFor[conTabFieldRela.Prefix];
objDR[conTabFieldRela.PrefixFldId] = objInFor[conTabFieldRela.PrefixFldId];
objDR[conTabFieldRela.vFieldCnName] = objInFor[conTabFieldRela.vFieldCnName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表字段关系(TabFieldRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabFieldRela : clsCommFun4BL
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
clsTabFieldRelaWApi.ReFreshThisCache();
}
}

}