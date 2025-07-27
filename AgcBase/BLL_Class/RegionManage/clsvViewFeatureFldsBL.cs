
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewFeatureFldsBL
 表名:vViewFeatureFlds(00050454)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvViewFeatureFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewFeatureFldsEN GetObj(this K_mId_vViewFeatureFlds myKey)
{
clsvViewFeatureFldsEN objvViewFeatureFldsEN = clsvViewFeatureFldsBL.vViewFeatureFldsDA.GetObjBymId(myKey.Value);
return objvViewFeatureFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetViewFeatureId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewFeatureId, convViewFeatureFlds.ViewFeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convViewFeatureFlds.ViewFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convViewFeatureFlds.ViewFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewFeatureFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewFeatureFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewFeatureFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewFeatureFlds.RegionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewFeatureFlds.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewFeatureFlds.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewFeatureFlds.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewFeatureFlds.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRegionTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewFeatureFlds.RegionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewFeatureFlds.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFeatureId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convViewFeatureFlds.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convViewFeatureFlds.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convViewFeatureFlds.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFeatureName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convViewFeatureFlds.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convViewFeatureFlds.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetButtonName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strButtonName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, convViewFeatureFlds.ButtonName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetValueGivingModeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convViewFeatureFlds.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convViewFeatureFlds.ValueGivingModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetGroupName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convViewFeatureFlds.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetReleTabId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strReleTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convViewFeatureFlds.ReleTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convViewFeatureFlds.ReleTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetSeqNum(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, int? intSeqNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetRelaTabName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strRelaTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convViewFeatureFlds.RelaTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetReleFldId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strReleFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convViewFeatureFlds.ReleFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convViewFeatureFlds.ReleFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFieldTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convViewFeatureFlds.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convViewFeatureFlds.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFieldTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convViewFeatureFlds.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFuncName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convViewFeatureFlds.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetLabelCaption(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convViewFeatureFlds.LabelCaption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convViewFeatureFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convViewFeatureFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convViewFeatureFlds.CtlTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convViewFeatureFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlCnName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convViewFeatureFlds.CtlCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convViewFeatureFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtlTypeAbbr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convViewFeatureFlds.CtlTypeAbbr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convViewFeatureFlds.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, convViewFeatureFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convViewFeatureFlds.VarId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarName, 50, convViewFeatureFlds.VarName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetCtrlId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strCtrlId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtrlId, 50, convViewFeatureFlds.CtrlId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDefaultValue(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convViewFeatureFlds.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetOrderNum(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDdlItemsOptionId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convViewFeatureFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convViewFeatureFlds.DdlItemsOptionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsTabId(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, convViewFeatureFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convViewFeatureFlds.DsTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convViewFeatureFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convViewFeatureFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsCondStr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convViewFeatureFlds.DsCondStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsSqlStr(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convViewFeatureFlds.DsSqlStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetItemsString(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, convViewFeatureFlds.ItemsString);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetUpdUser(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewFeatureFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetUpdDate(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewFeatureFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetMemo(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewFeatureFlds.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetDsTabName(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strDsTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabName, 100, convViewFeatureFlds.DsTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, convViewFeatureFlds.FldIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, convViewFeatureFlds.FldIdCond1);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetFldIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, convViewFeatureFlds.FldIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, convViewFeatureFlds.FldIdCond2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetTabFeatureId4Ddl(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, convViewFeatureFlds.TabFeatureId4Ddl);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, convViewFeatureFlds.TabFeatureId4Ddl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, convViewFeatureFlds.VarIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, convViewFeatureFlds.VarIdCond1);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, convViewFeatureFlds.VarIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, convViewFeatureFlds.VarIdCond2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarTypeIdCond1(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarTypeIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeIdCond1, 4, convViewFeatureFlds.VarTypeIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarTypeIdCond1, 4, convViewFeatureFlds.VarTypeIdCond1);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewFeatureFldsEN SetVarTypeIdCond2(this clsvViewFeatureFldsEN objvViewFeatureFldsEN, string strVarTypeIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeIdCond2, 4, convViewFeatureFlds.VarTypeIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarTypeIdCond2, 4, convViewFeatureFlds.VarTypeIdCond2);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewFeatureFldsENS">源对象</param>
 /// <param name = "objvViewFeatureFldsENT">目标对象</param>
 public static void CopyTo(this clsvViewFeatureFldsEN objvViewFeatureFldsENS, clsvViewFeatureFldsEN objvViewFeatureFldsENT)
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
 /// <param name = "objvViewFeatureFldsENS">源对象</param>
 /// <returns>目标对象=>clsvViewFeatureFldsEN:objvViewFeatureFldsENT</returns>
 public static clsvViewFeatureFldsEN CopyTo(this clsvViewFeatureFldsEN objvViewFeatureFldsENS)
{
try
{
 clsvViewFeatureFldsEN objvViewFeatureFldsENT = new clsvViewFeatureFldsEN()
{
mId = objvViewFeatureFldsENS.mId, //mId
ViewFeatureId = objvViewFeatureFldsENS.ViewFeatureId, //界面功能Id
RegionId = objvViewFeatureFldsENS.RegionId, //区域Id
RegionName = objvViewFeatureFldsENS.RegionName, //区域名称
RegionTypeId = objvViewFeatureFldsENS.RegionTypeId, //区域类型Id
RegionTypeName = objvViewFeatureFldsENS.RegionTypeName, //区域类型名称
FeatureId = objvViewFeatureFldsENS.FeatureId, //功能Id
FeatureName = objvViewFeatureFldsENS.FeatureName, //功能名称
ButtonName = objvViewFeatureFldsENS.ButtonName, //按钮名称
ValueGivingModeId = objvViewFeatureFldsENS.ValueGivingModeId, //给值方式Id
GroupName = objvViewFeatureFldsENS.GroupName, //组名
ReleTabId = objvViewFeatureFldsENS.ReleTabId, //相关表Id
SeqNum = objvViewFeatureFldsENS.SeqNum, //字段序号
RelaTabName = objvViewFeatureFldsENS.RelaTabName, //相关表名
ReleFldId = objvViewFeatureFldsENS.ReleFldId, //相关字段Id
FieldTypeId = objvViewFeatureFldsENS.FieldTypeId, //字段类型Id
FieldTypeName = objvViewFeatureFldsENS.FieldTypeName, //字段类型名
FuncName = objvViewFeatureFldsENS.FuncName, //函数名
LabelCaption = objvViewFeatureFldsENS.LabelCaption, //标签标题
CtlTypeId = objvViewFeatureFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvViewFeatureFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvViewFeatureFldsENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvViewFeatureFldsENS.CtlTypeAbbr, //控件类型缩写
VarId = objvViewFeatureFldsENS.VarId, //变量Id
VarName = objvViewFeatureFldsENS.VarName, //变量名
CtrlId = objvViewFeatureFldsENS.CtrlId, //控件Id
DefaultValue = objvViewFeatureFldsENS.DefaultValue, //缺省值
OrderNum = objvViewFeatureFldsENS.OrderNum, //序号
DdlItemsOptionId = objvViewFeatureFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DsTabId = objvViewFeatureFldsENS.DsTabId, //数据源表ID
FldName = objvViewFeatureFldsENS.FldName, //字段名
DsCondStr = objvViewFeatureFldsENS.DsCondStr, //数据源条件串
DsSqlStr = objvViewFeatureFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objvViewFeatureFldsENS.ItemsString, //列表项串
InUse = objvViewFeatureFldsENS.InUse, //是否在用
PrjId = objvViewFeatureFldsENS.PrjId, //工程ID
UpdUser = objvViewFeatureFldsENS.UpdUser, //修改者
UpdDate = objvViewFeatureFldsENS.UpdDate, //修改日期
Memo = objvViewFeatureFldsENS.Memo, //说明
DsTabName = objvViewFeatureFldsENS.DsTabName, //数据源表
FldIdCond1 = objvViewFeatureFldsENS.FldIdCond1, //字段Id_条件1
FldIdCond2 = objvViewFeatureFldsENS.FldIdCond2, //字段Id_条件2
TabFeatureId4Ddl = objvViewFeatureFldsENS.TabFeatureId4Ddl, //下拉框表功能Id
VarIdCond1 = objvViewFeatureFldsENS.VarIdCond1, //变量Id_条件1
VarIdCond2 = objvViewFeatureFldsENS.VarIdCond2, //数据源字段_条件1
VarTypeIdCond1 = objvViewFeatureFldsENS.VarTypeIdCond1, //变量类型Id_条件1
VarTypeIdCond2 = objvViewFeatureFldsENS.VarTypeIdCond2, //变量类型Id_条件2
};
 return objvViewFeatureFldsENT;
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
public static void CheckProperty4Condition(this clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
 clsvViewFeatureFldsBL.vViewFeatureFldsDA.CheckProperty4Condition(objvViewFeatureFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewFeatureFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面功能字段(vViewFeatureFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewFeatureFldsBL
{
public static RelatedActions_vViewFeatureFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewFeatureFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewFeatureFldsDA vViewFeatureFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewFeatureFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewFeatureFldsBL()
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
if (string.IsNullOrEmpty(clsvViewFeatureFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewFeatureFldsEN._ConnectString);
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
public static DataTable GetDataTable_vViewFeatureFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewFeatureFldsDA.GetDataTable_vViewFeatureFlds(strWhereCond);
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
objDT = vViewFeatureFldsDA.GetDataTable(strWhereCond);
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
objDT = vViewFeatureFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewFeatureFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewFeatureFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewFeatureFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vViewFeatureFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLst_Sel =
arrvViewFeatureFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvViewFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLst(string strWhereCond)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
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
public static List<clsvViewFeatureFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewFeatureFldsEN> GetSubObjLstCache(clsvViewFeatureFldsEN objvViewFeatureFldsCond)
{
 string strPrjId = objvViewFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewFeatureFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewFeatureFlds.AttributeName)
{
if (objvViewFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objvViewFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewFeatureFldsCond[strFldName].ToString());
}
else
{
if (objvViewFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewFeatureFldsCond[strFldName]));
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
public static List<clsvViewFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
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
public static List<clsvViewFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
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
List<clsvViewFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
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
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
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
public static List<clsvViewFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
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
public static List<clsvViewFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewFeatureFlds(ref clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
bool bolResult = vViewFeatureFldsDA.GetvViewFeatureFlds(ref objvViewFeatureFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewFeatureFldsEN GetObjBymId(long lngmId)
{
clsvViewFeatureFldsEN objvViewFeatureFldsEN = vViewFeatureFldsDA.GetObjBymId(lngmId);
return objvViewFeatureFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewFeatureFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewFeatureFldsEN objvViewFeatureFldsEN = vViewFeatureFldsDA.GetFirstObj(strWhereCond);
 return objvViewFeatureFldsEN;
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
public static clsvViewFeatureFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewFeatureFldsEN objvViewFeatureFldsEN = vViewFeatureFldsDA.GetObjByDataRow(objRow);
 return objvViewFeatureFldsEN;
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
public static clsvViewFeatureFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewFeatureFldsEN objvViewFeatureFldsEN = vViewFeatureFldsDA.GetObjByDataRow(objRow);
 return objvViewFeatureFldsEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvViewFeatureFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewFeatureFldsEN GetObjBymIdFromList(long lngmId, List<clsvViewFeatureFldsEN> lstvViewFeatureFldsObjLst)
{
foreach (clsvViewFeatureFldsEN objvViewFeatureFldsEN in lstvViewFeatureFldsObjLst)
{
if (objvViewFeatureFldsEN.mId == lngmId)
{
return objvViewFeatureFldsEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvViewFeatureFldsDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vViewFeatureFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vViewFeatureFldsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vViewFeatureFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvViewFeatureFldsDA.IsExistTable();
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
 bolIsExist = vViewFeatureFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewFeatureFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
try
{
objvViewFeatureFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewFeatureFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewFeatureFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.mId = objvViewFeatureFldsEN.mId; //mId
}
if (arrFldSet.Contains(convViewFeatureFlds.ViewFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ViewFeatureId = objvViewFeatureFldsEN.ViewFeatureId; //界面功能Id
}
if (arrFldSet.Contains(convViewFeatureFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.RegionId = objvViewFeatureFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convViewFeatureFlds.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.RegionName = objvViewFeatureFldsEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convViewFeatureFlds.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.RegionTypeId = objvViewFeatureFldsEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convViewFeatureFlds.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.RegionTypeName = objvViewFeatureFldsEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convViewFeatureFlds.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FeatureId = objvViewFeatureFldsEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convViewFeatureFlds.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FeatureName = objvViewFeatureFldsEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convViewFeatureFlds.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ButtonName = objvViewFeatureFldsEN.ButtonName == "[null]" ? null :  objvViewFeatureFldsEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(convViewFeatureFlds.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ValueGivingModeId = objvViewFeatureFldsEN.ValueGivingModeId == "[null]" ? null :  objvViewFeatureFldsEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(convViewFeatureFlds.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.GroupName = objvViewFeatureFldsEN.GroupName == "[null]" ? null :  objvViewFeatureFldsEN.GroupName; //组名
}
if (arrFldSet.Contains(convViewFeatureFlds.ReleTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ReleTabId = objvViewFeatureFldsEN.ReleTabId == "[null]" ? null :  objvViewFeatureFldsEN.ReleTabId; //相关表Id
}
if (arrFldSet.Contains(convViewFeatureFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.SeqNum = objvViewFeatureFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convViewFeatureFlds.RelaTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.RelaTabName = objvViewFeatureFldsEN.RelaTabName == "[null]" ? null :  objvViewFeatureFldsEN.RelaTabName; //相关表名
}
if (arrFldSet.Contains(convViewFeatureFlds.ReleFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ReleFldId = objvViewFeatureFldsEN.ReleFldId == "[null]" ? null :  objvViewFeatureFldsEN.ReleFldId; //相关字段Id
}
if (arrFldSet.Contains(convViewFeatureFlds.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FieldTypeId = objvViewFeatureFldsEN.FieldTypeId == "[null]" ? null :  objvViewFeatureFldsEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convViewFeatureFlds.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FieldTypeName = objvViewFeatureFldsEN.FieldTypeName == "[null]" ? null :  objvViewFeatureFldsEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convViewFeatureFlds.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FuncName = objvViewFeatureFldsEN.FuncName == "[null]" ? null :  objvViewFeatureFldsEN.FuncName; //函数名
}
if (arrFldSet.Contains(convViewFeatureFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.LabelCaption = objvViewFeatureFldsEN.LabelCaption == "[null]" ? null :  objvViewFeatureFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(convViewFeatureFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.CtlTypeId = objvViewFeatureFldsEN.CtlTypeId == "[null]" ? null :  objvViewFeatureFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convViewFeatureFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.CtlTypeName = objvViewFeatureFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convViewFeatureFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.CtlCnName = objvViewFeatureFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convViewFeatureFlds.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.CtlTypeAbbr = objvViewFeatureFldsEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convViewFeatureFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarId = objvViewFeatureFldsEN.VarId == "[null]" ? null :  objvViewFeatureFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(convViewFeatureFlds.VarName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarName = objvViewFeatureFldsEN.VarName == "[null]" ? null :  objvViewFeatureFldsEN.VarName; //变量名
}
if (arrFldSet.Contains(convViewFeatureFlds.CtrlId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.CtrlId = objvViewFeatureFldsEN.CtrlId == "[null]" ? null :  objvViewFeatureFldsEN.CtrlId; //控件Id
}
if (arrFldSet.Contains(convViewFeatureFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DefaultValue = objvViewFeatureFldsEN.DefaultValue == "[null]" ? null :  objvViewFeatureFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convViewFeatureFlds.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.OrderNum = objvViewFeatureFldsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convViewFeatureFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DdlItemsOptionId = objvViewFeatureFldsEN.DdlItemsOptionId == "[null]" ? null :  objvViewFeatureFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(convViewFeatureFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DsTabId = objvViewFeatureFldsEN.DsTabId == "[null]" ? null :  objvViewFeatureFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(convViewFeatureFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FldName = objvViewFeatureFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convViewFeatureFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DsCondStr = objvViewFeatureFldsEN.DsCondStr == "[null]" ? null :  objvViewFeatureFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(convViewFeatureFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DsSqlStr = objvViewFeatureFldsEN.DsSqlStr == "[null]" ? null :  objvViewFeatureFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(convViewFeatureFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.ItemsString = objvViewFeatureFldsEN.ItemsString == "[null]" ? null :  objvViewFeatureFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(convViewFeatureFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.InUse = objvViewFeatureFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convViewFeatureFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.PrjId = objvViewFeatureFldsEN.PrjId == "[null]" ? null :  objvViewFeatureFldsEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convViewFeatureFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.UpdUser = objvViewFeatureFldsEN.UpdUser == "[null]" ? null :  objvViewFeatureFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convViewFeatureFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.UpdDate = objvViewFeatureFldsEN.UpdDate == "[null]" ? null :  objvViewFeatureFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewFeatureFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.Memo = objvViewFeatureFldsEN.Memo == "[null]" ? null :  objvViewFeatureFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convViewFeatureFlds.DsTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.DsTabName = objvViewFeatureFldsEN.DsTabName == "[null]" ? null :  objvViewFeatureFldsEN.DsTabName; //数据源表
}
if (arrFldSet.Contains(convViewFeatureFlds.FldIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FldIdCond1 = objvViewFeatureFldsEN.FldIdCond1 == "[null]" ? null :  objvViewFeatureFldsEN.FldIdCond1; //字段Id_条件1
}
if (arrFldSet.Contains(convViewFeatureFlds.FldIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.FldIdCond2 = objvViewFeatureFldsEN.FldIdCond2 == "[null]" ? null :  objvViewFeatureFldsEN.FldIdCond2; //字段Id_条件2
}
if (arrFldSet.Contains(convViewFeatureFlds.TabFeatureId4Ddl, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.TabFeatureId4Ddl = objvViewFeatureFldsEN.TabFeatureId4Ddl == "[null]" ? null :  objvViewFeatureFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
}
if (arrFldSet.Contains(convViewFeatureFlds.VarIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarIdCond1 = objvViewFeatureFldsEN.VarIdCond1 == "[null]" ? null :  objvViewFeatureFldsEN.VarIdCond1; //变量Id_条件1
}
if (arrFldSet.Contains(convViewFeatureFlds.VarIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarIdCond2 = objvViewFeatureFldsEN.VarIdCond2 == "[null]" ? null :  objvViewFeatureFldsEN.VarIdCond2; //数据源字段_条件1
}
if (arrFldSet.Contains(convViewFeatureFlds.VarTypeIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarTypeIdCond1 = objvViewFeatureFldsEN.VarTypeIdCond1 == "[null]" ? null :  objvViewFeatureFldsEN.VarTypeIdCond1; //变量类型Id_条件1
}
if (arrFldSet.Contains(convViewFeatureFlds.VarTypeIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewFeatureFldsEN.VarTypeIdCond2 = objvViewFeatureFldsEN.VarTypeIdCond2 == "[null]" ? null :  objvViewFeatureFldsEN.VarTypeIdCond2; //变量类型Id_条件2
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
 /// <param name = "objvViewFeatureFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
try
{
if (objvViewFeatureFldsEN.ButtonName == "[null]") objvViewFeatureFldsEN.ButtonName = null; //按钮名称
if (objvViewFeatureFldsEN.ValueGivingModeId == "[null]") objvViewFeatureFldsEN.ValueGivingModeId = null; //给值方式Id
if (objvViewFeatureFldsEN.GroupName == "[null]") objvViewFeatureFldsEN.GroupName = null; //组名
if (objvViewFeatureFldsEN.ReleTabId == "[null]") objvViewFeatureFldsEN.ReleTabId = null; //相关表Id
if (objvViewFeatureFldsEN.RelaTabName == "[null]") objvViewFeatureFldsEN.RelaTabName = null; //相关表名
if (objvViewFeatureFldsEN.ReleFldId == "[null]") objvViewFeatureFldsEN.ReleFldId = null; //相关字段Id
if (objvViewFeatureFldsEN.FieldTypeId == "[null]") objvViewFeatureFldsEN.FieldTypeId = null; //字段类型Id
if (objvViewFeatureFldsEN.FieldTypeName == "[null]") objvViewFeatureFldsEN.FieldTypeName = null; //字段类型名
if (objvViewFeatureFldsEN.FuncName == "[null]") objvViewFeatureFldsEN.FuncName = null; //函数名
if (objvViewFeatureFldsEN.LabelCaption == "[null]") objvViewFeatureFldsEN.LabelCaption = null; //标签标题
if (objvViewFeatureFldsEN.CtlTypeId == "[null]") objvViewFeatureFldsEN.CtlTypeId = null; //控件类型号
if (objvViewFeatureFldsEN.VarId == "[null]") objvViewFeatureFldsEN.VarId = null; //变量Id
if (objvViewFeatureFldsEN.VarName == "[null]") objvViewFeatureFldsEN.VarName = null; //变量名
if (objvViewFeatureFldsEN.CtrlId == "[null]") objvViewFeatureFldsEN.CtrlId = null; //控件Id
if (objvViewFeatureFldsEN.DefaultValue == "[null]") objvViewFeatureFldsEN.DefaultValue = null; //缺省值
if (objvViewFeatureFldsEN.DdlItemsOptionId == "[null]") objvViewFeatureFldsEN.DdlItemsOptionId = null; //下拉框列表选项ID
if (objvViewFeatureFldsEN.DsTabId == "[null]") objvViewFeatureFldsEN.DsTabId = null; //数据源表ID
if (objvViewFeatureFldsEN.DsCondStr == "[null]") objvViewFeatureFldsEN.DsCondStr = null; //数据源条件串
if (objvViewFeatureFldsEN.DsSqlStr == "[null]") objvViewFeatureFldsEN.DsSqlStr = null; //数据源SQL串
if (objvViewFeatureFldsEN.ItemsString == "[null]") objvViewFeatureFldsEN.ItemsString = null; //列表项串
if (objvViewFeatureFldsEN.PrjId == "[null]") objvViewFeatureFldsEN.PrjId = null; //工程ID
if (objvViewFeatureFldsEN.UpdUser == "[null]") objvViewFeatureFldsEN.UpdUser = null; //修改者
if (objvViewFeatureFldsEN.UpdDate == "[null]") objvViewFeatureFldsEN.UpdDate = null; //修改日期
if (objvViewFeatureFldsEN.Memo == "[null]") objvViewFeatureFldsEN.Memo = null; //说明
if (objvViewFeatureFldsEN.DsTabName == "[null]") objvViewFeatureFldsEN.DsTabName = null; //数据源表
if (objvViewFeatureFldsEN.FldIdCond1 == "[null]") objvViewFeatureFldsEN.FldIdCond1 = null; //字段Id_条件1
if (objvViewFeatureFldsEN.FldIdCond2 == "[null]") objvViewFeatureFldsEN.FldIdCond2 = null; //字段Id_条件2
if (objvViewFeatureFldsEN.TabFeatureId4Ddl == "[null]") objvViewFeatureFldsEN.TabFeatureId4Ddl = null; //下拉框表功能Id
if (objvViewFeatureFldsEN.VarIdCond1 == "[null]") objvViewFeatureFldsEN.VarIdCond1 = null; //变量Id_条件1
if (objvViewFeatureFldsEN.VarIdCond2 == "[null]") objvViewFeatureFldsEN.VarIdCond2 = null; //数据源字段_条件1
if (objvViewFeatureFldsEN.VarTypeIdCond1 == "[null]") objvViewFeatureFldsEN.VarTypeIdCond1 = null; //变量类型Id_条件1
if (objvViewFeatureFldsEN.VarTypeIdCond2 == "[null]") objvViewFeatureFldsEN.VarTypeIdCond2 = null; //变量类型Id_条件2
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
public static void CheckProperty4Condition(clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
 vViewFeatureFldsDA.CheckProperty4Condition(objvViewFeatureFldsEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCtlTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCtlTypeBL没有刷新缓存机制(clsCtlTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewFeatureFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewFeatureFldsBL没有刷新缓存机制(clsViewFeatureFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGCVariableBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVariableBL没有刷新缓存机制(clsGCVariableBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewImplementationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewImplementationBL没有刷新缓存机制(clsViewImplementationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFeatureRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureRegionFldsBL没有刷新缓存机制(clsFeatureRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsValueGivingModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsValueGivingModeBL没有刷新缓存机制(clsValueGivingModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureBL没有刷新缓存机制(clsTabFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRegionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionBL没有刷新缓存机制(clsViewRegionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPageDispModeBL没有刷新缓存机制(clsPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGCContainerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCContainerTypeBL没有刷新缓存机制(clsGCContainerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvViewFeatureFldsObjLstCache == null)
//{
//arrvViewFeatureFldsObjLstCache = vViewFeatureFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewFeatureFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLst_Sel =
arrvViewFeatureFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvViewFeatureFldsObjLst_Sel.Count() == 0)
{
   clsvViewFeatureFldsEN obj = clsvViewFeatureFldsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetAllvViewFeatureFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewFeatureFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewFeatureFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewFeatureFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewFeatureFldsEN._CurrTabName, strPrjId);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-01-26
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convViewFeatureFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewFeatureFlds.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewFeatureFlds.AttributeName));
throw new Exception(strMsg);
}
var objvViewFeatureFlds = clsvViewFeatureFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvViewFeatureFlds == null) return "";
return objvViewFeatureFlds[strOutFldName].ToString();
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
int intRecCount = clsvViewFeatureFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewFeatureFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewFeatureFldsDA.GetRecCount();
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
int intRecCount = clsvViewFeatureFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewFeatureFldsEN objvViewFeatureFldsCond)
{
 string strPrjId = objvViewFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewFeatureFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewFeatureFlds.AttributeName)
{
if (objvViewFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objvViewFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewFeatureFldsCond[strFldName].ToString());
}
else
{
if (objvViewFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewFeatureFldsCond[strFldName]));
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
 List<string> arrList = clsvViewFeatureFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewFeatureFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewFeatureFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}