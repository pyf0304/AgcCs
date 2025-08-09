
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureBL
 表名:vPrjFeature(00050324)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvPrjFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFeatureEN GetObj(this K_FeatureId_vPrjFeature myKey)
{
clsvPrjFeatureEN objvPrjFeatureEN = clsvPrjFeatureBL.vPrjFeatureDA.GetObjByFeatureId(myKey.Value);
return objvPrjFeatureEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convPrjFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convPrjFeature.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convPrjFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convPrjFeature.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetKeyWords(this clsvPrjFeatureEN objvPrjFeatureEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convPrjFeature.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetDefaButtonName(this clsvPrjFeatureEN objvPrjFeatureEN, string strDefaButtonName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaButtonName, 30, convPrjFeature.DefaButtonName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetRegionTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convPrjFeature.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convPrjFeature.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetRegionTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convPrjFeature.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetGroupName(this clsvPrjFeatureEN objvPrjFeatureEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convPrjFeature.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureDescription(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convPrjFeature.FeatureDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetInOutTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convPrjFeature.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convPrjFeature.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convPrjFeature.InOutTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetInOutTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strInOutTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convPrjFeature.InOutTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFunctionGroupId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convPrjFeature.FunctionGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convPrjFeature.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convPrjFeature.FunctionGroupId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFunctionGroupName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFunctionGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convPrjFeature.FunctionGroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureTypeId(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convPrjFeature.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convPrjFeature.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convPrjFeature.FeatureTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureTypeName(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convPrjFeature.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convPrjFeature.FeatureTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetCreateUserId(this clsvPrjFeatureEN objvPrjFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convPrjFeature.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convPrjFeature.CreateUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetUpdDate(this clsvPrjFeatureEN objvPrjFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFeature.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetUpdUser(this clsvPrjFeatureEN objvPrjFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFeature.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetMemo(this clsvPrjFeatureEN objvPrjFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFeature.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFuncCount(this clsvPrjFeatureEN objvPrjFeatureEN, int? intFuncCount, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetFeatureName2(this clsvPrjFeatureEN objvPrjFeatureEN, string strFeatureName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convPrjFeature.FeatureName2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetParentFeatureId(this clsvPrjFeatureEN objvPrjFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convPrjFeature.ParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convPrjFeature.ParentFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureEN SetParentFeatureName(this clsvPrjFeatureEN objvPrjFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convPrjFeature.ParentFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要设置字段值的实体对象</param>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjFeatureENS">源对象</param>
 /// <param name = "objvPrjFeatureENT">目标对象</param>
 public static void CopyTo(this clsvPrjFeatureEN objvPrjFeatureENS, clsvPrjFeatureEN objvPrjFeatureENT)
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
 /// <param name = "objvPrjFeatureENS">源对象</param>
 /// <returns>目标对象=>clsvPrjFeatureEN:objvPrjFeatureENT</returns>
 public static clsvPrjFeatureEN CopyTo(this clsvPrjFeatureEN objvPrjFeatureENS)
{
try
{
 clsvPrjFeatureEN objvPrjFeatureENT = new clsvPrjFeatureEN()
{
FeatureId = objvPrjFeatureENS.FeatureId, //功能Id
FeatureName = objvPrjFeatureENS.FeatureName, //功能名称
KeyWords = objvPrjFeatureENS.KeyWords, //关键字
DefaButtonName = objvPrjFeatureENS.DefaButtonName, //默认按钮名
RegionTypeId = objvPrjFeatureENS.RegionTypeId, //区域类型Id
RegionTypeName = objvPrjFeatureENS.RegionTypeName, //区域类型名称
GroupName = objvPrjFeatureENS.GroupName, //组名
FeatureDescription = objvPrjFeatureENS.FeatureDescription, //功能说明
InOutTypeId = objvPrjFeatureENS.InOutTypeId, //INOUT类型ID
InOutTypeName = objvPrjFeatureENS.InOutTypeName, //INOUT类型名称
IsNeedField = objvPrjFeatureENS.IsNeedField, //是否需要字段
FunctionGroupId = objvPrjFeatureENS.FunctionGroupId, //函数组Id
FunctionGroupName = objvPrjFeatureENS.FunctionGroupName, //函数组名称
FeatureTypeId = objvPrjFeatureENS.FeatureTypeId, //功能类型Id
FeatureTypeName = objvPrjFeatureENS.FeatureTypeName, //功能类型名称
CreateUserId = objvPrjFeatureENS.CreateUserId, //建立用户Id
InUse = objvPrjFeatureENS.InUse, //是否在用
OrderNum = objvPrjFeatureENS.OrderNum, //序号
UpdDate = objvPrjFeatureENS.UpdDate, //修改日期
UpdUser = objvPrjFeatureENS.UpdUser, //修改者
Memo = objvPrjFeatureENS.Memo, //说明
FuncCount = objvPrjFeatureENS.FuncCount, //函数数目
FeatureName2 = objvPrjFeatureENS.FeatureName2, //功能名-FuncCount
ParentFeatureId = objvPrjFeatureENS.ParentFeatureId, //父功能Id
ParentFeatureName = objvPrjFeatureENS.ParentFeatureName, //父功能名
IsNeedTabFeature = objvPrjFeatureENS.IsNeedTabFeature, //是否需要表功能
};
 return objvPrjFeatureENT;
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
public static void CheckProperty4Condition(this clsvPrjFeatureEN objvPrjFeatureEN)
{
 clsvPrjFeatureBL.vPrjFeatureDA.CheckProperty4Condition(objvPrjFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjFeature
{
public virtual bool UpdRelaTabDate(string strFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能(vPrjFeature)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFeatureBL
{
public static RelatedActions_vPrjFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjFeatureDA vPrjFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjFeatureDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjFeatureBL()
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
if (string.IsNullOrEmpty(clsvPrjFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFeatureEN._ConnectString);
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
public static DataTable GetDataTable_vPrjFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjFeatureDA.GetDataTable_vPrjFeature(strWhereCond);
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
objDT = vPrjFeatureDA.GetDataTable(strWhereCond);
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
objDT = vPrjFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLstByFeatureIdLst(List<string> arrFeatureIdLst)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFeatureIdLst, true);
 string strWhereCond = string.Format("FeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjFeatureEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureIdLst)
{
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel =
arrvPrjFeatureObjLstCache
.Where(x => arrFeatureIdLst.Contains(x.FeatureId));
return arrvPrjFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLst(string strWhereCond)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
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
public static List<clsvPrjFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjFeatureEN> GetSubObjLstCache(clsvPrjFeatureEN objvPrjFeatureCond)
{
List<clsvPrjFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFeature._AttributeName)
{
if (objvPrjFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureCond[strFldName].ToString());
}
else
{
if (objvPrjFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureCond[strFldName]));
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
public static List<clsvPrjFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
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
public static List<clsvPrjFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
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
List<clsvPrjFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
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
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
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
public static List<clsvPrjFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
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
public static List<clsvPrjFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjFeature(ref clsvPrjFeatureEN objvPrjFeatureEN)
{
bool bolResult = vPrjFeatureDA.GetvPrjFeature(ref objvPrjFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
if (strFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjFeatureEN objvPrjFeatureEN = vPrjFeatureDA.GetObjByFeatureId(strFeatureId);
return objvPrjFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjFeatureEN objvPrjFeatureEN = vPrjFeatureDA.GetFirstObj(strWhereCond);
 return objvPrjFeatureEN;
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
public static clsvPrjFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjFeatureEN objvPrjFeatureEN = vPrjFeatureDA.GetObjByDataRow(objRow);
 return objvPrjFeatureEN;
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
public static clsvPrjFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjFeatureEN objvPrjFeatureEN = vPrjFeatureDA.GetObjByDataRow(objRow);
 return objvPrjFeatureEN;
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
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <param name = "lstvPrjFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFeatureEN GetObjByFeatureIdFromList(string strFeatureId, List<clsvPrjFeatureEN> lstvPrjFeatureObjLst)
{
foreach (clsvPrjFeatureEN objvPrjFeatureEN in lstvPrjFeatureObjLst)
{
if (objvPrjFeatureEN.FeatureId == strFeatureId)
{
return objvPrjFeatureEN;
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
 string strFeatureId;
 try
 {
 strFeatureId = new clsvPrjFeatureDA().GetFirstID(strWhereCond);
 return strFeatureId;
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
 arrList = vPrjFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjFeatureDA.IsExist(strFeatureId);
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
 bolIsExist = clsvPrjFeatureDA.IsExistTable();
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
 bolIsExist = vPrjFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjFeatureEN objvPrjFeatureEN)
{
try
{
objvPrjFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureId = objvPrjFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convPrjFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureName = objvPrjFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convPrjFeature.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.KeyWords = objvPrjFeatureEN.KeyWords == "[null]" ? null :  objvPrjFeatureEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convPrjFeature.DefaButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.DefaButtonName = objvPrjFeatureEN.DefaButtonName == "[null]" ? null :  objvPrjFeatureEN.DefaButtonName; //默认按钮名
}
if (arrFldSet.Contains(convPrjFeature.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.RegionTypeId = objvPrjFeatureEN.RegionTypeId == "[null]" ? null :  objvPrjFeatureEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convPrjFeature.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.RegionTypeName = objvPrjFeatureEN.RegionTypeName == "[null]" ? null :  objvPrjFeatureEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convPrjFeature.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.GroupName = objvPrjFeatureEN.GroupName == "[null]" ? null :  objvPrjFeatureEN.GroupName; //组名
}
if (arrFldSet.Contains(convPrjFeature.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureDescription = objvPrjFeatureEN.FeatureDescription == "[null]" ? null :  objvPrjFeatureEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convPrjFeature.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.InOutTypeId = objvPrjFeatureEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(convPrjFeature.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.InOutTypeName = objvPrjFeatureEN.InOutTypeName == "[null]" ? null :  objvPrjFeatureEN.InOutTypeName; //INOUT类型名称
}
if (arrFldSet.Contains(convPrjFeature.IsNeedField, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.IsNeedField = objvPrjFeatureEN.IsNeedField; //是否需要字段
}
if (arrFldSet.Contains(convPrjFeature.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FunctionGroupId = objvPrjFeatureEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(convPrjFeature.FunctionGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FunctionGroupName = objvPrjFeatureEN.FunctionGroupName == "[null]" ? null :  objvPrjFeatureEN.FunctionGroupName; //函数组名称
}
if (arrFldSet.Contains(convPrjFeature.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureTypeId = objvPrjFeatureEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convPrjFeature.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureTypeName = objvPrjFeatureEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convPrjFeature.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.CreateUserId = objvPrjFeatureEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convPrjFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.InUse = objvPrjFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(convPrjFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.OrderNum = objvPrjFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(convPrjFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.UpdDate = objvPrjFeatureEN.UpdDate == "[null]" ? null :  objvPrjFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.UpdUser = objvPrjFeatureEN.UpdUser == "[null]" ? null :  objvPrjFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convPrjFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.Memo = objvPrjFeatureEN.Memo == "[null]" ? null :  objvPrjFeatureEN.Memo; //说明
}
if (arrFldSet.Contains(convPrjFeature.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FuncCount = objvPrjFeatureEN.FuncCount; //函数数目
}
if (arrFldSet.Contains(convPrjFeature.FeatureName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.FeatureName2 = objvPrjFeatureEN.FeatureName2 == "[null]" ? null :  objvPrjFeatureEN.FeatureName2; //功能名-FuncCount
}
if (arrFldSet.Contains(convPrjFeature.ParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.ParentFeatureId = objvPrjFeatureEN.ParentFeatureId == "[null]" ? null :  objvPrjFeatureEN.ParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(convPrjFeature.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.ParentFeatureName = objvPrjFeatureEN.ParentFeatureName == "[null]" ? null :  objvPrjFeatureEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convPrjFeature.IsNeedTabFeature, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureEN.IsNeedTabFeature = objvPrjFeatureEN.IsNeedTabFeature; //是否需要表功能
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
 /// <param name = "objvPrjFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjFeatureEN objvPrjFeatureEN)
{
try
{
if (objvPrjFeatureEN.KeyWords == "[null]") objvPrjFeatureEN.KeyWords = null; //关键字
if (objvPrjFeatureEN.DefaButtonName == "[null]") objvPrjFeatureEN.DefaButtonName = null; //默认按钮名
if (objvPrjFeatureEN.RegionTypeId == "[null]") objvPrjFeatureEN.RegionTypeId = null; //区域类型Id
if (objvPrjFeatureEN.RegionTypeName == "[null]") objvPrjFeatureEN.RegionTypeName = null; //区域类型名称
if (objvPrjFeatureEN.GroupName == "[null]") objvPrjFeatureEN.GroupName = null; //组名
if (objvPrjFeatureEN.FeatureDescription == "[null]") objvPrjFeatureEN.FeatureDescription = null; //功能说明
if (objvPrjFeatureEN.InOutTypeName == "[null]") objvPrjFeatureEN.InOutTypeName = null; //INOUT类型名称
if (objvPrjFeatureEN.FunctionGroupName == "[null]") objvPrjFeatureEN.FunctionGroupName = null; //函数组名称
if (objvPrjFeatureEN.UpdDate == "[null]") objvPrjFeatureEN.UpdDate = null; //修改日期
if (objvPrjFeatureEN.UpdUser == "[null]") objvPrjFeatureEN.UpdUser = null; //修改者
if (objvPrjFeatureEN.Memo == "[null]") objvPrjFeatureEN.Memo = null; //说明
if (objvPrjFeatureEN.FeatureName2 == "[null]") objvPrjFeatureEN.FeatureName2 = null; //功能名-FuncCount
if (objvPrjFeatureEN.ParentFeatureId == "[null]") objvPrjFeatureEN.ParentFeatureId = null; //父功能Id
if (objvPrjFeatureEN.ParentFeatureName == "[null]") objvPrjFeatureEN.ParentFeatureName = null; //父功能名
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
public static void CheckProperty4Condition(clsvPrjFeatureEN objvPrjFeatureEN)
{
 vPrjFeatureDA.CheckProperty4Condition(objvPrjFeatureEN);
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
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FeatureId");
//if (arrvPrjFeatureObjLstCache == null)
//{
//arrvPrjFeatureObjLstCache = vPrjFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFeatureEN GetObjByFeatureIdCache(string strFeatureId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel =
arrvPrjFeatureObjLstCache
.Where(x=> x.FeatureId == strFeatureId 
);
if (arrvPrjFeatureObjLst_Sel.Count() == 0)
{
   clsvPrjFeatureEN obj = clsvPrjFeatureBL.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFeatureEN> GetAllvPrjFeatureObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = GetObjLstCache(); 
return arrvPrjFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFeatureEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
List<clsvPrjFeatureEN> arrvPrjFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjFeatureObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjFeatureEN._RefreshTimeLst[clsvPrjFeatureEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFeatureId)
{
if (strInFldName != convPrjFeature.FeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjFeature._AttributeName));
throw new Exception(strMsg);
}
var objvPrjFeature = clsvPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
if (objvPrjFeature == null) return "";
return objvPrjFeature[strOutFldName].ToString();
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
int intRecCount = clsvPrjFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjFeatureDA.GetRecCount();
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
int intRecCount = clsvPrjFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjFeatureEN objvPrjFeatureCond)
{
List<clsvPrjFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFeature._AttributeName)
{
if (objvPrjFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureCond[strFldName].ToString());
}
else
{
if (objvPrjFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureCond[strFldName]));
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
 List<string> arrList = clsvPrjFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}