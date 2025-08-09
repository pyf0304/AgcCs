
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMRequirementWApi
 表名:CMRequirement(00050075)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsCMRequirementWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqId">需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetReqId(this clsCMRequirementEN objCMRequirementEN, string strReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReqId, 8, conCMRequirement.ReqId);
clsCheckSql.CheckFieldForeignKey(strReqId, 8, conCMRequirement.ReqId);
objCMRequirementEN.ReqId = strReqId; //需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.ReqId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.ReqId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.ReqId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementName">需求名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetRequirementName(this clsCMRequirementEN objCMRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, conCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(strRequirementName, 50, conCMRequirement.RequirementName);
objCMRequirementEN.RequirementName = strRequirementName; //需求名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.RequirementName) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.RequirementName, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.RequirementName] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementTypeId">需求类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetRequirementTypeId(this clsCMRequirementEN objCMRequirementEN, string strRequirementTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementTypeId, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(strRequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldForeignKey(strRequirementTypeId, 4, conCMRequirement.RequirementTypeId);
objCMRequirementEN.RequirementTypeId = strRequirementTypeId; //需求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.RequirementTypeId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.RequirementTypeId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.RequirementTypeId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqContent">需求内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetReqContent(this clsCMRequirementEN objCMRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, conCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(strReqContent, 4000, conCMRequirement.ReqContent);
objCMRequirementEN.ReqContent = strReqContent; //需求内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.ReqContent) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.ReqContent, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.ReqContent] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpReqId">上级需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpReqId(this clsCMRequirementEN objCMRequirementEN, string strUpReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpReqId, 8, conCMRequirement.UpReqId);
clsCheckSql.CheckFieldForeignKey(strUpReqId, 8, conCMRequirement.UpReqId);
objCMRequirementEN.UpReqId = strUpReqId; //上级需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpReqId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpReqId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpReqId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFinished">是否完成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsFinished(this clsCMRequirementEN objCMRequirementEN, bool bolIsFinished, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFinished, conCMRequirement.IsFinished);
objCMRequirementEN.IsFinished = bolIsFinished; //是否完成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsFinished) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsFinished, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsFinished] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetCmPrjId(this clsCMRequirementEN objCMRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMRequirement.CmPrjId);
objCMRequirementEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.CmPrjId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.CmPrjId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.CmPrjId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetFuncModuleAgcId(this clsCMRequirementEN objCMRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
objCMRequirementEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.FuncModuleAgcId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetPrjId(this clsCMRequirementEN objCMRequirementEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMRequirement.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMRequirement.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMRequirement.PrjId);
objCMRequirementEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.PrjId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.PrjId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.PrjId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpdUser(this clsCMRequirementEN objCMRequirementEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMRequirement.UpdUser);
objCMRequirementEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpdUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpdUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpdUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpdDate(this clsCMRequirementEN objCMRequirementEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMRequirement.UpdDate);
objCMRequirementEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpdDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpdDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpdDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetMemo(this clsCMRequirementEN objCMRequirementEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMRequirement.Memo);
objCMRequirementEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.Memo) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.Memo, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.Memo] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToServer">是否同步到Server</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsSynchToServer(this clsCMRequirementEN objCMRequirementEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMRequirementEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsSynchToServer) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsSynchToServer, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsSynchToServer] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerDate">同步到Server日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToServerDate(this clsCMRequirementEN objCMRequirementEN, string strSynchToServerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMRequirement.SynchToServerDate);
objCMRequirementEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToServerDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToServerDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToServerDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerUser">同步到Server用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToServerUser(this clsCMRequirementEN objCMRequirementEN, string strSynchToServerUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMRequirement.SynchToServerUser);
objCMRequirementEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToServerUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToServerUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToServerUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToClient">是否同步到Client</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsSynchToClient(this clsCMRequirementEN objCMRequirementEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMRequirementEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsSynchToClient) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsSynchToClient, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsSynchToClient] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientDate">同步到Client库日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToClientDate(this clsCMRequirementEN objCMRequirementEN, string strSynchToClientDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMRequirement.SynchToClientDate);
objCMRequirementEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToClientDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToClientDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToClientDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientUser">同步到Client库用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToClientUser(this clsCMRequirementEN objCMRequirementEN, string strSynchToClientUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMRequirement.SynchToClientUser);
objCMRequirementEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToClientUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToClientUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToClientUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynSource">同步来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynSource(this clsCMRequirementEN objCMRequirementEN, string strSynSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMRequirement.SynSource);
objCMRequirementEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynSource) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynSource, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynSource] = strComparisonOp;
}
}
return objCMRequirementEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMRequirementEN objCMRequirementCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMRequirementCond.IsUpdated(conCMRequirement.ReqId) == true)
{
string strComparisonOpReqId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.ReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.ReqId, objCMRequirementCond.ReqId, strComparisonOpReqId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.RequirementName) == true)
{
string strComparisonOpRequirementName = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.RequirementName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.RequirementName, objCMRequirementCond.RequirementName, strComparisonOpRequirementName);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.RequirementTypeId) == true)
{
string strComparisonOpRequirementTypeId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.RequirementTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.RequirementTypeId, objCMRequirementCond.RequirementTypeId, strComparisonOpRequirementTypeId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.ReqContent) == true)
{
string strComparisonOpReqContent = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.ReqContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.ReqContent, objCMRequirementCond.ReqContent, strComparisonOpReqContent);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpReqId) == true)
{
string strComparisonOpUpReqId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpReqId, objCMRequirementCond.UpReqId, strComparisonOpUpReqId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsFinished) == true)
{
if (objCMRequirementCond.IsFinished == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsFinished);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsFinished);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.CmPrjId, objCMRequirementCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.FuncModuleAgcId, objCMRequirementCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.PrjId) == true)
{
string strComparisonOpPrjId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.PrjId, objCMRequirementCond.PrjId, strComparisonOpPrjId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpdUser, objCMRequirementCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpdDate, objCMRequirementCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.Memo) == true)
{
string strComparisonOpMemo = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.Memo, objCMRequirementCond.Memo, strComparisonOpMemo);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsSynchToServer) == true)
{
if (objCMRequirementCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsSynchToServer);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToServerDate, objCMRequirementCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToServerUser, objCMRequirementCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsSynchToClient) == true)
{
if (objCMRequirementCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsSynchToClient);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToClientDate, objCMRequirementCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToClientUser, objCMRequirementCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynSource) == true)
{
string strComparisonOpSynSource = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynSource, objCMRequirementCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMRequirementEN objCMRequirementEN)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMRequirementEN.sfUpdFldSetStr = objCMRequirementEN.getsfUpdFldSetStr();
clsCMRequirementWApi.CheckPropertyNew(objCMRequirementEN); 
bool bolResult = clsCMRequirementWApi.UpdateRecord(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
 /// 获取唯一性条件串--CMRequirement(项目需求), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequirementName_CMPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMRequirementEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMRequirementEN objCMRequirementEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMRequirementEN == null) return "";
if (objCMRequirementEN.ReqId == null || objCMRequirementEN.ReqId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReqId !=  '{0}'", objCMRequirementEN.ReqId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMRequirementEN objCMRequirementEN)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementWApi.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCMRequirementWApi.CheckPropertyNew(objCMRequirementEN); 
bool bolResult = clsCMRequirementWApi.AddNewRecord(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMRequirementEN objCMRequirementEN)
{
try
{
clsCMRequirementWApi.CheckPropertyNew(objCMRequirementEN); 
string strReqId = clsCMRequirementWApi.AddNewRecordWithMaxId(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
return strReqId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMRequirementEN objCMRequirementEN, string strWhereCond)
{
try
{
clsCMRequirementWApi.CheckPropertyNew(objCMRequirementEN); 
bool bolResult = clsCMRequirementWApi.UpdateWithCondition(objCMRequirementEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
 /// 项目需求(CMRequirement)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMRequirementWApi
{
private static readonly string mstrApiControllerName = "CMRequirementApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCMRequirementWApi()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_ReqId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMRequirement.ReqId); 
List<clsCMRequirementEN> arrObjLst = clsCMRequirementWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN()
{
ReqId = "0",
RequirementName = "选[项目需求]..."
};
arrObjLstSel.Insert(0, objCMRequirementEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMRequirement.ReqId;
objComboBox.DisplayMember = conCMRequirement.RequirementName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMRequirementEN objCMRequirementEN)
{
if (!Object.Equals(null, objCMRequirementEN.ReqId) && GetStrLen(objCMRequirementEN.ReqId) > 8)
{
 throw new Exception("字段[需求Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMRequirementEN.RequirementName) && GetStrLen(objCMRequirementEN.RequirementName) > 50)
{
 throw new Exception("字段[需求名称]的长度不能超过50!");
}
if (!Object.Equals(null, objCMRequirementEN.RequirementTypeId) && GetStrLen(objCMRequirementEN.RequirementTypeId) > 4)
{
 throw new Exception("字段[需求类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMRequirementEN.ReqContent) && GetStrLen(objCMRequirementEN.ReqContent) > 4000)
{
 throw new Exception("字段[需求内容]的长度不能超过4000!");
}
if (!Object.Equals(null, objCMRequirementEN.UpReqId) && GetStrLen(objCMRequirementEN.UpReqId) > 8)
{
 throw new Exception("字段[上级需求Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMRequirementEN.CmPrjId) && GetStrLen(objCMRequirementEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objCMRequirementEN.FuncModuleAgcId) && GetStrLen(objCMRequirementEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMRequirementEN.PrjId) && GetStrLen(objCMRequirementEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMRequirementEN.UpdUser) && GetStrLen(objCMRequirementEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.UpdDate) && GetStrLen(objCMRequirementEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.Memo) && GetStrLen(objCMRequirementEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objCMRequirementEN.SynchToServerDate) && GetStrLen(objCMRequirementEN.SynchToServerDate) > 20)
{
 throw new Exception("字段[同步到Server日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.SynchToServerUser) && GetStrLen(objCMRequirementEN.SynchToServerUser) > 20)
{
 throw new Exception("字段[同步到Server用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.SynchToClientDate) && GetStrLen(objCMRequirementEN.SynchToClientDate) > 20)
{
 throw new Exception("字段[同步到Client库日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.SynchToClientUser) && GetStrLen(objCMRequirementEN.SynchToClientUser) > 20)
{
 throw new Exception("字段[同步到Client库用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMRequirementEN.SynSource) && GetStrLen(objCMRequirementEN.SynSource) > 50)
{
 throw new Exception("字段[同步来源]的长度不能超过50!");
}
 objCMRequirementEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMRequirementEN GetObjByReqId(string strReqId)
{
if (strReqId == "") return null;
string strAction = "GetObjByReqId";
clsCMRequirementEN objCMRequirementEN;
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
objCMRequirementEN = JsonConvert.DeserializeObject<clsCMRequirementEN>(strJson);
return objCMRequirementEN;
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
public static clsCMRequirementEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMRequirementEN objCMRequirementEN;
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
objCMRequirementEN = JsonConvert.DeserializeObject<clsCMRequirementEN>(strJson);
return objCMRequirementEN;
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
 /// <param name = "strReqId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMRequirementEN GetObjByReqIdCache(string strReqId,string strPrjId)
{
if (string.IsNullOrEmpty(strReqId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrCMRequirementObjLst_Sel =
from objCMRequirementEN in arrCMRequirementObjLstCache
where objCMRequirementEN.ReqId == strReqId 
select objCMRequirementEN;
if (arrCMRequirementObjLst_Sel.Count() == 0)
{
   clsCMRequirementEN obj = clsCMRequirementWApi.GetObjByReqId(strReqId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMRequirementObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMRequirementEN> GetObjLst(string strWhereCond)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
public static List<clsCMRequirementEN> GetObjLstByReqIdLst(List<string> arrReqId)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
 /// <param name = "arrReqId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCMRequirementEN> GetObjLstByReqIdLstCache(List<string> arrReqId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrCMRequirementObjLst_Sel =
from objCMRequirementEN in arrCMRequirementObjLstCache
where arrReqId.Contains(objCMRequirementEN.ReqId)
select objCMRequirementEN;
return arrCMRequirementObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMRequirementEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
public static List<clsCMRequirementEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
public static List<clsCMRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
public static List<clsCMRequirementEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMRequirementEN>>(strJson);
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
public static int DelRecord(string strReqId)
{
string strAction = "DelRecord";
try
{
 clsCMRequirementEN objCMRequirementEN = clsCMRequirementWApi.GetObjByReqId(strReqId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strReqId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
public static int DelCMRequirements(List<string> arrReqId)
{
string strAction = "DelCMRequirements";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrReqId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsCMRequirementEN objCMRequirementEN = clsCMRequirementWApi.GetObjByReqId(arrReqId[0]);
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
public static int DelCMRequirementsByCond(string strWhereCond)
{
string strAction = "DelCMRequirementsByCond";
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
public static bool AddNewRecord(clsCMRequirementEN objCMRequirementEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMRequirementEN>(objCMRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsCMRequirementEN objCMRequirementEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMRequirementEN>(objCMRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementWApi.ReFreshCache(objCMRequirementEN.PrjId);
var strReqId = (string)jobjReturn0["returnStr"];
return strReqId;
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
public static bool UpdateRecord(clsCMRequirementEN objCMRequirementEN)
{
if (string.IsNullOrEmpty(objCMRequirementEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMRequirementEN.ReqId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMRequirementEN>(objCMRequirementEN);
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMRequirementEN objCMRequirementEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMRequirementEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMRequirementEN.ReqId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMRequirementEN.ReqId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMRequirementEN>(objCMRequirementEN);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMRequirementENS">源对象</param>
 /// <param name = "objCMRequirementENT">目标对象</param>
 public static void CopyTo(clsCMRequirementEN objCMRequirementENS, clsCMRequirementEN objCMRequirementENT)
{
try
{
objCMRequirementENT.ReqId = objCMRequirementENS.ReqId; //需求Id
objCMRequirementENT.RequirementName = objCMRequirementENS.RequirementName; //需求名称
objCMRequirementENT.RequirementTypeId = objCMRequirementENS.RequirementTypeId; //需求类型Id
objCMRequirementENT.ReqContent = objCMRequirementENS.ReqContent; //需求内容
objCMRequirementENT.UpReqId = objCMRequirementENS.UpReqId; //上级需求Id
objCMRequirementENT.IsFinished = objCMRequirementENS.IsFinished; //是否完成
objCMRequirementENT.CmPrjId = objCMRequirementENS.CmPrjId; //Cm工程Id
objCMRequirementENT.FuncModuleAgcId = objCMRequirementENS.FuncModuleAgcId; //功能模块Id
objCMRequirementENT.PrjId = objCMRequirementENS.PrjId; //工程Id
objCMRequirementENT.UpdUser = objCMRequirementENS.UpdUser; //修改者
objCMRequirementENT.UpdDate = objCMRequirementENS.UpdDate; //修改日期
objCMRequirementENT.Memo = objCMRequirementENS.Memo; //说明
objCMRequirementENT.IsSynchToServer = objCMRequirementENS.IsSynchToServer; //是否同步到Server
objCMRequirementENT.SynchToServerDate = objCMRequirementENS.SynchToServerDate; //同步到Server日期
objCMRequirementENT.SynchToServerUser = objCMRequirementENS.SynchToServerUser; //同步到Server用户
objCMRequirementENT.IsSynchToClient = objCMRequirementENS.IsSynchToClient; //是否同步到Client
objCMRequirementENT.SynchToClientDate = objCMRequirementENS.SynchToClientDate; //同步到Client库日期
objCMRequirementENT.SynchToClientUser = objCMRequirementENS.SynchToClientUser; //同步到Client库用户
objCMRequirementENT.SynSource = objCMRequirementENS.SynSource; //同步来源
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
public static DataTable ToDataTable(List<clsCMRequirementEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMRequirementEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMRequirementEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMRequirementEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMRequirementEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMRequirementEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMRequirementWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMRequirementWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCMRequirementWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMRequirementWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMRequirementWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMRequirementWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsCMRequirementEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsCMRequirementEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conCMRequirement.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMRequirementObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsCMRequirementEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMRequirementWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMRequirementWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrCMRequirementObjLstCache = CacheHelper.Get<List<clsCMRequirementEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrCMRequirementObjLstCache = CacheHelper.Get<List<clsCMRequirementEN>>(strKey);
}
return arrCMRequirementObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMRequirementEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMRequirement.ReqId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.RequirementName, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.RequirementTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.ReqContent, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.UpReqId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.IsFinished, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMRequirement.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.IsSynchToServer, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMRequirement.SynchToServerDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.SynchToServerUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.IsSynchToClient, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMRequirement.SynchToClientDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.SynchToClientUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMRequirement.SynSource, Type.GetType("System.String"));
foreach (clsCMRequirementEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMRequirement.ReqId] = objInFor[conCMRequirement.ReqId];
objDR[conCMRequirement.RequirementName] = objInFor[conCMRequirement.RequirementName];
objDR[conCMRequirement.RequirementTypeId] = objInFor[conCMRequirement.RequirementTypeId];
objDR[conCMRequirement.ReqContent] = objInFor[conCMRequirement.ReqContent];
objDR[conCMRequirement.UpReqId] = objInFor[conCMRequirement.UpReqId];
objDR[conCMRequirement.IsFinished] = objInFor[conCMRequirement.IsFinished];
objDR[conCMRequirement.CmPrjId] = objInFor[conCMRequirement.CmPrjId];
objDR[conCMRequirement.FuncModuleAgcId] = objInFor[conCMRequirement.FuncModuleAgcId];
objDR[conCMRequirement.PrjId] = objInFor[conCMRequirement.PrjId];
objDR[conCMRequirement.UpdUser] = objInFor[conCMRequirement.UpdUser];
objDR[conCMRequirement.UpdDate] = objInFor[conCMRequirement.UpdDate];
objDR[conCMRequirement.Memo] = objInFor[conCMRequirement.Memo];
objDR[conCMRequirement.IsSynchToServer] = objInFor[conCMRequirement.IsSynchToServer];
objDR[conCMRequirement.SynchToServerDate] = objInFor[conCMRequirement.SynchToServerDate];
objDR[conCMRequirement.SynchToServerUser] = objInFor[conCMRequirement.SynchToServerUser];
objDR[conCMRequirement.IsSynchToClient] = objInFor[conCMRequirement.IsSynchToClient];
objDR[conCMRequirement.SynchToClientDate] = objInFor[conCMRequirement.SynchToClientDate];
objDR[conCMRequirement.SynchToClientUser] = objInFor[conCMRequirement.SynchToClientUser];
objDR[conCMRequirement.SynSource] = objInFor[conCMRequirement.SynSource];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 项目需求(CMRequirement)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMRequirement : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsCMRequirementWApi.ReFreshThisCache(strPrjId);
}
}

}