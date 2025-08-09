
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureWApi
 表名:vCMFeature(00050519)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:29
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
public static class  clsvCMFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmFeatureId(this clsvCMFeatureEN objvCMFeatureEN, string strCmFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, convCMFeature.CmFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, convCMFeature.CmFeatureId);
objvCMFeatureEN.CmFeatureId = strCmFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmFeatureId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmFeatureId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmFeatureId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convCMFeature.FeatureName);
objvCMFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FeatureName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FeatureName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FeatureName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureENName">功能英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureENName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, convCMFeature.FeatureENName);
objvCMFeatureEN.FeatureENName = strFeatureENName; //功能英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FeatureENName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FeatureENName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FeatureENName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetKeyWords(this clsvCMFeatureEN objvCMFeatureEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convCMFeature.KeyWords);
objvCMFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.KeyWords) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.KeyWords, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.KeyWords] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureDescription(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convCMFeature.FeatureDescription);
objvCMFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FeatureDescription) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FeatureDescription, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FeatureDescription] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmParentFeatureId(this clsvCMFeatureEN objvCMFeatureEN, string strCmParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmParentFeatureId, convCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, convCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, convCMFeature.CmParentFeatureId);
objvCMFeatureEN.CmParentFeatureId = strCmParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmParentFeatureId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmParentFeatureId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmParentFeatureId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetParentFeatureName(this clsvCMFeatureEN objvCMFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convCMFeature.ParentFeatureName);
objvCMFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.ParentFeatureName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.ParentFeatureName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.ParentFeatureName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmFeatureTypeId(this clsvCMFeatureEN objvCMFeatureEN, string strCmFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureTypeId, convCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(strCmFeatureTypeId, 2, convCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureTypeId, 2, convCMFeature.CmFeatureTypeId);
objvCMFeatureEN.CmFeatureTypeId = strCmFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmFeatureTypeId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmFeatureTypeId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmFeatureTypeId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureTypeName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convCMFeature.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convCMFeature.FeatureTypeName);
objvCMFeatureEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FeatureTypeName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FeatureTypeName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FeatureTypeName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCreateUserId(this clsvCMFeatureEN objvCMFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convCMFeature.CreateUserId);
objvCMFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CreateUserId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CreateUserId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CreateUserId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetInUse(this clsvCMFeatureEN objvCMFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objvCMFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.InUse) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.InUse, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.InUse] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetOrderNum(this clsvCMFeatureEN objvCMFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMFeature.OrderNum);
objvCMFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.OrderNum) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.OrderNum, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.OrderNum] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleAgcId(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMFeature.FuncModuleAgcId);
objvCMFeatureEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FuncModuleAgcId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleName(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMFeature.FuncModuleName);
objvCMFeatureEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FuncModuleName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FuncModuleName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FuncModuleName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleEnName(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convCMFeature.FuncModuleEnName);
objvCMFeatureEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FuncModuleEnName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FuncModuleEnName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FuncModuleEnName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">功能模块简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleNameSim(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convCMFeature.FuncModuleNameSim);
objvCMFeatureEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FuncModuleNameSim) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FuncModuleNameSim, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FuncModuleNameSim] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmPrjId(this clsvCMFeatureEN objvCMFeatureEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMFeature.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMFeature.CmPrjId);
objvCMFeatureEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmPrjId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmPrjId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmPrjId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmPrjName(this clsvCMFeatureEN objvCMFeatureEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMFeature.CmPrjName);
objvCMFeatureEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmPrjName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmPrjName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmPrjName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetPrjId(this clsvCMFeatureEN objvCMFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFeature.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFeature.PrjId);
objvCMFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.PrjId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.PrjId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.PrjId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetPrjName(this clsvCMFeatureEN objvCMFeatureEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFeature.PrjName);
objvCMFeatureEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.PrjName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.PrjName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.PrjName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetApplicationTypeId(this clsvCMFeatureEN objvCMFeatureEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvCMFeatureEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.ApplicationTypeId) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetApplicationTypeSimName(this clsvCMFeatureEN objvCMFeatureEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMFeature.ApplicationTypeSimName);
objvCMFeatureEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.ApplicationTypeSimName) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetUpdDate(this clsvCMFeatureEN objvCMFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFeature.UpdDate);
objvCMFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.UpdDate) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.UpdDate, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.UpdDate] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetUpdUser(this clsvCMFeatureEN objvCMFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFeature.UpdUser);
objvCMFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.UpdUser) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.UpdUser, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.UpdUser] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetMemo(this clsvCMFeatureEN objvCMFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFeature.Memo);
objvCMFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.Memo) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.Memo, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.Memo] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName2">功能名-FuncCount</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureName2(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convCMFeature.FeatureName2);
objvCMFeatureEN.FeatureName2 = strFeatureName2; //功能名-FuncCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.FeatureName2) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.FeatureName2, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.FeatureName2] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intCmReqCount">CMReqCount</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmReqCount(this clsvCMFeatureEN objvCMFeatureEN, int intCmReqCount, string strComparisonOp="")
	{
objvCMFeatureEN.CmReqCount = intCmReqCount; //CMReqCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFeatureEN.dicFldComparisonOp.ContainsKey(convCMFeature.CmReqCount) == false)
{
objvCMFeatureEN.dicFldComparisonOp.Add(convCMFeature.CmReqCount, strComparisonOp);
}
else
{
objvCMFeatureEN.dicFldComparisonOp[convCMFeature.CmReqCount] = strComparisonOp;
}
}
return objvCMFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFeatureEN objvCMFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmFeatureId) == true)
{
string strComparisonOpCmFeatureId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CmFeatureId, objvCMFeatureCond.CmFeatureId, strComparisonOpCmFeatureId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FeatureName, objvCMFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FeatureENName) == true)
{
string strComparisonOpFeatureENName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FeatureENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FeatureENName, objvCMFeatureCond.FeatureENName, strComparisonOpFeatureENName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.KeyWords, objvCMFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FeatureDescription, objvCMFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmParentFeatureId) == true)
{
string strComparisonOpCmParentFeatureId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CmParentFeatureId, objvCMFeatureCond.CmParentFeatureId, strComparisonOpCmParentFeatureId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.ParentFeatureName, objvCMFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmFeatureTypeId) == true)
{
string strComparisonOpCmFeatureTypeId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmFeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CmFeatureTypeId, objvCMFeatureCond.CmFeatureTypeId, strComparisonOpCmFeatureTypeId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FeatureTypeName, objvCMFeatureCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CreateUserId, objvCMFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.InUse) == true)
{
if (objvCMFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFeature.InUse);
}
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFeature.OrderNum, objvCMFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FuncModuleAgcId, objvCMFeatureCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FuncModuleName, objvCMFeatureCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FuncModuleEnName, objvCMFeatureCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FuncModuleNameSim, objvCMFeatureCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CmPrjId, objvCMFeatureCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.CmPrjName, objvCMFeatureCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.PrjId, objvCMFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.PrjName) == true)
{
string strComparisonOpPrjName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.PrjName, objvCMFeatureCond.PrjName, strComparisonOpPrjName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFeature.ApplicationTypeId, objvCMFeatureCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.ApplicationTypeSimName, objvCMFeatureCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.UpdDate, objvCMFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.UpdUser, objvCMFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.Memo) == true)
{
string strComparisonOpMemo = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.Memo, objvCMFeatureCond.Memo, strComparisonOpMemo);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.FeatureName2) == true)
{
string strComparisonOpFeatureName2 = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.FeatureName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFeature.FeatureName2, objvCMFeatureCond.FeatureName2, strComparisonOpFeatureName2);
}
if (objvCMFeatureCond.IsUpdated(convCMFeature.CmReqCount) == true)
{
string strComparisonOpCmReqCount = objvCMFeatureCond.dicFldComparisonOp[convCMFeature.CmReqCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFeature.CmReqCount, objvCMFeatureCond.CmReqCount, strComparisonOpCmReqCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM功能(vCMFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFeatureWApi
{
private static readonly string mstrApiControllerName = "vCMFeatureApi";

 public clsvCMFeatureWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
if (strCmFeatureId == "") return null;
string strAction = "GetObjByCmFeatureId";
clsvCMFeatureEN objvCMFeatureEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFeatureId"] = strCmFeatureId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMFeatureEN = JsonConvert.DeserializeObject<clsvCMFeatureEN>(strJson);
return objvCMFeatureEN;
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
public static clsvCMFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFeatureEN objvCMFeatureEN;
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
objvCMFeatureEN = JsonConvert.DeserializeObject<clsvCMFeatureEN>(strJson);
return objvCMFeatureEN;
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
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureEN GetObjByCmFeatureIdCache(string strCmFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrvCMFeatureObjLst_Sel =
from objvCMFeatureEN in arrvCMFeatureObjLstCache
where objvCMFeatureEN.CmFeatureId == strCmFeatureId 
select objvCMFeatureEN;
if (arrvCMFeatureObjLst_Sel.Count() == 0)
{
   clsvCMFeatureEN obj = clsvCMFeatureWApi.GetObjByCmFeatureId(strCmFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
 /// <param name = "arrCmFeatureId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstByCmFeatureIdLst(List<string> arrCmFeatureId)
{
 List<clsvCMFeatureEN> arrObjLst; 
string strAction = "GetObjLstByCmFeatureIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFeatureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
 /// <param name = "arrCmFeatureId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMFeatureEN> GetObjLstByCmFeatureIdLstCache(List<string> arrCmFeatureId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrvCMFeatureObjLst_Sel =
from objvCMFeatureEN in arrvCMFeatureObjLstCache
where arrCmFeatureId.Contains(objvCMFeatureEN.CmFeatureId)
select objvCMFeatureEN;
return arrvCMFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
public static List<clsvCMFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
public static List<clsvCMFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
public static List<clsvCMFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFeatureEN>>(strJson);
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
public static bool IsExist(string strCmFeatureId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFeatureId"] = strCmFeatureId
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
 /// <param name = "objvCMFeatureENS">源对象</param>
 /// <param name = "objvCMFeatureENT">目标对象</param>
 public static void CopyTo(clsvCMFeatureEN objvCMFeatureENS, clsvCMFeatureEN objvCMFeatureENT)
{
try
{
objvCMFeatureENT.CmFeatureId = objvCMFeatureENS.CmFeatureId; //功能Id
objvCMFeatureENT.FeatureName = objvCMFeatureENS.FeatureName; //功能名称
objvCMFeatureENT.FeatureENName = objvCMFeatureENS.FeatureENName; //功能英文名
objvCMFeatureENT.KeyWords = objvCMFeatureENS.KeyWords; //关键字
objvCMFeatureENT.FeatureDescription = objvCMFeatureENS.FeatureDescription; //功能说明
objvCMFeatureENT.CmParentFeatureId = objvCMFeatureENS.CmParentFeatureId; //父功能Id
objvCMFeatureENT.ParentFeatureName = objvCMFeatureENS.ParentFeatureName; //父功能名
objvCMFeatureENT.CmFeatureTypeId = objvCMFeatureENS.CmFeatureTypeId; //功能类型Id
objvCMFeatureENT.FeatureTypeName = objvCMFeatureENS.FeatureTypeName; //功能类型名称
objvCMFeatureENT.CreateUserId = objvCMFeatureENS.CreateUserId; //建立用户Id
objvCMFeatureENT.InUse = objvCMFeatureENS.InUse; //是否在用
objvCMFeatureENT.OrderNum = objvCMFeatureENS.OrderNum; //序号
objvCMFeatureENT.FuncModuleAgcId = objvCMFeatureENS.FuncModuleAgcId; //功能模块Id
objvCMFeatureENT.FuncModuleName = objvCMFeatureENS.FuncModuleName; //功能模块名称
objvCMFeatureENT.FuncModuleEnName = objvCMFeatureENS.FuncModuleEnName; //功能模块英文名称
objvCMFeatureENT.FuncModuleNameSim = objvCMFeatureENS.FuncModuleNameSim; //功能模块简称
objvCMFeatureENT.CmPrjId = objvCMFeatureENS.CmPrjId; //Cm工程Id
objvCMFeatureENT.CmPrjName = objvCMFeatureENS.CmPrjName; //CM工程名
objvCMFeatureENT.PrjId = objvCMFeatureENS.PrjId; //工程Id
objvCMFeatureENT.PrjName = objvCMFeatureENS.PrjName; //工程名称
objvCMFeatureENT.ApplicationTypeId = objvCMFeatureENS.ApplicationTypeId; //应用程序类型ID
objvCMFeatureENT.ApplicationTypeSimName = objvCMFeatureENS.ApplicationTypeSimName; //应用程序类型简称
objvCMFeatureENT.UpdDate = objvCMFeatureENS.UpdDate; //修改日期
objvCMFeatureENT.UpdUser = objvCMFeatureENS.UpdUser; //修改者
objvCMFeatureENT.Memo = objvCMFeatureENS.Memo; //说明
objvCMFeatureENT.FeatureName2 = objvCMFeatureENS.FeatureName2; //功能名-FuncCount
objvCMFeatureENT.CmReqCount = objvCMFeatureENS.CmReqCount; //CMReqCount
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
public static DataTable ToDataTable(List<clsvCMFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFeatureEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
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
public static List<clsvCMFeatureEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMFeatureEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMFeatureEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMFeature.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMFeatureEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFeatureWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFeatureWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMFeatureObjLstCache = CacheHelper.Get<List<clsvCMFeatureEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMFeatureObjLstCache = CacheHelper.Get<List<clsvCMFeatureEN>>(strKey);
}
return arrvCMFeatureObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFeature.CmFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FeatureENName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CmParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CmFeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFeature.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFeature.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.FeatureName2, Type.GetType("System.String"));
objDT.Columns.Add(convCMFeature.CmReqCount, Type.GetType("System.Int32"));
foreach (clsvCMFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFeature.CmFeatureId] = objInFor[convCMFeature.CmFeatureId];
objDR[convCMFeature.FeatureName] = objInFor[convCMFeature.FeatureName];
objDR[convCMFeature.FeatureENName] = objInFor[convCMFeature.FeatureENName];
objDR[convCMFeature.KeyWords] = objInFor[convCMFeature.KeyWords];
objDR[convCMFeature.FeatureDescription] = objInFor[convCMFeature.FeatureDescription];
objDR[convCMFeature.CmParentFeatureId] = objInFor[convCMFeature.CmParentFeatureId];
objDR[convCMFeature.ParentFeatureName] = objInFor[convCMFeature.ParentFeatureName];
objDR[convCMFeature.CmFeatureTypeId] = objInFor[convCMFeature.CmFeatureTypeId];
objDR[convCMFeature.FeatureTypeName] = objInFor[convCMFeature.FeatureTypeName];
objDR[convCMFeature.CreateUserId] = objInFor[convCMFeature.CreateUserId];
objDR[convCMFeature.InUse] = objInFor[convCMFeature.InUse];
objDR[convCMFeature.OrderNum] = objInFor[convCMFeature.OrderNum];
objDR[convCMFeature.FuncModuleAgcId] = objInFor[convCMFeature.FuncModuleAgcId];
objDR[convCMFeature.FuncModuleName] = objInFor[convCMFeature.FuncModuleName];
objDR[convCMFeature.FuncModuleEnName] = objInFor[convCMFeature.FuncModuleEnName];
objDR[convCMFeature.FuncModuleNameSim] = objInFor[convCMFeature.FuncModuleNameSim];
objDR[convCMFeature.CmPrjId] = objInFor[convCMFeature.CmPrjId];
objDR[convCMFeature.CmPrjName] = objInFor[convCMFeature.CmPrjName];
objDR[convCMFeature.PrjId] = objInFor[convCMFeature.PrjId];
objDR[convCMFeature.PrjName] = objInFor[convCMFeature.PrjName];
objDR[convCMFeature.ApplicationTypeId] = objInFor[convCMFeature.ApplicationTypeId];
objDR[convCMFeature.ApplicationTypeSimName] = objInFor[convCMFeature.ApplicationTypeSimName];
objDR[convCMFeature.UpdDate] = objInFor[convCMFeature.UpdDate];
objDR[convCMFeature.UpdUser] = objInFor[convCMFeature.UpdUser];
objDR[convCMFeature.Memo] = objInFor[convCMFeature.Memo];
objDR[convCMFeature.FeatureName2] = objInFor[convCMFeature.FeatureName2];
objDR[convCMFeature.CmReqCount] = objInFor[convCMFeature.CmReqCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}