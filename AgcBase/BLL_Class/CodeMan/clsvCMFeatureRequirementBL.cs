
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureRequirementBL
 表名:vCMFeatureRequirement(00050521)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvCMFeatureRequirementBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureRequirementEN GetObj(this K_mId_vCMFeatureRequirement myKey)
{
clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = clsvCMFeatureRequirementBL.vCMFeatureRequirementDA.GetObjBymId(myKey.Value);
return objvCMFeatureRequirementEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmFeatureId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureId, convCMFeatureRequirement.CmFeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, convCMFeatureRequirement.CmFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, convCMFeatureRequirement.CmFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetFeatureName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convCMFeatureRequirement.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convCMFeatureRequirement.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmParentFeatureId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, convCMFeatureRequirement.CmParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, convCMFeatureRequirement.CmParentFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetParentFeatureName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convCMFeatureRequirement.ParentFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetFuncModuleAgcId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMFeatureRequirement.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMFeatureRequirement.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetCmPrjId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMFeatureRequirement.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMFeatureRequirement.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetReqId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqId, convCMFeatureRequirement.ReqId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqId, 8, convCMFeatureRequirement.ReqId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReqId, 8, convCMFeatureRequirement.ReqId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetPrjId(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFeatureRequirement.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFeatureRequirement.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetRequirementName(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, convCMFeatureRequirement.RequirementName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementName, 50, convCMFeatureRequirement.RequirementName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetReqContent(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, convCMFeatureRequirement.ReqContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqContent, 4000, convCMFeatureRequirement.ReqContent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetUpdDate(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFeatureRequirement.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetUpdUser(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFeatureRequirement.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureRequirementEN SetMemo(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFeatureRequirement.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementENS">源对象</param>
 /// <param name = "objvCMFeatureRequirementENT">目标对象</param>
 public static void CopyTo(this clsvCMFeatureRequirementEN objvCMFeatureRequirementENS, clsvCMFeatureRequirementEN objvCMFeatureRequirementENT)
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
 /// <param name = "objvCMFeatureRequirementENS">源对象</param>
 /// <returns>目标对象=>clsvCMFeatureRequirementEN:objvCMFeatureRequirementENT</returns>
 public static clsvCMFeatureRequirementEN CopyTo(this clsvCMFeatureRequirementEN objvCMFeatureRequirementENS)
{
try
{
 clsvCMFeatureRequirementEN objvCMFeatureRequirementENT = new clsvCMFeatureRequirementEN()
{
mId = objvCMFeatureRequirementENS.mId, //mId
CmFeatureId = objvCMFeatureRequirementENS.CmFeatureId, //功能Id
FeatureName = objvCMFeatureRequirementENS.FeatureName, //功能名称
CmParentFeatureId = objvCMFeatureRequirementENS.CmParentFeatureId, //父功能Id
ParentFeatureName = objvCMFeatureRequirementENS.ParentFeatureName, //父功能名
FuncModuleAgcId = objvCMFeatureRequirementENS.FuncModuleAgcId, //功能模块Id
CmPrjId = objvCMFeatureRequirementENS.CmPrjId, //Cm工程Id
ReqId = objvCMFeatureRequirementENS.ReqId, //需求Id
PrjId = objvCMFeatureRequirementENS.PrjId, //工程Id
RequirementName = objvCMFeatureRequirementENS.RequirementName, //需求名称
OrderNum = objvCMFeatureRequirementENS.OrderNum, //序号
ReqContent = objvCMFeatureRequirementENS.ReqContent, //需求内容
UpdDate = objvCMFeatureRequirementENS.UpdDate, //修改日期
UpdUser = objvCMFeatureRequirementENS.UpdUser, //修改者
Memo = objvCMFeatureRequirementENS.Memo, //说明
};
 return objvCMFeatureRequirementENT;
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
public static void CheckProperty4Condition(this clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
 clsvCMFeatureRequirementBL.vCMFeatureRequirementDA.CheckProperty4Condition(objvCMFeatureRequirementEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFeatureRequirement
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM功能需求关系(vCMFeatureRequirement)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFeatureRequirementBL
{
public static RelatedActions_vCMFeatureRequirement relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFeatureRequirementDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFeatureRequirementDA vCMFeatureRequirementDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFeatureRequirementDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFeatureRequirementBL()
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
if (string.IsNullOrEmpty(clsvCMFeatureRequirementEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFeatureRequirementEN._ConnectString);
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
public static DataTable GetDataTable_vCMFeatureRequirement(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFeatureRequirementDA.GetDataTable_vCMFeatureRequirement(strWhereCond);
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
objDT = vCMFeatureRequirementDA.GetDataTable(strWhereCond);
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
objDT = vCMFeatureRequirementDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFeatureRequirementDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFeatureRequirementDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFeatureRequirementDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFeatureRequirementDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFeatureRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFeatureRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
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
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFeatureRequirementEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLst_Sel =
arrvCMFeatureRequirementObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMFeatureRequirementObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLst(string strWhereCond)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
public static List<clsvCMFeatureRequirementEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFeatureRequirementEN> GetSubObjLstCache(clsvCMFeatureRequirementEN objvCMFeatureRequirementCond)
{
 string strPrjId = objvCMFeatureRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMFeatureRequirementBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMFeatureRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFeatureRequirement._AttributeName)
{
if (objvCMFeatureRequirementCond.IsUpdated(strFldName) == false) continue;
if (objvCMFeatureRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureRequirementCond[strFldName].ToString());
}
else
{
if (objvCMFeatureRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFeatureRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFeatureRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFeatureRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFeatureRequirementCond[strFldName]));
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
List<clsvCMFeatureRequirementEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFeatureRequirementEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFeatureRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
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
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
public static List<clsvCMFeatureRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
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
public static List<clsvCMFeatureRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFeatureRequirementEN> arrObjLst = new List<clsvCMFeatureRequirementEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
try
{
objvCMFeatureRequirementEN.mId = Int32.Parse(objRow[convCMFeatureRequirement.mId].ToString().Trim()); //mId
objvCMFeatureRequirementEN.CmFeatureId = objRow[convCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureRequirementEN.FeatureName = objRow[convCMFeatureRequirement.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureRequirementEN.CmParentFeatureId = objRow[convCMFeatureRequirement.CmParentFeatureId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureRequirementEN.ParentFeatureName = objRow[convCMFeatureRequirement.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeatureRequirement.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureRequirementEN.FuncModuleAgcId = objRow[convCMFeatureRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureRequirementEN.CmPrjId = objRow[convCMFeatureRequirement.CmPrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureRequirementEN.ReqId = objRow[convCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objvCMFeatureRequirementEN.PrjId = objRow[convCMFeatureRequirement.PrjId] == DBNull.Value ? null : objRow[convCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objvCMFeatureRequirementEN.RequirementName = objRow[convCMFeatureRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[convCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objvCMFeatureRequirementEN.ReqContent = objRow[convCMFeatureRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMFeatureRequirementEN.UpdDate = objRow[convCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureRequirementEN.UpdUser = objRow[convCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objvCMFeatureRequirementEN.Memo = objRow[convCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[convCMFeatureRequirement.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureRequirementEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureRequirementEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFeatureRequirement(ref clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
bool bolResult = vCMFeatureRequirementDA.GetvCMFeatureRequirement(ref objvCMFeatureRequirementEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureRequirementEN GetObjBymId(long lngmId)
{
clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = vCMFeatureRequirementDA.GetObjBymId(lngmId);
return objvCMFeatureRequirementEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFeatureRequirementEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = vCMFeatureRequirementDA.GetFirstObj(strWhereCond);
 return objvCMFeatureRequirementEN;
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
public static clsvCMFeatureRequirementEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = vCMFeatureRequirementDA.GetObjByDataRow(objRow);
 return objvCMFeatureRequirementEN;
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
public static clsvCMFeatureRequirementEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = vCMFeatureRequirementDA.GetObjByDataRow(objRow);
 return objvCMFeatureRequirementEN;
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
 /// <param name = "lstvCMFeatureRequirementObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureRequirementEN GetObjBymIdFromList(long lngmId, List<clsvCMFeatureRequirementEN> lstvCMFeatureRequirementObjLst)
{
foreach (clsvCMFeatureRequirementEN objvCMFeatureRequirementEN in lstvCMFeatureRequirementObjLst)
{
if (objvCMFeatureRequirementEN.mId == lngmId)
{
return objvCMFeatureRequirementEN;
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
 lngmId = new clsvCMFeatureRequirementDA().GetFirstID(strWhereCond);
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
 arrList = vCMFeatureRequirementDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFeatureRequirementDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCMFeatureRequirementDA.IsExist(lngmId);
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
 bolIsExist = clsvCMFeatureRequirementDA.IsExistTable();
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
 bolIsExist = vCMFeatureRequirementDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFeatureRequirementEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
try
{
objvCMFeatureRequirementEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFeatureRequirementEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFeatureRequirement.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.mId = objvCMFeatureRequirementEN.mId; //mId
}
if (arrFldSet.Contains(convCMFeatureRequirement.CmFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.CmFeatureId = objvCMFeatureRequirementEN.CmFeatureId; //功能Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.FeatureName = objvCMFeatureRequirementEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convCMFeatureRequirement.CmParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.CmParentFeatureId = objvCMFeatureRequirementEN.CmParentFeatureId == "[null]" ? null :  objvCMFeatureRequirementEN.CmParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.ParentFeatureName = objvCMFeatureRequirementEN.ParentFeatureName == "[null]" ? null :  objvCMFeatureRequirementEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convCMFeatureRequirement.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.FuncModuleAgcId = objvCMFeatureRequirementEN.FuncModuleAgcId == "[null]" ? null :  objvCMFeatureRequirementEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.CmPrjId = objvCMFeatureRequirementEN.CmPrjId == "[null]" ? null :  objvCMFeatureRequirementEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.ReqId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.ReqId = objvCMFeatureRequirementEN.ReqId; //需求Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.PrjId = objvCMFeatureRequirementEN.PrjId == "[null]" ? null :  objvCMFeatureRequirementEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMFeatureRequirement.RequirementName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.RequirementName = objvCMFeatureRequirementEN.RequirementName; //需求名称
}
if (arrFldSet.Contains(convCMFeatureRequirement.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.OrderNum = objvCMFeatureRequirementEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMFeatureRequirement.ReqContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.ReqContent = objvCMFeatureRequirementEN.ReqContent; //需求内容
}
if (arrFldSet.Contains(convCMFeatureRequirement.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.UpdDate = objvCMFeatureRequirementEN.UpdDate == "[null]" ? null :  objvCMFeatureRequirementEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFeatureRequirement.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.UpdUser = objvCMFeatureRequirementEN.UpdUser == "[null]" ? null :  objvCMFeatureRequirementEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFeatureRequirement.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureRequirementEN.Memo = objvCMFeatureRequirementEN.Memo == "[null]" ? null :  objvCMFeatureRequirementEN.Memo; //说明
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
 /// <param name = "objvCMFeatureRequirementEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
try
{
if (objvCMFeatureRequirementEN.CmParentFeatureId == "[null]") objvCMFeatureRequirementEN.CmParentFeatureId = null; //父功能Id
if (objvCMFeatureRequirementEN.ParentFeatureName == "[null]") objvCMFeatureRequirementEN.ParentFeatureName = null; //父功能名
if (objvCMFeatureRequirementEN.FuncModuleAgcId == "[null]") objvCMFeatureRequirementEN.FuncModuleAgcId = null; //功能模块Id
if (objvCMFeatureRequirementEN.CmPrjId == "[null]") objvCMFeatureRequirementEN.CmPrjId = null; //Cm工程Id
if (objvCMFeatureRequirementEN.PrjId == "[null]") objvCMFeatureRequirementEN.PrjId = null; //工程Id
if (objvCMFeatureRequirementEN.UpdDate == "[null]") objvCMFeatureRequirementEN.UpdDate = null; //修改日期
if (objvCMFeatureRequirementEN.UpdUser == "[null]") objvCMFeatureRequirementEN.UpdUser = null; //修改者
if (objvCMFeatureRequirementEN.Memo == "[null]") objvCMFeatureRequirementEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMFeatureRequirementEN objvCMFeatureRequirementEN)
{
 vCMFeatureRequirementDA.CheckProperty4Condition(objvCMFeatureRequirementEN);
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
if (clsCMFeatureRequirementBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFeatureRequirementBL没有刷新缓存机制(clsCMFeatureRequirementBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsCMFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFeatureBL没有刷新缓存机制(clsCMFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFeatureTypeBL没有刷新缓存机制(clsCMFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMFeatureRequirementObjLstCache == null)
//{
//arrvCMFeatureRequirementObjLstCache = vCMFeatureRequirementDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureRequirementEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLst_Sel =
arrvCMFeatureRequirementObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMFeatureRequirementObjLst_Sel.Count() == 0)
{
   clsvCMFeatureRequirementEN obj = clsvCMFeatureRequirementBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMFeatureRequirementObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetAllvCMFeatureRequirementObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMFeatureRequirementObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureRequirementEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMFeatureRequirementObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMFeatureRequirementEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMFeatureRequirementEN._RefreshTimeLst.Count == 0) return "";
return clsvCMFeatureRequirementEN._RefreshTimeLst[clsvCMFeatureRequirementEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convCMFeatureRequirement.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFeatureRequirement._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFeatureRequirement._AttributeName));
throw new Exception(strMsg);
}
var objvCMFeatureRequirement = clsvCMFeatureRequirementBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvCMFeatureRequirement == null) return "";
return objvCMFeatureRequirement[strOutFldName].ToString();
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
int intRecCount = clsvCMFeatureRequirementDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFeatureRequirementDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFeatureRequirementDA.GetRecCount();
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
int intRecCount = clsvCMFeatureRequirementDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFeatureRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFeatureRequirementEN objvCMFeatureRequirementCond)
{
 string strPrjId = objvCMFeatureRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMFeatureRequirementBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMFeatureRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFeatureRequirement._AttributeName)
{
if (objvCMFeatureRequirementCond.IsUpdated(strFldName) == false) continue;
if (objvCMFeatureRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureRequirementCond[strFldName].ToString());
}
else
{
if (objvCMFeatureRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFeatureRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFeatureRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFeatureRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFeatureRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFeatureRequirementCond[strFldName]));
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
 List<string> arrList = clsvCMFeatureRequirementDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFeatureRequirementDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFeatureRequirementDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}