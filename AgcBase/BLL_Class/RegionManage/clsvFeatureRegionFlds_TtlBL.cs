
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFlds_TtlBL
 表名:vFeatureRegionFlds_Ttl(00050474)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:45
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
public static class  clsvFeatureRegionFlds_TtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetObj(this K_ViewFeatureId_vFeatureRegionFlds_Ttl myKey)
{
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = clsvFeatureRegionFlds_TtlBL.vFeatureRegionFlds_TtlDA.GetObjByViewFeatureId(myKey.Value);
return objvFeatureRegionFlds_TtlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, convFeatureRegionFlds_Ttl.ViewFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, convFeatureRegionFlds_Ttl.ViewFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convFeatureRegionFlds_Ttl.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convFeatureRegionFlds_Ttl.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convFeatureRegionFlds_Ttl.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convFeatureRegionFlds_Ttl.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFeatureRegionFlds_Ttl.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFeatureRegionFlds_Ttl.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRegionTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFeatureRegionFlds_Ttl.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureRegionFlds_Ttl.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureRegionFlds_Ttl.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureRegionFlds_Ttl.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureRegionFlds_Ttl.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetKeyWords(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureRegionFlds_Ttl.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetTabFeatureId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convFeatureRegionFlds_Ttl.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convFeatureRegionFlds_Ttl.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetTabFeatureName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strTabFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convFeatureRegionFlds_Ttl.TabFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCheckTabFeature(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCheckTabFeature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, convFeatureRegionFlds_Ttl.CheckTabFeature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFeatureDescription(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureRegionFlds_Ttl.FeatureDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetButtonName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureRegionFlds_Ttl.ButtonName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureRegionFlds_Ttl.ButtonName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetButtonName4Mvc(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetEventFuncName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strEventFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureRegionFlds_Ttl.EventFuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetValueGivingModeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strValueGivingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convFeatureRegionFlds_Ttl.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convFeatureRegionFlds_Ttl.ValueGivingModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetValueGivingModeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strValueGivingModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convFeatureRegionFlds_Ttl.ValueGivingModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFuncName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureRegionFlds_Ttl.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetDefaultValue(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFeatureRegionFlds_Ttl.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetText(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureRegionFlds_Ttl.Text);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, convFeatureRegionFlds_Ttl.Text);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetGroupName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convFeatureRegionFlds_Ttl.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convFeatureRegionFlds_Ttl.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetReleTabId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strReleTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleTabId, 8, convFeatureRegionFlds_Ttl.ReleTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, convFeatureRegionFlds_Ttl.ReleTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetReleFldId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strReleFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleFldId, 8, convFeatureRegionFlds_Ttl.ReleFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, convFeatureRegionFlds_Ttl.ReleFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFieldTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureRegionFlds_Ttl.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureRegionFlds_Ttl.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFieldTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureRegionFlds_Ttl.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewImplId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureRegionFlds_Ttl.ViewImplId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureRegionFlds_Ttl.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureRegionFlds_Ttl.ViewImplId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetViewImplName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strViewImplName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureRegionFlds_Ttl.ViewImplName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeId(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convFeatureRegionFlds_Ttl.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convFeatureRegionFlds_Ttl.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convFeatureRegionFlds_Ttl.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlCnName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convFeatureRegionFlds_Ttl.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCtlTypeAbbr(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convFeatureRegionFlds_Ttl.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetHeight(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int? intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetWidth(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetSeqNum(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int? intSeqNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetCssClass(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strCssClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCssClass, 50, convFeatureRegionFlds_Ttl.CssClass);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetImageUrl(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convFeatureRegionFlds_Ttl.ImageUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetUpdUser(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFeatureRegionFlds_Ttl.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureRegionFlds_Ttl.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetUpdDate(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureRegionFlds_Ttl.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetMemo(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureRegionFlds_Ttl.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetFldNum(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, int? intFldNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRelaFldName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRelaFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convFeatureRegionFlds_Ttl.RelaFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureRegionFlds_TtlEN SetRelaTabName(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN, string strRelaTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabName, 100, convFeatureRegionFlds_Ttl.RelaTabName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <param name = "objvFeatureRegionFlds_TtlENT">目标对象</param>
 public static void CopyTo(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENS, clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENT)
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
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureRegionFlds_TtlEN:objvFeatureRegionFlds_TtlENT</returns>
 public static clsvFeatureRegionFlds_TtlEN CopyTo(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENS)
{
try
{
 clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENT = new clsvFeatureRegionFlds_TtlEN()
{
ViewFeatureId = objvFeatureRegionFlds_TtlENS.ViewFeatureId, //界面功能Id
RegionId = objvFeatureRegionFlds_TtlENS.RegionId, //区域Id
RegionName = objvFeatureRegionFlds_TtlENS.RegionName, //区域名称
RegionTypeId = objvFeatureRegionFlds_TtlENS.RegionTypeId, //区域类型Id
RegionTypeName = objvFeatureRegionFlds_TtlENS.RegionTypeName, //区域类型名称
FeatureId = objvFeatureRegionFlds_TtlENS.FeatureId, //功能Id
FeatureName = objvFeatureRegionFlds_TtlENS.FeatureName, //功能名称
KeyWords = objvFeatureRegionFlds_TtlENS.KeyWords, //关键字
TabFeatureId = objvFeatureRegionFlds_TtlENS.TabFeatureId, //表功能Id
TabFeatureName = objvFeatureRegionFlds_TtlENS.TabFeatureName, //表功能名
CheckTabFeature = objvFeatureRegionFlds_TtlENS.CheckTabFeature, //检查表功能
FeatureDescription = objvFeatureRegionFlds_TtlENS.FeatureDescription, //功能说明
ButtonName = objvFeatureRegionFlds_TtlENS.ButtonName, //按钮名称
ButtonName4Mvc = objvFeatureRegionFlds_TtlENS.ButtonName4Mvc, //按钮名称4Mvc
EventFuncName = objvFeatureRegionFlds_TtlENS.EventFuncName, //事件函数名
ValueGivingModeId = objvFeatureRegionFlds_TtlENS.ValueGivingModeId, //给值方式Id
ValueGivingModeName = objvFeatureRegionFlds_TtlENS.ValueGivingModeName, //给值方式名
FuncName = objvFeatureRegionFlds_TtlENS.FuncName, //函数名
DefaultValue = objvFeatureRegionFlds_TtlENS.DefaultValue, //缺省值
Text = objvFeatureRegionFlds_TtlENS.Text, //文本
GroupName = objvFeatureRegionFlds_TtlENS.GroupName, //组名
ReleTabId = objvFeatureRegionFlds_TtlENS.ReleTabId, //相关表Id
ReleFldId = objvFeatureRegionFlds_TtlENS.ReleFldId, //相关字段Id
FieldTypeId = objvFeatureRegionFlds_TtlENS.FieldTypeId, //字段类型Id
FieldTypeName = objvFeatureRegionFlds_TtlENS.FieldTypeName, //字段类型名
ViewImplId = objvFeatureRegionFlds_TtlENS.ViewImplId, //界面实现Id
ViewImplName = objvFeatureRegionFlds_TtlENS.ViewImplName, //界面实现名
CtlTypeId = objvFeatureRegionFlds_TtlENS.CtlTypeId, //控件类型号
CtlTypeName = objvFeatureRegionFlds_TtlENS.CtlTypeName, //控件类型名
CtlCnName = objvFeatureRegionFlds_TtlENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvFeatureRegionFlds_TtlENS.CtlTypeAbbr, //控件类型缩写
Height = objvFeatureRegionFlds_TtlENS.Height, //高度
Width = objvFeatureRegionFlds_TtlENS.Width, //宽
SeqNum = objvFeatureRegionFlds_TtlENS.SeqNum, //字段序号
CssClass = objvFeatureRegionFlds_TtlENS.CssClass, //样式表
ImageUrl = objvFeatureRegionFlds_TtlENS.ImageUrl, //图片资源
InUse = objvFeatureRegionFlds_TtlENS.InUse, //是否在用
UpdUser = objvFeatureRegionFlds_TtlENS.UpdUser, //修改者
UpdDate = objvFeatureRegionFlds_TtlENS.UpdDate, //修改日期
Memo = objvFeatureRegionFlds_TtlENS.Memo, //说明
FldNum = objvFeatureRegionFlds_TtlENS.FldNum, //字段数
RelaFldName = objvFeatureRegionFlds_TtlENS.RelaFldName, //关系字段名
RelaTabName = objvFeatureRegionFlds_TtlENS.RelaTabName, //相关表名
PrjId = objvFeatureRegionFlds_TtlENS.PrjId, //工程ID
};
 return objvFeatureRegionFlds_TtlENT;
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
public static void CheckProperty4Condition(this clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
 clsvFeatureRegionFlds_TtlBL.vFeatureRegionFlds_TtlDA.CheckProperty4Condition(objvFeatureRegionFlds_TtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureRegionFlds_Ttl
{
public virtual bool UpdRelaTabDate(string strViewFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能区域字段_Ttl(vFeatureRegionFlds_Ttl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureRegionFlds_TtlBL
{
public static RelatedActions_vFeatureRegionFlds_Ttl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureRegionFlds_TtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureRegionFlds_TtlDA vFeatureRegionFlds_TtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureRegionFlds_TtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureRegionFlds_TtlBL()
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
if (string.IsNullOrEmpty(clsvFeatureRegionFlds_TtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureRegionFlds_TtlEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureRegionFlds_Ttl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureRegionFlds_TtlDA.GetDataTable_vFeatureRegionFlds_Ttl(strWhereCond);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable(strWhereCond);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureRegionFlds_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureIdLst)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
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
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureRegionFlds_TtlEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFlds_TtlEN._CurrTabName, strPrjId);
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLst_Sel =
arrvFeatureRegionFlds_TtlObjLstCache
.Where(x => arrViewFeatureIdLst.Contains(x.ViewFeatureId));
return arrvFeatureRegionFlds_TtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureRegionFlds_TtlEN> GetSubObjLstCache(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlCond)
{
 string strPrjId = objvFeatureRegionFlds_TtlCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFeatureRegionFlds_TtlBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFeatureRegionFlds_TtlEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureRegionFlds_Ttl.AttributeName)
{
if (objvFeatureRegionFlds_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureRegionFlds_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFlds_TtlCond[strFldName].ToString());
}
else
{
if (objvFeatureRegionFlds_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFlds_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureRegionFlds_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFlds_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFlds_TtlCond[strFldName]));
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureRegionFlds_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
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
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureRegionFlds_TtlEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureRegionFlds_Ttl(ref clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
bool bolResult = vFeatureRegionFlds_TtlDA.GetvFeatureRegionFlds_Ttl(ref objvFeatureRegionFlds_TtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureId(string strViewFeatureId)
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
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = vFeatureRegionFlds_TtlDA.GetObjByViewFeatureId(strViewFeatureId);
return objvFeatureRegionFlds_TtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = vFeatureRegionFlds_TtlDA.GetFirstObj(strWhereCond);
 return objvFeatureRegionFlds_TtlEN;
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
public static clsvFeatureRegionFlds_TtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = vFeatureRegionFlds_TtlDA.GetObjByDataRow(objRow);
 return objvFeatureRegionFlds_TtlEN;
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
public static clsvFeatureRegionFlds_TtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = vFeatureRegionFlds_TtlDA.GetObjByDataRow(objRow);
 return objvFeatureRegionFlds_TtlEN;
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
 /// <param name = "lstvFeatureRegionFlds_TtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureIdFromList(string strViewFeatureId, List<clsvFeatureRegionFlds_TtlEN> lstvFeatureRegionFlds_TtlObjLst)
{
foreach (clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN in lstvFeatureRegionFlds_TtlObjLst)
{
if (objvFeatureRegionFlds_TtlEN.ViewFeatureId == strViewFeatureId)
{
return objvFeatureRegionFlds_TtlEN;
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
 strMaxViewFeatureId = clsvFeatureRegionFlds_TtlDA.GetMaxStrId();
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
 strViewFeatureId = new clsvFeatureRegionFlds_TtlDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureRegionFlds_TtlDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureRegionFlds_TtlDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureRegionFlds_TtlDA.IsExist(strViewFeatureId);
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
 bolIsExist = clsvFeatureRegionFlds_TtlDA.IsExistTable();
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
 bolIsExist = vFeatureRegionFlds_TtlDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureRegionFlds_TtlEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
try
{
objvFeatureRegionFlds_TtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureRegionFlds_TtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ViewFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objvFeatureRegionFlds_TtlEN.ViewFeatureId; //界面功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RegionId = objvFeatureRegionFlds_TtlEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RegionName = objvFeatureRegionFlds_TtlEN.RegionName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RegionTypeId = objvFeatureRegionFlds_TtlEN.RegionTypeId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RegionTypeName = objvFeatureRegionFlds_TtlEN.RegionTypeName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FeatureId = objvFeatureRegionFlds_TtlEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FeatureName = objvFeatureRegionFlds_TtlEN.FeatureName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.KeyWords = objvFeatureRegionFlds_TtlEN.KeyWords == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.TabFeatureId = objvFeatureRegionFlds_TtlEN.TabFeatureId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.TabFeatureName = objvFeatureRegionFlds_TtlEN.TabFeatureName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CheckTabFeature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objvFeatureRegionFlds_TtlEN.CheckTabFeature == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CheckTabFeature; //检查表功能
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FeatureDescription = objvFeatureRegionFlds_TtlEN.FeatureDescription == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ButtonName = objvFeatureRegionFlds_TtlEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ButtonName4Mvc, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objvFeatureRegionFlds_TtlEN.ButtonName4Mvc; //按钮名称4Mvc
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.EventFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.EventFuncName = objvFeatureRegionFlds_TtlEN.EventFuncName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.EventFuncName; //事件函数名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objvFeatureRegionFlds_TtlEN.ValueGivingModeId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ValueGivingModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objvFeatureRegionFlds_TtlEN.ValueGivingModeName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ValueGivingModeName; //给值方式名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FuncName = objvFeatureRegionFlds_TtlEN.FuncName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.DefaultValue = objvFeatureRegionFlds_TtlEN.DefaultValue == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.Text = objvFeatureRegionFlds_TtlEN.Text; //文本
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.GroupName = objvFeatureRegionFlds_TtlEN.GroupName; //组名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ReleTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ReleTabId = objvFeatureRegionFlds_TtlEN.ReleTabId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ReleTabId; //相关表Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ReleFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ReleFldId = objvFeatureRegionFlds_TtlEN.ReleFldId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ReleFldId; //相关字段Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FieldTypeId = objvFeatureRegionFlds_TtlEN.FieldTypeId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FieldTypeName = objvFeatureRegionFlds_TtlEN.FieldTypeName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ViewImplId = objvFeatureRegionFlds_TtlEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ViewImplName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ViewImplName = objvFeatureRegionFlds_TtlEN.ViewImplName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ViewImplName; //界面实现名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CtlTypeId = objvFeatureRegionFlds_TtlEN.CtlTypeId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CtlTypeName = objvFeatureRegionFlds_TtlEN.CtlTypeName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CtlCnName = objvFeatureRegionFlds_TtlEN.CtlCnName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objvFeatureRegionFlds_TtlEN.CtlTypeAbbr == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.Height = objvFeatureRegionFlds_TtlEN.Height; //高度
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.Width = objvFeatureRegionFlds_TtlEN.Width; //宽
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.SeqNum = objvFeatureRegionFlds_TtlEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.CssClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.CssClass = objvFeatureRegionFlds_TtlEN.CssClass == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.CssClass; //样式表
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.ImageUrl = objvFeatureRegionFlds_TtlEN.ImageUrl == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.ImageUrl; //图片资源
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.InUse = objvFeatureRegionFlds_TtlEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.UpdUser = objvFeatureRegionFlds_TtlEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.UpdDate = objvFeatureRegionFlds_TtlEN.UpdDate == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.Memo = objvFeatureRegionFlds_TtlEN.Memo == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.Memo; //说明
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.FldNum = objvFeatureRegionFlds_TtlEN.FldNum; //字段数
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RelaFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RelaFldName = objvFeatureRegionFlds_TtlEN.RelaFldName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.RelaFldName; //关系字段名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.RelaTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.RelaTabName = objvFeatureRegionFlds_TtlEN.RelaTabName == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.RelaTabName; //相关表名
}
if (arrFldSet.Contains(convFeatureRegionFlds_Ttl.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureRegionFlds_TtlEN.PrjId = objvFeatureRegionFlds_TtlEN.PrjId == "[null]" ? null :  objvFeatureRegionFlds_TtlEN.PrjId; //工程ID
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
 /// <param name = "objvFeatureRegionFlds_TtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
try
{
if (objvFeatureRegionFlds_TtlEN.RegionName == "[null]") objvFeatureRegionFlds_TtlEN.RegionName = null; //区域名称
if (objvFeatureRegionFlds_TtlEN.RegionTypeId == "[null]") objvFeatureRegionFlds_TtlEN.RegionTypeId = null; //区域类型Id
if (objvFeatureRegionFlds_TtlEN.RegionTypeName == "[null]") objvFeatureRegionFlds_TtlEN.RegionTypeName = null; //区域类型名称
if (objvFeatureRegionFlds_TtlEN.FeatureName == "[null]") objvFeatureRegionFlds_TtlEN.FeatureName = null; //功能名称
if (objvFeatureRegionFlds_TtlEN.KeyWords == "[null]") objvFeatureRegionFlds_TtlEN.KeyWords = null; //关键字
if (objvFeatureRegionFlds_TtlEN.TabFeatureId == "[null]") objvFeatureRegionFlds_TtlEN.TabFeatureId = null; //表功能Id
if (objvFeatureRegionFlds_TtlEN.TabFeatureName == "[null]") objvFeatureRegionFlds_TtlEN.TabFeatureName = null; //表功能名
if (objvFeatureRegionFlds_TtlEN.CheckTabFeature == "[null]") objvFeatureRegionFlds_TtlEN.CheckTabFeature = null; //检查表功能
if (objvFeatureRegionFlds_TtlEN.FeatureDescription == "[null]") objvFeatureRegionFlds_TtlEN.FeatureDescription = null; //功能说明
if (objvFeatureRegionFlds_TtlEN.EventFuncName == "[null]") objvFeatureRegionFlds_TtlEN.EventFuncName = null; //事件函数名
if (objvFeatureRegionFlds_TtlEN.ValueGivingModeId == "[null]") objvFeatureRegionFlds_TtlEN.ValueGivingModeId = null; //给值方式Id
if (objvFeatureRegionFlds_TtlEN.ValueGivingModeName == "[null]") objvFeatureRegionFlds_TtlEN.ValueGivingModeName = null; //给值方式名
if (objvFeatureRegionFlds_TtlEN.FuncName == "[null]") objvFeatureRegionFlds_TtlEN.FuncName = null; //函数名
if (objvFeatureRegionFlds_TtlEN.DefaultValue == "[null]") objvFeatureRegionFlds_TtlEN.DefaultValue = null; //缺省值
if (objvFeatureRegionFlds_TtlEN.ReleTabId == "[null]") objvFeatureRegionFlds_TtlEN.ReleTabId = null; //相关表Id
if (objvFeatureRegionFlds_TtlEN.ReleFldId == "[null]") objvFeatureRegionFlds_TtlEN.ReleFldId = null; //相关字段Id
if (objvFeatureRegionFlds_TtlEN.FieldTypeId == "[null]") objvFeatureRegionFlds_TtlEN.FieldTypeId = null; //字段类型Id
if (objvFeatureRegionFlds_TtlEN.FieldTypeName == "[null]") objvFeatureRegionFlds_TtlEN.FieldTypeName = null; //字段类型名
if (objvFeatureRegionFlds_TtlEN.ViewImplName == "[null]") objvFeatureRegionFlds_TtlEN.ViewImplName = null; //界面实现名
if (objvFeatureRegionFlds_TtlEN.CtlTypeId == "[null]") objvFeatureRegionFlds_TtlEN.CtlTypeId = null; //控件类型号
if (objvFeatureRegionFlds_TtlEN.CtlTypeName == "[null]") objvFeatureRegionFlds_TtlEN.CtlTypeName = null; //控件类型名
if (objvFeatureRegionFlds_TtlEN.CtlCnName == "[null]") objvFeatureRegionFlds_TtlEN.CtlCnName = null; //控件类型中文名
if (objvFeatureRegionFlds_TtlEN.CtlTypeAbbr == "[null]") objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = null; //控件类型缩写
if (objvFeatureRegionFlds_TtlEN.CssClass == "[null]") objvFeatureRegionFlds_TtlEN.CssClass = null; //样式表
if (objvFeatureRegionFlds_TtlEN.ImageUrl == "[null]") objvFeatureRegionFlds_TtlEN.ImageUrl = null; //图片资源
if (objvFeatureRegionFlds_TtlEN.UpdDate == "[null]") objvFeatureRegionFlds_TtlEN.UpdDate = null; //修改日期
if (objvFeatureRegionFlds_TtlEN.Memo == "[null]") objvFeatureRegionFlds_TtlEN.Memo = null; //说明
if (objvFeatureRegionFlds_TtlEN.RelaFldName == "[null]") objvFeatureRegionFlds_TtlEN.RelaFldName = null; //关系字段名
if (objvFeatureRegionFlds_TtlEN.RelaTabName == "[null]") objvFeatureRegionFlds_TtlEN.RelaTabName = null; //相关表名
if (objvFeatureRegionFlds_TtlEN.PrjId == "[null]") objvFeatureRegionFlds_TtlEN.PrjId = null; //工程ID
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
public static void CheckProperty4Condition(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
 vFeatureRegionFlds_TtlDA.CheckProperty4Condition(objvFeatureRegionFlds_TtlEN);
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
//if (arrvFeatureRegionFlds_TtlObjLstCache == null)
//{
//arrvFeatureRegionFlds_TtlObjLstCache = vFeatureRegionFlds_TtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFlds_TtlEN._CurrTabName, strPrjId);
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLst_Sel =
arrvFeatureRegionFlds_TtlObjLstCache
.Where(x=> x.ViewFeatureId == strViewFeatureId 
);
if (arrvFeatureRegionFlds_TtlObjLst_Sel.Count() == 0)
{
   clsvFeatureRegionFlds_TtlEN obj = clsvFeatureRegionFlds_TtlBL.GetObjByViewFeatureId(strViewFeatureId);
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
return arrvFeatureRegionFlds_TtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetAllvFeatureRegionFlds_TtlObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = GetObjLstCache(strPrjId); 
return arrvFeatureRegionFlds_TtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureRegionFlds_TtlEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFlds_TtlEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFeatureRegionFlds_TtlEN> arrvFeatureRegionFlds_TtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFeatureRegionFlds_TtlObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFeatureRegionFlds_TtlEN._CurrTabName, strPrjId);
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
if (strInFldName != convFeatureRegionFlds_Ttl.ViewFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureRegionFlds_Ttl.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureRegionFlds_Ttl.AttributeName));
throw new Exception(strMsg);
}
var objvFeatureRegionFlds_Ttl = clsvFeatureRegionFlds_TtlBL.GetObjByViewFeatureIdCache(strViewFeatureId, strPrjId);
if (objvFeatureRegionFlds_Ttl == null) return "";
return objvFeatureRegionFlds_Ttl[strOutFldName].ToString();
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
int intRecCount = clsvFeatureRegionFlds_TtlDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureRegionFlds_TtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureRegionFlds_TtlDA.GetRecCount();
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
int intRecCount = clsvFeatureRegionFlds_TtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlCond)
{
 string strPrjId = objvFeatureRegionFlds_TtlCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFeatureRegionFlds_TtlBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFeatureRegionFlds_TtlEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFeatureRegionFlds_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureRegionFlds_Ttl.AttributeName)
{
if (objvFeatureRegionFlds_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureRegionFlds_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFlds_TtlCond[strFldName].ToString());
}
else
{
if (objvFeatureRegionFlds_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureRegionFlds_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureRegionFlds_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureRegionFlds_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureRegionFlds_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFlds_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureRegionFlds_TtlCond[strFldName]));
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
 List<string> arrList = clsvFeatureRegionFlds_TtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureRegionFlds_TtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureRegionFlds_TtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}