
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRelaBL
 表名:vFunctionTemplateRela(00050317)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvFunctionTemplateRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateRelaEN GetObj(this K_mId_vFunctionTemplateRela myKey)
{
clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = clsvFunctionTemplateRelaBL.vFunctionTemplateRelaDA.GetObjBymId(myKey.Value);
return objvFunctionTemplateRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetmId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, long lngmId, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.mId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.mId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.mId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionTemplateId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convFunctionTemplateRela.FunctionTemplateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convFunctionTemplateRela.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convFunctionTemplateRela.FunctionTemplateId);
}
objvFunctionTemplateRelaEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionTemplateId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionTemplateId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionTemplateName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convFunctionTemplateRela.FunctionTemplateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convFunctionTemplateRela.FunctionTemplateName);
}
objvFunctionTemplateRelaEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionTemplateName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionTemplateName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCreateUserId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionTemplateRela.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionTemplateRela.CreateUserId);
}
objvFunctionTemplateRelaEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CreateUserId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CreateUserId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CreateUserId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionTemplateRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionTemplateRela.CodeTypeId);
}
objvFunctionTemplateRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunctionTemplateRela.CodeTypeName);
}
objvFunctionTemplateRelaEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeENName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convFunctionTemplateRela.CodeTypeENName);
}
objvFunctionTemplateRelaEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeENName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeENName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeENName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetRegionTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFunctionTemplateRela.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFunctionTemplateRela.RegionTypeId);
}
objvFunctionTemplateRelaEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.RegionTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.RegionTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetRegionTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFunctionTemplateRela.RegionTypeName);
}
objvFunctionTemplateRelaEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.RegionTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.RegionTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncId4GC(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionTemplateRela.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionTemplateRela.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionTemplateRela.FuncId4GC);
}
objvFunctionTemplateRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncId4GC) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionTemplateRela.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionTemplateRela.FuncName);
}
objvFunctionTemplateRelaEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncId4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunctionTemplateRela.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunctionTemplateRela.FuncId4Code);
}
objvFunctionTemplateRelaEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncId4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncId4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncId4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncName4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunctionTemplateRela.FuncName4Code);
}
objvFunctionTemplateRelaEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncName4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncName4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncName4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncCHName4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncCHName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunctionTemplateRela.FuncCHName4Code);
}
objvFunctionTemplateRelaEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncCHName4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetProgLangTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionTemplateRela.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionTemplateRela.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionTemplateRela.ProgLangTypeId);
}
objvFunctionTemplateRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ProgLangTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetProgLangTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionTemplateRela.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionTemplateRela.ProgLangTypeName);
}
objvFunctionTemplateRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ProgLangTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetSqlDsTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunctionTemplateRela.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunctionTemplateRela.SqlDsTypeId);
}
objvFunctionTemplateRelaEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.SqlDsTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetSqlDsTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convFunctionTemplateRela.SqlDsTypeName);
}
objvFunctionTemplateRelaEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.SqlDsTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.SqlDsTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetReturnTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunctionTemplateRela.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunctionTemplateRela.ReturnTypeId);
}
objvFunctionTemplateRelaEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ReturnTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ReturnTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunctionTemplateRela.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunctionTemplateRela.FuncTypeId);
}
objvFunctionTemplateRelaEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunctionTemplateRela.FuncTypeName);
}
objvFunctionTemplateRelaEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetIsTemplate(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convFunctionTemplateRela.IsTemplate);
objvFunctionTemplateRelaEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.IsTemplate) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.IsTemplate, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.IsTemplate] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionSignature(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunctionTemplateRela.FunctionSignature);
}
objvFunctionTemplateRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionSignature) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionSignature, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionSignature] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetReturnTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strReturnTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunctionTemplateRela.ReturnTypeName);
}
objvFunctionTemplateRelaEN.ReturnTypeName = strReturnTypeName; //返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ReturnTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ReturnTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetIsGeneCode(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.IsGeneCode) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.IsGeneCode, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.IsGeneCode] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetOrderNum(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFunctionTemplateRela.OrderNum);
objvFunctionTemplateRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.OrderNum) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.OrderNum, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.OrderNum] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetUpdDate(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionTemplateRela.UpdDate);
}
objvFunctionTemplateRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.UpdDate) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.UpdDate, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.UpdDate] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetUpdUser(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionTemplateRela.UpdUser);
}
objvFunctionTemplateRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.UpdUser) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.UpdUser, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.UpdUser] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetMemo(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionTemplateRela.Memo);
}
objvFunctionTemplateRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.Memo) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.Memo, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.Memo] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetOrder4FuncNum(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, int? intOrder4FuncNum, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.Order4FuncNum = intOrder4FuncNum; //Order4FuncNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.Order4FuncNum) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.Order4FuncNum, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.Order4FuncNum] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objvFunctionTemplateRelaENT">目标对象</param>
 public static void CopyTo(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS, clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENT)
{
try
{
objvFunctionTemplateRelaENT.mId = objvFunctionTemplateRelaENS.mId; //mId
objvFunctionTemplateRelaENT.FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRelaENT.FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName; //函数模板名
objvFunctionTemplateRelaENT.CreateUserId = objvFunctionTemplateRelaENS.CreateUserId; //建立用户Id
objvFunctionTemplateRelaENT.CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRelaENT.CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName; //代码类型名
objvFunctionTemplateRelaENT.CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvFunctionTemplateRelaENT.RegionTypeId = objvFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRelaENT.RegionTypeName = objvFunctionTemplateRelaENS.RegionTypeName; //区域类型名称
objvFunctionTemplateRelaENT.FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC; //函数ID
objvFunctionTemplateRelaENT.FuncName = objvFunctionTemplateRelaENS.FuncName; //函数名
objvFunctionTemplateRelaENT.FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code; //函数Id4Code
objvFunctionTemplateRelaENT.FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code; //函数名4Code
objvFunctionTemplateRelaENT.FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code; //函数中文名4Code
objvFunctionTemplateRelaENT.ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionTemplateRelaENT.ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionTemplateRelaENT.SqlDsTypeId = objvFunctionTemplateRelaENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRelaENT.SqlDsTypeName = objvFunctionTemplateRelaENS.SqlDsTypeName; //Sql数据源名
objvFunctionTemplateRelaENT.ReturnTypeId = objvFunctionTemplateRelaENS.ReturnTypeId; //返回类型ID
objvFunctionTemplateRelaENT.FuncTypeId = objvFunctionTemplateRelaENS.FuncTypeId; //函数类型Id
objvFunctionTemplateRelaENT.FuncTypeName = objvFunctionTemplateRelaENS.FuncTypeName; //函数类型名
objvFunctionTemplateRelaENT.IsTemplate = objvFunctionTemplateRelaENS.IsTemplate; //是否模板
objvFunctionTemplateRelaENT.FunctionSignature = objvFunctionTemplateRelaENS.FunctionSignature; //函数签名
objvFunctionTemplateRelaENT.ReturnTypeName = objvFunctionTemplateRelaENS.ReturnTypeName; //返回类型名
objvFunctionTemplateRelaENT.IsGeneCode = objvFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objvFunctionTemplateRelaENT.OrderNum = objvFunctionTemplateRelaENS.OrderNum; //序号
objvFunctionTemplateRelaENT.UpdDate = objvFunctionTemplateRelaENS.UpdDate; //修改日期
objvFunctionTemplateRelaENT.UpdUser = objvFunctionTemplateRelaENS.UpdUser; //修改者
objvFunctionTemplateRelaENT.Memo = objvFunctionTemplateRelaENS.Memo; //说明
objvFunctionTemplateRelaENT.Order4FuncNum = objvFunctionTemplateRelaENS.Order4FuncNum; //Order4FuncNum
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
 /// <param name = "objvFunctionTemplateRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionTemplateRelaEN:objvFunctionTemplateRelaENT</returns>
 public static clsvFunctionTemplateRelaEN CopyTo(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS)
{
try
{
 clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENT = new clsvFunctionTemplateRelaEN()
{
mId = objvFunctionTemplateRelaENS.mId, //mId
FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId, //函数模板Id
FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName, //函数模板名
CreateUserId = objvFunctionTemplateRelaENS.CreateUserId, //建立用户Id
CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId, //代码类型Id
CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName, //代码类型名
CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName, //代码类型英文名
RegionTypeId = objvFunctionTemplateRelaENS.RegionTypeId, //区域类型Id
RegionTypeName = objvFunctionTemplateRelaENS.RegionTypeName, //区域类型名称
FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC, //函数ID
FuncName = objvFunctionTemplateRelaENS.FuncName, //函数名
FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code, //函数名4Code
FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code, //函数中文名4Code
ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName, //编程语言类型名
SqlDsTypeId = objvFunctionTemplateRelaENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvFunctionTemplateRelaENS.SqlDsTypeName, //Sql数据源名
ReturnTypeId = objvFunctionTemplateRelaENS.ReturnTypeId, //返回类型ID
FuncTypeId = objvFunctionTemplateRelaENS.FuncTypeId, //函数类型Id
FuncTypeName = objvFunctionTemplateRelaENS.FuncTypeName, //函数类型名
IsTemplate = objvFunctionTemplateRelaENS.IsTemplate, //是否模板
FunctionSignature = objvFunctionTemplateRelaENS.FunctionSignature, //函数签名
ReturnTypeName = objvFunctionTemplateRelaENS.ReturnTypeName, //返回类型名
IsGeneCode = objvFunctionTemplateRelaENS.IsGeneCode, //是否生成代码
OrderNum = objvFunctionTemplateRelaENS.OrderNum, //序号
UpdDate = objvFunctionTemplateRelaENS.UpdDate, //修改日期
UpdUser = objvFunctionTemplateRelaENS.UpdUser, //修改者
Memo = objvFunctionTemplateRelaENS.Memo, //说明
Order4FuncNum = objvFunctionTemplateRelaENS.Order4FuncNum, //Order4FuncNum
};
 return objvFunctionTemplateRelaENT;
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
public static void CheckProperty4Condition(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
 clsvFunctionTemplateRelaBL.vFunctionTemplateRelaDA.CheckProperty4Condition(objvFunctionTemplateRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.mId) == true)
{
string strComparisonOpmId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.mId, objvFunctionTemplateRelaCond.mId, strComparisonOpmId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionTemplateId, objvFunctionTemplateRelaCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionTemplateName, objvFunctionTemplateRelaCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CreateUserId, objvFunctionTemplateRelaCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeId, objvFunctionTemplateRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeName, objvFunctionTemplateRelaCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeENName, objvFunctionTemplateRelaCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.RegionTypeId, objvFunctionTemplateRelaCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.RegionTypeName, objvFunctionTemplateRelaCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncId4GC, objvFunctionTemplateRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncName) == true)
{
string strComparisonOpFuncName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncName, objvFunctionTemplateRelaCond.FuncName, strComparisonOpFuncName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncId4Code, objvFunctionTemplateRelaCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncName4Code, objvFunctionTemplateRelaCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncCHName4Code, objvFunctionTemplateRelaCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ProgLangTypeId, objvFunctionTemplateRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ProgLangTypeName, objvFunctionTemplateRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.SqlDsTypeId, objvFunctionTemplateRelaCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.SqlDsTypeName, objvFunctionTemplateRelaCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ReturnTypeId, objvFunctionTemplateRelaCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncTypeId, objvFunctionTemplateRelaCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncTypeName, objvFunctionTemplateRelaCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.IsTemplate) == true)
{
if (objvFunctionTemplateRelaCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela.IsTemplate);
}
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionSignature, objvFunctionTemplateRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ReturnTypeName) == true)
{
string strComparisonOpReturnTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ReturnTypeName, objvFunctionTemplateRelaCond.ReturnTypeName, strComparisonOpReturnTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.IsGeneCode) == true)
{
if (objvFunctionTemplateRelaCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela.IsGeneCode);
}
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.OrderNum, objvFunctionTemplateRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.UpdDate, objvFunctionTemplateRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.UpdUser, objvFunctionTemplateRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.Memo) == true)
{
string strComparisonOpMemo = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.Memo, objvFunctionTemplateRelaCond.Memo, strComparisonOpMemo);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.Order4FuncNum) == true)
{
string strComparisonOpOrder4FuncNum = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.Order4FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.Order4FuncNum, objvFunctionTemplateRelaCond.Order4FuncNum, strComparisonOpOrder4FuncNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionTemplateRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数与模板关系(vFunctionTemplateRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTemplateRelaBL
{
public static RelatedActions_vFunctionTemplateRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionTemplateRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionTemplateRelaDA vFunctionTemplateRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionTemplateRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionTemplateRelaBL()
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
if (string.IsNullOrEmpty(clsvFunctionTemplateRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionTemplateRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionTemplateRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionTemplateRelaDA.GetDataTable_vFunctionTemplateRela(strWhereCond);
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
objDT = vFunctionTemplateRelaDA.GetDataTable(strWhereCond);
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
objDT = vFunctionTemplateRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionTemplateRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionTemplateRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionTemplateRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionTemplateRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
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
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionTemplateRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst_Sel =
arrvFunctionTemplateRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFunctionTemplateRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionTemplateRelaEN> GetSubObjLstCache(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaCond)
{
List<clsvFunctionTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionTemplateRela._AttributeName)
{
if (objvFunctionTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRelaCond[strFldName]));
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
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
List<clsvFunctionTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
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
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
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
public static List<clsvFunctionTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionTemplateRela(ref clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
bool bolResult = vFunctionTemplateRelaDA.GetvFunctionTemplateRela(ref objvFunctionTemplateRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateRelaEN GetObjBymId(long lngmId)
{
clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = vFunctionTemplateRelaDA.GetObjBymId(lngmId);
return objvFunctionTemplateRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionTemplateRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = vFunctionTemplateRelaDA.GetFirstObj(strWhereCond);
 return objvFunctionTemplateRelaEN;
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
public static clsvFunctionTemplateRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = vFunctionTemplateRelaDA.GetObjByDataRow(objRow);
 return objvFunctionTemplateRelaEN;
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
public static clsvFunctionTemplateRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = vFunctionTemplateRelaDA.GetObjByDataRow(objRow);
 return objvFunctionTemplateRelaEN;
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
 /// <param name = "lstvFunctionTemplateRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateRelaEN GetObjBymIdFromList(long lngmId, List<clsvFunctionTemplateRelaEN> lstvFunctionTemplateRelaObjLst)
{
foreach (clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN in lstvFunctionTemplateRelaObjLst)
{
if (objvFunctionTemplateRelaEN.mId == lngmId)
{
return objvFunctionTemplateRelaEN;
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
 lngmId = new clsvFunctionTemplateRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFunctionTemplateRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionTemplateRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFunctionTemplateRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFunctionTemplateRelaDA.IsExistTable();
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
 bolIsExist = vFunctionTemplateRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objvFunctionTemplateRelaENT">目标对象</param>
 public static void CopyTo(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS, clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENT)
{
try
{
objvFunctionTemplateRelaENT.mId = objvFunctionTemplateRelaENS.mId; //mId
objvFunctionTemplateRelaENT.FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRelaENT.FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName; //函数模板名
objvFunctionTemplateRelaENT.CreateUserId = objvFunctionTemplateRelaENS.CreateUserId; //建立用户Id
objvFunctionTemplateRelaENT.CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRelaENT.CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName; //代码类型名
objvFunctionTemplateRelaENT.CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvFunctionTemplateRelaENT.RegionTypeId = objvFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRelaENT.RegionTypeName = objvFunctionTemplateRelaENS.RegionTypeName; //区域类型名称
objvFunctionTemplateRelaENT.FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC; //函数ID
objvFunctionTemplateRelaENT.FuncName = objvFunctionTemplateRelaENS.FuncName; //函数名
objvFunctionTemplateRelaENT.FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code; //函数Id4Code
objvFunctionTemplateRelaENT.FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code; //函数名4Code
objvFunctionTemplateRelaENT.FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code; //函数中文名4Code
objvFunctionTemplateRelaENT.ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionTemplateRelaENT.ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionTemplateRelaENT.SqlDsTypeId = objvFunctionTemplateRelaENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRelaENT.SqlDsTypeName = objvFunctionTemplateRelaENS.SqlDsTypeName; //Sql数据源名
objvFunctionTemplateRelaENT.ReturnTypeId = objvFunctionTemplateRelaENS.ReturnTypeId; //返回类型ID
objvFunctionTemplateRelaENT.FuncTypeId = objvFunctionTemplateRelaENS.FuncTypeId; //函数类型Id
objvFunctionTemplateRelaENT.FuncTypeName = objvFunctionTemplateRelaENS.FuncTypeName; //函数类型名
objvFunctionTemplateRelaENT.IsTemplate = objvFunctionTemplateRelaENS.IsTemplate; //是否模板
objvFunctionTemplateRelaENT.FunctionSignature = objvFunctionTemplateRelaENS.FunctionSignature; //函数签名
objvFunctionTemplateRelaENT.ReturnTypeName = objvFunctionTemplateRelaENS.ReturnTypeName; //返回类型名
objvFunctionTemplateRelaENT.IsGeneCode = objvFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objvFunctionTemplateRelaENT.OrderNum = objvFunctionTemplateRelaENS.OrderNum; //序号
objvFunctionTemplateRelaENT.UpdDate = objvFunctionTemplateRelaENS.UpdDate; //修改日期
objvFunctionTemplateRelaENT.UpdUser = objvFunctionTemplateRelaENS.UpdUser; //修改者
objvFunctionTemplateRelaENT.Memo = objvFunctionTemplateRelaENS.Memo; //说明
objvFunctionTemplateRelaENT.Order4FuncNum = objvFunctionTemplateRelaENS.Order4FuncNum; //Order4FuncNum
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
 /// <param name = "objvFunctionTemplateRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
try
{
objvFunctionTemplateRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionTemplateRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionTemplateRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.mId = objvFunctionTemplateRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFunctionTemplateRela.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FunctionTemplateId = objvFunctionTemplateRelaEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.FunctionTemplateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FunctionTemplateName = objvFunctionTemplateRelaEN.FunctionTemplateName; //函数模板名
}
if (arrFldSet.Contains(convFunctionTemplateRela.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.CreateUserId = objvFunctionTemplateRelaEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.CodeTypeId = objvFunctionTemplateRelaEN.CodeTypeId == "[null]" ? null :  objvFunctionTemplateRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.CodeTypeName = objvFunctionTemplateRelaEN.CodeTypeName == "[null]" ? null :  objvFunctionTemplateRelaEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convFunctionTemplateRela.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.CodeTypeENName = objvFunctionTemplateRelaEN.CodeTypeENName == "[null]" ? null :  objvFunctionTemplateRelaEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convFunctionTemplateRela.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.RegionTypeId = objvFunctionTemplateRelaEN.RegionTypeId == "[null]" ? null :  objvFunctionTemplateRelaEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.RegionTypeName = objvFunctionTemplateRelaEN.RegionTypeName == "[null]" ? null :  objvFunctionTemplateRelaEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncId4GC = objvFunctionTemplateRelaEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncName = objvFunctionTemplateRelaEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncId4Code = objvFunctionTemplateRelaEN.FuncId4Code == "[null]" ? null :  objvFunctionTemplateRelaEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncName4Code = objvFunctionTemplateRelaEN.FuncName4Code == "[null]" ? null :  objvFunctionTemplateRelaEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncCHName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncCHName4Code = objvFunctionTemplateRelaEN.FuncCHName4Code == "[null]" ? null :  objvFunctionTemplateRelaEN.FuncCHName4Code; //函数中文名4Code
}
if (arrFldSet.Contains(convFunctionTemplateRela.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.ProgLangTypeId = objvFunctionTemplateRelaEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.ProgLangTypeName = objvFunctionTemplateRelaEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convFunctionTemplateRela.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.SqlDsTypeId = objvFunctionTemplateRelaEN.SqlDsTypeId == "[null]" ? null :  objvFunctionTemplateRelaEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.SqlDsTypeName = objvFunctionTemplateRelaEN.SqlDsTypeName == "[null]" ? null :  objvFunctionTemplateRelaEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convFunctionTemplateRela.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.ReturnTypeId = objvFunctionTemplateRelaEN.ReturnTypeId == "[null]" ? null :  objvFunctionTemplateRelaEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncTypeId = objvFunctionTemplateRelaEN.FuncTypeId == "[null]" ? null :  objvFunctionTemplateRelaEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convFunctionTemplateRela.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FuncTypeName = objvFunctionTemplateRelaEN.FuncTypeName == "[null]" ? null :  objvFunctionTemplateRelaEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convFunctionTemplateRela.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.IsTemplate = objvFunctionTemplateRelaEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convFunctionTemplateRela.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.FunctionSignature = objvFunctionTemplateRelaEN.FunctionSignature == "[null]" ? null :  objvFunctionTemplateRelaEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convFunctionTemplateRela.ReturnTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.ReturnTypeName = objvFunctionTemplateRelaEN.ReturnTypeName == "[null]" ? null :  objvFunctionTemplateRelaEN.ReturnTypeName; //返回类型名
}
if (arrFldSet.Contains(convFunctionTemplateRela.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.IsGeneCode = objvFunctionTemplateRelaEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(convFunctionTemplateRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.OrderNum = objvFunctionTemplateRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFunctionTemplateRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.UpdDate = objvFunctionTemplateRelaEN.UpdDate == "[null]" ? null :  objvFunctionTemplateRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunctionTemplateRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.UpdUser = objvFunctionTemplateRelaEN.UpdUser == "[null]" ? null :  objvFunctionTemplateRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunctionTemplateRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.Memo = objvFunctionTemplateRelaEN.Memo == "[null]" ? null :  objvFunctionTemplateRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convFunctionTemplateRela.Order4FuncNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTemplateRelaEN.Order4FuncNum = objvFunctionTemplateRelaEN.Order4FuncNum; //Order4FuncNum
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
 /// <param name = "objvFunctionTemplateRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
try
{
if (objvFunctionTemplateRelaEN.CodeTypeId == "[null]") objvFunctionTemplateRelaEN.CodeTypeId = null; //代码类型Id
if (objvFunctionTemplateRelaEN.CodeTypeName == "[null]") objvFunctionTemplateRelaEN.CodeTypeName = null; //代码类型名
if (objvFunctionTemplateRelaEN.CodeTypeENName == "[null]") objvFunctionTemplateRelaEN.CodeTypeENName = null; //代码类型英文名
if (objvFunctionTemplateRelaEN.RegionTypeId == "[null]") objvFunctionTemplateRelaEN.RegionTypeId = null; //区域类型Id
if (objvFunctionTemplateRelaEN.RegionTypeName == "[null]") objvFunctionTemplateRelaEN.RegionTypeName = null; //区域类型名称
if (objvFunctionTemplateRelaEN.FuncId4Code == "[null]") objvFunctionTemplateRelaEN.FuncId4Code = null; //函数Id4Code
if (objvFunctionTemplateRelaEN.FuncName4Code == "[null]") objvFunctionTemplateRelaEN.FuncName4Code = null; //函数名4Code
if (objvFunctionTemplateRelaEN.FuncCHName4Code == "[null]") objvFunctionTemplateRelaEN.FuncCHName4Code = null; //函数中文名4Code
if (objvFunctionTemplateRelaEN.SqlDsTypeId == "[null]") objvFunctionTemplateRelaEN.SqlDsTypeId = null; //数据源类型Id
if (objvFunctionTemplateRelaEN.SqlDsTypeName == "[null]") objvFunctionTemplateRelaEN.SqlDsTypeName = null; //Sql数据源名
if (objvFunctionTemplateRelaEN.ReturnTypeId == "[null]") objvFunctionTemplateRelaEN.ReturnTypeId = null; //返回类型ID
if (objvFunctionTemplateRelaEN.FuncTypeId == "[null]") objvFunctionTemplateRelaEN.FuncTypeId = null; //函数类型Id
if (objvFunctionTemplateRelaEN.FuncTypeName == "[null]") objvFunctionTemplateRelaEN.FuncTypeName = null; //函数类型名
if (objvFunctionTemplateRelaEN.FunctionSignature == "[null]") objvFunctionTemplateRelaEN.FunctionSignature = null; //函数签名
if (objvFunctionTemplateRelaEN.ReturnTypeName == "[null]") objvFunctionTemplateRelaEN.ReturnTypeName = null; //返回类型名
if (objvFunctionTemplateRelaEN.UpdDate == "[null]") objvFunctionTemplateRelaEN.UpdDate = null; //修改日期
if (objvFunctionTemplateRelaEN.UpdUser == "[null]") objvFunctionTemplateRelaEN.UpdUser = null; //修改者
if (objvFunctionTemplateRelaEN.Memo == "[null]") objvFunctionTemplateRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
 vFunctionTemplateRelaDA.CheckProperty4Condition(objvFunctionTemplateRelaEN);
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
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTemplateRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateRelaBL没有刷新缓存机制(clsFunctionTemplateRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncGCTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncGCTypeBL没有刷新缓存机制(clsFuncGCTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTemplateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateBL没有刷新缓存机制(clsFunctionTemplateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFunctionTemplateRelaObjLstCache == null)
//{
//arrvFunctionTemplateRelaObjLstCache = vFunctionTemplateRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst_Sel =
arrvFunctionTemplateRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFunctionTemplateRelaObjLst_Sel.Count() == 0)
{
   clsvFunctionTemplateRelaEN obj = clsvFunctionTemplateRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionTemplateRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetAllvFunctionTemplateRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLstCache = GetObjLstCache(); 
return arrvFunctionTemplateRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTemplateRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionTemplateRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionTemplateRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionTemplateRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionTemplateRelaEN._RefreshTimeLst[clsvFunctionTemplateRelaEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFunctionTemplateRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionTemplateRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionTemplateRela._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionTemplateRela = clsvFunctionTemplateRelaBL.GetObjBymIdCache(lngmId);
if (objvFunctionTemplateRela == null) return "";
return objvFunctionTemplateRela[strOutFldName].ToString();
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
int intRecCount = clsvFunctionTemplateRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionTemplateRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionTemplateRelaDA.GetRecCount();
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
int intRecCount = clsvFunctionTemplateRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaCond)
{
List<clsvFunctionTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionTemplateRela._AttributeName)
{
if (objvFunctionTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTemplateRelaCond[strFldName]));
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
 List<string> arrList = clsvFunctionTemplateRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTemplateRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTemplateRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}