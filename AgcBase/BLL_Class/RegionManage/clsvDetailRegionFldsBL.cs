
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDetailRegionFldsBL
 表名:vDetailRegionFlds(00050546)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:07
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
public static class  clsvDetailRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDetailRegionFldsEN GetObj(this K_mId_vDetailRegionFlds myKey)
{
clsvDetailRegionFldsEN objvDetailRegionFldsEN = clsvDetailRegionFldsBL.vDetailRegionFldsDA.GetObjBymId(myKey.Value);
return objvDetailRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetRegionId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convDetailRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convDetailRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convDetailRegionFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetRegionTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convDetailRegionFlds.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convDetailRegionFlds.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convDetailRegionFlds.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetTabId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDetailRegionFlds.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDetailRegionFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDetailRegionFlds.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetTabName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convDetailRegionFlds.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convDetailRegionFlds.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetFldId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDetailRegionFlds.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convDetailRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDetailRegionFlds.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetFldName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDetailRegionFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convDetailRegionFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetOutDataNodeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, long? lngOutDataNodeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetDataNodeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strDataNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDetailRegionFlds.DataNodeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetDataPropertyName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strDataPropertyName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataPropertyName, 50, convDetailRegionFlds.DataPropertyName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetLabelCaption(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convDetailRegionFlds.LabelCaption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convDetailRegionFlds.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convDetailRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convDetailRegionFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convDetailRegionFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlCnName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convDetailRegionFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetCtlTypeAbbr(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convDetailRegionFlds.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetColSpan(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int? intColSpan, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetColIndex(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int? intColIndex, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetWidth(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetInOutTypeId(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convDetailRegionFlds.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convDetailRegionFlds.InOutTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetInOutTypeName(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strInOutTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convDetailRegionFlds.InOutTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetChangeEvent(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convDetailRegionFlds.ChangeEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetClickEvent(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convDetailRegionFlds.ClickEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetUpdUser(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convDetailRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDetailRegionFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetUpdDate(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDetailRegionFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDetailRegionFldsEN SetMemo(this clsvDetailRegionFldsEN objvDetailRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDetailRegionFlds.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <param name = "objvDetailRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvDetailRegionFldsEN objvDetailRegionFldsENS, clsvDetailRegionFldsEN objvDetailRegionFldsENT)
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
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvDetailRegionFldsEN:objvDetailRegionFldsENT</returns>
 public static clsvDetailRegionFldsEN CopyTo(this clsvDetailRegionFldsEN objvDetailRegionFldsENS)
{
try
{
 clsvDetailRegionFldsEN objvDetailRegionFldsENT = new clsvDetailRegionFldsEN()
{
mId = objvDetailRegionFldsENS.mId, //mId
RegionId = objvDetailRegionFldsENS.RegionId, //区域Id
RegionTypeId = objvDetailRegionFldsENS.RegionTypeId, //区域类型Id
TabId = objvDetailRegionFldsENS.TabId, //表ID
TabName = objvDetailRegionFldsENS.TabName, //表名
FldId = objvDetailRegionFldsENS.FldId, //字段Id
FldName = objvDetailRegionFldsENS.FldName, //字段名
OutDataNodeId = objvDetailRegionFldsENS.OutDataNodeId, //Out数据结点Id
DataNodeName = objvDetailRegionFldsENS.DataNodeName, //数据结点名
IsUseFunc = objvDetailRegionFldsENS.IsUseFunc, //使用函数映射
DataPropertyName = objvDetailRegionFldsENS.DataPropertyName, //数据属性名
LabelCaption = objvDetailRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objvDetailRegionFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvDetailRegionFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvDetailRegionFldsENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvDetailRegionFldsENS.CtlTypeAbbr, //控件类型缩写
ColSpan = objvDetailRegionFldsENS.ColSpan, //跨列数
ColIndex = objvDetailRegionFldsENS.ColIndex, //列序号
Width = objvDetailRegionFldsENS.Width, //宽
IsMultiRow = objvDetailRegionFldsENS.IsMultiRow, //是否多行
SeqNum = objvDetailRegionFldsENS.SeqNum, //字段序号
InOutTypeId = objvDetailRegionFldsENS.InOutTypeId, //INOUT类型ID
InOutTypeName = objvDetailRegionFldsENS.InOutTypeName, //INOUT类型名称
InUse = objvDetailRegionFldsENS.InUse, //是否在用
ChangeEvent = objvDetailRegionFldsENS.ChangeEvent, //Change事件
ClickEvent = objvDetailRegionFldsENS.ClickEvent, //Click事件
UpdUser = objvDetailRegionFldsENS.UpdUser, //修改者
UpdDate = objvDetailRegionFldsENS.UpdDate, //修改日期
Memo = objvDetailRegionFldsENS.Memo, //说明
PrjId = objvDetailRegionFldsENS.PrjId, //工程Id
};
 return objvDetailRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
 clsvDetailRegionFldsBL.vDetailRegionFldsDA.CheckProperty4Condition(objvDetailRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDetailRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v详细区域字段(vDetailRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDetailRegionFldsBL
{
public static RelatedActions_vDetailRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDetailRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDetailRegionFldsDA vDetailRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDetailRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDetailRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvDetailRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDetailRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vDetailRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDetailRegionFldsDA.GetDataTable_vDetailRegionFlds(strWhereCond);
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
objDT = vDetailRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vDetailRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDetailRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDetailRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDetailRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vDetailRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDetailRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDetailRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
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
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDetailRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLst_Sel =
arrvDetailRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvDetailRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
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
public static List<clsvDetailRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDetailRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDetailRegionFldsEN> GetSubObjLstCache(clsvDetailRegionFldsEN objvDetailRegionFldsCond)
{
 string strPrjId = objvDetailRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDetailRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDetailRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDetailRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDetailRegionFlds._AttributeName)
{
if (objvDetailRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvDetailRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDetailRegionFldsCond[strFldName].ToString());
}
else
{
if (objvDetailRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDetailRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDetailRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDetailRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDetailRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDetailRegionFldsCond[strFldName]));
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
public static List<clsvDetailRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
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
List<clsvDetailRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDetailRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDetailRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
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
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
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
public static List<clsvDetailRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDetailRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
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
public static List<clsvDetailRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDetailRegionFlds(ref clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
bool bolResult = vDetailRegionFldsDA.GetvDetailRegionFlds(ref objvDetailRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDetailRegionFldsEN GetObjBymId(long lngmId)
{
clsvDetailRegionFldsEN objvDetailRegionFldsEN = vDetailRegionFldsDA.GetObjBymId(lngmId);
return objvDetailRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDetailRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDetailRegionFldsEN objvDetailRegionFldsEN = vDetailRegionFldsDA.GetFirstObj(strWhereCond);
 return objvDetailRegionFldsEN;
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
public static clsvDetailRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDetailRegionFldsEN objvDetailRegionFldsEN = vDetailRegionFldsDA.GetObjByDataRow(objRow);
 return objvDetailRegionFldsEN;
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
public static clsvDetailRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDetailRegionFldsEN objvDetailRegionFldsEN = vDetailRegionFldsDA.GetObjByDataRow(objRow);
 return objvDetailRegionFldsEN;
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
 /// <param name = "lstvDetailRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDetailRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsvDetailRegionFldsEN> lstvDetailRegionFldsObjLst)
{
foreach (clsvDetailRegionFldsEN objvDetailRegionFldsEN in lstvDetailRegionFldsObjLst)
{
if (objvDetailRegionFldsEN.mId == lngmId)
{
return objvDetailRegionFldsEN;
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
 lngmId = new clsvDetailRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = vDetailRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vDetailRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vDetailRegionFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvDetailRegionFldsDA.IsExistTable();
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
 bolIsExist = vDetailRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvDetailRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
try
{
objvDetailRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDetailRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDetailRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.mId = objvDetailRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(convDetailRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.RegionId = objvDetailRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convDetailRegionFlds.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.RegionTypeId = objvDetailRegionFldsEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convDetailRegionFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.TabId = objvDetailRegionFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convDetailRegionFlds.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.TabName = objvDetailRegionFldsEN.TabName; //表名
}
if (arrFldSet.Contains(convDetailRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.FldId = objvDetailRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convDetailRegionFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.FldName = objvDetailRegionFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convDetailRegionFlds.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.OutDataNodeId = objvDetailRegionFldsEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(convDetailRegionFlds.DataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.DataNodeName = objvDetailRegionFldsEN.DataNodeName == "[null]" ? null :  objvDetailRegionFldsEN.DataNodeName; //数据结点名
}
if (arrFldSet.Contains(convDetailRegionFlds.IsUseFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.IsUseFunc = objvDetailRegionFldsEN.IsUseFunc; //使用函数映射
}
if (arrFldSet.Contains(convDetailRegionFlds.DataPropertyName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.DataPropertyName = objvDetailRegionFldsEN.DataPropertyName == "[null]" ? null :  objvDetailRegionFldsEN.DataPropertyName; //数据属性名
}
if (arrFldSet.Contains(convDetailRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.LabelCaption = objvDetailRegionFldsEN.LabelCaption == "[null]" ? null :  objvDetailRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(convDetailRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.CtlTypeId = objvDetailRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convDetailRegionFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.CtlTypeName = objvDetailRegionFldsEN.CtlTypeName == "[null]" ? null :  objvDetailRegionFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convDetailRegionFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.CtlCnName = objvDetailRegionFldsEN.CtlCnName == "[null]" ? null :  objvDetailRegionFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convDetailRegionFlds.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.CtlTypeAbbr = objvDetailRegionFldsEN.CtlTypeAbbr == "[null]" ? null :  objvDetailRegionFldsEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convDetailRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.ColSpan = objvDetailRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(convDetailRegionFlds.ColIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.ColIndex = objvDetailRegionFldsEN.ColIndex; //列序号
}
if (arrFldSet.Contains(convDetailRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.Width = objvDetailRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(convDetailRegionFlds.IsMultiRow, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.IsMultiRow = objvDetailRegionFldsEN.IsMultiRow; //是否多行
}
if (arrFldSet.Contains(convDetailRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.SeqNum = objvDetailRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convDetailRegionFlds.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.InOutTypeId = objvDetailRegionFldsEN.InOutTypeId == "[null]" ? null :  objvDetailRegionFldsEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(convDetailRegionFlds.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.InOutTypeName = objvDetailRegionFldsEN.InOutTypeName == "[null]" ? null :  objvDetailRegionFldsEN.InOutTypeName; //INOUT类型名称
}
if (arrFldSet.Contains(convDetailRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.InUse = objvDetailRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convDetailRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.ChangeEvent = objvDetailRegionFldsEN.ChangeEvent == "[null]" ? null :  objvDetailRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(convDetailRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.ClickEvent = objvDetailRegionFldsEN.ClickEvent == "[null]" ? null :  objvDetailRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(convDetailRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.UpdUser = objvDetailRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDetailRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.UpdDate = objvDetailRegionFldsEN.UpdDate == "[null]" ? null :  objvDetailRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDetailRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.Memo = objvDetailRegionFldsEN.Memo == "[null]" ? null :  objvDetailRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convDetailRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDetailRegionFldsEN.PrjId = objvDetailRegionFldsEN.PrjId == "[null]" ? null :  objvDetailRegionFldsEN.PrjId; //工程Id
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
 /// <param name = "objvDetailRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
try
{
if (objvDetailRegionFldsEN.DataNodeName == "[null]") objvDetailRegionFldsEN.DataNodeName = null; //数据结点名
if (objvDetailRegionFldsEN.DataPropertyName == "[null]") objvDetailRegionFldsEN.DataPropertyName = null; //数据属性名
if (objvDetailRegionFldsEN.LabelCaption == "[null]") objvDetailRegionFldsEN.LabelCaption = null; //标签标题
if (objvDetailRegionFldsEN.CtlTypeName == "[null]") objvDetailRegionFldsEN.CtlTypeName = null; //控件类型名
if (objvDetailRegionFldsEN.CtlCnName == "[null]") objvDetailRegionFldsEN.CtlCnName = null; //控件类型中文名
if (objvDetailRegionFldsEN.CtlTypeAbbr == "[null]") objvDetailRegionFldsEN.CtlTypeAbbr = null; //控件类型缩写
if (objvDetailRegionFldsEN.InOutTypeId == "[null]") objvDetailRegionFldsEN.InOutTypeId = null; //INOUT类型ID
if (objvDetailRegionFldsEN.InOutTypeName == "[null]") objvDetailRegionFldsEN.InOutTypeName = null; //INOUT类型名称
if (objvDetailRegionFldsEN.ChangeEvent == "[null]") objvDetailRegionFldsEN.ChangeEvent = null; //Change事件
if (objvDetailRegionFldsEN.ClickEvent == "[null]") objvDetailRegionFldsEN.ClickEvent = null; //Click事件
if (objvDetailRegionFldsEN.UpdDate == "[null]") objvDetailRegionFldsEN.UpdDate = null; //修改日期
if (objvDetailRegionFldsEN.Memo == "[null]") objvDetailRegionFldsEN.Memo = null; //说明
if (objvDetailRegionFldsEN.PrjId == "[null]") objvDetailRegionFldsEN.PrjId = null; //工程Id
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
public static void CheckProperty4Condition(clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
 vDetailRegionFldsDA.CheckProperty4Condition(objvDetailRegionFldsEN);
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
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDetailRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDetailRegionFldsBL没有刷新缓存机制(clsDetailRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeBL没有刷新缓存机制(clsDataNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvDetailRegionFldsObjLstCache == null)
//{
//arrvDetailRegionFldsObjLstCache = vDetailRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDetailRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLst_Sel =
arrvDetailRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvDetailRegionFldsObjLst_Sel.Count() == 0)
{
   clsvDetailRegionFldsEN obj = clsvDetailRegionFldsBL.GetObjBymId(lngmId);
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
return arrvDetailRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetAllvDetailRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDetailRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvDetailRegionFldsEN> arrvDetailRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDetailRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDetailRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDetailRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDetailRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsvDetailRegionFldsEN._RefreshTimeLst[clsvDetailRegionFldsEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convDetailRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDetailRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDetailRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objvDetailRegionFlds = clsvDetailRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvDetailRegionFlds == null) return "";
return objvDetailRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvDetailRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvDetailRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDetailRegionFldsDA.GetRecCount();
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
int intRecCount = clsvDetailRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDetailRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDetailRegionFldsEN objvDetailRegionFldsCond)
{
 string strPrjId = objvDetailRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDetailRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDetailRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDetailRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDetailRegionFlds._AttributeName)
{
if (objvDetailRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvDetailRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDetailRegionFldsCond[strFldName].ToString());
}
else
{
if (objvDetailRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDetailRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDetailRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDetailRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDetailRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDetailRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvDetailRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDetailRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDetailRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}