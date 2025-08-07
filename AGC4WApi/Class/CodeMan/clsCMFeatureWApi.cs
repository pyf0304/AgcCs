
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureWApi
 表名:CMFeature(00050517)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:47
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
public static class  clsCMFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmFeatureId(this clsCMFeatureEN objCMFeatureEN, string strCmFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, conCMFeature.CmFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, conCMFeature.CmFeatureId);
objCMFeatureEN.CmFeatureId = strCmFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmFeatureId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmFeatureId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmFeatureId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureName(this clsCMFeatureEN objCMFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, conCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, conCMFeature.FeatureName);
objCMFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureENName">功能英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureENName(this clsCMFeatureEN objCMFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, conCMFeature.FeatureENName);
objCMFeatureEN.FeatureENName = strFeatureENName; //功能英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureENName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureENName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureENName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetKeyWords(this clsCMFeatureEN objCMFeatureEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conCMFeature.KeyWords);
objCMFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.KeyWords) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.KeyWords, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.KeyWords] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureDescription(this clsCMFeatureEN objCMFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conCMFeature.FeatureDescription);
objCMFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureDescription) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureDescription, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureDescription] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmParentFeatureId(this clsCMFeatureEN objCMFeatureEN, string strCmParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
objCMFeatureEN.CmParentFeatureId = strCmParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmParentFeatureId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmParentFeatureId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmParentFeatureId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetParentFeatureName(this clsCMFeatureEN objCMFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, conCMFeature.ParentFeatureName);
objCMFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.ParentFeatureName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.ParentFeatureName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.ParentFeatureName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmFeatureTypeId(this clsCMFeatureEN objCMFeatureEN, string strCmFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureTypeId, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(strCmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
objCMFeatureEN.CmFeatureTypeId = strCmFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmFeatureTypeId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmFeatureTypeId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmFeatureTypeId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCreateUserId(this clsCMFeatureEN objCMFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conCMFeature.CreateUserId);
objCMFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CreateUserId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CreateUserId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CreateUserId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetInUse(this clsCMFeatureEN objCMFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objCMFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.InUse) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.InUse, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.InUse] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetOrderNum(this clsCMFeatureEN objCMFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMFeature.OrderNum);
objCMFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.OrderNum) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.OrderNum, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.OrderNum] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFuncModuleAgcId(this clsCMFeatureEN objCMFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
objCMFeatureEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FuncModuleAgcId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmPrjId(this clsCMFeatureEN objCMFeatureEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMFeature.CmPrjId);
objCMFeatureEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmPrjId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmPrjId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmPrjId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetPrjId(this clsCMFeatureEN objCMFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMFeature.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMFeature.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMFeature.PrjId);
objCMFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.PrjId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.PrjId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.PrjId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetUpdDate(this clsCMFeatureEN objCMFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFeature.UpdDate);
objCMFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.UpdDate) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.UpdDate, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.UpdDate] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetUpdUser(this clsCMFeatureEN objCMFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFeature.UpdUser);
objCMFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.UpdUser) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.UpdUser, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.UpdUser] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetMemo(this clsCMFeatureEN objCMFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFeature.Memo);
objCMFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.Memo) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.Memo, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.Memo] = strComparisonOp;
}
}
return objCMFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFeatureEN objCMFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFeatureCond.IsUpdated(conCMFeature.CmFeatureId) == true)
{
string strComparisonOpCmFeatureId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmFeatureId, objCMFeatureCond.CmFeatureId, strComparisonOpCmFeatureId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureName, objCMFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureENName) == true)
{
string strComparisonOpFeatureENName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureENName, objCMFeatureCond.FeatureENName, strComparisonOpFeatureENName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objCMFeatureCond.dicFldComparisonOp[conCMFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.KeyWords, objCMFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureDescription, objCMFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmParentFeatureId) == true)
{
string strComparisonOpCmParentFeatureId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmParentFeatureId, objCMFeatureCond.CmParentFeatureId, strComparisonOpCmParentFeatureId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.ParentFeatureName, objCMFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmFeatureTypeId) == true)
{
string strComparisonOpCmFeatureTypeId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmFeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmFeatureTypeId, objCMFeatureCond.CmFeatureTypeId, strComparisonOpCmFeatureTypeId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CreateUserId, objCMFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.InUse) == true)
{
if (objCMFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFeature.InUse);
}
}
if (objCMFeatureCond.IsUpdated(conCMFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMFeatureCond.dicFldComparisonOp[conCMFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFeature.OrderNum, objCMFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FuncModuleAgcId, objCMFeatureCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmPrjId, objCMFeatureCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.PrjId) == true)
{
string strComparisonOpPrjId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.PrjId, objCMFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFeatureCond.dicFldComparisonOp[conCMFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.UpdDate, objCMFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFeatureCond.dicFldComparisonOp[conCMFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.UpdUser, objCMFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.Memo) == true)
{
string strComparisonOpMemo = objCMFeatureCond.dicFldComparisonOp[conCMFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.Memo, objCMFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureEN objCMFeatureEN)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMFeatureEN.sfUpdFldSetStr = objCMFeatureEN.getsfUpdFldSetStr();
clsCMFeatureWApi.CheckPropertyNew(objCMFeatureEN); 
bool bolResult = clsCMFeatureWApi.UpdateRecord(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
 /// 获取唯一性条件串--CMFeature(CM功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureName_CMPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMFeatureEN objCMFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureEN == null) return "";
if (objCMFeatureEN.CmFeatureId == null || objCMFeatureEN.CmFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFeatureId !=  '{0}'", objCMFeatureEN.CmFeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFeatureEN objCMFeatureEN)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMFeatureWApi.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMFeatureEN.CmFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCMFeatureWApi.CheckPropertyNew(objCMFeatureEN); 
bool bolResult = clsCMFeatureWApi.AddNewRecord(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFeatureEN objCMFeatureEN)
{
try
{
clsCMFeatureWApi.CheckPropertyNew(objCMFeatureEN); 
string strCmFeatureId = clsCMFeatureWApi.AddNewRecordWithMaxId(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
return strCmFeatureId;
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureEN objCMFeatureEN, string strWhereCond)
{
try
{
clsCMFeatureWApi.CheckPropertyNew(objCMFeatureEN); 
bool bolResult = clsCMFeatureWApi.UpdateWithCondition(objCMFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumCMFeatureWA
{
 /// <summary>
 /// 个人中心
 /// </summary>
public const string _00070008 = "00070008";
 /// <summary>
 /// 主任务维护
 /// </summary>
public const string _00070009 = "00070009";
 /// <summary>
 /// 首页
 /// </summary>
public const string _00070010 = "00070010";
 /// <summary>
 /// 子任务维护
 /// </summary>
public const string _00070011 = "00070011";
 /// <summary>
 /// 工程角色切换
 /// </summary>
public const string _00070012 = "00070012";
 /// <summary>
 /// 微信用户绑定
 /// </summary>
public const string _00070015 = "00070015";
 /// <summary>
 /// 任务类型统计
 /// </summary>
public const string _00070021 = "00070021";
 /// <summary>
 /// 任务相关数量统计
 /// </summary>
public const string _00070023 = "00070023";
 /// <summary>
 /// 任务进度
 /// </summary>
public const string _00070025 = "00070025";
 /// <summary>
 /// 意见反馈
 /// </summary>
public const string _00070026 = "00070026";
 /// <summary>
 /// 用户信息展示修改
 /// </summary>
public const string _00070028 = "00070028";
 /// <summary>
 /// 用户密码修改
 /// </summary>
public const string _00070030 = "00070030";
 /// <summary>
 /// 使用任务模板
 /// </summary>
public const string _00070033 = "00070033";
 /// <summary>
 /// 签到
 /// </summary>
public const string _00070037 = "00070037";
 /// <summary>
 /// 审核
 /// </summary>
public const string _00070038 = "00070038";
 /// <summary>
 /// 统计
 /// </summary>
public const string _00070039 = "00070039";
 /// <summary>
 /// 季报
 /// </summary>
public const string _00070040 = "00070040";
 /// <summary>
 /// 月报
 /// </summary>
public const string _00070041 = "00070041";
 /// <summary>
 /// 微信小程序 ，通过微信跳转登录习题试卷
 /// </summary>
public const string _01120013 = "01120013";
 /// <summary>
 /// 课程视频
 /// </summary>
public const string _01120014 = "01120014";
 /// <summary>
 /// 课件视频播放
 /// </summary>
public const string _01120016 = "01120016";
 /// <summary>
 /// 课件案例视频评论及评论列表展示
 /// </summary>
public const string _01120017 = "01120017";
 /// <summary>
 /// 课件案例视频点赞功能
 /// </summary>
public const string _01120018 = "01120018";
 /// <summary>
 /// 课件案例视频浏览次数记录功能
 /// </summary>
public const string _01120019 = "01120019";
 /// <summary>
 /// 课件案例视频收藏功能
 /// </summary>
public const string _01120020 = "01120020";
 /// <summary>
 /// 登录权限模块流程
 /// </summary>
public const string _01120022 = "01120022";
 /// <summary>
 /// 视频库
 /// </summary>
public const string _01120024 = "01120024";
 /// <summary>
 /// 视频库播放
 /// </summary>
public const string _01120031 = "01120031";
 /// <summary>
 /// 视频库视频播放评论及评论列表功能
 /// </summary>
public const string _01120032 = "01120032";
 /// <summary>
 /// 视频库播放浏览记录
 /// </summary>
public const string _01120034 = "01120034";
 /// <summary>
 /// 视频库点赞功能
 /// </summary>
public const string _01120035 = "01120035";
 /// <summary>
 /// 视频库收藏
 /// </summary>
public const string _01120036 = "01120036";
 /// <summary>
 /// 习题作业
 /// </summary>
public const string _01120042 = "01120042";
 /// <summary>
 /// 教学班作业列表功能
 /// </summary>
public const string _01120043 = "01120043";
 /// <summary>
 /// 习题题目展示
 /// </summary>
public const string _01120044 = "01120044";
 /// <summary>
 /// 试卷模块
 /// </summary>
public const string _01120045 = "01120045";
 /// <summary>
 /// 试卷列表功能
 /// </summary>
public const string _01120046 = "01120046";
 /// <summary>
 /// 试卷展示
 /// </summary>
public const string _01120047 = "01120047";
 /// <summary>
 /// 服务商信息展示
 /// </summary>
public const string _01120048 = "01120048";
 /// <summary>
 /// 关于界面
 /// </summary>
public const string _01120049 = "01120049";
 /// <summary>
 /// 意见反馈
 /// </summary>
public const string _01120050 = "01120050";
 /// <summary>
 /// 案例库收藏功能展示；
 /// </summary>
public const string _01120051 = "01120051";
 /// <summary>
 /// 视频库收藏功能列表展示
 /// </summary>
public const string _01120052 = "01120052";
 /// <summary>
 /// 个人中心案例库浏览记录列表功能
 /// </summary>
public const string _01120053 = "01120053";
 /// <summary>
 /// 个人中心视频库浏览记录列表功能
 /// </summary>
public const string _01120054 = "01120054";
 /// <summary>
 /// 流程更正；登录后无需选择课程直接跳转主页
 /// </summary>
public const string _01120055 = "01120055";
 /// <summary>
 /// 在视频库播放界面判断是否已收藏、或已点赞
 /// </summary>
public const string _01120056 = "01120056";
 /// <summary>
 /// 案例库界面判断是否已收藏或点赞；
 /// </summary>
public const string _01120057 = "01120057";
 /// <summary>
 /// 知识点维护
 /// </summary>
public const string _01120058 = "01120058";
 /// <summary>
 /// 论文阅读
 /// </summary>
public const string _01120059 = "01120059";
 /// <summary>
 /// 论文写作过程
 /// </summary>
public const string _01120060 = "01120060";
 /// <summary>
 /// 论文维护
 /// </summary>
public const string _01120061 = "01120061";
 /// <summary>
 /// 论文管理
 /// </summary>
public const string _01120062 = "01120062";
 /// <summary>
 /// 用户引用论文引用观点维护
 /// </summary>
public const string _01120063 = "01120063";
 /// <summary>
 /// 论文查看组
 /// </summary>
public const string _01120064 = "01120064";
 /// <summary>
 /// 论文查看1
 /// </summary>
public const string _01120065 = "01120065";
 /// <summary>
 /// 论文阅读查看
 /// </summary>
public const string _01120066 = "01120066";
 /// <summary>
 /// 论文写作查看
 /// </summary>
public const string _01120067 = "01120067";
 /// <summary>
 /// 专业方向
 /// </summary>
public const string _01120068 = "01120068";
 /// <summary>
 /// 专业方向维护
 /// </summary>
public const string _01120069 = "01120069";
 /// <summary>
 /// 专业方向与论文关系
 /// </summary>
public const string _01120070 = "01120070";
 /// <summary>
 /// 主题收集管理
 /// </summary>
public const string _01120071 = "01120071";
 /// <summary>
 /// 主题维护
 /// </summary>
public const string _01120072 = "01120072";
 /// <summary>
 /// 主题观点维护
 /// </summary>
public const string _01120073 = "01120073";
 /// <summary>
 /// 主题观点关系
 /// </summary>
public const string _01120074 = "01120074";
 /// <summary>
 /// 主题观点类型
 /// </summary>
public const string _01120075 = "01120075";
 /// <summary>
 /// 基础知识管理
 /// </summary>
public const string _01120076 = "01120076";
 /// <summary>
 /// 基本原理维护
 /// </summary>
public const string _01120078 = "01120078";
 /// <summary>
 /// 专业方向2
 /// </summary>
public const string _01120079 = "01120079";
}
 /// <summary>
 /// CM功能(CMFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMFeatureWApi
{
private static readonly string mstrApiControllerName = "CMFeatureApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCMFeatureWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmFeatureId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM功能]...","0");
List<clsCMFeatureEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CmFeatureId";
objDDL.DataTextField="FeatureName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_CmFeatureId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMFeature.CmFeatureId); 
List<clsCMFeatureEN> arrObjLst = clsCMFeatureWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN()
{
CmFeatureId = "0",
FeatureName = "选[CM功能]..."
};
arrObjLstSel.Insert(0, objCMFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMFeature.CmFeatureId;
objComboBox.DisplayMember = conCMFeature.FeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMFeatureEN objCMFeatureEN)
{
if (!Object.Equals(null, objCMFeatureEN.CmFeatureId) && GetStrLen(objCMFeatureEN.CmFeatureId) > 8)
{
 throw new Exception("字段[功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFeatureEN.FeatureName) && GetStrLen(objCMFeatureEN.FeatureName) > 100)
{
 throw new Exception("字段[功能名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCMFeatureEN.FeatureENName) && GetStrLen(objCMFeatureEN.FeatureENName) > 100)
{
 throw new Exception("字段[功能英文名]的长度不能超过100!");
}
if (!Object.Equals(null, objCMFeatureEN.KeyWords) && GetStrLen(objCMFeatureEN.KeyWords) > 500)
{
 throw new Exception("字段[关键字]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFeatureEN.FeatureDescription) && GetStrLen(objCMFeatureEN.FeatureDescription) > 4000)
{
 throw new Exception("字段[功能说明]的长度不能超过4000!");
}
if (!Object.Equals(null, objCMFeatureEN.CmParentFeatureId) && GetStrLen(objCMFeatureEN.CmParentFeatureId) > 8)
{
 throw new Exception("字段[父功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFeatureEN.ParentFeatureName) && GetStrLen(objCMFeatureEN.ParentFeatureName) > 500)
{
 throw new Exception("字段[父功能名]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFeatureEN.CmFeatureTypeId) && GetStrLen(objCMFeatureEN.CmFeatureTypeId) > 2)
{
 throw new Exception("字段[功能类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCMFeatureEN.CreateUserId) && GetStrLen(objCMFeatureEN.CreateUserId) > 18)
{
 throw new Exception("字段[建立用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objCMFeatureEN.FuncModuleAgcId) && GetStrLen(objCMFeatureEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFeatureEN.CmPrjId) && GetStrLen(objCMFeatureEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objCMFeatureEN.PrjId) && GetStrLen(objCMFeatureEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMFeatureEN.UpdDate) && GetStrLen(objCMFeatureEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureEN.UpdUser) && GetStrLen(objCMFeatureEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureEN.Memo) && GetStrLen(objCMFeatureEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCMFeatureEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
if (strCmFeatureId == "") return null;
string strAction = "GetObjByCmFeatureId";
clsCMFeatureEN objCMFeatureEN;
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
objCMFeatureEN = JsonConvert.DeserializeObject<clsCMFeatureEN>(strJson);
return objCMFeatureEN;
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
public static clsCMFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMFeatureEN objCMFeatureEN;
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
objCMFeatureEN = JsonConvert.DeserializeObject<clsCMFeatureEN>(strJson);
return objCMFeatureEN;
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
public static clsCMFeatureEN GetObjByCmFeatureIdCache(string strCmFeatureId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel =
from objCMFeatureEN in arrCMFeatureObjLstCache
where objCMFeatureEN.CmFeatureId == strCmFeatureId 
select objCMFeatureEN;
if (arrCMFeatureObjLst_Sel.Count() == 0)
{
   clsCMFeatureEN obj = clsCMFeatureWApi.GetObjByCmFeatureId(strCmFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureNameByCmFeatureIdCache(string strCmFeatureId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return "";
//初始化列表缓存
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel1 =
from objCMFeatureEN in arrCMFeatureObjLstCache
where objCMFeatureEN.CmFeatureId == strCmFeatureId 
select objCMFeatureEN;
List <clsCMFeatureEN> arrCMFeatureObjLst_Sel = new List<clsCMFeatureEN>();
foreach (clsCMFeatureEN obj in arrCMFeatureObjLst_Sel1)
{
arrCMFeatureObjLst_Sel.Add(obj);
}
if (arrCMFeatureObjLst_Sel.Count > 0)
{
return arrCMFeatureObjLst_Sel[0].FeatureName;
}
string strErrMsgForGetObjById = string.Format("在CMFeature对象缓存列表中,找不到记录[CmFeatureId = {0}](函数:{1})", strCmFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFeatureIdCache(string strCmFeatureId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return "";
//初始化列表缓存
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel1 =
from objCMFeatureEN in arrCMFeatureObjLstCache
where objCMFeatureEN.CmFeatureId == strCmFeatureId 
select objCMFeatureEN;
List <clsCMFeatureEN> arrCMFeatureObjLst_Sel = new List<clsCMFeatureEN>();
foreach (clsCMFeatureEN obj in arrCMFeatureObjLst_Sel1)
{
arrCMFeatureObjLst_Sel.Add(obj);
}
if (arrCMFeatureObjLst_Sel.Count > 0)
{
return arrCMFeatureObjLst_Sel[0].FeatureName;
}
string strErrMsgForGetObjById = string.Format("在CMFeature对象缓存列表中,找不到记录的相关名称[CmFeatureId = {0}](函数:{1})", strCmFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static List<clsCMFeatureEN> GetObjLstByCmFeatureIdLst(List<string> arrCmFeatureId)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static IEnumerable<clsCMFeatureEN> GetObjLstByCmFeatureIdLstCache(List<string> arrCmFeatureId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel =
from objCMFeatureEN in arrCMFeatureObjLstCache
where arrCmFeatureId.Contains(objCMFeatureEN.CmFeatureId)
select objCMFeatureEN;
return arrCMFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static List<clsCMFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static List<clsCMFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static List<clsCMFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureEN>>(strJson);
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
public static int DelRecord(string strCmFeatureId)
{
string strAction = "DelRecord";
try
{
 clsCMFeatureEN objCMFeatureEN = clsCMFeatureWApi.GetObjByCmFeatureId(strCmFeatureId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCmFeatureId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
public static int DelCMFeatures(List<string> arrCmFeatureId)
{
string strAction = "DelCMFeatures";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFeatureId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsCMFeatureEN objCMFeatureEN = clsCMFeatureWApi.GetObjByCmFeatureId(arrCmFeatureId[0]);
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
public static int DelCMFeaturesByCond(string strWhereCond)
{
string strAction = "DelCMFeaturesByCond";
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
public static bool AddNewRecord(clsCMFeatureEN objCMFeatureEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureEN>(objCMFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
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
public static string AddNewRecordWithMaxId(clsCMFeatureEN objCMFeatureEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureEN>(objCMFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureWApi.ReFreshCache(objCMFeatureEN.CmPrjId);
var strCmFeatureId = (string)jobjReturn0["returnStr"];
return strCmFeatureId;
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
public static bool UpdateRecord(clsCMFeatureEN objCMFeatureEN)
{
if (string.IsNullOrEmpty(objCMFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureEN.CmFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureEN>(objCMFeatureEN);
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMFeatureEN objCMFeatureEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureEN.CmFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureEN.CmFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureEN>(objCMFeatureEN);
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
 /// <param name = "objCMFeatureENS">源对象</param>
 /// <param name = "objCMFeatureENT">目标对象</param>
 public static void CopyTo(clsCMFeatureEN objCMFeatureENS, clsCMFeatureEN objCMFeatureENT)
{
try
{
objCMFeatureENT.CmFeatureId = objCMFeatureENS.CmFeatureId; //功能Id
objCMFeatureENT.FeatureName = objCMFeatureENS.FeatureName; //功能名称
objCMFeatureENT.FeatureENName = objCMFeatureENS.FeatureENName; //功能英文名
objCMFeatureENT.KeyWords = objCMFeatureENS.KeyWords; //关键字
objCMFeatureENT.FeatureDescription = objCMFeatureENS.FeatureDescription; //功能说明
objCMFeatureENT.CmParentFeatureId = objCMFeatureENS.CmParentFeatureId; //父功能Id
objCMFeatureENT.ParentFeatureName = objCMFeatureENS.ParentFeatureName; //父功能名
objCMFeatureENT.CmFeatureTypeId = objCMFeatureENS.CmFeatureTypeId; //功能类型Id
objCMFeatureENT.CreateUserId = objCMFeatureENS.CreateUserId; //建立用户Id
objCMFeatureENT.InUse = objCMFeatureENS.InUse; //是否在用
objCMFeatureENT.OrderNum = objCMFeatureENS.OrderNum; //序号
objCMFeatureENT.FuncModuleAgcId = objCMFeatureENS.FuncModuleAgcId; //功能模块Id
objCMFeatureENT.CmPrjId = objCMFeatureENS.CmPrjId; //Cm工程Id
objCMFeatureENT.PrjId = objCMFeatureENS.PrjId; //工程Id
objCMFeatureENT.UpdDate = objCMFeatureENS.UpdDate; //修改日期
objCMFeatureENT.UpdUser = objCMFeatureENS.UpdUser; //修改者
objCMFeatureENT.Memo = objCMFeatureENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCMFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMFeatureEN._AttributeName)
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
public static void ReFreshThisCache(string strCmPrjId = "")
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsCMFeatureWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsCMFeatureWApi.ReFreshThisCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
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
public static void ReFreshCache(string strCmPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCMFeatureWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsCMFeatureWApi.objCommFun4WApi.ReFreshCache(strCmPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsCMFeatureWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsCMFeatureWApi.GetObjLstCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsCMFeatureEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsCMFeatureEN._WhereFormat, strCmPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conCMFeature.CmPrjId, strCmPrjId);
}
var strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstCacheFromObjLst(string strCmPrjId,List<clsCMFeatureEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsCMFeatureWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsCMFeatureWApi.GetObjLstCacheFromObjLst)", strCmPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strCmPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrCMFeatureObjLstCache = CacheHelper.Get<List<clsCMFeatureEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.CmPrjId == strCmPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrCMFeatureObjLstCache = CacheHelper.Get<List<clsCMFeatureEN>>(strKey);
}
return arrCMFeatureObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMFeature.CmFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.FeatureENName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.CmParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.CmFeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMFeature.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeature.Memo, Type.GetType("System.String"));
foreach (clsCMFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMFeature.CmFeatureId] = objInFor[conCMFeature.CmFeatureId];
objDR[conCMFeature.FeatureName] = objInFor[conCMFeature.FeatureName];
objDR[conCMFeature.FeatureENName] = objInFor[conCMFeature.FeatureENName];
objDR[conCMFeature.KeyWords] = objInFor[conCMFeature.KeyWords];
objDR[conCMFeature.FeatureDescription] = objInFor[conCMFeature.FeatureDescription];
objDR[conCMFeature.CmParentFeatureId] = objInFor[conCMFeature.CmParentFeatureId];
objDR[conCMFeature.ParentFeatureName] = objInFor[conCMFeature.ParentFeatureName];
objDR[conCMFeature.CmFeatureTypeId] = objInFor[conCMFeature.CmFeatureTypeId];
objDR[conCMFeature.CreateUserId] = objInFor[conCMFeature.CreateUserId];
objDR[conCMFeature.InUse] = objInFor[conCMFeature.InUse];
objDR[conCMFeature.OrderNum] = objInFor[conCMFeature.OrderNum];
objDR[conCMFeature.FuncModuleAgcId] = objInFor[conCMFeature.FuncModuleAgcId];
objDR[conCMFeature.CmPrjId] = objInFor[conCMFeature.CmPrjId];
objDR[conCMFeature.PrjId] = objInFor[conCMFeature.PrjId];
objDR[conCMFeature.UpdDate] = objInFor[conCMFeature.UpdDate];
objDR[conCMFeature.UpdUser] = objInFor[conCMFeature.UpdUser];
objDR[conCMFeature.Memo] = objInFor[conCMFeature.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM功能(CMFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMFeature : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCmPrjId)
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
clsCMFeatureWApi.ReFreshThisCache(strCmPrjId);
}
}

}