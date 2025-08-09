
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewFeatureFldsWApi
 表名:ViewFeatureFlds(00050453)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:24
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
public static class  clsViewFeatureFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetmId(this clsViewFeatureFldsEN objViewFeatureFldsEN, long lngmId, string strComparisonOp="")
	{
objViewFeatureFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.mId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.mId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.mId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFeatureId">界面功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetViewFeatureId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewFeatureId, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
objViewFeatureFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ViewFeatureId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ViewFeatureId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ViewFeatureId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFieldTypeId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
objViewFeatureFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FieldTypeId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FieldTypeId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FieldTypeId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReleFldId">相关字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetReleFldId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strReleFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReleFldId, 8, conViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, conViewFeatureFlds.ReleFldId);
objViewFeatureFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ReleFldId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ReleFldId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ReleFldId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFuncName(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, conViewFeatureFlds.FuncName);
objViewFeatureFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FuncName) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FuncName, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FuncName] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetLabelCaption(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conViewFeatureFlds.LabelCaption);
objViewFeatureFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.LabelCaption) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.LabelCaption, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.LabelCaption] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCtlTypeId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
objViewFeatureFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CtlTypeId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CtlTypeId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CtlTypeId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conViewFeatureFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conViewFeatureFlds.VarId);
objViewFeatureFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtrlId">控件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCtrlId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCtrlId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtrlId, 50, conViewFeatureFlds.CtrlId);
objViewFeatureFldsEN.CtrlId = strCtrlId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CtrlId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CtrlId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CtrlId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDefaultValue(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conViewFeatureFlds.DefaultValue);
objViewFeatureFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DefaultValue) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DefaultValue, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DefaultValue] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetOrderNum(this clsViewFeatureFldsEN objViewFeatureFldsEN, int intOrderNum, string strComparisonOp="")
	{
objViewFeatureFldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.OrderNum) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.OrderNum, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.OrderNum] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCssClass(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, conViewFeatureFlds.CssClass);
objViewFeatureFldsEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CssClass) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CssClass, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CssClass] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDdlItemsOptionId">下拉框列表选项ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDdlItemsOptionId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
objViewFeatureFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DdlItemsOptionId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsTabId">数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsTabId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conViewFeatureFlds.DsTabId);
objViewFeatureFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsTabId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsTabId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsTabId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond2">字段Id_条件2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFldIdCond2(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
objViewFeatureFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FldIdCond2) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FldIdCond2, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FldIdCond2] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldIdCond1">字段Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFldIdCond1(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
objViewFeatureFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FldIdCond1) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FldIdCond1, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FldIdCond1] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond2">数据源字段_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarIdCond2(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
objViewFeatureFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarIdCond2) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarIdCond2, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarIdCond2] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarIdCond1">变量Id_条件1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarIdCond1(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
objViewFeatureFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarIdCond1) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarIdCond1, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarIdCond1] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId4Ddl">下拉框表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetTabFeatureId4Ddl(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
objViewFeatureFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.TabFeatureId4Ddl) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplId">界面实现Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetViewImplId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewImplId, 4, conViewFeatureFlds.ViewImplId);
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, conViewFeatureFlds.ViewImplId);
objViewFeatureFldsEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ViewImplId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ViewImplId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ViewImplId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetText(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strText, 30, conViewFeatureFlds.Text);
objViewFeatureFldsEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.Text) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.Text, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.Text] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsCondStr">数据源条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsCondStr(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsCondStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conViewFeatureFlds.DsCondStr);
objViewFeatureFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsCondStr) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsCondStr, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsCondStr] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDsSqlStr">数据源SQL串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsSqlStr(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conViewFeatureFlds.DsSqlStr);
objViewFeatureFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsSqlStr) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsSqlStr, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsSqlStr] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strItemsString">列表项串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetItemsString(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strItemsString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strItemsString, 200, conViewFeatureFlds.ItemsString);
objViewFeatureFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ItemsString) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ItemsString, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ItemsString] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetPrjId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewFeatureFlds.PrjId);
objViewFeatureFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.PrjId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.PrjId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.PrjId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetUpdUser(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conViewFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewFeatureFlds.UpdUser);
objViewFeatureFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.UpdUser) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.UpdUser, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.UpdUser] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetUpdDate(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewFeatureFlds.UpdDate);
objViewFeatureFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.UpdDate) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.UpdDate, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.UpdDate] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetInUse(this clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolInUse, string strComparisonOp="")
	{
objViewFeatureFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.InUse) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.InUse, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.InUse] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetMemo(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewFeatureFlds.Memo);
objViewFeatureFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.Memo) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.Memo, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.Memo] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewFeatureFldsEN objViewFeatureFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.mId) == true)
{
string strComparisonOpmId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewFeatureFlds.mId, objViewFeatureFldsCond.mId, strComparisonOpmId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ViewFeatureId, objViewFeatureFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FieldTypeId, objViewFeatureFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ReleFldId, objViewFeatureFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FuncName) == true)
{
string strComparisonOpFuncName = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FuncName, objViewFeatureFldsCond.FuncName, strComparisonOpFuncName);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.LabelCaption, objViewFeatureFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CtlTypeId, objViewFeatureFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarId) == true)
{
string strComparisonOpVarId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarId, objViewFeatureFldsCond.VarId, strComparisonOpVarId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CtrlId) == true)
{
string strComparisonOpCtrlId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CtrlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CtrlId, objViewFeatureFldsCond.CtrlId, strComparisonOpCtrlId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DefaultValue, objViewFeatureFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewFeatureFlds.OrderNum, objViewFeatureFldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CssClass) == true)
{
string strComparisonOpCssClass = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CssClass, objViewFeatureFldsCond.CssClass, strComparisonOpCssClass);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DdlItemsOptionId, objViewFeatureFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsTabId, objViewFeatureFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FldIdCond2, objViewFeatureFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FldIdCond1, objViewFeatureFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarIdCond2, objViewFeatureFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarIdCond1, objViewFeatureFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.TabFeatureId4Ddl, objViewFeatureFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ViewImplId) == true)
{
string strComparisonOpViewImplId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ViewImplId, objViewFeatureFldsCond.ViewImplId, strComparisonOpViewImplId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.Text) == true)
{
string strComparisonOpText = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.Text, objViewFeatureFldsCond.Text, strComparisonOpText);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsCondStr, objViewFeatureFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsSqlStr, objViewFeatureFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ItemsString, objViewFeatureFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.PrjId) == true)
{
string strComparisonOpPrjId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.PrjId, objViewFeatureFldsCond.PrjId, strComparisonOpPrjId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.UpdUser, objViewFeatureFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.UpdDate, objViewFeatureFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.InUse) == true)
{
if (objViewFeatureFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewFeatureFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewFeatureFlds.InUse);
}
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.Memo) == true)
{
string strComparisonOpMemo = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.Memo, objViewFeatureFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 if (objViewFeatureFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewFeatureFldsEN.sfUpdFldSetStr = objViewFeatureFldsEN.getsfUpdFldSetStr();
clsViewFeatureFldsWApi.CheckPropertyNew(objViewFeatureFldsEN); 
bool bolResult = clsViewFeatureFldsWApi.UpdateRecord(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
 /// 获取唯一性条件串--ViewFeatureFlds(界面功能字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewFeatureId_FieldTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewFeatureFldsEN == null) return "";
if (objViewFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
try
{
clsViewFeatureFldsWApi.CheckPropertyNew(objViewFeatureFldsEN); 
bool bolResult = clsViewFeatureFldsWApi.AddNewRecord(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strWhereCond)
{
try
{
clsViewFeatureFldsWApi.CheckPropertyNew(objViewFeatureFldsEN); 
bool bolResult = clsViewFeatureFldsWApi.UpdateWithCondition(objViewFeatureFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
 /// 界面功能字段(ViewFeatureFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewFeatureFldsWApi
{
private static readonly string mstrApiControllerName = "ViewFeatureFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewFeatureFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
if (!Object.Equals(null, objViewFeatureFldsEN.ViewFeatureId) && GetStrLen(objViewFeatureFldsEN.ViewFeatureId) > 8)
{
 throw new Exception("字段[界面功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.FieldTypeId) && GetStrLen(objViewFeatureFldsEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.ReleFldId) && GetStrLen(objViewFeatureFldsEN.ReleFldId) > 8)
{
 throw new Exception("字段[相关字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.FuncName) && GetStrLen(objViewFeatureFldsEN.FuncName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.LabelCaption) && GetStrLen(objViewFeatureFldsEN.LabelCaption) > 150)
{
 throw new Exception("字段[标签标题]的长度不能超过150!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.CtlTypeId) && GetStrLen(objViewFeatureFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.VarId) && GetStrLen(objViewFeatureFldsEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.CtrlId) && GetStrLen(objViewFeatureFldsEN.CtrlId) > 50)
{
 throw new Exception("字段[控件Id]的长度不能超过50!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.DefaultValue) && GetStrLen(objViewFeatureFldsEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.CssClass) && GetStrLen(objViewFeatureFldsEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.DdlItemsOptionId) && GetStrLen(objViewFeatureFldsEN.DdlItemsOptionId) > 2)
{
 throw new Exception("字段[下拉框列表选项ID]的长度不能超过2!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.DsTabId) && GetStrLen(objViewFeatureFldsEN.DsTabId) > 8)
{
 throw new Exception("字段[数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.FldIdCond2) && GetStrLen(objViewFeatureFldsEN.FldIdCond2) > 8)
{
 throw new Exception("字段[字段Id_条件2]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.FldIdCond1) && GetStrLen(objViewFeatureFldsEN.FldIdCond1) > 8)
{
 throw new Exception("字段[字段Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.VarIdCond2) && GetStrLen(objViewFeatureFldsEN.VarIdCond2) > 8)
{
 throw new Exception("字段[数据源字段_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.VarIdCond1) && GetStrLen(objViewFeatureFldsEN.VarIdCond1) > 8)
{
 throw new Exception("字段[变量Id_条件1]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.TabFeatureId4Ddl) && GetStrLen(objViewFeatureFldsEN.TabFeatureId4Ddl) > 8)
{
 throw new Exception("字段[下拉框表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.ViewImplId) && GetStrLen(objViewFeatureFldsEN.ViewImplId) > 4)
{
 throw new Exception("字段[界面实现Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.Text) && GetStrLen(objViewFeatureFldsEN.Text) > 30)
{
 throw new Exception("字段[文本]的长度不能超过30!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.DsCondStr) && GetStrLen(objViewFeatureFldsEN.DsCondStr) > 50)
{
 throw new Exception("字段[数据源条件串]的长度不能超过50!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.DsSqlStr) && GetStrLen(objViewFeatureFldsEN.DsSqlStr) > 200)
{
 throw new Exception("字段[数据源SQL串]的长度不能超过200!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.ItemsString) && GetStrLen(objViewFeatureFldsEN.ItemsString) > 200)
{
 throw new Exception("字段[列表项串]的长度不能超过200!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.PrjId) && GetStrLen(objViewFeatureFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.UpdUser) && GetStrLen(objViewFeatureFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.UpdDate) && GetStrLen(objViewFeatureFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewFeatureFldsEN.Memo) && GetStrLen(objViewFeatureFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objViewFeatureFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewFeatureFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsViewFeatureFldsEN objViewFeatureFldsEN;
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
objViewFeatureFldsEN = JsonConvert.DeserializeObject<clsViewFeatureFldsEN>(strJson);
return objViewFeatureFldsEN;
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
public static clsViewFeatureFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewFeatureFldsEN objViewFeatureFldsEN;
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
objViewFeatureFldsEN = JsonConvert.DeserializeObject<clsViewFeatureFldsEN>(strJson);
return objViewFeatureFldsEN;
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
public static clsViewFeatureFldsEN GetObjBymIdCache(long lngmId,string strViewFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = GetObjLstCache(strViewFeatureId);
IEnumerable <clsViewFeatureFldsEN> arrViewFeatureFldsObjLst_Sel =
from objViewFeatureFldsEN in arrViewFeatureFldsObjLstCache
where objViewFeatureFldsEN.mId == lngmId 
select objViewFeatureFldsEN;
if (arrViewFeatureFldsObjLst_Sel.Count() == 0)
{
   clsViewFeatureFldsEN obj = clsViewFeatureFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLst(string strWhereCond)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
public static List<clsViewFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
public static IEnumerable<clsViewFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strViewFeatureId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = GetObjLstCache(strViewFeatureId);
IEnumerable <clsViewFeatureFldsEN> arrViewFeatureFldsObjLst_Sel =
from objViewFeatureFldsEN in arrViewFeatureFldsObjLstCache
where arrMId.Contains(objViewFeatureFldsEN.mId)
select objViewFeatureFldsEN;
return arrViewFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
public static List<clsViewFeatureFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
public static List<clsViewFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
public static List<clsViewFeatureFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewFeatureFldsEN>>(strJson);
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
 clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
public static int DelViewFeatureFldss(List<string> arrmId)
{
string strAction = "DelViewFeatureFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
public static int DelViewFeatureFldssByCond(string strWhereCond)
{
string strAction = "DelViewFeatureFldssByCond";
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
public static bool AddNewRecord(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewFeatureFldsEN>(objViewFeatureFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewFeatureFldsEN>(objViewFeatureFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsWApi.ReFreshCache(objViewFeatureFldsEN.PrjId);
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
public static bool UpdateRecord(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
if (string.IsNullOrEmpty(objViewFeatureFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewFeatureFldsEN>(objViewFeatureFldsEN);
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewFeatureFldsEN objViewFeatureFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewFeatureFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewFeatureFldsEN>(objViewFeatureFldsEN);
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
 /// <param name = "objViewFeatureFldsENS">源对象</param>
 /// <param name = "objViewFeatureFldsENT">目标对象</param>
 public static void CopyTo(clsViewFeatureFldsEN objViewFeatureFldsENS, clsViewFeatureFldsEN objViewFeatureFldsENT)
{
try
{
objViewFeatureFldsENT.mId = objViewFeatureFldsENS.mId; //mId
objViewFeatureFldsENT.ViewFeatureId = objViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objViewFeatureFldsENT.FieldTypeId = objViewFeatureFldsENS.FieldTypeId; //字段类型Id
objViewFeatureFldsENT.ReleFldId = objViewFeatureFldsENS.ReleFldId; //相关字段Id
objViewFeatureFldsENT.FuncName = objViewFeatureFldsENS.FuncName; //函数名
objViewFeatureFldsENT.LabelCaption = objViewFeatureFldsENS.LabelCaption; //标签标题
objViewFeatureFldsENT.CtlTypeId = objViewFeatureFldsENS.CtlTypeId; //控件类型号
objViewFeatureFldsENT.VarId = objViewFeatureFldsENS.VarId; //变量Id
objViewFeatureFldsENT.CtrlId = objViewFeatureFldsENS.CtrlId; //控件Id
objViewFeatureFldsENT.DefaultValue = objViewFeatureFldsENS.DefaultValue; //缺省值
objViewFeatureFldsENT.OrderNum = objViewFeatureFldsENS.OrderNum; //序号
objViewFeatureFldsENT.CssClass = objViewFeatureFldsENS.CssClass; //样式表
objViewFeatureFldsENT.DdlItemsOptionId = objViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewFeatureFldsENT.DsTabId = objViewFeatureFldsENS.DsTabId; //数据源表ID
objViewFeatureFldsENT.FldIdCond2 = objViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objViewFeatureFldsENT.FldIdCond1 = objViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objViewFeatureFldsENT.VarIdCond2 = objViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objViewFeatureFldsENT.VarIdCond1 = objViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objViewFeatureFldsENT.TabFeatureId4Ddl = objViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objViewFeatureFldsENT.ViewImplId = objViewFeatureFldsENS.ViewImplId; //界面实现Id
objViewFeatureFldsENT.Text = objViewFeatureFldsENS.Text; //文本
objViewFeatureFldsENT.DsCondStr = objViewFeatureFldsENS.DsCondStr; //数据源条件串
objViewFeatureFldsENT.DsSqlStr = objViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objViewFeatureFldsENT.ItemsString = objViewFeatureFldsENS.ItemsString; //列表项串
objViewFeatureFldsENT.PrjId = objViewFeatureFldsENS.PrjId; //工程Id
objViewFeatureFldsENT.UpdUser = objViewFeatureFldsENS.UpdUser; //修改者
objViewFeatureFldsENT.UpdDate = objViewFeatureFldsENS.UpdDate; //修改日期
objViewFeatureFldsENT.InUse = objViewFeatureFldsENS.InUse; //是否在用
objViewFeatureFldsENT.Memo = objViewFeatureFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsViewFeatureFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewFeatureFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewFeatureFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewFeatureFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewFeatureFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewFeatureFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewFeatureFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewFeatureFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
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
if (clsViewFeatureFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewFeatureFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLstCache(string strViewFeatureId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewFeatureFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewFeatureFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewFeatureFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewFeatureFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewFeatureFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLstCacheFromObjLst(string strViewFeatureId,List<clsViewFeatureFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewFeatureFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewFeatureFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewFeatureFldsObjLstCache = CacheHelper.Get<List<clsViewFeatureFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewFeatureFldsObjLstCache = CacheHelper.Get<List<clsViewFeatureFldsEN>>(strKey);
}
return arrViewFeatureFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewFeatureFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewFeatureFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conViewFeatureFlds.ViewFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.ReleFldId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.CtrlId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewFeatureFlds.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.DdlItemsOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.DsTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.FldIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.FldIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.VarIdCond2, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.VarIdCond1, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.TabFeatureId4Ddl, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.ViewImplId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.Text, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.DsCondStr, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.DsSqlStr, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.ItemsString, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewFeatureFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewFeatureFlds.Memo, Type.GetType("System.String"));
foreach (clsViewFeatureFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewFeatureFlds.mId] = objInFor[conViewFeatureFlds.mId];
objDR[conViewFeatureFlds.ViewFeatureId] = objInFor[conViewFeatureFlds.ViewFeatureId];
objDR[conViewFeatureFlds.FieldTypeId] = objInFor[conViewFeatureFlds.FieldTypeId];
objDR[conViewFeatureFlds.ReleFldId] = objInFor[conViewFeatureFlds.ReleFldId];
objDR[conViewFeatureFlds.FuncName] = objInFor[conViewFeatureFlds.FuncName];
objDR[conViewFeatureFlds.LabelCaption] = objInFor[conViewFeatureFlds.LabelCaption];
objDR[conViewFeatureFlds.CtlTypeId] = objInFor[conViewFeatureFlds.CtlTypeId];
objDR[conViewFeatureFlds.VarId] = objInFor[conViewFeatureFlds.VarId];
objDR[conViewFeatureFlds.CtrlId] = objInFor[conViewFeatureFlds.CtrlId];
objDR[conViewFeatureFlds.DefaultValue] = objInFor[conViewFeatureFlds.DefaultValue];
objDR[conViewFeatureFlds.OrderNum] = objInFor[conViewFeatureFlds.OrderNum];
objDR[conViewFeatureFlds.CssClass] = objInFor[conViewFeatureFlds.CssClass];
objDR[conViewFeatureFlds.DdlItemsOptionId] = objInFor[conViewFeatureFlds.DdlItemsOptionId];
objDR[conViewFeatureFlds.DsTabId] = objInFor[conViewFeatureFlds.DsTabId];
objDR[conViewFeatureFlds.FldIdCond2] = objInFor[conViewFeatureFlds.FldIdCond2];
objDR[conViewFeatureFlds.FldIdCond1] = objInFor[conViewFeatureFlds.FldIdCond1];
objDR[conViewFeatureFlds.VarIdCond2] = objInFor[conViewFeatureFlds.VarIdCond2];
objDR[conViewFeatureFlds.VarIdCond1] = objInFor[conViewFeatureFlds.VarIdCond1];
objDR[conViewFeatureFlds.TabFeatureId4Ddl] = objInFor[conViewFeatureFlds.TabFeatureId4Ddl];
objDR[conViewFeatureFlds.ViewImplId] = objInFor[conViewFeatureFlds.ViewImplId];
objDR[conViewFeatureFlds.Text] = objInFor[conViewFeatureFlds.Text];
objDR[conViewFeatureFlds.DsCondStr] = objInFor[conViewFeatureFlds.DsCondStr];
objDR[conViewFeatureFlds.DsSqlStr] = objInFor[conViewFeatureFlds.DsSqlStr];
objDR[conViewFeatureFlds.ItemsString] = objInFor[conViewFeatureFlds.ItemsString];
objDR[conViewFeatureFlds.PrjId] = objInFor[conViewFeatureFlds.PrjId];
objDR[conViewFeatureFlds.UpdUser] = objInFor[conViewFeatureFlds.UpdUser];
objDR[conViewFeatureFlds.UpdDate] = objInFor[conViewFeatureFlds.UpdDate];
objDR[conViewFeatureFlds.InUse] = objInFor[conViewFeatureFlds.InUse];
objDR[conViewFeatureFlds.Memo] = objInFor[conViewFeatureFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面功能字段(ViewFeatureFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewFeatureFlds : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strViewFeatureId)
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
clsViewFeatureFldsWApi.ReFreshThisCache(strViewFeatureId);
}
}

}