
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMRequirementBL
 表名:vCMRequirement(00050260)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMRequirementBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMRequirementEN GetObj(this K_ReqId_vCMRequirement myKey)
{
clsvCMRequirementEN objvCMRequirementEN = clsvCMRequirementBL.vCMRequirementDA.GetObjByReqId(myKey.Value);
return objvCMRequirementEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetReqId(this clsvCMRequirementEN objvCMRequirementEN, string strReqId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqId, 8, convCMRequirement.ReqId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReqId, 8, convCMRequirement.ReqId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementName(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, convCMRequirement.RequirementName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementName, 50, convCMRequirement.RequirementName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetFuncModuleAgcId(this clsvCMRequirementEN objvCMRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMRequirement.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMRequirement.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetFuncModuleName(this clsvCMRequirementEN objvCMRequirementEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMRequirement.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetReqContent(this clsvCMRequirementEN objvCMRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, convCMRequirement.ReqContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqContent, 4000, convCMRequirement.ReqContent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpReqId(this clsvCMRequirementEN objvCMRequirementEN, string strUpReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpReqId, convCMRequirement.UpReqId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpReqId, 8, convCMRequirement.UpReqId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpReqId, 8, convCMRequirement.UpReqId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementTypeId(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementTypeId, convCMRequirement.RequirementTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementTypeId, 4, convCMRequirement.RequirementTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequirementTypeId, 4, convCMRequirement.RequirementTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetRequirementTypeName(this clsvCMRequirementEN objvCMRequirementEN, string strRequirementTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementTypeName, 30, convCMRequirement.RequirementTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetCmPrjId(this clsvCMRequirementEN objvCMRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMRequirement.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMRequirement.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMRequirement.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetCmPrjName(this clsvCMRequirementEN objvCMRequirementEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMRequirement.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetPrjId(this clsvCMRequirementEN objvCMRequirementEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMRequirement.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMRequirement.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetPrjName(this clsvCMRequirementEN objvCMRequirementEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMRequirement.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetApplicationTypeId(this clsvCMRequirementEN objvCMRequirementEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetApplicationTypeSimName(this clsvCMRequirementEN objvCMRequirementEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMRequirement.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetProjectFileName(this clsvCMRequirementEN objvCMRequirementEN, string strProjectFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMRequirement.ProjectFileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpdUser(this clsvCMRequirementEN objvCMRequirementEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMRequirement.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetUpdDate(this clsvCMRequirementEN objvCMRequirementEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMRequirement.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMRequirementEN SetMemo(this clsvCMRequirementEN objvCMRequirementEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMRequirement.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <param name = "objvCMRequirementENT">目标对象</param>
 public static void CopyTo(this clsvCMRequirementEN objvCMRequirementENS, clsvCMRequirementEN objvCMRequirementENT)
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
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <returns>目标对象=>clsvCMRequirementEN:objvCMRequirementENT</returns>
 public static clsvCMRequirementEN CopyTo(this clsvCMRequirementEN objvCMRequirementENS)
{
try
{
 clsvCMRequirementEN objvCMRequirementENT = new clsvCMRequirementEN()
{
ReqId = objvCMRequirementENS.ReqId, //需求Id
RequirementName = objvCMRequirementENS.RequirementName, //需求名称
FuncModuleAgcId = objvCMRequirementENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCMRequirementENS.FuncModuleName, //功能模块名称
ReqContent = objvCMRequirementENS.ReqContent, //需求内容
UpReqId = objvCMRequirementENS.UpReqId, //上级需求Id
RequirementTypeId = objvCMRequirementENS.RequirementTypeId, //需求类型Id
RequirementTypeName = objvCMRequirementENS.RequirementTypeName, //需求类型名
IsFinished = objvCMRequirementENS.IsFinished, //是否完成
CmPrjId = objvCMRequirementENS.CmPrjId, //Cm工程Id
CmPrjName = objvCMRequirementENS.CmPrjName, //CM工程名
PrjId = objvCMRequirementENS.PrjId, //工程Id
PrjName = objvCMRequirementENS.PrjName, //工程名称
ApplicationTypeId = objvCMRequirementENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeSimName = objvCMRequirementENS.ApplicationTypeSimName, //应用程序类型简称
ProjectFileName = objvCMRequirementENS.ProjectFileName, //工程文件名
UpdUser = objvCMRequirementENS.UpdUser, //修改者
UpdDate = objvCMRequirementENS.UpdDate, //修改日期
Memo = objvCMRequirementENS.Memo, //说明
};
 return objvCMRequirementENT;
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
public static void CheckProperty4Condition(this clsvCMRequirementEN objvCMRequirementEN)
{
 clsvCMRequirementBL.vCMRequirementDA.CheckProperty4Condition(objvCMRequirementEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMRequirement
{
public virtual bool UpdRelaTabDate(string strReqId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM需求(vCMRequirement)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMRequirementBL
{
public static RelatedActions_vCMRequirement relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMRequirementDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMRequirementDA vCMRequirementDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMRequirementDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMRequirementBL()
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
if (string.IsNullOrEmpty(clsvCMRequirementEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMRequirementEN._ConnectString);
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
public static DataTable GetDataTable_vCMRequirement(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMRequirementDA.GetDataTable_vCMRequirement(strWhereCond);
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
objDT = vCMRequirementDA.GetDataTable(strWhereCond);
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
objDT = vCMRequirementDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMRequirementDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMRequirementDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMRequirementDA.GetDataTable_Top(objTopPara);
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
objDT = vCMRequirementDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrReqIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLstByReqIdLst(List<string> arrReqIdLst)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrReqIdLst, true);
 string strWhereCond = string.Format("ReqId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReqIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMRequirementEN> GetObjLstByReqIdLstCache(List<string> arrReqIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMRequirementEN._CurrTabName, strPrjId);
List<clsvCMRequirementEN> arrvCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMRequirementEN> arrvCMRequirementObjLst_Sel =
arrvCMRequirementObjLstCache
.Where(x => arrReqIdLst.Contains(x.ReqId));
return arrvCMRequirementObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLst(string strWhereCond)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
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
public static List<clsvCMRequirementEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMRequirementEN> GetSubObjLstCache(clsvCMRequirementEN objvCMRequirementCond)
{
 string strPrjId = objvCMRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMRequirementBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMRequirement._AttributeName)
{
if (objvCMRequirementCond.IsUpdated(strFldName) == false) continue;
if (objvCMRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMRequirementCond[strFldName].ToString());
}
else
{
if (objvCMRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMRequirementCond[strFldName]));
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
public static List<clsvCMRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
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
public static List<clsvCMRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
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
List<clsvCMRequirementEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMRequirementEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
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
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
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
public static List<clsvCMRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
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
public static List<clsvCMRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMRequirementEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMRequirement(ref clsvCMRequirementEN objvCMRequirementEN)
{
bool bolResult = vCMRequirementDA.GetvCMRequirement(ref objvCMRequirementEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMRequirementEN GetObjByReqId(string strReqId)
{
if (strReqId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strReqId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strReqId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strReqId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMRequirementEN objvCMRequirementEN = vCMRequirementDA.GetObjByReqId(strReqId);
return objvCMRequirementEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMRequirementEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMRequirementEN objvCMRequirementEN = vCMRequirementDA.GetFirstObj(strWhereCond);
 return objvCMRequirementEN;
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
public static clsvCMRequirementEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMRequirementEN objvCMRequirementEN = vCMRequirementDA.GetObjByDataRow(objRow);
 return objvCMRequirementEN;
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
public static clsvCMRequirementEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMRequirementEN objvCMRequirementEN = vCMRequirementDA.GetObjByDataRow(objRow);
 return objvCMRequirementEN;
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
 /// <param name = "strReqId">所给的关键字</param>
 /// <param name = "lstvCMRequirementObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMRequirementEN GetObjByReqIdFromList(string strReqId, List<clsvCMRequirementEN> lstvCMRequirementObjLst)
{
foreach (clsvCMRequirementEN objvCMRequirementEN in lstvCMRequirementObjLst)
{
if (objvCMRequirementEN.ReqId == strReqId)
{
return objvCMRequirementEN;
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
 string strReqId;
 try
 {
 strReqId = new clsvCMRequirementDA().GetFirstID(strWhereCond);
 return strReqId;
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
 arrList = vCMRequirementDA.GetID(strWhereCond);
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
bool bolIsExist = vCMRequirementDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strReqId)
{
if (string.IsNullOrEmpty(strReqId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strReqId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMRequirementDA.IsExist(strReqId);
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
 bolIsExist = clsvCMRequirementDA.IsExistTable();
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
 bolIsExist = vCMRequirementDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMRequirementEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMRequirementEN objvCMRequirementEN)
{
try
{
objvCMRequirementEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMRequirementEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMRequirement.ReqId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.ReqId = objvCMRequirementEN.ReqId; //需求Id
}
if (arrFldSet.Contains(convCMRequirement.RequirementName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.RequirementName = objvCMRequirementEN.RequirementName; //需求名称
}
if (arrFldSet.Contains(convCMRequirement.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.FuncModuleAgcId = objvCMRequirementEN.FuncModuleAgcId == "[null]" ? null :  objvCMRequirementEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMRequirement.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.FuncModuleName = objvCMRequirementEN.FuncModuleName == "[null]" ? null :  objvCMRequirementEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCMRequirement.ReqContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.ReqContent = objvCMRequirementEN.ReqContent; //需求内容
}
if (arrFldSet.Contains(convCMRequirement.UpReqId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.UpReqId = objvCMRequirementEN.UpReqId; //上级需求Id
}
if (arrFldSet.Contains(convCMRequirement.RequirementTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.RequirementTypeId = objvCMRequirementEN.RequirementTypeId; //需求类型Id
}
if (arrFldSet.Contains(convCMRequirement.RequirementTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.RequirementTypeName = objvCMRequirementEN.RequirementTypeName == "[null]" ? null :  objvCMRequirementEN.RequirementTypeName; //需求类型名
}
if (arrFldSet.Contains(convCMRequirement.IsFinished, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.IsFinished = objvCMRequirementEN.IsFinished; //是否完成
}
if (arrFldSet.Contains(convCMRequirement.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.CmPrjId = objvCMRequirementEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMRequirement.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.CmPrjName = objvCMRequirementEN.CmPrjName == "[null]" ? null :  objvCMRequirementEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMRequirement.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.PrjId = objvCMRequirementEN.PrjId == "[null]" ? null :  objvCMRequirementEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMRequirement.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.PrjName = objvCMRequirementEN.PrjName == "[null]" ? null :  objvCMRequirementEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMRequirement.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.ApplicationTypeId = objvCMRequirementEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMRequirement.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.ApplicationTypeSimName = objvCMRequirementEN.ApplicationTypeSimName == "[null]" ? null :  objvCMRequirementEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMRequirement.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.ProjectFileName = objvCMRequirementEN.ProjectFileName == "[null]" ? null :  objvCMRequirementEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(convCMRequirement.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.UpdUser = objvCMRequirementEN.UpdUser == "[null]" ? null :  objvCMRequirementEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMRequirement.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.UpdDate = objvCMRequirementEN.UpdDate == "[null]" ? null :  objvCMRequirementEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMRequirement.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMRequirementEN.Memo = objvCMRequirementEN.Memo == "[null]" ? null :  objvCMRequirementEN.Memo; //说明
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
 /// <param name = "objvCMRequirementEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMRequirementEN objvCMRequirementEN)
{
try
{
if (objvCMRequirementEN.FuncModuleAgcId == "[null]") objvCMRequirementEN.FuncModuleAgcId = null; //功能模块Id
if (objvCMRequirementEN.FuncModuleName == "[null]") objvCMRequirementEN.FuncModuleName = null; //功能模块名称
if (objvCMRequirementEN.RequirementTypeName == "[null]") objvCMRequirementEN.RequirementTypeName = null; //需求类型名
if (objvCMRequirementEN.CmPrjName == "[null]") objvCMRequirementEN.CmPrjName = null; //CM工程名
if (objvCMRequirementEN.PrjId == "[null]") objvCMRequirementEN.PrjId = null; //工程Id
if (objvCMRequirementEN.PrjName == "[null]") objvCMRequirementEN.PrjName = null; //工程名称
if (objvCMRequirementEN.ApplicationTypeSimName == "[null]") objvCMRequirementEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMRequirementEN.ProjectFileName == "[null]") objvCMRequirementEN.ProjectFileName = null; //工程文件名
if (objvCMRequirementEN.UpdUser == "[null]") objvCMRequirementEN.UpdUser = null; //修改者
if (objvCMRequirementEN.UpdDate == "[null]") objvCMRequirementEN.UpdDate = null; //修改日期
if (objvCMRequirementEN.Memo == "[null]") objvCMRequirementEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMRequirementEN objvCMRequirementEN)
{
 vCMRequirementDA.CheckProperty4Condition(objvCMRequirementEN);
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
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMRequirementBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMRequirementBL没有刷新缓存机制(clsCMRequirementBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMRequirementTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMRequirementTypeBL没有刷新缓存机制(clsCMRequirementTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReqId");
//if (arrvCMRequirementObjLstCache == null)
//{
//arrvCMRequirementObjLstCache = vCMRequirementDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReqId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMRequirementEN GetObjByReqIdCache(string strReqId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMRequirementEN._CurrTabName, strPrjId);
List<clsvCMRequirementEN> arrvCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMRequirementEN> arrvCMRequirementObjLst_Sel =
arrvCMRequirementObjLstCache
.Where(x=> x.ReqId == strReqId 
);
if (arrvCMRequirementObjLst_Sel.Count() == 0)
{
   clsvCMRequirementEN obj = clsvCMRequirementBL.GetObjByReqId(strReqId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strReqId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMRequirementObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMRequirementEN> GetAllvCMRequirementObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMRequirementEN> arrvCMRequirementObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMRequirementObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMRequirementEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMRequirementEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMRequirementEN> arrvCMRequirementObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMRequirementObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCMRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMRequirementEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMRequirementEN._RefreshTimeLst.Count == 0) return "";
return clsvCMRequirementEN._RefreshTimeLst[clsvCMRequirementEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strReqId, string strPrjId)
{
if (strInFldName != convCMRequirement.ReqId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMRequirement._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMRequirement._AttributeName));
throw new Exception(strMsg);
}
var objvCMRequirement = clsvCMRequirementBL.GetObjByReqIdCache(strReqId, strPrjId);
if (objvCMRequirement == null) return "";
return objvCMRequirement[strOutFldName].ToString();
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
int intRecCount = clsvCMRequirementDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMRequirementDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMRequirementDA.GetRecCount();
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
int intRecCount = clsvCMRequirementDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMRequirementEN objvCMRequirementCond)
{
 string strPrjId = objvCMRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMRequirementBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMRequirement._AttributeName)
{
if (objvCMRequirementCond.IsUpdated(strFldName) == false) continue;
if (objvCMRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMRequirementCond[strFldName].ToString());
}
else
{
if (objvCMRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMRequirementCond[strFldName]));
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
 List<string> arrList = clsvCMRequirementDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMRequirementDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMRequirementDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}