
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFuncTemplateRelaBL
 表名:vPrjFuncTemplateRela(00050318)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvPrjFuncTemplateRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFuncTemplateRelaEN GetObj(this K_mId_vPrjFuncTemplateRela myKey)
{
clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = clsvPrjFuncTemplateRelaBL.vPrjFuncTemplateRelaDA.GetObjBymId(myKey.Value);
return objvPrjFuncTemplateRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetProgLangTypeName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convPrjFuncTemplateRela.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convPrjFuncTemplateRela.ProgLangTypeName);
}
objvPrjFuncTemplateRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.ProgLangTypeName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetFunctionTemplateName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convPrjFuncTemplateRela.FunctionTemplateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convPrjFuncTemplateRela.FunctionTemplateName);
}
objvPrjFuncTemplateRelaEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.FunctionTemplateName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.FunctionTemplateName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeENName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convPrjFuncTemplateRela.CodeTypeENName);
}
objvPrjFuncTemplateRelaEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeENName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeENName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeENName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convPrjFuncTemplateRela.CodeTypeName);
}
objvPrjFuncTemplateRelaEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetmId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, long lngmId, string strComparisonOp="")
	{
objvPrjFuncTemplateRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.mId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.mId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.mId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetPrjId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjFuncTemplateRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjFuncTemplateRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjFuncTemplateRela.PrjId);
}
objvPrjFuncTemplateRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.PrjId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.PrjId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.PrjId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetPrjName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjFuncTemplateRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjFuncTemplateRela.PrjName);
}
objvPrjFuncTemplateRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.PrjName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.PrjName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.PrjName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convPrjFuncTemplateRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convPrjFuncTemplateRela.CodeTypeId);
}
objvPrjFuncTemplateRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetProgLangTypeId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convPrjFuncTemplateRela.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convPrjFuncTemplateRela.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convPrjFuncTemplateRela.ProgLangTypeId);
}
objvPrjFuncTemplateRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.ProgLangTypeId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetFunctionTemplateId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convPrjFuncTemplateRela.FunctionTemplateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convPrjFuncTemplateRela.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convPrjFuncTemplateRela.FunctionTemplateId);
}
objvPrjFuncTemplateRelaEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.FunctionTemplateId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.FunctionTemplateId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetUpdDate(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFuncTemplateRela.UpdDate);
}
objvPrjFuncTemplateRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.UpdDate) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.UpdDate, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.UpdDate] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetUpdUser(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFuncTemplateRela.UpdUser);
}
objvPrjFuncTemplateRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.UpdUser) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.UpdUser, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.UpdUser] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetMemo(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFuncTemplateRela.Memo);
}
objvPrjFuncTemplateRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.Memo) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.Memo, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.Memo] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaENS">源对象</param>
 /// <param name = "objvPrjFuncTemplateRelaENT">目标对象</param>
 public static void CopyTo(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENS, clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENT)
{
try
{
objvPrjFuncTemplateRelaENT.ProgLangTypeName = objvPrjFuncTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvPrjFuncTemplateRelaENT.FunctionTemplateName = objvPrjFuncTemplateRelaENS.FunctionTemplateName; //函数模板名
objvPrjFuncTemplateRelaENT.CodeTypeENName = objvPrjFuncTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvPrjFuncTemplateRelaENT.CodeTypeName = objvPrjFuncTemplateRelaENS.CodeTypeName; //代码类型名
objvPrjFuncTemplateRelaENT.mId = objvPrjFuncTemplateRelaENS.mId; //mId
objvPrjFuncTemplateRelaENT.PrjId = objvPrjFuncTemplateRelaENS.PrjId; //工程Id
objvPrjFuncTemplateRelaENT.PrjName = objvPrjFuncTemplateRelaENS.PrjName; //工程名称
objvPrjFuncTemplateRelaENT.CodeTypeId = objvPrjFuncTemplateRelaENS.CodeTypeId; //代码类型Id
objvPrjFuncTemplateRelaENT.ProgLangTypeId = objvPrjFuncTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvPrjFuncTemplateRelaENT.FunctionTemplateId = objvPrjFuncTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvPrjFuncTemplateRelaENT.UpdDate = objvPrjFuncTemplateRelaENS.UpdDate; //修改日期
objvPrjFuncTemplateRelaENT.UpdUser = objvPrjFuncTemplateRelaENS.UpdUser; //修改者
objvPrjFuncTemplateRelaENT.Memo = objvPrjFuncTemplateRelaENS.Memo; //说明
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
 /// <param name = "objvPrjFuncTemplateRelaENS">源对象</param>
 /// <returns>目标对象=>clsvPrjFuncTemplateRelaEN:objvPrjFuncTemplateRelaENT</returns>
 public static clsvPrjFuncTemplateRelaEN CopyTo(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENS)
{
try
{
 clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENT = new clsvPrjFuncTemplateRelaEN()
{
ProgLangTypeName = objvPrjFuncTemplateRelaENS.ProgLangTypeName, //编程语言类型名
FunctionTemplateName = objvPrjFuncTemplateRelaENS.FunctionTemplateName, //函数模板名
CodeTypeENName = objvPrjFuncTemplateRelaENS.CodeTypeENName, //代码类型英文名
CodeTypeName = objvPrjFuncTemplateRelaENS.CodeTypeName, //代码类型名
mId = objvPrjFuncTemplateRelaENS.mId, //mId
PrjId = objvPrjFuncTemplateRelaENS.PrjId, //工程Id
PrjName = objvPrjFuncTemplateRelaENS.PrjName, //工程名称
CodeTypeId = objvPrjFuncTemplateRelaENS.CodeTypeId, //代码类型Id
ProgLangTypeId = objvPrjFuncTemplateRelaENS.ProgLangTypeId, //编程语言类型Id
FunctionTemplateId = objvPrjFuncTemplateRelaENS.FunctionTemplateId, //函数模板Id
UpdDate = objvPrjFuncTemplateRelaENS.UpdDate, //修改日期
UpdUser = objvPrjFuncTemplateRelaENS.UpdUser, //修改者
Memo = objvPrjFuncTemplateRelaENS.Memo, //说明
};
 return objvPrjFuncTemplateRelaENT;
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
public static void CheckProperty4Condition(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
 clsvPrjFuncTemplateRelaBL.vPrjFuncTemplateRelaDA.CheckProperty4Condition(objvPrjFuncTemplateRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.ProgLangTypeName, objvPrjFuncTemplateRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.FunctionTemplateName, objvPrjFuncTemplateRelaCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeENName, objvPrjFuncTemplateRelaCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeName, objvPrjFuncTemplateRelaCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.mId) == true)
{
string strComparisonOpmId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjFuncTemplateRela.mId, objvPrjFuncTemplateRelaCond.mId, strComparisonOpmId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.PrjId, objvPrjFuncTemplateRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.PrjName, objvPrjFuncTemplateRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeId, objvPrjFuncTemplateRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.ProgLangTypeId, objvPrjFuncTemplateRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.FunctionTemplateId, objvPrjFuncTemplateRelaCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.UpdDate, objvPrjFuncTemplateRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.UpdUser, objvPrjFuncTemplateRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.Memo) == true)
{
string strComparisonOpMemo = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.Memo, objvPrjFuncTemplateRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjFuncTemplateRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程与函数模板关系(vPrjFuncTemplateRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFuncTemplateRelaBL
{
public static RelatedActions_vPrjFuncTemplateRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjFuncTemplateRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjFuncTemplateRelaDA vPrjFuncTemplateRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjFuncTemplateRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjFuncTemplateRelaBL()
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
if (string.IsNullOrEmpty(clsvPrjFuncTemplateRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFuncTemplateRelaEN._ConnectString);
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
public static DataTable GetDataTable_vPrjFuncTemplateRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjFuncTemplateRelaDA.GetDataTable_vPrjFuncTemplateRela(strWhereCond);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable(strWhereCond);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjFuncTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
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
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjFuncTemplateRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLst_Sel =
arrvPrjFuncTemplateRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPrjFuncTemplateRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLst(string strWhereCond)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjFuncTemplateRelaEN> GetSubObjLstCache(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaCond)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFuncTemplateRela._AttributeName)
{
if (objvPrjFuncTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFuncTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFuncTemplateRelaCond[strFldName].ToString());
}
else
{
if (objvPrjFuncTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFuncTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFuncTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFuncTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFuncTemplateRelaCond[strFldName]));
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
List<clsvPrjFuncTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjFuncTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjFuncTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
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
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
public static List<clsvPrjFuncTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFuncTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjFuncTemplateRela(ref clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
bool bolResult = vPrjFuncTemplateRelaDA.GetvPrjFuncTemplateRela(ref objvPrjFuncTemplateRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFuncTemplateRelaEN GetObjBymId(long lngmId)
{
clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = vPrjFuncTemplateRelaDA.GetObjBymId(lngmId);
return objvPrjFuncTemplateRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjFuncTemplateRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = vPrjFuncTemplateRelaDA.GetFirstObj(strWhereCond);
 return objvPrjFuncTemplateRelaEN;
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
public static clsvPrjFuncTemplateRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = vPrjFuncTemplateRelaDA.GetObjByDataRow(objRow);
 return objvPrjFuncTemplateRelaEN;
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
public static clsvPrjFuncTemplateRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = vPrjFuncTemplateRelaDA.GetObjByDataRow(objRow);
 return objvPrjFuncTemplateRelaEN;
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
 /// <param name = "lstvPrjFuncTemplateRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFuncTemplateRelaEN GetObjBymIdFromList(long lngmId, List<clsvPrjFuncTemplateRelaEN> lstvPrjFuncTemplateRelaObjLst)
{
foreach (clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN in lstvPrjFuncTemplateRelaObjLst)
{
if (objvPrjFuncTemplateRelaEN.mId == lngmId)
{
return objvPrjFuncTemplateRelaEN;
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
 lngmId = new clsvPrjFuncTemplateRelaDA().GetFirstID(strWhereCond);
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
 arrList = vPrjFuncTemplateRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjFuncTemplateRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPrjFuncTemplateRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvPrjFuncTemplateRelaDA.IsExistTable();
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
 bolIsExist = vPrjFuncTemplateRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjFuncTemplateRelaENS">源对象</param>
 /// <param name = "objvPrjFuncTemplateRelaENT">目标对象</param>
 public static void CopyTo(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENS, clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENT)
{
try
{
objvPrjFuncTemplateRelaENT.ProgLangTypeName = objvPrjFuncTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvPrjFuncTemplateRelaENT.FunctionTemplateName = objvPrjFuncTemplateRelaENS.FunctionTemplateName; //函数模板名
objvPrjFuncTemplateRelaENT.CodeTypeENName = objvPrjFuncTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvPrjFuncTemplateRelaENT.CodeTypeName = objvPrjFuncTemplateRelaENS.CodeTypeName; //代码类型名
objvPrjFuncTemplateRelaENT.mId = objvPrjFuncTemplateRelaENS.mId; //mId
objvPrjFuncTemplateRelaENT.PrjId = objvPrjFuncTemplateRelaENS.PrjId; //工程Id
objvPrjFuncTemplateRelaENT.PrjName = objvPrjFuncTemplateRelaENS.PrjName; //工程名称
objvPrjFuncTemplateRelaENT.CodeTypeId = objvPrjFuncTemplateRelaENS.CodeTypeId; //代码类型Id
objvPrjFuncTemplateRelaENT.ProgLangTypeId = objvPrjFuncTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvPrjFuncTemplateRelaENT.FunctionTemplateId = objvPrjFuncTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvPrjFuncTemplateRelaENT.UpdDate = objvPrjFuncTemplateRelaENS.UpdDate; //修改日期
objvPrjFuncTemplateRelaENT.UpdUser = objvPrjFuncTemplateRelaENS.UpdUser; //修改者
objvPrjFuncTemplateRelaENT.Memo = objvPrjFuncTemplateRelaENS.Memo; //说明
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
 /// <param name = "objvPrjFuncTemplateRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
try
{
objvPrjFuncTemplateRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjFuncTemplateRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjFuncTemplateRela.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objvPrjFuncTemplateRelaEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.FunctionTemplateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objvPrjFuncTemplateRelaEN.FunctionTemplateName; //函数模板名
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.CodeTypeENName = objvPrjFuncTemplateRelaEN.CodeTypeENName == "[null]" ? null :  objvPrjFuncTemplateRelaEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.CodeTypeName = objvPrjFuncTemplateRelaEN.CodeTypeName == "[null]" ? null :  objvPrjFuncTemplateRelaEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.mId = objvPrjFuncTemplateRelaEN.mId; //mId
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.PrjId = objvPrjFuncTemplateRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.PrjName = objvPrjFuncTemplateRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.CodeTypeId = objvPrjFuncTemplateRelaEN.CodeTypeId == "[null]" ? null :  objvPrjFuncTemplateRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objvPrjFuncTemplateRelaEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objvPrjFuncTemplateRelaEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.UpdDate = objvPrjFuncTemplateRelaEN.UpdDate == "[null]" ? null :  objvPrjFuncTemplateRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.UpdUser = objvPrjFuncTemplateRelaEN.UpdUser == "[null]" ? null :  objvPrjFuncTemplateRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convPrjFuncTemplateRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFuncTemplateRelaEN.Memo = objvPrjFuncTemplateRelaEN.Memo == "[null]" ? null :  objvPrjFuncTemplateRelaEN.Memo; //说明
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
 /// <param name = "objvPrjFuncTemplateRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
try
{
if (objvPrjFuncTemplateRelaEN.CodeTypeENName == "[null]") objvPrjFuncTemplateRelaEN.CodeTypeENName = null; //代码类型英文名
if (objvPrjFuncTemplateRelaEN.CodeTypeName == "[null]") objvPrjFuncTemplateRelaEN.CodeTypeName = null; //代码类型名
if (objvPrjFuncTemplateRelaEN.CodeTypeId == "[null]") objvPrjFuncTemplateRelaEN.CodeTypeId = null; //代码类型Id
if (objvPrjFuncTemplateRelaEN.UpdDate == "[null]") objvPrjFuncTemplateRelaEN.UpdDate = null; //修改日期
if (objvPrjFuncTemplateRelaEN.UpdUser == "[null]") objvPrjFuncTemplateRelaEN.UpdUser = null; //修改者
if (objvPrjFuncTemplateRelaEN.Memo == "[null]") objvPrjFuncTemplateRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
 vPrjFuncTemplateRelaDA.CheckProperty4Condition(objvPrjFuncTemplateRelaEN);
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTemplateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateBL没有刷新缓存机制(clsFunctionTemplateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFuncTemplateRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFuncTemplateRelaBL没有刷新缓存机制(clsPrjFuncTemplateRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPrjFuncTemplateRelaObjLstCache == null)
//{
//arrvPrjFuncTemplateRelaObjLstCache = vPrjFuncTemplateRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFuncTemplateRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLst_Sel =
arrvPrjFuncTemplateRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPrjFuncTemplateRelaObjLst_Sel.Count() == 0)
{
   clsvPrjFuncTemplateRelaEN obj = clsvPrjFuncTemplateRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjFuncTemplateRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetAllvPrjFuncTemplateRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = GetObjLstCache(); 
return arrvPrjFuncTemplateRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjFuncTemplateRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjFuncTemplateRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjFuncTemplateRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjFuncTemplateRelaEN._RefreshTimeLst[clsvPrjFuncTemplateRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convPrjFuncTemplateRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjFuncTemplateRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjFuncTemplateRela._AttributeName));
throw new Exception(strMsg);
}
var objvPrjFuncTemplateRela = clsvPrjFuncTemplateRelaBL.GetObjBymIdCache(lngmId);
if (objvPrjFuncTemplateRela == null) return "";
return objvPrjFuncTemplateRela[strOutFldName].ToString();
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
int intRecCount = clsvPrjFuncTemplateRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjFuncTemplateRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjFuncTemplateRelaDA.GetRecCount();
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
int intRecCount = clsvPrjFuncTemplateRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaCond)
{
List<clsvPrjFuncTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFuncTemplateRela._AttributeName)
{
if (objvPrjFuncTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFuncTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFuncTemplateRelaCond[strFldName].ToString());
}
else
{
if (objvPrjFuncTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFuncTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFuncTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFuncTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFuncTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFuncTemplateRelaCond[strFldName]));
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
 List<string> arrList = clsvPrjFuncTemplateRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjFuncTemplateRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjFuncTemplateRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}