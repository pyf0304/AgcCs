
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsBL
 表名:vDGRegionFlds(00050201)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvDGRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDGRegionFldsEN GetObj(this K_mId_vDGRegionFlds myKey)
{
clsvDGRegionFldsEN objvDGRegionFldsEN = clsvDGRegionFldsBL.vDGRegionFldsDA.GetObjBymId(myKey.Value);
return objvDGRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetRegionId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convDGRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convDGRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convDGRegionFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetRegionName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convDGRegionFlds.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetTabId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDGRegionFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDGRegionFlds.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetFldId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convDGRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDGRegionFlds.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetFldName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDGRegionFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convDGRegionFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetSortExpression(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strSortExpression, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSortExpression, 50, convDGRegionFlds.SortExpression);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetHeaderText(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strHeaderText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeaderText, 100, convDGRegionFlds.HeaderText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetToolTipText(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strToolTipText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strToolTipText, 150, convDGRegionFlds.ToolTipText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlTypeId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convDGRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convDGRegionFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlTypeName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, convDGRegionFlds.CtlTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convDGRegionFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetCtlCnName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, convDGRegionFlds.CtlCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convDGRegionFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetDgFuncTypeId(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strDgFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgFuncTypeId, convDGRegionFlds.DgFuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgFuncTypeId, 4, convDGRegionFlds.DgFuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDgFuncTypeId, 4, convDGRegionFlds.DgFuncTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetDgFuncTypeName(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strDgFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgFuncTypeName, convDGRegionFlds.DgFuncTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgFuncTypeName, 30, convDGRegionFlds.DgFuncTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetUpdUser(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convDGRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDGRegionFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetUpdDate(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDGRegionFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDGRegionFldsEN SetMemo(this clsvDGRegionFldsEN objvDGRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDGRegionFlds.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <param name = "objvDGRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvDGRegionFldsEN objvDGRegionFldsENS, clsvDGRegionFldsEN objvDGRegionFldsENT)
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
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvDGRegionFldsEN:objvDGRegionFldsENT</returns>
 public static clsvDGRegionFldsEN CopyTo(this clsvDGRegionFldsEN objvDGRegionFldsENS)
{
try
{
 clsvDGRegionFldsEN objvDGRegionFldsENT = new clsvDGRegionFldsEN()
{
mId = objvDGRegionFldsENS.mId, //mId
RegionId = objvDGRegionFldsENS.RegionId, //区域Id
RegionName = objvDGRegionFldsENS.RegionName, //区域名称
TabId = objvDGRegionFldsENS.TabId, //表ID
FldId = objvDGRegionFldsENS.FldId, //字段Id
FldName = objvDGRegionFldsENS.FldName, //字段名
SortExpression = objvDGRegionFldsENS.SortExpression, //排序表达式
SeqNum = objvDGRegionFldsENS.SeqNum, //字段序号
HeaderText = objvDGRegionFldsENS.HeaderText, //列头
ToolTipText = objvDGRegionFldsENS.ToolTipText, //提示文字
CtlTypeId = objvDGRegionFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvDGRegionFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvDGRegionFldsENS.CtlCnName, //控件类型中文名
DgFuncTypeId = objvDGRegionFldsENS.DgFuncTypeId, //Dg功能类型Id
DgFuncTypeName = objvDGRegionFldsENS.DgFuncTypeName, //Dg功能类型名
IsNeedSort = objvDGRegionFldsENS.IsNeedSort, //是否需要排序
IsDefaultSort = objvDGRegionFldsENS.IsDefaultSort, //是否默认排序
IsTransToChkBox = objvDGRegionFldsENS.IsTransToChkBox, //是否转换成CheckBox
IsVisible = objvDGRegionFldsENS.IsVisible, //是否显示
IsFuncFld = objvDGRegionFldsENS.IsFuncFld, //是否功能字段
InUse = objvDGRegionFldsENS.InUse, //是否在用
UpdUser = objvDGRegionFldsENS.UpdUser, //修改者
UpdDate = objvDGRegionFldsENS.UpdDate, //修改日期
Memo = objvDGRegionFldsENS.Memo, //说明
PrjId = objvDGRegionFldsENS.PrjId, //工程Id
};
 return objvDGRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvDGRegionFldsEN objvDGRegionFldsEN)
{
 clsvDGRegionFldsBL.vDGRegionFldsDA.CheckProperty4Condition(objvDGRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDGRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vDG区域字段(vDGRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDGRegionFldsBL
{
public static RelatedActions_vDGRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDGRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDGRegionFldsDA vDGRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDGRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDGRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvDGRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDGRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vDGRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDGRegionFldsDA.GetDataTable_vDGRegionFlds(strWhereCond);
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
objDT = vDGRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vDGRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDGRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDGRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDGRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vDGRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDGRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDGRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvDGRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
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
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDGRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDGRegionFldsEN._CurrTabName, strPrjId);
List<clsvDGRegionFldsEN> arrvDGRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDGRegionFldsEN> arrvDGRegionFldsObjLst_Sel =
arrvDGRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvDGRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDGRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
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
public static List<clsvDGRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDGRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDGRegionFldsEN> GetSubObjLstCache(clsvDGRegionFldsEN objvDGRegionFldsCond)
{
 string strPrjId = objvDGRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDGRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDGRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDGRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDGRegionFlds._AttributeName)
{
if (objvDGRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvDGRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDGRegionFldsCond[strFldName].ToString());
}
else
{
if (objvDGRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDGRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDGRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDGRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDGRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDGRegionFldsCond[strFldName]));
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
public static List<clsvDGRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
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
public static List<clsvDGRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
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
List<clsvDGRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDGRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDGRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDGRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
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
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
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
public static List<clsvDGRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDGRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDGRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
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
public static List<clsvDGRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDGRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDGRegionFlds(ref clsvDGRegionFldsEN objvDGRegionFldsEN)
{
bool bolResult = vDGRegionFldsDA.GetvDGRegionFlds(ref objvDGRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDGRegionFldsEN GetObjBymId(long lngmId)
{
clsvDGRegionFldsEN objvDGRegionFldsEN = vDGRegionFldsDA.GetObjBymId(lngmId);
return objvDGRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDGRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDGRegionFldsEN objvDGRegionFldsEN = vDGRegionFldsDA.GetFirstObj(strWhereCond);
 return objvDGRegionFldsEN;
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
public static clsvDGRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDGRegionFldsEN objvDGRegionFldsEN = vDGRegionFldsDA.GetObjByDataRow(objRow);
 return objvDGRegionFldsEN;
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
public static clsvDGRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDGRegionFldsEN objvDGRegionFldsEN = vDGRegionFldsDA.GetObjByDataRow(objRow);
 return objvDGRegionFldsEN;
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
 /// <param name = "lstvDGRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDGRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsvDGRegionFldsEN> lstvDGRegionFldsObjLst)
{
foreach (clsvDGRegionFldsEN objvDGRegionFldsEN in lstvDGRegionFldsObjLst)
{
if (objvDGRegionFldsEN.mId == lngmId)
{
return objvDGRegionFldsEN;
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
 lngmId = new clsvDGRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = vDGRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vDGRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vDGRegionFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvDGRegionFldsDA.IsExistTable();
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
 bolIsExist = vDGRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvDGRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvDGRegionFldsEN objvDGRegionFldsEN)
{
try
{
objvDGRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDGRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDGRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.mId = objvDGRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(convDGRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.RegionId = objvDGRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convDGRegionFlds.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.RegionName = objvDGRegionFldsEN.RegionName == "[null]" ? null :  objvDGRegionFldsEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convDGRegionFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.TabId = objvDGRegionFldsEN.TabId == "[null]" ? null :  objvDGRegionFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convDGRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.FldId = objvDGRegionFldsEN.FldId == "[null]" ? null :  objvDGRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convDGRegionFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.FldName = objvDGRegionFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convDGRegionFlds.SortExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.SortExpression = objvDGRegionFldsEN.SortExpression == "[null]" ? null :  objvDGRegionFldsEN.SortExpression; //排序表达式
}
if (arrFldSet.Contains(convDGRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.SeqNum = objvDGRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convDGRegionFlds.HeaderText, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.HeaderText = objvDGRegionFldsEN.HeaderText == "[null]" ? null :  objvDGRegionFldsEN.HeaderText; //列头
}
if (arrFldSet.Contains(convDGRegionFlds.ToolTipText, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.ToolTipText = objvDGRegionFldsEN.ToolTipText == "[null]" ? null :  objvDGRegionFldsEN.ToolTipText; //提示文字
}
if (arrFldSet.Contains(convDGRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.CtlTypeId = objvDGRegionFldsEN.CtlTypeId == "[null]" ? null :  objvDGRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convDGRegionFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.CtlTypeName = objvDGRegionFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convDGRegionFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.CtlCnName = objvDGRegionFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convDGRegionFlds.DgFuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.DgFuncTypeId = objvDGRegionFldsEN.DgFuncTypeId; //Dg功能类型Id
}
if (arrFldSet.Contains(convDGRegionFlds.DgFuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.DgFuncTypeName = objvDGRegionFldsEN.DgFuncTypeName; //Dg功能类型名
}
if (arrFldSet.Contains(convDGRegionFlds.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.IsNeedSort = objvDGRegionFldsEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(convDGRegionFlds.IsDefaultSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.IsDefaultSort = objvDGRegionFldsEN.IsDefaultSort; //是否默认排序
}
if (arrFldSet.Contains(convDGRegionFlds.IsTransToChkBox, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.IsTransToChkBox = objvDGRegionFldsEN.IsTransToChkBox; //是否转换成CheckBox
}
if (arrFldSet.Contains(convDGRegionFlds.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.IsVisible = objvDGRegionFldsEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convDGRegionFlds.IsFuncFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.IsFuncFld = objvDGRegionFldsEN.IsFuncFld; //是否功能字段
}
if (arrFldSet.Contains(convDGRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.InUse = objvDGRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convDGRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.UpdUser = objvDGRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDGRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.UpdDate = objvDGRegionFldsEN.UpdDate == "[null]" ? null :  objvDGRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDGRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.Memo = objvDGRegionFldsEN.Memo == "[null]" ? null :  objvDGRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convDGRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDGRegionFldsEN.PrjId = objvDGRegionFldsEN.PrjId == "[null]" ? null :  objvDGRegionFldsEN.PrjId; //工程Id
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
 /// <param name = "objvDGRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDGRegionFldsEN objvDGRegionFldsEN)
{
try
{
if (objvDGRegionFldsEN.RegionName == "[null]") objvDGRegionFldsEN.RegionName = null; //区域名称
if (objvDGRegionFldsEN.TabId == "[null]") objvDGRegionFldsEN.TabId = null; //表ID
if (objvDGRegionFldsEN.FldId == "[null]") objvDGRegionFldsEN.FldId = null; //字段Id
if (objvDGRegionFldsEN.SortExpression == "[null]") objvDGRegionFldsEN.SortExpression = null; //排序表达式
if (objvDGRegionFldsEN.HeaderText == "[null]") objvDGRegionFldsEN.HeaderText = null; //列头
if (objvDGRegionFldsEN.ToolTipText == "[null]") objvDGRegionFldsEN.ToolTipText = null; //提示文字
if (objvDGRegionFldsEN.CtlTypeId == "[null]") objvDGRegionFldsEN.CtlTypeId = null; //控件类型号
if (objvDGRegionFldsEN.UpdDate == "[null]") objvDGRegionFldsEN.UpdDate = null; //修改日期
if (objvDGRegionFldsEN.Memo == "[null]") objvDGRegionFldsEN.Memo = null; //说明
if (objvDGRegionFldsEN.PrjId == "[null]") objvDGRegionFldsEN.PrjId = null; //工程Id
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
public static void CheckProperty4Condition(clsvDGRegionFldsEN objvDGRegionFldsEN)
{
 vDGRegionFldsDA.CheckProperty4Condition(objvDGRegionFldsEN);
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
if (clsDGRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDGRegionFldsBL没有刷新缓存机制(clsDGRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDgFuncTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDgFuncTypeBL没有刷新缓存机制(clsDgFuncTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvDGRegionFldsObjLstCache == null)
//{
//arrvDGRegionFldsObjLstCache = vDGRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDGRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDGRegionFldsEN._CurrTabName, strPrjId);
List<clsvDGRegionFldsEN> arrvDGRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDGRegionFldsEN> arrvDGRegionFldsObjLst_Sel =
arrvDGRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvDGRegionFldsObjLst_Sel.Count() == 0)
{
   clsvDGRegionFldsEN obj = clsvDGRegionFldsBL.GetObjBymId(lngmId);
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
return arrvDGRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDGRegionFldsEN> GetAllvDGRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDGRegionFldsEN> arrvDGRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvDGRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDGRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDGRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvDGRegionFldsEN> arrvDGRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDGRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDGRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDGRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvDGRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsvDGRegionFldsEN._RefreshTimeLst[clsvDGRegionFldsEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convDGRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDGRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDGRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objvDGRegionFlds = clsvDGRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvDGRegionFlds == null) return "";
return objvDGRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvDGRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvDGRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDGRegionFldsDA.GetRecCount();
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
int intRecCount = clsvDGRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDGRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDGRegionFldsEN objvDGRegionFldsCond)
{
 string strPrjId = objvDGRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDGRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDGRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDGRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDGRegionFlds._AttributeName)
{
if (objvDGRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvDGRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDGRegionFldsCond[strFldName].ToString());
}
else
{
if (objvDGRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDGRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDGRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDGRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDGRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDGRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvDGRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDGRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDGRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}