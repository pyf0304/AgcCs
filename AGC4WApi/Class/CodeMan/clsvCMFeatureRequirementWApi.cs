
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureRequirementWApi
 表名:vCMFeatureRequirement(00050521)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:54
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
public static class  clsvCMFeatureRequirementWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetmId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, long lngmId, string strComparisonOp="")
	{
objvCMFeatureRequirementEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.mId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.mId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.mId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmFeatureId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureId, convCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, convCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, convCMFeatureRequirement.CmFeatureId);
objvCMFeatureRequirementEN.CmFeatureId = strCmFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.CmFeatureId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.CmFeatureId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.CmFeatureId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetFeatureName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convCMFeatureRequirement.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convCMFeatureRequirement.FeatureName);
objvCMFeatureRequirementEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.FeatureName) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.FeatureName, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.FeatureName] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmParentFeatureId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, convCMFeatureRequirement.CmParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, convCMFeatureRequirement.CmParentFeatureId);
objvCMFeatureRequirementEN.CmParentFeatureId = strCmParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.CmParentFeatureId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.CmParentFeatureId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.CmParentFeatureId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetParentFeatureName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convCMFeatureRequirement.ParentFeatureName);
objvCMFeatureRequirementEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.ParentFeatureName) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.ParentFeatureName, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.ParentFeatureName] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetFuncModuleAgcId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMFeatureRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMFeatureRequirement.FuncModuleAgcId);
objvCMFeatureRequirementEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.FuncModuleAgcId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmPrjId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMFeatureRequirement.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMFeatureRequirement.CmPrjId);
objvCMFeatureRequirementEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.CmPrjId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.CmPrjId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.CmPrjId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqId">需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetReqId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqId, convCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(strReqId, 8, convCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldForeignKey(strReqId, 8, convCMFeatureRequirement.ReqId);
objvCMFeatureRequirementEN.ReqId = strReqId; //需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.ReqId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.ReqId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.ReqId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetPrjId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFeatureRequirement.PrjId);
objvCMFeatureRequirementEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.PrjId) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.PrjId, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.PrjId] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strRequirementName">需求名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetRequirementName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, convCMFeatureRequirement.RequirementName);
clsCheckSql.CheckFieldLen(strRequirementName, 50, convCMFeatureRequirement.RequirementName);
objvCMFeatureRequirementEN.RequirementName = strRequirementName; //需求名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.RequirementName) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.RequirementName, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.RequirementName] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetOrderNum(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMFeatureRequirement.OrderNum);
objvCMFeatureRequirementEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.OrderNum) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.OrderNum, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.OrderNum] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqContent">需求内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetReqContent(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, convCMFeatureRequirement.ReqContent);
clsCheckSql.CheckFieldLen(strReqContent, 4000, convCMFeatureRequirement.ReqContent);
objvCMFeatureRequirementEN.ReqContent = strReqContent; //需求内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.ReqContent) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.ReqContent, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.ReqContent] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetUpdDate(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFeatureRequirement.UpdDate);
objvCMFeatureRequirementEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.UpdDate) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.UpdDate, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.UpdDate] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetUpdUser(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFeatureRequirement.UpdUser);
objvCMFeatureRequirementEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.UpdUser) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.UpdUser, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.UpdUser] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetMemo(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFeatureRequirement.Memo);
objvCMFeatureRequirementEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(convCMFeatureRequirement.Memo) == false)
{
objvCMFeatureRequirementEN.dicFldComparisonOp.Add(convCMFeatureRequirement.Memo, strComparisonOp);
}
else
{
objvCMFeatureRequirementEN.dicFldComparisonOp[convCMFeatureRequirement.Memo] = strComparisonOp;
}
}
return objvCMFeatureRequirementEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFeatureRequirementEN objvCMFeatureRequirementCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.mId) == true)
{
string strComparisonOpmId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFeatureRequirement.mId, objvCMFeatureRequirementCond.mId, strComparisonOpmId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.CmFeatureId) == true)
{
string strComparisonOpCmFeatureId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.CmFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.CmFeatureId, objvCMFeatureRequirementCond.CmFeatureId, strComparisonOpCmFeatureId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.FeatureName) == true)
{
string strComparisonOpFeatureName = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.FeatureName, objvCMFeatureRequirementCond.FeatureName, strComparisonOpFeatureName);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.CmParentFeatureId) == true)
{
string strComparisonOpCmParentFeatureId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.CmParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.CmParentFeatureId, objvCMFeatureRequirementCond.CmParentFeatureId, strComparisonOpCmParentFeatureId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.ParentFeatureName, objvCMFeatureRequirementCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.FuncModuleAgcId, objvCMFeatureRequirementCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.CmPrjId, objvCMFeatureRequirementCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.ReqId) == true)
{
string strComparisonOpReqId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.ReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.ReqId, objvCMFeatureRequirementCond.ReqId, strComparisonOpReqId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.PrjId, objvCMFeatureRequirementCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.RequirementName) == true)
{
string strComparisonOpRequirementName = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.RequirementName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.RequirementName, objvCMFeatureRequirementCond.RequirementName, strComparisonOpRequirementName);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFeatureRequirement.OrderNum, objvCMFeatureRequirementCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.ReqContent) == true)
{
string strComparisonOpReqContent = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.ReqContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.ReqContent, objvCMFeatureRequirementCond.ReqContent, strComparisonOpReqContent);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.UpdDate, objvCMFeatureRequirementCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.UpdUser, objvCMFeatureRequirementCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFeatureRequirementCond.IsUpdated(convCMFeatureRequirement.Memo) == true)
{
string strComparisonOpMemo = objvCMFeatureRequirementCond.dicFldComparisonOp[convCMFeatureRequirement.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeatureRequirement.Memo, objvCMFeatureRequirementCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM功能需求关系(vCMFeatureRequirement)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFeatureRequirementWApi
{
private static readonly string mstrApiControllerName = "vCMFeatureRequirementApi";

 public clsvCMFeatureRequirementWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureRequirementEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCMFeatureRequirementEN objvCMFeatureRequirementEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMFeatureRequirementEN = JsonConvert.DeserializeObject<clsvCMFeatureRequirementEN>(strJson);
return objvCMFeatureRequirementEN;
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
public static clsvCMFeatureRequirementEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFeatureRequirementEN objvCMFeatureRequirementEN;
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
objvCMFeatureRequirementEN = JsonConvert.DeserializeObject<clsvCMFeatureRequirementEN>(strJson);
return objvCMFeatureRequirementEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureRequirementEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLst_Sel =
from objvCMFeatureRequirementEN in arrvCMFeatureRequirementObjLstCache
where objvCMFeatureRequirementEN.mId == lngmId 
select objvCMFeatureRequirementEN;
if (arrvCMFeatureRequirementObjLst_Sel.Count() == 0)
{
   clsvCMFeatureRequirementEN obj = clsvCMFeatureRequirementWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMFeatureRequirementObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMFeatureRequirementEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLst_Sel =
from objvCMFeatureRequirementEN in arrvCMFeatureRequirementObjLstCache
where arrMId.Contains(objvCMFeatureRequirementEN.mId)
select objvCMFeatureRequirementEN;
return arrvCMFeatureRequirementObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFeatureRequirementEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureRequirementEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvCMFeatureRequirementENS">源对象</param>
 /// <param name = "objvCMFeatureRequirementENT">目标对象</param>
 public static void CopyTo(clsvCMFeatureRequirementEN objvCMFeatureRequirementENS, clsvCMFeatureRequirementEN objvCMFeatureRequirementENT)
{
try
{
objvCMFeatureRequirementENT.mId = objvCMFeatureRequirementENS.mId; //mId
objvCMFeatureRequirementENT.CmFeatureId = objvCMFeatureRequirementENS.CmFeatureId; //功能Id
objvCMFeatureRequirementENT.FeatureName = objvCMFeatureRequirementENS.FeatureName; //功能名称
objvCMFeatureRequirementENT.CmParentFeatureId = objvCMFeatureRequirementENS.CmParentFeatureId; //父功能Id
objvCMFeatureRequirementENT.ParentFeatureName = objvCMFeatureRequirementENS.ParentFeatureName; //父功能名
objvCMFeatureRequirementENT.FuncModuleAgcId = objvCMFeatureRequirementENS.FuncModuleAgcId; //功能模块Id
objvCMFeatureRequirementENT.CmPrjId = objvCMFeatureRequirementENS.CmPrjId; //Cm工程Id
objvCMFeatureRequirementENT.ReqId = objvCMFeatureRequirementENS.ReqId; //需求Id
objvCMFeatureRequirementENT.PrjId = objvCMFeatureRequirementENS.PrjId; //工程Id
objvCMFeatureRequirementENT.RequirementName = objvCMFeatureRequirementENS.RequirementName; //需求名称
objvCMFeatureRequirementENT.OrderNum = objvCMFeatureRequirementENS.OrderNum; //序号
objvCMFeatureRequirementENT.ReqContent = objvCMFeatureRequirementENS.ReqContent; //需求内容
objvCMFeatureRequirementENT.UpdDate = objvCMFeatureRequirementENS.UpdDate; //修改日期
objvCMFeatureRequirementENT.UpdUser = objvCMFeatureRequirementENS.UpdUser; //修改者
objvCMFeatureRequirementENT.Memo = objvCMFeatureRequirementENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMFeatureRequirementEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFeatureRequirementEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFeatureRequirementEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFeatureRequirementEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFeatureRequirementEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFeatureRequirementEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureRequirementWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureRequirementWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureRequirementWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureRequirementWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMFeatureRequirementEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMFeatureRequirementEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMFeatureRequirement.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMFeatureRequirementObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMFeatureRequirementEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureRequirementWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureRequirementWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMFeatureRequirementObjLstCache = CacheHelper.Get<List<clsvCMFeatureRequirementEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMFeatureRequirementObjLstCache = CacheHelper.Get<List<clsvCMFeatureRequirementEN>>(strKey);
}
return arrvCMFeatureRequirementObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMFeatureRequirementEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFeatureRequirement.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMFeatureRequirement.CmFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.CmParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.ReqId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.RequirementName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFeatureRequirement.ReqContent, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeatureRequirement.Memo, Type.GetType("System.String"));
foreach (clsvCMFeatureRequirementEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFeatureRequirement.mId] = objInFor[convCMFeatureRequirement.mId];
objDR[convCMFeatureRequirement.CmFeatureId] = objInFor[convCMFeatureRequirement.CmFeatureId];
objDR[convCMFeatureRequirement.FeatureName] = objInFor[convCMFeatureRequirement.FeatureName];
objDR[convCMFeatureRequirement.CmParentFeatureId] = objInFor[convCMFeatureRequirement.CmParentFeatureId];
objDR[convCMFeatureRequirement.ParentFeatureName] = objInFor[convCMFeatureRequirement.ParentFeatureName];
objDR[convCMFeatureRequirement.FuncModuleAgcId] = objInFor[convCMFeatureRequirement.FuncModuleAgcId];
objDR[convCMFeatureRequirement.CmPrjId] = objInFor[convCMFeatureRequirement.CmPrjId];
objDR[convCMFeatureRequirement.ReqId] = objInFor[convCMFeatureRequirement.ReqId];
objDR[convCMFeatureRequirement.PrjId] = objInFor[convCMFeatureRequirement.PrjId];
objDR[convCMFeatureRequirement.RequirementName] = objInFor[convCMFeatureRequirement.RequirementName];
objDR[convCMFeatureRequirement.OrderNum] = objInFor[convCMFeatureRequirement.OrderNum];
objDR[convCMFeatureRequirement.ReqContent] = objInFor[convCMFeatureRequirement.ReqContent];
objDR[convCMFeatureRequirement.UpdDate] = objInFor[convCMFeatureRequirement.UpdDate];
objDR[convCMFeatureRequirement.UpdUser] = objInFor[convCMFeatureRequirement.UpdUser];
objDR[convCMFeatureRequirement.Memo] = objInFor[convCMFeatureRequirement.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}