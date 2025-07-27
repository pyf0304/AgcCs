
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewFeatureFldsWApi
 表名:vViewFeatureFlds(00050454)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:21
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
public static class  clsvViewFeatureFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetmId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, long lngmId, string strComparisonOp="")
	{
objvViewFeatureFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.mId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.mId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.mId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFeatureId">界面功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetViewFeatureId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewFeatureId, convViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convViewFeatureFlds.ViewFeatureId);
objvViewFeatureFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ViewFeatureId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ViewFeatureId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ViewFeatureId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewFeatureFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewFeatureFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewFeatureFlds.RegionId);
objvViewFeatureFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.RegionId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.RegionId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.RegionId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewFeatureFlds.RegionName);
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewFeatureFlds.RegionName);
objvViewFeatureFldsEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.RegionName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.RegionName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.RegionName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewFeatureFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewFeatureFlds.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewFeatureFlds.RegionTypeId);
objvViewFeatureFldsEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.RegionTypeId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.RegionTypeId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.RegionTypeId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewFeatureFlds.RegionTypeName);
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewFeatureFlds.RegionTypeName);
objvViewFeatureFldsEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.RegionTypeName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.RegionTypeName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.RegionTypeName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFeatureId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convViewFeatureFlds.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convViewFeatureFlds.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convViewFeatureFlds.FeatureId);
objvViewFeatureFldsEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FeatureId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FeatureId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FeatureId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFeatureName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convViewFeatureFlds.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convViewFeatureFlds.FeatureName);
objvViewFeatureFldsEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FeatureName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FeatureName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FeatureName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetButtonName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strButtonName, 30, convViewFeatureFlds.ButtonName);
objvViewFeatureFldsEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ButtonName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ButtonName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ButtonName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetValueGivingModeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convViewFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convViewFeatureFlds.ValueGivingModeId);
objvViewFeatureFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ValueGivingModeId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetGroupName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 30, convViewFeatureFlds.GroupName);
objvViewFeatureFldsEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.GroupName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.GroupName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.GroupName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetReleTabId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strReleTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convViewFeatureFlds.ReleTabId);
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convViewFeatureFlds.ReleTabId);
objvViewFeatureFldsEN.ReleTabId = strReleTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ReleTabId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ReleTabId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ReleTabId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetSeqNum(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, int intSeqNum, string strComparisonOp="")
	{
objvViewFeatureFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.SeqNum) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.SeqNum, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.SeqNum] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabName">相关表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRelaTabName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRelaTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convViewFeatureFlds.RelaTabName);
objvViewFeatureFldsEN.RelaTabName = strRelaTabName; //相关表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.RelaTabName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.RelaTabName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.RelaTabName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleFldId">相关字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetReleFldId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strReleFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convViewFeatureFlds.ReleFldId);
objvViewFeatureFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ReleFldId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ReleFldId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ReleFldId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFieldTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convViewFeatureFlds.FieldTypeId);
objvViewFeatureFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FieldTypeId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FieldTypeId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FieldTypeId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFieldTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convViewFeatureFlds.FieldTypeName);
objvViewFeatureFldsEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FieldTypeName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FieldTypeName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FieldTypeName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFuncName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, convViewFeatureFlds.FuncName);
objvViewFeatureFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FuncName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FuncName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FuncName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetLabelCaption(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convViewFeatureFlds.LabelCaption);
objvViewFeatureFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.LabelCaption) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.LabelCaption, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.LabelCaption] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convViewFeatureFlds.CtlTypeId);
objvViewFeatureFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.CtlTypeId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.CtlTypeId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.CtlTypeId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convViewFeatureFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convViewFeatureFlds.CtlTypeName);
objvViewFeatureFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.CtlTypeName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.CtlTypeName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.CtlTypeName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlCnName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convViewFeatureFlds.CtlCnName);
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convViewFeatureFlds.CtlCnName);
objvViewFeatureFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.CtlCnName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.CtlCnName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.CtlCnName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeAbbr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convViewFeatureFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convViewFeatureFlds.CtlTypeAbbr);
objvViewFeatureFldsEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.CtlTypeAbbr) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.CtlTypeAbbr, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.CtlTypeAbbr] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, convViewFeatureFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convViewFeatureFlds.VarId);
objvViewFeatureFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarName">变量名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarName, 50, convViewFeatureFlds.VarName);
objvViewFeatureFldsEN.VarName = strVarName; //变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtrlId">控件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtrlId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtrlId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtrlId, 50, convViewFeatureFlds.CtrlId);
objvViewFeatureFldsEN.CtrlId = strCtrlId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.CtrlId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.CtrlId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.CtrlId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDefaultValue(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convViewFeatureFlds.DefaultValue);
objvViewFeatureFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DefaultValue) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DefaultValue, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DefaultValue] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetOrderNum(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, int intOrderNum, string strComparisonOp="")
	{
objvViewFeatureFldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.OrderNum) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.OrderNum, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.OrderNum] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDdlItemsOptionId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convViewFeatureFlds.DdlItemsOptionId);
objvViewFeatureFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DdlItemsOptionId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsTabId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabId, 8, convViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convViewFeatureFlds.DsTabId);
objvViewFeatureFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DsTabId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DsTabId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DsTabId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convViewFeatureFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convViewFeatureFlds.FldName);
objvViewFeatureFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FldName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FldName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FldName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsCondStr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convViewFeatureFlds.DsCondStr);
objvViewFeatureFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DsCondStr) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DsCondStr, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DsCondStr] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsSqlStr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convViewFeatureFlds.DsSqlStr);
objvViewFeatureFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DsSqlStr) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DsSqlStr, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DsSqlStr] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetItemsString(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strItemsString, 200, convViewFeatureFlds.ItemsString);
objvViewFeatureFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.ItemsString) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.ItemsString, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.ItemsString] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetInUse(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvViewFeatureFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.InUse) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.InUse, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.InUse] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetPrjId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewFeatureFlds.PrjId);
objvViewFeatureFldsEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.PrjId) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.PrjId, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.PrjId] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetUpdUser(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewFeatureFlds.UpdUser);
objvViewFeatureFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.UpdUser) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.UpdUser, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.UpdUser] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetUpdDate(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewFeatureFlds.UpdDate);
objvViewFeatureFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.UpdDate) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.UpdDate, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.UpdDate] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetMemo(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewFeatureFlds.Memo);
objvViewFeatureFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.Memo) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.Memo, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.Memo] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabName">数据源表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsTabName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabName, 100, convViewFeatureFlds.DsTabName);
objvViewFeatureFldsEN.DsTabName = strDsTabName; //数据源表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.DsTabName) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.DsTabName, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.DsTabName] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond1">字段Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, convViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, convViewFeatureFlds.FldIdCond1);
objvViewFeatureFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FldIdCond1) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FldIdCond1, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FldIdCond1] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond2">字段Id_条件2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, convViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, convViewFeatureFlds.FldIdCond2);
objvViewFeatureFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.FldIdCond2) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.FldIdCond2, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.FldIdCond2] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId4Ddl">下拉框表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetTabFeatureId4Ddl(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, convViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, convViewFeatureFlds.TabFeatureId4Ddl);
objvViewFeatureFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.TabFeatureId4Ddl) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond1">变量Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, convViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, convViewFeatureFlds.VarIdCond1);
objvViewFeatureFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarIdCond1) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarIdCond1, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarIdCond1] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond2">数据源字段_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, convViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, convViewFeatureFlds.VarIdCond2);
objvViewFeatureFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarIdCond2) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarIdCond2, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarIdCond2] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarTypeIdCond1">变量类型Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarTypeIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarTypeIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarTypeIdCond1, 4, convViewFeatureFlds.VarTypeIdCond1);
clsCheckSql.CheckFieldForeignKey(strVarTypeIdCond1, 4, convViewFeatureFlds.VarTypeIdCond1);
objvViewFeatureFldsEN.VarTypeIdCond1 = strVarTypeIdCond1; //变量类型Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarTypeIdCond1) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarTypeIdCond1, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarTypeIdCond1] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarTypeIdCond2">变量类型Id_条件2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarTypeIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarTypeIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarTypeIdCond2, 4, convViewFeatureFlds.VarTypeIdCond2);
clsCheckSql.CheckFieldForeignKey(strVarTypeIdCond2, 4, convViewFeatureFlds.VarTypeIdCond2);
objvViewFeatureFldsEN.VarTypeIdCond2 = strVarTypeIdCond2; //变量类型Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(convViewFeatureFlds.VarTypeIdCond2) == false)
{
objvViewFeatureFldsEN.dicFldComparisonOp.Add(convViewFeatureFlds.VarTypeIdCond2, strComparisonOp);
}
else
{
objvViewFeatureFldsEN.dicFldComparisonOp[convViewFeatureFlds.VarTypeIdCond2] = strComparisonOp;
}
}
return objvViewFeatureFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewFeatureFldsEN objvViewFeatureFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.mId) == true)
{
string strComparisonOpmId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewFeatureFlds.mId, objvViewFeatureFldsCond.mId, strComparisonOpmId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ViewFeatureId, objvViewFeatureFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.RegionId, objvViewFeatureFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.RegionName) == true)
{
string strComparisonOpRegionName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.RegionName, objvViewFeatureFldsCond.RegionName, strComparisonOpRegionName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.RegionTypeId, objvViewFeatureFldsCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.RegionTypeName, objvViewFeatureFldsCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FeatureId) == true)
{
string strComparisonOpFeatureId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FeatureId, objvViewFeatureFldsCond.FeatureId, strComparisonOpFeatureId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FeatureName) == true)
{
string strComparisonOpFeatureName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FeatureName, objvViewFeatureFldsCond.FeatureName, strComparisonOpFeatureName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ButtonName) == true)
{
string strComparisonOpButtonName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ButtonName, objvViewFeatureFldsCond.ButtonName, strComparisonOpButtonName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ValueGivingModeId, objvViewFeatureFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.GroupName) == true)
{
string strComparisonOpGroupName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.GroupName, objvViewFeatureFldsCond.GroupName, strComparisonOpGroupName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ReleTabId) == true)
{
string strComparisonOpReleTabId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ReleTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ReleTabId, objvViewFeatureFldsCond.ReleTabId, strComparisonOpReleTabId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewFeatureFlds.SeqNum, objvViewFeatureFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.RelaTabName) == true)
{
string strComparisonOpRelaTabName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.RelaTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.RelaTabName, objvViewFeatureFldsCond.RelaTabName, strComparisonOpRelaTabName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ReleFldId, objvViewFeatureFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FieldTypeId, objvViewFeatureFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FieldTypeName, objvViewFeatureFldsCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FuncName) == true)
{
string strComparisonOpFuncName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FuncName, objvViewFeatureFldsCond.FuncName, strComparisonOpFuncName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.LabelCaption, objvViewFeatureFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.CtlTypeId, objvViewFeatureFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.CtlTypeName, objvViewFeatureFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.CtlCnName, objvViewFeatureFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.CtlTypeAbbr, objvViewFeatureFldsCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarId) == true)
{
string strComparisonOpVarId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarId, objvViewFeatureFldsCond.VarId, strComparisonOpVarId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarName) == true)
{
string strComparisonOpVarName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarName, objvViewFeatureFldsCond.VarName, strComparisonOpVarName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.CtrlId) == true)
{
string strComparisonOpCtrlId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.CtrlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.CtrlId, objvViewFeatureFldsCond.CtrlId, strComparisonOpCtrlId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DefaultValue, objvViewFeatureFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.OrderNum) == true)
{
string strComparisonOpOrderNum = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewFeatureFlds.OrderNum, objvViewFeatureFldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DdlItemsOptionId, objvViewFeatureFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DsTabId, objvViewFeatureFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FldName) == true)
{
string strComparisonOpFldName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FldName, objvViewFeatureFldsCond.FldName, strComparisonOpFldName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DsCondStr, objvViewFeatureFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DsSqlStr, objvViewFeatureFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.ItemsString, objvViewFeatureFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.InUse) == true)
{
if (objvViewFeatureFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewFeatureFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewFeatureFlds.InUse);
}
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.PrjId, objvViewFeatureFldsCond.PrjId, strComparisonOpPrjId);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.UpdUser, objvViewFeatureFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.UpdDate, objvViewFeatureFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.Memo) == true)
{
string strComparisonOpMemo = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.Memo, objvViewFeatureFldsCond.Memo, strComparisonOpMemo);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.DsTabName) == true)
{
string strComparisonOpDsTabName = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.DsTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.DsTabName, objvViewFeatureFldsCond.DsTabName, strComparisonOpDsTabName);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FldIdCond1, objvViewFeatureFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.FldIdCond2, objvViewFeatureFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.TabFeatureId4Ddl, objvViewFeatureFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarIdCond1, objvViewFeatureFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarIdCond2, objvViewFeatureFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarTypeIdCond1) == true)
{
string strComparisonOpVarTypeIdCond1 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarTypeIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarTypeIdCond1, objvViewFeatureFldsCond.VarTypeIdCond1, strComparisonOpVarTypeIdCond1);
}
if (objvViewFeatureFldsCond.IsUpdated(convViewFeatureFlds.VarTypeIdCond2) == true)
{
string strComparisonOpVarTypeIdCond2 = objvViewFeatureFldsCond.dicFldComparisonOp[convViewFeatureFlds.VarTypeIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewFeatureFlds.VarTypeIdCond2, objvViewFeatureFldsCond.VarTypeIdCond2, strComparisonOpVarTypeIdCond2);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面功能字段(vViewFeatureFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewFeatureFldsWApi
{
private static readonly string mstrApiControllerName = "vViewFeatureFldsApi";

 public clsvViewFeatureFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewFeatureFldsEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvViewFeatureFldsEN objvViewFeatureFldsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewFeatureFldsEN = JsonConvert.DeserializeObject<clsvViewFeatureFldsEN>(strJson);
return objvViewFeatureFldsEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvViewFeatureFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewFeatureFldsEN objvViewFeatureFldsEN;
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
objvViewFeatureFldsEN = JsonConvert.DeserializeObject<clsvViewFeatureFldsEN>(strJson);
return objvViewFeatureFldsEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewFeatureFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewFeatureFldsEN._CurrTabName);
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLst_Sel =
from objvViewFeatureFldsEN in arrvViewFeatureFldsObjLstCache
where objvViewFeatureFldsEN.mId == lngmId 
select objvViewFeatureFldsEN;
if (arrvViewFeatureFldsObjLst_Sel.Count() == 0)
{
   clsvViewFeatureFldsEN obj = clsvViewFeatureFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewFeatureFldsEN._CurrTabName);
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLst_Sel =
from objvViewFeatureFldsEN in arrvViewFeatureFldsObjLstCache
where arrMId.Contains(objvViewFeatureFldsEN.mId)
select objvViewFeatureFldsEN;
return arrvViewFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
public static List<clsvViewFeatureFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
public static List<clsvViewFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
public static List<clsvViewFeatureFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewFeatureFldsEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvViewFeatureFldsENS">源对象</param>
 /// <param name = "objvViewFeatureFldsENT">目标对象</param>
 public static void CopyTo(clsvViewFeatureFldsEN objvViewFeatureFldsENS, clsvViewFeatureFldsEN objvViewFeatureFldsENT)
{
try
{
objvViewFeatureFldsENT.mId = objvViewFeatureFldsENS.mId; //mId
objvViewFeatureFldsENT.ViewFeatureId = objvViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objvViewFeatureFldsENT.RegionId = objvViewFeatureFldsENS.RegionId; //区域Id
objvViewFeatureFldsENT.RegionName = objvViewFeatureFldsENS.RegionName; //区域名称
objvViewFeatureFldsENT.RegionTypeId = objvViewFeatureFldsENS.RegionTypeId; //区域类型Id
objvViewFeatureFldsENT.RegionTypeName = objvViewFeatureFldsENS.RegionTypeName; //区域类型名称
objvViewFeatureFldsENT.FeatureId = objvViewFeatureFldsENS.FeatureId; //功能Id
objvViewFeatureFldsENT.FeatureName = objvViewFeatureFldsENS.FeatureName; //功能名称
objvViewFeatureFldsENT.ButtonName = objvViewFeatureFldsENS.ButtonName; //按钮名称
objvViewFeatureFldsENT.ValueGivingModeId = objvViewFeatureFldsENS.ValueGivingModeId; //给值方式Id
objvViewFeatureFldsENT.GroupName = objvViewFeatureFldsENS.GroupName; //组名
objvViewFeatureFldsENT.ReleTabId = objvViewFeatureFldsENS.ReleTabId; //相关表Id
objvViewFeatureFldsENT.SeqNum = objvViewFeatureFldsENS.SeqNum; //字段序号
objvViewFeatureFldsENT.RelaTabName = objvViewFeatureFldsENS.RelaTabName; //相关表名
objvViewFeatureFldsENT.ReleFldId = objvViewFeatureFldsENS.ReleFldId; //相关字段Id
objvViewFeatureFldsENT.FieldTypeId = objvViewFeatureFldsENS.FieldTypeId; //字段类型Id
objvViewFeatureFldsENT.FieldTypeName = objvViewFeatureFldsENS.FieldTypeName; //字段类型名
objvViewFeatureFldsENT.FuncName = objvViewFeatureFldsENS.FuncName; //函数名
objvViewFeatureFldsENT.LabelCaption = objvViewFeatureFldsENS.LabelCaption; //标签标题
objvViewFeatureFldsENT.CtlTypeId = objvViewFeatureFldsENS.CtlTypeId; //控件类型号
objvViewFeatureFldsENT.CtlTypeName = objvViewFeatureFldsENS.CtlTypeName; //控件类型名
objvViewFeatureFldsENT.CtlCnName = objvViewFeatureFldsENS.CtlCnName; //控件类型中文名
objvViewFeatureFldsENT.CtlTypeAbbr = objvViewFeatureFldsENS.CtlTypeAbbr; //控件类型缩写
objvViewFeatureFldsENT.VarId = objvViewFeatureFldsENS.VarId; //变量Id
objvViewFeatureFldsENT.VarName = objvViewFeatureFldsENS.VarName; //变量名
objvViewFeatureFldsENT.CtrlId = objvViewFeatureFldsENS.CtrlId; //控件Id
objvViewFeatureFldsENT.DefaultValue = objvViewFeatureFldsENS.DefaultValue; //缺省值
objvViewFeatureFldsENT.OrderNum = objvViewFeatureFldsENS.OrderNum; //序号
objvViewFeatureFldsENT.DdlItemsOptionId = objvViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvViewFeatureFldsENT.DsTabId = objvViewFeatureFldsENS.DsTabId; //数据源表ID
objvViewFeatureFldsENT.FldName = objvViewFeatureFldsENS.FldName; //字段名
objvViewFeatureFldsENT.DsCondStr = objvViewFeatureFldsENS.DsCondStr; //数据源条件串
objvViewFeatureFldsENT.DsSqlStr = objvViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objvViewFeatureFldsENT.ItemsString = objvViewFeatureFldsENS.ItemsString; //列表项串
objvViewFeatureFldsENT.InUse = objvViewFeatureFldsENS.InUse; //是否在用
objvViewFeatureFldsENT.PrjId = objvViewFeatureFldsENS.PrjId; //工程ID
objvViewFeatureFldsENT.UpdUser = objvViewFeatureFldsENS.UpdUser; //修改者
objvViewFeatureFldsENT.UpdDate = objvViewFeatureFldsENS.UpdDate; //修改日期
objvViewFeatureFldsENT.Memo = objvViewFeatureFldsENS.Memo; //说明
objvViewFeatureFldsENT.DsTabName = objvViewFeatureFldsENS.DsTabName; //数据源表
objvViewFeatureFldsENT.FldIdCond1 = objvViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objvViewFeatureFldsENT.FldIdCond2 = objvViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objvViewFeatureFldsENT.TabFeatureId4Ddl = objvViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objvViewFeatureFldsENT.VarIdCond1 = objvViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objvViewFeatureFldsENT.VarIdCond2 = objvViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objvViewFeatureFldsENT.VarTypeIdCond1 = objvViewFeatureFldsENS.VarTypeIdCond1; //变量类型Id_条件1
objvViewFeatureFldsENT.VarTypeIdCond2 = objvViewFeatureFldsENS.VarTypeIdCond2; //变量类型Id_条件2
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
public static DataTable ToDataTable(List<clsvViewFeatureFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewFeatureFldsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewFeatureFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewFeatureFldsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewFeatureFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewFeatureFldsEN.AttributeName)
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
string strKey = string.Format("{0}", clsvViewFeatureFldsEN._CurrTabName);
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
public static List<clsvViewFeatureFldsEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvViewFeatureFldsEN._CurrTabName;
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewFeatureFldsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewFeatureFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewFeatureFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewFeatureFlds.ViewFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.ReleTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewFeatureFlds.RelaTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.ReleFldId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.CtrlId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewFeatureFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewFeatureFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.DsTabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FldIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.FldIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.TabFeatureId4Ddl, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarTypeIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(convViewFeatureFlds.VarTypeIdCond2, Type.GetType("System.String"));
foreach (clsvViewFeatureFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewFeatureFlds.mId] = objInFor[convViewFeatureFlds.mId];
objDR[convViewFeatureFlds.ViewFeatureId] = objInFor[convViewFeatureFlds.ViewFeatureId];
objDR[convViewFeatureFlds.RegionId] = objInFor[convViewFeatureFlds.RegionId];
objDR[convViewFeatureFlds.RegionName] = objInFor[convViewFeatureFlds.RegionName];
objDR[convViewFeatureFlds.RegionTypeId] = objInFor[convViewFeatureFlds.RegionTypeId];
objDR[convViewFeatureFlds.RegionTypeName] = objInFor[convViewFeatureFlds.RegionTypeName];
objDR[convViewFeatureFlds.FeatureId] = objInFor[convViewFeatureFlds.FeatureId];
objDR[convViewFeatureFlds.FeatureName] = objInFor[convViewFeatureFlds.FeatureName];
objDR[convViewFeatureFlds.ButtonName] = objInFor[convViewFeatureFlds.ButtonName];
objDR[convViewFeatureFlds.ValueGivingModeId] = objInFor[convViewFeatureFlds.ValueGivingModeId];
objDR[convViewFeatureFlds.GroupName] = objInFor[convViewFeatureFlds.GroupName];
objDR[convViewFeatureFlds.ReleTabId] = objInFor[convViewFeatureFlds.ReleTabId];
objDR[convViewFeatureFlds.SeqNum] = objInFor[convViewFeatureFlds.SeqNum];
objDR[convViewFeatureFlds.RelaTabName] = objInFor[convViewFeatureFlds.RelaTabName];
objDR[convViewFeatureFlds.ReleFldId] = objInFor[convViewFeatureFlds.ReleFldId];
objDR[convViewFeatureFlds.FieldTypeId] = objInFor[convViewFeatureFlds.FieldTypeId];
objDR[convViewFeatureFlds.FieldTypeName] = objInFor[convViewFeatureFlds.FieldTypeName];
objDR[convViewFeatureFlds.FuncName] = objInFor[convViewFeatureFlds.FuncName];
objDR[convViewFeatureFlds.LabelCaption] = objInFor[convViewFeatureFlds.LabelCaption];
objDR[convViewFeatureFlds.CtlTypeId] = objInFor[convViewFeatureFlds.CtlTypeId];
objDR[convViewFeatureFlds.CtlTypeName] = objInFor[convViewFeatureFlds.CtlTypeName];
objDR[convViewFeatureFlds.CtlCnName] = objInFor[convViewFeatureFlds.CtlCnName];
objDR[convViewFeatureFlds.CtlTypeAbbr] = objInFor[convViewFeatureFlds.CtlTypeAbbr];
objDR[convViewFeatureFlds.VarId] = objInFor[convViewFeatureFlds.VarId];
objDR[convViewFeatureFlds.VarName] = objInFor[convViewFeatureFlds.VarName];
objDR[convViewFeatureFlds.CtrlId] = objInFor[convViewFeatureFlds.CtrlId];
objDR[convViewFeatureFlds.DefaultValue] = objInFor[convViewFeatureFlds.DefaultValue];
objDR[convViewFeatureFlds.OrderNum] = objInFor[convViewFeatureFlds.OrderNum];
objDR[convViewFeatureFlds.DdlItemsOptionId] = objInFor[convViewFeatureFlds.DdlItemsOptionId];
objDR[convViewFeatureFlds.DsTabId] = objInFor[convViewFeatureFlds.DsTabId];
objDR[convViewFeatureFlds.FldName] = objInFor[convViewFeatureFlds.FldName];
objDR[convViewFeatureFlds.DsCondStr] = objInFor[convViewFeatureFlds.DsCondStr];
objDR[convViewFeatureFlds.DsSqlStr] = objInFor[convViewFeatureFlds.DsSqlStr];
objDR[convViewFeatureFlds.ItemsString] = objInFor[convViewFeatureFlds.ItemsString];
objDR[convViewFeatureFlds.InUse] = objInFor[convViewFeatureFlds.InUse];
objDR[convViewFeatureFlds.PrjId] = objInFor[convViewFeatureFlds.PrjId];
objDR[convViewFeatureFlds.UpdUser] = objInFor[convViewFeatureFlds.UpdUser];
objDR[convViewFeatureFlds.UpdDate] = objInFor[convViewFeatureFlds.UpdDate];
objDR[convViewFeatureFlds.Memo] = objInFor[convViewFeatureFlds.Memo];
objDR[convViewFeatureFlds.DsTabName] = objInFor[convViewFeatureFlds.DsTabName];
objDR[convViewFeatureFlds.FldIdCond1] = objInFor[convViewFeatureFlds.FldIdCond1];
objDR[convViewFeatureFlds.FldIdCond2] = objInFor[convViewFeatureFlds.FldIdCond2];
objDR[convViewFeatureFlds.TabFeatureId4Ddl] = objInFor[convViewFeatureFlds.TabFeatureId4Ddl];
objDR[convViewFeatureFlds.VarIdCond1] = objInFor[convViewFeatureFlds.VarIdCond1];
objDR[convViewFeatureFlds.VarIdCond2] = objInFor[convViewFeatureFlds.VarIdCond2];
objDR[convViewFeatureFlds.VarTypeIdCond1] = objInFor[convViewFeatureFlds.VarTypeIdCond1];
objDR[convViewFeatureFlds.VarTypeIdCond2] = objInFor[convViewFeatureFlds.VarTypeIdCond2];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}