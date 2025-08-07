
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQryRegionFldsWApi
 表名:QryRegionFlds(00050115)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:08
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
public static class  clsQryRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetmId(this clsQryRegionFldsEN objQryRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objQryRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.mId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.mId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.mId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetRegionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conQryRegionFlds.RegionId);
objQryRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.RegionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.RegionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.RegionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldId(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conQryRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conQryRegionFlds.FldId);
objQryRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldId">OutFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetOutFldId(this clsQryRegionFldsEN objQryRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conQryRegionFlds.OutFldId);
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conQryRegionFlds.OutFldId);
objQryRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.OutFldId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.OutFldId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.OutFldId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetLabelCaption(this clsQryRegionFldsEN objQryRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conQryRegionFlds.LabelCaption);
objQryRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.LabelCaption) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetCtlTypeId(this clsQryRegionFldsEN objQryRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conQryRegionFlds.CtlTypeId);
objQryRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.CtlTypeId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarId(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conQryRegionFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conQryRegionFlds.VarId);
objQryRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsTabId(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conQryRegionFlds.DsTabId);
objQryRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsTabId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsTabId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsTabId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId4Ddl">下拉框表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetTabFeatureId4Ddl(this clsQryRegionFldsEN objQryRegionFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
objQryRegionFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.TabFeatureId4Ddl) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond1">字段Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldIdCond1(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conQryRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conQryRegionFlds.FldIdCond1);
objQryRegionFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldIdCond1) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldIdCond1, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldIdCond1] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond1">变量Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarIdCond1(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conQryRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conQryRegionFlds.VarIdCond1);
objQryRegionFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarIdCond1) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarIdCond1, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarIdCond1] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond2">字段Id_条件2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldIdCond2(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conQryRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conQryRegionFlds.FldIdCond2);
objQryRegionFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldIdCond2) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldIdCond2, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldIdCond2] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond2">数据源字段_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarIdCond2(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conQryRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conQryRegionFlds.VarIdCond2);
objQryRegionFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarIdCond2) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarIdCond2, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarIdCond2] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strQueryOptionId">查询方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetQueryOptionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strQueryOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQueryOptionId, 2, conQryRegionFlds.QueryOptionId);
objQryRegionFldsEN.QueryOptionId = strQueryOptionId; //查询方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.QueryOptionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.QueryOptionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.QueryOptionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDdlItemsOptionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
objQryRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DdlItemsOptionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsSqlStr(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conQryRegionFlds.DsSqlStr);
objQryRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsSqlStr) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetItemsString(this clsQryRegionFldsEN objQryRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strItemsString, 200, conQryRegionFlds.ItemsString);
objQryRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ItemsString) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ItemsString, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ItemsString] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsCondStr(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conQryRegionFlds.DsCondStr);
objQryRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsCondStr) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetColSpan(this clsQryRegionFldsEN objQryRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objQryRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ColSpan) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ColSpan, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ColSpan] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetWidth(this clsQryRegionFldsEN objQryRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objQryRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.Width) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.Width, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.Width] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetSeqNum(this clsQryRegionFldsEN objQryRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objQryRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.SeqNum) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.SeqNum, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.SeqNum] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetChangeEvent(this clsQryRegionFldsEN objQryRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conQryRegionFlds.ChangeEvent);
objQryRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ChangeEvent) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetClickEvent(this clsQryRegionFldsEN objQryRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conQryRegionFlds.ClickEvent);
objQryRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ClickEvent) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetInUse(this clsQryRegionFldsEN objQryRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objQryRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.InUse) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.InUse, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.InUse] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetErrMsg(this clsQryRegionFldsEN objQryRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conQryRegionFlds.ErrMsg);
objQryRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ErrMsg) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetPrjId(this clsQryRegionFldsEN objQryRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conQryRegionFlds.PrjId);
objQryRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.PrjId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.PrjId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.PrjId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetUpdUser(this clsQryRegionFldsEN objQryRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQryRegionFlds.UpdUser);
objQryRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.UpdUser) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.UpdUser, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.UpdUser] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetUpdDate(this clsQryRegionFldsEN objQryRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQryRegionFlds.UpdDate);
objQryRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.UpdDate) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.UpdDate, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.UpdDate] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetMemo(this clsQryRegionFldsEN objQryRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQryRegionFlds.Memo);
objQryRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.Memo) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.Memo, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.Memo] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQryRegionFldsEN objQryRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.mId) == true)
{
string strComparisonOpmId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.mId, objQryRegionFldsCond.mId, strComparisonOpmId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.RegionId, objQryRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldId, objQryRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.OutFldId, objQryRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.LabelCaption, objQryRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.CtlTypeId, objQryRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarId, objQryRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsTabId, objQryRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.TabFeatureId4Ddl, objQryRegionFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldIdCond1, objQryRegionFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarIdCond1, objQryRegionFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldIdCond2, objQryRegionFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarIdCond2, objQryRegionFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.QueryOptionId) == true)
{
string strComparisonOpQueryOptionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.QueryOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.QueryOptionId, objQryRegionFldsCond.QueryOptionId, strComparisonOpQueryOptionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DdlItemsOptionId, objQryRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsSqlStr, objQryRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ItemsString, objQryRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsCondStr, objQryRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.ColSpan, objQryRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.Width) == true)
{
string strComparisonOpWidth = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.Width, objQryRegionFldsCond.Width, strComparisonOpWidth);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.SeqNum, objQryRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ChangeEvent, objQryRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ClickEvent, objQryRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.InUse) == true)
{
if (objQryRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQryRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQryRegionFlds.InUse);
}
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ErrMsg, objQryRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.PrjId, objQryRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.UpdUser, objQryRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.UpdDate, objQryRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.Memo, objQryRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQryRegionFldsEN objQryRegionFldsEN)
{
 if (objQryRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQryRegionFldsEN.sfUpdFldSetStr = objQryRegionFldsEN.getsfUpdFldSetStr();
clsQryRegionFldsWApi.CheckPropertyNew(objQryRegionFldsEN); 
bool bolResult = clsQryRegionFldsWApi.UpdateRecord(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--QryRegionFlds(查询区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQryRegionFldsEN objQryRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQryRegionFldsEN == null) return "";
if (objQryRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQryRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQryRegionFldsEN objQryRegionFldsEN)
{
try
{
clsQryRegionFldsWApi.CheckPropertyNew(objQryRegionFldsEN); 
bool bolResult = clsQryRegionFldsWApi.AddNewRecord(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQryRegionFldsEN objQryRegionFldsEN, string strWhereCond)
{
try
{
clsQryRegionFldsWApi.CheckPropertyNew(objQryRegionFldsEN); 
bool bolResult = clsQryRegionFldsWApi.UpdateWithCondition(objQryRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 查询区域字段(QryRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQryRegionFldsWApi
{
private static readonly string mstrApiControllerName = "QryRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsQryRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQryRegionFldsEN objQryRegionFldsEN)
{
if (!Object.Equals(null, objQryRegionFldsEN.RegionId) && GetStrLen(objQryRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objQryRegionFldsEN.FldId) && GetStrLen(objQryRegionFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.OutFldId) && GetStrLen(objQryRegionFldsEN.OutFldId) > 8)
{
 throw new Exception("字段[OutFldId]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.LabelCaption) && GetStrLen(objQryRegionFldsEN.LabelCaption) > 150)
{
 throw new Exception("字段[标签标题]的长度不能超过150!");
}
if (!Object.Equals(null, objQryRegionFldsEN.CtlTypeId) && GetStrLen(objQryRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objQryRegionFldsEN.VarId) && GetStrLen(objQryRegionFldsEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.DsTabId) && GetStrLen(objQryRegionFldsEN.DsTabId) > 8)
{
 throw new Exception("字段[数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.TabFeatureId4Ddl) && GetStrLen(objQryRegionFldsEN.TabFeatureId4Ddl) > 8)
{
 throw new Exception("字段[下拉框表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.FldIdCond1) && GetStrLen(objQryRegionFldsEN.FldIdCond1) > 8)
{
 throw new Exception("字段[字段Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.VarIdCond1) && GetStrLen(objQryRegionFldsEN.VarIdCond1) > 8)
{
 throw new Exception("字段[变量Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.FldIdCond2) && GetStrLen(objQryRegionFldsEN.FldIdCond2) > 8)
{
 throw new Exception("字段[字段Id_条件2]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.VarIdCond2) && GetStrLen(objQryRegionFldsEN.VarIdCond2) > 8)
{
 throw new Exception("字段[数据源字段_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objQryRegionFldsEN.QueryOptionId) && GetStrLen(objQryRegionFldsEN.QueryOptionId) > 2)
{
 throw new Exception("字段[查询方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQryRegionFldsEN.DdlItemsOptionId) && GetStrLen(objQryRegionFldsEN.DdlItemsOptionId) > 2)
{
 throw new Exception("字段[下拉框列表选项ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQryRegionFldsEN.DsSqlStr) && GetStrLen(objQryRegionFldsEN.DsSqlStr) > 200)
{
 throw new Exception("字段[数据源SQL串]的长度不能超过200!");
}
if (!Object.Equals(null, objQryRegionFldsEN.ItemsString) && GetStrLen(objQryRegionFldsEN.ItemsString) > 200)
{
 throw new Exception("字段[列表项串]的长度不能超过200!");
}
if (!Object.Equals(null, objQryRegionFldsEN.DsCondStr) && GetStrLen(objQryRegionFldsEN.DsCondStr) > 50)
{
 throw new Exception("字段[数据源条件串]的长度不能超过50!");
}
if (!Object.Equals(null, objQryRegionFldsEN.ChangeEvent) && GetStrLen(objQryRegionFldsEN.ChangeEvent) > 50)
{
 throw new Exception("字段[Change事件]的长度不能超过50!");
}
if (!Object.Equals(null, objQryRegionFldsEN.ClickEvent) && GetStrLen(objQryRegionFldsEN.ClickEvent) > 50)
{
 throw new Exception("字段[Click事件]的长度不能超过50!");
}
if (!Object.Equals(null, objQryRegionFldsEN.ErrMsg) && GetStrLen(objQryRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objQryRegionFldsEN.PrjId) && GetStrLen(objQryRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQryRegionFldsEN.UpdUser) && GetStrLen(objQryRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objQryRegionFldsEN.UpdDate) && GetStrLen(objQryRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQryRegionFldsEN.Memo) && GetStrLen(objQryRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objQryRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQryRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsQryRegionFldsEN objQryRegionFldsEN;
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
objQryRegionFldsEN = JsonConvert.DeserializeObject<clsQryRegionFldsEN>(strJson);
return objQryRegionFldsEN;
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
public static clsQryRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQryRegionFldsEN objQryRegionFldsEN;
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
objQryRegionFldsEN = JsonConvert.DeserializeObject<clsQryRegionFldsEN>(strJson);
return objQryRegionFldsEN;
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
public static clsQryRegionFldsEN GetObjBymIdCache(long lngmId,string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
from objQryRegionFldsEN in arrQryRegionFldsObjLstCache
where objQryRegionFldsEN.mId == lngmId 
select objQryRegionFldsEN;
if (arrQryRegionFldsObjLst_Sel.Count() == 0)
{
   clsQryRegionFldsEN obj = clsQryRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQryRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
public static List<clsQryRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
public static IEnumerable<clsQryRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
from objQryRegionFldsEN in arrQryRegionFldsObjLstCache
where arrMId.Contains(objQryRegionFldsEN.mId)
select objQryRegionFldsEN;
return arrQryRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQryRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
public static List<clsQryRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
public static List<clsQryRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
public static List<clsQryRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQryRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQryRegionFldsEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQryRegionFldss(List<string> arrmId)
{
string strAction = "DelQryRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQryRegionFldssByCond(string strWhereCond)
{
string strAction = "DelQryRegionFldssByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsQryRegionFldsEN objQryRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQryRegionFldsEN>(objQryRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQryRegionFldsEN objQryRegionFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQryRegionFldsEN>(objQryRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshCache(objQryRegionFldsEN.RegionId);
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQryRegionFldsEN objQryRegionFldsEN)
{
if (string.IsNullOrEmpty(objQryRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQryRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQryRegionFldsEN>(objQryRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQryRegionFldsEN objQryRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQryRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQryRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQryRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQryRegionFldsEN>(objQryRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
 public static void CopyTo(clsQryRegionFldsEN objQryRegionFldsENS, clsQryRegionFldsEN objQryRegionFldsENT)
{
try
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.FldId = objQryRegionFldsENS.FldId; //字段Id
objQryRegionFldsENT.OutFldId = objQryRegionFldsENS.OutFldId; //OutFldId
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.VarId = objQryRegionFldsENS.VarId; //变量Id
objQryRegionFldsENT.DsTabId = objQryRegionFldsENS.DsTabId; //数据源表ID
objQryRegionFldsENT.TabFeatureId4Ddl = objQryRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objQryRegionFldsENT.FldIdCond1 = objQryRegionFldsENS.FldIdCond1; //字段Id_条件1
objQryRegionFldsENT.VarIdCond1 = objQryRegionFldsENS.VarIdCond1; //变量Id_条件1
objQryRegionFldsENT.FldIdCond2 = objQryRegionFldsENS.FldIdCond2; //字段Id_条件2
objQryRegionFldsENT.VarIdCond2 = objQryRegionFldsENS.VarIdCond2; //数据源字段_条件1
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DdlItemsOptionId = objQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DsSqlStr = objQryRegionFldsENS.DsSqlStr; //数据源SQL串
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DsCondStr = objQryRegionFldsENS.DsCondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.ChangeEvent = objQryRegionFldsENS.ChangeEvent; //Change事件
objQryRegionFldsENT.ClickEvent = objQryRegionFldsENS.ClickEvent; //Click事件
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.ErrMsg = objQryRegionFldsENS.ErrMsg; //错误信息
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程Id
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsQryRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQryRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQryRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQryRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQryRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQryRegionFldsEN._AttributeName)
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
public static void ReFreshThisCache(string strRegionId = "")
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsQryRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsQryRegionFldsWApi.ReFreshThisCache)", strRegionId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strRegionId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQryRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
CacheHelper.Remove(strKey);
clsQryRegionFldsWApi.objCommFun4WApi.ReFreshCache(strRegionId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsQryRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsQryRegionFldsWApi.GetObjLstCache)", strRegionId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsQryRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsQryRegionFldsEN._WhereFormat, strRegionId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conQryRegionFlds.RegionId, strRegionId);
}
var strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQryRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsQryRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsQryRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsQryRegionFldsWApi.GetObjLstCacheFromObjLst)", strRegionId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strRegionId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrQryRegionFldsObjLstCache = CacheHelper.Get<List<clsQryRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.RegionId == strRegionId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrQryRegionFldsObjLstCache = CacheHelper.Get<List<clsQryRegionFldsEN>>(strKey);
}
return arrQryRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQryRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQryRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQryRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.OutFldId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.TabFeatureId4Ddl, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.FldIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.VarIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.FldIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.VarIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.QueryOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(conQryRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conQryRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQryRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQryRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQryRegionFlds.Memo, Type.GetType("System.String"));
foreach (clsQryRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQryRegionFlds.mId] = objInFor[conQryRegionFlds.mId];
objDR[conQryRegionFlds.RegionId] = objInFor[conQryRegionFlds.RegionId];
objDR[conQryRegionFlds.FldId] = objInFor[conQryRegionFlds.FldId];
objDR[conQryRegionFlds.OutFldId] = objInFor[conQryRegionFlds.OutFldId];
objDR[conQryRegionFlds.LabelCaption] = objInFor[conQryRegionFlds.LabelCaption];
objDR[conQryRegionFlds.CtlTypeId] = objInFor[conQryRegionFlds.CtlTypeId];
objDR[conQryRegionFlds.VarId] = objInFor[conQryRegionFlds.VarId];
objDR[conQryRegionFlds.DsTabId] = objInFor[conQryRegionFlds.DsTabId];
objDR[conQryRegionFlds.TabFeatureId4Ddl] = objInFor[conQryRegionFlds.TabFeatureId4Ddl];
objDR[conQryRegionFlds.FldIdCond1] = objInFor[conQryRegionFlds.FldIdCond1];
objDR[conQryRegionFlds.VarIdCond1] = objInFor[conQryRegionFlds.VarIdCond1];
objDR[conQryRegionFlds.FldIdCond2] = objInFor[conQryRegionFlds.FldIdCond2];
objDR[conQryRegionFlds.VarIdCond2] = objInFor[conQryRegionFlds.VarIdCond2];
objDR[conQryRegionFlds.QueryOptionId] = objInFor[conQryRegionFlds.QueryOptionId];
objDR[conQryRegionFlds.DdlItemsOptionId] = objInFor[conQryRegionFlds.DdlItemsOptionId];
objDR[conQryRegionFlds.DsSqlStr] = objInFor[conQryRegionFlds.DsSqlStr];
objDR[conQryRegionFlds.ItemsString] = objInFor[conQryRegionFlds.ItemsString];
objDR[conQryRegionFlds.DsCondStr] = objInFor[conQryRegionFlds.DsCondStr];
objDR[conQryRegionFlds.ColSpan] = objInFor[conQryRegionFlds.ColSpan];
objDR[conQryRegionFlds.Width] = objInFor[conQryRegionFlds.Width];
objDR[conQryRegionFlds.SeqNum] = objInFor[conQryRegionFlds.SeqNum];
objDR[conQryRegionFlds.ChangeEvent] = objInFor[conQryRegionFlds.ChangeEvent];
objDR[conQryRegionFlds.ClickEvent] = objInFor[conQryRegionFlds.ClickEvent];
objDR[conQryRegionFlds.InUse] = objInFor[conQryRegionFlds.InUse];
objDR[conQryRegionFlds.ErrMsg] = objInFor[conQryRegionFlds.ErrMsg];
objDR[conQryRegionFlds.PrjId] = objInFor[conQryRegionFlds.PrjId];
objDR[conQryRegionFlds.UpdUser] = objInFor[conQryRegionFlds.UpdUser];
objDR[conQryRegionFlds.UpdDate] = objInFor[conQryRegionFlds.UpdDate];
objDR[conQryRegionFlds.Memo] = objInFor[conQryRegionFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 查询区域字段(QryRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QryRegionFlds : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strRegionId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}