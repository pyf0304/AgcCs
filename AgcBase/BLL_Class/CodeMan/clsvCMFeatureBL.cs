
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureBL
 表名:vCMFeature(00050519)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:30
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
public static class  clsvCMFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureEN GetObj(this K_CmFeatureId_vCMFeature myKey)
{
clsvCMFeatureEN objvCMFeatureEN = clsvCMFeatureBL.vCMFeatureDA.GetObjByCmFeatureId(myKey.Value);
return objvCMFeatureEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmFeatureId(this clsvCMFeatureEN objvCMFeatureEN, string strCmFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, convCMFeature.CmFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, convCMFeature.CmFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convCMFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convCMFeature.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureENName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, convCMFeature.FeatureENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetKeyWords(this clsvCMFeatureEN objvCMFeatureEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convCMFeature.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureDescription(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convCMFeature.FeatureDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmParentFeatureId(this clsvCMFeatureEN objvCMFeatureEN, string strCmParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmParentFeatureId, convCMFeature.CmParentFeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, convCMFeature.CmParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, convCMFeature.CmParentFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetParentFeatureName(this clsvCMFeatureEN objvCMFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convCMFeature.ParentFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmFeatureTypeId(this clsvCMFeatureEN objvCMFeatureEN, string strCmFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureTypeId, convCMFeature.CmFeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureTypeId, 2, convCMFeature.CmFeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureTypeId, 2, convCMFeature.CmFeatureTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureTypeName(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convCMFeature.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convCMFeature.FeatureTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCreateUserId(this clsvCMFeatureEN objvCMFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convCMFeature.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convCMFeature.CreateUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleAgcId(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMFeature.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMFeature.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMFeature.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleName(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMFeature.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleEnName(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convCMFeature.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFuncModuleNameSim(this clsvCMFeatureEN objvCMFeatureEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convCMFeature.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmPrjId(this clsvCMFeatureEN objvCMFeatureEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMFeature.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMFeature.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMFeature.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmPrjName(this clsvCMFeatureEN objvCMFeatureEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMFeature.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetPrjId(this clsvCMFeatureEN objvCMFeatureEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFeature.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFeature.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetPrjName(this clsvCMFeatureEN objvCMFeatureEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFeature.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetApplicationTypeId(this clsvCMFeatureEN objvCMFeatureEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetApplicationTypeSimName(this clsvCMFeatureEN objvCMFeatureEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMFeature.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetUpdDate(this clsvCMFeatureEN objvCMFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFeature.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetUpdUser(this clsvCMFeatureEN objvCMFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFeature.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetMemo(this clsvCMFeatureEN objvCMFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFeature.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetFeatureName2(this clsvCMFeatureEN objvCMFeatureEN, string strFeatureName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convCMFeature.FeatureName2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFeatureEN SetCmReqCount(this clsvCMFeatureEN objvCMFeatureEN, int? intCmReqCount, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFeatureENS">源对象</param>
 /// <param name = "objvCMFeatureENT">目标对象</param>
 public static void CopyTo(this clsvCMFeatureEN objvCMFeatureENS, clsvCMFeatureEN objvCMFeatureENT)
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
 /// <param name = "objvCMFeatureENS">源对象</param>
 /// <returns>目标对象=>clsvCMFeatureEN:objvCMFeatureENT</returns>
 public static clsvCMFeatureEN CopyTo(this clsvCMFeatureEN objvCMFeatureENS)
{
try
{
 clsvCMFeatureEN objvCMFeatureENT = new clsvCMFeatureEN()
{
CmFeatureId = objvCMFeatureENS.CmFeatureId, //功能Id
FeatureName = objvCMFeatureENS.FeatureName, //功能名称
FeatureENName = objvCMFeatureENS.FeatureENName, //功能英文名
KeyWords = objvCMFeatureENS.KeyWords, //关键字
FeatureDescription = objvCMFeatureENS.FeatureDescription, //功能说明
CmParentFeatureId = objvCMFeatureENS.CmParentFeatureId, //父功能Id
ParentFeatureName = objvCMFeatureENS.ParentFeatureName, //父功能名
CmFeatureTypeId = objvCMFeatureENS.CmFeatureTypeId, //功能类型Id
FeatureTypeName = objvCMFeatureENS.FeatureTypeName, //功能类型名称
CreateUserId = objvCMFeatureENS.CreateUserId, //建立用户Id
InUse = objvCMFeatureENS.InUse, //是否在用
OrderNum = objvCMFeatureENS.OrderNum, //序号
FuncModuleAgcId = objvCMFeatureENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCMFeatureENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvCMFeatureENS.FuncModuleEnName, //功能模块英文名称
FuncModuleNameSim = objvCMFeatureENS.FuncModuleNameSim, //功能模块简称
CmPrjId = objvCMFeatureENS.CmPrjId, //Cm工程Id
CmPrjName = objvCMFeatureENS.CmPrjName, //CM工程名
PrjId = objvCMFeatureENS.PrjId, //工程Id
PrjName = objvCMFeatureENS.PrjName, //工程名称
ApplicationTypeId = objvCMFeatureENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeSimName = objvCMFeatureENS.ApplicationTypeSimName, //应用程序类型简称
UpdDate = objvCMFeatureENS.UpdDate, //修改日期
UpdUser = objvCMFeatureENS.UpdUser, //修改者
Memo = objvCMFeatureENS.Memo, //说明
FeatureName2 = objvCMFeatureENS.FeatureName2, //功能名-FuncCount
CmReqCount = objvCMFeatureENS.CmReqCount, //CMReqCount
};
 return objvCMFeatureENT;
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
public static void CheckProperty4Condition(this clsvCMFeatureEN objvCMFeatureEN)
{
 clsvCMFeatureBL.vCMFeatureDA.CheckProperty4Condition(objvCMFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFeature
{
public virtual bool UpdRelaTabDate(string strCmFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM功能(vCMFeature)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFeatureBL
{
public static RelatedActions_vCMFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFeatureDA vCMFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFeatureDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFeatureBL()
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
if (string.IsNullOrEmpty(clsvCMFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFeatureEN._ConnectString);
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
public static DataTable GetDataTable_vCMFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFeatureDA.GetDataTable_vCMFeature(strWhereCond);
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
objDT = vCMFeatureDA.GetDataTable(strWhereCond);
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
objDT = vCMFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstByCmFeatureIdLst(List<string> arrCmFeatureIdLst)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFeatureIdLst, true);
 string strWhereCond = string.Format("CmFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFeatureEN> GetObjLstByCmFeatureIdLstCache(List<string> arrCmFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrvCMFeatureObjLst_Sel =
arrvCMFeatureObjLstCache
.Where(x => arrCmFeatureIdLst.Contains(x.CmFeatureId));
return arrvCMFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLst(string strWhereCond)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
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
public static List<clsvCMFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFeatureEN> GetSubObjLstCache(clsvCMFeatureEN objvCMFeatureCond)
{
 string strPrjId = objvCMFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMFeatureBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFeature._AttributeName)
{
if (objvCMFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvCMFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureCond[strFldName].ToString());
}
else
{
if (objvCMFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFeatureCond[strFldName]));
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
public static List<clsvCMFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
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
public static List<clsvCMFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
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
List<clsvCMFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
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
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
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
public static List<clsvCMFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
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
public static List<clsvCMFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFeature(ref clsvCMFeatureEN objvCMFeatureEN)
{
bool bolResult = vCMFeatureDA.GetvCMFeature(ref objvCMFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
if (strCmFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMFeatureEN objvCMFeatureEN = vCMFeatureDA.GetObjByCmFeatureId(strCmFeatureId);
return objvCMFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFeatureEN objvCMFeatureEN = vCMFeatureDA.GetFirstObj(strWhereCond);
 return objvCMFeatureEN;
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
public static clsvCMFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFeatureEN objvCMFeatureEN = vCMFeatureDA.GetObjByDataRow(objRow);
 return objvCMFeatureEN;
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
public static clsvCMFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFeatureEN objvCMFeatureEN = vCMFeatureDA.GetObjByDataRow(objRow);
 return objvCMFeatureEN;
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
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <param name = "lstvCMFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureEN GetObjByCmFeatureIdFromList(string strCmFeatureId, List<clsvCMFeatureEN> lstvCMFeatureObjLst)
{
foreach (clsvCMFeatureEN objvCMFeatureEN in lstvCMFeatureObjLst)
{
if (objvCMFeatureEN.CmFeatureId == strCmFeatureId)
{
return objvCMFeatureEN;
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
 string strCmFeatureId;
 try
 {
 strCmFeatureId = new clsvCMFeatureDA().GetFirstID(strWhereCond);
 return strCmFeatureId;
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
 arrList = vCMFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFeatureId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMFeatureDA.IsExist(strCmFeatureId);
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
 bolIsExist = clsvCMFeatureDA.IsExistTable();
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
 bolIsExist = vCMFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFeatureEN objvCMFeatureEN)
{
try
{
objvCMFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFeature.CmFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmFeatureId = objvCMFeatureEN.CmFeatureId; //功能Id
}
if (arrFldSet.Contains(convCMFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FeatureName = objvCMFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convCMFeature.FeatureENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FeatureENName = objvCMFeatureEN.FeatureENName == "[null]" ? null :  objvCMFeatureEN.FeatureENName; //功能英文名
}
if (arrFldSet.Contains(convCMFeature.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.KeyWords = objvCMFeatureEN.KeyWords == "[null]" ? null :  objvCMFeatureEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convCMFeature.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FeatureDescription = objvCMFeatureEN.FeatureDescription == "[null]" ? null :  objvCMFeatureEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convCMFeature.CmParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmParentFeatureId = objvCMFeatureEN.CmParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(convCMFeature.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.ParentFeatureName = objvCMFeatureEN.ParentFeatureName == "[null]" ? null :  objvCMFeatureEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convCMFeature.CmFeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmFeatureTypeId = objvCMFeatureEN.CmFeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convCMFeature.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FeatureTypeName = objvCMFeatureEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convCMFeature.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CreateUserId = objvCMFeatureEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convCMFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.InUse = objvCMFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(convCMFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.OrderNum = objvCMFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMFeature.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FuncModuleAgcId = objvCMFeatureEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMFeature.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FuncModuleName = objvCMFeatureEN.FuncModuleName == "[null]" ? null :  objvCMFeatureEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCMFeature.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FuncModuleEnName = objvCMFeatureEN.FuncModuleEnName == "[null]" ? null :  objvCMFeatureEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convCMFeature.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FuncModuleNameSim = objvCMFeatureEN.FuncModuleNameSim == "[null]" ? null :  objvCMFeatureEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convCMFeature.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmPrjId = objvCMFeatureEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMFeature.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmPrjName = objvCMFeatureEN.CmPrjName == "[null]" ? null :  objvCMFeatureEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMFeature.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.PrjId = objvCMFeatureEN.PrjId == "[null]" ? null :  objvCMFeatureEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMFeature.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.PrjName = objvCMFeatureEN.PrjName == "[null]" ? null :  objvCMFeatureEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMFeature.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.ApplicationTypeId = objvCMFeatureEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMFeature.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.ApplicationTypeSimName = objvCMFeatureEN.ApplicationTypeSimName == "[null]" ? null :  objvCMFeatureEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.UpdDate = objvCMFeatureEN.UpdDate == "[null]" ? null :  objvCMFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.UpdUser = objvCMFeatureEN.UpdUser == "[null]" ? null :  objvCMFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.Memo = objvCMFeatureEN.Memo == "[null]" ? null :  objvCMFeatureEN.Memo; //说明
}
if (arrFldSet.Contains(convCMFeature.FeatureName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.FeatureName2 = objvCMFeatureEN.FeatureName2 == "[null]" ? null :  objvCMFeatureEN.FeatureName2; //功能名-FuncCount
}
if (arrFldSet.Contains(convCMFeature.CmReqCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFeatureEN.CmReqCount = objvCMFeatureEN.CmReqCount; //CMReqCount
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
 /// <param name = "objvCMFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFeatureEN objvCMFeatureEN)
{
try
{
if (objvCMFeatureEN.FeatureENName == "[null]") objvCMFeatureEN.FeatureENName = null; //功能英文名
if (objvCMFeatureEN.KeyWords == "[null]") objvCMFeatureEN.KeyWords = null; //关键字
if (objvCMFeatureEN.FeatureDescription == "[null]") objvCMFeatureEN.FeatureDescription = null; //功能说明
if (objvCMFeatureEN.ParentFeatureName == "[null]") objvCMFeatureEN.ParentFeatureName = null; //父功能名
if (objvCMFeatureEN.FuncModuleName == "[null]") objvCMFeatureEN.FuncModuleName = null; //功能模块名称
if (objvCMFeatureEN.FuncModuleEnName == "[null]") objvCMFeatureEN.FuncModuleEnName = null; //功能模块英文名称
if (objvCMFeatureEN.FuncModuleNameSim == "[null]") objvCMFeatureEN.FuncModuleNameSim = null; //功能模块简称
if (objvCMFeatureEN.CmPrjName == "[null]") objvCMFeatureEN.CmPrjName = null; //CM工程名
if (objvCMFeatureEN.PrjId == "[null]") objvCMFeatureEN.PrjId = null; //工程Id
if (objvCMFeatureEN.PrjName == "[null]") objvCMFeatureEN.PrjName = null; //工程名称
if (objvCMFeatureEN.ApplicationTypeSimName == "[null]") objvCMFeatureEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMFeatureEN.UpdDate == "[null]") objvCMFeatureEN.UpdDate = null; //修改日期
if (objvCMFeatureEN.UpdUser == "[null]") objvCMFeatureEN.UpdUser = null; //修改者
if (objvCMFeatureEN.Memo == "[null]") objvCMFeatureEN.Memo = null; //说明
if (objvCMFeatureEN.FeatureName2 == "[null]") objvCMFeatureEN.FeatureName2 = null; //功能名-FuncCount
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
public static void CheckProperty4Condition(clsvCMFeatureEN objvCMFeatureEN)
{
 vCMFeatureDA.CheckProperty4Condition(objvCMFeatureEN);
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
//string strWhereCond = string.Format("1 = 1 order by CmFeatureId");
//if (arrvCMFeatureObjLstCache == null)
//{
//arrvCMFeatureObjLstCache = vCMFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFeatureEN GetObjByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrvCMFeatureObjLst_Sel =
arrvCMFeatureObjLstCache
.Where(x=> x.CmFeatureId == strCmFeatureId 
);
if (arrvCMFeatureObjLst_Sel.Count() == 0)
{
   clsvCMFeatureEN obj = clsvCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCmFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureEN> GetAllvCMFeatureObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFeatureEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMFeatureEN> arrvCMFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMFeatureObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCMFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsvCMFeatureEN._RefreshTimeLst[clsvCMFeatureEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCmFeatureId, string strPrjId)
{
if (strInFldName != convCMFeature.CmFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFeature._AttributeName));
throw new Exception(strMsg);
}
var objvCMFeature = clsvCMFeatureBL.GetObjByCmFeatureIdCache(strCmFeatureId, strPrjId);
if (objvCMFeature == null) return "";
return objvCMFeature[strOutFldName].ToString();
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
int intRecCount = clsvCMFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFeatureDA.GetRecCount();
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
int intRecCount = clsvCMFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFeatureEN objvCMFeatureCond)
{
 string strPrjId = objvCMFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMFeatureBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFeature._AttributeName)
{
if (objvCMFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvCMFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureCond[strFldName].ToString());
}
else
{
if (objvCMFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFeatureCond[strFldName]));
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
 List<string> arrList = clsvCMFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}