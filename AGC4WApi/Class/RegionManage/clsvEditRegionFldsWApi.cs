
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsWApi
 表名:vEditRegionFlds(00050126)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:53
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
public static class  clsvEditRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetmId(this clsvEditRegionFldsEN objvEditRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objvEditRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.mId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.mId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.mId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetRegionId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convEditRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convEditRegionFlds.RegionId);
objvEditRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.RegionId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.RegionId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.RegionId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetRegionTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convEditRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convEditRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convEditRegionFlds.RegionTypeId);
objvEditRegionFldsEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.RegionTypeId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.RegionTypeId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.RegionTypeId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetTabId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convEditRegionFlds.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convEditRegionFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convEditRegionFlds.TabId);
objvEditRegionFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.TabId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.TabId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.TabId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetTabName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convEditRegionFlds.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convEditRegionFlds.TabName);
objvEditRegionFldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.TabName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.TabName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.TabName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetFldId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convEditRegionFlds.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convEditRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convEditRegionFlds.FldId);
objvEditRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.FldId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.FldId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.FldId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetFldName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convEditRegionFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convEditRegionFlds.FldName);
objvEditRegionFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.FldName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.FldName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.FldName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetLabelCaption(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convEditRegionFlds.LabelCaption);
objvEditRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.LabelCaption) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convEditRegionFlds.CtlTypeId);
objvEditRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.CtlTypeId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convEditRegionFlds.CtlTypeName);
objvEditRegionFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.CtlTypeName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.CtlTypeName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.CtlTypeName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlCnName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convEditRegionFlds.CtlCnName);
objvEditRegionFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.CtlCnName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.CtlCnName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.CtlCnName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeAbbr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convEditRegionFlds.CtlTypeAbbr);
objvEditRegionFldsEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.CtlTypeAbbr) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.CtlTypeAbbr, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.CtlTypeAbbr] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCallTabFeatureId">调用表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCallTabFeatureId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCallTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCallTabFeatureId, 8, convEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldForeignKey(strCallTabFeatureId, 8, convEditRegionFlds.CallTabFeatureId);
objvEditRegionFldsEN.CallTabFeatureId = strCallTabFeatureId; //调用表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.CallTabFeatureId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.CallTabFeatureId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.CallTabFeatureId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetVarId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, convEditRegionFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convEditRegionFlds.VarId);
objvEditRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.VarId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.VarId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.VarId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDdlItemsOptionId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionId, convEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convEditRegionFlds.DdlItemsOptionId);
objvEditRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.DdlItemsOptionId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionName">下拉选项名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDdlItemsOptionName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDdlItemsOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionName, 20, convEditRegionFlds.DdlItemsOptionName);
objvEditRegionFldsEN.DdlItemsOptionName = strDdlItemsOptionName; //下拉选项名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.DdlItemsOptionName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.DdlItemsOptionName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.DdlItemsOptionName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsTabId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabId, 8, convEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convEditRegionFlds.DsTabId);
objvEditRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.DsTabId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.DsTabId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.DsTabId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsCondStr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsCondStr, convEditRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convEditRegionFlds.DsCondStr);
objvEditRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.DsCondStr) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsSqlStr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsSqlStr, convEditRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convEditRegionFlds.DsSqlStr);
objvEditRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.DsSqlStr) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetItemsString(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strItemsString, convEditRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(strItemsString, 200, convEditRegionFlds.ItemsString);
objvEditRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.ItemsString) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.ItemsString, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.ItemsString] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetColSpan(this clsvEditRegionFldsEN objvEditRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objvEditRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.ColSpan) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.ColSpan, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.ColSpan] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColIndex">列序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetColIndex(this clsvEditRegionFldsEN objvEditRegionFldsEN, int intColIndex, string strComparisonOp="")
	{
objvEditRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.ColIndex) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.ColIndex, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.ColIndex] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetWidth(this clsvEditRegionFldsEN objvEditRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objvEditRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.Width) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.Width, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.Width] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMultiRow">是否多行</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetIsMultiRow(this clsvEditRegionFldsEN objvEditRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objvEditRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.IsMultiRow) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetSeqNum(this clsvEditRegionFldsEN objvEditRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, convEditRegionFlds.SeqNum);
objvEditRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.SeqNum) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetInOutTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convEditRegionFlds.InOutTypeId);
objvEditRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.InOutTypeId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeName">INOUT类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetInOutTypeName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convEditRegionFlds.InOutTypeName);
objvEditRegionFldsEN.InOutTypeName = strInOutTypeName; //INOUT类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.InOutTypeName) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.InOutTypeName, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.InOutTypeName] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetClickEvent(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convEditRegionFlds.ClickEvent);
objvEditRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.ClickEvent) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetChangeEvent(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convEditRegionFlds.ChangeEvent);
objvEditRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.ChangeEvent) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetInUse(this clsvEditRegionFldsEN objvEditRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvEditRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.InUse) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.InUse, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.InUse] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetUpdUser(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convEditRegionFlds.UpdUser);
objvEditRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.UpdUser) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetUpdDate(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convEditRegionFlds.UpdDate);
objvEditRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.UpdDate) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetMemo(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMemo, convEditRegionFlds.Memo);
clsCheckSql.CheckFieldLen(strMemo, 1000, convEditRegionFlds.Memo);
objvEditRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.Memo) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.Memo, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.Memo] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetPrjId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convEditRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convEditRegionFlds.PrjId);
objvEditRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEditRegionFldsEN.dicFldComparisonOp.ContainsKey(convEditRegionFlds.PrjId) == false)
{
objvEditRegionFldsEN.dicFldComparisonOp.Add(convEditRegionFlds.PrjId, strComparisonOp);
}
else
{
objvEditRegionFldsEN.dicFldComparisonOp[convEditRegionFlds.PrjId] = strComparisonOp;
}
}
return objvEditRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEditRegionFldsEN objvEditRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.mId) == true)
{
string strComparisonOpmId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convEditRegionFlds.mId, objvEditRegionFldsCond.mId, strComparisonOpmId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.RegionId, objvEditRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.RegionTypeId, objvEditRegionFldsCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.TabId) == true)
{
string strComparisonOpTabId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.TabId, objvEditRegionFldsCond.TabId, strComparisonOpTabId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.TabName) == true)
{
string strComparisonOpTabName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.TabName, objvEditRegionFldsCond.TabName, strComparisonOpTabName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.FldId, objvEditRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.FldName) == true)
{
string strComparisonOpFldName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.FldName, objvEditRegionFldsCond.FldName, strComparisonOpFldName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.LabelCaption, objvEditRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.CtlTypeId, objvEditRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.CtlTypeName, objvEditRegionFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.CtlCnName, objvEditRegionFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.CtlTypeAbbr, objvEditRegionFldsCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.CallTabFeatureId) == true)
{
string strComparisonOpCallTabFeatureId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.CallTabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.CallTabFeatureId, objvEditRegionFldsCond.CallTabFeatureId, strComparisonOpCallTabFeatureId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.VarId, objvEditRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.DdlItemsOptionId, objvEditRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.DdlItemsOptionName) == true)
{
string strComparisonOpDdlItemsOptionName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.DdlItemsOptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.DdlItemsOptionName, objvEditRegionFldsCond.DdlItemsOptionName, strComparisonOpDdlItemsOptionName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.DsTabId, objvEditRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.DsCondStr, objvEditRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.DsSqlStr, objvEditRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.ItemsString, objvEditRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", convEditRegionFlds.ColSpan, objvEditRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convEditRegionFlds.ColIndex, objvEditRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.Width) == true)
{
string strComparisonOpWidth = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convEditRegionFlds.Width, objvEditRegionFldsCond.Width, strComparisonOpWidth);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.IsMultiRow) == true)
{
if (objvEditRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEditRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEditRegionFlds.IsMultiRow);
}
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convEditRegionFlds.SeqNum, objvEditRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.InOutTypeId, objvEditRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.InOutTypeName, objvEditRegionFldsCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.ClickEvent, objvEditRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.ChangeEvent, objvEditRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.InUse) == true)
{
if (objvEditRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEditRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEditRegionFlds.InUse);
}
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.UpdUser, objvEditRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.UpdDate, objvEditRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.Memo, objvEditRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvEditRegionFldsCond.IsUpdated(convEditRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvEditRegionFldsCond.dicFldComparisonOp[convEditRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEditRegionFlds.PrjId, objvEditRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEditRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vEditRegionFldsApi";

 public clsvEditRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEditRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvEditRegionFldsEN objvEditRegionFldsEN;
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
objvEditRegionFldsEN = JsonConvert.DeserializeObject<clsvEditRegionFldsEN>(strJson);
return objvEditRegionFldsEN;
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
public static clsvEditRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvEditRegionFldsEN objvEditRegionFldsEN;
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
objvEditRegionFldsEN = JsonConvert.DeserializeObject<clsvEditRegionFldsEN>(strJson);
return objvEditRegionFldsEN;
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
public static clsvEditRegionFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvEditRegionFldsEN> arrvEditRegionFldsObjLst_Sel =
from objvEditRegionFldsEN in arrvEditRegionFldsObjLstCache
where objvEditRegionFldsEN.mId == lngmId 
select objvEditRegionFldsEN;
if (arrvEditRegionFldsObjLst_Sel.Count() == 0)
{
   clsvEditRegionFldsEN obj = clsvEditRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEditRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
public static List<clsvEditRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
public static IEnumerable<clsvEditRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvEditRegionFldsEN> arrvEditRegionFldsObjLst_Sel =
from objvEditRegionFldsEN in arrvEditRegionFldsObjLstCache
where arrMId.Contains(objvEditRegionFldsEN.mId)
select objvEditRegionFldsEN;
return arrvEditRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEditRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
public static List<clsvEditRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
public static List<clsvEditRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
public static List<clsvEditRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEditRegionFldsEN>>(strJson);
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
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <param name = "objvEditRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvEditRegionFldsEN objvEditRegionFldsENS, clsvEditRegionFldsEN objvEditRegionFldsENT)
{
try
{
objvEditRegionFldsENT.mId = objvEditRegionFldsENS.mId; //mId
objvEditRegionFldsENT.RegionId = objvEditRegionFldsENS.RegionId; //区域Id
objvEditRegionFldsENT.RegionTypeId = objvEditRegionFldsENS.RegionTypeId; //区域类型Id
objvEditRegionFldsENT.TabId = objvEditRegionFldsENS.TabId; //表ID
objvEditRegionFldsENT.TabName = objvEditRegionFldsENS.TabName; //表名
objvEditRegionFldsENT.FldId = objvEditRegionFldsENS.FldId; //字段Id
objvEditRegionFldsENT.FldName = objvEditRegionFldsENS.FldName; //字段名
objvEditRegionFldsENT.LabelCaption = objvEditRegionFldsENS.LabelCaption; //标签标题
objvEditRegionFldsENT.CtlTypeId = objvEditRegionFldsENS.CtlTypeId; //控件类型号
objvEditRegionFldsENT.CtlTypeName = objvEditRegionFldsENS.CtlTypeName; //控件类型名
objvEditRegionFldsENT.CtlCnName = objvEditRegionFldsENS.CtlCnName; //控件类型中文名
objvEditRegionFldsENT.CtlTypeAbbr = objvEditRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvEditRegionFldsENT.CallTabFeatureId = objvEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objvEditRegionFldsENT.VarId = objvEditRegionFldsENS.VarId; //变量Id
objvEditRegionFldsENT.DdlItemsOptionId = objvEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvEditRegionFldsENT.DdlItemsOptionName = objvEditRegionFldsENS.DdlItemsOptionName; //下拉选项名
objvEditRegionFldsENT.DsTabId = objvEditRegionFldsENS.DsTabId; //数据源表ID
objvEditRegionFldsENT.DsCondStr = objvEditRegionFldsENS.DsCondStr; //数据源条件串
objvEditRegionFldsENT.DsSqlStr = objvEditRegionFldsENS.DsSqlStr; //数据源SQL串
objvEditRegionFldsENT.ItemsString = objvEditRegionFldsENS.ItemsString; //列表项串
objvEditRegionFldsENT.ColSpan = objvEditRegionFldsENS.ColSpan; //跨列数
objvEditRegionFldsENT.ColIndex = objvEditRegionFldsENS.ColIndex; //列序号
objvEditRegionFldsENT.Width = objvEditRegionFldsENS.Width; //宽
objvEditRegionFldsENT.IsMultiRow = objvEditRegionFldsENS.IsMultiRow; //是否多行
objvEditRegionFldsENT.SeqNum = objvEditRegionFldsENS.SeqNum; //字段序号
objvEditRegionFldsENT.InOutTypeId = objvEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objvEditRegionFldsENT.InOutTypeName = objvEditRegionFldsENS.InOutTypeName; //INOUT类型名称
objvEditRegionFldsENT.ClickEvent = objvEditRegionFldsENS.ClickEvent; //Click事件
objvEditRegionFldsENT.ChangeEvent = objvEditRegionFldsENS.ChangeEvent; //Change事件
objvEditRegionFldsENT.InUse = objvEditRegionFldsENS.InUse; //是否在用
objvEditRegionFldsENT.UpdUser = objvEditRegionFldsENS.UpdUser; //修改者
objvEditRegionFldsENT.UpdDate = objvEditRegionFldsENS.UpdDate; //修改日期
objvEditRegionFldsENT.Memo = objvEditRegionFldsENS.Memo; //说明
objvEditRegionFldsENT.PrjId = objvEditRegionFldsENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvEditRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEditRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEditRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEditRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEditRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEditRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvEditRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvEditRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
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
public static List<clsvEditRegionFldsEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvEditRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvEditRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvEditRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvEditRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convEditRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLstCacheFromObjLst(List<clsvEditRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvEditRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvEditRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvEditRegionFldsObjLstCache = CacheHelper.Get<List<clsvEditRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvEditRegionFldsObjLstCache = CacheHelper.Get<List<clsvEditRegionFldsEN>>(strKey);
}
return arrvEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEditRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEditRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convEditRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.CallTabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.DdlItemsOptionName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(convEditRegionFlds.ColIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convEditRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convEditRegionFlds.IsMultiRow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEditRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convEditRegionFlds.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEditRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convEditRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvEditRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEditRegionFlds.mId] = objInFor[convEditRegionFlds.mId];
objDR[convEditRegionFlds.RegionId] = objInFor[convEditRegionFlds.RegionId];
objDR[convEditRegionFlds.RegionTypeId] = objInFor[convEditRegionFlds.RegionTypeId];
objDR[convEditRegionFlds.TabId] = objInFor[convEditRegionFlds.TabId];
objDR[convEditRegionFlds.TabName] = objInFor[convEditRegionFlds.TabName];
objDR[convEditRegionFlds.FldId] = objInFor[convEditRegionFlds.FldId];
objDR[convEditRegionFlds.FldName] = objInFor[convEditRegionFlds.FldName];
objDR[convEditRegionFlds.LabelCaption] = objInFor[convEditRegionFlds.LabelCaption];
objDR[convEditRegionFlds.CtlTypeId] = objInFor[convEditRegionFlds.CtlTypeId];
objDR[convEditRegionFlds.CtlTypeName] = objInFor[convEditRegionFlds.CtlTypeName];
objDR[convEditRegionFlds.CtlCnName] = objInFor[convEditRegionFlds.CtlCnName];
objDR[convEditRegionFlds.CtlTypeAbbr] = objInFor[convEditRegionFlds.CtlTypeAbbr];
objDR[convEditRegionFlds.CallTabFeatureId] = objInFor[convEditRegionFlds.CallTabFeatureId];
objDR[convEditRegionFlds.VarId] = objInFor[convEditRegionFlds.VarId];
objDR[convEditRegionFlds.DdlItemsOptionId] = objInFor[convEditRegionFlds.DdlItemsOptionId];
objDR[convEditRegionFlds.DdlItemsOptionName] = objInFor[convEditRegionFlds.DdlItemsOptionName];
objDR[convEditRegionFlds.DsTabId] = objInFor[convEditRegionFlds.DsTabId];
objDR[convEditRegionFlds.DsCondStr] = objInFor[convEditRegionFlds.DsCondStr];
objDR[convEditRegionFlds.DsSqlStr] = objInFor[convEditRegionFlds.DsSqlStr];
objDR[convEditRegionFlds.ItemsString] = objInFor[convEditRegionFlds.ItemsString];
objDR[convEditRegionFlds.ColSpan] = objInFor[convEditRegionFlds.ColSpan];
objDR[convEditRegionFlds.ColIndex] = objInFor[convEditRegionFlds.ColIndex];
objDR[convEditRegionFlds.Width] = objInFor[convEditRegionFlds.Width];
objDR[convEditRegionFlds.IsMultiRow] = objInFor[convEditRegionFlds.IsMultiRow];
objDR[convEditRegionFlds.SeqNum] = objInFor[convEditRegionFlds.SeqNum];
objDR[convEditRegionFlds.InOutTypeId] = objInFor[convEditRegionFlds.InOutTypeId];
objDR[convEditRegionFlds.InOutTypeName] = objInFor[convEditRegionFlds.InOutTypeName];
objDR[convEditRegionFlds.ClickEvent] = objInFor[convEditRegionFlds.ClickEvent];
objDR[convEditRegionFlds.ChangeEvent] = objInFor[convEditRegionFlds.ChangeEvent];
objDR[convEditRegionFlds.InUse] = objInFor[convEditRegionFlds.InUse];
objDR[convEditRegionFlds.UpdUser] = objInFor[convEditRegionFlds.UpdUser];
objDR[convEditRegionFlds.UpdDate] = objInFor[convEditRegionFlds.UpdDate];
objDR[convEditRegionFlds.Memo] = objInFor[convEditRegionFlds.Memo];
objDR[convEditRegionFlds.PrjId] = objInFor[convEditRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}