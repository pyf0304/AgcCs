
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFieldRelaWApi
 表名:vTabFieldRela(00050267)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:01
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
public static class  clsvTabFieldRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngIdFieldTabRela">字段表关系流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIdFieldTabRela(this clsvTabFieldRelaEN objvTabFieldRelaEN, long lngIdFieldTabRela, string strComparisonOp="")
	{
objvTabFieldRelaEN.IdFieldTabRela = lngIdFieldTabRela; //字段表关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IdFieldTabRela) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IdFieldTabRela, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IdFieldTabRela] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFieldRela.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFieldRela.TabId);
objvTabFieldRelaEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TabId) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TabId, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TabId] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFieldRela.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFieldRela.FldId);
objvTabFieldRelaEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.FldId) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.FldId, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.FldId] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldName, 50, convTabFieldRela.FldName);
objvTabFieldRelaEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.FldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.FldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.FldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetCaption(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaption, 200, convTabFieldRela.Caption);
objvTabFieldRelaEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.Caption) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.Caption, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.Caption] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlFldName">Sql字段名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetSqlFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strSqlFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlFldName, 100, convTabFieldRela.SqlFldName);
objvTabFieldRelaEN.SqlFldName = strSqlFldName; //Sql字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.SqlFldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.SqlFldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.SqlFldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strExcelFieldName">Excel字段名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetExcelFieldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strExcelFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcelFieldName, 100, convTabFieldRela.ExcelFieldName);
objvTabFieldRelaEN.ExcelFieldName = strExcelFieldName; //Excel字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.ExcelFieldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.ExcelFieldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.ExcelFieldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTrans">是否需要转换</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsNeedTrans(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsNeedTrans, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsNeedTrans = bolIsNeedTrans; //是否需要转换
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsNeedTrans) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsNeedTrans, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsNeedTrans] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransOutFldName">转换Out字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransOutFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransOutFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransOutFldName, 50, convTabFieldRela.TransOutFldName);
objvTabFieldRelaEN.TransOutFldName = strTransOutFldName; //转换Out字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransOutFldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransOutFldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransOutFldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransInFldName">转换IN字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransInFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransInFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransInFldName, 50, convTabFieldRela.TransInFldName);
objvTabFieldRelaEN.TransInFldName = strTransInFldName; //转换IN字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransInFldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransInFldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransInFldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryTypeId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convTabFieldRela.PrimaryTypeId);
objvTabFieldRelaEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrimaryTypeId) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrimaryTypeId, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrimaryTypeId] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryTypeName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convTabFieldRela.PrimaryTypeName);
objvTabFieldRelaEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrimaryTypeName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrimaryTypeName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrimaryTypeName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransTabName">转换表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransTabName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransTabName, 50, convTabFieldRela.TransTabName);
objvTabFieldRelaEN.TransTabName = strTransTabName; //转换表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransTabName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransTabName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransTabName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsIdentity(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsIdentity, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsIdentity) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsIdentity, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsIdentity] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsVisible(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsVisible) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsVisible, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsVisible] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabPrimary">是否作为表中主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsTabPrimary(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsTabPrimary, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsTabPrimary = bolIsTabPrimary; //是否作为表中主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsTabPrimary) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsTabPrimary, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsTabPrimary] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabNullable">是否表中可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsTabNullable(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsTabNullable, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsTabNullable) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsTabNullable, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsTabNullable] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabUnique">是否表中唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsTabUnique(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsTabUnique) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsTabUnique, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsTabUnique] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetDataTypeName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convTabFieldRela.DataTypeName);
objvTabFieldRelaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.DataTypeName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.DataTypeName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.DataTypeName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intSequenceNumber">顺序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetSequenceNumber(this clsvTabFieldRelaEN objvTabFieldRelaEN, int intSequenceNumber, string strComparisonOp="")
	{
objvTabFieldRelaEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.SequenceNumber) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.SequenceNumber, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.SequenceNumber] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedCheckPriForeignKey">是否检查主外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsNeedCheckPriForeignKey(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsNeedCheckPriForeignKey, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = bolIsNeedCheckPriForeignKey; //是否检查主外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsNeedCheckPriForeignKey) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsNeedCheckPriForeignKey, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsNeedCheckPriForeignKey] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabForeignKey">是否表外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetIsTabForeignKey(this clsvTabFieldRelaEN objvTabFieldRelaEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
objvTabFieldRelaEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.IsTabForeignKey) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.IsTabForeignKey, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.IsTabForeignKey] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyFieldName">主键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryKeyFieldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryKeyFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyFieldName, 50, convTabFieldRela.PrimaryKeyFieldName);
objvTabFieldRelaEN.PrimaryKeyFieldName = strPrimaryKeyFieldName; //主键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrimaryKeyFieldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrimaryKeyFieldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrimaryKeyFieldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyTabName">主键表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryKeyTabName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabName, 50, convTabFieldRela.PrimaryKeyTabName);
objvTabFieldRelaEN.PrimaryKeyTabName = strPrimaryKeyTabName; //主键表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrimaryKeyTabName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrimaryKeyTabName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrimaryKeyTabName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetDefaultValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFieldRela.DefaultValue);
objvTabFieldRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.DefaultValue) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.DefaultValue, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.DefaultValue] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransWayId">转换方式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransWayId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTransWayId, convTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(strTransWayId, 2, convTabFieldRela.TransWayId);
clsCheckSql.CheckFieldForeignKey(strTransWayId, 2, convTabFieldRela.TransWayId);
objvTabFieldRelaEN.TransWayId = strTransWayId; //转换方式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransWayId) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransWayId, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransWayId] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransWayName">转换方式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransWayName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransWayName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransWayName, 30, convTabFieldRela.TransWayName);
objvTabFieldRelaEN.TransWayName = strTransWayName; //转换方式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransWayName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransWayName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransWayName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldLength(this clsvTabFieldRelaEN objvTabFieldRelaEN, int intFldLength, string strComparisonOp="")
	{
objvTabFieldRelaEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.FldLength) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.FldLength, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.FldLength] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransMissingValue">转换失败值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransMissingValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransMissingValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransMissingValue, 50, convTabFieldRela.TransMissingValue);
objvTabFieldRelaEN.TransMissingValue = strTransMissingValue; //转换失败值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransMissingValue) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransMissingValue, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransMissingValue] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTransNullValue">转换空值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransNullValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransNullValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTransNullValue, 50, convTabFieldRela.TransNullValue);
objvTabFieldRelaEN.TransNullValue = strTransNullValue; //转换空值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TransNullValue) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TransNullValue, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TransNullValue] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrjName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFieldRela.PrjName);
objvTabFieldRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrjName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrjName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrjName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrjId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFieldRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFieldRela.PrjId);
objvTabFieldRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrjId) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrjId, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrjId] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefixFldName">前缀字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrefixFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrefixFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefixFldName, 100, convTabFieldRela.PrefixFldName);
objvTabFieldRelaEN.PrefixFldName = strPrefixFldName; //前缀字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.PrefixFldName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.PrefixFldName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.PrefixFldName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetKeyword(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convTabFieldRela.Keyword);
objvTabFieldRelaEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.Keyword) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.Keyword, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.Keyword] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabCnName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFieldRela.TabCnName);
objvTabFieldRelaEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TabCnName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TabCnName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TabCnName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabEnName">表英文详细名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabEnName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabEnName, 200, convTabFieldRela.TabEnName);
objvTabFieldRelaEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.TabEnName) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.TabEnName, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.TabEnName] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetMemo(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFieldRela.Memo);
objvTabFieldRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFieldRelaEN.dicFldComparisonOp.ContainsKey(convTabFieldRela.Memo) == false)
{
objvTabFieldRelaEN.dicFldComparisonOp.Add(convTabFieldRela.Memo, strComparisonOp);
}
else
{
objvTabFieldRelaEN.dicFldComparisonOp[convTabFieldRela.Memo] = strComparisonOp;
}
}
return objvTabFieldRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFieldRelaEN objvTabFieldRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IdFieldTabRela) == true)
{
string strComparisonOpIdFieldTabRela = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.IdFieldTabRela];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFieldRela.IdFieldTabRela, objvTabFieldRelaCond.IdFieldTabRela, strComparisonOpIdFieldTabRela);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TabId) == true)
{
string strComparisonOpTabId = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TabId, objvTabFieldRelaCond.TabId, strComparisonOpTabId);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.FldId) == true)
{
string strComparisonOpFldId = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.FldId, objvTabFieldRelaCond.FldId, strComparisonOpFldId);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.FldName) == true)
{
string strComparisonOpFldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.FldName, objvTabFieldRelaCond.FldName, strComparisonOpFldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.Caption) == true)
{
string strComparisonOpCaption = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.Caption, objvTabFieldRelaCond.Caption, strComparisonOpCaption);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.SqlFldName) == true)
{
string strComparisonOpSqlFldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.SqlFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.SqlFldName, objvTabFieldRelaCond.SqlFldName, strComparisonOpSqlFldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.ExcelFieldName) == true)
{
string strComparisonOpExcelFieldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.ExcelFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.ExcelFieldName, objvTabFieldRelaCond.ExcelFieldName, strComparisonOpExcelFieldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsNeedTrans) == true)
{
if (objvTabFieldRelaCond.IsNeedTrans == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsNeedTrans);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsNeedTrans);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransOutFldName) == true)
{
string strComparisonOpTransOutFldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransOutFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransOutFldName, objvTabFieldRelaCond.TransOutFldName, strComparisonOpTransOutFldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransInFldName) == true)
{
string strComparisonOpTransInFldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransInFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransInFldName, objvTabFieldRelaCond.TransInFldName, strComparisonOpTransInFldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrimaryTypeId, objvTabFieldRelaCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrimaryTypeName, objvTabFieldRelaCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransTabName) == true)
{
string strComparisonOpTransTabName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransTabName, objvTabFieldRelaCond.TransTabName, strComparisonOpTransTabName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsIdentity) == true)
{
if (objvTabFieldRelaCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsIdentity);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsVisible) == true)
{
if (objvTabFieldRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsVisible);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsTabPrimary) == true)
{
if (objvTabFieldRelaCond.IsTabPrimary == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsTabPrimary);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsTabPrimary);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsTabNullable) == true)
{
if (objvTabFieldRelaCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsTabNullable);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsTabUnique) == true)
{
if (objvTabFieldRelaCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsTabUnique);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.DataTypeName, objvTabFieldRelaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFieldRela.SequenceNumber, objvTabFieldRelaCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsNeedCheckPriForeignKey) == true)
{
if (objvTabFieldRelaCond.IsNeedCheckPriForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsNeedCheckPriForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsNeedCheckPriForeignKey);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.IsTabForeignKey) == true)
{
if (objvTabFieldRelaCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFieldRela.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFieldRela.IsTabForeignKey);
}
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrimaryKeyFieldName) == true)
{
string strComparisonOpPrimaryKeyFieldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrimaryKeyFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrimaryKeyFieldName, objvTabFieldRelaCond.PrimaryKeyFieldName, strComparisonOpPrimaryKeyFieldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrimaryKeyTabName) == true)
{
string strComparisonOpPrimaryKeyTabName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrimaryKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrimaryKeyTabName, objvTabFieldRelaCond.PrimaryKeyTabName, strComparisonOpPrimaryKeyTabName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.DefaultValue, objvTabFieldRelaCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransWayId) == true)
{
string strComparisonOpTransWayId = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransWayId, objvTabFieldRelaCond.TransWayId, strComparisonOpTransWayId);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransWayName) == true)
{
string strComparisonOpTransWayName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransWayName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransWayName, objvTabFieldRelaCond.TransWayName, strComparisonOpTransWayName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.FldLength) == true)
{
string strComparisonOpFldLength = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFieldRela.FldLength, objvTabFieldRelaCond.FldLength, strComparisonOpFldLength);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransMissingValue) == true)
{
string strComparisonOpTransMissingValue = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransMissingValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransMissingValue, objvTabFieldRelaCond.TransMissingValue, strComparisonOpTransMissingValue);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TransNullValue) == true)
{
string strComparisonOpTransNullValue = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TransNullValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TransNullValue, objvTabFieldRelaCond.TransNullValue, strComparisonOpTransNullValue);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrjName) == true)
{
string strComparisonOpPrjName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrjName, objvTabFieldRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrjId) == true)
{
string strComparisonOpPrjId = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrjId, objvTabFieldRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.PrefixFldName) == true)
{
string strComparisonOpPrefixFldName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.PrefixFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.PrefixFldName, objvTabFieldRelaCond.PrefixFldName, strComparisonOpPrefixFldName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.Keyword) == true)
{
string strComparisonOpKeyword = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.Keyword, objvTabFieldRelaCond.Keyword, strComparisonOpKeyword);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TabCnName) == true)
{
string strComparisonOpTabCnName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TabCnName, objvTabFieldRelaCond.TabCnName, strComparisonOpTabCnName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.TabEnName) == true)
{
string strComparisonOpTabEnName = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.TabEnName, objvTabFieldRelaCond.TabEnName, strComparisonOpTabEnName);
}
if (objvTabFieldRelaCond.IsUpdated(convTabFieldRela.Memo) == true)
{
string strComparisonOpMemo = objvTabFieldRelaCond.dicFldComparisonOp[convTabFieldRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFieldRela.Memo, objvTabFieldRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v表字段关系(vTabFieldRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFieldRelaWApi
{
private static readonly string mstrApiControllerName = "vTabFieldRelaApi";

 public clsvTabFieldRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
if (lngIdFieldTabRela == 0) return null;
string strAction = "GetObjByIdFieldTabRela";
clsvTabFieldRelaEN objvTabFieldRelaEN;
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
objvTabFieldRelaEN = JsonConvert.DeserializeObject<clsvTabFieldRelaEN>(strJson);
return objvTabFieldRelaEN;
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
public static clsvTabFieldRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFieldRelaEN objvTabFieldRelaEN;
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
objvTabFieldRelaEN = JsonConvert.DeserializeObject<clsvTabFieldRelaEN>(strJson);
return objvTabFieldRelaEN;
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
public static clsvTabFieldRelaEN GetObjByIdFieldTabRelaCache(long lngIdFieldTabRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrvTabFieldRelaObjLst_Sel =
from objvTabFieldRelaEN in arrvTabFieldRelaObjLstCache
where objvTabFieldRelaEN.IdFieldTabRela == lngIdFieldTabRela 
select objvTabFieldRelaEN;
if (arrvTabFieldRelaObjLst_Sel.Count() == 0)
{
   clsvTabFieldRelaEN obj = clsvTabFieldRelaWApi.GetObjByIdFieldTabRela(lngIdFieldTabRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFieldRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
public static List<clsvTabFieldRelaEN> GetObjLstByIdFieldTabRelaLst(List<long> arrIdFieldTabRela)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
public static IEnumerable<clsvTabFieldRelaEN> GetObjLstByIdFieldTabRelaLstCache(List<long> arrIdFieldTabRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrvTabFieldRelaObjLst_Sel =
from objvTabFieldRelaEN in arrvTabFieldRelaObjLstCache
where arrIdFieldTabRela.Contains(objvTabFieldRelaEN.IdFieldTabRela)
select objvTabFieldRelaEN;
return arrvTabFieldRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFieldRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
public static List<clsvTabFieldRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
public static List<clsvTabFieldRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
public static List<clsvTabFieldRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFieldRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFieldRelaEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvTabFieldRelaENS">源对象</param>
 /// <param name = "objvTabFieldRelaENT">目标对象</param>
 public static void CopyTo(clsvTabFieldRelaEN objvTabFieldRelaENS, clsvTabFieldRelaEN objvTabFieldRelaENT)
{
try
{
objvTabFieldRelaENT.IdFieldTabRela = objvTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objvTabFieldRelaENT.TabId = objvTabFieldRelaENS.TabId; //表ID
objvTabFieldRelaENT.FldId = objvTabFieldRelaENS.FldId; //字段Id
objvTabFieldRelaENT.FldName = objvTabFieldRelaENS.FldName; //字段名
objvTabFieldRelaENT.Caption = objvTabFieldRelaENS.Caption; //标题
objvTabFieldRelaENT.SqlFldName = objvTabFieldRelaENS.SqlFldName; //Sql字段名称
objvTabFieldRelaENT.ExcelFieldName = objvTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objvTabFieldRelaENT.IsNeedTrans = objvTabFieldRelaENS.IsNeedTrans; //是否需要转换
objvTabFieldRelaENT.TransOutFldName = objvTabFieldRelaENS.TransOutFldName; //转换Out字段名
objvTabFieldRelaENT.TransInFldName = objvTabFieldRelaENS.TransInFldName; //转换IN字段名
objvTabFieldRelaENT.PrimaryTypeId = objvTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objvTabFieldRelaENT.PrimaryTypeName = objvTabFieldRelaENS.PrimaryTypeName; //主键类型名
objvTabFieldRelaENT.TransTabName = objvTabFieldRelaENS.TransTabName; //转换表名
objvTabFieldRelaENT.IsIdentity = objvTabFieldRelaENS.IsIdentity; //是否Identity
objvTabFieldRelaENT.IsVisible = objvTabFieldRelaENS.IsVisible; //是否显示
objvTabFieldRelaENT.IsTabPrimary = objvTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objvTabFieldRelaENT.IsTabNullable = objvTabFieldRelaENS.IsTabNullable; //是否表中可空
objvTabFieldRelaENT.IsTabUnique = objvTabFieldRelaENS.IsTabUnique; //是否表中唯一
objvTabFieldRelaENT.DataTypeName = objvTabFieldRelaENS.DataTypeName; //数据类型名称
objvTabFieldRelaENT.SequenceNumber = objvTabFieldRelaENS.SequenceNumber; //顺序号
objvTabFieldRelaENT.IsNeedCheckPriForeignKey = objvTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objvTabFieldRelaENT.IsTabForeignKey = objvTabFieldRelaENS.IsTabForeignKey; //是否表外键
objvTabFieldRelaENT.PrimaryKeyFieldName = objvTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objvTabFieldRelaENT.PrimaryKeyTabName = objvTabFieldRelaENS.PrimaryKeyTabName; //主键表
objvTabFieldRelaENT.DefaultValue = objvTabFieldRelaENS.DefaultValue; //缺省值
objvTabFieldRelaENT.TransWayId = objvTabFieldRelaENS.TransWayId; //转换方式ID
objvTabFieldRelaENT.TransWayName = objvTabFieldRelaENS.TransWayName; //转换方式名称
objvTabFieldRelaENT.FldLength = objvTabFieldRelaENS.FldLength; //字段长度
objvTabFieldRelaENT.TransMissingValue = objvTabFieldRelaENS.TransMissingValue; //转换失败值
objvTabFieldRelaENT.TransNullValue = objvTabFieldRelaENS.TransNullValue; //转换空值
objvTabFieldRelaENT.PrjName = objvTabFieldRelaENS.PrjName; //工程名称
objvTabFieldRelaENT.PrjId = objvTabFieldRelaENS.PrjId; //工程Id
objvTabFieldRelaENT.PrefixFldName = objvTabFieldRelaENS.PrefixFldName; //前缀字段名
objvTabFieldRelaENT.Keyword = objvTabFieldRelaENS.Keyword; //关键字
objvTabFieldRelaENT.TabCnName = objvTabFieldRelaENS.TabCnName; //表中文名
objvTabFieldRelaENT.TabEnName = objvTabFieldRelaENS.TabEnName; //表英文详细名
objvTabFieldRelaENT.Memo = objvTabFieldRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvTabFieldRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFieldRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFieldRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFieldRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFieldRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFieldRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
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
public static List<clsvTabFieldRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvTabFieldRelaEN._CurrTabName;
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFieldRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFieldRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFieldRela.IdFieldTabRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabFieldRela.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.SqlFldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.ExcelFieldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.IsNeedTrans, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.TransOutFldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TransInFldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TransTabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.IsTabPrimary, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.IsTabNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.IsTabUnique, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.SequenceNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFieldRela.IsNeedCheckPriForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.IsTabForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFieldRela.PrimaryKeyFieldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrimaryKeyTabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TransWayId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TransWayName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFieldRela.TransMissingValue, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TransNullValue, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.PrefixFldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.TabEnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFieldRela.Memo, Type.GetType("System.String"));
foreach (clsvTabFieldRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFieldRela.IdFieldTabRela] = objInFor[convTabFieldRela.IdFieldTabRela];
objDR[convTabFieldRela.TabId] = objInFor[convTabFieldRela.TabId];
objDR[convTabFieldRela.FldId] = objInFor[convTabFieldRela.FldId];
objDR[convTabFieldRela.FldName] = objInFor[convTabFieldRela.FldName];
objDR[convTabFieldRela.Caption] = objInFor[convTabFieldRela.Caption];
objDR[convTabFieldRela.SqlFldName] = objInFor[convTabFieldRela.SqlFldName];
objDR[convTabFieldRela.ExcelFieldName] = objInFor[convTabFieldRela.ExcelFieldName];
objDR[convTabFieldRela.IsNeedTrans] = objInFor[convTabFieldRela.IsNeedTrans];
objDR[convTabFieldRela.TransOutFldName] = objInFor[convTabFieldRela.TransOutFldName];
objDR[convTabFieldRela.TransInFldName] = objInFor[convTabFieldRela.TransInFldName];
objDR[convTabFieldRela.PrimaryTypeId] = objInFor[convTabFieldRela.PrimaryTypeId];
objDR[convTabFieldRela.PrimaryTypeName] = objInFor[convTabFieldRela.PrimaryTypeName];
objDR[convTabFieldRela.TransTabName] = objInFor[convTabFieldRela.TransTabName];
objDR[convTabFieldRela.IsIdentity] = objInFor[convTabFieldRela.IsIdentity];
objDR[convTabFieldRela.IsVisible] = objInFor[convTabFieldRela.IsVisible];
objDR[convTabFieldRela.IsTabPrimary] = objInFor[convTabFieldRela.IsTabPrimary];
objDR[convTabFieldRela.IsTabNullable] = objInFor[convTabFieldRela.IsTabNullable];
objDR[convTabFieldRela.IsTabUnique] = objInFor[convTabFieldRela.IsTabUnique];
objDR[convTabFieldRela.DataTypeName] = objInFor[convTabFieldRela.DataTypeName];
objDR[convTabFieldRela.SequenceNumber] = objInFor[convTabFieldRela.SequenceNumber];
objDR[convTabFieldRela.IsNeedCheckPriForeignKey] = objInFor[convTabFieldRela.IsNeedCheckPriForeignKey];
objDR[convTabFieldRela.IsTabForeignKey] = objInFor[convTabFieldRela.IsTabForeignKey];
objDR[convTabFieldRela.PrimaryKeyFieldName] = objInFor[convTabFieldRela.PrimaryKeyFieldName];
objDR[convTabFieldRela.PrimaryKeyTabName] = objInFor[convTabFieldRela.PrimaryKeyTabName];
objDR[convTabFieldRela.DefaultValue] = objInFor[convTabFieldRela.DefaultValue];
objDR[convTabFieldRela.TransWayId] = objInFor[convTabFieldRela.TransWayId];
objDR[convTabFieldRela.TransWayName] = objInFor[convTabFieldRela.TransWayName];
objDR[convTabFieldRela.FldLength] = objInFor[convTabFieldRela.FldLength];
objDR[convTabFieldRela.TransMissingValue] = objInFor[convTabFieldRela.TransMissingValue];
objDR[convTabFieldRela.TransNullValue] = objInFor[convTabFieldRela.TransNullValue];
objDR[convTabFieldRela.PrjName] = objInFor[convTabFieldRela.PrjName];
objDR[convTabFieldRela.PrjId] = objInFor[convTabFieldRela.PrjId];
objDR[convTabFieldRela.PrefixFldName] = objInFor[convTabFieldRela.PrefixFldName];
objDR[convTabFieldRela.Keyword] = objInFor[convTabFieldRela.Keyword];
objDR[convTabFieldRela.TabCnName] = objInFor[convTabFieldRela.TabCnName];
objDR[convTabFieldRela.TabEnName] = objInFor[convTabFieldRela.TabEnName];
objDR[convTabFieldRela.Memo] = objInFor[convTabFieldRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}