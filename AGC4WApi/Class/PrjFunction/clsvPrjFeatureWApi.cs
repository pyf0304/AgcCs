
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureWApi
 表名:vPrjFeature(00050324)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvPrjFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convPrjFeature.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convPrjFeature.FeatureId);
objvPrjFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convPrjFeature.FeatureName);
objvPrjFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetKeyWords(this clsvPrjFeatureEN objvPrjFeatureEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convPrjFeature.KeyWords);
objvPrjFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.KeyWords) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.KeyWords, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.KeyWords] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaButtonName">默认按钮名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetDefaButtonName(this clsvPrjFeatureEN objvPrjFeatureEN, string strDefaButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaButtonName, 30, convPrjFeature.DefaButtonName);
objvPrjFeatureEN.DefaButtonName = strDefaButtonName; //默认按钮名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.DefaButtonName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.DefaButtonName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.DefaButtonName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetRegionTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convPrjFeature.RegionTypeId);
objvPrjFeatureEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.RegionTypeId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.RegionTypeId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.RegionTypeId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetRegionTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convPrjFeature.RegionTypeName);
objvPrjFeatureEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.RegionTypeName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.RegionTypeName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.RegionTypeName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetGroupName(this clsvPrjFeatureEN objvPrjFeatureEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 30, convPrjFeature.GroupName);
objvPrjFeatureEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.GroupName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.GroupName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.GroupName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureDescription(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convPrjFeature.FeatureDescription);
objvPrjFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureDescription) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureDescription, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureDescription] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetInOutTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convPrjFeature.InOutTypeId);
objvPrjFeatureEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.InOutTypeId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.InOutTypeId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.InOutTypeId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeName">INOUT类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetInOutTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convPrjFeature.InOutTypeName);
objvPrjFeatureEN.InOutTypeName = strInOutTypeName; //INOUT类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.InOutTypeName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.InOutTypeName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.InOutTypeName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedField">是否需要字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetIsNeedField(this clsvPrjFeatureEN objvPrjFeatureEN, bool bolIsNeedField, string strComparisonOp="")
	{
objvPrjFeatureEN.IsNeedField = bolIsNeedField; //是否需要字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.IsNeedField) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.IsNeedField, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.IsNeedField] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFunctionGroupId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convPrjFeature.FunctionGroupId);
objvPrjFeatureEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FunctionGroupId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FunctionGroupId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FunctionGroupId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupName">函数组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFunctionGroupName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convPrjFeature.FunctionGroupName);
objvPrjFeatureEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FunctionGroupName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FunctionGroupName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FunctionGroupName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convPrjFeature.FeatureTypeId);
objvPrjFeatureEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureTypeId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureTypeId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureTypeId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convPrjFeature.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convPrjFeature.FeatureTypeName);
objvPrjFeatureEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureTypeName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureTypeName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureTypeName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetCreateUserId(this clsvPrjFeatureEN objvPrjFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convPrjFeature.CreateUserId);
objvPrjFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.CreateUserId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.CreateUserId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.CreateUserId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetInUse(this clsvPrjFeatureEN objvPrjFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objvPrjFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.InUse) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.InUse, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.InUse] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetOrderNum(this clsvPrjFeatureEN objvPrjFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convPrjFeature.OrderNum);
objvPrjFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.OrderNum) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.OrderNum, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.OrderNum] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetUpdDate(this clsvPrjFeatureEN objvPrjFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFeature.UpdDate);
objvPrjFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.UpdDate) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.UpdDate, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.UpdDate] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetUpdUser(this clsvPrjFeatureEN objvPrjFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFeature.UpdUser);
objvPrjFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.UpdUser) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.UpdUser, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.UpdUser] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetMemo(this clsvPrjFeatureEN objvPrjFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFeature.Memo);
objvPrjFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.Memo) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.Memo, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.Memo] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFuncCount(this clsvPrjFeatureEN objvPrjFeatureEN, int intFuncCount, string strComparisonOp="")
	{
objvPrjFeatureEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FuncCount) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FuncCount, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FuncCount] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName2">功能名-FuncCount</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureName2(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convPrjFeature.FeatureName2);
objvPrjFeatureEN.FeatureName2 = strFeatureName2; //功能名-FuncCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.FeatureName2) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.FeatureName2, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.FeatureName2] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetParentFeatureId(this clsvPrjFeatureEN objvPrjFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convPrjFeature.ParentFeatureId);
objvPrjFeatureEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.ParentFeatureId) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.ParentFeatureId, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.ParentFeatureId] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetParentFeatureName(this clsvPrjFeatureEN objvPrjFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convPrjFeature.ParentFeatureName);
objvPrjFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.ParentFeatureName) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.ParentFeatureName, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.ParentFeatureName] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTabFeature">是否需要表功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetIsNeedTabFeature(this clsvPrjFeatureEN objvPrjFeatureEN, bool bolIsNeedTabFeature, string strComparisonOp="")
	{
objvPrjFeatureEN.IsNeedTabFeature = bolIsNeedTabFeature; //是否需要表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureEN.dicFldComparisonOp.ContainsKey(convPrjFeature.IsNeedTabFeature) == false)
{
objvPrjFeatureEN.dicFldComparisonOp.Add(convPrjFeature.IsNeedTabFeature, strComparisonOp);
}
else
{
objvPrjFeatureEN.dicFldComparisonOp[convPrjFeature.IsNeedTabFeature] = strComparisonOp;
}
}
return objvPrjFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFeatureEN objvPrjFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureId, objvPrjFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureName, objvPrjFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.KeyWords, objvPrjFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.DefaButtonName) == true)
{
string strComparisonOpDefaButtonName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.DefaButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.DefaButtonName, objvPrjFeatureCond.DefaButtonName, strComparisonOpDefaButtonName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.RegionTypeId, objvPrjFeatureCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.RegionTypeName, objvPrjFeatureCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.GroupName) == true)
{
string strComparisonOpGroupName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.GroupName, objvPrjFeatureCond.GroupName, strComparisonOpGroupName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureDescription, objvPrjFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.InOutTypeId, objvPrjFeatureCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.InOutTypeName, objvPrjFeatureCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.IsNeedField) == true)
{
if (objvPrjFeatureCond.IsNeedField == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFeature.IsNeedField);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFeature.IsNeedField);
}
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FunctionGroupId, objvPrjFeatureCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FunctionGroupName, objvPrjFeatureCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureTypeId, objvPrjFeatureCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureTypeName, objvPrjFeatureCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.CreateUserId, objvPrjFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.InUse) == true)
{
if (objvPrjFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFeature.InUse);
}
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjFeature.OrderNum, objvPrjFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.UpdDate, objvPrjFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.UpdUser, objvPrjFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.Memo) == true)
{
string strComparisonOpMemo = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.Memo, objvPrjFeatureCond.Memo, strComparisonOpMemo);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FuncCount) == true)
{
string strComparisonOpFuncCount = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjFeature.FuncCount, objvPrjFeatureCond.FuncCount, strComparisonOpFuncCount);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.FeatureName2) == true)
{
string strComparisonOpFeatureName2 = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.FeatureName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.FeatureName2, objvPrjFeatureCond.FeatureName2, strComparisonOpFeatureName2);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.ParentFeatureId, objvPrjFeatureCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvPrjFeatureCond.dicFldComparisonOp[convPrjFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeature.ParentFeatureName, objvPrjFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvPrjFeatureCond.IsUpdated(convPrjFeature.IsNeedTabFeature) == true)
{
if (objvPrjFeatureCond.IsNeedTabFeature == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFeature.IsNeedTabFeature);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFeature.IsNeedTabFeature);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能(vPrjFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFeatureWApi
{
private static readonly string mstrApiControllerName = "vPrjFeatureApi";

 public clsvPrjFeatureWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
if (strFeatureId == "") return null;
string strAction = "GetObjByFeatureId";
clsvPrjFeatureEN objvPrjFeatureEN;
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
objvPrjFeatureEN = JsonConvert.DeserializeObject<clsvPrjFeatureEN>(strJson);
return objvPrjFeatureEN;
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
public static clsvPrjFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjFeatureEN objvPrjFeatureEN;
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
objvPrjFeatureEN = JsonConvert.DeserializeObject<clsvPrjFeatureEN>(strJson);
return objvPrjFeatureEN;
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
public static clsvPrjFeatureEN GetObjByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel =
from objvPrjFeatureEN in arrvPrjFeatureObjLstCache
where objvPrjFeatureEN.FeatureId == strFeatureId 
select objvPrjFeatureEN;
if (arrvPrjFeatureObjLst_Sel.Count() == 0)
{
   clsvPrjFeatureEN obj = clsvPrjFeatureWApi.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
public static List<clsvPrjFeatureEN> GetObjLstByFeatureIdLst(List<string> arrFeatureId)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
public static IEnumerable<clsvPrjFeatureEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel =
from objvPrjFeatureEN in arrvPrjFeatureObjLstCache
where arrFeatureId.Contains(objvPrjFeatureEN.FeatureId)
select objvPrjFeatureEN;
return arrvPrjFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
public static List<clsvPrjFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
public static List<clsvPrjFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
public static List<clsvPrjFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFeatureEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvPrjFeatureENS">源对象</param>
 /// <param name = "objvPrjFeatureENT">目标对象</param>
 public static void CopyTo(clsvPrjFeatureEN objvPrjFeatureENS, clsvPrjFeatureEN objvPrjFeatureENT)
{
try
{
objvPrjFeatureENT.FeatureId = objvPrjFeatureENS.FeatureId; //功能Id
objvPrjFeatureENT.FeatureName = objvPrjFeatureENS.FeatureName; //功能名称
objvPrjFeatureENT.KeyWords = objvPrjFeatureENS.KeyWords; //关键字
objvPrjFeatureENT.DefaButtonName = objvPrjFeatureENS.DefaButtonName; //默认按钮名
objvPrjFeatureENT.RegionTypeId = objvPrjFeatureENS.RegionTypeId; //区域类型Id
objvPrjFeatureENT.RegionTypeName = objvPrjFeatureENS.RegionTypeName; //区域类型名称
objvPrjFeatureENT.GroupName = objvPrjFeatureENS.GroupName; //组名
objvPrjFeatureENT.FeatureDescription = objvPrjFeatureENS.FeatureDescription; //功能说明
objvPrjFeatureENT.InOutTypeId = objvPrjFeatureENS.InOutTypeId; //INOUT类型ID
objvPrjFeatureENT.InOutTypeName = objvPrjFeatureENS.InOutTypeName; //INOUT类型名称
objvPrjFeatureENT.IsNeedField = objvPrjFeatureENS.IsNeedField; //是否需要字段
objvPrjFeatureENT.FunctionGroupId = objvPrjFeatureENS.FunctionGroupId; //函数组Id
objvPrjFeatureENT.FunctionGroupName = objvPrjFeatureENS.FunctionGroupName; //函数组名称
objvPrjFeatureENT.FeatureTypeId = objvPrjFeatureENS.FeatureTypeId; //功能类型Id
objvPrjFeatureENT.FeatureTypeName = objvPrjFeatureENS.FeatureTypeName; //功能类型名称
objvPrjFeatureENT.CreateUserId = objvPrjFeatureENS.CreateUserId; //建立用户Id
objvPrjFeatureENT.InUse = objvPrjFeatureENS.InUse; //是否在用
objvPrjFeatureENT.OrderNum = objvPrjFeatureENS.OrderNum; //序号
objvPrjFeatureENT.UpdDate = objvPrjFeatureENS.UpdDate; //修改日期
objvPrjFeatureENT.UpdUser = objvPrjFeatureENS.UpdUser; //修改者
objvPrjFeatureENT.Memo = objvPrjFeatureENS.Memo; //说明
objvPrjFeatureENT.FuncCount = objvPrjFeatureENS.FuncCount; //函数数目
objvPrjFeatureENT.FeatureName2 = objvPrjFeatureENS.FeatureName2; //功能名-FuncCount
objvPrjFeatureENT.ParentFeatureId = objvPrjFeatureENS.ParentFeatureId; //父功能Id
objvPrjFeatureENT.ParentFeatureName = objvPrjFeatureENS.ParentFeatureName; //父功能名
objvPrjFeatureENT.IsNeedTabFeature = objvPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
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
public static DataTable ToDataTable(List<clsvPrjFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjFeatureEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
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
public static List<clsvPrjFeatureEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvPrjFeatureEN._CurrTabName;
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjFeatureObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjFeature.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.DefaButtonName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.IsNeedField, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjFeature.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FunctionGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.FuncCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjFeature.FeatureName2, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.ParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFeature.IsNeedTabFeature, Type.GetType("System.Boolean"));
foreach (clsvPrjFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjFeature.FeatureId] = objInFor[convPrjFeature.FeatureId];
objDR[convPrjFeature.FeatureName] = objInFor[convPrjFeature.FeatureName];
objDR[convPrjFeature.KeyWords] = objInFor[convPrjFeature.KeyWords];
objDR[convPrjFeature.DefaButtonName] = objInFor[convPrjFeature.DefaButtonName];
objDR[convPrjFeature.RegionTypeId] = objInFor[convPrjFeature.RegionTypeId];
objDR[convPrjFeature.RegionTypeName] = objInFor[convPrjFeature.RegionTypeName];
objDR[convPrjFeature.GroupName] = objInFor[convPrjFeature.GroupName];
objDR[convPrjFeature.FeatureDescription] = objInFor[convPrjFeature.FeatureDescription];
objDR[convPrjFeature.InOutTypeId] = objInFor[convPrjFeature.InOutTypeId];
objDR[convPrjFeature.InOutTypeName] = objInFor[convPrjFeature.InOutTypeName];
objDR[convPrjFeature.IsNeedField] = objInFor[convPrjFeature.IsNeedField];
objDR[convPrjFeature.FunctionGroupId] = objInFor[convPrjFeature.FunctionGroupId];
objDR[convPrjFeature.FunctionGroupName] = objInFor[convPrjFeature.FunctionGroupName];
objDR[convPrjFeature.FeatureTypeId] = objInFor[convPrjFeature.FeatureTypeId];
objDR[convPrjFeature.FeatureTypeName] = objInFor[convPrjFeature.FeatureTypeName];
objDR[convPrjFeature.CreateUserId] = objInFor[convPrjFeature.CreateUserId];
objDR[convPrjFeature.InUse] = objInFor[convPrjFeature.InUse];
objDR[convPrjFeature.OrderNum] = objInFor[convPrjFeature.OrderNum];
objDR[convPrjFeature.UpdDate] = objInFor[convPrjFeature.UpdDate];
objDR[convPrjFeature.UpdUser] = objInFor[convPrjFeature.UpdUser];
objDR[convPrjFeature.Memo] = objInFor[convPrjFeature.Memo];
objDR[convPrjFeature.FuncCount] = objInFor[convPrjFeature.FuncCount];
objDR[convPrjFeature.FeatureName2] = objInFor[convPrjFeature.FeatureName2];
objDR[convPrjFeature.ParentFeatureId] = objInFor[convPrjFeature.ParentFeatureId];
objDR[convPrjFeature.ParentFeatureName] = objInFor[convPrjFeature.ParentFeatureName];
objDR[convPrjFeature.IsNeedTabFeature] = objInFor[convPrjFeature.IsNeedTabFeature];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}