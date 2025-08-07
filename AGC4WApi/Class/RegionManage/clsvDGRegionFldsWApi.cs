
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsWApi
 表名:vDGRegionFlds(00050201)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvDGRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetmId(this clsvDGRegionFldsEN objvDGRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objvDGRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.mId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.mId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.mId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetRegionId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convDGRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convDGRegionFlds.RegionId);
objvDGRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.RegionId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.RegionId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.RegionId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetRegionName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionName, 50, convDGRegionFlds.RegionName);
objvDGRegionFldsEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.RegionName) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.RegionName, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.RegionName] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetTabId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convDGRegionFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDGRegionFlds.TabId);
objvDGRegionFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.TabId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.TabId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.TabId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetFldId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convDGRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDGRegionFlds.FldId);
objvDGRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.FldId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.FldId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.FldId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetFldName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDGRegionFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convDGRegionFlds.FldName);
objvDGRegionFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.FldName) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.FldName, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.FldName] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSortExpression">排序表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetSortExpression(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strSortExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSortExpression, 50, convDGRegionFlds.SortExpression);
objvDGRegionFldsEN.SortExpression = strSortExpression; //排序表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.SortExpression) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.SortExpression, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.SortExpression] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetSeqNum(this clsvDGRegionFldsEN objvDGRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, convDGRegionFlds.SeqNum);
objvDGRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.SeqNum) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strHeaderText">列头</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetHeaderText(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strHeaderText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeaderText, 100, convDGRegionFlds.HeaderText);
objvDGRegionFldsEN.HeaderText = strHeaderText; //列头
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.HeaderText) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.HeaderText, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.HeaderText] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strToolTipText">提示文字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetToolTipText(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strToolTipText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strToolTipText, 150, convDGRegionFlds.ToolTipText);
objvDGRegionFldsEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.ToolTipText) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.ToolTipText, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.ToolTipText] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlTypeId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convDGRegionFlds.CtlTypeId);
objvDGRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.CtlTypeId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlTypeName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convDGRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convDGRegionFlds.CtlTypeName);
objvDGRegionFldsEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.CtlTypeName) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.CtlTypeName, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.CtlTypeName] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlCnName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convDGRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convDGRegionFlds.CtlCnName);
objvDGRegionFldsEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.CtlCnName) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.CtlCnName, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.CtlCnName] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgFuncTypeId">Dg功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetDgFuncTypeId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strDgFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgFuncTypeId, convDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldLen(strDgFuncTypeId, 4, convDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldForeignKey(strDgFuncTypeId, 4, convDGRegionFlds.DgFuncTypeId);
objvDGRegionFldsEN.DgFuncTypeId = strDgFuncTypeId; //Dg功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.DgFuncTypeId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.DgFuncTypeId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.DgFuncTypeId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgFuncTypeName">Dg功能类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetDgFuncTypeName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strDgFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgFuncTypeName, convDGRegionFlds.DgFuncTypeName);
clsCheckSql.CheckFieldLen(strDgFuncTypeName, 30, convDGRegionFlds.DgFuncTypeName);
objvDGRegionFldsEN.DgFuncTypeName = strDgFuncTypeName; //Dg功能类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.DgFuncTypeName) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.DgFuncTypeName, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.DgFuncTypeName] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetIsNeedSort(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, convDGRegionFlds.IsNeedSort);
objvDGRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.IsNeedSort) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultSort">是否默认排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetIsDefaultSort(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
objvDGRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.IsDefaultSort) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTransToChkBox">是否转换成CheckBox</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetIsTransToChkBox(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolIsTransToChkBox, string strComparisonOp="")
	{
objvDGRegionFldsEN.IsTransToChkBox = bolIsTransToChkBox; //是否转换成CheckBox
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.IsTransToChkBox) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.IsTransToChkBox, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.IsTransToChkBox] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetIsVisible(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolIsVisible, string strComparisonOp="")
	{
objvDGRegionFldsEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.IsVisible) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.IsVisible, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.IsVisible] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFuncFld">是否功能字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetIsFuncFld(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolIsFuncFld, string strComparisonOp="")
	{
objvDGRegionFldsEN.IsFuncFld = bolIsFuncFld; //是否功能字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.IsFuncFld) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.IsFuncFld, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.IsFuncFld] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetInUse(this clsvDGRegionFldsEN objvDGRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvDGRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.InUse) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.InUse, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.InUse] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetUpdUser(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDGRegionFlds.UpdUser);
objvDGRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.UpdUser) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetUpdDate(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDGRegionFlds.UpdDate);
objvDGRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.UpdDate) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetMemo(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDGRegionFlds.Memo);
objvDGRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.Memo) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.Memo, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.Memo] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetPrjId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDGRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDGRegionFlds.PrjId);
objvDGRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDGRegionFldsEN.dicFldComparisonOp.ContainsKey(convDGRegionFlds.PrjId) == false)
{
objvDGRegionFldsEN.dicFldComparisonOp.Add(convDGRegionFlds.PrjId, strComparisonOp);
}
else
{
objvDGRegionFldsEN.dicFldComparisonOp[convDGRegionFlds.PrjId] = strComparisonOp;
}
}
return objvDGRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDGRegionFldsEN objvDGRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.mId) == true)
{
string strComparisonOpmId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convDGRegionFlds.mId, objvDGRegionFldsCond.mId, strComparisonOpmId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.RegionId, objvDGRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.RegionName) == true)
{
string strComparisonOpRegionName = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.RegionName, objvDGRegionFldsCond.RegionName, strComparisonOpRegionName);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.TabId) == true)
{
string strComparisonOpTabId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.TabId, objvDGRegionFldsCond.TabId, strComparisonOpTabId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.FldId, objvDGRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.FldName) == true)
{
string strComparisonOpFldName = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.FldName, objvDGRegionFldsCond.FldName, strComparisonOpFldName);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.SortExpression) == true)
{
string strComparisonOpSortExpression = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.SortExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.SortExpression, objvDGRegionFldsCond.SortExpression, strComparisonOpSortExpression);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDGRegionFlds.SeqNum, objvDGRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.HeaderText) == true)
{
string strComparisonOpHeaderText = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.HeaderText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.HeaderText, objvDGRegionFldsCond.HeaderText, strComparisonOpHeaderText);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.ToolTipText) == true)
{
string strComparisonOpToolTipText = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.ToolTipText, objvDGRegionFldsCond.ToolTipText, strComparisonOpToolTipText);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.CtlTypeId, objvDGRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.CtlTypeName, objvDGRegionFldsCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.CtlCnName, objvDGRegionFldsCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.DgFuncTypeId) == true)
{
string strComparisonOpDgFuncTypeId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.DgFuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.DgFuncTypeId, objvDGRegionFldsCond.DgFuncTypeId, strComparisonOpDgFuncTypeId);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.DgFuncTypeName) == true)
{
string strComparisonOpDgFuncTypeName = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.DgFuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.DgFuncTypeName, objvDGRegionFldsCond.DgFuncTypeName, strComparisonOpDgFuncTypeName);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.IsNeedSort) == true)
{
if (objvDGRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.IsNeedSort);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.IsDefaultSort) == true)
{
if (objvDGRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.IsDefaultSort);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.IsTransToChkBox) == true)
{
if (objvDGRegionFldsCond.IsTransToChkBox == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.IsTransToChkBox);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.IsTransToChkBox);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.IsVisible) == true)
{
if (objvDGRegionFldsCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.IsVisible);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.IsFuncFld) == true)
{
if (objvDGRegionFldsCond.IsFuncFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.IsFuncFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.IsFuncFld);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.InUse) == true)
{
if (objvDGRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDGRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDGRegionFlds.InUse);
}
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.UpdUser, objvDGRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.UpdDate, objvDGRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.Memo, objvDGRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvDGRegionFldsCond.IsUpdated(convDGRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvDGRegionFldsCond.dicFldComparisonOp[convDGRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDGRegionFlds.PrjId, objvDGRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vDG区域字段(vDGRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDGRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vDGRegionFldsApi";

 public clsvDGRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDGRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvDGRegionFldsEN objvDGRegionFldsEN;
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
objvDGRegionFldsEN = JsonConvert.DeserializeObject<clsvDGRegionFldsEN>(strJson);
return objvDGRegionFldsEN;
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
public static clsvDGRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDGRegionFldsEN objvDGRegionFldsEN;
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
objvDGRegionFldsEN = JsonConvert.DeserializeObject<clsvDGRegionFldsEN>(strJson);
return objvDGRegionFldsEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDGRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
public static List<clsvDGRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDGRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
public static List<clsvDGRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
public static List<clsvDGRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
public static List<clsvDGRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDGRegionFldsEN>>(strJson);
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
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <param name = "objvDGRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvDGRegionFldsEN objvDGRegionFldsENS, clsvDGRegionFldsEN objvDGRegionFldsENT)
{
try
{
objvDGRegionFldsENT.mId = objvDGRegionFldsENS.mId; //mId
objvDGRegionFldsENT.RegionId = objvDGRegionFldsENS.RegionId; //区域Id
objvDGRegionFldsENT.RegionName = objvDGRegionFldsENS.RegionName; //区域名称
objvDGRegionFldsENT.TabId = objvDGRegionFldsENS.TabId; //表ID
objvDGRegionFldsENT.FldId = objvDGRegionFldsENS.FldId; //字段Id
objvDGRegionFldsENT.FldName = objvDGRegionFldsENS.FldName; //字段名
objvDGRegionFldsENT.SortExpression = objvDGRegionFldsENS.SortExpression; //排序表达式
objvDGRegionFldsENT.SeqNum = objvDGRegionFldsENS.SeqNum; //字段序号
objvDGRegionFldsENT.HeaderText = objvDGRegionFldsENS.HeaderText; //列头
objvDGRegionFldsENT.ToolTipText = objvDGRegionFldsENS.ToolTipText; //提示文字
objvDGRegionFldsENT.CtlTypeId = objvDGRegionFldsENS.CtlTypeId; //控件类型号
objvDGRegionFldsENT.CtlTypeName = objvDGRegionFldsENS.CtlTypeName; //控件类型名
objvDGRegionFldsENT.CtlCnName = objvDGRegionFldsENS.CtlCnName; //控件类型中文名
objvDGRegionFldsENT.DgFuncTypeId = objvDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objvDGRegionFldsENT.DgFuncTypeName = objvDGRegionFldsENS.DgFuncTypeName; //Dg功能类型名
objvDGRegionFldsENT.IsNeedSort = objvDGRegionFldsENS.IsNeedSort; //是否需要排序
objvDGRegionFldsENT.IsDefaultSort = objvDGRegionFldsENS.IsDefaultSort; //是否默认排序
objvDGRegionFldsENT.IsTransToChkBox = objvDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objvDGRegionFldsENT.IsVisible = objvDGRegionFldsENS.IsVisible; //是否显示
objvDGRegionFldsENT.IsFuncFld = objvDGRegionFldsENS.IsFuncFld; //是否功能字段
objvDGRegionFldsENT.InUse = objvDGRegionFldsENS.InUse; //是否在用
objvDGRegionFldsENT.UpdUser = objvDGRegionFldsENS.UpdUser; //修改者
objvDGRegionFldsENT.UpdDate = objvDGRegionFldsENS.UpdDate; //修改日期
objvDGRegionFldsENT.Memo = objvDGRegionFldsENS.Memo; //说明
objvDGRegionFldsENT.PrjId = objvDGRegionFldsENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvDGRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDGRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDGRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDGRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDGRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDGRegionFldsEN._AttributeName)
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

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvDGRegionFldsEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDGRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDGRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDGRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.SortExpression, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convDGRegionFlds.HeaderText, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.ToolTipText, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.DgFuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.DgFuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.IsDefaultSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.IsTransToChkBox, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.IsFuncFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDGRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convDGRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvDGRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDGRegionFlds.mId] = objInFor[convDGRegionFlds.mId];
objDR[convDGRegionFlds.RegionId] = objInFor[convDGRegionFlds.RegionId];
objDR[convDGRegionFlds.RegionName] = objInFor[convDGRegionFlds.RegionName];
objDR[convDGRegionFlds.TabId] = objInFor[convDGRegionFlds.TabId];
objDR[convDGRegionFlds.FldId] = objInFor[convDGRegionFlds.FldId];
objDR[convDGRegionFlds.FldName] = objInFor[convDGRegionFlds.FldName];
objDR[convDGRegionFlds.SortExpression] = objInFor[convDGRegionFlds.SortExpression];
objDR[convDGRegionFlds.SeqNum] = objInFor[convDGRegionFlds.SeqNum];
objDR[convDGRegionFlds.HeaderText] = objInFor[convDGRegionFlds.HeaderText];
objDR[convDGRegionFlds.ToolTipText] = objInFor[convDGRegionFlds.ToolTipText];
objDR[convDGRegionFlds.CtlTypeId] = objInFor[convDGRegionFlds.CtlTypeId];
objDR[convDGRegionFlds.CtlTypeName] = objInFor[convDGRegionFlds.CtlTypeName];
objDR[convDGRegionFlds.CtlCnName] = objInFor[convDGRegionFlds.CtlCnName];
objDR[convDGRegionFlds.DgFuncTypeId] = objInFor[convDGRegionFlds.DgFuncTypeId];
objDR[convDGRegionFlds.DgFuncTypeName] = objInFor[convDGRegionFlds.DgFuncTypeName];
objDR[convDGRegionFlds.IsNeedSort] = objInFor[convDGRegionFlds.IsNeedSort];
objDR[convDGRegionFlds.IsDefaultSort] = objInFor[convDGRegionFlds.IsDefaultSort];
objDR[convDGRegionFlds.IsTransToChkBox] = objInFor[convDGRegionFlds.IsTransToChkBox];
objDR[convDGRegionFlds.IsVisible] = objInFor[convDGRegionFlds.IsVisible];
objDR[convDGRegionFlds.IsFuncFld] = objInFor[convDGRegionFlds.IsFuncFld];
objDR[convDGRegionFlds.InUse] = objInFor[convDGRegionFlds.InUse];
objDR[convDGRegionFlds.UpdUser] = objInFor[convDGRegionFlds.UpdUser];
objDR[convDGRegionFlds.UpdDate] = objInFor[convDGRegionFlds.UpdDate];
objDR[convDGRegionFlds.Memo] = objInFor[convDGRegionFlds.Memo];
objDR[convDGRegionFlds.PrjId] = objInFor[convDGRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}