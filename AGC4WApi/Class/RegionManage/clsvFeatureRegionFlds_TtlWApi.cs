
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFlds_TtlWApi
 表名:vFeatureRegionFlds_Ttl(00050474)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:18
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
public static class  clsvFeatureRegionFlds_TtlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFeatureId">界面功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convFeatureRegionFlds_Ttl.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convFeatureRegionFlds_Ttl.ViewFeatureId);
objvFeatureRegionFlds_TtlEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ViewFeatureId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ViewFeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewFeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convFeatureRegionFlds_Ttl.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convFeatureRegionFlds_Ttl.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convFeatureRegionFlds_Ttl.RegionId);
objvFeatureRegionFlds_TtlEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RegionId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RegionId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionName, 50, convFeatureRegionFlds_Ttl.RegionName);
objvFeatureRegionFlds_TtlEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RegionName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RegionName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFeatureRegionFlds_Ttl.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFeatureRegionFlds_Ttl.RegionTypeId);
objvFeatureRegionFlds_TtlEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RegionTypeId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RegionTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFeatureRegionFlds_Ttl.RegionTypeName);
objvFeatureRegionFlds_TtlEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RegionTypeName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RegionTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureRegionFlds_Ttl.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureRegionFlds_Ttl.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureRegionFlds_Ttl.FeatureId);
objvFeatureRegionFlds_TtlEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FeatureId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureRegionFlds_Ttl.FeatureName);
objvFeatureRegionFlds_TtlEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FeatureName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FeatureName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetKeyWords(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureRegionFlds_Ttl.KeyWords);
objvFeatureRegionFlds_TtlEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.KeyWords) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.KeyWords, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.KeyWords] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetTabFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convFeatureRegionFlds_Ttl.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convFeatureRegionFlds_Ttl.TabFeatureId);
objvFeatureRegionFlds_TtlEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.TabFeatureId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.TabFeatureId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.TabFeatureId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetTabFeatureName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convFeatureRegionFlds_Ttl.TabFeatureName);
objvFeatureRegionFlds_TtlEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.TabFeatureName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.TabFeatureName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.TabFeatureName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckTabFeature">检查表功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCheckTabFeature(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCheckTabFeature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, convFeatureRegionFlds_Ttl.CheckTabFeature);
objvFeatureRegionFlds_TtlEN.CheckTabFeature = strCheckTabFeature; //检查表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CheckTabFeature) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CheckTabFeature, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CheckTabFeature] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureDescription(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureRegionFlds_Ttl.FeatureDescription);
objvFeatureRegionFlds_TtlEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FeatureDescription) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FeatureDescription, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureDescription] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetButtonName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureRegionFlds_Ttl.ButtonName);
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureRegionFlds_Ttl.ButtonName);
objvFeatureRegionFlds_TtlEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ButtonName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ButtonName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ButtonName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName4Mvc">按钮名称4Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetButtonName4Mvc(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = strButtonName4Mvc; //按钮名称4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ButtonName4Mvc) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ButtonName4Mvc, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ButtonName4Mvc] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strEventFuncName">事件函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetEventFuncName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strEventFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureRegionFlds_Ttl.EventFuncName);
objvFeatureRegionFlds_TtlEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.EventFuncName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.EventFuncName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.EventFuncName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetValueGivingModeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convFeatureRegionFlds_Ttl.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convFeatureRegionFlds_Ttl.ValueGivingModeId);
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ValueGivingModeId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ValueGivingModeId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ValueGivingModeId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeName">给值方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetValueGivingModeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strValueGivingModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convFeatureRegionFlds_Ttl.ValueGivingModeName);
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = strValueGivingModeName; //给值方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ValueGivingModeName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ValueGivingModeName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ValueGivingModeName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFuncName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureRegionFlds_Ttl.FuncName);
objvFeatureRegionFlds_TtlEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FuncName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FuncName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FuncName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetDefaultValue(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFeatureRegionFlds_Ttl.DefaultValue);
objvFeatureRegionFlds_TtlEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.DefaultValue) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.DefaultValue, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.DefaultValue] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetText(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureRegionFlds_Ttl.Text);
clsCheckSql.CheckFieldLen(strText, 30, convFeatureRegionFlds_Ttl.Text);
objvFeatureRegionFlds_TtlEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.Text) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.Text, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Text] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetGroupName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convFeatureRegionFlds_Ttl.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convFeatureRegionFlds_Ttl.GroupName);
objvFeatureRegionFlds_TtlEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.GroupName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.GroupName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.GroupName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetReleTabId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strReleTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convFeatureRegionFlds_Ttl.ReleTabId);
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convFeatureRegionFlds_Ttl.ReleTabId);
objvFeatureRegionFlds_TtlEN.ReleTabId = strReleTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ReleTabId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ReleTabId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ReleTabId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleFldId">相关字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetReleFldId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strReleFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convFeatureRegionFlds_Ttl.ReleFldId);
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convFeatureRegionFlds_Ttl.ReleFldId);
objvFeatureRegionFlds_TtlEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ReleFldId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ReleFldId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ReleFldId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFieldTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureRegionFlds_Ttl.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureRegionFlds_Ttl.FieldTypeId);
objvFeatureRegionFlds_TtlEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FieldTypeId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FieldTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FieldTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFieldTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureRegionFlds_Ttl.FieldTypeName);
objvFeatureRegionFlds_TtlEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FieldTypeName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FieldTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FieldTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplId">界面实现Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewImplId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureRegionFlds_Ttl.ViewImplId);
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureRegionFlds_Ttl.ViewImplId);
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureRegionFlds_Ttl.ViewImplId);
objvFeatureRegionFlds_TtlEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ViewImplId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ViewImplId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewImplId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplName">界面实现名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewImplName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewImplName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureRegionFlds_Ttl.ViewImplName);
objvFeatureRegionFlds_TtlEN.ViewImplName = strViewImplName; //界面实现名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ViewImplName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ViewImplName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewImplName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convFeatureRegionFlds_Ttl.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convFeatureRegionFlds_Ttl.CtlTypeId);
objvFeatureRegionFlds_TtlEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CtlTypeId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CtlTypeId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convFeatureRegionFlds_Ttl.CtlTypeName);
objvFeatureRegionFlds_TtlEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CtlTypeName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CtlTypeName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlCnName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convFeatureRegionFlds_Ttl.CtlCnName);
objvFeatureRegionFlds_TtlEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CtlCnName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CtlCnName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlCnName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeAbbr(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convFeatureRegionFlds_Ttl.CtlTypeAbbr);
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CtlTypeAbbr) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CtlTypeAbbr, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeAbbr] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetHeight(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int intHeight, string strComparisonOp="")
	{
objvFeatureRegionFlds_TtlEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.Height) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.Height, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Height] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetWidth(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int intWidth, string strComparisonOp="")
	{
objvFeatureRegionFlds_TtlEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.Width) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.Width, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Width] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetSeqNum(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int intSeqNum, string strComparisonOp="")
	{
objvFeatureRegionFlds_TtlEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.SeqNum) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.SeqNum, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.SeqNum] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCssClass(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, convFeatureRegionFlds_Ttl.CssClass);
objvFeatureRegionFlds_TtlEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.CssClass) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.CssClass, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CssClass] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strImageUrl">图片资源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetImageUrl(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convFeatureRegionFlds_Ttl.ImageUrl);
objvFeatureRegionFlds_TtlEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.ImageUrl) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.ImageUrl, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ImageUrl] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetInUse(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, bool bolInUse, string strComparisonOp="")
	{
objvFeatureRegionFlds_TtlEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.InUse) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.InUse, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.InUse] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetUpdUser(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFeatureRegionFlds_Ttl.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureRegionFlds_Ttl.UpdUser);
objvFeatureRegionFlds_TtlEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.UpdUser) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.UpdUser, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.UpdUser] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetUpdDate(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureRegionFlds_Ttl.UpdDate);
objvFeatureRegionFlds_TtlEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.UpdDate) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.UpdDate, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.UpdDate] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetMemo(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureRegionFlds_Ttl.Memo);
objvFeatureRegionFlds_TtlEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.Memo) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.Memo, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Memo] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFldNum(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int intFldNum, string strComparisonOp="")
	{
objvFeatureRegionFlds_TtlEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.FldNum) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.FldNum, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FldNum] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldName">关系字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRelaFldName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRelaFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convFeatureRegionFlds_Ttl.RelaFldName);
objvFeatureRegionFlds_TtlEN.RelaFldName = strRelaFldName; //关系字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RelaFldName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RelaFldName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RelaFldName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabName">相关表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRelaTabName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRelaTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convFeatureRegionFlds_Ttl.RelaTabName);
objvFeatureRegionFlds_TtlEN.RelaTabName = strRelaTabName; //相关表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.RelaTabName) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.RelaTabName, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RelaTabName] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetPrjId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFeatureRegionFlds_Ttl.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFeatureRegionFlds_Ttl.PrjId);
objvFeatureRegionFlds_TtlEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.ContainsKey(convFeatureRegionFlds_Ttl.PrjId) == false)
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp.Add(convFeatureRegionFlds_Ttl.PrjId, strComparisonOp);
}
else
{
objvFeatureRegionFlds_TtlEN.dicFldComparisonOp[convFeatureRegionFlds_Ttl.PrjId] = strComparisonOp;
}
}
return objvFeatureRegionFlds_TtlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ViewFeatureId, objvFeatureRegionFlds_TtlCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RegionId) == true)
{
string strComparisonOpRegionId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RegionId, objvFeatureRegionFlds_TtlCond.RegionId, strComparisonOpRegionId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RegionName) == true)
{
string strComparisonOpRegionName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RegionName, objvFeatureRegionFlds_TtlCond.RegionName, strComparisonOpRegionName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RegionTypeId, objvFeatureRegionFlds_TtlCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RegionTypeName, objvFeatureRegionFlds_TtlCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FeatureId, objvFeatureRegionFlds_TtlCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FeatureName, objvFeatureRegionFlds_TtlCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.KeyWords, objvFeatureRegionFlds_TtlCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.TabFeatureId, objvFeatureRegionFlds_TtlCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.TabFeatureName, objvFeatureRegionFlds_TtlCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CheckTabFeature) == true)
{
string strComparisonOpCheckTabFeature = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CheckTabFeature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CheckTabFeature, objvFeatureRegionFlds_TtlCond.CheckTabFeature, strComparisonOpCheckTabFeature);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FeatureDescription, objvFeatureRegionFlds_TtlCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ButtonName) == true)
{
string strComparisonOpButtonName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ButtonName, objvFeatureRegionFlds_TtlCond.ButtonName, strComparisonOpButtonName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ButtonName4Mvc) == true)
{
string strComparisonOpButtonName4Mvc = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ButtonName4Mvc, objvFeatureRegionFlds_TtlCond.ButtonName4Mvc, strComparisonOpButtonName4Mvc);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.EventFuncName, objvFeatureRegionFlds_TtlCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ValueGivingModeId, objvFeatureRegionFlds_TtlCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ValueGivingModeName) == true)
{
string strComparisonOpValueGivingModeName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ValueGivingModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ValueGivingModeName, objvFeatureRegionFlds_TtlCond.ValueGivingModeName, strComparisonOpValueGivingModeName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FuncName) == true)
{
string strComparisonOpFuncName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FuncName, objvFeatureRegionFlds_TtlCond.FuncName, strComparisonOpFuncName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.DefaultValue, objvFeatureRegionFlds_TtlCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.Text) == true)
{
string strComparisonOpText = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.Text, objvFeatureRegionFlds_TtlCond.Text, strComparisonOpText);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.GroupName) == true)
{
string strComparisonOpGroupName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.GroupName, objvFeatureRegionFlds_TtlCond.GroupName, strComparisonOpGroupName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ReleTabId) == true)
{
string strComparisonOpReleTabId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ReleTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ReleTabId, objvFeatureRegionFlds_TtlCond.ReleTabId, strComparisonOpReleTabId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ReleFldId) == true)
{
string strComparisonOpReleFldId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ReleFldId, objvFeatureRegionFlds_TtlCond.ReleFldId, strComparisonOpReleFldId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FieldTypeId, objvFeatureRegionFlds_TtlCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.FieldTypeName, objvFeatureRegionFlds_TtlCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ViewImplId) == true)
{
string strComparisonOpViewImplId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ViewImplId, objvFeatureRegionFlds_TtlCond.ViewImplId, strComparisonOpViewImplId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ViewImplName) == true)
{
string strComparisonOpViewImplName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ViewImplName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ViewImplName, objvFeatureRegionFlds_TtlCond.ViewImplName, strComparisonOpViewImplName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CtlTypeId, objvFeatureRegionFlds_TtlCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CtlTypeName, objvFeatureRegionFlds_TtlCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CtlCnName, objvFeatureRegionFlds_TtlCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CtlTypeAbbr, objvFeatureRegionFlds_TtlCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.Height) == true)
{
string strComparisonOpHeight = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Height];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds_Ttl.Height, objvFeatureRegionFlds_TtlCond.Height, strComparisonOpHeight);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.Width) == true)
{
string strComparisonOpWidth = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds_Ttl.Width, objvFeatureRegionFlds_TtlCond.Width, strComparisonOpWidth);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.SeqNum) == true)
{
string strComparisonOpSeqNum = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds_Ttl.SeqNum, objvFeatureRegionFlds_TtlCond.SeqNum, strComparisonOpSeqNum);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.CssClass) == true)
{
string strComparisonOpCssClass = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.CssClass, objvFeatureRegionFlds_TtlCond.CssClass, strComparisonOpCssClass);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.ImageUrl, objvFeatureRegionFlds_TtlCond.ImageUrl, strComparisonOpImageUrl);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.InUse) == true)
{
if (objvFeatureRegionFlds_TtlCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFeatureRegionFlds_Ttl.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFeatureRegionFlds_Ttl.InUse);
}
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.UpdUser, objvFeatureRegionFlds_TtlCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.UpdDate, objvFeatureRegionFlds_TtlCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.Memo) == true)
{
string strComparisonOpMemo = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.Memo, objvFeatureRegionFlds_TtlCond.Memo, strComparisonOpMemo);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.FldNum) == true)
{
string strComparisonOpFldNum = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureRegionFlds_Ttl.FldNum, objvFeatureRegionFlds_TtlCond.FldNum, strComparisonOpFldNum);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RelaFldName) == true)
{
string strComparisonOpRelaFldName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RelaFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RelaFldName, objvFeatureRegionFlds_TtlCond.RelaFldName, strComparisonOpRelaFldName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.RelaTabName) == true)
{
string strComparisonOpRelaTabName = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.RelaTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.RelaTabName, objvFeatureRegionFlds_TtlCond.RelaTabName, strComparisonOpRelaTabName);
}
if (objvFeatureRegionFlds_TtlCond.IsUpdated(convFeatureRegionFlds_Ttl.PrjId) == true)
{
string strComparisonOpPrjId = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[convFeatureRegionFlds_Ttl.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureRegionFlds_Ttl.PrjId, objvFeatureRegionFlds_TtlCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能区域字段_Ttl(vFeatureRegionFlds_Ttl)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureRegionFlds_TtlWApi
{
private static readonly string mstrApiControllerName = "vFeatureRegionFlds_TtlApi";

 public clsvFeatureRegionFlds_TtlWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureId(string strViewFeatureId)
{
string strAction = "GetObjByViewFeatureId";
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN;
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
objvFeatureRegionFlds_TtlEN = JsonConvert.DeserializeObject<clsvFeatureRegionFlds_TtlEN>(strJson);
return objvFeatureRegionFlds_TtlEN;
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
public static clsvFeatureRegionFlds_TtlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN;
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
objvFeatureRegionFlds_TtlEN = JsonConvert.DeserializeObject<clsvFeatureRegionFlds_TtlEN>(strJson);
return objvFeatureRegionFlds_TtlEN;
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
public static clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureIdCache(string strViewFeatureId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureRegionFlds_TtlEN._CurrTabName);
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLst_Sel =
from objvFeatureRegionFlds_TtlEN in arrvFeatureRegionFlds_TtlObjLstCache
where objvFeatureRegionFlds_TtlEN.ViewFeatureId == strViewFeatureId 
select objvFeatureRegionFlds_TtlEN;
if (arrvFeatureRegionFlds_TtlObjLst_Sel.Count() == 0)
{
   clsvFeatureRegionFlds_TtlEN obj = clsvFeatureRegionFlds_TtlWApi.GetObjByViewFeatureId(strViewFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFeatureRegionFlds_TtlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureId)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
public static IEnumerable<clsvFeatureRegionFlds_TtlEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureRegionFlds_TtlEN._CurrTabName);
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLst_Sel =
from objvFeatureRegionFlds_TtlEN in arrvFeatureRegionFlds_TtlObjLstCache
where arrViewFeatureId.Contains(objvFeatureRegionFlds_TtlEN.ViewFeatureId)
select objvFeatureRegionFlds_TtlEN;
return arrvFeatureRegionFlds_TtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureRegionFlds_TtlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureRegionFlds_TtlEN>>(strJson);
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
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <param name = "objvFeatureRegionFlds_TtlENT">目标对象</param>
 public static void CopyTo(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENS, clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENT)
{
try
{
objvFeatureRegionFlds_TtlENT.ViewFeatureId = objvFeatureRegionFlds_TtlENS.ViewFeatureId; //界面功能Id
objvFeatureRegionFlds_TtlENT.RegionId = objvFeatureRegionFlds_TtlENS.RegionId; //区域Id
objvFeatureRegionFlds_TtlENT.RegionName = objvFeatureRegionFlds_TtlENS.RegionName; //区域名称
objvFeatureRegionFlds_TtlENT.RegionTypeId = objvFeatureRegionFlds_TtlENS.RegionTypeId; //区域类型Id
objvFeatureRegionFlds_TtlENT.RegionTypeName = objvFeatureRegionFlds_TtlENS.RegionTypeName; //区域类型名称
objvFeatureRegionFlds_TtlENT.FeatureId = objvFeatureRegionFlds_TtlENS.FeatureId; //功能Id
objvFeatureRegionFlds_TtlENT.FeatureName = objvFeatureRegionFlds_TtlENS.FeatureName; //功能名称
objvFeatureRegionFlds_TtlENT.KeyWords = objvFeatureRegionFlds_TtlENS.KeyWords; //关键字
objvFeatureRegionFlds_TtlENT.TabFeatureId = objvFeatureRegionFlds_TtlENS.TabFeatureId; //表功能Id
objvFeatureRegionFlds_TtlENT.TabFeatureName = objvFeatureRegionFlds_TtlENS.TabFeatureName; //表功能名
objvFeatureRegionFlds_TtlENT.CheckTabFeature = objvFeatureRegionFlds_TtlENS.CheckTabFeature; //检查表功能
objvFeatureRegionFlds_TtlENT.FeatureDescription = objvFeatureRegionFlds_TtlENS.FeatureDescription; //功能说明
objvFeatureRegionFlds_TtlENT.ButtonName = objvFeatureRegionFlds_TtlENS.ButtonName; //按钮名称
objvFeatureRegionFlds_TtlENT.ButtonName4Mvc = objvFeatureRegionFlds_TtlENS.ButtonName4Mvc; //按钮名称4Mvc
objvFeatureRegionFlds_TtlENT.EventFuncName = objvFeatureRegionFlds_TtlENS.EventFuncName; //事件函数名
objvFeatureRegionFlds_TtlENT.ValueGivingModeId = objvFeatureRegionFlds_TtlENS.ValueGivingModeId; //给值方式Id
objvFeatureRegionFlds_TtlENT.ValueGivingModeName = objvFeatureRegionFlds_TtlENS.ValueGivingModeName; //给值方式名
objvFeatureRegionFlds_TtlENT.FuncName = objvFeatureRegionFlds_TtlENS.FuncName; //函数名
objvFeatureRegionFlds_TtlENT.DefaultValue = objvFeatureRegionFlds_TtlENS.DefaultValue; //缺省值
objvFeatureRegionFlds_TtlENT.Text = objvFeatureRegionFlds_TtlENS.Text; //文本
objvFeatureRegionFlds_TtlENT.GroupName = objvFeatureRegionFlds_TtlENS.GroupName; //组名
objvFeatureRegionFlds_TtlENT.ReleTabId = objvFeatureRegionFlds_TtlENS.ReleTabId; //相关表Id
objvFeatureRegionFlds_TtlENT.ReleFldId = objvFeatureRegionFlds_TtlENS.ReleFldId; //相关字段Id
objvFeatureRegionFlds_TtlENT.FieldTypeId = objvFeatureRegionFlds_TtlENS.FieldTypeId; //字段类型Id
objvFeatureRegionFlds_TtlENT.FieldTypeName = objvFeatureRegionFlds_TtlENS.FieldTypeName; //字段类型名
objvFeatureRegionFlds_TtlENT.ViewImplId = objvFeatureRegionFlds_TtlENS.ViewImplId; //界面实现Id
objvFeatureRegionFlds_TtlENT.ViewImplName = objvFeatureRegionFlds_TtlENS.ViewImplName; //界面实现名
objvFeatureRegionFlds_TtlENT.CtlTypeId = objvFeatureRegionFlds_TtlENS.CtlTypeId; //控件类型号
objvFeatureRegionFlds_TtlENT.CtlTypeName = objvFeatureRegionFlds_TtlENS.CtlTypeName; //控件类型名
objvFeatureRegionFlds_TtlENT.CtlCnName = objvFeatureRegionFlds_TtlENS.CtlCnName; //控件类型中文名
objvFeatureRegionFlds_TtlENT.CtlTypeAbbr = objvFeatureRegionFlds_TtlENS.CtlTypeAbbr; //控件类型缩写
objvFeatureRegionFlds_TtlENT.Height = objvFeatureRegionFlds_TtlENS.Height; //高度
objvFeatureRegionFlds_TtlENT.Width = objvFeatureRegionFlds_TtlENS.Width; //宽
objvFeatureRegionFlds_TtlENT.SeqNum = objvFeatureRegionFlds_TtlENS.SeqNum; //字段序号
objvFeatureRegionFlds_TtlENT.CssClass = objvFeatureRegionFlds_TtlENS.CssClass; //样式表
objvFeatureRegionFlds_TtlENT.ImageUrl = objvFeatureRegionFlds_TtlENS.ImageUrl; //图片资源
objvFeatureRegionFlds_TtlENT.InUse = objvFeatureRegionFlds_TtlENS.InUse; //是否在用
objvFeatureRegionFlds_TtlENT.UpdUser = objvFeatureRegionFlds_TtlENS.UpdUser; //修改者
objvFeatureRegionFlds_TtlENT.UpdDate = objvFeatureRegionFlds_TtlENS.UpdDate; //修改日期
objvFeatureRegionFlds_TtlENT.Memo = objvFeatureRegionFlds_TtlENS.Memo; //说明
objvFeatureRegionFlds_TtlENT.FldNum = objvFeatureRegionFlds_TtlENS.FldNum; //字段数
objvFeatureRegionFlds_TtlENT.RelaFldName = objvFeatureRegionFlds_TtlENS.RelaFldName; //关系字段名
objvFeatureRegionFlds_TtlENT.RelaTabName = objvFeatureRegionFlds_TtlENS.RelaTabName; //相关表名
objvFeatureRegionFlds_TtlENT.PrjId = objvFeatureRegionFlds_TtlENS.PrjId; //工程ID
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
public static DataTable ToDataTable(List<clsvFeatureRegionFlds_TtlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureRegionFlds_TtlEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureRegionFlds_TtlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureRegionFlds_TtlEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureRegionFlds_TtlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureRegionFlds_TtlEN.AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureRegionFlds_TtlEN._CurrTabName);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFeatureRegionFlds_TtlEN._CurrTabName;
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFeatureRegionFlds_TtlObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureRegionFlds_TtlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ViewFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CheckTabFeature, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ButtonName4Mvc, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.EventFuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ValueGivingModeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.Text, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ReleTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ReleFldId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ViewImplId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ViewImplName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RelaFldName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.RelaTabName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureRegionFlds_Ttl.PrjId, Type.GetType("System.String"));
foreach (clsvFeatureRegionFlds_TtlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureRegionFlds_Ttl.ViewFeatureId] = objInFor[convFeatureRegionFlds_Ttl.ViewFeatureId];
objDR[convFeatureRegionFlds_Ttl.RegionId] = objInFor[convFeatureRegionFlds_Ttl.RegionId];
objDR[convFeatureRegionFlds_Ttl.RegionName] = objInFor[convFeatureRegionFlds_Ttl.RegionName];
objDR[convFeatureRegionFlds_Ttl.RegionTypeId] = objInFor[convFeatureRegionFlds_Ttl.RegionTypeId];
objDR[convFeatureRegionFlds_Ttl.RegionTypeName] = objInFor[convFeatureRegionFlds_Ttl.RegionTypeName];
objDR[convFeatureRegionFlds_Ttl.FeatureId] = objInFor[convFeatureRegionFlds_Ttl.FeatureId];
objDR[convFeatureRegionFlds_Ttl.FeatureName] = objInFor[convFeatureRegionFlds_Ttl.FeatureName];
objDR[convFeatureRegionFlds_Ttl.KeyWords] = objInFor[convFeatureRegionFlds_Ttl.KeyWords];
objDR[convFeatureRegionFlds_Ttl.TabFeatureId] = objInFor[convFeatureRegionFlds_Ttl.TabFeatureId];
objDR[convFeatureRegionFlds_Ttl.TabFeatureName] = objInFor[convFeatureRegionFlds_Ttl.TabFeatureName];
objDR[convFeatureRegionFlds_Ttl.CheckTabFeature] = objInFor[convFeatureRegionFlds_Ttl.CheckTabFeature];
objDR[convFeatureRegionFlds_Ttl.FeatureDescription] = objInFor[convFeatureRegionFlds_Ttl.FeatureDescription];
objDR[convFeatureRegionFlds_Ttl.ButtonName] = objInFor[convFeatureRegionFlds_Ttl.ButtonName];
objDR[convFeatureRegionFlds_Ttl.ButtonName4Mvc] = objInFor[convFeatureRegionFlds_Ttl.ButtonName4Mvc];
objDR[convFeatureRegionFlds_Ttl.EventFuncName] = objInFor[convFeatureRegionFlds_Ttl.EventFuncName];
objDR[convFeatureRegionFlds_Ttl.ValueGivingModeId] = objInFor[convFeatureRegionFlds_Ttl.ValueGivingModeId];
objDR[convFeatureRegionFlds_Ttl.ValueGivingModeName] = objInFor[convFeatureRegionFlds_Ttl.ValueGivingModeName];
objDR[convFeatureRegionFlds_Ttl.FuncName] = objInFor[convFeatureRegionFlds_Ttl.FuncName];
objDR[convFeatureRegionFlds_Ttl.DefaultValue] = objInFor[convFeatureRegionFlds_Ttl.DefaultValue];
objDR[convFeatureRegionFlds_Ttl.Text] = objInFor[convFeatureRegionFlds_Ttl.Text];
objDR[convFeatureRegionFlds_Ttl.GroupName] = objInFor[convFeatureRegionFlds_Ttl.GroupName];
objDR[convFeatureRegionFlds_Ttl.ReleTabId] = objInFor[convFeatureRegionFlds_Ttl.ReleTabId];
objDR[convFeatureRegionFlds_Ttl.ReleFldId] = objInFor[convFeatureRegionFlds_Ttl.ReleFldId];
objDR[convFeatureRegionFlds_Ttl.FieldTypeId] = objInFor[convFeatureRegionFlds_Ttl.FieldTypeId];
objDR[convFeatureRegionFlds_Ttl.FieldTypeName] = objInFor[convFeatureRegionFlds_Ttl.FieldTypeName];
objDR[convFeatureRegionFlds_Ttl.ViewImplId] = objInFor[convFeatureRegionFlds_Ttl.ViewImplId];
objDR[convFeatureRegionFlds_Ttl.ViewImplName] = objInFor[convFeatureRegionFlds_Ttl.ViewImplName];
objDR[convFeatureRegionFlds_Ttl.CtlTypeId] = objInFor[convFeatureRegionFlds_Ttl.CtlTypeId];
objDR[convFeatureRegionFlds_Ttl.CtlTypeName] = objInFor[convFeatureRegionFlds_Ttl.CtlTypeName];
objDR[convFeatureRegionFlds_Ttl.CtlCnName] = objInFor[convFeatureRegionFlds_Ttl.CtlCnName];
objDR[convFeatureRegionFlds_Ttl.CtlTypeAbbr] = objInFor[convFeatureRegionFlds_Ttl.CtlTypeAbbr];
objDR[convFeatureRegionFlds_Ttl.Height] = objInFor[convFeatureRegionFlds_Ttl.Height];
objDR[convFeatureRegionFlds_Ttl.Width] = objInFor[convFeatureRegionFlds_Ttl.Width];
objDR[convFeatureRegionFlds_Ttl.SeqNum] = objInFor[convFeatureRegionFlds_Ttl.SeqNum];
objDR[convFeatureRegionFlds_Ttl.CssClass] = objInFor[convFeatureRegionFlds_Ttl.CssClass];
objDR[convFeatureRegionFlds_Ttl.ImageUrl] = objInFor[convFeatureRegionFlds_Ttl.ImageUrl];
objDR[convFeatureRegionFlds_Ttl.InUse] = objInFor[convFeatureRegionFlds_Ttl.InUse];
objDR[convFeatureRegionFlds_Ttl.UpdUser] = objInFor[convFeatureRegionFlds_Ttl.UpdUser];
objDR[convFeatureRegionFlds_Ttl.UpdDate] = objInFor[convFeatureRegionFlds_Ttl.UpdDate];
objDR[convFeatureRegionFlds_Ttl.Memo] = objInFor[convFeatureRegionFlds_Ttl.Memo];
objDR[convFeatureRegionFlds_Ttl.FldNum] = objInFor[convFeatureRegionFlds_Ttl.FldNum];
objDR[convFeatureRegionFlds_Ttl.RelaFldName] = objInFor[convFeatureRegionFlds_Ttl.RelaFldName];
objDR[convFeatureRegionFlds_Ttl.RelaTabName] = objInFor[convFeatureRegionFlds_Ttl.RelaTabName];
objDR[convFeatureRegionFlds_Ttl.PrjId] = objInFor[convFeatureRegionFlds_Ttl.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}