
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureWApi
 表名:TabFeature(00050463)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsTabFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabFeatureId(this clsTabFeatureEN objTabFeatureEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, conTabFeature.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, conTabFeature.TabFeatureId);
objTabFeatureEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabFeatureId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabFeatureId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabFeatureId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabFeatureName(this clsTabFeatureEN objTabFeatureEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabFeatureName, conTabFeature.TabFeatureName);
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, conTabFeature.TabFeatureName);
objTabFeatureEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabFeatureName) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabFeatureName, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabFeatureName] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabId(this clsTabFeatureEN objTabFeatureEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabFeature.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conTabFeature.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabFeature.TabId);
objTabFeatureEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFeatureId(this clsTabFeatureEN objTabFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, conTabFeature.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conTabFeature.FeatureId);
objTabFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FeatureId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FeatureId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FeatureId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameCs">Cs函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFuncNameCs(this clsTabFeatureEN objTabFeatureEN, string strFuncNameCs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, conTabFeature.FuncNameCs);
objTabFeatureEN.FuncNameCs = strFuncNameCs; //Cs函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FuncNameCs) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FuncNameCs, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FuncNameCs] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExtendedClass">是否在扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsExtendedClass(this clsTabFeatureEN objTabFeatureEN, bool bolIsExtendedClass, string strComparisonOp="")
	{
objTabFeatureEN.IsExtendedClass = bolIsExtendedClass; //是否在扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsExtendedClass) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsExtendedClass, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsExtendedClass] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameJs">Js函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFuncNameJs(this clsTabFeatureEN objTabFeatureEN, string strFuncNameJs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, conTabFeature.FuncNameJs);
objTabFeatureEN.FuncNameJs = strFuncNameJs; //Js函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FuncNameJs) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FuncNameJs, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FuncNameJs] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strGetDdlDataFuncName4Ex">获取Ddl函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetGetDdlDataFuncName4Ex(this clsTabFeatureEN objTabFeatureEN, string strGetDdlDataFuncName4Ex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetDdlDataFuncName4Ex, 100, conTabFeature.GetDdlDataFuncName4Ex);
objTabFeatureEN.GetDdlDataFuncName4Ex = strGetDdlDataFuncName4Ex; //获取Ddl函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.GetDdlDataFuncName4Ex) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.GetDdlDataFuncName4Ex, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.GetDdlDataFuncName4Ex] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForCSharp">是否ForCSharp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForCSharp(this clsTabFeatureEN objTabFeatureEN, bool bolIsForCSharp, string strComparisonOp="")
	{
objTabFeatureEN.IsForCSharp = bolIsForCSharp; //是否ForCSharp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForCSharp) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForCSharp, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForCSharp] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForTypeScript">是否ForTypeScript</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForTypeScript(this clsTabFeatureEN objTabFeatureEN, bool bolIsForTypeScript, string strComparisonOp="")
	{
objTabFeatureEN.IsForTypeScript = bolIsForTypeScript; //是否ForTypeScript
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForTypeScript) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForTypeScript, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForTypeScript] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForDiv">是否针对Div内控件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForDiv(this clsTabFeatureEN objTabFeatureEN, bool bolIsForDiv, string strComparisonOp="")
	{
objTabFeatureEN.IsForDiv = bolIsForDiv; //是否针对Div内控件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForDiv) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForDiv, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForDiv] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGC">是否需要生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsNeedGC(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedGC, string strComparisonOp="")
	{
objTabFeatureEN.IsNeedGC = bolIsNeedGC; //是否需要生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsNeedGC) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsNeedGC, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsNeedGC] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intUseTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUseTimes(this clsTabFeatureEN objTabFeatureEN, int intUseTimes, string strComparisonOp="")
	{
objTabFeatureEN.UseTimes = intUseTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UseTimes) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UseTimes, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UseTimes] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetOrderNum(this clsTabFeatureEN objTabFeatureEN, int intOrderNum, string strComparisonOp="")
	{
objTabFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.OrderNum) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.OrderNum, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.OrderNum] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNullable">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsNullable(this clsTabFeatureEN objTabFeatureEN, bool bolIsNullable, string strComparisonOp="")
	{
objTabFeatureEN.IsNullable = bolIsNullable; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsNullable) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsNullable, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsNullable] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetInUse(this clsTabFeatureEN objTabFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objTabFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.InUse) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.InUse, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.InUse] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckDate">检查日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetCheckDate(this clsTabFeatureEN objTabFeatureEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conTabFeature.CheckDate);
objTabFeatureEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.CheckDate) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.CheckDate, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.CheckDate] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strToolTipText">提示文字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetToolTipText(this clsTabFeatureEN objTabFeatureEN, string strToolTipText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strToolTipText, 150, conTabFeature.ToolTipText);
objTabFeatureEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.ToolTipText) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.ToolTipText, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.ToolTipText] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetErrMsg(this clsTabFeatureEN objTabFeatureEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conTabFeature.ErrMsg);
objTabFeatureEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.ErrMsg) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.ErrMsg, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.ErrMsg] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetPrjId(this clsTabFeatureEN objTabFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabFeature.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFeature.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFeature.PrjId);
objTabFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.PrjId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.PrjId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.PrjId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUpdUser(this clsTabFeatureEN objTabFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conTabFeature.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabFeature.UpdUser);
objTabFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UpdUser) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UpdUser, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UpdUser] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUpdDate(this clsTabFeatureEN objTabFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabFeature.UpdDate);
objTabFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UpdDate) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UpdDate, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UpdDate] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetMemo(this clsTabFeatureEN objTabFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFeature.Memo);
objTabFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.Memo) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.Memo, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.Memo] = strComparisonOp;
}
}
return objTabFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFeatureEN objTabFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFeatureCond.IsUpdated(conTabFeature.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabFeatureId, objTabFeatureCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabFeatureName, objTabFeatureCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.TabId) == true)
{
string strComparisonOpTabId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabId, objTabFeatureCond.TabId, strComparisonOpTabId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FeatureId, objTabFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FuncNameCs) == true)
{
string strComparisonOpFuncNameCs = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FuncNameCs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FuncNameCs, objTabFeatureCond.FuncNameCs, strComparisonOpFuncNameCs);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsExtendedClass) == true)
{
if (objTabFeatureCond.IsExtendedClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsExtendedClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsExtendedClass);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FuncNameJs) == true)
{
string strComparisonOpFuncNameJs = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FuncNameJs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FuncNameJs, objTabFeatureCond.FuncNameJs, strComparisonOpFuncNameJs);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex) == true)
{
string strComparisonOpGetDdlDataFuncName4Ex = objTabFeatureCond.dicFldComparisonOp[conTabFeature.GetDdlDataFuncName4Ex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.GetDdlDataFuncName4Ex, objTabFeatureCond.GetDdlDataFuncName4Ex, strComparisonOpGetDdlDataFuncName4Ex);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForCSharp) == true)
{
if (objTabFeatureCond.IsForCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForCSharp);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForTypeScript) == true)
{
if (objTabFeatureCond.IsForTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForTypeScript);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForDiv) == true)
{
if (objTabFeatureCond.IsForDiv == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForDiv);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForDiv);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsNeedGC) == true)
{
if (objTabFeatureCond.IsNeedGC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsNeedGC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsNeedGC);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UseTimes) == true)
{
string strComparisonOpUseTimes = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UseTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeature.UseTimes, objTabFeatureCond.UseTimes, strComparisonOpUseTimes);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objTabFeatureCond.dicFldComparisonOp[conTabFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeature.OrderNum, objTabFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsNullable) == true)
{
if (objTabFeatureCond.IsNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsNullable);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.InUse) == true)
{
if (objTabFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.InUse);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.CheckDate) == true)
{
string strComparisonOpCheckDate = objTabFeatureCond.dicFldComparisonOp[conTabFeature.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.CheckDate, objTabFeatureCond.CheckDate, strComparisonOpCheckDate);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.ToolTipText) == true)
{
string strComparisonOpToolTipText = objTabFeatureCond.dicFldComparisonOp[conTabFeature.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.ToolTipText, objTabFeatureCond.ToolTipText, strComparisonOpToolTipText);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.ErrMsg) == true)
{
string strComparisonOpErrMsg = objTabFeatureCond.dicFldComparisonOp[conTabFeature.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.ErrMsg, objTabFeatureCond.ErrMsg, strComparisonOpErrMsg);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.PrjId) == true)
{
string strComparisonOpPrjId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.PrjId, objTabFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.UpdUser, objTabFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.UpdDate, objTabFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.Memo) == true)
{
string strComparisonOpMemo = objTabFeatureCond.dicFldComparisonOp[conTabFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.Memo, objTabFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFeatureEN objTabFeatureEN)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabFeatureEN.sfUpdFldSetStr = objTabFeatureEN.getsfUpdFldSetStr();
clsTabFeatureWApi.CheckPropertyNew(objTabFeatureEN); 
bool bolResult = clsTabFeatureWApi.UpdateRecord(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
 /// 获取唯一性条件串--TabFeature(表功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FeatureId_TabFeatureName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return "";
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
 return sbCondition.ToString();
}
}
 /// <summary>
 /// 获取唯一性条件串--TabFeature(表功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FeatureId_FuncName_Cs_FuncName_Js
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_V2(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return "";
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFeatureEN objTabFeatureEN)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabFeatureWApi.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabFeatureEN.TabFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTabFeatureWApi.CheckPropertyNew(objTabFeatureEN); 
bool bolResult = clsTabFeatureWApi.AddNewRecord(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTabFeatureEN objTabFeatureEN)
{
try
{
clsTabFeatureWApi.CheckPropertyNew(objTabFeatureEN); 
string strTabFeatureId = clsTabFeatureWApi.AddNewRecordWithMaxId(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
return strTabFeatureId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFeatureEN objTabFeatureEN, string strWhereCond)
{
try
{
clsTabFeatureWApi.CheckPropertyNew(objTabFeatureEN); 
bool bolResult = clsTabFeatureWApi.UpdateWithCondition(objTabFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
 /// 表功能(TabFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabFeatureWApi
{
private static readonly string mstrApiControllerName = "TabFeatureApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsTabFeatureWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabFeatureId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[表功能]...","0");
List<clsTabFeatureEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabFeatureId";
objDDL.DataTextField="TabFeatureName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strTabId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_TabFeatureId(System.Windows.Forms.ComboBox objComboBox , string strTabId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTabFeature.TabFeatureId); 
List<clsTabFeatureEN> arrObjLst = clsTabFeatureWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.TabId == strTabId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN()
{
TabFeatureId = "0",
TabFeatureName = "选[表功能]..."
};
arrObjLstSel.Insert(0, objTabFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTabFeature.TabFeatureId;
objComboBox.DisplayMember = conTabFeature.TabFeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabFeatureEN objTabFeatureEN)
{
if (!Object.Equals(null, objTabFeatureEN.TabFeatureId) && GetStrLen(objTabFeatureEN.TabFeatureId) > 8)
{
 throw new Exception("字段[表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFeatureEN.TabFeatureName) && GetStrLen(objTabFeatureEN.TabFeatureName) > 100)
{
 throw new Exception("字段[表功能名]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFeatureEN.TabId) && GetStrLen(objTabFeatureEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFeatureEN.FeatureId) && GetStrLen(objTabFeatureEN.FeatureId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabFeatureEN.FuncNameCs) && GetStrLen(objTabFeatureEN.FuncNameCs) > 100)
{
 throw new Exception("字段[Cs函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFeatureEN.FuncNameJs) && GetStrLen(objTabFeatureEN.FuncNameJs) > 100)
{
 throw new Exception("字段[Js函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFeatureEN.GetDdlDataFuncName4Ex) && GetStrLen(objTabFeatureEN.GetDdlDataFuncName4Ex) > 100)
{
 throw new Exception("字段[获取Ddl函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFeatureEN.CheckDate) && GetStrLen(objTabFeatureEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTabFeatureEN.ToolTipText) && GetStrLen(objTabFeatureEN.ToolTipText) > 150)
{
 throw new Exception("字段[提示文字]的长度不能超过150!");
}
if (!Object.Equals(null, objTabFeatureEN.ErrMsg) && GetStrLen(objTabFeatureEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objTabFeatureEN.PrjId) && GetStrLen(objTabFeatureEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabFeatureEN.UpdUser) && GetStrLen(objTabFeatureEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objTabFeatureEN.UpdDate) && GetStrLen(objTabFeatureEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTabFeatureEN.Memo) && GetStrLen(objTabFeatureEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTabFeatureEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId == "") return null;
string strAction = "GetObjByTabFeatureId";
clsTabFeatureEN objTabFeatureEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabFeatureId"] = strTabFeatureId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objTabFeatureEN = JsonConvert.DeserializeObject<clsTabFeatureEN>(strJson);
return objTabFeatureEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsTabFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabFeatureEN objTabFeatureEN;
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
objTabFeatureEN = JsonConvert.DeserializeObject<clsTabFeatureEN>(strJson);
return objTabFeatureEN;
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
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFeatureEN GetObjByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel =
from objTabFeatureEN in arrTabFeatureObjLstCache
where objTabFeatureEN.TabFeatureId == strTabFeatureId 
select objTabFeatureEN;
if (arrTabFeatureObjLst_Sel.Count() == 0)
{
   clsTabFeatureEN obj = clsTabFeatureWApi.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabFeatureNameByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//初始化列表缓存
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel1 =
from objTabFeatureEN in arrTabFeatureObjLstCache
where objTabFeatureEN.TabFeatureId == strTabFeatureId 
select objTabFeatureEN;
List <clsTabFeatureEN> arrTabFeatureObjLst_Sel = new List<clsTabFeatureEN>();
foreach (clsTabFeatureEN obj in arrTabFeatureObjLst_Sel1)
{
arrTabFeatureObjLst_Sel.Add(obj);
}
if (arrTabFeatureObjLst_Sel.Count > 0)
{
return arrTabFeatureObjLst_Sel[0].TabFeatureName;
}
string strErrMsgForGetObjById = string.Format("在TabFeature对象缓存列表中,找不到记录[TabFeatureId = {0}](函数:{1})", strTabFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTabFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//初始化列表缓存
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel1 =
from objTabFeatureEN in arrTabFeatureObjLstCache
where objTabFeatureEN.TabFeatureId == strTabFeatureId 
select objTabFeatureEN;
List <clsTabFeatureEN> arrTabFeatureObjLst_Sel = new List<clsTabFeatureEN>();
foreach (clsTabFeatureEN obj in arrTabFeatureObjLst_Sel1)
{
arrTabFeatureObjLst_Sel.Add(obj);
}
if (arrTabFeatureObjLst_Sel.Count > 0)
{
return arrTabFeatureObjLst_Sel[0].TabFeatureName;
}
string strErrMsgForGetObjById = string.Format("在TabFeature对象缓存列表中,找不到记录的相关名称[TabFeatureId = {0}](函数:{1})", strTabFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTabFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
 /// <param name = "arrTabFeatureId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureId)
{
 List<clsTabFeatureEN> arrObjLst; 
string strAction = "GetObjLstByTabFeatureIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabFeatureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
 /// <param name = "arrTabFeatureId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsTabFeatureEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel =
from objTabFeatureEN in arrTabFeatureObjLstCache
where arrTabFeatureId.Contains(objTabFeatureEN.TabFeatureId)
select objTabFeatureEN;
return arrTabFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
public static List<clsTabFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
public static List<clsTabFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
public static List<clsTabFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureEN>>(strJson);
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
public static int DelRecord(string strTabFeatureId)
{
string strAction = "DelRecord";
try
{
 clsTabFeatureEN objTabFeatureEN = clsTabFeatureWApi.GetObjByTabFeatureId(strTabFeatureId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTabFeatureId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
public static int DelTabFeatures(List<string> arrTabFeatureId)
{
string strAction = "DelTabFeatures";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabFeatureId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsTabFeatureEN objTabFeatureEN = clsTabFeatureWApi.GetObjByTabFeatureId(arrTabFeatureId[0]);
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
public static int DelTabFeaturesByCond(string strWhereCond)
{
string strAction = "DelTabFeaturesByCond";
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
public static bool AddNewRecord(clsTabFeatureEN objTabFeatureEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureEN>(objTabFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsTabFeatureEN objTabFeatureEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureEN>(objTabFeatureEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureWApi.ReFreshCache(objTabFeatureEN.PrjId);
var strTabFeatureId = (string)jobjReturn0["returnStr"];
return strTabFeatureId;
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
public static bool UpdateRecord(clsTabFeatureEN objTabFeatureEN)
{
if (string.IsNullOrEmpty(objTabFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureEN.TabFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureEN>(objTabFeatureEN);
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabFeatureEN objTabFeatureEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabFeatureEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureEN.TabFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureEN.TabFeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureEN>(objTabFeatureEN);
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
public static bool IsExist(string strTabFeatureId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabFeatureId"] = strTabFeatureId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabFeatureENS">源对象</param>
 /// <param name = "objTabFeatureENT">目标对象</param>
 public static void CopyTo(clsTabFeatureEN objTabFeatureENS, clsTabFeatureEN objTabFeatureENT)
{
try
{
objTabFeatureENT.TabFeatureId = objTabFeatureENS.TabFeatureId; //表功能Id
objTabFeatureENT.TabFeatureName = objTabFeatureENS.TabFeatureName; //表功能名
objTabFeatureENT.TabId = objTabFeatureENS.TabId; //表ID
objTabFeatureENT.FeatureId = objTabFeatureENS.FeatureId; //功能Id
objTabFeatureENT.FuncNameCs = objTabFeatureENS.FuncNameCs; //Cs函数名
objTabFeatureENT.IsExtendedClass = objTabFeatureENS.IsExtendedClass; //是否在扩展类
objTabFeatureENT.FuncNameJs = objTabFeatureENS.FuncNameJs; //Js函数名
objTabFeatureENT.GetDdlDataFuncName4Ex = objTabFeatureENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objTabFeatureENT.IsForCSharp = objTabFeatureENS.IsForCSharp; //是否ForCSharp
objTabFeatureENT.IsForTypeScript = objTabFeatureENS.IsForTypeScript; //是否ForTypeScript
objTabFeatureENT.IsForDiv = objTabFeatureENS.IsForDiv; //是否针对Div内控件
objTabFeatureENT.IsNeedGC = objTabFeatureENS.IsNeedGC; //是否需要生成代码
objTabFeatureENT.UseTimes = objTabFeatureENS.UseTimes; //使用次数
objTabFeatureENT.OrderNum = objTabFeatureENS.OrderNum; //序号
objTabFeatureENT.IsNullable = objTabFeatureENS.IsNullable; //是否可空
objTabFeatureENT.InUse = objTabFeatureENS.InUse; //是否在用
objTabFeatureENT.CheckDate = objTabFeatureENS.CheckDate; //检查日期
objTabFeatureENT.ToolTipText = objTabFeatureENS.ToolTipText; //提示文字
objTabFeatureENT.ErrMsg = objTabFeatureENS.ErrMsg; //错误信息
objTabFeatureENT.PrjId = objTabFeatureENS.PrjId; //工程Id
objTabFeatureENT.UpdUser = objTabFeatureENS.UpdUser; //修改者
objTabFeatureENT.UpdDate = objTabFeatureENS.UpdDate; //修改日期
objTabFeatureENT.Memo = objTabFeatureENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTabFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabFeatureEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
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
if (clsTabFeatureWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFeatureWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsTabFeatureEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsTabFeatureEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conTabFeature.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsTabFeatureEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrTabFeatureObjLstCache = CacheHelper.Get<List<clsTabFeatureEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrTabFeatureObjLstCache = CacheHelper.Get<List<clsTabFeatureEN>>(strKey);
}
return arrTabFeatureObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabFeature.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.FuncNameCs, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.IsExtendedClass, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.FuncNameJs, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.GetDdlDataFuncName4Ex, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.IsForCSharp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.IsForTypeScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.IsForDiv, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.IsNeedGC, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.UseTimes, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFeature.IsNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeature.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.ToolTipText, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeature.Memo, Type.GetType("System.String"));
foreach (clsTabFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabFeature.TabFeatureId] = objInFor[conTabFeature.TabFeatureId];
objDR[conTabFeature.TabFeatureName] = objInFor[conTabFeature.TabFeatureName];
objDR[conTabFeature.TabId] = objInFor[conTabFeature.TabId];
objDR[conTabFeature.FeatureId] = objInFor[conTabFeature.FeatureId];
objDR[conTabFeature.FuncNameCs] = objInFor[conTabFeature.FuncNameCs];
objDR[conTabFeature.IsExtendedClass] = objInFor[conTabFeature.IsExtendedClass];
objDR[conTabFeature.FuncNameJs] = objInFor[conTabFeature.FuncNameJs];
objDR[conTabFeature.GetDdlDataFuncName4Ex] = objInFor[conTabFeature.GetDdlDataFuncName4Ex];
objDR[conTabFeature.IsForCSharp] = objInFor[conTabFeature.IsForCSharp];
objDR[conTabFeature.IsForTypeScript] = objInFor[conTabFeature.IsForTypeScript];
objDR[conTabFeature.IsForDiv] = objInFor[conTabFeature.IsForDiv];
objDR[conTabFeature.IsNeedGC] = objInFor[conTabFeature.IsNeedGC];
objDR[conTabFeature.UseTimes] = objInFor[conTabFeature.UseTimes];
objDR[conTabFeature.OrderNum] = objInFor[conTabFeature.OrderNum];
objDR[conTabFeature.IsNullable] = objInFor[conTabFeature.IsNullable];
objDR[conTabFeature.InUse] = objInFor[conTabFeature.InUse];
objDR[conTabFeature.CheckDate] = objInFor[conTabFeature.CheckDate];
objDR[conTabFeature.ToolTipText] = objInFor[conTabFeature.ToolTipText];
objDR[conTabFeature.ErrMsg] = objInFor[conTabFeature.ErrMsg];
objDR[conTabFeature.PrjId] = objInFor[conTabFeature.PrjId];
objDR[conTabFeature.UpdUser] = objInFor[conTabFeature.UpdUser];
objDR[conTabFeature.UpdDate] = objInFor[conTabFeature.UpdDate];
objDR[conTabFeature.Memo] = objInFor[conTabFeature.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表功能(TabFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabFeature : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsTabFeatureWApi.ReFreshThisCache(strPrjId);
}
}

}