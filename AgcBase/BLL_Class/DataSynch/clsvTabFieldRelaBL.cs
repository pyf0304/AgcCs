
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFieldRelaBL
 表名:vTabFieldRela(00050267)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsvTabFieldRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFieldRelaEN GetObj(this K_IdFieldTabRela_vTabFieldRela myKey)
{
clsvTabFieldRelaEN objvTabFieldRelaEN = clsvTabFieldRelaBL.vTabFieldRelaDA.GetObjByIdFieldTabRela(myKey.Value);
return objvTabFieldRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFieldRela.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFieldRela.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFieldRela.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFieldRela.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFieldRela.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFieldRela.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convTabFieldRela.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetCaption(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convTabFieldRela.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetSqlFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strSqlFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlFldName, 100, convTabFieldRela.SqlFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetExcelFieldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strExcelFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcelFieldName, 100, convTabFieldRela.ExcelFieldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransOutFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransOutFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransOutFldName, 50, convTabFieldRela.TransOutFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransInFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransInFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransInFldName, 50, convTabFieldRela.TransInFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryTypeId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convTabFieldRela.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convTabFieldRela.PrimaryTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryTypeName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convTabFieldRela.PrimaryTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransTabName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransTabName, 50, convTabFieldRela.TransTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetDataTypeName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convTabFieldRela.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetSequenceNumber(this clsvTabFieldRelaEN objvTabFieldRelaEN, int? intSequenceNumber, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryKeyFieldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryKeyFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyFieldName, 50, convTabFieldRela.PrimaryKeyFieldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrimaryKeyTabName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrimaryKeyTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabName, 50, convTabFieldRela.PrimaryKeyTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetDefaultValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFieldRela.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransWayId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTransWayId, convTabFieldRela.TransWayId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransWayId, 2, convTabFieldRela.TransWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTransWayId, 2, convTabFieldRela.TransWayId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransWayName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransWayName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransWayName, 30, convTabFieldRela.TransWayName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetFldLength(this clsvTabFieldRelaEN objvTabFieldRelaEN, int? intFldLength, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransMissingValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransMissingValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransMissingValue, 50, convTabFieldRela.TransMissingValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTransNullValue(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTransNullValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransNullValue, 50, convTabFieldRela.TransNullValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrjName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFieldRela.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrjId(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabFieldRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFieldRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFieldRela.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetPrefixFldName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strPrefixFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefixFldName, 100, convTabFieldRela.PrefixFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetKeyword(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convTabFieldRela.Keyword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabCnName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFieldRela.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetTabEnName(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strTabEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabEnName, 200, convTabFieldRela.TabEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFieldRelaEN SetMemo(this clsvTabFieldRelaEN objvTabFieldRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFieldRela.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFieldRelaENS">源对象</param>
 /// <param name = "objvTabFieldRelaENT">目标对象</param>
 public static void CopyTo(this clsvTabFieldRelaEN objvTabFieldRelaENS, clsvTabFieldRelaEN objvTabFieldRelaENT)
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
 /// <param name = "objvTabFieldRelaENS">源对象</param>
 /// <returns>目标对象=>clsvTabFieldRelaEN:objvTabFieldRelaENT</returns>
 public static clsvTabFieldRelaEN CopyTo(this clsvTabFieldRelaEN objvTabFieldRelaENS)
{
try
{
 clsvTabFieldRelaEN objvTabFieldRelaENT = new clsvTabFieldRelaEN()
{
IdFieldTabRela = objvTabFieldRelaENS.IdFieldTabRela, //字段表关系流水号
TabId = objvTabFieldRelaENS.TabId, //表ID
FldId = objvTabFieldRelaENS.FldId, //字段Id
FldName = objvTabFieldRelaENS.FldName, //字段名
Caption = objvTabFieldRelaENS.Caption, //标题
SqlFldName = objvTabFieldRelaENS.SqlFldName, //Sql字段名称
ExcelFieldName = objvTabFieldRelaENS.ExcelFieldName, //Excel字段名称
IsNeedTrans = objvTabFieldRelaENS.IsNeedTrans, //是否需要转换
TransOutFldName = objvTabFieldRelaENS.TransOutFldName, //转换Out字段名
TransInFldName = objvTabFieldRelaENS.TransInFldName, //转换IN字段名
PrimaryTypeId = objvTabFieldRelaENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objvTabFieldRelaENS.PrimaryTypeName, //主键类型名
TransTabName = objvTabFieldRelaENS.TransTabName, //转换表名
IsIdentity = objvTabFieldRelaENS.IsIdentity, //是否Identity
IsVisible = objvTabFieldRelaENS.IsVisible, //是否显示
IsTabPrimary = objvTabFieldRelaENS.IsTabPrimary, //是否作为表中主键
IsTabNullable = objvTabFieldRelaENS.IsTabNullable, //是否表中可空
IsTabUnique = objvTabFieldRelaENS.IsTabUnique, //是否表中唯一
DataTypeName = objvTabFieldRelaENS.DataTypeName, //数据类型名称
SequenceNumber = objvTabFieldRelaENS.SequenceNumber, //顺序号
IsNeedCheckPriForeignKey = objvTabFieldRelaENS.IsNeedCheckPriForeignKey, //是否检查主外键
IsTabForeignKey = objvTabFieldRelaENS.IsTabForeignKey, //是否表外键
PrimaryKeyFieldName = objvTabFieldRelaENS.PrimaryKeyFieldName, //主键字段名
PrimaryKeyTabName = objvTabFieldRelaENS.PrimaryKeyTabName, //主键表
DefaultValue = objvTabFieldRelaENS.DefaultValue, //缺省值
TransWayId = objvTabFieldRelaENS.TransWayId, //转换方式ID
TransWayName = objvTabFieldRelaENS.TransWayName, //转换方式名称
FldLength = objvTabFieldRelaENS.FldLength, //字段长度
TransMissingValue = objvTabFieldRelaENS.TransMissingValue, //转换失败值
TransNullValue = objvTabFieldRelaENS.TransNullValue, //转换空值
PrjName = objvTabFieldRelaENS.PrjName, //工程名称
PrjId = objvTabFieldRelaENS.PrjId, //工程Id
PrefixFldName = objvTabFieldRelaENS.PrefixFldName, //前缀字段名
Keyword = objvTabFieldRelaENS.Keyword, //关键字
TabCnName = objvTabFieldRelaENS.TabCnName, //表中文名
TabEnName = objvTabFieldRelaENS.TabEnName, //表英文详细名
Memo = objvTabFieldRelaENS.Memo, //说明
};
 return objvTabFieldRelaENT;
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
public static void CheckProperty4Condition(this clsvTabFieldRelaEN objvTabFieldRelaEN)
{
 clsvTabFieldRelaBL.vTabFieldRelaDA.CheckProperty4Condition(objvTabFieldRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFieldRela
{
public virtual bool UpdRelaTabDate(long lngIdFieldTabRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表字段关系(vTabFieldRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFieldRelaBL
{
public static RelatedActions_vTabFieldRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFieldRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFieldRelaDA vTabFieldRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFieldRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFieldRelaBL()
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
if (string.IsNullOrEmpty(clsvTabFieldRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFieldRelaEN._ConnectString);
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
public static DataTable GetDataTable_vTabFieldRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFieldRelaDA.GetDataTable_vTabFieldRela(strWhereCond);
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
objDT = vTabFieldRelaDA.GetDataTable(strWhereCond);
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
objDT = vTabFieldRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabFieldRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabFieldRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabFieldRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vTabFieldRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabFieldRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabFieldRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdFieldTabRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLstByIdFieldTabRelaLst(List<long> arrIdFieldTabRelaLst)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdFieldTabRelaLst);
 string strWhereCond = string.Format("IdFieldTabRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdFieldTabRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFieldRelaEN> GetObjLstByIdFieldTabRelaLstCache(List<long> arrIdFieldTabRelaLst)
{
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrvTabFieldRelaObjLst_Sel =
arrvTabFieldRelaObjLstCache
.Where(x => arrIdFieldTabRelaLst.Contains(x.IdFieldTabRela));
return arrvTabFieldRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLst(string strWhereCond)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
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
public static List<clsvTabFieldRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFieldRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFieldRelaEN> GetSubObjLstCache(clsvTabFieldRelaEN objvTabFieldRelaCond)
{
List<clsvTabFieldRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFieldRela._AttributeName)
{
if (objvTabFieldRelaCond.IsUpdated(strFldName) == false) continue;
if (objvTabFieldRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFieldRelaCond[strFldName].ToString());
}
else
{
if (objvTabFieldRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFieldRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFieldRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFieldRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFieldRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFieldRelaCond[strFldName]));
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
public static List<clsvTabFieldRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
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
public static List<clsvTabFieldRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
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
List<clsvTabFieldRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabFieldRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFieldRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabFieldRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
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
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
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
public static List<clsvTabFieldRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabFieldRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
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
public static List<clsvTabFieldRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFieldRela(ref clsvTabFieldRelaEN objvTabFieldRelaEN)
{
bool bolResult = vTabFieldRelaDA.GetvTabFieldRela(ref objvTabFieldRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
clsvTabFieldRelaEN objvTabFieldRelaEN = vTabFieldRelaDA.GetObjByIdFieldTabRela(lngIdFieldTabRela);
return objvTabFieldRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFieldRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFieldRelaEN objvTabFieldRelaEN = vTabFieldRelaDA.GetFirstObj(strWhereCond);
 return objvTabFieldRelaEN;
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
public static clsvTabFieldRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFieldRelaEN objvTabFieldRelaEN = vTabFieldRelaDA.GetObjByDataRow(objRow);
 return objvTabFieldRelaEN;
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
public static clsvTabFieldRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFieldRelaEN objvTabFieldRelaEN = vTabFieldRelaDA.GetObjByDataRow(objRow);
 return objvTabFieldRelaEN;
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
 /// <param name = "lngIdFieldTabRela">所给的关键字</param>
 /// <param name = "lstvTabFieldRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFieldRelaEN GetObjByIdFieldTabRelaFromList(long lngIdFieldTabRela, List<clsvTabFieldRelaEN> lstvTabFieldRelaObjLst)
{
foreach (clsvTabFieldRelaEN objvTabFieldRelaEN in lstvTabFieldRelaObjLst)
{
if (objvTabFieldRelaEN.IdFieldTabRela == lngIdFieldTabRela)
{
return objvTabFieldRelaEN;
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
 long lngIdFieldTabRela;
 try
 {
 lngIdFieldTabRela = new clsvTabFieldRelaDA().GetFirstID(strWhereCond);
 return lngIdFieldTabRela;
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
 arrList = vTabFieldRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vTabFieldRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdFieldTabRela)
{
//检测记录是否存在
bool bolIsExist = vTabFieldRelaDA.IsExist(lngIdFieldTabRela);
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
 bolIsExist = clsvTabFieldRelaDA.IsExistTable();
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
 bolIsExist = vTabFieldRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvTabFieldRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFieldRelaEN objvTabFieldRelaEN)
{
try
{
objvTabFieldRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFieldRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFieldRela.IdFieldTabRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IdFieldTabRela = objvTabFieldRelaEN.IdFieldTabRela; //字段表关系流水号
}
if (arrFldSet.Contains(convTabFieldRela.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TabId = objvTabFieldRelaEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabFieldRela.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.FldId = objvTabFieldRelaEN.FldId; //字段Id
}
if (arrFldSet.Contains(convTabFieldRela.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.FldName = objvTabFieldRelaEN.FldName == "[null]" ? null :  objvTabFieldRelaEN.FldName; //字段名
}
if (arrFldSet.Contains(convTabFieldRela.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.Caption = objvTabFieldRelaEN.Caption == "[null]" ? null :  objvTabFieldRelaEN.Caption; //标题
}
if (arrFldSet.Contains(convTabFieldRela.SqlFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.SqlFldName = objvTabFieldRelaEN.SqlFldName == "[null]" ? null :  objvTabFieldRelaEN.SqlFldName; //Sql字段名称
}
if (arrFldSet.Contains(convTabFieldRela.ExcelFieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.ExcelFieldName = objvTabFieldRelaEN.ExcelFieldName == "[null]" ? null :  objvTabFieldRelaEN.ExcelFieldName; //Excel字段名称
}
if (arrFldSet.Contains(convTabFieldRela.IsNeedTrans, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsNeedTrans = objvTabFieldRelaEN.IsNeedTrans; //是否需要转换
}
if (arrFldSet.Contains(convTabFieldRela.TransOutFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransOutFldName = objvTabFieldRelaEN.TransOutFldName == "[null]" ? null :  objvTabFieldRelaEN.TransOutFldName; //转换Out字段名
}
if (arrFldSet.Contains(convTabFieldRela.TransInFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransInFldName = objvTabFieldRelaEN.TransInFldName == "[null]" ? null :  objvTabFieldRelaEN.TransInFldName; //转换IN字段名
}
if (arrFldSet.Contains(convTabFieldRela.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrimaryTypeId = objvTabFieldRelaEN.PrimaryTypeId == "[null]" ? null :  objvTabFieldRelaEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convTabFieldRela.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrimaryTypeName = objvTabFieldRelaEN.PrimaryTypeName == "[null]" ? null :  objvTabFieldRelaEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convTabFieldRela.TransTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransTabName = objvTabFieldRelaEN.TransTabName == "[null]" ? null :  objvTabFieldRelaEN.TransTabName; //转换表名
}
if (arrFldSet.Contains(convTabFieldRela.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsIdentity = objvTabFieldRelaEN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(convTabFieldRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsVisible = objvTabFieldRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTabFieldRela.IsTabPrimary, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsTabPrimary = objvTabFieldRelaEN.IsTabPrimary; //是否作为表中主键
}
if (arrFldSet.Contains(convTabFieldRela.IsTabNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsTabNullable = objvTabFieldRelaEN.IsTabNullable; //是否表中可空
}
if (arrFldSet.Contains(convTabFieldRela.IsTabUnique, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsTabUnique = objvTabFieldRelaEN.IsTabUnique; //是否表中唯一
}
if (arrFldSet.Contains(convTabFieldRela.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.DataTypeName = objvTabFieldRelaEN.DataTypeName == "[null]" ? null :  objvTabFieldRelaEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convTabFieldRela.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.SequenceNumber = objvTabFieldRelaEN.SequenceNumber; //顺序号
}
if (arrFldSet.Contains(convTabFieldRela.IsNeedCheckPriForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = objvTabFieldRelaEN.IsNeedCheckPriForeignKey; //是否检查主外键
}
if (arrFldSet.Contains(convTabFieldRela.IsTabForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.IsTabForeignKey = objvTabFieldRelaEN.IsTabForeignKey; //是否表外键
}
if (arrFldSet.Contains(convTabFieldRela.PrimaryKeyFieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrimaryKeyFieldName = objvTabFieldRelaEN.PrimaryKeyFieldName == "[null]" ? null :  objvTabFieldRelaEN.PrimaryKeyFieldName; //主键字段名
}
if (arrFldSet.Contains(convTabFieldRela.PrimaryKeyTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrimaryKeyTabName = objvTabFieldRelaEN.PrimaryKeyTabName == "[null]" ? null :  objvTabFieldRelaEN.PrimaryKeyTabName; //主键表
}
if (arrFldSet.Contains(convTabFieldRela.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.DefaultValue = objvTabFieldRelaEN.DefaultValue == "[null]" ? null :  objvTabFieldRelaEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convTabFieldRela.TransWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransWayId = objvTabFieldRelaEN.TransWayId; //转换方式ID
}
if (arrFldSet.Contains(convTabFieldRela.TransWayName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransWayName = objvTabFieldRelaEN.TransWayName == "[null]" ? null :  objvTabFieldRelaEN.TransWayName; //转换方式名称
}
if (arrFldSet.Contains(convTabFieldRela.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.FldLength = objvTabFieldRelaEN.FldLength; //字段长度
}
if (arrFldSet.Contains(convTabFieldRela.TransMissingValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransMissingValue = objvTabFieldRelaEN.TransMissingValue == "[null]" ? null :  objvTabFieldRelaEN.TransMissingValue; //转换失败值
}
if (arrFldSet.Contains(convTabFieldRela.TransNullValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TransNullValue = objvTabFieldRelaEN.TransNullValue == "[null]" ? null :  objvTabFieldRelaEN.TransNullValue; //转换空值
}
if (arrFldSet.Contains(convTabFieldRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrjName = objvTabFieldRelaEN.PrjName == "[null]" ? null :  objvTabFieldRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convTabFieldRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrjId = objvTabFieldRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabFieldRela.PrefixFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.PrefixFldName = objvTabFieldRelaEN.PrefixFldName == "[null]" ? null :  objvTabFieldRelaEN.PrefixFldName; //前缀字段名
}
if (arrFldSet.Contains(convTabFieldRela.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.Keyword = objvTabFieldRelaEN.Keyword == "[null]" ? null :  objvTabFieldRelaEN.Keyword; //关键字
}
if (arrFldSet.Contains(convTabFieldRela.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TabCnName = objvTabFieldRelaEN.TabCnName == "[null]" ? null :  objvTabFieldRelaEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convTabFieldRela.TabEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.TabEnName = objvTabFieldRelaEN.TabEnName == "[null]" ? null :  objvTabFieldRelaEN.TabEnName; //表英文详细名
}
if (arrFldSet.Contains(convTabFieldRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFieldRelaEN.Memo = objvTabFieldRelaEN.Memo == "[null]" ? null :  objvTabFieldRelaEN.Memo; //说明
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
 /// <param name = "objvTabFieldRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFieldRelaEN objvTabFieldRelaEN)
{
try
{
if (objvTabFieldRelaEN.FldName == "[null]") objvTabFieldRelaEN.FldName = null; //字段名
if (objvTabFieldRelaEN.Caption == "[null]") objvTabFieldRelaEN.Caption = null; //标题
if (objvTabFieldRelaEN.SqlFldName == "[null]") objvTabFieldRelaEN.SqlFldName = null; //Sql字段名称
if (objvTabFieldRelaEN.ExcelFieldName == "[null]") objvTabFieldRelaEN.ExcelFieldName = null; //Excel字段名称
if (objvTabFieldRelaEN.TransOutFldName == "[null]") objvTabFieldRelaEN.TransOutFldName = null; //转换Out字段名
if (objvTabFieldRelaEN.TransInFldName == "[null]") objvTabFieldRelaEN.TransInFldName = null; //转换IN字段名
if (objvTabFieldRelaEN.PrimaryTypeId == "[null]") objvTabFieldRelaEN.PrimaryTypeId = null; //主键类型ID
if (objvTabFieldRelaEN.PrimaryTypeName == "[null]") objvTabFieldRelaEN.PrimaryTypeName = null; //主键类型名
if (objvTabFieldRelaEN.TransTabName == "[null]") objvTabFieldRelaEN.TransTabName = null; //转换表名
if (objvTabFieldRelaEN.DataTypeName == "[null]") objvTabFieldRelaEN.DataTypeName = null; //数据类型名称
if (objvTabFieldRelaEN.PrimaryKeyFieldName == "[null]") objvTabFieldRelaEN.PrimaryKeyFieldName = null; //主键字段名
if (objvTabFieldRelaEN.PrimaryKeyTabName == "[null]") objvTabFieldRelaEN.PrimaryKeyTabName = null; //主键表
if (objvTabFieldRelaEN.DefaultValue == "[null]") objvTabFieldRelaEN.DefaultValue = null; //缺省值
if (objvTabFieldRelaEN.TransWayName == "[null]") objvTabFieldRelaEN.TransWayName = null; //转换方式名称
if (objvTabFieldRelaEN.TransMissingValue == "[null]") objvTabFieldRelaEN.TransMissingValue = null; //转换失败值
if (objvTabFieldRelaEN.TransNullValue == "[null]") objvTabFieldRelaEN.TransNullValue = null; //转换空值
if (objvTabFieldRelaEN.PrjName == "[null]") objvTabFieldRelaEN.PrjName = null; //工程名称
if (objvTabFieldRelaEN.PrefixFldName == "[null]") objvTabFieldRelaEN.PrefixFldName = null; //前缀字段名
if (objvTabFieldRelaEN.Keyword == "[null]") objvTabFieldRelaEN.Keyword = null; //关键字
if (objvTabFieldRelaEN.TabCnName == "[null]") objvTabFieldRelaEN.TabCnName = null; //表中文名
if (objvTabFieldRelaEN.TabEnName == "[null]") objvTabFieldRelaEN.TabEnName = null; //表英文详细名
if (objvTabFieldRelaEN.Memo == "[null]") objvTabFieldRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvTabFieldRelaEN objvTabFieldRelaEN)
{
 vTabFieldRelaDA.CheckProperty4Condition(objvTabFieldRelaEN);
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
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFieldRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFieldRelaBL没有刷新缓存机制(clsTabFieldRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTransWayBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTransWayBL没有刷新缓存机制(clsTransWayBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFieldTabRela");
//if (arrvTabFieldRelaObjLstCache == null)
//{
//arrvTabFieldRelaObjLstCache = vTabFieldRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFieldRelaEN GetObjByIdFieldTabRelaCache(long lngIdFieldTabRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrvTabFieldRelaObjLst_Sel =
arrvTabFieldRelaObjLstCache
.Where(x=> x.IdFieldTabRela == lngIdFieldTabRela 
);
if (arrvTabFieldRelaObjLst_Sel.Count() == 0)
{
   clsvTabFieldRelaEN obj = clsvTabFieldRelaBL.GetObjByIdFieldTabRela(lngIdFieldTabRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTabFieldRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFieldRelaEN> GetAllvTabFieldRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = GetObjLstCache(); 
return arrvTabFieldRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFieldRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
List<clsvTabFieldRelaEN> arrvTabFieldRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTabFieldRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvTabFieldRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvTabFieldRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabFieldRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFieldRelaEN._RefreshTimeLst[clsvTabFieldRelaEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngIdFieldTabRela)
{
if (strInFldName != convTabFieldRela.IdFieldTabRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFieldRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFieldRela._AttributeName));
throw new Exception(strMsg);
}
var objvTabFieldRela = clsvTabFieldRelaBL.GetObjByIdFieldTabRelaCache(lngIdFieldTabRela);
if (objvTabFieldRela == null) return "";
return objvTabFieldRela[strOutFldName].ToString();
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
int intRecCount = clsvTabFieldRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabFieldRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFieldRelaDA.GetRecCount();
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
int intRecCount = clsvTabFieldRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFieldRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFieldRelaEN objvTabFieldRelaCond)
{
List<clsvTabFieldRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFieldRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFieldRela._AttributeName)
{
if (objvTabFieldRelaCond.IsUpdated(strFldName) == false) continue;
if (objvTabFieldRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFieldRelaCond[strFldName].ToString());
}
else
{
if (objvTabFieldRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFieldRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFieldRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFieldRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFieldRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFieldRelaCond[strFldName]));
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
 List<string> arrList = clsvTabFieldRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabFieldRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabFieldRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}