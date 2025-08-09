
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsWApi
 表名:EditRegionFlds(00050116)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:12
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
public static class  clsEditRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetmId(this clsEditRegionFldsEN objEditRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objEditRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.mId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.mId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.mId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetRegionId(this clsEditRegionFldsEN objEditRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conEditRegionFlds.RegionId);
objEditRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.RegionId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.RegionId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.RegionId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldId(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conEditRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conEditRegionFlds.FldId);
objEditRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetLabelCaption(this clsEditRegionFldsEN objEditRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conEditRegionFlds.LabelCaption);
objEditRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.LabelCaption) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetCtlTypeId(this clsEditRegionFldsEN objEditRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conEditRegionFlds.CtlTypeId);
objEditRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.CtlTypeId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCallTabFeatureId">调用表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetCallTabFeatureId(this clsEditRegionFldsEN objEditRegionFldsEN, string strCallTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldForeignKey(strCallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
objEditRegionFldsEN.CallTabFeatureId = strCallTabFeatureId; //调用表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.CallTabFeatureId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.CallTabFeatureId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.CallTabFeatureId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarId(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conEditRegionFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conEditRegionFlds.VarId);
objEditRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDefaultValue(this clsEditRegionFldsEN objEditRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conEditRegionFlds.DefaultValue);
objEditRegionFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DefaultValue) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DefaultValue, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DefaultValue] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDdlItemsOptionId(this clsEditRegionFldsEN objEditRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
objEditRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DdlItemsOptionId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsTabId(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conEditRegionFlds.DsTabId);
objEditRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsTabId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsTabId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsTabId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId4Ddl">下拉框表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetTabFeatureId4Ddl(this clsEditRegionFldsEN objEditRegionFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
objEditRegionFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.TabFeatureId4Ddl) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond1">字段Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldIdCond1(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conEditRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conEditRegionFlds.FldIdCond1);
objEditRegionFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldIdCond1) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldIdCond1, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldIdCond1] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond1">变量Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarIdCond1(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conEditRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conEditRegionFlds.VarIdCond1);
objEditRegionFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarIdCond1) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarIdCond1, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarIdCond1] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond2">字段Id_条件2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldIdCond2(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conEditRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conEditRegionFlds.FldIdCond2);
objEditRegionFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldIdCond2) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldIdCond2, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldIdCond2] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond2">数据源字段_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarIdCond2(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conEditRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conEditRegionFlds.VarIdCond2);
objEditRegionFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarIdCond2) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarIdCond2, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarIdCond2] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsCondStr(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conEditRegionFlds.DsCondStr);
objEditRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsCondStr) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsSqlStr(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conEditRegionFlds.DsSqlStr);
objEditRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsSqlStr) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetItemsString(this clsEditRegionFldsEN objEditRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strItemsString, 200, conEditRegionFlds.ItemsString);
objEditRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ItemsString) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ItemsString, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ItemsString] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetColSpan(this clsEditRegionFldsEN objEditRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objEditRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ColSpan) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ColSpan, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ColSpan] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColIndex">列序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetColIndex(this clsEditRegionFldsEN objEditRegionFldsEN, int intColIndex, string strComparisonOp="")
	{
objEditRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ColIndex) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ColIndex, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ColIndex] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetWidth(this clsEditRegionFldsEN objEditRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objEditRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.Width) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.Width, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.Width] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMultiRow">是否多行</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetIsMultiRow(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objEditRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.IsMultiRow) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetSeqNum(this clsEditRegionFldsEN objEditRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objEditRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.SeqNum) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.SeqNum, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.SeqNum] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetInOutTypeId(this clsEditRegionFldsEN objEditRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conEditRegionFlds.InOutTypeId);
objEditRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.InOutTypeId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetClickEvent(this clsEditRegionFldsEN objEditRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conEditRegionFlds.ClickEvent);
objEditRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ClickEvent) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetChangeEvent(this clsEditRegionFldsEN objEditRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conEditRegionFlds.ChangeEvent);
objEditRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ChangeEvent) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetInUse(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objEditRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.InUse) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.InUse, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.InUse] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetErrMsg(this clsEditRegionFldsEN objEditRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conEditRegionFlds.ErrMsg);
objEditRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ErrMsg) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetPrjId(this clsEditRegionFldsEN objEditRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conEditRegionFlds.PrjId);
objEditRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.PrjId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.PrjId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.PrjId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetUpdUser(this clsEditRegionFldsEN objEditRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conEditRegionFlds.UpdUser);
objEditRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.UpdUser) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.UpdUser, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.UpdUser] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetUpdDate(this clsEditRegionFldsEN objEditRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conEditRegionFlds.UpdDate);
objEditRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.UpdDate) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.UpdDate, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.UpdDate] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetMemo(this clsEditRegionFldsEN objEditRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conEditRegionFlds.Memo);
objEditRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.Memo) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.Memo, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.Memo] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEditRegionFldsEN objEditRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.mId) == true)
{
string strComparisonOpmId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.mId, objEditRegionFldsCond.mId, strComparisonOpmId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.RegionId, objEditRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldId, objEditRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.LabelCaption, objEditRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.CtlTypeId, objEditRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.CallTabFeatureId) == true)
{
string strComparisonOpCallTabFeatureId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.CallTabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.CallTabFeatureId, objEditRegionFldsCond.CallTabFeatureId, strComparisonOpCallTabFeatureId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarId, objEditRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DefaultValue, objEditRegionFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DdlItemsOptionId, objEditRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsTabId, objEditRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.TabFeatureId4Ddl, objEditRegionFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldIdCond1, objEditRegionFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarIdCond1, objEditRegionFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldIdCond2, objEditRegionFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarIdCond2, objEditRegionFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsCondStr, objEditRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsSqlStr, objEditRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ItemsString, objEditRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.ColSpan, objEditRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.ColIndex, objEditRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.Width) == true)
{
string strComparisonOpWidth = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.Width, objEditRegionFldsCond.Width, strComparisonOpWidth);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.IsMultiRow) == true)
{
if (objEditRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEditRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEditRegionFlds.IsMultiRow);
}
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.SeqNum, objEditRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.InOutTypeId, objEditRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ClickEvent, objEditRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ChangeEvent, objEditRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.InUse) == true)
{
if (objEditRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEditRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEditRegionFlds.InUse);
}
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ErrMsg, objEditRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.PrjId, objEditRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.UpdUser, objEditRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.UpdDate, objEditRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.Memo, objEditRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEditRegionFldsEN objEditRegionFldsEN)
{
 if (objEditRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objEditRegionFldsEN.sfUpdFldSetStr = objEditRegionFldsEN.getsfUpdFldSetStr();
clsEditRegionFldsWApi.CheckPropertyNew(objEditRegionFldsEN); 
bool bolResult = clsEditRegionFldsWApi.UpdateRecord(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
 /// 获取唯一性条件串--EditRegionFlds(编辑区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsEditRegionFldsEN objEditRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objEditRegionFldsEN == null) return "";
if (objEditRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objEditRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEditRegionFldsEN objEditRegionFldsEN)
{
try
{
clsEditRegionFldsWApi.CheckPropertyNew(objEditRegionFldsEN); 
bool bolResult = clsEditRegionFldsWApi.AddNewRecord(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEditRegionFldsEN objEditRegionFldsEN, string strWhereCond)
{
try
{
clsEditRegionFldsWApi.CheckPropertyNew(objEditRegionFldsEN); 
bool bolResult = clsEditRegionFldsWApi.UpdateWithCondition(objEditRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsEditRegionFldsWApi
{
private static readonly string mstrApiControllerName = "EditRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsEditRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsEditRegionFldsEN objEditRegionFldsEN)
{
if (!Object.Equals(null, objEditRegionFldsEN.RegionId) && GetStrLen(objEditRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objEditRegionFldsEN.FldId) && GetStrLen(objEditRegionFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.LabelCaption) && GetStrLen(objEditRegionFldsEN.LabelCaption) > 150)
{
 throw new Exception("字段[标签标题]的长度不能超过150!");
}
if (!Object.Equals(null, objEditRegionFldsEN.CtlTypeId) && GetStrLen(objEditRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objEditRegionFldsEN.CallTabFeatureId) && GetStrLen(objEditRegionFldsEN.CallTabFeatureId) > 8)
{
 throw new Exception("字段[调用表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.VarId) && GetStrLen(objEditRegionFldsEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.DefaultValue) && GetStrLen(objEditRegionFldsEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objEditRegionFldsEN.DdlItemsOptionId) && GetStrLen(objEditRegionFldsEN.DdlItemsOptionId) > 2)
{
 throw new Exception("字段[下拉框列表选项ID]的长度不能超过2!");
}
if (!Object.Equals(null, objEditRegionFldsEN.DsTabId) && GetStrLen(objEditRegionFldsEN.DsTabId) > 8)
{
 throw new Exception("字段[数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.TabFeatureId4Ddl) && GetStrLen(objEditRegionFldsEN.TabFeatureId4Ddl) > 8)
{
 throw new Exception("字段[下拉框表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.FldIdCond1) && GetStrLen(objEditRegionFldsEN.FldIdCond1) > 8)
{
 throw new Exception("字段[字段Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.VarIdCond1) && GetStrLen(objEditRegionFldsEN.VarIdCond1) > 8)
{
 throw new Exception("字段[变量Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.FldIdCond2) && GetStrLen(objEditRegionFldsEN.FldIdCond2) > 8)
{
 throw new Exception("字段[字段Id_条件2]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.VarIdCond2) && GetStrLen(objEditRegionFldsEN.VarIdCond2) > 8)
{
 throw new Exception("字段[数据源字段_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objEditRegionFldsEN.DsCondStr) && GetStrLen(objEditRegionFldsEN.DsCondStr) > 50)
{
 throw new Exception("字段[数据源条件串]的长度不能超过50!");
}
if (!Object.Equals(null, objEditRegionFldsEN.DsSqlStr) && GetStrLen(objEditRegionFldsEN.DsSqlStr) > 200)
{
 throw new Exception("字段[数据源SQL串]的长度不能超过200!");
}
if (!Object.Equals(null, objEditRegionFldsEN.ItemsString) && GetStrLen(objEditRegionFldsEN.ItemsString) > 200)
{
 throw new Exception("字段[列表项串]的长度不能超过200!");
}
if (!Object.Equals(null, objEditRegionFldsEN.InOutTypeId) && GetStrLen(objEditRegionFldsEN.InOutTypeId) > 2)
{
 throw new Exception("字段[INOUT类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objEditRegionFldsEN.ClickEvent) && GetStrLen(objEditRegionFldsEN.ClickEvent) > 50)
{
 throw new Exception("字段[Click事件]的长度不能超过50!");
}
if (!Object.Equals(null, objEditRegionFldsEN.ChangeEvent) && GetStrLen(objEditRegionFldsEN.ChangeEvent) > 50)
{
 throw new Exception("字段[Change事件]的长度不能超过50!");
}
if (!Object.Equals(null, objEditRegionFldsEN.ErrMsg) && GetStrLen(objEditRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objEditRegionFldsEN.PrjId) && GetStrLen(objEditRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objEditRegionFldsEN.UpdUser) && GetStrLen(objEditRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objEditRegionFldsEN.UpdDate) && GetStrLen(objEditRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objEditRegionFldsEN.Memo) && GetStrLen(objEditRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objEditRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEditRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsEditRegionFldsEN objEditRegionFldsEN;
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
objEditRegionFldsEN = JsonConvert.DeserializeObject<clsEditRegionFldsEN>(strJson);
return objEditRegionFldsEN;
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
public static clsEditRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsEditRegionFldsEN objEditRegionFldsEN;
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
objEditRegionFldsEN = JsonConvert.DeserializeObject<clsEditRegionFldsEN>(strJson);
return objEditRegionFldsEN;
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
public static clsEditRegionFldsEN GetObjBymIdCache(long lngmId,string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
from objEditRegionFldsEN in arrEditRegionFldsObjLstCache
where objEditRegionFldsEN.mId == lngmId 
select objEditRegionFldsEN;
if (arrEditRegionFldsObjLst_Sel.Count() == 0)
{
   clsEditRegionFldsEN obj = clsEditRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrEditRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
public static List<clsEditRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
public static IEnumerable<clsEditRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
from objEditRegionFldsEN in arrEditRegionFldsObjLstCache
where arrMId.Contains(objEditRegionFldsEN.mId)
select objEditRegionFldsEN;
return arrEditRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
public static List<clsEditRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
public static List<clsEditRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
public static List<clsEditRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsEditRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionFldsEN>>(strJson);
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
 clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
public static int DelEditRegionFldss(List<string> arrmId)
{
string strAction = "DelEditRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
public static int DelEditRegionFldssByCond(string strWhereCond)
{
string strAction = "DelEditRegionFldssByCond";
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
public static bool AddNewRecord(clsEditRegionFldsEN objEditRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionFldsEN>(objEditRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
 /// <param name = "objEditRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsEditRegionFldsEN objEditRegionFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionFldsEN>(objEditRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsWApi.ReFreshCache(objEditRegionFldsEN.PrjId);
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
public static bool UpdateRecord(clsEditRegionFldsEN objEditRegionFldsEN)
{
if (string.IsNullOrEmpty(objEditRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionFldsEN>(objEditRegionFldsEN);
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsEditRegionFldsEN objEditRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objEditRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionFldsEN>(objEditRegionFldsEN);
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
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
 public static void CopyTo(clsEditRegionFldsEN objEditRegionFldsENS, clsEditRegionFldsEN objEditRegionFldsENT)
{
try
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.FldId = objEditRegionFldsENS.FldId; //字段Id
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.CallTabFeatureId = objEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objEditRegionFldsENT.VarId = objEditRegionFldsENS.VarId; //变量Id
objEditRegionFldsENT.DefaultValue = objEditRegionFldsENS.DefaultValue; //缺省值
objEditRegionFldsENT.DdlItemsOptionId = objEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DsTabId = objEditRegionFldsENS.DsTabId; //数据源表ID
objEditRegionFldsENT.TabFeatureId4Ddl = objEditRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objEditRegionFldsENT.FldIdCond1 = objEditRegionFldsENS.FldIdCond1; //字段Id_条件1
objEditRegionFldsENT.VarIdCond1 = objEditRegionFldsENS.VarIdCond1; //变量Id_条件1
objEditRegionFldsENT.FldIdCond2 = objEditRegionFldsENS.FldIdCond2; //字段Id_条件2
objEditRegionFldsENT.VarIdCond2 = objEditRegionFldsENS.VarIdCond2; //数据源字段_条件1
objEditRegionFldsENT.DsCondStr = objEditRegionFldsENS.DsCondStr; //数据源条件串
objEditRegionFldsENT.DsSqlStr = objEditRegionFldsENS.DsSqlStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.InOutTypeId = objEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objEditRegionFldsENT.ClickEvent = objEditRegionFldsENS.ClickEvent; //Click事件
objEditRegionFldsENT.ChangeEvent = objEditRegionFldsENS.ChangeEvent; //Change事件
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.ErrMsg = objEditRegionFldsENS.ErrMsg; //错误信息
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程Id
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsEditRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsEditRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsEditRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsEditRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsEditRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsEditRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsEditRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsEditRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsEditRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsEditRegionFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsEditRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsEditRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsEditRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsEditRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conEditRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsEditRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsEditRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsEditRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrEditRegionFldsObjLstCache = CacheHelper.Get<List<clsEditRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrEditRegionFldsObjLstCache = CacheHelper.Get<List<clsEditRegionFldsEN>>(strKey);
}
return arrEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsEditRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conEditRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conEditRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.CallTabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.TabFeatureId4Ddl, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.FldIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.VarIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.FldIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.VarIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(conEditRegionFlds.ColIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conEditRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conEditRegionFlds.IsMultiRow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEditRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conEditRegionFlds.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEditRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegionFlds.Memo, Type.GetType("System.String"));
foreach (clsEditRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conEditRegionFlds.mId] = objInFor[conEditRegionFlds.mId];
objDR[conEditRegionFlds.RegionId] = objInFor[conEditRegionFlds.RegionId];
objDR[conEditRegionFlds.FldId] = objInFor[conEditRegionFlds.FldId];
objDR[conEditRegionFlds.LabelCaption] = objInFor[conEditRegionFlds.LabelCaption];
objDR[conEditRegionFlds.CtlTypeId] = objInFor[conEditRegionFlds.CtlTypeId];
objDR[conEditRegionFlds.CallTabFeatureId] = objInFor[conEditRegionFlds.CallTabFeatureId];
objDR[conEditRegionFlds.VarId] = objInFor[conEditRegionFlds.VarId];
objDR[conEditRegionFlds.DefaultValue] = objInFor[conEditRegionFlds.DefaultValue];
objDR[conEditRegionFlds.DdlItemsOptionId] = objInFor[conEditRegionFlds.DdlItemsOptionId];
objDR[conEditRegionFlds.DsTabId] = objInFor[conEditRegionFlds.DsTabId];
objDR[conEditRegionFlds.TabFeatureId4Ddl] = objInFor[conEditRegionFlds.TabFeatureId4Ddl];
objDR[conEditRegionFlds.FldIdCond1] = objInFor[conEditRegionFlds.FldIdCond1];
objDR[conEditRegionFlds.VarIdCond1] = objInFor[conEditRegionFlds.VarIdCond1];
objDR[conEditRegionFlds.FldIdCond2] = objInFor[conEditRegionFlds.FldIdCond2];
objDR[conEditRegionFlds.VarIdCond2] = objInFor[conEditRegionFlds.VarIdCond2];
objDR[conEditRegionFlds.DsCondStr] = objInFor[conEditRegionFlds.DsCondStr];
objDR[conEditRegionFlds.DsSqlStr] = objInFor[conEditRegionFlds.DsSqlStr];
objDR[conEditRegionFlds.ItemsString] = objInFor[conEditRegionFlds.ItemsString];
objDR[conEditRegionFlds.ColSpan] = objInFor[conEditRegionFlds.ColSpan];
objDR[conEditRegionFlds.ColIndex] = objInFor[conEditRegionFlds.ColIndex];
objDR[conEditRegionFlds.Width] = objInFor[conEditRegionFlds.Width];
objDR[conEditRegionFlds.IsMultiRow] = objInFor[conEditRegionFlds.IsMultiRow];
objDR[conEditRegionFlds.SeqNum] = objInFor[conEditRegionFlds.SeqNum];
objDR[conEditRegionFlds.InOutTypeId] = objInFor[conEditRegionFlds.InOutTypeId];
objDR[conEditRegionFlds.ClickEvent] = objInFor[conEditRegionFlds.ClickEvent];
objDR[conEditRegionFlds.ChangeEvent] = objInFor[conEditRegionFlds.ChangeEvent];
objDR[conEditRegionFlds.InUse] = objInFor[conEditRegionFlds.InUse];
objDR[conEditRegionFlds.ErrMsg] = objInFor[conEditRegionFlds.ErrMsg];
objDR[conEditRegionFlds.PrjId] = objInFor[conEditRegionFlds.PrjId];
objDR[conEditRegionFlds.UpdUser] = objInFor[conEditRegionFlds.UpdUser];
objDR[conEditRegionFlds.UpdDate] = objInFor[conEditRegionFlds.UpdDate];
objDR[conEditRegionFlds.Memo] = objInFor[conEditRegionFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 编辑区域字段(EditRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4EditRegionFlds : clsCommFun4BLV2
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
clsEditRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}