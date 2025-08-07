
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMRequirementWApi
 表名:vCMRequirement(00050260)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMRequirementWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqId">需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetReqId(this clsvCMRequirementEN objvCMRequirementEN, string strReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReqId, 8, convCMRequirement.ReqId);
clsCheckSql.CheckFieldForeignKey(strReqId, 8, convCMRequirement.ReqId);
objvCMRequirementEN.ReqId = strReqId; //需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.ReqId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.ReqId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.ReqId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementName">需求名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementName(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, convCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(strRequirementName, 50, convCMRequirement.RequirementName);
objvCMRequirementEN.RequirementName = strRequirementName; //需求名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.RequirementName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.RequirementName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.RequirementName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetFuncModuleAgcId(this clsvCMRequirementEN objvCMRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMRequirement.FuncModuleAgcId);
objvCMRequirementEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.FuncModuleAgcId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetFuncModuleName(this clsvCMRequirementEN objvCMRequirementEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMRequirement.FuncModuleName);
objvCMRequirementEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.FuncModuleName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.FuncModuleName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.FuncModuleName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqContent">需求内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetReqContent(this clsvCMRequirementEN objvCMRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, convCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(strReqContent, 4000, convCMRequirement.ReqContent);
objvCMRequirementEN.ReqContent = strReqContent; //需求内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.ReqContent) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.ReqContent, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.ReqContent] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpReqId">上级需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpReqId(this clsvCMRequirementEN objvCMRequirementEN, string strUpReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpReqId, convCMRequirement.UpReqId);
clsCheckSql.CheckFieldLen(strUpReqId, 8, convCMRequirement.UpReqId);
clsCheckSql.CheckFieldForeignKey(strUpReqId, 8, convCMRequirement.UpReqId);
objvCMRequirementEN.UpReqId = strUpReqId; //上级需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.UpReqId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.UpReqId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.UpReqId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementTypeId">需求类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementTypeId(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementTypeId, convCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(strRequirementTypeId, 4, convCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldForeignKey(strRequirementTypeId, 4, convCMRequirement.RequirementTypeId);
objvCMRequirementEN.RequirementTypeId = strRequirementTypeId; //需求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.RequirementTypeId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.RequirementTypeId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.RequirementTypeId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementTypeName">需求类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementTypeName(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRequirementTypeName, 30, convCMRequirement.RequirementTypeName);
objvCMRequirementEN.RequirementTypeName = strRequirementTypeName; //需求类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.RequirementTypeName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.RequirementTypeName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.RequirementTypeName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFinished">是否完成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetIsFinished(this clsvCMRequirementEN objvCMRequirementEN, bool bolIsFinished, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFinished, convCMRequirement.IsFinished);
objvCMRequirementEN.IsFinished = bolIsFinished; //是否完成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.IsFinished) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.IsFinished, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.IsFinished] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetCmPrjId(this clsvCMRequirementEN objvCMRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMRequirement.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMRequirement.CmPrjId);
objvCMRequirementEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.CmPrjId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.CmPrjId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.CmPrjId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetCmPrjName(this clsvCMRequirementEN objvCMRequirementEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMRequirement.CmPrjName);
objvCMRequirementEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.CmPrjName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.CmPrjName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.CmPrjName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetPrjId(this clsvCMRequirementEN objvCMRequirementEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMRequirement.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMRequirement.PrjId);
objvCMRequirementEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.PrjId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.PrjId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.PrjId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetPrjName(this clsvCMRequirementEN objvCMRequirementEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMRequirement.PrjName);
objvCMRequirementEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.PrjName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.PrjName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.PrjName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetApplicationTypeId(this clsvCMRequirementEN objvCMRequirementEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvCMRequirementEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.ApplicationTypeId) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetApplicationTypeSimName(this clsvCMRequirementEN objvCMRequirementEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMRequirement.ApplicationTypeSimName);
objvCMRequirementEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.ApplicationTypeSimName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectFileName">工程文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetProjectFileName(this clsvCMRequirementEN objvCMRequirementEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMRequirement.ProjectFileName);
objvCMRequirementEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.ProjectFileName) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.ProjectFileName, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.ProjectFileName] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpdUser(this clsvCMRequirementEN objvCMRequirementEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMRequirement.UpdUser);
objvCMRequirementEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.UpdUser) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.UpdUser, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.UpdUser] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpdDate(this clsvCMRequirementEN objvCMRequirementEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMRequirement.UpdDate);
objvCMRequirementEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.UpdDate) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.UpdDate, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.UpdDate] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetMemo(this clsvCMRequirementEN objvCMRequirementEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMRequirement.Memo);
objvCMRequirementEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMRequirementEN.dicFldComparisonOp.ContainsKey(convCMRequirement.Memo) == false)
{
objvCMRequirementEN.dicFldComparisonOp.Add(convCMRequirement.Memo, strComparisonOp);
}
else
{
objvCMRequirementEN.dicFldComparisonOp[convCMRequirement.Memo] = strComparisonOp;
}
}
return objvCMRequirementEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMRequirementEN objvCMRequirementCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMRequirementCond.IsUpdated(convCMRequirement.ReqId) == true)
{
string strComparisonOpReqId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.ReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.ReqId, objvCMRequirementCond.ReqId, strComparisonOpReqId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.RequirementName) == true)
{
string strComparisonOpRequirementName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.RequirementName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.RequirementName, objvCMRequirementCond.RequirementName, strComparisonOpRequirementName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.FuncModuleAgcId, objvCMRequirementCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.FuncModuleName, objvCMRequirementCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.ReqContent) == true)
{
string strComparisonOpReqContent = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.ReqContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.ReqContent, objvCMRequirementCond.ReqContent, strComparisonOpReqContent);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.UpReqId) == true)
{
string strComparisonOpUpReqId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.UpReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.UpReqId, objvCMRequirementCond.UpReqId, strComparisonOpUpReqId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.RequirementTypeId) == true)
{
string strComparisonOpRequirementTypeId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.RequirementTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.RequirementTypeId, objvCMRequirementCond.RequirementTypeId, strComparisonOpRequirementTypeId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.RequirementTypeName) == true)
{
string strComparisonOpRequirementTypeName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.RequirementTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.RequirementTypeName, objvCMRequirementCond.RequirementTypeName, strComparisonOpRequirementTypeName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.IsFinished) == true)
{
if (objvCMRequirementCond.IsFinished == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMRequirement.IsFinished);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMRequirement.IsFinished);
}
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.CmPrjId, objvCMRequirementCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.CmPrjName, objvCMRequirementCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.PrjId) == true)
{
string strComparisonOpPrjId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.PrjId, objvCMRequirementCond.PrjId, strComparisonOpPrjId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.PrjName) == true)
{
string strComparisonOpPrjName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.PrjName, objvCMRequirementCond.PrjName, strComparisonOpPrjName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMRequirement.ApplicationTypeId, objvCMRequirementCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.ApplicationTypeSimName, objvCMRequirementCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.ProjectFileName, objvCMRequirementCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.UpdUser, objvCMRequirementCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.UpdDate, objvCMRequirementCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMRequirementCond.IsUpdated(convCMRequirement.Memo) == true)
{
string strComparisonOpMemo = objvCMRequirementCond.dicFldComparisonOp[convCMRequirement.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMRequirement.Memo, objvCMRequirementCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM需求(vCMRequirement)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMRequirementWApi
{
private static readonly string mstrApiControllerName = "vCMRequirementApi";

 public clsvCMRequirementWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMRequirementEN GetObjByReqId(string strReqId)
{
if (strReqId == "") return null;
string strAction = "GetObjByReqId";
clsvCMRequirementEN objvCMRequirementEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strReqId"] = strReqId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMRequirementEN = JsonConvert.DeserializeObject<clsvCMRequirementEN>(strJson);
return objvCMRequirementEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCMRequirementEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMRequirementEN objvCMRequirementEN;
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
objvCMRequirementEN = JsonConvert.DeserializeObject<clsvCMRequirementEN>(strJson);
return objvCMRequirementEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLst(string strWhereCond)
{
 List<clsvCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
 /// <param name = "arrReqId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLstByReqIdLst(List<string> arrReqId)
{
 List<clsvCMRequirementEN> arrObjLst; 
string strAction = "GetObjLstByReqIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrReqId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
public static List<clsvCMRequirementEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
public static List<clsvCMRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
public static List<clsvCMRequirementEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMRequirementEN>>(strJson);
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
public static bool IsExist(string strReqId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strReqId"] = strReqId
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
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <param name = "objvCMRequirementENT">目标对象</param>
 public static void CopyTo(clsvCMRequirementEN objvCMRequirementENS, clsvCMRequirementEN objvCMRequirementENT)
{
try
{
objvCMRequirementENT.ReqId = objvCMRequirementENS.ReqId; //需求Id
objvCMRequirementENT.RequirementName = objvCMRequirementENS.RequirementName; //需求名称
objvCMRequirementENT.FuncModuleAgcId = objvCMRequirementENS.FuncModuleAgcId; //功能模块Id
objvCMRequirementENT.FuncModuleName = objvCMRequirementENS.FuncModuleName; //功能模块名称
objvCMRequirementENT.ReqContent = objvCMRequirementENS.ReqContent; //需求内容
objvCMRequirementENT.UpReqId = objvCMRequirementENS.UpReqId; //上级需求Id
objvCMRequirementENT.RequirementTypeId = objvCMRequirementENS.RequirementTypeId; //需求类型Id
objvCMRequirementENT.RequirementTypeName = objvCMRequirementENS.RequirementTypeName; //需求类型名
objvCMRequirementENT.IsFinished = objvCMRequirementENS.IsFinished; //是否完成
objvCMRequirementENT.CmPrjId = objvCMRequirementENS.CmPrjId; //Cm工程Id
objvCMRequirementENT.CmPrjName = objvCMRequirementENS.CmPrjName; //CM工程名
objvCMRequirementENT.PrjId = objvCMRequirementENS.PrjId; //工程Id
objvCMRequirementENT.PrjName = objvCMRequirementENS.PrjName; //工程名称
objvCMRequirementENT.ApplicationTypeId = objvCMRequirementENS.ApplicationTypeId; //应用程序类型ID
objvCMRequirementENT.ApplicationTypeSimName = objvCMRequirementENS.ApplicationTypeSimName; //应用程序类型简称
objvCMRequirementENT.ProjectFileName = objvCMRequirementENS.ProjectFileName; //工程文件名
objvCMRequirementENT.UpdUser = objvCMRequirementENS.UpdUser; //修改者
objvCMRequirementENT.UpdDate = objvCMRequirementENS.UpdDate; //修改日期
objvCMRequirementENT.Memo = objvCMRequirementENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMRequirementEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMRequirementEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMRequirementEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMRequirementEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMRequirementEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMRequirementEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMRequirementWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMRequirementWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMRequirementEN._CurrTabName, strPrjId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMRequirementEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMRequirement.ReqId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.RequirementName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.ReqContent, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.UpReqId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.RequirementTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.RequirementTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.IsFinished, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMRequirement.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMRequirement.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.ProjectFileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMRequirement.Memo, Type.GetType("System.String"));
foreach (clsvCMRequirementEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMRequirement.ReqId] = objInFor[convCMRequirement.ReqId];
objDR[convCMRequirement.RequirementName] = objInFor[convCMRequirement.RequirementName];
objDR[convCMRequirement.FuncModuleAgcId] = objInFor[convCMRequirement.FuncModuleAgcId];
objDR[convCMRequirement.FuncModuleName] = objInFor[convCMRequirement.FuncModuleName];
objDR[convCMRequirement.ReqContent] = objInFor[convCMRequirement.ReqContent];
objDR[convCMRequirement.UpReqId] = objInFor[convCMRequirement.UpReqId];
objDR[convCMRequirement.RequirementTypeId] = objInFor[convCMRequirement.RequirementTypeId];
objDR[convCMRequirement.RequirementTypeName] = objInFor[convCMRequirement.RequirementTypeName];
objDR[convCMRequirement.IsFinished] = objInFor[convCMRequirement.IsFinished];
objDR[convCMRequirement.CmPrjId] = objInFor[convCMRequirement.CmPrjId];
objDR[convCMRequirement.CmPrjName] = objInFor[convCMRequirement.CmPrjName];
objDR[convCMRequirement.PrjId] = objInFor[convCMRequirement.PrjId];
objDR[convCMRequirement.PrjName] = objInFor[convCMRequirement.PrjName];
objDR[convCMRequirement.ApplicationTypeId] = objInFor[convCMRequirement.ApplicationTypeId];
objDR[convCMRequirement.ApplicationTypeSimName] = objInFor[convCMRequirement.ApplicationTypeSimName];
objDR[convCMRequirement.ProjectFileName] = objInFor[convCMRequirement.ProjectFileName];
objDR[convCMRequirement.UpdUser] = objInFor[convCMRequirement.UpdUser];
objDR[convCMRequirement.UpdDate] = objInFor[convCMRequirement.UpdDate];
objDR[convCMRequirement.Memo] = objInFor[convCMRequirement.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}