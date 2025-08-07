
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFldsBL
 表名:vFeatureRegionFlds(00050197)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:50
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
public static class  clsvFeatureRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFldsEN GetObj(this K_ViewFeatureId_vFeatureRegionFlds myKey)
{
clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = clsvFeatureRegionFldsBL.vFeatureRegionFldsDA.GetObjByViewFeatureId(myKey.Value);
return objvFeatureRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convFeatureRegionFlds.ViewFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convFeatureRegionFlds.ViewFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convFeatureRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convFeatureRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convFeatureRegionFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convFeatureRegionFlds.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convFeatureRegionFlds.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFeatureRegionFlds.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFeatureRegionFlds.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convFeatureRegionFlds.RegionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFeatureRegionFlds.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRegionTypeSimName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRegionTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convFeatureRegionFlds.RegionTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureRegionFlds.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureRegionFlds.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureRegionFlds.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureRegionFlds.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureRegionFlds.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetKeyWords(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureRegionFlds.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetTabFeatureId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convFeatureRegionFlds.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convFeatureRegionFlds.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetTabFeatureName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strTabFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convFeatureRegionFlds.TabFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCheckTabFeature(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCheckTabFeature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, convFeatureRegionFlds.CheckTabFeature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFeatureDescription(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureRegionFlds.FeatureDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetButtonName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureRegionFlds.ButtonName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureRegionFlds.ButtonName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetButtonName4Mvc(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, convFeatureRegionFlds.ButtonName4Mvc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, convFeatureRegionFlds.ButtonName4Mvc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetEventFuncName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strEventFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureRegionFlds.EventFuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetValueGivingModeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convFeatureRegionFlds.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convFeatureRegionFlds.ValueGivingModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetValueGivingModeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strValueGivingModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convFeatureRegionFlds.ValueGivingModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFuncName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureRegionFlds.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetDefaultValue(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFeatureRegionFlds.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetKeyIdGetModeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, convFeatureRegionFlds.KeyIdGetModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, convFeatureRegionFlds.KeyIdGetModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetText(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureRegionFlds.Text);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, convFeatureRegionFlds.Text);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetGroupName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convFeatureRegionFlds.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convFeatureRegionFlds.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetReleTabId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strReleTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convFeatureRegionFlds.ReleTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convFeatureRegionFlds.ReleTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetReleFldId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strReleFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convFeatureRegionFlds.ReleFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convFeatureRegionFlds.ReleFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFieldTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureRegionFlds.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureRegionFlds.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetFieldTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureRegionFlds.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewImplId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureRegionFlds.ViewImplId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureRegionFlds.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureRegionFlds.ViewImplId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetViewImplName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strViewImplName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureRegionFlds.ViewImplName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeId(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convFeatureRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convFeatureRegionFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convFeatureRegionFlds.CtlTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convFeatureRegionFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlCnName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convFeatureRegionFlds.CtlCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convFeatureRegionFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCtlTypeAbbr(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convFeatureRegionFlds.CtlTypeAbbr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convFeatureRegionFlds.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetHeight(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int? intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetWidth(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetSeqNum(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, int? intSeqNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetCssClass(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strCssClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCssClass, 50, convFeatureRegionFlds.CssClass);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetImageUrl(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convFeatureRegionFlds.ImageUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetUpdUser(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFeatureRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureRegionFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetUpdDate(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureRegionFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetMemo(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureRegionFlds.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRelaFldName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRelaFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convFeatureRegionFlds.RelaFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFldsEN SetRelaTabName(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN, string strRelaTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convFeatureRegionFlds.RelaTabName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsENS">源对象</param>
 /// <param name = "objvFeatureRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvFeatureRegionFldsEN objvFeatureRegionFldsENS, clsvFeatureRegionFldsEN objvFeatureRegionFldsENT)
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
 /// <param name = "objvFeatureRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureRegionFldsEN:objvFeatureRegionFldsENT</returns>
 public static clsvFeatureRegionFldsEN CopyTo(this clsvFeatureRegionFldsEN objvFeatureRegionFldsENS)
{
try
{
 clsvFeatureRegionFldsEN objvFeatureRegionFldsENT = new clsvFeatureRegionFldsEN()
{
ViewFeatureId = objvFeatureRegionFldsENS.ViewFeatureId, //界面功能Id
RegionId = objvFeatureRegionFldsENS.RegionId, //区域Id
RegionName = objvFeatureRegionFldsENS.RegionName, //区域名称
RegionTypeId = objvFeatureRegionFldsENS.RegionTypeId, //区域类型Id
RegionTypeName = objvFeatureRegionFldsENS.RegionTypeName, //区域类型名称
RegionTypeSimName = objvFeatureRegionFldsENS.RegionTypeSimName, //区域类型简名
FeatureId = objvFeatureRegionFldsENS.FeatureId, //功能Id
FeatureName = objvFeatureRegionFldsENS.FeatureName, //功能名称
KeyWords = objvFeatureRegionFldsENS.KeyWords, //关键字
TabFeatureId = objvFeatureRegionFldsENS.TabFeatureId, //表功能Id
TabFeatureName = objvFeatureRegionFldsENS.TabFeatureName, //表功能名
CheckTabFeature = objvFeatureRegionFldsENS.CheckTabFeature, //检查表功能
FeatureDescription = objvFeatureRegionFldsENS.FeatureDescription, //功能说明
ButtonName = objvFeatureRegionFldsENS.ButtonName, //按钮名称
ButtonName4Mvc = objvFeatureRegionFldsENS.ButtonName4Mvc, //按钮名称4Mvc
EventFuncName = objvFeatureRegionFldsENS.EventFuncName, //事件函数名
ValueGivingModeId = objvFeatureRegionFldsENS.ValueGivingModeId, //给值方式Id
ValueGivingModeName = objvFeatureRegionFldsENS.ValueGivingModeName, //给值方式名
FuncName = objvFeatureRegionFldsENS.FuncName, //函数名
DefaultValue = objvFeatureRegionFldsENS.DefaultValue, //缺省值
KeyIdGetModeId = objvFeatureRegionFldsENS.KeyIdGetModeId, //GC关键字获取方式Id
Text = objvFeatureRegionFldsENS.Text, //文本
GroupName = objvFeatureRegionFldsENS.GroupName, //组名
ReleTabId = objvFeatureRegionFldsENS.ReleTabId, //相关表Id
ReleFldId = objvFeatureRegionFldsENS.ReleFldId, //相关字段Id
FieldTypeId = objvFeatureRegionFldsENS.FieldTypeId, //字段类型Id
FieldTypeName = objvFeatureRegionFldsENS.FieldTypeName, //字段类型名
ViewImplId = objvFeatureRegionFldsENS.ViewImplId, //界面实现Id
ViewImplName = objvFeatureRegionFldsENS.ViewImplName, //界面实现名
CtlTypeId = objvFeatureRegionFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvFeatureRegionFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvFeatureRegionFldsENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvFeatureRegionFldsENS.CtlTypeAbbr, //控件类型缩写
Height = objvFeatureRegionFldsENS.Height, //高度
Width = objvFeatureRegionFldsENS.Width, //宽
SeqNum = objvFeatureRegionFldsENS.SeqNum, //字段序号
CssClass = objvFeatureRegionFldsENS.CssClass, //样式表
ImageUrl = objvFeatureRegionFldsENS.ImageUrl, //图片资源
InUse = objvFeatureRegionFldsENS.InUse, //是否在用
UpdUser = objvFeatureRegionFldsENS.UpdUser, //修改者
UpdDate = objvFeatureRegionFldsENS.UpdDate, //修改日期
Memo = objvFeatureRegionFldsENS.Memo, //说明
RelaFldName = objvFeatureRegionFldsENS.RelaFldName, //关系字段名
RelaTabName = objvFeatureRegionFldsENS.RelaTabName, //相关表名
PrjId = objvFeatureRegionFldsENS.PrjId, //工程ID
};
 return objvFeatureRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
 clsvFeatureRegionFldsBL.vFeatureRegionFldsDA.CheckProperty4Condition(objvFeatureRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureRegionFlds
{
public virtual bool UpdRelaTabDate(string strViewFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能区域字段(vFeatureRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureRegionFldsBL
{
public static RelatedActions_vFeatureRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureRegionFldsDA vFeatureRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvFeatureRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureRegionFldsDA.GetDataTable_vFeatureRegionFlds(strWhereCond);
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
objDT = vFeatureRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vFeatureRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureIdLst)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewFeatureIdLst, true);
 string strWhereCond = string.Format("ViewFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureRegionFldsEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst_Sel =
arrvFeatureRegionFldsObjLstCache
.Where(x => arrViewFeatureIdLst.Contains(x.ViewFeatureId));
return arrvFeatureRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
public static List<clsvFeatureRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureRegionFldsEN> GetSubObjLstCache(clsvFeatureRegionFldsEN objvFeatureRegionFldsCond)
{
 string strPrjId = objvFeatureRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFeatureRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFeatureRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureRegionFlds.AttributeName)
{
if (objvFeatureRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFldsCond[strFldName].ToString());
}
else
{
if (objvFeatureRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFldsCond[strFldName]));
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
List<clsvFeatureRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
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
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
public static List<clsvFeatureRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
public static List<clsvFeatureRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureRegionFlds(ref clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
bool bolResult = vFeatureRegionFldsDA.GetvFeatureRegionFlds(ref objvFeatureRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
if (strViewFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = vFeatureRegionFldsDA.GetObjByViewFeatureId(strViewFeatureId);
return objvFeatureRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = vFeatureRegionFldsDA.GetFirstObj(strWhereCond);
 return objvFeatureRegionFldsEN;
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
public static clsvFeatureRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = vFeatureRegionFldsDA.GetObjByDataRow(objRow);
 return objvFeatureRegionFldsEN;
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
public static clsvFeatureRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = vFeatureRegionFldsDA.GetObjByDataRow(objRow);
 return objvFeatureRegionFldsEN;
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
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <param name = "lstvFeatureRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureRegionFldsEN GetObjByViewFeatureIdFromList(string strViewFeatureId, List<clsvFeatureRegionFldsEN> lstvFeatureRegionFldsObjLst)
{
foreach (clsvFeatureRegionFldsEN objvFeatureRegionFldsEN in lstvFeatureRegionFldsObjLst)
{
if (objvFeatureRegionFldsEN.ViewFeatureId == strViewFeatureId)
{
return objvFeatureRegionFldsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxViewFeatureId;
 try
 {
 strMaxViewFeatureId = clsvFeatureRegionFldsDA.GetMaxStrId();
 return strMaxViewFeatureId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strViewFeatureId;
 try
 {
 strViewFeatureId = new clsvFeatureRegionFldsDA().GetFirstID(strWhereCond);
 return strViewFeatureId;
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
 arrList = vFeatureRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureRegionFldsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewFeatureId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFeatureRegionFldsDA.IsExist(strViewFeatureId);
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
 bolIsExist = clsvFeatureRegionFldsDA.IsExistTable();
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
 bolIsExist = vFeatureRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
try
{
objvFeatureRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureRegionFlds.ViewFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ViewFeatureId = objvFeatureRegionFldsEN.ViewFeatureId; //界面功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RegionId = objvFeatureRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RegionName = objvFeatureRegionFldsEN.RegionName == "[null]" ? null :  objvFeatureRegionFldsEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convFeatureRegionFlds.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RegionTypeId = objvFeatureRegionFldsEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RegionTypeName = objvFeatureRegionFldsEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convFeatureRegionFlds.RegionTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RegionTypeSimName = objvFeatureRegionFldsEN.RegionTypeSimName == "[null]" ? null :  objvFeatureRegionFldsEN.RegionTypeSimName; //区域类型简名
}
if (arrFldSet.Contains(convFeatureRegionFlds.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FeatureId = objvFeatureRegionFldsEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FeatureName = objvFeatureRegionFldsEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureRegionFlds.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.KeyWords = objvFeatureRegionFldsEN.KeyWords == "[null]" ? null :  objvFeatureRegionFldsEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFeatureRegionFlds.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.TabFeatureId = objvFeatureRegionFldsEN.TabFeatureId == "[null]" ? null :  objvFeatureRegionFldsEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.TabFeatureName = objvFeatureRegionFldsEN.TabFeatureName == "[null]" ? null :  objvFeatureRegionFldsEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(convFeatureRegionFlds.CheckTabFeature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CheckTabFeature = objvFeatureRegionFldsEN.CheckTabFeature == "[null]" ? null :  objvFeatureRegionFldsEN.CheckTabFeature; //检查表功能
}
if (arrFldSet.Contains(convFeatureRegionFlds.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FeatureDescription = objvFeatureRegionFldsEN.FeatureDescription == "[null]" ? null :  objvFeatureRegionFldsEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convFeatureRegionFlds.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ButtonName = objvFeatureRegionFldsEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(convFeatureRegionFlds.ButtonName4Mvc, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ButtonName4Mvc = objvFeatureRegionFldsEN.ButtonName4Mvc; //按钮名称4Mvc
}
if (arrFldSet.Contains(convFeatureRegionFlds.EventFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.EventFuncName = objvFeatureRegionFldsEN.EventFuncName == "[null]" ? null :  objvFeatureRegionFldsEN.EventFuncName; //事件函数名
}
if (arrFldSet.Contains(convFeatureRegionFlds.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ValueGivingModeId = objvFeatureRegionFldsEN.ValueGivingModeId == "[null]" ? null :  objvFeatureRegionFldsEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.ValueGivingModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ValueGivingModeName = objvFeatureRegionFldsEN.ValueGivingModeName == "[null]" ? null :  objvFeatureRegionFldsEN.ValueGivingModeName; //给值方式名
}
if (arrFldSet.Contains(convFeatureRegionFlds.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FuncName = objvFeatureRegionFldsEN.FuncName == "[null]" ? null :  objvFeatureRegionFldsEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFeatureRegionFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.DefaultValue = objvFeatureRegionFldsEN.DefaultValue == "[null]" ? null :  objvFeatureRegionFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convFeatureRegionFlds.KeyIdGetModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.KeyIdGetModeId = objvFeatureRegionFldsEN.KeyIdGetModeId == "[null]" ? null :  objvFeatureRegionFldsEN.KeyIdGetModeId; //GC关键字获取方式Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.Text = objvFeatureRegionFldsEN.Text; //文本
}
if (arrFldSet.Contains(convFeatureRegionFlds.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.GroupName = objvFeatureRegionFldsEN.GroupName; //组名
}
if (arrFldSet.Contains(convFeatureRegionFlds.ReleTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ReleTabId = objvFeatureRegionFldsEN.ReleTabId == "[null]" ? null :  objvFeatureRegionFldsEN.ReleTabId; //相关表Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.ReleFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ReleFldId = objvFeatureRegionFldsEN.ReleFldId == "[null]" ? null :  objvFeatureRegionFldsEN.ReleFldId; //相关字段Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FieldTypeId = objvFeatureRegionFldsEN.FieldTypeId == "[null]" ? null :  objvFeatureRegionFldsEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.FieldTypeName = objvFeatureRegionFldsEN.FieldTypeName == "[null]" ? null :  objvFeatureRegionFldsEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convFeatureRegionFlds.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ViewImplId = objvFeatureRegionFldsEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(convFeatureRegionFlds.ViewImplName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ViewImplName = objvFeatureRegionFldsEN.ViewImplName == "[null]" ? null :  objvFeatureRegionFldsEN.ViewImplName; //界面实现名
}
if (arrFldSet.Contains(convFeatureRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CtlTypeId = objvFeatureRegionFldsEN.CtlTypeId == "[null]" ? null :  objvFeatureRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convFeatureRegionFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CtlTypeName = objvFeatureRegionFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convFeatureRegionFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CtlCnName = objvFeatureRegionFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convFeatureRegionFlds.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CtlTypeAbbr = objvFeatureRegionFldsEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convFeatureRegionFlds.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.Height = objvFeatureRegionFldsEN.Height; //高度
}
if (arrFldSet.Contains(convFeatureRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.Width = objvFeatureRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(convFeatureRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.SeqNum = objvFeatureRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convFeatureRegionFlds.CssClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.CssClass = objvFeatureRegionFldsEN.CssClass == "[null]" ? null :  objvFeatureRegionFldsEN.CssClass; //样式表
}
if (arrFldSet.Contains(convFeatureRegionFlds.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.ImageUrl = objvFeatureRegionFldsEN.ImageUrl == "[null]" ? null :  objvFeatureRegionFldsEN.ImageUrl; //图片资源
}
if (arrFldSet.Contains(convFeatureRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.InUse = objvFeatureRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFeatureRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.UpdUser = objvFeatureRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.UpdDate = objvFeatureRegionFldsEN.UpdDate == "[null]" ? null :  objvFeatureRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.Memo = objvFeatureRegionFldsEN.Memo == "[null]" ? null :  objvFeatureRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convFeatureRegionFlds.RelaFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RelaFldName = objvFeatureRegionFldsEN.RelaFldName == "[null]" ? null :  objvFeatureRegionFldsEN.RelaFldName; //关系字段名
}
if (arrFldSet.Contains(convFeatureRegionFlds.RelaTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.RelaTabName = objvFeatureRegionFldsEN.RelaTabName == "[null]" ? null :  objvFeatureRegionFldsEN.RelaTabName; //相关表名
}
if (arrFldSet.Contains(convFeatureRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFldsEN.PrjId = objvFeatureRegionFldsEN.PrjId == "[null]" ? null :  objvFeatureRegionFldsEN.PrjId; //工程ID
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
 /// <param name = "objvFeatureRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
try
{
if (objvFeatureRegionFldsEN.RegionName == "[null]") objvFeatureRegionFldsEN.RegionName = null; //区域名称
if (objvFeatureRegionFldsEN.RegionTypeSimName == "[null]") objvFeatureRegionFldsEN.RegionTypeSimName = null; //区域类型简名
if (objvFeatureRegionFldsEN.KeyWords == "[null]") objvFeatureRegionFldsEN.KeyWords = null; //关键字
if (objvFeatureRegionFldsEN.TabFeatureId == "[null]") objvFeatureRegionFldsEN.TabFeatureId = null; //表功能Id
if (objvFeatureRegionFldsEN.TabFeatureName == "[null]") objvFeatureRegionFldsEN.TabFeatureName = null; //表功能名
if (objvFeatureRegionFldsEN.CheckTabFeature == "[null]") objvFeatureRegionFldsEN.CheckTabFeature = null; //检查表功能
if (objvFeatureRegionFldsEN.FeatureDescription == "[null]") objvFeatureRegionFldsEN.FeatureDescription = null; //功能说明
if (objvFeatureRegionFldsEN.EventFuncName == "[null]") objvFeatureRegionFldsEN.EventFuncName = null; //事件函数名
if (objvFeatureRegionFldsEN.ValueGivingModeId == "[null]") objvFeatureRegionFldsEN.ValueGivingModeId = null; //给值方式Id
if (objvFeatureRegionFldsEN.ValueGivingModeName == "[null]") objvFeatureRegionFldsEN.ValueGivingModeName = null; //给值方式名
if (objvFeatureRegionFldsEN.FuncName == "[null]") objvFeatureRegionFldsEN.FuncName = null; //函数名
if (objvFeatureRegionFldsEN.DefaultValue == "[null]") objvFeatureRegionFldsEN.DefaultValue = null; //缺省值
if (objvFeatureRegionFldsEN.KeyIdGetModeId == "[null]") objvFeatureRegionFldsEN.KeyIdGetModeId = null; //GC关键字获取方式Id
if (objvFeatureRegionFldsEN.ReleTabId == "[null]") objvFeatureRegionFldsEN.ReleTabId = null; //相关表Id
if (objvFeatureRegionFldsEN.ReleFldId == "[null]") objvFeatureRegionFldsEN.ReleFldId = null; //相关字段Id
if (objvFeatureRegionFldsEN.FieldTypeId == "[null]") objvFeatureRegionFldsEN.FieldTypeId = null; //字段类型Id
if (objvFeatureRegionFldsEN.FieldTypeName == "[null]") objvFeatureRegionFldsEN.FieldTypeName = null; //字段类型名
if (objvFeatureRegionFldsEN.ViewImplName == "[null]") objvFeatureRegionFldsEN.ViewImplName = null; //界面实现名
if (objvFeatureRegionFldsEN.CtlTypeId == "[null]") objvFeatureRegionFldsEN.CtlTypeId = null; //控件类型号
if (objvFeatureRegionFldsEN.CssClass == "[null]") objvFeatureRegionFldsEN.CssClass = null; //样式表
if (objvFeatureRegionFldsEN.ImageUrl == "[null]") objvFeatureRegionFldsEN.ImageUrl = null; //图片资源
if (objvFeatureRegionFldsEN.UpdDate == "[null]") objvFeatureRegionFldsEN.UpdDate = null; //修改日期
if (objvFeatureRegionFldsEN.Memo == "[null]") objvFeatureRegionFldsEN.Memo = null; //说明
if (objvFeatureRegionFldsEN.RelaFldName == "[null]") objvFeatureRegionFldsEN.RelaFldName = null; //关系字段名
if (objvFeatureRegionFldsEN.RelaTabName == "[null]") objvFeatureRegionFldsEN.RelaTabName = null; //相关表名
if (objvFeatureRegionFldsEN.PrjId == "[null]") objvFeatureRegionFldsEN.PrjId = null; //工程ID
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
public static void CheckProperty4Condition(clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
 vFeatureRegionFldsDA.CheckProperty4Condition(objvFeatureRegionFldsEN);
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
//string strWhereCond = string.Format("1 = 1 order by ViewFeatureId");
//if (arrvFeatureRegionFldsObjLstCache == null)
//{
//arrvFeatureRegionFldsObjLstCache = vFeatureRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureRegionFldsEN GetObjByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst_Sel =
arrvFeatureRegionFldsObjLstCache
.Where(x=> x.ViewFeatureId == strViewFeatureId 
);
if (arrvFeatureRegionFldsObjLst_Sel.Count() == 0)
{
   clsvFeatureRegionFldsEN obj = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFeatureRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetAllvFeatureRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvFeatureRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFeatureRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFldsEN._CurrTabName, strPrjId);
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
public static string Func(string strInFldName, string strOutFldName, string strViewFeatureId, string strPrjId)
{
if (strInFldName != convFeatureRegionFlds.ViewFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureRegionFlds.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureRegionFlds.AttributeName));
throw new Exception(strMsg);
}
var objvFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureIdCache(strViewFeatureId, strPrjId);
if (objvFeatureRegionFlds == null) return "";
return objvFeatureRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvFeatureRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureRegionFldsDA.GetRecCount();
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
int intRecCount = clsvFeatureRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureRegionFldsEN objvFeatureRegionFldsCond)
{
 string strPrjId = objvFeatureRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFeatureRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFeatureRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureRegionFlds.AttributeName)
{
if (objvFeatureRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFldsCond[strFldName].ToString());
}
else
{
if (objvFeatureRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvFeatureRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}