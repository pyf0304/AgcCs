
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsBL
 表名:vQryRegionFlds(00050151)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:58
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
public static class  clsvQryRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQryRegionFldsEN GetObj(this K_mId_vQryRegionFlds myKey)
{
clsvQryRegionFldsEN objvQryRegionFldsEN = clsvQryRegionFldsBL.vQryRegionFldsDA.GetObjBymId(myKey.Value);
return objvQryRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetRegionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convQryRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convQryRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convQryRegionFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetRegionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convQryRegionFlds.RegionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convQryRegionFlds.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetTabId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convQryRegionFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQryRegionFlds.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetTabName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convQryRegionFlds.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convQryRegionFlds.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetFldId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convQryRegionFlds.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convQryRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convQryRegionFlds.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetFldName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convQryRegionFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convQryRegionFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetLabelCaption(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convQryRegionFlds.LabelCaption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convQryRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convQryRegionFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convQryRegionFlds.CtlTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convQryRegionFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlCnName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convQryRegionFlds.CtlCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convQryRegionFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetCtlTypeAbbr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, convQryRegionFlds.CtlTypeAbbr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convQryRegionFlds.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetVarId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, convQryRegionFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convQryRegionFlds.VarId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsTabId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsTabId, convQryRegionFlds.DsTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, convQryRegionFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convQryRegionFlds.DsTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetQueryOptionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strQueryOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQueryOptionId, convQryRegionFlds.QueryOptionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQueryOptionId, 2, convQryRegionFlds.QueryOptionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetQueryOptionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strQueryOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQueryOptionName, 20, convQryRegionFlds.QueryOptionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDdlItemsOptionId(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionId, convQryRegionFlds.DdlItemsOptionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convQryRegionFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convQryRegionFlds.DdlItemsOptionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDdlItemsOptionName(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDdlItemsOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionName, 20, convQryRegionFlds.DdlItemsOptionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsSqlStr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convQryRegionFlds.DsSqlStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetItemsString(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, convQryRegionFlds.ItemsString);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetDsCondStr(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convQryRegionFlds.DsCondStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetColSpan(this clsvQryRegionFldsEN objvQryRegionFldsEN, int? intColSpan, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetWidth(this clsvQryRegionFldsEN objvQryRegionFldsEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetSeqNum(this clsvQryRegionFldsEN objvQryRegionFldsEN, int? intSeqNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetChangeEvent(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convQryRegionFlds.ChangeEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetClickEvent(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convQryRegionFlds.ClickEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetUpdUser(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQryRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQryRegionFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetUpdDate(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQryRegionFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQryRegionFldsEN SetMemo(this clsvQryRegionFldsEN objvQryRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQryRegionFlds.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <param name = "objvQryRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvQryRegionFldsEN objvQryRegionFldsENS, clsvQryRegionFldsEN objvQryRegionFldsENT)
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
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvQryRegionFldsEN:objvQryRegionFldsENT</returns>
 public static clsvQryRegionFldsEN CopyTo(this clsvQryRegionFldsEN objvQryRegionFldsENS)
{
try
{
 clsvQryRegionFldsEN objvQryRegionFldsENT = new clsvQryRegionFldsEN()
{
mId = objvQryRegionFldsENS.mId, //mId
RegionId = objvQryRegionFldsENS.RegionId, //区域Id
RegionName = objvQryRegionFldsENS.RegionName, //区域名称
TabId = objvQryRegionFldsENS.TabId, //表ID
TabName = objvQryRegionFldsENS.TabName, //表名
FldId = objvQryRegionFldsENS.FldId, //字段Id
FldName = objvQryRegionFldsENS.FldName, //字段名
LabelCaption = objvQryRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objvQryRegionFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvQryRegionFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvQryRegionFldsENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvQryRegionFldsENS.CtlTypeAbbr, //控件类型缩写
VarId = objvQryRegionFldsENS.VarId, //变量Id
DsTabId = objvQryRegionFldsENS.DsTabId, //数据源表ID
QueryOptionId = objvQryRegionFldsENS.QueryOptionId, //查询方式Id
QueryOptionName = objvQryRegionFldsENS.QueryOptionName, //查询方式名称
DdlItemsOptionId = objvQryRegionFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DdlItemsOptionName = objvQryRegionFldsENS.DdlItemsOptionName, //下拉选项名
DsSqlStr = objvQryRegionFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objvQryRegionFldsENS.ItemsString, //列表项串
DsCondStr = objvQryRegionFldsENS.DsCondStr, //数据源条件串
ColSpan = objvQryRegionFldsENS.ColSpan, //跨列数
Width = objvQryRegionFldsENS.Width, //宽
SeqNum = objvQryRegionFldsENS.SeqNum, //字段序号
ChangeEvent = objvQryRegionFldsENS.ChangeEvent, //Change事件
ClickEvent = objvQryRegionFldsENS.ClickEvent, //Click事件
InUse = objvQryRegionFldsENS.InUse, //是否在用
UpdUser = objvQryRegionFldsENS.UpdUser, //修改者
UpdDate = objvQryRegionFldsENS.UpdDate, //修改日期
Memo = objvQryRegionFldsENS.Memo, //说明
PrjId = objvQryRegionFldsENS.PrjId, //工程ID
};
 return objvQryRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvQryRegionFldsEN objvQryRegionFldsEN)
{
 clsvQryRegionFldsBL.vQryRegionFldsDA.CheckProperty4Condition(objvQryRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQryRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v查询区域字段(vQryRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQryRegionFldsBL
{
public static RelatedActions_vQryRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQryRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQryRegionFldsDA vQryRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQryRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQryRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvQryRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQryRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vQryRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQryRegionFldsDA.GetDataTable_vQryRegionFlds(strWhereCond);
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
objDT = vQryRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vQryRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQryRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQryRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQryRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vQryRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQryRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQryRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvQryRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
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
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQryRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvQryRegionFldsEN._CurrTabName, strPrjId);
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvQryRegionFldsEN> arrvQryRegionFldsObjLst_Sel =
arrvQryRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQryRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQryRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
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
public static List<clsvQryRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQryRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQryRegionFldsEN> GetSubObjLstCache(clsvQryRegionFldsEN objvQryRegionFldsCond)
{
 string strPrjId = objvQryRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQryRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQryRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvQryRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQryRegionFlds.AttributeName)
{
if (objvQryRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvQryRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQryRegionFldsCond[strFldName].ToString());
}
else
{
if (objvQryRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQryRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQryRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQryRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQryRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQryRegionFldsCond[strFldName]));
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
public static List<clsvQryRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
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
public static List<clsvQryRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
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
List<clsvQryRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQryRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQryRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQryRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
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
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
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
public static List<clsvQryRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQryRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQryRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
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
public static List<clsvQryRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQryRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQryRegionFlds(ref clsvQryRegionFldsEN objvQryRegionFldsEN)
{
bool bolResult = vQryRegionFldsDA.GetvQryRegionFlds(ref objvQryRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQryRegionFldsEN GetObjBymId(long lngmId)
{
clsvQryRegionFldsEN objvQryRegionFldsEN = vQryRegionFldsDA.GetObjBymId(lngmId);
return objvQryRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQryRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQryRegionFldsEN objvQryRegionFldsEN = vQryRegionFldsDA.GetFirstObj(strWhereCond);
 return objvQryRegionFldsEN;
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
public static clsvQryRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQryRegionFldsEN objvQryRegionFldsEN = vQryRegionFldsDA.GetObjByDataRow(objRow);
 return objvQryRegionFldsEN;
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
public static clsvQryRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQryRegionFldsEN objvQryRegionFldsEN = vQryRegionFldsDA.GetObjByDataRow(objRow);
 return objvQryRegionFldsEN;
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
 /// <param name = "lstvQryRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQryRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsvQryRegionFldsEN> lstvQryRegionFldsObjLst)
{
foreach (clsvQryRegionFldsEN objvQryRegionFldsEN in lstvQryRegionFldsObjLst)
{
if (objvQryRegionFldsEN.mId == lngmId)
{
return objvQryRegionFldsEN;
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
 lngmId = new clsvQryRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = vQryRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vQryRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQryRegionFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvQryRegionFldsDA.IsExistTable();
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
 bolIsExist = vQryRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvQryRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvQryRegionFldsEN objvQryRegionFldsEN)
{
try
{
objvQryRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQryRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQryRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.mId = objvQryRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(convQryRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.RegionId = objvQryRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convQryRegionFlds.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.RegionName = objvQryRegionFldsEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convQryRegionFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.TabId = objvQryRegionFldsEN.TabId == "[null]" ? null :  objvQryRegionFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convQryRegionFlds.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.TabName = objvQryRegionFldsEN.TabName; //表名
}
if (arrFldSet.Contains(convQryRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.FldId = objvQryRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convQryRegionFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.FldName = objvQryRegionFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convQryRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.LabelCaption = objvQryRegionFldsEN.LabelCaption == "[null]" ? null :  objvQryRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(convQryRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.CtlTypeId = objvQryRegionFldsEN.CtlTypeId == "[null]" ? null :  objvQryRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convQryRegionFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.CtlTypeName = objvQryRegionFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convQryRegionFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.CtlCnName = objvQryRegionFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convQryRegionFlds.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.CtlTypeAbbr = objvQryRegionFldsEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convQryRegionFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.VarId = objvQryRegionFldsEN.VarId == "[null]" ? null :  objvQryRegionFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(convQryRegionFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.DsTabId = objvQryRegionFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(convQryRegionFlds.QueryOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.QueryOptionId = objvQryRegionFldsEN.QueryOptionId; //查询方式Id
}
if (arrFldSet.Contains(convQryRegionFlds.QueryOptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.QueryOptionName = objvQryRegionFldsEN.QueryOptionName == "[null]" ? null :  objvQryRegionFldsEN.QueryOptionName; //查询方式名称
}
if (arrFldSet.Contains(convQryRegionFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.DdlItemsOptionId = objvQryRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(convQryRegionFlds.DdlItemsOptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.DdlItemsOptionName = objvQryRegionFldsEN.DdlItemsOptionName == "[null]" ? null :  objvQryRegionFldsEN.DdlItemsOptionName; //下拉选项名
}
if (arrFldSet.Contains(convQryRegionFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.DsSqlStr = objvQryRegionFldsEN.DsSqlStr == "[null]" ? null :  objvQryRegionFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(convQryRegionFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.ItemsString = objvQryRegionFldsEN.ItemsString == "[null]" ? null :  objvQryRegionFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(convQryRegionFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.DsCondStr = objvQryRegionFldsEN.DsCondStr == "[null]" ? null :  objvQryRegionFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(convQryRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.ColSpan = objvQryRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(convQryRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.Width = objvQryRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(convQryRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.SeqNum = objvQryRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convQryRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.ChangeEvent = objvQryRegionFldsEN.ChangeEvent == "[null]" ? null :  objvQryRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(convQryRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.ClickEvent = objvQryRegionFldsEN.ClickEvent == "[null]" ? null :  objvQryRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(convQryRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.InUse = objvQryRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQryRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.UpdUser = objvQryRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convQryRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.UpdDate = objvQryRegionFldsEN.UpdDate == "[null]" ? null :  objvQryRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQryRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.Memo = objvQryRegionFldsEN.Memo == "[null]" ? null :  objvQryRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convQryRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQryRegionFldsEN.PrjId = objvQryRegionFldsEN.PrjId == "[null]" ? null :  objvQryRegionFldsEN.PrjId; //工程ID
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
 /// <param name = "objvQryRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQryRegionFldsEN objvQryRegionFldsEN)
{
try
{
if (objvQryRegionFldsEN.TabId == "[null]") objvQryRegionFldsEN.TabId = null; //表ID
if (objvQryRegionFldsEN.LabelCaption == "[null]") objvQryRegionFldsEN.LabelCaption = null; //标签标题
if (objvQryRegionFldsEN.CtlTypeId == "[null]") objvQryRegionFldsEN.CtlTypeId = null; //控件类型号
if (objvQryRegionFldsEN.VarId == "[null]") objvQryRegionFldsEN.VarId = null; //变量Id
if (objvQryRegionFldsEN.QueryOptionName == "[null]") objvQryRegionFldsEN.QueryOptionName = null; //查询方式名称
if (objvQryRegionFldsEN.DdlItemsOptionName == "[null]") objvQryRegionFldsEN.DdlItemsOptionName = null; //下拉选项名
if (objvQryRegionFldsEN.DsSqlStr == "[null]") objvQryRegionFldsEN.DsSqlStr = null; //数据源SQL串
if (objvQryRegionFldsEN.ItemsString == "[null]") objvQryRegionFldsEN.ItemsString = null; //列表项串
if (objvQryRegionFldsEN.DsCondStr == "[null]") objvQryRegionFldsEN.DsCondStr = null; //数据源条件串
if (objvQryRegionFldsEN.ChangeEvent == "[null]") objvQryRegionFldsEN.ChangeEvent = null; //Change事件
if (objvQryRegionFldsEN.ClickEvent == "[null]") objvQryRegionFldsEN.ClickEvent = null; //Click事件
if (objvQryRegionFldsEN.UpdDate == "[null]") objvQryRegionFldsEN.UpdDate = null; //修改日期
if (objvQryRegionFldsEN.Memo == "[null]") objvQryRegionFldsEN.Memo = null; //说明
if (objvQryRegionFldsEN.PrjId == "[null]") objvQryRegionFldsEN.PrjId = null; //工程ID
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
public static void CheckProperty4Condition(clsvQryRegionFldsEN objvQryRegionFldsEN)
{
 vQryRegionFldsDA.CheckProperty4Condition(objvQryRegionFldsEN);
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
if (clsDDLItemsOptionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDDLItemsOptionBL没有刷新缓存机制(clsDDLItemsOptionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQueryOptionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQueryOptionBL没有刷新缓存机制(clsQueryOptionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQryRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQryRegionFldsBL没有刷新缓存机制(clsQryRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQryRegionFldsObjLstCache == null)
//{
//arrvQryRegionFldsObjLstCache = vQryRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQryRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvQryRegionFldsEN._CurrTabName, strPrjId);
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvQryRegionFldsEN> arrvQryRegionFldsObjLst_Sel =
arrvQryRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQryRegionFldsObjLst_Sel.Count() == 0)
{
   clsvQryRegionFldsEN obj = clsvQryRegionFldsBL.GetObjBymId(lngmId);
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
return arrvQryRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQryRegionFldsEN> GetAllvQryRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvQryRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQryRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvQryRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvQryRegionFldsEN> arrvQryRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQryRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQryRegionFldsEN._CurrTabName, strPrjId);
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
if (strInFldName != convQryRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQryRegionFlds.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQryRegionFlds.AttributeName));
throw new Exception(strMsg);
}
var objvQryRegionFlds = clsvQryRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvQryRegionFlds == null) return "";
return objvQryRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvQryRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvQryRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQryRegionFldsDA.GetRecCount();
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
int intRecCount = clsvQryRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQryRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQryRegionFldsEN objvQryRegionFldsCond)
{
 string strPrjId = objvQryRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQryRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQryRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvQryRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQryRegionFlds.AttributeName)
{
if (objvQryRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvQryRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQryRegionFldsCond[strFldName].ToString());
}
else
{
if (objvQryRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQryRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQryRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQryRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQryRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQryRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvQryRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQryRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQryRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}