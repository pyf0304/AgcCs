
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDetailRegionFldsWApi
 表名:vDetailRegionFlds(00050546)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:57
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
public static class  clsvDetailRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetmId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objvDetailRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.mId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.mId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.mId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetRegionId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convDetailRegionFlds.RegionId);
objvDetailRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.RegionId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.RegionId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.RegionId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetRegionTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convDetailRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convDetailRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convDetailRegionFlds.RegionTypeId);
objvDetailRegionFldsEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.RegionTypeId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.RegionTypeId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.RegionTypeId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetTabId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDetailRegionFlds.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDetailRegionFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDetailRegionFlds.TabId);
objvDetailRegionFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.TabId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.TabId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.TabId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetTabName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convDetailRegionFlds.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convDetailRegionFlds.TabName);
objvDetailRegionFldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.TabName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.TabName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.TabName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetFldId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDetailRegionFlds.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convDetailRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDetailRegionFlds.FldId);
objvDetailRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.FldId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.FldId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.FldId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetFldName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDetailRegionFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convDetailRegionFlds.FldName);
objvDetailRegionFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.FldName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.FldName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.FldName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetOutDataNodeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, long lngOutDataNodeId, string strComparisonOp="")
	{
objvDetailRegionFldsEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.OutDataNodeId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.OutDataNodeId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.OutDataNodeId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeName">数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetDataNodeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDetailRegionFlds.DataNodeName);
objvDetailRegionFldsEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.DataNodeName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.DataNodeName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.DataNodeName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseFunc">使用函数映射</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetIsUseFunc(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, bool bolIsUseFunc, string strComparisonOp="")
	{
objvDetailRegionFldsEN.IsUseFunc = bolIsUseFunc; //使用函数映射
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.IsUseFunc) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.IsUseFunc, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.IsUseFunc] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataPropertyName">数据属性名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetDataPropertyName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strDataPropertyName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataPropertyName, 50, convDetailRegionFlds.DataPropertyName);
objvDetailRegionFldsEN.DataPropertyName = strDataPropertyName; //数据属性名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.DataPropertyName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.DataPropertyName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.DataPropertyName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetLabelCaption(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convDetailRegionFlds.LabelCaption);
objvDetailRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.LabelCaption) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convDetailRegionFlds.CtlTypeId);
objvDetailRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.CtlTypeId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convDetailRegionFlds.CtlTypeName);
objvDetailRegionFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.CtlTypeName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.CtlTypeName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.CtlTypeName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlCnName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convDetailRegionFlds.CtlCnName);
objvDetailRegionFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.CtlCnName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.CtlCnName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.CtlCnName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeAbbr(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convDetailRegionFlds.CtlTypeAbbr);
objvDetailRegionFldsEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.CtlTypeAbbr) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.CtlTypeAbbr, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.CtlTypeAbbr] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetColSpan(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objvDetailRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.ColSpan) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.ColSpan, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.ColSpan] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColIndex">列序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetColIndex(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int intColIndex, string strComparisonOp="")
	{
objvDetailRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.ColIndex) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.ColIndex, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.ColIndex] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetWidth(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objvDetailRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.Width) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.Width, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.Width] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMultiRow">是否多行</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetIsMultiRow(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objvDetailRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.IsMultiRow) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetSeqNum(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, convDetailRegionFlds.SeqNum);
objvDetailRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.SeqNum) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetInOutTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convDetailRegionFlds.InOutTypeId);
objvDetailRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.InOutTypeId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeName">INOUT类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetInOutTypeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convDetailRegionFlds.InOutTypeName);
objvDetailRegionFldsEN.InOutTypeName = strInOutTypeName; //INOUT类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.InOutTypeName) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.InOutTypeName, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.InOutTypeName] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetInUse(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvDetailRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.InUse) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.InUse, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.InUse] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetChangeEvent(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convDetailRegionFlds.ChangeEvent);
objvDetailRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.ChangeEvent) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetClickEvent(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convDetailRegionFlds.ClickEvent);
objvDetailRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.ClickEvent) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetUpdUser(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDetailRegionFlds.UpdUser);
objvDetailRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.UpdUser) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetUpdDate(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDetailRegionFlds.UpdDate);
objvDetailRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.UpdDate) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetMemo(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDetailRegionFlds.Memo);
objvDetailRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.Memo) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.Memo, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.Memo] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetPrjId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDetailRegionFlds.PrjId);
objvDetailRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(convDetailRegionFlds.PrjId) == false)
{
objvDetailRegionFldsEN.dicFldComparisonOp.Add(convDetailRegionFlds.PrjId, strComparisonOp);
}
else
{
objvDetailRegionFldsEN.dicFldComparisonOp[convDetailRegionFlds.PrjId] = strComparisonOp;
}
}
return objvDetailRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDetailRegionFldsEN objvDetailRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.mId) == true)
{
string strComparisonOpmId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.mId, objvDetailRegionFldsCond.mId, strComparisonOpmId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.RegionId, objvDetailRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.RegionTypeId, objvDetailRegionFldsCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.TabId) == true)
{
string strComparisonOpTabId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.TabId, objvDetailRegionFldsCond.TabId, strComparisonOpTabId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.TabName) == true)
{
string strComparisonOpTabName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.TabName, objvDetailRegionFldsCond.TabName, strComparisonOpTabName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.FldId, objvDetailRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.FldName) == true)
{
string strComparisonOpFldName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.FldName, objvDetailRegionFldsCond.FldName, strComparisonOpFldName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.OutDataNodeId, objvDetailRegionFldsCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.DataNodeName, objvDetailRegionFldsCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.IsUseFunc) == true)
{
if (objvDetailRegionFldsCond.IsUseFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDetailRegionFlds.IsUseFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDetailRegionFlds.IsUseFunc);
}
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.DataPropertyName) == true)
{
string strComparisonOpDataPropertyName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.DataPropertyName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.DataPropertyName, objvDetailRegionFldsCond.DataPropertyName, strComparisonOpDataPropertyName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.LabelCaption, objvDetailRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.CtlTypeId, objvDetailRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.CtlTypeName, objvDetailRegionFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.CtlCnName, objvDetailRegionFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.CtlTypeAbbr, objvDetailRegionFldsCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.ColSpan, objvDetailRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.ColIndex, objvDetailRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.Width) == true)
{
string strComparisonOpWidth = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.Width, objvDetailRegionFldsCond.Width, strComparisonOpWidth);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.IsMultiRow) == true)
{
if (objvDetailRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDetailRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDetailRegionFlds.IsMultiRow);
}
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDetailRegionFlds.SeqNum, objvDetailRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.InOutTypeId, objvDetailRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.InOutTypeName, objvDetailRegionFldsCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.InUse) == true)
{
if (objvDetailRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDetailRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDetailRegionFlds.InUse);
}
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.ChangeEvent, objvDetailRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.ClickEvent, objvDetailRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.UpdUser, objvDetailRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.UpdDate, objvDetailRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.Memo, objvDetailRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvDetailRegionFldsCond.IsUpdated(convDetailRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvDetailRegionFldsCond.dicFldComparisonOp[convDetailRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDetailRegionFlds.PrjId, objvDetailRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v详细区域字段(vDetailRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDetailRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vDetailRegionFldsApi";

 public clsvDetailRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDetailRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvDetailRegionFldsEN objvDetailRegionFldsEN;
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
objvDetailRegionFldsEN = JsonConvert.DeserializeObject<clsvDetailRegionFldsEN>(strJson);
return objvDetailRegionFldsEN;
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
public static clsvDetailRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDetailRegionFldsEN objvDetailRegionFldsEN;
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
objvDetailRegionFldsEN = JsonConvert.DeserializeObject<clsvDetailRegionFldsEN>(strJson);
return objvDetailRegionFldsEN;
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
public static clsvDetailRegionFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLst_Sel =
from objvDetailRegionFldsEN in arrvDetailRegionFldsObjLstCache
where objvDetailRegionFldsEN.mId == lngmId 
select objvDetailRegionFldsEN;
if (arrvDetailRegionFldsObjLst_Sel.Count() == 0)
{
   clsvDetailRegionFldsEN obj = clsvDetailRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDetailRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
public static IEnumerable<clsvDetailRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLst_Sel =
from objvDetailRegionFldsEN in arrvDetailRegionFldsObjLstCache
where arrMId.Contains(objvDetailRegionFldsEN.mId)
select objvDetailRegionFldsEN;
return arrvDetailRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDetailRegionFldsEN>>(strJson);
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
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <param name = "objvDetailRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvDetailRegionFldsEN objvDetailRegionFldsENS, clsvDetailRegionFldsEN objvDetailRegionFldsENT)
{
try
{
objvDetailRegionFldsENT.mId = objvDetailRegionFldsENS.mId; //mId
objvDetailRegionFldsENT.RegionId = objvDetailRegionFldsENS.RegionId; //区域Id
objvDetailRegionFldsENT.RegionTypeId = objvDetailRegionFldsENS.RegionTypeId; //区域类型Id
objvDetailRegionFldsENT.TabId = objvDetailRegionFldsENS.TabId; //表ID
objvDetailRegionFldsENT.TabName = objvDetailRegionFldsENS.TabName; //表名
objvDetailRegionFldsENT.FldId = objvDetailRegionFldsENS.FldId; //字段Id
objvDetailRegionFldsENT.FldName = objvDetailRegionFldsENS.FldName; //字段名
objvDetailRegionFldsENT.OutDataNodeId = objvDetailRegionFldsENS.OutDataNodeId; //Out数据结点Id
objvDetailRegionFldsENT.DataNodeName = objvDetailRegionFldsENS.DataNodeName; //数据结点名
objvDetailRegionFldsENT.IsUseFunc = objvDetailRegionFldsENS.IsUseFunc; //使用函数映射
objvDetailRegionFldsENT.DataPropertyName = objvDetailRegionFldsENS.DataPropertyName; //数据属性名
objvDetailRegionFldsENT.LabelCaption = objvDetailRegionFldsENS.LabelCaption; //标签标题
objvDetailRegionFldsENT.CtlTypeId = objvDetailRegionFldsENS.CtlTypeId; //控件类型号
objvDetailRegionFldsENT.CtlTypeName = objvDetailRegionFldsENS.CtlTypeName; //控件类型名
objvDetailRegionFldsENT.CtlCnName = objvDetailRegionFldsENS.CtlCnName; //控件类型中文名
objvDetailRegionFldsENT.CtlTypeAbbr = objvDetailRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvDetailRegionFldsENT.ColSpan = objvDetailRegionFldsENS.ColSpan; //跨列数
objvDetailRegionFldsENT.ColIndex = objvDetailRegionFldsENS.ColIndex; //列序号
objvDetailRegionFldsENT.Width = objvDetailRegionFldsENS.Width; //宽
objvDetailRegionFldsENT.IsMultiRow = objvDetailRegionFldsENS.IsMultiRow; //是否多行
objvDetailRegionFldsENT.SeqNum = objvDetailRegionFldsENS.SeqNum; //字段序号
objvDetailRegionFldsENT.InOutTypeId = objvDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objvDetailRegionFldsENT.InOutTypeName = objvDetailRegionFldsENS.InOutTypeName; //INOUT类型名称
objvDetailRegionFldsENT.InUse = objvDetailRegionFldsENS.InUse; //是否在用
objvDetailRegionFldsENT.ChangeEvent = objvDetailRegionFldsENS.ChangeEvent; //Change事件
objvDetailRegionFldsENT.ClickEvent = objvDetailRegionFldsENS.ClickEvent; //Click事件
objvDetailRegionFldsENT.UpdUser = objvDetailRegionFldsENS.UpdUser; //修改者
objvDetailRegionFldsENT.UpdDate = objvDetailRegionFldsENS.UpdDate; //修改日期
objvDetailRegionFldsENT.Memo = objvDetailRegionFldsENS.Memo; //说明
objvDetailRegionFldsENT.PrjId = objvDetailRegionFldsENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvDetailRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDetailRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDetailRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDetailRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDetailRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDetailRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDetailRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDetailRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
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
public static List<clsvDetailRegionFldsEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDetailRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDetailRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvDetailRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvDetailRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convDetailRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLstCacheFromObjLst(List<clsvDetailRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDetailRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDetailRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvDetailRegionFldsObjLstCache = CacheHelper.Get<List<clsvDetailRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvDetailRegionFldsObjLstCache = CacheHelper.Get<List<clsvDetailRegionFldsEN>>(strKey);
}
return arrvDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDetailRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDetailRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDetailRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDetailRegionFlds.DataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.IsUseFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDetailRegionFlds.DataPropertyName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(convDetailRegionFlds.ColIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convDetailRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convDetailRegionFlds.IsMultiRow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDetailRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convDetailRegionFlds.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDetailRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convDetailRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvDetailRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDetailRegionFlds.mId] = objInFor[convDetailRegionFlds.mId];
objDR[convDetailRegionFlds.RegionId] = objInFor[convDetailRegionFlds.RegionId];
objDR[convDetailRegionFlds.RegionTypeId] = objInFor[convDetailRegionFlds.RegionTypeId];
objDR[convDetailRegionFlds.TabId] = objInFor[convDetailRegionFlds.TabId];
objDR[convDetailRegionFlds.TabName] = objInFor[convDetailRegionFlds.TabName];
objDR[convDetailRegionFlds.FldId] = objInFor[convDetailRegionFlds.FldId];
objDR[convDetailRegionFlds.FldName] = objInFor[convDetailRegionFlds.FldName];
objDR[convDetailRegionFlds.OutDataNodeId] = objInFor[convDetailRegionFlds.OutDataNodeId];
objDR[convDetailRegionFlds.DataNodeName] = objInFor[convDetailRegionFlds.DataNodeName];
objDR[convDetailRegionFlds.IsUseFunc] = objInFor[convDetailRegionFlds.IsUseFunc];
objDR[convDetailRegionFlds.DataPropertyName] = objInFor[convDetailRegionFlds.DataPropertyName];
objDR[convDetailRegionFlds.LabelCaption] = objInFor[convDetailRegionFlds.LabelCaption];
objDR[convDetailRegionFlds.CtlTypeId] = objInFor[convDetailRegionFlds.CtlTypeId];
objDR[convDetailRegionFlds.CtlTypeName] = objInFor[convDetailRegionFlds.CtlTypeName];
objDR[convDetailRegionFlds.CtlCnName] = objInFor[convDetailRegionFlds.CtlCnName];
objDR[convDetailRegionFlds.CtlTypeAbbr] = objInFor[convDetailRegionFlds.CtlTypeAbbr];
objDR[convDetailRegionFlds.ColSpan] = objInFor[convDetailRegionFlds.ColSpan];
objDR[convDetailRegionFlds.ColIndex] = objInFor[convDetailRegionFlds.ColIndex];
objDR[convDetailRegionFlds.Width] = objInFor[convDetailRegionFlds.Width];
objDR[convDetailRegionFlds.IsMultiRow] = objInFor[convDetailRegionFlds.IsMultiRow];
objDR[convDetailRegionFlds.SeqNum] = objInFor[convDetailRegionFlds.SeqNum];
objDR[convDetailRegionFlds.InOutTypeId] = objInFor[convDetailRegionFlds.InOutTypeId];
objDR[convDetailRegionFlds.InOutTypeName] = objInFor[convDetailRegionFlds.InOutTypeName];
objDR[convDetailRegionFlds.InUse] = objInFor[convDetailRegionFlds.InUse];
objDR[convDetailRegionFlds.ChangeEvent] = objInFor[convDetailRegionFlds.ChangeEvent];
objDR[convDetailRegionFlds.ClickEvent] = objInFor[convDetailRegionFlds.ClickEvent];
objDR[convDetailRegionFlds.UpdUser] = objInFor[convDetailRegionFlds.UpdUser];
objDR[convDetailRegionFlds.UpdDate] = objInFor[convDetailRegionFlds.UpdDate];
objDR[convDetailRegionFlds.Memo] = objInFor[convDetailRegionFlds.Memo];
objDR[convDetailRegionFlds.PrjId] = objInFor[convDetailRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}