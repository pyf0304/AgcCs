
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureWApi
 表名:PrjFeature(00050322)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsPrjFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureId(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conPrjFeature.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conPrjFeature.FeatureId);
objPrjFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureName(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, conPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, conPrjFeature.FeatureName);
objPrjFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureENName">功能英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureENName(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, conPrjFeature.FeatureENName);
objPrjFeatureEN.FeatureENName = strFeatureENName; //功能英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureENName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureENName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureENName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetKeyWords(this clsPrjFeatureEN objPrjFeatureEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conPrjFeature.KeyWords);
objPrjFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.KeyWords) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.KeyWords, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.KeyWords] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaButtonName">默认按钮名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetDefaButtonName(this clsPrjFeatureEN objPrjFeatureEN, string strDefaButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaButtonName, 30, conPrjFeature.DefaButtonName);
objPrjFeatureEN.DefaButtonName = strDefaButtonName; //默认按钮名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.DefaButtonName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.DefaButtonName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.DefaButtonName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaButtonName4Mvc">默认按钮名4Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetDefaButtonName4Mvc(this clsPrjFeatureEN objPrjFeatureEN, string strDefaButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaButtonName4Mvc, 30, conPrjFeature.DefaButtonName4Mvc);
objPrjFeatureEN.DefaButtonName4Mvc = strDefaButtonName4Mvc; //默认按钮名4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.DefaButtonName4Mvc) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.DefaButtonName4Mvc, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.DefaButtonName4Mvc] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetRegionTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conPrjFeature.RegionTypeId);
objPrjFeatureEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.RegionTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.RegionTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.RegionTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetGroupName(this clsPrjFeatureEN objPrjFeatureEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 30, conPrjFeature.GroupName);
objPrjFeatureEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.GroupName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.GroupName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.GroupName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureDescription(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conPrjFeature.FeatureDescription);
objPrjFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureDescription) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureDescription, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureDescription] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetInOutTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conPrjFeature.InOutTypeId);
objPrjFeatureEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.InOutTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.InOutTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.InOutTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedField">是否需要字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetIsNeedField(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedField, string strComparisonOp="")
	{
objPrjFeatureEN.IsNeedField = bolIsNeedField; //是否需要字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.IsNeedField) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.IsNeedField, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.IsNeedField] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTabFeature">是否需要表功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetIsNeedTabFeature(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedTabFeature, string strComparisonOp="")
	{
objPrjFeatureEN.IsNeedTabFeature = bolIsNeedTabFeature; //是否需要表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.IsNeedTabFeature) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.IsNeedTabFeature, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.IsNeedTabFeature] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetParentFeatureId(this clsPrjFeatureEN objPrjFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, conPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, conPrjFeature.ParentFeatureId);
objPrjFeatureEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.ParentFeatureId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.ParentFeatureId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.ParentFeatureId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetParentFeatureName(this clsPrjFeatureEN objPrjFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, conPrjFeature.ParentFeatureName);
objPrjFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.ParentFeatureName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.ParentFeatureName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.ParentFeatureName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFunctionGroupId(this clsPrjFeatureEN objPrjFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, conPrjFeature.FunctionGroupId);
objPrjFeatureEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FunctionGroupId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FunctionGroupId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FunctionGroupId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, conPrjFeature.FeatureTypeId);
objPrjFeatureEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetCreateUserId(this clsPrjFeatureEN objPrjFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conPrjFeature.CreateUserId);
objPrjFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.CreateUserId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.CreateUserId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.CreateUserId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetInUse(this clsPrjFeatureEN objPrjFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objPrjFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.InUse) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.InUse, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.InUse] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetOrderNum(this clsPrjFeatureEN objPrjFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conPrjFeature.OrderNum);
objPrjFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.OrderNum) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.OrderNum, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.OrderNum] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetUpdDate(this clsPrjFeatureEN objPrjFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjFeature.UpdDate);
objPrjFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.UpdDate) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.UpdDate, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.UpdDate] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetUpdUser(this clsPrjFeatureEN objPrjFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjFeature.UpdUser);
objPrjFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.UpdUser) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.UpdUser, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.UpdUser] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetMemo(this clsPrjFeatureEN objPrjFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjFeature.Memo);
objPrjFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.Memo) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.Memo, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.Memo] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjFeatureEN objPrjFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureId, objPrjFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureName, objPrjFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureENName) == true)
{
string strComparisonOpFeatureENName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureENName, objPrjFeatureCond.FeatureENName, strComparisonOpFeatureENName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.KeyWords, objPrjFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.DefaButtonName) == true)
{
string strComparisonOpDefaButtonName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.DefaButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.DefaButtonName, objPrjFeatureCond.DefaButtonName, strComparisonOpDefaButtonName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.DefaButtonName4Mvc) == true)
{
string strComparisonOpDefaButtonName4Mvc = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.DefaButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.DefaButtonName4Mvc, objPrjFeatureCond.DefaButtonName4Mvc, strComparisonOpDefaButtonName4Mvc);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.RegionTypeId, objPrjFeatureCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.GroupName) == true)
{
string strComparisonOpGroupName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.GroupName, objPrjFeatureCond.GroupName, strComparisonOpGroupName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureDescription, objPrjFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.InOutTypeId, objPrjFeatureCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.IsNeedField) == true)
{
if (objPrjFeatureCond.IsNeedField == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.IsNeedField);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.IsNeedField);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.IsNeedTabFeature) == true)
{
if (objPrjFeatureCond.IsNeedTabFeature == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.IsNeedTabFeature);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.IsNeedTabFeature);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.ParentFeatureId, objPrjFeatureCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.ParentFeatureName, objPrjFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FunctionGroupId, objPrjFeatureCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureTypeId, objPrjFeatureCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.CreateUserId, objPrjFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.InUse) == true)
{
if (objPrjFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.InUse);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjFeature.OrderNum, objPrjFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.UpdDate, objPrjFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.UpdUser, objPrjFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.Memo) == true)
{
string strComparisonOpMemo = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.Memo, objPrjFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFeatureEN objPrjFeatureEN)
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjFeatureEN.sfUpdFldSetStr = objPrjFeatureEN.getsfUpdFldSetStr();
clsPrjFeatureWApi.CheckPropertyNew(objPrjFeatureEN); 
bool bolResult = clsPrjFeatureWApi.UpdateRecord(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
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
 /// 获取唯一性条件串--PrjFeature(功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjFeatureEN objPrjFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjFeatureEN == null) return "";
if (objPrjFeatureEN.FeatureId == null || objPrjFeatureEN.FeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FeatureId !=  '{0}'", objPrjFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjFeatureEN objPrjFeatureEN)
{
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureWApi.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureWApi.GetMaxStrId();
 }
clsPrjFeatureWApi.CheckPropertyNew(objPrjFeatureEN); 
bool bolResult = clsPrjFeatureWApi.AddNewRecord(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjFeatureEN objPrjFeatureEN)
{
try
{
clsPrjFeatureWApi.CheckPropertyNew(objPrjFeatureEN); 
string strFeatureId = clsPrjFeatureWApi.AddNewRecordWithMaxId(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
return strFeatureId;
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFeatureEN objPrjFeatureEN, string strWhereCond)
{
try
{
clsPrjFeatureWApi.CheckPropertyNew(objPrjFeatureEN); 
bool bolResult = clsPrjFeatureWApi.UpdateWithCondition(objPrjFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
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
public class enumPrjFeatureWA
{
 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// </summary>
public const string _0004 = "0004";
 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入-Sim
 /// </summary>
public const string _0005 = "0005";
 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0006 = "0006";
 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0007 = "0007";
 /// <summary>
 /// 根据条件获取一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0008 = "0008";
 /// <summary>
 /// 根据条件获取一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击(带排除)
 /// </summary>
public const string _0010 = "0010";
 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取
 /// </summary>
public const string _0011 = "0011";
 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0012 = "0012";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0014 = "0014";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0015 = "0015";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0016 = "0016";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0017 = "0017";
 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0018 = "0018";
 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0019 = "0019";
 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0020 = "0020";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0021 = "0021";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0022 = "0022";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0023 = "0023";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// </summary>
public const string _0024 = "0024";
 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0025 = "0025";
 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0026 = "0026";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0027 = "0027";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检(带排除)
 /// </summary>
public const string _0028 = "0028";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击.
 /// </summary>
public const string _0029 = "0029";
 /// <summary>
 /// 根据条件获取对象列表,带排除
 /// </summary>
public const string _0030 = "0030";
 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// </summary>
public const string _0031 = "0031";
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示
 /// </summary>
public const string _0032 = "0032";
 /// <summary>
 /// 根据关键字工获取相关对象,用对象的形式表示.
 /// </summary>
public const string _0033 = "0033";
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程College_SelectOne来获取
 /// </summary>
public const string _0034 = "0034";
 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// </summary>
public const string _0035 = "0035";
 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// </summary>
public const string _0036 = "0036";
 /// <summary>
 /// 把DataRow转换成记录对象
 /// </summary>
public const string _0037 = "0037";
 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// </summary>
public const string _0038 = "0038";
 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// </summary>
public const string _0039 = "0039";
 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// </summary>
public const string _0040 = "0040";
 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// </summary>
public const string _0041 = "0041";
 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// </summary>
public const string _0042 = "0042";
 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// </summary>
public const string _0043 = "0043";
 /// <summary>
 /// 判断是否存在某一条件的记录
 /// </summary>
public const string _0044 = "0044";
 /// <summary>
 /// 检查是否存在当前表
 /// </summary>
public const string _0045 = "0045";
 /// <summary>
 /// 添加新记录
 /// </summary>
public const string _0046 = "0046";
 /// <summary>
 /// 通过SQL命令来插入记录
 /// </summary>
public const string _0047 = "0047";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式
 /// </summary>
public const string _0048 = "0048";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值
 /// </summary>
public const string _0049 = "0049";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,进行事务处理
 /// </summary>
public const string _0050 = "0050";
 /// <summary>
 /// 通过SQL命令来插入记录,带事务处理
 /// </summary>
public const string _0051 = "0051";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,带事务处理
 /// </summary>
public const string _0052 = "0052";
 /// <summary>
 /// 通过存储过程来插入记录
 /// </summary>
public const string _0053 = "0053";
 /// <summary>
 /// 把多条记录同时插入到表中
 /// </summary>
public const string _0054 = "0054";
 /// <summary>
 /// 通过ADO修改记录
 /// </summary>
public const string _0055 = "0055";
 /// <summary>
 /// 通过存储过程(StoreProcedure)来修改记录
 /// </summary>
public const string _0056 = "0056";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式
 /// </summary>
public const string _0057 = "0057";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是优化方式
 /// </summary>
public const string _0058 = "0058";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// </summary>
public const string _0059 = "0059";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// </summary>
public const string _0060 = "0060";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式.(带事务处理)
 /// </summary>
public const string _0061 = "0061";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// </summary>
public const string _0062 = "0062";
 /// <summary>
 /// 删除关键字所指定的记录,通过存储过程(SP)来删除
 /// </summary>
public const string _0063 = "0063";
 /// <summary>
 /// 删除关键字所指的记录,使用事务
 /// </summary>
public const string _0064 = "0064";
 /// <summary>
 /// 同时删除多条记录,删除给定关键字列表的记录
 /// </summary>
public const string _0065 = "0065";
 /// <summary>
 /// 删除关键字所指定的记录
 /// </summary>
public const string _0066 = "0066";
 /// <summary>
 /// 删除满足条件的多条记录
 /// </summary>
public const string _0067 = "0067";
 /// <summary>
 /// 删除满足条件的多条记录,同时处理事务
 /// </summary>
public const string _0068 = "0068";
 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// </summary>
public const string _0069 = "0069";
 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// </summary>
public const string _0070 = "0070";
 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// </summary>
public const string _0071 = "0071";
 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// </summary>
public const string _0072 = "0072";
 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// </summary>
public const string _0073 = "0073";
 /// <summary>
 /// 专门针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// </summary>
public const string _0074 = "0074";
 /// <summary>
 /// 检查对象字段值是否合法,1)检查字段值长度是否超长;2)检查属性是否包含Sql注入等非法字符.
 /// </summary>
public const string _0075 = "0075";
 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// </summary>
public const string _0076 = "0076";
 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// </summary>
public const string _0077 = "0077";
 /// <summary>
 /// 检查唯一性(Uniqueness), 如果不唯一,即存在相同的记录,就返回False
 /// </summary>
public const string _0078 = "0078";
 /// <summary>
 /// 获取唯一性条件串(Uniqueness)
 /// </summary>
public const string _0079 = "0079";
 /// <summary>
 /// 把Null数据转换成String型,如果给定的对象不是Null,就直接返回
 /// </summary>
public const string _0080 = "0080";
 /// <summary>
 /// 把给定的异常对象存储到日志中去
 /// </summary>
public const string _0081 = "0081";
 /// <summary>
 /// 把给定的异常对象存储到日志中去(含模块名)
 /// </summary>
public const string _0082 = "0082";
 /// <summary>
 /// 获取给定表的记录数, 该表与当前类不相关
 /// </summary>
public const string _0083 = "0083";
 /// <summary>
 /// 获取给定表中满足条件的记录数, 该表与当前类不相关
 /// </summary>
public const string _0084 = "0084";
 /// <summary>
 /// 获取当前表的记录数.该表与当前类相关
 /// </summary>
public const string _0085 = "0085";
 /// <summary>
 /// 获取当前表中满足条件的记录数, 该表与当前类相关
 /// </summary>
public const string _0086 = "0086";
 /// <summary>
 /// 获取给定表中的符合条件的某字段的值,以列表返回
 /// </summary>
public const string _0087 = "0087";
 /// <summary>
 /// 获取当前表中的符合条件的某字段的值,以列表返回
 /// </summary>
public const string _0088 = "0088";
 /// <summary>
 /// 获取当前表中的符合条件的某字段的值,以列表返回(去除重复值)
 /// </summary>
public const string _0089 = "0089";
 /// <summary>
 /// 设置当前表中的符合条件的某字段的值
 /// </summary>
public const string _0090 = "0090";
 /// <summary>
 /// 获取SQL服务器连接对象(静态)
 /// </summary>
public const string _0091 = "0091";
 /// <summary>
 /// 获取SQL服务器连接对象
 /// </summary>
public const string _0092 = "0092";
 /// <summary>
 /// Copy_根据条件获取一定范围数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0093 = "0093";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0094 = "0094";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0095 = "0095";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0096 = "0096";
 /// <summary>
 /// 构造函数
 /// </summary>
public const string _0097 = "0097";
 /// <summary>
 /// 根据条件获取顶部对象列表
 /// </summary>
public const string _0098 = "0098";
 /// <summary>
 /// 根据条件获取一定范围对象列表
 /// </summary>
public const string _0099 = "0099";
 /// <summary>
 /// 根据条件获取对象列表
 /// </summary>
public const string _0100 = "0100";
 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// </summary>
public const string _0101 = "0101";
 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// </summary>
public const string _0102 = "0102";
 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// </summary>
public const string _0103 = "0103";
 /// <summary>
 /// 通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// </summary>
public const string _0104 = "0104";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// </summary>
public const string _0105 = "0105";
 /// <summary>
 /// 把对象转换成简化对象
 /// </summary>
public const string _0106 = "0106";
 /// <summary>
 /// 把简化对象转换成对象
 /// </summary>
public const string _0107 = "0107";
 /// <summary>
 /// 把简化对象转换成对象.专门针对修改记录，即脏字段才复制
 /// </summary>
public const string _0108 = "0108";
 /// <summary>
 /// 把对象列表转换成简化对象列表
 /// </summary>
public const string _0109 = "0109";
 /// <summary>
 /// 绑定基于Win的下拉框
 /// </summary>
public const string _0110 = "0110";
 /// <summary>
 /// 绑定基于Web的下拉框
 /// </summary>
public const string _0111 = "0111";
 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// </summary>
public const string _0112 = "0112";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// </summary>
public const string _0113 = "0113";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.(再试一次)
 /// </summary>
public const string _0114 = "0114";
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// </summary>
public const string _0115 = "0115";
 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// </summary>
public const string _0116 = "0116";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
 /// </summary>
public const string _0117 = "0117";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.(一次)
 /// </summary>
public const string _0118 = "0118";
 /// <summary>
 /// 序列化一个对象列表到Xml字符串
 /// </summary>
public const string _0119 = "0119";
 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// </summary>
public const string _0120 = "0120";
 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// </summary>
public const string _0121 = "0121";
 /// <summary>
 /// 序列化一个对象到XmlWriter
 /// </summary>
public const string _0122 = "0122";
 /// <summary>
 /// 从XML串中获取一个对象列表
 /// </summary>
public const string _0123 = "0123";
 /// <summary>
 /// 从XML文件中获取一个对象列表
 /// </summary>
public const string _0124 = "0124";
 /// <summary>
 /// 读XmlReader到一个对象
 /// </summary>
public const string _0125 = "0125";
 /// <summary>
 /// 读Xml字符串到一个对象
 /// </summary>
public const string _0126 = "0126";
 /// <summary>
 /// 序列化一个对象到Xml字符串
 /// </summary>
public const string _0127 = "0127";
 /// <summary>
 /// 获取当前类的相关表名
 /// </summary>
public const string _0128 = "0128";
 /// <summary>
 /// 定义对象:专门在逻辑层用于处理缓存等公共函数的对象
 /// </summary>
public const string _0129 = "0129";
 /// <summary>
 /// 定义常量:专门在逻辑层用于处理XML的常量
 /// </summary>
public const string _0130 = "0130";
 /// <summary>
 /// 定义缓存对象列表:专门在逻辑层用于处理缓存的对象列表
 /// </summary>
public const string _0131 = "0131";
 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// </summary>
public const string _0132 = "0132";
 /// <summary>
 /// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
 /// </summary>
public const string _0133 = "0133";
 /// <summary>
 /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
 /// </summary>
public const string _0134 = "0134";
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集
 /// </summary>
public const string _0135 = "0135";
 /// <summary>
 /// 添加
 /// </summary>
public const string AddNewRecord_0136 = "0136";
 /// <summary>
 /// 修改
 /// </summary>
public const string UpdateRecord_0137 = "0137";
 /// <summary>
 /// 删除
 /// </summary>
public const string DelRecord_0138 = "0138";
 /// <summary>
 /// 查询
 /// </summary>
public const string Query_0139 = "0139";
 /// <summary>
 /// 查询并显示
 /// </summary>
public const string _0140 = "0140";
 /// <summary>
 /// 复制记录
 /// </summary>
public const string CopyRecord_0141 = "0141";
 /// <summary>
 /// 调整次序
 /// </summary>
public const string AdjustOrderNum_0142 = "0142";
 /// <summary>
 /// 导出Excel
 /// </summary>
public const string ExportToFile_0143 = "0143";
 /// <summary>
 /// 设置导出字段
 /// </summary>
public const string SetExportExcel4User_0144 = "0144";
 /// <summary>
 /// 初始化列表缓存.
 /// </summary>
public const string _0145 = "0145";
 /// <summary>
 /// 刷新缓存.把当前表的缓存清空.
 /// </summary>
public const string _0146 = "0146";
 /// <summary>
 /// 根据条件获取对象列表,返回JSON串
 /// </summary>
public const string _0147 = "0147";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string SetFieldValue_0148 = "0148";
 /// <summary>
 /// 界面初始化
 /// </summary>
public const string _0149 = "0149";
 /// <summary>
 /// 权限管理
 /// </summary>
public const string _0150 = "0150";
 /// <summary>
 /// 定义字段控件属性
 /// </summary>
public const string _0151 = "0151";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string BindDdl_0152 = "0152";
 /// <summary>
 /// 校验控件值
 /// </summary>
public const string _0153 = "0153";
 /// <summary>
 /// 设置控件状态
 /// </summary>
public const string _0154 = "0154";
 /// <summary>
 /// 任务队列
 /// </summary>
public const string _0155 = "0155";
 /// <summary>
 /// 用户控件初始化
 /// </summary>
public const string _0156 = "0156";
 /// <summary>
 /// 标志删除
 /// </summary>
public const string DelRecordBySign_0157 = "0157";
 /// <summary>
 /// 恢复删除
 /// </summary>
public const string UnDelRecordBySign_0158 = "0158";
 /// <summary>
 /// 移顶00
 /// </summary>
public const string GoTop_0159 = "0159";
 /// <summary>
 /// 上移00
 /// </summary>
public const string UpMove_0160 = "0160";
 /// <summary>
 /// 下移00
 /// </summary>
public const string DownMove_0161 = "0161";
 /// <summary>
 /// 移底00
 /// </summary>
public const string GoButton_0162 = "0162";
 /// <summary>
 /// 重序00
 /// </summary>
public const string ReOrder_0163 = "0163";
 /// <summary>
 /// 添加-弹出层
 /// </summary>
public const string AddRecord_Popup_0164 = "0164";
 /// <summary>
 /// 修改-弹出层
 /// </summary>
public const string UpdateRecord_Popup_0165 = "0165";
 /// <summary>
 /// 批量修改
 /// </summary>
public const string BatchUpdateRecord_0166 = "0166";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string Tab_AdjustOrderNum_0167 = "0167";
 /// <summary>
 /// 根据标志删除
 /// </summary>
public const string Tab_DelRecordBySign_0168 = "0168";
 /// <summary>
 /// 恢复删除
 /// </summary>
public const string Tab_UnDelRecordBySign_0169 = "0169";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string Tab_SetFieldValue_0170 = "0170";
 /// <summary>
 /// XML相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0171 = "0171";
 /// <summary>
 /// 表相关事务操作
 /// </summary>
public const string Tab_TransEvent_0172 = "0172";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string Tab_BindDdl_0173 = "0173";
 /// <summary>
 /// 修改Gv
 /// </summary>
public const string UpdateRecord_Gv_0174 = "0174";
 /// <summary>
 /// 删除Gv
 /// </summary>
public const string DelRecord_Gv_0175 = "0175";
 /// <summary>
 /// 详细信息_Gv
 /// </summary>
public const string DetailRecord_Gv_0181 = "0181";
 /// <summary>
 /// 选择记录_Gv
 /// </summary>
public const string SelectRecord_Gv_0182 = "0182";
 /// <summary>
 /// 添加-关键字自增
 /// </summary>
public const string AddNewRecordWithMaxId_0183 = "0183";
 /// <summary>
 /// 删除
 /// </summary>
public const string DelRecord_0184 = "0184";
 /// <summary>
 /// 查询
 /// </summary>
public const string Query_0186 = "0186";
 /// <summary>
 /// 根据标志删除
 /// </summary>
public const string Tab_DelRecordBySign_0190 = "0190";
 /// <summary>
 /// XML相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0192 = "0192";
 /// <summary>
 /// 事务操作
 /// </summary>
public const string Tab_TransEvent_0193 = "0193";
 /// <summary>
 /// 导出Excel
 /// </summary>
public const string ExportToFile_0196 = "0196";
 /// <summary>
 /// 添加
 /// </summary>
public const string AddNewRecord_0197 = "0197";
 /// <summary>
 /// 复制记录
 /// </summary>
public const string CopyRecord_0198 = "0198";
 /// <summary>
 /// 修改
 /// </summary>
public const string UpdateRecord_0199 = "0199";
 /// <summary>
 /// 获取对象
 /// </summary>
public const string _0200 = "0200";
 /// <summary>
 /// 获取对象列表
 /// </summary>
public const string _0201 = "0201";
 /// <summary>
 /// 检查表关键字是否合法
 /// </summary>
public const string _0202 = "0202";
 /// <summary>
 /// 获取SQL服务器连接对象
 /// </summary>
public const string _0203 = "0203";
 /// <summary>
 /// 获取数据集
 /// </summary>
public const string _0204 = "0204";
 /// <summary>
 /// 获取数据表
 /// </summary>
public const string _0205 = "0205";
 /// <summary>
 /// 获取字符串长度
 /// </summary>
public const string _0206 = "0206";
 /// <summary>
 /// 检查唯一性
 /// </summary>
public const string _0207 = "0207";
 /// <summary>
 /// 把Null数据转换成相应类型
 /// </summary>
public const string _0208 = "0208";
 /// <summary>
 /// 日志操作
 /// </summary>
public const string _0209 = "0209";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string Tab_SetFieldValue_0210 = "0210";
 /// <summary>
 /// 获取表的记录数
 /// </summary>
public const string _0211 = "0211";
 /// <summary>
 /// 获取字段值
 /// </summary>
public const string Tab_SetFieldValue_0212 = "0212";
 /// <summary>
 /// 把DataRow转换成对象
 /// </summary>
public const string _0213 = "0213";
 /// <summary>
 /// 构造函数
 /// </summary>
public const string _0214 = "0214";
 /// <summary>
 /// 定义属性
 /// </summary>
public const string _0215 = "0215";
 /// <summary>
 /// 获取关键字、名称
 /// </summary>
public const string _0216 = "0216";
 /// <summary>
 /// 定义字段常量
 /// </summary>
public const string _0217 = "0217";
 /// <summary>
 /// Json相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0218 = "0218";
 /// <summary>
 /// 条件串
 /// </summary>
public const string Tab_XMLRelaOP_0219 = "0219";
 /// <summary>
 /// 数据同步
 /// </summary>
public const string Tab_XMLRelaOP_0220 = "0220";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string Tab_BindDdl_0221 = "0221";
 /// <summary>
 /// 缓存操作
 /// </summary>
public const string _0222 = "0222";
 /// <summary>
 /// 获取最大关键字Id
 /// </summary>
public const string _0223 = "0223";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string AdjustOrderNum_0224 = "0224";
 /// <summary>
 /// 排序函数
 /// </summary>
public const string AdjustOrderNum_0225 = "0225";
 /// <summary>
 /// 检查约束
 /// </summary>
public const string _0226 = "0226";
 /// <summary>
 /// 检查表字段
 /// </summary>
public const string _0227 = "0227";
 /// <summary>
 /// 判断是否存在记录
 /// </summary>
public const string _0228 = "0228";
 /// <summary>
 /// 测试
 /// </summary>
public const string _0229 = "0229";
 /// <summary>
 /// 定义枚举常量
 /// </summary>
public const string _0230 = "0230";
 /// <summary>
 /// 打印区域定义
 /// </summary>
public const string _0231 = "0231";
 /// <summary>
 /// 绑定列表
 /// </summary>
public const string Tab_BindList_0232 = "0232";
 /// <summary>
 /// 权限管理
 /// </summary>
public const string _0233 = "0233";
 /// <summary>
 /// 状态管理
 /// </summary>
public const string _0234 = "0234";
 /// <summary>
 /// 页面导入
 /// </summary>
public const string _0235 = "0235";
 /// <summary>
 /// 编辑
 /// </summary>
public const string EditRecord_0236 = "0236";
 /// <summary>
 /// 获取设置页面数据
 /// </summary>
public const string _0237 = "0237";
 /// <summary>
 /// 区域代码生成
 /// </summary>
public const string Tab_XMLRelaOP_0238 = "0238";
 /// <summary>
 /// 详细信息
 /// </summary>
public const string DetailRecord_0239 = "0239";
 /// <summary>
 /// 自定义功能
 /// </summary>
public const string DefaultFeature_0240 = "0240";
 /// <summary>
 /// 重序00
 /// </summary>
public const string Tab_ReOrder_1187 = "1187";
 /// <summary>
 /// 移底00
 /// </summary>
public const string Tab_GoButton_1188 = "1188";
 /// <summary>
 /// 下移00
 /// </summary>
public const string Tab_DownMove_1189 = "1189";
 /// <summary>
 /// 移顶00
 /// </summary>
public const string Tab_GoTop_1194 = "1194";
 /// <summary>
 /// 上移00
 /// </summary>
public const string Tab_UpMove_1195 = "1195";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string AdjustOrderNum_1196 = "1196";
}
 /// <summary>
 /// 功能(PrjFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjFeatureWApi
{
private static readonly string mstrApiControllerName = "PrjFeatureApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsPrjFeatureWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FeatureId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能]...","0");
List<clsPrjFeatureEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FeatureId";
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

 /// <param name = "strFeatureTypeId"></param>
public static void BindCbo_FeatureId(System.Windows.Forms.ComboBox objComboBox , string strFeatureTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjFeature.FeatureId); 
List<clsPrjFeatureEN> arrObjLst = clsPrjFeatureWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FeatureTypeId == strFeatureTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN()
{
FeatureId = "0",
FeatureName = "选[功能]..."
};
arrObjLstSel.Insert(0, objPrjFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjFeature.FeatureId;
objComboBox.DisplayMember = conPrjFeature.FeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjFeatureEN objPrjFeatureEN)
{
if (!Object.Equals(null, objPrjFeatureEN.FeatureId) && GetStrLen(objPrjFeatureEN.FeatureId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjFeatureEN.FeatureName) && GetStrLen(objPrjFeatureEN.FeatureName) > 100)
{
 throw new Exception("字段[功能名称]的长度不能超过100!");
}
if (!Object.Equals(null, objPrjFeatureEN.FeatureENName) && GetStrLen(objPrjFeatureEN.FeatureENName) > 100)
{
 throw new Exception("字段[功能英文名]的长度不能超过100!");
}
if (!Object.Equals(null, objPrjFeatureEN.KeyWords) && GetStrLen(objPrjFeatureEN.KeyWords) > 500)
{
 throw new Exception("字段[关键字]的长度不能超过500!");
}
if (!Object.Equals(null, objPrjFeatureEN.DefaButtonName) && GetStrLen(objPrjFeatureEN.DefaButtonName) > 30)
{
 throw new Exception("字段[默认按钮名]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjFeatureEN.DefaButtonName4Mvc) && GetStrLen(objPrjFeatureEN.DefaButtonName4Mvc) > 30)
{
 throw new Exception("字段[默认按钮名4Mvc]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjFeatureEN.RegionTypeId) && GetStrLen(objPrjFeatureEN.RegionTypeId) > 4)
{
 throw new Exception("字段[区域类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjFeatureEN.GroupName) && GetStrLen(objPrjFeatureEN.GroupName) > 30)
{
 throw new Exception("字段[组名]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjFeatureEN.FeatureDescription) && GetStrLen(objPrjFeatureEN.FeatureDescription) > 4000)
{
 throw new Exception("字段[功能说明]的长度不能超过4000!");
}
if (!Object.Equals(null, objPrjFeatureEN.InOutTypeId) && GetStrLen(objPrjFeatureEN.InOutTypeId) > 2)
{
 throw new Exception("字段[INOUT类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjFeatureEN.ParentFeatureId) && GetStrLen(objPrjFeatureEN.ParentFeatureId) > 4)
{
 throw new Exception("字段[父功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjFeatureEN.ParentFeatureName) && GetStrLen(objPrjFeatureEN.ParentFeatureName) > 500)
{
 throw new Exception("字段[父功能名]的长度不能超过500!");
}
if (!Object.Equals(null, objPrjFeatureEN.FunctionGroupId) && GetStrLen(objPrjFeatureEN.FunctionGroupId) > 4)
{
 throw new Exception("字段[函数组Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjFeatureEN.FeatureTypeId) && GetStrLen(objPrjFeatureEN.FeatureTypeId) > 2)
{
 throw new Exception("字段[功能类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjFeatureEN.CreateUserId) && GetStrLen(objPrjFeatureEN.CreateUserId) > 18)
{
 throw new Exception("字段[建立用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objPrjFeatureEN.UpdDate) && GetStrLen(objPrjFeatureEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjFeatureEN.UpdUser) && GetStrLen(objPrjFeatureEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjFeatureEN.Memo) && GetStrLen(objPrjFeatureEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objPrjFeatureEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
if (strFeatureId == "") return null;
string strAction = "GetObjByFeatureId";
clsPrjFeatureEN objPrjFeatureEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFeatureId"] = strFeatureId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objPrjFeatureEN = JsonConvert.DeserializeObject<clsPrjFeatureEN>(strJson);
return objPrjFeatureEN;
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
public static clsPrjFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjFeatureEN objPrjFeatureEN;
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
objPrjFeatureEN = JsonConvert.DeserializeObject<clsPrjFeatureEN>(strJson);
return objPrjFeatureEN;
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
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFeatureEN GetObjByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel =
from objPrjFeatureEN in arrPrjFeatureObjLstCache
where objPrjFeatureEN.FeatureId == strFeatureId 
select objPrjFeatureEN;
if (arrPrjFeatureObjLst_Sel.Count() == 0)
{
   clsPrjFeatureEN obj = clsPrjFeatureWApi.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//初始化列表缓存
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel1 =
from objPrjFeatureEN in arrPrjFeatureObjLstCache
where objPrjFeatureEN.FeatureId == strFeatureId 
select objPrjFeatureEN;
List <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel = new List<clsPrjFeatureEN>();
foreach (clsPrjFeatureEN obj in arrPrjFeatureObjLst_Sel1)
{
arrPrjFeatureObjLst_Sel.Add(obj);
}
if (arrPrjFeatureObjLst_Sel.Count > 0)
{
return arrPrjFeatureObjLst_Sel[0].FeatureName;
}
string strErrMsgForGetObjById = string.Format("在PrjFeature对象缓存列表中,找不到记录[FeatureId = {0}](函数:{1})", strFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//初始化列表缓存
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel1 =
from objPrjFeatureEN in arrPrjFeatureObjLstCache
where objPrjFeatureEN.FeatureId == strFeatureId 
select objPrjFeatureEN;
List <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel = new List<clsPrjFeatureEN>();
foreach (clsPrjFeatureEN obj in arrPrjFeatureObjLst_Sel1)
{
arrPrjFeatureObjLst_Sel.Add(obj);
}
if (arrPrjFeatureObjLst_Sel.Count > 0)
{
return arrPrjFeatureObjLst_Sel[0].FeatureName;
}
string strErrMsgForGetObjById = string.Format("在PrjFeature对象缓存列表中,找不到记录的相关名称[FeatureId = {0}](函数:{1})", strFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
 /// <param name = "arrFeatureId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstByFeatureIdLst(List<string> arrFeatureId)
{
 List<clsPrjFeatureEN> arrObjLst; 
string strAction = "GetObjLstByFeatureIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFeatureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
 /// <param name = "arrFeatureId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsPrjFeatureEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel =
from objPrjFeatureEN in arrPrjFeatureObjLstCache
where arrFeatureId.Contains(objPrjFeatureEN.FeatureId)
select objPrjFeatureEN;
return arrPrjFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
public static List<clsPrjFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
public static List<clsPrjFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
public static List<clsPrjFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureEN>>(strJson);
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
public static int DelRecord(string strFeatureId)
{
string strAction = "DelRecord";
try
{
 clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureWApi.GetObjByFeatureId(strFeatureId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFeatureId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjFeatureWApi.ReFreshCache();
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
public static int DelPrjFeatures(List<string> arrFeatureId)
{
string strAction = "DelPrjFeatures";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFeatureId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjFeatureWApi.ReFreshCache();
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
public static int DelPrjFeaturesByCond(string strWhereCond)
{
string strAction = "DelPrjFeaturesByCond";
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
public static bool AddNewRecord(clsPrjFeatureEN objPrjFeatureEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureEN>(objPrjFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsPrjFeatureEN objPrjFeatureEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureEN>(objPrjFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureWApi.ReFreshCache();
var strFeatureId = (string)jobjReturn0["returnStr"];
return strFeatureId;
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
public static bool UpdateRecord(clsPrjFeatureEN objPrjFeatureEN)
{
if (string.IsNullOrEmpty(objPrjFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureEN.FeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureEN>(objPrjFeatureEN);
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjFeatureEN objPrjFeatureEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureEN.FeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureEN.FeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureEN>(objPrjFeatureEN);
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
public static bool IsExist(string strFeatureId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFeatureId"] = strFeatureId
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
 /// <param name = "objPrjFeatureENS">源对象</param>
 /// <param name = "objPrjFeatureENT">目标对象</param>
 public static void CopyTo(clsPrjFeatureEN objPrjFeatureENS, clsPrjFeatureEN objPrjFeatureENT)
{
try
{
objPrjFeatureENT.FeatureId = objPrjFeatureENS.FeatureId; //功能Id
objPrjFeatureENT.FeatureName = objPrjFeatureENS.FeatureName; //功能名称
objPrjFeatureENT.FeatureENName = objPrjFeatureENS.FeatureENName; //功能英文名
objPrjFeatureENT.KeyWords = objPrjFeatureENS.KeyWords; //关键字
objPrjFeatureENT.DefaButtonName = objPrjFeatureENS.DefaButtonName; //默认按钮名
objPrjFeatureENT.DefaButtonName4Mvc = objPrjFeatureENS.DefaButtonName4Mvc; //默认按钮名4Mvc
objPrjFeatureENT.RegionTypeId = objPrjFeatureENS.RegionTypeId; //区域类型Id
objPrjFeatureENT.GroupName = objPrjFeatureENS.GroupName; //组名
objPrjFeatureENT.FeatureDescription = objPrjFeatureENS.FeatureDescription; //功能说明
objPrjFeatureENT.InOutTypeId = objPrjFeatureENS.InOutTypeId; //INOUT类型ID
objPrjFeatureENT.IsNeedField = objPrjFeatureENS.IsNeedField; //是否需要字段
objPrjFeatureENT.IsNeedTabFeature = objPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
objPrjFeatureENT.ParentFeatureId = objPrjFeatureENS.ParentFeatureId; //父功能Id
objPrjFeatureENT.ParentFeatureName = objPrjFeatureENS.ParentFeatureName; //父功能名
objPrjFeatureENT.FunctionGroupId = objPrjFeatureENS.FunctionGroupId; //函数组Id
objPrjFeatureENT.FeatureTypeId = objPrjFeatureENS.FeatureTypeId; //功能类型Id
objPrjFeatureENT.CreateUserId = objPrjFeatureENS.CreateUserId; //建立用户Id
objPrjFeatureENT.InUse = objPrjFeatureENS.InUse; //是否在用
objPrjFeatureENT.OrderNum = objPrjFeatureENS.OrderNum; //序号
objPrjFeatureENT.UpdDate = objPrjFeatureENS.UpdDate; //修改日期
objPrjFeatureENT.UpdUser = objPrjFeatureENS.UpdUser; //修改者
objPrjFeatureENT.Memo = objPrjFeatureENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsPrjFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjFeatureEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPrjFeatureWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFeatureWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsPrjFeatureEN._CurrTabName;
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjFeatureObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjFeature.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.FeatureENName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.DefaButtonName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.DefaButtonName4Mvc, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.IsNeedField, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjFeature.IsNeedTabFeature, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjFeature.ParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeature.Memo, Type.GetType("System.String"));
foreach (clsPrjFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjFeature.FeatureId] = objInFor[conPrjFeature.FeatureId];
objDR[conPrjFeature.FeatureName] = objInFor[conPrjFeature.FeatureName];
objDR[conPrjFeature.FeatureENName] = objInFor[conPrjFeature.FeatureENName];
objDR[conPrjFeature.KeyWords] = objInFor[conPrjFeature.KeyWords];
objDR[conPrjFeature.DefaButtonName] = objInFor[conPrjFeature.DefaButtonName];
objDR[conPrjFeature.DefaButtonName4Mvc] = objInFor[conPrjFeature.DefaButtonName4Mvc];
objDR[conPrjFeature.RegionTypeId] = objInFor[conPrjFeature.RegionTypeId];
objDR[conPrjFeature.GroupName] = objInFor[conPrjFeature.GroupName];
objDR[conPrjFeature.FeatureDescription] = objInFor[conPrjFeature.FeatureDescription];
objDR[conPrjFeature.InOutTypeId] = objInFor[conPrjFeature.InOutTypeId];
objDR[conPrjFeature.IsNeedField] = objInFor[conPrjFeature.IsNeedField];
objDR[conPrjFeature.IsNeedTabFeature] = objInFor[conPrjFeature.IsNeedTabFeature];
objDR[conPrjFeature.ParentFeatureId] = objInFor[conPrjFeature.ParentFeatureId];
objDR[conPrjFeature.ParentFeatureName] = objInFor[conPrjFeature.ParentFeatureName];
objDR[conPrjFeature.FunctionGroupId] = objInFor[conPrjFeature.FunctionGroupId];
objDR[conPrjFeature.FeatureTypeId] = objInFor[conPrjFeature.FeatureTypeId];
objDR[conPrjFeature.CreateUserId] = objInFor[conPrjFeature.CreateUserId];
objDR[conPrjFeature.InUse] = objInFor[conPrjFeature.InUse];
objDR[conPrjFeature.OrderNum] = objInFor[conPrjFeature.OrderNum];
objDR[conPrjFeature.UpdDate] = objInFor[conPrjFeature.UpdDate];
objDR[conPrjFeature.UpdUser] = objInFor[conPrjFeature.UpdUser];
objDR[conPrjFeature.Memo] = objInFor[conPrjFeature.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能(PrjFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjFeature : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsPrjFeatureWApi.ReFreshThisCache();
}
}

}