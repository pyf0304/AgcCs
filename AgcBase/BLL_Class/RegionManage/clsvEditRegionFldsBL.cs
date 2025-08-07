
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsBL
 表名:vEditRegionFlds(00050126)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:15
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
public static class  clsvEditRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEditRegionFldsEN GetObj(this K_mId_vEditRegionFlds myKey)
{
clsvEditRegionFldsEN objvEditRegionFldsEN = clsvEditRegionFldsBL.vEditRegionFldsDA.GetObjBymId(myKey.Value);
return objvEditRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetRegionId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convEditRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convEditRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convEditRegionFlds.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetRegionTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convEditRegionFlds.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convEditRegionFlds.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convEditRegionFlds.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetTabId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convEditRegionFlds.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convEditRegionFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convEditRegionFlds.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetTabName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convEditRegionFlds.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convEditRegionFlds.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetFldId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convEditRegionFlds.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convEditRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convEditRegionFlds.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetFldName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convEditRegionFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convEditRegionFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetLabelCaption(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, convEditRegionFlds.LabelCaption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convEditRegionFlds.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convEditRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convEditRegionFlds.CtlTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convEditRegionFlds.CtlTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlCnName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, convEditRegionFlds.CtlCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCtlTypeAbbr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, convEditRegionFlds.CtlTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetCallTabFeatureId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strCallTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCallTabFeatureId, 8, convEditRegionFlds.CallTabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCallTabFeatureId, 8, convEditRegionFlds.CallTabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetVarId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, convEditRegionFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convEditRegionFlds.VarId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDdlItemsOptionId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionId, convEditRegionFlds.DdlItemsOptionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, convEditRegionFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, convEditRegionFlds.DdlItemsOptionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDdlItemsOptionName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDdlItemsOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionName, 20, convEditRegionFlds.DdlItemsOptionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsTabId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, convEditRegionFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, convEditRegionFlds.DsTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsCondStr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsCondStr, convEditRegionFlds.DsCondStr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, convEditRegionFlds.DsCondStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetDsSqlStr(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsSqlStr, convEditRegionFlds.DsSqlStr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, convEditRegionFlds.DsSqlStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetItemsString(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strItemsString, convEditRegionFlds.ItemsString);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, convEditRegionFlds.ItemsString);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetColSpan(this clsvEditRegionFldsEN objvEditRegionFldsEN, int? intColSpan, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetColIndex(this clsvEditRegionFldsEN objvEditRegionFldsEN, int? intColIndex, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetWidth(this clsvEditRegionFldsEN objvEditRegionFldsEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetInOutTypeId(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convEditRegionFlds.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convEditRegionFlds.InOutTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetInOutTypeName(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strInOutTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convEditRegionFlds.InOutTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetClickEvent(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, convEditRegionFlds.ClickEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetChangeEvent(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, convEditRegionFlds.ChangeEvent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetUpdUser(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convEditRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convEditRegionFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetUpdDate(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convEditRegionFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvEditRegionFldsEN SetMemo(this clsvEditRegionFldsEN objvEditRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMemo, convEditRegionFlds.Memo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEditRegionFlds.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <param name = "objvEditRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvEditRegionFldsEN objvEditRegionFldsENS, clsvEditRegionFldsEN objvEditRegionFldsENT)
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
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvEditRegionFldsEN:objvEditRegionFldsENT</returns>
 public static clsvEditRegionFldsEN CopyTo(this clsvEditRegionFldsEN objvEditRegionFldsENS)
{
try
{
 clsvEditRegionFldsEN objvEditRegionFldsENT = new clsvEditRegionFldsEN()
{
mId = objvEditRegionFldsENS.mId, //mId
RegionId = objvEditRegionFldsENS.RegionId, //区域Id
RegionTypeId = objvEditRegionFldsENS.RegionTypeId, //区域类型Id
TabId = objvEditRegionFldsENS.TabId, //表ID
TabName = objvEditRegionFldsENS.TabName, //表名
FldId = objvEditRegionFldsENS.FldId, //字段Id
FldName = objvEditRegionFldsENS.FldName, //字段名
LabelCaption = objvEditRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objvEditRegionFldsENS.CtlTypeId, //控件类型号
CtlTypeName = objvEditRegionFldsENS.CtlTypeName, //控件类型名
CtlCnName = objvEditRegionFldsENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objvEditRegionFldsENS.CtlTypeAbbr, //控件类型缩写
CallTabFeatureId = objvEditRegionFldsENS.CallTabFeatureId, //调用表功能Id
VarId = objvEditRegionFldsENS.VarId, //变量Id
DdlItemsOptionId = objvEditRegionFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DdlItemsOptionName = objvEditRegionFldsENS.DdlItemsOptionName, //下拉选项名
DsTabId = objvEditRegionFldsENS.DsTabId, //数据源表ID
DsCondStr = objvEditRegionFldsENS.DsCondStr, //数据源条件串
DsSqlStr = objvEditRegionFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objvEditRegionFldsENS.ItemsString, //列表项串
ColSpan = objvEditRegionFldsENS.ColSpan, //跨列数
ColIndex = objvEditRegionFldsENS.ColIndex, //列序号
Width = objvEditRegionFldsENS.Width, //宽
IsMultiRow = objvEditRegionFldsENS.IsMultiRow, //是否多行
SeqNum = objvEditRegionFldsENS.SeqNum, //字段序号
InOutTypeId = objvEditRegionFldsENS.InOutTypeId, //INOUT类型ID
InOutTypeName = objvEditRegionFldsENS.InOutTypeName, //INOUT类型名称
ClickEvent = objvEditRegionFldsENS.ClickEvent, //Click事件
ChangeEvent = objvEditRegionFldsENS.ChangeEvent, //Change事件
InUse = objvEditRegionFldsENS.InUse, //是否在用
UpdUser = objvEditRegionFldsENS.UpdUser, //修改者
UpdDate = objvEditRegionFldsENS.UpdDate, //修改日期
Memo = objvEditRegionFldsENS.Memo, //说明
PrjId = objvEditRegionFldsENS.PrjId, //工程Id
};
 return objvEditRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvEditRegionFldsEN objvEditRegionFldsEN)
{
 clsvEditRegionFldsBL.vEditRegionFldsDA.CheckProperty4Condition(objvEditRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vEditRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v编辑区域字段(vEditRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvEditRegionFldsBL
{
public static RelatedActions_vEditRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvEditRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvEditRegionFldsDA vEditRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvEditRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvEditRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvEditRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEditRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vEditRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vEditRegionFldsDA.GetDataTable_vEditRegionFlds(strWhereCond);
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
objDT = vEditRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vEditRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vEditRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vEditRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vEditRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vEditRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vEditRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vEditRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvEditRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
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
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvEditRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvEditRegionFldsEN> arrvEditRegionFldsObjLst_Sel =
arrvEditRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvEditRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
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
public static List<clsvEditRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvEditRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvEditRegionFldsEN> GetSubObjLstCache(clsvEditRegionFldsEN objvEditRegionFldsCond)
{
 string strPrjId = objvEditRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvEditRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvEditRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvEditRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEditRegionFlds._AttributeName)
{
if (objvEditRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvEditRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEditRegionFldsCond[strFldName].ToString());
}
else
{
if (objvEditRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEditRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEditRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEditRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEditRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEditRegionFldsCond[strFldName]));
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
public static List<clsvEditRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
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
public static List<clsvEditRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
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
List<clsvEditRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvEditRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEditRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvEditRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
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
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
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
public static List<clsvEditRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvEditRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
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
public static List<clsvEditRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvEditRegionFlds(ref clsvEditRegionFldsEN objvEditRegionFldsEN)
{
bool bolResult = vEditRegionFldsDA.GetvEditRegionFlds(ref objvEditRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEditRegionFldsEN GetObjBymId(long lngmId)
{
clsvEditRegionFldsEN objvEditRegionFldsEN = vEditRegionFldsDA.GetObjBymId(lngmId);
return objvEditRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvEditRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvEditRegionFldsEN objvEditRegionFldsEN = vEditRegionFldsDA.GetFirstObj(strWhereCond);
 return objvEditRegionFldsEN;
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
public static clsvEditRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvEditRegionFldsEN objvEditRegionFldsEN = vEditRegionFldsDA.GetObjByDataRow(objRow);
 return objvEditRegionFldsEN;
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
public static clsvEditRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvEditRegionFldsEN objvEditRegionFldsEN = vEditRegionFldsDA.GetObjByDataRow(objRow);
 return objvEditRegionFldsEN;
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
 /// <param name = "lstvEditRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEditRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsvEditRegionFldsEN> lstvEditRegionFldsObjLst)
{
foreach (clsvEditRegionFldsEN objvEditRegionFldsEN in lstvEditRegionFldsObjLst)
{
if (objvEditRegionFldsEN.mId == lngmId)
{
return objvEditRegionFldsEN;
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
 lngmId = new clsvEditRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = vEditRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vEditRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vEditRegionFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvEditRegionFldsDA.IsExistTable();
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
 bolIsExist = vEditRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvEditRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvEditRegionFldsEN objvEditRegionFldsEN)
{
try
{
objvEditRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvEditRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convEditRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.mId = objvEditRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(convEditRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.RegionId = objvEditRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convEditRegionFlds.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.RegionTypeId = objvEditRegionFldsEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convEditRegionFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.TabId = objvEditRegionFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convEditRegionFlds.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.TabName = objvEditRegionFldsEN.TabName; //表名
}
if (arrFldSet.Contains(convEditRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.FldId = objvEditRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convEditRegionFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.FldName = objvEditRegionFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convEditRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.LabelCaption = objvEditRegionFldsEN.LabelCaption == "[null]" ? null :  objvEditRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(convEditRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.CtlTypeId = objvEditRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convEditRegionFlds.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.CtlTypeName = objvEditRegionFldsEN.CtlTypeName == "[null]" ? null :  objvEditRegionFldsEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convEditRegionFlds.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.CtlCnName = objvEditRegionFldsEN.CtlCnName == "[null]" ? null :  objvEditRegionFldsEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(convEditRegionFlds.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.CtlTypeAbbr = objvEditRegionFldsEN.CtlTypeAbbr == "[null]" ? null :  objvEditRegionFldsEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(convEditRegionFlds.CallTabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.CallTabFeatureId = objvEditRegionFldsEN.CallTabFeatureId == "[null]" ? null :  objvEditRegionFldsEN.CallTabFeatureId; //调用表功能Id
}
if (arrFldSet.Contains(convEditRegionFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.VarId = objvEditRegionFldsEN.VarId == "[null]" ? null :  objvEditRegionFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(convEditRegionFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.DdlItemsOptionId = objvEditRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(convEditRegionFlds.DdlItemsOptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.DdlItemsOptionName = objvEditRegionFldsEN.DdlItemsOptionName == "[null]" ? null :  objvEditRegionFldsEN.DdlItemsOptionName; //下拉选项名
}
if (arrFldSet.Contains(convEditRegionFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.DsTabId = objvEditRegionFldsEN.DsTabId == "[null]" ? null :  objvEditRegionFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(convEditRegionFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.DsCondStr = objvEditRegionFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(convEditRegionFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.DsSqlStr = objvEditRegionFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(convEditRegionFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.ItemsString = objvEditRegionFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(convEditRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.ColSpan = objvEditRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(convEditRegionFlds.ColIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.ColIndex = objvEditRegionFldsEN.ColIndex; //列序号
}
if (arrFldSet.Contains(convEditRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.Width = objvEditRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(convEditRegionFlds.IsMultiRow, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.IsMultiRow = objvEditRegionFldsEN.IsMultiRow; //是否多行
}
if (arrFldSet.Contains(convEditRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.SeqNum = objvEditRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convEditRegionFlds.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.InOutTypeId = objvEditRegionFldsEN.InOutTypeId == "[null]" ? null :  objvEditRegionFldsEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(convEditRegionFlds.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.InOutTypeName = objvEditRegionFldsEN.InOutTypeName == "[null]" ? null :  objvEditRegionFldsEN.InOutTypeName; //INOUT类型名称
}
if (arrFldSet.Contains(convEditRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.ClickEvent = objvEditRegionFldsEN.ClickEvent == "[null]" ? null :  objvEditRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(convEditRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.ChangeEvent = objvEditRegionFldsEN.ChangeEvent == "[null]" ? null :  objvEditRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(convEditRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.InUse = objvEditRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convEditRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.UpdUser = objvEditRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convEditRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.UpdDate = objvEditRegionFldsEN.UpdDate == "[null]" ? null :  objvEditRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convEditRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.Memo = objvEditRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convEditRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvEditRegionFldsEN.PrjId = objvEditRegionFldsEN.PrjId == "[null]" ? null :  objvEditRegionFldsEN.PrjId; //工程Id
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
 /// <param name = "objvEditRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvEditRegionFldsEN objvEditRegionFldsEN)
{
try
{
if (objvEditRegionFldsEN.LabelCaption == "[null]") objvEditRegionFldsEN.LabelCaption = null; //标签标题
if (objvEditRegionFldsEN.CtlTypeName == "[null]") objvEditRegionFldsEN.CtlTypeName = null; //控件类型名
if (objvEditRegionFldsEN.CtlCnName == "[null]") objvEditRegionFldsEN.CtlCnName = null; //控件类型中文名
if (objvEditRegionFldsEN.CtlTypeAbbr == "[null]") objvEditRegionFldsEN.CtlTypeAbbr = null; //控件类型缩写
if (objvEditRegionFldsEN.CallTabFeatureId == "[null]") objvEditRegionFldsEN.CallTabFeatureId = null; //调用表功能Id
if (objvEditRegionFldsEN.VarId == "[null]") objvEditRegionFldsEN.VarId = null; //变量Id
if (objvEditRegionFldsEN.DdlItemsOptionName == "[null]") objvEditRegionFldsEN.DdlItemsOptionName = null; //下拉选项名
if (objvEditRegionFldsEN.DsTabId == "[null]") objvEditRegionFldsEN.DsTabId = null; //数据源表ID
if (objvEditRegionFldsEN.InOutTypeId == "[null]") objvEditRegionFldsEN.InOutTypeId = null; //INOUT类型ID
if (objvEditRegionFldsEN.InOutTypeName == "[null]") objvEditRegionFldsEN.InOutTypeName = null; //INOUT类型名称
if (objvEditRegionFldsEN.ClickEvent == "[null]") objvEditRegionFldsEN.ClickEvent = null; //Click事件
if (objvEditRegionFldsEN.ChangeEvent == "[null]") objvEditRegionFldsEN.ChangeEvent = null; //Change事件
if (objvEditRegionFldsEN.UpdDate == "[null]") objvEditRegionFldsEN.UpdDate = null; //修改日期
if (objvEditRegionFldsEN.PrjId == "[null]") objvEditRegionFldsEN.PrjId = null; //工程Id
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
public static void CheckProperty4Condition(clsvEditRegionFldsEN objvEditRegionFldsEN)
{
 vEditRegionFldsDA.CheckProperty4Condition(objvEditRegionFldsEN);
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
if (clsEditRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsEditRegionFldsBL没有刷新缓存机制(clsEditRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvEditRegionFldsObjLstCache == null)
//{
//arrvEditRegionFldsObjLstCache = vEditRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEditRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvEditRegionFldsEN> arrvEditRegionFldsObjLst_Sel =
arrvEditRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvEditRegionFldsObjLst_Sel.Count() == 0)
{
   clsvEditRegionFldsEN obj = clsvEditRegionFldsBL.GetObjBymId(lngmId);
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
return arrvEditRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEditRegionFldsEN> GetAllvEditRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvEditRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvEditRegionFldsEN> arrvEditRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvEditRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvEditRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvEditRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvEditRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsvEditRegionFldsEN._RefreshTimeLst[clsvEditRegionFldsEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convEditRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convEditRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convEditRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objvEditRegionFlds = clsvEditRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvEditRegionFlds == null) return "";
return objvEditRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvEditRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvEditRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvEditRegionFldsDA.GetRecCount();
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
int intRecCount = clsvEditRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvEditRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvEditRegionFldsEN objvEditRegionFldsCond)
{
 string strPrjId = objvEditRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvEditRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvEditRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvEditRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convEditRegionFlds._AttributeName)
{
if (objvEditRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvEditRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEditRegionFldsCond[strFldName].ToString());
}
else
{
if (objvEditRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvEditRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvEditRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvEditRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvEditRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvEditRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvEditRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vEditRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vEditRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}