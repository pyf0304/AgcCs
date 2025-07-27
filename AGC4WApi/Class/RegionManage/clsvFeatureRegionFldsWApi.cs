
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFldsWApi
 表名:vFeatureRegionFlds(00050197)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:WA_访问层(CS)(WA_Access)
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
public static class  clsvFeatureRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFeatureId">界面功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convFeatureRegionFlds.ViewFeatureId);
objvFeatureRegionFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ViewFeatureId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ViewFeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ViewFeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convFeatureRegionFlds.RegionId);
objvFeatureRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RegionId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RegionId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RegionId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionName, 50, convFeatureRegionFlds.RegionName);
objvFeatureRegionFldsEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RegionName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RegionName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RegionName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convFeatureRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFeatureRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFeatureRegionFlds.RegionTypeId);
objvFeatureRegionFldsEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RegionTypeId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RegionTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convFeatureRegionFlds.RegionTypeName);
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFeatureRegionFlds.RegionTypeName);
objvFeatureRegionFldsEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RegionTypeName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RegionTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeSimName">区域类型简名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeSimName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convFeatureRegionFlds.RegionTypeSimName);
objvFeatureRegionFldsEN.RegionTypeSimName = strRegionTypeSimName; //区域类型简名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RegionTypeSimName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RegionTypeSimName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeSimName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureRegionFlds.FeatureId);
objvFeatureRegionFldsEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FeatureId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureRegionFlds.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureRegionFlds.FeatureName);
objvFeatureRegionFldsEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FeatureName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FeatureName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FeatureName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetKeyWords(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureRegionFlds.KeyWords);
objvFeatureRegionFldsEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.KeyWords) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.KeyWords, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.KeyWords] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetTabFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convFeatureRegionFlds.TabFeatureId);
objvFeatureRegionFldsEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.TabFeatureId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.TabFeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.TabFeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetTabFeatureName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convFeatureRegionFlds.TabFeatureName);
objvFeatureRegionFldsEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.TabFeatureName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.TabFeatureName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.TabFeatureName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckTabFeature">检查表功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCheckTabFeature(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCheckTabFeature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, convFeatureRegionFlds.CheckTabFeature);
objvFeatureRegionFldsEN.CheckTabFeature = strCheckTabFeature; //检查表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CheckTabFeature) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CheckTabFeature, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CheckTabFeature] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureDescription(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureRegionFlds.FeatureDescription);
objvFeatureRegionFldsEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FeatureDescription) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FeatureDescription, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FeatureDescription] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetButtonName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureRegionFlds.ButtonName);
objvFeatureRegionFldsEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ButtonName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ButtonName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ButtonName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName4Mvc">按钮名称4Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetButtonName4Mvc(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, convFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, convFeatureRegionFlds.ButtonName4Mvc);
objvFeatureRegionFldsEN.ButtonName4Mvc = strButtonName4Mvc; //按钮名称4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ButtonName4Mvc) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ButtonName4Mvc, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ButtonName4Mvc] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strEventFuncName">事件函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetEventFuncName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strEventFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureRegionFlds.EventFuncName);
objvFeatureRegionFldsEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.EventFuncName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.EventFuncName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.EventFuncName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetValueGivingModeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convFeatureRegionFlds.ValueGivingModeId);
objvFeatureRegionFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ValueGivingModeId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeName">给值方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetValueGivingModeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strValueGivingModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convFeatureRegionFlds.ValueGivingModeName);
objvFeatureRegionFldsEN.ValueGivingModeName = strValueGivingModeName; //给值方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ValueGivingModeName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ValueGivingModeName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ValueGivingModeName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFuncName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureRegionFlds.FuncName);
objvFeatureRegionFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FuncName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FuncName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FuncName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetDefaultValue(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFeatureRegionFlds.DefaultValue);
objvFeatureRegionFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.DefaultValue) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.DefaultValue, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.DefaultValue] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyIdGetModeId">GC关键字获取方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetKeyIdGetModeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, convFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, convFeatureRegionFlds.KeyIdGetModeId);
objvFeatureRegionFldsEN.KeyIdGetModeId = strKeyIdGetModeId; //GC关键字获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.KeyIdGetModeId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.KeyIdGetModeId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.KeyIdGetModeId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetText(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(strText, 30, convFeatureRegionFlds.Text);
objvFeatureRegionFldsEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.Text) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.Text, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.Text] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetGroupName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convFeatureRegionFlds.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convFeatureRegionFlds.GroupName);
objvFeatureRegionFldsEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.GroupName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.GroupName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.GroupName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetReleTabId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strReleTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convFeatureRegionFlds.ReleTabId);
objvFeatureRegionFldsEN.ReleTabId = strReleTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ReleTabId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ReleTabId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ReleTabId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleFldId">相关字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetReleFldId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strReleFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convFeatureRegionFlds.ReleFldId);
objvFeatureRegionFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ReleFldId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ReleFldId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ReleFldId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFieldTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureRegionFlds.FieldTypeId);
objvFeatureRegionFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FieldTypeId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FieldTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FieldTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFieldTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureRegionFlds.FieldTypeName);
objvFeatureRegionFldsEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.FieldTypeName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.FieldTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.FieldTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplId">界面实现Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewImplId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureRegionFlds.ViewImplId);
objvFeatureRegionFldsEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ViewImplId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ViewImplId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ViewImplId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplName">界面实现名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewImplName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewImplName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureRegionFlds.ViewImplName);
objvFeatureRegionFldsEN.ViewImplName = strViewImplName; //界面实现名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ViewImplName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ViewImplName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ViewImplName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convFeatureRegionFlds.CtlTypeId);
objvFeatureRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CtlTypeId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convFeatureRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convFeatureRegionFlds.CtlTypeName);
objvFeatureRegionFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CtlTypeName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CtlTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlCnName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convFeatureRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convFeatureRegionFlds.CtlCnName);
objvFeatureRegionFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CtlCnName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CtlCnName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CtlCnName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeAbbr(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convFeatureRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convFeatureRegionFlds.CtlTypeAbbr);
objvFeatureRegionFldsEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CtlTypeAbbr) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CtlTypeAbbr, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeAbbr] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetHeight(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int intHeight, string strComparisonOp="")
	{
objvFeatureRegionFldsEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.Height) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.Height, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.Height] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetWidth(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objvFeatureRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.Width) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.Width, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.Width] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetSeqNum(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objvFeatureRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.SeqNum) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCssClass(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, convFeatureRegionFlds.CssClass);
objvFeatureRegionFldsEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.CssClass) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.CssClass, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.CssClass] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strImageUrl">图片资源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetImageUrl(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convFeatureRegionFlds.ImageUrl);
objvFeatureRegionFldsEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.ImageUrl) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.ImageUrl, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.ImageUrl] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetInUse(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvFeatureRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.InUse) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.InUse, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.InUse] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetUpdUser(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureRegionFlds.UpdUser);
objvFeatureRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.UpdUser) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetUpdDate(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureRegionFlds.UpdDate);
objvFeatureRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.UpdDate) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetMemo(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureRegionFlds.Memo);
objvFeatureRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.Memo) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.Memo, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.Memo] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldName">关系字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRelaFldName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRelaFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convFeatureRegionFlds.RelaFldName);
objvFeatureRegionFldsEN.RelaFldName = strRelaFldName; //关系字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RelaFldName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RelaFldName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RelaFldName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabName">相关表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRelaTabName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRelaTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convFeatureRegionFlds.RelaTabName);
objvFeatureRegionFldsEN.RelaTabName = strRelaTabName; //相关表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.RelaTabName) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.RelaTabName, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.RelaTabName] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetPrjId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFeatureRegionFlds.PrjId);
objvFeatureRegionFldsEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds.PrjId) == false)
{
objvFeatureRegionFldsEN.dicFldComparisonOp.Add(convFeatureRegionFlds.PrjId, strComparisonOp);
}
else
{
objvFeatureRegionFldsEN.dicFldComparisonOp[convFeatureRegionFlds.PrjId] = strComparisonOp;
}
}
return objvFeatureRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureRegionFldsEN objvFeatureRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ViewFeatureId, objvFeatureRegionFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RegionId, objvFeatureRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RegionName) == true)
{
string strComparisonOpRegionName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RegionName, objvFeatureRegionFldsCond.RegionName, strComparisonOpRegionName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RegionTypeId, objvFeatureRegionFldsCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RegionTypeName, objvFeatureRegionFldsCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RegionTypeSimName) == true)
{
string strComparisonOpRegionTypeSimName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RegionTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RegionTypeSimName, objvFeatureRegionFldsCond.RegionTypeSimName, strComparisonOpRegionTypeSimName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FeatureId, objvFeatureRegionFldsCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FeatureName, objvFeatureRegionFldsCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.KeyWords, objvFeatureRegionFldsCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.TabFeatureId, objvFeatureRegionFldsCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.TabFeatureName, objvFeatureRegionFldsCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CheckTabFeature) == true)
{
string strComparisonOpCheckTabFeature = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CheckTabFeature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CheckTabFeature, objvFeatureRegionFldsCond.CheckTabFeature, strComparisonOpCheckTabFeature);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FeatureDescription, objvFeatureRegionFldsCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ButtonName) == true)
{
string strComparisonOpButtonName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ButtonName, objvFeatureRegionFldsCond.ButtonName, strComparisonOpButtonName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ButtonName4Mvc) == true)
{
string strComparisonOpButtonName4Mvc = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ButtonName4Mvc, objvFeatureRegionFldsCond.ButtonName4Mvc, strComparisonOpButtonName4Mvc);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.EventFuncName, objvFeatureRegionFldsCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ValueGivingModeId, objvFeatureRegionFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ValueGivingModeName) == true)
{
string strComparisonOpValueGivingModeName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ValueGivingModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ValueGivingModeName, objvFeatureRegionFldsCond.ValueGivingModeName, strComparisonOpValueGivingModeName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FuncName) == true)
{
string strComparisonOpFuncName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FuncName, objvFeatureRegionFldsCond.FuncName, strComparisonOpFuncName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.DefaultValue, objvFeatureRegionFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.KeyIdGetModeId) == true)
{
string strComparisonOpKeyIdGetModeId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.KeyIdGetModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.KeyIdGetModeId, objvFeatureRegionFldsCond.KeyIdGetModeId, strComparisonOpKeyIdGetModeId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.Text) == true)
{
string strComparisonOpText = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.Text, objvFeatureRegionFldsCond.Text, strComparisonOpText);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.GroupName) == true)
{
string strComparisonOpGroupName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.GroupName, objvFeatureRegionFldsCond.GroupName, strComparisonOpGroupName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ReleTabId) == true)
{
string strComparisonOpReleTabId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ReleTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ReleTabId, objvFeatureRegionFldsCond.ReleTabId, strComparisonOpReleTabId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ReleFldId, objvFeatureRegionFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FieldTypeId, objvFeatureRegionFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.FieldTypeName, objvFeatureRegionFldsCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ViewImplId) == true)
{
string strComparisonOpViewImplId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ViewImplId, objvFeatureRegionFldsCond.ViewImplId, strComparisonOpViewImplId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ViewImplName) == true)
{
string strComparisonOpViewImplName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ViewImplName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ViewImplName, objvFeatureRegionFldsCond.ViewImplName, strComparisonOpViewImplName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CtlTypeId, objvFeatureRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CtlTypeName, objvFeatureRegionFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CtlCnName, objvFeatureRegionFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CtlTypeAbbr, objvFeatureRegionFldsCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.Height) == true)
{
string strComparisonOpHeight = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.Height];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds.Height, objvFeatureRegionFldsCond.Height, strComparisonOpHeight);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.Width) == true)
{
string strComparisonOpWidth = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds.Width, objvFeatureRegionFldsCond.Width, strComparisonOpWidth);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds.SeqNum, objvFeatureRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.CssClass) == true)
{
string strComparisonOpCssClass = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.CssClass, objvFeatureRegionFldsCond.CssClass, strComparisonOpCssClass);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.ImageUrl, objvFeatureRegionFldsCond.ImageUrl, strComparisonOpImageUrl);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.InUse) == true)
{
if (objvFeatureRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFeatureRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFeatureRegionFlds.InUse);
}
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.UpdUser, objvFeatureRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.UpdDate, objvFeatureRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.Memo, objvFeatureRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RelaFldName) == true)
{
string strComparisonOpRelaFldName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RelaFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RelaFldName, objvFeatureRegionFldsCond.RelaFldName, strComparisonOpRelaFldName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.RelaTabName) == true)
{
string strComparisonOpRelaTabName = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.RelaTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.RelaTabName, objvFeatureRegionFldsCond.RelaTabName, strComparisonOpRelaTabName);
}
if (objvFeatureRegionFldsCond.IsUpdated(convFeatureRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvFeatureRegionFldsCond.dicFldComparisonOp[convFeatureRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds.PrjId, objvFeatureRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能区域字段(vFeatureRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vFeatureRegionFldsApi";

 public clsvFeatureRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
string strAction = "GetObjByViewFeatureId";
clsvFeatureRegionFldsEN objvFeatureRegionFldsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewFeatureId"] = strViewFeatureId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFeatureRegionFldsEN = JsonConvert.DeserializeObject<clsvFeatureRegionFldsEN>(strJson);
return objvFeatureRegionFldsEN;
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
public static clsvFeatureRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureRegionFldsEN objvFeatureRegionFldsEN;
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
objvFeatureRegionFldsEN = JsonConvert.DeserializeObject<clsvFeatureRegionFldsEN>(strJson);
return objvFeatureRegionFldsEN;
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
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureRegionFldsEN GetObjByViewFeatureIdCache(string strViewFeatureId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureRegionFldsEN._CurrTabName);
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst_Sel =
from objvFeatureRegionFldsEN in arrvFeatureRegionFldsObjLstCache
where objvFeatureRegionFldsEN.ViewFeatureId == strViewFeatureId 
select objvFeatureRegionFldsEN;
if (arrvFeatureRegionFldsObjLst_Sel.Count() == 0)
{
   clsvFeatureRegionFldsEN obj = clsvFeatureRegionFldsWApi.GetObjByViewFeatureId(strViewFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFeatureRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
 /// <param name = "arrViewFeatureId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureId)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
string strAction = "GetObjLstByViewFeatureIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewFeatureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
 /// <param name = "arrViewFeatureId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFeatureRegionFldsEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureRegionFldsEN._CurrTabName);
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst_Sel =
from objvFeatureRegionFldsEN in arrvFeatureRegionFldsObjLstCache
where arrViewFeatureId.Contains(objvFeatureRegionFldsEN.ViewFeatureId)
select objvFeatureRegionFldsEN;
return arrvFeatureRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFldsEN>>(strJson);
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
public static bool IsExist(string strViewFeatureId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewFeatureId"] = strViewFeatureId
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
 /// <param name = "objvFeatureRegionFldsENS">源对象</param>
 /// <param name = "objvFeatureRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvFeatureRegionFldsEN objvFeatureRegionFldsENS, clsvFeatureRegionFldsEN objvFeatureRegionFldsENT)
{
try
{
objvFeatureRegionFldsENT.ViewFeatureId = objvFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objvFeatureRegionFldsENT.RegionId = objvFeatureRegionFldsENS.RegionId; //区域Id
objvFeatureRegionFldsENT.RegionName = objvFeatureRegionFldsENS.RegionName; //区域名称
objvFeatureRegionFldsENT.RegionTypeId = objvFeatureRegionFldsENS.RegionTypeId; //区域类型Id
objvFeatureRegionFldsENT.RegionTypeName = objvFeatureRegionFldsENS.RegionTypeName; //区域类型名称
objvFeatureRegionFldsENT.RegionTypeSimName = objvFeatureRegionFldsENS.RegionTypeSimName; //区域类型简名
objvFeatureRegionFldsENT.FeatureId = objvFeatureRegionFldsENS.FeatureId; //功能Id
objvFeatureRegionFldsENT.FeatureName = objvFeatureRegionFldsENS.FeatureName; //功能名称
objvFeatureRegionFldsENT.KeyWords = objvFeatureRegionFldsENS.KeyWords; //关键字
objvFeatureRegionFldsENT.TabFeatureId = objvFeatureRegionFldsENS.TabFeatureId; //表功能Id
objvFeatureRegionFldsENT.TabFeatureName = objvFeatureRegionFldsENS.TabFeatureName; //表功能名
objvFeatureRegionFldsENT.CheckTabFeature = objvFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objvFeatureRegionFldsENT.FeatureDescription = objvFeatureRegionFldsENS.FeatureDescription; //功能说明
objvFeatureRegionFldsENT.ButtonName = objvFeatureRegionFldsENS.ButtonName; //按钮名称
objvFeatureRegionFldsENT.ButtonName4Mvc = objvFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objvFeatureRegionFldsENT.EventFuncName = objvFeatureRegionFldsENS.EventFuncName; //事件函数名
objvFeatureRegionFldsENT.ValueGivingModeId = objvFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objvFeatureRegionFldsENT.ValueGivingModeName = objvFeatureRegionFldsENS.ValueGivingModeName; //给值方式名
objvFeatureRegionFldsENT.FuncName = objvFeatureRegionFldsENS.FuncName; //函数名
objvFeatureRegionFldsENT.DefaultValue = objvFeatureRegionFldsENS.DefaultValue; //缺省值
objvFeatureRegionFldsENT.KeyIdGetModeId = objvFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objvFeatureRegionFldsENT.Text = objvFeatureRegionFldsENS.Text; //文本
objvFeatureRegionFldsENT.GroupName = objvFeatureRegionFldsENS.GroupName; //组名
objvFeatureRegionFldsENT.ReleTabId = objvFeatureRegionFldsENS.ReleTabId; //相关表Id
objvFeatureRegionFldsENT.ReleFldId = objvFeatureRegionFldsENS.ReleFldId; //相关字段Id
objvFeatureRegionFldsENT.FieldTypeId = objvFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objvFeatureRegionFldsENT.FieldTypeName = objvFeatureRegionFldsENS.FieldTypeName; //字段类型名
objvFeatureRegionFldsENT.ViewImplId = objvFeatureRegionFldsENS.ViewImplId; //界面实现Id
objvFeatureRegionFldsENT.ViewImplName = objvFeatureRegionFldsENS.ViewImplName; //界面实现名
objvFeatureRegionFldsENT.CtlTypeId = objvFeatureRegionFldsENS.CtlTypeId; //控件类型号
objvFeatureRegionFldsENT.CtlTypeName = objvFeatureRegionFldsENS.CtlTypeName; //控件类型名
objvFeatureRegionFldsENT.CtlCnName = objvFeatureRegionFldsENS.CtlCnName; //控件类型中文名
objvFeatureRegionFldsENT.CtlTypeAbbr = objvFeatureRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvFeatureRegionFldsENT.Height = objvFeatureRegionFldsENS.Height; //高度
objvFeatureRegionFldsENT.Width = objvFeatureRegionFldsENS.Width; //宽
objvFeatureRegionFldsENT.SeqNum = objvFeatureRegionFldsENS.SeqNum; //字段序号
objvFeatureRegionFldsENT.CssClass = objvFeatureRegionFldsENS.CssClass; //样式表
objvFeatureRegionFldsENT.ImageUrl = objvFeatureRegionFldsENS.ImageUrl; //图片资源
objvFeatureRegionFldsENT.InUse = objvFeatureRegionFldsENS.InUse; //是否在用
objvFeatureRegionFldsENT.UpdUser = objvFeatureRegionFldsENS.UpdUser; //修改者
objvFeatureRegionFldsENT.UpdDate = objvFeatureRegionFldsENS.UpdDate; //修改日期
objvFeatureRegionFldsENT.Memo = objvFeatureRegionFldsENS.Memo; //说明
objvFeatureRegionFldsENT.RelaFldName = objvFeatureRegionFldsENS.RelaFldName; //关系字段名
objvFeatureRegionFldsENT.RelaTabName = objvFeatureRegionFldsENS.RelaTabName; //相关表名
objvFeatureRegionFldsENT.PrjId = objvFeatureRegionFldsENS.PrjId; //工程ID
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
public static DataTable ToDataTable(List<clsvFeatureRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureRegionFldsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureRegionFldsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureRegionFldsEN.AttributeName)
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
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFeatureRegionFldsEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFeatureRegionFldsEN._CurrTabName;
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFeatureRegionFldsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureRegionFlds.ViewFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RegionTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.CheckTabFeature, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ButtonName4Mvc, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.EventFuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ValueGivingModeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.KeyIdGetModeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.Text, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ReleTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ReleFldId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ViewImplId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ViewImplName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFeatureRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RelaFldName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.RelaTabName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvFeatureRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureRegionFlds.ViewFeatureId] = objInFor[convFeatureRegionFlds.ViewFeatureId];
objDR[convFeatureRegionFlds.RegionId] = objInFor[convFeatureRegionFlds.RegionId];
objDR[convFeatureRegionFlds.RegionName] = objInFor[convFeatureRegionFlds.RegionName];
objDR[convFeatureRegionFlds.RegionTypeId] = objInFor[convFeatureRegionFlds.RegionTypeId];
objDR[convFeatureRegionFlds.RegionTypeName] = objInFor[convFeatureRegionFlds.RegionTypeName];
objDR[convFeatureRegionFlds.RegionTypeSimName] = objInFor[convFeatureRegionFlds.RegionTypeSimName];
objDR[convFeatureRegionFlds.FeatureId] = objInFor[convFeatureRegionFlds.FeatureId];
objDR[convFeatureRegionFlds.FeatureName] = objInFor[convFeatureRegionFlds.FeatureName];
objDR[convFeatureRegionFlds.KeyWords] = objInFor[convFeatureRegionFlds.KeyWords];
objDR[convFeatureRegionFlds.TabFeatureId] = objInFor[convFeatureRegionFlds.TabFeatureId];
objDR[convFeatureRegionFlds.TabFeatureName] = objInFor[convFeatureRegionFlds.TabFeatureName];
objDR[convFeatureRegionFlds.CheckTabFeature] = objInFor[convFeatureRegionFlds.CheckTabFeature];
objDR[convFeatureRegionFlds.FeatureDescription] = objInFor[convFeatureRegionFlds.FeatureDescription];
objDR[convFeatureRegionFlds.ButtonName] = objInFor[convFeatureRegionFlds.ButtonName];
objDR[convFeatureRegionFlds.ButtonName4Mvc] = objInFor[convFeatureRegionFlds.ButtonName4Mvc];
objDR[convFeatureRegionFlds.EventFuncName] = objInFor[convFeatureRegionFlds.EventFuncName];
objDR[convFeatureRegionFlds.ValueGivingModeId] = objInFor[convFeatureRegionFlds.ValueGivingModeId];
objDR[convFeatureRegionFlds.ValueGivingModeName] = objInFor[convFeatureRegionFlds.ValueGivingModeName];
objDR[convFeatureRegionFlds.FuncName] = objInFor[convFeatureRegionFlds.FuncName];
objDR[convFeatureRegionFlds.DefaultValue] = objInFor[convFeatureRegionFlds.DefaultValue];
objDR[convFeatureRegionFlds.KeyIdGetModeId] = objInFor[convFeatureRegionFlds.KeyIdGetModeId];
objDR[convFeatureRegionFlds.Text] = objInFor[convFeatureRegionFlds.Text];
objDR[convFeatureRegionFlds.GroupName] = objInFor[convFeatureRegionFlds.GroupName];
objDR[convFeatureRegionFlds.ReleTabId] = objInFor[convFeatureRegionFlds.ReleTabId];
objDR[convFeatureRegionFlds.ReleFldId] = objInFor[convFeatureRegionFlds.ReleFldId];
objDR[convFeatureRegionFlds.FieldTypeId] = objInFor[convFeatureRegionFlds.FieldTypeId];
objDR[convFeatureRegionFlds.FieldTypeName] = objInFor[convFeatureRegionFlds.FieldTypeName];
objDR[convFeatureRegionFlds.ViewImplId] = objInFor[convFeatureRegionFlds.ViewImplId];
objDR[convFeatureRegionFlds.ViewImplName] = objInFor[convFeatureRegionFlds.ViewImplName];
objDR[convFeatureRegionFlds.CtlTypeId] = objInFor[convFeatureRegionFlds.CtlTypeId];
objDR[convFeatureRegionFlds.CtlTypeName] = objInFor[convFeatureRegionFlds.CtlTypeName];
objDR[convFeatureRegionFlds.CtlCnName] = objInFor[convFeatureRegionFlds.CtlCnName];
objDR[convFeatureRegionFlds.CtlTypeAbbr] = objInFor[convFeatureRegionFlds.CtlTypeAbbr];
objDR[convFeatureRegionFlds.Height] = objInFor[convFeatureRegionFlds.Height];
objDR[convFeatureRegionFlds.Width] = objInFor[convFeatureRegionFlds.Width];
objDR[convFeatureRegionFlds.SeqNum] = objInFor[convFeatureRegionFlds.SeqNum];
objDR[convFeatureRegionFlds.CssClass] = objInFor[convFeatureRegionFlds.CssClass];
objDR[convFeatureRegionFlds.ImageUrl] = objInFor[convFeatureRegionFlds.ImageUrl];
objDR[convFeatureRegionFlds.InUse] = objInFor[convFeatureRegionFlds.InUse];
objDR[convFeatureRegionFlds.UpdUser] = objInFor[convFeatureRegionFlds.UpdUser];
objDR[convFeatureRegionFlds.UpdDate] = objInFor[convFeatureRegionFlds.UpdDate];
objDR[convFeatureRegionFlds.Memo] = objInFor[convFeatureRegionFlds.Memo];
objDR[convFeatureRegionFlds.RelaFldName] = objInFor[convFeatureRegionFlds.RelaFldName];
objDR[convFeatureRegionFlds.RelaTabName] = objInFor[convFeatureRegionFlds.RelaTabName];
objDR[convFeatureRegionFlds.PrjId] = objInFor[convFeatureRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}