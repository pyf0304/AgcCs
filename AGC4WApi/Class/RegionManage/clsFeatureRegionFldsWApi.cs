
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureRegionFldsWApi
 表名:FeatureRegionFlds(00050452)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsFeatureRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFeatureId">界面功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetViewFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
objFeatureRegionFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ViewFeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ViewFeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ViewFeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetRegionId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conFeatureRegionFlds.RegionId);
objFeatureRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.RegionId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.RegionId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.RegionId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFeatureRegionFlds.FeatureId);
objFeatureRegionFldsEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetTabFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
objFeatureRegionFldsEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.TabFeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.TabFeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.TabFeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckTabFeature">检查表功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCheckTabFeature(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCheckTabFeature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, conFeatureRegionFlds.CheckTabFeature);
objFeatureRegionFldsEN.CheckTabFeature = strCheckTabFeature; //检查表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CheckTabFeature) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CheckTabFeature, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CheckTabFeature] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFeatureDescription(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conFeatureRegionFlds.FeatureDescription);
objFeatureRegionFldsEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FeatureDescription) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FeatureDescription, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FeatureDescription] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetButtonName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(strButtonName, 30, conFeatureRegionFlds.ButtonName);
objFeatureRegionFldsEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ButtonName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ButtonName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ButtonName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName4Mvc">按钮名称4Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetButtonName4Mvc(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, conFeatureRegionFlds.ButtonName4Mvc);
objFeatureRegionFldsEN.ButtonName4Mvc = strButtonName4Mvc; //按钮名称4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ButtonName4Mvc) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ButtonName4Mvc, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ButtonName4Mvc] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCommandName">命令名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCommandName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCommandName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCommandName, 30, conFeatureRegionFlds.CommandName);
objFeatureRegionFldsEN.CommandName = strCommandName; //命令名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CommandName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CommandName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CommandName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetValueGivingModeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
objFeatureRegionFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ValueGivingModeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFuncName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, conFeatureRegionFlds.FuncName);
objFeatureRegionFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FuncName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FuncName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FuncName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetDefaultValue(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conFeatureRegionFlds.DefaultValue);
objFeatureRegionFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.DefaultValue) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.DefaultValue, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.DefaultValue] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyIdGetModeId">GC关键字获取方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetKeyIdGetModeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
objFeatureRegionFldsEN.KeyIdGetModeId = strKeyIdGetModeId; //GC关键字获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.KeyIdGetModeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.KeyIdGetModeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.KeyIdGetModeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetText(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, conFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(strText, 30, conFeatureRegionFlds.Text);
objFeatureRegionFldsEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Text) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Text, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Text] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetGroupName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 30, conFeatureRegionFlds.GroupName);
objFeatureRegionFldsEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.GroupName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.GroupName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.GroupName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetReleTabId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strReleTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReleTabId, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldLen(strReleTabId, 8, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, conFeatureRegionFlds.ReleTabId);
objFeatureRegionFldsEN.ReleTabId = strReleTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ReleTabId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ReleTabId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ReleTabId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleFldId">相关字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetReleFldId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strReleFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleFldId, 8, conFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, conFeatureRegionFlds.ReleFldId);
objFeatureRegionFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ReleFldId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ReleFldId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ReleFldId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strEventFuncName">事件函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetEventFuncName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strEventFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, conFeatureRegionFlds.EventFuncName);
objFeatureRegionFldsEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.EventFuncName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.EventFuncName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.EventFuncName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFieldTypeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
objFeatureRegionFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FieldTypeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FieldTypeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FieldTypeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplId">界面实现Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetViewImplId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(strViewImplId, 4, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, conFeatureRegionFlds.ViewImplId);
objFeatureRegionFldsEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ViewImplId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ViewImplId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ViewImplId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCtlTypeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
objFeatureRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CtlTypeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetHeight(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int intHeight, string strComparisonOp="")
	{
objFeatureRegionFldsEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Height) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Height, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Height] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetWidth(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objFeatureRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Width) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Width, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Width] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetSeqNum(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objFeatureRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.SeqNum) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.SeqNum, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.SeqNum] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCssClass(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, conFeatureRegionFlds.CssClass);
objFeatureRegionFldsEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CssClass) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CssClass, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CssClass] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strImageUrl">图片资源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetImageUrl(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conFeatureRegionFlds.ImageUrl);
objFeatureRegionFldsEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ImageUrl) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ImageUrl, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ImageUrl] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetInUse(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objFeatureRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.InUse) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.InUse, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.InUse] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetErrMsg(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conFeatureRegionFlds.ErrMsg);
objFeatureRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ErrMsg) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetPrjId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFeatureRegionFlds.PrjId);
objFeatureRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.PrjId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.PrjId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.PrjId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetUpdUser(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFeatureRegionFlds.UpdUser);
objFeatureRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.UpdUser) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.UpdUser, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.UpdUser] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetUpdDate(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFeatureRegionFlds.UpdDate);
objFeatureRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.UpdDate) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.UpdDate, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.UpdDate] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetMemo(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFeatureRegionFlds.Memo);
objFeatureRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Memo) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Memo, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Memo] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFeatureRegionFldsEN objFeatureRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ViewFeatureId, objFeatureRegionFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.RegionId, objFeatureRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FeatureId) == true)
{
string strComparisonOpFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FeatureId, objFeatureRegionFldsCond.FeatureId, strComparisonOpFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.TabFeatureId, objFeatureRegionFldsCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CheckTabFeature) == true)
{
string strComparisonOpCheckTabFeature = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CheckTabFeature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CheckTabFeature, objFeatureRegionFldsCond.CheckTabFeature, strComparisonOpCheckTabFeature);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FeatureDescription, objFeatureRegionFldsCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ButtonName) == true)
{
string strComparisonOpButtonName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ButtonName, objFeatureRegionFldsCond.ButtonName, strComparisonOpButtonName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc) == true)
{
string strComparisonOpButtonName4Mvc = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ButtonName4Mvc, objFeatureRegionFldsCond.ButtonName4Mvc, strComparisonOpButtonName4Mvc);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CommandName) == true)
{
string strComparisonOpCommandName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CommandName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CommandName, objFeatureRegionFldsCond.CommandName, strComparisonOpCommandName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ValueGivingModeId, objFeatureRegionFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FuncName) == true)
{
string strComparisonOpFuncName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FuncName, objFeatureRegionFldsCond.FuncName, strComparisonOpFuncName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.DefaultValue, objFeatureRegionFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId) == true)
{
string strComparisonOpKeyIdGetModeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.KeyIdGetModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.KeyIdGetModeId, objFeatureRegionFldsCond.KeyIdGetModeId, strComparisonOpKeyIdGetModeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Text) == true)
{
string strComparisonOpText = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.Text, objFeatureRegionFldsCond.Text, strComparisonOpText);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.GroupName) == true)
{
string strComparisonOpGroupName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.GroupName, objFeatureRegionFldsCond.GroupName, strComparisonOpGroupName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ReleTabId) == true)
{
string strComparisonOpReleTabId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ReleTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ReleTabId, objFeatureRegionFldsCond.ReleTabId, strComparisonOpReleTabId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ReleFldId, objFeatureRegionFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.EventFuncName, objFeatureRegionFldsCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FieldTypeId, objFeatureRegionFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ViewImplId) == true)
{
string strComparisonOpViewImplId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ViewImplId, objFeatureRegionFldsCond.ViewImplId, strComparisonOpViewImplId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CtlTypeId, objFeatureRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Height) == true)
{
string strComparisonOpHeight = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.Height, objFeatureRegionFldsCond.Height, strComparisonOpHeight);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Width) == true)
{
string strComparisonOpWidth = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.Width, objFeatureRegionFldsCond.Width, strComparisonOpWidth);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.SeqNum, objFeatureRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CssClass) == true)
{
string strComparisonOpCssClass = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CssClass, objFeatureRegionFldsCond.CssClass, strComparisonOpCssClass);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ImageUrl) == true)
{
string strComparisonOpImageUrl = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ImageUrl, objFeatureRegionFldsCond.ImageUrl, strComparisonOpImageUrl);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.InUse) == true)
{
if (objFeatureRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFeatureRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFeatureRegionFlds.InUse);
}
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ErrMsg, objFeatureRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.PrjId, objFeatureRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.UpdUser, objFeatureRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.UpdDate, objFeatureRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.Memo, objFeatureRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFeatureRegionFldsEN.sfUpdFldSetStr = objFeatureRegionFldsEN.getsfUpdFldSetStr();
clsFeatureRegionFldsWApi.CheckPropertyNew(objFeatureRegionFldsEN); 
bool bolResult = clsFeatureRegionFldsWApi.UpdateRecord(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
 /// 获取唯一性条件串--FeatureRegionFlds(功能区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Uni_RegionId_FeatureId_ButtonName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFeatureRegionFldsEN == null) return "";
if (objFeatureRegionFldsEN.ViewFeatureId == null || objFeatureRegionFldsEN.ViewFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewFeatureId !=  '{0}'", objFeatureRegionFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsWApi.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsWApi.GetMaxStrId();
 }
clsFeatureRegionFldsWApi.CheckPropertyNew(objFeatureRegionFldsEN); 
bool bolResult = clsFeatureRegionFldsWApi.AddNewRecord(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
clsFeatureRegionFldsWApi.CheckPropertyNew(objFeatureRegionFldsEN); 
string strViewFeatureId = clsFeatureRegionFldsWApi.AddNewRecordWithMaxId(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
return strViewFeatureId;
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strWhereCond)
{
try
{
clsFeatureRegionFldsWApi.CheckPropertyNew(objFeatureRegionFldsEN); 
bool bolResult = clsFeatureRegionFldsWApi.UpdateWithCondition(objFeatureRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
 /// 功能区域字段(FeatureRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFeatureRegionFldsWApi
{
private static readonly string mstrApiControllerName = "FeatureRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFeatureRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
if (!Object.Equals(null, objFeatureRegionFldsEN.ViewFeatureId) && GetStrLen(objFeatureRegionFldsEN.ViewFeatureId) > 8)
{
 throw new Exception("字段[界面功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.RegionId) && GetStrLen(objFeatureRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.FeatureId) && GetStrLen(objFeatureRegionFldsEN.FeatureId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.TabFeatureId) && GetStrLen(objFeatureRegionFldsEN.TabFeatureId) > 8)
{
 throw new Exception("字段[表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.CheckTabFeature) && GetStrLen(objFeatureRegionFldsEN.CheckTabFeature) > 50)
{
 throw new Exception("字段[检查表功能]的长度不能超过50!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.FeatureDescription) && GetStrLen(objFeatureRegionFldsEN.FeatureDescription) > 4000)
{
 throw new Exception("字段[功能说明]的长度不能超过4000!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ButtonName) && GetStrLen(objFeatureRegionFldsEN.ButtonName) > 30)
{
 throw new Exception("字段[按钮名称]的长度不能超过30!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ButtonName4Mvc) && GetStrLen(objFeatureRegionFldsEN.ButtonName4Mvc) > 30)
{
 throw new Exception("字段[按钮名称4Mvc]的长度不能超过30!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.CommandName) && GetStrLen(objFeatureRegionFldsEN.CommandName) > 30)
{
 throw new Exception("字段[命令名]的长度不能超过30!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ValueGivingModeId) && GetStrLen(objFeatureRegionFldsEN.ValueGivingModeId) > 2)
{
 throw new Exception("字段[给值方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.FuncName) && GetStrLen(objFeatureRegionFldsEN.FuncName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.DefaultValue) && GetStrLen(objFeatureRegionFldsEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.KeyIdGetModeId) && GetStrLen(objFeatureRegionFldsEN.KeyIdGetModeId) > 4)
{
 throw new Exception("字段[GC关键字获取方式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.Text) && GetStrLen(objFeatureRegionFldsEN.Text) > 30)
{
 throw new Exception("字段[文本]的长度不能超过30!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.GroupName) && GetStrLen(objFeatureRegionFldsEN.GroupName) > 30)
{
 throw new Exception("字段[组名]的长度不能超过30!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ReleTabId) && GetStrLen(objFeatureRegionFldsEN.ReleTabId) > 8)
{
 throw new Exception("字段[相关表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ReleFldId) && GetStrLen(objFeatureRegionFldsEN.ReleFldId) > 8)
{
 throw new Exception("字段[相关字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.EventFuncName) && GetStrLen(objFeatureRegionFldsEN.EventFuncName) > 50)
{
 throw new Exception("字段[事件函数名]的长度不能超过50!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.FieldTypeId) && GetStrLen(objFeatureRegionFldsEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ViewImplId) && GetStrLen(objFeatureRegionFldsEN.ViewImplId) > 4)
{
 throw new Exception("字段[界面实现Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.CtlTypeId) && GetStrLen(objFeatureRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.CssClass) && GetStrLen(objFeatureRegionFldsEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ImageUrl) && GetStrLen(objFeatureRegionFldsEN.ImageUrl) > 100)
{
 throw new Exception("字段[图片资源]的长度不能超过100!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.ErrMsg) && GetStrLen(objFeatureRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.PrjId) && GetStrLen(objFeatureRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.UpdUser) && GetStrLen(objFeatureRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.UpdDate) && GetStrLen(objFeatureRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFeatureRegionFldsEN.Memo) && GetStrLen(objFeatureRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFeatureRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
if (strViewFeatureId == "") return null;
string strAction = "GetObjByViewFeatureId";
clsFeatureRegionFldsEN objFeatureRegionFldsEN;
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
objFeatureRegionFldsEN = JsonConvert.DeserializeObject<clsFeatureRegionFldsEN>(strJson);
return objFeatureRegionFldsEN;
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
public static clsFeatureRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFeatureRegionFldsEN objFeatureRegionFldsEN;
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
objFeatureRegionFldsEN = JsonConvert.DeserializeObject<clsFeatureRegionFldsEN>(strJson);
return objFeatureRegionFldsEN;
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
public static clsFeatureRegionFldsEN GetObjByViewFeatureIdCache(string strViewFeatureId,string strRegionId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
from objFeatureRegionFldsEN in arrFeatureRegionFldsObjLstCache
where objFeatureRegionFldsEN.ViewFeatureId == strViewFeatureId 
select objFeatureRegionFldsEN;
if (arrFeatureRegionFldsObjLst_Sel.Count() == 0)
{
   clsFeatureRegionFldsEN obj = clsFeatureRegionFldsWApi.GetObjByViewFeatureId(strViewFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFeatureRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureId)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static IEnumerable<clsFeatureRegionFldsEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
from objFeatureRegionFldsEN in arrFeatureRegionFldsObjLstCache
where arrViewFeatureId.Contains(objFeatureRegionFldsEN.ViewFeatureId)
select objFeatureRegionFldsEN;
return arrFeatureRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFeatureRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureRegionFldsEN>>(strJson);
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
public static int DelRecord(string strViewFeatureId)
{
string strAction = "DelRecord";
try
{
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsWApi.GetObjByViewFeatureId(strViewFeatureId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewFeatureId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
public static int DelFeatureRegionFldss(List<string> arrViewFeatureId)
{
string strAction = "DelFeatureRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewFeatureId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsWApi.GetObjByViewFeatureId(arrViewFeatureId[0]);
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
public static int DelFeatureRegionFldssByCond(string strWhereCond)
{
string strAction = "DelFeatureRegionFldssByCond";
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
public static bool AddNewRecord(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureRegionFldsEN>(objFeatureRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureRegionFldsEN>(objFeatureRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
var strViewFeatureId = (string)jobjReturn0["returnStr"];
return strViewFeatureId;
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
public static bool UpdateRecord(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
if (string.IsNullOrEmpty(objFeatureRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureRegionFldsEN.ViewFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureRegionFldsEN>(objFeatureRegionFldsEN);
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFeatureRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureRegionFldsEN.ViewFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureRegionFldsEN.ViewFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureRegionFldsEN>(objFeatureRegionFldsEN);
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
 /// <param name = "objFeatureRegionFldsENS">源对象</param>
 /// <param name = "objFeatureRegionFldsENT">目标对象</param>
 public static void CopyTo(clsFeatureRegionFldsEN objFeatureRegionFldsENS, clsFeatureRegionFldsEN objFeatureRegionFldsENT)
{
try
{
objFeatureRegionFldsENT.ViewFeatureId = objFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objFeatureRegionFldsENT.RegionId = objFeatureRegionFldsENS.RegionId; //区域Id
objFeatureRegionFldsENT.FeatureId = objFeatureRegionFldsENS.FeatureId; //功能Id
objFeatureRegionFldsENT.TabFeatureId = objFeatureRegionFldsENS.TabFeatureId; //表功能Id
objFeatureRegionFldsENT.CheckTabFeature = objFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objFeatureRegionFldsENT.FeatureDescription = objFeatureRegionFldsENS.FeatureDescription; //功能说明
objFeatureRegionFldsENT.ButtonName = objFeatureRegionFldsENS.ButtonName; //按钮名称
objFeatureRegionFldsENT.ButtonName4Mvc = objFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objFeatureRegionFldsENT.CommandName = objFeatureRegionFldsENS.CommandName; //命令名
objFeatureRegionFldsENT.ValueGivingModeId = objFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objFeatureRegionFldsENT.FuncName = objFeatureRegionFldsENS.FuncName; //函数名
objFeatureRegionFldsENT.DefaultValue = objFeatureRegionFldsENS.DefaultValue; //缺省值
objFeatureRegionFldsENT.KeyIdGetModeId = objFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objFeatureRegionFldsENT.Text = objFeatureRegionFldsENS.Text; //文本
objFeatureRegionFldsENT.GroupName = objFeatureRegionFldsENS.GroupName; //组名
objFeatureRegionFldsENT.ReleTabId = objFeatureRegionFldsENS.ReleTabId; //相关表Id
objFeatureRegionFldsENT.ReleFldId = objFeatureRegionFldsENS.ReleFldId; //相关字段Id
objFeatureRegionFldsENT.EventFuncName = objFeatureRegionFldsENS.EventFuncName; //事件函数名
objFeatureRegionFldsENT.FieldTypeId = objFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objFeatureRegionFldsENT.ViewImplId = objFeatureRegionFldsENS.ViewImplId; //界面实现Id
objFeatureRegionFldsENT.CtlTypeId = objFeatureRegionFldsENS.CtlTypeId; //控件类型号
objFeatureRegionFldsENT.Height = objFeatureRegionFldsENS.Height; //高度
objFeatureRegionFldsENT.Width = objFeatureRegionFldsENS.Width; //宽
objFeatureRegionFldsENT.SeqNum = objFeatureRegionFldsENS.SeqNum; //字段序号
objFeatureRegionFldsENT.CssClass = objFeatureRegionFldsENS.CssClass; //样式表
objFeatureRegionFldsENT.ImageUrl = objFeatureRegionFldsENS.ImageUrl; //图片资源
objFeatureRegionFldsENT.InUse = objFeatureRegionFldsENS.InUse; //是否在用
objFeatureRegionFldsENT.ErrMsg = objFeatureRegionFldsENS.ErrMsg; //错误信息
objFeatureRegionFldsENT.PrjId = objFeatureRegionFldsENS.PrjId; //工程Id
objFeatureRegionFldsENT.UpdUser = objFeatureRegionFldsENS.UpdUser; //修改者
objFeatureRegionFldsENT.UpdDate = objFeatureRegionFldsENS.UpdDate; //修改日期
objFeatureRegionFldsENT.Memo = objFeatureRegionFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFeatureRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFeatureRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFeatureRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFeatureRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFeatureRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFeatureRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFeatureRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFeatureRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFeatureRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFeatureRegionFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFeatureRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFeatureRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFeatureRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFeatureRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFeatureRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFeatureRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsFeatureRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFeatureRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFeatureRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFeatureRegionFldsObjLstCache = CacheHelper.Get<List<clsFeatureRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFeatureRegionFldsObjLstCache = CacheHelper.Get<List<clsFeatureRegionFldsEN>>(strKey);
}
return arrFeatureRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFeatureRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFeatureRegionFlds.ViewFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.CheckTabFeature, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ButtonName4Mvc, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.CommandName, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.KeyIdGetModeId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.Text, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ReleTabId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ReleFldId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.EventFuncName, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ViewImplId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conFeatureRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conFeatureRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFeatureRegionFlds.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFeatureRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureRegionFlds.Memo, Type.GetType("System.String"));
foreach (clsFeatureRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFeatureRegionFlds.ViewFeatureId] = objInFor[conFeatureRegionFlds.ViewFeatureId];
objDR[conFeatureRegionFlds.RegionId] = objInFor[conFeatureRegionFlds.RegionId];
objDR[conFeatureRegionFlds.FeatureId] = objInFor[conFeatureRegionFlds.FeatureId];
objDR[conFeatureRegionFlds.TabFeatureId] = objInFor[conFeatureRegionFlds.TabFeatureId];
objDR[conFeatureRegionFlds.CheckTabFeature] = objInFor[conFeatureRegionFlds.CheckTabFeature];
objDR[conFeatureRegionFlds.FeatureDescription] = objInFor[conFeatureRegionFlds.FeatureDescription];
objDR[conFeatureRegionFlds.ButtonName] = objInFor[conFeatureRegionFlds.ButtonName];
objDR[conFeatureRegionFlds.ButtonName4Mvc] = objInFor[conFeatureRegionFlds.ButtonName4Mvc];
objDR[conFeatureRegionFlds.CommandName] = objInFor[conFeatureRegionFlds.CommandName];
objDR[conFeatureRegionFlds.ValueGivingModeId] = objInFor[conFeatureRegionFlds.ValueGivingModeId];
objDR[conFeatureRegionFlds.FuncName] = objInFor[conFeatureRegionFlds.FuncName];
objDR[conFeatureRegionFlds.DefaultValue] = objInFor[conFeatureRegionFlds.DefaultValue];
objDR[conFeatureRegionFlds.KeyIdGetModeId] = objInFor[conFeatureRegionFlds.KeyIdGetModeId];
objDR[conFeatureRegionFlds.Text] = objInFor[conFeatureRegionFlds.Text];
objDR[conFeatureRegionFlds.GroupName] = objInFor[conFeatureRegionFlds.GroupName];
objDR[conFeatureRegionFlds.ReleTabId] = objInFor[conFeatureRegionFlds.ReleTabId];
objDR[conFeatureRegionFlds.ReleFldId] = objInFor[conFeatureRegionFlds.ReleFldId];
objDR[conFeatureRegionFlds.EventFuncName] = objInFor[conFeatureRegionFlds.EventFuncName];
objDR[conFeatureRegionFlds.FieldTypeId] = objInFor[conFeatureRegionFlds.FieldTypeId];
objDR[conFeatureRegionFlds.ViewImplId] = objInFor[conFeatureRegionFlds.ViewImplId];
objDR[conFeatureRegionFlds.CtlTypeId] = objInFor[conFeatureRegionFlds.CtlTypeId];
objDR[conFeatureRegionFlds.Height] = objInFor[conFeatureRegionFlds.Height];
objDR[conFeatureRegionFlds.Width] = objInFor[conFeatureRegionFlds.Width];
objDR[conFeatureRegionFlds.SeqNum] = objInFor[conFeatureRegionFlds.SeqNum];
objDR[conFeatureRegionFlds.CssClass] = objInFor[conFeatureRegionFlds.CssClass];
objDR[conFeatureRegionFlds.ImageUrl] = objInFor[conFeatureRegionFlds.ImageUrl];
objDR[conFeatureRegionFlds.InUse] = objInFor[conFeatureRegionFlds.InUse];
objDR[conFeatureRegionFlds.ErrMsg] = objInFor[conFeatureRegionFlds.ErrMsg];
objDR[conFeatureRegionFlds.PrjId] = objInFor[conFeatureRegionFlds.PrjId];
objDR[conFeatureRegionFlds.UpdUser] = objInFor[conFeatureRegionFlds.UpdUser];
objDR[conFeatureRegionFlds.UpdDate] = objInFor[conFeatureRegionFlds.UpdDate];
objDR[conFeatureRegionFlds.Memo] = objInFor[conFeatureRegionFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能区域字段(FeatureRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FeatureRegionFlds : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strRegionId)
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
clsFeatureRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}