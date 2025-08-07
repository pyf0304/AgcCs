
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsWApi
 表名:vQryRegionFlds(00050151)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:14
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
public static class  clsvQryRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetmId(this clsvQryRegionFldsEN objvQryRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objvQryRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.mId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.mId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.mId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetRegionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convQryRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convQryRegionFlds.RegionId);
objvQryRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.RegionId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.RegionId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.RegionId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetRegionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convQryRegionFlds.RegionName);
clsCheckSql.CheckFieldLen(strRegionName, 50, convQryRegionFlds.RegionName);
objvQryRegionFldsEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.RegionName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.RegionName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.RegionName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetTabId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convQryRegionFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQryRegionFlds.TabId);
objvQryRegionFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.TabId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.TabId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.TabId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetTabName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convQryRegionFlds.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convQryRegionFlds.TabName);
objvQryRegionFldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.TabName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.TabName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.TabName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetFldId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convQryRegionFlds.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convQryRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convQryRegionFlds.FldId);
objvQryRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.FldId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.FldId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.FldId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetFldName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convQryRegionFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convQryRegionFlds.FldName);
objvQryRegionFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.FldName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.FldName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.FldName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetLabelCaption(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convQryRegionFlds.LabelCaption);
objvQryRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.LabelCaption) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convQryRegionFlds.CtlTypeId);
objvQryRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.CtlTypeId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convQryRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convQryRegionFlds.CtlTypeName);
objvQryRegionFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.CtlTypeName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.CtlTypeName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.CtlTypeName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlCnName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convQryRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convQryRegionFlds.CtlCnName);
objvQryRegionFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.CtlCnName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.CtlCnName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.CtlCnName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeAbbr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convQryRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convQryRegionFlds.CtlTypeAbbr);
objvQryRegionFldsEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.CtlTypeAbbr) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.CtlTypeAbbr, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.CtlTypeAbbr] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetVarId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, convQryRegionFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convQryRegionFlds.VarId);
objvQryRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.VarId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.VarId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.VarId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsTabId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsTabId, convQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(strDsTabId, 8, convQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convQryRegionFlds.DsTabId);
objvQryRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.DsTabId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.DsTabId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.DsTabId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strQueryOptionId">查询方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetQueryOptionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strQueryOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQueryOptionId, convQryRegionFlds.QueryOptionId);
clsCheckSql.CheckFieldLen(strQueryOptionId, 2, convQryRegionFlds.QueryOptionId);
objvQryRegionFldsEN.QueryOptionId = strQueryOptionId; //查询方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.QueryOptionId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.QueryOptionId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.QueryOptionId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strQueryOptionName">查询方式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetQueryOptionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strQueryOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQueryOptionName, 20, convQryRegionFlds.QueryOptionName);
objvQryRegionFldsEN.QueryOptionName = strQueryOptionName; //查询方式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.QueryOptionName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.QueryOptionName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.QueryOptionName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDdlItemsOptionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionId, convQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convQryRegionFlds.DdlItemsOptionId);
objvQryRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.DdlItemsOptionId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionName">下拉选项名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDdlItemsOptionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDdlItemsOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionName, 20, convQryRegionFlds.DdlItemsOptionName);
objvQryRegionFldsEN.DdlItemsOptionName = strDdlItemsOptionName; //下拉选项名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.DdlItemsOptionName) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.DdlItemsOptionName, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.DdlItemsOptionName] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsSqlStr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convQryRegionFlds.DsSqlStr);
objvQryRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.DsSqlStr) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetItemsString(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strItemsString, 200, convQryRegionFlds.ItemsString);
objvQryRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.ItemsString) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.ItemsString, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.ItemsString] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsCondStr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convQryRegionFlds.DsCondStr);
objvQryRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.DsCondStr) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetColSpan(this clsvQryRegionFldsEN objvQryRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objvQryRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.ColSpan) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.ColSpan, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.ColSpan] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetWidth(this clsvQryRegionFldsEN objvQryRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objvQryRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.Width) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.Width, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.Width] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetSeqNum(this clsvQryRegionFldsEN objvQryRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objvQryRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.SeqNum) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetChangeEvent(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convQryRegionFlds.ChangeEvent);
objvQryRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.ChangeEvent) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetClickEvent(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convQryRegionFlds.ClickEvent);
objvQryRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.ClickEvent) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetInUse(this clsvQryRegionFldsEN objvQryRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvQryRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.InUse) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.InUse, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.InUse] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetUpdUser(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQryRegionFlds.UpdUser);
objvQryRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.UpdUser) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetUpdDate(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQryRegionFlds.UpdDate);
objvQryRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.UpdDate) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetMemo(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQryRegionFlds.Memo);
objvQryRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.Memo) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.Memo, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.Memo] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetPrjId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convQryRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convQryRegionFlds.PrjId);
objvQryRegionFldsEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQryRegionFldsEN.dicFldComparisonOp.ContainsKey(convQryRegionFlds.PrjId) == false)
{
objvQryRegionFldsEN.dicFldComparisonOp.Add(convQryRegionFlds.PrjId, strComparisonOp);
}
else
{
objvQryRegionFldsEN.dicFldComparisonOp[convQryRegionFlds.PrjId] = strComparisonOp;
}
}
return objvQryRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQryRegionFldsEN objvQryRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.mId) == true)
{
string strComparisonOpmId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQryRegionFlds.mId, objvQryRegionFldsCond.mId, strComparisonOpmId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.RegionId, objvQryRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.RegionName) == true)
{
string strComparisonOpRegionName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.RegionName, objvQryRegionFldsCond.RegionName, strComparisonOpRegionName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.TabId) == true)
{
string strComparisonOpTabId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.TabId, objvQryRegionFldsCond.TabId, strComparisonOpTabId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.TabName) == true)
{
string strComparisonOpTabName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.TabName, objvQryRegionFldsCond.TabName, strComparisonOpTabName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.FldId, objvQryRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.FldName) == true)
{
string strComparisonOpFldName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.FldName, objvQryRegionFldsCond.FldName, strComparisonOpFldName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.LabelCaption, objvQryRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.CtlTypeId, objvQryRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.CtlTypeName, objvQryRegionFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.CtlCnName, objvQryRegionFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.CtlTypeAbbr, objvQryRegionFldsCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.VarId, objvQryRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.DsTabId, objvQryRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.QueryOptionId) == true)
{
string strComparisonOpQueryOptionId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.QueryOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.QueryOptionId, objvQryRegionFldsCond.QueryOptionId, strComparisonOpQueryOptionId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.QueryOptionName) == true)
{
string strComparisonOpQueryOptionName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.QueryOptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.QueryOptionName, objvQryRegionFldsCond.QueryOptionName, strComparisonOpQueryOptionName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.DdlItemsOptionId, objvQryRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.DdlItemsOptionName) == true)
{
string strComparisonOpDdlItemsOptionName = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.DdlItemsOptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.DdlItemsOptionName, objvQryRegionFldsCond.DdlItemsOptionName, strComparisonOpDdlItemsOptionName);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.DsSqlStr, objvQryRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.ItemsString, objvQryRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.DsCondStr, objvQryRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", convQryRegionFlds.ColSpan, objvQryRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.Width) == true)
{
string strComparisonOpWidth = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convQryRegionFlds.Width, objvQryRegionFldsCond.Width, strComparisonOpWidth);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQryRegionFlds.SeqNum, objvQryRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.ChangeEvent, objvQryRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.ClickEvent, objvQryRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.InUse) == true)
{
if (objvQryRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQryRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQryRegionFlds.InUse);
}
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.UpdUser, objvQryRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.UpdDate, objvQryRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.Memo, objvQryRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvQryRegionFldsCond.IsUpdated(convQryRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvQryRegionFldsCond.dicFldComparisonOp[convQryRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQryRegionFlds.PrjId, objvQryRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v查询区域字段(vQryRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQryRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vQryRegionFldsApi";

 public clsvQryRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQryRegionFldsEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQryRegionFldsEN objvQryRegionFldsEN;
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
objvQryRegionFldsEN = JsonConvert.DeserializeObject<clsvQryRegionFldsEN>(strJson);
return objvQryRegionFldsEN;
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
public static clsvQryRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQryRegionFldsEN objvQryRegionFldsEN;
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
objvQryRegionFldsEN = JsonConvert.DeserializeObject<clsvQryRegionFldsEN>(strJson);
return objvQryRegionFldsEN;
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
public static clsvQryRegionFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQryRegionFldsEN._CurrTabName);
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvQryRegionFldsEN> arrvQryRegionFldsObjLst_Sel =
from objvQryRegionFldsEN in arrvQryRegionFldsObjLstCache
where objvQryRegionFldsEN.mId == lngmId 
select objvQryRegionFldsEN;
if (arrvQryRegionFldsObjLst_Sel.Count() == 0)
{
   clsvQryRegionFldsEN obj = clsvQryRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQryRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQryRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
public static List<clsvQryRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
public static IEnumerable<clsvQryRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQryRegionFldsEN._CurrTabName);
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvQryRegionFldsEN> arrvQryRegionFldsObjLst_Sel =
from objvQryRegionFldsEN in arrvQryRegionFldsObjLstCache
where arrMId.Contains(objvQryRegionFldsEN.mId)
select objvQryRegionFldsEN;
return arrvQryRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQryRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
public static List<clsvQryRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
public static List<clsvQryRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
public static List<clsvQryRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQryRegionFldsEN>>(strJson);
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
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <param name = "objvQryRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvQryRegionFldsEN objvQryRegionFldsENS, clsvQryRegionFldsEN objvQryRegionFldsENT)
{
try
{
objvQryRegionFldsENT.mId = objvQryRegionFldsENS.mId; //mId
objvQryRegionFldsENT.RegionId = objvQryRegionFldsENS.RegionId; //区域Id
objvQryRegionFldsENT.RegionName = objvQryRegionFldsENS.RegionName; //区域名称
objvQryRegionFldsENT.TabId = objvQryRegionFldsENS.TabId; //表ID
objvQryRegionFldsENT.TabName = objvQryRegionFldsENS.TabName; //表名
objvQryRegionFldsENT.FldId = objvQryRegionFldsENS.FldId; //字段Id
objvQryRegionFldsENT.FldName = objvQryRegionFldsENS.FldName; //字段名
objvQryRegionFldsENT.LabelCaption = objvQryRegionFldsENS.LabelCaption; //标签标题
objvQryRegionFldsENT.CtlTypeId = objvQryRegionFldsENS.CtlTypeId; //控件类型号
objvQryRegionFldsENT.CtlTypeName = objvQryRegionFldsENS.CtlTypeName; //控件类型名
objvQryRegionFldsENT.CtlCnName = objvQryRegionFldsENS.CtlCnName; //控件类型中文名
objvQryRegionFldsENT.CtlTypeAbbr = objvQryRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvQryRegionFldsENT.VarId = objvQryRegionFldsENS.VarId; //变量Id
objvQryRegionFldsENT.DsTabId = objvQryRegionFldsENS.DsTabId; //数据源表ID
objvQryRegionFldsENT.QueryOptionId = objvQryRegionFldsENS.QueryOptionId; //查询方式Id
objvQryRegionFldsENT.QueryOptionName = objvQryRegionFldsENS.QueryOptionName; //查询方式名称
objvQryRegionFldsENT.DdlItemsOptionId = objvQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvQryRegionFldsENT.DdlItemsOptionName = objvQryRegionFldsENS.DdlItemsOptionName; //下拉选项名
objvQryRegionFldsENT.DsSqlStr = objvQryRegionFldsENS.DsSqlStr; //数据源SQL串
objvQryRegionFldsENT.ItemsString = objvQryRegionFldsENS.ItemsString; //列表项串
objvQryRegionFldsENT.DsCondStr = objvQryRegionFldsENS.DsCondStr; //数据源条件串
objvQryRegionFldsENT.ColSpan = objvQryRegionFldsENS.ColSpan; //跨列数
objvQryRegionFldsENT.Width = objvQryRegionFldsENS.Width; //宽
objvQryRegionFldsENT.SeqNum = objvQryRegionFldsENS.SeqNum; //字段序号
objvQryRegionFldsENT.ChangeEvent = objvQryRegionFldsENS.ChangeEvent; //Change事件
objvQryRegionFldsENT.ClickEvent = objvQryRegionFldsENS.ClickEvent; //Click事件
objvQryRegionFldsENT.InUse = objvQryRegionFldsENS.InUse; //是否在用
objvQryRegionFldsENT.UpdUser = objvQryRegionFldsENS.UpdUser; //修改者
objvQryRegionFldsENT.UpdDate = objvQryRegionFldsENS.UpdDate; //修改日期
objvQryRegionFldsENT.Memo = objvQryRegionFldsENS.Memo; //说明
objvQryRegionFldsENT.PrjId = objvQryRegionFldsENS.PrjId; //工程ID
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
public static DataTable ToDataTable(List<clsvQryRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQryRegionFldsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQryRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQryRegionFldsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQryRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQryRegionFldsEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQryRegionFldsEN._CurrTabName);
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
public static List<clsvQryRegionFldsEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvQryRegionFldsEN._CurrTabName;
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvQryRegionFldsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQryRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQryRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQryRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.QueryOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.QueryOptionName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.DdlItemsOptionName, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(convQryRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convQryRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQryRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQryRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQryRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvQryRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQryRegionFlds.mId] = objInFor[convQryRegionFlds.mId];
objDR[convQryRegionFlds.RegionId] = objInFor[convQryRegionFlds.RegionId];
objDR[convQryRegionFlds.RegionName] = objInFor[convQryRegionFlds.RegionName];
objDR[convQryRegionFlds.TabId] = objInFor[convQryRegionFlds.TabId];
objDR[convQryRegionFlds.TabName] = objInFor[convQryRegionFlds.TabName];
objDR[convQryRegionFlds.FldId] = objInFor[convQryRegionFlds.FldId];
objDR[convQryRegionFlds.FldName] = objInFor[convQryRegionFlds.FldName];
objDR[convQryRegionFlds.LabelCaption] = objInFor[convQryRegionFlds.LabelCaption];
objDR[convQryRegionFlds.CtlTypeId] = objInFor[convQryRegionFlds.CtlTypeId];
objDR[convQryRegionFlds.CtlTypeName] = objInFor[convQryRegionFlds.CtlTypeName];
objDR[convQryRegionFlds.CtlCnName] = objInFor[convQryRegionFlds.CtlCnName];
objDR[convQryRegionFlds.CtlTypeAbbr] = objInFor[convQryRegionFlds.CtlTypeAbbr];
objDR[convQryRegionFlds.VarId] = objInFor[convQryRegionFlds.VarId];
objDR[convQryRegionFlds.DsTabId] = objInFor[convQryRegionFlds.DsTabId];
objDR[convQryRegionFlds.QueryOptionId] = objInFor[convQryRegionFlds.QueryOptionId];
objDR[convQryRegionFlds.QueryOptionName] = objInFor[convQryRegionFlds.QueryOptionName];
objDR[convQryRegionFlds.DdlItemsOptionId] = objInFor[convQryRegionFlds.DdlItemsOptionId];
objDR[convQryRegionFlds.DdlItemsOptionName] = objInFor[convQryRegionFlds.DdlItemsOptionName];
objDR[convQryRegionFlds.DsSqlStr] = objInFor[convQryRegionFlds.DsSqlStr];
objDR[convQryRegionFlds.ItemsString] = objInFor[convQryRegionFlds.ItemsString];
objDR[convQryRegionFlds.DsCondStr] = objInFor[convQryRegionFlds.DsCondStr];
objDR[convQryRegionFlds.ColSpan] = objInFor[convQryRegionFlds.ColSpan];
objDR[convQryRegionFlds.Width] = objInFor[convQryRegionFlds.Width];
objDR[convQryRegionFlds.SeqNum] = objInFor[convQryRegionFlds.SeqNum];
objDR[convQryRegionFlds.ChangeEvent] = objInFor[convQryRegionFlds.ChangeEvent];
objDR[convQryRegionFlds.ClickEvent] = objInFor[convQryRegionFlds.ClickEvent];
objDR[convQryRegionFlds.InUse] = objInFor[convQryRegionFlds.InUse];
objDR[convQryRegionFlds.UpdUser] = objInFor[convQryRegionFlds.UpdUser];
objDR[convQryRegionFlds.UpdDate] = objInFor[convQryRegionFlds.UpdDate];
objDR[convQryRegionFlds.Memo] = objInFor[convQryRegionFlds.Memo];
objDR[convQryRegionFlds.PrjId] = objInFor[convQryRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}